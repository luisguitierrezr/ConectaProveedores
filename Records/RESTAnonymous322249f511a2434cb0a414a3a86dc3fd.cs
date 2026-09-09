using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUpdateInfoRecord
public class RESTRC_a582d84634a30a3a3b1e61cbfd3db9de : AbstractRESTStructure<RC_a582d84634a30a3a3b1e61cbfd3db9de> {
[JsonProperty("UserUpdateInfo")]
public ssConectaProveedores.RestRecords.RESTST_da83da85e5348cd2800e701fda6288aaStructure AttrUserUpdateInfo;

public RESTRC_a582d84634a30a3a3b1e61cbfd3db9de() { }

public RESTRC_a582d84634a30a3a3b1e61cbfd3db9de (RC_a582d84634a30a3a3b1e61cbfd3db9de s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserUpdateInfo = ConvertToRestWithoutDefaults(s.ssSTUserUpdateInfo, new ST_da83da85e5348cd2800e701fda6288aaStructure(), ssConectaProveedores.RestRecords.RESTST_da83da85e5348cd2800e701fda6288aaStructure.FromStructure, config);
  } else {
AttrUserUpdateInfo = ssConectaProveedores.RestRecords.RESTST_da83da85e5348cd2800e701fda6288aaStructure.FromStructure(s.ssSTUserUpdateInfo, config);
  }
}

public static RC_a582d84634a30a3a3b1e61cbfd3db9de ToStructure(ssConectaProveedores.RestRecords.RESTRC_a582d84634a30a3a3b1e61cbfd3db9de obj) { 
  RC_a582d84634a30a3a3b1e61cbfd3db9de s = new RC_a582d84634a30a3a3b1e61cbfd3db9de();
  if(obj != null) {
  s.ssSTUserUpdateInfo = ssConectaProveedores.RestRecords.RESTST_da83da85e5348cd2800e701fda6288aaStructure.ToStructure(obj.AttrUserUpdateInfo);
  }
  return s;
}

public static Func<RC_a582d84634a30a3a3b1e61cbfd3db9de, ssConectaProveedores.RestRecords.RESTRC_a582d84634a30a3a3b1e61cbfd3db9de> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a582d84634a30a3a3b1e61cbfd3db9de s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a582d84634a30a3a3b1e61cbfd3db9de FromStructure(RC_a582d84634a30a3a3b1e61cbfd3db9de s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a582d84634a30a3a3b1e61cbfd3db9de(s, config);
}

}


