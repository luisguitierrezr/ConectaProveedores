using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_0250_FI_CREATE_RELATRespRecord
public class RESTRC_fb2347f1fe6bd56b4233b13a791f4550 : AbstractRESTStructure<RC_fb2347f1fe6bd56b4233b13a791f4550> {
[JsonProperty("ZMXFFIMF_0250_FI_CREATE_RELATResp")]
public ssConectaProveedores.RestRecords.RESTST_31a464e509d55210f80b735594283423Structure AttrZMXFFIMF_0250_FI_CREATE_RELATResp;

public RESTRC_fb2347f1fe6bd56b4233b13a791f4550() { }

public RESTRC_fb2347f1fe6bd56b4233b13a791f4550 (RC_fb2347f1fe6bd56b4233b13a791f4550 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_0250_FI_CREATE_RELATResp = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp, new ST_31a464e509d55210f80b735594283423Structure(), ssConectaProveedores.RestRecords.RESTST_31a464e509d55210f80b735594283423Structure.FromStructure, config);
  } else {
AttrZMXFFIMF_0250_FI_CREATE_RELATResp = ssConectaProveedores.RestRecords.RESTST_31a464e509d55210f80b735594283423Structure.FromStructure(s.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp, config);
  }
}

public static RC_fb2347f1fe6bd56b4233b13a791f4550 ToStructure(ssConectaProveedores.RestRecords.RESTRC_fb2347f1fe6bd56b4233b13a791f4550 obj) { 
  RC_fb2347f1fe6bd56b4233b13a791f4550 s = new RC_fb2347f1fe6bd56b4233b13a791f4550();
  if(obj != null) {
  s.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp = ssConectaProveedores.RestRecords.RESTST_31a464e509d55210f80b735594283423Structure.ToStructure(obj.AttrZMXFFIMF_0250_FI_CREATE_RELATResp);
  }
  return s;
}

public static Func<RC_fb2347f1fe6bd56b4233b13a791f4550, ssConectaProveedores.RestRecords.RESTRC_fb2347f1fe6bd56b4233b13a791f4550> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fb2347f1fe6bd56b4233b13a791f4550 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fb2347f1fe6bd56b4233b13a791f4550 FromStructure(RC_fb2347f1fe6bd56b4233b13a791f4550 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fb2347f1fe6bd56b4233b13a791f4550(s, config);
}

}


