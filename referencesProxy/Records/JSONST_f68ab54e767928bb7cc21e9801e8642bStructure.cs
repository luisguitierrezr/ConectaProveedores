using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_VISUALIZAR_SAL_ANTReq
public class JSONST_f68ab54e767928bb7cc21e9801e8642bStructure : AbstractRESTStructure<ST_f68ab54e767928bb7cc21e9801e8642bStructure> {
[JsonProperty("PI_PEDIDO")]
[JsonPropertyName("PI_PEDIDO")]
public string AttrPI_PEDIDO;

public JSONST_f68ab54e767928bb7cc21e9801e8642bStructure() { }

public JSONST_f68ab54e767928bb7cc21e9801e8642bStructure (ST_f68ab54e767928bb7cc21e9801e8642bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_PEDIDO = ConvertToRestWithoutDefaults(s.ssPI_PEDIDO, "");
  } else {
AttrPI_PEDIDO = s.ssPI_PEDIDO;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure, ST_f68ab54e767928bb7cc21e9801e8642bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure s) => ToStructure(s, config);
}
public static ST_f68ab54e767928bb7cc21e9801e8642bStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure obj, IBehaviorsConfiguration config) { 
  ST_f68ab54e767928bb7cc21e9801e8642bStructure s = new ST_f68ab54e767928bb7cc21e9801e8642bStructure();
  if(obj != null) {
  s.ssPI_PEDIDO = obj.AttrPI_PEDIDO == null ? "" : obj.AttrPI_PEDIDO;
  }
  return s;
}

public static Func<ST_f68ab54e767928bb7cc21e9801e8642bStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f68ab54e767928bb7cc21e9801e8642bStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure FromStructure(ST_f68ab54e767928bb7cc21e9801e8642bStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure(s, config);
}

}


