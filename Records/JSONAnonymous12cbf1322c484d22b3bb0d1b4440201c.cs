using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalCommentFileRecord
public class JSONRC_1fc482b76911051ba177b5ef645edd69 : AbstractRESTStructure<RC_1fc482b76911051ba177b5ef645edd69> {
[JsonProperty("ProposalCommentFile")]
[JsonPropertyName("ProposalCommentFile")]
public ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord AttrProposalCommentFile;

public JSONRC_1fc482b76911051ba177b5ef645edd69() { }

public JSONRC_1fc482b76911051ba177b5ef645edd69 (RC_1fc482b76911051ba177b5ef645edd69 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalCommentFile = ConvertToRestWithoutDefaults(s.ssENProposalCommentFile, new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.FromStructure, config);
  } else {
AttrProposalCommentFile = ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.FromStructure(s.ssENProposalCommentFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1fc482b76911051ba177b5ef645edd69, RC_1fc482b76911051ba177b5ef645edd69> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1fc482b76911051ba177b5ef645edd69 s) => ToStructure(s, config);
}
public static RC_1fc482b76911051ba177b5ef645edd69 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1fc482b76911051ba177b5ef645edd69 obj, IBehaviorsConfiguration config) { 
  RC_1fc482b76911051ba177b5ef645edd69 s = new RC_1fc482b76911051ba177b5ef645edd69();
  if(obj != null) {
  s.ssENProposalCommentFile = ssConectaProveedores.RestRecords.JSONEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.ToStructure(obj.AttrProposalCommentFile, config);
  }
  return s;
}

public static Func<RC_1fc482b76911051ba177b5ef645edd69, ssConectaProveedores.RestRecords.JSONRC_1fc482b76911051ba177b5ef645edd69> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1fc482b76911051ba177b5ef645edd69 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1fc482b76911051ba177b5ef645edd69 FromStructure(RC_1fc482b76911051ba177b5ef645edd69 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1fc482b76911051ba177b5ef645edd69(s, config);
}

}


