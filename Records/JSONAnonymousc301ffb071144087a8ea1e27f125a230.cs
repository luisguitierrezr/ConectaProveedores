using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRoleApplicationRoleUser_Extended_InternalRegionRecord
public class JSONRC_407f3f6863feafe144ff5ca8c500a81b : AbstractRESTStructure<RC_407f3f6863feafe144ff5ca8c500a81b> {
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

public JSONRC_407f3f6863feafe144ff5ca8c500a81b() { }

public JSONRC_407f3f6863feafe144ff5ca8c500a81b (RC_407f3f6863feafe144ff5ca8c500a81b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_407f3f6863feafe144ff5ca8c500a81b, RC_407f3f6863feafe144ff5ca8c500a81b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_407f3f6863feafe144ff5ca8c500a81b s) => ToStructure(s, config);
}
public static RC_407f3f6863feafe144ff5ca8c500a81b ToStructure(ssConectaProveedores.RestRecords.JSONRC_407f3f6863feafe144ff5ca8c500a81b obj, IBehaviorsConfiguration config) { 
  RC_407f3f6863feafe144ff5ca8c500a81b s = new RC_407f3f6863feafe144ff5ca8c500a81b();
  if(obj != null) {
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_407f3f6863feafe144ff5ca8c500a81b, ssConectaProveedores.RestRecords.JSONRC_407f3f6863feafe144ff5ca8c500a81b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_407f3f6863feafe144ff5ca8c500a81b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_407f3f6863feafe144ff5ca8c500a81b FromStructure(RC_407f3f6863feafe144ff5ca8c500a81b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_407f3f6863feafe144ff5ca8c500a81b(s, config);
}

}


