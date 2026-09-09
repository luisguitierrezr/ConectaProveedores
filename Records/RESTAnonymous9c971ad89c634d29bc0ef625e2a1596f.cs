using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalCommentRecord
public class RESTRC_cd5101cd31ffd8dc09aecaca6d77004a : AbstractRESTStructure<RC_cd5101cd31ffd8dc09aecaca6d77004a> {
[JsonProperty("ProposalComment")]
public ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

public RESTRC_cd5101cd31ffd8dc09aecaca6d77004a() { }

public RESTRC_cd5101cd31ffd8dc09aecaca6d77004a (RC_cd5101cd31ffd8dc09aecaca6d77004a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
  } else {
AttrProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
  }
}

public static RC_cd5101cd31ffd8dc09aecaca6d77004a ToStructure(ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a obj) { 
  RC_cd5101cd31ffd8dc09aecaca6d77004a s = new RC_cd5101cd31ffd8dc09aecaca6d77004a();
  if(obj != null) {
  s.ssENProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment);
  }
  return s;
}

public static Func<RC_cd5101cd31ffd8dc09aecaca6d77004a, ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cd5101cd31ffd8dc09aecaca6d77004a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a FromStructure(RC_cd5101cd31ffd8dc09aecaca6d77004a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cd5101cd31ffd8dc09aecaca6d77004a(s, config);
}

}


