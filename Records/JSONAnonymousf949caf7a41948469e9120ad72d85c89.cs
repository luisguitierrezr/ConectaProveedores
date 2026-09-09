using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IntegerLiteralRecord
public class JSONRCIntegerLiteralRecord : AbstractRESTStructure<RCIntegerLiteralRecord> {
[JsonProperty("IntegerLiteral")]
[JsonPropertyName("IntegerLiteral")]
public ssConectaProveedores.RestRecords.JSONSTIntegerLiteralStructure AttrIntegerLiteral;

public JSONRCIntegerLiteralRecord() { }

public JSONRCIntegerLiteralRecord (RCIntegerLiteralRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIntegerLiteral = ConvertToRestWithoutDefaults(s.ssSTIntegerLiteral, new STIntegerLiteralStructure(), ssConectaProveedores.RestRecords.JSONSTIntegerLiteralStructure.FromStructure, config);
  } else {
AttrIntegerLiteral = ssConectaProveedores.RestRecords.JSONSTIntegerLiteralStructure.FromStructure(s.ssSTIntegerLiteral, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRCIntegerLiteralRecord, RCIntegerLiteralRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRCIntegerLiteralRecord s) => ToStructure(s, config);
}
public static RCIntegerLiteralRecord ToStructure(ssConectaProveedores.RestRecords.JSONRCIntegerLiteralRecord obj, IBehaviorsConfiguration config) { 
  RCIntegerLiteralRecord s = new RCIntegerLiteralRecord();
  if(obj != null) {
  s.ssSTIntegerLiteral = ssConectaProveedores.RestRecords.JSONSTIntegerLiteralStructure.ToStructure(obj.AttrIntegerLiteral, config);
  }
  return s;
}

public static Func<RCIntegerLiteralRecord, ssConectaProveedores.RestRecords.JSONRCIntegerLiteralRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCIntegerLiteralRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRCIntegerLiteralRecord FromStructure(RCIntegerLiteralRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRCIntegerLiteralRecord(s, config);
}

}


