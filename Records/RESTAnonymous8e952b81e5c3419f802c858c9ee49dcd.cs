using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceApprovalInvoiceApprovalLevelRecord
public class RESTRC_85f15a383e9651f9f34f899ceee2be30 : AbstractRESTStructure<RC_85f15a383e9651f9f34f899ceee2be30> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("InvoiceApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public RESTRC_85f15a383e9651f9f34f899ceee2be30() { }

public RESTRC_85f15a383e9651f9f34f899ceee2be30 (RC_85f15a383e9651f9f34f899ceee2be30 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static RC_85f15a383e9651f9f34f899ceee2be30 ToStructure(ssConectaProveedores.RestRecords.RESTRC_85f15a383e9651f9f34f899ceee2be30 obj) { 
  RC_85f15a383e9651f9f34f899ceee2be30 s = new RC_85f15a383e9651f9f34f899ceee2be30();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  }
  return s;
}

public static Func<RC_85f15a383e9651f9f34f899ceee2be30, ssConectaProveedores.RestRecords.RESTRC_85f15a383e9651f9f34f899ceee2be30> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_85f15a383e9651f9f34f899ceee2be30 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_85f15a383e9651f9f34f899ceee2be30 FromStructure(RC_85f15a383e9651f9f34f899ceee2be30 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_85f15a383e9651f9f34f899ceee2be30(s, config);
}

}


