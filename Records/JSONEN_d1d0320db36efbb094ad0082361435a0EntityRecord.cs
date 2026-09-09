using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Invoice
public class JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord : AbstractRESTStructure<EN_d1d0320db36efbb094ad0082361435a0EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("RequisitionId")]
[JsonPropertyName("RequisitionId")]
public long? AttrRequisitionId;

[JsonProperty("FolioId")]
[JsonPropertyName("FolioId")]
public long? AttrFolioId;

[JsonProperty("OrderMainId")]
[JsonPropertyName("OrderMainId")]
public long? AttrOrderMainId;

[JsonProperty("CFDITypeId")]
[JsonPropertyName("CFDITypeId")]
public int? AttrCFDITypeId;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("InvoiceStatusId")]
[JsonPropertyName("InvoiceStatusId")]
public int? AttrInvoiceStatusId;

[JsonProperty("AccountingDateTime")]
[JsonPropertyName("AccountingDateTime")]
public String AttrAccountingDateTime;

[JsonProperty("PaymentDateTime")]
[JsonPropertyName("PaymentDateTime")]
public String AttrPaymentDateTime;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("SubmittedOn")]
[JsonPropertyName("SubmittedOn")]
public String AttrSubmittedOn;

[JsonProperty("IsNewVersion")]
[JsonPropertyName("IsNewVersion")]
public bool? AttrIsNewVersion;

[JsonProperty("ID_POLIZA")]
[JsonPropertyName("ID_POLIZA")]
public string AttrID_POLIZA;

[JsonProperty("ID_POLIZA_SAP")]
[JsonPropertyName("ID_POLIZA_SAP")]
public string AttrID_POLIZA_SAP;

[JsonProperty("Doc51")]
[JsonPropertyName("Doc51")]
public string AttrDoc51;

[JsonProperty("AccountingError")]
[JsonPropertyName("AccountingError")]
public string AttrAccountingError;

[JsonProperty("OrderAccConceptsID")]
[JsonPropertyName("OrderAccConceptsID")]
public long? AttrOrderAccConceptsID;

[JsonProperty("Amortization")]
[JsonPropertyName("Amortization")]
public decimal? AttrAmortization;

[JsonProperty("CreditNoteInvoiceId")]
[JsonPropertyName("CreditNoteInvoiceId")]
public long? AttrCreditNoteInvoiceId;

public JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord() { }

public JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord (EN_d1d0320db36efbb094ad0082361435a0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrRequisitionId = ConvertToRestWithoutDefaults(s.ssRequisitionId, 0L);
AttrFolioId = ConvertToRestWithoutDefaults(s.ssFolioId, 0L);
AttrOrderMainId = ConvertToRestWithoutDefaults(s.ssOrderMainId, 0L);
AttrCFDITypeId = ConvertToRestWithoutDefaults(s.ssCFDITypeId, 0);
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrInvoiceStatusId = ConvertToRestWithoutDefaults(s.ssInvoiceStatusId, 0);
AttrAccountingDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssAccountingDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrPaymentDateTime = ConvertDateTimeToRestWithoutDefaults(s.ssPaymentDateTime, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrSubmittedOn = ConvertDateTimeToRestWithoutDefaults(s.ssSubmittedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsNewVersion = ConvertToRestWithoutDefaults(s.ssIsNewVersion, false);
AttrID_POLIZA = ConvertToRestWithoutDefaults(s.ssID_POLIZA, "");
AttrID_POLIZA_SAP = ConvertToRestWithoutDefaults(s.ssID_POLIZA_SAP, "");
AttrDoc51 = ConvertToRestWithoutDefaults(s.ssDoc51, "");
AttrAccountingError = ConvertToRestWithoutDefaults(s.ssAccountingError, "");
AttrOrderAccConceptsID = ConvertToRestWithoutDefaults(s.ssOrderAccConceptsID, 0L);
AttrAmortization = ConvertToRestWithoutDefaults(s.ssAmortization, 0.0M);
AttrCreditNoteInvoiceId = ConvertToRestWithoutDefaults(s.ssCreditNoteInvoiceId, 0L);
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrRequisitionId = (long?) s.ssRequisitionId;
AttrFolioId = (long?) s.ssFolioId;
AttrOrderMainId = (long?) s.ssOrderMainId;
AttrCFDITypeId = (int?) s.ssCFDITypeId;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrCurrency = s.ssCurrency;
AttrInvoiceStatusId = (int?) s.ssInvoiceStatusId;
AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssAccountingDateTime, config.DateTimeFormat);
AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssPaymentDateTime, config.DateTimeFormat);
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssSubmittedOn, config.DateTimeFormat);
AttrIsNewVersion = (bool?) s.ssIsNewVersion;
AttrID_POLIZA = s.ssID_POLIZA;
AttrID_POLIZA_SAP = s.ssID_POLIZA_SAP;
AttrDoc51 = s.ssDoc51;
AttrAccountingError = s.ssAccountingError;
AttrOrderAccConceptsID = (long?) s.ssOrderAccConceptsID;
AttrAmortization = (decimal?) s.ssAmortization;
AttrCreditNoteInvoiceId = (long?) s.ssCreditNoteInvoiceId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord, EN_d1d0320db36efbb094ad0082361435a0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord s) => ToStructure(s, config);
}
public static EN_d1d0320db36efbb094ad0082361435a0EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d1d0320db36efbb094ad0082361435a0EntityRecord s = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRequisitionId = obj.AttrRequisitionId == null ? 0L : obj.AttrRequisitionId.Value;
  s.ssFolioId = obj.AttrFolioId == null ? 0L : obj.AttrFolioId.Value;
  s.ssOrderMainId = obj.AttrOrderMainId == null ? 0L : obj.AttrOrderMainId.Value;
  s.ssCFDITypeId = obj.AttrCFDITypeId == null ? 0 : obj.AttrCFDITypeId.Value;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssInvoiceStatusId = obj.AttrInvoiceStatusId == null ? 0 : obj.AttrInvoiceStatusId.Value;
  s.ssAccountingDateTime = obj.AttrAccountingDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrAccountingDateTime, config.DateTimeFormat);
  s.ssPaymentDateTime = obj.AttrPaymentDateTime == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrPaymentDateTime, config.DateTimeFormat);
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssSubmittedOn = obj.AttrSubmittedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrSubmittedOn, config.DateTimeFormat);
  s.ssIsNewVersion = obj.AttrIsNewVersion == null ? false : obj.AttrIsNewVersion.Value;
  s.ssID_POLIZA = obj.AttrID_POLIZA == null ? "" : obj.AttrID_POLIZA;
  s.ssID_POLIZA_SAP = obj.AttrID_POLIZA_SAP == null ? "" : obj.AttrID_POLIZA_SAP;
  s.ssDoc51 = obj.AttrDoc51 == null ? "" : obj.AttrDoc51;
  s.ssAccountingError = obj.AttrAccountingError == null ? "" : obj.AttrAccountingError;
  s.ssOrderAccConceptsID = obj.AttrOrderAccConceptsID == null ? 0L : obj.AttrOrderAccConceptsID.Value;
  s.ssAmortization = obj.AttrAmortization == null ? 0.0M : obj.AttrAmortization.Value;
  s.ssCreditNoteInvoiceId = obj.AttrCreditNoteInvoiceId == null ? 0L : obj.AttrCreditNoteInvoiceId.Value;
  }
  return s;
}

public static Func<EN_d1d0320db36efbb094ad0082361435a0EntityRecord, ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d1d0320db36efbb094ad0082361435a0EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord FromStructure(EN_d1d0320db36efbb094ad0082361435a0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord(s, config);
}

}


