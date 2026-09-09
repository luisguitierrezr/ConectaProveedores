using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_RETEN_PROVEEDORESReq
public class JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure : AbstractRESTStructure<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> {
[JsonProperty("PI_BUKRS")]
[JsonPropertyName("PI_BUKRS")]
public string AttrPI_BUKRS;

[JsonProperty("PI_VENDORNO")]
[JsonPropertyName("PI_VENDORNO")]
public string AttrPI_VENDORNO;

[JsonProperty("TI_RETENCIONES_In")]
[JsonPropertyName("TI_RETENCIONES_In")]
public ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure[] AttrTI_RETENCIONES_In;

public JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure() { }

public JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_BUKRS = s.ssPI_BUKRS;
AttrPI_VENDORNO = s.ssPI_VENDORNO;
AttrTI_RETENCIONES_In = s.ssTI_RETENCIONES_In.Length == 0 ? null : s.ssTI_RETENCIONES_In.ToArray<ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure>(ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure.FromStructureDelegate(config));
  } else {
AttrPI_BUKRS = s.ssPI_BUKRS;
AttrPI_VENDORNO = s.ssPI_VENDORNO;
AttrTI_RETENCIONES_In = s.ssTI_RETENCIONES_In.ToArray<ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure>(ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure, ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s) => ToStructure(s, config);
}
public static ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure obj, IBehaviorsConfiguration config) { 
  ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s = new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure();
  if(obj != null) {
  s.ssPI_BUKRS = obj.AttrPI_BUKRS == null ? "" : obj.AttrPI_BUKRS;
  s.ssPI_VENDORNO = obj.AttrPI_VENDORNO == null ? "" : obj.AttrPI_VENDORNO;
  s.ssTI_RETENCIONES_In = RL_725bda958021cd78431a036d1def2d7e.ToList(obj.AttrTI_RETENCIONES_In, ssConectaProveedores.RestRecords.JSONST_57edec30140ebe846267970253841d11Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure, ssConectaProveedores.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure FromStructure(ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(s, config);
}

}


