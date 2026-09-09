using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_CECO_COSMOZ_Response_Struct
public class RESTST_b6cef14925f799164fc3167fe695008bStructure : AbstractRESTStructure<ST_b6cef14925f799164fc3167fe695008bStructure> {
[JsonProperty("PO_DESCRIPCION_ERROR")]
public string AttrPO_DESCRIPCION_ERROR;

[JsonProperty("PO_DOCUMENTO_MATERIAL_EM")]
public string AttrPO_DOCUMENTO_MATERIAL_EM;

[JsonProperty("PO_DOCUMENTO_MATERIAL_SM")]
public string AttrPO_DOCUMENTO_MATERIAL_SM;

[JsonProperty("PO_EJERCICIO_EM")]
public string AttrPO_EJERCICIO_EM;

[JsonProperty("PO_EJERCICIO_SM")]
public string AttrPO_EJERCICIO_SM;

[JsonProperty("PO_FOLIO_AGRUPADOS")]
public string AttrPO_FOLIO_AGRUPADOS;

[JsonProperty("PO_NUMERO_ERROR")]
public string AttrPO_NUMERO_ERROR;

[JsonProperty("PO_RESULTADO")]
public string AttrPO_RESULTADO;

public RESTST_b6cef14925f799164fc3167fe695008bStructure() { }

public RESTST_b6cef14925f799164fc3167fe695008bStructure (ST_b6cef14925f799164fc3167fe695008bStructure s, IBehaviorsConfiguration config) {
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

public static ST_b6cef14925f799164fc3167fe695008bStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure obj) { 
  ST_b6cef14925f799164fc3167fe695008bStructure s = new ST_b6cef14925f799164fc3167fe695008bStructure();
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

public static Func<ST_b6cef14925f799164fc3167fe695008bStructure, ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b6cef14925f799164fc3167fe695008bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure FromStructure(ST_b6cef14925f799164fc3167fe695008bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure(s, config);
}

}


