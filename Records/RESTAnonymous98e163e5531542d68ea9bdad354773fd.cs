using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_0250_FI_CREATE_RELATReqRecord
public class RESTRC_c6cf3e200ddc2179c3439116cd77a508 : AbstractRESTStructure<RC_c6cf3e200ddc2179c3439116cd77a508> {
[JsonProperty("ZMXFFIMF_0250_FI_CREATE_RELATReq")]
public ssConectaProveedores.RestRecords.RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure AttrZMXFFIMF_0250_FI_CREATE_RELATReq;

public RESTRC_c6cf3e200ddc2179c3439116cd77a508() { }

public RESTRC_c6cf3e200ddc2179c3439116cd77a508 (RC_c6cf3e200ddc2179c3439116cd77a508 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_0250_FI_CREATE_RELATReq = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq, new ST_b9515582922fdbd4d217706a5c5c0f3fStructure(), ssConectaProveedores.RestRecords.RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure.FromStructure, config);
  } else {
AttrZMXFFIMF_0250_FI_CREATE_RELATReq = ssConectaProveedores.RestRecords.RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure.FromStructure(s.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq, config);
  }
}

public static RC_c6cf3e200ddc2179c3439116cd77a508 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c6cf3e200ddc2179c3439116cd77a508 obj) { 
  RC_c6cf3e200ddc2179c3439116cd77a508 s = new RC_c6cf3e200ddc2179c3439116cd77a508();
  if(obj != null) {
  s.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq = ssConectaProveedores.RestRecords.RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure.ToStructure(obj.AttrZMXFFIMF_0250_FI_CREATE_RELATReq);
  }
  return s;
}

public static Func<RC_c6cf3e200ddc2179c3439116cd77a508, ssConectaProveedores.RestRecords.RESTRC_c6cf3e200ddc2179c3439116cd77a508> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c6cf3e200ddc2179c3439116cd77a508 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c6cf3e200ddc2179c3439116cd77a508 FromStructure(RC_c6cf3e200ddc2179c3439116cd77a508 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c6cf3e200ddc2179c3439116cd77a508(s, config);
}

}


