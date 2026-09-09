using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalProposalApprovalRecord
public class JSONRC_921fd9090c7367c088e0777ee6e3ef28 : AbstractRESTStructure<RC_921fd9090c7367c088e0777ee6e3ef28> {
[JsonProperty("ProposalApprovalLevel")]
[JsonPropertyName("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalApproval")]
[JsonPropertyName("ProposalApproval")]
public ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

public JSONRC_921fd9090c7367c088e0777ee6e3ef28() { }

public JSONRC_921fd9090c7367c088e0777ee6e3ef28 (RC_921fd9090c7367c088e0777ee6e3ef28 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_921fd9090c7367c088e0777ee6e3ef28, RC_921fd9090c7367c088e0777ee6e3ef28> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_921fd9090c7367c088e0777ee6e3ef28 s) => ToStructure(s, config);
}
public static RC_921fd9090c7367c088e0777ee6e3ef28 ToStructure(ssConectaProveedores.RestRecords.JSONRC_921fd9090c7367c088e0777ee6e3ef28 obj, IBehaviorsConfiguration config) { 
  RC_921fd9090c7367c088e0777ee6e3ef28 s = new RC_921fd9090c7367c088e0777ee6e3ef28();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel, config);
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval, config);
  }
  return s;
}

public static Func<RC_921fd9090c7367c088e0777ee6e3ef28, ssConectaProveedores.RestRecords.JSONRC_921fd9090c7367c088e0777ee6e3ef28> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_921fd9090c7367c088e0777ee6e3ef28 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_921fd9090c7367c088e0777ee6e3ef28 FromStructure(RC_921fd9090c7367c088e0777ee6e3ef28 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_921fd9090c7367c088e0777ee6e3ef28(s, config);
}

}


