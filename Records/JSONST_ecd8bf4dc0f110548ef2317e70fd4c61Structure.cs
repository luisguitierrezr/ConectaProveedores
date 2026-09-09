using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_CECO_COSMOZREsp
public class JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure : AbstractRESTStructure<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> {
[JsonProperty("PO_DESCRIPCION_ERROR")]
[JsonPropertyName("PO_DESCRIPCION_ERROR")]
public string AttrPO_DESCRIPCION_ERROR;

[JsonProperty("PO_DOCUMENTO_MATERIAL_EM")]
[JsonPropertyName("PO_DOCUMENTO_MATERIAL_EM")]
public string AttrPO_DOCUMENTO_MATERIAL_EM;

[JsonProperty("PO_DOCUMENTO_MATERIAL_SM")]
[JsonPropertyName("PO_DOCUMENTO_MATERIAL_SM")]
public string AttrPO_DOCUMENTO_MATERIAL_SM;

[JsonProperty("PO_EJERCICIO_EM")]
[JsonPropertyName("PO_EJERCICIO_EM")]
public string AttrPO_EJERCICIO_EM;

[JsonProperty("PO_EJERCICIO_SM")]
[JsonPropertyName("PO_EJERCICIO_SM")]
public string AttrPO_EJERCICIO_SM;

[JsonProperty("PO_FOLIO_AGRUPADOS")]
[JsonPropertyName("PO_FOLIO_AGRUPADOS")]
public string AttrPO_FOLIO_AGRUPADOS;

[JsonProperty("PO_NUMERO_ERROR")]
[JsonPropertyName("PO_NUMERO_ERROR")]
public string AttrPO_NUMERO_ERROR;

[JsonProperty("PO_RESULTADO")]
[JsonPropertyName("PO_RESULTADO")]
public string AttrPO_RESULTADO;

public JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure() { }

public JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_DESCRIPCION_ERROR = ConvertToRestWithoutDefaults(s.ssPO_DESCRIPCION_ERROR, "");
AttrPO_DOCUMENTO_MATERIAL_EM = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_EM, "");
AttrPO_DOCUMENTO_MATERIAL_SM = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_SM, "");
AttrPO_EJERCICIO_EM = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_EM, "");
AttrPO_EJERCICIO_SM = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_SM, "");
AttrPO_FOLIO_AGRUPADOS = ConvertToRestWithoutDefaults(s.ssPO_FOLIO_AGRUPADOS, "");
AttrPO_NUMERO_ERROR = ConvertToRestWithoutDefaults(s.ssPO_NUMERO_ERROR, "");
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
  } else {
AttrPO_DESCRIPCION_ERROR = s.ssPO_DESCRIPCION_ERROR;
AttrPO_DOCUMENTO_MATERIAL_EM = s.ssPO_DOCUMENTO_MATERIAL_EM;
AttrPO_DOCUMENTO_MATERIAL_SM = s.ssPO_DOCUMENTO_MATERIAL_SM;
AttrPO_EJERCICIO_EM = s.ssPO_EJERCICIO_EM;
AttrPO_EJERCICIO_SM = s.ssPO_EJERCICIO_SM;
AttrPO_FOLIO_AGRUPADOS = s.ssPO_FOLIO_AGRUPADOS;
AttrPO_NUMERO_ERROR = s.ssPO_NUMERO_ERROR;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure, ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure s) => ToStructure(s, config);
}
public static ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure obj, IBehaviorsConfiguration config) { 
  ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure s = new ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure();
  if(obj != null) {
  s.ssPO_DESCRIPCION_ERROR = obj.AttrPO_DESCRIPCION_ERROR == null ? "" : obj.AttrPO_DESCRIPCION_ERROR;
  s.ssPO_DOCUMENTO_MATERIAL_EM = obj.AttrPO_DOCUMENTO_MATERIAL_EM == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_EM;
  s.ssPO_DOCUMENTO_MATERIAL_SM = obj.AttrPO_DOCUMENTO_MATERIAL_SM == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_SM;
  s.ssPO_EJERCICIO_EM = obj.AttrPO_EJERCICIO_EM == null ? "" : obj.AttrPO_EJERCICIO_EM;
  s.ssPO_EJERCICIO_SM = obj.AttrPO_EJERCICIO_SM == null ? "" : obj.AttrPO_EJERCICIO_SM;
  s.ssPO_FOLIO_AGRUPADOS = obj.AttrPO_FOLIO_AGRUPADOS == null ? "" : obj.AttrPO_FOLIO_AGRUPADOS;
  s.ssPO_NUMERO_ERROR = obj.AttrPO_NUMERO_ERROR == null ? "" : obj.AttrPO_NUMERO_ERROR;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  }
  return s;
}

public static Func<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure, ssConectaProveedores.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure FromStructure(ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure(s, config);
}

}


