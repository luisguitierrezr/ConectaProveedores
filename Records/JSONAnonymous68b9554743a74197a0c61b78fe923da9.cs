using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserProposalCommentApplicationRoleRecord
public class JSONRC_eb264c698175fb3dfb268b531134340c : AbstractRESTStructure<RC_eb264c698175fb3dfb268b531134340c> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("ProposalComment")]
[JsonPropertyName("ProposalComment")]
public ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord AttrProposalComment;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_eb264c698175fb3dfb268b531134340c() { }

public JSONRC_eb264c698175fb3dfb268b531134340c (RC_eb264c698175fb3dfb268b531134340c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrProposalComment = ConvertToRestWithoutDefaults(s.ssENProposalComment, new EN_c75b4bd59e1200fee3175175a6054340EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrProposalComment = ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.FromStructure(s.ssENProposalComment, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_eb264c698175fb3dfb268b531134340c, RC_eb264c698175fb3dfb268b531134340c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_eb264c698175fb3dfb268b531134340c s) => ToStructure(s, config);
}
public static RC_eb264c698175fb3dfb268b531134340c ToStructure(ssConectaProveedores.RestRecords.JSONRC_eb264c698175fb3dfb268b531134340c obj, IBehaviorsConfiguration config) { 
  RC_eb264c698175fb3dfb268b531134340c s = new RC_eb264c698175fb3dfb268b531134340c();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENProposalComment = ssConectaProveedores.RestRecords.JSONEN_c75b4bd59e1200fee3175175a6054340EntityRecord.ToStructure(obj.AttrProposalComment, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_eb264c698175fb3dfb268b531134340c, ssConectaProveedores.RestRecords.JSONRC_eb264c698175fb3dfb268b531134340c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eb264c698175fb3dfb268b531134340c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_eb264c698175fb3dfb268b531134340c FromStructure(RC_eb264c698175fb3dfb268b531134340c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_eb264c698175fb3dfb268b531134340c(s, config);
}

}


