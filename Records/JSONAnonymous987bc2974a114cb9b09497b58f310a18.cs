using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserEntraRoleUser_Extended_InternalRecord
public class JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7 : AbstractRESTStructure<RC_aad5e0f2e56c05eeddd020d008f4b3d7> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7() { }

public JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7 (RC_aad5e0f2e56c05eeddd020d008f4b3d7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7, RC_aad5e0f2e56c05eeddd020d008f4b3d7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7 s) => ToStructure(s, config);
}
public static RC_aad5e0f2e56c05eeddd020d008f4b3d7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7 obj, IBehaviorsConfiguration config) { 
  RC_aad5e0f2e56c05eeddd020d008f4b3d7 s = new RC_aad5e0f2e56c05eeddd020d008f4b3d7();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  }
  return s;
}

public static Func<RC_aad5e0f2e56c05eeddd020d008f4b3d7, ssConectaProveedores.RestRecords.JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aad5e0f2e56c05eeddd020d008f4b3d7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7 FromStructure(RC_aad5e0f2e56c05eeddd020d008f4b3d7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_aad5e0f2e56c05eeddd020d008f4b3d7(s, config);
}

}


