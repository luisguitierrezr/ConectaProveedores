using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserEntraRoleUser_Extended_InternalRecord
public class RESTRC_aad5e0f2e56c05eeddd020d008f4b3d7 : AbstractRESTStructure<RC_aad5e0f2e56c05eeddd020d008f4b3d7> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public RESTRC_aad5e0f2e56c05eeddd020d008f4b3d7() { }

public RESTRC_aad5e0f2e56c05eeddd020d008f4b3d7 (RC_aad5e0f2e56c05eeddd020d008f4b3d7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static RC_aad5e0f2e56c05eeddd020d008f4b3d7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_aad5e0f2e56c05eeddd020d008f4b3d7 obj) { 
  RC_aad5e0f2e56c05eeddd020d008f4b3d7 s = new RC_aad5e0f2e56c05eeddd020d008f4b3d7();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  }
  return s;
}

public static Func<RC_aad5e0f2e56c05eeddd020d008f4b3d7, ssConectaProveedores.RestRecords.RESTRC_aad5e0f2e56c05eeddd020d008f4b3d7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aad5e0f2e56c05eeddd020d008f4b3d7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_aad5e0f2e56c05eeddd020d008f4b3d7 FromStructure(RC_aad5e0f2e56c05eeddd020d008f4b3d7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_aad5e0f2e56c05eeddd020d008f4b3d7(s, config);
}

}


