using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalProposalApprovalApplicationRoleRecord
public class RESTRC_37b2ba4d72ceb89cfb30009990025b2f : AbstractRESTStructure<RC_37b2ba4d72ceb89cfb30009990025b2f> {
[JsonProperty("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalApproval")]
public ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public RESTRC_37b2ba4d72ceb89cfb30009990025b2f() { }

public RESTRC_37b2ba4d72ceb89cfb30009990025b2f (RC_37b2ba4d72ceb89cfb30009990025b2f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static RC_37b2ba4d72ceb89cfb30009990025b2f ToStructure(ssConectaProveedores.RestRecords.RESTRC_37b2ba4d72ceb89cfb30009990025b2f obj) { 
  RC_37b2ba4d72ceb89cfb30009990025b2f s = new RC_37b2ba4d72ceb89cfb30009990025b2f();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel);
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  }
  return s;
}

public static Func<RC_37b2ba4d72ceb89cfb30009990025b2f, ssConectaProveedores.RestRecords.RESTRC_37b2ba4d72ceb89cfb30009990025b2f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_37b2ba4d72ceb89cfb30009990025b2f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_37b2ba4d72ceb89cfb30009990025b2f FromStructure(RC_37b2ba4d72ceb89cfb30009990025b2f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_37b2ba4d72ceb89cfb30009990025b2f(s, config);
}

}


