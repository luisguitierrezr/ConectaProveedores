using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserApplicationRoleApplicationRoleRecord
public class JSONRC_79713d00f72f3f42333169ab2740c159 : AbstractRESTStructure<RC_79713d00f72f3f42333169ab2740c159> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("UserApplicationRole")]
[JsonPropertyName("UserApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_79713d00f72f3f42333169ab2740c159() { }

public JSONRC_79713d00f72f3f42333169ab2740c159 (RC_79713d00f72f3f42333169ab2740c159 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_79713d00f72f3f42333169ab2740c159, RC_79713d00f72f3f42333169ab2740c159> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_79713d00f72f3f42333169ab2740c159 s) => ToStructure(s, config);
}
public static RC_79713d00f72f3f42333169ab2740c159 ToStructure(ssConectaProveedores.RestRecords.JSONRC_79713d00f72f3f42333169ab2740c159 obj, IBehaviorsConfiguration config) { 
  RC_79713d00f72f3f42333169ab2740c159 s = new RC_79713d00f72f3f42333169ab2740c159();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_79713d00f72f3f42333169ab2740c159, ssConectaProveedores.RestRecords.JSONRC_79713d00f72f3f42333169ab2740c159> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_79713d00f72f3f42333169ab2740c159 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_79713d00f72f3f42333169ab2740c159 FromStructure(RC_79713d00f72f3f42333169ab2740c159 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_79713d00f72f3f42333169ab2740c159(s, config);
}

}


