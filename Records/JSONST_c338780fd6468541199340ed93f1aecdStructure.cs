using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_Request
public class JSONST_c338780fd6468541199340ed93f1aecdStructure : AbstractRESTStructure<ST_c338780fd6468541199340ed93f1aecdStructure> {
[JsonProperty("ZMXMIMMF_EM_SM_RM_COSMOZ")]
[JsonPropertyName("ZMXMIMMF_EM_SM_RM_COSMOZ")]
public ssConectaProveedores.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure AttrEM_SM_RM_COSMOZ_Request_Struct;

public JSONST_c338780fd6468541199340ed93f1aecdStructure() { }

public JSONST_c338780fd6468541199340ed93f1aecdStructure (ST_c338780fd6468541199340ed93f1aecdStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_RM_COSMOZ_Request_Struct, new ST_b38fe38940c72474a8e67442651bc995Structure(), ssConectaProveedores.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure.FromStructure(s.ssEM_SM_RM_COSMOZ_Request_Struct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure, ST_c338780fd6468541199340ed93f1aecdStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure s) => ToStructure(s, config);
}
public static ST_c338780fd6468541199340ed93f1aecdStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure obj, IBehaviorsConfiguration config) { 
  ST_c338780fd6468541199340ed93f1aecdStructure s = new ST_c338780fd6468541199340ed93f1aecdStructure();
  if(obj != null) {
  s.ssEM_SM_RM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Request_Struct, config);
  }
  return s;
}

public static Func<ST_c338780fd6468541199340ed93f1aecdStructure, ssConectaProveedores.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c338780fd6468541199340ed93f1aecdStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure FromStructure(ST_c338780fd6468541199340ed93f1aecdStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure(s, config);
}

}


