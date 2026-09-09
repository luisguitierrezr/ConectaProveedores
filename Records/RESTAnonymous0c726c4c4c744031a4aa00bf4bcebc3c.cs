using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_RETEN_PROVEEDORESRespRecord
public class RESTRC_fb484da40dd0ef932a872c89efe253b4 : AbstractRESTStructure<RC_fb484da40dd0ef932a872c89efe253b4> {
[JsonProperty("ZMXFFIMF_RETEN_PROVEEDORESResp")]
public ssConectaProveedores.RestRecords.RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure AttrZMXFFIMF_RETEN_PROVEEDORESResp;

public RESTRC_fb484da40dd0ef932a872c89efe253b4() { }

public RESTRC_fb484da40dd0ef932a872c89efe253b4 (RC_fb484da40dd0ef932a872c89efe253b4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_RETEN_PROVEEDORESResp = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_RETEN_PROVEEDORESResp, new ST_b29967856499aeaa8c796dc87fe4c6e8Structure(), ssConectaProveedores.RestRecords.RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure.FromStructure, config);
  } else {
AttrZMXFFIMF_RETEN_PROVEEDORESResp = ssConectaProveedores.RestRecords.RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure.FromStructure(s.ssSTZMXFFIMF_RETEN_PROVEEDORESResp, config);
  }
}

public static RC_fb484da40dd0ef932a872c89efe253b4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_fb484da40dd0ef932a872c89efe253b4 obj) { 
  RC_fb484da40dd0ef932a872c89efe253b4 s = new RC_fb484da40dd0ef932a872c89efe253b4();
  if(obj != null) {
  s.ssSTZMXFFIMF_RETEN_PROVEEDORESResp = ssConectaProveedores.RestRecords.RESTST_b29967856499aeaa8c796dc87fe4c6e8Structure.ToStructure(obj.AttrZMXFFIMF_RETEN_PROVEEDORESResp);
  }
  return s;
}

public static Func<RC_fb484da40dd0ef932a872c89efe253b4, ssConectaProveedores.RestRecords.RESTRC_fb484da40dd0ef932a872c89efe253b4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fb484da40dd0ef932a872c89efe253b4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fb484da40dd0ef932a872c89efe253b4 FromStructure(RC_fb484da40dd0ef932a872c89efe253b4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fb484da40dd0ef932a872c89efe253b4(s, config);
}

}


