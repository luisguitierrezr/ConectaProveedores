using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalProposalCommentProposalLineSupplierRegionRecord
public class RESTRC_344c35cf0b565533cad543b081be7d24 : AbstractRESTStructure<RC_344c35cf0b565533cad543b081be7d24> {
[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalComment")]
public ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

[JsonProperty("ProposalLine")]
public ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_344c35cf0b565533cad543b081be7d24() { }

public RESTRC_344c35cf0b565533cad543b081be7d24 (RC_344c35cf0b565533cad543b081be7d24 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
AttrProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_344c35cf0b565533cad543b081be7d24 ToStructure(ssConectaProveedores.RestRecords.RESTRC_344c35cf0b565533cad543b081be7d24 obj) { 
  RC_344c35cf0b565533cad543b081be7d24 s = new RC_344c35cf0b565533cad543b081be7d24();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_344c35cf0b565533cad543b081be7d24, ssConectaProveedores.RestRecords.RESTRC_344c35cf0b565533cad543b081be7d24> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_344c35cf0b565533cad543b081be7d24 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_344c35cf0b565533cad543b081be7d24 FromStructure(RC_344c35cf0b565533cad543b081be7d24 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_344c35cf0b565533cad543b081be7d24(s, config);
}

}


