using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_COSMOZ_Response_Struct
public class JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure : AbstractRESTStructure<ST_5bf89f3eec4235b40802e9da4fd3e4afStructure> {
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

public JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure() { }

public JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure (ST_5bf89f3eec4235b40802e9da4fd3e4afStructure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure, ST_5bf89f3eec4235b40802e9da4fd3e4afStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure s) => ToStructure(s, config);
}
public static ST_5bf89f3eec4235b40802e9da4fd3e4afStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure obj, IBehaviorsConfiguration config) { 
  ST_5bf89f3eec4235b40802e9da4fd3e4afStructure s = new ST_5bf89f3eec4235b40802e9da4fd3e4afStructure();
  if(obj != null) {
  s.ssPO_DESCRIPCION_ERROR = obj.AttrPO_DESCRIPCION_ERROR == null ? "" : obj.AttrPO_DESCRIPCION_ERROR;
  s.ssPO_DOCUMENTO_MATERIAL = obj.AttrPO_DOCUMENTO_MATERIAL == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL;
  s.ssPO_EJERCICIO = obj.AttrPO_EJERCICIO == null ? "" : obj.AttrPO_EJERCICIO;
  s.ssPO_NUMERO_ERROR = obj.AttrPO_NUMERO_ERROR == null ? "" : obj.AttrPO_NUMERO_ERROR;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  }
  return s;
}

public static Func<ST_5bf89f3eec4235b40802e9da4fd3e4afStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5bf89f3eec4235b40802e9da4fd3e4afStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure FromStructure(ST_5bf89f3eec4235b40802e9da4fd3e4afStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5bf89f3eec4235b40802e9da4fd3e4afStructure(s, config);
}

}


