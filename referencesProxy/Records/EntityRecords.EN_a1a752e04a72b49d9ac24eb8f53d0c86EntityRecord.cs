using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] CostCenterSAP (DostSvZCvEOV8DzfvEl0DA)
///  <code>EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord</code> that represent
/// s <code>CostCenterSAP</code> <p>Description: Cost Center from SAP</p>
/// </summary>
// Name: CostCenterSAP
public partial struct EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord : ITypedRecord<EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*oQSgnC+SLUSfok0m3BdE+Q");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*eG+OSt8xakePv0_qW1AlEw");
internal static readonly GlobalObjectKey IdCompanyId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*IwoSQkX3UEK5R5gUSQcMzw");
internal static readonly GlobalObjectKey IdSoc_ = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*pxpsn5ZuOUmAe05SWLYZbA");
internal static readonly GlobalObjectKey IdDiv_ = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*BIu7eoNIdkSnkE_WT95N5w");
internal static readonly GlobalObjectKey IdArea = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*3CqpRjHSmUSyHbaGlyddsA");
internal static readonly GlobalObjectKey IdCe_coste = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*E975m9lrz0yA1ahYGRn8lQ");
internal static readonly GlobalObjectKey IdCeBe = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*pieC9StomEm93FQ8o2zXng");
internal static readonly GlobalObjectKey IdDenominacion = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*K_uwRzaS2kKT+1a990kfOQ");
internal static readonly GlobalObjectKey IdDescripcion = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*1_7mxblED0+q4beDK0KpRQ");
internal static readonly GlobalObjectKey IdResponsable = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*qTC2X3rcb0WZjzd5CN+KpQ");
internal static readonly GlobalObjectKey IdCeCo = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*VfPMM805RkmESmWfILjorA");
internal static readonly GlobalObjectKey IdCostesprim_reales_Ind_debloq = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*QRsDcur_B0C+yG_JwI37uw");
internal static readonly GlobalObjectKey IdCostessecund_reales_Ind_debl = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*OyICjtJR7UC231mytrWFSw");
internal static readonly GlobalObjectKey IdIngresosreales_Ind_debloqueo = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*A3X8IcmEb0Cgif0A_6P9+g");
internal static readonly GlobalObjectKey IdActualiz_comprom__Ind_debloq = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*cAeE8QS6jUKxp9nwFSgQkg");
internal static readonly GlobalObjectKey IdCostesprimariosplan_Ind_debl = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*KUmRpLD1ykK4MvuQEd0roA");
internal static readonly GlobalObjectKey IdCostessecund_plan_Ind_debloq = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*dmUidEBj3ECIyZTtvBojcw");
internal static readonly GlobalObjectKey IdIngresosplan_Ind_debloqueo_ = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*YDJrKkM8w0O+rlCWvmzLkA");
internal static readonly GlobalObjectKey IdAutor = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*1We+XMIllkKVAGAOZndL9g");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*5ymvuXYPM0SW3r2kzDRdGw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*kykJ9Z02nkOGOxrnQE8DWg");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*2t3hR+qazUSRVEQSjcTnWw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*MRf6YovHvEaDQ28fho_Q+w");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*lFecP7F9gUC4gnAy63Lviw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(25,true);
          _ssId = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRegionId = value;
      }
  }
}

private long _ssCompanyId;
public long ssCompanyId{
  get{
      return _ssCompanyId;
  }
  set{
      if((_ssCompanyId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCompanyId = value;
      }
  }
}

private string _ssSoc_;
public string ssSoc_{
  get{
      return _ssSoc_;
  }
  set{
      if((_ssSoc_!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssSoc_ = value;
      }
  }
}

private string _ssDiv_;
public string ssDiv_{
  get{
      return _ssDiv_;
  }
  set{
      if((_ssDiv_!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssDiv_ = value;
      }
  }
}

private string _ssArea;
public string ssArea{
  get{
      return _ssArea;
  }
  set{
      if((_ssArea!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssArea = value;
      }
  }
}

private string _ssCe_coste;
public string ssCe_coste{
  get{
      return _ssCe_coste;
  }
  set{
      if((_ssCe_coste!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCe_coste = value;
      }
  }
}

private string _ssCeBe;
public string ssCeBe{
  get{
      return _ssCeBe;
  }
  set{
      if((_ssCeBe!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCeBe = value;
      }
  }
}

private string _ssDenominacion;
public string ssDenominacion{
  get{
      return _ssDenominacion;
  }
  set{
      if((_ssDenominacion!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssDenominacion = value;
      }
  }
}

private string _ssDescripcion;
public string ssDescripcion{
  get{
      return _ssDescripcion;
  }
  set{
      if((_ssDescripcion!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssDescripcion = value;
      }
  }
}

private string _ssResponsable;
public string ssResponsable{
  get{
      return _ssResponsable;
  }
  set{
      if((_ssResponsable!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssResponsable = value;
      }
  }
}

private string _ssCeCo;
public string ssCeCo{
  get{
      return _ssCeCo;
  }
  set{
      if((_ssCeCo!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssCeCo = value;
      }
  }
}

private string _ssCostesprim_reales_Ind_debloq;
public string ssCostesprim_reales_Ind_debloq{
  get{
      return _ssCostesprim_reales_Ind_debloq;
  }
  set{
      if((_ssCostesprim_reales_Ind_debloq!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssCostesprim_reales_Ind_debloq = value;
      }
  }
}

private string _ssCostessecund_reales_Ind_debl;
public string ssCostessecund_reales_Ind_debl{
  get{
      return _ssCostessecund_reales_Ind_debl;
  }
  set{
      if((_ssCostessecund_reales_Ind_debl!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssCostessecund_reales_Ind_debl = value;
      }
  }
}

private string _ssIngresosreales_Ind_debloqueo;
public string ssIngresosreales_Ind_debloqueo{
  get{
      return _ssIngresosreales_Ind_debloqueo;
  }
  set{
      if((_ssIngresosreales_Ind_debloqueo!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssIngresosreales_Ind_debloqueo = value;
      }
  }
}

private string _ssActualiz_comprom__Ind_debloq;
public string ssActualiz_comprom__Ind_debloq{
  get{
      return _ssActualiz_comprom__Ind_debloq;
  }
  set{
      if((_ssActualiz_comprom__Ind_debloq!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssActualiz_comprom__Ind_debloq = value;
      }
  }
}

private string _ssCostesprimariosplan_Ind_debl;
public string ssCostesprimariosplan_Ind_debl{
  get{
      return _ssCostesprimariosplan_Ind_debl;
  }
  set{
      if((_ssCostesprimariosplan_Ind_debl!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssCostesprimariosplan_Ind_debl = value;
      }
  }
}

private string _ssCostessecund_plan_Ind_debloq;
public string ssCostessecund_plan_Ind_debloq{
  get{
      return _ssCostessecund_plan_Ind_debloq;
  }
  set{
      if((_ssCostessecund_plan_Ind_debloq!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssCostessecund_plan_Ind_debloq = value;
      }
  }
}

private string _ssIngresosplan_Ind_debloqueo_;
public string ssIngresosplan_Ind_debloqueo_{
  get{
      return _ssIngresosplan_Ind_debloqueo_;
  }
  set{
      if((_ssIngresosplan_Ind_debloqueo_!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssIngresosplan_Ind_debloqueo_ = value;
      }
  }
}

private string _ssAutor;
public string ssAutor{
  get{
      return _ssAutor;
  }
  set{
      if((_ssAutor!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssAutor = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssUpdatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssUpdatedBy = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssIsActive = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord() {
ChangedAttributes = new BitArray(25,true);
OptimizedAttributes = new BitArray(25,false);
_ssId = 0L;
_ssRegionId = 0L;
_ssCompanyId = 0L;
_ssSoc_ = "";
_ssDiv_ = "";
_ssArea = "";
_ssCe_coste = "";
_ssCeBe = "";
_ssDenominacion = "";
_ssDescripcion = "";
_ssResponsable = "";
_ssCeCo = "";
_ssCostesprim_reales_Ind_debloq = "";
_ssCostessecund_reales_Ind_debl = "";
_ssIngresosreales_Ind_debloqueo = "";
_ssActualiz_comprom__Ind_debloq = "";
_ssCostesprimariosplan_Ind_debl = "";
_ssCostessecund_plan_Ind_debloq = "";
_ssIngresosplan_Ind_debloqueo_ = "";
_ssAutor = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssIsActive = true;
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
ssId = r.ReadLongInteger(index++, "CostCenterSAP.Id", 0L);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "CostCenterSAP.RegionId", 0L);
ssCompanyId = r.ReadEntityReferenceLongInteger(index++, "CostCenterSAP.CompanyId", 0L);
ssSoc_ = r.ReadText(index++, "CostCenterSAP.Soc_", "");
ssDiv_ = r.ReadText(index++, "CostCenterSAP.Div_", "");
ssArea = r.ReadText(index++, "CostCenterSAP.Area", "");
ssCe_coste = r.ReadText(index++, "CostCenterSAP.Ce_coste", "");
ssCeBe = r.ReadText(index++, "CostCenterSAP.CeBe", "");
ssDenominacion = r.ReadText(index++, "CostCenterSAP.Denominacion", "");
ssDescripcion = r.ReadText(index++, "CostCenterSAP.Descripcion", "");
ssResponsable = r.ReadText(index++, "CostCenterSAP.Responsable", "");
ssCeCo = r.ReadText(index++, "CostCenterSAP.CeCo", "");
ssCostesprim_reales_Ind_debloq = r.ReadText(index++, "CostCenterSAP.Costesprim_reales_Ind_debloq", "");
ssCostessecund_reales_Ind_debl = r.ReadText(index++, "CostCenterSAP.Costessecund_reales_Ind_debl", "");
ssIngresosreales_Ind_debloqueo = r.ReadText(index++, "CostCenterSAP.Ingresosreales_Ind_debloqueo", "");
ssActualiz_comprom__Ind_debloq = r.ReadText(index++, "CostCenterSAP.Actualiz_comprom__Ind_debloq", "");
ssCostesprimariosplan_Ind_debl = r.ReadText(index++, "CostCenterSAP.Costesprimariosplan_Ind_debl", "");
ssCostessecund_plan_Ind_debloq = r.ReadText(index++, "CostCenterSAP.Costessecund_plan_Ind_debloq", "");
ssIngresosplan_Ind_debloqueo_ = r.ReadText(index++, "CostCenterSAP.Ingresosplan_Ind_debloqueo_", "");
ssAutor = r.ReadText(index++, "CostCenterSAP.Autor", "");
ssCreatedOn = r.ReadDateTime(index++, "CostCenterSAP.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "CostCenterSAP.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "CostCenterSAP.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "CostCenterSAP.UpdatedBy", "");
ssIsActive = r.ReadBoolean(index++, "CostCenterSAP.IsActive", true);
ChangedAttributes = new BitArray(25,false);
OptimizedAttributes = new BitArray(25,false);
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
public void ReadIM(EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord r) {
this = r;
}


public static bool operator == (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord a, EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
if (a.ssCompanyId != b.ssCompanyId) return false;
if (a.ssSoc_ != b.ssSoc_) return false;
if (a.ssDiv_ != b.ssDiv_) return false;
if (a.ssArea != b.ssArea) return false;
if (a.ssCe_coste != b.ssCe_coste) return false;
if (a.ssCeBe != b.ssCeBe) return false;
if (a.ssDenominacion != b.ssDenominacion) return false;
if (a.ssDescripcion != b.ssDescripcion) return false;
if (a.ssResponsable != b.ssResponsable) return false;
if (a.ssCeCo != b.ssCeCo) return false;
if (a.ssCostesprim_reales_Ind_debloq != b.ssCostesprim_reales_Ind_debloq) return false;
if (a.ssCostessecund_reales_Ind_debl != b.ssCostessecund_reales_Ind_debl) return false;
if (a.ssIngresosreales_Ind_debloqueo != b.ssIngresosreales_Ind_debloqueo) return false;
if (a.ssActualiz_comprom__Ind_debloq != b.ssActualiz_comprom__Ind_debloq) return false;
if (a.ssCostesprimariosplan_Ind_debl != b.ssCostesprimariosplan_Ind_debl) return false;
if (a.ssCostessecund_plan_Ind_debloq != b.ssCostessecund_plan_Ind_debloq) return false;
if (a.ssIngresosplan_Ind_debloqueo_ != b.ssIngresosplan_Ind_debloqueo_) return false;
if (a.ssAutor != b.ssAutor) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssIsActive != b.ssIsActive) return false;
return true;
}

public static bool operator != (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord a, EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)) return false;
return (this == (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRegionId.GetHashCode()
 ^ ssCompanyId.GetHashCode()
 ^ ssSoc_.GetHashCode()
 ^ ssDiv_.GetHashCode()
 ^ ssArea.GetHashCode()
 ^ ssCe_coste.GetHashCode()
 ^ ssCeBe.GetHashCode()
 ^ ssDenominacion.GetHashCode()
 ^ ssDescripcion.GetHashCode()
 ^ ssResponsable.GetHashCode()
 ^ ssCeCo.GetHashCode()
 ^ ssCostesprim_reales_Ind_debloq.GetHashCode()
 ^ ssCostessecund_reales_Ind_debl.GetHashCode()
 ^ ssIngresosreales_Ind_debloqueo.GetHashCode()
 ^ ssActualiz_comprom__Ind_debloq.GetHashCode()
 ^ ssCostesprimariosplan_Ind_debl.GetHashCode()
 ^ ssCostessecund_plan_Ind_debloq.GetHashCode()
 ^ ssIngresosplan_Ind_debloqueo_.GetHashCode()
 ^ ssAutor.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssIsActive.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord Duplicate() {
EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord t;
t._ssId = this._ssId;
t._ssRegionId = this._ssRegionId;
t._ssCompanyId = this._ssCompanyId;
t._ssSoc_ = this._ssSoc_;
t._ssDiv_ = this._ssDiv_;
t._ssArea = this._ssArea;
t._ssCe_coste = this._ssCe_coste;
t._ssCeBe = this._ssCeBe;
t._ssDenominacion = this._ssDenominacion;
t._ssDescripcion = this._ssDescripcion;
t._ssResponsable = this._ssResponsable;
t._ssCeCo = this._ssCeCo;
t._ssCostesprim_reales_Ind_debloq = this._ssCostesprim_reales_Ind_debloq;
t._ssCostessecund_reales_Ind_debl = this._ssCostessecund_reales_Ind_debl;
t._ssIngresosreales_Ind_debloqueo = this._ssIngresosreales_Ind_debloqueo;
t._ssActualiz_comprom__Ind_debloq = this._ssActualiz_comprom__Ind_debloq;
t._ssCostesprimariosplan_Ind_debl = this._ssCostesprimariosplan_Ind_debl;
t._ssCostessecund_plan_Ind_debloq = this._ssCostessecund_plan_Ind_debloq;
t._ssIngresosplan_Ind_debloqueo_ = this._ssIngresosplan_Ind_debloqueo_;
t._ssAutor = this._ssAutor;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssIsActive = this._ssIsActive;
t.ChangedAttributes = new BitArray(25);
t.OptimizedAttributes = new BitArray(25);
for(int i = 0; i < 25; i++){
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
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
} else if (head == "companyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyId")) variable.Value = ssCompanyId; else variable.Optimized = true;
} else if (head == "soc_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Soc_")) variable.Value = ssSoc_; else variable.Optimized = true;
} else if (head == "div_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Div_")) variable.Value = ssDiv_; else variable.Optimized = true;
} else if (head == "area") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Area")) variable.Value = ssArea; else variable.Optimized = true;
} else if (head == "ce_coste") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ce_coste")) variable.Value = ssCe_coste; else variable.Optimized = true;
} else if (head == "cebe") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CeBe")) variable.Value = ssCeBe; else variable.Optimized = true;
} else if (head == "denominacion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Denominacion")) variable.Value = ssDenominacion; else variable.Optimized = true;
} else if (head == "descripcion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Descripcion")) variable.Value = ssDescripcion; else variable.Optimized = true;
} else if (head == "responsable") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Responsable")) variable.Value = ssResponsable; else variable.Optimized = true;
} else if (head == "ceco") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CeCo")) variable.Value = ssCeCo; else variable.Optimized = true;
} else if (head == "costesprim_reales_ind_debloq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Costesprim_reales_Ind_debloq")) variable.Value = ssCostesprim_reales_Ind_debloq; else variable.Optimized = true;
} else if (head == "costessecund_reales_ind_debl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Costessecund_reales_Ind_debl")) variable.Value = ssCostessecund_reales_Ind_debl; else variable.Optimized = true;
} else if (head == "ingresosreales_ind_debloqueo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ingresosreales_Ind_debloqueo")) variable.Value = ssIngresosreales_Ind_debloqueo; else variable.Optimized = true;
} else if (head == "actualiz_comprom__ind_debloq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Actualiz_comprom__Ind_debloq")) variable.Value = ssActualiz_comprom__Ind_debloq; else variable.Optimized = true;
} else if (head == "costesprimariosplan_ind_debl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Costesprimariosplan_Ind_debl")) variable.Value = ssCostesprimariosplan_Ind_debl; else variable.Optimized = true;
} else if (head == "costessecund_plan_ind_debloq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Costessecund_plan_Ind_debloq")) variable.Value = ssCostessecund_plan_Ind_debloq; else variable.Optimized = true;
} else if (head == "ingresosplan_ind_debloqueo_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ingresosplan_Ind_debloqueo_")) variable.Value = ssIngresosplan_Ind_debloqueo_; else variable.Optimized = true;
} else if (head == "autor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Autor")) variable.Value = ssAutor; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCompanyId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdSoc_)) {
return ChangedAttributes[3];
}
if (key.Equals(IdDiv_)) {
return ChangedAttributes[4];
}
if (key.Equals(IdArea)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCe_coste)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCeBe)) {
return ChangedAttributes[7];
}
if (key.Equals(IdDenominacion)) {
return ChangedAttributes[8];
}
if (key.Equals(IdDescripcion)) {
return ChangedAttributes[9];
}
if (key.Equals(IdResponsable)) {
return ChangedAttributes[10];
}
if (key.Equals(IdCeCo)) {
return ChangedAttributes[11];
}
if (key.Equals(IdCostesprim_reales_Ind_debloq)) {
return ChangedAttributes[12];
}
if (key.Equals(IdCostessecund_reales_Ind_debl)) {
return ChangedAttributes[13];
}
if (key.Equals(IdIngresosreales_Ind_debloqueo)) {
return ChangedAttributes[14];
}
if (key.Equals(IdActualiz_comprom__Ind_debloq)) {
return ChangedAttributes[15];
}
if (key.Equals(IdCostesprimariosplan_Ind_debl)) {
return ChangedAttributes[16];
}
if (key.Equals(IdCostessecund_plan_Ind_debloq)) {
return ChangedAttributes[17];
}
if (key.Equals(IdIngresosplan_Ind_debloqueo_)) {
return ChangedAttributes[18];
}
if (key.Equals(IdAutor)) {
return ChangedAttributes[19];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[20];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[21];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[22];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[23];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[24];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdCompanyId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdSoc_)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdDiv_)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdArea)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCe_coste)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCeBe)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdDenominacion)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdDescripcion)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdResponsable)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdCeCo)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdCostesprim_reales_Ind_debloq)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdCostessecund_reales_Ind_debl)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdIngresosreales_Ind_debloqueo)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdActualiz_comprom__Ind_debloq)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdCostesprimariosplan_Ind_debl)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdCostessecund_plan_Ind_debloq)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdIngresosplan_Ind_debloqueo_)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdAutor)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[24];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRegionId) {
return ssRegionId;
}
if (key == IdCompanyId) {
return ssCompanyId;
}
if (key == IdSoc_) {
return ssSoc_;
}
if (key == IdDiv_) {
return ssDiv_;
}
if (key == IdArea) {
return ssArea;
}
if (key == IdCe_coste) {
return ssCe_coste;
}
if (key == IdCeBe) {
return ssCeBe;
}
if (key == IdDenominacion) {
return ssDenominacion;
}
if (key == IdDescripcion) {
return ssDescripcion;
}
if (key == IdResponsable) {
return ssResponsable;
}
if (key == IdCeCo) {
return ssCeCo;
}
if (key == IdCostesprim_reales_Ind_debloq) {
return ssCostesprim_reales_Ind_debloq;
}
if (key == IdCostessecund_reales_Ind_debl) {
return ssCostessecund_reales_Ind_debl;
}
if (key == IdIngresosreales_Ind_debloqueo) {
return ssIngresosreales_Ind_debloqueo;
}
if (key == IdActualiz_comprom__Ind_debloq) {
return ssActualiz_comprom__Ind_debloq;
}
if (key == IdCostesprimariosplan_Ind_debl) {
return ssCostesprimariosplan_Ind_debl;
}
if (key == IdCostessecund_plan_Ind_debloq) {
return ssCostessecund_plan_Ind_debloq;
}
if (key == IdIngresosplan_Ind_debloqueo_) {
return ssIngresosplan_Ind_debloqueo_;
}
if (key == IdAutor) {
return ssAutor;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdIsActive) {
return ssIsActive;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
if (attributeKey == IdCompanyId.Key.AsGuid) {
return ssCompanyId;
}
if (attributeKey == IdSoc_.Key.AsGuid) {
return ssSoc_;
}
if (attributeKey == IdDiv_.Key.AsGuid) {
return ssDiv_;
}
if (attributeKey == IdArea.Key.AsGuid) {
return ssArea;
}
if (attributeKey == IdCe_coste.Key.AsGuid) {
return ssCe_coste;
}
if (attributeKey == IdCeBe.Key.AsGuid) {
return ssCeBe;
}
if (attributeKey == IdDenominacion.Key.AsGuid) {
return ssDenominacion;
}
if (attributeKey == IdDescripcion.Key.AsGuid) {
return ssDescripcion;
}
if (attributeKey == IdResponsable.Key.AsGuid) {
return ssResponsable;
}
if (attributeKey == IdCeCo.Key.AsGuid) {
return ssCeCo;
}
if (attributeKey == IdCostesprim_reales_Ind_debloq.Key.AsGuid) {
return ssCostesprim_reales_Ind_debloq;
}
if (attributeKey == IdCostessecund_reales_Ind_debl.Key.AsGuid) {
return ssCostessecund_reales_Ind_debl;
}
if (attributeKey == IdIngresosreales_Ind_debloqueo.Key.AsGuid) {
return ssIngresosreales_Ind_debloqueo;
}
if (attributeKey == IdActualiz_comprom__Ind_debloq.Key.AsGuid) {
return ssActualiz_comprom__Ind_debloq;
}
if (attributeKey == IdCostesprimariosplan_Ind_debl.Key.AsGuid) {
return ssCostesprimariosplan_Ind_debl;
}
if (attributeKey == IdCostessecund_plan_Ind_debloq.Key.AsGuid) {
return ssCostessecund_plan_Ind_debloq;
}
if (attributeKey == IdIngresosplan_Ind_debloqueo_.Key.AsGuid) {
return ssIngresosplan_Ind_debloqueo_;
}
if (attributeKey == IdAutor.Key.AsGuid) {
return ssAutor;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(25);
OptimizedAttributes = new BitArray(25);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRegionId);
ssCompanyId = (long) other.AttributeGet(IdCompanyId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCompanyId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCompanyId);
ssSoc_ = (string) other.AttributeGet(IdSoc_);
ChangedAttributes[3] = other.ChangedAttributeGet(IdSoc_);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdSoc_);
ssDiv_ = (string) other.AttributeGet(IdDiv_);
ChangedAttributes[4] = other.ChangedAttributeGet(IdDiv_);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdDiv_);
ssArea = (string) other.AttributeGet(IdArea);
ChangedAttributes[5] = other.ChangedAttributeGet(IdArea);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdArea);
ssCe_coste = (string) other.AttributeGet(IdCe_coste);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCe_coste);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCe_coste);
ssCeBe = (string) other.AttributeGet(IdCeBe);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCeBe);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCeBe);
ssDenominacion = (string) other.AttributeGet(IdDenominacion);
ChangedAttributes[8] = other.ChangedAttributeGet(IdDenominacion);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdDenominacion);
ssDescripcion = (string) other.AttributeGet(IdDescripcion);
ChangedAttributes[9] = other.ChangedAttributeGet(IdDescripcion);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdDescripcion);
ssResponsable = (string) other.AttributeGet(IdResponsable);
ChangedAttributes[10] = other.ChangedAttributeGet(IdResponsable);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdResponsable);
ssCeCo = (string) other.AttributeGet(IdCeCo);
ChangedAttributes[11] = other.ChangedAttributeGet(IdCeCo);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdCeCo);
ssCostesprim_reales_Ind_debloq = (string) other.AttributeGet(IdCostesprim_reales_Ind_debloq);
ChangedAttributes[12] = other.ChangedAttributeGet(IdCostesprim_reales_Ind_debloq);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdCostesprim_reales_Ind_debloq);
ssCostessecund_reales_Ind_debl = (string) other.AttributeGet(IdCostessecund_reales_Ind_debl);
ChangedAttributes[13] = other.ChangedAttributeGet(IdCostessecund_reales_Ind_debl);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdCostessecund_reales_Ind_debl);
ssIngresosreales_Ind_debloqueo = (string) other.AttributeGet(IdIngresosreales_Ind_debloqueo);
ChangedAttributes[14] = other.ChangedAttributeGet(IdIngresosreales_Ind_debloqueo);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdIngresosreales_Ind_debloqueo);
ssActualiz_comprom__Ind_debloq = (string) other.AttributeGet(IdActualiz_comprom__Ind_debloq);
ChangedAttributes[15] = other.ChangedAttributeGet(IdActualiz_comprom__Ind_debloq);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdActualiz_comprom__Ind_debloq);
ssCostesprimariosplan_Ind_debl = (string) other.AttributeGet(IdCostesprimariosplan_Ind_debl);
ChangedAttributes[16] = other.ChangedAttributeGet(IdCostesprimariosplan_Ind_debl);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdCostesprimariosplan_Ind_debl);
ssCostessecund_plan_Ind_debloq = (string) other.AttributeGet(IdCostessecund_plan_Ind_debloq);
ChangedAttributes[17] = other.ChangedAttributeGet(IdCostessecund_plan_Ind_debloq);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdCostessecund_plan_Ind_debloq);
ssIngresosplan_Ind_debloqueo_ = (string) other.AttributeGet(IdIngresosplan_Ind_debloqueo_);
ChangedAttributes[18] = other.ChangedAttributeGet(IdIngresosplan_Ind_debloqueo_);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdIngresosplan_Ind_debloqueo_);
ssAutor = (string) other.AttributeGet(IdAutor);
ChangedAttributes[19] = other.ChangedAttributeGet(IdAutor);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdAutor);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[20] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[21] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[22] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[23] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdUpdatedBy);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[24] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdIsActive);
}
} // EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord

/// <summary>
/// RecordList type <code>CostCenterSAPList</code> that represents a record list of
///  <code>CostCenterSAP</code>
/// </summary>
public partial class RL_f02111f6a8d8ffc0b8c4ceddca237e26 : GenericRecordList<EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord>, IEnumerable, IEnumerator {

protected override EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord GetElementDefaultValue() {
return new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public T[] ToArray<T>(Func<EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f02111f6a8d8ffc0b8c4ceddca237e26 recordList, Func<EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f02111f6a8d8ffc0b8c4ceddca237e26(EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord[] array) {
  RL_f02111f6a8d8ffc0b8c4ceddca237e26 result = new RL_f02111f6a8d8ffc0b8c4ceddca237e26();
result.InnerFromArray(array);
    return result;
}

public static RL_f02111f6a8d8ffc0b8c4ceddca237e26 ToList<T>(T[] array, Func <T, EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord> converter) {
  RL_f02111f6a8d8ffc0b8c4ceddca237e26 result = new RL_f02111f6a8d8ffc0b8c4ceddca237e26();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f02111f6a8d8ffc0b8c4ceddca237e26 FromRestList<T>(RestList<T> restList, Func <T, EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord> converter) {
  RL_f02111f6a8d8ffc0b8c4ceddca237e26 result = new RL_f02111f6a8d8ffc0b8c4ceddca237e26();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f02111f6a8d8ffc0b8c4ceddca237e26() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord> NewList() {
return new RL_f02111f6a8d8ffc0b8c4ceddca237e26();
}


} // RL_f02111f6a8d8ffc0b8c4ceddca237e26
}
