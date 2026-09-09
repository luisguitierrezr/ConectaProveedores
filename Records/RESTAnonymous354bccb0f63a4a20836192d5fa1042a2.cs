using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIMessageRecord
public class RESTRCAIMessageRecord : AbstractRESTStructure<RCAIMessageRecord> {
[JsonProperty("AIMessage")]
public ssConectaProveedores.RestRecords.RESTSTAIMessageStructure AttrAIMessage;

public RESTRCAIMessageRecord() { }

public RESTRCAIMessageRecord (RCAIMessageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIMessage = ConvertToRestWithoutDefaults(s.ssSTAIMessage, new STAIMessageStructure(), ssConectaProveedores.RestRecords.RESTSTAIMessageStructure.FromStructure, config);
  } else {
AttrAIMessage = ssConectaProveedores.RestRecords.RESTSTAIMessageStructure.FromStructure(s.ssSTAIMessage, config);
  }
}

public static RCAIMessageRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCAIMessageRecord obj) { 
  RCAIMessageRecord s = new RCAIMessageRecord();
  if(obj != null) {
  s.ssSTAIMessage = ssConectaProveedores.RestRecords.RESTSTAIMessageStructure.ToStructure(obj.AttrAIMessage);
  }
  return s;
}

public static Func<RCAIMessageRecord, ssConectaProveedores.RestRecords.RESTRCAIMessageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIMessageRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCAIMessageRecord FromStructure(RCAIMessageRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCAIMessageRecord(s, config);
}

}


