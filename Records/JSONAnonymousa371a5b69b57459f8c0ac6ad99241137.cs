using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalCommentProposalCommentFileProposalLineRecord
public class JSONRC_781b0cc57cc94effbff3496f8da9c758 : AbstractRESTStructure<RC_781b0cc57cc94effbff3496f8da9c758> {
[JsonProperty("ProposalComment")]
[JsonPropertyName("ProposalComment")]
public ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

[JsonProperty("ProposalCommentFile")]
[JsonPropertyName("ProposalCommentFile")]
public ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord AttrProposalCommentFile;

[JsonProperty("ProposalLine")]
[JsonPropertyName("ProposalLine")]
public ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

public JSONRC_781b0cc57cc94effbff3496f8da9c758() { }

public JSONRC_781b0cc57cc94effbff3496f8da9c758 (RC_781b0cc57cc94effbff3496f8da9c758 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
AttrProposalCommentFile = ConvertToRestWithoutDefaults(s.ssENProposalCommentFile, new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposalComment = ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
AttrProposalCommentFile = ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.FromStructure(s.ssENProposalCommentFile, config);
AttrProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_781b0cc57cc94effbff3496f8da9c758, RC_781b0cc57cc94effbff3496f8da9c758> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_781b0cc57cc94effbff3496f8da9c758 s) => ToStructure(s, config);
}
public static RC_781b0cc57cc94effbff3496f8da9c758 ToStructure(ssConectaProveedores.RestRecords.JSONRC_781b0cc57cc94effbff3496f8da9c758 obj, IBehaviorsConfiguration config) { 
  RC_781b0cc57cc94effbff3496f8da9c758 s = new RC_781b0cc57cc94effbff3496f8da9c758();
  if(obj != null) {
  s.ssENProposalComment = ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment, config);
  s.ssENProposalCommentFile = ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.ToStructure(obj.AttrProposalCommentFile, config);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine, config);
  }
  return s;
}

public static Func<RC_781b0cc57cc94effbff3496f8da9c758, ssConectaProveedores.RestRecords.JSONRC_781b0cc57cc94effbff3496f8da9c758> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_781b0cc57cc94effbff3496f8da9c758 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_781b0cc57cc94effbff3496f8da9c758 FromStructure(RC_781b0cc57cc94effbff3496f8da9c758 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_781b0cc57cc94effbff3496f8da9c758(s, config);
}

}


