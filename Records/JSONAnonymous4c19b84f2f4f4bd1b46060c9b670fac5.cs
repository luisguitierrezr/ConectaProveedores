using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalProposalApprovalRecord
public class JSONRC_577e0d18883096d0ebc3eb78e20586ee : AbstractRESTStructure<RC_577e0d18883096d0ebc3eb78e20586ee> {
[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalApproval")]
[JsonPropertyName("ProposalApproval")]
public ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

public JSONRC_577e0d18883096d0ebc3eb78e20586ee() { }

public JSONRC_577e0d18883096d0ebc3eb78e20586ee (RC_577e0d18883096d0ebc3eb78e20586ee s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_577e0d18883096d0ebc3eb78e20586ee, RC_577e0d18883096d0ebc3eb78e20586ee> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_577e0d18883096d0ebc3eb78e20586ee s) => ToStructure(s, config);
}
public static RC_577e0d18883096d0ebc3eb78e20586ee ToStructure(ssConectaProveedores.RestRecords.JSONRC_577e0d18883096d0ebc3eb78e20586ee obj, IBehaviorsConfiguration config) { 
  RC_577e0d18883096d0ebc3eb78e20586ee s = new RC_577e0d18883096d0ebc3eb78e20586ee();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval, config);
  }
  return s;
}

public static Func<RC_577e0d18883096d0ebc3eb78e20586ee, ssConectaProveedores.RestRecords.JSONRC_577e0d18883096d0ebc3eb78e20586ee> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_577e0d18883096d0ebc3eb78e20586ee s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_577e0d18883096d0ebc3eb78e20586ee FromStructure(RC_577e0d18883096d0ebc3eb78e20586ee s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_577e0d18883096d0ebc3eb78e20586ee(s, config);
}

}


