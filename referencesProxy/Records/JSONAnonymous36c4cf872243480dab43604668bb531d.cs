using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_ESTD_CUENTA_COSMOZRespRecord
public class JSONRC_c9e767f458efda82eb9e48ffda41df1b : AbstractRESTStructure<RC_c9e767f458efda82eb9e48ffda41df1b> {
[JsonProperty("ZMXMIMMF_ESTD_CUENTA_COSMOZResp")]
[JsonPropertyName("ZMXMIMMF_ESTD_CUENTA_COSMOZResp")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure AttrZMXMIMMF_ESTD_CUENTA_COSMOZResp;

public JSONRC_c9e767f458efda82eb9e48ffda41df1b() { }

public JSONRC_c9e767f458efda82eb9e48ffda41df1b (RC_c9e767f458efda82eb9e48ffda41df1b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_ESTD_CUENTA_COSMOZResp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp, new ST_382afa1d8361f400b6ea03403d75e294Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_ESTD_CUENTA_COSMOZResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure.FromStructure(s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c9e767f458efda82eb9e48ffda41df1b, RC_c9e767f458efda82eb9e48ffda41df1b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c9e767f458efda82eb9e48ffda41df1b s) => ToStructure(s, config);
}
public static RC_c9e767f458efda82eb9e48ffda41df1b ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c9e767f458efda82eb9e48ffda41df1b obj, IBehaviorsConfiguration config) { 
  RC_c9e767f458efda82eb9e48ffda41df1b s = new RC_c9e767f458efda82eb9e48ffda41df1b();
  if(obj != null) {
  s.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure.ToStructure(obj.AttrZMXMIMMF_ESTD_CUENTA_COSMOZResp, config);
  }
  return s;
}

public static Func<RC_c9e767f458efda82eb9e48ffda41df1b, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c9e767f458efda82eb9e48ffda41df1b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c9e767f458efda82eb9e48ffda41df1b s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c9e767f458efda82eb9e48ffda41df1b FromStructure(RC_c9e767f458efda82eb9e48ffda41df1b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c9e767f458efda82eb9e48ffda41df1b(s, config);
}

}


