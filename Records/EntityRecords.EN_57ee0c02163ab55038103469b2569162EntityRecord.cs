using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] SupplierDetail (OPSCn5yvSkiq4FH2LIB8iA)
///  <code>EN_57ee0c02163ab55038103469b2569162EntityRecord</code> that represent
/// s <code>SupplierDetail</code> <p>Description: Entity holds supplier</p>
/// </summary>
// Name: SupplierDetail
public partial struct EN_57ee0c02163ab55038103469b2569162EntityRecord : ITypedRecord<EN_57ee0c02163ab55038103469b2569162EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*147iocqDl0aKRBawP4l5Zg");
internal static readonly GlobalObjectKey IdSupplierId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*0kiWaDnGTkO1LQBCOOZzhw");
internal static readonly GlobalObjectKey IdSociedadeId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*QK8wHX2JykWV4yXfUMKkdQ");
internal static readonly GlobalObjectKey IdBloqueocontabilidad = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*xEnMxE+550+5hBEA7eL+jA");
internal static readonly GlobalObjectKey IdBloqueopedido = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*0qfU9u4mmUOZOfHqqSovLw");
internal static readonly GlobalObjectKey IdPais2 = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*EdFH0iSr3EKtZfR5kj3Ukw");
internal static readonly GlobalObjectKey IdClavebanco = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+uRJdodo6UKUJJ2YkNxHRg");
internal static readonly GlobalObjectKey IdCuentabancaria = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*5gk8sfDMR0eFNZmCofV7Hw");
internal static readonly GlobalObjectKey IdTitular = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*rnt7rzBku0erf4CvVo5KNQ");
internal static readonly GlobalObjectKey IdTpBco = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*_TGY2g8yqEuZYF3qET2U3w");
internal static readonly GlobalObjectKey IdReferencia = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*F0YPX7ARuE6PvTGQ8xU6iw");
internal static readonly GlobalObjectKey IdAutoriz_Extraccion = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*LPGGwZH250+iAoyvkA1iVg");
internal static readonly GlobalObjectKey IdNombredelainstitucionfinanci = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*h8NtBb0qKkiE0MRnExH_Rw");
internal static readonly GlobalObjectKey IdCuentaasociada = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*yM6D7FtoTkCn2aa8okKlBQ");
internal static readonly GlobalObjectKey IdClaveclasific_ = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*X1x47GBSUEG4vY0UUaS__Q");
internal static readonly GlobalObjectKey IdGrupodeTesoreria = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*EPLnI0NfXkKojWTBZ9K2GA");
internal static readonly GlobalObjectKey IdN_cta_anterior = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*JHGr2Rk0hEaYKC1OeLefrw");
internal static readonly GlobalObjectKey IdCond_pago = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*dxcFa6uk3UuDRa52dRaHqA");
internal static readonly GlobalObjectKey IdViasdepago = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*XTfbk55wYEeFHYL6EWX4tw");
internal static readonly GlobalObjectKey IdBloqueopago = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*cqmZVJ_niEu0naEN3Y+7TA");
internal static readonly GlobalObjectKey IdPaisderetencion = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*BcKuWKmJ10GbIDmwSqjxng");
internal static readonly GlobalObjectKey IdTp_retenc_ = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*DM40jYv50k+nYoFpUnJBOQ");
internal static readonly GlobalObjectKey IdInRet = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*mPFkF_GFIEWqfSispbmG9g");
internal static readonly GlobalObjectKey IdSujeto = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*om4AO+CPjU+x9k0rS8iB0g");
internal static readonly GlobalObjectKey IdExen__ = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*OLRfWW5YPE6mCoz0R85row");
internal static readonly GlobalObjectKey IdDescripcion = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*GDQ_EYl5wES4VK5T+dTlaw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(26,true);
          _ssId = value;
      }
  }
}

private long _ssSupplierId;
public long ssSupplierId{
  get{
      return _ssSupplierId;
  }
  set{
      if((_ssSupplierId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssSupplierId = value;
      }
  }
}

private long _ssSociedadeId;
public long ssSociedadeId{
  get{
      return _ssSociedadeId;
  }
  set{
      if((_ssSociedadeId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssSociedadeId = value;
      }
  }
}

private string _ssBloqueocontabilidad;
public string ssBloqueocontabilidad{
  get{
      return _ssBloqueocontabilidad;
  }
  set{
      if((_ssBloqueocontabilidad!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssBloqueocontabilidad = value;
      }
  }
}

private string _ssBloqueopedido;
public string ssBloqueopedido{
  get{
      return _ssBloqueopedido;
  }
  set{
      if((_ssBloqueopedido!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssBloqueopedido = value;
      }
  }
}

private string _ssPais2;
public string ssPais2{
  get{
      return _ssPais2;
  }
  set{
      if((_ssPais2!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssPais2 = value;
      }
  }
}

private string _ssClavebanco;
public string ssClavebanco{
  get{
      return _ssClavebanco;
  }
  set{
      if((_ssClavebanco!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssClavebanco = value;
      }
  }
}

private string _ssCuentabancaria;
public string ssCuentabancaria{
  get{
      return _ssCuentabancaria;
  }
  set{
      if((_ssCuentabancaria!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCuentabancaria = value;
      }
  }
}

private string _ssTitular;
public string ssTitular{
  get{
      return _ssTitular;
  }
  set{
      if((_ssTitular!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssTitular = value;
      }
  }
}

private string _ssTpBco;
public string ssTpBco{
  get{
      return _ssTpBco;
  }
  set{
      if((_ssTpBco!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssTpBco = value;
      }
  }
}

private string _ssReferencia;
public string ssReferencia{
  get{
      return _ssReferencia;
  }
  set{
      if((_ssReferencia!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssReferencia = value;
      }
  }
}

private string _ssAutoriz_Extraccion;
public string ssAutoriz_Extraccion{
  get{
      return _ssAutoriz_Extraccion;
  }
  set{
      if((_ssAutoriz_Extraccion!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssAutoriz_Extraccion = value;
      }
  }
}

private string _ssNombredelainstitucionfinanci;
public string ssNombredelainstitucionfinanci{
  get{
      return _ssNombredelainstitucionfinanci;
  }
  set{
      if((_ssNombredelainstitucionfinanci!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssNombredelainstitucionfinanci = value;
      }
  }
}

private string _ssCuentaasociada;
public string ssCuentaasociada{
  get{
      return _ssCuentaasociada;
  }
  set{
      if((_ssCuentaasociada!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssCuentaasociada = value;
      }
  }
}

private string _ssClaveclasific_;
public string ssClaveclasific_{
  get{
      return _ssClaveclasific_;
  }
  set{
      if((_ssClaveclasific_!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssClaveclasific_ = value;
      }
  }
}

private string _ssGrupodeTesoreria;
public string ssGrupodeTesoreria{
  get{
      return _ssGrupodeTesoreria;
  }
  set{
      if((_ssGrupodeTesoreria!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssGrupodeTesoreria = value;
      }
  }
}

private string _ssN_cta_anterior;
public string ssN_cta_anterior{
  get{
      return _ssN_cta_anterior;
  }
  set{
      if((_ssN_cta_anterior!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssN_cta_anterior = value;
      }
  }
}

private string _ssCond_pago;
public string ssCond_pago{
  get{
      return _ssCond_pago;
  }
  set{
      if((_ssCond_pago!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssCond_pago = value;
      }
  }
}

private string _ssViasdepago;
public string ssViasdepago{
  get{
      return _ssViasdepago;
  }
  set{
      if((_ssViasdepago!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssViasdepago = value;
      }
  }
}

private string _ssBloqueopago;
public string ssBloqueopago{
  get{
      return _ssBloqueopago;
  }
  set{
      if((_ssBloqueopago!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssBloqueopago = value;
      }
  }
}

private string _ssPaisderetencion;
public string ssPaisderetencion{
  get{
      return _ssPaisderetencion;
  }
  set{
      if((_ssPaisderetencion!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssPaisderetencion = value;
      }
  }
}

private string _ssTp_retenc_;
public string ssTp_retenc_{
  get{
      return _ssTp_retenc_;
  }
  set{
      if((_ssTp_retenc_!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssTp_retenc_ = value;
      }
  }
}

private string _ssInRet;
public string ssInRet{
  get{
      return _ssInRet;
  }
  set{
      if((_ssInRet!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssInRet = value;
      }
  }
}

private string _ssSujeto;
public string ssSujeto{
  get{
      return _ssSujeto;
  }
  set{
      if((_ssSujeto!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssSujeto = value;
      }
  }
}

private string _ssExen__;
public string ssExen__{
  get{
      return _ssExen__;
  }
  set{
      if((_ssExen__!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssExen__ = value;
      }
  }
}

private string _ssDescripcion;
public string ssDescripcion{
  get{
      return _ssDescripcion;
  }
  set{
      if((_ssDescripcion!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
          _ssDescripcion = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_57ee0c02163ab55038103469b2569162EntityRecord() {
ChangedAttributes = new BitArray(26,true);
OptimizedAttributes = new BitArray(26,false);
_ssId = 0L;
_ssSupplierId = 0L;
_ssSociedadeId = 0L;
_ssBloqueocontabilidad = "";
_ssBloqueopedido = "";
_ssPais2 = "";
_ssClavebanco = "";
_ssCuentabancaria = "";
_ssTitular = "";
_ssTpBco = "";
_ssReferencia = "";
_ssAutoriz_Extraccion = "";
_ssNombredelainstitucionfinanci = "";
_ssCuentaasociada = "";
_ssClaveclasific_ = "";
_ssGrupodeTesoreria = "";
_ssN_cta_anterior = "";
_ssCond_pago = "";
_ssViasdepago = "";
_ssBloqueopago = "";
_ssPaisderetencion = "";
_ssTp_retenc_ = "";
_ssInRet = "";
_ssSujeto = "";
_ssExen__ = "";
_ssDescripcion = "";
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
ssId = r.ReadLongInteger(index++, "SupplierDetail.Id", 0L);
ssSupplierId = r.ReadEntityReferenceLongInteger(index++, "SupplierDetail.SupplierId", 0L);
ssSociedadeId = r.ReadEntityReferenceLongInteger(index++, "SupplierDetail.SociedadeId", 0L);
ssBloqueocontabilidad = r.ReadText(index++, "SupplierDetail.Bloqueocontabilidad", "");
ssBloqueopedido = r.ReadText(index++, "SupplierDetail.Bloqueopedido", "");
ssPais2 = r.ReadText(index++, "SupplierDetail.Pais2", "");
ssClavebanco = r.ReadText(index++, "SupplierDetail.Clavebanco", "");
ssCuentabancaria = r.ReadText(index++, "SupplierDetail.Cuentabancaria", "");
ssTitular = r.ReadText(index++, "SupplierDetail.Titular", "");
ssTpBco = r.ReadText(index++, "SupplierDetail.TpBco", "");
ssReferencia = r.ReadText(index++, "SupplierDetail.Referencia", "");
ssAutoriz_Extraccion = r.ReadText(index++, "SupplierDetail.Autoriz_Extraccion", "");
ssNombredelainstitucionfinanci = r.ReadText(index++, "SupplierDetail.Nombredelainstitucionfinanci", "");
ssCuentaasociada = r.ReadText(index++, "SupplierDetail.Cuentaasociada", "");
ssClaveclasific_ = r.ReadText(index++, "SupplierDetail.Claveclasific_", "");
ssGrupodeTesoreria = r.ReadText(index++, "SupplierDetail.GrupodeTesoreria", "");
ssN_cta_anterior = r.ReadText(index++, "SupplierDetail.N_cta_anterior", "");
ssCond_pago = r.ReadText(index++, "SupplierDetail.Cond_pago", "");
ssViasdepago = r.ReadText(index++, "SupplierDetail.Viasdepago", "");
ssBloqueopago = r.ReadText(index++, "SupplierDetail.Bloqueopago", "");
ssPaisderetencion = r.ReadText(index++, "SupplierDetail.Paisderetencion", "");
ssTp_retenc_ = r.ReadText(index++, "SupplierDetail.Tp_retenc_", "");
ssInRet = r.ReadText(index++, "SupplierDetail.InRet", "");
ssSujeto = r.ReadText(index++, "SupplierDetail.Sujeto", "");
ssExen__ = r.ReadText(index++, "SupplierDetail.Exen__", "");
ssDescripcion = r.ReadText(index++, "SupplierDetail.Descripcion", "");
ChangedAttributes = new BitArray(26,false);
OptimizedAttributes = new BitArray(26,false);
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
public void ReadIM(EN_57ee0c02163ab55038103469b2569162EntityRecord r) {
this = r;
}


public static bool operator == (EN_57ee0c02163ab55038103469b2569162EntityRecord a, EN_57ee0c02163ab55038103469b2569162EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssSupplierId != b.ssSupplierId) return false;
if (a.ssSociedadeId != b.ssSociedadeId) return false;
if (a.ssBloqueocontabilidad != b.ssBloqueocontabilidad) return false;
if (a.ssBloqueopedido != b.ssBloqueopedido) return false;
if (a.ssPais2 != b.ssPais2) return false;
if (a.ssClavebanco != b.ssClavebanco) return false;
if (a.ssCuentabancaria != b.ssCuentabancaria) return false;
if (a.ssTitular != b.ssTitular) return false;
if (a.ssTpBco != b.ssTpBco) return false;
if (a.ssReferencia != b.ssReferencia) return false;
if (a.ssAutoriz_Extraccion != b.ssAutoriz_Extraccion) return false;
if (a.ssNombredelainstitucionfinanci != b.ssNombredelainstitucionfinanci) return false;
if (a.ssCuentaasociada != b.ssCuentaasociada) return false;
if (a.ssClaveclasific_ != b.ssClaveclasific_) return false;
if (a.ssGrupodeTesoreria != b.ssGrupodeTesoreria) return false;
if (a.ssN_cta_anterior != b.ssN_cta_anterior) return false;
if (a.ssCond_pago != b.ssCond_pago) return false;
if (a.ssViasdepago != b.ssViasdepago) return false;
if (a.ssBloqueopago != b.ssBloqueopago) return false;
if (a.ssPaisderetencion != b.ssPaisderetencion) return false;
if (a.ssTp_retenc_ != b.ssTp_retenc_) return false;
if (a.ssInRet != b.ssInRet) return false;
if (a.ssSujeto != b.ssSujeto) return false;
if (a.ssExen__ != b.ssExen__) return false;
if (a.ssDescripcion != b.ssDescripcion) return false;
return true;
}

public static bool operator != (EN_57ee0c02163ab55038103469b2569162EntityRecord a, EN_57ee0c02163ab55038103469b2569162EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_57ee0c02163ab55038103469b2569162EntityRecord)) return false;
return (this == (EN_57ee0c02163ab55038103469b2569162EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssSupplierId.GetHashCode()
 ^ ssSociedadeId.GetHashCode()
 ^ ssBloqueocontabilidad.GetHashCode()
 ^ ssBloqueopedido.GetHashCode()
 ^ ssPais2.GetHashCode()
 ^ ssClavebanco.GetHashCode()
 ^ ssCuentabancaria.GetHashCode()
 ^ ssTitular.GetHashCode()
 ^ ssTpBco.GetHashCode()
 ^ ssReferencia.GetHashCode()
 ^ ssAutoriz_Extraccion.GetHashCode()
 ^ ssNombredelainstitucionfinanci.GetHashCode()
 ^ ssCuentaasociada.GetHashCode()
 ^ ssClaveclasific_.GetHashCode()
 ^ ssGrupodeTesoreria.GetHashCode()
 ^ ssN_cta_anterior.GetHashCode()
 ^ ssCond_pago.GetHashCode()
 ^ ssViasdepago.GetHashCode()
 ^ ssBloqueopago.GetHashCode()
 ^ ssPaisderetencion.GetHashCode()
 ^ ssTp_retenc_.GetHashCode()
 ^ ssInRet.GetHashCode()
 ^ ssSujeto.GetHashCode()
 ^ ssExen__.GetHashCode()
 ^ ssDescripcion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_57ee0c02163ab55038103469b2569162EntityRecord Duplicate() {
EN_57ee0c02163ab55038103469b2569162EntityRecord t;
t._ssId = this._ssId;
t._ssSupplierId = this._ssSupplierId;
t._ssSociedadeId = this._ssSociedadeId;
t._ssBloqueocontabilidad = this._ssBloqueocontabilidad;
t._ssBloqueopedido = this._ssBloqueopedido;
t._ssPais2 = this._ssPais2;
t._ssClavebanco = this._ssClavebanco;
t._ssCuentabancaria = this._ssCuentabancaria;
t._ssTitular = this._ssTitular;
t._ssTpBco = this._ssTpBco;
t._ssReferencia = this._ssReferencia;
t._ssAutoriz_Extraccion = this._ssAutoriz_Extraccion;
t._ssNombredelainstitucionfinanci = this._ssNombredelainstitucionfinanci;
t._ssCuentaasociada = this._ssCuentaasociada;
t._ssClaveclasific_ = this._ssClaveclasific_;
t._ssGrupodeTesoreria = this._ssGrupodeTesoreria;
t._ssN_cta_anterior = this._ssN_cta_anterior;
t._ssCond_pago = this._ssCond_pago;
t._ssViasdepago = this._ssViasdepago;
t._ssBloqueopago = this._ssBloqueopago;
t._ssPaisderetencion = this._ssPaisderetencion;
t._ssTp_retenc_ = this._ssTp_retenc_;
t._ssInRet = this._ssInRet;
t._ssSujeto = this._ssSujeto;
t._ssExen__ = this._ssExen__;
t._ssDescripcion = this._ssDescripcion;
t.ChangedAttributes = new BitArray(26);
t.OptimizedAttributes = new BitArray(26);
for(int i = 0; i < 26; i++){
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
} else if (head == "supplierid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierId")) variable.Value = ssSupplierId; else variable.Optimized = true;
} else if (head == "sociedadeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SociedadeId")) variable.Value = ssSociedadeId; else variable.Optimized = true;
} else if (head == "bloqueocontabilidad") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Bloqueocontabilidad")) variable.Value = ssBloqueocontabilidad; else variable.Optimized = true;
} else if (head == "bloqueopedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Bloqueopedido")) variable.Value = ssBloqueopedido; else variable.Optimized = true;
} else if (head == "pais2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Pais2")) variable.Value = ssPais2; else variable.Optimized = true;
} else if (head == "clavebanco") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Clavebanco")) variable.Value = ssClavebanco; else variable.Optimized = true;
} else if (head == "cuentabancaria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cuentabancaria")) variable.Value = ssCuentabancaria; else variable.Optimized = true;
} else if (head == "titular") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Titular")) variable.Value = ssTitular; else variable.Optimized = true;
} else if (head == "tpbco") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TpBco")) variable.Value = ssTpBco; else variable.Optimized = true;
} else if (head == "referencia") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Referencia")) variable.Value = ssReferencia; else variable.Optimized = true;
} else if (head == "autoriz_extraccion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Autoriz_Extraccion")) variable.Value = ssAutoriz_Extraccion; else variable.Optimized = true;
} else if (head == "nombredelainstitucionfinanci") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Nombredelainstitucionfinanci")) variable.Value = ssNombredelainstitucionfinanci; else variable.Optimized = true;
} else if (head == "cuentaasociada") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cuentaasociada")) variable.Value = ssCuentaasociada; else variable.Optimized = true;
} else if (head == "claveclasific_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Claveclasific_")) variable.Value = ssClaveclasific_; else variable.Optimized = true;
} else if (head == "grupodetesoreria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GrupodeTesoreria")) variable.Value = ssGrupodeTesoreria; else variable.Optimized = true;
} else if (head == "n_cta_anterior") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".N_cta_anterior")) variable.Value = ssN_cta_anterior; else variable.Optimized = true;
} else if (head == "cond_pago") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cond_pago")) variable.Value = ssCond_pago; else variable.Optimized = true;
} else if (head == "viasdepago") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Viasdepago")) variable.Value = ssViasdepago; else variable.Optimized = true;
} else if (head == "bloqueopago") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Bloqueopago")) variable.Value = ssBloqueopago; else variable.Optimized = true;
} else if (head == "paisderetencion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Paisderetencion")) variable.Value = ssPaisderetencion; else variable.Optimized = true;
} else if (head == "tp_retenc_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tp_retenc_")) variable.Value = ssTp_retenc_; else variable.Optimized = true;
} else if (head == "inret") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InRet")) variable.Value = ssInRet; else variable.Optimized = true;
} else if (head == "sujeto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sujeto")) variable.Value = ssSujeto; else variable.Optimized = true;
} else if (head == "exen__") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Exen__")) variable.Value = ssExen__; else variable.Optimized = true;
} else if (head == "descripcion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Descripcion")) variable.Value = ssDescripcion; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdSupplierId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdSociedadeId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdBloqueocontabilidad)) {
return ChangedAttributes[3];
}
if (key.Equals(IdBloqueopedido)) {
return ChangedAttributes[4];
}
if (key.Equals(IdPais2)) {
return ChangedAttributes[5];
}
if (key.Equals(IdClavebanco)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCuentabancaria)) {
return ChangedAttributes[7];
}
if (key.Equals(IdTitular)) {
return ChangedAttributes[8];
}
if (key.Equals(IdTpBco)) {
return ChangedAttributes[9];
}
if (key.Equals(IdReferencia)) {
return ChangedAttributes[10];
}
if (key.Equals(IdAutoriz_Extraccion)) {
return ChangedAttributes[11];
}
if (key.Equals(IdNombredelainstitucionfinanci)) {
return ChangedAttributes[12];
}
if (key.Equals(IdCuentaasociada)) {
return ChangedAttributes[13];
}
if (key.Equals(IdClaveclasific_)) {
return ChangedAttributes[14];
}
if (key.Equals(IdGrupodeTesoreria)) {
return ChangedAttributes[15];
}
if (key.Equals(IdN_cta_anterior)) {
return ChangedAttributes[16];
}
if (key.Equals(IdCond_pago)) {
return ChangedAttributes[17];
}
if (key.Equals(IdViasdepago)) {
return ChangedAttributes[18];
}
if (key.Equals(IdBloqueopago)) {
return ChangedAttributes[19];
}
if (key.Equals(IdPaisderetencion)) {
return ChangedAttributes[20];
}
if (key.Equals(IdTp_retenc_)) {
return ChangedAttributes[21];
}
if (key.Equals(IdInRet)) {
return ChangedAttributes[22];
}
if (key.Equals(IdSujeto)) {
return ChangedAttributes[23];
}
if (key.Equals(IdExen__)) {
return ChangedAttributes[24];
}
if (key.Equals(IdDescripcion)) {
return ChangedAttributes[25];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdSupplierId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdSociedadeId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdBloqueocontabilidad)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdBloqueopedido)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdPais2)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdClavebanco)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCuentabancaria)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdTitular)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdTpBco)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdReferencia)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdAutoriz_Extraccion)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdNombredelainstitucionfinanci)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdCuentaasociada)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdClaveclasific_)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdGrupodeTesoreria)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdN_cta_anterior)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdCond_pago)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdViasdepago)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdBloqueopago)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdPaisderetencion)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdTp_retenc_)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdInRet)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdSujeto)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdExen__)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdDescripcion)) {
return OptimizedAttributes[25];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdSupplierId) {
return ssSupplierId;
}
if (key == IdSociedadeId) {
return ssSociedadeId;
}
if (key == IdBloqueocontabilidad) {
return ssBloqueocontabilidad;
}
if (key == IdBloqueopedido) {
return ssBloqueopedido;
}
if (key == IdPais2) {
return ssPais2;
}
if (key == IdClavebanco) {
return ssClavebanco;
}
if (key == IdCuentabancaria) {
return ssCuentabancaria;
}
if (key == IdTitular) {
return ssTitular;
}
if (key == IdTpBco) {
return ssTpBco;
}
if (key == IdReferencia) {
return ssReferencia;
}
if (key == IdAutoriz_Extraccion) {
return ssAutoriz_Extraccion;
}
if (key == IdNombredelainstitucionfinanci) {
return ssNombredelainstitucionfinanci;
}
if (key == IdCuentaasociada) {
return ssCuentaasociada;
}
if (key == IdClaveclasific_) {
return ssClaveclasific_;
}
if (key == IdGrupodeTesoreria) {
return ssGrupodeTesoreria;
}
if (key == IdN_cta_anterior) {
return ssN_cta_anterior;
}
if (key == IdCond_pago) {
return ssCond_pago;
}
if (key == IdViasdepago) {
return ssViasdepago;
}
if (key == IdBloqueopago) {
return ssBloqueopago;
}
if (key == IdPaisderetencion) {
return ssPaisderetencion;
}
if (key == IdTp_retenc_) {
return ssTp_retenc_;
}
if (key == IdInRet) {
return ssInRet;
}
if (key == IdSujeto) {
return ssSujeto;
}
if (key == IdExen__) {
return ssExen__;
}
if (key == IdDescripcion) {
return ssDescripcion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdSupplierId.Key.AsGuid) {
return ssSupplierId;
}
if (attributeKey == IdSociedadeId.Key.AsGuid) {
return ssSociedadeId;
}
if (attributeKey == IdBloqueocontabilidad.Key.AsGuid) {
return ssBloqueocontabilidad;
}
if (attributeKey == IdBloqueopedido.Key.AsGuid) {
return ssBloqueopedido;
}
if (attributeKey == IdPais2.Key.AsGuid) {
return ssPais2;
}
if (attributeKey == IdClavebanco.Key.AsGuid) {
return ssClavebanco;
}
if (attributeKey == IdCuentabancaria.Key.AsGuid) {
return ssCuentabancaria;
}
if (attributeKey == IdTitular.Key.AsGuid) {
return ssTitular;
}
if (attributeKey == IdTpBco.Key.AsGuid) {
return ssTpBco;
}
if (attributeKey == IdReferencia.Key.AsGuid) {
return ssReferencia;
}
if (attributeKey == IdAutoriz_Extraccion.Key.AsGuid) {
return ssAutoriz_Extraccion;
}
if (attributeKey == IdNombredelainstitucionfinanci.Key.AsGuid) {
return ssNombredelainstitucionfinanci;
}
if (attributeKey == IdCuentaasociada.Key.AsGuid) {
return ssCuentaasociada;
}
if (attributeKey == IdClaveclasific_.Key.AsGuid) {
return ssClaveclasific_;
}
if (attributeKey == IdGrupodeTesoreria.Key.AsGuid) {
return ssGrupodeTesoreria;
}
if (attributeKey == IdN_cta_anterior.Key.AsGuid) {
return ssN_cta_anterior;
}
if (attributeKey == IdCond_pago.Key.AsGuid) {
return ssCond_pago;
}
if (attributeKey == IdViasdepago.Key.AsGuid) {
return ssViasdepago;
}
if (attributeKey == IdBloqueopago.Key.AsGuid) {
return ssBloqueopago;
}
if (attributeKey == IdPaisderetencion.Key.AsGuid) {
return ssPaisderetencion;
}
if (attributeKey == IdTp_retenc_.Key.AsGuid) {
return ssTp_retenc_;
}
if (attributeKey == IdInRet.Key.AsGuid) {
return ssInRet;
}
if (attributeKey == IdSujeto.Key.AsGuid) {
return ssSujeto;
}
if (attributeKey == IdExen__.Key.AsGuid) {
return ssExen__;
}
if (attributeKey == IdDescripcion.Key.AsGuid) {
return ssDescripcion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(26);
OptimizedAttributes = new BitArray(26);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssSupplierId = (long) other.AttributeGet(IdSupplierId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdSupplierId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSupplierId);
ssSociedadeId = (long) other.AttributeGet(IdSociedadeId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdSociedadeId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdSociedadeId);
ssBloqueocontabilidad = (string) other.AttributeGet(IdBloqueocontabilidad);
ChangedAttributes[3] = other.ChangedAttributeGet(IdBloqueocontabilidad);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdBloqueocontabilidad);
ssBloqueopedido = (string) other.AttributeGet(IdBloqueopedido);
ChangedAttributes[4] = other.ChangedAttributeGet(IdBloqueopedido);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdBloqueopedido);
ssPais2 = (string) other.AttributeGet(IdPais2);
ChangedAttributes[5] = other.ChangedAttributeGet(IdPais2);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdPais2);
ssClavebanco = (string) other.AttributeGet(IdClavebanco);
ChangedAttributes[6] = other.ChangedAttributeGet(IdClavebanco);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdClavebanco);
ssCuentabancaria = (string) other.AttributeGet(IdCuentabancaria);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCuentabancaria);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCuentabancaria);
ssTitular = (string) other.AttributeGet(IdTitular);
ChangedAttributes[8] = other.ChangedAttributeGet(IdTitular);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdTitular);
ssTpBco = (string) other.AttributeGet(IdTpBco);
ChangedAttributes[9] = other.ChangedAttributeGet(IdTpBco);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdTpBco);
ssReferencia = (string) other.AttributeGet(IdReferencia);
ChangedAttributes[10] = other.ChangedAttributeGet(IdReferencia);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdReferencia);
ssAutoriz_Extraccion = (string) other.AttributeGet(IdAutoriz_Extraccion);
ChangedAttributes[11] = other.ChangedAttributeGet(IdAutoriz_Extraccion);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdAutoriz_Extraccion);
ssNombredelainstitucionfinanci = (string) other.AttributeGet(IdNombredelainstitucionfinanci);
ChangedAttributes[12] = other.ChangedAttributeGet(IdNombredelainstitucionfinanci);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdNombredelainstitucionfinanci);
ssCuentaasociada = (string) other.AttributeGet(IdCuentaasociada);
ChangedAttributes[13] = other.ChangedAttributeGet(IdCuentaasociada);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdCuentaasociada);
ssClaveclasific_ = (string) other.AttributeGet(IdClaveclasific_);
ChangedAttributes[14] = other.ChangedAttributeGet(IdClaveclasific_);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdClaveclasific_);
ssGrupodeTesoreria = (string) other.AttributeGet(IdGrupodeTesoreria);
ChangedAttributes[15] = other.ChangedAttributeGet(IdGrupodeTesoreria);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdGrupodeTesoreria);
ssN_cta_anterior = (string) other.AttributeGet(IdN_cta_anterior);
ChangedAttributes[16] = other.ChangedAttributeGet(IdN_cta_anterior);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdN_cta_anterior);
ssCond_pago = (string) other.AttributeGet(IdCond_pago);
ChangedAttributes[17] = other.ChangedAttributeGet(IdCond_pago);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdCond_pago);
ssViasdepago = (string) other.AttributeGet(IdViasdepago);
ChangedAttributes[18] = other.ChangedAttributeGet(IdViasdepago);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdViasdepago);
ssBloqueopago = (string) other.AttributeGet(IdBloqueopago);
ChangedAttributes[19] = other.ChangedAttributeGet(IdBloqueopago);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdBloqueopago);
ssPaisderetencion = (string) other.AttributeGet(IdPaisderetencion);
ChangedAttributes[20] = other.ChangedAttributeGet(IdPaisderetencion);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdPaisderetencion);
ssTp_retenc_ = (string) other.AttributeGet(IdTp_retenc_);
ChangedAttributes[21] = other.ChangedAttributeGet(IdTp_retenc_);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdTp_retenc_);
ssInRet = (string) other.AttributeGet(IdInRet);
ChangedAttributes[22] = other.ChangedAttributeGet(IdInRet);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdInRet);
ssSujeto = (string) other.AttributeGet(IdSujeto);
ChangedAttributes[23] = other.ChangedAttributeGet(IdSujeto);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdSujeto);
ssExen__ = (string) other.AttributeGet(IdExen__);
ChangedAttributes[24] = other.ChangedAttributeGet(IdExen__);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdExen__);
ssDescripcion = (string) other.AttributeGet(IdDescripcion);
ChangedAttributes[25] = other.ChangedAttributeGet(IdDescripcion);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdDescripcion);
}
} // EN_57ee0c02163ab55038103469b2569162EntityRecord

/// <summary>
/// RecordList type <code>SupplierDetailList</code> that represents a record list of
///  <code>SupplierDetail</code>
/// </summary>
public partial class RL_0ef780f29af83f648ff3ed912b524f2d : GenericRecordList<EN_57ee0c02163ab55038103469b2569162EntityRecord>, IEnumerable, IEnumerator {

protected override EN_57ee0c02163ab55038103469b2569162EntityRecord GetElementDefaultValue() {
return new EN_57ee0c02163ab55038103469b2569162EntityRecord();
}

public T[] ToArray<T>(Func<EN_57ee0c02163ab55038103469b2569162EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0ef780f29af83f648ff3ed912b524f2d recordList, Func<EN_57ee0c02163ab55038103469b2569162EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0ef780f29af83f648ff3ed912b524f2d(EN_57ee0c02163ab55038103469b2569162EntityRecord[] array) {
  RL_0ef780f29af83f648ff3ed912b524f2d result = new RL_0ef780f29af83f648ff3ed912b524f2d();
result.InnerFromArray(array);
    return result;
}

public static RL_0ef780f29af83f648ff3ed912b524f2d ToList<T>(T[] array, Func <T, EN_57ee0c02163ab55038103469b2569162EntityRecord> converter) {
  RL_0ef780f29af83f648ff3ed912b524f2d result = new RL_0ef780f29af83f648ff3ed912b524f2d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0ef780f29af83f648ff3ed912b524f2d FromRestList<T>(RestList<T> restList, Func <T, EN_57ee0c02163ab55038103469b2569162EntityRecord> converter) {
  RL_0ef780f29af83f648ff3ed912b524f2d result = new RL_0ef780f29af83f648ff3ed912b524f2d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0ef780f29af83f648ff3ed912b524f2d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_57ee0c02163ab55038103469b2569162EntityRecord> NewList() {
return new RL_0ef780f29af83f648ff3ed912b524f2d();
}


} // RL_0ef780f29af83f648ff3ed912b524f2d
}
