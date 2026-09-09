using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_Response
public class RESTST_b3b2573902c6e22d9647e405d3baf728Structure : AbstractRESTStructure<ST_b3b2573902c6e22d9647e405d3baf728Structure> {
[JsonProperty("EM_SM_RM_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure AttrEM_SM_RM_COSMOZ_Response_Struct;

public RESTST_b3b2573902c6e22d9647e405d3baf728Structure() { }

public RESTST_b3b2573902c6e22d9647e405d3baf728Structure (ST_b3b2573902c6e22d9647e405d3baf728Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_RM_COSMOZ_Response_Struct, new ST_e4cfb5ae163d3591da9f760267d740aaStructure(), ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure.FromStructure(s.ssEM_SM_RM_COSMOZ_Response_Struct, config);
  }
}

public static ST_b3b2573902c6e22d9647e405d3baf728Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_b3b2573902c6e22d9647e405d3baf728Structure obj) { 
  ST_b3b2573902c6e22d9647e405d3baf728Structure s = new ST_b3b2573902c6e22d9647e405d3baf728Structure();
  if(obj != null) {
  s.ssEM_SM_RM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Response_Struct);
  }
  return s;
}

public static Func<ST_b3b2573902c6e22d9647e405d3baf728Structure, ssConectaProveedores.RestRecords.RESTST_b3b2573902c6e22d9647e405d3baf728Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b3b2573902c6e22d9647e405d3baf728Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b3b2573902c6e22d9647e405d3baf728Structure FromStructure(ST_b3b2573902c6e22d9647e405d3baf728Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b3b2573902c6e22d9647e405d3baf728Structure(s, config);
}

}


