using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRoleConceptEntraRoleUser_Extended_InternalRecord
public class RESTRC_552c926b5ae43c594aa2b0762b255928 : AbstractRESTStructure<RC_552c926b5ae43c594aa2b0762b255928> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("RoleConcept")]
public ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord AttrRoleConcept;

[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

[JsonProperty("User_Extended_Internal")]
public ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord AttrUser_Extended_Internal;

public RESTRC_552c926b5ae43c594aa2b0762b255928() { }

public RESTRC_552c926b5ae43c594aa2b0762b255928 (RC_552c926b5ae43c594aa2b0762b255928 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrRoleConcept = ConvertToRestWithoutDefaults(s.ssENRoleConcept, new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
AttrUser_Extended_Internal = ConvertToRestWithoutDefaults(s.ssENUser_Extended_Internal, new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrRoleConcept = ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure(s.ssENRoleConcept, config);
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
AttrUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.FromStructure(s.ssENUser_Extended_Internal, config);
  }
}

public static RC_552c926b5ae43c594aa2b0762b255928 ToStructure(ssConectaProveedores.RestRecords.RESTRC_552c926b5ae43c594aa2b0762b255928 obj) { 
  RC_552c926b5ae43c594aa2b0762b255928 s = new RC_552c926b5ae43c594aa2b0762b255928();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENRoleConcept = ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.ToStructure(obj.AttrRoleConcept);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  s.ssENUser_Extended_Internal = ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord.ToStructure(obj.AttrUser_Extended_Internal);
  }
  return s;
}

public static Func<RC_552c926b5ae43c594aa2b0762b255928, ssConectaProveedores.RestRecords.RESTRC_552c926b5ae43c594aa2b0762b255928> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_552c926b5ae43c594aa2b0762b255928 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_552c926b5ae43c594aa2b0762b255928 FromStructure(RC_552c926b5ae43c594aa2b0762b255928 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_552c926b5ae43c594aa2b0762b255928(s, config);
}

}


