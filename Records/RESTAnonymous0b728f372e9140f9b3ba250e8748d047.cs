using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceApprovalInvoiceApprovalLevelApplicationRoleRecord
public class RESTRC_0c929027c696b201a1aceb2f23c1d74d : AbstractRESTStructure<RC_0c929027c696b201a1aceb2f23c1d74d> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("InvoiceApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

[JsonProperty("ApplicationRole")]
public ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public RESTRC_0c929027c696b201a1aceb2f23c1d74d() { }

public RESTRC_0c929027c696b201a1aceb2f23c1d74d (RC_0c929027c696b201a1aceb2f23c1d74d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static RC_0c929027c696b201a1aceb2f23c1d74d ToStructure(ssConectaProveedores.RestRecords.RESTRC_0c929027c696b201a1aceb2f23c1d74d obj) { 
  RC_0c929027c696b201a1aceb2f23c1d74d s = new RC_0c929027c696b201a1aceb2f23c1d74d();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.RESTEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole);
  }
  return s;
}

public static Func<RC_0c929027c696b201a1aceb2f23c1d74d, ssConectaProveedores.RestRecords.RESTRC_0c929027c696b201a1aceb2f23c1d74d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0c929027c696b201a1aceb2f23c1d74d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0c929027c696b201a1aceb2f23c1d74d FromStructure(RC_0c929027c696b201a1aceb2f23c1d74d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0c929027c696b201a1aceb2f23c1d74d(s, config);
}

}


