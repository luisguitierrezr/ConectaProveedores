using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessLevelApprovalProcessApplicationRoleRecord
public class RESTRC_3cc958ea69e2da94e66c1d6c79d0b67f : AbstractRESTStructure<RC_3cc958ea69e2da94e66c1d6c79d0b67f> {
[JsonProperty("ApprovalProcessLevel")]
public ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord AttrApprovalProcessLevel;

[JsonProperty("ApprovalProcess")]
public ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord AttrApprovalProcess;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public RESTRC_3cc958ea69e2da94e66c1d6c79d0b67f() { }

public RESTRC_3cc958ea69e2da94e66c1d6c79d0b67f (RC_3cc958ea69e2da94e66c1d6c79d0b67f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessLevel = ConvertToRestWithoutDefaults(s.ssENApprovalProcessLevel, new EN_1d28318723f39133c60733b3cce8955eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure, config);
AttrApprovalProcess = ConvertToRestWithoutDefaults(s.ssENApprovalProcess, new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.FromStructure(s.ssENApprovalProcessLevel, config);
AttrApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructure(s.ssENApprovalProcess, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static RC_3cc958ea69e2da94e66c1d6c79d0b67f ToStructure(ssConectaProveedores.RestRecords.RESTRC_3cc958ea69e2da94e66c1d6c79d0b67f obj) { 
  RC_3cc958ea69e2da94e66c1d6c79d0b67f s = new RC_3cc958ea69e2da94e66c1d6c79d0b67f();
  if(obj != null) {
  s.ssENApprovalProcessLevel = ssConectaProveedores.RestRecords.RESTEN_1d28318723f39133c60733b3cce8955eEntityRecord.ToStructure(obj.AttrApprovalProcessLevel);
  s.ssENApprovalProcess = ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure(obj.AttrApprovalProcess);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  }
  return s;
}

public static Func<RC_3cc958ea69e2da94e66c1d6c79d0b67f, ssConectaProveedores.RestRecords.RESTRC_3cc958ea69e2da94e66c1d6c79d0b67f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3cc958ea69e2da94e66c1d6c79d0b67f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3cc958ea69e2da94e66c1d6c79d0b67f FromStructure(RC_3cc958ea69e2da94e66c1d6c79d0b67f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3cc958ea69e2da94e66c1d6c79d0b67f(s, config);
}

}


