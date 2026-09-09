using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TO_RESULTADO_Out
public class JSONST_1ca05235ee87feb8ff9907143d7de852Structure : AbstractRESTStructure<ST_1ca05235ee87feb8ff9907143d7de852Structure> {
[JsonProperty("ID_POLIZA")]
[JsonPropertyName("ID_POLIZA")]
public string AttrID_POLIZA;

[JsonProperty("CODIGO")]
[JsonPropertyName("CODIGO")]
public string AttrCODIGO;

[JsonProperty("TEXTO")]
[JsonPropertyName("TEXTO")]
public string AttrTEXTO;

public JSONST_1ca05235ee87feb8ff9907143d7de852Structure() { }

public JSONST_1ca05235ee87feb8ff9907143d7de852Structure (ST_1ca05235ee87feb8ff9907143d7de852Structure s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure, ST_1ca05235ee87feb8ff9907143d7de852Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure s) => ToStructure(s, config);
}
public static ST_1ca05235ee87feb8ff9907143d7de852Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure obj, IBehaviorsConfiguration config) { 
  ST_1ca05235ee87feb8ff9907143d7de852Structure s = new ST_1ca05235ee87feb8ff9907143d7de852Structure();
  if(obj != null) {
  s.ssID_POLIZA = obj.AttrID_POLIZA == null ? "" : obj.AttrID_POLIZA;
  s.ssCODIGO = obj.AttrCODIGO == null ? "" : obj.AttrCODIGO;
  s.ssTEXTO = obj.AttrTEXTO == null ? "" : obj.AttrTEXTO;
  }
  return s;
}

public static Func<ST_1ca05235ee87feb8ff9907143d7de852Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1ca05235ee87feb8ff9907143d7de852Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure FromStructure(ST_1ca05235ee87feb8ff9907143d7de852Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1ca05235ee87feb8ff9907143d7de852Structure(s, config);
}

}


