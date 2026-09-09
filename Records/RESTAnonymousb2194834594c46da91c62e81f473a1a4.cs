using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserIdRoleNameUserNameRecord
public class RESTRC_f4217b217830b749d338ebe1832450a6 : AbstractRESTStructure<RC_f4217b217830b749d338ebe1832450a6> {
[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("RoleName")]
public string AttrRoleName;

[JsonProperty("UserName")]
public string AttrUserName;

public RESTRC_f4217b217830b749d338ebe1832450a6() { }

public RESTRC_f4217b217830b749d338ebe1832450a6 (RC_f4217b217830b749d338ebe1832450a6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrRoleName = ConvertToRestWithoutDefaults(s.ssRoleName, "");
AttrUserName = ConvertToRestWithoutDefaults(s.ssUserName, "");
  } else {
AttrUserId = s.ssUserId;
AttrRoleName = s.ssRoleName;
AttrUserName = s.ssUserName;
  }
}

public static RC_f4217b217830b749d338ebe1832450a6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f4217b217830b749d338ebe1832450a6 obj) { 
  RC_f4217b217830b749d338ebe1832450a6 s = new RC_f4217b217830b749d338ebe1832450a6();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssRoleName = obj.AttrRoleName == null ? "" : obj.AttrRoleName;
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<RC_f4217b217830b749d338ebe1832450a6, ssConectaProveedores.RestRecords.RESTRC_f4217b217830b749d338ebe1832450a6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f4217b217830b749d338ebe1832450a6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f4217b217830b749d338ebe1832450a6 FromStructure(RC_f4217b217830b749d338ebe1832450a6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f4217b217830b749d338ebe1832450a6(s, config);
}

}


