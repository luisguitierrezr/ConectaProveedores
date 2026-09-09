using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TO_RESULTADO_In
public class RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure : AbstractRESTStructure<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> {
[JsonProperty("ID_POLIZA")]
public string AttrID_POLIZA;

[JsonProperty("CODIGO")]
public string AttrCODIGO;

[JsonProperty("TEXTO")]
public string AttrTEXTO;

public RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure() { }

public RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s, IBehaviorsConfiguration config) {
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

public static ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure obj) { 
  ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s = new ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure();
  if(obj != null) {
  s.ssID_POLIZA = obj.AttrID_POLIZA == null ? "" : obj.AttrID_POLIZA;
  s.ssCODIGO = obj.AttrCODIGO == null ? "" : obj.AttrCODIGO;
  s.ssTEXTO = obj.AttrTEXTO == null ? "" : obj.AttrTEXTO;
  }
  return s;
}

public static Func<ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure, ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure FromStructure(ST_1881d7eeaa3bae99e7aa7a6ecb977980Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_1881d7eeaa3bae99e7aa7a6ecb977980Structure(s, config);
}

}


