using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserApplicationRoleApplicationRoleUser_Extended_InternalRecord
public class RESTRC_c77d66d9ff86c86854dcdb2c4c9f3219 : AbstractRESTStructure<RC_c77d66d9ff86c86854dcdb2c4c9f3219> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("UserApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public RESTRC_c77d66d9ff86c86854dcdb2c4c9f3219() { }

public RESTRC_c77d66d9ff86c86854dcdb2c4c9f3219 (RC_c77d66d9ff86c86854dcdb2c4c9f3219 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserApplicationRole = ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static RC_c77d66d9ff86c86854dcdb2c4c9f3219 ToStructure(ssConectaProveedores.RestRecords.RESTRC_c77d66d9ff86c86854dcdb2c4c9f3219 obj) { 
  RC_c77d66d9ff86c86854dcdb2c4c9f3219 s = new RC_c77d66d9ff86c86854dcdb2c4c9f3219();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  }
  return s;
}

public static Func<RC_c77d66d9ff86c86854dcdb2c4c9f3219, ssConectaProveedores.RestRecords.RESTRC_c77d66d9ff86c86854dcdb2c4c9f3219> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c77d66d9ff86c86854dcdb2c4c9f3219 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c77d66d9ff86c86854dcdb2c4c9f3219 FromStructure(RC_c77d66d9ff86c86854dcdb2c4c9f3219 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c77d66d9ff86c86854dcdb2c4c9f3219(s, config);
}

}


