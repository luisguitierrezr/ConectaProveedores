using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalInvoiceApprovalLevelRecord
public class JSONRC_bdad25a559cd2f146ec69d1aec036546 : AbstractRESTStructure<RC_bdad25a559cd2f146ec69d1aec036546> {
[JsonProperty("InvoiceApproval")]
[JsonPropertyName("InvoiceApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceApprovalLevel")]
[JsonPropertyName("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public JSONRC_bdad25a559cd2f146ec69d1aec036546() { }

public JSONRC_bdad25a559cd2f146ec69d1aec036546 (RC_bdad25a559cd2f146ec69d1aec036546 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bdad25a559cd2f146ec69d1aec036546, RC_bdad25a559cd2f146ec69d1aec036546> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bdad25a559cd2f146ec69d1aec036546 s) => ToStructure(s, config);
}
public static RC_bdad25a559cd2f146ec69d1aec036546 ToStructure(ssConectaProveedores.RestRecords.JSONRC_bdad25a559cd2f146ec69d1aec036546 obj, IBehaviorsConfiguration config) { 
  RC_bdad25a559cd2f146ec69d1aec036546 s = new RC_bdad25a559cd2f146ec69d1aec036546();
  if(obj != null) {
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval, config);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel, config);
  }
  return s;
}

public static Func<RC_bdad25a559cd2f146ec69d1aec036546, ssConectaProveedores.RestRecords.JSONRC_bdad25a559cd2f146ec69d1aec036546> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bdad25a559cd2f146ec69d1aec036546 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bdad25a559cd2f146ec69d1aec036546 FromStructure(RC_bdad25a559cd2f146ec69d1aec036546 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bdad25a559cd2f146ec69d1aec036546(s, config);
}

}


