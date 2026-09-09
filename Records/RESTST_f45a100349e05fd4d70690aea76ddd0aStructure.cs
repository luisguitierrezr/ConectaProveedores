using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FindUserByEmail
public class RESTST_f45a100349e05fd4d70690aea76ddd0aStructure : AbstractRESTStructure<ST_f45a100349e05fd4d70690aea76ddd0aStructure> {
[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("UserEmail")]
public string AttrUserEmail;

[JsonProperty("ExtensionEmail")]
public string AttrExtensionEmail;

public RESTST_f45a100349e05fd4d70690aea76ddd0aStructure() { }

public RESTST_f45a100349e05fd4d70690aea76ddd0aStructure (ST_f45a100349e05fd4d70690aea76ddd0aStructure s, IBehaviorsConfiguration config) {
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

public static ST_f45a100349e05fd4d70690aea76ddd0aStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_f45a100349e05fd4d70690aea76ddd0aStructure obj) { 
  ST_f45a100349e05fd4d70690aea76ddd0aStructure s = new ST_f45a100349e05fd4d70690aea76ddd0aStructure();
  if(obj != null) {
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssUserEmail = obj.AttrUserEmail == null ? "" : obj.AttrUserEmail;
  s.ssExtensionEmail = obj.AttrExtensionEmail == null ? "" : obj.AttrExtensionEmail;
  }
  return s;
}

public static Func<ST_f45a100349e05fd4d70690aea76ddd0aStructure, ssConectaProveedores.RestRecords.RESTST_f45a100349e05fd4d70690aea76ddd0aStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f45a100349e05fd4d70690aea76ddd0aStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_f45a100349e05fd4d70690aea76ddd0aStructure FromStructure(ST_f45a100349e05fd4d70690aea76ddd0aStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_f45a100349e05fd4d70690aea76ddd0aStructure(s, config);
}

}


