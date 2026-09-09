namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KuIRm0PEPEG6Nb+nWHlsyg)
///  <code>RC_8675220d3fe960c67254ae28d587388e</code> that represents <code>ValueSumRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ValueSumRecord
public partial struct RC_8675220d3fe960c67254ae28d587388e : ITypedRecord<RC_8675220d3fe960c67254ae28d587388e> {
internal static readonly GlobalObjectKey IdValueSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DSJ1huk_xmByVK4o1Yc4jg");

public decimal ssValueSum;


public BitArray OptimizedAttributes;

public RC_8675220d3fe960c67254ae28d587388e() {
OptimizedAttributes = null;
ssValueSum = 0.0M;
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
ssValueSum = r.ReadDecimal(index++, "ValueSumRecord.ValueSum", 0.0M);
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
public void ReadIM(RC_8675220d3fe960c67254ae28d587388e r) {
this = r;
}


public static bool operator == (RC_8675220d3fe960c67254ae28d587388e a, RC_8675220d3fe960c67254ae28d587388e b) {
if (a.ssValueSum != b.ssValueSum) return false;
return true;
}

public static bool operator != (RC_8675220d3fe960c67254ae28d587388e a, RC_8675220d3fe960c67254ae28d587388e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8675220d3fe960c67254ae28d587388e)) return false;
return (this == (RC_8675220d3fe960c67254ae28d587388e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValueSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_8675220d3fe960c67254ae28d587388e Duplicate() {
RC_8675220d3fe960c67254ae28d587388e t;
t.ssValueSum = this.ssValueSum;
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
if (head == "valuesum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValueSum")) variable.Value = ssValueSum; else variable.Optimized = true;
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
if (key == IdValueSum) {
return ssValueSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValueSum.Key.AsGuid) {
return ssValueSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssValueSum = (decimal) other.AttributeGet(IdValueSum);
}
} // RC_8675220d3fe960c67254ae28d587388e
/// <summary>
/// RecordList type <code>ValueSumRecordList</code> that represents a record list of
///  <code>Decimal</code>
/// </summary>
public partial class RL_84dada5f12004775b86c894b55ae9596 : GenericRecordList<RC_8675220d3fe960c67254ae28d587388e>, IEnumerable, IEnumerator {

protected override RC_8675220d3fe960c67254ae28d587388e GetElementDefaultValue() {
return new RC_8675220d3fe960c67254ae28d587388e();
}

public T[] ToArray<T>(Func<RC_8675220d3fe960c67254ae28d587388e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_84dada5f12004775b86c894b55ae9596 recordList, Func<RC_8675220d3fe960c67254ae28d587388e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_84dada5f12004775b86c894b55ae9596(RC_8675220d3fe960c67254ae28d587388e[] array) {
  RL_84dada5f12004775b86c894b55ae9596 result = new RL_84dada5f12004775b86c894b55ae9596();
result.InnerFromArray(array);
    return result;
}

public static RL_84dada5f12004775b86c894b55ae9596 ToList<T>(T[] array, Func <T, RC_8675220d3fe960c67254ae28d587388e> converter) {
  RL_84dada5f12004775b86c894b55ae9596 result = new RL_84dada5f12004775b86c894b55ae9596();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_84dada5f12004775b86c894b55ae9596 FromRestList<T>(RestList<T> restList, Func <T, RC_8675220d3fe960c67254ae28d587388e> converter) {
  RL_84dada5f12004775b86c894b55ae9596 result = new RL_84dada5f12004775b86c894b55ae9596();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_84dada5f12004775b86c894b55ae9596() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8675220d3fe960c67254ae28d587388e> NewList() {
return new RL_84dada5f12004775b86c894b55ae9596();
}


} // RL_84dada5f12004775b86c894b55ae9596
}

