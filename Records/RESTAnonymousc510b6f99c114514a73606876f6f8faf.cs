using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalLineApprovalLevelProposalLineRecord
public class RESTRC_90af34fed2114347870a398404753d70 : AbstractRESTStructure<RC_90af34fed2114347870a398404753d70> {
[JsonProperty("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("ProposalLineApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord AttrProposalLineApprovalLevel;

[JsonProperty("ProposalLine")]
public ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

public RESTRC_90af34fed2114347870a398404753d70() { }

public RESTRC_90af34fed2114347870a398404753d70 (RC_90af34fed2114347870a398404753d70 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
AttrProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static RC_90af34fed2114347870a398404753d70 ToStructure(ssConectaProveedores.RestRecords.RESTRC_90af34fed2114347870a398404753d70 obj) { 
  RC_90af34fed2114347870a398404753d70 s = new RC_90af34fed2114347870a398404753d70();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel);
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine);
  }
  return s;
}

public static Func<RC_90af34fed2114347870a398404753d70, ssConectaProveedores.RestRecords.RESTRC_90af34fed2114347870a398404753d70> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_90af34fed2114347870a398404753d70 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_90af34fed2114347870a398404753d70 FromStructure(RC_90af34fed2114347870a398404753d70 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_90af34fed2114347870a398404753d70(s, config);
}

}


