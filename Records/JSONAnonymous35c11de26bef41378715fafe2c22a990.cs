using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalLineApprovalLevelRecord
public class JSONRC_5327da8894a76849e4ef5a737a86e7d3 : AbstractRESTStructure<RC_5327da8894a76849e4ef5a737a86e7d3> {
[JsonProperty("ProposalApprovalLevel")]
[JsonPropertyName("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("ProposalLineApprovalLevel")]
[JsonPropertyName("ProposalLineApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord AttrProposalLineApprovalLevel;

public JSONRC_5327da8894a76849e4ef5a737a86e7d3() { }

public JSONRC_5327da8894a76849e4ef5a737a86e7d3 (RC_5327da8894a76849e4ef5a737a86e7d3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5327da8894a76849e4ef5a737a86e7d3, RC_5327da8894a76849e4ef5a737a86e7d3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5327da8894a76849e4ef5a737a86e7d3 s) => ToStructure(s, config);
}
public static RC_5327da8894a76849e4ef5a737a86e7d3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5327da8894a76849e4ef5a737a86e7d3 obj, IBehaviorsConfiguration config) { 
  RC_5327da8894a76849e4ef5a737a86e7d3 s = new RC_5327da8894a76849e4ef5a737a86e7d3();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel, config);
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel, config);
  }
  return s;
}

public static Func<RC_5327da8894a76849e4ef5a737a86e7d3, ssConectaProveedores.RestRecords.JSONRC_5327da8894a76849e4ef5a737a86e7d3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5327da8894a76849e4ef5a737a86e7d3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5327da8894a76849e4ef5a737a86e7d3 FromStructure(RC_5327da8894a76849e4ef5a737a86e7d3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5327da8894a76849e4ef5a737a86e7d3(s, config);
}

}


