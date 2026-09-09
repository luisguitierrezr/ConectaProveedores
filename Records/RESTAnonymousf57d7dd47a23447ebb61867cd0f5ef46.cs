using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceApprovalInvoiceStatusCanUploadRecord
public class RESTRC_0034cf2433ba52d290961e6b42045a29 : AbstractRESTStructure<RC_0034cf2433ba52d290961e6b42045a29> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceStatus")]
public ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

[JsonProperty("CanUpload")]
public bool? AttrCanUpload;

public RESTRC_0034cf2433ba52d290961e6b42045a29() { }

public RESTRC_0034cf2433ba52d290961e6b42045a29 (RC_0034cf2433ba52d290961e6b42045a29 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
AttrCanUpload = ConvertToRestWithoutDefaults(s.ssCanUpload, false);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
AttrCanUpload = (bool?) s.ssCanUpload;
  }
}

public static RC_0034cf2433ba52d290961e6b42045a29 ToStructure(ssConectaProveedores.RestRecords.RESTRC_0034cf2433ba52d290961e6b42045a29 obj) { 
  RC_0034cf2433ba52d290961e6b42045a29 s = new RC_0034cf2433ba52d290961e6b42045a29();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.RESTEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus);
  s.ssCanUpload = obj.AttrCanUpload == null ? false : obj.AttrCanUpload.Value;
  }
  return s;
}

public static Func<RC_0034cf2433ba52d290961e6b42045a29, ssConectaProveedores.RestRecords.RESTRC_0034cf2433ba52d290961e6b42045a29> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0034cf2433ba52d290961e6b42045a29 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0034cf2433ba52d290961e6b42045a29 FromStructure(RC_0034cf2433ba52d290961e6b42045a29 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0034cf2433ba52d290961e6b42045a29(s, config);
}

}


