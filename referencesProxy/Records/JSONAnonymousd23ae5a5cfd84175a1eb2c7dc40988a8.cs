using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_EM_SM_RM_COSMOZReqRecord
public class JSONRC_0876bbc223697f964aa1316bf14d647e : AbstractRESTStructure<RC_0876bbc223697f964aa1316bf14d647e> {
[JsonProperty("ZMXMIMMF_EM_SM_RM_COSMOZReq")]
[JsonPropertyName("ZMXMIMMF_EM_SM_RM_COSMOZReq")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure AttrZMXMIMMF_EM_SM_RM_COSMOZReq;

public JSONRC_0876bbc223697f964aa1316bf14d647e() { }

public JSONRC_0876bbc223697f964aa1316bf14d647e (RC_0876bbc223697f964aa1316bf14d647e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_SM_RM_COSMOZReq = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq, new ST_e629b825a45e94758f239d11120cb772Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_SM_RM_COSMOZReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure.FromStructure(s.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0876bbc223697f964aa1316bf14d647e, RC_0876bbc223697f964aa1316bf14d647e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0876bbc223697f964aa1316bf14d647e s) => ToStructure(s, config);
}
public static RC_0876bbc223697f964aa1316bf14d647e ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0876bbc223697f964aa1316bf14d647e obj, IBehaviorsConfiguration config) { 
  RC_0876bbc223697f964aa1316bf14d647e s = new RC_0876bbc223697f964aa1316bf14d647e();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure.ToStructure(obj.AttrZMXMIMMF_EM_SM_RM_COSMOZReq, config);
  }
  return s;
}

public static Func<RC_0876bbc223697f964aa1316bf14d647e, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0876bbc223697f964aa1316bf14d647e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0876bbc223697f964aa1316bf14d647e s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0876bbc223697f964aa1316bf14d647e FromStructure(RC_0876bbc223697f964aa1316bf14d647e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0876bbc223697f964aa1316bf14d647e(s, config);
}

}


