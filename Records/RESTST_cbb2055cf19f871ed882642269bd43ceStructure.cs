using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_VISUALIZAR_SAL_ANTResp
public class RESTST_cbb2055cf19f871ed882642269bd43ceStructure : AbstractRESTStructure<ST_cbb2055cf19f871ed882642269bd43ceStructure> {
[JsonProperty("PO_EXITO_ERROR")]
public string AttrPO_EXITO_ERROR;

[JsonProperty("PO_IMP_ANT")]
public decimal? AttrPO_IMP_ANT;

[JsonProperty("PO_MENSAJE")]
public string AttrPO_MENSAJE;

[JsonProperty("PO_NUM_ERROR")]
public string AttrPO_NUM_ERROR;

[JsonProperty("PO_PEDIDO")]
public string AttrPO_PEDIDO;

public RESTST_cbb2055cf19f871ed882642269bd43ceStructure() { }

public RESTST_cbb2055cf19f871ed882642269bd43ceStructure (ST_cbb2055cf19f871ed882642269bd43ceStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPO_EXITO_ERROR = ConvertToRestWithoutDefaults(s.ssPO_EXITO_ERROR, "");
AttrPO_IMP_ANT = ConvertToRestWithoutDefaults(s.ssPO_IMP_ANT, 0.0M);
AttrPO_MENSAJE = ConvertToRestWithoutDefaults(s.ssPO_MENSAJE, "");
AttrPO_NUM_ERROR = ConvertToRestWithoutDefaults(s.ssPO_NUM_ERROR, "");
AttrPO_PEDIDO = ConvertToRestWithoutDefaults(s.ssPO_PEDIDO, "");
  } else {
AttrPO_EXITO_ERROR = s.ssPO_EXITO_ERROR;
AttrPO_IMP_ANT = (decimal?) s.ssPO_IMP_ANT;
AttrPO_MENSAJE = s.ssPO_MENSAJE;
AttrPO_NUM_ERROR = s.ssPO_NUM_ERROR;
AttrPO_PEDIDO = s.ssPO_PEDIDO;
  }
}

public static ST_cbb2055cf19f871ed882642269bd43ceStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure obj) { 
  ST_cbb2055cf19f871ed882642269bd43ceStructure s = new ST_cbb2055cf19f871ed882642269bd43ceStructure();
  if(obj != null) {
  s.ssPO_EXITO_ERROR = obj.AttrPO_EXITO_ERROR == null ? "" : obj.AttrPO_EXITO_ERROR;
  s.ssPO_IMP_ANT = obj.AttrPO_IMP_ANT == null ? 0.0M : obj.AttrPO_IMP_ANT.Value;
  s.ssPO_MENSAJE = obj.AttrPO_MENSAJE == null ? "" : obj.AttrPO_MENSAJE;
  s.ssPO_NUM_ERROR = obj.AttrPO_NUM_ERROR == null ? "" : obj.AttrPO_NUM_ERROR;
  s.ssPO_PEDIDO = obj.AttrPO_PEDIDO == null ? "" : obj.AttrPO_PEDIDO;
  }
  return s;
}

public static Func<ST_cbb2055cf19f871ed882642269bd43ceStructure, ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_cbb2055cf19f871ed882642269bd43ceStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure FromStructure(ST_cbb2055cf19f871ed882642269bd43ceStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure(s, config);
}

}


