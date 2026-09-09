using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelRecord
public class RESTRC_55929a788bcf79c72354fc49160acc0c : AbstractRESTStructure<RC_55929a788bcf79c72354fc49160acc0c> {
[JsonProperty("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

public RESTRC_55929a788bcf79c72354fc49160acc0c() { }

public RESTRC_55929a788bcf79c72354fc49160acc0c (RC_55929a788bcf79c72354fc49160acc0c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
  }
}

public static RC_55929a788bcf79c72354fc49160acc0c ToStructure(ssConectaProveedores.RestRecords.RESTRC_55929a788bcf79c72354fc49160acc0c obj) { 
  RC_55929a788bcf79c72354fc49160acc0c s = new RC_55929a788bcf79c72354fc49160acc0c();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel);
  }
  return s;
}

public static Func<RC_55929a788bcf79c72354fc49160acc0c, ssConectaProveedores.RestRecords.RESTRC_55929a788bcf79c72354fc49160acc0c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_55929a788bcf79c72354fc49160acc0c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_55929a788bcf79c72354fc49160acc0c FromStructure(RC_55929a788bcf79c72354fc49160acc0c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_55929a788bcf79c72354fc49160acc0c(s, config);
}

}


