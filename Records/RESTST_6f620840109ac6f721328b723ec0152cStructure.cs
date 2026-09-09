using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ForeignInvoiceUsResult
public class RESTST_6f620840109ac6f721328b723ec0152cStructure : AbstractRESTStructure<ST_6f620840109ac6f721328b723ec0152cStructure> {
[JsonProperty("Success")]
public bool? AttrSuccess;

[JsonProperty("ErrorMessage")]
public string AttrErrorMessage;

[JsonProperty("DocumentType")]
public string AttrDocumentType;

[JsonProperty("InvoiceNumber")]
public string AttrInvoiceNumber;

[JsonProperty("SupplierName")]
public string AttrSupplierName;

[JsonProperty("SupplierTaxId")]
public string AttrSupplierTaxId;

[JsonProperty("InvoiceDate")]
public string AttrInvoiceDate;

[JsonProperty("TotalAmount")]
public string AttrTotalAmount;

[JsonProperty("Currency")]
public string AttrCurrency;

[JsonProperty("CustomerNameDetected")]
public string AttrCustomerNameDetected;

[JsonProperty("CustomerTaxIdDetected")]
public string AttrCustomerTaxIdDetected;

[JsonProperty("CustomerAddressDetected")]
public string AttrCustomerAddressDetected;

[JsonProperty("ConfidenceScore")]
public decimal? AttrConfidenceScore;

[JsonProperty("WarningsText")]
public string AttrWarningsText;

[JsonProperty("RawText")]
public string AttrRawText;

public RESTST_6f620840109ac6f721328b723ec0152cStructure() { }

public RESTST_6f620840109ac6f721328b723ec0152cStructure (ST_6f620840109ac6f721328b723ec0152cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
AttrDocumentType = ConvertToRestWithoutDefaults(s.ssDocumentType, "");
AttrInvoiceNumber = ConvertToRestWithoutDefaults(s.ssInvoiceNumber, "");
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrSupplierTaxId = ConvertToRestWithoutDefaults(s.ssSupplierTaxId, "");
AttrInvoiceDate = ConvertToRestWithoutDefaults(s.ssInvoiceDate, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrCustomerNameDetected = ConvertToRestWithoutDefaults(s.ssCustomerNameDetected, "");
AttrCustomerTaxIdDetected = ConvertToRestWithoutDefaults(s.ssCustomerTaxIdDetected, "");
AttrCustomerAddressDetected = ConvertToRestWithoutDefaults(s.ssCustomerAddressDetected, "");
AttrConfidenceScore = ConvertToRestWithoutDefaults(s.ssConfidenceScore, 0.0M);
AttrWarningsText = ConvertToRestWithoutDefaults(s.ssWarningsText, "");
AttrRawText = ConvertToRestWithoutDefaults(s.ssRawText, "");
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrErrorMessage = s.ssErrorMessage;
AttrDocumentType = s.ssDocumentType;
AttrInvoiceNumber = s.ssInvoiceNumber;
AttrSupplierName = s.ssSupplierName;
AttrSupplierTaxId = s.ssSupplierTaxId;
AttrInvoiceDate = s.ssInvoiceDate;
AttrTotalAmount = s.ssTotalAmount;
AttrCurrency = s.ssCurrency;
AttrCustomerNameDetected = s.ssCustomerNameDetected;
AttrCustomerTaxIdDetected = s.ssCustomerTaxIdDetected;
AttrCustomerAddressDetected = s.ssCustomerAddressDetected;
AttrConfidenceScore = (decimal?) s.ssConfidenceScore;
AttrWarningsText = s.ssWarningsText;
AttrRawText = s.ssRawText;
  }
}

public static ST_6f620840109ac6f721328b723ec0152cStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure obj) { 
  ST_6f620840109ac6f721328b723ec0152cStructure s = new ST_6f620840109ac6f721328b723ec0152cStructure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  s.ssDocumentType = obj.AttrDocumentType == null ? "" : obj.AttrDocumentType;
  s.ssInvoiceNumber = obj.AttrInvoiceNumber == null ? "" : obj.AttrInvoiceNumber;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssSupplierTaxId = obj.AttrSupplierTaxId == null ? "" : obj.AttrSupplierTaxId;
  s.ssInvoiceDate = obj.AttrInvoiceDate == null ? "" : obj.AttrInvoiceDate;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssCustomerNameDetected = obj.AttrCustomerNameDetected == null ? "" : obj.AttrCustomerNameDetected;
  s.ssCustomerTaxIdDetected = obj.AttrCustomerTaxIdDetected == null ? "" : obj.AttrCustomerTaxIdDetected;
  s.ssCustomerAddressDetected = obj.AttrCustomerAddressDetected == null ? "" : obj.AttrCustomerAddressDetected;
  s.ssConfidenceScore = obj.AttrConfidenceScore == null ? 0.0M : obj.AttrConfidenceScore.Value;
  s.ssWarningsText = obj.AttrWarningsText == null ? "" : obj.AttrWarningsText;
  s.ssRawText = obj.AttrRawText == null ? "" : obj.AttrRawText;
  }
  return s;
}

public static Func<ST_6f620840109ac6f721328b723ec0152cStructure, ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6f620840109ac6f721328b723ec0152cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure FromStructure(ST_6f620840109ac6f721328b723ec0152cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure(s, config);
}

}


