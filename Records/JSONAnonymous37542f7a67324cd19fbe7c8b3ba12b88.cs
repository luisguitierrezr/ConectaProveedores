using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserEntraRoleUserExtensionUser_Extended_InternalDepartmentTelcelDirectionRecord
public class JSONRC_334fa46a307bf0dfedbddfd14d3375f8 : AbstractRESTStructure<RC_334fa46a307bf0dfedbddfd14d3375f8> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Department")]
[JsonPropertyName("Department")]
public ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord AttrDepartment;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

public JSONRC_334fa46a307bf0dfedbddfd14d3375f8() { }

public JSONRC_334fa46a307bf0dfedbddfd14d3375f8 (RC_334fa46a307bf0dfedbddfd14d3375f8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrDepartment = ConvertToRestWithoutDefaults(s.ssENDepartment, new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure, config);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrDepartment = ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.FromStructure(s.ssENDepartment, config);
AttrTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_334fa46a307bf0dfedbddfd14d3375f8, RC_334fa46a307bf0dfedbddfd14d3375f8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_334fa46a307bf0dfedbddfd14d3375f8 s) => ToStructure(s, config);
}
public static RC_334fa46a307bf0dfedbddfd14d3375f8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_334fa46a307bf0dfedbddfd14d3375f8 obj, IBehaviorsConfiguration config) { 
  RC_334fa46a307bf0dfedbddfd14d3375f8 s = new RC_334fa46a307bf0dfedbddfd14d3375f8();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENDepartment = ssConectaProveedores.RestRecords.JSONEN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord.ToStructure(obj.AttrDepartment, config);
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection, config);
  }
  return s;
}

public static Func<RC_334fa46a307bf0dfedbddfd14d3375f8, ssConectaProveedores.RestRecords.JSONRC_334fa46a307bf0dfedbddfd14d3375f8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_334fa46a307bf0dfedbddfd14d3375f8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_334fa46a307bf0dfedbddfd14d3375f8 FromStructure(RC_334fa46a307bf0dfedbddfd14d3375f8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_334fa46a307bf0dfedbddfd14d3375f8(s, config);
}

}


