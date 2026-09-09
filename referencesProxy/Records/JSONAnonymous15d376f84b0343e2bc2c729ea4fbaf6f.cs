using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_EM_COSMOZRespRecord
public class JSONRC_889992011346c72f40c5df9c68ce8075 : AbstractRESTStructure<RC_889992011346c72f40c5df9c68ce8075> {
[JsonProperty("ZMXMIMMF_EM_COSMOZResp")]
[JsonPropertyName("ZMXMIMMF_EM_COSMOZResp")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure AttrZMXMIMMF_EM_COSMOZResp;

public JSONRC_889992011346c72f40c5df9c68ce8075() { }

public JSONRC_889992011346c72f40c5df9c68ce8075 (RC_889992011346c72f40c5df9c68ce8075 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_COSMOZResp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_COSMOZResp, new ST_9142fa8204e8ba0b33acb137d6acbbd3Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_COSMOZResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure.FromStructure(s.ssSTZMXMIMMF_EM_COSMOZResp, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_889992011346c72f40c5df9c68ce8075, RC_889992011346c72f40c5df9c68ce8075> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_889992011346c72f40c5df9c68ce8075 s) => ToStructure(s, config);
}
public static RC_889992011346c72f40c5df9c68ce8075 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_889992011346c72f40c5df9c68ce8075 obj, IBehaviorsConfiguration config) { 
  RC_889992011346c72f40c5df9c68ce8075 s = new RC_889992011346c72f40c5df9c68ce8075();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_COSMOZResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure.ToStructure(obj.AttrZMXMIMMF_EM_COSMOZResp, config);
  }
  return s;
}

public static Func<RC_889992011346c72f40c5df9c68ce8075, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_889992011346c72f40c5df9c68ce8075> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_889992011346c72f40c5df9c68ce8075 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_889992011346c72f40c5df9c68ce8075 FromStructure(RC_889992011346c72f40c5df9c68ce8075 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_889992011346c72f40c5df9c68ce8075(s, config);
}

}


