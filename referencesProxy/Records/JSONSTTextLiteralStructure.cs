using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TextLiteral
public class JSONSTTextLiteralStructure : AbstractRESTStructure<STTextLiteralStructure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

public JSONSTTextLiteralStructure() { }

public JSONSTTextLiteralStructure (STTextLiteralStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
  } else {
AttrValue = s.ssValue;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure, STTextLiteralStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure s) => ToStructure(s, config);
}
public static STTextLiteralStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure obj, IBehaviorsConfiguration config) { 
  STTextLiteralStructure s = new STTextLiteralStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<STTextLiteralStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STTextLiteralStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure FromStructure(STTextLiteralStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure(s, config);
}

}


