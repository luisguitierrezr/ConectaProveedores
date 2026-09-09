using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_GENERA_PEDIDO_PDFResp
public class JSONST_bc70ab3695876bb4315a9088f41998b7Structure : AbstractRESTStructure<ST_bc70ab3695876bb4315a9088f41998b7Structure> {
[JsonProperty("PO_DESCRIPCION_ERROR")]
[JsonPropertyName("PO_DESCRIPCION_ERROR")]
public string AttrPO_DESCRIPCION_ERROR;

[JsonProperty("PO_NUMERO_ERROR")]
[JsonPropertyName("PO_NUMERO_ERROR")]
public int? AttrPO_NUMERO_ERROR;

[JsonProperty("PO_PDF")]
[JsonPropertyName("PO_PDF")]
public string AttrPO_PDF;

[JsonProperty("PO_RESULTADO")]
[JsonPropertyName("PO_RESULTADO")]
public string AttrPO_RESULTADO;

public JSONST_bc70ab3695876bb4315a9088f41998b7Structure() { }

public JSONST_bc70ab3695876bb4315a9088f41998b7Structure (ST_bc70ab3695876bb4315a9088f41998b7Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_DESCRIPCION_ERROR = ConvertToRestWithoutDefaults(s.ssPO_DESCRIPCION_ERROR, "");
AttrPO_NUMERO_ERROR = ConvertToRestWithoutDefaults(s.ssPO_NUMERO_ERROR, 0);
AttrPO_PDF = ConvertToRestWithoutDefaults(s.ssPO_PDF, "");
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
  } else {
AttrPO_DESCRIPCION_ERROR = s.ssPO_DESCRIPCION_ERROR;
AttrPO_NUMERO_ERROR = (int?) s.ssPO_NUMERO_ERROR;
AttrPO_PDF = s.ssPO_PDF;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure, ST_bc70ab3695876bb4315a9088f41998b7Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure s) => ToStructure(s, config);
}
public static ST_bc70ab3695876bb4315a9088f41998b7Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure obj, IBehaviorsConfiguration config) { 
  ST_bc70ab3695876bb4315a9088f41998b7Structure s = new ST_bc70ab3695876bb4315a9088f41998b7Structure();
  if(obj != null) {
  s.ssPO_DESCRIPCION_ERROR = obj.AttrPO_DESCRIPCION_ERROR == null ? "" : obj.AttrPO_DESCRIPCION_ERROR;
  s.ssPO_NUMERO_ERROR = obj.AttrPO_NUMERO_ERROR == null ? 0 : obj.AttrPO_NUMERO_ERROR.Value;
  s.ssPO_PDF = obj.AttrPO_PDF == null ? "" : obj.AttrPO_PDF;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  }
  return s;
}

public static Func<ST_bc70ab3695876bb4315a9088f41998b7Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_bc70ab3695876bb4315a9088f41998b7Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure FromStructure(ST_bc70ab3695876bb4315a9088f41998b7Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure(s, config);
}

}


