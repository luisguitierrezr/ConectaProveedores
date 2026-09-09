using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyBankUploadedByProposalFileExtendedProposalTypeProposalStatusRegionRecord
public class JSONRC_8d415889034a2c958f8f82d7128f2067 : AbstractRESTStructure<RC_8d415889034a2c958f8f82d7128f2067> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("Bank")]
[JsonPropertyName("Bank")]
public ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord AttrBank;

[JsonProperty("UploadedBy")]
[JsonPropertyName("UploadedBy")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUploadedBy;

[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("FileExtended")]
[JsonPropertyName("FileExtended")]
public ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord AttrFileExtended;

[JsonProperty("ProposalType")]
[JsonPropertyName("ProposalType")]
public ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord AttrProposalType;

[JsonProperty("ProposalStatus")]
[JsonPropertyName("ProposalStatus")]
public ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_8d415889034a2c958f8f82d7128f2067() { }

public JSONRC_8d415889034a2c958f8f82d7128f2067 (RC_8d415889034a2c958f8f82d7128f2067 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrBank = ConvertToRestWithoutDefaults(s.ssENBank, new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.FromStructure, config);
AttrUploadedBy = ConvertToRestWithoutDefaults(s.ssENUploadedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrFileExtended = ConvertToRestWithoutDefaults(s.ssENFileExtended, new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure, config);
AttrProposalType = ConvertToRestWithoutDefaults(s.ssENProposalType, new EN_7de728375ec552c47f71bca85f9991d9EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord.FromStructure, config);
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrBank = ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.FromStructure(s.ssENBank, config);
AttrUploadedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUploadedBy, config);
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrFileExtended = ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure(s.ssENFileExtended, config);
AttrProposalType = ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord.FromStructure(s.ssENProposalType, config);
AttrProposalStatus = ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8d415889034a2c958f8f82d7128f2067, RC_8d415889034a2c958f8f82d7128f2067> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8d415889034a2c958f8f82d7128f2067 s) => ToStructure(s, config);
}
public static RC_8d415889034a2c958f8f82d7128f2067 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8d415889034a2c958f8f82d7128f2067 obj, IBehaviorsConfiguration config) { 
  RC_8d415889034a2c958f8f82d7128f2067 s = new RC_8d415889034a2c958f8f82d7128f2067();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENBank = ssConectaProveedores.RestRecords.JSONEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord.ToStructure(obj.AttrBank, config);
  s.ssENUploadedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUploadedBy, config);
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENFileExtended = ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.ToStructure(obj.AttrFileExtended, config);
  s.ssENProposalType = ssConectaProveedores.RestRecords.JSONEN_7de728375ec552c47f71bca85f9991d9EntityRecord.ToStructure(obj.AttrProposalType, config);
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_8d415889034a2c958f8f82d7128f2067, ssConectaProveedores.RestRecords.JSONRC_8d415889034a2c958f8f82d7128f2067> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d415889034a2c958f8f82d7128f2067 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8d415889034a2c958f8f82d7128f2067 FromStructure(RC_8d415889034a2c958f8f82d7128f2067 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8d415889034a2c958f8f82d7128f2067(s, config);
}

}


