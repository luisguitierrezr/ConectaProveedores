using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LastApproverRequisitionRequisitionApprovalLevelRequisitionApprovalRecord
public class JSONRC_853b3dd6b575c6d19eb5343d397a37e7 : AbstractRESTStructure<RC_853b3dd6b575c6d19eb5343d397a37e7> {
[JsonProperty("LastApprover")]
[JsonPropertyName("LastApprover")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrLastApprover;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApprovalLevel")]
[JsonPropertyName("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("RequisitionApproval")]
[JsonPropertyName("RequisitionApproval")]
public ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord AttrRequisitionApproval;

public JSONRC_853b3dd6b575c6d19eb5343d397a37e7() { }

public JSONRC_853b3dd6b575c6d19eb5343d397a37e7 (RC_853b3dd6b575c6d19eb5343d397a37e7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLastApprover = ConvertToRestWithoutDefaults(s.ssENLastApprover, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrRequisitionApproval = ConvertToRestWithoutDefaults(s.ssENRequisitionApproval, new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure, config);
  } else {
AttrLastApprover = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENLastApprover, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.FromStructure(s.ssENRequisitionApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_853b3dd6b575c6d19eb5343d397a37e7, RC_853b3dd6b575c6d19eb5343d397a37e7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_853b3dd6b575c6d19eb5343d397a37e7 s) => ToStructure(s, config);
}
public static RC_853b3dd6b575c6d19eb5343d397a37e7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_853b3dd6b575c6d19eb5343d397a37e7 obj, IBehaviorsConfiguration config) { 
  RC_853b3dd6b575c6d19eb5343d397a37e7 s = new RC_853b3dd6b575c6d19eb5343d397a37e7();
  if(obj != null) {
  s.ssENLastApprover = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrLastApprover, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel, config);
  s.ssENRequisitionApproval = ssConectaProveedores.RestRecords.JSONEN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord.ToStructure(obj.AttrRequisitionApproval, config);
  }
  return s;
}

public static Func<RC_853b3dd6b575c6d19eb5343d397a37e7, ssConectaProveedores.RestRecords.JSONRC_853b3dd6b575c6d19eb5343d397a37e7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_853b3dd6b575c6d19eb5343d397a37e7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_853b3dd6b575c6d19eb5343d397a37e7 FromStructure(RC_853b3dd6b575c6d19eb5343d397a37e7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_853b3dd6b575c6d19eb5343d397a37e7(s, config);
}

}


