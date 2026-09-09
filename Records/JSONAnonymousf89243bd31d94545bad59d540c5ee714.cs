using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIItemRecord
public class JSONRCAIItemRecord : AbstractRESTStructure<RCAIItemRecord> {
[JsonProperty("AIItem")]
[JsonPropertyName("AIItem")]
public ssConectaProveedores.RestRecords.JSONSTAIItemStructure AttrAIItem;

public JSONRCAIItemRecord() { }

public JSONRCAIItemRecord (RCAIItemRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIItem = ConvertToRestWithoutDefaults(s.ssSTAIItem, new STAIItemStructure(), ssConectaProveedores.RestRecords.JSONSTAIItemStructure.FromStructure, config);
  } else {
AttrAIItem = ssConectaProveedores.RestRecords.JSONSTAIItemStructure.FromStructure(s.ssSTAIItem, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRCAIItemRecord, RCAIItemRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRCAIItemRecord s) => ToStructure(s, config);
}
public static RCAIItemRecord ToStructure(ssConectaProveedores.RestRecords.JSONRCAIItemRecord obj, IBehaviorsConfiguration config) { 
  RCAIItemRecord s = new RCAIItemRecord();
  if(obj != null) {
  s.ssSTAIItem = ssConectaProveedores.RestRecords.JSONSTAIItemStructure.ToStructure(obj.AttrAIItem, config);
  }
  return s;
}

public static Func<RCAIItemRecord, ssConectaProveedores.RestRecords.JSONRCAIItemRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIItemRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRCAIItemRecord FromStructure(RCAIItemRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRCAIItemRecord(s, config);
}

}


