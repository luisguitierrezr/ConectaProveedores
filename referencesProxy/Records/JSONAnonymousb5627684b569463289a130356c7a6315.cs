using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// File2Record
public class JSONRCFileRecord : AbstractRESTStructure<RCFileRecord> {
[JsonProperty("File")]
[JsonPropertyName("File")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure AttrFile2;

public JSONRCFileRecord() { }

public JSONRCFileRecord (RCFileRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFile2 = ConvertToRestWithoutDefaults(s.ssSTFile2, new STFileStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure.FromStructure, config);
  } else {
AttrFile2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure.FromStructure(s.ssSTFile2, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCFileRecord, RCFileRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCFileRecord s) => ToStructure(s, config);
}
public static RCFileRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCFileRecord obj, IBehaviorsConfiguration config) { 
  RCFileRecord s = new RCFileRecord();
  if(obj != null) {
  s.ssSTFile2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTFileStructure.ToStructure(obj.AttrFile2, config);
  }
  return s;
}

public static Func<RCFileRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCFileRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCFileRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCFileRecord FromStructure(RCFileRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCFileRecord(s, config);
}

}


