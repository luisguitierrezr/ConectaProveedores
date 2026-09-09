using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalRecord
public class JSONRC_1e5bc1d6d010761f865e3a0774f1c819 : AbstractRESTStructure<RC_1e5bc1d6d010761f865e3a0774f1c819> {
[JsonProperty("ProposalApproval")]
[JsonPropertyName("ProposalApproval")]
public ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord AttrProposalApproval;

public JSONRC_1e5bc1d6d010761f865e3a0774f1c819() { }

public JSONRC_1e5bc1d6d010761f865e3a0774f1c819 (RC_1e5bc1d6d010761f865e3a0774f1c819 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApproval = ConvertToRestWithoutDefaults(s.ssENProposalApproval, new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure, config);
  } else {
AttrProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.FromStructure(s.ssENProposalApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1e5bc1d6d010761f865e3a0774f1c819, RC_1e5bc1d6d010761f865e3a0774f1c819> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1e5bc1d6d010761f865e3a0774f1c819 s) => ToStructure(s, config);
}
public static RC_1e5bc1d6d010761f865e3a0774f1c819 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1e5bc1d6d010761f865e3a0774f1c819 obj, IBehaviorsConfiguration config) { 
  RC_1e5bc1d6d010761f865e3a0774f1c819 s = new RC_1e5bc1d6d010761f865e3a0774f1c819();
  if(obj != null) {
  s.ssENProposalApproval = ssConectaProveedores.RestRecords.JSONEN_5464a383ceb6bec564e8dfa03f011357EntityRecord.ToStructure(obj.AttrProposalApproval, config);
  }
  return s;
}

public static Func<RC_1e5bc1d6d010761f865e3a0774f1c819, ssConectaProveedores.RestRecords.JSONRC_1e5bc1d6d010761f865e3a0774f1c819> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1e5bc1d6d010761f865e3a0774f1c819 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1e5bc1d6d010761f865e3a0774f1c819 FromStructure(RC_1e5bc1d6d010761f865e3a0774f1c819 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1e5bc1d6d010761f865e3a0774f1c819(s, config);
}

}


