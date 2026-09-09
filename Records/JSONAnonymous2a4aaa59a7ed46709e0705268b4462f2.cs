using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextLiteralRecord
public class JSONRCTextLiteralRecord : AbstractRESTStructure<RCTextLiteralRecord> {
[JsonProperty("TextLiteral")]
[JsonPropertyName("TextLiteral")]
public ssConectaProveedores.RestRecords.JSONSTTextLiteralStructure AttrTextLiteral;

public JSONRCTextLiteralRecord() { }

public JSONRCTextLiteralRecord (RCTextLiteralRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTextLiteral = ConvertToRestWithoutDefaults(s.ssSTTextLiteral, new STTextLiteralStructure(), ssConectaProveedores.RestRecords.JSONSTTextLiteralStructure.FromStructure, config);
  } else {
AttrTextLiteral = ssConectaProveedores.RestRecords.JSONSTTextLiteralStructure.FromStructure(s.ssSTTextLiteral, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRCTextLiteralRecord, RCTextLiteralRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRCTextLiteralRecord s) => ToStructure(s, config);
}
public static RCTextLiteralRecord ToStructure(ssConectaProveedores.RestRecords.JSONRCTextLiteralRecord obj, IBehaviorsConfiguration config) { 
  RCTextLiteralRecord s = new RCTextLiteralRecord();
  if(obj != null) {
  s.ssSTTextLiteral = ssConectaProveedores.RestRecords.JSONSTTextLiteralStructure.ToStructure(obj.AttrTextLiteral, config);
  }
  return s;
}

public static Func<RCTextLiteralRecord, ssConectaProveedores.RestRecords.JSONRCTextLiteralRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCTextLiteralRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRCTextLiteralRecord FromStructure(RCTextLiteralRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRCTextLiteralRecord(s, config);
}

}


