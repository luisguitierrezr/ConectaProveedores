using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// XmlErrorRecord
public class JSONRCXmlErrorRecord : AbstractRESTStructure<RCXmlErrorRecord> {
[JsonProperty("XmlError")]
[JsonPropertyName("XmlError")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure AttrXmlError;

public JSONRCXmlErrorRecord() { }

public JSONRCXmlErrorRecord (RCXmlErrorRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrXmlError = ConvertToRestWithoutDefaults(s.ssSTXmlError, new STXmlErrorStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure.FromStructure, config);
  } else {
AttrXmlError = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure.FromStructure(s.ssSTXmlError, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCXmlErrorRecord, RCXmlErrorRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCXmlErrorRecord s) => ToStructure(s, config);
}
public static RCXmlErrorRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCXmlErrorRecord obj, IBehaviorsConfiguration config) { 
  RCXmlErrorRecord s = new RCXmlErrorRecord();
  if(obj != null) {
  s.ssSTXmlError = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure.ToStructure(obj.AttrXmlError, config);
  }
  return s;
}

public static Func<RCXmlErrorRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCXmlErrorRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCXmlErrorRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCXmlErrorRecord FromStructure(RCXmlErrorRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCXmlErrorRecord(s, config);
}

}


