namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Dpi_fUpFqECJhStMNY8dWQ)
///  <code>RC_d93780ae9c35b458438c31065b3f06ba</code> that represents <code>CounterRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CounterRecord
public partial struct RC_d93780ae9c35b458438c31065b3f06ba : ITypedRecord<RC_d93780ae9c35b458438c31065b3f06ba> {
internal static readonly GlobalObjectKey IdCounter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*roA32TWcWLRDjDEGWz8Gug");

public int ssCounter;


public BitArray OptimizedAttributes;

public RC_d93780ae9c35b458438c31065b3f06ba() {
OptimizedAttributes = null;
ssCounter = 0;
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
ssCounter = r.ReadInteger(index++, "CounterRecord.Counter", 0);
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
public void ReadIM(RC_d93780ae9c35b458438c31065b3f06ba r) {
this = r;
}


public static bool operator == (RC_d93780ae9c35b458438c31065b3f06ba a, RC_d93780ae9c35b458438c31065b3f06ba b) {
if (a.ssCounter != b.ssCounter) return false;
return true;
}

public static bool operator != (RC_d93780ae9c35b458438c31065b3f06ba a, RC_d93780ae9c35b458438c31065b3f06ba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d93780ae9c35b458438c31065b3f06ba)) return false;
return (this == (RC_d93780ae9c35b458438c31065b3f06ba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCounter.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_d93780ae9c35b458438c31065b3f06ba Duplicate() {
RC_d93780ae9c35b458438c31065b3f06ba t;
t.ssCounter = this.ssCounter;
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
if (head == "counter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Counter")) variable.Value = ssCounter; else variable.Optimized = true;
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
if (key == IdCounter) {
return ssCounter;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCounter.Key.AsGuid) {
return ssCounter;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCounter = (int) other.AttributeGet(IdCounter);
}
} // RC_d93780ae9c35b458438c31065b3f06ba
/// <summary>
/// RecordList type <code>CounterRecordList</code> that represents a record list of
///  <code>Integer</code>
/// </summary>
public partial class RL_7c5a995519f0d2ebac2441eb253f1bf8 : GenericRecordList<RC_d93780ae9c35b458438c31065b3f06ba>, IEnumerable, IEnumerator {

protected override RC_d93780ae9c35b458438c31065b3f06ba GetElementDefaultValue() {
return new RC_d93780ae9c35b458438c31065b3f06ba();
}

public T[] ToArray<T>(Func<RC_d93780ae9c35b458438c31065b3f06ba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7c5a995519f0d2ebac2441eb253f1bf8 recordList, Func<RC_d93780ae9c35b458438c31065b3f06ba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7c5a995519f0d2ebac2441eb253f1bf8(RC_d93780ae9c35b458438c31065b3f06ba[] array) {
  RL_7c5a995519f0d2ebac2441eb253f1bf8 result = new RL_7c5a995519f0d2ebac2441eb253f1bf8();
result.InnerFromArray(array);
    return result;
}

public static RL_7c5a995519f0d2ebac2441eb253f1bf8 ToList<T>(T[] array, Func <T, RC_d93780ae9c35b458438c31065b3f06ba> converter) {
  RL_7c5a995519f0d2ebac2441eb253f1bf8 result = new RL_7c5a995519f0d2ebac2441eb253f1bf8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7c5a995519f0d2ebac2441eb253f1bf8 FromRestList<T>(RestList<T> restList, Func <T, RC_d93780ae9c35b458438c31065b3f06ba> converter) {
  RL_7c5a995519f0d2ebac2441eb253f1bf8 result = new RL_7c5a995519f0d2ebac2441eb253f1bf8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7c5a995519f0d2ebac2441eb253f1bf8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d93780ae9c35b458438c31065b3f06ba> NewList() {
return new RL_7c5a995519f0d2ebac2441eb253f1bf8();
}


} // RL_7c5a995519f0d2ebac2441eb253f1bf8
}

