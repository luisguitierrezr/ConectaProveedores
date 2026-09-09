using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// AccountingAccounts_ServiceType
public class JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord : AbstractRESTStructure<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("CC")]
[JsonPropertyName("CC")]
public string AttrCC;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

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

public JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord() { }

public JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord, EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s) => ToStructure(s, config);
}
public static EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCC = obj.AttrCC == null ? "" : obj.AttrCC;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord FromStructure(EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(s, config);
}

}


