using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EntraRoleRecord
public class JSONRC_3ae851ff8b62d3b4ff8041de781ce47d : AbstractRESTStructure<RC_3ae851ff8b62d3b4ff8041de781ce47d> {
[JsonProperty("EntraRole")]
[JsonPropertyName("EntraRole")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord AttrEntraRole;

public JSONRC_3ae851ff8b62d3b4ff8041de781ce47d() { }

public JSONRC_3ae851ff8b62d3b4ff8041de781ce47d (RC_3ae851ff8b62d3b4ff8041de781ce47d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntraRole = ConvertToRestWithoutDefaults(s.ssENEntraRole, new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure, config);
  } else {
AttrEntraRole = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.FromStructure(s.ssENEntraRole, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ae851ff8b62d3b4ff8041de781ce47d, RC_3ae851ff8b62d3b4ff8041de781ce47d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ae851ff8b62d3b4ff8041de781ce47d s) => ToStructure(s, config);
}
public static RC_3ae851ff8b62d3b4ff8041de781ce47d ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ae851ff8b62d3b4ff8041de781ce47d obj, IBehaviorsConfiguration config) { 
  RC_3ae851ff8b62d3b4ff8041de781ce47d s = new RC_3ae851ff8b62d3b4ff8041de781ce47d();
  if(obj != null) {
  s.ssENEntraRole = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord.ToStructure(obj.AttrEntraRole, config);
  }
  return s;
}

public static Func<RC_3ae851ff8b62d3b4ff8041de781ce47d, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ae851ff8b62d3b4ff8041de781ce47d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3ae851ff8b62d3b4ff8041de781ce47d s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ae851ff8b62d3b4ff8041de781ce47d FromStructure(RC_3ae851ff8b62d3b4ff8041de781ce47d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_3ae851ff8b62d3b4ff8041de781ce47d(s, config);
}

}


