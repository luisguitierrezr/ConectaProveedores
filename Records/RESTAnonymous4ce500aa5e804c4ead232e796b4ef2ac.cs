using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_VISUALIZAR_SAL_ANTReqRecord
public class RESTRC_0af43c1e2c7fa4a11aabdc946b7d5f8b : AbstractRESTStructure<RC_0af43c1e2c7fa4a11aabdc946b7d5f8b> {
[JsonProperty("ZMXMIMMF_VISUALIZAR_SAL_ANTReq")]
public ssConectaProveedores.RestRecords.RESTST_f68ab54e767928bb7cc21e9801e8642bStructure AttrZMXMIMMF_VISUALIZAR_SAL_ANTReq;

public RESTRC_0af43c1e2c7fa4a11aabdc946b7d5f8b() { }

public RESTRC_0af43c1e2c7fa4a11aabdc946b7d5f8b (RC_0af43c1e2c7fa4a11aabdc946b7d5f8b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_VISUALIZAR_SAL_ANTReq = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq, new ST_f68ab54e767928bb7cc21e9801e8642bStructure(), ssConectaProveedores.RestRecords.RESTST_f68ab54e767928bb7cc21e9801e8642bStructure.FromStructure, config);
  } else {
AttrZMXMIMMF_VISUALIZAR_SAL_ANTReq = ssConectaProveedores.RestRecords.RESTST_f68ab54e767928bb7cc21e9801e8642bStructure.FromStructure(s.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq, config);
  }
}

public static RC_0af43c1e2c7fa4a11aabdc946b7d5f8b ToStructure(ssConectaProveedores.RestRecords.RESTRC_0af43c1e2c7fa4a11aabdc946b7d5f8b obj) { 
  RC_0af43c1e2c7fa4a11aabdc946b7d5f8b s = new RC_0af43c1e2c7fa4a11aabdc946b7d5f8b();
  if(obj != null) {
  s.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq = ssConectaProveedores.RestRecords.RESTST_f68ab54e767928bb7cc21e9801e8642bStructure.ToStructure(obj.AttrZMXMIMMF_VISUALIZAR_SAL_ANTReq);
  }
  return s;
}

public static Func<RC_0af43c1e2c7fa4a11aabdc946b7d5f8b, ssConectaProveedores.RestRecords.RESTRC_0af43c1e2c7fa4a11aabdc946b7d5f8b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0af43c1e2c7fa4a11aabdc946b7d5f8b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0af43c1e2c7fa4a11aabdc946b7d5f8b FromStructure(RC_0af43c1e2c7fa4a11aabdc946b7d5f8b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0af43c1e2c7fa4a11aabdc946b7d5f8b(s, config);
}

}


