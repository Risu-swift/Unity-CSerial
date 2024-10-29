using System;
using System.Text;
using System.Threading;
using itas109;
using UnityEngine;

public class SerialPortHandler
{
    private CSerialPort serialPort;
    public SerialListener listener;
    private SerialPortInfoVector serialPortInfo;
    public bool isConnected = false;
    private Thread updateThread;
    private bool isRunning = true;
    private string portName;
    private int baudRate;
    
    public event Action<bool> OnConnectionStatusChanged; // New event for connection status

    public SerialPortHandler(string portName, int baudRate)
    {
        this.portName = portName;
        this.baudRate = baudRate;
        
        serialPort = new CSerialPort();
        listener = new SerialListener(serialPort);

        serialPort.init(portName, baudRate, Parity.ParityNone, DataBits.DataBits8, StopBits.StopOne,
            FlowControl.FlowNone, 4096);
        serialPort.setReadIntervalTimeout(0);
    }

    public void Connect()
    {
        if (!isConnected)
        {
            isConnected = serialPort.open();
            serialPort.flushBuffers();
            serialPort.connectReadEvent(listener);
            OnConnectionStatusChanged?.Invoke(isConnected); // Notify connection status
            isRunning = true;
            updateThread = new Thread(RunUpdateLoop);
            updateThread.Start();
        }
    }

    private void Disconnect()
    {
        if (isConnected)
        {
            isRunning = false;
            if (updateThread is { IsAlive: true })
            {
                updateThread.Join(); // Wait for the thread to finish
            }

            serialPort.flushBuffers();
            serialPort.close();
            serialPort = null;
            isConnected = false;
            OnConnectionStatusChanged?.Invoke(isConnected); // Notify disconnection status
        }
    }

    private void RunUpdateLoop()
    {
        while (isRunning)
        {
            serialPortInfo = CSerialPortInfo.availablePortInfos();

            if (serialPortInfo.Count == 0 && isConnected)
            {
                serialPort.flushBuffers();
                isConnected = false;
                serialPort.close();
                OnConnectionStatusChanged?.Invoke(isConnected); // Notify disconnection status
            }

            if (serialPortInfo.Count >= 1 && !isConnected)
            {
                isConnected = serialPort.open();
                OnConnectionStatusChanged?.Invoke(isConnected); // Notify connection status
            }

            Thread.Sleep(100); // Adjust sleep duration as needed
        }
    }

    public void Write<T>(T data)
    {
        if (isConnected)
        {
            byte[] bytes;

            if (data is string strData)
            {
                bytes = Encoding.ASCII.GetBytes(strData);
            }
            else if (data is byte byteData)
            {
                bytes = new []{ byteData };
            }
            else
            {
                throw new ArgumentException("Unsupported data type");
            }

            serialPort.writeData(bytes, bytes.Length);
        }
        else
        {
            Debug.LogWarning("Serial port is not connected.");
        }
    }

    public void Stop()
    {
        Disconnect();
    }
}