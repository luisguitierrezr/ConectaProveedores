using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_EM_SM_MO_COSMOZResp
public class JSONST_39fca1fbc45889b86a3f10d9a278767bStructure : AbstractRESTStructure<ST_39fca1fbc45889b86a3f10d9a278767bStructure> {
[JsonProperty("PO_DESCRIPCION_ERROR")]
[JsonPropertyName("PO_DESCRIPCION_ERROR")]
public string AttrPO_DESCRIPCION_ERROR;

[JsonProperty("PO_DOCUMENTO_MATERIAL_221")]
[JsonPropertyName("PO_DOCUMENTO_MATERIAL_221")]
public string AttrPO_DOCUMENTO_MATERIAL_221;

[JsonProperty("PO_DOCUMENTO_MATERIAL_415")]
[JsonPropertyName("PO_DOCUMENTO_MATERIAL_415")]
public string AttrPO_DOCUMENTO_MATERIAL_415;

[JsonProperty("PO_DOCUMENTO_MATERIAL_EM")]
[JsonPropertyName("PO_DOCUMENTO_MATERIAL_EM")]
public string AttrPO_DOCUMENTO_MATERIAL_EM;

[JsonProperty("PO_EJERCICIO_221")]
[JsonPropertyName("PO_EJERCICIO_221")]
public int? AttrPO_EJERCICIO_221;

[JsonProperty("PO_EJERCICIO_415")]
[JsonPropertyName("PO_EJERCICIO_415")]
public int? AttrPO_EJERCICIO_415;

[JsonProperty("PO_EJERCICIO_EM")]
[JsonPropertyName("PO_EJERCICIO_EM")]
public int? AttrPO_EJERCICIO_EM;

[JsonProperty("PO_NUMERO_ERROR")]
[JsonPropertyName("PO_NUMERO_ERROR")]
public int? AttrPO_NUMERO_ERROR;

[JsonProperty("PO_RESULTADO")]
[JsonPropertyName("PO_RESULTADO")]
public string AttrPO_RESULTADO;

public JSONST_39fca1fbc45889b86a3f10d9a278767bStructure() { }

public JSONST_39fca1fbc45889b86a3f10d9a278767bStructure (ST_39fca1fbc45889b86a3f10d9a278767bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_DESCRIPCION_ERROR = ConvertToRestWithoutDefaults(s.ssPO_DESCRIPCION_ERROR, "");
AttrPO_DOCUMENTO_MATERIAL_221 = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_221, "");
AttrPO_DOCUMENTO_MATERIAL_415 = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_415, "");
AttrPO_DOCUMENTO_MATERIAL_EM = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_EM, "");
AttrPO_EJERCICIO_221 = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_221, 0);
AttrPO_EJERCICIO_415 = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_415, 0);
AttrPO_EJERCICIO_EM = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_EM, 0);
AttrPO_NUMERO_ERROR = ConvertToRestWithoutDefaults(s.ssPO_NUMERO_ERROR, 0);
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
  } else {
AttrPO_DESCRIPCION_ERROR = s.ssPO_DESCRIPCION_ERROR;
AttrPO_DOCUMENTO_MATERIAL_221 = s.ssPO_DOCUMENTO_MATERIAL_221;
AttrPO_DOCUMENTO_MATERIAL_415 = s.ssPO_DOCUMENTO_MATERIAL_415;
AttrPO_DOCUMENTO_MATERIAL_EM = s.ssPO_DOCUMENTO_MATERIAL_EM;
AttrPO_EJERCICIO_221 = (int?) s.ssPO_EJERCICIO_221;
AttrPO_EJERCICIO_415 = (int?) s.ssPO_EJERCICIO_415;
AttrPO_EJERCICIO_EM = (int?) s.ssPO_EJERCICIO_EM;
AttrPO_NUMERO_ERROR = (int?) s.ssPO_NUMERO_ERROR;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure, ST_39fca1fbc45889b86a3f10d9a278767bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure s) => ToStructure(s, config);
}
public static ST_39fca1fbc45889b86a3f10d9a278767bStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure obj, IBehaviorsConfiguration config) { 
  ST_39fca1fbc45889b86a3f10d9a278767bStructure s = new ST_39fca1fbc45889b86a3f10d9a278767bStructure();
  if(obj != null) {
  s.ssPO_DESCRIPCION_ERROR = obj.AttrPO_DESCRIPCION_ERROR == null ? "" : obj.AttrPO_DESCRIPCION_ERROR;
  s.ssPO_DOCUMENTO_MATERIAL_221 = obj.AttrPO_DOCUMENTO_MATERIAL_221 == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_221;
  s.ssPO_DOCUMENTO_MATERIAL_415 = obj.AttrPO_DOCUMENTO_MATERIAL_415 == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_415;
  s.ssPO_DOCUMENTO_MATERIAL_EM = obj.AttrPO_DOCUMENTO_MATERIAL_EM == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_EM;
  s.ssPO_EJERCICIO_221 = obj.AttrPO_EJERCICIO_221 == null ? 0 : obj.AttrPO_EJERCICIO_221.Value;
  s.ssPO_EJERCICIO_415 = obj.AttrPO_EJERCICIO_415 == null ? 0 : obj.AttrPO_EJERCICIO_415.Value;
  s.ssPO_EJERCICIO_EM = obj.AttrPO_EJERCICIO_EM == null ? 0 : obj.AttrPO_EJERCICIO_EM.Value;
  s.ssPO_NUMERO_ERROR = obj.AttrPO_NUMERO_ERROR == null ? 0 : obj.AttrPO_NUMERO_ERROR.Value;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  }
  return s;
}

public static Func<ST_39fca1fbc45889b86a3f10d9a278767bStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_39fca1fbc45889b86a3f10d9a278767bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure FromStructure(ST_39fca1fbc45889b86a3f10d9a278767bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure(s, config);
}

}


