using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActivityKind
public class JSONENActivityKindEntityRecord : AbstractRESTStructure<ENActivityKindEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENActivityKindEntityRecord() { }

public JSONENActivityKindEntityRecord (ENActivityKindEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONENActivityKindEntityRecord, ENActivityKindEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONENActivityKindEntityRecord s) => ToStructure(s, config);
}
public static ENActivityKindEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONENActivityKindEntityRecord obj, IBehaviorsConfiguration config) { 
  ENActivityKindEntityRecord s = new ENActivityKindEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENActivityKindEntityRecord, ssConectaProveedores.RestRecords.JSONENActivityKindEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityKindEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONENActivityKindEntityRecord FromStructure(ENActivityKindEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONENActivityKindEntityRecord(s, config);
}

}


