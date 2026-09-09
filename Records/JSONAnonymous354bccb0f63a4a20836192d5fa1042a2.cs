using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIMessageRecord
public class JSONRCAIMessageRecord : AbstractRESTStructure<RCAIMessageRecord> {
[JsonProperty("AIMessage")]
[JsonPropertyName("AIMessage")]
public ssConectaProveedores.RestRecords.JSONSTAIMessageStructure AttrAIMessage;

public JSONRCAIMessageRecord() { }

public JSONRCAIMessageRecord (RCAIMessageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIMessage = ConvertToRestWithoutDefaults(s.ssSTAIMessage, new STAIMessageStructure(), ssConectaProveedores.RestRecords.JSONSTAIMessageStructure.FromStructure, config);
  } else {
AttrAIMessage = ssConectaProveedores.RestRecords.JSONSTAIMessageStructure.FromStructure(s.ssSTAIMessage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRCAIMessageRecord, RCAIMessageRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRCAIMessageRecord s) => ToStructure(s, config);
}
public static RCAIMessageRecord ToStructure(ssConectaProveedores.RestRecords.JSONRCAIMessageRecord obj, IBehaviorsConfiguration config) { 
  RCAIMessageRecord s = new RCAIMessageRecord();
  if(obj != null) {
  s.ssSTAIMessage = ssConectaProveedores.RestRecords.JSONSTAIMessageStructure.ToStructure(obj.AttrAIMessage, config);
  }
  return s;
}

public static Func<RCAIMessageRecord, ssConectaProveedores.RestRecords.JSONRCAIMessageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIMessageRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRCAIMessageRecord FromStructure(RCAIMessageRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRCAIMessageRecord(s, config);
}

}


