using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SpecialWorkflows
public class RESTEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord : AbstractRESTStructure<EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Descritpion")]
public string AttrDescritpion;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

public RESTEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord() { }

public RESTEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrDescritpion = ConvertToRestWithoutDefaults(s.ssDescritpion, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
AttrDescritpion = s.ssDescritpion;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord obj) { 
  EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord s = new EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssDescritpion = obj.AttrDescritpion == null ? "" : obj.AttrDescritpion;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord, ssConectaProveedores.RestRecords.RESTEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord FromStructure(EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord(s, config);
}

}


