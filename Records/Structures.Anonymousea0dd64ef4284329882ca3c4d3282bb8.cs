namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (TtYN6ij0KUOILKPE0ygruA)
///  <code>RC_6f342358c6e90ab9a2abcb1c749e0ce3</code> that represents <code>TotalPriceSumRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TotalPriceSumRecord
public partial struct RC_6f342358c6e90ab9a2abcb1c749e0ce3 : ITypedRecord<RC_6f342358c6e90ab9a2abcb1c749e0ce3> {
internal static readonly GlobalObjectKey IdTotalPriceSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WCM0b+nGuQqiq8scdJ4M4w");

public decimal ssTotalPriceSum;


public BitArray OptimizedAttributes;

public RC_6f342358c6e90ab9a2abcb1c749e0ce3() {
OptimizedAttributes = null;
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
ssTotalPriceSum = r.ReadCurrency(index++, "TotalPriceSumRecord.TotalPriceSum", 0.0M);
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
public void ReadIM(RC_6f342358c6e90ab9a2abcb1c749e0ce3 r) {
this = r;
}


public static bool operator == (RC_6f342358c6e90ab9a2abcb1c749e0ce3 a, RC_6f342358c6e90ab9a2abcb1c749e0ce3 b) {
if (a.ssTotalPriceSum != b.ssTotalPriceSum) return false;
return true;
}

public static bool operator != (RC_6f342358c6e90ab9a2abcb1c749e0ce3 a, RC_6f342358c6e90ab9a2abcb1c749e0ce3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6f342358c6e90ab9a2abcb1c749e0ce3)) return false;
return (this == (RC_6f342358c6e90ab9a2abcb1c749e0ce3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
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


public RC_6f342358c6e90ab9a2abcb1c749e0ce3 Duplicate() {
RC_6f342358c6e90ab9a2abcb1c749e0ce3 t;
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
if (head == "totalpricesum") {
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
if (key == IdTotalPriceSum) {
return ssTotalPriceSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTotalPriceSum.Key.AsGuid) {
return ssTotalPriceSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssTotalPriceSum = (decimal) other.AttributeGet(IdTotalPriceSum);
}
} // RC_6f342358c6e90ab9a2abcb1c749e0ce3
/// <summary>
/// RecordList type <code>TotalPriceSumRecordList</code> that represents a record list of
///  <code>Currency</code>
/// </summary>
public partial class RL_d3c140b81b16482eac14fd0448f33de5 : GenericRecordList<RC_6f342358c6e90ab9a2abcb1c749e0ce3>, IEnumerable, IEnumerator {

protected override RC_6f342358c6e90ab9a2abcb1c749e0ce3 GetElementDefaultValue() {
return new RC_6f342358c6e90ab9a2abcb1c749e0ce3();
}

public T[] ToArray<T>(Func<RC_6f342358c6e90ab9a2abcb1c749e0ce3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d3c140b81b16482eac14fd0448f33de5 recordList, Func<RC_6f342358c6e90ab9a2abcb1c749e0ce3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d3c140b81b16482eac14fd0448f33de5(RC_6f342358c6e90ab9a2abcb1c749e0ce3[] array) {
  RL_d3c140b81b16482eac14fd0448f33de5 result = new RL_d3c140b81b16482eac14fd0448f33de5();
result.InnerFromArray(array);
    return result;
}

public static RL_d3c140b81b16482eac14fd0448f33de5 ToList<T>(T[] array, Func <T, RC_6f342358c6e90ab9a2abcb1c749e0ce3> converter) {
  RL_d3c140b81b16482eac14fd0448f33de5 result = new RL_d3c140b81b16482eac14fd0448f33de5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d3c140b81b16482eac14fd0448f33de5 FromRestList<T>(RestList<T> restList, Func <T, RC_6f342358c6e90ab9a2abcb1c749e0ce3> converter) {
  RL_d3c140b81b16482eac14fd0448f33de5 result = new RL_d3c140b81b16482eac14fd0448f33de5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d3c140b81b16482eac14fd0448f33de5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6f342358c6e90ab9a2abcb1c749e0ce3> NewList() {
return new RL_d3c140b81b16482eac14fd0448f33de5();
}


} // RL_d3c140b81b16482eac14fd0448f33de5
}

