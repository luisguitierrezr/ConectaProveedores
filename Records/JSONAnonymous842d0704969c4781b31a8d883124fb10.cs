using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserSourceUserTargetInvoiceReassignmentsRequisitionRequisitionApprovalLevelInvoiceApprovalLevelRecord
public class JSONRC_cf466c446053e827622ddde1ad0222be : AbstractRESTStructure<RC_cf466c446053e827622ddde1ad0222be> {
[JsonProperty("UserSource")]
[JsonPropertyName("UserSource")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUserSource;

[JsonProperty("UserTarget")]
[JsonPropertyName("UserTarget")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUserTarget;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Reassignments")]
[JsonPropertyName("Reassignments")]
public ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord AttrReassignments;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApprovalLevel")]
[JsonPropertyName("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public JSONRC_cf466c446053e827622ddde1ad0222be() { }

public JSONRC_cf466c446053e827622ddde1ad0222be (RC_cf466c446053e827622ddde1ad0222be s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserSource = ConvertToRestWithoutDefaults(s.ssENUserSource, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUserTarget = ConvertToRestWithoutDefaults(s.ssENUserTarget, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrReassignments = ConvertToRestWithoutDefaults(s.ssENReassignments, new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrUserSource = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUserSource, config);
AttrUserTarget = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUserTarget, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrReassignments = ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure(s.ssENReassignments, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cf466c446053e827622ddde1ad0222be, RC_cf466c446053e827622ddde1ad0222be> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cf466c446053e827622ddde1ad0222be s) => ToStructure(s, config);
}
public static RC_cf466c446053e827622ddde1ad0222be ToStructure(ssConectaProveedores.RestRecords.JSONRC_cf466c446053e827622ddde1ad0222be obj, IBehaviorsConfiguration config) { 
  RC_cf466c446053e827622ddde1ad0222be s = new RC_cf466c446053e827622ddde1ad0222be();
  if(obj != null) {
  s.ssENUserSource = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUserSource, config);
  s.ssENUserTarget = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUserTarget, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENReassignments = ssConectaProveedores.RestRecords.JSONEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.ToStructure(obj.AttrReassignments, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  }
  return s;
}

public static Func<RC_cf466c446053e827622ddde1ad0222be, ssConectaProveedores.RestRecords.JSONRC_cf466c446053e827622ddde1ad0222be> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cf466c446053e827622ddde1ad0222be s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cf466c446053e827622ddde1ad0222be FromStructure(RC_cf466c446053e827622ddde1ad0222be s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cf466c446053e827622ddde1ad0222be(s, config);
}

}


