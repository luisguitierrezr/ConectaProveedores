using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_EM_SM_RM_COSMOZRespRecord
public class JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617 : AbstractRESTStructure<RC_66a20a7b8ce3f53dc41a0f7d5901d617> {
[JsonProperty("ZMXMIMMF_EM_SM_RM_COSMOZResp")]
[JsonPropertyName("ZMXMIMMF_EM_SM_RM_COSMOZResp")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure AttrZMXMIMMF_EM_SM_RM_COSMOZResp;

public JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617() { }

public JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617 (RC_66a20a7b8ce3f53dc41a0f7d5901d617 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_SM_RM_COSMOZResp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp, new ST_b413183d4662c427b8a9318270b9732cStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_SM_RM_COSMOZResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure.FromStructure(s.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617, RC_66a20a7b8ce3f53dc41a0f7d5901d617> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617 s) => ToStructure(s, config);
}
public static RC_66a20a7b8ce3f53dc41a0f7d5901d617 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617 obj, IBehaviorsConfiguration config) { 
  RC_66a20a7b8ce3f53dc41a0f7d5901d617 s = new RC_66a20a7b8ce3f53dc41a0f7d5901d617();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure.ToStructure(obj.AttrZMXMIMMF_EM_SM_RM_COSMOZResp, config);
  }
  return s;
}

public static Func<RC_66a20a7b8ce3f53dc41a0f7d5901d617, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_66a20a7b8ce3f53dc41a0f7d5901d617 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617 FromStructure(RC_66a20a7b8ce3f53dc41a0f7d5901d617 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_66a20a7b8ce3f53dc41a0f7d5901d617(s, config);
}

}


