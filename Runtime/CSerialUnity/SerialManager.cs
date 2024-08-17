using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[RequireComponent(typeof(MainThreadDispatcher))]
public class SerialManager : MonoBehaviour
{
    [HideInInspector, SerializeField]
    private string _portName = "COM3";
    [HideInInspector, SerializeField]
    private int _baudRate = 9600;
    private SerialPortHandler serialPortHandler;

    [HideInInspector]
    public UnityEvent<string> onDataReceived;
    [HideInInspector]
    public UnityEvent<bool> onConnectionStatusChanged; // New event for connection status

    private bool _executeInEditMode = false;

    void Awake()
    {
        if (onDataReceived == null)
        {
            onDataReceived = new UnityEvent<string>();
        }

        if (onConnectionStatusChanged == null)
        {
            onConnectionStatusChanged = new UnityEvent<bool>();
        }

        if (!Application.isPlaying && _executeInEditMode)
        {
            InitializeSerialPortHandler();
        }
    }

    void Start()
    {
        if (Application.isPlaying)
        {
            InitializeSerialPortHandler();
        }
    }

    public void InitializeSerialPortHandler()
    {
        serialPortHandler = new SerialPortHandler(_portName, _baudRate);
       // serialPortHandler.listener.OnDataReceived += HandleDataReceived;
       // serialPortHandler.OnConnectionStatusChanged += HandleConnectionStatusChanged; // Subscribe to connection status changes
        serialPortHandler.Connect();
    }

    /*void HandleDataReceived(string data)
    {
        Debug.Log("Received data: " + data);
        onDataReceived.Invoke(data);
    }

    void HandleConnectionStatusChanged(bool isConnected)
    {
        Debug.Log("Connection status changed: " + isConnected);
        onConnectionStatusChanged.Invoke(isConnected);
    }*/

    void OnDestroy()
    {
        Disconnect();
    }

    public void Disconnect()
    {
        serialPortHandler?.Stop();
       // serialPortHandler.listener.OnDataReceived -= HandleDataReceived;
      //  serialPortHandler.OnConnectionStatusChanged -= HandleConnectionStatusChanged; // Unsubscribe from connection status changes
    }

    void ReconnectSerialPort()
    {
        serialPortHandler?.Stop();
      //  serialPortHandler.listener.OnDataReceived -= HandleDataReceived;
       // serialPortHandler.OnConnectionStatusChanged -= HandleConnectionStatusChanged; // Unsubscribe from connection status changes
        InitializeSerialPortHandler();
    }

    public void SetPortName(string portName)
    {
        if (_portName != portName)
        {
            _portName = portName;
            if (Application.isPlaying)
            {
                ReconnectSerialPort();
            }
        }
    }

    public void SetBaudRate(int baudRate)
    {
        if (_baudRate != baudRate)
        {
            _baudRate = baudRate;
            if (Application.isPlaying)
            {
                ReconnectSerialPort();
            }
        }
    }

    public string GetPortName()
    {
        return _portName;
    }

    public int GetBaudRate()
    {
        return _baudRate;
    }

    void OnValidate()
    {
        if (!Application.isPlaying && _executeInEditMode)
        {
            InitializeSerialPortHandler();
        }
    }
}