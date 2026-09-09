using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntraRoleRecord
public class RESTRC_3ae851ff8b62d3b4ff8041de781ce47d : AbstractRESTStructure<RC_3ae851ff8b62d3b4ff8041de781ce47d> {
[JsonProperty("EntraRole")]
public ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public RESTRC_3ae851ff8b62d3b4ff8041de781ce47d() { }

public RESTRC_3ae851ff8b62d3b4ff8041de781ce47d (RC_3ae851ff8b62d3b4ff8041de781ce47d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static RC_3ae851ff8b62d3b4ff8041de781ce47d ToStructure(ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d obj) { 
  RC_3ae851ff8b62d3b4ff8041de781ce47d s = new RC_3ae851ff8b62d3b4ff8041de781ce47d();
  if(obj != null) {
  s.ssENEntraRole = ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole);
  }
  return s;
}

public static Func<RC_3ae851ff8b62d3b4ff8041de781ce47d, ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3ae851ff8b62d3b4ff8041de781ce47d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d FromStructure(RC_3ae851ff8b62d3b4ff8041de781ce47d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d(s, config);
}

}


