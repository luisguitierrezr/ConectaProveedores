namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (JZI+3UtneE+75Hnprqo2oQ)
///  <code>RC_c45ce7ee0ff58d891b8d78c9e2e835ad</code> that represent
/// s <code>InvoiceApprovalLevelIdInvoiceIdRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceApprovalLevelIdInvoiceIdRecord
public partial struct RC_c45ce7ee0ff58d891b8d78c9e2e835ad : ITypedRecord<RC_c45ce7ee0ff58d891b8d78c9e2e835ad> {
internal static readonly GlobalObjectKey IdInvoiceApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DCwQXPo08rxbZl5QxC0f2g");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FEYfrJuk3IJBHUZHMkXWrA");

public long ssInvoiceApprovalLevelId;

public long ssInvoiceId;


public BitArray OptimizedAttributes;

public RC_c45ce7ee0ff58d891b8d78c9e2e835ad() {
OptimizedAttributes = null;
ssInvoiceApprovalLevelId = 0L;
ssInvoiceId = 0L;
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
ssInvoiceApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevelIdInvoiceIdRecord.InvoiceApprovalLevelId", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevelIdInvoiceIdRecord.InvoiceId", 0L);
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
public void ReadIM(RC_c45ce7ee0ff58d891b8d78c9e2e835ad r) {
this = r;
}


public static bool operator == (RC_c45ce7ee0ff58d891b8d78c9e2e835ad a, RC_c45ce7ee0ff58d891b8d78c9e2e835ad b) {
if (a.ssInvoiceApprovalLevelId != b.ssInvoiceApprovalLevelId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
return true;
}

public static bool operator != (RC_c45ce7ee0ff58d891b8d78c9e2e835ad a, RC_c45ce7ee0ff58d891b8d78c9e2e835ad b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c45ce7ee0ff58d891b8d78c9e2e835ad)) return false;
return (this == (RC_c45ce7ee0ff58d891b8d78c9e2e835ad)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceApprovalLevelId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_c45ce7ee0ff58d891b8d78c9e2e835ad Duplicate() {
RC_c45ce7ee0ff58d891b8d78c9e2e835ad t;
t.ssInvoiceApprovalLevelId = this.ssInvoiceApprovalLevelId;
t.ssInvoiceId = this.ssInvoiceId;
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
if (head == "invoiceapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevelId")) variable.Value = ssInvoiceApprovalLevelId; else variable.Optimized = true;
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceApprovalLevelId) {
return ssInvoiceApprovalLevelId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceApprovalLevelId.Key.AsGuid) {
return ssInvoiceApprovalLevelId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceApprovalLevelId = (long) other.AttributeGet(IdInvoiceApprovalLevelId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
}
} // RC_c45ce7ee0ff58d891b8d78c9e2e835ad
/// <summary>
/// RecordList type <code>InvoiceApprovalLevelIdInvoiceIdRecordList</code> that represents a record
///  list of <code>InvoiceApprovalLevelIdentifier, InvoiceIdentifier</code>
/// </summary>
public partial class RL_12444f18cbf938e5a637c66b266df871 : GenericRecordList<RC_c45ce7ee0ff58d891b8d78c9e2e835ad>, IEnumerable, IEnumerator {

protected override RC_c45ce7ee0ff58d891b8d78c9e2e835ad GetElementDefaultValue() {
return new RC_c45ce7ee0ff58d891b8d78c9e2e835ad();
}

public T[] ToArray<T>(Func<RC_c45ce7ee0ff58d891b8d78c9e2e835ad, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_12444f18cbf938e5a637c66b266df871 recordList, Func<RC_c45ce7ee0ff58d891b8d78c9e2e835ad, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_12444f18cbf938e5a637c66b266df871(RC_c45ce7ee0ff58d891b8d78c9e2e835ad[] array) {
  RL_12444f18cbf938e5a637c66b266df871 result = new RL_12444f18cbf938e5a637c66b266df871();
result.InnerFromArray(array);
    return result;
}

public static RL_12444f18cbf938e5a637c66b266df871 ToList<T>(T[] array, Func <T, RC_c45ce7ee0ff58d891b8d78c9e2e835ad> converter) {
  RL_12444f18cbf938e5a637c66b266df871 result = new RL_12444f18cbf938e5a637c66b266df871();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_12444f18cbf938e5a637c66b266df871 FromRestList<T>(RestList<T> restList, Func <T, RC_c45ce7ee0ff58d891b8d78c9e2e835ad> converter) {
  RL_12444f18cbf938e5a637c66b266df871 result = new RL_12444f18cbf938e5a637c66b266df871();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_12444f18cbf938e5a637c66b266df871() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c45ce7ee0ff58d891b8d78c9e2e835ad> NewList() {
return new RL_12444f18cbf938e5a637c66b266df871();
}


} // RL_12444f18cbf938e5a637c66b266df871
}

