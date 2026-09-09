using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TO_RESULTADO_In
public class JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure : AbstractRESTStructure<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> {
[JsonProperty("ID_POLIZA")]
[JsonPropertyName("ID_POLIZA")]
public string AttrID_POLIZA;

[JsonProperty("CODIGO")]
[JsonPropertyName("CODIGO")]
public string AttrCODIGO;

[JsonProperty("TEXTO")]
[JsonPropertyName("TEXTO")]
public string AttrTEXTO;

public JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure() { }

public JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrID_POLIZA = ConvertToRestWithoutDefaults(s.ssID_POLIZA, "");
AttrCODIGO = ConvertToRestWithoutDefaults(s.ssCODIGO, "");
AttrTEXTO = ConvertToRestWithoutDefaults(s.ssTEXTO, "");
  } else {
AttrID_POLIZA = s.ssID_POLIZA;
AttrCODIGO = s.ssCODIGO;
AttrTEXTO = s.ssTEXTO;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure, ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s) => ToStructure(s, config);
}
public static ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure obj, IBehaviorsConfiguration config) { 
  ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s = new ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure();
  if(obj != null) {
  s.ssID_POLIZA = obj.AttrID_POLIZA == null ? "" : obj.AttrID_POLIZA;
  s.ssCODIGO = obj.AttrCODIGO == null ? "" : obj.AttrCODIGO;
  s.ssTEXTO = obj.AttrTEXTO == null ? "" : obj.AttrTEXTO;
  }
  return s;
}

public static Func<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure FromStructure(ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1881d7eeaa3bae99e7aa7a6ecb977980Structure(s, config);
}

}


