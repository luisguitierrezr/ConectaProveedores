using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDistributionConfig
public class JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord : AbstractRESTStructure<EN_4ad0cdb13562998fda111463f2af9c31EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("RegionId")]
[JsonPropertyName("RegionId")]
public long? AttrRegionId;

[JsonProperty("Applicant")]
[JsonPropertyName("Applicant")]
public string AttrApplicant;

[JsonProperty("ApplicantDescription")]
[JsonPropertyName("ApplicantDescription")]
public string AttrApplicantDescription;

[JsonProperty("DirectionId")]
[JsonPropertyName("DirectionId")]
public long? AttrDirectionId;

[JsonProperty("FirstContact_EntraRoleId")]
[JsonPropertyName("FirstContact_EntraRoleId")]
public long? AttrFirstContact_EntraRoleId;

[JsonProperty("SecondContact_EntraRoleId")]
[JsonPropertyName("SecondContact_EntraRoleId")]
public long? AttrSecondContact_EntraRoleId;

[JsonProperty("FirstApprover_EntraRoleId")]
[JsonPropertyName("FirstApprover_EntraRoleId")]
public long? AttrFirstApprover_EntraRoleId;

[JsonProperty("SecondApprover_EntraRoleId")]
[JsonPropertyName("SecondApprover_EntraRoleId")]
public long? AttrSecondApprover_EntraRoleId;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

public JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord() { }

public JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrRegionId = ConvertToRestWithoutDefaults(s.ssRegionId, 0L);
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrApplicantDescription = ConvertToRestWithoutDefaults(s.ssApplicantDescription, "");
AttrDirectionId = ConvertToRestWithoutDefaults(s.ssDirectionId, 0L);
AttrFirstContact_EntraRoleId = ConvertToRestWithoutDefaults(s.ssFirstContact_EntraRoleId, 0L);
AttrSecondContact_EntraRoleId = ConvertToRestWithoutDefaults(s.ssSecondContact_EntraRoleId, 0L);
AttrFirstApprover_EntraRoleId = ConvertToRestWithoutDefaults(s.ssFirstApprover_EntraRoleId, 0L);
AttrSecondApprover_EntraRoleId = ConvertToRestWithoutDefaults(s.ssSecondApprover_EntraRoleId, 0L);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrRegionId = (long?) s.ssRegionId;
AttrApplicant = s.ssApplicant;
AttrApplicantDescription = s.ssApplicantDescription;
AttrDirectionId = (long?) s.ssDirectionId;
AttrFirstContact_EntraRoleId = (long?) s.ssFirstContact_EntraRoleId;
AttrSecondContact_EntraRoleId = (long?) s.ssSecondContact_EntraRoleId;
AttrFirstApprover_EntraRoleId = (long?) s.ssFirstApprover_EntraRoleId;
AttrSecondApprover_EntraRoleId = (long?) s.ssSecondApprover_EntraRoleId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord, EN_4ad0cdb13562998fda111463f2af9c31EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord s) => ToStructure(s, config);
}
public static EN_4ad0cdb13562998fda111463f2af9c31EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_4ad0cdb13562998fda111463f2af9c31EntityRecord s = new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssRegionId = obj.AttrRegionId == null ? 0L : obj.AttrRegionId.Value;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssApplicantDescription = obj.AttrApplicantDescription == null ? "" : obj.AttrApplicantDescription;
  s.ssDirectionId = obj.AttrDirectionId == null ? 0L : obj.AttrDirectionId.Value;
  s.ssFirstContact_EntraRoleId = obj.AttrFirstContact_EntraRoleId == null ? 0L : obj.AttrFirstContact_EntraRoleId.Value;
  s.ssSecondContact_EntraRoleId = obj.AttrSecondContact_EntraRoleId == null ? 0L : obj.AttrSecondContact_EntraRoleId.Value;
  s.ssFirstApprover_EntraRoleId = obj.AttrFirstApprover_EntraRoleId == null ? 0L : obj.AttrFirstApprover_EntraRoleId.Value;
  s.ssSecondApprover_EntraRoleId = obj.AttrSecondApprover_EntraRoleId == null ? 0L : obj.AttrSecondApprover_EntraRoleId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_4ad0cdb13562998fda111463f2af9c31EntityRecord, ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord FromStructure(EN_4ad0cdb13562998fda111463f2af9c31EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_4ad0cdb13562998fda111463f2af9c31EntityRecord(s, config);
}

}


