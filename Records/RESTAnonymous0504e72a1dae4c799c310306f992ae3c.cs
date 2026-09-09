using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_ResponseRecord
public class RESTRC_0e7ae7b08ef9d51cb994ca1e00306a2a : AbstractRESTStructure<RC_0e7ae7b08ef9d51cb994ca1e00306a2a> {
[JsonProperty("EM_SM_RM_COSMOZ_Response")]
public ssConectaProveedores.RestRecords.RESTST_b3b2573902c6e22d9647e405d3baf728Structure AttrEM_SM_RM_COSMOZ_Response;

public RESTRC_0e7ae7b08ef9d51cb994ca1e00306a2a() { }

public RESTRC_0e7ae7b08ef9d51cb994ca1e00306a2a (RC_0e7ae7b08ef9d51cb994ca1e00306a2a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Response = ConvertToRestWithoutDefaults(s.ssSTEM_SM_RM_COSMOZ_Response, new ST_b3b2573902c6e22d9647e405d3baf728Structure(), ssConectaProveedores.RestRecords.RESTST_b3b2573902c6e22d9647e405d3baf728Structure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Response = ssConectaProveedores.RestRecords.RESTST_b3b2573902c6e22d9647e405d3baf728Structure.FromStructure(s.ssSTEM_SM_RM_COSMOZ_Response, config);
  }
}

public static RC_0e7ae7b08ef9d51cb994ca1e00306a2a ToStructure(ssConectaProveedores.RestRecords.RESTRC_0e7ae7b08ef9d51cb994ca1e00306a2a obj) { 
  RC_0e7ae7b08ef9d51cb994ca1e00306a2a s = new RC_0e7ae7b08ef9d51cb994ca1e00306a2a();
  if(obj != null) {
  s.ssSTEM_SM_RM_COSMOZ_Response = ssConectaProveedores.RestRecords.RESTST_b3b2573902c6e22d9647e405d3baf728Structure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Response);
  }
  return s;
}

public static Func<RC_0e7ae7b08ef9d51cb994ca1e00306a2a, ssConectaProveedores.RestRecords.RESTRC_0e7ae7b08ef9d51cb994ca1e00306a2a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0e7ae7b08ef9d51cb994ca1e00306a2a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0e7ae7b08ef9d51cb994ca1e00306a2a FromStructure(RC_0e7ae7b08ef9d51cb994ca1e00306a2a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0e7ae7b08ef9d51cb994ca1e00306a2a(s, config);
}

}


