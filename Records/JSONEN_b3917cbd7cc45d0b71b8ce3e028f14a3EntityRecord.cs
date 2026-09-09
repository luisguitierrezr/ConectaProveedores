using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccounting
public class JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord : AbstractRESTStructure<EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("SupplierNumber")]
[JsonPropertyName("SupplierNumber")]
public string AttrSupplierNumber;

[JsonProperty("ServiceTypeId")]
[JsonPropertyName("ServiceTypeId")]
public long? AttrServiceTypeId;

[JsonProperty("FreeText")]
[JsonPropertyName("FreeText")]
public string AttrFreeText;

[JsonProperty("Division")]
[JsonPropertyName("Division")]
public string AttrDivision;

[JsonProperty("IvaAmount")]
[JsonPropertyName("IvaAmount")]
public decimal? AttrIvaAmount;

[JsonProperty("Iva_Old")]
[JsonPropertyName("Iva_Old")]
public string AttrIva_Old;

[JsonProperty("IvaIndicatorId")]
[JsonPropertyName("IvaIndicatorId")]
public long? AttrIvaIndicatorId;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("PaymentMethodId")]
[JsonPropertyName("PaymentMethodId")]
public long? AttrPaymentMethodId;

[JsonProperty("PaymentTermsId")]
[JsonPropertyName("PaymentTermsId")]
public long? AttrPaymentTermsId;

[JsonProperty("ICMEIndicator")]
[JsonPropertyName("ICMEIndicator")]
public string AttrICMEIndicator;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("SubmissionBy")]
[JsonPropertyName("SubmissionBy")]
public string AttrSubmissionBy;

[JsonProperty("SubmissionOn")]
[JsonPropertyName("SubmissionOn")]
public String AttrSubmissionOn;

[JsonProperty("ServiceCalledBy")]
[JsonPropertyName("ServiceCalledBy")]
public string AttrServiceCalledBy;

[JsonProperty("ServiceCalledOn")]
[JsonPropertyName("ServiceCalledOn")]
public String AttrServiceCalledOn;

[JsonProperty("BuyDocNumber")]
[JsonPropertyName("BuyDocNumber")]
public string AttrBuyDocNumber;

[JsonProperty("BuyDocPosition")]
[JsonPropertyName("BuyDocPosition")]
public string AttrBuyDocPosition;

public JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord() { }

public JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrSupplierNumber = ConvertToRestWithoutDefaults(s.ssSupplierNumber, "");
AttrServiceTypeId = ConvertToRestWithoutDefaults(s.ssServiceTypeId, 0L);
AttrFreeText = ConvertToRestWithoutDefaults(s.ssFreeText, "");
AttrDivision = ConvertToRestWithoutDefaults(s.ssDivision, "");
AttrIvaAmount = ConvertToRestWithoutDefaults(s.ssIvaAmount, 0.0M);
AttrIva_Old = ConvertToRestWithoutDefaults(s.ssIva_Old, "");
AttrIvaIndicatorId = ConvertToRestWithoutDefaults(s.ssIvaIndicatorId, 0L);
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrPaymentMethodId = ConvertToRestWithoutDefaults(s.ssPaymentMethodId, 0L);
AttrPaymentTermsId = ConvertToRestWithoutDefaults(s.ssPaymentTermsId, 0L);
AttrICMEIndicator = ConvertToRestWithoutDefaults(s.ssICMEIndicator, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrSubmissionBy = ConvertToRestWithoutDefaults(s.ssSubmissionBy, "");
AttrSubmissionOn = ConvertDateTimeToRestWithoutDefaults(s.ssSubmissionOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrServiceCalledBy = ConvertToRestWithoutDefaults(s.ssServiceCalledBy, "");
AttrServiceCalledOn = ConvertDateTimeToRestWithoutDefaults(s.ssServiceCalledOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrBuyDocNumber = ConvertToRestWithoutDefaults(s.ssBuyDocNumber, "");
AttrBuyDocPosition = ConvertToRestWithoutDefaults(s.ssBuyDocPosition, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrSupplierNumber = s.ssSupplierNumber;
AttrServiceTypeId = (long?) s.ssServiceTypeId;
AttrFreeText = s.ssFreeText;
AttrDivision = s.ssDivision;
AttrIvaAmount = (decimal?) s.ssIvaAmount;
AttrIva_Old = s.ssIva_Old;
AttrIvaIndicatorId = (long?) s.ssIvaIndicatorId;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrPaymentMethodId = (long?) s.ssPaymentMethodId;
AttrPaymentTermsId = (long?) s.ssPaymentTermsId;
AttrICMEIndicator = s.ssICMEIndicator;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrSubmissionBy = s.ssSubmissionBy;
AttrSubmissionOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssSubmissionOn, config.DateTimeFormat);
AttrServiceCalledBy = s.ssServiceCalledBy;
AttrServiceCalledOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssServiceCalledOn, config.DateTimeFormat);
AttrBuyDocNumber = s.ssBuyDocNumber;
AttrBuyDocPosition = s.ssBuyDocPosition;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord s) => ToStructure(s, config);
}
public static EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord s = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssSupplierNumber = obj.AttrSupplierNumber == null ? "" : obj.AttrSupplierNumber;
  s.ssServiceTypeId = obj.AttrServiceTypeId == null ? 0L : obj.AttrServiceTypeId.Value;
  s.ssFreeText = obj.AttrFreeText == null ? "" : obj.AttrFreeText;
  s.ssDivision = obj.AttrDivision == null ? "" : obj.AttrDivision;
  s.ssIvaAmount = obj.AttrIvaAmount == null ? 0.0M : obj.AttrIvaAmount.Value;
  s.ssIva_Old = obj.AttrIva_Old == null ? "" : obj.AttrIva_Old;
  s.ssIvaIndicatorId = obj.AttrIvaIndicatorId == null ? 0L : obj.AttrIvaIndicatorId.Value;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssPaymentMethodId = obj.AttrPaymentMethodId == null ? 0L : obj.AttrPaymentMethodId.Value;
  s.ssPaymentTermsId = obj.AttrPaymentTermsId == null ? 0L : obj.AttrPaymentTermsId.Value;
  s.ssICMEIndicator = obj.AttrICMEIndicator == null ? "" : obj.AttrICMEIndicator;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssSubmissionBy = obj.AttrSubmissionBy == null ? "" : obj.AttrSubmissionBy;
  s.ssSubmissionOn = obj.AttrSubmissionOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrSubmissionOn, config.DateTimeFormat);
  s.ssServiceCalledBy = obj.AttrServiceCalledBy == null ? "" : obj.AttrServiceCalledBy;
  s.ssServiceCalledOn = obj.AttrServiceCalledOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrServiceCalledOn, config.DateTimeFormat);
  s.ssBuyDocNumber = obj.AttrBuyDocNumber == null ? "" : obj.AttrBuyDocNumber;
  s.ssBuyDocPosition = obj.AttrBuyDocPosition == null ? "" : obj.AttrBuyDocPosition;
  }
  return s;
}

public static Func<EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord, ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord FromStructure(EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(s, config);
}

}


