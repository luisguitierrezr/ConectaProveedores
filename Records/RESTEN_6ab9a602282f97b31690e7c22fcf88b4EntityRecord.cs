using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Department
public class RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord : AbstractRESTStructure<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

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

public RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord() { }

public RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord obj) { 
  EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssIsActive = obj.AttrIsActive == null ? true : obj.AttrIsActive.Value;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord, ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord FromStructure(EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(s, config);
}

}


