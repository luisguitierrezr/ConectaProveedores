namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GcJUn0zQJ0+W7xxcbQthtQ)
///  <code>RC_eb02c428bfcfe640dd4beef4a47700a4</code> that represents <code>TotalSAPSumRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TotalSAPSumRecord
public partial struct RC_eb02c428bfcfe640dd4beef4a47700a4 : ITypedRecord<RC_eb02c428bfcfe640dd4beef4a47700a4> {
internal static readonly GlobalObjectKey IdTotalSAPSum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KMQC68+_QObdS+70pHcApA");

public decimal ssTotalSAPSum;


public BitArray OptimizedAttributes;

public RC_eb02c428bfcfe640dd4beef4a47700a4() {
OptimizedAttributes = null;
ssTotalSAPSum = 0.0M;
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
ssTotalSAPSum = r.ReadDecimal(index++, "TotalSAPSumRecord.TotalSAPSum", 0.0M);
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
public void ReadIM(RC_eb02c428bfcfe640dd4beef4a47700a4 r) {
this = r;
}


public static bool operator == (RC_eb02c428bfcfe640dd4beef4a47700a4 a, RC_eb02c428bfcfe640dd4beef4a47700a4 b) {
if (a.ssTotalSAPSum != b.ssTotalSAPSum) return false;
return true;
}

public static bool operator != (RC_eb02c428bfcfe640dd4beef4a47700a4 a, RC_eb02c428bfcfe640dd4beef4a47700a4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_eb02c428bfcfe640dd4beef4a47700a4)) return false;
return (this == (RC_eb02c428bfcfe640dd4beef4a47700a4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTotalSAPSum.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_eb02c428bfcfe640dd4beef4a47700a4 Duplicate() {
RC_eb02c428bfcfe640dd4beef4a47700a4 t;
t.ssTotalSAPSum = this.ssTotalSAPSum;
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
if (head == "totalsapsum") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalSAPSum")) variable.Value = ssTotalSAPSum; else variable.Optimized = true;
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
if (key == IdTotalSAPSum) {
return ssTotalSAPSum;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTotalSAPSum.Key.AsGuid) {
return ssTotalSAPSum;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssTotalSAPSum = (decimal) other.AttributeGet(IdTotalSAPSum);
}
} // RC_eb02c428bfcfe640dd4beef4a47700a4
/// <summary>
/// RecordList type <code>TotalSAPSumRecordList</code> that represents a record list of
///  <code>Decimal</code>
/// </summary>
public partial class RL_312927afcf3eb9d5fa3bc02bbc91d978 : GenericRecordList<RC_eb02c428bfcfe640dd4beef4a47700a4>, IEnumerable, IEnumerator {

protected override RC_eb02c428bfcfe640dd4beef4a47700a4 GetElementDefaultValue() {
return new RC_eb02c428bfcfe640dd4beef4a47700a4();
}

public T[] ToArray<T>(Func<RC_eb02c428bfcfe640dd4beef4a47700a4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_312927afcf3eb9d5fa3bc02bbc91d978 recordList, Func<RC_eb02c428bfcfe640dd4beef4a47700a4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_312927afcf3eb9d5fa3bc02bbc91d978(RC_eb02c428bfcfe640dd4beef4a47700a4[] array) {
  RL_312927afcf3eb9d5fa3bc02bbc91d978 result = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
result.InnerFromArray(array);
    return result;
}

public static RL_312927afcf3eb9d5fa3bc02bbc91d978 ToList<T>(T[] array, Func <T, RC_eb02c428bfcfe640dd4beef4a47700a4> converter) {
  RL_312927afcf3eb9d5fa3bc02bbc91d978 result = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_312927afcf3eb9d5fa3bc02bbc91d978 FromRestList<T>(RestList<T> restList, Func <T, RC_eb02c428bfcfe640dd4beef4a47700a4> converter) {
  RL_312927afcf3eb9d5fa3bc02bbc91d978 result = new RL_312927afcf3eb9d5fa3bc02bbc91d978();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_312927afcf3eb9d5fa3bc02bbc91d978() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_eb02c428bfcfe640dd4beef4a47700a4> NewList() {
return new RL_312927afcf3eb9d5fa3bc02bbc91d978();
}


} // RL_312927afcf3eb9d5fa3bc02bbc91d978
}

