namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5X7w4pp5u0C2FzGLz9t+bg)
///  <code>RC_2512cd3cc7f986e36b4d5edf290d4383</code> that represents <code>InvoiceUsageRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceUsageRecord
public partial struct RC_2512cd3cc7f986e36b4d5edf290d4383 : ITypedRecord<RC_2512cd3cc7f986e36b4d5edf290d4383> {
internal static readonly GlobalObjectKey IdInvoiceUsage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PM0SJfnH44ZrTV7fKQ1Dgw");

public EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord ssENInvoiceUsage;


public static implicit operator EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord( RC_2512cd3cc7f986e36b4d5edf290d4383 r) {
return r.ssENInvoiceUsage;
}

public static implicit operator RC_2512cd3cc7f986e36b4d5edf290d4383 (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord r) {
RC_2512cd3cc7f986e36b4d5edf290d4383 res = new RC_2512cd3cc7f986e36b4d5edf290d4383 ();
res.ssENInvoiceUsage = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceUsage.ChangedAttributes = value;
}
get {
    return ssENInvoiceUsage.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2512cd3cc7f986e36b4d5edf290d4383() {
OptimizedAttributes = null;
ssENInvoiceUsage = new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceUsage.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceUsage.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceUsage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceUsage.Read( r, ref index);
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
public void ReadIM(RC_2512cd3cc7f986e36b4d5edf290d4383 r) {
this = r;
}


public static bool operator == (RC_2512cd3cc7f986e36b4d5edf290d4383 a, RC_2512cd3cc7f986e36b4d5edf290d4383 b) {
if (a.ssENInvoiceUsage != b.ssENInvoiceUsage) return false;
return true;
}

public static bool operator != (RC_2512cd3cc7f986e36b4d5edf290d4383 a, RC_2512cd3cc7f986e36b4d5edf290d4383 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2512cd3cc7f986e36b4d5edf290d4383)) return false;
return (this == (RC_2512cd3cc7f986e36b4d5edf290d4383)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceUsage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceUsage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceUsage.InternalRecursiveSave();
}


public RC_2512cd3cc7f986e36b4d5edf290d4383 Duplicate() {
RC_2512cd3cc7f986e36b4d5edf290d4383 t;
t.ssENInvoiceUsage = (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord)this.ssENInvoiceUsage.Duplicate();
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
if (head == "invoiceusage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsage")) variable.Value = ssENInvoiceUsage; else variable.Optimized = true;
variable.SetFieldName("invoiceusage");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceUsage.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceUsage.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceUsage) {
return ssENInvoiceUsage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceUsage.Key.AsGuid) {
return ssENInvoiceUsage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceUsage.FillFromOther((IRecord) other.AttributeGet(IdInvoiceUsage));
}
} // RC_2512cd3cc7f986e36b4d5edf290d4383
/// <summary>
/// RecordList type <code>InvoiceUsageRecordList</code> that represents a record list of
///  <code>InvoiceUsage</code>
/// </summary>
public partial class RL_1078cb2b44dad3e211c3325e839a4151 : GenericRecordList<RC_2512cd3cc7f986e36b4d5edf290d4383>, IEnumerable, IEnumerator {

protected override RC_2512cd3cc7f986e36b4d5edf290d4383 GetElementDefaultValue() {
return new RC_2512cd3cc7f986e36b4d5edf290d4383();
}

public T[] ToArray<T>(Func<RC_2512cd3cc7f986e36b4d5edf290d4383, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1078cb2b44dad3e211c3325e839a4151 recordList, Func<RC_2512cd3cc7f986e36b4d5edf290d4383, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1078cb2b44dad3e211c3325e839a4151(RC_2512cd3cc7f986e36b4d5edf290d4383[] array) {
  RL_1078cb2b44dad3e211c3325e839a4151 result = new RL_1078cb2b44dad3e211c3325e839a4151();
result.InnerFromArray(array);
    return result;
}

public static RL_1078cb2b44dad3e211c3325e839a4151 ToList<T>(T[] array, Func <T, RC_2512cd3cc7f986e36b4d5edf290d4383> converter) {
  RL_1078cb2b44dad3e211c3325e839a4151 result = new RL_1078cb2b44dad3e211c3325e839a4151();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1078cb2b44dad3e211c3325e839a4151 FromRestList<T>(RestList<T> restList, Func <T, RC_2512cd3cc7f986e36b4d5edf290d4383> converter) {
  RL_1078cb2b44dad3e211c3325e839a4151 result = new RL_1078cb2b44dad3e211c3325e839a4151();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1078cb2b44dad3e211c3325e839a4151() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2512cd3cc7f986e36b4d5edf290d4383> NewList() {
return new RL_1078cb2b44dad3e211c3325e839a4151();
}


} // RL_1078cb2b44dad3e211c3325e839a4151
}

