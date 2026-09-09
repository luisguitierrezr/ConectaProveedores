using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_COSMOZResp
public class JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure : AbstractRESTStructure<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure> {
[JsonProperty("PO_DESCRIPCION_ERROR")]
[JsonPropertyName("PO_DESCRIPCION_ERROR")]
public string AttrPO_DESCRIPCION_ERROR;

[JsonProperty("PO_DOCUMENTO_MATERIAL")]
[JsonPropertyName("PO_DOCUMENTO_MATERIAL")]
public string AttrPO_DOCUMENTO_MATERIAL;

[JsonProperty("PO_EJERCICIO")]
[JsonPropertyName("PO_EJERCICIO")]
public string AttrPO_EJERCICIO;

[JsonProperty("PO_NUMERO_ERROR")]
[JsonPropertyName("PO_NUMERO_ERROR")]
public string AttrPO_NUMERO_ERROR;

[JsonProperty("PO_RESULTADO")]
[JsonPropertyName("PO_RESULTADO")]
public string AttrPO_RESULTADO;

public JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure() { }

public JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_DESCRIPCION_ERROR = ConvertToRestWithoutDefaults(s.ssPO_DESCRIPCION_ERROR, "");
AttrPO_DOCUMENTO_MATERIAL = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL, "");
AttrPO_EJERCICIO = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO, "");
AttrPO_NUMERO_ERROR = ConvertToRestWithoutDefaults(s.ssPO_NUMERO_ERROR, "");
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
  } else {
AttrPO_DESCRIPCION_ERROR = s.ssPO_DESCRIPCION_ERROR;
AttrPO_DOCUMENTO_MATERIAL = s.ssPO_DOCUMENTO_MATERIAL;
AttrPO_EJERCICIO = s.ssPO_EJERCICIO;
AttrPO_NUMERO_ERROR = s.ssPO_NUMERO_ERROR;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure, ST_9142fa8204e8ba0b33acb137d6acbbd3Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure s) => ToStructure(s, config);
}
public static ST_9142fa8204e8ba0b33acb137d6acbbd3Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure obj, IBehaviorsConfiguration config) { 
  ST_9142fa8204e8ba0b33acb137d6acbbd3Structure s = new ST_9142fa8204e8ba0b33acb137d6acbbd3Structure();
  if(obj != null) {
  s.ssPO_DESCRIPCION_ERROR = obj.AttrPO_DESCRIPCION_ERROR == null ? "" : obj.AttrPO_DESCRIPCION_ERROR;
  s.ssPO_DOCUMENTO_MATERIAL = obj.AttrPO_DOCUMENTO_MATERIAL == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL;
  s.ssPO_EJERCICIO = obj.AttrPO_EJERCICIO == null ? "" : obj.AttrPO_EJERCICIO;
  s.ssPO_NUMERO_ERROR = obj.AttrPO_NUMERO_ERROR == null ? "" : obj.AttrPO_NUMERO_ERROR;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  }
  return s;
}

public static Func<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure, ssConectaProveedores.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure FromStructure(ST_9142fa8204e8ba0b33acb137d6acbbd3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure(s, config);
}

}


