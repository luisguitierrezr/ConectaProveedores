using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalComment
public class RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord : AbstractRESTStructure<EN_c75b4bd59e1200fee3175175a6054340EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("CommentTypeId")]
public int? AttrCommentTypeId;

[JsonProperty("ProposalId")]
public long? AttrProposalId;

[JsonProperty("ProposalLineId")]
public long? AttrProposalLineId;

[JsonProperty("ProposalLineApprovalLevelId")]
public long? AttrProposalLineApprovalLevelId;

[JsonProperty("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("Message")]
public string AttrMessage;

public RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord() { }

public RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord (EN_c75b4bd59e1200fee3175175a6054340EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrCommentTypeId = ConvertToRestWithoutDefaults(s.ssCommentTypeId, 0);
AttrProposalId = ConvertToRestWithoutDefaults(s.ssProposalId, 0L);
AttrProposalLineId = ConvertToRestWithoutDefaults(s.ssProposalLineId, 0L);
AttrProposalLineApprovalLevelId = ConvertToRestWithoutDefaults(s.ssProposalLineApprovalLevelId, 0L);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrId = (long?) s.ssId;
AttrCommentTypeId = (int?) s.ssCommentTypeId;
AttrProposalId = (long?) s.ssProposalId;
AttrProposalLineId = (long?) s.ssProposalLineId;
AttrProposalLineApprovalLevelId = (long?) s.ssProposalLineApprovalLevelId;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrCreatedBy = s.ssCreatedBy;
AttrMessage = s.ssMessage;
  }
}

public static EN_c75b4bd59e1200fee3175175a6054340EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord obj) { 
  EN_c75b4bd59e1200fee3175175a6054340EntityRecord s = new EN_c75b4bd59e1200fee3175175a6054340EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssCommentTypeId = obj.AttrCommentTypeId == null ? 0 : obj.AttrCommentTypeId.Value;
  s.ssProposalId = obj.AttrProposalId == null ? 0L : obj.AttrProposalId.Value;
  s.ssProposalLineId = obj.AttrProposalLineId == null ? 0L : obj.AttrProposalLineId.Value;
  s.ssProposalLineApprovalLevelId = obj.AttrProposalLineApprovalLevelId == null ? 0L : obj.AttrProposalLineApprovalLevelId.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<EN_c75b4bd59e1200fee3175175a6054340EntityRecord, ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_c75b4bd59e1200fee3175175a6054340EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord FromStructure(EN_c75b4bd59e1200fee3175175a6054340EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord(s, config);
}

}


