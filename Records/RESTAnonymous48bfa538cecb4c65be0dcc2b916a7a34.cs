using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserIdEmailUserNameRecord
public class RESTRC_3cb5faf855470afd6e46669ad1a86a21 : AbstractRESTStructure<RC_3cb5faf855470afd6e46669ad1a86a21> {
[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("UserName")]
public string AttrUserName;

public RESTRC_3cb5faf855470afd6e46669ad1a86a21() { }

public RESTRC_3cb5faf855470afd6e46669ad1a86a21 (RC_3cb5faf855470afd6e46669ad1a86a21 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrUserName = ConvertToRestWithoutDefaults(s.ssUserName, "");
  } else {
AttrUserId = s.ssUserId;
AttrEmail = s.ssEmail;
AttrUserName = s.ssUserName;
  }
}

public static RC_3cb5faf855470afd6e46669ad1a86a21 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3cb5faf855470afd6e46669ad1a86a21 obj) { 
  RC_3cb5faf855470afd6e46669ad1a86a21 s = new RC_3cb5faf855470afd6e46669ad1a86a21();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<RC_3cb5faf855470afd6e46669ad1a86a21, ssConectaProveedores.RestRecords.RESTRC_3cb5faf855470afd6e46669ad1a86a21> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3cb5faf855470afd6e46669ad1a86a21 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3cb5faf855470afd6e46669ad1a86a21 FromStructure(RC_3cb5faf855470afd6e46669ad1a86a21 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3cb5faf855470afd6e46669ad1a86a21(s, config);
}

}


