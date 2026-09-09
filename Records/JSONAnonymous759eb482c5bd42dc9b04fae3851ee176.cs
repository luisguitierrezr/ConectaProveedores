using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyInvoiceFolioInvoiceExtendedForeignerRecord
public class JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9 : AbstractRESTStructure<RC_0d7cf510ad0e091abdf9a2eb501fc0e9> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("InvoiceExtendedForeigner")]
[JsonPropertyName("InvoiceExtendedForeigner")]
public ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord AttrInvoiceExtendedForeigner;

public JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9() { }

public JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9 (RC_0d7cf510ad0e091abdf9a2eb501fc0e9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrInvoiceExtendedForeigner = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedForeigner, new EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrInvoiceExtendedForeigner = ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord.FromStructure(s.ssENInvoiceExtendedForeigner, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9, RC_0d7cf510ad0e091abdf9a2eb501fc0e9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9 s) => ToStructure(s, config);
}
public static RC_0d7cf510ad0e091abdf9a2eb501fc0e9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9 obj, IBehaviorsConfiguration config) { 
  RC_0d7cf510ad0e091abdf9a2eb501fc0e9 s = new RC_0d7cf510ad0e091abdf9a2eb501fc0e9();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENFolio = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio, config);
  s.ssENInvoiceExtendedForeigner = ssConectaProveedores.RestRecords.JSONEN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord.ToStructure(obj.AttrInvoiceExtendedForeigner, config);
  }
  return s;
}

public static Func<RC_0d7cf510ad0e091abdf9a2eb501fc0e9, ssConectaProveedores.RestRecords.JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0d7cf510ad0e091abdf9a2eb501fc0e9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9 FromStructure(RC_0d7cf510ad0e091abdf9a2eb501fc0e9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0d7cf510ad0e091abdf9a2eb501fc0e9(s, config);
}

}


