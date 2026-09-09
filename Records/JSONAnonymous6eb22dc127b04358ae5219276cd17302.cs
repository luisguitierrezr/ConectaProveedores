using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZTC_GENERA_POLIZA_GRALRespRecord
public class JSONRC_c791b0e7f92315f354525a79f511e845 : AbstractRESTStructure<RC_c791b0e7f92315f354525a79f511e845> {
[JsonProperty("ZTC_GENERA_POLIZA_GRALResp")]
[JsonPropertyName("ZTC_GENERA_POLIZA_GRALResp")]
public ssConectaProveedores.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure AttrZTC_GENERA_POLIZA_GRALResp;

public JSONRC_c791b0e7f92315f354525a79f511e845() { }

public JSONRC_c791b0e7f92315f354525a79f511e845 (RC_c791b0e7f92315f354525a79f511e845 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZTC_GENERA_POLIZA_GRALResp = ConvertToRestWithoutDefaults(s.ssSTZTC_GENERA_POLIZA_GRALResp, new ST_35778da666b987b02b8cb887e66647a4Structure(), ssConectaProveedores.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure.FromStructure, config);
  } else {
AttrZTC_GENERA_POLIZA_GRALResp = ssConectaProveedores.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure.FromStructure(s.ssSTZTC_GENERA_POLIZA_GRALResp, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c791b0e7f92315f354525a79f511e845, RC_c791b0e7f92315f354525a79f511e845> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c791b0e7f92315f354525a79f511e845 s) => ToStructure(s, config);
}
public static RC_c791b0e7f92315f354525a79f511e845 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c791b0e7f92315f354525a79f511e845 obj, IBehaviorsConfiguration config) { 
  RC_c791b0e7f92315f354525a79f511e845 s = new RC_c791b0e7f92315f354525a79f511e845();
  if(obj != null) {
  s.ssSTZTC_GENERA_POLIZA_GRALResp = ssConectaProveedores.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure.ToStructure(obj.AttrZTC_GENERA_POLIZA_GRALResp, config);
  }
  return s;
}

public static Func<RC_c791b0e7f92315f354525a79f511e845, ssConectaProveedores.RestRecords.JSONRC_c791b0e7f92315f354525a79f511e845> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c791b0e7f92315f354525a79f511e845 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c791b0e7f92315f354525a79f511e845 FromStructure(RC_c791b0e7f92315f354525a79f511e845 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c791b0e7f92315f354525a79f511e845(s, config);
}

}


