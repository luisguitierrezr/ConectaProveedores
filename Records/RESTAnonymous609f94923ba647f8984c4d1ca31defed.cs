using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntraRoleUser_Extended_InternalRegionRecord
public class RESTRC_a977e4ee3fe611d1f9a8a51587df5f57 : AbstractRESTStructure<RC_a977e4ee3fe611d1f9a8a51587df5f57> {
[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_a977e4ee3fe611d1f9a8a51587df5f57() { }

public RESTRC_a977e4ee3fe611d1f9a8a51587df5f57 (RC_a977e4ee3fe611d1f9a8a51587df5f57 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_a977e4ee3fe611d1f9a8a51587df5f57 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a977e4ee3fe611d1f9a8a51587df5f57 obj) { 
  RC_a977e4ee3fe611d1f9a8a51587df5f57 s = new RC_a977e4ee3fe611d1f9a8a51587df5f57();
  if(obj != null) {
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_a977e4ee3fe611d1f9a8a51587df5f57, ssConectaProveedores.RestRecords.RESTRC_a977e4ee3fe611d1f9a8a51587df5f57> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a977e4ee3fe611d1f9a8a51587df5f57 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a977e4ee3fe611d1f9a8a51587df5f57 FromStructure(RC_a977e4ee3fe611d1f9a8a51587df5f57 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a977e4ee3fe611d1f9a8a51587df5f57(s, config);
}

}


