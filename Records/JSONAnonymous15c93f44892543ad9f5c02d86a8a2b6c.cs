using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleConceptApplicationRoleEntraRoleRecord
public class JSONRC_87cc7367398744031899074e30b93bba : AbstractRESTStructure<RC_87cc7367398744031899074e30b93bba> {
[JsonProperty("RoleConcept")]
[JsonPropertyName("RoleConcept")]
public ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord AttrRoleConcept;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public JSONRC_87cc7367398744031899074e30b93bba() { }

public JSONRC_87cc7367398744031899074e30b93bba (RC_87cc7367398744031899074e30b93bba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRoleConcept = ConvertToRestWithoutDefaults(s.ssENRoleConcept, new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrRoleConcept = ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure(s.ssENRoleConcept, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_87cc7367398744031899074e30b93bba, RC_87cc7367398744031899074e30b93bba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_87cc7367398744031899074e30b93bba s) => ToStructure(s, config);
}
public static RC_87cc7367398744031899074e30b93bba ToStructure(ssConectaProveedores.RestRecords.JSONRC_87cc7367398744031899074e30b93bba obj, IBehaviorsConfiguration config) { 
  RC_87cc7367398744031899074e30b93bba s = new RC_87cc7367398744031899074e30b93bba();
  if(obj != null) {
  s.ssENRoleConcept = ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.ToStructure(obj.AttrRoleConcept, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  s.ssENEntraRole = ssConectaProveedores.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  }
  return s;
}

public static Func<RC_87cc7367398744031899074e30b93bba, ssConectaProveedores.RestRecords.JSONRC_87cc7367398744031899074e30b93bba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87cc7367398744031899074e30b93bba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_87cc7367398744031899074e30b93bba FromStructure(RC_87cc7367398744031899074e30b93bba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_87cc7367398744031899074e30b93bba(s, config);
}

}


