using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyBankUploadedByProposalFileExtendedProposalTypeProposalStatusRegionRecord
public class RESTRC_8d415889034a2c958f8f82d7128f2067 : AbstractRESTStructure<RC_8d415889034a2c958f8f82d7128f2067> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("Bank")]
public ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord AttrBank;

[JsonProperty("UploadedBy")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUploadedBy;

[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("FileExtended")]
public ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord AttrFileExtended;

[JsonProperty("ProposalType")]
public ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord AttrProposalType;

[JsonProperty("ProposalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_8d415889034a2c958f8f82d7128f2067() { }

public RESTRC_8d415889034a2c958f8f82d7128f2067 (RC_8d415889034a2c958f8f82d7128f2067 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrBank = ConvertToRestWithoutDefaults(s.ssENBank, new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.FromStructure, config);
AttrUploadedBy = ConvertToRestWithoutDefaults(s.ssENUploadedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrFileExtended = ConvertToRestWithoutDefaults(s.ssENFileExtended, new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure, config);
AttrProposalType = ConvertToRestWithoutDefaults(s.ssENProposalType, new EN_7de728375ec552c47f71bca85f9991d9EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.FromStructure, config);
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrBank = ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.FromStructure(s.ssENBank, config);
AttrUploadedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUploadedBy, config);
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrFileExtended = ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure(s.ssENFileExtended, config);
AttrProposalType = ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.FromStructure(s.ssENProposalType, config);
AttrProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_8d415889034a2c958f8f82d7128f2067 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067 obj) { 
  RC_8d415889034a2c958f8f82d7128f2067 s = new RC_8d415889034a2c958f8f82d7128f2067();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  s.ssENBank = ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.ToStructure(obj.AttrBank);
  s.ssENUploadedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUploadedBy);
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENFileExtended = ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.ToStructure(obj.AttrFileExtended);
  s.ssENProposalType = ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.ToStructure(obj.AttrProposalType);
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_8d415889034a2c958f8f82d7128f2067, ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d415889034a2c958f8f82d7128f2067 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067 FromStructure(RC_8d415889034a2c958f8f82d7128f2067 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067(s, config);
}

}


