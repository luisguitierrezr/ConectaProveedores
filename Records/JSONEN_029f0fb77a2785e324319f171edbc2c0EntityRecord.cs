using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SegmentAccGroup
public class JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord : AbstractRESTStructure<EN_029f0fb77a2785e324319f171edbc2c0EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("GroupName")]
[JsonPropertyName("GroupName")]
public string AttrGroupName;

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

public JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord() { }

public JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord (EN_029f0fb77a2785e324319f171edbc2c0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrGroupName = s.ssGroupName;
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrGroupName = s.ssGroupName;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord, EN_029f0fb77a2785e324319f171edbc2c0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord s) => ToStructure(s, config);
}
public static EN_029f0fb77a2785e324319f171edbc2c0EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_029f0fb77a2785e324319f171edbc2c0EntityRecord s = new EN_029f0fb77a2785e324319f171edbc2c0EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssGroupName = obj.AttrGroupName == null ? "" : obj.AttrGroupName;
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_029f0fb77a2785e324319f171edbc2c0EntityRecord, ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_029f0fb77a2785e324319f171edbc2c0EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord FromStructure(EN_029f0fb77a2785e324319f171edbc2c0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_029f0fb77a2785e324319f171edbc2c0EntityRecord(s, config);
}

}


