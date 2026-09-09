using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_PaidUser_UnpaidProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineIsSelectedRecord
public class JSONRC_1d9708453e759844315b6b93812afa56 : AbstractRESTStructure<RC_1d9708453e759844315b6b93812afa56> {
[JsonProperty("User_Paid")]
[JsonPropertyName("User_Paid")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Paid;

[JsonProperty("User_Unpaid")]
[JsonPropertyName("User_Unpaid")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Unpaid;

[JsonProperty("ProposalApprovalLevel")]
[JsonPropertyName("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("ProposalLineApprovalLevel")]
[JsonPropertyName("ProposalLineApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord AttrProposalLineApprovalLevel;

[JsonProperty("ProposalApproval")]
[JsonPropertyName("ProposalApproval")]
public ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

[JsonProperty("ProposalLine")]
[JsonPropertyName("ProposalLine")]
public ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

public JSONRC_1d9708453e759844315b6b93812afa56() { }

public JSONRC_1d9708453e759844315b6b93812afa56 (RC_1d9708453e759844315b6b93812afa56 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Paid = ConvertToRestWithoutDefaults(s.ssENUser_Paid, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Unpaid = ConvertToRestWithoutDefaults(s.ssENUser_Unpaid, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrUser_Paid = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Paid, config);
AttrUser_Unpaid = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Unpaid, config);
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
AttrProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1d9708453e759844315b6b93812afa56, RC_1d9708453e759844315b6b93812afa56> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1d9708453e759844315b6b93812afa56 s) => ToStructure(s, config);
}
public static RC_1d9708453e759844315b6b93812afa56 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1d9708453e759844315b6b93812afa56 obj, IBehaviorsConfiguration config) { 
  RC_1d9708453e759844315b6b93812afa56 s = new RC_1d9708453e759844315b6b93812afa56();
  if(obj != null) {
  s.ssENUser_Paid = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Paid, config);
  s.ssENUser_Unpaid = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Unpaid, config);
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel, config);
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel, config);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval, config);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine, config);
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<RC_1d9708453e759844315b6b93812afa56, ssConectaProveedores.RestRecords.JSONRC_1d9708453e759844315b6b93812afa56> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1d9708453e759844315b6b93812afa56 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1d9708453e759844315b6b93812afa56 FromStructure(RC_1d9708453e759844315b6b93812afa56 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1d9708453e759844315b6b93812afa56(s, config);
}

}


