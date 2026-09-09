using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FindUserByEmail
public class JSONST_f45a100349e05fd4d70690aea76ddd0aStructure : AbstractRESTStructure<ST_f45a100349e05fd4d70690aea76ddd0aStructure> {
[JsonProperty("UserId")]
[JsonPropertyName("UserId")]
public string AttrUserId;

[JsonProperty("UserEmail")]
[JsonPropertyName("UserEmail")]
public string AttrUserEmail;

[JsonProperty("ExtensionEmail")]
[JsonPropertyName("ExtensionEmail")]
public string AttrExtensionEmail;

public JSONST_f45a100349e05fd4d70690aea76ddd0aStructure() { }

public JSONST_f45a100349e05fd4d70690aea76ddd0aStructure (ST_f45a100349e05fd4d70690aea76ddd0aStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrUserEmail = ConvertToRestWithoutDefaults(s.ssUserEmail, "");
AttrExtensionEmail = ConvertToRestWithoutDefaults(s.ssExtensionEmail, "");
  } else {
AttrUserId = s.ssUserId;
AttrUserEmail = s.ssUserEmail;
AttrExtensionEmail = s.ssExtensionEmail;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f45a100349e05fd4d70690aea76ddd0aStructure, ST_f45a100349e05fd4d70690aea76ddd0aStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f45a100349e05fd4d70690aea76ddd0aStructure s) => ToStructure(s, config);
}
public static ST_f45a100349e05fd4d70690aea76ddd0aStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_f45a100349e05fd4d70690aea76ddd0aStructure obj, IBehaviorsConfiguration config) { 
  ST_f45a100349e05fd4d70690aea76ddd0aStructure s = new ST_f45a100349e05fd4d70690aea76ddd0aStructure();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssUserEmail = obj.AttrUserEmail == null ? "" : obj.AttrUserEmail;
  s.ssExtensionEmail = obj.AttrExtensionEmail == null ? "" : obj.AttrExtensionEmail;
  }
  return s;
}

public static Func<ST_f45a100349e05fd4d70690aea76ddd0aStructure, ssConectaProveedores.RestRecords.JSONST_f45a100349e05fd4d70690aea76ddd0aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f45a100349e05fd4d70690aea76ddd0aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f45a100349e05fd4d70690aea76ddd0aStructure FromStructure(ST_f45a100349e05fd4d70690aea76ddd0aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f45a100349e05fd4d70690aea76ddd0aStructure(s, config);
}

}


