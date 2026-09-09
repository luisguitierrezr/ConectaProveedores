using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalTypeRecord
public class RESTRC_d6a77c530b0e1f2687ee6b3214e237ef : AbstractRESTStructure<RC_d6a77c530b0e1f2687ee6b3214e237ef> {
[JsonProperty("ProposalType")]
public ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord AttrProposalType;

public RESTRC_d6a77c530b0e1f2687ee6b3214e237ef() { }

public RESTRC_d6a77c530b0e1f2687ee6b3214e237ef (RC_d6a77c530b0e1f2687ee6b3214e237ef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalType = ConvertToRestWithoutDefaults(s.ssENProposalType, new EN_7de728375ec552c47f71bca85f9991d9EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.FromStructure, config);
  } else {
AttrProposalType = ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.FromStructure(s.ssENProposalType, config);
  }
}

public static RC_d6a77c530b0e1f2687ee6b3214e237ef ToStructure(ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef obj) { 
  RC_d6a77c530b0e1f2687ee6b3214e237ef s = new RC_d6a77c530b0e1f2687ee6b3214e237ef();
  if(obj != null) {
  s.ssENProposalType = ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord.ToStructure(obj.AttrProposalType);
  }
  return s;
}

public static Func<RC_d6a77c530b0e1f2687ee6b3214e237ef, ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d6a77c530b0e1f2687ee6b3214e237ef s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef FromStructure(RC_d6a77c530b0e1f2687ee6b3214e237ef s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d6a77c530b0e1f2687ee6b3214e237ef(s, config);
}

}


