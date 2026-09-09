using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationUUID
public class RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure : AbstractRESTStructure<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> {
[JsonProperty("UUID")]
public string AttrUUID;

public RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure() { }

public RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
  } else {
AttrUUID = s.ssUUID;
  }
}

public static ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure obj) { 
  ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s = new ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure();
  if(obj != null) {
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  }
  return s;
}

public static Func<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure, ssConectaProveedores.RestRecords.RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure FromStructure(ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure(s, config);
}

}


