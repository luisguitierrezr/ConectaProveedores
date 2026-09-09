using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZTC_GENERA_POLIZA_GRALResp
public class RESTST_35778da666b987b02b8cb887e66647a4Structure : AbstractRESTStructure<ST_35778da666b987b02b8cb887e66647a4Structure> {
[JsonProperty("PO_RESULTADO")]
public string AttrPO_RESULTADO;

[JsonProperty("TI_POS_Out")]
public RestList<ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure> AttrTI_POS_Out;

[JsonProperty("TO_RESULTADO_Out")]
public RestList<ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure> AttrTO_RESULTADO_Out;

public RESTST_35778da666b987b02b8cb887e66647a4Structure() { }

public RESTST_35778da666b987b02b8cb887e66647a4Structure (ST_35778da666b987b02b8cb887e66647a4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
AttrTI_POS_Out = s.ssTI_POS_Out.Length == 0 ? null : s.ssTI_POS_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure>(ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure.FromStructureDelegate(config));
AttrTO_RESULTADO_Out = s.ssTO_RESULTADO_Out.Length == 0 ? null : s.ssTO_RESULTADO_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure>(ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure.FromStructureDelegate(config));
  } else {
AttrPO_RESULTADO = s.ssPO_RESULTADO;
AttrTI_POS_Out = s.ssTI_POS_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure>(ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure.FromStructureDelegate(config));
AttrTO_RESULTADO_Out = s.ssTO_RESULTADO_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure>(ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure.FromStructureDelegate(config));
  }
}

public static ST_35778da666b987b02b8cb887e66647a4Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_35778da666b987b02b8cb887e66647a4Structure obj) { 
  ST_35778da666b987b02b8cb887e66647a4Structure s = new ST_35778da666b987b02b8cb887e66647a4Structure();
  if(obj != null) {
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  s.ssTI_POS_Out = RL_480c1f8575ebe73e18b76b318e3cf1a3.FromRestList(obj.AttrTI_POS_Out, ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure.ToStructure);
  s.ssTO_RESULTADO_Out = RL_48c08abdc43583e242f48c4245aed919.FromRestList(obj.AttrTO_RESULTADO_Out, ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure.ToStructure);
  }
  return s;
}

public static Func<ST_35778da666b987b02b8cb887e66647a4Structure, ssConectaProveedores.RestRecords.RESTST_35778da666b987b02b8cb887e66647a4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_35778da666b987b02b8cb887e66647a4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_35778da666b987b02b8cb887e66647a4Structure FromStructure(ST_35778da666b987b02b8cb887e66647a4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_35778da666b987b02b8cb887e66647a4Structure(s, config);
}

}


