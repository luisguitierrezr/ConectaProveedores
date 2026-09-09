using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalRecord
public class RESTRC_91adc4f46f8a0f51cacc4bc718d2ea35 : AbstractRESTStructure<RC_91adc4f46f8a0f51cacc4bc718d2ea35> {
[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

public RESTRC_91adc4f46f8a0f51cacc4bc718d2ea35() { }

public RESTRC_91adc4f46f8a0f51cacc4bc718d2ea35 (RC_91adc4f46f8a0f51cacc4bc718d2ea35 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
  }
}

public static RC_91adc4f46f8a0f51cacc4bc718d2ea35 ToStructure(ssConectaProveedores.RestRecords.RESTRC_91adc4f46f8a0f51cacc4bc718d2ea35 obj) { 
  RC_91adc4f46f8a0f51cacc4bc718d2ea35 s = new RC_91adc4f46f8a0f51cacc4bc718d2ea35();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  }
  return s;
}

public static Func<RC_91adc4f46f8a0f51cacc4bc718d2ea35, ssConectaProveedores.RestRecords.RESTRC_91adc4f46f8a0f51cacc4bc718d2ea35> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_91adc4f46f8a0f51cacc4bc718d2ea35 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_91adc4f46f8a0f51cacc4bc718d2ea35 FromStructure(RC_91adc4f46f8a0f51cacc4bc718d2ea35 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_91adc4f46f8a0f51cacc4bc718d2ea35(s, config);
}

}


