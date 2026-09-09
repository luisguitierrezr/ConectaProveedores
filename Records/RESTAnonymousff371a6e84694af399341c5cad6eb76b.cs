using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleConceptRecord
public class RESTRC_51f0b789ef77b4d6d4002737fb63bbb9 : AbstractRESTStructure<RC_51f0b789ef77b4d6d4002737fb63bbb9> {
[JsonProperty("RoleConcept")]
public ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord AttrRoleConcept;

public RESTRC_51f0b789ef77b4d6d4002737fb63bbb9() { }

public RESTRC_51f0b789ef77b4d6d4002737fb63bbb9 (RC_51f0b789ef77b4d6d4002737fb63bbb9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRoleConcept = ConvertToRestWithoutDefaults(s.ssENRoleConcept, new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure, config);
  } else {
AttrRoleConcept = ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.FromStructure(s.ssENRoleConcept, config);
  }
}

public static RC_51f0b789ef77b4d6d4002737fb63bbb9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_51f0b789ef77b4d6d4002737fb63bbb9 obj) { 
  RC_51f0b789ef77b4d6d4002737fb63bbb9 s = new RC_51f0b789ef77b4d6d4002737fb63bbb9();
  if(obj != null) {
  s.ssENRoleConcept = ssConectaProveedores.RestRecords.RESTEN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord.ToStructure(obj.AttrRoleConcept);
  }
  return s;
}

public static Func<RC_51f0b789ef77b4d6d4002737fb63bbb9, ssConectaProveedores.RestRecords.RESTRC_51f0b789ef77b4d6d4002737fb63bbb9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_51f0b789ef77b4d6d4002737fb63bbb9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_51f0b789ef77b4d6d4002737fb63bbb9 FromStructure(RC_51f0b789ef77b4d6d4002737fb63bbb9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_51f0b789ef77b4d6d4002737fb63bbb9(s, config);
}

}


