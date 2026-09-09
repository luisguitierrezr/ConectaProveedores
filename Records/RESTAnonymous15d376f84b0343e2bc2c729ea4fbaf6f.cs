using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_COSMOZRespRecord
public class RESTRC_889992011346c72f40c5df9c68ce8075 : AbstractRESTStructure<RC_889992011346c72f40c5df9c68ce8075> {
[JsonProperty("ZMXMIMMF_EM_COSMOZResp")]
public ssConectaProveedores.RestRecords.RESTST_9142fa8204e8ba0b33acb137d6acbbd3Structure AttrZMXMIMMF_EM_COSMOZResp;

public RESTRC_889992011346c72f40c5df9c68ce8075() { }

public RESTRC_889992011346c72f40c5df9c68ce8075 (RC_889992011346c72f40c5df9c68ce8075 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_COSMOZResp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_COSMOZResp, new ST_9142fa8204e8ba0b33acb137d6acbbd3Structure(), ssConectaProveedores.RestRecords.RESTST_9142fa8204e8ba0b33acb137d6acbbd3Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_COSMOZResp = ssConectaProveedores.RestRecords.RESTST_9142fa8204e8ba0b33acb137d6acbbd3Structure.FromStructure(s.ssSTZMXMIMMF_EM_COSMOZResp, config);
  }
}

public static RC_889992011346c72f40c5df9c68ce8075 ToStructure(ssConectaProveedores.RestRecords.RESTRC_889992011346c72f40c5df9c68ce8075 obj) { 
  RC_889992011346c72f40c5df9c68ce8075 s = new RC_889992011346c72f40c5df9c68ce8075();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_COSMOZResp = ssConectaProveedores.RestRecords.RESTST_9142fa8204e8ba0b33acb137d6acbbd3Structure.ToStructure(obj.AttrZMXMIMMF_EM_COSMOZResp);
  }
  return s;
}

public static Func<RC_889992011346c72f40c5df9c68ce8075, ssConectaProveedores.RestRecords.RESTRC_889992011346c72f40c5df9c68ce8075> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_889992011346c72f40c5df9c68ce8075 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_889992011346c72f40c5df9c68ce8075 FromStructure(RC_889992011346c72f40c5df9c68ce8075 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_889992011346c72f40c5df9c68ce8075(s, config);
}

}


