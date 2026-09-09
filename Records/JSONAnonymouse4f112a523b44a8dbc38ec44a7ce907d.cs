using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserUserApplicationRoleUser_Extended_InternalRecord
public class JSONRC_d4fdf5fe986f15577c3a6610348f52f6 : AbstractRESTStructure<RC_d4fdf5fe986f15577c3a6610348f52f6> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("UserApplicationRole")]
[JsonPropertyName("UserApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord AttrUserApplicationRole;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public JSONRC_d4fdf5fe986f15577c3a6610348f52f6() { }

public JSONRC_d4fdf5fe986f15577c3a6610348f52f6 (RC_d4fdf5fe986f15577c3a6610348f52f6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUserApplicationRole = ConvertToRestWithoutDefaults(s.ssENUserApplicationRole, new EN_d70717a411b3cebe926da612400b1467EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.FromStructure(s.ssENUserApplicationRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d4fdf5fe986f15577c3a6610348f52f6, RC_d4fdf5fe986f15577c3a6610348f52f6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d4fdf5fe986f15577c3a6610348f52f6 s) => ToStructure(s, config);
}
public static RC_d4fdf5fe986f15577c3a6610348f52f6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d4fdf5fe986f15577c3a6610348f52f6 obj, IBehaviorsConfiguration config) { 
  RC_d4fdf5fe986f15577c3a6610348f52f6 s = new RC_d4fdf5fe986f15577c3a6610348f52f6();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENUserApplicationRole = ssConectaProveedores.RestRecords.JSONEN_d70717a411b3cebe926da612400b1467EntityRecord.ToStructure(obj.AttrUserApplicationRole, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  }
  return s;
}

public static Func<RC_d4fdf5fe986f15577c3a6610348f52f6, ssConectaProveedores.RestRecords.JSONRC_d4fdf5fe986f15577c3a6610348f52f6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d4fdf5fe986f15577c3a6610348f52f6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d4fdf5fe986f15577c3a6610348f52f6 FromStructure(RC_d4fdf5fe986f15577c3a6610348f52f6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d4fdf5fe986f15577c3a6610348f52f6(s, config);
}

}


