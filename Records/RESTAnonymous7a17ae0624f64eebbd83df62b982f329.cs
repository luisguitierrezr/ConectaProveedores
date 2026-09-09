using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUser_AssignedByUser_RevokedApplicationRoleUserApplicationRoleTempRoleStatusRecord
public class RESTRC_284d6b812acb53aa55a28cbe2a22b4ca : AbstractRESTStructure<RC_284d6b812acb53aa55a28cbe2a22b4ca> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("User_AssignedBy")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_AssignedBy;

[JsonProperty("User_Revoked")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Revoked;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord AttrUserApplicationRoleTemp;

[JsonProperty("RoleStatus")]
public ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord AttrRoleStatus;

public RESTRC_284d6b812acb53aa55a28cbe2a22b4ca() { }

public RESTRC_284d6b812acb53aa55a28cbe2a22b4ca (RC_284d6b812acb53aa55a28cbe2a22b4ca s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_AssignedBy = ConvertToRestWithoutDefaults(s.ssENUser_AssignedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Revoked = ConvertToRestWithoutDefaults(s.ssENUser_Revoked, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrUserApplicationRoleTemp = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTemp, new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure, config);
AttrRoleStatus = ConvertToRestWithoutDefaults(s.ssENRoleStatus, new EN_fee44a96be32c0c9f1bda470eac56718EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUser_AssignedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_AssignedBy, config);
AttrUser_Revoked = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Revoked, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrUserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(s.ssENUserApplicationRoleTemp, config);
AttrRoleStatus = ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.FromStructure(s.ssENRoleStatus, config);
  }
}

public static RC_284d6b812acb53aa55a28cbe2a22b4ca ToStructure(ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca obj) { 
  RC_284d6b812acb53aa55a28cbe2a22b4ca s = new RC_284d6b812acb53aa55a28cbe2a22b4ca();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUser_AssignedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_AssignedBy);
  s.ssENUser_Revoked = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Revoked);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  s.ssENUserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(obj.AttrUserApplicationRoleTemp);
  s.ssENRoleStatus = ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord.ToStructure(obj.AttrRoleStatus);
  }
  return s;
}

public static Func<RC_284d6b812acb53aa55a28cbe2a22b4ca, ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_284d6b812acb53aa55a28cbe2a22b4ca s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca FromStructure(RC_284d6b812acb53aa55a28cbe2a22b4ca s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_284d6b812acb53aa55a28cbe2a22b4ca(s, config);
}

}


