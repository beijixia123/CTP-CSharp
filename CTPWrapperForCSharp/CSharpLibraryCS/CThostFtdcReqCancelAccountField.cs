//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqCancelAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqCancelAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqCancelAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqCancelAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcReqCancelAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char Gender {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Gender_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Gender_get(swigCPtr);
      return ret;
    } 
  }

  public string CountryCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CountryCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CountryCode_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string MobilePhone {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_MobilePhone_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_MobilePhone_get(swigCPtr);
      return ret;
    } 
  }

  public string Fax {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Fax_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Fax_get(swigCPtr);
      return ret;
    } 
  }

  public string EMail {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_EMail_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_EMail_get(swigCPtr);
      return ret;
    } 
  }

  public char MoneyAccountStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_MoneyAccountStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_MoneyAccountStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public char CashExchangeCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CashExchangeCode_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_CashExchangeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public char BankSecuAccType {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankSecuAccType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankSecuAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSecuAcc {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankSecuAcc_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankSecuAcc_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string LongCustomerName {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_LongCustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqCancelAccountField_LongCustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqCancelAccountField() : this(thosttradeapiPINVOKE.new_CThostFtdcReqCancelAccountField(), true) {
  }

}
