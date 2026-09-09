using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_ApprovedUser_AssignedRequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionComment_CancelRequisitionComment_ModifyApplicationRoleRecord
public class JSONRC_8b89674084a8b334109c261c1cd156c4 : AbstractRESTStructure<RC_8b89674084a8b334109c261c1cd156c4> {
[JsonProperty("User_Approved")]
[JsonPropertyName("User_Approved")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Approved;

[JsonProperty("User_Assigned")]
[JsonPropertyName("User_Assigned")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_Assigned;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApprovalLevel")]
[JsonPropertyName("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("RequisitionApproval")]
[JsonPropertyName("RequisitionApproval")]
public ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

[JsonProperty("RequisitionComment_Cancel")]
[JsonPropertyName("RequisitionComment_Cancel")]
public ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord AttrRequisitionComment_Cancel;

[JsonProperty("RequisitionComment_Modify")]
[JsonPropertyName("RequisitionComment_Modify")]
public ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord AttrRequisitionComment_Modify;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_8b89674084a8b334109c261c1cd156c4() { }

public JSONRC_8b89674084a8b334109c261c1cd156c4 (RC_8b89674084a8b334109c261c1cd156c4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_Approved = ConvertToRestWithoutDefaults(s.ssENUser_Approved, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_Assigned = ConvertToRestWithoutDefaults(s.ssENUser_Assigned, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
AttrRequisitionComment_Cancel = ConvertToRestWithoutDefaults(s.ssENRequisitionComment_Cancel, new EN_cbeb601b681344342c8de0161d058f87EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.FromStructure, config);
AttrRequisitionComment_Modify = ConvertToRestWithoutDefaults(s.ssENRequisitionComment_Modify, new EN_cbeb601b681344342c8de0161d058f87EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUser_Approved = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Approved, config);
AttrUser_Assigned = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_Assigned, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
AttrRequisitionComment_Cancel = ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.FromStructure(s.ssENRequisitionComment_Cancel, config);
AttrRequisitionComment_Modify = ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.FromStructure(s.ssENRequisitionComment_Modify, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8b89674084a8b334109c261c1cd156c4, RC_8b89674084a8b334109c261c1cd156c4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8b89674084a8b334109c261c1cd156c4 s) => ToStructure(s, config);
}
public static RC_8b89674084a8b334109c261c1cd156c4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8b89674084a8b334109c261c1cd156c4 obj, IBehaviorsConfiguration config) { 
  RC_8b89674084a8b334109c261c1cd156c4 s = new RC_8b89674084a8b334109c261c1cd156c4();
  if(obj != null) {
  s.ssENUser_Approved = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Approved, config);
  s.ssENUser_Assigned = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_Assigned, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel, config);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval, config);
  s.ssENRequisitionComment_Cancel = ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.ToStructure(obj.AttrRequisitionComment_Cancel, config);
  s.ssENRequisitionComment_Modify = ssConectaProveedores.RestRecords.JSONEN_cbeb601b681344342c8de0161d058f87EntityRecord.ToStructure(obj.AttrRequisitionComment_Modify, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_8b89674084a8b334109c261c1cd156c4, ssConectaProveedores.RestRecords.JSONRC_8b89674084a8b334109c261c1cd156c4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8b89674084a8b334109c261c1cd156c4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8b89674084a8b334109c261c1cd156c4 FromStructure(RC_8b89674084a8b334109c261c1cd156c4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8b89674084a8b334109c261c1cd156c4(s, config);
}

}


