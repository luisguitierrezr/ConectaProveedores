using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationUUIDRecord
public class JSONRC_8ffee1344334d078ce2df096169df2fe : AbstractRESTStructure<RC_8ffee1344334d078ce2df096169df2fe> {
[JsonProperty("DocumentExtrationUUID")]
[JsonPropertyName("DocumentExtrationUUID")]
public ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure AttrDocumentExtrationUUID;

public JSONRC_8ffee1344334d078ce2df096169df2fe() { }

public JSONRC_8ffee1344334d078ce2df096169df2fe (RC_8ffee1344334d078ce2df096169df2fe s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationUUID = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationUUID, new ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure(), ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure.FromStructure, config);
  } else {
AttrDocumentExtrationUUID = ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure.FromStructure(s.ssSTDocumentExtrationUUID, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8ffee1344334d078ce2df096169df2fe, RC_8ffee1344334d078ce2df096169df2fe> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8ffee1344334d078ce2df096169df2fe s) => ToStructure(s, config);
}
public static RC_8ffee1344334d078ce2df096169df2fe ToStructure(ssConectaProveedores.RestRecords.JSONRC_8ffee1344334d078ce2df096169df2fe obj, IBehaviorsConfiguration config) { 
  RC_8ffee1344334d078ce2df096169df2fe s = new RC_8ffee1344334d078ce2df096169df2fe();
  if(obj != null) {
  s.ssSTDocumentExtrationUUID = ssConectaProveedores.RestRecords.JSONST_b0916350579ce1a3cbfa5c467f6cd7c9Structure.ToStructure(obj.AttrDocumentExtrationUUID, config);
  }
  return s;
}

public static Func<RC_8ffee1344334d078ce2df096169df2fe, ssConectaProveedores.RestRecords.JSONRC_8ffee1344334d078ce2df096169df2fe> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8ffee1344334d078ce2df096169df2fe s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8ffee1344334d078ce2df096169df2fe FromStructure(RC_8ffee1344334d078ce2df096169df2fe s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8ffee1344334d078ce2df096169df2fe(s, config);
}

}


