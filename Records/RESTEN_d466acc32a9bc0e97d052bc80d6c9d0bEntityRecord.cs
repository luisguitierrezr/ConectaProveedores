using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TelcelDirection
public class RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord : AbstractRESTStructure<EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord> {
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

public RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord() { }

public RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
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

public static EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord obj) { 
  EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord s = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
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

public static Func<EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord, ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord FromStructure(EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(s, config);
}

}


