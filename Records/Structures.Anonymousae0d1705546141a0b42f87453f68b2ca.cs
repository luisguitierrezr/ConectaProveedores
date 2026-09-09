namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BRcNrmFUoEG0L4dFP2iyyg)
///  <code>RC_a542803a75b19356be8279fb269e55fb</code> that represent
/// s <code>InvoiceApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceApprovalLevelRecord
public partial struct RC_a542803a75b19356be8279fb269e55fb : ITypedRecord<RC_a542803a75b19356be8279fb269e55fb> {
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public static implicit operator EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord( RC_a542803a75b19356be8279fb269e55fb r) {
return r.ssENInvoiceApprovalLevel;
}

public static implicit operator RC_a542803a75b19356be8279fb269e55fb (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord r) {
RC_a542803a75b19356be8279fb269e55fb res = new RC_a542803a75b19356be8279fb269e55fb ();
res.ssENInvoiceApprovalLevel = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceApprovalLevel.ChangedAttributes = value;
}
get {
    return ssENInvoiceApprovalLevel.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a542803a75b19356be8279fb269e55fb() {
OptimizedAttributes = null;
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_a542803a75b19356be8279fb269e55fb r) {
this = r;
}


public static bool operator == (RC_a542803a75b19356be8279fb269e55fb a, RC_a542803a75b19356be8279fb269e55fb b) {
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_a542803a75b19356be8279fb269e55fb a, RC_a542803a75b19356be8279fb269e55fb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a542803a75b19356be8279fb269e55fb)) return false;
return (this == (RC_a542803a75b19356be8279fb269e55fb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_a542803a75b19356be8279fb269e55fb Duplicate() {
RC_a542803a75b19356be8279fb269e55fb t;
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
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
if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceApprovalLevel.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceApprovalLevel.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_a542803a75b19356be8279fb269e55fb
/// <summary>
/// RecordList type <code>InvoiceApprovalLevelRecordList</code> that represents a record list of
///  <code>InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_b2132c93db5fd1f839353b7412eed8f5 : GenericRecordList<RC_a542803a75b19356be8279fb269e55fb>, IEnumerable, IEnumerator {

protected override RC_a542803a75b19356be8279fb269e55fb GetElementDefaultValue() {
return new RC_a542803a75b19356be8279fb269e55fb();
}

public T[] ToArray<T>(Func<RC_a542803a75b19356be8279fb269e55fb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b2132c93db5fd1f839353b7412eed8f5 recordList, Func<RC_a542803a75b19356be8279fb269e55fb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b2132c93db5fd1f839353b7412eed8f5(RC_a542803a75b19356be8279fb269e55fb[] array) {
  RL_b2132c93db5fd1f839353b7412eed8f5 result = new RL_b2132c93db5fd1f839353b7412eed8f5();
result.InnerFromArray(array);
    return result;
}

public static RL_b2132c93db5fd1f839353b7412eed8f5 ToList<T>(T[] array, Func <T, RC_a542803a75b19356be8279fb269e55fb> converter) {
  RL_b2132c93db5fd1f839353b7412eed8f5 result = new RL_b2132c93db5fd1f839353b7412eed8f5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b2132c93db5fd1f839353b7412eed8f5 FromRestList<T>(RestList<T> restList, Func <T, RC_a542803a75b19356be8279fb269e55fb> converter) {
  RL_b2132c93db5fd1f839353b7412eed8f5 result = new RL_b2132c93db5fd1f839353b7412eed8f5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b2132c93db5fd1f839353b7412eed8f5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a542803a75b19356be8279fb269e55fb> NewList() {
return new RL_b2132c93db5fd1f839353b7412eed8f5();
}


} // RL_b2132c93db5fd1f839353b7412eed8f5
}

