using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceApprovalInvoiceApprovalLevelRecord
public class RESTRC_bdad25a559cd2f146ec69d1aec036546 : AbstractRESTStructure<RC_bdad25a559cd2f146ec69d1aec036546> {
[JsonProperty("InvoiceApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord AttrInvoiceApprovalLevel;

public RESTRC_bdad25a559cd2f146ec69d1aec036546() { }

public RESTRC_bdad25a559cd2f146ec69d1aec036546 (RC_bdad25a559cd2f146ec69d1aec036546 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceApprovalLevel = ConvertToRestWithoutDefaults(s.ssENInvoiceApprovalLevel, new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure, config);
  } else {
AttrInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.FromStructure(s.ssENInvoiceApprovalLevel, config);
  }
}

public static RC_bdad25a559cd2f146ec69d1aec036546 ToStructure(ssConectaProveedores.RestRecords.RESTRC_bdad25a559cd2f146ec69d1aec036546 obj) { 
  RC_bdad25a559cd2f146ec69d1aec036546 s = new RC_bdad25a559cd2f146ec69d1aec036546();
  if(obj != null) {
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval);
  s.ssENInvoiceApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord.ToStructure(obj.AttrInvoiceApprovalLevel);
  }
  return s;
}

public static Func<RC_bdad25a559cd2f146ec69d1aec036546, ssConectaProveedores.RestRecords.RESTRC_bdad25a559cd2f146ec69d1aec036546> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bdad25a559cd2f146ec69d1aec036546 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bdad25a559cd2f146ec69d1aec036546 FromStructure(RC_bdad25a559cd2f146ec69d1aec036546 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bdad25a559cd2f146ec69d1aec036546(s, config);
}

}


