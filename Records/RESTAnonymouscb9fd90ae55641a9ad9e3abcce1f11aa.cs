using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_ZMXFAPMF_CONSUL_RETENPROV_ReqRecord
public class RESTRC_f74790f9f925ee8b861e1bdb891704ae : AbstractRESTStructure<RC_f74790f9f925ee8b861e1bdb891704ae> {
[JsonProperty("BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req")]
public ssConectaProveedores.RestRecords.RESTST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req;

public RESTRC_f74790f9f925ee8b861e1bdb891704ae() { }

public RESTRC_f74790f9f925ee8b861e1bdb891704ae (RC_f74790f9f925ee8b861e1bdb891704ae s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = ConvertToRestWithoutDefaults(s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req, new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure(), ssConectaProveedores.RestRecords.RESTST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure.FromStructure, config);
  } else {
AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = ssConectaProveedores.RestRecords.RESTST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure.FromStructure(s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req, config);
  }
}

public static RC_f74790f9f925ee8b861e1bdb891704ae ToStructure(ssConectaProveedores.RestRecords.RESTRC_f74790f9f925ee8b861e1bdb891704ae obj) { 
  RC_f74790f9f925ee8b861e1bdb891704ae s = new RC_f74790f9f925ee8b861e1bdb891704ae();
  if(obj != null) {
  s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = ssConectaProveedores.RestRecords.RESTST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure.ToStructure(obj.AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req);
  }
  return s;
}

public static Func<RC_f74790f9f925ee8b861e1bdb891704ae, ssConectaProveedores.RestRecords.RESTRC_f74790f9f925ee8b861e1bdb891704ae> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f74790f9f925ee8b861e1bdb891704ae s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f74790f9f925ee8b861e1bdb891704ae FromStructure(RC_f74790f9f925ee8b861e1bdb891704ae s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f74790f9f925ee8b861e1bdb891704ae(s, config);
}

}


