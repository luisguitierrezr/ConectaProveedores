using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalApprovalLevelRecord
public class JSONRC_55929a788bcf79c72354fc49160acc0c : AbstractRESTStructure<RC_55929a788bcf79c72354fc49160acc0c> {
[JsonProperty("ProposalApprovalLevel")]
[JsonPropertyName("ProposalApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord AttrProposalApprovalLevel;

public JSONRC_55929a788bcf79c72354fc49160acc0c() { }

public JSONRC_55929a788bcf79c72354fc49160acc0c (RC_55929a788bcf79c72354fc49160acc0c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProposalApprovalLevel = ConvertToRestWithoutDefaults(s.ssENProposalApprovalLevel, new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure, config);
  } else {
AttrProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.FromStructure(s.ssENProposalApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_55929a788bcf79c72354fc49160acc0c, RC_55929a788bcf79c72354fc49160acc0c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_55929a788bcf79c72354fc49160acc0c s) => ToStructure(s, config);
}
public static RC_55929a788bcf79c72354fc49160acc0c ToStructure(ssConectaProveedores.RestRecords.JSONRC_55929a788bcf79c72354fc49160acc0c obj, IBehaviorsConfiguration config) { 
  RC_55929a788bcf79c72354fc49160acc0c s = new RC_55929a788bcf79c72354fc49160acc0c();
  if(obj != null) {
  s.ssENProposalApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_9d8b873ac73cc192f28429eff2455f5bEntityRecord.ToStructure(obj.AttrProposalApprovalLevel, config);
  }
  return s;
}

public static Func<RC_55929a788bcf79c72354fc49160acc0c, ssConectaProveedores.RestRecords.JSONRC_55929a788bcf79c72354fc49160acc0c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_55929a788bcf79c72354fc49160acc0c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_55929a788bcf79c72354fc49160acc0c FromStructure(RC_55929a788bcf79c72354fc49160acc0c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_55929a788bcf79c72354fc49160acc0c(s, config);
}

}


