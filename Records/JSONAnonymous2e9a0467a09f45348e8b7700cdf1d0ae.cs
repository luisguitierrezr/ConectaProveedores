using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelApplicationRoleIsAllowedFromRoleAndRegionRecord
public class JSONRC_ada25812cfab5c5db1ea84d416297bbf : AbstractRESTStructure<RC_ada25812cfab5c5db1ea84d416297bbf> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
[JsonPropertyName("InvoiceApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

[JsonProperty("IsAllowedFromRoleAndRegion")]
[JsonPropertyName("IsAllowedFromRoleAndRegion")]
public bool? AttrIsAllowedFromRoleAndRegion;

public JSONRC_ada25812cfab5c5db1ea84d416297bbf() { }

public JSONRC_ada25812cfab5c5db1ea84d416297bbf (RC_ada25812cfab5c5db1ea84d416297bbf s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
AttrIsAllowedFromRoleAndRegion = ConvertToRestWithoutDefaults(s.ssIsAllowedFromRoleAndRegion, false);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
AttrIsAllowedFromRoleAndRegion = (bool?) s.ssIsAllowedFromRoleAndRegion;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ada25812cfab5c5db1ea84d416297bbf, RC_ada25812cfab5c5db1ea84d416297bbf> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ada25812cfab5c5db1ea84d416297bbf s) => ToStructure(s, config);
}
public static RC_ada25812cfab5c5db1ea84d416297bbf ToStructure(ssConectaProveedores.RestRecords.JSONRC_ada25812cfab5c5db1ea84d416297bbf obj, IBehaviorsConfiguration config) { 
  RC_ada25812cfab5c5db1ea84d416297bbf s = new RC_ada25812cfab5c5db1ea84d416297bbf();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  s.ssIsAllowedFromRoleAndRegion = obj.AttrIsAllowedFromRoleAndRegion == null ? false : obj.AttrIsAllowedFromRoleAndRegion.Value;
  }
  return s;
}

public static Func<RC_ada25812cfab5c5db1ea84d416297bbf, ssConectaProveedores.RestRecords.JSONRC_ada25812cfab5c5db1ea84d416297bbf> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ada25812cfab5c5db1ea84d416297bbf s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ada25812cfab5c5db1ea84d416297bbf FromStructure(RC_ada25812cfab5c5db1ea84d416297bbf s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ada25812cfab5c5db1ea84d416297bbf(s, config);
}

}


