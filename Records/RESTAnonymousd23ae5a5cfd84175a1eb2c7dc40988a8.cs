using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_RM_COSMOZReqRecord
public class RESTRC_0876bbc223697f964aa1316bf14d647e : AbstractRESTStructure<RC_0876bbc223697f964aa1316bf14d647e> {
[JsonProperty("ZMXMIMMF_EM_SM_RM_COSMOZReq")]
public ssConectaProveedores.RestRecords.RESTST_e629b825a45e94758f239d11120cb772Structure AttrZMXMIMMF_EM_SM_RM_COSMOZReq;

public RESTRC_0876bbc223697f964aa1316bf14d647e() { }

public RESTRC_0876bbc223697f964aa1316bf14d647e (RC_0876bbc223697f964aa1316bf14d647e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_SM_RM_COSMOZReq = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq, new ST_e629b825a45e94758f239d11120cb772Structure(), ssConectaProveedores.RestRecords.RESTST_e629b825a45e94758f239d11120cb772Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_SM_RM_COSMOZReq = ssConectaProveedores.RestRecords.RESTST_e629b825a45e94758f239d11120cb772Structure.FromStructure(s.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq, config);
  }
}

public static RC_0876bbc223697f964aa1316bf14d647e ToStructure(ssConectaProveedores.RestRecords.RESTRC_0876bbc223697f964aa1316bf14d647e obj) { 
  RC_0876bbc223697f964aa1316bf14d647e s = new RC_0876bbc223697f964aa1316bf14d647e();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq = ssConectaProveedores.RestRecords.RESTST_e629b825a45e94758f239d11120cb772Structure.ToStructure(obj.AttrZMXMIMMF_EM_SM_RM_COSMOZReq);
  }
  return s;
}

public static Func<RC_0876bbc223697f964aa1316bf14d647e, ssConectaProveedores.RestRecords.RESTRC_0876bbc223697f964aa1316bf14d647e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0876bbc223697f964aa1316bf14d647e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0876bbc223697f964aa1316bf14d647e FromStructure(RC_0876bbc223697f964aa1316bf14d647e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0876bbc223697f964aa1316bf14d647e(s, config);
}

}


