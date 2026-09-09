using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// User_ApprovedByUser_AssignedToInvoiceInvoiceApprovalInvoiceComment_CancelInvoiceComment_ModifyInvoiceApprovalLevelApplicationRoleRecord
public class JSONRC_605897e6a4b36a23ebf729de65626af9 : AbstractRESTStructure<RC_605897e6a4b36a23ebf729de65626af9> {
[JsonProperty("User_ApprovedBy")]
[JsonPropertyName("User_ApprovedBy")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_ApprovedBy;

[JsonProperty("User_AssignedTo")]
[JsonPropertyName("User_AssignedTo")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser_AssignedTo;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
[JsonPropertyName("InvoiceApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceComment_Cancel")]
[JsonPropertyName("InvoiceComment_Cancel")]
public ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord AttrInvoiceComment_Cancel;

[JsonProperty("InvoiceComment_Modify")]
[JsonPropertyName("InvoiceComment_Modify")]
public ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord AttrInvoiceComment_Modify;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_605897e6a4b36a23ebf729de65626af9() { }

public JSONRC_605897e6a4b36a23ebf729de65626af9 (RC_605897e6a4b36a23ebf729de65626af9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser_ApprovedBy = ConvertToRestWithoutDefaults(s.ssENUser_ApprovedBy, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrUser_AssignedTo = ConvertToRestWithoutDefaults(s.ssENUser_AssignedTo, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceComment_Cancel = ConvertToRestWithoutDefaults(s.ssENInvoiceComment_Cancel, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure, config);
AttrInvoiceComment_Modify = ConvertToRestWithoutDefaults(s.ssENInvoiceComment_Modify, new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUser_ApprovedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_ApprovedBy, config);
AttrUser_AssignedTo = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser_AssignedTo, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceComment_Cancel = ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure(s.ssENInvoiceComment_Cancel, config);
AttrInvoiceComment_Modify = ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.FromStructure(s.ssENInvoiceComment_Modify, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_605897e6a4b36a23ebf729de65626af9, RC_605897e6a4b36a23ebf729de65626af9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_605897e6a4b36a23ebf729de65626af9 s) => ToStructure(s, config);
}
public static RC_605897e6a4b36a23ebf729de65626af9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_605897e6a4b36a23ebf729de65626af9 obj, IBehaviorsConfiguration config) { 
  RC_605897e6a4b36a23ebf729de65626af9 s = new RC_605897e6a4b36a23ebf729de65626af9();
  if(obj != null) {
  s.ssENUser_ApprovedBy = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_ApprovedBy, config);
  s.ssENUser_AssignedTo = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser_AssignedTo, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval, config);
  s.ssENInvoiceComment_Cancel = ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.ToStructure(obj.AttrInvoiceComment_Cancel, config);
  s.ssENInvoiceComment_Modify = ssConectaProveedores.RestRecords.JSONEN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord.ToStructure(obj.AttrInvoiceComment_Modify, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_605897e6a4b36a23ebf729de65626af9, ssConectaProveedores.RestRecords.JSONRC_605897e6a4b36a23ebf729de65626af9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_605897e6a4b36a23ebf729de65626af9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_605897e6a4b36a23ebf729de65626af9 FromStructure(RC_605897e6a4b36a23ebf729de65626af9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_605897e6a4b36a23ebf729de65626af9(s, config);
}

}


