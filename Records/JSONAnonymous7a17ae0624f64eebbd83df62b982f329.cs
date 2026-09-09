using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_AssignedByUser_RevokedApplicationRoleUserApplicationRoleTempRoleStatusRecord
public class JSONRC_284d6b812acb53aa55a28cbe2a22b4ca : AbstractRESTStructure<RC_284d6b812acb53aa55a28cbe2a22b4ca> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("User_AssignedBy")]
[JsonPropertyName("User_AssignedBy")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_AssignedBy;

[JsonProperty("User_Revoked")]
[JsonPropertyName("User_Revoked")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Revoked;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("UserApplicationRoleTemp")]
[JsonPropertyName("UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord AttrUserApplicationRoleTemp;

[JsonProperty("RoleStatus")]
[JsonPropertyName("RoleStatus")]
public ssConectaProveedores.RestRecords.JSONEN_fee44a96be32c0c9f1bda470eac56718EntityRecord AttrRoleStatus;

public JSONRC_284d6b812acb53aa55a28cbe2a22b4ca() { }

public JSONRC_284d6b812acb53aa55a28cbe2a22b4ca (RC_284d6b812acb53aa55a28cbe2a22b4ca s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_AssignedBy = ConvertToRestWithoutDefaults(s.ssENUser_AssignedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Revoked = ConvertToRestWithoutDefaults(s.ssENUser_Revoked, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrUserApplicationRoleTemp = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTemp, new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure, config);
AttrRoleStatus = ConvertToRestWithoutDefaults(s.ssENRoleStatus, new EN_fee44a96be32c0c9f1bda470eac56718EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_AssignedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_AssignedBy, config);
AttrUser_Revoked = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Revoked, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrUserApplicationRoleTemp = ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(s.ssENUserApplicationRoleTemp, config);
AttrRoleStatus = ssConectaProveedores.RestRecords.JSONEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.FromStructure(s.ssENRoleStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_284d6b812acb53aa55a28cbe2a22b4ca, RC_284d6b812acb53aa55a28cbe2a22b4ca> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_284d6b812acb53aa55a28cbe2a22b4ca s) => ToStructure(s, config);
}
public static RC_284d6b812acb53aa55a28cbe2a22b4ca ToStructure(ssConectaProveedores.RestRecords.JSONRC_284d6b812acb53aa55a28cbe2a22b4ca obj, IBehaviorsConfiguration config) { 
  RC_284d6b812acb53aa55a28cbe2a22b4ca s = new RC_284d6b812acb53aa55a28cbe2a22b4ca();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUser_AssignedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_AssignedBy, config);
  s.ssENUser_Revoked = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Revoked, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  s.ssENUserApplicationRoleTemp = ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(obj.AttrUserApplicationRoleTemp, config);
  s.ssENRoleStatus = ssConectaProveedores.RestRecords.JSONEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.ToStructure(obj.AttrRoleStatus, config);
  }
  return s;
}

public static Func<RC_284d6b812acb53aa55a28cbe2a22b4ca, ssConectaProveedores.RestRecords.JSONRC_284d6b812acb53aa55a28cbe2a22b4ca> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_284d6b812acb53aa55a28cbe2a22b4ca s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_284d6b812acb53aa55a28cbe2a22b4ca FromStructure(RC_284d6b812acb53aa55a28cbe2a22b4ca s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_284d6b812acb53aa55a28cbe2a22b4ca(s, config);
}

}


