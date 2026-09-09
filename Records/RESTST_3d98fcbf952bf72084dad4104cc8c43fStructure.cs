using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserDetail
public class RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure : AbstractRESTStructure<ST_3d98fcbf952bf72084dad4104cc8c43fStructure> {
[JsonProperty("Key")]
public string AttrKey;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("Status")]
public string AttrStatus;

[JsonProperty("LastLoginAt")]
public String AttrLastLoginAt;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("PhotoUrl")]
public string AttrPhotoUrl;

[JsonProperty("IsEmailVerified")]
public bool? AttrIsEmailVerified;

[JsonProperty("IsTermsAndConditionsAccepted")]
public bool? AttrIsTermsAndConditionsAccepted;

public RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure() { }

public RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure (ST_3d98fcbf952bf72084dad4104cc8c43fStructure s, IBehaviorsConfiguration config) {
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

public static ST_3d98fcbf952bf72084dad4104cc8c43fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure obj) { 
  ST_3d98fcbf952bf72084dad4104cc8c43fStructure s = new ST_3d98fcbf952bf72084dad4104cc8c43fStructure();
  if(obj != null) {
  s.ssKey = obj.AttrKey == null ? "" : obj.AttrKey;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssStatus = obj.AttrStatus == null ? "" : obj.AttrStatus;
  s.ssLastLoginAt = obj.AttrLastLoginAt == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastLoginAt, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssPhotoUrl = obj.AttrPhotoUrl == null ? "" : obj.AttrPhotoUrl;
  s.ssIsEmailVerified = obj.AttrIsEmailVerified == null ? false : obj.AttrIsEmailVerified.Value;
  s.ssIsTermsAndConditionsAccepted = obj.AttrIsTermsAndConditionsAccepted == null ? false : obj.AttrIsTermsAndConditionsAccepted.Value;
  }
  return s;
}

public static Func<ST_3d98fcbf952bf72084dad4104cc8c43fStructure, ssConectaProveedores.RestRecords.RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_3d98fcbf952bf72084dad4104cc8c43fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure FromStructure(ST_3d98fcbf952bf72084dad4104cc8c43fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_3d98fcbf952bf72084dad4104cc8c43fStructure(s, config);
}

}


