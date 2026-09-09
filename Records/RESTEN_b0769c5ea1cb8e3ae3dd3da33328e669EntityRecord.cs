using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLineApprovalLevel
public class RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord : AbstractRESTStructure<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("ProposalLineId")]
public long? AttrProposalLineId;

[JsonProperty("ProposalApprovalLevelId")]
public long? AttrProposalApprovalLevelId;

[JsonProperty("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("ApprovedBy")]
public string AttrApprovedBy;

[JsonProperty("ApprovedOn")]
public String AttrApprovedOn;

[JsonProperty("RejectedBy")]
public string AttrRejectedBy;

[JsonProperty("RejectedOn")]
public String AttrRejectedOn;

public RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord() { }

public RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord obj) { 
  EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s = new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProposalLineId = obj.AttrProposalLineId == null ? 0L : obj.AttrProposalLineId.Value;
  s.ssProposalApprovalLevelId = obj.AttrProposalApprovalLevelId == null ? 0L : obj.AttrProposalApprovalLevelId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssApprovedBy = obj.AttrApprovedBy == null ? "" : obj.AttrApprovedBy;
  s.ssApprovedOn = obj.AttrApprovedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrApprovedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssRejectedBy = obj.AttrRejectedBy == null ? "" : obj.AttrRejectedBy;
  s.ssRejectedOn = obj.AttrRejectedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrRejectedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord, ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord FromStructure(EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(s, config);
}

}


