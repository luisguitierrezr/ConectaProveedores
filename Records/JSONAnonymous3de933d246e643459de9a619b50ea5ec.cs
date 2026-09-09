using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLineRecord
public class JSONRC_cbff39127609a0f830b2d34948d1c019 : AbstractRESTStructure<RC_cbff39127609a0f830b2d34948d1c019> {
[JsonProperty("ProposalLine")]
[JsonPropertyName("ProposalLine")]
public ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

public JSONRC_cbff39127609a0f830b2d34948d1c019() { }

public JSONRC_cbff39127609a0f830b2d34948d1c019 (RC_cbff39127609a0f830b2d34948d1c019 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cbff39127609a0f830b2d34948d1c019, RC_cbff39127609a0f830b2d34948d1c019> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cbff39127609a0f830b2d34948d1c019 s) => ToStructure(s, config);
}
public static RC_cbff39127609a0f830b2d34948d1c019 ToStructure(ssConectaProveedores.RestRecords.JSONRC_cbff39127609a0f830b2d34948d1c019 obj, IBehaviorsConfiguration config) { 
  RC_cbff39127609a0f830b2d34948d1c019 s = new RC_cbff39127609a0f830b2d34948d1c019();
  if(obj != null) {
  s.ssENProposalLine = ssConectaProveedores.RestRecords.JSONEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine, config);
  }
  return s;
}

public static Func<RC_cbff39127609a0f830b2d34948d1c019, ssConectaProveedores.RestRecords.JSONRC_cbff39127609a0f830b2d34948d1c019> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cbff39127609a0f830b2d34948d1c019 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cbff39127609a0f830b2d34948d1c019 FromStructure(RC_cbff39127609a0f830b2d34948d1c019 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cbff39127609a0f830b2d34948d1c019(s, config);
}

}


