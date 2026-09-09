using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_ZMXFAPMF_CONSUL_RETENPROV_RespRecord
public class RESTRC_8a4029ca829f8e0c0b6507e5280556a7 : AbstractRESTStructure<RC_8a4029ca829f8e0c0b6507e5280556a7> {
[JsonProperty("BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp")]
public ssConectaProveedores.RestRecords.RESTST_24353ddcec93ac51b13ce9ab94fe4001Structure AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp;

public RESTRC_8a4029ca829f8e0c0b6507e5280556a7() { }

public RESTRC_8a4029ca829f8e0c0b6507e5280556a7 (RC_8a4029ca829f8e0c0b6507e5280556a7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = ConvertToRestWithoutDefaults(s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp, new ST_24353ddcec93ac51b13ce9ab94fe4001Structure(), ssConectaProveedores.RestRecords.RESTST_24353ddcec93ac51b13ce9ab94fe4001Structure.FromStructure, config);
  } else {
AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = ssConectaProveedores.RestRecords.RESTST_24353ddcec93ac51b13ce9ab94fe4001Structure.FromStructure(s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp, config);
  }
}

public static RC_8a4029ca829f8e0c0b6507e5280556a7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8a4029ca829f8e0c0b6507e5280556a7 obj) { 
  RC_8a4029ca829f8e0c0b6507e5280556a7 s = new RC_8a4029ca829f8e0c0b6507e5280556a7();
  if(obj != null) {
  s.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = ssConectaProveedores.RestRecords.RESTST_24353ddcec93ac51b13ce9ab94fe4001Structure.ToStructure(obj.AttrBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp);
  }
  return s;
}

public static Func<RC_8a4029ca829f8e0c0b6507e5280556a7, ssConectaProveedores.RestRecords.RESTRC_8a4029ca829f8e0c0b6507e5280556a7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8a4029ca829f8e0c0b6507e5280556a7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8a4029ca829f8e0c0b6507e5280556a7 FromStructure(RC_8a4029ca829f8e0c0b6507e5280556a7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8a4029ca829f8e0c0b6507e5280556a7(s, config);
}

}


