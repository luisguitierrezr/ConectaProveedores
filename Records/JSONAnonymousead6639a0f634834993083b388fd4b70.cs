using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRoleApplicationRoleRecord
public class JSONRC_c2921a936d592680b8275006015423c4 : AbstractRESTStructure<RC_c2921a936d592680b8275006015423c4> {
[JsonProperty("UserApplicationRole")]
[JsonPropertyName("UserApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_c2921a936d592680b8275006015423c4() { }

public JSONRC_c2921a936d592680b8275006015423c4 (RC_c2921a936d592680b8275006015423c4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_c2921a936d592680b8275006015423c4, RC_c2921a936d592680b8275006015423c4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_c2921a936d592680b8275006015423c4 s) => ToStructure(s, config);
}
public static RC_c2921a936d592680b8275006015423c4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_c2921a936d592680b8275006015423c4 obj, IBehaviorsConfiguration config) { 
  RC_c2921a936d592680b8275006015423c4 s = new RC_c2921a936d592680b8275006015423c4();
  if(obj != null) {
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_c2921a936d592680b8275006015423c4, ssConectaProveedores.RestRecords.JSONRC_c2921a936d592680b8275006015423c4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c2921a936d592680b8275006015423c4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_c2921a936d592680b8275006015423c4 FromStructure(RC_c2921a936d592680b8275006015423c4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_c2921a936d592680b8275006015423c4(s, config);
}

}


