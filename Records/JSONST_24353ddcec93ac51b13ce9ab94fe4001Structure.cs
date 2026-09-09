using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp
public class JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure : AbstractRESTStructure<ST_24353ddcec93ac51b13ce9ab94fe4001Structure> {
[JsonProperty("PO_RESPUESTA")]
[JsonPropertyName("PO_RESPUESTA")]
public string AttrPO_RESPUESTA;

[JsonProperty("TI_RETENCIONES_Out")]
[JsonPropertyName("TI_RETENCIONES_Out")]
public ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure[] AttrTI_RETENCIONES_Out;

public JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure() { }

public JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure (ST_24353ddcec93ac51b13ce9ab94fe4001Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_RESPUESTA = ConvertToRestWithoutDefaults(s.ssPO_RESPUESTA, "");
AttrTI_RETENCIONES_Out = s.ssTI_RETENCIONES_Out.Length == 0 ? null : s.ssTI_RETENCIONES_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure>(ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.FromStructureDelegate(config));
  } else {
AttrPO_RESPUESTA = s.ssPO_RESPUESTA;
AttrTI_RETENCIONES_Out = s.ssTI_RETENCIONES_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure>(ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure, ST_24353ddcec93ac51b13ce9ab94fe4001Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure s) => ToStructure(s, config);
}
public static ST_24353ddcec93ac51b13ce9ab94fe4001Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure obj, IBehaviorsConfiguration config) { 
  ST_24353ddcec93ac51b13ce9ab94fe4001Structure s = new ST_24353ddcec93ac51b13ce9ab94fe4001Structure();
  if(obj != null) {
  s.ssPO_RESPUESTA = obj.AttrPO_RESPUESTA == null ? "" : obj.AttrPO_RESPUESTA;
  s.ssTI_RETENCIONES_Out = RL_4b72a47efbb84d37cf5e3e0ffb46314d.ToList(obj.AttrTI_RETENCIONES_Out, ssConectaProveedores.RestRecords.JSONST_9e0fb2735a5b1c9875cbba9ab856e646Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_24353ddcec93ac51b13ce9ab94fe4001Structure, ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_24353ddcec93ac51b13ce9ab94fe4001Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure FromStructure(ST_24353ddcec93ac51b13ce9ab94fe4001Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure(s, config);
}

}


