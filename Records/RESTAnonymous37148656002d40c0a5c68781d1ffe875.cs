using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionApprovalLevelRequisitionApprovalApplicationRoleRecord
public class RESTRC_ba1b673fb7796808ead75722c028b587 : AbstractRESTStructure<RC_ba1b673fb7796808ead75722c028b587> {
[JsonProperty("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("RequisitionApproval")]
public ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public RESTRC_ba1b673fb7796808ead75722c028b587() { }

public RESTRC_ba1b673fb7796808ead75722c028b587 (RC_ba1b673fb7796808ead75722c028b587 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static RC_ba1b673fb7796808ead75722c028b587 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ba1b673fb7796808ead75722c028b587 obj) { 
  RC_ba1b673fb7796808ead75722c028b587 s = new RC_ba1b673fb7796808ead75722c028b587();
  if(obj != null) {
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.RESTEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  }
  return s;
}

public static Func<RC_ba1b673fb7796808ead75722c028b587, ssConectaProveedores.RestRecords.RESTRC_ba1b673fb7796808ead75722c028b587> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ba1b673fb7796808ead75722c028b587 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ba1b673fb7796808ead75722c028b587 FromStructure(RC_ba1b673fb7796808ead75722c028b587 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ba1b673fb7796808ead75722c028b587(s, config);
}

}


