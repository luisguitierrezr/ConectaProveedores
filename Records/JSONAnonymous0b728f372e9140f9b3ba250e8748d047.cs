using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceApprovalInvoiceApprovalLevelApplicationRoleRecord
public class JSONRC_0c929027c696b201a1aceb2f23c1d74d : AbstractRESTStructure<RC_0c929027c696b201a1aceb2f23c1d74d> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("InvoiceApproval")]
[JsonPropertyName("InvoiceApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

[JsonProperty("ApplicationRole")]
[JsonPropertyName("ApplicationRole")]
public ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord AttrApplicationRole;

public JSONRC_0c929027c696b201a1aceb2f23c1d74d() { }

public JSONRC_0c929027c696b201a1aceb2f23c1d74d (RC_0c929027c696b201a1aceb2f23c1d74d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
AttrApplicationRole = ConvertToRestWithoutDefaults(s.ssENApplicationRole, new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
AttrApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.FromStructure(s.ssENApplicationRole, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0c929027c696b201a1aceb2f23c1d74d, RC_0c929027c696b201a1aceb2f23c1d74d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0c929027c696b201a1aceb2f23c1d74d s) => ToStructure(s, config);
}
public static RC_0c929027c696b201a1aceb2f23c1d74d ToStructure(ssConectaProveedores.RestRecords.JSONRC_0c929027c696b201a1aceb2f23c1d74d obj, IBehaviorsConfiguration config) { 
  RC_0c929027c696b201a1aceb2f23c1d74d s = new RC_0c929027c696b201a1aceb2f23c1d74d();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  s.ssENApplicationRole = ssConectaProveedores.RestRecords.JSONEN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord.ToStructure(obj.AttrApplicationRole, config);
  }
  return s;
}

public static Func<RC_0c929027c696b201a1aceb2f23c1d74d, ssConectaProveedores.RestRecords.JSONRC_0c929027c696b201a1aceb2f23c1d74d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0c929027c696b201a1aceb2f23c1d74d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0c929027c696b201a1aceb2f23c1d74d FromStructure(RC_0c929027c696b201a1aceb2f23c1d74d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0c929027c696b201a1aceb2f23c1d74d(s, config);
}

}


