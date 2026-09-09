using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_RM_COSMOZReq
public class RESTST_e629b825a45e94758f239d11120cb772Structure : AbstractRESTStructure<ST_e629b825a45e94758f239d11120cb772Structure> {
[JsonProperty("PI_HEADER")]
public ssConectaProveedores.RestRecords.RESTST_976925bffb49d1800d61d6274bd325dfStructure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
public RestList<ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure> AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
public RestList<ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure> AttrPI_ITEM_SM;

public RESTST_e629b825a45e94758f239d11120cb772Structure() { }

public RESTST_e629b825a45e94758f239d11120cb772Structure (ST_e629b825a45e94758f239d11120cb772Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_976925bffb49d1800d61d6274bd325dfStructure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToRestList<ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure>(ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToRestList<ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure>(ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure.FromStructureDelegate(config));
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_976925bffb49d1800d61d6274bd325dfStructure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToRestList<ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure>(ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToRestList<ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure>(ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure.FromStructureDelegate(config));
  }
}

public static ST_e629b825a45e94758f239d11120cb772Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_e629b825a45e94758f239d11120cb772Structure obj) { 
  ST_e629b825a45e94758f239d11120cb772Structure s = new ST_e629b825a45e94758f239d11120cb772Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.RESTST_976925bffb49d1800d61d6274bd325dfStructure.ToStructure(obj.AttrPI_HEADER);
  s.ssPI_ITEM_EM = RL_7467e78eb931d55f4ebaca0d0fac8a6d.FromRestList(obj.AttrPI_ITEM_EM, ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.ToStructure);
  s.ssPI_ITEM_SM = RL_6c5e26ef7403cc17d38ef0323d406754.FromRestList(obj.AttrPI_ITEM_SM, ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure.ToStructure);
  }
  return s;
}

public static Func<ST_e629b825a45e94758f239d11120cb772Structure, ssConectaProveedores.RestRecords.RESTST_e629b825a45e94758f239d11120cb772Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e629b825a45e94758f239d11120cb772Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_e629b825a45e94758f239d11120cb772Structure FromStructure(ST_e629b825a45e94758f239d11120cb772Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_e629b825a45e94758f239d11120cb772Structure(s, config);
}

}


