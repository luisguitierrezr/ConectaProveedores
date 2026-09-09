using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LastApproverRequisitionRequisitionApprovalLevelRequisitionApprovalRecord
public class RESTRC_853b3dd6b575c6d19eb5343d397a37e7 : AbstractRESTStructure<RC_853b3dd6b575c6d19eb5343d397a37e7> {
[JsonProperty("LastApprover")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrLastApprover;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("RequisitionApproval")]
public ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public RESTRC_853b3dd6b575c6d19eb5343d397a37e7() { }

public RESTRC_853b3dd6b575c6d19eb5343d397a37e7 (RC_853b3dd6b575c6d19eb5343d397a37e7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLastApprover = ConvertToRestWithoutDefaults(s.ssENLastApprover, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrLastApprover = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENLastApprover, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static RC_853b3dd6b575c6d19eb5343d397a37e7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_853b3dd6b575c6d19eb5343d397a37e7 obj) { 
  RC_853b3dd6b575c6d19eb5343d397a37e7 s = new RC_853b3dd6b575c6d19eb5343d397a37e7();
  if(obj != null) {
  s.ssENLastApprover = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrLastApprover);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval);
  }
  return s;
}

public static Func<RC_853b3dd6b575c6d19eb5343d397a37e7, ssConectaProveedores.RestRecords.RESTRC_853b3dd6b575c6d19eb5343d397a37e7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_853b3dd6b575c6d19eb5343d397a37e7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_853b3dd6b575c6d19eb5343d397a37e7 FromStructure(RC_853b3dd6b575c6d19eb5343d397a37e7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_853b3dd6b575c6d19eb5343d397a37e7(s, config);
}

}


