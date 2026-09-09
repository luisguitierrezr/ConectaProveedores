using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserRoleCodeRecord
public class RESTRC_0a3f9d90df8bd7c726f88030e3651410 : AbstractRESTStructure<RC_0a3f9d90df8bd7c726f88030e3651410> {
[JsonProperty("UserRoleCode")]
public ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure AttrUserRoleCode;

public RESTRC_0a3f9d90df8bd7c726f88030e3651410() { }

public RESTRC_0a3f9d90df8bd7c726f88030e3651410 (RC_0a3f9d90df8bd7c726f88030e3651410 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserRoleCode = ConvertToRestWithoutDefaults(s.ssSTUserRoleCode, new ST_e39617f0f094a322d4157f34fe424dadStructure(), ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructure, config);
  } else {
AttrUserRoleCode = ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.FromStructure(s.ssSTUserRoleCode, config);
  }
}

public static RC_0a3f9d90df8bd7c726f88030e3651410 ToStructure(ssConectaProveedores.RestRecords.RESTRC_0a3f9d90df8bd7c726f88030e3651410 obj) { 
  RC_0a3f9d90df8bd7c726f88030e3651410 s = new RC_0a3f9d90df8bd7c726f88030e3651410();
  if(obj != null) {
  s.ssSTUserRoleCode = ssConectaProveedores.RestRecords.RESTST_e39617f0f094a322d4157f34fe424dadStructure.ToStructure(obj.AttrUserRoleCode);
  }
  return s;
}

public static Func<RC_0a3f9d90df8bd7c726f88030e3651410, ssConectaProveedores.RestRecords.RESTRC_0a3f9d90df8bd7c726f88030e3651410> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0a3f9d90df8bd7c726f88030e3651410 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0a3f9d90df8bd7c726f88030e3651410 FromStructure(RC_0a3f9d90df8bd7c726f88030e3651410 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0a3f9d90df8bd7c726f88030e3651410(s, config);
}

}


