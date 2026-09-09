using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalProposalLineRecord
public class RESTRC_05f5be3a1430a1bea3f80a8be6d08c9b : AbstractRESTStructure<RC_05f5be3a1430a1bea3f80a8be6d08c9b> {
[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("ProposalLine")]
public ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

public RESTRC_05f5be3a1430a1bea3f80a8be6d08c9b() { }

public RESTRC_05f5be3a1430a1bea3f80a8be6d08c9b (RC_05f5be3a1430a1bea3f80a8be6d08c9b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static RC_05f5be3a1430a1bea3f80a8be6d08c9b ToStructure(ssConectaProveedores.RestRecords.RESTRC_05f5be3a1430a1bea3f80a8be6d08c9b obj) { 
  RC_05f5be3a1430a1bea3f80a8be6d08c9b s = new RC_05f5be3a1430a1bea3f80a8be6d08c9b();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine);
  }
  return s;
}

public static Func<RC_05f5be3a1430a1bea3f80a8be6d08c9b, ssConectaProveedores.RestRecords.RESTRC_05f5be3a1430a1bea3f80a8be6d08c9b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_05f5be3a1430a1bea3f80a8be6d08c9b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_05f5be3a1430a1bea3f80a8be6d08c9b FromStructure(RC_05f5be3a1430a1bea3f80a8be6d08c9b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_05f5be3a1430a1bea3f80a8be6d08c9b(s, config);
}

}


