using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_EM_SM_CECO_COSMOZReqRecord
public class JSONRC_3ad4ffb8938fb171b63db568e2bf5412 : AbstractRESTStructure<RC_3ad4ffb8938fb171b63db568e2bf5412> {
[JsonProperty("ZMXMIMMF_EM_SM_CECO_COSMOZReq")]
[JsonPropertyName("ZMXMIMMF_EM_SM_CECO_COSMOZReq")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure AttrZMXMIMMF_EM_SM_CECO_COSMOZReq;

public JSONRC_3ad4ffb8938fb171b63db568e2bf5412() { }

public JSONRC_3ad4ffb8938fb171b63db568e2bf5412 (RC_3ad4ffb8938fb171b63db568e2bf5412 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_SM_CECO_COSMOZReq = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq, new ST_f9c1c13a018839a3b7bd285f1331e967Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_SM_CECO_COSMOZReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure.FromStructure(s.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ad4ffb8938fb171b63db568e2bf5412, RC_3ad4ffb8938fb171b63db568e2bf5412> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ad4ffb8938fb171b63db568e2bf5412 s) => ToStructure(s, config);
}
public static RC_3ad4ffb8938fb171b63db568e2bf5412 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ad4ffb8938fb171b63db568e2bf5412 obj, IBehaviorsConfiguration config) { 
  RC_3ad4ffb8938fb171b63db568e2bf5412 s = new RC_3ad4ffb8938fb171b63db568e2bf5412();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure.ToStructure(obj.AttrZMXMIMMF_EM_SM_CECO_COSMOZReq, config);
  }
  return s;
}

public static Func<RC_3ad4ffb8938fb171b63db568e2bf5412, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ad4ffb8938fb171b63db568e2bf5412> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3ad4ffb8938fb171b63db568e2bf5412 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ad4ffb8938fb171b63db568e2bf5412 FromStructure(RC_3ad4ffb8938fb171b63db568e2bf5412 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ad4ffb8938fb171b63db568e2bf5412(s, config);
}

}


