using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalFileExtendedRecord
public class JSONRC_2a29aed0a2b753b8e46cbcb586392c66 : AbstractRESTStructure<RC_2a29aed0a2b753b8e46cbcb586392c66> {
[JsonProperty("Proposal")]
[JsonPropertyName("Proposal")]
public ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord AttrProposal;

[JsonProperty("FileExtended")]
[JsonPropertyName("FileExtended")]
public ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord AttrFileExtended;

public JSONRC_2a29aed0a2b753b8e46cbcb586392c66() { }

public JSONRC_2a29aed0a2b753b8e46cbcb586392c66 (RC_2a29aed0a2b753b8e46cbcb586392c66 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposal = ConvertToRestWithoutDefaults(s.ssENProposal, new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure, config);
AttrFileExtended = ConvertToRestWithoutDefaults(s.ssENFileExtended, new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure, config);
  } else {
AttrProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.FromStructure(s.ssENProposal, config);
AttrFileExtended = ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.FromStructure(s.ssENFileExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2a29aed0a2b753b8e46cbcb586392c66, RC_2a29aed0a2b753b8e46cbcb586392c66> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2a29aed0a2b753b8e46cbcb586392c66 s) => ToStructure(s, config);
}
public static RC_2a29aed0a2b753b8e46cbcb586392c66 ToStructure(ssConectaProveedores.RestRecords.JSONRC_2a29aed0a2b753b8e46cbcb586392c66 obj, IBehaviorsConfiguration config) { 
  RC_2a29aed0a2b753b8e46cbcb586392c66 s = new RC_2a29aed0a2b753b8e46cbcb586392c66();
  if(obj != null) {
  s.ssENProposal = ssConectaProveedores.RestRecords.JSONEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord.ToStructure(obj.AttrProposal, config);
  s.ssENFileExtended = ssConectaProveedores.RestRecords.JSONEN_dcebdd8ba305133f41b1e1804925997fEntityRecord.ToStructure(obj.AttrFileExtended, config);
  }
  return s;
}

public static Func<RC_2a29aed0a2b753b8e46cbcb586392c66, ssConectaProveedores.RestRecords.JSONRC_2a29aed0a2b753b8e46cbcb586392c66> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2a29aed0a2b753b8e46cbcb586392c66 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2a29aed0a2b753b8e46cbcb586392c66 FromStructure(RC_2a29aed0a2b753b8e46cbcb586392c66 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2a29aed0a2b753b8e46cbcb586392c66(s, config);
}

}


