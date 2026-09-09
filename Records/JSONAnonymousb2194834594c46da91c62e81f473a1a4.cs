using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserIdRoleNameUserNameRecord
public class JSONRC_f4217b217830b749d338ebe1832450a6 : AbstractRESTStructure<RC_f4217b217830b749d338ebe1832450a6> {
[JsonProperty("UserId")]
[JsonPropertyName("UserId")]
public string AttrUserId;

[JsonProperty("RoleName")]
[JsonPropertyName("RoleName")]
public string AttrRoleName;

[JsonProperty("UserName")]
[JsonPropertyName("UserName")]
public string AttrUserName;

public JSONRC_f4217b217830b749d338ebe1832450a6() { }

public JSONRC_f4217b217830b749d338ebe1832450a6 (RC_f4217b217830b749d338ebe1832450a6 s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONRC_f4217b217830b749d338ebe1832450a6, RC_f4217b217830b749d338ebe1832450a6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f4217b217830b749d338ebe1832450a6 s) => ToStructure(s, config);
}
public static RC_f4217b217830b749d338ebe1832450a6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f4217b217830b749d338ebe1832450a6 obj, IBehaviorsConfiguration config) { 
  RC_f4217b217830b749d338ebe1832450a6 s = new RC_f4217b217830b749d338ebe1832450a6();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssRoleName = obj.AttrRoleName == null ? "" : obj.AttrRoleName;
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<RC_f4217b217830b749d338ebe1832450a6, ssConectaProveedores.RestRecords.JSONRC_f4217b217830b749d338ebe1832450a6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f4217b217830b749d338ebe1832450a6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f4217b217830b749d338ebe1832450a6 FromStructure(RC_f4217b217830b749d338ebe1832450a6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f4217b217830b749d338ebe1832450a6(s, config);
}

}


