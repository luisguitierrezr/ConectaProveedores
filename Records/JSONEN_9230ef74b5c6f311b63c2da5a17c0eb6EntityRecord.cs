using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Applicant
public class JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord : AbstractRESTStructure<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Applicant")]
[JsonPropertyName("Applicant")]
public string AttrApplicant;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("ApprovalProcessTypeId")]
[JsonPropertyName("ApprovalProcessTypeId")]
public int? AttrApprovalProcessTypeId;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedOn")]
[JsonPropertyName("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
[JsonPropertyName("UpdatedBy")]
public string AttrUpdatedBy;

public JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord() { }

public JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrApplicant = ConvertToRestWithoutDefaults(s.ssApplicant, "");
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrApprovalProcessTypeId = ConvertToRestWithoutDefaults(s.ssApprovalProcessTypeId, 0);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrUpdatedBy = ConvertToRestWithoutDefaults(s.ssUpdatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrApplicant = s.ssApplicant;
AttrDescription = s.ssDescription;
AttrApprovalProcessTypeId = (int?) s.ssApprovalProcessTypeId;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssUpdatedOn, config.DateTimeFormat);
AttrUpdatedBy = s.ssUpdatedBy;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord, EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s) => ToStructure(s, config);
}
public static EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s = new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssApprovalProcessTypeId = obj.AttrApprovalProcessTypeId == null ? 0 : obj.AttrApprovalProcessTypeId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, config.DateTimeFormat);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord, ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord FromStructure(EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord(s, config);
}

}


