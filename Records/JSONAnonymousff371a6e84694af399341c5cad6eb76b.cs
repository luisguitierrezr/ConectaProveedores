using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleConceptRecord
public class JSONRC_51f0b789ef77b4d6d4002737fb63bbb9 : AbstractRESTStructure<RC_51f0b789ef77b4d6d4002737fb63bbb9> {
[JsonProperty("RoleConcept")]
[JsonPropertyName("RoleConcept")]
public ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord AttrRoleConcept;

public JSONRC_51f0b789ef77b4d6d4002737fb63bbb9() { }

public JSONRC_51f0b789ef77b4d6d4002737fb63bbb9 (RC_51f0b789ef77b4d6d4002737fb63bbb9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRoleConcept = ConvertToRestWithoutDefaults(s.ssENRoleConcept, new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure, config);
  } else {
AttrRoleConcept = ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure(s.ssENRoleConcept, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_51f0b789ef77b4d6d4002737fb63bbb9, RC_51f0b789ef77b4d6d4002737fb63bbb9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_51f0b789ef77b4d6d4002737fb63bbb9 s) => ToStructure(s, config);
}
public static RC_51f0b789ef77b4d6d4002737fb63bbb9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_51f0b789ef77b4d6d4002737fb63bbb9 obj, IBehaviorsConfiguration config) { 
  RC_51f0b789ef77b4d6d4002737fb63bbb9 s = new RC_51f0b789ef77b4d6d4002737fb63bbb9();
  if(obj != null) {
  s.ssENRoleConcept = ssConectaProveedores.RestRecords.JSONEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.ToStructure(obj.AttrRoleConcept, config);
  }
  return s;
}

public static Func<RC_51f0b789ef77b4d6d4002737fb63bbb9, ssConectaProveedores.RestRecords.JSONRC_51f0b789ef77b4d6d4002737fb63bbb9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_51f0b789ef77b4d6d4002737fb63bbb9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_51f0b789ef77b4d6d4002737fb63bbb9 FromStructure(RC_51f0b789ef77b4d6d4002737fb63bbb9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_51f0b789ef77b4d6d4002737fb63bbb9(s, config);
}

}


