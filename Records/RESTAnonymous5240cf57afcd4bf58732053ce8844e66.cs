using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalProposalTypeApprovalStatusProposalStatusProposalLineRecord
public class RESTRC_ad5e17bc33d6c36e94593cff1d9300bb : AbstractRESTStructure<RC_ad5e17bc33d6c36e94593cff1d9300bb> {
[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalType")]
public ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord AttrProposalType;

[JsonProperty("ApprovalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord AttrApprovalStatus;

[JsonProperty("ProposalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

[JsonProperty("ProposalLine")]
public ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

public RESTRC_ad5e17bc33d6c36e94593cff1d9300bb() { }

public RESTRC_ad5e17bc33d6c36e94593cff1d9300bb (RC_ad5e17bc33d6c36e94593cff1d9300bb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalType = ConvertToRestWithoutDefaults(s.ssENProposalType, new EN_7de728375ec552c47f71bca85f9991d9EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.FromStructure, config);
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssENApprovalStatus, new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure, config);
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalType = ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.FromStructure(s.ssENProposalType, config);
AttrApprovalStatus = ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure(s.ssENApprovalStatus, config);
AttrProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
AttrProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static RC_ad5e17bc33d6c36e94593cff1d9300bb ToStructure(ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb obj) { 
  RC_ad5e17bc33d6c36e94593cff1d9300bb s = new RC_ad5e17bc33d6c36e94593cff1d9300bb();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENProposalType = ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.ToStructure(obj.AttrProposalType);
  s.ssENApprovalStatus = ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.ToStructure(obj.AttrApprovalStatus);
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine);
  }
  return s;
}

public static Func<RC_ad5e17bc33d6c36e94593cff1d9300bb, ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ad5e17bc33d6c36e94593cff1d9300bb s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb FromStructure(RC_ad5e17bc33d6c36e94593cff1d9300bb s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb(s, config);
}

}


