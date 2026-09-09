using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_Response_StructRecord
public class RESTRC_005bcb84b613dbc7d93b98c3c1aa6999 : AbstractRESTStructure<RC_005bcb84b613dbc7d93b98c3c1aa6999> {
[JsonProperty("EM_SM_RM_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure AttrEM_SM_RM_COSMOZ_Response_Struct;

public RESTRC_005bcb84b613dbc7d93b98c3c1aa6999() { }

public RESTRC_005bcb84b613dbc7d93b98c3c1aa6999 (RC_005bcb84b613dbc7d93b98c3c1aa6999 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_RM_COSMOZ_Response_Struct, new ST_e4cfb5ae163d3591da9f760267d740aaStructure(), ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure.FromStructure(s.ssSTEM_SM_RM_COSMOZ_Response_Struct, config);
  }
}

public static RC_005bcb84b613dbc7d93b98c3c1aa6999 ToStructure(ssConectaProveedores.RestRecords.RESTRC_005bcb84b613dbc7d93b98c3c1aa6999 obj) { 
  RC_005bcb84b613dbc7d93b98c3c1aa6999 s = new RC_005bcb84b613dbc7d93b98c3c1aa6999();
  if(obj != null) {
  s.ssSTEM_SM_RM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_e4cfb5ae163d3591da9f760267d740aaStructure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Response_Struct);
  }
  return s;
}

public static Func<RC_005bcb84b613dbc7d93b98c3c1aa6999, ssConectaProveedores.RestRecords.RESTRC_005bcb84b613dbc7d93b98c3c1aa6999> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_005bcb84b613dbc7d93b98c3c1aa6999 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_005bcb84b613dbc7d93b98c3c1aa6999 FromStructure(RC_005bcb84b613dbc7d93b98c3c1aa6999 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_005bcb84b613dbc7d93b98c3c1aa6999(s, config);
}

}


