using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_ESTD_CUENTA_COSMOZRespRecord
public class RESTRC_c9e767f458efda82eb9e48ffda41df1b : AbstractRESTStructure<RC_c9e767f458efda82eb9e48ffda41df1b> {
[JsonProperty("ZMXMIMMF_ESTD_CUENTA_COSMOZResp")]
public ssConectaProveedores.RestRecords.RESTST_382afa1d8361f400b6ea03403d75e294Structure AttrZMXMIMMF_ESTD_CUENTA_COSMOZResp;

public RESTRC_c9e767f458efda82eb9e48ffda41df1b() { }

public RESTRC_c9e767f458efda82eb9e48ffda41df1b (RC_c9e767f458efda82eb9e48ffda41df1b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_ESTD_CUENTA_COSMOZResp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp, new ST_382afa1d8361f400b6ea03403d75e294Structure(), ssConectaProveedores.RestRecords.RESTST_382afa1d8361f400b6ea03403d75e294Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_ESTD_CUENTA_COSMOZResp = ssConectaProveedores.RestRecords.RESTST_382afa1d8361f400b6ea03403d75e294Structure.FromStructure(s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp, config);
  }
}

public static RC_c9e767f458efda82eb9e48ffda41df1b ToStructure(ssConectaProveedores.RestRecords.RESTRC_c9e767f458efda82eb9e48ffda41df1b obj) { 
  RC_c9e767f458efda82eb9e48ffda41df1b s = new RC_c9e767f458efda82eb9e48ffda41df1b();
  if(obj != null) {
  s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp = ssConectaProveedores.RestRecords.RESTST_382afa1d8361f400b6ea03403d75e294Structure.ToStructure(obj.AttrZMXMIMMF_ESTD_CUENTA_COSMOZResp);
  }
  return s;
}

public static Func<RC_c9e767f458efda82eb9e48ffda41df1b, ssConectaProveedores.RestRecords.RESTRC_c9e767f458efda82eb9e48ffda41df1b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c9e767f458efda82eb9e48ffda41df1b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c9e767f458efda82eb9e48ffda41df1b FromStructure(RC_c9e767f458efda82eb9e48ffda41df1b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c9e767f458efda82eb9e48ffda41df1b(s, config);
}

}


