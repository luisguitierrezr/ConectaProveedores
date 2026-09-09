using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApprovalLevelRecord
public class JSONRC_5404698ef74632f0bc59763509d95177 : AbstractRESTStructure<RC_5404698ef74632f0bc59763509d95177> {
[JsonProperty("RequisitionApprovalLevel")]
[JsonPropertyName("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

public JSONRC_5404698ef74632f0bc59763509d95177() { }

public JSONRC_5404698ef74632f0bc59763509d95177 (RC_5404698ef74632f0bc59763509d95177 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
  } else {
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5404698ef74632f0bc59763509d95177, RC_5404698ef74632f0bc59763509d95177> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5404698ef74632f0bc59763509d95177 s) => ToStructure(s, config);
}
public static RC_5404698ef74632f0bc59763509d95177 ToStructure(ssConectaProveedores.RestRecords.JSONRC_5404698ef74632f0bc59763509d95177 obj, IBehaviorsConfiguration config) { 
  RC_5404698ef74632f0bc59763509d95177 s = new RC_5404698ef74632f0bc59763509d95177();
  if(obj != null) {
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel, config);
  }
  return s;
}

public static Func<RC_5404698ef74632f0bc59763509d95177, ssConectaProveedores.RestRecords.JSONRC_5404698ef74632f0bc59763509d95177> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5404698ef74632f0bc59763509d95177 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5404698ef74632f0bc59763509d95177 FromStructure(RC_5404698ef74632f0bc59763509d95177 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5404698ef74632f0bc59763509d95177(s, config);
}

}


