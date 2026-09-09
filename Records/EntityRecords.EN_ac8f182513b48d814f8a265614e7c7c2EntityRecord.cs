using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedItemTax (qhih4fsgik+IAQUTx_bgtg)
///  <code>EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord</code> that represent
/// s <code>InvoiceExtendedItemTax</code> <p>Description: Entity that holds Invoice Extended Irem
///  Tax.</p>
/// </summary>
// Name: InvoiceExtendedItemTax
public partial struct EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord : ITypedRecord<EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BFb3y0pT6EmdscBmmtZcSw");
internal static readonly GlobalObjectKey IdInvoiceExtendedItemId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HRedugNL90ayNRZLa_E1zg");
internal static readonly GlobalObjectKey IdInvoiceTaxTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*o4KHhKXHK0e4_v8SGfU9rw");
internal static readonly GlobalObjectKey IdImpuesto = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3May39qlp0eY3ajRHrvwuQ");
internal static readonly GlobalObjectKey IdBase = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*j92OG8cKh02uEOl6RDK2PQ");
internal static readonly GlobalObjectKey IdTasaOCuota = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rB45qqYmUUG_3CsFPfbS6w");
internal static readonly GlobalObjectKey IdImporte = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uN1Fn9qPe0eYfJnBM6dqpQ");
internal static readonly GlobalObjectKey IdTipoFactor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5iAnDXk40k2h0tgxsenEfg");

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

private long _ssInvoiceExtendedItemId;
public long ssInvoiceExtendedItemId{
  get{
      return _ssInvoiceExtendedItemId;
  }
  set{
      if((_ssInvoiceExtendedItemId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceExtendedItemId = value;
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

public EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssInvoiceExtendedItemId = 0L;
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
ssId = r.ReadLongInteger(index++, "InvoiceExtendedItemTax.Id", 0L);
ssInvoiceExtendedItemId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedItemTax.InvoiceExtendedItemId", 0L);
ssInvoiceTaxTypeId = r.ReadEntityReference(index++, "InvoiceExtendedItemTax.InvoiceTaxTypeId", 0);
ssImpuesto = r.ReadText(index++, "InvoiceExtendedItemTax.Impuesto", "");
ssBase = r.ReadDecimal(index++, "InvoiceExtendedItemTax.Base", 0.0M);
ssTasaOCuota = r.ReadDecimal(index++, "InvoiceExtendedItemTax.TasaOCuota", 0.0M);
ssImporte = r.ReadDecimal(index++, "InvoiceExtendedItemTax.Importe", 0.0M);
ssTipoFactor = r.ReadText(index++, "InvoiceExtendedItemTax.TipoFactor", "");
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
public void ReadIM(EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord r) {
this = r;
}


public static bool operator == (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord a, EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceExtendedItemId != b.ssInvoiceExtendedItemId) return false;
if (a.ssInvoiceTaxTypeId != b.ssInvoiceTaxTypeId) return false;
if (a.ssImpuesto != b.ssImpuesto) return false;
if (a.ssBase != b.ssBase) return false;
if (a.ssTasaOCuota != b.ssTasaOCuota) return false;
if (a.ssImporte != b.ssImporte) return false;
if (a.ssTipoFactor != b.ssTipoFactor) return false;
return true;
}

public static bool operator != (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord a, EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord)) return false;
return (this == (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceExtendedItemId.GetHashCode()
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


public EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord Duplicate() {
EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceExtendedItemId = this._ssInvoiceExtendedItemId;
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
} else if (head == "invoiceextendeditemid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedItemId")) variable.Value = ssInvoiceExtendedItemId; else variable.Optimized = true;
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
if (key.Equals(IdInvoiceExtendedItemId)) {
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
if (key.Equals(IdInvoiceExtendedItemId)) {
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
if (key == IdInvoiceExtendedItemId) {
return ssInvoiceExtendedItemId;
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
if (attributeKey == IdInvoiceExtendedItemId.Key.AsGuid) {
return ssInvoiceExtendedItemId;
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
ssInvoiceExtendedItemId = (long) other.AttributeGet(IdInvoiceExtendedItemId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceExtendedItemId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceExtendedItemId);
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
} // EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedItemTaxList</code> that represents a record list of
///  <code>InvoiceExtendedItemTax</code>
/// </summary>
public partial class RL_052a618537841aabfe590fb1dffa78ab : GenericRecordList<EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord>, IEnumerable, IEnumerator {

protected override EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord GetElementDefaultValue() {
return new EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord();
}

public T[] ToArray<T>(Func<EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_052a618537841aabfe590fb1dffa78ab recordList, Func<EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_052a618537841aabfe590fb1dffa78ab(EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord[] array) {
  RL_052a618537841aabfe590fb1dffa78ab result = new RL_052a618537841aabfe590fb1dffa78ab();
result.InnerFromArray(array);
    return result;
}

public static RL_052a618537841aabfe590fb1dffa78ab ToList<T>(T[] array, Func <T, EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord> converter) {
  RL_052a618537841aabfe590fb1dffa78ab result = new RL_052a618537841aabfe590fb1dffa78ab();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_052a618537841aabfe590fb1dffa78ab FromRestList<T>(RestList<T> restList, Func <T, EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord> converter) {
  RL_052a618537841aabfe590fb1dffa78ab result = new RL_052a618537841aabfe590fb1dffa78ab();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_052a618537841aabfe590fb1dffa78ab() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord> NewList() {
return new RL_052a618537841aabfe590fb1dffa78ab();
}


} // RL_052a618537841aabfe590fb1dffa78ab
}
