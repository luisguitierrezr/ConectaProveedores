using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// XmlError
public class RESTSTXmlErrorStructure : AbstractRESTStructure<STXmlErrorStructure> {
[JsonProperty("Severity")]
public string AttrSeverity;

[JsonProperty("Message")]
public string AttrMessage;

public RESTSTXmlErrorStructure() { }

public RESTSTXmlErrorStructure (STXmlErrorStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeverity = s.ssSeverity;
AttrMessage = s.ssMessage;
  } else {
AttrSeverity = s.ssSeverity;
AttrMessage = s.ssMessage;
  }
}

public static STXmlErrorStructure ToStructure(ssConectaProveedores.RestRecords.RESTSTXmlErrorStructure obj) { 
  STXmlErrorStructure s = new STXmlErrorStructure();
  if(obj != null) {
  s.ssSeverity = obj.AttrSeverity == null ? "" : obj.AttrSeverity;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<STXmlErrorStructure, ssConectaProveedores.RestRecords.RESTSTXmlErrorStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STXmlErrorStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTSTXmlErrorStructure FromStructure(STXmlErrorStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTSTXmlErrorStructure(s, config);
}

}


