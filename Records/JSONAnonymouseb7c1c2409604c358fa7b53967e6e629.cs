using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserProposalProposalStatusRecord
public class JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5 : AbstractRESTStructure<RC_7aa039fd81e6f2e2436b0f21d2ee75b5> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalStatus")]
[JsonPropertyName("ProposalStatus")]
public ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

public JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5() { }

public JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5 (RC_7aa039fd81e6f2e2436b0f21d2ee75b5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalStatus = ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5, RC_7aa039fd81e6f2e2436b0f21d2ee75b5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5 s) => ToStructure(s, config);
}
public static RC_7aa039fd81e6f2e2436b0f21d2ee75b5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5 obj, IBehaviorsConfiguration config) { 
  RC_7aa039fd81e6f2e2436b0f21d2ee75b5 s = new RC_7aa039fd81e6f2e2436b0f21d2ee75b5();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus, config);
  }
  return s;
}

public static Func<RC_7aa039fd81e6f2e2436b0f21d2ee75b5, ssConectaProveedores.RestRecords.JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7aa039fd81e6f2e2436b0f21d2ee75b5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5 FromStructure(RC_7aa039fd81e6f2e2436b0f21d2ee75b5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7aa039fd81e6f2e2436b0f21d2ee75b5(s, config);
}

}


