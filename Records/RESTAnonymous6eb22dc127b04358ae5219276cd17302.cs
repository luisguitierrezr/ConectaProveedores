using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZTC_GENERA_POLIZA_GRALRespRecord
public class RESTRC_c791b0e7f92315f354525a79f511e845 : AbstractRESTStructure<RC_c791b0e7f92315f354525a79f511e845> {
[JsonProperty("ZTC_GENERA_POLIZA_GRALResp")]
public ssConectaProveedores.RestRecords.RESTST_35778da666b987b02b8cb887e66647a4Structure AttrZTC_GENERA_POLIZA_GRALResp;

public RESTRC_c791b0e7f92315f354525a79f511e845() { }

public RESTRC_c791b0e7f92315f354525a79f511e845 (RC_c791b0e7f92315f354525a79f511e845 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZTC_GENERA_POLIZA_GRALResp = ConvertToRestWithoutDefaults(s.ssSTZTC_GENERA_POLIZA_GRALResp, new ST_35778da666b987b02b8cb887e66647a4Structure(), ssConectaProveedores.RestRecords.RESTST_35778da666b987b02b8cb887e66647a4Structure.FromStructure, config);
  } else {
AttrZTC_GENERA_POLIZA_GRALResp = ssConectaProveedores.RestRecords.RESTST_35778da666b987b02b8cb887e66647a4Structure.FromStructure(s.ssSTZTC_GENERA_POLIZA_GRALResp, config);
  }
}

public static RC_c791b0e7f92315f354525a79f511e845 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c791b0e7f92315f354525a79f511e845 obj) { 
  RC_c791b0e7f92315f354525a79f511e845 s = new RC_c791b0e7f92315f354525a79f511e845();
  if(obj != null) {
  s.ssSTZTC_GENERA_POLIZA_GRALResp = ssConectaProveedores.RestRecords.RESTST_35778da666b987b02b8cb887e66647a4Structure.ToStructure(obj.AttrZTC_GENERA_POLIZA_GRALResp);
  }
  return s;
}

public static Func<RC_c791b0e7f92315f354525a79f511e845, ssConectaProveedores.RestRecords.RESTRC_c791b0e7f92315f354525a79f511e845> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c791b0e7f92315f354525a79f511e845 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c791b0e7f92315f354525a79f511e845 FromStructure(RC_c791b0e7f92315f354525a79f511e845 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c791b0e7f92315f354525a79f511e845(s, config);
}

}


