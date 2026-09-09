using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_Response_Struct
public class JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure : AbstractRESTStructure<ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure> {
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
public string AttrPO_EJERCICIO_221;

[JsonProperty("PO_EJERCICIO_415")]
[JsonPropertyName("PO_EJERCICIO_415")]
public string AttrPO_EJERCICIO_415;

[JsonProperty("PO_EJERCICIO_EM")]
[JsonPropertyName("PO_EJERCICIO_EM")]
public string AttrPO_EJERCICIO_EM;

[JsonProperty("PO_NUMERO_ERROR")]
[JsonPropertyName("PO_NUMERO_ERROR")]
public string AttrPO_NUMERO_ERROR;

[JsonProperty("PO_RESULTADO")]
[JsonPropertyName("PO_RESULTADO")]
public string AttrPO_RESULTADO;

public JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure() { }

public JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_DESCRIPCION_ERROR = ConvertToRestWithoutDefaults(s.ssPO_DESCRIPCION_ERROR, "");
AttrPO_DOCUMENTO_MATERIAL_221 = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_221, "");
AttrPO_DOCUMENTO_MATERIAL_415 = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_415, "");
AttrPO_DOCUMENTO_MATERIAL_EM = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL_EM, "");
AttrPO_EJERCICIO_221 = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_221, "");
AttrPO_EJERCICIO_415 = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_415, "");
AttrPO_EJERCICIO_EM = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO_EM, "");
AttrPO_NUMERO_ERROR = ConvertToRestWithoutDefaults(s.ssPO_NUMERO_ERROR, "");
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
  } else {
AttrPO_DESCRIPCION_ERROR = s.ssPO_DESCRIPCION_ERROR;
AttrPO_DOCUMENTO_MATERIAL_221 = s.ssPO_DOCUMENTO_MATERIAL_221;
AttrPO_DOCUMENTO_MATERIAL_415 = s.ssPO_DOCUMENTO_MATERIAL_415;
AttrPO_DOCUMENTO_MATERIAL_EM = s.ssPO_DOCUMENTO_MATERIAL_EM;
AttrPO_EJERCICIO_221 = s.ssPO_EJERCICIO_221;
AttrPO_EJERCICIO_415 = s.ssPO_EJERCICIO_415;
AttrPO_EJERCICIO_EM = s.ssPO_EJERCICIO_EM;
AttrPO_NUMERO_ERROR = s.ssPO_NUMERO_ERROR;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure, ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure s) => ToStructure(s, config);
}
public static ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure obj, IBehaviorsConfiguration config) { 
  ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure s = new ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure();
  if(obj != null) {
  s.ssPO_DESCRIPCION_ERROR = obj.AttrPO_DESCRIPCION_ERROR == null ? "" : obj.AttrPO_DESCRIPCION_ERROR;
  s.ssPO_DOCUMENTO_MATERIAL_221 = obj.AttrPO_DOCUMENTO_MATERIAL_221 == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_221;
  s.ssPO_DOCUMENTO_MATERIAL_415 = obj.AttrPO_DOCUMENTO_MATERIAL_415 == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_415;
  s.ssPO_DOCUMENTO_MATERIAL_EM = obj.AttrPO_DOCUMENTO_MATERIAL_EM == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL_EM;
  s.ssPO_EJERCICIO_221 = obj.AttrPO_EJERCICIO_221 == null ? "" : obj.AttrPO_EJERCICIO_221;
  s.ssPO_EJERCICIO_415 = obj.AttrPO_EJERCICIO_415 == null ? "" : obj.AttrPO_EJERCICIO_415;
  s.ssPO_EJERCICIO_EM = obj.AttrPO_EJERCICIO_EM == null ? "" : obj.AttrPO_EJERCICIO_EM;
  s.ssPO_NUMERO_ERROR = obj.AttrPO_NUMERO_ERROR == null ? "" : obj.AttrPO_NUMERO_ERROR;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  }
  return s;
}

public static Func<ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure, ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure FromStructure(ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure(s, config);
}

}


