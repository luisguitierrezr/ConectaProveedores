namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2v1FCkFaHE2Ya7_PiFrNyw)
///  <code>RC_a2551032116fa7acb5fb1896fd9acdf2</code> that represent
/// s <code>InvoiceStatusHistoryRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceStatusHistoryRecord
public partial struct RC_a2551032116fa7acb5fb1896fd9acdf2 : ITypedRecord<RC_a2551032116fa7acb5fb1896fd9acdf2> {
internal static readonly GlobalObjectKey IdInvoiceStatusHistory = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MhBVom8RrKe1+xiW_ZrN8g");

public EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord ssENInvoiceStatusHistory;


public static implicit operator EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord( RC_a2551032116fa7acb5fb1896fd9acdf2 r) {
return r.ssENInvoiceStatusHistory;
}

public static implicit operator RC_a2551032116fa7acb5fb1896fd9acdf2 (EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord r) {
RC_a2551032116fa7acb5fb1896fd9acdf2 res = new RC_a2551032116fa7acb5fb1896fd9acdf2 ();
res.ssENInvoiceStatusHistory = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceStatusHistory.ChangedAttributes = value;
}
get {
    return ssENInvoiceStatusHistory.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a2551032116fa7acb5fb1896fd9acdf2() {
OptimizedAttributes = null;
ssENInvoiceStatusHistory = new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceStatusHistory.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceStatusHistory.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceStatusHistory.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceStatusHistory.Read( r, ref index);
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
public void ReadIM(RC_a2551032116fa7acb5fb1896fd9acdf2 r) {
this = r;
}


public static bool operator == (RC_a2551032116fa7acb5fb1896fd9acdf2 a, RC_a2551032116fa7acb5fb1896fd9acdf2 b) {
if (a.ssENInvoiceStatusHistory != b.ssENInvoiceStatusHistory) return false;
return true;
}

public static bool operator != (RC_a2551032116fa7acb5fb1896fd9acdf2 a, RC_a2551032116fa7acb5fb1896fd9acdf2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a2551032116fa7acb5fb1896fd9acdf2)) return false;
return (this == (RC_a2551032116fa7acb5fb1896fd9acdf2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceStatusHistory.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceStatusHistory.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceStatusHistory.InternalRecursiveSave();
}


public RC_a2551032116fa7acb5fb1896fd9acdf2 Duplicate() {
RC_a2551032116fa7acb5fb1896fd9acdf2 t;
t.ssENInvoiceStatusHistory = (EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord)this.ssENInvoiceStatusHistory.Duplicate();
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
if (head == "invoicestatushistory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatusHistory")) variable.Value = ssENInvoiceStatusHistory; else variable.Optimized = true;
variable.SetFieldName("invoicestatushistory");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceStatusHistory.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceStatusHistory.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceStatusHistory) {
return ssENInvoiceStatusHistory;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceStatusHistory.Key.AsGuid) {
return ssENInvoiceStatusHistory;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceStatusHistory.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatusHistory));
}
} // RC_a2551032116fa7acb5fb1896fd9acdf2
/// <summary>
/// RecordList type <code>InvoiceStatusHistoryRecordList</code> that represents a record list of
///  <code>InvoiceStatusHistory</code>
/// </summary>
public partial class RL_61b7015322a190028a6e9742f654db41 : GenericRecordList<RC_a2551032116fa7acb5fb1896fd9acdf2>, IEnumerable, IEnumerator {

protected override RC_a2551032116fa7acb5fb1896fd9acdf2 GetElementDefaultValue() {
return new RC_a2551032116fa7acb5fb1896fd9acdf2();
}

public T[] ToArray<T>(Func<RC_a2551032116fa7acb5fb1896fd9acdf2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_61b7015322a190028a6e9742f654db41 recordList, Func<RC_a2551032116fa7acb5fb1896fd9acdf2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_61b7015322a190028a6e9742f654db41(RC_a2551032116fa7acb5fb1896fd9acdf2[] array) {
  RL_61b7015322a190028a6e9742f654db41 result = new RL_61b7015322a190028a6e9742f654db41();
result.InnerFromArray(array);
    return result;
}

public static RL_61b7015322a190028a6e9742f654db41 ToList<T>(T[] array, Func <T, RC_a2551032116fa7acb5fb1896fd9acdf2> converter) {
  RL_61b7015322a190028a6e9742f654db41 result = new RL_61b7015322a190028a6e9742f654db41();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_61b7015322a190028a6e9742f654db41 FromRestList<T>(RestList<T> restList, Func <T, RC_a2551032116fa7acb5fb1896fd9acdf2> converter) {
  RL_61b7015322a190028a6e9742f654db41 result = new RL_61b7015322a190028a6e9742f654db41();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_61b7015322a190028a6e9742f654db41() : base() {
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
protected override OSList<RC_a2551032116fa7acb5fb1896fd9acdf2> NewList() {
return new RL_61b7015322a190028a6e9742f654db41();
}


} // RL_61b7015322a190028a6e9742f654db41
}

