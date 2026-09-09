using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IntegerLiteral
public class RESTSTIntegerLiteralStructure : AbstractRESTStructure<STIntegerLiteralStructure> {
[JsonProperty("Value")]
public long? AttrValue;

public RESTSTIntegerLiteralStructure() { }

public RESTSTIntegerLiteralStructure (STIntegerLiteralStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = (long?) s.ssValue;
  } else {
AttrValue = (long?) s.ssValue;
  }
}

public static STIntegerLiteralStructure ToStructure(ssConectaProveedores.RestRecords.RESTSTIntegerLiteralStructure obj) { 
  STIntegerLiteralStructure s = new STIntegerLiteralStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? 0L : obj.AttrValue.Value;
  }
  return s;
}

public static Func<STIntegerLiteralStructure, ssConectaProveedores.RestRecords.RESTSTIntegerLiteralStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STIntegerLiteralStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTSTIntegerLiteralStructure FromStructure(STIntegerLiteralStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTSTIntegerLiteralStructure(s, config);
}

}


