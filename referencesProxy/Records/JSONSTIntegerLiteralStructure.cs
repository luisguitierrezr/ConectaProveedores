using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// IntegerLiteral
public class JSONSTIntegerLiteralStructure : AbstractRESTStructure<STIntegerLiteralStructure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public long? AttrValue;

public JSONSTIntegerLiteralStructure() { }

public JSONSTIntegerLiteralStructure (STIntegerLiteralStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = (long?) s.ssValue;
  } else {
AttrValue = (long?) s.ssValue;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure, STIntegerLiteralStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure s) => ToStructure(s, config);
}
public static STIntegerLiteralStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure obj, IBehaviorsConfiguration config) { 
  STIntegerLiteralStructure s = new STIntegerLiteralStructure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? 0L : obj.AttrValue.Value;
  }
  return s;
}

public static Func<STIntegerLiteralStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (STIntegerLiteralStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure FromStructure(STIntegerLiteralStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure(s, config);
}

}


