using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelRecord
public class RESTRC_8d72a852ad297e510ecacc4327468027 : AbstractRESTStructure<RC_8d72a852ad297e510ecacc4327468027> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public RESTRC_8d72a852ad297e510ecacc4327468027() { }

public RESTRC_8d72a852ad297e510ecacc4327468027 (RC_8d72a852ad297e510ecacc4327468027 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static RC_8d72a852ad297e510ecacc4327468027 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8d72a852ad297e510ecacc4327468027 obj) { 
  RC_8d72a852ad297e510ecacc4327468027 s = new RC_8d72a852ad297e510ecacc4327468027();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  }
  return s;
}

public static Func<RC_8d72a852ad297e510ecacc4327468027, ssConectaProveedores.RestRecords.RESTRC_8d72a852ad297e510ecacc4327468027> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8d72a852ad297e510ecacc4327468027 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8d72a852ad297e510ecacc4327468027 FromStructure(RC_8d72a852ad297e510ecacc4327468027 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8d72a852ad297e510ecacc4327468027(s, config);
}

}


