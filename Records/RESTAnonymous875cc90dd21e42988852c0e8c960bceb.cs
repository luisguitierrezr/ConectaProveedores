using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApprovalLevelRecord
public class RESTRC_5404698ef74632f0bc59763509d95177 : AbstractRESTStructure<RC_5404698ef74632f0bc59763509d95177> {
[JsonProperty("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

public RESTRC_5404698ef74632f0bc59763509d95177() { }

public RESTRC_5404698ef74632f0bc59763509d95177 (RC_5404698ef74632f0bc59763509d95177 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
  } else {
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
  }
}

public static RC_5404698ef74632f0bc59763509d95177 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5404698ef74632f0bc59763509d95177 obj) { 
  RC_5404698ef74632f0bc59763509d95177 s = new RC_5404698ef74632f0bc59763509d95177();
  if(obj != null) {
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel);
  }
  return s;
}

public static Func<RC_5404698ef74632f0bc59763509d95177, ssConectaProveedores.RestRecords.RESTRC_5404698ef74632f0bc59763509d95177> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5404698ef74632f0bc59763509d95177 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5404698ef74632f0bc59763509d95177 FromStructure(RC_5404698ef74632f0bc59763509d95177 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5404698ef74632f0bc59763509d95177(s, config);
}

}


