using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelApprovalProcessApplicationRoleRecord
public class JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f : AbstractRESTStructure<RC_3cc958ea69e2da94e66c1d6c79d0b67f> {
[JsonProperty("ApprovalProcessLevel")]
[JsonPropertyName("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("ApprovalProcess")]
[JsonPropertyName("ApprovalProcess")]
public ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f() { }

public JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f (RC_3cc958ea69e2da94e66c1d6c79d0b67f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f, RC_3cc958ea69e2da94e66c1d6c79d0b67f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f s) => ToStructure(s, config);
}
public static RC_3cc958ea69e2da94e66c1d6c79d0b67f ToStructure(ssConectaProveedores.RestRecords.JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f obj, IBehaviorsConfiguration config) { 
  RC_3cc958ea69e2da94e66c1d6c79d0b67f s = new RC_3cc958ea69e2da94e66c1d6c79d0b67f();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.JSONEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel, config);
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.JSONEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_3cc958ea69e2da94e66c1d6c79d0b67f, ssConectaProveedores.RestRecords.JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3cc958ea69e2da94e66c1d6c79d0b67f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f FromStructure(RC_3cc958ea69e2da94e66c1d6c79d0b67f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3cc958ea69e2da94e66c1d6c79d0b67f(s, config);
}

}


