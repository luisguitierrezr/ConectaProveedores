using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_EM_SM_RM_COSMOZResp
public class JSONST_b413183d4662c427b8a9318270b9732cStructure : AbstractRESTStructure<ST_b413183d4662c427b8a9318270b9732cStructure> {
[JsonProperty("PO_DESCRIPCION_ERROR")]
[JsonPropertyName("PO_DESCRIPCION_ERROR")]
public string AttrPO_DESCRIPCION_ERROR;

[JsonProperty("PO_DOCUMENTO_MATERIAL")]
[JsonPropertyName("PO_DOCUMENTO_MATERIAL")]
public string AttrPO_DOCUMENTO_MATERIAL;

[JsonProperty("PO_EJERCICIO")]
[JsonPropertyName("PO_EJERCICIO")]
public int? AttrPO_EJERCICIO;

[JsonProperty("PO_FOLIO_AGRUPADOR")]
[JsonPropertyName("PO_FOLIO_AGRUPADOR")]
public string AttrPO_FOLIO_AGRUPADOR;

[JsonProperty("PO_NUMERO_ERROR")]
[JsonPropertyName("PO_NUMERO_ERROR")]
public int? AttrPO_NUMERO_ERROR;

[JsonProperty("PO_RESULTADO")]
[JsonPropertyName("PO_RESULTADO")]
public string AttrPO_RESULTADO;

public JSONST_b413183d4662c427b8a9318270b9732cStructure() { }

public JSONST_b413183d4662c427b8a9318270b9732cStructure (ST_b413183d4662c427b8a9318270b9732cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_DESCRIPCION_ERROR = ConvertToRestWithoutDefaults(s.ssPO_DESCRIPCION_ERROR, "");
AttrPO_DOCUMENTO_MATERIAL = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL, "");
AttrPO_EJERCICIO = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO, 0);
AttrPO_FOLIO_AGRUPADOR = ConvertToRestWithoutDefaults(s.ssPO_FOLIO_AGRUPADOR, "");
AttrPO_NUMERO_ERROR = ConvertToRestWithoutDefaults(s.ssPO_NUMERO_ERROR, 0);
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
  } else {
AttrPO_DESCRIPCION_ERROR = s.ssPO_DESCRIPCION_ERROR;
AttrPO_DOCUMENTO_MATERIAL = s.ssPO_DOCUMENTO_MATERIAL;
AttrPO_EJERCICIO = (int?) s.ssPO_EJERCICIO;
AttrPO_FOLIO_AGRUPADOR = s.ssPO_FOLIO_AGRUPADOR;
AttrPO_NUMERO_ERROR = (int?) s.ssPO_NUMERO_ERROR;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure, ST_b413183d4662c427b8a9318270b9732cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure s) => ToStructure(s, config);
}
public static ST_b413183d4662c427b8a9318270b9732cStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure obj, IBehaviorsConfiguration config) { 
  ST_b413183d4662c427b8a9318270b9732cStructure s = new ST_b413183d4662c427b8a9318270b9732cStructure();
  if(obj != null) {
  s.ssPO_DESCRIPCION_ERROR = obj.AttrPO_DESCRIPCION_ERROR == null ? "" : obj.AttrPO_DESCRIPCION_ERROR;
  s.ssPO_DOCUMENTO_MATERIAL = obj.AttrPO_DOCUMENTO_MATERIAL == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL;
  s.ssPO_EJERCICIO = obj.AttrPO_EJERCICIO == null ? 0 : obj.AttrPO_EJERCICIO.Value;
  s.ssPO_FOLIO_AGRUPADOR = obj.AttrPO_FOLIO_AGRUPADOR == null ? "" : obj.AttrPO_FOLIO_AGRUPADOR;
  s.ssPO_NUMERO_ERROR = obj.AttrPO_NUMERO_ERROR == null ? 0 : obj.AttrPO_NUMERO_ERROR.Value;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  }
  return s;
}

public static Func<ST_b413183d4662c427b8a9318270b9732cStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b413183d4662c427b8a9318270b9732cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure FromStructure(ST_b413183d4662c427b8a9318270b9732cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure(s, config);
}

}


