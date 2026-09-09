using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_Response_StructRecord
public class JSONRC_005bcb84b613dbc7d93b98c3c1aa6999 : AbstractRESTStructure<RC_005bcb84b613dbc7d93b98c3c1aa6999> {
[JsonProperty("EM_SM_RM_COSMOZ_Response_Struct")]
[JsonPropertyName("EM_SM_RM_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.JSONST_e4cfb5ae163d3591da9f760267d740aaStructure AttrEM_SM_RM_COSMOZ_Response_Struct;

public JSONRC_005bcb84b613dbc7d93b98c3c1aa6999() { }

public JSONRC_005bcb84b613dbc7d93b98c3c1aa6999 (RC_005bcb84b613dbc7d93b98c3c1aa6999 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_RM_COSMOZ_Response_Struct, new ST_e4cfb5ae163d3591da9f760267d740aaStructure(), ssConectaProveedores.RestRecords.JSONST_e4cfb5ae163d3591da9f760267d740aaStructure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.JSONST_e4cfb5ae163d3591da9f760267d740aaStructure.FromStructure(s.ssSTEM_SM_RM_COSMOZ_Response_Struct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_005bcb84b613dbc7d93b98c3c1aa6999, RC_005bcb84b613dbc7d93b98c3c1aa6999> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_005bcb84b613dbc7d93b98c3c1aa6999 s) => ToStructure(s, config);
}
public static RC_005bcb84b613dbc7d93b98c3c1aa6999 ToStructure(ssConectaProveedores.RestRecords.JSONRC_005bcb84b613dbc7d93b98c3c1aa6999 obj, IBehaviorsConfiguration config) { 
  RC_005bcb84b613dbc7d93b98c3c1aa6999 s = new RC_005bcb84b613dbc7d93b98c3c1aa6999();
  if(obj != null) {
  s.ssSTEM_SM_RM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.JSONST_e4cfb5ae163d3591da9f760267d740aaStructure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Response_Struct, config);
  }
  return s;
}

public static Func<RC_005bcb84b613dbc7d93b98c3c1aa6999, ssConectaProveedores.RestRecords.JSONRC_005bcb84b613dbc7d93b98c3c1aa6999> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_005bcb84b613dbc7d93b98c3c1aa6999 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_005bcb84b613dbc7d93b98c3c1aa6999 FromStructure(RC_005bcb84b613dbc7d93b98c3c1aa6999 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_005bcb84b613dbc7d93b98c3c1aa6999(s, config);
}

}


