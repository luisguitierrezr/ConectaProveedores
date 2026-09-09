using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceApprovalInvoiceApprovalLevelRecord
public class JSONRC_85f15a383e9651f9f34f899ceee2be30 : AbstractRESTStructure<RC_85f15a383e9651f9f34f899ceee2be30> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("InvoiceApproval")]
[JsonPropertyName("InvoiceApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public JSONRC_85f15a383e9651f9f34f899ceee2be30() { }

public JSONRC_85f15a383e9651f9f34f899ceee2be30 (RC_85f15a383e9651f9f34f899ceee2be30 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_85f15a383e9651f9f34f899ceee2be30, RC_85f15a383e9651f9f34f899ceee2be30> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_85f15a383e9651f9f34f899ceee2be30 s) => ToStructure(s, config);
}
public static RC_85f15a383e9651f9f34f899ceee2be30 ToStructure(ssConectaProveedores.RestRecords.JSONRC_85f15a383e9651f9f34f899ceee2be30 obj, IBehaviorsConfiguration config) { 
  RC_85f15a383e9651f9f34f899ceee2be30 s = new RC_85f15a383e9651f9f34f899ceee2be30();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  }
  return s;
}

public static Func<RC_85f15a383e9651f9f34f899ceee2be30, ssConectaProveedores.RestRecords.JSONRC_85f15a383e9651f9f34f899ceee2be30> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_85f15a383e9651f9f34f899ceee2be30 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_85f15a383e9651f9f34f899ceee2be30 FromStructure(RC_85f15a383e9651f9f34f899ceee2be30 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_85f15a383e9651f9f34f899ceee2be30(s, config);
}

}


