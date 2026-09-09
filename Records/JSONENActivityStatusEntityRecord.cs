using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActivityStatus
public class JSONENActivityStatusEntityRecord : AbstractRESTStructure<ENActivityStatusEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENActivityStatusEntityRecord() { }

public JSONENActivityStatusEntityRecord (ENActivityStatusEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord, ENActivityStatusEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord s) => ToStructure(s, config);
}
public static ENActivityStatusEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord obj, IBehaviorsConfiguration config) { 
  ENActivityStatusEntityRecord s = new ENActivityStatusEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENActivityStatusEntityRecord, ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityStatusEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord FromStructure(ENActivityStatusEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONENActivityStatusEntityRecord(s, config);
}

}


