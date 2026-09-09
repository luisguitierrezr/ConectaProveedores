namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (cvVCVGhjDU6fEW_iFwD6jA)
///  <code>RC_d896ddfd96504faa41bec68e2ff8d0eb</code> that represents <code>CountLogsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CountLogsRecord
public partial struct RC_d896ddfd96504faa41bec68e2ff8d0eb : ITypedRecord<RC_d896ddfd96504faa41bec68e2ff8d0eb> {
internal static readonly GlobalObjectKey IdCountLogs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_d2W2FCWqk9BvsaOL_jQ6w");

public long ssCountLogs;


public BitArray OptimizedAttributes;

public RC_d896ddfd96504faa41bec68e2ff8d0eb() {
OptimizedAttributes = null;
ssCountLogs = 0L;
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
ssCountLogs = r.ReadLongInteger(index++, "CountLogsRecord.CountLogs", 0L);
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
public void ReadIM(RC_d896ddfd96504faa41bec68e2ff8d0eb r) {
this = r;
}


public static bool operator == (RC_d896ddfd96504faa41bec68e2ff8d0eb a, RC_d896ddfd96504faa41bec68e2ff8d0eb b) {
if (a.ssCountLogs != b.ssCountLogs) return false;
return true;
}

public static bool operator != (RC_d896ddfd96504faa41bec68e2ff8d0eb a, RC_d896ddfd96504faa41bec68e2ff8d0eb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d896ddfd96504faa41bec68e2ff8d0eb)) return false;
return (this == (RC_d896ddfd96504faa41bec68e2ff8d0eb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCountLogs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_d896ddfd96504faa41bec68e2ff8d0eb Duplicate() {
RC_d896ddfd96504faa41bec68e2ff8d0eb t;
t.ssCountLogs = this.ssCountLogs;
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
if (head == "countlogs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CountLogs")) variable.Value = ssCountLogs; else variable.Optimized = true;
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
if (key == IdCountLogs) {
return ssCountLogs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCountLogs.Key.AsGuid) {
return ssCountLogs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCountLogs = (long) other.AttributeGet(IdCountLogs);
}
} // RC_d896ddfd96504faa41bec68e2ff8d0eb
/// <summary>
/// RecordList type <code>CountLogsRecordList</code> that represents a record list of
///  <code>LongInteger</code>
/// </summary>
public partial class RL_9801bd776ff900c0406cf35f97fa0b26 : GenericRecordList<RC_d896ddfd96504faa41bec68e2ff8d0eb>, IEnumerable, IEnumerator {

protected override RC_d896ddfd96504faa41bec68e2ff8d0eb GetElementDefaultValue() {
return new RC_d896ddfd96504faa41bec68e2ff8d0eb();
}

public T[] ToArray<T>(Func<RC_d896ddfd96504faa41bec68e2ff8d0eb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9801bd776ff900c0406cf35f97fa0b26 recordList, Func<RC_d896ddfd96504faa41bec68e2ff8d0eb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9801bd776ff900c0406cf35f97fa0b26(RC_d896ddfd96504faa41bec68e2ff8d0eb[] array) {
  RL_9801bd776ff900c0406cf35f97fa0b26 result = new RL_9801bd776ff900c0406cf35f97fa0b26();
result.InnerFromArray(array);
    return result;
}

public static RL_9801bd776ff900c0406cf35f97fa0b26 ToList<T>(T[] array, Func <T, RC_d896ddfd96504faa41bec68e2ff8d0eb> converter) {
  RL_9801bd776ff900c0406cf35f97fa0b26 result = new RL_9801bd776ff900c0406cf35f97fa0b26();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9801bd776ff900c0406cf35f97fa0b26 FromRestList<T>(RestList<T> restList, Func <T, RC_d896ddfd96504faa41bec68e2ff8d0eb> converter) {
  RL_9801bd776ff900c0406cf35f97fa0b26 result = new RL_9801bd776ff900c0406cf35f97fa0b26();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9801bd776ff900c0406cf35f97fa0b26() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d896ddfd96504faa41bec68e2ff8d0eb> NewList() {
return new RL_9801bd776ff900c0406cf35f97fa0b26();
}


} // RL_9801bd776ff900c0406cf35f97fa0b26
}

