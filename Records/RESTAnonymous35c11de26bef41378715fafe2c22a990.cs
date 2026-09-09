using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalLineApprovalLevelRecord
public class RESTRC_5327da8894a76849e4ef5a737a86e7d3 : AbstractRESTStructure<RC_5327da8894a76849e4ef5a737a86e7d3> {
[JsonProperty("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("ProposalLineApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord AttrProposalLineApprovalLevel;

public RESTRC_5327da8894a76849e4ef5a737a86e7d3() { }

public RESTRC_5327da8894a76849e4ef5a737a86e7d3 (RC_5327da8894a76849e4ef5a737a86e7d3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposalLineApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalLineApprovalLevel, new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposalLineApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.FromStructure(s.ssENProposalLineApprovalLevel, config);
  }
}

public static RC_5327da8894a76849e4ef5a737a86e7d3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5327da8894a76849e4ef5a737a86e7d3 obj) { 
  RC_5327da8894a76849e4ef5a737a86e7d3 s = new RC_5327da8894a76849e4ef5a737a86e7d3();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel);
  s.ssENProposalLineApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord.ToStructure(obj.AttrProposalLineApprovalLevel);
  }
  return s;
}

public static Func<RC_5327da8894a76849e4ef5a737a86e7d3, ssConectaProveedores.RestRecords.RESTRC_5327da8894a76849e4ef5a737a86e7d3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5327da8894a76849e4ef5a737a86e7d3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5327da8894a76849e4ef5a737a86e7d3 FromStructure(RC_5327da8894a76849e4ef5a737a86e7d3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5327da8894a76849e4ef5a737a86e7d3(s, config);
}

}


