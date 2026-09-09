using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLineApprovalLevel
public class JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord : AbstractRESTStructure<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProposalLineId")]
[JsonPropertyName("ProposalLineId")]
public long? AttrProposalLineId;

[JsonProperty("ProposalApprovalLevelId")]
[JsonPropertyName("ProposalApprovalLevelId")]
public long? AttrProposalApprovalLevelId;

[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("ApprovalStatusId")]
[JsonPropertyName("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("ApprovedBy")]
[JsonPropertyName("ApprovedBy")]
public string AttrApprovedBy;

[JsonProperty("ApprovedOn")]
[JsonPropertyName("ApprovedOn")]
public String AttrApprovedOn;

[JsonProperty("RejectedBy")]
[JsonPropertyName("RejectedBy")]
public string AttrRejectedBy;

[JsonProperty("RejectedOn")]
[JsonPropertyName("RejectedOn")]
public String AttrRejectedOn;

public JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord() { }

public JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProposalLineId = ConvertToRestWithoutDefaults(s.ssProposalLineId, 0L);
AttrProposalApprovalLevelId = ConvertToRestWithoutDefaults(s.ssProposalApprovalLevelId, 0L);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrApprovedBy = ConvertToRestWithoutDefaults(s.ssApprovedBy, "");
AttrApprovedOn = ConvertDateTimeToRestWithoutDefaults(s.ssApprovedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrRejectedBy = ConvertToRestWithoutDefaults(s.ssRejectedBy, "");
AttrRejectedOn = ConvertDateTimeToRestWithoutDefaults(s.ssRejectedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrProposalLineId = (long?) s.ssProposalLineId;
AttrProposalApprovalLevelId = (long?) s.ssProposalApprovalLevelId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrApprovedBy = s.ssApprovedBy;
AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssApprovedOn, config.DateTimeFormat);
AttrRejectedBy = s.ssRejectedBy;
AttrRejectedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssRejectedOn, config.DateTimeFormat);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord, EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s) => ToStructure(s, config);
}
public static EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProposalLineId = obj.AttrProposalLineId == null ? 0L : obj.AttrProposalLineId.Value;
  s.ssProposalApprovalLevelId = obj.AttrProposalApprovalLevelId == null ? 0L : obj.AttrProposalApprovalLevelId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssApprovedBy = obj.AttrApprovedBy == null ? "" : obj.AttrApprovedBy;
  s.ssApprovedOn = obj.AttrApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrApprovedOn, config.DateTimeFormat);
  s.ssRejectedBy = obj.AttrRejectedBy == null ? "" : obj.AttrRejectedBy;
  s.ssRejectedOn = obj.AttrRejectedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRejectedOn, config.DateTimeFormat);
  }
  return s;
}

public static Func<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord, ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord FromStructure(EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(s, config);
}

}


