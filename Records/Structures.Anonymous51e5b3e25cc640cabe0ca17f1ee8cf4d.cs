namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4rPlUcZcykC+DKF_HujPTQ)
///  <code>RC_85ff79276420f97ef98dc48e2b262e60</code> that represent
/// s <code>InvoiceAccountingEntriesRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingEntriesRecord
public partial struct RC_85ff79276420f97ef98dc48e2b262e60 : ITypedRecord<RC_85ff79276420f97ef98dc48e2b262e60> {
internal static readonly GlobalObjectKey IdInvoiceAccountingEntries = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*J3n_hSBkfvn5jcSOKyYuYA");

public EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord ssENInvoiceAccountingEntries;


public static implicit operator EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord( RC_85ff79276420f97ef98dc48e2b262e60 r) {
return r.ssENInvoiceAccountingEntries;
}

public static implicit operator RC_85ff79276420f97ef98dc48e2b262e60 (EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord r) {
RC_85ff79276420f97ef98dc48e2b262e60 res = new RC_85ff79276420f97ef98dc48e2b262e60 ();
res.ssENInvoiceAccountingEntries = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceAccountingEntries.ChangedAttributes = value;
}
get {
    return ssENInvoiceAccountingEntries.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_85ff79276420f97ef98dc48e2b262e60() {
OptimizedAttributes = null;
ssENInvoiceAccountingEntries = new EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(35,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingEntries.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccountingEntries.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccountingEntries.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccountingEntries.Read( r, ref index);
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
public void ReadIM(RC_85ff79276420f97ef98dc48e2b262e60 r) {
this = r;
}


public static bool operator == (RC_85ff79276420f97ef98dc48e2b262e60 a, RC_85ff79276420f97ef98dc48e2b262e60 b) {
if (a.ssENInvoiceAccountingEntries != b.ssENInvoiceAccountingEntries) return false;
return true;
}

public static bool operator != (RC_85ff79276420f97ef98dc48e2b262e60 a, RC_85ff79276420f97ef98dc48e2b262e60 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_85ff79276420f97ef98dc48e2b262e60)) return false;
return (this == (RC_85ff79276420f97ef98dc48e2b262e60)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingEntries.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingEntries.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingEntries.InternalRecursiveSave();
}


public RC_85ff79276420f97ef98dc48e2b262e60 Duplicate() {
RC_85ff79276420f97ef98dc48e2b262e60 t;
t.ssENInvoiceAccountingEntries = (EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord)this.ssENInvoiceAccountingEntries.Duplicate();
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
if (head == "invoiceaccountingentries") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingEntries")) variable.Value = ssENInvoiceAccountingEntries; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingentries");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingEntries.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingEntries.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingEntries) {
return ssENInvoiceAccountingEntries;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingEntries.Key.AsGuid) {
return ssENInvoiceAccountingEntries;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingEntries.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingEntries));
}
} // RC_85ff79276420f97ef98dc48e2b262e60
/// <summary>
/// RecordList type <code>InvoiceAccountingEntriesRecordList</code> that represents a record list of
///  <code>InvoiceAccountingEntries</code>
/// </summary>
public partial class RL_f5917f1dc841252de92dfa9bbe2bfadf : GenericRecordList<RC_85ff79276420f97ef98dc48e2b262e60>, IEnumerable, IEnumerator {

protected override RC_85ff79276420f97ef98dc48e2b262e60 GetElementDefaultValue() {
return new RC_85ff79276420f97ef98dc48e2b262e60();
}

public T[] ToArray<T>(Func<RC_85ff79276420f97ef98dc48e2b262e60, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f5917f1dc841252de92dfa9bbe2bfadf recordList, Func<RC_85ff79276420f97ef98dc48e2b262e60, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f5917f1dc841252de92dfa9bbe2bfadf(RC_85ff79276420f97ef98dc48e2b262e60[] array) {
  RL_f5917f1dc841252de92dfa9bbe2bfadf result = new RL_f5917f1dc841252de92dfa9bbe2bfadf();
result.InnerFromArray(array);
    return result;
}

public static RL_f5917f1dc841252de92dfa9bbe2bfadf ToList<T>(T[] array, Func <T, RC_85ff79276420f97ef98dc48e2b262e60> converter) {
  RL_f5917f1dc841252de92dfa9bbe2bfadf result = new RL_f5917f1dc841252de92dfa9bbe2bfadf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f5917f1dc841252de92dfa9bbe2bfadf FromRestList<T>(RestList<T> restList, Func <T, RC_85ff79276420f97ef98dc48e2b262e60> converter) {
  RL_f5917f1dc841252de92dfa9bbe2bfadf result = new RL_f5917f1dc841252de92dfa9bbe2bfadf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f5917f1dc841252de92dfa9bbe2bfadf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(35,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_85ff79276420f97ef98dc48e2b262e60> NewList() {
return new RL_f5917f1dc841252de92dfa9bbe2bfadf();
}


} // RL_f5917f1dc841252de92dfa9bbe2bfadf
}

