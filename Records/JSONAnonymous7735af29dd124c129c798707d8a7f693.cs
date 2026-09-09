using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRoleConceptEntraRoleUserExtensionUser_Extended_InternalRegionRecord
public class JSONRC_54a9ab3ba99fc61632c4ed43afcfc260 : AbstractRESTStructure<RC_54a9ab3ba99fc61632c4ed43afcfc260> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("RoleConcept")]
[JsonPropertyName("RoleConcept")]
public ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord AttrRoleConcept;

[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

[JsonProperty("UserExtension")]
[JsonPropertyName("UserExtension")]
public ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord AttrUserExtension;

[JsonProperty("User_Extended_Internal")]
[JsonPropertyName("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_54a9ab3ba99fc61632c4ed43afcfc260() { }

public JSONRC_54a9ab3ba99fc61632c4ed43afcfc260 (RC_54a9ab3ba99fc61632c4ed43afcfc260 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrRoleConcept = ConvertToRestWithoutDefaults(s.ssENRoleConcept, new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrUserExtension = ConvertToRestWithoutDefaults(s.ssENUserExtension, new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrRoleConcept = ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure(s.ssENRoleConcept, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.FromStructure(s.ssENUserExtension, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_54a9ab3ba99fc61632c4ed43afcfc260, RC_54a9ab3ba99fc61632c4ed43afcfc260> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_54a9ab3ba99fc61632c4ed43afcfc260 s) => ToStructure(s, config);
}
public static RC_54a9ab3ba99fc61632c4ed43afcfc260 ToStructure(ssConectaProveedores.RestRecords.JSONRC_54a9ab3ba99fc61632c4ed43afcfc260 obj, IBehaviorsConfiguration config) { 
  RC_54a9ab3ba99fc61632c4ed43afcfc260 s = new RC_54a9ab3ba99fc61632c4ed43afcfc260();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENRoleConcept = ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.ToStructure(obj.AttrRoleConcept, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  s.ssENUserExtension = ssConectaProveedores.RestRecords.JSONEN_f1e0c2ce033985fcca9f3086ab959521EntityRecord.ToStructure(obj.AttrUserExtension, config);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.JSONEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_54a9ab3ba99fc61632c4ed43afcfc260, ssConectaProveedores.RestRecords.JSONRC_54a9ab3ba99fc61632c4ed43afcfc260> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_54a9ab3ba99fc61632c4ed43afcfc260 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_54a9ab3ba99fc61632c4ed43afcfc260 FromStructure(RC_54a9ab3ba99fc61632c4ed43afcfc260 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_54a9ab3ba99fc61632c4ed43afcfc260(s, config);
}

}


