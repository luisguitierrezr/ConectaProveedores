using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalCommentProposalCommentFileProposalLineRecord
public class RESTRC_781b0cc57cc94effbff3496f8da9c758 : AbstractRESTStructure<RC_781b0cc57cc94effbff3496f8da9c758> {
[JsonProperty("ProposalComment")]
public ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

[JsonProperty("ProposalCommentFile")]
public ssConectaProveedores.RestRecords.RESTEN_7db82b55fc996c1dcfda575a9310d307EntityRecord AttrProposalCommentFile;

[JsonProperty("ProposalLine")]
public ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

public RESTRC_781b0cc57cc94effbff3496f8da9c758() { }

public RESTRC_781b0cc57cc94effbff3496f8da9c758 (RC_781b0cc57cc94effbff3496f8da9c758 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
AttrProposalCommentFile = ConvertToRestWithoutDefaults(s.ssENProposalCommentFile, new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
AttrProposalCommentFile = ssConectaProveedores.RestRecords.RESTEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.FromStructure(s.ssENProposalCommentFile, config);
AttrProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static RC_781b0cc57cc94effbff3496f8da9c758 ToStructure(ssConectaProveedores.RestRecords.RESTRC_781b0cc57cc94effbff3496f8da9c758 obj) { 
  RC_781b0cc57cc94effbff3496f8da9c758 s = new RC_781b0cc57cc94effbff3496f8da9c758();
  if(obj != null) {
  s.ssENProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment);
  s.ssENProposalCommentFile = ssConectaProveedores.RestRecords.RESTEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.ToStructure(obj.AttrProposalCommentFile);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine);
  }
  return s;
}

public static Func<RC_781b0cc57cc94effbff3496f8da9c758, ssConectaProveedores.RestRecords.RESTRC_781b0cc57cc94effbff3496f8da9c758> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_781b0cc57cc94effbff3496f8da9c758 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_781b0cc57cc94effbff3496f8da9c758 FromStructure(RC_781b0cc57cc94effbff3496f8da9c758 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_781b0cc57cc94effbff3496f8da9c758(s, config);
}

}


