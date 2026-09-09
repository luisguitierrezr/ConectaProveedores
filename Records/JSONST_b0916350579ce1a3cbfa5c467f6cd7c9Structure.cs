using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationUUID
public class JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure : AbstractRESTStructure<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> {
[JsonProperty("UUID")]
[JsonPropertyName("UUID")]
public string AttrUUID;

public JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure() { }

public JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
  } else {
AttrUUID = s.ssUUID;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure, ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s) => ToStructure(s, config);
}
public static ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure obj, IBehaviorsConfiguration config) { 
  ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s = new ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure();
  if(obj != null) {
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  }
  return s;
}

public static Func<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure, ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure FromStructure(ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure(s, config);
}

}


