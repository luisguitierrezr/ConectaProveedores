using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_PaidUser_UnpaidProposalCommentProposalLineIsSelectedRecord
public class RESTRC_b34001d496bee16bcec019df0c313eb6 : AbstractRESTStructure<RC_b34001d496bee16bcec019df0c313eb6> {
[JsonProperty("User_Paid")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Paid;

[JsonProperty("User_Unpaid")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_Unpaid;

[JsonProperty("ProposalComment")]
public ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

[JsonProperty("ProposalLine")]
public ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

[JsonProperty("IsSelected")]
public bool? AttrIsSelected;

public RESTRC_b34001d496bee16bcec019df0c313eb6() { }

public RESTRC_b34001d496bee16bcec019df0c313eb6 (RC_b34001d496bee16bcec019df0c313eb6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Paid = ConvertToRestWithoutDefaults(s.ssENUser_Paid, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_Unpaid = ConvertToRestWithoutDefaults(s.ssENUser_Unpaid, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
AttrIsSelected = ConvertToRestWithoutDefaults(s.ssIsSelected, false);
  } else {
AttrUser_Paid = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Paid, config);
AttrUser_Unpaid = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_Unpaid, config);
AttrProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
AttrProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
AttrIsSelected = (bool?) s.ssIsSelected;
  }
}

public static RC_b34001d496bee16bcec019df0c313eb6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_b34001d496bee16bcec019df0c313eb6 obj) { 
  RC_b34001d496bee16bcec019df0c313eb6 s = new RC_b34001d496bee16bcec019df0c313eb6();
  if(obj != null) {
  s.ssENUser_Paid = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Paid);
  s.ssENUser_Unpaid = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_Unpaid);
  s.ssENProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine);
  s.ssIsSelected = obj.AttrIsSelected == null ? false : obj.AttrIsSelected.Value;
  }
  return s;
}

public static Func<RC_b34001d496bee16bcec019df0c313eb6, ssConectaProveedores.RestRecords.RESTRC_b34001d496bee16bcec019df0c313eb6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b34001d496bee16bcec019df0c313eb6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b34001d496bee16bcec019df0c313eb6 FromStructure(RC_b34001d496bee16bcec019df0c313eb6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b34001d496bee16bcec019df0c313eb6(s, config);
}

}


