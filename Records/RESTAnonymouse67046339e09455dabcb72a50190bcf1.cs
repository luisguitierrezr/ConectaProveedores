using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_ESTD_CUENTA_COSMOZReqRecord
public class RESTRC_e3f97a835052a7077c357e00e680711c : AbstractRESTStructure<RC_e3f97a835052a7077c357e00e680711c> {
[JsonProperty("ZMXMIMMF_ESTD_CUENTA_COSMOZReq")]
public ssConectaProveedores.RestRecords.RESTST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure AttrZMXMIMMF_ESTD_CUENTA_COSMOZReq;

public RESTRC_e3f97a835052a7077c357e00e680711c() { }

public RESTRC_e3f97a835052a7077c357e00e680711c (RC_e3f97a835052a7077c357e00e680711c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_ESTD_CUENTA_COSMOZReq = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq, new ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure(), ssConectaProveedores.RestRecords.RESTST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure.FromStructure, config);
  } else {
AttrZMXMIMMF_ESTD_CUENTA_COSMOZReq = ssConectaProveedores.RestRecords.RESTST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure.FromStructure(s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq, config);
  }
}

public static RC_e3f97a835052a7077c357e00e680711c ToStructure(ssConectaProveedores.RestRecords.RESTRC_e3f97a835052a7077c357e00e680711c obj) { 
  RC_e3f97a835052a7077c357e00e680711c s = new RC_e3f97a835052a7077c357e00e680711c();
  if(obj != null) {
  s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq = ssConectaProveedores.RestRecords.RESTST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure.ToStructure(obj.AttrZMXMIMMF_ESTD_CUENTA_COSMOZReq);
  }
  return s;
}

public static Func<RC_e3f97a835052a7077c357e00e680711c, ssConectaProveedores.RestRecords.RESTRC_e3f97a835052a7077c357e00e680711c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e3f97a835052a7077c357e00e680711c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e3f97a835052a7077c357e00e680711c FromStructure(RC_e3f97a835052a7077c357e00e680711c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e3f97a835052a7077c357e00e680711c(s, config);
}

}


