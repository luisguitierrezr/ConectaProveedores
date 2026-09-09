using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedTax (vCaOHNeT2EiY1E6vMVp3_w)
///  <code>EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord</code> that represent
/// s <code>InvoiceExtendedTax</code> <p>Description: Entity that holds Invoice Extended Tax.</p>
/// </summary>
// Name: InvoiceExtendedTax
public partial struct EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord : ITypedRecord<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DW5ru+2FwkWYpQgFiiL_iA");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KJVwmAOoXEmLN+1RBm2KJQ");
internal static readonly GlobalObjectKey IdInvoiceTaxTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pxKP4PAUPE656SdIZLRUsQ");
internal static readonly GlobalObjectKey IdImpuesto = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WGJgrO61ZUeJx1LauFlggg");
internal static readonly GlobalObjectKey IdBase = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LA_zKZ+dQ0aIcvQtcFESyw");
internal static readonly GlobalObjectKey IdTasaOCuota = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*V1v8L2Nryki2AYwk3UyXLQ");
internal static readonly GlobalObjectKey IdImporte = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*w8igBrxC+kiF1G5X5eIbgQ");
internal static readonly GlobalObjectKey IdTipoFactor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ocAXvUAAaU+xdzrOujAQIw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
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

private int _ssInvoiceTaxTypeId;
public int ssInvoiceTaxTypeId{
  get{
      return _ssInvoiceTaxTypeId;
  }
  set{
      if((_ssInvoiceTaxTypeId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssInvoiceTaxTypeId = value;
      }
  }
}

private string _ssImpuesto;
public string ssImpuesto{
  get{
      return _ssImpuesto;
  }
  set{
      if((_ssImpuesto!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssImpuesto = value;
      }
  }
}

private decimal _ssBase;
public decimal ssBase{
  get{
      return _ssBase;
  }
  set{
      if((_ssBase!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssBase = value;
      }
  }
}

private decimal _ssTasaOCuota;
public decimal ssTasaOCuota{
  get{
      return _ssTasaOCuota;
  }
  set{
      if((_ssTasaOCuota!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssTasaOCuota = value;
      }
  }
}

private decimal _ssImporte;
public decimal ssImporte{
  get{
      return _ssImporte;
  }
  set{
      if((_ssImporte!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssImporte = value;
      }
  }
}

private string _ssTipoFactor;
public string ssTipoFactor{
  get{
      return _ssTipoFactor;
  }
  set{
      if((_ssTipoFactor!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssTipoFactor = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssInvoiceTaxTypeId = 0;
_ssImpuesto = "";
_ssBase = 0.0M;
_ssTasaOCuota = 0.0M;
_ssImporte = 0.0M;
_ssTipoFactor = "";
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
ssId = r.ReadLongInteger(index++, "InvoiceExtendedTax.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedTax.InvoiceId", 0L);
ssInvoiceTaxTypeId = r.ReadEntityReference(index++, "InvoiceExtendedTax.InvoiceTaxTypeId", 0);
ssImpuesto = r.ReadText(index++, "InvoiceExtendedTax.Impuesto", "");
ssBase = r.ReadDecimal(index++, "InvoiceExtendedTax.Base", 0.0M);
ssTasaOCuota = r.ReadDecimal(index++, "InvoiceExtendedTax.TasaOCuota", 0.0M);
ssImporte = r.ReadDecimal(index++, "InvoiceExtendedTax.Importe", 0.0M);
ssTipoFactor = r.ReadText(index++, "InvoiceExtendedTax.TipoFactor", "");
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord r) {
this = r;
}


public static bool operator == (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord a, EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceTaxTypeId != b.ssInvoiceTaxTypeId) return false;
if (a.ssImpuesto != b.ssImpuesto) return false;
if (a.ssBase != b.ssBase) return false;
if (a.ssTasaOCuota != b.ssTasaOCuota) return false;
if (a.ssImporte != b.ssImporte) return false;
if (a.ssTipoFactor != b.ssTipoFactor) return false;
return true;
}

public static bool operator != (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord a, EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord)) return false;
return (this == (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceTaxTypeId.GetHashCode()
 ^ ssImpuesto.GetHashCode()
 ^ ssBase.GetHashCode()
 ^ ssTasaOCuota.GetHashCode()
 ^ ssImporte.GetHashCode()
 ^ ssTipoFactor.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord Duplicate() {
EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssInvoiceTaxTypeId = this._ssInvoiceTaxTypeId;
t._ssImpuesto = this._ssImpuesto;
t._ssBase = this._ssBase;
t._ssTasaOCuota = this._ssTasaOCuota;
t._ssImporte = this._ssImporte;
t._ssTipoFactor = this._ssTipoFactor;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
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
} else if (head == "invoicetaxtypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceTaxTypeId")) variable.Value = ssInvoiceTaxTypeId; else variable.Optimized = true;
} else if (head == "impuesto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Impuesto")) variable.Value = ssImpuesto; else variable.Optimized = true;
} else if (head == "base") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Base")) variable.Value = ssBase; else variable.Optimized = true;
} else if (head == "tasaocuota") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TasaOCuota")) variable.Value = ssTasaOCuota; else variable.Optimized = true;
} else if (head == "importe") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Importe")) variable.Value = ssImporte; else variable.Optimized = true;
} else if (head == "tipofactor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TipoFactor")) variable.Value = ssTipoFactor; else variable.Optimized = true;
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
if (key.Equals(IdInvoiceTaxTypeId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdImpuesto)) {
return ChangedAttributes[3];
}
if (key.Equals(IdBase)) {
return ChangedAttributes[4];
}
if (key.Equals(IdTasaOCuota)) {
return ChangedAttributes[5];
}
if (key.Equals(IdImporte)) {
return ChangedAttributes[6];
}
if (key.Equals(IdTipoFactor)) {
return ChangedAttributes[7];
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
if (key.Equals(IdInvoiceTaxTypeId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdImpuesto)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdBase)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdTasaOCuota)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdImporte)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdTipoFactor)) {
return OptimizedAttributes[7];
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
if (key == IdInvoiceTaxTypeId) {
return ssInvoiceTaxTypeId;
}
if (key == IdImpuesto) {
return ssImpuesto;
}
if (key == IdBase) {
return ssBase;
}
if (key == IdTasaOCuota) {
return ssTasaOCuota;
}
if (key == IdImporte) {
return ssImporte;
}
if (key == IdTipoFactor) {
return ssTipoFactor;
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
if (attributeKey == IdInvoiceTaxTypeId.Key.AsGuid) {
return ssInvoiceTaxTypeId;
}
if (attributeKey == IdImpuesto.Key.AsGuid) {
return ssImpuesto;
}
if (attributeKey == IdBase.Key.AsGuid) {
return ssBase;
}
if (attributeKey == IdTasaOCuota.Key.AsGuid) {
return ssTasaOCuota;
}
if (attributeKey == IdImporte.Key.AsGuid) {
return ssImporte;
}
if (attributeKey == IdTipoFactor.Key.AsGuid) {
return ssTipoFactor;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssInvoiceTaxTypeId = (int) other.AttributeGet(IdInvoiceTaxTypeId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdInvoiceTaxTypeId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInvoiceTaxTypeId);
ssImpuesto = (string) other.AttributeGet(IdImpuesto);
ChangedAttributes[3] = other.ChangedAttributeGet(IdImpuesto);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdImpuesto);
ssBase = (decimal) other.AttributeGet(IdBase);
ChangedAttributes[4] = other.ChangedAttributeGet(IdBase);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdBase);
ssTasaOCuota = (decimal) other.AttributeGet(IdTasaOCuota);
ChangedAttributes[5] = other.ChangedAttributeGet(IdTasaOCuota);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdTasaOCuota);
ssImporte = (decimal) other.AttributeGet(IdImporte);
ChangedAttributes[6] = other.ChangedAttributeGet(IdImporte);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdImporte);
ssTipoFactor = (string) other.AttributeGet(IdTipoFactor);
ChangedAttributes[7] = other.ChangedAttributeGet(IdTipoFactor);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdTipoFactor);
}
} // EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedTaxList</code> that represents a record list of
///  <code>InvoiceExtendedTax</code>
/// </summary>
public partial class RL_18908f1ccb5f6631454d810d9be77594 : GenericRecordList<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord>, IEnumerable, IEnumerator {

protected override EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord GetElementDefaultValue() {
return new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord();
}

public T[] ToArray<T>(Func<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_18908f1ccb5f6631454d810d9be77594 recordList, Func<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_18908f1ccb5f6631454d810d9be77594(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord[] array) {
  RL_18908f1ccb5f6631454d810d9be77594 result = new RL_18908f1ccb5f6631454d810d9be77594();
result.InnerFromArray(array);
    return result;
}

public static RL_18908f1ccb5f6631454d810d9be77594 ToList<T>(T[] array, Func <T, EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> converter) {
  RL_18908f1ccb5f6631454d810d9be77594 result = new RL_18908f1ccb5f6631454d810d9be77594();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_18908f1ccb5f6631454d810d9be77594 FromRestList<T>(RestList<T> restList, Func <T, EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> converter) {
  RL_18908f1ccb5f6631454d810d9be77594 result = new RL_18908f1ccb5f6631454d810d9be77594();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_18908f1ccb5f6631454d810d9be77594() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord> NewList() {
return new RL_18908f1ccb5f6631454d810d9be77594();
}


} // RL_18908f1ccb5f6631454d810d9be77594
}
