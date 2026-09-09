namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (M8huYEubgEuDnsiiZCbNag)
///  <code>RC_76b1ff1d6a963752b041dfef3f1cb835</code> that represents <code>CountRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CountRecord
public partial struct RC_76b1ff1d6a963752b041dfef3f1cb835 : ITypedRecord<RC_76b1ff1d6a963752b041dfef3f1cb835> {
internal static readonly GlobalObjectKey IdCount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Hf+xdpZqUjewQd_vPxy4NQ");

public long ssCount;


public BitArray OptimizedAttributes;

public RC_76b1ff1d6a963752b041dfef3f1cb835() {
OptimizedAttributes = null;
ssCount = 0L;
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
ssCount = r.ReadLongInteger(index++, "CountRecord.Count", 0L);
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
public void ReadIM(RC_76b1ff1d6a963752b041dfef3f1cb835 r) {
this = r;
}


public static bool operator == (RC_76b1ff1d6a963752b041dfef3f1cb835 a, RC_76b1ff1d6a963752b041dfef3f1cb835 b) {
if (a.ssCount != b.ssCount) return false;
return true;
}

public static bool operator != (RC_76b1ff1d6a963752b041dfef3f1cb835 a, RC_76b1ff1d6a963752b041dfef3f1cb835 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_76b1ff1d6a963752b041dfef3f1cb835)) return false;
return (this == (RC_76b1ff1d6a963752b041dfef3f1cb835)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_76b1ff1d6a963752b041dfef3f1cb835 Duplicate() {
RC_76b1ff1d6a963752b041dfef3f1cb835 t;
t.ssCount = this.ssCount;
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
if (head == "count") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Count")) variable.Value = ssCount; else variable.Optimized = true;
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
if (key == IdCount) {
return ssCount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCount.Key.AsGuid) {
return ssCount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCount = (long) other.AttributeGet(IdCount);
}
} // RC_76b1ff1d6a963752b041dfef3f1cb835
/// <summary>
/// RecordList type <code>CountRecordList</code> that represents a record list of
///  <code>LongInteger</code>
/// </summary>
public partial class RL_11e68f59508e412eaf5b78801dd06b0e : GenericRecordList<RC_76b1ff1d6a963752b041dfef3f1cb835>, IEnumerable, IEnumerator {

protected override RC_76b1ff1d6a963752b041dfef3f1cb835 GetElementDefaultValue() {
return new RC_76b1ff1d6a963752b041dfef3f1cb835();
}

public T[] ToArray<T>(Func<RC_76b1ff1d6a963752b041dfef3f1cb835, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_11e68f59508e412eaf5b78801dd06b0e recordList, Func<RC_76b1ff1d6a963752b041dfef3f1cb835, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_11e68f59508e412eaf5b78801dd06b0e(RC_76b1ff1d6a963752b041dfef3f1cb835[] array) {
  RL_11e68f59508e412eaf5b78801dd06b0e result = new RL_11e68f59508e412eaf5b78801dd06b0e();
result.InnerFromArray(array);
    return result;
}

public static RL_11e68f59508e412eaf5b78801dd06b0e ToList<T>(T[] array, Func <T, RC_76b1ff1d6a963752b041dfef3f1cb835> converter) {
  RL_11e68f59508e412eaf5b78801dd06b0e result = new RL_11e68f59508e412eaf5b78801dd06b0e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_11e68f59508e412eaf5b78801dd06b0e FromRestList<T>(RestList<T> restList, Func <T, RC_76b1ff1d6a963752b041dfef3f1cb835> converter) {
  RL_11e68f59508e412eaf5b78801dd06b0e result = new RL_11e68f59508e412eaf5b78801dd06b0e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_11e68f59508e412eaf5b78801dd06b0e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_76b1ff1d6a963752b041dfef3f1cb835> NewList() {
return new RL_11e68f59508e412eaf5b78801dd06b0e();
}


} // RL_11e68f59508e412eaf5b78801dd06b0e
}

