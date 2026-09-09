using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceAccountingEntries (TM3WpVuPDEy0TrzRiQDrYw)
///  <code>EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord</code> that represent
/// s <code>InvoiceAccountingEntries</code> <p>Description: Entity that holds invoice Accounting
///  Entries from Excel Importing.</p>
/// </summary>
// Name: InvoiceAccountingEntries
public partial struct EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord : ITypedRecord<EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QyUivHvjJ02Zea6OXo+Bag");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0Y4VCF0aYEGAUE4MO6yR8g");
internal static readonly GlobalObjectKey IdControldedocumento = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Wi3A3lvHdU+V9Q9mf2CSng");
internal static readonly GlobalObjectKey IdFechadedocumento = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uhsaAn_5WUC28eqAjDCbxA");
internal static readonly GlobalObjectKey IdFechadecontabilizacion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZAAXEsFajkGVog0_dg2_dQ");
internal static readonly GlobalObjectKey IdClasededocumento = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GtymluuR+kOaWX5koxeCCQ");
internal static readonly GlobalObjectKey IdSociedad = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PfvASDjZcUqTsNqm1XhAuQ");
internal static readonly GlobalObjectKey IdMoneda = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J7rY0p6tsEygyhjf88L4xQ");
internal static readonly GlobalObjectKey IdTipodeCambio = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uPFDSA6bYEqYLPJVB5JyRg");
internal static readonly GlobalObjectKey IdFechadeConversion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PRyH1STLE0SqRN21X3aSBg");
internal static readonly GlobalObjectKey IdNumerodeDoc_DeReferencia = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NXDQFAecC0+PUiFeDLDm9w");
internal static readonly GlobalObjectKey IdTextodeCabeceradeDocumento = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*29BmN+a2SUOguibeYhh1Dw");
internal static readonly GlobalObjectKey IdClaveContabilizacion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5oRPGzKmeE+59gecZqnHiQ");
internal static readonly GlobalObjectKey IdCuentadeMayor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kZ35F9nsTkWOXILNQMtFpA");
internal static readonly GlobalObjectKey IdIndicadorICME = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZcDxSoq3XUCUhcVemJ8zfA");
internal static readonly GlobalObjectKey IdImporteenmonedadeldocto = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*O8KxiM9Kg0yzvRcWW8rVug");
internal static readonly GlobalObjectKey IdCalcularimpuestos = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nM7StFlaaUiuhQ64y8xWyg");
internal static readonly GlobalObjectKey IdIndicadordeIVA = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UQIXamIJVkOMVlXzSaMCJQ");
internal static readonly GlobalObjectKey IdDivision = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+MV0LFBqAkmBp8yjMHH6ag");
internal static readonly GlobalObjectKey IdCondicionesdepago = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HH1fWxNsMUGPxvbm1Mjd_Q");
internal static readonly GlobalObjectKey IdFechabase = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8zCy7f4lUEaC3K2LcKnnbw");
internal static readonly GlobalObjectKey IdCentrodecostos = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YRlqPsKnbUOPBOjGwEyWag");
internal static readonly GlobalObjectKey IdCentrodebeneficio = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zZpNODHPzE+T0KEuYrPn2w");
internal static readonly GlobalObjectKey IdNumerodeasignacion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HQZJyqyzc0O4r0Vi4iZRZQ");
internal static readonly GlobalObjectKey IdTexto = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*z4+AWCGeDEGtjxaWK4HEmg");
internal static readonly GlobalObjectKey IdF_vencimiento = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zQzjIBplKEWgf4IzJviIUQ");
internal static readonly GlobalObjectKey IdF_valor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3BrVbUzTNUa9RJOa9qM50g");
internal static readonly GlobalObjectKey IdV_pago = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*s5irSkLFrEeAEC+rIBJh+g");
internal static readonly GlobalObjectKey IdNombre = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UhA4KD3Q0k+Jn5BrOylR6A");
internal static readonly GlobalObjectKey IdPoblacion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*P5zI8kUUGk25RkRVm+IfEg");
internal static readonly GlobalObjectKey IdClavebanco = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7dyvsUZjaUyXavtThA3FpA");
internal static readonly GlobalObjectKey IdCta_bancaria = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HXs5O6Y5Rk6dX4dh27IgGg");
internal static readonly GlobalObjectKey IdCuentaalternativa = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IJiOF7IfUkmjRI09ivWu8A");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lI8rehb9H0y8QJbU6pzeNQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dMkklBhmvEyAEyQF23gdhg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(35,true);
          _ssId = value;
      }
  }
}

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceId = value;
      }
  }
}

private int _ssControldedocumento;
public int ssControldedocumento{
  get{
      return _ssControldedocumento;
  }
  set{
      if((_ssControldedocumento!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssControldedocumento = value;
      }
  }
}

private DateTime _ssFechadedocumento;
public DateTime ssFechadedocumento{
  get{
      return _ssFechadedocumento;
  }
  set{
      if((_ssFechadedocumento!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssFechadedocumento = value;
      }
  }
}

private DateTime _ssFechadecontabilizacion;
public DateTime ssFechadecontabilizacion{
  get{
      return _ssFechadecontabilizacion;
  }
  set{
      if((_ssFechadecontabilizacion!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssFechadecontabilizacion = value;
      }
  }
}

private string _ssClasededocumento;
public string ssClasededocumento{
  get{
      return _ssClasededocumento;
  }
  set{
      if((_ssClasededocumento!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssClasededocumento = value;
      }
  }
}

private string _ssSociedad;
public string ssSociedad{
  get{
      return _ssSociedad;
  }
  set{
      if((_ssSociedad!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssSociedad = value;
      }
  }
}

private string _ssMoneda;
public string ssMoneda{
  get{
      return _ssMoneda;
  }
  set{
      if((_ssMoneda!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssMoneda = value;
      }
  }
}

private string _ssTipodeCambio;
public string ssTipodeCambio{
  get{
      return _ssTipodeCambio;
  }
  set{
      if((_ssTipodeCambio!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssTipodeCambio = value;
      }
  }
}

private DateTime _ssFechadeConversion;
public DateTime ssFechadeConversion{
  get{
      return _ssFechadeConversion;
  }
  set{
      if((_ssFechadeConversion!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssFechadeConversion = value;
      }
  }
}

private string _ssNumerodeDoc_DeReferencia;
public string ssNumerodeDoc_DeReferencia{
  get{
      return _ssNumerodeDoc_DeReferencia;
  }
  set{
      if((_ssNumerodeDoc_DeReferencia!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssNumerodeDoc_DeReferencia = value;
      }
  }
}

private string _ssTextodeCabeceradeDocumento;
public string ssTextodeCabeceradeDocumento{
  get{
      return _ssTextodeCabeceradeDocumento;
  }
  set{
      if((_ssTextodeCabeceradeDocumento!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssTextodeCabeceradeDocumento = value;
      }
  }
}

private int _ssClaveContabilizacion;
public int ssClaveContabilizacion{
  get{
      return _ssClaveContabilizacion;
  }
  set{
      if((_ssClaveContabilizacion!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssClaveContabilizacion = value;
      }
  }
}

private string _ssCuentadeMayor;
public string ssCuentadeMayor{
  get{
      return _ssCuentadeMayor;
  }
  set{
      if((_ssCuentadeMayor!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssCuentadeMayor = value;
      }
  }
}

private string _ssIndicadorICME;
public string ssIndicadorICME{
  get{
      return _ssIndicadorICME;
  }
  set{
      if((_ssIndicadorICME!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssIndicadorICME = value;
      }
  }
}

private decimal _ssImporteenmonedadeldocto;
public decimal ssImporteenmonedadeldocto{
  get{
      return _ssImporteenmonedadeldocto;
  }
  set{
      if((_ssImporteenmonedadeldocto!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssImporteenmonedadeldocto = value;
      }
  }
}

private string _ssCalcularimpuestos;
public string ssCalcularimpuestos{
  get{
      return _ssCalcularimpuestos;
  }
  set{
      if((_ssCalcularimpuestos!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssCalcularimpuestos = value;
      }
  }
}

private string _ssIndicadordeIVA;
public string ssIndicadordeIVA{
  get{
      return _ssIndicadordeIVA;
  }
  set{
      if((_ssIndicadordeIVA!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssIndicadordeIVA = value;
      }
  }
}

private string _ssDivision;
public string ssDivision{
  get{
      return _ssDivision;
  }
  set{
      if((_ssDivision!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssDivision = value;
      }
  }
}

private string _ssCondicionesdepago;
public string ssCondicionesdepago{
  get{
      return _ssCondicionesdepago;
  }
  set{
      if((_ssCondicionesdepago!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssCondicionesdepago = value;
      }
  }
}

private DateTime _ssFechabase;
public DateTime ssFechabase{
  get{
      return _ssFechabase;
  }
  set{
      if((_ssFechabase!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssFechabase = value;
      }
  }
}

private string _ssCentrodecostos;
public string ssCentrodecostos{
  get{
      return _ssCentrodecostos;
  }
  set{
      if((_ssCentrodecostos!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssCentrodecostos = value;
      }
  }
}

private string _ssCentrodebeneficio;
public string ssCentrodebeneficio{
  get{
      return _ssCentrodebeneficio;
  }
  set{
      if((_ssCentrodebeneficio!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssCentrodebeneficio = value;
      }
  }
}

private string _ssNumerodeasignacion;
public string ssNumerodeasignacion{
  get{
      return _ssNumerodeasignacion;
  }
  set{
      if((_ssNumerodeasignacion!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssNumerodeasignacion = value;
      }
  }
}

private string _ssTexto;
public string ssTexto{
  get{
      return _ssTexto;
  }
  set{
      if((_ssTexto!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssTexto = value;
      }
  }
}

private string _ssF_vencimiento;
public string ssF_vencimiento{
  get{
      return _ssF_vencimiento;
  }
  set{
      if((_ssF_vencimiento!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
          _ssF_vencimiento = value;
      }
  }
}

private string _ssF_valor;
public string ssF_valor{
  get{
      return _ssF_valor;
  }
  set{
      if((_ssF_valor!=value) || OptimizedAttributes[26]){
          ChangedAttributes[26] = true;
          _ssF_valor = value;
      }
  }
}

private string _ssV_pago;
public string ssV_pago{
  get{
      return _ssV_pago;
  }
  set{
      if((_ssV_pago!=value) || OptimizedAttributes[27]){
          ChangedAttributes[27] = true;
          _ssV_pago = value;
      }
  }
}

private string _ssNombre;
public string ssNombre{
  get{
      return _ssNombre;
  }
  set{
      if((_ssNombre!=value) || OptimizedAttributes[28]){
          ChangedAttributes[28] = true;
          _ssNombre = value;
      }
  }
}

private string _ssPoblacion;
public string ssPoblacion{
  get{
      return _ssPoblacion;
  }
  set{
      if((_ssPoblacion!=value) || OptimizedAttributes[29]){
          ChangedAttributes[29] = true;
          _ssPoblacion = value;
      }
  }
}

private string _ssClavebanco;
public string ssClavebanco{
  get{
      return _ssClavebanco;
  }
  set{
      if((_ssClavebanco!=value) || OptimizedAttributes[30]){
          ChangedAttributes[30] = true;
          _ssClavebanco = value;
      }
  }
}

private string _ssCta_bancaria;
public string ssCta_bancaria{
  get{
      return _ssCta_bancaria;
  }
  set{
      if((_ssCta_bancaria!=value) || OptimizedAttributes[31]){
          ChangedAttributes[31] = true;
          _ssCta_bancaria = value;
      }
  }
}

private string _ssCuentaalternativa;
public string ssCuentaalternativa{
  get{
      return _ssCuentaalternativa;
  }
  set{
      if((_ssCuentaalternativa!=value) || OptimizedAttributes[32]){
          ChangedAttributes[32] = true;
          _ssCuentaalternativa = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[33]){
          ChangedAttributes[33] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[34]){
          ChangedAttributes[34] = true;
          _ssCreatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord() {
ChangedAttributes = new BitArray(35,true);
OptimizedAttributes = new BitArray(35,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssControldedocumento = 0;
_ssFechadedocumento = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssFechadecontabilizacion = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssClasededocumento = "";
_ssSociedad = "";
_ssMoneda = "";
_ssTipodeCambio = "";
_ssFechadeConversion = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssNumerodeDoc_DeReferencia = "";
_ssTextodeCabeceradeDocumento = "";
_ssClaveContabilizacion = 0;
_ssCuentadeMayor = "";
_ssIndicadorICME = "";
_ssImporteenmonedadeldocto = 0.0M;
_ssCalcularimpuestos = "";
_ssIndicadordeIVA = "";
_ssDivision = "";
_ssCondicionesdepago = "";
_ssFechabase = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCentrodecostos = "";
_ssCentrodebeneficio = "";
_ssNumerodeasignacion = "";
_ssTexto = "";
_ssF_vencimiento = "";
_ssF_valor = "";
_ssV_pago = "";
_ssNombre = "";
_ssPoblacion = "";
_ssClavebanco = "";
_ssCta_bancaria = "";
_ssCuentaalternativa = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssId = r.ReadLongInteger(index++, "InvoiceAccountingEntries.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingEntries.InvoiceId", 0L);
ssControldedocumento = r.ReadInteger(index++, "InvoiceAccountingEntries.Controldedocumento", 0);
ssFechadedocumento = r.ReadDate(index++, "InvoiceAccountingEntries.Fechadedocumento", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFechadecontabilizacion = r.ReadDate(index++, "InvoiceAccountingEntries.Fechadecontabilizacion", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssClasededocumento = r.ReadText(index++, "InvoiceAccountingEntries.Clasededocumento", "");
ssSociedad = r.ReadText(index++, "InvoiceAccountingEntries.Sociedad", "");
ssMoneda = r.ReadText(index++, "InvoiceAccountingEntries.Moneda", "");
ssTipodeCambio = r.ReadText(index++, "InvoiceAccountingEntries.TipodeCambio", "");
ssFechadeConversion = r.ReadDate(index++, "InvoiceAccountingEntries.FechadeConversion", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssNumerodeDoc_DeReferencia = r.ReadText(index++, "InvoiceAccountingEntries.NumerodeDoc_DeReferencia", "");
ssTextodeCabeceradeDocumento = r.ReadText(index++, "InvoiceAccountingEntries.TextodeCabeceradeDocumento", "");
ssClaveContabilizacion = r.ReadInteger(index++, "InvoiceAccountingEntries.ClaveContabilizacion", 0);
ssCuentadeMayor = r.ReadText(index++, "InvoiceAccountingEntries.CuentadeMayor", "");
ssIndicadorICME = r.ReadText(index++, "InvoiceAccountingEntries.IndicadorICME", "");
ssImporteenmonedadeldocto = r.ReadDecimal(index++, "InvoiceAccountingEntries.Importeenmonedadeldocto", 0.0M);
ssCalcularimpuestos = r.ReadText(index++, "InvoiceAccountingEntries.Calcularimpuestos", "");
ssIndicadordeIVA = r.ReadText(index++, "InvoiceAccountingEntries.IndicadordeIVA", "");
ssDivision = r.ReadText(index++, "InvoiceAccountingEntries.Division", "");
ssCondicionesdepago = r.ReadText(index++, "InvoiceAccountingEntries.Condicionesdepago", "");
ssFechabase = r.ReadDate(index++, "InvoiceAccountingEntries.Fechabase", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCentrodecostos = r.ReadText(index++, "InvoiceAccountingEntries.Centrodecostos", "");
ssCentrodebeneficio = r.ReadText(index++, "InvoiceAccountingEntries.Centrodebeneficio", "");
ssNumerodeasignacion = r.ReadText(index++, "InvoiceAccountingEntries.Numerodeasignacion", "");
ssTexto = r.ReadText(index++, "InvoiceAccountingEntries.Texto", "");
ssF_vencimiento = r.ReadText(index++, "InvoiceAccountingEntries.F_vencimiento", "");
ssF_valor = r.ReadText(index++, "InvoiceAccountingEntries.F_valor", "");
ssV_pago = r.ReadText(index++, "InvoiceAccountingEntries.V_pago", "");
ssNombre = r.ReadText(index++, "InvoiceAccountingEntries.Nombre", "");
ssPoblacion = r.ReadText(index++, "InvoiceAccountingEntries.Poblacion", "");
ssClavebanco = r.ReadText(index++, "InvoiceAccountingEntries.Clavebanco", "");
ssCta_bancaria = r.ReadText(index++, "InvoiceAccountingEntries.Cta_bancaria", "");
ssCuentaalternativa = r.ReadText(index++, "InvoiceAccountingEntries.Cuentaalternativa", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceAccountingEntries.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "InvoiceAccountingEntries.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(35,false);
OptimizedAttributes = new BitArray(35,false);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord r) {
this = r;
}


public static bool operator == (EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord a, EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssControldedocumento != b.ssControldedocumento) return false;
if (a.ssFechadedocumento != b.ssFechadedocumento) return false;
if (a.ssFechadecontabilizacion != b.ssFechadecontabilizacion) return false;
if (a.ssClasededocumento != b.ssClasededocumento) return false;
if (a.ssSociedad != b.ssSociedad) return false;
if (a.ssMoneda != b.ssMoneda) return false;
if (a.ssTipodeCambio != b.ssTipodeCambio) return false;
if (a.ssFechadeConversion != b.ssFechadeConversion) return false;
if (a.ssNumerodeDoc_DeReferencia != b.ssNumerodeDoc_DeReferencia) return false;
if (a.ssTextodeCabeceradeDocumento != b.ssTextodeCabeceradeDocumento) return false;
if (a.ssClaveContabilizacion != b.ssClaveContabilizacion) return false;
if (a.ssCuentadeMayor != b.ssCuentadeMayor) return false;
if (a.ssIndicadorICME != b.ssIndicadorICME) return false;
if (a.ssImporteenmonedadeldocto != b.ssImporteenmonedadeldocto) return false;
if (a.ssCalcularimpuestos != b.ssCalcularimpuestos) return false;
if (a.ssIndicadordeIVA != b.ssIndicadordeIVA) return false;
if (a.ssDivision != b.ssDivision) return false;
if (a.ssCondicionesdepago != b.ssCondicionesdepago) return false;
if (a.ssFechabase != b.ssFechabase) return false;
if (a.ssCentrodecostos != b.ssCentrodecostos) return false;
if (a.ssCentrodebeneficio != b.ssCentrodebeneficio) return false;
if (a.ssNumerodeasignacion != b.ssNumerodeasignacion) return false;
if (a.ssTexto != b.ssTexto) return false;
if (a.ssF_vencimiento != b.ssF_vencimiento) return false;
if (a.ssF_valor != b.ssF_valor) return false;
if (a.ssV_pago != b.ssV_pago) return false;
if (a.ssNombre != b.ssNombre) return false;
if (a.ssPoblacion != b.ssPoblacion) return false;
if (a.ssClavebanco != b.ssClavebanco) return false;
if (a.ssCta_bancaria != b.ssCta_bancaria) return false;
if (a.ssCuentaalternativa != b.ssCuentaalternativa) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
return true;
}

public static bool operator != (EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord a, EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord)) return false;
return (this == (EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssControldedocumento.GetHashCode()
 ^ ssFechadedocumento.GetHashCode()
 ^ ssFechadecontabilizacion.GetHashCode()
 ^ ssClasededocumento.GetHashCode()
 ^ ssSociedad.GetHashCode()
 ^ ssMoneda.GetHashCode()
 ^ ssTipodeCambio.GetHashCode()
 ^ ssFechadeConversion.GetHashCode()
 ^ ssNumerodeDoc_DeReferencia.GetHashCode()
 ^ ssTextodeCabeceradeDocumento.GetHashCode()
 ^ ssClaveContabilizacion.GetHashCode()
 ^ ssCuentadeMayor.GetHashCode()
 ^ ssIndicadorICME.GetHashCode()
 ^ ssImporteenmonedadeldocto.GetHashCode()
 ^ ssCalcularimpuestos.GetHashCode()
 ^ ssIndicadordeIVA.GetHashCode()
 ^ ssDivision.GetHashCode()
 ^ ssCondicionesdepago.GetHashCode()
 ^ ssFechabase.GetHashCode()
 ^ ssCentrodecostos.GetHashCode()
 ^ ssCentrodebeneficio.GetHashCode()
 ^ ssNumerodeasignacion.GetHashCode()
 ^ ssTexto.GetHashCode()
 ^ ssF_vencimiento.GetHashCode()
 ^ ssF_valor.GetHashCode()
 ^ ssV_pago.GetHashCode()
 ^ ssNombre.GetHashCode()
 ^ ssPoblacion.GetHashCode()
 ^ ssClavebanco.GetHashCode()
 ^ ssCta_bancaria.GetHashCode()
 ^ ssCuentaalternativa.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord Duplicate() {
EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssControldedocumento = this._ssControldedocumento;
t._ssFechadedocumento = this._ssFechadedocumento;
t._ssFechadecontabilizacion = this._ssFechadecontabilizacion;
t._ssClasededocumento = this._ssClasededocumento;
t._ssSociedad = this._ssSociedad;
t._ssMoneda = this._ssMoneda;
t._ssTipodeCambio = this._ssTipodeCambio;
t._ssFechadeConversion = this._ssFechadeConversion;
t._ssNumerodeDoc_DeReferencia = this._ssNumerodeDoc_DeReferencia;
t._ssTextodeCabeceradeDocumento = this._ssTextodeCabeceradeDocumento;
t._ssClaveContabilizacion = this._ssClaveContabilizacion;
t._ssCuentadeMayor = this._ssCuentadeMayor;
t._ssIndicadorICME = this._ssIndicadorICME;
t._ssImporteenmonedadeldocto = this._ssImporteenmonedadeldocto;
t._ssCalcularimpuestos = this._ssCalcularimpuestos;
t._ssIndicadordeIVA = this._ssIndicadordeIVA;
t._ssDivision = this._ssDivision;
t._ssCondicionesdepago = this._ssCondicionesdepago;
t._ssFechabase = this._ssFechabase;
t._ssCentrodecostos = this._ssCentrodecostos;
t._ssCentrodebeneficio = this._ssCentrodebeneficio;
t._ssNumerodeasignacion = this._ssNumerodeasignacion;
t._ssTexto = this._ssTexto;
t._ssF_vencimiento = this._ssF_vencimiento;
t._ssF_valor = this._ssF_valor;
t._ssV_pago = this._ssV_pago;
t._ssNombre = this._ssNombre;
t._ssPoblacion = this._ssPoblacion;
t._ssClavebanco = this._ssClavebanco;
t._ssCta_bancaria = this._ssCta_bancaria;
t._ssCuentaalternativa = this._ssCuentaalternativa;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t.ChangedAttributes = new BitArray(35);
t.OptimizedAttributes = new BitArray(35);
for(int i = 0; i < 35; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "controldedocumento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Controldedocumento")) variable.Value = ssControldedocumento; else variable.Optimized = true;
} else if (head == "fechadedocumento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fechadedocumento")) variable.Value = ssFechadedocumento; else variable.Optimized = true;
} else if (head == "fechadecontabilizacion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fechadecontabilizacion")) variable.Value = ssFechadecontabilizacion; else variable.Optimized = true;
} else if (head == "clasededocumento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Clasededocumento")) variable.Value = ssClasededocumento; else variable.Optimized = true;
} else if (head == "sociedad") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sociedad")) variable.Value = ssSociedad; else variable.Optimized = true;
} else if (head == "moneda") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Moneda")) variable.Value = ssMoneda; else variable.Optimized = true;
} else if (head == "tipodecambio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TipodeCambio")) variable.Value = ssTipodeCambio; else variable.Optimized = true;
} else if (head == "fechadeconversion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FechadeConversion")) variable.Value = ssFechadeConversion; else variable.Optimized = true;
} else if (head == "numerodedoc_dereferencia") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NumerodeDoc_DeReferencia")) variable.Value = ssNumerodeDoc_DeReferencia; else variable.Optimized = true;
} else if (head == "textodecabeceradedocumento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TextodeCabeceradeDocumento")) variable.Value = ssTextodeCabeceradeDocumento; else variable.Optimized = true;
} else if (head == "clavecontabilizacion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ClaveContabilizacion")) variable.Value = ssClaveContabilizacion; else variable.Optimized = true;
} else if (head == "cuentademayor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CuentadeMayor")) variable.Value = ssCuentadeMayor; else variable.Optimized = true;
} else if (head == "indicadoricme") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IndicadorICME")) variable.Value = ssIndicadorICME; else variable.Optimized = true;
} else if (head == "importeenmonedadeldocto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Importeenmonedadeldocto")) variable.Value = ssImporteenmonedadeldocto; else variable.Optimized = true;
} else if (head == "calcularimpuestos") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Calcularimpuestos")) variable.Value = ssCalcularimpuestos; else variable.Optimized = true;
} else if (head == "indicadordeiva") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IndicadordeIVA")) variable.Value = ssIndicadordeIVA; else variable.Optimized = true;
} else if (head == "division") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Division")) variable.Value = ssDivision; else variable.Optimized = true;
} else if (head == "condicionesdepago") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Condicionesdepago")) variable.Value = ssCondicionesdepago; else variable.Optimized = true;
} else if (head == "fechabase") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fechabase")) variable.Value = ssFechabase; else variable.Optimized = true;
} else if (head == "centrodecostos") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Centrodecostos")) variable.Value = ssCentrodecostos; else variable.Optimized = true;
} else if (head == "centrodebeneficio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Centrodebeneficio")) variable.Value = ssCentrodebeneficio; else variable.Optimized = true;
} else if (head == "numerodeasignacion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Numerodeasignacion")) variable.Value = ssNumerodeasignacion; else variable.Optimized = true;
} else if (head == "texto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Texto")) variable.Value = ssTexto; else variable.Optimized = true;
} else if (head == "f_vencimiento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".F_vencimiento")) variable.Value = ssF_vencimiento; else variable.Optimized = true;
} else if (head == "f_valor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".F_valor")) variable.Value = ssF_valor; else variable.Optimized = true;
} else if (head == "v_pago") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".V_pago")) variable.Value = ssV_pago; else variable.Optimized = true;
} else if (head == "nombre") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Nombre")) variable.Value = ssNombre; else variable.Optimized = true;
} else if (head == "poblacion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Poblacion")) variable.Value = ssPoblacion; else variable.Optimized = true;
} else if (head == "clavebanco") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Clavebanco")) variable.Value = ssClavebanco; else variable.Optimized = true;
} else if (head == "cta_bancaria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cta_bancaria")) variable.Value = ssCta_bancaria; else variable.Optimized = true;
} else if (head == "cuentaalternativa") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cuentaalternativa")) variable.Value = ssCuentaalternativa; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdControldedocumento)) {
return ChangedAttributes[2];
}
if (key.Equals(IdFechadedocumento)) {
return ChangedAttributes[3];
}
if (key.Equals(IdFechadecontabilizacion)) {
return ChangedAttributes[4];
}
if (key.Equals(IdClasededocumento)) {
return ChangedAttributes[5];
}
if (key.Equals(IdSociedad)) {
return ChangedAttributes[6];
}
if (key.Equals(IdMoneda)) {
return ChangedAttributes[7];
}
if (key.Equals(IdTipodeCambio)) {
return ChangedAttributes[8];
}
if (key.Equals(IdFechadeConversion)) {
return ChangedAttributes[9];
}
if (key.Equals(IdNumerodeDoc_DeReferencia)) {
return ChangedAttributes[10];
}
if (key.Equals(IdTextodeCabeceradeDocumento)) {
return ChangedAttributes[11];
}
if (key.Equals(IdClaveContabilizacion)) {
return ChangedAttributes[12];
}
if (key.Equals(IdCuentadeMayor)) {
return ChangedAttributes[13];
}
if (key.Equals(IdIndicadorICME)) {
return ChangedAttributes[14];
}
if (key.Equals(IdImporteenmonedadeldocto)) {
return ChangedAttributes[15];
}
if (key.Equals(IdCalcularimpuestos)) {
return ChangedAttributes[16];
}
if (key.Equals(IdIndicadordeIVA)) {
return ChangedAttributes[17];
}
if (key.Equals(IdDivision)) {
return ChangedAttributes[18];
}
if (key.Equals(IdCondicionesdepago)) {
return ChangedAttributes[19];
}
if (key.Equals(IdFechabase)) {
return ChangedAttributes[20];
}
if (key.Equals(IdCentrodecostos)) {
return ChangedAttributes[21];
}
if (key.Equals(IdCentrodebeneficio)) {
return ChangedAttributes[22];
}
if (key.Equals(IdNumerodeasignacion)) {
return ChangedAttributes[23];
}
if (key.Equals(IdTexto)) {
return ChangedAttributes[24];
}
if (key.Equals(IdF_vencimiento)) {
return ChangedAttributes[25];
}
if (key.Equals(IdF_valor)) {
return ChangedAttributes[26];
}
if (key.Equals(IdV_pago)) {
return ChangedAttributes[27];
}
if (key.Equals(IdNombre)) {
return ChangedAttributes[28];
}
if (key.Equals(IdPoblacion)) {
return ChangedAttributes[29];
}
if (key.Equals(IdClavebanco)) {
return ChangedAttributes[30];
}
if (key.Equals(IdCta_bancaria)) {
return ChangedAttributes[31];
}
if (key.Equals(IdCuentaalternativa)) {
return ChangedAttributes[32];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[33];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[34];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdControldedocumento)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdFechadedocumento)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdFechadecontabilizacion)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdClasededocumento)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdSociedad)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdMoneda)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdTipodeCambio)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdFechadeConversion)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdNumerodeDoc_DeReferencia)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdTextodeCabeceradeDocumento)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdClaveContabilizacion)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdCuentadeMayor)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdIndicadorICME)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdImporteenmonedadeldocto)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdCalcularimpuestos)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdIndicadordeIVA)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdDivision)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdCondicionesdepago)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdFechabase)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdCentrodecostos)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdCentrodebeneficio)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdNumerodeasignacion)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdTexto)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdF_vencimiento)) {
return OptimizedAttributes[25];
}
if (key.Equals(IdF_valor)) {
return OptimizedAttributes[26];
}
if (key.Equals(IdV_pago)) {
return OptimizedAttributes[27];
}
if (key.Equals(IdNombre)) {
return OptimizedAttributes[28];
}
if (key.Equals(IdPoblacion)) {
return OptimizedAttributes[29];
}
if (key.Equals(IdClavebanco)) {
return OptimizedAttributes[30];
}
if (key.Equals(IdCta_bancaria)) {
return OptimizedAttributes[31];
}
if (key.Equals(IdCuentaalternativa)) {
return OptimizedAttributes[32];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[33];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[34];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdControldedocumento) {
return ssControldedocumento;
}
if (key == IdFechadedocumento) {
return ssFechadedocumento;
}
if (key == IdFechadecontabilizacion) {
return ssFechadecontabilizacion;
}
if (key == IdClasededocumento) {
return ssClasededocumento;
}
if (key == IdSociedad) {
return ssSociedad;
}
if (key == IdMoneda) {
return ssMoneda;
}
if (key == IdTipodeCambio) {
return ssTipodeCambio;
}
if (key == IdFechadeConversion) {
return ssFechadeConversion;
}
if (key == IdNumerodeDoc_DeReferencia) {
return ssNumerodeDoc_DeReferencia;
}
if (key == IdTextodeCabeceradeDocumento) {
return ssTextodeCabeceradeDocumento;
}
if (key == IdClaveContabilizacion) {
return ssClaveContabilizacion;
}
if (key == IdCuentadeMayor) {
return ssCuentadeMayor;
}
if (key == IdIndicadorICME) {
return ssIndicadorICME;
}
if (key == IdImporteenmonedadeldocto) {
return ssImporteenmonedadeldocto;
}
if (key == IdCalcularimpuestos) {
return ssCalcularimpuestos;
}
if (key == IdIndicadordeIVA) {
return ssIndicadordeIVA;
}
if (key == IdDivision) {
return ssDivision;
}
if (key == IdCondicionesdepago) {
return ssCondicionesdepago;
}
if (key == IdFechabase) {
return ssFechabase;
}
if (key == IdCentrodecostos) {
return ssCentrodecostos;
}
if (key == IdCentrodebeneficio) {
return ssCentrodebeneficio;
}
if (key == IdNumerodeasignacion) {
return ssNumerodeasignacion;
}
if (key == IdTexto) {
return ssTexto;
}
if (key == IdF_vencimiento) {
return ssF_vencimiento;
}
if (key == IdF_valor) {
return ssF_valor;
}
if (key == IdV_pago) {
return ssV_pago;
}
if (key == IdNombre) {
return ssNombre;
}
if (key == IdPoblacion) {
return ssPoblacion;
}
if (key == IdClavebanco) {
return ssClavebanco;
}
if (key == IdCta_bancaria) {
return ssCta_bancaria;
}
if (key == IdCuentaalternativa) {
return ssCuentaalternativa;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdControldedocumento.Key.AsGuid) {
return ssControldedocumento;
}
if (attributeKey == IdFechadedocumento.Key.AsGuid) {
return ssFechadedocumento;
}
if (attributeKey == IdFechadecontabilizacion.Key.AsGuid) {
return ssFechadecontabilizacion;
}
if (attributeKey == IdClasededocumento.Key.AsGuid) {
return ssClasededocumento;
}
if (attributeKey == IdSociedad.Key.AsGuid) {
return ssSociedad;
}
if (attributeKey == IdMoneda.Key.AsGuid) {
return ssMoneda;
}
if (attributeKey == IdTipodeCambio.Key.AsGuid) {
return ssTipodeCambio;
}
if (attributeKey == IdFechadeConversion.Key.AsGuid) {
return ssFechadeConversion;
}
if (attributeKey == IdNumerodeDoc_DeReferencia.Key.AsGuid) {
return ssNumerodeDoc_DeReferencia;
}
if (attributeKey == IdTextodeCabeceradeDocumento.Key.AsGuid) {
return ssTextodeCabeceradeDocumento;
}
if (attributeKey == IdClaveContabilizacion.Key.AsGuid) {
return ssClaveContabilizacion;
}
if (attributeKey == IdCuentadeMayor.Key.AsGuid) {
return ssCuentadeMayor;
}
if (attributeKey == IdIndicadorICME.Key.AsGuid) {
return ssIndicadorICME;
}
if (attributeKey == IdImporteenmonedadeldocto.Key.AsGuid) {
return ssImporteenmonedadeldocto;
}
if (attributeKey == IdCalcularimpuestos.Key.AsGuid) {
return ssCalcularimpuestos;
}
if (attributeKey == IdIndicadordeIVA.Key.AsGuid) {
return ssIndicadordeIVA;
}
if (attributeKey == IdDivision.Key.AsGuid) {
return ssDivision;
}
if (attributeKey == IdCondicionesdepago.Key.AsGuid) {
return ssCondicionesdepago;
}
if (attributeKey == IdFechabase.Key.AsGuid) {
return ssFechabase;
}
if (attributeKey == IdCentrodecostos.Key.AsGuid) {
return ssCentrodecostos;
}
if (attributeKey == IdCentrodebeneficio.Key.AsGuid) {
return ssCentrodebeneficio;
}
if (attributeKey == IdNumerodeasignacion.Key.AsGuid) {
return ssNumerodeasignacion;
}
if (attributeKey == IdTexto.Key.AsGuid) {
return ssTexto;
}
if (attributeKey == IdF_vencimiento.Key.AsGuid) {
return ssF_vencimiento;
}
if (attributeKey == IdF_valor.Key.AsGuid) {
return ssF_valor;
}
if (attributeKey == IdV_pago.Key.AsGuid) {
return ssV_pago;
}
if (attributeKey == IdNombre.Key.AsGuid) {
return ssNombre;
}
if (attributeKey == IdPoblacion.Key.AsGuid) {
return ssPoblacion;
}
if (attributeKey == IdClavebanco.Key.AsGuid) {
return ssClavebanco;
}
if (attributeKey == IdCta_bancaria.Key.AsGuid) {
return ssCta_bancaria;
}
if (attributeKey == IdCuentaalternativa.Key.AsGuid) {
return ssCuentaalternativa;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(35);
OptimizedAttributes = new BitArray(35);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssControldedocumento = (int) other.AttributeGet(IdControldedocumento);
ChangedAttributes[2] = other.ChangedAttributeGet(IdControldedocumento);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdControldedocumento);
ssFechadedocumento = (DateTime) other.AttributeGet(IdFechadedocumento);
ChangedAttributes[3] = other.ChangedAttributeGet(IdFechadedocumento);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdFechadedocumento);
ssFechadecontabilizacion = (DateTime) other.AttributeGet(IdFechadecontabilizacion);
ChangedAttributes[4] = other.ChangedAttributeGet(IdFechadecontabilizacion);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdFechadecontabilizacion);
ssClasededocumento = (string) other.AttributeGet(IdClasededocumento);
ChangedAttributes[5] = other.ChangedAttributeGet(IdClasededocumento);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdClasededocumento);
ssSociedad = (string) other.AttributeGet(IdSociedad);
ChangedAttributes[6] = other.ChangedAttributeGet(IdSociedad);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdSociedad);
ssMoneda = (string) other.AttributeGet(IdMoneda);
ChangedAttributes[7] = other.ChangedAttributeGet(IdMoneda);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdMoneda);
ssTipodeCambio = (string) other.AttributeGet(IdTipodeCambio);
ChangedAttributes[8] = other.ChangedAttributeGet(IdTipodeCambio);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdTipodeCambio);
ssFechadeConversion = (DateTime) other.AttributeGet(IdFechadeConversion);
ChangedAttributes[9] = other.ChangedAttributeGet(IdFechadeConversion);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdFechadeConversion);
ssNumerodeDoc_DeReferencia = (string) other.AttributeGet(IdNumerodeDoc_DeReferencia);
ChangedAttributes[10] = other.ChangedAttributeGet(IdNumerodeDoc_DeReferencia);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdNumerodeDoc_DeReferencia);
ssTextodeCabeceradeDocumento = (string) other.AttributeGet(IdTextodeCabeceradeDocumento);
ChangedAttributes[11] = other.ChangedAttributeGet(IdTextodeCabeceradeDocumento);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdTextodeCabeceradeDocumento);
ssClaveContabilizacion = (int) other.AttributeGet(IdClaveContabilizacion);
ChangedAttributes[12] = other.ChangedAttributeGet(IdClaveContabilizacion);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdClaveContabilizacion);
ssCuentadeMayor = (string) other.AttributeGet(IdCuentadeMayor);
ChangedAttributes[13] = other.ChangedAttributeGet(IdCuentadeMayor);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdCuentadeMayor);
ssIndicadorICME = (string) other.AttributeGet(IdIndicadorICME);
ChangedAttributes[14] = other.ChangedAttributeGet(IdIndicadorICME);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdIndicadorICME);
ssImporteenmonedadeldocto = (decimal) other.AttributeGet(IdImporteenmonedadeldocto);
ChangedAttributes[15] = other.ChangedAttributeGet(IdImporteenmonedadeldocto);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdImporteenmonedadeldocto);
ssCalcularimpuestos = (string) other.AttributeGet(IdCalcularimpuestos);
ChangedAttributes[16] = other.ChangedAttributeGet(IdCalcularimpuestos);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdCalcularimpuestos);
ssIndicadordeIVA = (string) other.AttributeGet(IdIndicadordeIVA);
ChangedAttributes[17] = other.ChangedAttributeGet(IdIndicadordeIVA);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdIndicadordeIVA);
ssDivision = (string) other.AttributeGet(IdDivision);
ChangedAttributes[18] = other.ChangedAttributeGet(IdDivision);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdDivision);
ssCondicionesdepago = (string) other.AttributeGet(IdCondicionesdepago);
ChangedAttributes[19] = other.ChangedAttributeGet(IdCondicionesdepago);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdCondicionesdepago);
ssFechabase = (DateTime) other.AttributeGet(IdFechabase);
ChangedAttributes[20] = other.ChangedAttributeGet(IdFechabase);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdFechabase);
ssCentrodecostos = (string) other.AttributeGet(IdCentrodecostos);
ChangedAttributes[21] = other.ChangedAttributeGet(IdCentrodecostos);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdCentrodecostos);
ssCentrodebeneficio = (string) other.AttributeGet(IdCentrodebeneficio);
ChangedAttributes[22] = other.ChangedAttributeGet(IdCentrodebeneficio);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdCentrodebeneficio);
ssNumerodeasignacion = (string) other.AttributeGet(IdNumerodeasignacion);
ChangedAttributes[23] = other.ChangedAttributeGet(IdNumerodeasignacion);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdNumerodeasignacion);
ssTexto = (string) other.AttributeGet(IdTexto);
ChangedAttributes[24] = other.ChangedAttributeGet(IdTexto);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdTexto);
ssF_vencimiento = (string) other.AttributeGet(IdF_vencimiento);
ChangedAttributes[25] = other.ChangedAttributeGet(IdF_vencimiento);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdF_vencimiento);
ssF_valor = (string) other.AttributeGet(IdF_valor);
ChangedAttributes[26] = other.ChangedAttributeGet(IdF_valor);
OptimizedAttributes[26] = other.OptimizedAttributeGet(IdF_valor);
ssV_pago = (string) other.AttributeGet(IdV_pago);
ChangedAttributes[27] = other.ChangedAttributeGet(IdV_pago);
OptimizedAttributes[27] = other.OptimizedAttributeGet(IdV_pago);
ssNombre = (string) other.AttributeGet(IdNombre);
ChangedAttributes[28] = other.ChangedAttributeGet(IdNombre);
OptimizedAttributes[28] = other.OptimizedAttributeGet(IdNombre);
ssPoblacion = (string) other.AttributeGet(IdPoblacion);
ChangedAttributes[29] = other.ChangedAttributeGet(IdPoblacion);
OptimizedAttributes[29] = other.OptimizedAttributeGet(IdPoblacion);
ssClavebanco = (string) other.AttributeGet(IdClavebanco);
ChangedAttributes[30] = other.ChangedAttributeGet(IdClavebanco);
OptimizedAttributes[30] = other.OptimizedAttributeGet(IdClavebanco);
ssCta_bancaria = (string) other.AttributeGet(IdCta_bancaria);
ChangedAttributes[31] = other.ChangedAttributeGet(IdCta_bancaria);
OptimizedAttributes[31] = other.OptimizedAttributeGet(IdCta_bancaria);
ssCuentaalternativa = (string) other.AttributeGet(IdCuentaalternativa);
ChangedAttributes[32] = other.ChangedAttributeGet(IdCuentaalternativa);
OptimizedAttributes[32] = other.OptimizedAttributeGet(IdCuentaalternativa);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[33] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[33] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[34] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[34] = other.OptimizedAttributeGet(IdCreatedOn);
}
} // EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord

/// <summary>
/// RecordList type <code>InvoiceAccountingEntriesList</code> that represents a record list of
///  <code>InvoiceAccountingEntries</code>
/// </summary>
public partial class RL_0704e14bc1b3305d76f59d709913c287 : GenericRecordList<EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord>, IEnumerable, IEnumerator {

protected override EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord GetElementDefaultValue() {
return new EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord();
}

public T[] ToArray<T>(Func<EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0704e14bc1b3305d76f59d709913c287 recordList, Func<EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0704e14bc1b3305d76f59d709913c287(EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord[] array) {
  RL_0704e14bc1b3305d76f59d709913c287 result = new RL_0704e14bc1b3305d76f59d709913c287();
result.InnerFromArray(array);
    return result;
}

public static RL_0704e14bc1b3305d76f59d709913c287 ToList<T>(T[] array, Func <T, EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord> converter) {
  RL_0704e14bc1b3305d76f59d709913c287 result = new RL_0704e14bc1b3305d76f59d709913c287();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0704e14bc1b3305d76f59d709913c287 FromRestList<T>(RestList<T> restList, Func <T, EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord> converter) {
  RL_0704e14bc1b3305d76f59d709913c287 result = new RL_0704e14bc1b3305d76f59d709913c287();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0704e14bc1b3305d76f59d709913c287() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord> NewList() {
return new RL_0704e14bc1b3305d76f59d709913c287();
}


} // RL_0704e14bc1b3305d76f59d709913c287
}
