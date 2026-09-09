using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalLineRecord
public class RESTRC_cbff39127609a0f830b2d34948d1c019 : AbstractRESTStructure<RC_cbff39127609a0f830b2d34948d1c019> {
[JsonProperty("ProposalLine")]
public ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord AttrProposalLine;

public RESTRC_cbff39127609a0f830b2d34948d1c019() { }

public RESTRC_cbff39127609a0f830b2d34948d1c019 (RC_cbff39127609a0f830b2d34948d1c019 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalLine = ConvertToRestWithoutDefaults(s.ssENProposalLine, new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure, config);
  } else {
AttrProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.FromStructure(s.ssENProposalLine, config);
  }
}

public static RC_cbff39127609a0f830b2d34948d1c019 ToStructure(ssConectaProveedores.RestRecords.RESTRC_cbff39127609a0f830b2d34948d1c019 obj) { 
  RC_cbff39127609a0f830b2d34948d1c019 s = new RC_cbff39127609a0f830b2d34948d1c019();
  if(obj != null) {
  s.ssENProposalLine = ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord.ToStructure(obj.AttrProposalLine);
  }
  return s;
}

public static Func<RC_cbff39127609a0f830b2d34948d1c019, ssConectaProveedores.RestRecords.RESTRC_cbff39127609a0f830b2d34948d1c019> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cbff39127609a0f830b2d34948d1c019 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cbff39127609a0f830b2d34948d1c019 FromStructure(RC_cbff39127609a0f830b2d34948d1c019 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cbff39127609a0f830b2d34948d1c019(s, config);
}

}


