using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserProposalProposalStatusRecord
public class RESTRC_7aa039fd81e6f2e2436b0f21d2ee75b5 : AbstractRESTStructure<RC_7aa039fd81e6f2e2436b0f21d2ee75b5> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

public RESTRC_7aa039fd81e6f2e2436b0f21d2ee75b5() { }

public RESTRC_7aa039fd81e6f2e2436b0f21d2ee75b5 (RC_7aa039fd81e6f2e2436b0f21d2ee75b5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
  }
}

public static RC_7aa039fd81e6f2e2436b0f21d2ee75b5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7aa039fd81e6f2e2436b0f21d2ee75b5 obj) { 
  RC_7aa039fd81e6f2e2436b0f21d2ee75b5 s = new RC_7aa039fd81e6f2e2436b0f21d2ee75b5();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus);
  }
  return s;
}

public static Func<RC_7aa039fd81e6f2e2436b0f21d2ee75b5, ssConectaProveedores.RestRecords.RESTRC_7aa039fd81e6f2e2436b0f21d2ee75b5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7aa039fd81e6f2e2436b0f21d2ee75b5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7aa039fd81e6f2e2436b0f21d2ee75b5 FromStructure(RC_7aa039fd81e6f2e2436b0f21d2ee75b5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7aa039fd81e6f2e2436b0f21d2ee75b5(s, config);
}

}


