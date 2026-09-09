using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXFFIMF_0250_FI_CREATE_RELATResp
public class JSONST_31a464e509d55210f80b735594283423Structure : AbstractRESTStructure<ST_31a464e509d55210f80b735594283423Structure> {
[JsonProperty("EV_ERROR_MESSAGE")]
[JsonPropertyName("EV_ERROR_MESSAGE")]
public string AttrEV_ERROR_MESSAGE;

public JSONST_31a464e509d55210f80b735594283423Structure() { }

public JSONST_31a464e509d55210f80b735594283423Structure (ST_31a464e509d55210f80b735594283423Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEV_ERROR_MESSAGE = ConvertToRestWithoutDefaults(s.ssEV_ERROR_MESSAGE, "");
  } else {
AttrEV_ERROR_MESSAGE = s.ssEV_ERROR_MESSAGE;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure, ST_31a464e509d55210f80b735594283423Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure s) => ToStructure(s, config);
}
public static ST_31a464e509d55210f80b735594283423Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure obj, IBehaviorsConfiguration config) { 
  ST_31a464e509d55210f80b735594283423Structure s = new ST_31a464e509d55210f80b735594283423Structure();
  if(obj != null) {
  s.ssEV_ERROR_MESSAGE = obj.AttrEV_ERROR_MESSAGE == null ? "" : obj.AttrEV_ERROR_MESSAGE;
  }
  return s;
}

public static Func<ST_31a464e509d55210f80b735594283423Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_31a464e509d55210f80b735594283423Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure FromStructure(ST_31a464e509d55210f80b735594283423Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure(s, config);
}

}


