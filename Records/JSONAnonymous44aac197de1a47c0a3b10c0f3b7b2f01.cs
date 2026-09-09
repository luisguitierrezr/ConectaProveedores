using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalProposalApprovalApplicationRoleRecord
public class JSONRC_37b2ba4d72ceb89cfb30009990025b2f : AbstractRESTStructure<RC_37b2ba4d72ceb89cfb30009990025b2f> {
[JsonProperty("ProposalApprovalLevel")]
[JsonPropertyName("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalApproval")]
[JsonPropertyName("ProposalApproval")]
public ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_37b2ba4d72ceb89cfb30009990025b2f() { }

public JSONRC_37b2ba4d72ceb89cfb30009990025b2f (RC_37b2ba4d72ceb89cfb30009990025b2f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_37b2ba4d72ceb89cfb30009990025b2f, RC_37b2ba4d72ceb89cfb30009990025b2f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_37b2ba4d72ceb89cfb30009990025b2f s) => ToStructure(s, config);
}
public static RC_37b2ba4d72ceb89cfb30009990025b2f ToStructure(ssConectaProveedores.RestRecords.JSONRC_37b2ba4d72ceb89cfb30009990025b2f obj, IBehaviorsConfiguration config) { 
  RC_37b2ba4d72ceb89cfb30009990025b2f s = new RC_37b2ba4d72ceb89cfb30009990025b2f();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel, config);
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_37b2ba4d72ceb89cfb30009990025b2f, ssConectaProveedores.RestRecords.JSONRC_37b2ba4d72ceb89cfb30009990025b2f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_37b2ba4d72ceb89cfb30009990025b2f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_37b2ba4d72ceb89cfb30009990025b2f FromStructure(RC_37b2ba4d72ceb89cfb30009990025b2f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_37b2ba4d72ceb89cfb30009990025b2f(s, config);
}

}


