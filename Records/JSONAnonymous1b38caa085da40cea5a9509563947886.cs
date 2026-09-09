using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingTaxIndicatorPaymentTermsPaymentMethodsRecord
public class JSONRC_f925a49e2decb9ca9ea463dccae74847 : AbstractRESTStructure<RC_f925a49e2decb9ca9ea463dccae74847> {
[JsonProperty("InvoiceAccounting")]
[JsonPropertyName("InvoiceAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord AttrInvoiceAccounting;

[JsonProperty("TaxIndicator")]
[JsonPropertyName("TaxIndicator")]
public ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord AttrTaxIndicator;

[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

[JsonProperty("PaymentMethods")]
[JsonPropertyName("PaymentMethods")]
public ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord AttrPaymentMethods;

public JSONRC_f925a49e2decb9ca9ea463dccae74847() { }

public JSONRC_f925a49e2decb9ca9ea463dccae74847 (RC_f925a49e2decb9ca9ea463dccae74847 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccounting = ConvertToRestWithoutDefaults(s.ssENInvoiceAccounting, new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure, config);
AttrTaxIndicator = ConvertToRestWithoutDefaults(s.ssENTaxIndicator, new EN_efc751d189a1545503ba31ced5225e86EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
AttrPaymentMethods = ConvertToRestWithoutDefaults(s.ssENPaymentMethods, new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure(s.ssENInvoiceAccounting, config);
AttrTaxIndicator = ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure(s.ssENTaxIndicator, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
AttrPaymentMethods = ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure(s.ssENPaymentMethods, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f925a49e2decb9ca9ea463dccae74847, RC_f925a49e2decb9ca9ea463dccae74847> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f925a49e2decb9ca9ea463dccae74847 s) => ToStructure(s, config);
}
public static RC_f925a49e2decb9ca9ea463dccae74847 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f925a49e2decb9ca9ea463dccae74847 obj, IBehaviorsConfiguration config) { 
  RC_f925a49e2decb9ca9ea463dccae74847 s = new RC_f925a49e2decb9ca9ea463dccae74847();
  if(obj != null) {
  s.ssENInvoiceAccounting = ssConectaProveedores.RestRecords.JSONEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.ToStructure(obj.AttrInvoiceAccounting, config);
  s.ssENTaxIndicator = ssConectaProveedores.RestRecords.JSONEN_efc751d189a1545503ba31ced5225e86EntityRecord.ToStructure(obj.AttrTaxIndicator, config);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  s.ssENPaymentMethods = ssConectaProveedores.RestRecords.JSONEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure(obj.AttrPaymentMethods, config);
  }
  return s;
}

public static Func<RC_f925a49e2decb9ca9ea463dccae74847, ssConectaProveedores.RestRecords.JSONRC_f925a49e2decb9ca9ea463dccae74847> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f925a49e2decb9ca9ea463dccae74847 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f925a49e2decb9ca9ea463dccae74847 FromStructure(RC_f925a49e2decb9ca9ea463dccae74847 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f925a49e2decb9ca9ea463dccae74847(s, config);
}

}


