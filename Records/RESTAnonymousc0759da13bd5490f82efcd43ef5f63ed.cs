using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIModelUsageRecord
public class RESTRCAIModelUsageRecord : AbstractRESTStructure<RCAIModelUsageRecord> {
[JsonProperty("AIModelUsage")]
public ssConectaProveedores.RestRecords.RESTSTAIModelUsageStructure AttrAIModelUsage;

public RESTRCAIModelUsageRecord() { }

public RESTRCAIModelUsageRecord (RCAIModelUsageRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIModelUsage = ConvertToRestWithoutDefaults(s.ssSTAIModelUsage, new STAIModelUsageStructure(), ssConectaProveedores.RestRecords.RESTSTAIModelUsageStructure.FromStructure, config);
  } else {
AttrAIModelUsage = ssConectaProveedores.RestRecords.RESTSTAIModelUsageStructure.FromStructure(s.ssSTAIModelUsage, config);
  }
}

public static RCAIModelUsageRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCAIModelUsageRecord obj) { 
  RCAIModelUsageRecord s = new RCAIModelUsageRecord();
  if(obj != null) {
  s.ssSTAIModelUsage = ssConectaProveedores.RestRecords.RESTSTAIModelUsageStructure.ToStructure(obj.AttrAIModelUsage);
  }
  return s;
}

public static Func<RCAIModelUsageRecord, ssConectaProveedores.RestRecords.RESTRCAIModelUsageRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIModelUsageRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCAIModelUsageRecord FromStructure(RCAIModelUsageRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCAIModelUsageRecord(s, config);
}

}


