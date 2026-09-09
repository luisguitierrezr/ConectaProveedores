using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// XmlErrorRecord
public class RESTRCXmlErrorRecord : AbstractRESTStructure<RCXmlErrorRecord> {
[JsonProperty("XmlError")]
public ssConectaProveedores.RestRecords.RESTSTXmlErrorStructure AttrXmlError;

public RESTRCXmlErrorRecord() { }

public RESTRCXmlErrorRecord (RCXmlErrorRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrXmlError = ConvertToRestWithoutDefaults(s.ssSTXmlError, new STXmlErrorStructure(), ssConectaProveedores.RestRecords.RESTSTXmlErrorStructure.FromStructure, config);
  } else {
AttrXmlError = ssConectaProveedores.RestRecords.RESTSTXmlErrorStructure.FromStructure(s.ssSTXmlError, config);
  }
}

public static RCXmlErrorRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCXmlErrorRecord obj) { 
  RCXmlErrorRecord s = new RCXmlErrorRecord();
  if(obj != null) {
  s.ssSTXmlError = ssConectaProveedores.RestRecords.RESTSTXmlErrorStructure.ToStructure(obj.AttrXmlError);
  }
  return s;
}

public static Func<RCXmlErrorRecord, ssConectaProveedores.RestRecords.RESTRCXmlErrorRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCXmlErrorRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCXmlErrorRecord FromStructure(RCXmlErrorRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCXmlErrorRecord(s, config);
}

}


