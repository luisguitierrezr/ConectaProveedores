using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserEntraRoleUserExtensionUser_Extended_InternalTelcelDirectionRecord
public class JSONRC_097150223bd4f9024b41b58833c5a636 : AbstractRESTStructure<RC_097150223bd4f9024b41b58833c5a636> {
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

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

public JSONRC_097150223bd4f9024b41b58833c5a636() { }

public JSONRC_097150223bd4f9024b41b58833c5a636 (RC_097150223bd4f9024b41b58833c5a636 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_097150223bd4f9024b41b58833c5a636, RC_097150223bd4f9024b41b58833c5a636> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_097150223bd4f9024b41b58833c5a636 s) => ToStructure(s, config);
}
public static RC_097150223bd4f9024b41b58833c5a636 ToStructure(ssConectaProveedores.RestRecords.JSONRC_097150223bd4f9024b41b58833c5a636 obj, IBehaviorsConfiguration config) { 
  RC_097150223bd4f9024b41b58833c5a636 s = new RC_097150223bd4f9024b41b58833c5a636();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection, config);
  }
  return s;
}

public static Func<RC_097150223bd4f9024b41b58833c5a636, ssConectaProveedores.RestRecords.JSONRC_097150223bd4f9024b41b58833c5a636> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_097150223bd4f9024b41b58833c5a636 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_097150223bd4f9024b41b58833c5a636 FromStructure(RC_097150223bd4f9024b41b58833c5a636 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_097150223bd4f9024b41b58833c5a636(s, config);
}

}


