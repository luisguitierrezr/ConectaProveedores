using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_ApprovedByUser_AssignedToInvoiceInvoiceApprovalInvoiceComment_CancelInvoiceComment_ModifyInvoiceApprovalLevelApplicationRoleRecord
public class RESTRC_605897e6a4b36a23ebf729de65626af9 : AbstractRESTStructure<RC_605897e6a4b36a23ebf729de65626af9> {
[JsonProperty("User_ApprovedBy")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_ApprovedBy;

[JsonProperty("User_AssignedTo")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser_AssignedTo;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceComment_Cancel")]
public ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord AttrInvoiceComment_Cancel;

[JsonProperty("InvoiceComment_Modify")]
public ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord AttrInvoiceComment_Modify;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public RESTRC_605897e6a4b36a23ebf729de65626af9() { }

public RESTRC_605897e6a4b36a23ebf729de65626af9 (RC_605897e6a4b36a23ebf729de65626af9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_ApprovedBy = ConvertToRestWithoutDefaults(s.ssENUser_ApprovedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrUser_AssignedTo = ConvertToRestWithoutDefaults(s.ssENUser_AssignedTo, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceComment_Cancel = ConvertToRestWithoutDefaults(s.ssENInvoiceComment_Cancel, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure, config);
AttrInvoiceComment_Modify = ConvertToRestWithoutDefaults(s.ssENInvoiceComment_Modify, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUser_ApprovedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_ApprovedBy, config);
AttrUser_AssignedTo = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser_AssignedTo, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceComment_Cancel = ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure(s.ssENInvoiceComment_Cancel, config);
AttrInvoiceComment_Modify = ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure(s.ssENInvoiceComment_Modify, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static RC_605897e6a4b36a23ebf729de65626af9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_605897e6a4b36a23ebf729de65626af9 obj) { 
  RC_605897e6a4b36a23ebf729de65626af9 s = new RC_605897e6a4b36a23ebf729de65626af9();
  if(obj != null) {
  s.ssENUser_ApprovedBy = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_ApprovedBy);
  s.ssENUser_AssignedTo = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser_AssignedTo);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval);
  s.ssENInvoiceComment_Cancel = ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.ToStructure(obj.AttrInvoiceComment_Cancel);
  s.ssENInvoiceComment_Modify = ssConectaProveedores.RestRecords.RESTEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.ToStructure(obj.AttrInvoiceComment_Modify);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  }
  return s;
}

public static Func<RC_605897e6a4b36a23ebf729de65626af9, ssConectaProveedores.RestRecords.RESTRC_605897e6a4b36a23ebf729de65626af9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_605897e6a4b36a23ebf729de65626af9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_605897e6a4b36a23ebf729de65626af9 FromStructure(RC_605897e6a4b36a23ebf729de65626af9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_605897e6a4b36a23ebf729de65626af9(s, config);
}

}


