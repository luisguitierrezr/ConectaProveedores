using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FiscalYearExceptions
public class RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord : AbstractRESTStructure<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Year")]
public int? AttrYear;

[JsonProperty("InvoiceFolio")]
public string AttrInvoiceFolio;

[JsonProperty("InvoiceUUID")]
public string AttrInvoiceUUID;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord() { }

public RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord obj) { 
  EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s = new EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssYear = obj.AttrYear == null ? 0 : obj.AttrYear.Value;
  s.ssInvoiceFolio = obj.AttrInvoiceFolio == null ? "" : obj.AttrInvoiceFolio;
  s.ssInvoiceUUID = obj.AttrInvoiceUUID == null ? "" : obj.AttrInvoiceUUID;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord, ssConectaProveedores.RestRecords.RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord FromStructure(EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord(s, config);
}

}


