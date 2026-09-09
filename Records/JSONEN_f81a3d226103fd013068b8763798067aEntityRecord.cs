using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtended
public class JSONEN_f81a3d226103fd013068b8763798067aEntityRecord : AbstractRESTStructure<EN_f81a3d226103fd013068b8763798067aEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("Version")]
[JsonPropertyName("Version")]
public string AttrVersion;

[JsonProperty("Folio")]
[JsonPropertyName("Folio")]
public string AttrFolio;

[JsonProperty("Serie")]
[JsonPropertyName("Serie")]
public string AttrSerie;

[JsonProperty("FechaEmision")]
[JsonPropertyName("FechaEmision")]
public string AttrFechaEmision;

[JsonProperty("FormaPago")]
[JsonPropertyName("FormaPago")]
public string AttrFormaPago;

[JsonProperty("MetodoPago")]
[JsonPropertyName("MetodoPago")]
public string AttrMetodoPago;

[JsonProperty("LugarExpedicion")]
[JsonPropertyName("LugarExpedicion")]
public string AttrLugarExpedicion;

[JsonProperty("Subtotal")]
[JsonPropertyName("Subtotal")]
public decimal? AttrSubtotal;

[JsonProperty("Descuento")]
[JsonPropertyName("Descuento")]
public decimal? AttrDescuento;

[JsonProperty("TotalIVA")]
[JsonPropertyName("TotalIVA")]
public decimal? AttrTotalIVA;

[JsonProperty("Retenciones")]
[JsonPropertyName("Retenciones")]
public decimal? AttrRetenciones;

[JsonProperty("Total")]
[JsonPropertyName("Total")]
public decimal? AttrTotal;

[JsonProperty("TipoComprobante")]
[JsonPropertyName("TipoComprobante")]
public string AttrTipoComprobante;

[JsonProperty("Moneda")]
[JsonPropertyName("Moneda")]
public string AttrMoneda;

[JsonProperty("TipoCambio")]
[JsonPropertyName("TipoCambio")]
public decimal? AttrTipoCambio;

[JsonProperty("UsoCFDI")]
[JsonPropertyName("UsoCFDI")]
public string AttrUsoCFDI;

[JsonProperty("Exportacion")]
[JsonPropertyName("Exportacion")]
public string AttrExportacion;

[JsonProperty("UUID")]
[JsonPropertyName("UUID")]
public string AttrUUID;

public JSONEN_f81a3d226103fd013068b8763798067aEntityRecord() { }

public JSONEN_f81a3d226103fd013068b8763798067aEntityRecord (EN_f81a3d226103fd013068b8763798067aEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrVersion = ConvertToRestWithoutDefaults(s.ssVersion, "");
AttrFolio = ConvertToRestWithoutDefaults(s.ssFolio, "");
AttrSerie = ConvertToRestWithoutDefaults(s.ssSerie, "");
AttrFechaEmision = ConvertToRestWithoutDefaults(s.ssFechaEmision, "");
AttrFormaPago = ConvertToRestWithoutDefaults(s.ssFormaPago, "");
AttrMetodoPago = ConvertToRestWithoutDefaults(s.ssMetodoPago, "");
AttrLugarExpedicion = ConvertToRestWithoutDefaults(s.ssLugarExpedicion, "");
AttrSubtotal = ConvertToRestWithoutDefaults(s.ssSubtotal, 0.0M);
AttrDescuento = ConvertToRestWithoutDefaults(s.ssDescuento, 0.0M);
AttrTotalIVA = ConvertToRestWithoutDefaults(s.ssTotalIVA, 0.0M);
AttrRetenciones = ConvertToRestWithoutDefaults(s.ssRetenciones, 0.0M);
AttrTotal = ConvertToRestWithoutDefaults(s.ssTotal, 0.0M);
AttrTipoComprobante = ConvertToRestWithoutDefaults(s.ssTipoComprobante, "");
AttrMoneda = ConvertToRestWithoutDefaults(s.ssMoneda, "");
AttrTipoCambio = ConvertToRestWithoutDefaults(s.ssTipoCambio, 0.0M);
AttrUsoCFDI = ConvertToRestWithoutDefaults(s.ssUsoCFDI, "");
AttrExportacion = ConvertToRestWithoutDefaults(s.ssExportacion, "");
AttrUUID = ConvertToRestWithoutDefaults(s.ssUUID, "");
  } else {
AttrId = (long?) s.ssId;
AttrVersion = s.ssVersion;
AttrFolio = s.ssFolio;
AttrSerie = s.ssSerie;
AttrFechaEmision = s.ssFechaEmision;
AttrFormaPago = s.ssFormaPago;
AttrMetodoPago = s.ssMetodoPago;
AttrLugarExpedicion = s.ssLugarExpedicion;
AttrSubtotal = (decimal?) s.ssSubtotal;
AttrDescuento = (decimal?) s.ssDescuento;
AttrTotalIVA = (decimal?) s.ssTotalIVA;
AttrRetenciones = (decimal?) s.ssRetenciones;
AttrTotal = (decimal?) s.ssTotal;
AttrTipoComprobante = s.ssTipoComprobante;
AttrMoneda = s.ssMoneda;
AttrTipoCambio = (decimal?) s.ssTipoCambio;
AttrUsoCFDI = s.ssUsoCFDI;
AttrExportacion = s.ssExportacion;
AttrUUID = s.ssUUID;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord, EN_f81a3d226103fd013068b8763798067aEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord s) => ToStructure(s, config);
}
public static EN_f81a3d226103fd013068b8763798067aEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f81a3d226103fd013068b8763798067aEntityRecord s = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssVersion = obj.AttrVersion == null ? "" : obj.AttrVersion;
  s.ssFolio = obj.AttrFolio == null ? "" : obj.AttrFolio;
  s.ssSerie = obj.AttrSerie == null ? "" : obj.AttrSerie;
  s.ssFechaEmision = obj.AttrFechaEmision == null ? "" : obj.AttrFechaEmision;
  s.ssFormaPago = obj.AttrFormaPago == null ? "" : obj.AttrFormaPago;
  s.ssMetodoPago = obj.AttrMetodoPago == null ? "" : obj.AttrMetodoPago;
  s.ssLugarExpedicion = obj.AttrLugarExpedicion == null ? "" : obj.AttrLugarExpedicion;
  s.ssSubtotal = obj.AttrSubtotal == null ? 0.0M : obj.AttrSubtotal.Value;
  s.ssDescuento = obj.AttrDescuento == null ? 0.0M : obj.AttrDescuento.Value;
  s.ssTotalIVA = obj.AttrTotalIVA == null ? 0.0M : obj.AttrTotalIVA.Value;
  s.ssRetenciones = obj.AttrRetenciones == null ? 0.0M : obj.AttrRetenciones.Value;
  s.ssTotal = obj.AttrTotal == null ? 0.0M : obj.AttrTotal.Value;
  s.ssTipoComprobante = obj.AttrTipoComprobante == null ? "" : obj.AttrTipoComprobante;
  s.ssMoneda = obj.AttrMoneda == null ? "" : obj.AttrMoneda;
  s.ssTipoCambio = obj.AttrTipoCambio == null ? 0.0M : obj.AttrTipoCambio.Value;
  s.ssUsoCFDI = obj.AttrUsoCFDI == null ? "" : obj.AttrUsoCFDI;
  s.ssExportacion = obj.AttrExportacion == null ? "" : obj.AttrExportacion;
  s.ssUUID = obj.AttrUUID == null ? "" : obj.AttrUUID;
  }
  return s;
}

public static Func<EN_f81a3d226103fd013068b8763798067aEntityRecord, ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f81a3d226103fd013068b8763798067aEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord FromStructure(EN_f81a3d226103fd013068b8763798067aEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord(s, config);
}

}


