using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserSourceUserTargetInvoiceReassignmentsRequisitionRequisitionApprovalLevelInvoiceApprovalLevelRecord
public class RESTRC_cf466c446053e827622ddde1ad0222be : AbstractRESTStructure<RC_cf466c446053e827622ddde1ad0222be> {
[JsonProperty("UserSource")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUserSource;

[JsonProperty("UserTarget")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUserTarget;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Reassignments")]
public ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord AttrReassignments;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord AttrRequisitionApprovalLevel;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public RESTRC_cf466c446053e827622ddde1ad0222be() { }

public RESTRC_cf466c446053e827622ddde1ad0222be (RC_cf466c446053e827622ddde1ad0222be s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUserSource = ConvertToRestWithoutDefaults(s.ssENUserSource, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUserTarget = ConvertToRestWithoutDefaults(s.ssENUserTarget, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrReassignments = ConvertToRestWithoutDefaults(s.ssENReassignments, new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionApprovalLevel = ConvertToRestWithoutDefaults(s.ssENRequisitionApprovalLevel, new EN_27b1469f497d364a764a1359956ef9adEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrUserSource = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUserSource, config);
AttrUserTarget = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUserTarget, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrReassignments = ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.FromStructure(s.ssENReassignments, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.FromStructure(s.ssENRequisitionApprovalLevel, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static RC_cf466c446053e827622ddde1ad0222be ToStructure(ssConectaProveedores.RestRecords.RESTRC_cf466c446053e827622ddde1ad0222be obj) { 
  RC_cf466c446053e827622ddde1ad0222be s = new RC_cf466c446053e827622ddde1ad0222be();
  if(obj != null) {
  s.ssENUserSource = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUserSource);
  s.ssENUserTarget = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUserTarget);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENReassignments = ssConectaProveedores.RestRecords.RESTEN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord.ToStructure(obj.AttrReassignments);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_27b1469f497d364a764a1359956ef9adEntityRecord.ToStructure(obj.AttrRequisitionApprovalLevel);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  }
  return s;
}

public static Func<RC_cf466c446053e827622ddde1ad0222be, ssConectaProveedores.RestRecords.RESTRC_cf466c446053e827622ddde1ad0222be> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cf466c446053e827622ddde1ad0222be s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cf466c446053e827622ddde1ad0222be FromStructure(RC_cf466c446053e827622ddde1ad0222be s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cf466c446053e827622ddde1ad0222be(s, config);
}

}


