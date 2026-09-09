using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FiscalYearExceptions
public class JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord : AbstractRESTStructure<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Year")]
[JsonPropertyName("Year")]
public int? AttrYear;

[JsonProperty("InvoiceFolio")]
[JsonPropertyName("InvoiceFolio")]
public string AttrInvoiceFolio;

[JsonProperty("InvoiceUUID")]
[JsonPropertyName("InvoiceUUID")]
public string AttrInvoiceUUID;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

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

public JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord() { }

public JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrYear = ConvertToRestWithoutDefaults(s.ssYear, 0);
AttrInvoiceFolio = ConvertToRestWithoutDefaults(s.ssInvoiceFolio, "");
AttrInvoiceUUID = ConvertToRestWithoutDefaults(s.ssInvoiceUUID, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrYear = (int?) s.ssYear;
AttrInvoiceFolio = s.ssInvoiceFolio;
AttrInvoiceUUID = s.ssInvoiceUUID;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord, EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s) => ToStructure(s, config);
}
public static EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s = new EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssYear = obj.AttrYear == null ? 0 : obj.AttrYear.Value;
  s.ssInvoiceFolio = obj.AttrInvoiceFolio == null ? "" : obj.AttrInvoiceFolio;
  s.ssInvoiceUUID = obj.AttrInvoiceUUID == null ? "" : obj.AttrInvoiceUUID;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord, ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord FromStructure(EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord(s, config);
}

}


