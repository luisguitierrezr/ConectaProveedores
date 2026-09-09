namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tFagMaY5PUmaKa4khWLztA)
///  <code>RC_375b15daf8a41c077766480dd582bf2b</code> that represent
/// s <code>ReassignNotificationContentRecord</code> <p>Description: </p>
/// </summary>
// Name: ReassignNotificationContentRecord
public partial struct RC_375b15daf8a41c077766480dd582bf2b : ITypedRecord<RC_375b15daf8a41c077766480dd582bf2b> {
internal static readonly GlobalObjectKey IdReassignNotificationContent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2hVbN6T4Bxx3ZkgN1YK_Kw");

public ST_6fc999fa8f6e0055c73f2f167c4bad19Structure ssSTReassignNotificationContent;


public static implicit operator ST_6fc999fa8f6e0055c73f2f167c4bad19Structure( RC_375b15daf8a41c077766480dd582bf2b r) {
return r.ssSTReassignNotificationContent;
}

public static implicit operator RC_375b15daf8a41c077766480dd582bf2b (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure r) {
RC_375b15daf8a41c077766480dd582bf2b res = new RC_375b15daf8a41c077766480dd582bf2b ();
res.ssSTReassignNotificationContent = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_375b15daf8a41c077766480dd582bf2b() {
OptimizedAttributes = null;
ssSTReassignNotificationContent = new ST_6fc999fa8f6e0055c73f2f167c4bad19Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTReassignNotificationContent.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTReassignNotificationContent.Read( r, ref index);
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
public void ReadIM(RC_375b15daf8a41c077766480dd582bf2b r) {
this = r;
}


public static bool operator == (RC_375b15daf8a41c077766480dd582bf2b a, RC_375b15daf8a41c077766480dd582bf2b b) {
if (a.ssSTReassignNotificationContent != b.ssSTReassignNotificationContent) return false;
return true;
}

public static bool operator != (RC_375b15daf8a41c077766480dd582bf2b a, RC_375b15daf8a41c077766480dd582bf2b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_375b15daf8a41c077766480dd582bf2b)) return false;
return (this == (RC_375b15daf8a41c077766480dd582bf2b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTReassignNotificationContent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTReassignNotificationContent.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTReassignNotificationContent.InternalRecursiveSave();
}


public RC_375b15daf8a41c077766480dd582bf2b Duplicate() {
RC_375b15daf8a41c077766480dd582bf2b t;
t.ssSTReassignNotificationContent = (ST_6fc999fa8f6e0055c73f2f167c4bad19Structure)this.ssSTReassignNotificationContent.Duplicate();
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
if (head == "reassignnotificationcontent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ReassignNotificationContent")) variable.Value = ssSTReassignNotificationContent; else variable.Optimized = true;
variable.SetFieldName("reassignnotificationcontent");
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
if (key == IdReassignNotificationContent) {
return ssSTReassignNotificationContent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdReassignNotificationContent.Key.AsGuid) {
return ssSTReassignNotificationContent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTReassignNotificationContent.FillFromOther((IRecord) other.AttributeGet(IdReassignNotificationContent));
}
} // RC_375b15daf8a41c077766480dd582bf2b
/// <summary>
/// RecordList type <code>ReassignNotificationContentRecordList</code> that represents a record list of
///  <code>ReassignNotificationContent</code>
/// </summary>
public partial class RL_6defac189e2fad27ed4da38c05a4acd4 : GenericRecordList<RC_375b15daf8a41c077766480dd582bf2b>, IEnumerable, IEnumerator {

protected override RC_375b15daf8a41c077766480dd582bf2b GetElementDefaultValue() {
return new RC_375b15daf8a41c077766480dd582bf2b();
}

public T[] ToArray<T>(Func<RC_375b15daf8a41c077766480dd582bf2b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6defac189e2fad27ed4da38c05a4acd4 recordList, Func<RC_375b15daf8a41c077766480dd582bf2b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6defac189e2fad27ed4da38c05a4acd4(RC_375b15daf8a41c077766480dd582bf2b[] array) {
  RL_6defac189e2fad27ed4da38c05a4acd4 result = new RL_6defac189e2fad27ed4da38c05a4acd4();
result.InnerFromArray(array);
    return result;
}

public static RL_6defac189e2fad27ed4da38c05a4acd4 ToList<T>(T[] array, Func <T, RC_375b15daf8a41c077766480dd582bf2b> converter) {
  RL_6defac189e2fad27ed4da38c05a4acd4 result = new RL_6defac189e2fad27ed4da38c05a4acd4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6defac189e2fad27ed4da38c05a4acd4 FromRestList<T>(RestList<T> restList, Func <T, RC_375b15daf8a41c077766480dd582bf2b> converter) {
  RL_6defac189e2fad27ed4da38c05a4acd4 result = new RL_6defac189e2fad27ed4da38c05a4acd4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6defac189e2fad27ed4da38c05a4acd4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_375b15daf8a41c077766480dd582bf2b> NewList() {
return new RL_6defac189e2fad27ed4da38c05a4acd4();
}


} // RL_6defac189e2fad27ed4da38c05a4acd4
}

