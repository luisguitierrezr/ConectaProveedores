using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// IntegerLiteralRecord
public class RESTRCIntegerLiteralRecord : AbstractRESTStructure<RCIntegerLiteralRecord> {
[JsonProperty("IntegerLiteral")]
public ssConectaProveedores.RestRecords.RESTSTIntegerLiteralStructure AttrIntegerLiteral;

public RESTRCIntegerLiteralRecord() { }

public RESTRCIntegerLiteralRecord (RCIntegerLiteralRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIntegerLiteral = ConvertToRestWithoutDefaults(s.ssSTIntegerLiteral, new STIntegerLiteralStructure(), ssConectaProveedores.RestRecords.RESTSTIntegerLiteralStructure.FromStructure, config);
  } else {
AttrIntegerLiteral = ssConectaProveedores.RestRecords.RESTSTIntegerLiteralStructure.FromStructure(s.ssSTIntegerLiteral, config);
  }
}

public static RCIntegerLiteralRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCIntegerLiteralRecord obj) { 
  RCIntegerLiteralRecord s = new RCIntegerLiteralRecord();
  if(obj != null) {
  s.ssSTIntegerLiteral = ssConectaProveedores.RestRecords.RESTSTIntegerLiteralStructure.ToStructure(obj.AttrIntegerLiteral);
  }
  return s;
}

public static Func<RCIntegerLiteralRecord, ssConectaProveedores.RestRecords.RESTRCIntegerLiteralRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCIntegerLiteralRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCIntegerLiteralRecord FromStructure(RCIntegerLiteralRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCIntegerLiteralRecord(s, config);
}

}


