// Update SerialListener.cs

using System;
using System.Text;
using itas109;
using UnityEngine;
using UnityEngine.Events;

public class SerialListener : CSerialPortListener
{
    private string _buffer = ""; // Accumulate incomplete lines here
    private readonly CSerialPort _mSp;
    public event Action<string> OnDataReceived = delegate { };

    public SerialListener(CSerialPort sp)
    {
        _mSp = sp;
    }

    public override void onReadEvent(string portName, uint readBufferLen)
    {
        if (readBufferLen > 0)
        {
            int lengthToRead = (int)Math.Min(readBufferLen, int.MaxValue);

            byte[] data = new byte[lengthToRead];
            int recLen = _mSp.readData(data, lengthToRead);

            if (recLen > 0)
            {
                string str = Encoding.ASCII.GetString(data, 0, recLen);
                _buffer += str;

                int newLineIndex;
                while ((newLineIndex = _buffer.IndexOf('\n')) != -1)
                {
                    string line = _buffer.Substring(0, newLineIndex).Trim();
                    _buffer = _buffer.Substring(newLineIndex + 1);

                    if (!ApplicationState.IsPlaying)
                    {
                        OnDataReceived.Invoke(line);
                    }
                    
                    MainThreadDispatcher.Enqueue(() => OnDataReceived.Invoke(line));
                    break;
                }
            }
        }
    }
}