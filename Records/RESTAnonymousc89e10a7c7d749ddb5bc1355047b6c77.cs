using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_RequestRecord
public class RESTRC_11e209a1965a36ac5fa26385f1f26680 : AbstractRESTStructure<RC_11e209a1965a36ac5fa26385f1f26680> {
[JsonProperty("EM_SM_RM_COSMOZ_Request")]
public ssConectaProveedores.RestRecords.RESTST_c338780fd6468541199340ed93f1aecdStructure AttrEM_SM_RM_COSMOZ_Request;

public RESTRC_11e209a1965a36ac5fa26385f1f26680() { }

public RESTRC_11e209a1965a36ac5fa26385f1f26680 (RC_11e209a1965a36ac5fa26385f1f26680 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_RM_COSMOZ_Request = ConvertToRestWithoutDefaults(s.ssSTEM_SM_RM_COSMOZ_Request, new ST_c338780fd6468541199340ed93f1aecdStructure(), ssConectaProveedores.RestRecords.RESTST_c338780fd6468541199340ed93f1aecdStructure.FromStructure, config);
  } else {
AttrEM_SM_RM_COSMOZ_Request = ssConectaProveedores.RestRecords.RESTST_c338780fd6468541199340ed93f1aecdStructure.FromStructure(s.ssSTEM_SM_RM_COSMOZ_Request, config);
  }
}

public static RC_11e209a1965a36ac5fa26385f1f26680 ToStructure(ssConectaProveedores.RestRecords.RESTRC_11e209a1965a36ac5fa26385f1f26680 obj) { 
  RC_11e209a1965a36ac5fa26385f1f26680 s = new RC_11e209a1965a36ac5fa26385f1f26680();
  if(obj != null) {
  s.ssSTEM_SM_RM_COSMOZ_Request = ssConectaProveedores.RestRecords.RESTST_c338780fd6468541199340ed93f1aecdStructure.ToStructure(obj.AttrEM_SM_RM_COSMOZ_Request);
  }
  return s;
}

public static Func<RC_11e209a1965a36ac5fa26385f1f26680, ssConectaProveedores.RestRecords.RESTRC_11e209a1965a36ac5fa26385f1f26680> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_11e209a1965a36ac5fa26385f1f26680 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_11e209a1965a36ac5fa26385f1f26680 FromStructure(RC_11e209a1965a36ac5fa26385f1f26680 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_11e209a1965a36ac5fa26385f1f26680(s, config);
}

}


