using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_PaidUser_UnpaidProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineIsSelectedRecord
public class RESTRC_1d9708453e759844315b6b93812afa56 : AbstractRESTStructure<RC_1d9708453e759844315b6b93812afa56> {
[JsonProperty("User_Paid")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Paid;

[JsonProperty("User_Unpaid")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Unpaid;

[JsonProperty("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("ProposalLineApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord AttrProposalLineApprovalLevel;

[JsonProperty("ProposalApproval")]
public ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

[JsonProperty("ProposalLine")]
public ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

public RESTRC_1d9708453e759844315b6b93812afa56() { }

public RESTRC_1d9708453e759844315b6b93812afa56 (RC_1d9708453e759844315b6b93812afa56 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Paid = ConvertToRestWithoutDefaults(s.ssENUser_Paid, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Unpaid = ConvertToRestWithoutDefaults(s.ssENUser_Unpaid, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrUser_Paid = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Paid, config);
AttrUser_Unpaid = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Unpaid, config);
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
AttrProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static RC_1d9708453e759844315b6b93812afa56 ToStructure(ssConectaProveedores.RestRecords.RESTRC_1d9708453e759844315b6b93812afa56 obj) { 
  RC_1d9708453e759844315b6b93812afa56 s = new RC_1d9708453e759844315b6b93812afa56();
  if(obj != null) {
  s.ssENUser_Paid = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Paid);
  s.ssENUser_Unpaid = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Unpaid);
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel);
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine);
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<RC_1d9708453e759844315b6b93812afa56, ssConectaProveedores.RestRecords.RESTRC_1d9708453e759844315b6b93812afa56> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1d9708453e759844315b6b93812afa56 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1d9708453e759844315b6b93812afa56 FromStructure(RC_1d9708453e759844315b6b93812afa56 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1d9708453e759844315b6b93812afa56(s, config);
}

}


