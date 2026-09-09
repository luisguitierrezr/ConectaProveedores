using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingEntries
public class RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord : AbstractRESTStructure<EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("Controldedocumento")]
public int? AttrControldedocumento;

[JsonProperty("Fechadedocumento")]
public String AttrFechadedocumento;

[JsonProperty("Fechadecontabilizacion")]
public String AttrFechadecontabilizacion;

[JsonProperty("Clasededocumento")]
public string AttrClasededocumento;

[JsonProperty("Sociedad")]
public string AttrSociedad;

[JsonProperty("Moneda")]
public string AttrMoneda;

[JsonProperty("TipodeCambio")]
public string AttrTipodeCambio;

[JsonProperty("FechadeConversion")]
public String AttrFechadeConversion;

[JsonProperty("NumerodeDoc_DeReferencia")]
public string AttrNumerodeDoc_DeReferencia;

[JsonProperty("TextodeCabeceradeDocumento")]
public string AttrTextodeCabeceradeDocumento;

[JsonProperty("ClaveContabilizacion")]
public int? AttrClaveContabilizacion;

[JsonProperty("CuentadeMayor")]
public string AttrCuentadeMayor;

[JsonProperty("IndicadorICME")]
public string AttrIndicadorICME;

[JsonProperty("Importeenmonedadeldocto")]
public decimal? AttrImporteenmonedadeldocto;

[JsonProperty("Calcularimpuestos")]
public string AttrCalcularimpuestos;

[JsonProperty("IndicadordeIVA")]
public string AttrIndicadordeIVA;

[JsonProperty("Division")]
public string AttrDivision;

[JsonProperty("Condicionesdepago")]
public string AttrCondicionesdepago;

[JsonProperty("Fechabase")]
public String AttrFechabase;

[JsonProperty("Centrodecostos")]
public string AttrCentrodecostos;

[JsonProperty("Centrodebeneficio")]
public string AttrCentrodebeneficio;

[JsonProperty("Numerodeasignacion")]
public string AttrNumerodeasignacion;

[JsonProperty("Texto")]
public string AttrTexto;

[JsonProperty("F_vencimiento")]
public string AttrF_vencimiento;

[JsonProperty("F_valor")]
public string AttrF_valor;

[JsonProperty("V_pago")]
public string AttrV_pago;

[JsonProperty("Nombre")]
public string AttrNombre;

[JsonProperty("Poblacion")]
public string AttrPoblacion;

[JsonProperty("Clavebanco")]
public string AttrClavebanco;

[JsonProperty("Cta_bancaria")]
public string AttrCta_bancaria;

[JsonProperty("Cuentaalternativa")]
public string AttrCuentaalternativa;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

public RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord() { }

public RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord (EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrControldedocumento = ConvertToRestWithoutDefaults(s.ssControldedocumento, 0);
AttrFechadedocumento = ConvertDateToRestWithoutDefaults(s.ssFechadedocumento, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrFechadecontabilizacion = ConvertDateToRestWithoutDefaults(s.ssFechadecontabilizacion, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrClasededocumento = ConvertToRestWithoutDefaults(s.ssClasededocumento, "");
AttrSociedad = ConvertToRestWithoutDefaults(s.ssSociedad, "");
AttrMoneda = ConvertToRestWithoutDefaults(s.ssMoneda, "");
AttrTipodeCambio = ConvertToRestWithoutDefaults(s.ssTipodeCambio, "");
AttrFechadeConversion = ConvertDateToRestWithoutDefaults(s.ssFechadeConversion, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrNumerodeDoc_DeReferencia = ConvertToRestWithoutDefaults(s.ssNumerodeDoc_DeReferencia, "");
AttrTextodeCabeceradeDocumento = ConvertToRestWithoutDefaults(s.ssTextodeCabeceradeDocumento, "");
AttrClaveContabilizacion = ConvertToRestWithoutDefaults(s.ssClaveContabilizacion, 0);
AttrCuentadeMayor = ConvertToRestWithoutDefaults(s.ssCuentadeMayor, "");
AttrIndicadorICME = ConvertToRestWithoutDefaults(s.ssIndicadorICME, "");
AttrImporteenmonedadeldocto = ConvertToRestWithoutDefaults(s.ssImporteenmonedadeldocto, 0.0M);
AttrCalcularimpuestos = ConvertToRestWithoutDefaults(s.ssCalcularimpuestos, "");
AttrIndicadordeIVA = ConvertToRestWithoutDefaults(s.ssIndicadordeIVA, "");
AttrDivision = ConvertToRestWithoutDefaults(s.ssDivision, "");
AttrCondicionesdepago = ConvertToRestWithoutDefaults(s.ssCondicionesdepago, "");
AttrFechabase = ConvertDateToRestWithoutDefaults(s.ssFechabase, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrCentrodecostos = ConvertToRestWithoutDefaults(s.ssCentrodecostos, "");
AttrCentrodebeneficio = ConvertToRestWithoutDefaults(s.ssCentrodebeneficio, "");
AttrNumerodeasignacion = ConvertToRestWithoutDefaults(s.ssNumerodeasignacion, "");
AttrTexto = ConvertToRestWithoutDefaults(s.ssTexto, "");
AttrF_vencimiento = ConvertToRestWithoutDefaults(s.ssF_vencimiento, "");
AttrF_valor = ConvertToRestWithoutDefaults(s.ssF_valor, "");
AttrV_pago = ConvertToRestWithoutDefaults(s.ssV_pago, "");
AttrNombre = ConvertToRestWithoutDefaults(s.ssNombre, "");
AttrPoblacion = ConvertToRestWithoutDefaults(s.ssPoblacion, "");
AttrClavebanco = ConvertToRestWithoutDefaults(s.ssClavebanco, "");
AttrCta_bancaria = ConvertToRestWithoutDefaults(s.ssCta_bancaria, "");
AttrCuentaalternativa = ConvertToRestWithoutDefaults(s.ssCuentaalternativa, "");
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrControldedocumento = (int?) s.ssControldedocumento;
AttrFechadedocumento = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssFechadedocumento);
AttrFechadecontabilizacion = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssFechadecontabilizacion);
AttrClasededocumento = s.ssClasededocumento;
AttrSociedad = s.ssSociedad;
AttrMoneda = s.ssMoneda;
AttrTipodeCambio = s.ssTipodeCambio;
AttrFechadeConversion = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssFechadeConversion);
AttrNumerodeDoc_DeReferencia = s.ssNumerodeDoc_DeReferencia;
AttrTextodeCabeceradeDocumento = s.ssTextodeCabeceradeDocumento;
AttrClaveContabilizacion = (int?) s.ssClaveContabilizacion;
AttrCuentadeMayor = s.ssCuentadeMayor;
AttrIndicadorICME = s.ssIndicadorICME;
AttrImporteenmonedadeldocto = (decimal?) s.ssImporteenmonedadeldocto;
AttrCalcularimpuestos = s.ssCalcularimpuestos;
AttrIndicadordeIVA = s.ssIndicadordeIVA;
AttrDivision = s.ssDivision;
AttrCondicionesdepago = s.ssCondicionesdepago;
AttrFechabase = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssFechabase);
AttrCentrodecostos = s.ssCentrodecostos;
AttrCentrodebeneficio = s.ssCentrodebeneficio;
AttrNumerodeasignacion = s.ssNumerodeasignacion;
AttrTexto = s.ssTexto;
AttrF_vencimiento = s.ssF_vencimiento;
AttrF_valor = s.ssF_valor;
AttrV_pago = s.ssV_pago;
AttrNombre = s.ssNombre;
AttrPoblacion = s.ssPoblacion;
AttrClavebanco = s.ssClavebanco;
AttrCta_bancaria = s.ssCta_bancaria;
AttrCuentaalternativa = s.ssCuentaalternativa;
AttrCreatedBy = s.ssCreatedBy;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  }
}

public static EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord obj) { 
  EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord s = new EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssControldedocumento = obj.AttrControldedocumento == null ? 0 : obj.AttrControldedocumento.Value;
  s.ssFechadedocumento = obj.AttrFechadedocumento == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrFechadedocumento);
  s.ssFechadecontabilizacion = obj.AttrFechadecontabilizacion == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrFechadecontabilizacion);
  s.ssClasededocumento = obj.AttrClasededocumento == null ? "" : obj.AttrClasededocumento;
  s.ssSociedad = obj.AttrSociedad == null ? "" : obj.AttrSociedad;
  s.ssMoneda = obj.AttrMoneda == null ? "" : obj.AttrMoneda;
  s.ssTipodeCambio = obj.AttrTipodeCambio == null ? "" : obj.AttrTipodeCambio;
  s.ssFechadeConversion = obj.AttrFechadeConversion == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrFechadeConversion);
  s.ssNumerodeDoc_DeReferencia = obj.AttrNumerodeDoc_DeReferencia == null ? "" : obj.AttrNumerodeDoc_DeReferencia;
  s.ssTextodeCabeceradeDocumento = obj.AttrTextodeCabeceradeDocumento == null ? "" : obj.AttrTextodeCabeceradeDocumento;
  s.ssClaveContabilizacion = obj.AttrClaveContabilizacion == null ? 0 : obj.AttrClaveContabilizacion.Value;
  s.ssCuentadeMayor = obj.AttrCuentadeMayor == null ? "" : obj.AttrCuentadeMayor;
  s.ssIndicadorICME = obj.AttrIndicadorICME == null ? "" : obj.AttrIndicadorICME;
  s.ssImporteenmonedadeldocto = obj.AttrImporteenmonedadeldocto == null ? 0.0M : obj.AttrImporteenmonedadeldocto.Value;
  s.ssCalcularimpuestos = obj.AttrCalcularimpuestos == null ? "" : obj.AttrCalcularimpuestos;
  s.ssIndicadordeIVA = obj.AttrIndicadordeIVA == null ? "" : obj.AttrIndicadordeIVA;
  s.ssDivision = obj.AttrDivision == null ? "" : obj.AttrDivision;
  s.ssCondicionesdepago = obj.AttrCondicionesdepago == null ? "" : obj.AttrCondicionesdepago;
  s.ssFechabase = obj.AttrFechabase == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrFechabase);
  s.ssCentrodecostos = obj.AttrCentrodecostos == null ? "" : obj.AttrCentrodecostos;
  s.ssCentrodebeneficio = obj.AttrCentrodebeneficio == null ? "" : obj.AttrCentrodebeneficio;
  s.ssNumerodeasignacion = obj.AttrNumerodeasignacion == null ? "" : obj.AttrNumerodeasignacion;
  s.ssTexto = obj.AttrTexto == null ? "" : obj.AttrTexto;
  s.ssF_vencimiento = obj.AttrF_vencimiento == null ? "" : obj.AttrF_vencimiento;
  s.ssF_valor = obj.AttrF_valor == null ? "" : obj.AttrF_valor;
  s.ssV_pago = obj.AttrV_pago == null ? "" : obj.AttrV_pago;
  s.ssNombre = obj.AttrNombre == null ? "" : obj.AttrNombre;
  s.ssPoblacion = obj.AttrPoblacion == null ? "" : obj.AttrPoblacion;
  s.ssClavebanco = obj.AttrClavebanco == null ? "" : obj.AttrClavebanco;
  s.ssCta_bancaria = obj.AttrCta_bancaria == null ? "" : obj.AttrCta_bancaria;
  s.ssCuentaalternativa = obj.AttrCuentaalternativa == null ? "" : obj.AttrCuentaalternativa;
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord, ssConectaProveedores.RestRecords.RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord FromStructure(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_66fb76d3fab58a693a3c750c022bd4efEntityRecord(s, config);
}

}


