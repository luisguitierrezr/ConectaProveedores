using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_RETEN_PROVEEDORESResp
public class RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure : AbstractRESTStructure<ST_b29967856499aeaa8c796dc87fe4c6e8Structure> {
[JsonProperty("PO_RESPUESTA")]
public string AttrPO_RESPUESTA;

[JsonProperty("TI_RETENCIONES_Out")]
public RestList<ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure> AttrTI_RETENCIONES_Out;

public RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure() { }

public RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure (ST_b29967856499aeaa8c796dc87fe4c6e8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_RESPUESTA = ConvertToRestWithoutDefaults(s.ssPO_RESPUESTA, "");
AttrTI_RETENCIONES_Out = s.ssTI_RETENCIONES_Out.Length == 0 ? null : s.ssTI_RETENCIONES_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure>(ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure.FromStructureDelegate(config));
  } else {
AttrPO_RESPUESTA = s.ssPO_RESPUESTA;
AttrTI_RETENCIONES_Out = s.ssTI_RETENCIONES_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure>(ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure.FromStructureDelegate(config));
  }
}

public static ST_b29967856499aeaa8c796dc87fe4c6e8Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure obj) { 
  ST_b29967856499aeaa8c796dc87fe4c6e8Structure s = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();
  if(obj != null) {
  s.ssPO_RESPUESTA = obj.AttrPO_RESPUESTA == null ? "" : obj.AttrPO_RESPUESTA;
  s.ssTI_RETENCIONES_Out = RL_9290b8f2ad0d5ad8e2511aa8b7a9f6fd.FromRestList(obj.AttrTI_RETENCIONES_Out, ssConectaProveedores.RestRecords.RESTST_9fe56281b338f341e5bf9f16eeeff800Structure.ToStructure);
  }
  return s;
}

public static Func<ST_b29967856499aeaa8c796dc87fe4c6e8Structure, ssConectaProveedores.RestRecords.RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b29967856499aeaa8c796dc87fe4c6e8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure FromStructure(ST_b29967856499aeaa8c796dc87fe4c6e8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure(s, config);
}

}


