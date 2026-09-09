using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// XmlErrorRecord
public class JSONRCXmlErrorRecord : AbstractRESTStructure<RCXmlErrorRecord> {
[JsonProperty("XmlError")]
[JsonPropertyName("XmlError")]
public ssConectaProveedores.RestRecords.JSONSTXmlErrorStructure AttrXmlError;

public JSONRCXmlErrorRecord() { }

public JSONRCXmlErrorRecord (RCXmlErrorRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrXmlError = ConvertToRestWithoutDefaults(s.ssSTXmlError, new STXmlErrorStructure(), ssConectaProveedores.RestRecords.JSONSTXmlErrorStructure.FromStructure, config);
  } else {
AttrXmlError = ssConectaProveedores.RestRecords.JSONSTXmlErrorStructure.FromStructure(s.ssSTXmlError, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRCXmlErrorRecord, RCXmlErrorRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRCXmlErrorRecord s) => ToStructure(s, config);
}
public static RCXmlErrorRecord ToStructure(ssConectaProveedores.RestRecords.JSONRCXmlErrorRecord obj, IBehaviorsConfiguration config) { 
  RCXmlErrorRecord s = new RCXmlErrorRecord();
  if(obj != null) {
  s.ssSTXmlError = ssConectaProveedores.RestRecords.JSONSTXmlErrorStructure.ToStructure(obj.AttrXmlError, config);
  }
  return s;
}

public static Func<RCXmlErrorRecord, ssConectaProveedores.RestRecords.JSONRCXmlErrorRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCXmlErrorRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRCXmlErrorRecord FromStructure(RCXmlErrorRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRCXmlErrorRecord(s, config);
}

}


