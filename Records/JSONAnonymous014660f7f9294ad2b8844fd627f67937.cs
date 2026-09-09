using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalStatusRecord
public class JSONRC_5627f7a3ec063e602863ee6b4dd816a2 : AbstractRESTStructure<RC_5627f7a3ec063e602863ee6b4dd816a2> {
[JsonProperty("ProposalStatus")]
[JsonPropertyName("ProposalStatus")]
public ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

public JSONRC_5627f7a3ec063e602863ee6b4dd816a2() { }

public JSONRC_5627f7a3ec063e602863ee6b4dd816a2 (RC_5627f7a3ec063e602863ee6b4dd816a2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
  } else {
AttrProposalStatus = ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5627f7a3ec063e602863ee6b4dd816a2, RC_5627f7a3ec063e602863ee6b4dd816a2> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5627f7a3ec063e602863ee6b4dd816a2 s) => ToStructure(s, config);
}
public static RC_5627f7a3ec063e602863ee6b4dd816a2 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5627f7a3ec063e602863ee6b4dd816a2 obj, IBehaviorsConfiguration config) { 
  RC_5627f7a3ec063e602863ee6b4dd816a2 s = new RC_5627f7a3ec063e602863ee6b4dd816a2();
  if(obj != null) {
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus, config);
  }
  return s;
}

public static Func<RC_5627f7a3ec063e602863ee6b4dd816a2, ssConectaProveedores.RestRecords.JSONRC_5627f7a3ec063e602863ee6b4dd816a2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5627f7a3ec063e602863ee6b4dd816a2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5627f7a3ec063e602863ee6b4dd816a2 FromStructure(RC_5627f7a3ec063e602863ee6b4dd816a2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5627f7a3ec063e602863ee6b4dd816a2(s, config);
}

}


