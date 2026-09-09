using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TextLiteralRecord
public class JSONRCTextLiteralRecord : AbstractRESTStructure<RCTextLiteralRecord> {
[JsonProperty("TextLiteral")]
[JsonPropertyName("TextLiteral")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure AttrTextLiteral;

public JSONRCTextLiteralRecord() { }

public JSONRCTextLiteralRecord (RCTextLiteralRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTextLiteral = ConvertToRestWithoutDefaults(s.ssSTTextLiteral, new STTextLiteralStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure.FromStructure, config);
  } else {
AttrTextLiteral = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure.FromStructure(s.ssSTTextLiteral, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextLiteralRecord, RCTextLiteralRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextLiteralRecord s) => ToStructure(s, config);
}
public static RCTextLiteralRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextLiteralRecord obj, IBehaviorsConfiguration config) { 
  RCTextLiteralRecord s = new RCTextLiteralRecord();
  if(obj != null) {
  s.ssSTTextLiteral = ssConectaProveedores.ReferencesProxy.RestRecords.JSONSTTextLiteralStructure.ToStructure(obj.AttrTextLiteral, config);
  }
  return s;
}

public static Func<RCTextLiteralRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextLiteralRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCTextLiteralRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextLiteralRecord FromStructure(RCTextLiteralRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRCTextLiteralRecord(s, config);
}

}


