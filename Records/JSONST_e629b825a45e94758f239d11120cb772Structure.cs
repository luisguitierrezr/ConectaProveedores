using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_RM_COSMOZReq
public class JSONST_e629b825a45e94758f239d11120cb772Structure : AbstractRESTStructure<ST_e629b825a45e94758f239d11120cb772Structure> {
[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.RestRecords.JSONST_976925bffb49d1800d61d6274bd325dfStructure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
[JsonPropertyName("PI_ITEM_EM")]
public ssConectaProveedores.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure[] AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
[JsonPropertyName("PI_ITEM_SM")]
public ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure[] AttrPI_ITEM_SM;

public JSONST_e629b825a45e94758f239d11120cb772Structure() { }

public JSONST_e629b825a45e94758f239d11120cb772Structure (ST_e629b825a45e94758f239d11120cb772Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ssConectaProveedores.RestRecords.JSONST_976925bffb49d1800d61d6274bd325dfStructure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToArray<ssConectaProveedores.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure>(ssConectaProveedores.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToArray<ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure>(ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure.FromStructureDelegate(config));
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.JSONST_976925bffb49d1800d61d6274bd325dfStructure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToArray<ssConectaProveedores.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure>(ssConectaProveedores.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToArray<ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure>(ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure, ST_e629b825a45e94758f239d11120cb772Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure s) => ToStructure(s, config);
}
public static ST_e629b825a45e94758f239d11120cb772Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure obj, IBehaviorsConfiguration config) { 
  ST_e629b825a45e94758f239d11120cb772Structure s = new ST_e629b825a45e94758f239d11120cb772Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.JSONST_976925bffb49d1800d61d6274bd325dfStructure.ToStructure(obj.AttrPI_HEADER, config);
  s.ssPI_ITEM_EM = RL_7467e78eb931d55f4ebaca0d0fac8a6d.ToList(obj.AttrPI_ITEM_EM, ssConectaProveedores.RestRecords.JSONST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.ToStructureDelegate(config));
  s.ssPI_ITEM_SM = RL_6c5e26ef7403cc17d38ef0323d406754.ToList(obj.AttrPI_ITEM_SM, ssConectaProveedores.RestRecords.JSONST_21ada127931bc47aabf2d9a5964b17feStructure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_e629b825a45e94758f239d11120cb772Structure, ssConectaProveedores.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e629b825a45e94758f239d11120cb772Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure FromStructure(ST_e629b825a45e94758f239d11120cb772Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure(s, config);
}

}


