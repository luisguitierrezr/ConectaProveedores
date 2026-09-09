using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProcessStatus
public class JSONENProcessStatusEntityRecord : AbstractRESTStructure<ENProcessStatusEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENProcessStatusEntityRecord() { }

public JSONENProcessStatusEntityRecord (ENProcessStatusEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord, ENProcessStatusEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord s) => ToStructure(s, config);
}
public static ENProcessStatusEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord obj, IBehaviorsConfiguration config) { 
  ENProcessStatusEntityRecord s = new ENProcessStatusEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENProcessStatusEntityRecord, ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENProcessStatusEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord FromStructure(ENProcessStatusEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONENProcessStatusEntityRecord(s, config);
}

}


