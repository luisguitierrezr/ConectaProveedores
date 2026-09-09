using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserProposalLogsProposalRecord
public class RESTRC_a6b7967ad624705fbcd9d81593f9e64b : AbstractRESTStructure<RC_a6b7967ad624705fbcd9d81593f9e64b> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("ProposalLogs")]
public ssConectaProveedores.RestRecords.RESTEN_013f76cfa3062515b73935963b1697b0EntityRecord AttrProposalLogs;

[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

public RESTRC_a6b7967ad624705fbcd9d81593f9e64b() { }

public RESTRC_a6b7967ad624705fbcd9d81593f9e64b (RC_a6b7967ad624705fbcd9d81593f9e64b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrProposalLogs = ConvertToRestWithoutDefaults(s.ssENProposalLogs, new EN_013f76cfa3062515b73935963b1697b0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure, config);
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrProposalLogs = ssConectaProveedores.RestRecords.RESTEN_013f76cfa3062515b73935963b1697b0EntityRecord.FromStructure(s.ssENProposalLogs, config);
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
  }
}

public static RC_a6b7967ad624705fbcd9d81593f9e64b ToStructure(ssConectaProveedores.RestRecords.RESTRC_a6b7967ad624705fbcd9d81593f9e64b obj) { 
  RC_a6b7967ad624705fbcd9d81593f9e64b s = new RC_a6b7967ad624705fbcd9d81593f9e64b();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENProposalLogs = ssConectaProveedores.RestRecords.RESTEN_013f76cfa3062515b73935963b1697b0EntityRecord.ToStructure(obj.AttrProposalLogs);
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  }
  return s;
}

public static Func<RC_a6b7967ad624705fbcd9d81593f9e64b, ssConectaProveedores.RestRecords.RESTRC_a6b7967ad624705fbcd9d81593f9e64b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a6b7967ad624705fbcd9d81593f9e64b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a6b7967ad624705fbcd9d81593f9e64b FromStructure(RC_a6b7967ad624705fbcd9d81593f9e64b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a6b7967ad624705fbcd9d81593f9e64b(s, config);
}

}


