using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceApprovalInvoiceStatusCanUploadRecord
public class JSONRC_0034cf2433ba52d290961e6b42045a29 : AbstractRESTStructure<RC_0034cf2433ba52d290961e6b42045a29> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceApproval")]
[JsonPropertyName("InvoiceApproval")]
public ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord AttrInvoiceApproval;

[JsonProperty("InvoiceStatus")]
[JsonPropertyName("InvoiceStatus")]
public ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

[JsonProperty("CanUpload")]
[JsonPropertyName("CanUpload")]
public bool? AttrCanUpload;

public JSONRC_0034cf2433ba52d290961e6b42045a29() { }

public JSONRC_0034cf2433ba52d290961e6b42045a29 (RC_0034cf2433ba52d290961e6b42045a29 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceApproval = ConvertToRestWithoutDefaults(s.ssENInvoiceApproval, new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
AttrCanUpload = ConvertToRestWithoutDefaults(s.ssCanUpload, false);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.FromStructure(s.ssENInvoiceApproval, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
AttrCanUpload = (bool?) s.ssCanUpload;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0034cf2433ba52d290961e6b42045a29, RC_0034cf2433ba52d290961e6b42045a29> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0034cf2433ba52d290961e6b42045a29 s) => ToStructure(s, config);
}
public static RC_0034cf2433ba52d290961e6b42045a29 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0034cf2433ba52d290961e6b42045a29 obj, IBehaviorsConfiguration config) { 
  RC_0034cf2433ba52d290961e6b42045a29 s = new RC_0034cf2433ba52d290961e6b42045a29();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceApproval = ssConectaProveedores.RestRecords.JSONEN_c2bd0675fed3aedb585c484c59155eddEntityRecord.ToStructure(obj.AttrInvoiceApproval, config);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus, config);
  s.ssCanUpload = obj.AttrCanUpload == null ? false : obj.AttrCanUpload.Value;
  }
  return s;
}

public static Func<RC_0034cf2433ba52d290961e6b42045a29, ssConectaProveedores.RestRecords.JSONRC_0034cf2433ba52d290961e6b42045a29> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0034cf2433ba52d290961e6b42045a29 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0034cf2433ba52d290961e6b42045a29 FromStructure(RC_0034cf2433ba52d290961e6b42045a29 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0034cf2433ba52d290961e6b42045a29(s, config);
}

}


