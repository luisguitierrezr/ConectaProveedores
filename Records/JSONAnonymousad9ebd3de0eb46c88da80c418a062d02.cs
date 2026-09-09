using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserApplicationRoleUserExtensionRegionRecord
public class JSONRC_b1aef7e4555afd67b6953fcc571f18a7 : AbstractRESTStructure<RC_b1aef7e4555afd67b6953fcc571f18a7> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("UserApplicationRole")]
[JsonPropertyName("UserApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_b1aef7e4555afd67b6953fcc571f18a7() { }

public JSONRC_b1aef7e4555afd67b6953fcc571f18a7 (RC_b1aef7e4555afd67b6953fcc571f18a7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b1aef7e4555afd67b6953fcc571f18a7, RC_b1aef7e4555afd67b6953fcc571f18a7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b1aef7e4555afd67b6953fcc571f18a7 s) => ToStructure(s, config);
}
public static RC_b1aef7e4555afd67b6953fcc571f18a7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b1aef7e4555afd67b6953fcc571f18a7 obj, IBehaviorsConfiguration config) { 
  RC_b1aef7e4555afd67b6953fcc571f18a7 s = new RC_b1aef7e4555afd67b6953fcc571f18a7();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_b1aef7e4555afd67b6953fcc571f18a7, ssConectaProveedores.RestRecords.JSONRC_b1aef7e4555afd67b6953fcc571f18a7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b1aef7e4555afd67b6953fcc571f18a7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b1aef7e4555afd67b6953fcc571f18a7 FromStructure(RC_b1aef7e4555afd67b6953fcc571f18a7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b1aef7e4555afd67b6953fcc571f18a7(s, config);
}

}


