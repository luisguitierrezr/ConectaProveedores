using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalProposalApprovalRecord
public class RESTRC_577e0d18883096d0ebc3eb78e20586ee : AbstractRESTStructure<RC_577e0d18883096d0ebc3eb78e20586ee> {
[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalApproval")]
public ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

public RESTRC_577e0d18883096d0ebc3eb78e20586ee() { }

public RESTRC_577e0d18883096d0ebc3eb78e20586ee (RC_577e0d18883096d0ebc3eb78e20586ee s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
  }
}

public static RC_577e0d18883096d0ebc3eb78e20586ee ToStructure(ssConectaProveedores.RestRecords.RESTRC_577e0d18883096d0ebc3eb78e20586ee obj) { 
  RC_577e0d18883096d0ebc3eb78e20586ee s = new RC_577e0d18883096d0ebc3eb78e20586ee();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval);
  }
  return s;
}

public static Func<RC_577e0d18883096d0ebc3eb78e20586ee, ssConectaProveedores.RestRecords.RESTRC_577e0d18883096d0ebc3eb78e20586ee> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_577e0d18883096d0ebc3eb78e20586ee s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_577e0d18883096d0ebc3eb78e20586ee FromStructure(RC_577e0d18883096d0ebc3eb78e20586ee s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_577e0d18883096d0ebc3eb78e20586ee(s, config);
}

}


