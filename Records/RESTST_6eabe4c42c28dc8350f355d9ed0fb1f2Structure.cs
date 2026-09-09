using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LinesReport62
public class RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure : AbstractRESTStructure<ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure> {
[JsonProperty("InvoiceNumber")]
public string AttrInvoiceNumber;

[JsonProperty("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("AccountingDate")]
public string AttrAccountingDate;

[JsonProperty("AccountingUser")]
public string AttrAccountingUser;

[JsonProperty("EmployedNumber")]
public string AttrEmployedNumber;

[JsonProperty("DocNumber")]
public string AttrDocNumber;

[JsonProperty("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("Region")]
public string AttrRegion;

[JsonProperty("Department")]
public string AttrDepartment;

[JsonProperty("Management")]
public string AttrManagement;

[JsonProperty("Direction")]
public string AttrDirection;

[JsonProperty("InvoiceCreationDate")]
public string AttrInvoiceCreationDate;

[JsonProperty("Currency")]
public string AttrCurrency;

[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("PaymentDate")]
public string AttrPaymentDate;

[JsonProperty("ExchangeType")]
public string AttrExchangeType;

public RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure() { }

public RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure (ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceNumber = ConvertToRestWithoutDefaults(s.ssInvoiceNumber, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrAccountingDate = ConvertToRestWithoutDefaults(s.ssAccountingDate, "");
AttrAccountingUser = ConvertToRestWithoutDefaults(s.ssAccountingUser, "");
AttrEmployedNumber = ConvertToRestWithoutDefaults(s.ssEmployedNumber, "");
AttrDocNumber = ConvertToRestWithoutDefaults(s.ssDocNumber, "");
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrDepartment = ConvertToRestWithoutDefaults(s.ssDepartment, "");
AttrManagement = ConvertToRestWithoutDefaults(s.ssManagement, "");
AttrDirection = ConvertToRestWithoutDefaults(s.ssDirection, "");
AttrInvoiceCreationDate = ConvertToRestWithoutDefaults(s.ssInvoiceCreationDate, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrPaymentDate = ConvertToRestWithoutDefaults(s.ssPaymentDate, "");
AttrExchangeType = ConvertToRestWithoutDefaults(s.ssExchangeType, "");
  } else {
AttrInvoiceNumber = s.ssInvoiceNumber;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrAccountingDate = s.ssAccountingDate;
AttrAccountingUser = s.ssAccountingUser;
AttrEmployedNumber = s.ssEmployedNumber;
AttrDocNumber = s.ssDocNumber;
AttrSupplierNumber = s.ssSupplierNumber;
AttrRegion = s.ssRegion;
AttrDepartment = s.ssDepartment;
AttrManagement = s.ssManagement;
AttrDirection = s.ssDirection;
AttrInvoiceCreationDate = s.ssInvoiceCreationDate;
AttrCurrency = s.ssCurrency;
AttrSupplierName = s.ssSupplierName;
AttrPaymentDate = s.ssPaymentDate;
AttrExchangeType = s.ssExchangeType;
  }
}

public static ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure obj) { 
  ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure s = new ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure();
  if(obj != null) {
  s.ssInvoiceNumber = obj.AttrInvoiceNumber == null ? "" : obj.AttrInvoiceNumber;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssAccountingDate = obj.AttrAccountingDate == null ? "" : obj.AttrAccountingDate;
  s.ssAccountingUser = obj.AttrAccountingUser == null ? "" : obj.AttrAccountingUser;
  s.ssEmployedNumber = obj.AttrEmployedNumber == null ? "" : obj.AttrEmployedNumber;
  s.ssDocNumber = obj.AttrDocNumber == null ? "" : obj.AttrDocNumber;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssDepartment = obj.AttrDepartment == null ? "" : obj.AttrDepartment;
  s.ssManagement = obj.AttrManagement == null ? "" : obj.AttrManagement;
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssInvoiceCreationDate = obj.AttrInvoiceCreationDate == null ? "" : obj.AttrInvoiceCreationDate;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssPaymentDate = obj.AttrPaymentDate == null ? "" : obj.AttrPaymentDate;
  s.ssExchangeType = obj.AttrExchangeType == null ? "" : obj.AttrExchangeType;
  }
  return s;
}

public static Func<ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure, ssConectaProveedores.RestRecords.RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure FromStructure(ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure(s, config);
}

}


