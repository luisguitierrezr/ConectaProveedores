using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalStatusRecord
public class RESTRC_5627f7a3ec063e602863ee6b4dd816a2 : AbstractRESTStructure<RC_5627f7a3ec063e602863ee6b4dd816a2> {
[JsonProperty("ProposalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord AttrProposalStatus;

public RESTRC_5627f7a3ec063e602863ee6b4dd816a2() { }

public RESTRC_5627f7a3ec063e602863ee6b4dd816a2 (RC_5627f7a3ec063e602863ee6b4dd816a2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalStatus = ConvertToRestWithoutDefaults(s.ssENProposalStatus, new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure, config);
  } else {
AttrProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.FromStructure(s.ssENProposalStatus, config);
  }
}

public static RC_5627f7a3ec063e602863ee6b4dd816a2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2 obj) { 
  RC_5627f7a3ec063e602863ee6b4dd816a2 s = new RC_5627f7a3ec063e602863ee6b4dd816a2();
  if(obj != null) {
  s.ssENProposalStatus = ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord.ToStructure(obj.AttrProposalStatus);
  }
  return s;
}

public static Func<RC_5627f7a3ec063e602863ee6b4dd816a2, ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5627f7a3ec063e602863ee6b4dd816a2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2 FromStructure(RC_5627f7a3ec063e602863ee6b4dd816a2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5627f7a3ec063e602863ee6b4dd816a2(s, config);
}

}


