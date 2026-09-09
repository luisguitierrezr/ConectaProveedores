using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// XmlError
public class JSONSTXmlErrorStructure : AbstractRESTStructure<STXmlErrorStructure> {
[JsonProperty("Severity")]
[JsonPropertyName("Severity")]
public string AttrSeverity;

[JsonProperty("Message")]
[JsonPropertyName("Message")]
public string AttrMessage;

public JSONSTXmlErrorStructure() { }

public JSONSTXmlErrorStructure (STXmlErrorStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeverity = s.ssSeverity;
AttrMessage = s.ssMessage;
  } else {
AttrSeverity = s.ssSeverity;
AttrMessage = s.ssMessage;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure, STXmlErrorStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure s) => ToStructure(s, config);
}
public static STXmlErrorStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure obj, IBehaviorsConfiguration config) { 
  STXmlErrorStructure s = new STXmlErrorStructure();
  if(obj != null) {
  s.ssSeverity = obj.AttrSeverity == null ? "" : obj.AttrSeverity;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<STXmlErrorStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STXmlErrorStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure FromStructure(STXmlErrorStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTXmlErrorStructure(s, config);
}

}


