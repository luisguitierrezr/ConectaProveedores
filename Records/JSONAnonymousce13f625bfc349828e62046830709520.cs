using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_ZMXFAPMF_CONSUL_RETENPROV_RespRecord
public class JSONRC_8a4029ca829f8e0c0b6507e5280556a7 : AbstractRESTStructure<RC_8a4029ca829f8e0c0b6507e5280556a7> {
[JsonProperty("BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp")]
[JsonPropertyName("BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp")]
public ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp;

public JSONRC_8a4029ca829f8e0c0b6507e5280556a7() { }

public JSONRC_8a4029ca829f8e0c0b6507e5280556a7 (RC_8a4029ca829f8e0c0b6507e5280556a7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = ConvertToRestWithoutDefaults(s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp, new ST_24353ddcec93ac51b13ce9ab94fe4001Structure(), ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure.FromStructure, config);
  } else {
AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure.FromStructure(s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8a4029ca829f8e0c0b6507e5280556a7, RC_8a4029ca829f8e0c0b6507e5280556a7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8a4029ca829f8e0c0b6507e5280556a7 s) => ToStructure(s, config);
}
public static RC_8a4029ca829f8e0c0b6507e5280556a7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8a4029ca829f8e0c0b6507e5280556a7 obj, IBehaviorsConfiguration config) { 
  RC_8a4029ca829f8e0c0b6507e5280556a7 s = new RC_8a4029ca829f8e0c0b6507e5280556a7();
  if(obj != null) {
  s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = ssConectaProveedores.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure.ToStructure(obj.AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp, config);
  }
  return s;
}

public static Func<RC_8a4029ca829f8e0c0b6507e5280556a7, ssConectaProveedores.RestRecords.JSONRC_8a4029ca829f8e0c0b6507e5280556a7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8a4029ca829f8e0c0b6507e5280556a7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8a4029ca829f8e0c0b6507e5280556a7 FromStructure(RC_8a4029ca829f8e0c0b6507e5280556a7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8a4029ca829f8e0c0b6507e5280556a7(s, config);
}

}


