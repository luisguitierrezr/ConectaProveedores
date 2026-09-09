namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (n3AxZjQ06Uy66xyVDnV0Qg)
///  <code>RC_285d5103004edd69f9105c056eb9d2a6</code> that represent
/// s <code>InvoicePolizaStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoicePolizaStorageRecord
public partial struct RC_285d5103004edd69f9105c056eb9d2a6 : ITypedRecord<RC_285d5103004edd69f9105c056eb9d2a6> {
internal static readonly GlobalObjectKey IdInvoicePolizaStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*A1FdKE4Aad35EFwFbrnSpg");

public EN_c914a6fdb165c9751808adf2e01e2226EntityRecord ssENInvoicePolizaStorage;


public static implicit operator EN_c914a6fdb165c9751808adf2e01e2226EntityRecord( RC_285d5103004edd69f9105c056eb9d2a6 r) {
return r.ssENInvoicePolizaStorage;
}

public static implicit operator RC_285d5103004edd69f9105c056eb9d2a6 (EN_c914a6fdb165c9751808adf2e01e2226EntityRecord r) {
RC_285d5103004edd69f9105c056eb9d2a6 res = new RC_285d5103004edd69f9105c056eb9d2a6 ();
res.ssENInvoicePolizaStorage = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoicePolizaStorage.ChangedAttributes = value;
}
get {
    return ssENInvoicePolizaStorage.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_285d5103004edd69f9105c056eb9d2a6() {
OptimizedAttributes = null;
ssENInvoicePolizaStorage = new EN_c914a6fdb165c9751808adf2e01e2226EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoicePolizaStorage.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoicePolizaStorage.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoicePolizaStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoicePolizaStorage.Read( r, ref index);
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
public void ReadIM(RC_285d5103004edd69f9105c056eb9d2a6 r) {
this = r;
}


public static bool operator == (RC_285d5103004edd69f9105c056eb9d2a6 a, RC_285d5103004edd69f9105c056eb9d2a6 b) {
if (a.ssENInvoicePolizaStorage != b.ssENInvoicePolizaStorage) return false;
return true;
}

public static bool operator != (RC_285d5103004edd69f9105c056eb9d2a6 a, RC_285d5103004edd69f9105c056eb9d2a6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_285d5103004edd69f9105c056eb9d2a6)) return false;
return (this == (RC_285d5103004edd69f9105c056eb9d2a6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoicePolizaStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoicePolizaStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoicePolizaStorage.InternalRecursiveSave();
}


public RC_285d5103004edd69f9105c056eb9d2a6 Duplicate() {
RC_285d5103004edd69f9105c056eb9d2a6 t;
t.ssENInvoicePolizaStorage = (EN_c914a6fdb165c9751808adf2e01e2226EntityRecord)this.ssENInvoicePolizaStorage.Duplicate();
t.OptimizedAttributes = null;
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
if (head == "invoicepolizastorage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicePolizaStorage")) variable.Value = ssENInvoicePolizaStorage; else variable.Optimized = true;
variable.SetFieldName("invoicepolizastorage");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoicePolizaStorage.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoicePolizaStorage.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoicePolizaStorage) {
return ssENInvoicePolizaStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoicePolizaStorage.Key.AsGuid) {
return ssENInvoicePolizaStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoicePolizaStorage.FillFromOther((IRecord) other.AttributeGet(IdInvoicePolizaStorage));
}
} // RC_285d5103004edd69f9105c056eb9d2a6
/// <summary>
/// RecordList type <code>InvoicePolizaStorageRecordList</code> that represents a record list of
///  <code>InvoicePolizaStorage</code>
/// </summary>
public partial class RL_07ac56adaf714bda8c987b24888a8934 : GenericRecordList<RC_285d5103004edd69f9105c056eb9d2a6>, IEnumerable, IEnumerator {

protected override RC_285d5103004edd69f9105c056eb9d2a6 GetElementDefaultValue() {
return new RC_285d5103004edd69f9105c056eb9d2a6();
}

public T[] ToArray<T>(Func<RC_285d5103004edd69f9105c056eb9d2a6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_07ac56adaf714bda8c987b24888a8934 recordList, Func<RC_285d5103004edd69f9105c056eb9d2a6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_07ac56adaf714bda8c987b24888a8934(RC_285d5103004edd69f9105c056eb9d2a6[] array) {
  RL_07ac56adaf714bda8c987b24888a8934 result = new RL_07ac56adaf714bda8c987b24888a8934();
result.InnerFromArray(array);
    return result;
}

public static RL_07ac56adaf714bda8c987b24888a8934 ToList<T>(T[] array, Func <T, RC_285d5103004edd69f9105c056eb9d2a6> converter) {
  RL_07ac56adaf714bda8c987b24888a8934 result = new RL_07ac56adaf714bda8c987b24888a8934();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_07ac56adaf714bda8c987b24888a8934 FromRestList<T>(RestList<T> restList, Func <T, RC_285d5103004edd69f9105c056eb9d2a6> converter) {
  RL_07ac56adaf714bda8c987b24888a8934 result = new RL_07ac56adaf714bda8c987b24888a8934();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_07ac56adaf714bda8c987b24888a8934() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_285d5103004edd69f9105c056eb9d2a6> NewList() {
return new RL_07ac56adaf714bda8c987b24888a8934();
}


} // RL_07ac56adaf714bda8c987b24888a8934
}

