using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_VISUALIZAR_SAL_ANTRespRecord
public class RESTRC_dfc12769dee17fa6a0d26c41f4862476 : AbstractRESTStructure<RC_dfc12769dee17fa6a0d26c41f4862476> {
[JsonProperty("ZMXMIMMF_VISUALIZAR_SAL_ANTResp")]
public ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure AttrZMXMIMMF_VISUALIZAR_SAL_ANTResp;

public RESTRC_dfc12769dee17fa6a0d26c41f4862476() { }

public RESTRC_dfc12769dee17fa6a0d26c41f4862476 (RC_dfc12769dee17fa6a0d26c41f4862476 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_VISUALIZAR_SAL_ANTResp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp, new ST_cbb2055cf19f871ed882642269bd43ceStructure(), ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure.FromStructure, config);
  } else {
AttrZMXMIMMF_VISUALIZAR_SAL_ANTResp = ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure.FromStructure(s.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp, config);
  }
}

public static RC_dfc12769dee17fa6a0d26c41f4862476 ToStructure(ssConectaProveedores.RestRecords.RESTRC_dfc12769dee17fa6a0d26c41f4862476 obj) { 
  RC_dfc12769dee17fa6a0d26c41f4862476 s = new RC_dfc12769dee17fa6a0d26c41f4862476();
  if(obj != null) {
  s.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp = ssConectaProveedores.RestRecords.RESTST_cbb2055cf19f871ed882642269bd43ceStructure.ToStructure(obj.AttrZMXMIMMF_VISUALIZAR_SAL_ANTResp);
  }
  return s;
}

public static Func<RC_dfc12769dee17fa6a0d26c41f4862476, ssConectaProveedores.RestRecords.RESTRC_dfc12769dee17fa6a0d26c41f4862476> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dfc12769dee17fa6a0d26c41f4862476 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dfc12769dee17fa6a0d26c41f4862476 FromStructure(RC_dfc12769dee17fa6a0d26c41f4862476 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dfc12769dee17fa6a0d26c41f4862476(s, config);
}

}


