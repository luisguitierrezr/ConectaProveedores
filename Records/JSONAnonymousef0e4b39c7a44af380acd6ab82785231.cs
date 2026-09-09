using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_PaidUser_UnpaidProposalCommentProposalLineIsSelectedRecord
public class JSONRC_b34001d496bee16bcec019df0c313eb6 : AbstractRESTStructure<RC_b34001d496bee16bcec019df0c313eb6> {
[JsonProperty("User_Paid")]
[JsonPropertyName("User_Paid")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Paid;

[JsonProperty("User_Unpaid")]
[JsonPropertyName("User_Unpaid")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Unpaid;

[JsonProperty("ProposalComment")]
[JsonPropertyName("ProposalComment")]
public ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

[JsonProperty("ProposalLine")]
[JsonPropertyName("ProposalLine")]
public ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

[JsonProperty("IsSelected")]
[JsonPropertyName("IsSelected")]
public bool? AttrIsSelected;

public JSONRC_b34001d496bee16bcec019df0c313eb6() { }

public JSONRC_b34001d496bee16bcec019df0c313eb6 (RC_b34001d496bee16bcec019df0c313eb6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Paid = ConvertToRestWithoutDefaults(s.ssENUser_Paid, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Unpaid = ConvertToRestWithoutDefaults(s.ssENUser_Unpaid, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrUser_Paid = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Paid, config);
AttrUser_Unpaid = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Unpaid, config);
AttrProposalComment = ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
AttrProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b34001d496bee16bcec019df0c313eb6, RC_b34001d496bee16bcec019df0c313eb6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b34001d496bee16bcec019df0c313eb6 s) => ToStructure(s, config);
}
public static RC_b34001d496bee16bcec019df0c313eb6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_b34001d496bee16bcec019df0c313eb6 obj, IBehaviorsConfiguration config) { 
  RC_b34001d496bee16bcec019df0c313eb6 s = new RC_b34001d496bee16bcec019df0c313eb6();
  if(obj != null) {
  s.ssENUser_Paid = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Paid, config);
  s.ssENUser_Unpaid = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Unpaid, config);
  s.ssENProposalComment = ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment, config);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine, config);
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<RC_b34001d496bee16bcec019df0c313eb6, ssConectaProveedores.RestRecords.JSONRC_b34001d496bee16bcec019df0c313eb6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b34001d496bee16bcec019df0c313eb6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b34001d496bee16bcec019df0c313eb6 FromStructure(RC_b34001d496bee16bcec019df0c313eb6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b34001d496bee16bcec019df0c313eb6(s, config);
}

}


