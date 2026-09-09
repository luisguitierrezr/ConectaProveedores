using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedTax
public class JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord : AbstractRESTStructure<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
[JsonPropertyName("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceTaxTypeId")]
[JsonPropertyName("InvoiceTaxTypeId")]
public int? AttrInvoiceTaxTypeId;

[JsonProperty("Impuesto")]
[JsonPropertyName("Impuesto")]
public string AttrImpuesto;

[JsonProperty("Base")]
[JsonPropertyName("Base")]
public decimal? AttrBase;

[JsonProperty("TasaOCuota")]
[JsonPropertyName("TasaOCuota")]
public decimal? AttrTasaOCuota;

[JsonProperty("Importe")]
[JsonPropertyName("Importe")]
public decimal? AttrImporte;

[JsonProperty("TipoFactor")]
[JsonPropertyName("TipoFactor")]
public string AttrTipoFactor;

public JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord() { }

public JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrInvoiceTaxTypeId = ConvertToRestWithoutDefaults(s.ssInvoiceTaxTypeId, 0);
AttrImpuesto = ConvertToRestWithoutDefaults(s.ssImpuesto, "");
AttrBase = ConvertToRestWithoutDefaults(s.ssBase, 0.0M);
AttrTasaOCuota = ConvertToRestWithoutDefaults(s.ssTasaOCuota, 0.0M);
AttrImporte = ConvertToRestWithoutDefaults(s.ssImporte, 0.0M);
AttrTipoFactor = ConvertToRestWithoutDefaults(s.ssTipoFactor, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrInvoiceTaxTypeId = (int?) s.ssInvoiceTaxTypeId;
AttrImpuesto = s.ssImpuesto;
AttrBase = (decimal?) s.ssBase;
AttrTasaOCuota = (decimal?) s.ssTasaOCuota;
AttrImporte = (decimal?) s.ssImporte;
AttrTipoFactor = s.ssTipoFactor;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord s) => ToStructure(s, config);
}
public static EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord s = new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceTaxTypeId = obj.AttrInvoiceTaxTypeId == null ? 0 : obj.AttrInvoiceTaxTypeId.Value;
  s.ssImpuesto = obj.AttrImpuesto == null ? "" : obj.AttrImpuesto;
  s.ssBase = obj.AttrBase == null ? 0.0M : obj.AttrBase.Value;
  s.ssTasaOCuota = obj.AttrTasaOCuota == null ? 0.0M : obj.AttrTasaOCuota.Value;
  s.ssImporte = obj.AttrImporte == null ? 0.0M : obj.AttrImporte.Value;
  s.ssTipoFactor = obj.AttrTipoFactor == null ? "" : obj.AttrTipoFactor;
  }
  return s;
}

public static Func<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord FromStructure(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord(s, config);
}

}


