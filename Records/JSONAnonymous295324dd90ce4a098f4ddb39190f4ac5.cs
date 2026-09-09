using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ChangePasswordFailureReasonRecord
public class JSONRC_e5c662d406f83f7f791bd7e5c8b0c543 : AbstractRESTStructure<RC_e5c662d406f83f7f791bd7e5c8b0c543> {
[JsonProperty("ChangePasswordFailureReason")]
[JsonPropertyName("ChangePasswordFailureReason")]
public ssConectaProveedores.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure AttrChangePasswordFailureReason;

public JSONRC_e5c662d406f83f7f791bd7e5c8b0c543() { }

public JSONRC_e5c662d406f83f7f791bd7e5c8b0c543 (RC_e5c662d406f83f7f791bd7e5c8b0c543 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrChangePasswordFailureReason = ConvertToRestWithoutDefaults(s.ssSTChangePasswordFailureReason, new ST_896e066bc5a2d27c8f6a276746e82800Structure(), ssConectaProveedores.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure.FromStructure, config);
  } else {
AttrChangePasswordFailureReason = ssConectaProveedores.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure.FromStructure(s.ssSTChangePasswordFailureReason, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e5c662d406f83f7f791bd7e5c8b0c543, RC_e5c662d406f83f7f791bd7e5c8b0c543> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e5c662d406f83f7f791bd7e5c8b0c543 s) => ToStructure(s, config);
}
public static RC_e5c662d406f83f7f791bd7e5c8b0c543 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e5c662d406f83f7f791bd7e5c8b0c543 obj, IBehaviorsConfiguration config) { 
  RC_e5c662d406f83f7f791bd7e5c8b0c543 s = new RC_e5c662d406f83f7f791bd7e5c8b0c543();
  if(obj != null) {
  s.ssSTChangePasswordFailureReason = ssConectaProveedores.RestRecords.JSONST_896e066bc5a2d27c8f6a276746e82800Structure.ToStructure(obj.AttrChangePasswordFailureReason, config);
  }
  return s;
}

public static Func<RC_e5c662d406f83f7f791bd7e5c8b0c543, ssConectaProveedores.RestRecords.JSONRC_e5c662d406f83f7f791bd7e5c8b0c543> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e5c662d406f83f7f791bd7e5c8b0c543 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e5c662d406f83f7f791bd7e5c8b0c543 FromStructure(RC_e5c662d406f83f7f791bd7e5c8b0c543 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e5c662d406f83f7f791bd7e5c8b0c543(s, config);
}

}


