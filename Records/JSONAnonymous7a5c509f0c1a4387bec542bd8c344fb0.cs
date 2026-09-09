using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelProposalProposalStatusProposalApprovalRecord
public class JSONRC_8d4e836281190fb3045013ce70fbff7d : AbstractRESTStructure<RC_8d4e836281190fb3045013ce70fbff7d> {
[JsonProperty("ProposalApprovalLevel")]
[JsonPropertyName("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalStatus")]
[JsonPropertyName("ProposalStatus")]
public ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

[JsonProperty("ProposalApproval")]
[JsonPropertyName("ProposalApproval")]
public ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

public JSONRC_8d4e836281190fb3045013ce70fbff7d() { }

public JSONRC_8d4e836281190fb3045013ce70fbff7d (RC_8d4e836281190fb3045013ce70fbff7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalStatus = ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8d4e836281190fb3045013ce70fbff7d, RC_8d4e836281190fb3045013ce70fbff7d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8d4e836281190fb3045013ce70fbff7d s) => ToStructure(s, config);
}
public static RC_8d4e836281190fb3045013ce70fbff7d ToStructure(ssConectaProveedores.RestRecords.JSONRC_8d4e836281190fb3045013ce70fbff7d obj, IBehaviorsConfiguration config) { 
  RC_8d4e836281190fb3045013ce70fbff7d s = new RC_8d4e836281190fb3045013ce70fbff7d();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel, config);
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus, config);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval, config);
  }
  return s;
}

public static Func<RC_8d4e836281190fb3045013ce70fbff7d, ssConectaProveedores.RestRecords.JSONRC_8d4e836281190fb3045013ce70fbff7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d4e836281190fb3045013ce70fbff7d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8d4e836281190fb3045013ce70fbff7d FromStructure(RC_8d4e836281190fb3045013ce70fbff7d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8d4e836281190fb3045013ce70fbff7d(s, config);
}

}


