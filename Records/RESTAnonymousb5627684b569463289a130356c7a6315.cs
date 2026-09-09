using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// File2Record
public class RESTRCFileRecord : AbstractRESTStructure<RCFileRecord> {
[JsonProperty("File")]
public ssConectaProveedores.RestRecords.RESTSTFileStructure AttrFile2;

public RESTRCFileRecord() { }

public RESTRCFileRecord (RCFileRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFile2 = ConvertToRestWithoutDefaults(s.ssSTFile2, new STFileStructure(), ssConectaProveedores.RestRecords.RESTSTFileStructure.FromStructure, config);
  } else {
AttrFile2 = ssConectaProveedores.RestRecords.RESTSTFileStructure.FromStructure(s.ssSTFile2, config);
  }
}

public static RCFileRecord ToStructure(ssConectaProveedores.RestRecords.RESTRCFileRecord obj) { 
  RCFileRecord s = new RCFileRecord();
  if(obj != null) {
  s.ssSTFile2 = ssConectaProveedores.RestRecords.RESTSTFileStructure.ToStructure(obj.AttrFile2);
  }
  return s;
}

public static Func<RCFileRecord, ssConectaProveedores.RestRecords.RESTRCFileRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RCFileRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRCFileRecord FromStructure(RCFileRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRCFileRecord(s, config);
}

}


