using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationUUIDRecord
public class RESTRC_8ffee1344334d078ce2df096169df2fe : AbstractRESTStructure<RC_8ffee1344334d078ce2df096169df2fe> {
[JsonProperty("DocumentExtrationUUID")]
public ssConectaProveedores.RestRecords.RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure AttrDocumentExtrationUUID;

public RESTRC_8ffee1344334d078ce2df096169df2fe() { }

public RESTRC_8ffee1344334d078ce2df096169df2fe (RC_8ffee1344334d078ce2df096169df2fe s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationUUID = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationUUID, new ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure(), ssConectaProveedores.RestRecords.RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure.FromStructure, config);
  } else {
AttrDocumentExtrationUUID = ssConectaProveedores.RestRecords.RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure.FromStructure(s.ssSTDocumentExtrationUUID, config);
  }
}

public static RC_8ffee1344334d078ce2df096169df2fe ToStructure(ssConectaProveedores.RestRecords.RESTRC_8ffee1344334d078ce2df096169df2fe obj) { 
  RC_8ffee1344334d078ce2df096169df2fe s = new RC_8ffee1344334d078ce2df096169df2fe();
  if(obj != null) {
  s.ssSTDocumentExtrationUUID = ssConectaProveedores.RestRecords.RESTST_b0916350579ce1a3cbfa5c467f6cd7c9Structure.ToStructure(obj.AttrDocumentExtrationUUID);
  }
  return s;
}

public static Func<RC_8ffee1344334d078ce2df096169df2fe, ssConectaProveedores.RestRecords.RESTRC_8ffee1344334d078ce2df096169df2fe> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8ffee1344334d078ce2df096169df2fe s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8ffee1344334d078ce2df096169df2fe FromStructure(RC_8ffee1344334d078ce2df096169df2fe s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8ffee1344334d078ce2df096169df2fe(s, config);
}

}


