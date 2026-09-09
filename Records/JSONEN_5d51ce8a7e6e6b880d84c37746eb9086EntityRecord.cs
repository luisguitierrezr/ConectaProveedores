using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedForeigner
public class JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord : AbstractRESTStructure<EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceNumber")]
[JsonPropertyName("InvoiceNumber")]
public string AttrInvoiceNumber;

[JsonProperty("Direction")]
[JsonPropertyName("Direction")]
public string AttrDirection;

[JsonProperty("ReceiverSocialReason")]
[JsonPropertyName("ReceiverSocialReason")]
public string AttrReceiverSocialReason;

[JsonProperty("ReceiverRFC")]
[JsonPropertyName("ReceiverRFC")]
public string AttrReceiverRFC;

[JsonProperty("IssuerSocialReason")]
[JsonPropertyName("IssuerSocialReason")]
public string AttrIssuerSocialReason;

[JsonProperty("IssuerTaxId")]
[JsonPropertyName("IssuerTaxId")]
public string AttrIssuerTaxId;

[JsonProperty("InvoiceDate")]
[JsonPropertyName("InvoiceDate")]
public String AttrInvoiceDate;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

public JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord() { }

public JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceNumber = ConvertToRestWithoutDefaults(s.ssInvoiceNumber, "");
AttrDirection = ConvertToRestWithoutDefaults(s.ssDirection, "");
AttrReceiverSocialReason = ConvertToRestWithoutDefaults(s.ssReceiverSocialReason, "");
AttrReceiverRFC = ConvertToRestWithoutDefaults(s.ssReceiverRFC, "");
AttrIssuerSocialReason = ConvertToRestWithoutDefaults(s.ssIssuerSocialReason, "");
AttrIssuerTaxId = ConvertToRestWithoutDefaults(s.ssIssuerTaxId, "");
AttrInvoiceDate = ConvertDateToRestWithoutDefaults(s.ssInvoiceDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceNumber = s.ssInvoiceNumber;
AttrDirection = s.ssDirection;
AttrReceiverSocialReason = s.ssReceiverSocialReason;
AttrReceiverRFC = s.ssReceiverRFC;
AttrIssuerSocialReason = s.ssIssuerSocialReason;
AttrIssuerTaxId = s.ssIssuerTaxId;
AttrInvoiceDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssInvoiceDate);
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrCurrency = s.ssCurrency;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord, EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord s) => ToStructure(s, config);
}
public static EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord s = new EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceNumber = obj.AttrInvoiceNumber == null ? "" : obj.AttrInvoiceNumber;
  s.ssDirection = obj.AttrDirection == null ? "" : obj.AttrDirection;
  s.ssReceiverSocialReason = obj.AttrReceiverSocialReason == null ? "" : obj.AttrReceiverSocialReason;
  s.ssReceiverRFC = obj.AttrReceiverRFC == null ? "" : obj.AttrReceiverRFC;
  s.ssIssuerSocialReason = obj.AttrIssuerSocialReason == null ? "" : obj.AttrIssuerSocialReason;
  s.ssIssuerTaxId = obj.AttrIssuerTaxId == null ? "" : obj.AttrIssuerTaxId;
  s.ssInvoiceDate = obj.AttrInvoiceDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrInvoiceDate);
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  }
  return s;
}

public static Func<EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord, ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord FromStructure(EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord(s, config);
}

}


