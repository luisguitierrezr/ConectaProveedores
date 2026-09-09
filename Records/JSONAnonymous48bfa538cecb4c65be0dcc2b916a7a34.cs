using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserIdEmailUserNameRecord
public class JSONRC_3cb5faf855470afd6e46669ad1a86a21 : AbstractRESTStructure<RC_3cb5faf855470afd6e46669ad1a86a21> {
[JsonProperty("UserId")]
[JsonPropertyName("UserId")]
public string AttrUserId;

[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("UserName")]
[JsonPropertyName("UserName")]
public string AttrUserName;

public JSONRC_3cb5faf855470afd6e46669ad1a86a21() { }

public JSONRC_3cb5faf855470afd6e46669ad1a86a21 (RC_3cb5faf855470afd6e46669ad1a86a21 s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONRC_3cb5faf855470afd6e46669ad1a86a21, RC_3cb5faf855470afd6e46669ad1a86a21> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3cb5faf855470afd6e46669ad1a86a21 s) => ToStructure(s, config);
}
public static RC_3cb5faf855470afd6e46669ad1a86a21 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3cb5faf855470afd6e46669ad1a86a21 obj, IBehaviorsConfiguration config) { 
  RC_3cb5faf855470afd6e46669ad1a86a21 s = new RC_3cb5faf855470afd6e46669ad1a86a21();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssUserName = obj.AttrUserName == null ? "" : obj.AttrUserName;
  }
  return s;
}

public static Func<RC_3cb5faf855470afd6e46669ad1a86a21, ssConectaProveedores.RestRecords.JSONRC_3cb5faf855470afd6e46669ad1a86a21> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3cb5faf855470afd6e46669ad1a86a21 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3cb5faf855470afd6e46669ad1a86a21 FromStructure(RC_3cb5faf855470afd6e46669ad1a86a21 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3cb5faf855470afd6e46669ad1a86a21(s, config);
}

}


