using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActivityKind
public class RESTENActivityKindEntityRecord : AbstractRESTStructure<ENActivityKindEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Name")]
public string AttrName;

public RESTENActivityKindEntityRecord() { }

public RESTENActivityKindEntityRecord (ENActivityKindEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static ENActivityKindEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTENActivityKindEntityRecord obj) { 
  ENActivityKindEntityRecord s = new ENActivityKindEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENActivityKindEntityRecord, ssConectaProveedores.RestRecords.RESTENActivityKindEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENActivityKindEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTENActivityKindEntityRecord FromStructure(ENActivityKindEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTENActivityKindEntityRecord(s, config);
}

}


