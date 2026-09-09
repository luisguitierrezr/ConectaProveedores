using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalProposalCommentProposalLineSupplierRegionRecord
public class JSONRC_344c35cf0b565533cad543b081be7d24 : AbstractRESTStructure<RC_344c35cf0b565533cad543b081be7d24> {
[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalComment")]
[JsonPropertyName("ProposalComment")]
public ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

[JsonProperty("ProposalLine")]
[JsonPropertyName("ProposalLine")]
public ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

[JsonProperty("Supplier")]
[JsonPropertyName("Supplier")]
public ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_344c35cf0b565533cad543b081be7d24() { }

public JSONRC_344c35cf0b565533cad543b081be7d24 (RC_344c35cf0b565533cad543b081be7d24 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalComment = ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
AttrProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
AttrSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_344c35cf0b565533cad543b081be7d24, RC_344c35cf0b565533cad543b081be7d24> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_344c35cf0b565533cad543b081be7d24 s) => ToStructure(s, config);
}
public static RC_344c35cf0b565533cad543b081be7d24 ToStructure(ssConectaProveedores.RestRecords.JSONRC_344c35cf0b565533cad543b081be7d24 obj, IBehaviorsConfiguration config) { 
  RC_344c35cf0b565533cad543b081be7d24 s = new RC_344c35cf0b565533cad543b081be7d24();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENProposalComment = ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment, config);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine, config);
  s.ssENSupplier = ssConectaProveedores.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_344c35cf0b565533cad543b081be7d24, ssConectaProveedores.RestRecords.JSONRC_344c35cf0b565533cad543b081be7d24> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_344c35cf0b565533cad543b081be7d24 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_344c35cf0b565533cad543b081be7d24 FromStructure(RC_344c35cf0b565533cad543b081be7d24 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_344c35cf0b565533cad543b081be7d24(s, config);
}

}


