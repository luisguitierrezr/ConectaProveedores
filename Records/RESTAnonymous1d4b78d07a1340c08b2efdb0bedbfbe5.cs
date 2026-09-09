using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserApplicationRoleTempRecord
public class RESTRC_66c67d926e518c0b673d9119f62da193 : AbstractRESTStructure<RC_66c67d926e518c0b673d9119f62da193> {
[JsonProperty("UserApplicationRoleTemp")]
public ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord AttrUserApplicationRoleTemp;

public RESTRC_66c67d926e518c0b673d9119f62da193() { }

public RESTRC_66c67d926e518c0b673d9119f62da193 (RC_66c67d926e518c0b673d9119f62da193 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserApplicationRoleTemp = ConvertToRestWithoutDefaults(s.ssENUserApplicationRoleTemp, new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure, config);
  } else {
AttrUserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(s.ssENUserApplicationRoleTemp, config);
  }
}

public static RC_66c67d926e518c0b673d9119f62da193 ToStructure(ssConectaProveedores.RestRecords.RESTRC_66c67d926e518c0b673d9119f62da193 obj) { 
  RC_66c67d926e518c0b673d9119f62da193 s = new RC_66c67d926e518c0b673d9119f62da193();
  if(obj != null) {
  s.ssENUserApplicationRoleTemp = ssConectaProveedores.RestRecords.RESTEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.ToStructure(obj.AttrUserApplicationRoleTemp);
  }
  return s;
}

public static Func<RC_66c67d926e518c0b673d9119f62da193, ssConectaProveedores.RestRecords.RESTRC_66c67d926e518c0b673d9119f62da193> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_66c67d926e518c0b673d9119f62da193 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_66c67d926e518c0b673d9119f62da193 FromStructure(RC_66c67d926e518c0b673d9119f62da193 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_66c67d926e518c0b673d9119f62da193(s, config);
}

}


