using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_Request
public class RESTST_c338780fd6468541199340ed93f1aecdStructure : AbstractRESTStructure<ST_c338780fd6468541199340ed93f1aecdStructure> {
[JsonProperty("EM_SM_RM_COSMOZ_Request_Struct")]
public ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure AttrEM_SM_RM_COSMOZ_Request_Struct;

public RESTST_c338780fd6468541199340ed93f1aecdStructure() { }

public RESTST_c338780fd6468541199340ed93f1aecdStructure (ST_c338780fd6468541199340ed93f1aecdStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_RM_COSMOZ_Request_Struct, new ST_b38fe38940c72474a8e67442651bc995Structure(), ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure.FromStructure(s.ssEM_SM_RM_COSMOZ_Request_Struct, config);
  }
}

public static ST_c338780fd6468541199340ed93f1aecdStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_c338780fd6468541199340ed93f1aecdStructure obj) { 
  ST_c338780fd6468541199340ed93f1aecdStructure s = new ST_c338780fd6468541199340ed93f1aecdStructure();
  if(obj != null) {
  s.ssEM_SM_RM_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Request_Struct);
  }
  return s;
}

public static Func<ST_c338780fd6468541199340ed93f1aecdStructure, ssConectaProveedores.RestRecords.RESTST_c338780fd6468541199340ed93f1aecdStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c338780fd6468541199340ed93f1aecdStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_c338780fd6468541199340ed93f1aecdStructure FromStructure(ST_c338780fd6468541199340ed93f1aecdStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_c338780fd6468541199340ed93f1aecdStructure(s, config);
}

}


