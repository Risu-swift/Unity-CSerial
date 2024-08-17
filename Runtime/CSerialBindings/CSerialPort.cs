//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace itas109 {

public class CSerialPort : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CSerialPort(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CSerialPort obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CSerialPort obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~CSerialPort() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cserialportCSharpPINVOKE.delete_CSerialPort(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CSerialPort() : this(cserialportCSharpPINVOKE.new_CSerialPort__SWIG_0(), true) {
  }

  public CSerialPort(string portName) : this(cserialportCSharpPINVOKE.new_CSerialPort__SWIG_1(portName), true) {
  }

  public void init(string portName, int baudRate, Parity parity, DataBits dataBits, StopBits stopbits, FlowControl flowControl, uint readBufferSize) {
    cserialportCSharpPINVOKE.CSerialPort_init__SWIG_0(swigCPtr, portName, baudRate, (int)parity, (int)dataBits, (int)stopbits, (int)flowControl, readBufferSize);
  }

  public void init(string portName, int baudRate, Parity parity, DataBits dataBits, StopBits stopbits, FlowControl flowControl) {
    cserialportCSharpPINVOKE.CSerialPort_init__SWIG_1(swigCPtr, portName, baudRate, (int)parity, (int)dataBits, (int)stopbits, (int)flowControl);
  }

  public void init(string portName, int baudRate, Parity parity, DataBits dataBits, StopBits stopbits) {
    cserialportCSharpPINVOKE.CSerialPort_init__SWIG_2(swigCPtr, portName, baudRate, (int)parity, (int)dataBits, (int)stopbits);
  }

  public void init(string portName, int baudRate, Parity parity, DataBits dataBits) {
    cserialportCSharpPINVOKE.CSerialPort_init__SWIG_3(swigCPtr, portName, baudRate, (int)parity, (int)dataBits);
  }

  public void init(string portName, int baudRate, Parity parity) {
    cserialportCSharpPINVOKE.CSerialPort_init__SWIG_4(swigCPtr, portName, baudRate, (int)parity);
  }

  public void init(string portName, int baudRate) {
    cserialportCSharpPINVOKE.CSerialPort_init__SWIG_5(swigCPtr, portName, baudRate);
  }

  public void init(string portName) {
    cserialportCSharpPINVOKE.CSerialPort_init__SWIG_6(swigCPtr, portName);
  }

  public void setOperateMode(OperateMode operateMode) {
    cserialportCSharpPINVOKE.CSerialPort_setOperateMode__SWIG_0(swigCPtr, (int)operateMode);
  }

  public void setOperateMode() {
    cserialportCSharpPINVOKE.CSerialPort_setOperateMode__SWIG_1(swigCPtr);
  }

  public bool open() {
    bool ret = cserialportCSharpPINVOKE.CSerialPort_open(swigCPtr);
    return ret;
  }

  public void close() {
    cserialportCSharpPINVOKE.CSerialPort_close(swigCPtr);
  }

  public bool isOpen() {
    bool ret = cserialportCSharpPINVOKE.CSerialPort_isOpen(swigCPtr);
    return ret;
  }

  public int connectReadEvent(CSerialPortListener event_) {
    int ret = cserialportCSharpPINVOKE.CSerialPort_connectReadEvent(swigCPtr, CSerialPortListener.getCPtr(event_));
    return ret;
  }

  public int disconnectReadEvent() {
    int ret = cserialportCSharpPINVOKE.CSerialPort_disconnectReadEvent(swigCPtr);
    return ret;
  }

  public uint getReadBufferUsedLen() {
    uint ret = cserialportCSharpPINVOKE.CSerialPort_getReadBufferUsedLen(swigCPtr);
    return ret;
  }

  public int readData(byte[] data, int size) {
    int ret = cserialportCSharpPINVOKE.CSerialPort_readData(swigCPtr, data, size);
    return ret;
  }

  public int readAllData(byte[] data) {
    int ret = cserialportCSharpPINVOKE.CSerialPort_readAllData(swigCPtr, data);
    return ret;
  }

  public int readLineData(byte[] data, int size) {
    int ret = cserialportCSharpPINVOKE.CSerialPort_readLineData(swigCPtr, data, size);
    return ret;
  }

  public int writeData(byte[] data, int size) {
    int ret = cserialportCSharpPINVOKE.CSerialPort_writeData(swigCPtr, data, size);
    return ret;
  }

  public void setDebugModel(bool isDebug) {
    cserialportCSharpPINVOKE.CSerialPort_setDebugModel(swigCPtr, isDebug);
  }

  public void setReadIntervalTimeout(uint msecs) {
    cserialportCSharpPINVOKE.CSerialPort_setReadIntervalTimeout(swigCPtr, msecs);
  }

  public uint getReadIntervalTimeout() {
    uint ret = cserialportCSharpPINVOKE.CSerialPort_getReadIntervalTimeout(swigCPtr);
    return ret;
  }

  public void setMinByteReadNotify(uint minByteReadNotify) {
    cserialportCSharpPINVOKE.CSerialPort_setMinByteReadNotify__SWIG_0(swigCPtr, minByteReadNotify);
  }

  public void setMinByteReadNotify() {
    cserialportCSharpPINVOKE.CSerialPort_setMinByteReadNotify__SWIG_1(swigCPtr);
  }

  public void setByteReadBufferFullNotify(uint byteReadBufferFullNotify) {
    cserialportCSharpPINVOKE.CSerialPort_setByteReadBufferFullNotify(swigCPtr, byteReadBufferFullNotify);
  }

  public bool flushBuffers() {
    bool ret = cserialportCSharpPINVOKE.CSerialPort_flushBuffers(swigCPtr);
    return ret;
  }

  public bool flushReadBuffers() {
    bool ret = cserialportCSharpPINVOKE.CSerialPort_flushReadBuffers(swigCPtr);
    return ret;
  }

  public bool flushWriteBuffers() {
    bool ret = cserialportCSharpPINVOKE.CSerialPort_flushWriteBuffers(swigCPtr);
    return ret;
  }

  public int getLastError() {
    int ret = cserialportCSharpPINVOKE.CSerialPort_getLastError(swigCPtr);
    return ret;
  }

  public string getLastErrorMsg() {
    string ret = cserialportCSharpPINVOKE.CSerialPort_getLastErrorMsg(swigCPtr);
    return ret;
  }

  public void clearError() {
    cserialportCSharpPINVOKE.CSerialPort_clearError(swigCPtr);
  }

  public void setPortName(string portName) {
    cserialportCSharpPINVOKE.CSerialPort_setPortName(swigCPtr, portName);
  }

  public string getPortName() {
    string ret = cserialportCSharpPINVOKE.CSerialPort_getPortName(swigCPtr);
    return ret;
  }

  public void setBaudRate(int baudRate) {
    cserialportCSharpPINVOKE.CSerialPort_setBaudRate(swigCPtr, baudRate);
  }

  public int getBaudRate() {
    int ret = cserialportCSharpPINVOKE.CSerialPort_getBaudRate(swigCPtr);
    return ret;
  }

  public void setParity(Parity parity) {
    cserialportCSharpPINVOKE.CSerialPort_setParity(swigCPtr, (int)parity);
  }

  public Parity getParity() {
    Parity ret = (Parity)cserialportCSharpPINVOKE.CSerialPort_getParity(swigCPtr);
    return ret;
  }

  public void setDataBits(DataBits dataBits) {
    cserialportCSharpPINVOKE.CSerialPort_setDataBits(swigCPtr, (int)dataBits);
  }

  public DataBits getDataBits() {
    DataBits ret = (DataBits)cserialportCSharpPINVOKE.CSerialPort_getDataBits(swigCPtr);
    return ret;
  }

  public void setStopBits(StopBits stopbits) {
    cserialportCSharpPINVOKE.CSerialPort_setStopBits(swigCPtr, (int)stopbits);
  }

  public StopBits getStopBits() {
    StopBits ret = (StopBits)cserialportCSharpPINVOKE.CSerialPort_getStopBits(swigCPtr);
    return ret;
  }

  public void setFlowControl(FlowControl flowControl) {
    cserialportCSharpPINVOKE.CSerialPort_setFlowControl(swigCPtr, (int)flowControl);
  }

  public FlowControl getFlowControl() {
    FlowControl ret = (FlowControl)cserialportCSharpPINVOKE.CSerialPort_getFlowControl(swigCPtr);
    return ret;
  }

  public void setReadBufferSize(uint size) {
    cserialportCSharpPINVOKE.CSerialPort_setReadBufferSize(swigCPtr, size);
  }

  public uint getReadBufferSize() {
    uint ret = cserialportCSharpPINVOKE.CSerialPort_getReadBufferSize(swigCPtr);
    return ret;
  }

  public void setDtr(bool set) {
    cserialportCSharpPINVOKE.CSerialPort_setDtr__SWIG_0(swigCPtr, set);
  }

  public void setDtr() {
    cserialportCSharpPINVOKE.CSerialPort_setDtr__SWIG_1(swigCPtr);
  }

  public void setRts(bool set) {
    cserialportCSharpPINVOKE.CSerialPort_setRts__SWIG_0(swigCPtr, set);
  }

  public void setRts() {
    cserialportCSharpPINVOKE.CSerialPort_setRts__SWIG_1(swigCPtr);
  }

  public string getVersion() {
    string ret = cserialportCSharpPINVOKE.CSerialPort_getVersion(swigCPtr);
    return ret;
  }

}

}
