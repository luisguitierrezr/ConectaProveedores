using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioRecord
public class RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526 : AbstractRESTStructure<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526> {
[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

public RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526() { }

public RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526 (RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
  }
}

public static RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 ToStructure(ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526 obj) { 
  RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 s = new RC_cfeb2cf80ab683e7d9a9b5d02d9c9526();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  }
  return s;
}

public static Func<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526, ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526 FromStructure(RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cfeb2cf80ab683e7d9a9b5d02d9c9526(s, config);
}

}


