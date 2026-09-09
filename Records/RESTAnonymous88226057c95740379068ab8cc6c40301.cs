using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalProposalApprovalRecord
public class RESTRC_921fd9090c7367c088e0777ee6e3ef28 : AbstractRESTStructure<RC_921fd9090c7367c088e0777ee6e3ef28> {
[JsonProperty("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalApproval")]
public ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

public RESTRC_921fd9090c7367c088e0777ee6e3ef28() { }

public RESTRC_921fd9090c7367c088e0777ee6e3ef28 (RC_921fd9090c7367c088e0777ee6e3ef28 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
  }
}

public static RC_921fd9090c7367c088e0777ee6e3ef28 ToStructure(ssConectaProveedores.RestRecords.RESTRC_921fd9090c7367c088e0777ee6e3ef28 obj) { 
  RC_921fd9090c7367c088e0777ee6e3ef28 s = new RC_921fd9090c7367c088e0777ee6e3ef28();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel);
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval);
  }
  return s;
}

public static Func<RC_921fd9090c7367c088e0777ee6e3ef28, ssConectaProveedores.RestRecords.RESTRC_921fd9090c7367c088e0777ee6e3ef28> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_921fd9090c7367c088e0777ee6e3ef28 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_921fd9090c7367c088e0777ee6e3ef28 FromStructure(RC_921fd9090c7367c088e0777ee6e3ef28 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_921fd9090c7367c088e0777ee6e3ef28(s, config);
}

}


