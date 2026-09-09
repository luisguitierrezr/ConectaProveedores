using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextLiteral
public class RESTSTTextLiteralStructure : AbstractRESTStructure<STTextLiteralStructure> {
[JsonProperty("Value")]
public string AttrValue;

public RESTSTTextLiteralStructure() { }

public RESTSTTextLiteralStructure (STTextLiteralStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = s.ssValue;
  } else {
AttrValue = s.ssValue;
  }
}

public static STTextLiteralStructure ToStructure(ssConectaProveedores.RestRecords.RESTSTTextLiteralStructure obj) { 
  STTextLiteralStructure s = new STTextLiteralStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  }
  return s;
}

public static Func<STTextLiteralStructure, ssConectaProveedores.RestRecords.RESTSTTextLiteralStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STTextLiteralStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTSTTextLiteralStructure FromStructure(STTextLiteralStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTSTTextLiteralStructure(s, config);
}

}


