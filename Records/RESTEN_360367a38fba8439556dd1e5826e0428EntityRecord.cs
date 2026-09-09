using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SupplierUser
public class RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord : AbstractRESTStructure<EN_360367a38fba8439556dd1e5826e0428EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("SupplierId")]
public long? AttrSupplierId;

[JsonProperty("UserId")]
public string AttrUserId;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("ActivationEmailSentDate")]
public String AttrActivationEmailSentDate;

[JsonProperty("IsActive")]
public bool? AttrIsActive;

[JsonProperty("IsDeleted")]
public bool? AttrIsDeleted;

[JsonProperty("IsBlocked")]
public bool? AttrIsBlocked;

[JsonProperty("BlockedUntil")]
public String AttrBlockedUntil;

[JsonProperty("LastLoginDate")]
public String AttrLastLoginDate;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

public RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord() { }

public RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord (EN_360367a38fba8439556dd1e5826e0428EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrSupplierId = ConvertToRestWithoutDefaults(s.ssSupplierId, 0L);
AttrUserId = ConvertToRestWithoutDefaults(s.ssUserId, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrActivationEmailSentDate = ConvertDateTimeToRestWithoutDefaults(s.ssActivationEmailSentDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrIsActive = ConvertToRestWithoutDefaults(s.ssIsActive, false);
AttrIsDeleted = ConvertToRestWithoutDefaults(s.ssIsDeleted, false);
AttrIsBlocked = ConvertToRestWithoutDefaults(s.ssIsBlocked, false);
AttrBlockedUntil = ConvertDateTimeToRestWithoutDefaults(s.ssBlockedUntil, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrLastLoginDate = ConvertDateTimeToRestWithoutDefaults(s.ssLastLoginDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrSupplierId = (long?) s.ssSupplierId;
AttrUserId = s.ssUserId;
AttrName = s.ssName;
AttrEmail = s.ssEmail;
AttrActivationEmailSentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssActivationEmailSentDate, config.DateTimeFormat);
AttrIsActive = (bool?) s.ssIsActive;
AttrIsDeleted = (bool?) s.ssIsDeleted;
AttrIsBlocked = (bool?) s.ssIsBlocked;
AttrBlockedUntil = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssBlockedUntil, config.DateTimeFormat);
AttrLastLoginDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssLastLoginDate, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static EN_360367a38fba8439556dd1e5826e0428EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord obj) { 
  EN_360367a38fba8439556dd1e5826e0428EntityRecord s = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssSupplierId = obj.AttrSupplierId == null ? 0L : obj.AttrSupplierId.Value;
  s.ssUserId = obj.AttrUserId == null ? "" : obj.AttrUserId;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssActivationEmailSentDate = obj.AttrActivationEmailSentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrActivationEmailSentDate, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssIsActive = obj.AttrIsActive == null ? false : obj.AttrIsActive.Value;
  s.ssIsDeleted = obj.AttrIsDeleted == null ? false : obj.AttrIsDeleted.Value;
  s.ssIsBlocked = obj.AttrIsBlocked == null ? false : obj.AttrIsBlocked.Value;
  s.ssBlockedUntil = obj.AttrBlockedUntil == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrBlockedUntil, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssLastLoginDate = obj.AttrLastLoginDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrLastLoginDate, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_360367a38fba8439556dd1e5826e0428EntityRecord, ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_360367a38fba8439556dd1e5826e0428EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord FromStructure(EN_360367a38fba8439556dd1e5826e0428EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord(s, config);
}

}


