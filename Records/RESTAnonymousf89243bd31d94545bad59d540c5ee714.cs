using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AIItemRecord
public class RESTRCAIItemRecord : AbstractRESTStructure<RCAIItemRecord> {
[JsonProperty("AIItem")]
public ssConectaProveedores.RestRecords.RESTSTAIItemStructure AttrAIItem;

public RESTRCAIItemRecord() { }

public RESTRCAIItemRecord (RCAIItemRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAIItem = ConvertToRestWithoutDefaults(s.ssSTAIItem, new STAIItemStructure(), ssConectaProveedores.RestRecords.RESTSTAIItemStructure.FromStructure, config);
  } else {
AttrAIItem = ssConectaProveedores.RestRecords.RESTSTAIItemStructure.FromStructure(s.ssSTAIItem, config);
  }
}

public static RCAIItemRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCAIItemRecord obj) { 
  RCAIItemRecord s = new RCAIItemRecord();
  if(obj != null) {
  s.ssSTAIItem = ssConectaProveedores.RestRecords.RESTSTAIItemStructure.ToStructure(obj.AttrAIItem);
  }
  return s;
}

public static Func<RCAIItemRecord, ssConectaProveedores.RestRecords.RESTRCAIItemRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCAIItemRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCAIItemRecord FromStructure(RCAIItemRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCAIItemRecord(s, config);
}

}


