using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalCommentFileRecord
public class RESTRC_1fc482b76911051ba177b5ef645edd69 : AbstractRESTStructure<RC_1fc482b76911051ba177b5ef645edd69> {
[JsonProperty("ProposalCommentFile")]
public ssConectaProveedores.RestRecords.RESTEN_7db82b55fc996c1dcfda575a9310d307EntityRecord AttrProposalCommentFile;

public RESTRC_1fc482b76911051ba177b5ef645edd69() { }

public RESTRC_1fc482b76911051ba177b5ef645edd69 (RC_1fc482b76911051ba177b5ef645edd69 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalCommentFile = ConvertToRestWithoutDefaults(s.ssENProposalCommentFile, new EN_7db82b55fc996c1dcfda575a9310d307EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.FromStructure, config);
  } else {
AttrProposalCommentFile = ssConectaProveedores.RestRecords.RESTEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.FromStructure(s.ssENProposalCommentFile, config);
  }
}

public static RC_1fc482b76911051ba177b5ef645edd69 ToStructure(ssConectaProveedores.RestRecords.RESTRC_1fc482b76911051ba177b5ef645edd69 obj) { 
  RC_1fc482b76911051ba177b5ef645edd69 s = new RC_1fc482b76911051ba177b5ef645edd69();
  if(obj != null) {
  s.ssENProposalCommentFile = ssConectaProveedores.RestRecords.RESTEN_7db82b55fc996c1dcfda575a9310d307EntityRecord.ToStructure(obj.AttrProposalCommentFile);
  }
  return s;
}

public static Func<RC_1fc482b76911051ba177b5ef645edd69, ssConectaProveedores.RestRecords.RESTRC_1fc482b76911051ba177b5ef645edd69> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1fc482b76911051ba177b5ef645edd69 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1fc482b76911051ba177b5ef645edd69 FromStructure(RC_1fc482b76911051ba177b5ef645edd69 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1fc482b76911051ba177b5ef645edd69(s, config);
}

}


