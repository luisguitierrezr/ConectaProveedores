using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Text2Record
public class RESTRCTextRecord : AbstractRESTStructure<RCTextRecord> {
[JsonProperty("Text")]
public ssConectaProveedores.RestRecords.RESTSTTextStructure AttrText2;

public RESTRCTextRecord() { }

public RESTRCTextRecord (RCTextRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText2 = ConvertToRestWithoutDefaults(s.ssSTText2, new STTextStructure(), ssConectaProveedores.RestRecords.RESTSTTextStructure.FromStructure, config);
  } else {
AttrText2 = ssConectaProveedores.RestRecords.RESTSTTextStructure.FromStructure(s.ssSTText2, config);
  }
}

public static RCTextRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCTextRecord obj) { 
  RCTextRecord s = new RCTextRecord();
  if(obj != null) {
  s.ssSTText2 = ssConectaProveedores.RestRecords.RESTSTTextStructure.ToStructure(obj.AttrText2);
  }
  return s;
}

public static Func<RCTextRecord, ssConectaProveedores.RestRecords.RESTRCTextRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCTextRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCTextRecord FromStructure(RCTextRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCTextRecord(s, config);
}

}


