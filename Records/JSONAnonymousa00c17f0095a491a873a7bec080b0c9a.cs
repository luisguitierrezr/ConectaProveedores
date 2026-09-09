using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRoleCodeRecord
public class JSONRC_0a3f9d90df8bd7c726f88030e3651410 : AbstractRESTStructure<RC_0a3f9d90df8bd7c726f88030e3651410> {
[JsonProperty("UserRoleCode")]
[JsonPropertyName("UserRoleCode")]
public ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure AttrUserRoleCode;

public JSONRC_0a3f9d90df8bd7c726f88030e3651410() { }

public JSONRC_0a3f9d90df8bd7c726f88030e3651410 (RC_0a3f9d90df8bd7c726f88030e3651410 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserRoleCode = ConvertToRestWithoutDefaults(s.ssSTUserRoleCode, new ST_e39617f0f094a322d4157f34fe424dadStructure(), ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure.FromStructure, config);
  } else {
AttrUserRoleCode = ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure.FromStructure(s.ssSTUserRoleCode, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0a3f9d90df8bd7c726f88030e3651410, RC_0a3f9d90df8bd7c726f88030e3651410> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0a3f9d90df8bd7c726f88030e3651410 s) => ToStructure(s, config);
}
public static RC_0a3f9d90df8bd7c726f88030e3651410 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0a3f9d90df8bd7c726f88030e3651410 obj, IBehaviorsConfiguration config) { 
  RC_0a3f9d90df8bd7c726f88030e3651410 s = new RC_0a3f9d90df8bd7c726f88030e3651410();
  if(obj != null) {
  s.ssSTUserRoleCode = ssConectaProveedores.RestRecords.JSONST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure(obj.AttrUserRoleCode, config);
  }
  return s;
}

public static Func<RC_0a3f9d90df8bd7c726f88030e3651410, ssConectaProveedores.RestRecords.JSONRC_0a3f9d90df8bd7c726f88030e3651410> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a3f9d90df8bd7c726f88030e3651410 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0a3f9d90df8bd7c726f88030e3651410 FromStructure(RC_0a3f9d90df8bd7c726f88030e3651410 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0a3f9d90df8bd7c726f88030e3651410(s, config);
}

}


