using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceOrderAccConceptsOrderMainCompanyPaymentTermsRecord
public class JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed : AbstractRESTStructure<RC_ff6aa2b6e9ff9861ddfa27919ed0cfed> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("OrderAccConcepts")]
[JsonPropertyName("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("Company")]
[JsonPropertyName("Company")]
public ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord AttrCompany;

[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

public JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed() { }

public JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed (RC_ff6aa2b6e9ff9861ddfa27919ed0cfed s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrCompany = ConvertToRestWithoutDefaults(s.ssENCompany, new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure, config);
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(s.ssENCompany, config);
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed, RC_ff6aa2b6e9ff9861ddfa27919ed0cfed> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed s) => ToStructure(s, config);
}
public static RC_ff6aa2b6e9ff9861ddfa27919ed0cfed ToStructure(ssConectaProveedores.RestRecords.JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed obj, IBehaviorsConfiguration config) { 
  RC_ff6aa2b6e9ff9861ddfa27919ed0cfed s = new RC_ff6aa2b6e9ff9861ddfa27919ed0cfed();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.JSONEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENCompany = ssConectaProveedores.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.ToStructure(obj.AttrCompany, config);
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  }
  return s;
}

public static Func<RC_ff6aa2b6e9ff9861ddfa27919ed0cfed, ssConectaProveedores.RestRecords.JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ff6aa2b6e9ff9861ddfa27919ed0cfed s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed FromStructure(RC_ff6aa2b6e9ff9861ddfa27919ed0cfed s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ff6aa2b6e9ff9861ddfa27919ed0cfed(s, config);
}

}


