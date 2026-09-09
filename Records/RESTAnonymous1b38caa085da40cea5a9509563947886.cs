using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingTaxIndicatorPaymentTermsPaymentMethodsRecord
public class RESTRC_f925a49e2decb9ca9ea463dccae74847 : AbstractRESTStructure<RC_f925a49e2decb9ca9ea463dccae74847> {
[JsonProperty("InvoiceAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord AttrInvoiceAccounting;

[JsonProperty("TaxIndicator")]
public ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord AttrTaxIndicator;

[JsonProperty("PaymentTerms")]
public ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

[JsonProperty("PaymentMethods")]
public ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord AttrPaymentMethods;

public RESTRC_f925a49e2decb9ca9ea463dccae74847() { }

public RESTRC_f925a49e2decb9ca9ea463dccae74847 (RC_f925a49e2decb9ca9ea463dccae74847 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccounting = ConvertToRestWithoutDefaults(s.ssENInvoiceAccounting, new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure, config);
AttrTaxIndicator = ConvertToRestWithoutDefaults(s.ssENTaxIndicator, new EN_efc751d189a1545503ba31ced5225e86EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
AttrPaymentMethods = ConvertToRestWithoutDefaults(s.ssENPaymentMethods, new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure, config);
  } else {
AttrInvoiceAccounting = ssConectaProveedores.RestRecords.RESTEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.FromStructure(s.ssENInvoiceAccounting, config);
AttrTaxIndicator = ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.FromStructure(s.ssENTaxIndicator, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
AttrPaymentMethods = ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructure(s.ssENPaymentMethods, config);
  }
}

public static RC_f925a49e2decb9ca9ea463dccae74847 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f925a49e2decb9ca9ea463dccae74847 obj) { 
  RC_f925a49e2decb9ca9ea463dccae74847 s = new RC_f925a49e2decb9ca9ea463dccae74847();
  if(obj != null) {
  s.ssENInvoiceAccounting = ssConectaProveedores.RestRecords.RESTEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord.ToStructure(obj.AttrInvoiceAccounting);
  s.ssENTaxIndicator = ssConectaProveedores.RestRecords.RESTEN_efc751d189a1545503ba31ced5225e86EntityRecord.ToStructure(obj.AttrTaxIndicator);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms);
  s.ssENPaymentMethods = ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure(obj.AttrPaymentMethods);
  }
  return s;
}

public static Func<RC_f925a49e2decb9ca9ea463dccae74847, ssConectaProveedores.RestRecords.RESTRC_f925a49e2decb9ca9ea463dccae74847> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f925a49e2decb9ca9ea463dccae74847 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f925a49e2decb9ca9ea463dccae74847 FromStructure(RC_f925a49e2decb9ca9ea463dccae74847 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f925a49e2decb9ca9ea463dccae74847(s, config);
}

}


