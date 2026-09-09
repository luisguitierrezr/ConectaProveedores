using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FinishUpdateEmailFailureReasonRecord
public class JSONRC_9808e19d66784f7acd0d80b7d130df17 : AbstractRESTStructure<RC_9808e19d66784f7acd0d80b7d130df17> {
[JsonProperty("FinishUpdateEmailFailureReason")]
[JsonPropertyName("FinishUpdateEmailFailureReason")]
public ssConectaProveedores.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure AttrFinishUpdateEmailFailureReason;

public JSONRC_9808e19d66784f7acd0d80b7d130df17() { }

public JSONRC_9808e19d66784f7acd0d80b7d130df17 (RC_9808e19d66784f7acd0d80b7d130df17 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFinishUpdateEmailFailureReason = ConvertToRestWithoutDefaults(s.ssSTFinishUpdateEmailFailureReason, new ST_23034956e06e8e0a2169e5e731331735Structure(), ssConectaProveedores.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure.FromStructure, config);
  } else {
AttrFinishUpdateEmailFailureReason = ssConectaProveedores.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure.FromStructure(s.ssSTFinishUpdateEmailFailureReason, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9808e19d66784f7acd0d80b7d130df17, RC_9808e19d66784f7acd0d80b7d130df17> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9808e19d66784f7acd0d80b7d130df17 s) => ToStructure(s, config);
}
public static RC_9808e19d66784f7acd0d80b7d130df17 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9808e19d66784f7acd0d80b7d130df17 obj, IBehaviorsConfiguration config) { 
  RC_9808e19d66784f7acd0d80b7d130df17 s = new RC_9808e19d66784f7acd0d80b7d130df17();
  if(obj != null) {
  s.ssSTFinishUpdateEmailFailureReason = ssConectaProveedores.RestRecords.JSONST_23034956e06e8e0a2169e5e731331735Structure.ToStructure(obj.AttrFinishUpdateEmailFailureReason, config);
  }
  return s;
}

public static Func<RC_9808e19d66784f7acd0d80b7d130df17, ssConectaProveedores.RestRecords.JSONRC_9808e19d66784f7acd0d80b7d130df17> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9808e19d66784f7acd0d80b7d130df17 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9808e19d66784f7acd0d80b7d130df17 FromStructure(RC_9808e19d66784f7acd0d80b7d130df17 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9808e19d66784f7acd0d80b7d130df17(s, config);
}

}


