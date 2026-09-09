using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIModelUsageRecord
public class JSONRCAIModelUsageRecord : AbstractRESTStructure<RCAIModelUsageRecord> {
[JsonProperty("AIModelUsage")]
[JsonPropertyName("AIModelUsage")]
public ssConectaProveedores.RestRecords.JSONSTAIModelUsageStructure AttrAIModelUsage;

public JSONRCAIModelUsageRecord() { }

public JSONRCAIModelUsageRecord (RCAIModelUsageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIModelUsage = ConvertToRestWithoutDefaults(s.ssSTAIModelUsage, new STAIModelUsageStructure(), ssConectaProveedores.RestRecords.JSONSTAIModelUsageStructure.FromStructure, config);
  } else {
AttrAIModelUsage = ssConectaProveedores.RestRecords.JSONSTAIModelUsageStructure.FromStructure(s.ssSTAIModelUsage, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRCAIModelUsageRecord, RCAIModelUsageRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRCAIModelUsageRecord s) => ToStructure(s, config);
}
public static RCAIModelUsageRecord ToStructure(ssConectaProveedores.RestRecords.JSONRCAIModelUsageRecord obj, IBehaviorsConfiguration config) { 
  RCAIModelUsageRecord s = new RCAIModelUsageRecord();
  if(obj != null) {
  s.ssSTAIModelUsage = ssConectaProveedores.RestRecords.JSONSTAIModelUsageStructure.ToStructure(obj.AttrAIModelUsage, config);
  }
  return s;
}

public static Func<RCAIModelUsageRecord, ssConectaProveedores.RestRecords.JSONRCAIModelUsageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIModelUsageRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRCAIModelUsageRecord FromStructure(RCAIModelUsageRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRCAIModelUsageRecord(s, config);
}

}


