using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtended (6oFV_4zXdU6AtNF1hD2OaQ)
///  <code>EN_f81a3d226103fd013068b8763798067aEntityRecord</code> that represent
/// s <code>InvoiceExtended</code> <p>Description: Invoice data from the XML file.</p>
/// </summary>
// Name: InvoiceExtended
public partial struct EN_f81a3d226103fd013068b8763798067aEntityRecord : ITypedRecord<EN_f81a3d226103fd013068b8763798067aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sql7+NTzbUWAYUFTStRU6g");
internal static readonly GlobalObjectKey IdVersion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zfqdxDzp10y8qlMhzdECxA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7ulDMMd86Umkkh3Xy_Jobg");
internal static readonly GlobalObjectKey IdSerie = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mgHuXK0m3UqCY2owf4QrbQ");
internal static readonly GlobalObjectKey IdFechaEmision = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6ruFEZd5q0yJm6JGb1snCw");
internal static readonly GlobalObjectKey IdFormaPago = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*P5bDYFHvbkeIXXneNlF00w");
internal static readonly GlobalObjectKey IdMetodoPago = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YhDHEiTkqkWB_9q49gKAKg");
internal static readonly GlobalObjectKey IdLugarExpedicion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VZH_v9PtlkmWZIcjQEjJgQ");
internal static readonly GlobalObjectKey IdSubtotal = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_COrSH+osEejqUim5abhVQ");
internal static readonly GlobalObjectKey IdDescuento = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pZurmcRgDEqrOFIpJ71zkg");
internal static readonly GlobalObjectKey IdTotalIVA = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*B+EXijtqkUyiFEnrLDCPTA");
internal static readonly GlobalObjectKey IdRetenciones = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*baSpmUs1PEmkKBnH7884GQ");
internal static readonly GlobalObjectKey IdTotal = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rXnjSOhVYE2M0993puyS9A");
internal static readonly GlobalObjectKey IdTipoComprobante = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KVmBvDF+2UGF1Byp0TWLrg");
internal static readonly GlobalObjectKey IdMoneda = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ocSf2mE7y0yrl983E09VmQ");
internal static readonly GlobalObjectKey IdTipoCambio = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YLJdCx3UYEuXSSvDII1_vQ");
internal static readonly GlobalObjectKey IdUsoCFDI = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZtTOYmqspkC1+BFNWCkzvw");
internal static readonly GlobalObjectKey IdExportacion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZKhsG0vrIkWRx+S9+iSG5g");
internal static readonly GlobalObjectKey IdUUID = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zqkPqfa4IUOsNtTb9cN0GQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(19,true);
          _ssId = value;
      }
  }
}

private string _ssVersion;
public string ssVersion{
  get{
      return _ssVersion;
  }
  set{
      if((_ssVersion!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssVersion = value;
      }
  }
}

private string _ssFolio;
public string ssFolio{
  get{
      return _ssFolio;
  }
  set{
      if((_ssFolio!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssFolio = value;
      }
  }
}

private string _ssSerie;
public string ssSerie{
  get{
      return _ssSerie;
  }
  set{
      if((_ssSerie!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssSerie = value;
      }
  }
}

private string _ssFechaEmision;
public string ssFechaEmision{
  get{
      return _ssFechaEmision;
  }
  set{
      if((_ssFechaEmision!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssFechaEmision = value;
      }
  }
}

private string _ssFormaPago;
public string ssFormaPago{
  get{
      return _ssFormaPago;
  }
  set{
      if((_ssFormaPago!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssFormaPago = value;
      }
  }
}

private string _ssMetodoPago;
public string ssMetodoPago{
  get{
      return _ssMetodoPago;
  }
  set{
      if((_ssMetodoPago!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssMetodoPago = value;
      }
  }
}

private string _ssLugarExpedicion;
public string ssLugarExpedicion{
  get{
      return _ssLugarExpedicion;
  }
  set{
      if((_ssLugarExpedicion!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssLugarExpedicion = value;
      }
  }
}

private decimal _ssSubtotal;
public decimal ssSubtotal{
  get{
      return _ssSubtotal;
  }
  set{
      if((_ssSubtotal!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssSubtotal = value;
      }
  }
}

private decimal _ssDescuento;
public decimal ssDescuento{
  get{
      return _ssDescuento;
  }
  set{
      if((_ssDescuento!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssDescuento = value;
      }
  }
}

private decimal _ssTotalIVA;
public decimal ssTotalIVA{
  get{
      return _ssTotalIVA;
  }
  set{
      if((_ssTotalIVA!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssTotalIVA = value;
      }
  }
}

private decimal _ssRetenciones;
public decimal ssRetenciones{
  get{
      return _ssRetenciones;
  }
  set{
      if((_ssRetenciones!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssRetenciones = value;
      }
  }
}

private decimal _ssTotal;
public decimal ssTotal{
  get{
      return _ssTotal;
  }
  set{
      if((_ssTotal!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssTotal = value;
      }
  }
}

private string _ssTipoComprobante;
public string ssTipoComprobante{
  get{
      return _ssTipoComprobante;
  }
  set{
      if((_ssTipoComprobante!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssTipoComprobante = value;
      }
  }
}

private string _ssMoneda;
public string ssMoneda{
  get{
      return _ssMoneda;
  }
  set{
      if((_ssMoneda!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssMoneda = value;
      }
  }
}

private decimal _ssTipoCambio;
public decimal ssTipoCambio{
  get{
      return _ssTipoCambio;
  }
  set{
      if((_ssTipoCambio!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssTipoCambio = value;
      }
  }
}

private string _ssUsoCFDI;
public string ssUsoCFDI{
  get{
      return _ssUsoCFDI;
  }
  set{
      if((_ssUsoCFDI!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssUsoCFDI = value;
      }
  }
}

private string _ssExportacion;
public string ssExportacion{
  get{
      return _ssExportacion;
  }
  set{
      if((_ssExportacion!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssExportacion = value;
      }
  }
}

private string _ssUUID;
public string ssUUID{
  get{
      return _ssUUID;
  }
  set{
      if((_ssUUID!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssUUID = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_f81a3d226103fd013068b8763798067aEntityRecord() {
ChangedAttributes = new BitArray(19,true);
OptimizedAttributes = new BitArray(19,false);
_ssId = 0L;
_ssVersion = "";
_ssFolio = "";
_ssSerie = "";
_ssFechaEmision = "";
_ssFormaPago = "";
_ssMetodoPago = "";
_ssLugarExpedicion = "";
_ssSubtotal = 0.0M;
_ssDescuento = 0.0M;
_ssTotalIVA = 0.0M;
_ssRetenciones = 0.0M;
_ssTotal = 0.0M;
_ssTipoComprobante = "";
_ssMoneda = "";
_ssTipoCambio = 0.0M;
_ssUsoCFDI = "";
_ssExportacion = "";
_ssUUID = "";
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
ssId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtended.Id", 0L);
ssVersion = r.ReadText(index++, "InvoiceExtended.Version", "");
ssFolio = r.ReadText(index++, "InvoiceExtended.Folio", "");
ssSerie = r.ReadText(index++, "InvoiceExtended.Serie", "");
ssFechaEmision = r.ReadText(index++, "InvoiceExtended.FechaEmision", "");
ssFormaPago = r.ReadText(index++, "InvoiceExtended.FormaPago", "");
ssMetodoPago = r.ReadText(index++, "InvoiceExtended.MetodoPago", "");
ssLugarExpedicion = r.ReadText(index++, "InvoiceExtended.LugarExpedicion", "");
ssSubtotal = r.ReadDecimal(index++, "InvoiceExtended.Subtotal", 0.0M);
ssDescuento = r.ReadDecimal(index++, "InvoiceExtended.Descuento", 0.0M);
ssTotalIVA = r.ReadDecimal(index++, "InvoiceExtended.TotalIVA", 0.0M);
ssRetenciones = r.ReadDecimal(index++, "InvoiceExtended.Retenciones", 0.0M);
ssTotal = r.ReadDecimal(index++, "InvoiceExtended.Total", 0.0M);
ssTipoComprobante = r.ReadText(index++, "InvoiceExtended.TipoComprobante", "");
ssMoneda = r.ReadText(index++, "InvoiceExtended.Moneda", "");
ssTipoCambio = r.ReadDecimal(index++, "InvoiceExtended.TipoCambio", 0.0M);
ssUsoCFDI = r.ReadText(index++, "InvoiceExtended.UsoCFDI", "");
ssExportacion = r.ReadText(index++, "InvoiceExtended.Exportacion", "");
ssUUID = r.ReadText(index++, "InvoiceExtended.UUID", "");
ChangedAttributes = new BitArray(19,false);
OptimizedAttributes = new BitArray(19,false);
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
public void ReadIM(EN_f81a3d226103fd013068b8763798067aEntityRecord r) {
this = r;
}


public static bool operator == (EN_f81a3d226103fd013068b8763798067aEntityRecord a, EN_f81a3d226103fd013068b8763798067aEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssVersion != b.ssVersion) return false;
if (a.ssFolio != b.ssFolio) return false;
if (a.ssSerie != b.ssSerie) return false;
if (a.ssFechaEmision != b.ssFechaEmision) return false;
if (a.ssFormaPago != b.ssFormaPago) return false;
if (a.ssMetodoPago != b.ssMetodoPago) return false;
if (a.ssLugarExpedicion != b.ssLugarExpedicion) return false;
if (a.ssSubtotal != b.ssSubtotal) return false;
if (a.ssDescuento != b.ssDescuento) return false;
if (a.ssTotalIVA != b.ssTotalIVA) return false;
if (a.ssRetenciones != b.ssRetenciones) return false;
if (a.ssTotal != b.ssTotal) return false;
if (a.ssTipoComprobante != b.ssTipoComprobante) return false;
if (a.ssMoneda != b.ssMoneda) return false;
if (a.ssTipoCambio != b.ssTipoCambio) return false;
if (a.ssUsoCFDI != b.ssUsoCFDI) return false;
if (a.ssExportacion != b.ssExportacion) return false;
if (a.ssUUID != b.ssUUID) return false;
return true;
}

public static bool operator != (EN_f81a3d226103fd013068b8763798067aEntityRecord a, EN_f81a3d226103fd013068b8763798067aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f81a3d226103fd013068b8763798067aEntityRecord)) return false;
return (this == (EN_f81a3d226103fd013068b8763798067aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssVersion.GetHashCode()
 ^ ssFolio.GetHashCode()
 ^ ssSerie.GetHashCode()
 ^ ssFechaEmision.GetHashCode()
 ^ ssFormaPago.GetHashCode()
 ^ ssMetodoPago.GetHashCode()
 ^ ssLugarExpedicion.GetHashCode()
 ^ ssSubtotal.GetHashCode()
 ^ ssDescuento.GetHashCode()
 ^ ssTotalIVA.GetHashCode()
 ^ ssRetenciones.GetHashCode()
 ^ ssTotal.GetHashCode()
 ^ ssTipoComprobante.GetHashCode()
 ^ ssMoneda.GetHashCode()
 ^ ssTipoCambio.GetHashCode()
 ^ ssUsoCFDI.GetHashCode()
 ^ ssExportacion.GetHashCode()
 ^ ssUUID.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_f81a3d226103fd013068b8763798067aEntityRecord Duplicate() {
EN_f81a3d226103fd013068b8763798067aEntityRecord t;
t._ssId = this._ssId;
t._ssVersion = this._ssVersion;
t._ssFolio = this._ssFolio;
t._ssSerie = this._ssSerie;
t._ssFechaEmision = this._ssFechaEmision;
t._ssFormaPago = this._ssFormaPago;
t._ssMetodoPago = this._ssMetodoPago;
t._ssLugarExpedicion = this._ssLugarExpedicion;
t._ssSubtotal = this._ssSubtotal;
t._ssDescuento = this._ssDescuento;
t._ssTotalIVA = this._ssTotalIVA;
t._ssRetenciones = this._ssRetenciones;
t._ssTotal = this._ssTotal;
t._ssTipoComprobante = this._ssTipoComprobante;
t._ssMoneda = this._ssMoneda;
t._ssTipoCambio = this._ssTipoCambio;
t._ssUsoCFDI = this._ssUsoCFDI;
t._ssExportacion = this._ssExportacion;
t._ssUUID = this._ssUUID;
t.ChangedAttributes = new BitArray(19);
t.OptimizedAttributes = new BitArray(19);
for(int i = 0; i < 19; i++){
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
} else if (head == "version") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Version")) variable.Value = ssVersion; else variable.Optimized = true;
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssFolio; else variable.Optimized = true;
} else if (head == "serie") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Serie")) variable.Value = ssSerie; else variable.Optimized = true;
} else if (head == "fechaemision") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FechaEmision")) variable.Value = ssFechaEmision; else variable.Optimized = true;
} else if (head == "formapago") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FormaPago")) variable.Value = ssFormaPago; else variable.Optimized = true;
} else if (head == "metodopago") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MetodoPago")) variable.Value = ssMetodoPago; else variable.Optimized = true;
} else if (head == "lugarexpedicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LugarExpedicion")) variable.Value = ssLugarExpedicion; else variable.Optimized = true;
} else if (head == "subtotal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Subtotal")) variable.Value = ssSubtotal; else variable.Optimized = true;
} else if (head == "descuento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Descuento")) variable.Value = ssDescuento; else variable.Optimized = true;
} else if (head == "totaliva") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalIVA")) variable.Value = ssTotalIVA; else variable.Optimized = true;
} else if (head == "retenciones") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Retenciones")) variable.Value = ssRetenciones; else variable.Optimized = true;
} else if (head == "total") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Total")) variable.Value = ssTotal; else variable.Optimized = true;
} else if (head == "tipocomprobante") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TipoComprobante")) variable.Value = ssTipoComprobante; else variable.Optimized = true;
} else if (head == "moneda") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Moneda")) variable.Value = ssMoneda; else variable.Optimized = true;
} else if (head == "tipocambio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TipoCambio")) variable.Value = ssTipoCambio; else variable.Optimized = true;
} else if (head == "usocfdi") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UsoCFDI")) variable.Value = ssUsoCFDI; else variable.Optimized = true;
} else if (head == "exportacion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Exportacion")) variable.Value = ssExportacion; else variable.Optimized = true;
} else if (head == "uuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UUID")) variable.Value = ssUUID; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdVersion)) {
return ChangedAttributes[1];
}
if (key.Equals(IdFolio)) {
return ChangedAttributes[2];
}
if (key.Equals(IdSerie)) {
return ChangedAttributes[3];
}
if (key.Equals(IdFechaEmision)) {
return ChangedAttributes[4];
}
if (key.Equals(IdFormaPago)) {
return ChangedAttributes[5];
}
if (key.Equals(IdMetodoPago)) {
return ChangedAttributes[6];
}
if (key.Equals(IdLugarExpedicion)) {
return ChangedAttributes[7];
}
if (key.Equals(IdSubtotal)) {
return ChangedAttributes[8];
}
if (key.Equals(IdDescuento)) {
return ChangedAttributes[9];
}
if (key.Equals(IdTotalIVA)) {
return ChangedAttributes[10];
}
if (key.Equals(IdRetenciones)) {
return ChangedAttributes[11];
}
if (key.Equals(IdTotal)) {
return ChangedAttributes[12];
}
if (key.Equals(IdTipoComprobante)) {
return ChangedAttributes[13];
}
if (key.Equals(IdMoneda)) {
return ChangedAttributes[14];
}
if (key.Equals(IdTipoCambio)) {
return ChangedAttributes[15];
}
if (key.Equals(IdUsoCFDI)) {
return ChangedAttributes[16];
}
if (key.Equals(IdExportacion)) {
return ChangedAttributes[17];
}
if (key.Equals(IdUUID)) {
return ChangedAttributes[18];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdVersion)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdFolio)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdSerie)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdFechaEmision)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdFormaPago)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdMetodoPago)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdLugarExpedicion)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdSubtotal)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdDescuento)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdTotalIVA)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdRetenciones)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdTotal)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdTipoComprobante)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdMoneda)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdTipoCambio)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdUsoCFDI)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdExportacion)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdUUID)) {
return OptimizedAttributes[18];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdVersion) {
return ssVersion;
}
if (key == IdFolio) {
return ssFolio;
}
if (key == IdSerie) {
return ssSerie;
}
if (key == IdFechaEmision) {
return ssFechaEmision;
}
if (key == IdFormaPago) {
return ssFormaPago;
}
if (key == IdMetodoPago) {
return ssMetodoPago;
}
if (key == IdLugarExpedicion) {
return ssLugarExpedicion;
}
if (key == IdSubtotal) {
return ssSubtotal;
}
if (key == IdDescuento) {
return ssDescuento;
}
if (key == IdTotalIVA) {
return ssTotalIVA;
}
if (key == IdRetenciones) {
return ssRetenciones;
}
if (key == IdTotal) {
return ssTotal;
}
if (key == IdTipoComprobante) {
return ssTipoComprobante;
}
if (key == IdMoneda) {
return ssMoneda;
}
if (key == IdTipoCambio) {
return ssTipoCambio;
}
if (key == IdUsoCFDI) {
return ssUsoCFDI;
}
if (key == IdExportacion) {
return ssExportacion;
}
if (key == IdUUID) {
return ssUUID;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdVersion.Key.AsGuid) {
return ssVersion;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssFolio;
}
if (attributeKey == IdSerie.Key.AsGuid) {
return ssSerie;
}
if (attributeKey == IdFechaEmision.Key.AsGuid) {
return ssFechaEmision;
}
if (attributeKey == IdFormaPago.Key.AsGuid) {
return ssFormaPago;
}
if (attributeKey == IdMetodoPago.Key.AsGuid) {
return ssMetodoPago;
}
if (attributeKey == IdLugarExpedicion.Key.AsGuid) {
return ssLugarExpedicion;
}
if (attributeKey == IdSubtotal.Key.AsGuid) {
return ssSubtotal;
}
if (attributeKey == IdDescuento.Key.AsGuid) {
return ssDescuento;
}
if (attributeKey == IdTotalIVA.Key.AsGuid) {
return ssTotalIVA;
}
if (attributeKey == IdRetenciones.Key.AsGuid) {
return ssRetenciones;
}
if (attributeKey == IdTotal.Key.AsGuid) {
return ssTotal;
}
if (attributeKey == IdTipoComprobante.Key.AsGuid) {
return ssTipoComprobante;
}
if (attributeKey == IdMoneda.Key.AsGuid) {
return ssMoneda;
}
if (attributeKey == IdTipoCambio.Key.AsGuid) {
return ssTipoCambio;
}
if (attributeKey == IdUsoCFDI.Key.AsGuid) {
return ssUsoCFDI;
}
if (attributeKey == IdExportacion.Key.AsGuid) {
return ssExportacion;
}
if (attributeKey == IdUUID.Key.AsGuid) {
return ssUUID;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(19);
OptimizedAttributes = new BitArray(19);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssVersion = (string) other.AttributeGet(IdVersion);
ChangedAttributes[1] = other.ChangedAttributeGet(IdVersion);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdVersion);
ssFolio = (string) other.AttributeGet(IdFolio);
ChangedAttributes[2] = other.ChangedAttributeGet(IdFolio);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFolio);
ssSerie = (string) other.AttributeGet(IdSerie);
ChangedAttributes[3] = other.ChangedAttributeGet(IdSerie);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdSerie);
ssFechaEmision = (string) other.AttributeGet(IdFechaEmision);
ChangedAttributes[4] = other.ChangedAttributeGet(IdFechaEmision);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdFechaEmision);
ssFormaPago = (string) other.AttributeGet(IdFormaPago);
ChangedAttributes[5] = other.ChangedAttributeGet(IdFormaPago);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdFormaPago);
ssMetodoPago = (string) other.AttributeGet(IdMetodoPago);
ChangedAttributes[6] = other.ChangedAttributeGet(IdMetodoPago);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdMetodoPago);
ssLugarExpedicion = (string) other.AttributeGet(IdLugarExpedicion);
ChangedAttributes[7] = other.ChangedAttributeGet(IdLugarExpedicion);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdLugarExpedicion);
ssSubtotal = (decimal) other.AttributeGet(IdSubtotal);
ChangedAttributes[8] = other.ChangedAttributeGet(IdSubtotal);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdSubtotal);
ssDescuento = (decimal) other.AttributeGet(IdDescuento);
ChangedAttributes[9] = other.ChangedAttributeGet(IdDescuento);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdDescuento);
ssTotalIVA = (decimal) other.AttributeGet(IdTotalIVA);
ChangedAttributes[10] = other.ChangedAttributeGet(IdTotalIVA);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdTotalIVA);
ssRetenciones = (decimal) other.AttributeGet(IdRetenciones);
ChangedAttributes[11] = other.ChangedAttributeGet(IdRetenciones);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdRetenciones);
ssTotal = (decimal) other.AttributeGet(IdTotal);
ChangedAttributes[12] = other.ChangedAttributeGet(IdTotal);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdTotal);
ssTipoComprobante = (string) other.AttributeGet(IdTipoComprobante);
ChangedAttributes[13] = other.ChangedAttributeGet(IdTipoComprobante);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdTipoComprobante);
ssMoneda = (string) other.AttributeGet(IdMoneda);
ChangedAttributes[14] = other.ChangedAttributeGet(IdMoneda);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdMoneda);
ssTipoCambio = (decimal) other.AttributeGet(IdTipoCambio);
ChangedAttributes[15] = other.ChangedAttributeGet(IdTipoCambio);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdTipoCambio);
ssUsoCFDI = (string) other.AttributeGet(IdUsoCFDI);
ChangedAttributes[16] = other.ChangedAttributeGet(IdUsoCFDI);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdUsoCFDI);
ssExportacion = (string) other.AttributeGet(IdExportacion);
ChangedAttributes[17] = other.ChangedAttributeGet(IdExportacion);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdExportacion);
ssUUID = (string) other.AttributeGet(IdUUID);
ChangedAttributes[18] = other.ChangedAttributeGet(IdUUID);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdUUID);
}
} // EN_f81a3d226103fd013068b8763798067aEntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedList</code> that represents a record list of
///  <code>InvoiceExtended</code>
/// </summary>
public partial class RL_6466ecf50cc035d7b29b237164d2b075 : GenericRecordList<EN_f81a3d226103fd013068b8763798067aEntityRecord>, IEnumerable, IEnumerator {

protected override EN_f81a3d226103fd013068b8763798067aEntityRecord GetElementDefaultValue() {
return new EN_f81a3d226103fd013068b8763798067aEntityRecord();
}

public T[] ToArray<T>(Func<EN_f81a3d226103fd013068b8763798067aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6466ecf50cc035d7b29b237164d2b075 recordList, Func<EN_f81a3d226103fd013068b8763798067aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6466ecf50cc035d7b29b237164d2b075(EN_f81a3d226103fd013068b8763798067aEntityRecord[] array) {
  RL_6466ecf50cc035d7b29b237164d2b075 result = new RL_6466ecf50cc035d7b29b237164d2b075();
result.InnerFromArray(array);
    return result;
}

public static RL_6466ecf50cc035d7b29b237164d2b075 ToList<T>(T[] array, Func <T, EN_f81a3d226103fd013068b8763798067aEntityRecord> converter) {
  RL_6466ecf50cc035d7b29b237164d2b075 result = new RL_6466ecf50cc035d7b29b237164d2b075();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6466ecf50cc035d7b29b237164d2b075 FromRestList<T>(RestList<T> restList, Func <T, EN_f81a3d226103fd013068b8763798067aEntityRecord> converter) {
  RL_6466ecf50cc035d7b29b237164d2b075 result = new RL_6466ecf50cc035d7b29b237164d2b075();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6466ecf50cc035d7b29b237164d2b075() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f81a3d226103fd013068b8763798067aEntityRecord> NewList() {
return new RL_6466ecf50cc035d7b29b237164d2b075();
}


} // RL_6466ecf50cc035d7b29b237164d2b075
}
