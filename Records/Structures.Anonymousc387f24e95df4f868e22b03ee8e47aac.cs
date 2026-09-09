namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (TvKHw9+Vhk+OIrA+6OR6rA)
///  <code>RC_d158748ead56eba288746615205b9a8e</code> that represent
/// s <code>InvoiceQttSumTotalPriceSumRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceQttSumTotalPriceSumRecord
public partial struct RC_d158748ead56eba288746615205b9a8e : ITypedRecord<RC_d158748ead56eba288746615205b9a8e> {
internal static readonly GlobalObjectKey IdInvoiceQttSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sVCc01j3JJNqqE20dNgtUA");
internal static readonly GlobalObjectKey IdTotalPriceSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WCM0b+nGuQqiq8scdJ4M4w");

public decimal ssInvoiceQttSum;

public decimal ssTotalPriceSum;


public BitArray OptimizedAttributes;

public RC_d158748ead56eba288746615205b9a8e() {
OptimizedAttributes = null;
ssInvoiceQttSum = 0.0M;
ssTotalPriceSum = 0.0M;
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
ssInvoiceQttSum = r.ReadDecimal(index++, "InvoiceQttSumTotalPriceSumRecord.InvoiceQttSum", 0.0M);
ssTotalPriceSum = r.ReadCurrency(index++, "InvoiceQttSumTotalPriceSumRecord.TotalPriceSum", 0.0M);
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
public void ReadIM(RC_d158748ead56eba288746615205b9a8e r) {
this = r;
}


public static bool operator == (RC_d158748ead56eba288746615205b9a8e a, RC_d158748ead56eba288746615205b9a8e b) {
if (a.ssInvoiceQttSum != b.ssInvoiceQttSum) return false;
if (a.ssTotalPriceSum != b.ssTotalPriceSum) return false;
return true;
}

public static bool operator != (RC_d158748ead56eba288746615205b9a8e a, RC_d158748ead56eba288746615205b9a8e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d158748ead56eba288746615205b9a8e)) return false;
return (this == (RC_d158748ead56eba288746615205b9a8e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceQttSum.GetHashCode()
 ^ ssTotalPriceSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_d158748ead56eba288746615205b9a8e Duplicate() {
RC_d158748ead56eba288746615205b9a8e t;
t.ssInvoiceQttSum = this.ssInvoiceQttSum;
t.ssTotalPriceSum = this.ssTotalPriceSum;
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
} else if (head == "totalpricesum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalPriceSum")) variable.Value = ssTotalPriceSum; else variable.Optimized = true;
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
if (key == IdTotalPriceSum) {
return ssTotalPriceSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceQttSum.Key.AsGuid) {
return ssInvoiceQttSum;
}
if (attributeKey == IdTotalPriceSum.Key.AsGuid) {
return ssTotalPriceSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceQttSum = (decimal) other.AttributeGet(IdInvoiceQttSum);
ssTotalPriceSum = (decimal) other.AttributeGet(IdTotalPriceSum);
}
} // RC_d158748ead56eba288746615205b9a8e
/// <summary>
/// RecordList type <code>InvoiceQttSumTotalPriceSumRecordList</code> that represents a record list of
///  <code>Decimal, Currency</code>
/// </summary>
public partial class RL_ea38cd17f0e5d232db6162f29d44a023 : GenericRecordList<RC_d158748ead56eba288746615205b9a8e>, IEnumerable, IEnumerator {

protected override RC_d158748ead56eba288746615205b9a8e GetElementDefaultValue() {
return new RC_d158748ead56eba288746615205b9a8e();
}

public T[] ToArray<T>(Func<RC_d158748ead56eba288746615205b9a8e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ea38cd17f0e5d232db6162f29d44a023 recordList, Func<RC_d158748ead56eba288746615205b9a8e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ea38cd17f0e5d232db6162f29d44a023(RC_d158748ead56eba288746615205b9a8e[] array) {
  RL_ea38cd17f0e5d232db6162f29d44a023 result = new RL_ea38cd17f0e5d232db6162f29d44a023();
result.InnerFromArray(array);
    return result;
}

public static RL_ea38cd17f0e5d232db6162f29d44a023 ToList<T>(T[] array, Func <T, RC_d158748ead56eba288746615205b9a8e> converter) {
  RL_ea38cd17f0e5d232db6162f29d44a023 result = new RL_ea38cd17f0e5d232db6162f29d44a023();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ea38cd17f0e5d232db6162f29d44a023 FromRestList<T>(RestList<T> restList, Func <T, RC_d158748ead56eba288746615205b9a8e> converter) {
  RL_ea38cd17f0e5d232db6162f29d44a023 result = new RL_ea38cd17f0e5d232db6162f29d44a023();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ea38cd17f0e5d232db6162f29d44a023() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d158748ead56eba288746615205b9a8e> NewList() {
return new RL_ea38cd17f0e5d232db6162f29d44a023();
}


} // RL_ea38cd17f0e5d232db6162f29d44a023
}

