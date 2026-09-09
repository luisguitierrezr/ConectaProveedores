using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserLoginFailureReasonRecord
public class JSONRC_f61c868ef053db94121ce89ee15a14fe : AbstractRESTStructure<RC_f61c868ef053db94121ce89ee15a14fe> {
[JsonProperty("UserLoginFailureReason")]
[JsonPropertyName("UserLoginFailureReason")]
public ssConectaProveedores.RestRecords.JSONST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure AttrUserLoginFailureReason;

public JSONRC_f61c868ef053db94121ce89ee15a14fe() { }

public JSONRC_f61c868ef053db94121ce89ee15a14fe (RC_f61c868ef053db94121ce89ee15a14fe s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserLoginFailureReason = ConvertToRestWithoutDefaults(s.ssSTUserLoginFailureReason, new ST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure(), ssConectaProveedores.RestRecords.JSONST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.FromStructure, config);
  } else {
AttrUserLoginFailureReason = ssConectaProveedores.RestRecords.JSONST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.FromStructure(s.ssSTUserLoginFailureReason, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f61c868ef053db94121ce89ee15a14fe, RC_f61c868ef053db94121ce89ee15a14fe> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f61c868ef053db94121ce89ee15a14fe s) => ToStructure(s, config);
}
public static RC_f61c868ef053db94121ce89ee15a14fe ToStructure(ssConectaProveedores.RestRecords.JSONRC_f61c868ef053db94121ce89ee15a14fe obj, IBehaviorsConfiguration config) { 
  RC_f61c868ef053db94121ce89ee15a14fe s = new RC_f61c868ef053db94121ce89ee15a14fe();
  if(obj != null) {
  s.ssSTUserLoginFailureReason = ssConectaProveedores.RestRecords.JSONST_e2a9ab5ddca1e0d52c465d6a64ff98abStructure.ToStructure(obj.AttrUserLoginFailureReason, config);
  }
  return s;
}

public static Func<RC_f61c868ef053db94121ce89ee15a14fe, ssConectaProveedores.RestRecords.JSONRC_f61c868ef053db94121ce89ee15a14fe> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f61c868ef053db94121ce89ee15a14fe s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f61c868ef053db94121ce89ee15a14fe FromStructure(RC_f61c868ef053db94121ce89ee15a14fe s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f61c868ef053db94121ce89ee15a14fe(s, config);
}

}


