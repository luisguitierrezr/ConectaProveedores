using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceStatusInvoiceExtendedReceiverInvoiceExtendedCartaPorteInvoiceExtendedIssuerInvoiceAccountingInvoiceExtendedPaymentTermsRecord
public class JSONRC_04cecda152c36243971fd8bd8862f207 : AbstractRESTStructure<RC_04cecda152c36243971fd8bd8862f207> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceStatus")]
[JsonPropertyName("InvoiceStatus")]
public ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

[JsonProperty("InvoiceExtendedReceiver")]
[JsonPropertyName("InvoiceExtendedReceiver")]
public ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord AttrInvoiceExtendedReceiver;

[JsonProperty("InvoiceExtendedCartaPorte")]
[JsonPropertyName("InvoiceExtendedCartaPorte")]
public ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord AttrInvoiceExtendedCartaPorte;

[JsonProperty("InvoiceExtendedIssuer")]
[JsonPropertyName("InvoiceExtendedIssuer")]
public ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord AttrInvoiceExtendedIssuer;

[JsonProperty("InvoiceAccounting")]
[JsonPropertyName("InvoiceAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord AttrInvoiceAccounting;

[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

public JSONRC_04cecda152c36243971fd8bd8862f207() { }

public JSONRC_04cecda152c36243971fd8bd8862f207 (RC_04cecda152c36243971fd8bd8862f207 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
AttrInvoiceExtendedReceiver = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedReceiver, new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.FromStructure, config);
AttrInvoiceExtendedCartaPorte = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedCartaPorte, new EN_9bd576a05df3846c52ce88a606aff414EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.FromStructure, config);
AttrInvoiceExtendedIssuer = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedIssuer, new EN_1ca446167f1a5fee035306f622895668EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.FromStructure, config);
AttrInvoiceAccounting = ConvertToRestWithoutDefaults(s.ssENInvoiceAccounting, new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure, config);
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
AttrInvoiceExtendedReceiver = ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.FromStructure(s.ssENInvoiceExtendedReceiver, config);
AttrInvoiceExtendedCartaPorte = ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.FromStructure(s.ssENInvoiceExtendedCartaPorte, config);
AttrInvoiceExtendedIssuer = ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.FromStructure(s.ssENInvoiceExtendedIssuer, config);
AttrInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure(s.ssENInvoiceAccounting, config);
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_04cecda152c36243971fd8bd8862f207, RC_04cecda152c36243971fd8bd8862f207> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_04cecda152c36243971fd8bd8862f207 s) => ToStructure(s, config);
}
public static RC_04cecda152c36243971fd8bd8862f207 ToStructure(ssConectaProveedores.RestRecords.JSONRC_04cecda152c36243971fd8bd8862f207 obj, IBehaviorsConfiguration config) { 
  RC_04cecda152c36243971fd8bd8862f207 s = new RC_04cecda152c36243971fd8bd8862f207();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus, config);
  s.ssENInvoiceExtendedReceiver = ssConectaProveedores.RestRecords.JSONEN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord.ToStructure(obj.AttrInvoiceExtendedReceiver, config);
  s.ssENInvoiceExtendedCartaPorte = ssConectaProveedores.RestRecords.JSONEN_9bd576a05df3846c52ce88a606aff414EntityRecord.ToStructure(obj.AttrInvoiceExtendedCartaPorte, config);
  s.ssENInvoiceExtendedIssuer = ssConectaProveedores.RestRecords.JSONEN_1ca446167f1a5fee035306f622895668EntityRecord.ToStructure(obj.AttrInvoiceExtendedIssuer, config);
  s.ssENInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.ToStructure(obj.AttrInvoiceAccounting, config);
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  }
  return s;
}

public static Func<RC_04cecda152c36243971fd8bd8862f207, ssConectaProveedores.RestRecords.JSONRC_04cecda152c36243971fd8bd8862f207> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04cecda152c36243971fd8bd8862f207 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_04cecda152c36243971fd8bd8862f207 FromStructure(RC_04cecda152c36243971fd8bd8862f207 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_04cecda152c36243971fd8bd8862f207(s, config);
}

}


