using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// BAPI_ZMXFAPMF_CONSUL_RETENPROV_ReqRecord
public class JSONRC_f74790f9f925ee8b861e1bdb891704ae : AbstractRESTStructure<RC_f74790f9f925ee8b861e1bdb891704ae> {
[JsonProperty("BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req")]
[JsonPropertyName("BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req;

public JSONRC_f74790f9f925ee8b861e1bdb891704ae() { }

public JSONRC_f74790f9f925ee8b861e1bdb891704ae (RC_f74790f9f925ee8b861e1bdb891704ae s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = ConvertToRestWithoutDefaults(s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req, new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure.FromStructure, config);
  } else {
AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure.FromStructure(s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f74790f9f925ee8b861e1bdb891704ae, RC_f74790f9f925ee8b861e1bdb891704ae> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f74790f9f925ee8b861e1bdb891704ae s) => ToStructure(s, config);
}
public static RC_f74790f9f925ee8b861e1bdb891704ae ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f74790f9f925ee8b861e1bdb891704ae obj, IBehaviorsConfiguration config) { 
  RC_f74790f9f925ee8b861e1bdb891704ae s = new RC_f74790f9f925ee8b861e1bdb891704ae();
  if(obj != null) {
  s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure.ToStructure(obj.AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req, config);
  }
  return s;
}

public static Func<RC_f74790f9f925ee8b861e1bdb891704ae, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f74790f9f925ee8b861e1bdb891704ae> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f74790f9f925ee8b861e1bdb891704ae s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f74790f9f925ee8b861e1bdb891704ae FromStructure(RC_f74790f9f925ee8b861e1bdb891704ae s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f74790f9f925ee8b861e1bdb891704ae(s, config);
}

}


