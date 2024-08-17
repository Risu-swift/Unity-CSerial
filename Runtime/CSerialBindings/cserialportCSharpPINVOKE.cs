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

class cserialportCSharpPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="SWIGRegisterExceptionCallbacks_cserialportCSharp")]
    public static extern void SWIGRegisterExceptionCallbacks_cserialportCSharp(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_cserialportCSharp")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_cserialportCSharp(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_cserialportCSharp(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_cserialportCSharp(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;
    private static global::System.Object exceptionsLock = null;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(exceptionsLock) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(exceptionsLock) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }

    static SWIGPendingException() {
      exceptionsLock = new global::System.Object();
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="SWIGRegisterStringCallback_cserialportCSharp")]
    public static extern void SWIGRegisterStringCallback_cserialportCSharp(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_cserialportCSharp(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static cserialportCSharpPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_new_SerialPortInfoVector__SWIG_0")]
  public static extern global::System.IntPtr new_SerialPortInfoVector__SWIG_0();

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_new_SerialPortInfoVector__SWIG_1")]
  public static extern global::System.IntPtr new_SerialPortInfoVector__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_Clear")]
  public static extern void SerialPortInfoVector_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_Add")]
  public static extern void SerialPortInfoVector_Add(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_size")]
  public static extern uint SerialPortInfoVector_size(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_empty")]
  public static extern bool SerialPortInfoVector_empty(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_capacity")]
  public static extern uint SerialPortInfoVector_capacity(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_reserve")]
  public static extern void SerialPortInfoVector_reserve(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_new_SerialPortInfoVector__SWIG_2")]
  public static extern global::System.IntPtr new_SerialPortInfoVector__SWIG_2(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_getitemcopy")]
  public static extern global::System.IntPtr SerialPortInfoVector_getitemcopy(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_getitem")]
  public static extern global::System.IntPtr SerialPortInfoVector_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_setitem")]
  public static extern void SerialPortInfoVector_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_AddRange")]
  public static extern void SerialPortInfoVector_AddRange(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_GetRange")]
  public static extern global::System.IntPtr SerialPortInfoVector_GetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_Insert")]
  public static extern void SerialPortInfoVector_Insert(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_InsertRange")]
  public static extern void SerialPortInfoVector_InsertRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_RemoveAt")]
  public static extern void SerialPortInfoVector_RemoveAt(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_RemoveRange")]
  public static extern void SerialPortInfoVector_RemoveRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_Repeat")]
  public static extern global::System.IntPtr SerialPortInfoVector_Repeat(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_Reverse__SWIG_0")]
  public static extern void SerialPortInfoVector_Reverse__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_Reverse__SWIG_1")]
  public static extern void SerialPortInfoVector_Reverse__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfoVector_SetRange")]
  public static extern void SerialPortInfoVector_SetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_delete_SerialPortInfoVector")]
  public static extern void delete_SerialPortInfoVector(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfo_portName_set")]
  public static extern void SerialPortInfo_portName_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfo_portName_get")]
  public static extern string SerialPortInfo_portName_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfo_description_set")]
  public static extern void SerialPortInfo_description_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfo_description_get")]
  public static extern string SerialPortInfo_description_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfo_hardwareId_set")]
  public static extern void SerialPortInfo_hardwareId_set(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_SerialPortInfo_hardwareId_get")]
  public static extern string SerialPortInfo_hardwareId_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_new_SerialPortInfo")]
  public static extern global::System.IntPtr new_SerialPortInfo();

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_delete_SerialPortInfo")]
  public static extern void delete_SerialPortInfo(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_new_CSerialPort__SWIG_0")]
  public static extern global::System.IntPtr new_CSerialPort__SWIG_0();

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_new_CSerialPort__SWIG_1")]
  public static extern global::System.IntPtr new_CSerialPort__SWIG_1(string jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_delete_CSerialPort")]
  public static extern void delete_CSerialPort(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_init__SWIG_0")]
  public static extern void CSerialPort_init__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, uint jarg8);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_init__SWIG_1")]
  public static extern void CSerialPort_init__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_init__SWIG_2")]
  public static extern void CSerialPort_init__SWIG_2(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3, int jarg4, int jarg5, int jarg6);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_init__SWIG_3")]
  public static extern void CSerialPort_init__SWIG_3(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3, int jarg4, int jarg5);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_init__SWIG_4")]
  public static extern void CSerialPort_init__SWIG_4(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3, int jarg4);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_init__SWIG_5")]
  public static extern void CSerialPort_init__SWIG_5(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_init__SWIG_6")]
  public static extern void CSerialPort_init__SWIG_6(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setOperateMode__SWIG_0")]
  public static extern void CSerialPort_setOperateMode__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setOperateMode__SWIG_1")]
  public static extern void CSerialPort_setOperateMode__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_open")]
  public static extern bool CSerialPort_open(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_close")]
  public static extern void CSerialPort_close(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_isOpen")]
  public static extern bool CSerialPort_isOpen(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_connectReadEvent")]
  public static extern int CSerialPort_connectReadEvent(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_disconnectReadEvent")]
  public static extern int CSerialPort_disconnectReadEvent(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getReadBufferUsedLen")]
  public static extern uint CSerialPort_getReadBufferUsedLen(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_readData")]
  public static extern int CSerialPort_readData(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.In, global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPArray)]byte[] jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_readAllData")]
  public static extern int CSerialPort_readAllData(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.In, global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPArray)]byte[] jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_readLineData")]
  public static extern int CSerialPort_readLineData(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.In, global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPArray)]byte[] jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_writeData")]
  public static extern int CSerialPort_writeData(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.In, global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPArray)]byte[] jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setDebugModel")]
  public static extern void CSerialPort_setDebugModel(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setReadIntervalTimeout")]
  public static extern void CSerialPort_setReadIntervalTimeout(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getReadIntervalTimeout")]
  public static extern uint CSerialPort_getReadIntervalTimeout(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setMinByteReadNotify__SWIG_0")]
  public static extern void CSerialPort_setMinByteReadNotify__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setMinByteReadNotify__SWIG_1")]
  public static extern void CSerialPort_setMinByteReadNotify__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setByteReadBufferFullNotify")]
  public static extern void CSerialPort_setByteReadBufferFullNotify(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_flushBuffers")]
  public static extern bool CSerialPort_flushBuffers(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_flushReadBuffers")]
  public static extern bool CSerialPort_flushReadBuffers(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_flushWriteBuffers")]
  public static extern bool CSerialPort_flushWriteBuffers(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getLastError")]
  public static extern int CSerialPort_getLastError(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getLastErrorMsg")]
  public static extern string CSerialPort_getLastErrorMsg(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_clearError")]
  public static extern void CSerialPort_clearError(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setPortName")]
  public static extern void CSerialPort_setPortName(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getPortName")]
  public static extern string CSerialPort_getPortName(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setBaudRate")]
  public static extern void CSerialPort_setBaudRate(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getBaudRate")]
  public static extern int CSerialPort_getBaudRate(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setParity")]
  public static extern void CSerialPort_setParity(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getParity")]
  public static extern int CSerialPort_getParity(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setDataBits")]
  public static extern void CSerialPort_setDataBits(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getDataBits")]
  public static extern int CSerialPort_getDataBits(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setStopBits")]
  public static extern void CSerialPort_setStopBits(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getStopBits")]
  public static extern int CSerialPort_getStopBits(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setFlowControl")]
  public static extern void CSerialPort_setFlowControl(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getFlowControl")]
  public static extern int CSerialPort_getFlowControl(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setReadBufferSize")]
  public static extern void CSerialPort_setReadBufferSize(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getReadBufferSize")]
  public static extern uint CSerialPort_getReadBufferSize(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setDtr__SWIG_0")]
  public static extern void CSerialPort_setDtr__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setDtr__SWIG_1")]
  public static extern void CSerialPort_setDtr__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setRts__SWIG_0")]
  public static extern void CSerialPort_setRts__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_setRts__SWIG_1")]
  public static extern void CSerialPort_setRts__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPort_getVersion")]
  public static extern string CSerialPort_getVersion(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_delete_CSerialPortListener")]
  public static extern void delete_CSerialPortListener(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPortListener_onReadEvent")]
  public static extern void CSerialPortListener_onReadEvent(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, uint jarg3);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_new_CSerialPortListener")]
  public static extern global::System.IntPtr new_CSerialPortListener();

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPortListener_director_connect")]
  public static extern void CSerialPortListener_director_connect(global::System.Runtime.InteropServices.HandleRef jarg1, CSerialPortListener.SwigDelegateCSerialPortListener_0 delegate0);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_new_CSerialPortInfo")]
  public static extern global::System.IntPtr new_CSerialPortInfo();

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_delete_CSerialPortInfo")]
  public static extern void delete_CSerialPortInfo(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("libcserialport", EntryPoint="CSharp_itas109_CSerialPortInfo_availablePortInfos")]
  public static extern global::System.IntPtr CSerialPortInfo_availablePortInfos();
}

}
