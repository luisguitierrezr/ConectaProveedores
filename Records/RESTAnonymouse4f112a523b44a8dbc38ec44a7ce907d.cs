using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserApplicationRoleUser_Extended_InternalRecord
public class RESTRC_d4fdf5fe986f15577c3a6610348f52f6 : AbstractRESTStructure<RC_d4fdf5fe986f15577c3a6610348f52f6> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("UserApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public RESTRC_d4fdf5fe986f15577c3a6610348f52f6() { }

public RESTRC_d4fdf5fe986f15577c3a6610348f52f6 (RC_d4fdf5fe986f15577c3a6610348f52f6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserApplicationRole = ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static RC_d4fdf5fe986f15577c3a6610348f52f6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d4fdf5fe986f15577c3a6610348f52f6 obj) { 
  RC_d4fdf5fe986f15577c3a6610348f52f6 s = new RC_d4fdf5fe986f15577c3a6610348f52f6();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.RESTEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  }
  return s;
}

public static Func<RC_d4fdf5fe986f15577c3a6610348f52f6, ssConectaProveedores.RestRecords.RESTRC_d4fdf5fe986f15577c3a6610348f52f6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d4fdf5fe986f15577c3a6610348f52f6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d4fdf5fe986f15577c3a6610348f52f6 FromStructure(RC_d4fdf5fe986f15577c3a6610348f52f6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d4fdf5fe986f15577c3a6610348f52f6(s, config);
}

}


