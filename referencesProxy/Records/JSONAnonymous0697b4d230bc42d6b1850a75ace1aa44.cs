using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Text2Record
public class JSONRCTextRecord : AbstractRESTStructure<RCTextRecord> {
[JsonProperty("Text")]
[JsonPropertyName("Text")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure AttrText2;

public JSONRCTextRecord() { }

public JSONRCTextRecord (RCTextRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText2 = ConvertToRestWithoutDefaults(s.ssSTText2, new STTextStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure.FromStructure, config);
  } else {
AttrText2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure.FromStructure(s.ssSTText2, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextRecord, RCTextRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextRecord s) => ToStructure(s, config);
}
public static RCTextRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextRecord obj, IBehaviorsConfiguration config) { 
  RCTextRecord s = new RCTextRecord();
  if(obj != null) {
  s.ssSTText2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextStructure.ToStructure(obj.AttrText2, config);
  }
  return s;
}

public static Func<RCTextRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCTextRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextRecord FromStructure(RCTextRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextRecord(s, config);
}

}


