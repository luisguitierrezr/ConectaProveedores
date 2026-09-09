using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_RETEN_PROVEEDORESReq
public class RESTST_90ad61a7b6c3b8dc6db7b1d64798236bStructure : AbstractRESTStructure<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> {
[JsonProperty("PI_BUKRS")]
public string AttrPI_BUKRS;

[JsonProperty("PI_VENDORNO")]
public string AttrPI_VENDORNO;

[JsonProperty("TI_RETENCIONES_In")]
public RestList<ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure> AttrTI_RETENCIONES_In;

public RESTST_90ad61a7b6c3b8dc6db7b1d64798236bStructure() { }

public RESTST_90ad61a7b6c3b8dc6db7b1d64798236bStructure (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_BUKRS = s.ssPI_BUKRS;
AttrPI_VENDORNO = s.ssPI_VENDORNO;
AttrTI_RETENCIONES_In = s.ssTI_RETENCIONES_In.Length == 0 ? null : s.ssTI_RETENCIONES_In.ToRestList<ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure>(ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure.FromStructureDelegate(config));
  } else {
AttrPI_BUKRS = s.ssPI_BUKRS;
AttrPI_VENDORNO = s.ssPI_VENDORNO;
AttrTI_RETENCIONES_In = s.ssTI_RETENCIONES_In.ToRestList<ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure>(ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure.FromStructureDelegate(config));
  }
}

public static ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_90ad61a7b6c3b8dc6db7b1d64798236bStructure obj) { 
  ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s = new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure();
  if(obj != null) {
  s.ssPI_BUKRS = obj.AttrPI_BUKRS == null ? "" : obj.AttrPI_BUKRS;
  s.ssPI_VENDORNO = obj.AttrPI_VENDORNO == null ? "" : obj.AttrPI_VENDORNO;
  s.ssTI_RETENCIONES_In = RL_725bda958021cd78431a036d1def2d7e.FromRestList(obj.AttrTI_RETENCIONES_In, ssConectaProveedores.RestRecords.RESTST_57edec30140ebe846267970253841d11Structure.ToStructure);
  }
  return s;
}

public static Func<ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure, ssConectaProveedores.RestRecords.RESTST_90ad61a7b6c3b8dc6db7b1d64798236bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_90ad61a7b6c3b8dc6db7b1d64798236bStructure FromStructure(ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(s, config);
}

}


