namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EKJJN2qiQEKsh9H5WduflA)
///  <code>RC_466f18b870f78193989904128fc2d15c</code> that represent
/// s <code>InvoiceExtendedReceiverRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedReceiverRecord
public partial struct RC_466f18b870f78193989904128fc2d15c : ITypedRecord<RC_466f18b870f78193989904128fc2d15c> {
internal static readonly GlobalObjectKey IdInvoiceExtendedReceiver = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uBhvRvdwk4GYmQQSj8LRXA");

public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord ssENInvoiceExtendedReceiver;


public static implicit operator EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord( RC_466f18b870f78193989904128fc2d15c r) {
return r.ssENInvoiceExtendedReceiver;
}

public static implicit operator RC_466f18b870f78193989904128fc2d15c (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord r) {
RC_466f18b870f78193989904128fc2d15c res = new RC_466f18b870f78193989904128fc2d15c ();
res.ssENInvoiceExtendedReceiver = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedReceiver.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedReceiver.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_466f18b870f78193989904128fc2d15c() {
OptimizedAttributes = null;
ssENInvoiceExtendedReceiver = new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedReceiver.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedReceiver.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedReceiver.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedReceiver.Read( r, ref index);
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
public void ReadIM(RC_466f18b870f78193989904128fc2d15c r) {
this = r;
}


public static bool operator == (RC_466f18b870f78193989904128fc2d15c a, RC_466f18b870f78193989904128fc2d15c b) {
if (a.ssENInvoiceExtendedReceiver != b.ssENInvoiceExtendedReceiver) return false;
return true;
}

public static bool operator != (RC_466f18b870f78193989904128fc2d15c a, RC_466f18b870f78193989904128fc2d15c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_466f18b870f78193989904128fc2d15c)) return false;
return (this == (RC_466f18b870f78193989904128fc2d15c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedReceiver.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedReceiver.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedReceiver.InternalRecursiveSave();
}


public RC_466f18b870f78193989904128fc2d15c Duplicate() {
RC_466f18b870f78193989904128fc2d15c t;
t.ssENInvoiceExtendedReceiver = (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord)this.ssENInvoiceExtendedReceiver.Duplicate();
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
if (head == "invoiceextendedreceiver") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedReceiver")) variable.Value = ssENInvoiceExtendedReceiver; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedreceiver");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedReceiver.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedReceiver.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedReceiver) {
return ssENInvoiceExtendedReceiver;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedReceiver.Key.AsGuid) {
return ssENInvoiceExtendedReceiver;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedReceiver.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedReceiver));
}
} // RC_466f18b870f78193989904128fc2d15c
/// <summary>
/// RecordList type <code>InvoiceExtendedReceiverRecordList</code> that represents a record list of
///  <code>InvoiceExtendedReceiver</code>
/// </summary>
public partial class RL_1c4a39fc53e61bce46c269ec1ce49b95 : GenericRecordList<RC_466f18b870f78193989904128fc2d15c>, IEnumerable, IEnumerator {

protected override RC_466f18b870f78193989904128fc2d15c GetElementDefaultValue() {
return new RC_466f18b870f78193989904128fc2d15c();
}

public T[] ToArray<T>(Func<RC_466f18b870f78193989904128fc2d15c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1c4a39fc53e61bce46c269ec1ce49b95 recordList, Func<RC_466f18b870f78193989904128fc2d15c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1c4a39fc53e61bce46c269ec1ce49b95(RC_466f18b870f78193989904128fc2d15c[] array) {
  RL_1c4a39fc53e61bce46c269ec1ce49b95 result = new RL_1c4a39fc53e61bce46c269ec1ce49b95();
result.InnerFromArray(array);
    return result;
}

public static RL_1c4a39fc53e61bce46c269ec1ce49b95 ToList<T>(T[] array, Func <T, RC_466f18b870f78193989904128fc2d15c> converter) {
  RL_1c4a39fc53e61bce46c269ec1ce49b95 result = new RL_1c4a39fc53e61bce46c269ec1ce49b95();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1c4a39fc53e61bce46c269ec1ce49b95 FromRestList<T>(RestList<T> restList, Func <T, RC_466f18b870f78193989904128fc2d15c> converter) {
  RL_1c4a39fc53e61bce46c269ec1ce49b95 result = new RL_1c4a39fc53e61bce46c269ec1ce49b95();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1c4a39fc53e61bce46c269ec1ce49b95() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_466f18b870f78193989904128fc2d15c> NewList() {
return new RL_1c4a39fc53e61bce46c269ec1ce49b95();
}


} // RL_1c4a39fc53e61bce46c269ec1ce49b95
}

