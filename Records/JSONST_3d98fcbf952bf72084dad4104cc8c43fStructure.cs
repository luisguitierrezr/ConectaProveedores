using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserDetail
public class JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure : AbstractRESTStructure<ST_3d98fcbf952bf72084dad4104cc8c43fStructure> {
[JsonProperty("Key")]
[JsonPropertyName("Key")]
public string AttrKey;

[JsonProperty("Name")]
[JsonPropertyName("Name")]
public string AttrName;

[JsonProperty("Email")]
[JsonPropertyName("Email")]
public string AttrEmail;

[JsonProperty("Status")]
[JsonPropertyName("Status")]
public string AttrStatus;

[JsonProperty("LastLoginAt")]
[JsonPropertyName("LastLoginAt")]
public String AttrLastLoginAt;

[JsonProperty("IsActive")]
[JsonPropertyName("IsActive")]
public bool? AttrIsActive;

[JsonProperty("PhotoUrl")]
[JsonPropertyName("PhotoUrl")]
public string AttrPhotoUrl;

[JsonProperty("IsEmailVerified")]
[JsonPropertyName("IsEmailVerified")]
public bool? AttrIsEmailVerified;

[JsonProperty("IsTermsAndConditionsAccepted")]
[JsonPropertyName("IsTermsAndConditionsAccepted")]
public bool? AttrIsTermsAndConditionsAccepted;

public JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure() { }

public JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure (ST_3d98fcbf952bf72084dad4104cc8c43fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKey = ConvertToRestWithoutDefaults(s.ssKey, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrStatus = ConvertToRestWithoutDefaults(s.ssStatus, "");
AttrLastLoginAt = ConvertDateTimeToRestWithoutDefaults(s.ssLastLoginAt, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrPhotoUrl = ConvertToRestWithoutDefaults(s.ssPhotoUrl, "");
AttrIsEmailVerified = ConvertToRestWithoutDefaults(s.ssIsEmailVerified, false);
AttrIsTermsAndConditionsAccepted = ConvertToRestWithoutDefaults(s.ssIsTermsAndConditionsAccepted, false);
  } else {
AttrKey = s.ssKey;
AttrName = s.ssName;
AttrEmail = s.ssEmail;
AttrStatus = s.ssStatus;
AttrLastLoginAt = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssLastLoginAt, config.DateTimeFormat);
AttrIsActive = (bool?) s.ssIsActive;
AttrPhotoUrl = s.ssPhotoUrl;
AttrIsEmailVerified = (bool?) s.ssIsEmailVerified;
AttrIsTermsAndConditionsAccepted = (bool?) s.ssIsTermsAndConditionsAccepted;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure, ST_3d98fcbf952bf72084dad4104cc8c43fStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure s) => ToStructure(s, config);
}
public static ST_3d98fcbf952bf72084dad4104cc8c43fStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure obj, IBehaviorsConfiguration config) { 
  ST_3d98fcbf952bf72084dad4104cc8c43fStructure s = new ST_3d98fcbf952bf72084dad4104cc8c43fStructure();
  if(obj != null) {
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  s.ssLastLoginAt = obj.AttrLastLoginAt == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastLoginAt, config.DateTimeFormat);
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssPhotoUrl = obj.AttrPhotoUrl == null ? "" : obj.AttrPhotoUrl;
  s.ssIsEmailVerified = obj.AttrIsEmailVerified == null ? false : obj.AttrIsEmailVerified.Value;
  s.ssIsTermsAndConditionsAccepted = obj.AttrIsTermsAndConditionsAccepted == null ? false : obj.AttrIsTermsAndConditionsAccepted.Value;
  }
  return s;
}

public static Func<ST_3d98fcbf952bf72084dad4104cc8c43fStructure, ssConectaProveedores.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3d98fcbf952bf72084dad4104cc8c43fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure FromStructure(ST_3d98fcbf952bf72084dad4104cc8c43fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure(s, config);
}

}


