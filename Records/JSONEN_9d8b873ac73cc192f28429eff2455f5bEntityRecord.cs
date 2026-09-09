using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevel
public class JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord : AbstractRESTStructure<EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("ProposalApprovalId")]
[JsonPropertyName("ProposalApprovalId")]
public long? AttrProposalApprovalId;

[JsonProperty("LevelNumber")]
[JsonPropertyName("LevelNumber")]
public int? AttrLevelNumber;

[JsonProperty("ApplicationRoleId")]
[JsonPropertyName("ApplicationRoleId")]
public long? AttrApplicationRoleId;

[JsonProperty("ApprovalStatusId")]
[JsonPropertyName("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("HasStarted")]
[JsonPropertyName("HasStarted")]
public bool? AttrHasStarted;

[JsonProperty("HasFinished")]
[JsonPropertyName("HasFinished")]
public bool? AttrHasFinished;

public JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord() { }

public JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrProposalApprovalId = ConvertToRestWithoutDefaults(s.ssProposalApprovalId, 0L);
AttrLevelNumber = ConvertToRestWithoutDefaults(s.ssLevelNumber, 0);
AttrApplicationRoleId = ConvertToRestWithoutDefaults(s.ssApplicationRoleId, 0L);
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrHasStarted = ConvertToRestWithoutDefaults(s.ssHasStarted, false);
AttrHasFinished = ConvertToRestWithoutDefaults(s.ssHasFinished, false);
  } else {
AttrId = (long?) s.ssId;
AttrProposalApprovalId = (long?) s.ssProposalApprovalId;
AttrLevelNumber = (int?) s.ssLevelNumber;
AttrApplicationRoleId = (long?) s.ssApplicationRoleId;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrHasStarted = (bool?) s.ssHasStarted;
AttrHasFinished = (bool?) s.ssHasFinished;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord, EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord s) => ToStructure(s, config);
}
public static EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord s = new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssProposalApprovalId = obj.AttrProposalApprovalId == null ? 0L : obj.AttrProposalApprovalId.Value;
  s.ssLevelNumber = obj.AttrLevelNumber == null ? 0 : obj.AttrLevelNumber.Value;
  s.ssApplicationRoleId = obj.AttrApplicationRoleId == null ? 0L : obj.AttrApplicationRoleId.Value;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssHasStarted = obj.AttrHasStarted == null ? false : obj.AttrHasStarted.Value;
  s.ssHasFinished = obj.AttrHasFinished == null ? false : obj.AttrHasFinished.Value;
  }
  return s;
}

public static Func<EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord, ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord FromStructure(EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(s, config);
}

}


