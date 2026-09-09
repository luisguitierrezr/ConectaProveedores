using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Z01_READ_TEXTRespRecord
public class JSONRC_044a5f839fa7637f6ee7b728352fd227 : AbstractRESTStructure<RC_044a5f839fa7637f6ee7b728352fd227> {
[JsonProperty("Z01_READ_TEXTResp")]
[JsonPropertyName("Z01_READ_TEXTResp")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure AttrZ01_READ_TEXTResp;

public JSONRC_044a5f839fa7637f6ee7b728352fd227() { }

public JSONRC_044a5f839fa7637f6ee7b728352fd227 (RC_044a5f839fa7637f6ee7b728352fd227 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZ01_READ_TEXTResp = ConvertToRestWithoutDefaults(s.ssSTZ01_READ_TEXTResp, new ST_cc99e347274d861473c4d7d08b6332b6Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure.FromStructure, config);
  } else {
AttrZ01_READ_TEXTResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure.FromStructure(s.ssSTZ01_READ_TEXTResp, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_044a5f839fa7637f6ee7b728352fd227, RC_044a5f839fa7637f6ee7b728352fd227> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_044a5f839fa7637f6ee7b728352fd227 s) => ToStructure(s, config);
}
public static RC_044a5f839fa7637f6ee7b728352fd227 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_044a5f839fa7637f6ee7b728352fd227 obj, IBehaviorsConfiguration config) { 
  RC_044a5f839fa7637f6ee7b728352fd227 s = new RC_044a5f839fa7637f6ee7b728352fd227();
  if(obj != null) {
  s.ssSTZ01_READ_TEXTResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure.ToStructure(obj.AttrZ01_READ_TEXTResp, config);
  }
  return s;
}

public static Func<RC_044a5f839fa7637f6ee7b728352fd227, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_044a5f839fa7637f6ee7b728352fd227> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_044a5f839fa7637f6ee7b728352fd227 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_044a5f839fa7637f6ee7b728352fd227 FromStructure(RC_044a5f839fa7637f6ee7b728352fd227 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_044a5f839fa7637f6ee7b728352fd227(s, config);
}

}


