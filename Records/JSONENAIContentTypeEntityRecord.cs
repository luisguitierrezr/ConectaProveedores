using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIContentType
public class JSONENAIContentTypeEntityRecord : AbstractRESTStructure<ENAIContentTypeEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

public JSONENAIContentTypeEntityRecord() { }

public JSONENAIContentTypeEntityRecord (ENAIContentTypeEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = ConvertToRestWithoutDefaults(s.ssId, 0L);
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
  } else {
AttrId = (long?) s.ssId;
AttrName = s.ssName;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord, ENAIContentTypeEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord s) => ToStructure(s, config);
}
public static ENAIContentTypeEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord obj, IBehaviorsConfiguration config) { 
  ENAIContentTypeEntityRecord s = new ENAIContentTypeEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  }
  return s;
}

public static Func<ENAIContentTypeEntityRecord, ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ENAIContentTypeEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord FromStructure(ENAIContentTypeEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONENAIContentTypeEntityRecord(s, config);
}

}


