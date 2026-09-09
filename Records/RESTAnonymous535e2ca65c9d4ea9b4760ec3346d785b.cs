using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicationRoleRecord
public class RESTRC_ceec47435de563c2690b605ecca69a94 : AbstractRESTStructure<RC_ceec47435de563c2690b605ecca69a94> {
[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public RESTRC_ceec47435de563c2690b605ecca69a94() { }

public RESTRC_ceec47435de563c2690b605ecca69a94 (RC_ceec47435de563c2690b605ecca69a94 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static RC_ceec47435de563c2690b605ecca69a94 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ceec47435de563c2690b605ecca69a94 obj) { 
  RC_ceec47435de563c2690b605ecca69a94 s = new RC_ceec47435de563c2690b605ecca69a94();
  if(obj != null) {
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  }
  return s;
}

public static Func<RC_ceec47435de563c2690b605ecca69a94, ssConectaProveedores.RestRecords.RESTRC_ceec47435de563c2690b605ecca69a94> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ceec47435de563c2690b605ecca69a94 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ceec47435de563c2690b605ecca69a94 FromStructure(RC_ceec47435de563c2690b605ecca69a94 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ceec47435de563c2690b605ecca69a94(s, config);
}

}


