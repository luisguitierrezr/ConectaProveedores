using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessMatrix
public class RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord : AbstractRESTStructure<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ProcessTypeId")]
public long? AttrProcessTypeId;

[JsonProperty("Region")]
public string AttrRegion;

[JsonProperty("Area")]
public string AttrArea;

[JsonProperty("TelcelDirection")]
public string AttrTelcelDirection;

[JsonProperty("ApprovalProcessId")]
public long? AttrApprovalProcessId;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("IsDonation_DEPREC")]
public bool? AttrIsDonation_DEPREC;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

public RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord() { }

public RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord obj) { 
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
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord, ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord FromStructure(EN_fb6314d818ce8b161376c10b2af51bb9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_fb6314d818ce8b161376c10b2af51bb9EntityRecord(s, config);
}

}


