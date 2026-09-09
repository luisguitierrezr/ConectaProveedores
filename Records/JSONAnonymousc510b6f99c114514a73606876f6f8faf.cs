using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalLineApprovalLevelProposalLineRecord
public class JSONRC_90af34fed2114347870a398404753d70 : AbstractRESTStructure<RC_90af34fed2114347870a398404753d70> {
[JsonProperty("ProposalApprovalLevel")]
[JsonPropertyName("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("ProposalLineApprovalLevel")]
[JsonPropertyName("ProposalLineApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord AttrProposalLineApprovalLevel;

[JsonProperty("ProposalLine")]
[JsonPropertyName("ProposalLine")]
public ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

public JSONRC_90af34fed2114347870a398404753d70() { }

public JSONRC_90af34fed2114347870a398404753d70 (RC_90af34fed2114347870a398404753d70 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
AttrProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_90af34fed2114347870a398404753d70, RC_90af34fed2114347870a398404753d70> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_90af34fed2114347870a398404753d70 s) => ToStructure(s, config);
}
public static RC_90af34fed2114347870a398404753d70 ToStructure(ssConectaProveedores.RestRecords.JSONRC_90af34fed2114347870a398404753d70 obj, IBehaviorsConfiguration config) { 
  RC_90af34fed2114347870a398404753d70 s = new RC_90af34fed2114347870a398404753d70();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel, config);
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel, config);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine, config);
  }
  return s;
}

public static Func<RC_90af34fed2114347870a398404753d70, ssConectaProveedores.RestRecords.JSONRC_90af34fed2114347870a398404753d70> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_90af34fed2114347870a398404753d70 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_90af34fed2114347870a398404753d70 FromStructure(RC_90af34fed2114347870a398404753d70 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_90af34fed2114347870a398404753d70(s, config);
}

}


