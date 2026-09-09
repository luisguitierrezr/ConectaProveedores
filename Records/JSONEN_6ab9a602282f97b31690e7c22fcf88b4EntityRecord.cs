using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Department
public class JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord : AbstractRESTStructure<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

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

public JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord() { }

public JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrIsActive = (bool?) s.ssIsActive;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord, EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s) => ToStructure(s, config);
}
public static EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord, ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord FromStructure(EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(s, config);
}

}


