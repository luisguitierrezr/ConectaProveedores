using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalStatusRequisitionRequisitionApprovalLevelRequisitionApprovalRecord
public class RESTRC_0750e1f3144a1c14d632b9799d496b79 : AbstractRESTStructure<RC_0750e1f3144a1c14d632b9799d496b79> {
[JsonProperty("ApprovalStatus")]
public ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord AttrApprovalStatus;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("RequisitionApproval")]
public ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public RESTRC_0750e1f3144a1c14d632b9799d496b79() { }

public RESTRC_0750e1f3144a1c14d632b9799d496b79 (RC_0750e1f3144a1c14d632b9799d496b79 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalStatus = ConvertToRestWithoutDefaults(s.ssENApprovalStatus, new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrApprovalStatus = ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.FromStructure(s.ssENApprovalStatus, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static RC_0750e1f3144a1c14d632b9799d496b79 ToStructure(ssConectaProveedores.RestRecords.RESTRC_0750e1f3144a1c14d632b9799d496b79 obj) { 
  RC_0750e1f3144a1c14d632b9799d496b79 s = new RC_0750e1f3144a1c14d632b9799d496b79();
  if(obj != null) {
  s.ssENApprovalStatus = ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord.ToStructure(obj.AttrApprovalStatus);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval);
  }
  return s;
}

public static Func<RC_0750e1f3144a1c14d632b9799d496b79, ssConectaProveedores.RestRecords.RESTRC_0750e1f3144a1c14d632b9799d496b79> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0750e1f3144a1c14d632b9799d496b79 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0750e1f3144a1c14d632b9799d496b79 FromStructure(RC_0750e1f3144a1c14d632b9799d496b79 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0750e1f3144a1c14d632b9799d496b79(s, config);
}

}


