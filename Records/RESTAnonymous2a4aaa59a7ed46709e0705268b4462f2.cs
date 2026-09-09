using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextLiteralRecord
public class RESTRCTextLiteralRecord : AbstractRESTStructure<RCTextLiteralRecord> {
[JsonProperty("TextLiteral")]
public ssConectaProveedores.RestRecords.RESTSTTextLiteralStructure AttrTextLiteral;

public RESTRCTextLiteralRecord() { }

public RESTRCTextLiteralRecord (RCTextLiteralRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTextLiteral = ConvertToRestWithoutDefaults(s.ssSTTextLiteral, new STTextLiteralStructure(), ssConectaProveedores.RestRecords.RESTSTTextLiteralStructure.FromStructure, config);
  } else {
AttrTextLiteral = ssConectaProveedores.RestRecords.RESTSTTextLiteralStructure.FromStructure(s.ssSTTextLiteral, config);
  }
}

public static RCTextLiteralRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCTextLiteralRecord obj) { 
  RCTextLiteralRecord s = new RCTextLiteralRecord();
  if(obj != null) {
  s.ssSTTextLiteral = ssConectaProveedores.RestRecords.RESTSTTextLiteralStructure.ToStructure(obj.AttrTextLiteral);
  }
  return s;
}

public static Func<RCTextLiteralRecord, ssConectaProveedores.RestRecords.RESTRCTextLiteralRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCTextLiteralRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCTextLiteralRecord FromStructure(RCTextLiteralRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCTextLiteralRecord(s, config);
}

}


