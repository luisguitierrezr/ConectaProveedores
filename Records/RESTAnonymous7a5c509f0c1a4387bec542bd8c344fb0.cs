using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalProposalStatusProposalApprovalRecord
public class RESTRC_8d4e836281190fb3045013ce70fbff7d : AbstractRESTStructure<RC_8d4e836281190fb3045013ce70fbff7d> {
[JsonProperty("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

[JsonProperty("ProposalApproval")]
public ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

public RESTRC_8d4e836281190fb3045013ce70fbff7d() { }

public RESTRC_8d4e836281190fb3045013ce70fbff7d (RC_8d4e836281190fb3045013ce70fbff7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
  }
}

public static RC_8d4e836281190fb3045013ce70fbff7d ToStructure(ssConectaProveedores.RestRecords.RESTRC_8d4e836281190fb3045013ce70fbff7d obj) { 
  RC_8d4e836281190fb3045013ce70fbff7d s = new RC_8d4e836281190fb3045013ce70fbff7d();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel);
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval);
  }
  return s;
}

public static Func<RC_8d4e836281190fb3045013ce70fbff7d, ssConectaProveedores.RestRecords.RESTRC_8d4e836281190fb3045013ce70fbff7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d4e836281190fb3045013ce70fbff7d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8d4e836281190fb3045013ce70fbff7d FromStructure(RC_8d4e836281190fb3045013ce70fbff7d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8d4e836281190fb3045013ce70fbff7d(s, config);
}

}


