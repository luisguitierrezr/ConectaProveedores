using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalRecord
public class RESTRC_1e5bc1d6d010761f865e3a0774f1c819 : AbstractRESTStructure<RC_1e5bc1d6d010761f865e3a0774f1c819> {
[JsonProperty("ProposalApproval")]
public ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

public RESTRC_1e5bc1d6d010761f865e3a0774f1c819() { }

public RESTRC_1e5bc1d6d010761f865e3a0774f1c819 (RC_1e5bc1d6d010761f865e3a0774f1c819 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
  } else {
AttrProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
  }
}

public static RC_1e5bc1d6d010761f865e3a0774f1c819 ToStructure(ssConectaProveedores.RestRecords.RESTRC_1e5bc1d6d010761f865e3a0774f1c819 obj) { 
  RC_1e5bc1d6d010761f865e3a0774f1c819 s = new RC_1e5bc1d6d010761f865e3a0774f1c819();
  if(obj != null) {
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.RESTEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval);
  }
  return s;
}

public static Func<RC_1e5bc1d6d010761f865e3a0774f1c819, ssConectaProveedores.RestRecords.RESTRC_1e5bc1d6d010761f865e3a0774f1c819> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1e5bc1d6d010761f865e3a0774f1c819 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1e5bc1d6d010761f865e3a0774f1c819 FromStructure(RC_1e5bc1d6d010761f865e3a0774f1c819 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1e5bc1d6d010761f865e3a0774f1c819(s, config);
}

}


