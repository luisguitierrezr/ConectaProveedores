namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2+Kca9LvuEequJ_rCRxnrQ)
///  <code>RC_8d2c7f494e763d54feb138104c341adb</code> that represent
/// s <code>InvoiceAccountingProcessResponseRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingProcessResponseRecord
public partial struct RC_8d2c7f494e763d54feb138104c341adb : ITypedRecord<RC_8d2c7f494e763d54feb138104c341adb> {
internal static readonly GlobalObjectKey IdInvoiceAccountingProcessResponse = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SX8sjXZOVD3+sTgQTDQa2w");

public EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord ssENInvoiceAccountingProcessResponse;


public static implicit operator EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord( RC_8d2c7f494e763d54feb138104c341adb r) {
return r.ssENInvoiceAccountingProcessResponse;
}

public static implicit operator RC_8d2c7f494e763d54feb138104c341adb (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord r) {
RC_8d2c7f494e763d54feb138104c341adb res = new RC_8d2c7f494e763d54feb138104c341adb ();
res.ssENInvoiceAccountingProcessResponse = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceAccountingProcessResponse.ChangedAttributes = value;
}
get {
    return ssENInvoiceAccountingProcessResponse.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8d2c7f494e763d54feb138104c341adb() {
OptimizedAttributes = null;
ssENInvoiceAccountingProcessResponse = new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingProcessResponse.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccountingProcessResponse.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccountingProcessResponse.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccountingProcessResponse.Read( r, ref index);
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
public void ReadIM(RC_8d2c7f494e763d54feb138104c341adb r) {
this = r;
}


public static bool operator == (RC_8d2c7f494e763d54feb138104c341adb a, RC_8d2c7f494e763d54feb138104c341adb b) {
if (a.ssENInvoiceAccountingProcessResponse != b.ssENInvoiceAccountingProcessResponse) return false;
return true;
}

public static bool operator != (RC_8d2c7f494e763d54feb138104c341adb a, RC_8d2c7f494e763d54feb138104c341adb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8d2c7f494e763d54feb138104c341adb)) return false;
return (this == (RC_8d2c7f494e763d54feb138104c341adb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingProcessResponse.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingProcessResponse.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingProcessResponse.InternalRecursiveSave();
}


public RC_8d2c7f494e763d54feb138104c341adb Duplicate() {
RC_8d2c7f494e763d54feb138104c341adb t;
t.ssENInvoiceAccountingProcessResponse = (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord)this.ssENInvoiceAccountingProcessResponse.Duplicate();
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
if (head == "invoiceaccountingprocessresponse") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcessResponse")) variable.Value = ssENInvoiceAccountingProcessResponse; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocessresponse");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcessResponse.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcessResponse.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingProcessResponse) {
return ssENInvoiceAccountingProcessResponse;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingProcessResponse.Key.AsGuid) {
return ssENInvoiceAccountingProcessResponse;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingProcessResponse.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcessResponse));
}
} // RC_8d2c7f494e763d54feb138104c341adb
/// <summary>
/// RecordList type <code>InvoiceAccountingProcessResponseRecordList</code> that represents a record
///  list of <code>InvoiceAccountingProcessResponse</code>
/// </summary>
public partial class RL_c523bce2fb9ae799ea203ce8adb1c163 : GenericRecordList<RC_8d2c7f494e763d54feb138104c341adb>, IEnumerable, IEnumerator {

protected override RC_8d2c7f494e763d54feb138104c341adb GetElementDefaultValue() {
return new RC_8d2c7f494e763d54feb138104c341adb();
}

public T[] ToArray<T>(Func<RC_8d2c7f494e763d54feb138104c341adb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c523bce2fb9ae799ea203ce8adb1c163 recordList, Func<RC_8d2c7f494e763d54feb138104c341adb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c523bce2fb9ae799ea203ce8adb1c163(RC_8d2c7f494e763d54feb138104c341adb[] array) {
  RL_c523bce2fb9ae799ea203ce8adb1c163 result = new RL_c523bce2fb9ae799ea203ce8adb1c163();
result.InnerFromArray(array);
    return result;
}

public static RL_c523bce2fb9ae799ea203ce8adb1c163 ToList<T>(T[] array, Func <T, RC_8d2c7f494e763d54feb138104c341adb> converter) {
  RL_c523bce2fb9ae799ea203ce8adb1c163 result = new RL_c523bce2fb9ae799ea203ce8adb1c163();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c523bce2fb9ae799ea203ce8adb1c163 FromRestList<T>(RestList<T> restList, Func <T, RC_8d2c7f494e763d54feb138104c341adb> converter) {
  RL_c523bce2fb9ae799ea203ce8adb1c163 result = new RL_c523bce2fb9ae799ea203ce8adb1c163();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c523bce2fb9ae799ea203ce8adb1c163() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8d2c7f494e763d54feb138104c341adb> NewList() {
return new RL_c523bce2fb9ae799ea203ce8adb1c163();
}


} // RL_c523bce2fb9ae799ea203ce8adb1c163
}

