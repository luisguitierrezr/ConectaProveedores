using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_CECO_COSMOZ_Response
public class JSONST_92e975006ec90075480e9af34dc228e3Structure : AbstractRESTStructure<ST_92e975006ec90075480e9af34dc228e3Structure> {
[JsonProperty("ZMXMIMMF_EM_SM_CECO_COSMOZ.Response")]
[JsonPropertyName("ZMXMIMMF_EM_SM_CECO_COSMOZ.Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b6cef14925f799164fc3167fe695008bStructure AttrEM_SM_CECO_COSMOZ_Response_Struct;

public JSONST_92e975006ec90075480e9af34dc228e3Structure() { }

public JSONST_92e975006ec90075480e9af34dc228e3Structure (ST_92e975006ec90075480e9af34dc228e3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_CECO_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_CECO_COSMOZ_Response_Struct, new ST_b6cef14925f799164fc3167fe695008bStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b6cef14925f799164fc3167fe695008bStructure.FromStructure, config);
  } else {
AttrEM_SM_CECO_COSMOZ_Response_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b6cef14925f799164fc3167fe695008bStructure.FromStructure(s.ssEM_SM_CECO_COSMOZ_Response_Struct, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure, ST_92e975006ec90075480e9af34dc228e3Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure s) => ToStructure(s, config);
}
public static ST_92e975006ec90075480e9af34dc228e3Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure obj, IBehaviorsConfiguration config) { 
  ST_92e975006ec90075480e9af34dc228e3Structure s = new ST_92e975006ec90075480e9af34dc228e3Structure();
  if(obj != null) {
  s.ssEM_SM_CECO_COSMOZ_Response_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b6cef14925f799164fc3167fe695008bStructure.ToStructure(obj.AttrEM_SM_CECO_COSMOZ_Response_Struct, config);
  }
  return s;
}

public static Func<ST_92e975006ec90075480e9af34dc228e3Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_92e975006ec90075480e9af34dc228e3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure FromStructure(ST_92e975006ec90075480e9af34dc228e3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure(s, config);
}

}


