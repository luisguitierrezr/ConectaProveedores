using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleConceptApplicationRoleEntraRoleRecord
public class RESTRC_87cc7367398744031899074e30b93bba : AbstractRESTStructure<RC_87cc7367398744031899074e30b93bba> {
[JsonProperty("RoleConcept")]
public ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord AttrRoleConcept;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public RESTRC_87cc7367398744031899074e30b93bba() { }

public RESTRC_87cc7367398744031899074e30b93bba (RC_87cc7367398744031899074e30b93bba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRoleConcept = ConvertToRestWithoutDefaults(s.ssENRoleConcept, new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrRoleConcept = ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure(s.ssENRoleConcept, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static RC_87cc7367398744031899074e30b93bba ToStructure(ssConectaProveedores.RestRecords.RESTRC_87cc7367398744031899074e30b93bba obj) { 
  RC_87cc7367398744031899074e30b93bba s = new RC_87cc7367398744031899074e30b93bba();
  if(obj != null) {
  s.ssENRoleConcept = ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.ToStructure(obj.AttrRoleConcept);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  }
  return s;
}

public static Func<RC_87cc7367398744031899074e30b93bba, ssConectaProveedores.RestRecords.RESTRC_87cc7367398744031899074e30b93bba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87cc7367398744031899074e30b93bba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_87cc7367398744031899074e30b93bba FromStructure(RC_87cc7367398744031899074e30b93bba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_87cc7367398744031899074e30b93bba(s, config);
}

}


