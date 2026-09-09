using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FinishResetPasswordFailureReasonRecord
public class RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d : AbstractRESTStructure<RC_1ba3db8c7175cd095b4f1a36c3a1e53d> {
[JsonProperty("FinishResetPasswordFailureReason")]
public ssConectaProveedores.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure AttrFinishResetPasswordFailureReason;

public RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d() { }

public RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d (RC_1ba3db8c7175cd095b4f1a36c3a1e53d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishResetPasswordFailureReason = ConvertToRestWithoutDefaults(s.ssSTFinishResetPasswordFailureReason, new ST_9b153b9b179efd305d9e3eb52006065fStructure(), ssConectaProveedores.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructure, config);
  } else {
AttrFinishResetPasswordFailureReason = ssConectaProveedores.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructure(s.ssSTFinishResetPasswordFailureReason, config);
  }
}

public static RC_1ba3db8c7175cd095b4f1a36c3a1e53d ToStructure(ssConectaProveedores.RestRecords.RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d obj) { 
  RC_1ba3db8c7175cd095b4f1a36c3a1e53d s = new RC_1ba3db8c7175cd095b4f1a36c3a1e53d();
  if(obj != null) {
  s.ssSTFinishResetPasswordFailureReason = ssConectaProveedores.RestRecords.RESTST_9b153b9b179efd305d9e3eb52006065fStructure.ToStructure(obj.AttrFinishResetPasswordFailureReason);
  }
  return s;
}

public static Func<RC_1ba3db8c7175cd095b4f1a36c3a1e53d, ssConectaProveedores.RestRecords.RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1ba3db8c7175cd095b4f1a36c3a1e53d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d FromStructure(RC_1ba3db8c7175cd095b4f1a36c3a1e53d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1ba3db8c7175cd095b4f1a36c3a1e53d(s, config);
}

}


