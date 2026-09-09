using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApprovalProcessMatrix
public class JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord : AbstractRESTStructure<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProcessTypeId")]
[JsonPropertyName("ProcessTypeId")]
public long? AttrProcessTypeId;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public string AttrRegion;

[JsonProperty("Area")]
[JsonPropertyName("Area")]
public string AttrArea;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public string AttrTelcelDirection;

[JsonProperty("ApprovalProcessId")]
[JsonPropertyName("ApprovalProcessId")]
public long? AttrApprovalProcessId;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("IsDonation_DEPREC")]
[JsonPropertyName("IsDonation_DEPREC")]
public bool? AttrIsDonation_DEPREC;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

public JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord() { }

public JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProcessTypeId = ConvertToRestWithoutDefaults(s.ssProcessTypeId, 0L);
AttrRegion = ConvertToRestWithoutDefaults(s.ssRegion, "");
AttrArea = ConvertToRestWithoutDefaults(s.ssArea, "");
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssTelcelDirection, "");
AttrApprovalProcessId = ConvertToRestWithoutDefaults(s.ssApprovalProcessId, 0L);
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrIsDonation_DEPREC = ConvertToRestWithoutDefaults(s.ssIsDonation_DEPREC, false);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrProcessTypeId = (long?) s.ssProcessTypeId;
AttrRegion = s.ssRegion;
AttrArea = s.ssArea;
AttrTelcelDirection = s.ssTelcelDirection;
AttrApprovalProcessId = (long?) s.ssApprovalProcessId;
AttrIsActive = (bool?) s.ssIsActive;
AttrIsDonation_DEPREC = (bool?) s.ssIsDonation_DEPREC;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord, EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord s) => ToStructure(s, config);
}
public static EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord s = new EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProcessTypeId = obj.AttrProcessTypeId == null ? 0L : obj.AttrProcessTypeId.Value;
  s.ssRegion = obj.AttrRegion == null ? "" : obj.AttrRegion;
  s.ssArea = obj.AttrArea == null ? "" : obj.AttrArea;
  s.ssTelcelDirection = obj.AttrTelcelDirection == null ? "" : obj.AttrTelcelDirection;
  s.ssApprovalProcessId = obj.AttrApprovalProcessId == null ? 0L : obj.AttrApprovalProcessId.Value;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssIsDonation_DEPREC = obj.AttrIsDonation_DEPREC == null ? false : obj.AttrIsDonation_DEPREC.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord FromStructure(EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord(s, config);
}

}


