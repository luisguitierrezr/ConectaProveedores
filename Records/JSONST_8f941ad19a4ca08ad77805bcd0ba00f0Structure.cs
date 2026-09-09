using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ImportAccountingExcelStruct
public class JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure : AbstractRESTStructure<ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure> {
[JsonProperty("Controldedocumento")]
[JsonPropertyName("Controldedocumento")]
public int? AttrControldedocumento;

[JsonProperty("Fechadedocumento")]
[JsonPropertyName("Fechadedocumento")]
public string AttrFechadedocumento;

[JsonProperty("Fechadecontabilizacion")]
[JsonPropertyName("Fechadecontabilizacion")]
public string AttrFechadecontabilizacion;

[JsonProperty("Clasededocumento")]
[JsonPropertyName("Clasededocumento")]
public string AttrClasededocumento;

[JsonProperty("Sociedad")]
[JsonPropertyName("Sociedad")]
public string AttrSociedad;

[JsonProperty("Moneda")]
[JsonPropertyName("Moneda")]
public string AttrMoneda;

[JsonProperty("TipodeCambio")]
[JsonPropertyName("TipodeCambio")]
public string AttrTipodeCambio;

[JsonProperty("FechadeConversion")]
[JsonPropertyName("FechadeConversion")]
public string AttrFechadeConversion;

[JsonProperty("NumerodeDoc_DeReferencia")]
[JsonPropertyName("NumerodeDoc_DeReferencia")]
public string AttrNumerodeDoc_DeReferencia;

[JsonProperty("TextodeCabeceradeDocumento")]
[JsonPropertyName("TextodeCabeceradeDocumento")]
public string AttrTextodeCabeceradeDocumento;

[JsonProperty("ClaveContabilizacion")]
[JsonPropertyName("ClaveContabilizacion")]
public int? AttrClaveContabilizacion;

[JsonProperty("CuentadeMayor")]
[JsonPropertyName("CuentadeMayor")]
public string AttrCuentadeMayor;

[JsonProperty("IndicadorICME")]
[JsonPropertyName("IndicadorICME")]
public string AttrIndicadorICME;

[JsonProperty("Importeenmonedadeldocto")]
[JsonPropertyName("Importeenmonedadeldocto")]
public decimal? AttrImporteenmonedadeldocto;

[JsonProperty("Calcularimpuestos")]
[JsonPropertyName("Calcularimpuestos")]
public string AttrCalcularimpuestos;

[JsonProperty("IVA")]
[JsonPropertyName("IVA")]
public string AttrIVA;

[JsonProperty("Division")]
[JsonPropertyName("Division")]
public string AttrDivision;

[JsonProperty("Condicionesdepago")]
[JsonPropertyName("Condicionesdepago")]
public string AttrCondicionesdepago;

[JsonProperty("Fechabase")]
[JsonPropertyName("Fechabase")]
public string AttrFechabase;

[JsonProperty("Centrodecostos")]
[JsonPropertyName("Centrodecostos")]
public string AttrCentrodecostos;

[JsonProperty("Centrodebeneficio")]
[JsonPropertyName("Centrodebeneficio")]
public string AttrCentrodebeneficio;

[JsonProperty("Numerodeasignacion")]
[JsonPropertyName("Numerodeasignacion")]
public string AttrNumerodeasignacion;

[JsonProperty("Texto")]
[JsonPropertyName("Texto")]
public string AttrTexto;

[JsonProperty("F_vencimiento")]
[JsonPropertyName("F_vencimiento")]
public string AttrF_vencimiento;

[JsonProperty("F_valor")]
[JsonPropertyName("F_valor")]
public string AttrF_valor;

[JsonProperty("V_pago")]
[JsonPropertyName("V_pago")]
public string AttrV_pago;

[JsonProperty("Nombre")]
[JsonPropertyName("Nombre")]
public string AttrNombre;

[JsonProperty("Poblacion")]
[JsonPropertyName("Poblacion")]
public string AttrPoblacion;

[JsonProperty("Clavebanco")]
[JsonPropertyName("Clavebanco")]
public string AttrClavebanco;

[JsonProperty("Cta_bancaria")]
[JsonPropertyName("Cta_bancaria")]
public string AttrCta_bancaria;

[JsonProperty("Cuentaalternativa")]
[JsonPropertyName("Cuentaalternativa")]
public string AttrCuentaalternativa;

public JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure() { }

public JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure (ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrControldedocumento = ConvertToRestWithoutDefaults(s.ssControldedocumento, 0);
AttrFechadedocumento = ConvertToRestWithoutDefaults(s.ssFechadedocumento, "");
AttrFechadecontabilizacion = ConvertToRestWithoutDefaults(s.ssFechadecontabilizacion, "");
AttrClasededocumento = ConvertToRestWithoutDefaults(s.ssClasededocumento, "");
AttrSociedad = ConvertToRestWithoutDefaults(s.ssSociedad, "");
AttrMoneda = ConvertToRestWithoutDefaults(s.ssMoneda, "");
AttrTipodeCambio = ConvertToRestWithoutDefaults(s.ssTipodeCambio, "");
AttrFechadeConversion = ConvertToRestWithoutDefaults(s.ssFechadeConversion, "");
AttrNumerodeDoc_DeReferencia = ConvertToRestWithoutDefaults(s.ssNumerodeDoc_DeReferencia, "");
AttrTextodeCabeceradeDocumento = ConvertToRestWithoutDefaults(s.ssTextodeCabeceradeDocumento, "");
AttrClaveContabilizacion = ConvertToRestWithoutDefaults(s.ssClaveContabilizacion, 0);
AttrCuentadeMayor = ConvertToRestWithoutDefaults(s.ssCuentadeMayor, "");
AttrIndicadorICME = ConvertToRestWithoutDefaults(s.ssIndicadorICME, "");
AttrImporteenmonedadeldocto = ConvertToRestWithoutDefaults(s.ssImporteenmonedadeldocto, 0.0M);
AttrCalcularimpuestos = ConvertToRestWithoutDefaults(s.ssCalcularimpuestos, "");
AttrIVA = ConvertToRestWithoutDefaults(s.ssIVA, "");
AttrDivision = ConvertToRestWithoutDefaults(s.ssDivision, "");
AttrCondicionesdepago = ConvertToRestWithoutDefaults(s.ssCondicionesdepago, "");
AttrFechabase = ConvertToRestWithoutDefaults(s.ssFechabase, "");
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
  } else {
AttrControldedocumento = (int?) s.ssControldedocumento;
AttrFechadedocumento = s.ssFechadedocumento;
AttrFechadecontabilizacion = s.ssFechadecontabilizacion;
AttrClasededocumento = s.ssClasededocumento;
AttrSociedad = s.ssSociedad;
AttrMoneda = s.ssMoneda;
AttrTipodeCambio = s.ssTipodeCambio;
AttrFechadeConversion = s.ssFechadeConversion;
AttrNumerodeDoc_DeReferencia = s.ssNumerodeDoc_DeReferencia;
AttrTextodeCabeceradeDocumento = s.ssTextodeCabeceradeDocumento;
AttrClaveContabilizacion = (int?) s.ssClaveContabilizacion;
AttrCuentadeMayor = s.ssCuentadeMayor;
AttrIndicadorICME = s.ssIndicadorICME;
AttrImporteenmonedadeldocto = (decimal?) s.ssImporteenmonedadeldocto;
AttrCalcularimpuestos = s.ssCalcularimpuestos;
AttrIVA = s.ssIVA;
AttrDivision = s.ssDivision;
AttrCondicionesdepago = s.ssCondicionesdepago;
AttrFechabase = s.ssFechabase;
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
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure, ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure s) => ToStructure(s, config);
}
public static ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure obj, IBehaviorsConfiguration config) { 
  ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure s = new ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure();
  if(obj != null) {
  s.ssControldedocumento = obj.AttrControldedocumento == null ? 0 : obj.AttrControldedocumento.Value;
  s.ssFechadedocumento = obj.AttrFechadedocumento == null ? "" : obj.AttrFechadedocumento;
  s.ssFechadecontabilizacion = obj.AttrFechadecontabilizacion == null ? "" : obj.AttrFechadecontabilizacion;
  s.ssClasededocumento = obj.AttrClasededocumento == null ? "" : obj.AttrClasededocumento;
  s.ssSociedad = obj.AttrSociedad == null ? "" : obj.AttrSociedad;
  s.ssMoneda = obj.AttrMoneda == null ? "" : obj.AttrMoneda;
  s.ssTipodeCambio = obj.AttrTipodeCambio == null ? "" : obj.AttrTipodeCambio;
  s.ssFechadeConversion = obj.AttrFechadeConversion == null ? "" : obj.AttrFechadeConversion;
  s.ssNumerodeDoc_DeReferencia = obj.AttrNumerodeDoc_DeReferencia == null ? "" : obj.AttrNumerodeDoc_DeReferencia;
  s.ssTextodeCabeceradeDocumento = obj.AttrTextodeCabeceradeDocumento == null ? "" : obj.AttrTextodeCabeceradeDocumento;
  s.ssClaveContabilizacion = obj.AttrClaveContabilizacion == null ? 0 : obj.AttrClaveContabilizacion.Value;
  s.ssCuentadeMayor = obj.AttrCuentadeMayor == null ? "" : obj.AttrCuentadeMayor;
  s.ssIndicadorICME = obj.AttrIndicadorICME == null ? "" : obj.AttrIndicadorICME;
  s.ssImporteenmonedadeldocto = obj.AttrImporteenmonedadeldocto == null ? 0.0M : obj.AttrImporteenmonedadeldocto.Value;
  s.ssCalcularimpuestos = obj.AttrCalcularimpuestos == null ? "" : obj.AttrCalcularimpuestos;
  s.ssIVA = obj.AttrIVA == null ? "" : obj.AttrIVA;
  s.ssDivision = obj.AttrDivision == null ? "" : obj.AttrDivision;
  s.ssCondicionesdepago = obj.AttrCondicionesdepago == null ? "" : obj.AttrCondicionesdepago;
  s.ssFechabase = obj.AttrFechabase == null ? "" : obj.AttrFechabase;
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
  }
  return s;
}

public static Func<ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure, ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure FromStructure(ST_8f941ad19a4ca08ad77805bcd0ba00f0Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_8f941ad19a4ca08ad77805bcd0ba00f0Structure(s, config);
}

}


