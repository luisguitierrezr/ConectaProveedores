using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserProposalLogsProposalRecord
public class JSONRC_a6b7967ad624705fbcd9d81593f9e64b : AbstractRESTStructure<RC_a6b7967ad624705fbcd9d81593f9e64b> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("ProposalLogs")]
[JsonPropertyName("ProposalLogs")]
public ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord AttrProposalLogs;

[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

public JSONRC_a6b7967ad624705fbcd9d81593f9e64b() { }

public JSONRC_a6b7967ad624705fbcd9d81593f9e64b (RC_a6b7967ad624705fbcd9d81593f9e64b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrProposalLogs = ConvertToRestWithoutDefaults(s.ssENProposalLogs, new EN_013f76cfa3062515b73935963b1697b0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrProposalLogs = ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure(s.ssENProposalLogs, config);
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a6b7967ad624705fbcd9d81593f9e64b, RC_a6b7967ad624705fbcd9d81593f9e64b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a6b7967ad624705fbcd9d81593f9e64b s) => ToStructure(s, config);
}
public static RC_a6b7967ad624705fbcd9d81593f9e64b ToStructure(ssConectaProveedores.RestRecords.JSONRC_a6b7967ad624705fbcd9d81593f9e64b obj, IBehaviorsConfiguration config) { 
  RC_a6b7967ad624705fbcd9d81593f9e64b s = new RC_a6b7967ad624705fbcd9d81593f9e64b();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENProposalLogs = ssConectaProveedores.RestRecords.JSONEN_013f76cfa3062515b73935963b1697b0EntityRecord.ToStructure(obj.AttrProposalLogs, config);
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  }
  return s;
}

public static Func<RC_a6b7967ad624705fbcd9d81593f9e64b, ssConectaProveedores.RestRecords.JSONRC_a6b7967ad624705fbcd9d81593f9e64b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a6b7967ad624705fbcd9d81593f9e64b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a6b7967ad624705fbcd9d81593f9e64b FromStructure(RC_a6b7967ad624705fbcd9d81593f9e64b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a6b7967ad624705fbcd9d81593f9e64b(s, config);
}

}


