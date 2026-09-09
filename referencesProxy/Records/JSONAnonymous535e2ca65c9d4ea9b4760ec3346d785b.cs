using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ApplicationRoleRecord
public class JSONRC_ceec47435de563c2690b605ecca69a94 : AbstractRESTStructure<RC_ceec47435de563c2690b605ecca69a94> {
[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_ceec47435de563c2690b605ecca69a94() { }

public JSONRC_ceec47435de563c2690b605ecca69a94 (RC_ceec47435de563c2690b605ecca69a94 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrApplicationRole = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ceec47435de563c2690b605ecca69a94, RC_ceec47435de563c2690b605ecca69a94> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ceec47435de563c2690b605ecca69a94 s) => ToStructure(s, config);
}
public static RC_ceec47435de563c2690b605ecca69a94 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ceec47435de563c2690b605ecca69a94 obj, IBehaviorsConfiguration config) { 
  RC_ceec47435de563c2690b605ecca69a94 s = new RC_ceec47435de563c2690b605ecca69a94();
  if(obj != null) {
  s.ssENApplicationRole = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_ceec47435de563c2690b605ecca69a94, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ceec47435de563c2690b605ecca69a94> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ceec47435de563c2690b605ecca69a94 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ceec47435de563c2690b605ecca69a94 FromStructure(RC_ceec47435de563c2690b605ecca69a94 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ceec47435de563c2690b605ecca69a94(s, config);
}

}


