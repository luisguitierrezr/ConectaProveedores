using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRoleTempRecord
public class JSONRC_66c67d926e518c0b673d9119f62da193 : AbstractRESTStructure<RC_66c67d926e518c0b673d9119f62da193> {
[JsonProperty("UserApplicationRoleTemp")]
[JsonPropertyName("UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord AttrUserApplicationRoleTemp;

public JSONRC_66c67d926e518c0b673d9119f62da193() { }

public JSONRC_66c67d926e518c0b673d9119f62da193 (RC_66c67d926e518c0b673d9119f62da193 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRoleTemp = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTemp, new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRoleTemp = ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(s.ssENUserApplicationRoleTemp, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_66c67d926e518c0b673d9119f62da193, RC_66c67d926e518c0b673d9119f62da193> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_66c67d926e518c0b673d9119f62da193 s) => ToStructure(s, config);
}
public static RC_66c67d926e518c0b673d9119f62da193 ToStructure(ssConectaProveedores.RestRecords.JSONRC_66c67d926e518c0b673d9119f62da193 obj, IBehaviorsConfiguration config) { 
  RC_66c67d926e518c0b673d9119f62da193 s = new RC_66c67d926e518c0b673d9119f62da193();
  if(obj != null) {
  s.ssENUserApplicationRoleTemp = ssConectaProveedores.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(obj.AttrUserApplicationRoleTemp, config);
  }
  return s;
}

public static Func<RC_66c67d926e518c0b673d9119f62da193, ssConectaProveedores.RestRecords.JSONRC_66c67d926e518c0b673d9119f62da193> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_66c67d926e518c0b673d9119f62da193 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_66c67d926e518c0b673d9119f62da193 FromStructure(RC_66c67d926e518c0b673d9119f62da193 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_66c67d926e518c0b673d9119f62da193(s, config);
}

}


