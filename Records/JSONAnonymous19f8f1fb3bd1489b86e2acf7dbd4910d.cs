using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyInvoiceRequisitionInvoiceExtendedItemRecord
public class JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039 : AbstractRESTStructure<RC_f5e2444cde8ccebe1d8b8fbec7a36039> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("InvoiceExtendedItem")]
[JsonPropertyName("InvoiceExtendedItem")]
public ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord AttrInvoiceExtendedItem;

public JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039() { }

public JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039 (RC_f5e2444cde8ccebe1d8b8fbec7a36039 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrInvoiceExtendedItem = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItem, new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrInvoiceExtendedItem = ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure(s.ssENInvoiceExtendedItem, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039, RC_f5e2444cde8ccebe1d8b8fbec7a36039> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039 s) => ToStructure(s, config);
}
public static RC_f5e2444cde8ccebe1d8b8fbec7a36039 ToStructure(ssConectaProveedores.RestRecords.JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039 obj, IBehaviorsConfiguration config) { 
  RC_f5e2444cde8ccebe1d8b8fbec7a36039 s = new RC_f5e2444cde8ccebe1d8b8fbec7a36039();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssENInvoiceExtendedItem = ssConectaProveedores.RestRecords.JSONEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.ToStructure(obj.AttrInvoiceExtendedItem, config);
  }
  return s;
}

public static Func<RC_f5e2444cde8ccebe1d8b8fbec7a36039, ssConectaProveedores.RestRecords.JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f5e2444cde8ccebe1d8b8fbec7a36039 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039 FromStructure(RC_f5e2444cde8ccebe1d8b8fbec7a36039 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_f5e2444cde8ccebe1d8b8fbec7a36039(s, config);
}

}


