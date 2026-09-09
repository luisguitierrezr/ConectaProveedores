using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_MO_COSMOZRespRecord
public class RESTRC_6bb7219d5e0c95ac87eb2e8fd881c9c0 : AbstractRESTStructure<RC_6bb7219d5e0c95ac87eb2e8fd881c9c0> {
[JsonProperty("ZMXMIMMF_EM_SM_MO_COSMOZResp")]
public ssConectaProveedores.RestRecords.RESTST_39fca1fbc45889b86a3f10d9a278767bStructure AttrZMXMIMMF_EM_SM_MO_COSMOZResp;

public RESTRC_6bb7219d5e0c95ac87eb2e8fd881c9c0() { }

public RESTRC_6bb7219d5e0c95ac87eb2e8fd881c9c0 (RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_SM_MO_COSMOZResp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp, new ST_39fca1fbc45889b86a3f10d9a278767bStructure(), ssConectaProveedores.RestRecords.RESTST_39fca1fbc45889b86a3f10d9a278767bStructure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_SM_MO_COSMOZResp = ssConectaProveedores.RestRecords.RESTST_39fca1fbc45889b86a3f10d9a278767bStructure.FromStructure(s.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp, config);
  }
}

public static RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6bb7219d5e0c95ac87eb2e8fd881c9c0 obj) { 
  RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 s = new RC_6bb7219d5e0c95ac87eb2e8fd881c9c0();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp = ssConectaProveedores.RestRecords.RESTST_39fca1fbc45889b86a3f10d9a278767bStructure.ToStructure(obj.AttrZMXMIMMF_EM_SM_MO_COSMOZResp);
  }
  return s;
}

public static Func<RC_6bb7219d5e0c95ac87eb2e8fd881c9c0, ssConectaProveedores.RestRecords.RESTRC_6bb7219d5e0c95ac87eb2e8fd881c9c0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6bb7219d5e0c95ac87eb2e8fd881c9c0 FromStructure(RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6bb7219d5e0c95ac87eb2e8fd881c9c0(s, config);
}

}


