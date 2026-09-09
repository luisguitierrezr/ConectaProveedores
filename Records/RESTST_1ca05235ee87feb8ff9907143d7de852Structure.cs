using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TO_RESULTADO_Out
public class RESTST_1ca05235ee87feb8ff9907143d7de852Structure : AbstractRESTStructure<ST_1ca05235ee87feb8ff9907143d7de852Structure> {
[JsonProperty("ID_POLIZA")]
public string AttrID_POLIZA;

[JsonProperty("CODIGO")]
public string AttrCODIGO;

[JsonProperty("TEXTO")]
public string AttrTEXTO;

public RESTST_1ca05235ee87feb8ff9907143d7de852Structure() { }

public RESTST_1ca05235ee87feb8ff9907143d7de852Structure (ST_1ca05235ee87feb8ff9907143d7de852Structure s, IBehaviorsConfiguration config) {
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

public static ST_1ca05235ee87feb8ff9907143d7de852Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure obj) { 
  ST_1ca05235ee87feb8ff9907143d7de852Structure s = new ST_1ca05235ee87feb8ff9907143d7de852Structure();
  if(obj != null) {
  s.ssID_POLIZA = obj.AttrID_POLIZA == null ? "" : obj.AttrID_POLIZA;
  s.ssCODIGO = obj.AttrCODIGO == null ? "" : obj.AttrCODIGO;
  s.ssTEXTO = obj.AttrTEXTO == null ? "" : obj.AttrTEXTO;
  }
  return s;
}

public static Func<ST_1ca05235ee87feb8ff9907143d7de852Structure, ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1ca05235ee87feb8ff9907143d7de852Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure FromStructure(ST_1ca05235ee87feb8ff9907143d7de852Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_1ca05235ee87feb8ff9907143d7de852Structure(s, config);
}

}


