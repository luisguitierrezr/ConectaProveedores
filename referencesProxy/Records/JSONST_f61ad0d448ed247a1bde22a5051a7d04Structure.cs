using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_MO_COSMOZ_Request
public class JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure : AbstractRESTStructure<ST_f61ad0d448ed247a1bde22a5051a7d04Structure> {
[JsonProperty("ZMXMIMMF_EM_SM_MO_COSMOZ")]
[JsonPropertyName("ZMXMIMMF_EM_SM_MO_COSMOZ")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure AttrEM_SM_MO_COSMOZ_Request_Struct;

public JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure() { }

public JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure (ST_f61ad0d448ed247a1bde22a5051a7d04Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_MO_COSMOZ_Request_Struct, new ST_e88e810a3be3c7b278de1b477e897388Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure.FromStructure(s.ssEM_SM_MO_COSMOZ_Request_Struct, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure, ST_f61ad0d448ed247a1bde22a5051a7d04Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure s) => ToStructure(s, config);
}
public static ST_f61ad0d448ed247a1bde22a5051a7d04Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure obj, IBehaviorsConfiguration config) { 
  ST_f61ad0d448ed247a1bde22a5051a7d04Structure s = new ST_f61ad0d448ed247a1bde22a5051a7d04Structure();
  if(obj != null) {
  s.ssEM_SM_MO_COSMOZ_Request_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Request_Struct, config);
  }
  return s;
}

public static Func<ST_f61ad0d448ed247a1bde22a5051a7d04Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f61ad0d448ed247a1bde22a5051a7d04Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure FromStructure(ST_f61ad0d448ed247a1bde22a5051a7d04Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure(s, config);
}

}


