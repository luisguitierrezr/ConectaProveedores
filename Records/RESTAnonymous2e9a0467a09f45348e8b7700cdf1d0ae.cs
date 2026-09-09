using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelApplicationRoleIsAllowedFromRoleAndRegionRecord
public class RESTRC_ada25812cfab5c5db1ea84d416297bbf : AbstractRESTStructure<RC_ada25812cfab5c5db1ea84d416297bbf> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("IsAllowedFromRoleAndRegion")]
public bool? AttrIsAllowedFromRoleAndRegion;

public RESTRC_ada25812cfab5c5db1ea84d416297bbf() { }

public RESTRC_ada25812cfab5c5db1ea84d416297bbf (RC_ada25812cfab5c5db1ea84d416297bbf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrIsAllowedFromRoleAndRegion = ConvertToRestWithoutDefaults(s.ssIsAllowedFromRoleAndRegion, false);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrIsAllowedFromRoleAndRegion = (bool?) s.ssIsAllowedFromRoleAndRegion;
  }
}

public static RC_ada25812cfab5c5db1ea84d416297bbf ToStructure(ssConectaProveedores.RestRecords.RESTRC_ada25812cfab5c5db1ea84d416297bbf obj) { 
  RC_ada25812cfab5c5db1ea84d416297bbf s = new RC_ada25812cfab5c5db1ea84d416297bbf();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  s.ssIsAllowedFromRoleAndRegion = obj.AttrIsAllowedFromRoleAndRegion == null ? false : obj.AttrIsAllowedFromRoleAndRegion.Value;
  }
  return s;
}

public static Func<RC_ada25812cfab5c5db1ea84d416297bbf, ssConectaProveedores.RestRecords.RESTRC_ada25812cfab5c5db1ea84d416297bbf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ada25812cfab5c5db1ea84d416297bbf s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ada25812cfab5c5db1ea84d416297bbf FromStructure(RC_ada25812cfab5c5db1ea84d416297bbf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ada25812cfab5c5db1ea84d416297bbf(s, config);
}

}


