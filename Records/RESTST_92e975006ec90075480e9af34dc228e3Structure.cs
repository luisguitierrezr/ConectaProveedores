using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_CECO_COSMOZ_Response
public class RESTST_92e975006ec90075480e9af34dc228e3Structure : AbstractRESTStructure<ST_92e975006ec90075480e9af34dc228e3Structure> {
[JsonProperty("EM_SM_CECO_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure AttrEM_SM_CECO_COSMOZ_Response_Struct;

public RESTST_92e975006ec90075480e9af34dc228e3Structure() { }

public RESTST_92e975006ec90075480e9af34dc228e3Structure (ST_92e975006ec90075480e9af34dc228e3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_CECO_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_CECO_COSMOZ_Response_Struct, new ST_b6cef14925f799164fc3167fe695008bStructure(), ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure.FromStructure, config);
  } else {
AttrEM_SM_CECO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure.FromStructure(s.ssEM_SM_CECO_COSMOZ_Response_Struct, config);
  }
}

public static ST_92e975006ec90075480e9af34dc228e3Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_92e975006ec90075480e9af34dc228e3Structure obj) { 
  ST_92e975006ec90075480e9af34dc228e3Structure s = new ST_92e975006ec90075480e9af34dc228e3Structure();
  if(obj != null) {
  s.ssEM_SM_CECO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure.ToStructure(obj.AttrEM_SM_CECO_COSMOZ_Response_Struct);
  }
  return s;
}

public static Func<ST_92e975006ec90075480e9af34dc228e3Structure, ssConectaProveedores.RestRecords.RESTST_92e975006ec90075480e9af34dc228e3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_92e975006ec90075480e9af34dc228e3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_92e975006ec90075480e9af34dc228e3Structure FromStructure(ST_92e975006ec90075480e9af34dc228e3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_92e975006ec90075480e9af34dc228e3Structure(s, config);
}

}


