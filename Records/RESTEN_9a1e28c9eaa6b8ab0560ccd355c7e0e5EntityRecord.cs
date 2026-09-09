using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedTax
public class RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord : AbstractRESTStructure<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceTaxTypeId")]
public int? AttrInvoiceTaxTypeId;

[JsonProperty("Impuesto")]
public string AttrImpuesto;

[JsonProperty("Base")]
public decimal? AttrBase;

[JsonProperty("TasaOCuota")]
public decimal? AttrTasaOCuota;

[JsonProperty("Importe")]
public decimal? AttrImporte;

[JsonProperty("TipoFactor")]
public string AttrTipoFactor;

public RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord() { }

public RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord obj) { 
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

public static Func<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, ssConectaProveedores.RestRecords.RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord FromStructure(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord(s, config);
}

}


