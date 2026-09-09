using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountingAccounts_ServiceType
public class RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord : AbstractRESTStructure<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("CC")]
public string AttrCC;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

public RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord() { }

public RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCC = ConvertToRestWithoutDefaults(s.ssCC, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, true);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrCC = s.ssCC;
AttrDescription = s.ssDescription;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord obj) { 
  EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCC = obj.AttrCC == null ? "" : obj.AttrCC;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord, ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord FromStructure(EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(s, config);
}

}


