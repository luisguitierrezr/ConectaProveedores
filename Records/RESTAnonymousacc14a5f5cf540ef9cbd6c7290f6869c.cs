using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalIdProposalLineApprovalLevelIdRecord
public class RESTRC_474c5c8cc36282ebfc11b03838b11802 : AbstractRESTStructure<RC_474c5c8cc36282ebfc11b03838b11802> {
[JsonProperty("ProposalId")]
public long? AttrProposalId;

[JsonProperty("ProposalLineApprovalLevelId")]
public long? AttrProposalLineApprovalLevelId;

public RESTRC_474c5c8cc36282ebfc11b03838b11802() { }

public RESTRC_474c5c8cc36282ebfc11b03838b11802 (RC_474c5c8cc36282ebfc11b03838b11802 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalId = ConvertToRestWithoutDefaults(s.ssProposalId, 0L);
AttrProposalLineApprovalLevelId = ConvertToRestWithoutDefaults(s.ssProposalLineApprovalLevelId, 0L);
  } else {
AttrProposalId = (long?) s.ssProposalId;
AttrProposalLineApprovalLevelId = (long?) s.ssProposalLineApprovalLevelId;
  }
}

public static RC_474c5c8cc36282ebfc11b03838b11802 ToStructure(ssConectaProveedores.RestRecords.RESTRC_474c5c8cc36282ebfc11b03838b11802 obj) { 
  RC_474c5c8cc36282ebfc11b03838b11802 s = new RC_474c5c8cc36282ebfc11b03838b11802();
  if(obj != null) {
  s.ssProposalId = obj.AttrProposalId == null ? 0L : obj.AttrProposalId.Value;
  s.ssProposalLineApprovalLevelId = obj.AttrProposalLineApprovalLevelId == null ? 0L : obj.AttrProposalLineApprovalLevelId.Value;
  }
  return s;
}

public static Func<RC_474c5c8cc36282ebfc11b03838b11802, ssConectaProveedores.RestRecords.RESTRC_474c5c8cc36282ebfc11b03838b11802> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_474c5c8cc36282ebfc11b03838b11802 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_474c5c8cc36282ebfc11b03838b11802 FromStructure(RC_474c5c8cc36282ebfc11b03838b11802 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_474c5c8cc36282ebfc11b03838b11802(s, config);
}

}


