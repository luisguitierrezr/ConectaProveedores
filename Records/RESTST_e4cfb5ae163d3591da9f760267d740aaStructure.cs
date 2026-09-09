using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_Response_Struct
public class RESTST_e4cfb5ae163d3591da9f760267d740aaStructure : AbstractRESTStructure<ST_e4cfb5ae163d3591da9f760267d740aaStructure> {
[JsonProperty("PO_DESCRIPCION_ERROR")]
public string AttrPO_DESCRIPCION_ERROR;

[JsonProperty("PO_DOCUMENTO_MATERIAL")]
public string AttrPO_DOCUMENTO_MATERIAL;

[JsonProperty("PO_EJERCICIO")]
public string AttrPO_EJERCICIO;

[JsonProperty("PO_FOLIO_AGRUPADOR")]
public string AttrPO_FOLIO_AGRUPADOR;

[JsonProperty("PO_NUMERO_ERROR")]
public string AttrPO_NUMERO_ERROR;

[JsonProperty("PO_RESULTADO")]
public string AttrPO_RESULTADO;

public RESTST_e4cfb5ae163d3591da9f760267d740aaStructure() { }

public RESTST_e4cfb5ae163d3591da9f760267d740aaStructure (ST_e4cfb5ae163d3591da9f760267d740aaStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_DESCRIPCION_ERROR = ConvertToRestWithoutDefaults(s.ssPO_DESCRIPCION_ERROR, "");
AttrPO_DOCUMENTO_MATERIAL = ConvertToRestWithoutDefaults(s.ssPO_DOCUMENTO_MATERIAL, "");
AttrPO_EJERCICIO = ConvertToRestWithoutDefaults(s.ssPO_EJERCICIO, "");
AttrPO_FOLIO_AGRUPADOR = ConvertToRestWithoutDefaults(s.ssPO_FOLIO_AGRUPADOR, "");
AttrPO_NUMERO_ERROR = ConvertToRestWithoutDefaults(s.ssPO_NUMERO_ERROR, "");
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
  } else {
AttrPO_DESCRIPCION_ERROR = s.ssPO_DESCRIPCION_ERROR;
AttrPO_DOCUMENTO_MATERIAL = s.ssPO_DOCUMENTO_MATERIAL;
AttrPO_EJERCICIO = s.ssPO_EJERCICIO;
AttrPO_FOLIO_AGRUPADOR = s.ssPO_FOLIO_AGRUPADOR;
AttrPO_NUMERO_ERROR = s.ssPO_NUMERO_ERROR;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
  }
}

public static ST_e4cfb5ae163d3591da9f760267d740aaStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure obj) { 
  ST_e4cfb5ae163d3591da9f760267d740aaStructure s = new ST_e4cfb5ae163d3591da9f760267d740aaStructure();
  if(obj != null) {
  s.ssPO_DESCRIPCION_ERROR = obj.AttrPO_DESCRIPCION_ERROR == null ? "" : obj.AttrPO_DESCRIPCION_ERROR;
  s.ssPO_DOCUMENTO_MATERIAL = obj.AttrPO_DOCUMENTO_MATERIAL == null ? "" : obj.AttrPO_DOCUMENTO_MATERIAL;
  s.ssPO_EJERCICIO = obj.AttrPO_EJERCICIO == null ? "" : obj.AttrPO_EJERCICIO;
  s.ssPO_FOLIO_AGRUPADOR = obj.AttrPO_FOLIO_AGRUPADOR == null ? "" : obj.AttrPO_FOLIO_AGRUPADOR;
  s.ssPO_NUMERO_ERROR = obj.AttrPO_NUMERO_ERROR == null ? "" : obj.AttrPO_NUMERO_ERROR;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  }
  return s;
}

public static Func<ST_e4cfb5ae163d3591da9f760267d740aaStructure, ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e4cfb5ae163d3591da9f760267d740aaStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure FromStructure(ST_e4cfb5ae163d3591da9f760267d740aaStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure(s, config);
}

}


