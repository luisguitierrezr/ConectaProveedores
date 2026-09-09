namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (uH46EdezdkmHJMb0w__xtA)
///  <code>RC_95c68a20cdfa1714694774ffd45b1c33</code> that represents <code>LabelESCountRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: LabelESCountRecord
public partial struct RC_95c68a20cdfa1714694774ffd45b1c33 : ITypedRecord<RC_95c68a20cdfa1714694774ffd45b1c33> {
internal static readonly GlobalObjectKey IdLabelES = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5ztryVZbP_nShXkqSTeB6Q");
internal static readonly GlobalObjectKey IdCount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Hf+xdpZqUjewQd_vPxy4NQ");

public string ssLabelES;

public long ssCount;


public BitArray OptimizedAttributes;

public RC_95c68a20cdfa1714694774ffd45b1c33() {
OptimizedAttributes = null;
ssLabelES = "";
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
ssLabelES = r.ReadText(index++, "LabelESCountRecord.LabelES", "");
ssCount = r.ReadLongInteger(index++, "LabelESCountRecord.Count", 0L);
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
public void ReadIM(RC_95c68a20cdfa1714694774ffd45b1c33 r) {
this = r;
}


public static bool operator == (RC_95c68a20cdfa1714694774ffd45b1c33 a, RC_95c68a20cdfa1714694774ffd45b1c33 b) {
if (a.ssLabelES != b.ssLabelES) return false;
if (a.ssCount != b.ssCount) return false;
return true;
}

public static bool operator != (RC_95c68a20cdfa1714694774ffd45b1c33 a, RC_95c68a20cdfa1714694774ffd45b1c33 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_95c68a20cdfa1714694774ffd45b1c33)) return false;
return (this == (RC_95c68a20cdfa1714694774ffd45b1c33)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLabelES.GetHashCode()
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


public RC_95c68a20cdfa1714694774ffd45b1c33 Duplicate() {
RC_95c68a20cdfa1714694774ffd45b1c33 t;
t.ssLabelES = this.ssLabelES;
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
if (head == "labeles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LabelES")) variable.Value = ssLabelES; else variable.Optimized = true;
} else if (head == "count") {
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
if (key == IdLabelES) {
return ssLabelES;
}
if (key == IdCount) {
return ssCount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLabelES.Key.AsGuid) {
return ssLabelES;
}
if (attributeKey == IdCount.Key.AsGuid) {
return ssCount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLabelES = (string) other.AttributeGet(IdLabelES);
ssCount = (long) other.AttributeGet(IdCount);
}
} // RC_95c68a20cdfa1714694774ffd45b1c33
/// <summary>
/// RecordList type <code>LabelESCountRecordList</code> that represents a record list of <code>Text,
///  LongInteger</code>
/// </summary>
public partial class RL_768cce162e7c81def144e505024952d1 : GenericRecordList<RC_95c68a20cdfa1714694774ffd45b1c33>, IEnumerable, IEnumerator {

protected override RC_95c68a20cdfa1714694774ffd45b1c33 GetElementDefaultValue() {
return new RC_95c68a20cdfa1714694774ffd45b1c33();
}

public T[] ToArray<T>(Func<RC_95c68a20cdfa1714694774ffd45b1c33, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_768cce162e7c81def144e505024952d1 recordList, Func<RC_95c68a20cdfa1714694774ffd45b1c33, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_768cce162e7c81def144e505024952d1(RC_95c68a20cdfa1714694774ffd45b1c33[] array) {
  RL_768cce162e7c81def144e505024952d1 result = new RL_768cce162e7c81def144e505024952d1();
result.InnerFromArray(array);
    return result;
}

public static RL_768cce162e7c81def144e505024952d1 ToList<T>(T[] array, Func <T, RC_95c68a20cdfa1714694774ffd45b1c33> converter) {
  RL_768cce162e7c81def144e505024952d1 result = new RL_768cce162e7c81def144e505024952d1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_768cce162e7c81def144e505024952d1 FromRestList<T>(RestList<T> restList, Func <T, RC_95c68a20cdfa1714694774ffd45b1c33> converter) {
  RL_768cce162e7c81def144e505024952d1 result = new RL_768cce162e7c81def144e505024952d1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_768cce162e7c81def144e505024952d1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_95c68a20cdfa1714694774ffd45b1c33> NewList() {
return new RL_768cce162e7c81def144e505024952d1();
}


} // RL_768cce162e7c81def144e505024952d1
}

