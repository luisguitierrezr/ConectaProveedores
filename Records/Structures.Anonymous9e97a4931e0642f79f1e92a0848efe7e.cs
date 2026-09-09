namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (k6SXngYe90KfHpKghI7+fg)
///  <code>RC_8129c2d9846bc83a20ef6f3e7b60c809</code> that represents <code>IdNameRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: IdNameRecord
public partial struct RC_8129c2d9846bc83a20ef6f3e7b60c809 : ITypedRecord<RC_8129c2d9846bc83a20ef6f3e7b60c809> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfhee3Puo4zGvVEOJlm5Wg");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Y+cKFFxbDlVfkzJLEj4LTw");

public string ssId;

public string ssName;


public BitArray OptimizedAttributes;

public RC_8129c2d9846bc83a20ef6f3e7b60c809() {
OptimizedAttributes = null;
ssId = "";
ssName = "";
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
ssId = r.ReadEntityReferenceText(index++, "IdNameRecord.Id", "");
ssName = r.ReadText(index++, "IdNameRecord.Name", "");
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
public void ReadIM(RC_8129c2d9846bc83a20ef6f3e7b60c809 r) {
this = r;
}


public static bool operator == (RC_8129c2d9846bc83a20ef6f3e7b60c809 a, RC_8129c2d9846bc83a20ef6f3e7b60c809 b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (RC_8129c2d9846bc83a20ef6f3e7b60c809 a, RC_8129c2d9846bc83a20ef6f3e7b60c809 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8129c2d9846bc83a20ef6f3e7b60c809)) return false;
return (this == (RC_8129c2d9846bc83a20ef6f3e7b60c809)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_8129c2d9846bc83a20ef6f3e7b60c809 Duplicate() {
RC_8129c2d9846bc83a20ef6f3e7b60c809 t;
t.ssId = this.ssId;
t.ssName = this.ssName;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
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
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
}
} // RC_8129c2d9846bc83a20ef6f3e7b60c809
/// <summary>
/// RecordList type <code>IdNameRecordList</code> that represents a record list of
///  <code>UserIdentifier, Text</code>
/// </summary>
public partial class RL_999b467c81e0dee8574a63e95d64104c : GenericRecordList<RC_8129c2d9846bc83a20ef6f3e7b60c809>, IEnumerable, IEnumerator {

protected override RC_8129c2d9846bc83a20ef6f3e7b60c809 GetElementDefaultValue() {
return new RC_8129c2d9846bc83a20ef6f3e7b60c809();
}

public T[] ToArray<T>(Func<RC_8129c2d9846bc83a20ef6f3e7b60c809, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_999b467c81e0dee8574a63e95d64104c recordList, Func<RC_8129c2d9846bc83a20ef6f3e7b60c809, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_999b467c81e0dee8574a63e95d64104c(RC_8129c2d9846bc83a20ef6f3e7b60c809[] array) {
  RL_999b467c81e0dee8574a63e95d64104c result = new RL_999b467c81e0dee8574a63e95d64104c();
result.InnerFromArray(array);
    return result;
}

public static RL_999b467c81e0dee8574a63e95d64104c ToList<T>(T[] array, Func <T, RC_8129c2d9846bc83a20ef6f3e7b60c809> converter) {
  RL_999b467c81e0dee8574a63e95d64104c result = new RL_999b467c81e0dee8574a63e95d64104c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_999b467c81e0dee8574a63e95d64104c FromRestList<T>(RestList<T> restList, Func <T, RC_8129c2d9846bc83a20ef6f3e7b60c809> converter) {
  RL_999b467c81e0dee8574a63e95d64104c result = new RL_999b467c81e0dee8574a63e95d64104c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_999b467c81e0dee8574a63e95d64104c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8129c2d9846bc83a20ef6f3e7b60c809> NewList() {
return new RL_999b467c81e0dee8574a63e95d64104c();
}


} // RL_999b467c81e0dee8574a63e95d64104c
}

