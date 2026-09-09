using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZTC_GENERA_POLIZA_GRALResp
public class JSONST_35778da666b987b02b8cb887e66647a4Structure : AbstractRESTStructure<ST_35778da666b987b02b8cb887e66647a4Structure> {
[JsonProperty("PO_RESULTADO")]
[JsonPropertyName("PO_RESULTADO")]
public string AttrPO_RESULTADO;

[JsonProperty("TI_POS_Out")]
[JsonPropertyName("TI_POS_Out")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure[] AttrTI_POS_Out;

[JsonProperty("TO_RESULTADO_Out")]
[JsonPropertyName("TO_RESULTADO_Out")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure[] AttrTO_RESULTADO_Out;

public JSONST_35778da666b987b02b8cb887e66647a4Structure() { }

public JSONST_35778da666b987b02b8cb887e66647a4Structure (ST_35778da666b987b02b8cb887e66647a4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
AttrTI_POS_Out = s.ssTI_POS_Out.Length == 0 ? null : s.ssTI_POS_Out.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure.FromStructureDelegate(config));
AttrTO_RESULTADO_Out = s.ssTO_RESULTADO_Out.Length == 0 ? null : s.ssTO_RESULTADO_Out.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure.FromStructureDelegate(config));
  } else {
AttrPO_RESULTADO = s.ssPO_RESULTADO;
AttrTI_POS_Out = s.ssTI_POS_Out.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure.FromStructureDelegate(config));
AttrTO_RESULTADO_Out = s.ssTO_RESULTADO_Out.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure, ST_35778da666b987b02b8cb887e66647a4Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure s) => ToStructure(s, config);
}
public static ST_35778da666b987b02b8cb887e66647a4Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure obj, IBehaviorsConfiguration config) { 
  ST_35778da666b987b02b8cb887e66647a4Structure s = new ST_35778da666b987b02b8cb887e66647a4Structure();
  if(obj != null) {
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  s.ssTI_POS_Out = RL_480c1f8575ebe73e18b76b318e3cf1a3.ToList(obj.AttrTI_POS_Out, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure.ToStructureDelegate(config));
  s.ssTO_RESULTADO_Out = RL_48c08abdc43583e242f48c4245aed919.ToList(obj.AttrTO_RESULTADO_Out, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_35778da666b987b02b8cb887e66647a4Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_35778da666b987b02b8cb887e66647a4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure FromStructure(ST_35778da666b987b02b8cb887e66647a4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure(s, config);
}

}


