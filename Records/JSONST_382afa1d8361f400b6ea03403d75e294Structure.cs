using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_ESTD_CUENTA_COSMOZResp
public class JSONST_382afa1d8361f400b6ea03403d75e294Structure : AbstractRESTStructure<ST_382afa1d8361f400b6ea03403d75e294Structure> {
[JsonProperty("T_DAT_PROV_Out")]
[JsonPropertyName("T_DAT_PROV_Out")]
public ssConectaProveedores.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure[] AttrT_DAT_PROV_Out;

[JsonProperty("T_FACT_PEN_PAG_Out")]
[JsonPropertyName("T_FACT_PEN_PAG_Out")]
public ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure[] AttrT_FACT_PEN_PAG_Out;

[JsonProperty("T_FAC_PAG_Out")]
[JsonPropertyName("T_FAC_PAG_Out")]
public ssConectaProveedores.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure[] AttrT_FAC_PAG_Out;

[JsonProperty("T_FAC_PAG_CAB_Out")]
[JsonPropertyName("T_FAC_PAG_CAB_Out")]
public ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure[] AttrT_FAC_PAG_CAB_Out;

public JSONST_382afa1d8361f400b6ea03403d75e294Structure() { }

public JSONST_382afa1d8361f400b6ea03403d75e294Structure (ST_382afa1d8361f400b6ea03403d75e294Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_DAT_PROV_Out = s.ssT_DAT_PROV_Out.Length == 0 ? null : s.ssT_DAT_PROV_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure>(ssConectaProveedores.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure.FromStructureDelegate(config));
AttrT_FACT_PEN_PAG_Out = s.ssT_FACT_PEN_PAG_Out.Length == 0 ? null : s.ssT_FACT_PEN_PAG_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure>(ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure.FromStructureDelegate(config));
AttrT_FAC_PAG_Out = s.ssT_FAC_PAG_Out.Length == 0 ? null : s.ssT_FAC_PAG_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure>(ssConectaProveedores.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure.FromStructureDelegate(config));
AttrT_FAC_PAG_CAB_Out = s.ssT_FAC_PAG_CAB_Out.Length == 0 ? null : s.ssT_FAC_PAG_CAB_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure>(ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure.FromStructureDelegate(config));
  } else {
AttrT_DAT_PROV_Out = s.ssT_DAT_PROV_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure>(ssConectaProveedores.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure.FromStructureDelegate(config));
AttrT_FACT_PEN_PAG_Out = s.ssT_FACT_PEN_PAG_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure>(ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure.FromStructureDelegate(config));
AttrT_FAC_PAG_Out = s.ssT_FAC_PAG_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure>(ssConectaProveedores.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure.FromStructureDelegate(config));
AttrT_FAC_PAG_CAB_Out = s.ssT_FAC_PAG_CAB_Out.ToArray<ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure>(ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure, ST_382afa1d8361f400b6ea03403d75e294Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure s) => ToStructure(s, config);
}
public static ST_382afa1d8361f400b6ea03403d75e294Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure obj, IBehaviorsConfiguration config) { 
  ST_382afa1d8361f400b6ea03403d75e294Structure s = new ST_382afa1d8361f400b6ea03403d75e294Structure();
  if(obj != null) {
  s.ssT_DAT_PROV_Out = RL_467e1836e09ca6c5339502ff533527b0.ToList(obj.AttrT_DAT_PROV_Out, ssConectaProveedores.RestRecords.JSONST_4639a265770186863b3ecaeafd29fb96Structure.ToStructureDelegate(config));
  s.ssT_FACT_PEN_PAG_Out = RL_dd107351023827897d1e9d4f7246e1d9.ToList(obj.AttrT_FACT_PEN_PAG_Out, ssConectaProveedores.RestRecords.JSONST_9f44b824af1405b8fbe038a5a393bb86Structure.ToStructureDelegate(config));
  s.ssT_FAC_PAG_Out = RL_17d58cb91fc4c8d1157864a76942b9ff.ToList(obj.AttrT_FAC_PAG_Out, ssConectaProveedores.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure.ToStructureDelegate(config));
  s.ssT_FAC_PAG_CAB_Out = RL_c269559318987f7f9b248e427dd83abb.ToList(obj.AttrT_FAC_PAG_CAB_Out, ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_382afa1d8361f400b6ea03403d75e294Structure, ssConectaProveedores.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_382afa1d8361f400b6ea03403d75e294Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure FromStructure(ST_382afa1d8361f400b6ea03403d75e294Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure(s, config);
}

}


