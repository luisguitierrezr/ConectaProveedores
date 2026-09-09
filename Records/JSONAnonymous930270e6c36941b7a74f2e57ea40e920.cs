using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FinishResetPasswordFailureReasonRecord
public class JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d : AbstractRESTStructure<RC_1ba3db8c7175cd095b4f1a36c3a1e53d> {
[JsonProperty("FinishResetPasswordFailureReason")]
[JsonPropertyName("FinishResetPasswordFailureReason")]
public ssConectaProveedores.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure AttrFinishResetPasswordFailureReason;

public JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d() { }

public JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d (RC_1ba3db8c7175cd095b4f1a36c3a1e53d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishResetPasswordFailureReason = ConvertToRestWithoutDefaults(s.ssSTFinishResetPasswordFailureReason, new ST_9b153b9b179efd305d9e3eb52006065fStructure(), ssConectaProveedores.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructure, config);
  } else {
AttrFinishResetPasswordFailureReason = ssConectaProveedores.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.FromStructure(s.ssSTFinishResetPasswordFailureReason, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d, RC_1ba3db8c7175cd095b4f1a36c3a1e53d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d s) => ToStructure(s, config);
}
public static RC_1ba3db8c7175cd095b4f1a36c3a1e53d ToStructure(ssConectaProveedores.RestRecords.JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d obj, IBehaviorsConfiguration config) { 
  RC_1ba3db8c7175cd095b4f1a36c3a1e53d s = new RC_1ba3db8c7175cd095b4f1a36c3a1e53d();
  if(obj != null) {
  s.ssSTFinishResetPasswordFailureReason = ssConectaProveedores.RestRecords.JSONST_9b153b9b179efd305d9e3eb52006065fStructure.ToStructure(obj.AttrFinishResetPasswordFailureReason, config);
  }
  return s;
}

public static Func<RC_1ba3db8c7175cd095b4f1a36c3a1e53d, ssConectaProveedores.RestRecords.JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1ba3db8c7175cd095b4f1a36c3a1e53d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d FromStructure(RC_1ba3db8c7175cd095b4f1a36c3a1e53d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1ba3db8c7175cd095b4f1a36c3a1e53d(s, config);
}

}


