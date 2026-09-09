using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_RM_COSMOZ_Response
public class JSONST_b3b2573902c6e22d9647e405d3baf728Structure : AbstractRESTStructure<ST_b3b2573902c6e22d9647e405d3baf728Structure> {
[JsonProperty("ZMXMIMMF_EM_SM_RM_COSMOZ.Response")]
[JsonPropertyName("ZMXMIMMF_EM_SM_RM_COSMOZ.Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e4cfb5ae163d3591da9f760267d740aaStructure AttrEM_SM_RM_COSMOZ_Response_Struct;

public JSONST_b3b2573902c6e22d9647e405d3baf728Structure() { }

public JSONST_b3b2573902c6e22d9647e405d3baf728Structure (ST_b3b2573902c6e22d9647e405d3baf728Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_RM_COSMOZ_Response_Struct, new ST_e4cfb5ae163d3591da9f760267d740aaStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e4cfb5ae163d3591da9f760267d740aaStructure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Response_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e4cfb5ae163d3591da9f760267d740aaStructure.FromStructure(s.ssEM_SM_RM_COSMOZ_Response_Struct, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure, ST_b3b2573902c6e22d9647e405d3baf728Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure s) => ToStructure(s, config);
}
public static ST_b3b2573902c6e22d9647e405d3baf728Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure obj, IBehaviorsConfiguration config) { 
  ST_b3b2573902c6e22d9647e405d3baf728Structure s = new ST_b3b2573902c6e22d9647e405d3baf728Structure();
  if(obj != null) {
  s.ssEM_SM_RM_COSMOZ_Response_Struct = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e4cfb5ae163d3591da9f760267d740aaStructure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Response_Struct, config);
  }
  return s;
}

public static Func<ST_b3b2573902c6e22d9647e405d3baf728Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b3b2573902c6e22d9647e405d3baf728Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure FromStructure(ST_b3b2573902c6e22d9647e405d3baf728Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure(s, config);
}

}


