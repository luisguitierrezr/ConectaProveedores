using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceStatusRequisitionRequisitionAccountingPaymentTermsRecord
public class RESTRC_8fe6259afe1f49269695fecf5b2d7937 : AbstractRESTStructure<RC_8fe6259afe1f49269695fecf5b2d7937> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceStatus")]
public ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

[JsonProperty("PaymentTerms")]
public ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

public RESTRC_8fe6259afe1f49269695fecf5b2d7937() { }

public RESTRC_8fe6259afe1f49269695fecf5b2d7937 (RC_8fe6259afe1f49269695fecf5b2d7937 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
  }
}

public static RC_8fe6259afe1f49269695fecf5b2d7937 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8fe6259afe1f49269695fecf5b2d7937 obj) { 
  RC_8fe6259afe1f49269695fecf5b2d7937 s = new RC_8fe6259afe1f49269695fecf5b2d7937();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms);
  }
  return s;
}

public static Func<RC_8fe6259afe1f49269695fecf5b2d7937, ssConectaProveedores.RestRecords.RESTRC_8fe6259afe1f49269695fecf5b2d7937> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8fe6259afe1f49269695fecf5b2d7937 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8fe6259afe1f49269695fecf5b2d7937 FromStructure(RC_8fe6259afe1f49269695fecf5b2d7937 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8fe6259afe1f49269695fecf5b2d7937(s, config);
}

}


