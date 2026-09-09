using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemTax
public class JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord : AbstractRESTStructure<EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("InvoiceExtendedItemId")]
[JsonPropertyName("InvoiceExtendedItemId")]
public long? AttrInvoiceExtendedItemId;

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

public JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord() { }

public JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceExtendedItemId = ConvertToRestWithoutDefaults(s.ssInvoiceExtendedItemId, 0L);
AttrInvoiceTaxTypeId = ConvertToRestWithoutDefaults(s.ssInvoiceTaxTypeId, 0);
AttrImpuesto = ConvertToRestWithoutDefaults(s.ssImpuesto, "");
AttrBase = ConvertToRestWithoutDefaults(s.ssBase, 0.0M);
AttrTasaOCuota = ConvertToRestWithoutDefaults(s.ssTasaOCuota, 0.0M);
AttrImporte = ConvertToRestWithoutDefaults(s.ssImporte, 0.0M);
AttrTipoFactor = ConvertToRestWithoutDefaults(s.ssTipoFactor, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceExtendedItemId = (long?) s.ssInvoiceExtendedItemId;
AttrInvoiceTaxTypeId = (int?) s.ssInvoiceTaxTypeId;
AttrImpuesto = s.ssImpuesto;
AttrBase = (decimal?) s.ssBase;
AttrTasaOCuota = (decimal?) s.ssTasaOCuota;
AttrImporte = (decimal?) s.ssImporte;
AttrTipoFactor = s.ssTipoFactor;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord, EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord s) => ToStructure(s, config);
}
public static EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord s = new EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceExtendedItemId = obj.AttrInvoiceExtendedItemId == null ? 0L : obj.AttrInvoiceExtendedItemId.Value;
  s.ssInvoiceTaxTypeId = obj.AttrInvoiceTaxTypeId == null ? 0 : obj.AttrInvoiceTaxTypeId.Value;
  s.ssImpuesto = obj.AttrImpuesto == null ? "" : obj.AttrImpuesto;
  s.ssBase = obj.AttrBase == null ? 0.0M : obj.AttrBase.Value;
  s.ssTasaOCuota = obj.AttrTasaOCuota == null ? 0.0M : obj.AttrTasaOCuota.Value;
  s.ssImporte = obj.AttrImporte == null ? 0.0M : obj.AttrImporte.Value;
  s.ssTipoFactor = obj.AttrTipoFactor == null ? "" : obj.AttrTipoFactor;
  }
  return s;
}

public static Func<EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord, ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord FromStructure(EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord(s, config);
}

}


