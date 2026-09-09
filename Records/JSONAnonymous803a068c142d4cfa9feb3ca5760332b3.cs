using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalLineApprovalLevelProposalApprovalProposalLineRecord
public class JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4 : AbstractRESTStructure<RC_be1a2f02e9ce96cb93b1fb40e877c6b4> {
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

public JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4() { }

public JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4 (RC_be1a2f02e9ce96cb93b1fb40e877c6b4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
AttrProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4, RC_be1a2f02e9ce96cb93b1fb40e877c6b4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4 s) => ToStructure(s, config);
}
public static RC_be1a2f02e9ce96cb93b1fb40e877c6b4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4 obj, IBehaviorsConfiguration config) { 
  RC_be1a2f02e9ce96cb93b1fb40e877c6b4 s = new RC_be1a2f02e9ce96cb93b1fb40e877c6b4();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel, config);
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel, config);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval, config);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine, config);
  }
  return s;
}

public static Func<RC_be1a2f02e9ce96cb93b1fb40e877c6b4, ssConectaProveedores.RestRecords.JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_be1a2f02e9ce96cb93b1fb40e877c6b4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4 FromStructure(RC_be1a2f02e9ce96cb93b1fb40e877c6b4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_be1a2f02e9ce96cb93b1fb40e877c6b4(s, config);
}

}


