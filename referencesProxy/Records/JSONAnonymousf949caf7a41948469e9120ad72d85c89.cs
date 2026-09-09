using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// IntegerLiteralRecord
public class JSONRCIntegerLiteralRecord : AbstractRESTStructure<RCIntegerLiteralRecord> {
[JsonProperty("IntegerLiteral")]
[JsonPropertyName("IntegerLiteral")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure AttrIntegerLiteral;

public JSONRCIntegerLiteralRecord() { }

public JSONRCIntegerLiteralRecord (RCIntegerLiteralRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIntegerLiteral = ConvertToRestWithoutDefaults(s.ssSTIntegerLiteral, new STIntegerLiteralStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure.FromStructure, config);
  } else {
AttrIntegerLiteral = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure.FromStructure(s.ssSTIntegerLiteral, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCIntegerLiteralRecord, RCIntegerLiteralRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCIntegerLiteralRecord s) => ToStructure(s, config);
}
public static RCIntegerLiteralRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCIntegerLiteralRecord obj, IBehaviorsConfiguration config) { 
  RCIntegerLiteralRecord s = new RCIntegerLiteralRecord();
  if(obj != null) {
  s.ssSTIntegerLiteral = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTIntegerLiteralStructure.ToStructure(obj.AttrIntegerLiteral, config);
  }
  return s;
}

public static Func<RCIntegerLiteralRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCIntegerLiteralRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCIntegerLiteralRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCIntegerLiteralRecord FromStructure(RCIntegerLiteralRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCIntegerLiteralRecord(s, config);
}

}


