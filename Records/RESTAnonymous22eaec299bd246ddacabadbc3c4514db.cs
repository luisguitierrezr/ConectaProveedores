using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalFileExtendedRecord
public class RESTRC_2a29aed0a2b753b8e46cbcb586392c66 : AbstractRESTStructure<RC_2a29aed0a2b753b8e46cbcb586392c66> {
[JsonProperty("Proposal")]
public ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("FileExtended")]
public ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord AttrFileExtended;

public RESTRC_2a29aed0a2b753b8e46cbcb586392c66() { }

public RESTRC_2a29aed0a2b753b8e46cbcb586392c66 (RC_2a29aed0a2b753b8e46cbcb586392c66 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrFileExtended = ConvertToRestWithoutDefaults(s.ssENFileExtended, new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrFileExtended = ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure(s.ssENFileExtended, config);
  }
}

public static RC_2a29aed0a2b753b8e46cbcb586392c66 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2a29aed0a2b753b8e46cbcb586392c66 obj) { 
  RC_2a29aed0a2b753b8e46cbcb586392c66 s = new RC_2a29aed0a2b753b8e46cbcb586392c66();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal);
  s.ssENFileExtended = ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.ToStructure(obj.AttrFileExtended);
  }
  return s;
}

public static Func<RC_2a29aed0a2b753b8e46cbcb586392c66, ssConectaProveedores.RestRecords.RESTRC_2a29aed0a2b753b8e46cbcb586392c66> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2a29aed0a2b753b8e46cbcb586392c66 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2a29aed0a2b753b8e46cbcb586392c66 FromStructure(RC_2a29aed0a2b753b8e46cbcb586392c66 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2a29aed0a2b753b8e46cbcb586392c66(s, config);
}

}


