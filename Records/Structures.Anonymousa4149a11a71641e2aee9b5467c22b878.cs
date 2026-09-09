namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EZoUpBan4kGu6bVGfCK4eA)
///  <code>RC_d39c50b1f75893246aa84db474d82d50</code> that represents <code>InvoiceQttSumRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceQttSumRecord
public partial struct RC_d39c50b1f75893246aa84db474d82d50 : ITypedRecord<RC_d39c50b1f75893246aa84db474d82d50> {
internal static readonly GlobalObjectKey IdInvoiceQttSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sVCc01j3JJNqqE20dNgtUA");

public decimal ssInvoiceQttSum;


public BitArray OptimizedAttributes;

public RC_d39c50b1f75893246aa84db474d82d50() {
OptimizedAttributes = null;
ssInvoiceQttSum = 0.0M;
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
ssInvoiceQttSum = r.ReadDecimal(index++, "InvoiceQttSumRecord.InvoiceQttSum", 0.0M);
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
public void ReadIM(RC_d39c50b1f75893246aa84db474d82d50 r) {
this = r;
}


public static bool operator == (RC_d39c50b1f75893246aa84db474d82d50 a, RC_d39c50b1f75893246aa84db474d82d50 b) {
if (a.ssInvoiceQttSum != b.ssInvoiceQttSum) return false;
return true;
}

public static bool operator != (RC_d39c50b1f75893246aa84db474d82d50 a, RC_d39c50b1f75893246aa84db474d82d50 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d39c50b1f75893246aa84db474d82d50)) return false;
return (this == (RC_d39c50b1f75893246aa84db474d82d50)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceQttSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_d39c50b1f75893246aa84db474d82d50 Duplicate() {
RC_d39c50b1f75893246aa84db474d82d50 t;
t.ssInvoiceQttSum = this.ssInvoiceQttSum;
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
if (head == "invoiceqttsum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceQttSum")) variable.Value = ssInvoiceQttSum; else variable.Optimized = true;
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
if (key == IdInvoiceQttSum) {
return ssInvoiceQttSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceQttSum.Key.AsGuid) {
return ssInvoiceQttSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceQttSum = (decimal) other.AttributeGet(IdInvoiceQttSum);
}
} // RC_d39c50b1f75893246aa84db474d82d50
/// <summary>
/// RecordList type <code>InvoiceQttSumRecordList</code> that represents a record list of
///  <code>Decimal</code>
/// </summary>
public partial class RL_f09a54b116410a7027db4eb30998df1e : GenericRecordList<RC_d39c50b1f75893246aa84db474d82d50>, IEnumerable, IEnumerator {

protected override RC_d39c50b1f75893246aa84db474d82d50 GetElementDefaultValue() {
return new RC_d39c50b1f75893246aa84db474d82d50();
}

public T[] ToArray<T>(Func<RC_d39c50b1f75893246aa84db474d82d50, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f09a54b116410a7027db4eb30998df1e recordList, Func<RC_d39c50b1f75893246aa84db474d82d50, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f09a54b116410a7027db4eb30998df1e(RC_d39c50b1f75893246aa84db474d82d50[] array) {
  RL_f09a54b116410a7027db4eb30998df1e result = new RL_f09a54b116410a7027db4eb30998df1e();
result.InnerFromArray(array);
    return result;
}

public static RL_f09a54b116410a7027db4eb30998df1e ToList<T>(T[] array, Func <T, RC_d39c50b1f75893246aa84db474d82d50> converter) {
  RL_f09a54b116410a7027db4eb30998df1e result = new RL_f09a54b116410a7027db4eb30998df1e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f09a54b116410a7027db4eb30998df1e FromRestList<T>(RestList<T> restList, Func <T, RC_d39c50b1f75893246aa84db474d82d50> converter) {
  RL_f09a54b116410a7027db4eb30998df1e result = new RL_f09a54b116410a7027db4eb30998df1e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f09a54b116410a7027db4eb30998df1e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d39c50b1f75893246aa84db474d82d50> NewList() {
return new RL_f09a54b116410a7027db4eb30998df1e();
}


} // RL_f09a54b116410a7027db4eb30998df1e
}

