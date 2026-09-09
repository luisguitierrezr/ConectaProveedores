using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserProposalCommentApplicationRoleRecord
public class RESTRC_eb264c698175fb3dfb268b531134340c : AbstractRESTStructure<RC_eb264c698175fb3dfb268b531134340c> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("ProposalComment")]
public ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public RESTRC_eb264c698175fb3dfb268b531134340c() { }

public RESTRC_eb264c698175fb3dfb268b531134340c (RC_eb264c698175fb3dfb268b531134340c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static RC_eb264c698175fb3dfb268b531134340c ToStructure(ssConectaProveedores.RestRecords.RESTRC_eb264c698175fb3dfb268b531134340c obj) { 
  RC_eb264c698175fb3dfb268b531134340c s = new RC_eb264c698175fb3dfb268b531134340c();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENProposalComment = ssConectaProveedores.RestRecords.RESTEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  }
  return s;
}

public static Func<RC_eb264c698175fb3dfb268b531134340c, ssConectaProveedores.RestRecords.RESTRC_eb264c698175fb3dfb268b531134340c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eb264c698175fb3dfb268b531134340c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_eb264c698175fb3dfb268b531134340c FromStructure(RC_eb264c698175fb3dfb268b531134340c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_eb264c698175fb3dfb268b531134340c(s, config);
}

}


