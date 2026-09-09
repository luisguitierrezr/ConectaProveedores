using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserApplicationRoleApplicationRoleUser_Extended_InternalRegionRecord
public class JSONRC_82a9276cec67a3d539884db9fd67d1e2 : AbstractRESTStructure<RC_82a9276cec67a3d539884db9fd67d1e2> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("UserApplicationRole")]
[JsonPropertyName("UserApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_82a9276cec67a3d539884db9fd67d1e2() { }

public JSONRC_82a9276cec67a3d539884db9fd67d1e2 (RC_82a9276cec67a3d539884db9fd67d1e2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_82a9276cec67a3d539884db9fd67d1e2, RC_82a9276cec67a3d539884db9fd67d1e2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_82a9276cec67a3d539884db9fd67d1e2 s) => ToStructure(s, config);
}
public static RC_82a9276cec67a3d539884db9fd67d1e2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_82a9276cec67a3d539884db9fd67d1e2 obj, IBehaviorsConfiguration config) { 
  RC_82a9276cec67a3d539884db9fd67d1e2 s = new RC_82a9276cec67a3d539884db9fd67d1e2();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_82a9276cec67a3d539884db9fd67d1e2, ssConectaProveedores.RestRecords.JSONRC_82a9276cec67a3d539884db9fd67d1e2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_82a9276cec67a3d539884db9fd67d1e2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_82a9276cec67a3d539884db9fd67d1e2 FromStructure(RC_82a9276cec67a3d539884db9fd67d1e2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_82a9276cec67a3d539884db9fd67d1e2(s, config);
}

}


