using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Applicant
public class RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord : AbstractRESTStructure<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("Applicant")]
public string AttrApplicant;

[JsonProperty("Description")]
public string AttrDescription;

[JsonProperty("ApprovalProcessTypeId")]
public int? AttrApprovalProcessTypeId;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("UpdatedOn")]
public String AttrUpdatedOn;

[JsonProperty("UpdatedBy")]
public string AttrUpdatedBy;

public RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord() { }

public RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord obj) { 
  EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s = new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssApplicant = obj.AttrApplicant == null ? "" : obj.AttrApplicant;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssApprovalProcessTypeId = obj.AttrApprovalProcessTypeId == null ? 0 : obj.AttrApprovalProcessTypeId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedOn = obj.AttrUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssUpdatedBy = obj.AttrUpdatedBy == null ? "" : obj.AttrUpdatedBy;
  }
  return s;
}

public static Func<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord, ssConectaProveedores.RestRecords.RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord FromStructure(EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord(s, config);
}

}


