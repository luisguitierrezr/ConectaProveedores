namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (ZvuffjIrbkyXYKx1q8Zv5A)
///  <code>RC_78f8de95e867ccc81eabb054968cbf5b</code> that represent
/// s <code>SegmentAccGroupTelcelDirRecord</code> <p>Description: </p>
/// </summary>
// Name: SegmentAccGroupTelcelDirRecord
public partial struct RC_78f8de95e867ccc81eabb054968cbf5b : ITypedRecord<RC_78f8de95e867ccc81eabb054968cbf5b> {
internal static readonly GlobalObjectKey IdSegmentAccGroupTelcelDir = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ld74eGfoyMweq7BUloy_Ww");

public EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord ssENSegmentAccGroupTelcelDir;


public static implicit operator EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord( RC_78f8de95e867ccc81eabb054968cbf5b r) {
return r.ssENSegmentAccGroupTelcelDir;
}

public static implicit operator RC_78f8de95e867ccc81eabb054968cbf5b (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord r) {
RC_78f8de95e867ccc81eabb054968cbf5b res = new RC_78f8de95e867ccc81eabb054968cbf5b ();
res.ssENSegmentAccGroupTelcelDir = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSegmentAccGroupTelcelDir.ChangedAttributes = value;
}
get {
    return ssENSegmentAccGroupTelcelDir.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_78f8de95e867ccc81eabb054968cbf5b() {
OptimizedAttributes = null;
ssENSegmentAccGroupTelcelDir = new EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSegmentAccGroupTelcelDir.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSegmentAccGroupTelcelDir.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSegmentAccGroupTelcelDir.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSegmentAccGroupTelcelDir.Read( r, ref index);
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
public void ReadIM(RC_78f8de95e867ccc81eabb054968cbf5b r) {
this = r;
}


public static bool operator == (RC_78f8de95e867ccc81eabb054968cbf5b a, RC_78f8de95e867ccc81eabb054968cbf5b b) {
if (a.ssENSegmentAccGroupTelcelDir != b.ssENSegmentAccGroupTelcelDir) return false;
return true;
}

public static bool operator != (RC_78f8de95e867ccc81eabb054968cbf5b a, RC_78f8de95e867ccc81eabb054968cbf5b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_78f8de95e867ccc81eabb054968cbf5b)) return false;
return (this == (RC_78f8de95e867ccc81eabb054968cbf5b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSegmentAccGroupTelcelDir.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSegmentAccGroupTelcelDir.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSegmentAccGroupTelcelDir.InternalRecursiveSave();
}


public RC_78f8de95e867ccc81eabb054968cbf5b Duplicate() {
RC_78f8de95e867ccc81eabb054968cbf5b t;
t.ssENSegmentAccGroupTelcelDir = (EN_2a34dd0db0e0295f5091c15f08aa6001EntityRecord)this.ssENSegmentAccGroupTelcelDir.Duplicate();
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
if (head == "segmentaccgrouptelceldir") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SegmentAccGroupTelcelDir")) variable.Value = ssENSegmentAccGroupTelcelDir; else variable.Optimized = true;
variable.SetFieldName("segmentaccgrouptelceldir");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSegmentAccGroupTelcelDir.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSegmentAccGroupTelcelDir.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSegmentAccGroupTelcelDir) {
return ssENSegmentAccGroupTelcelDir;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSegmentAccGroupTelcelDir.Key.AsGuid) {
return ssENSegmentAccGroupTelcelDir;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSegmentAccGroupTelcelDir.FillFromOther((IRecord) other.AttributeGet(IdSegmentAccGroupTelcelDir));
}
} // RC_78f8de95e867ccc81eabb054968cbf5b
/// <summary>
/// RecordList type <code>SegmentAccGroupTelcelDirRecordList</code> that represents a record list of
///  <code>SegmentAccGroupTelcelDir</code>
/// </summary>
public partial class RL_aea988459b3fea61e1459fb233ec9d7c : GenericRecordList<RC_78f8de95e867ccc81eabb054968cbf5b>, IEnumerable, IEnumerator {

protected override RC_78f8de95e867ccc81eabb054968cbf5b GetElementDefaultValue() {
return new RC_78f8de95e867ccc81eabb054968cbf5b();
}

public T[] ToArray<T>(Func<RC_78f8de95e867ccc81eabb054968cbf5b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aea988459b3fea61e1459fb233ec9d7c recordList, Func<RC_78f8de95e867ccc81eabb054968cbf5b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aea988459b3fea61e1459fb233ec9d7c(RC_78f8de95e867ccc81eabb054968cbf5b[] array) {
  RL_aea988459b3fea61e1459fb233ec9d7c result = new RL_aea988459b3fea61e1459fb233ec9d7c();
result.InnerFromArray(array);
    return result;
}

public static RL_aea988459b3fea61e1459fb233ec9d7c ToList<T>(T[] array, Func <T, RC_78f8de95e867ccc81eabb054968cbf5b> converter) {
  RL_aea988459b3fea61e1459fb233ec9d7c result = new RL_aea988459b3fea61e1459fb233ec9d7c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aea988459b3fea61e1459fb233ec9d7c FromRestList<T>(RestList<T> restList, Func <T, RC_78f8de95e867ccc81eabb054968cbf5b> converter) {
  RL_aea988459b3fea61e1459fb233ec9d7c result = new RL_aea988459b3fea61e1459fb233ec9d7c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aea988459b3fea61e1459fb233ec9d7c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_78f8de95e867ccc81eabb054968cbf5b> NewList() {
return new RL_aea988459b3fea61e1459fb233ec9d7c();
}


} // RL_aea988459b3fea61e1459fb233ec9d7c
}

