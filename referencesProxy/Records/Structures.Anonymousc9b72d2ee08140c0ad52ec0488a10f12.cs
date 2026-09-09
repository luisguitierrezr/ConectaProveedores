namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Li23yYHgwECtUuwEiKEPEg)
///  <code>RC_6f19ec7945aa4d185bdc790151967a09</code> that represents <code>DirectoryRoleRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DirectoryRoleRecord
public partial struct RC_6f19ec7945aa4d185bdc790151967a09 : ITypedRecord<RC_6f19ec7945aa4d185bdc790151967a09> {
internal static readonly GlobalObjectKey IdDirectoryRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eewZb6pFGE1b3HkBUZZ6CQ");

public ST_2d127d12a9d7c02aac84eb45d06f36fbStructure ssSTDirectoryRole;


public static implicit operator ST_2d127d12a9d7c02aac84eb45d06f36fbStructure( RC_6f19ec7945aa4d185bdc790151967a09 r) {
return r.ssSTDirectoryRole;
}

public static implicit operator RC_6f19ec7945aa4d185bdc790151967a09 (ST_2d127d12a9d7c02aac84eb45d06f36fbStructure r) {
RC_6f19ec7945aa4d185bdc790151967a09 res = new RC_6f19ec7945aa4d185bdc790151967a09 ();
res.ssSTDirectoryRole = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6f19ec7945aa4d185bdc790151967a09() {
OptimizedAttributes = null;
ssSTDirectoryRole = new ST_2d127d12a9d7c02aac84eb45d06f36fbStructure();
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
    ssSTDirectoryRole.OptimizedAttributes = value[0];
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
ssSTDirectoryRole.Read( r, ref index);
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
public void ReadIM(RC_6f19ec7945aa4d185bdc790151967a09 r) {
this = r;
}


public static bool operator == (RC_6f19ec7945aa4d185bdc790151967a09 a, RC_6f19ec7945aa4d185bdc790151967a09 b) {
if (a.ssSTDirectoryRole != b.ssSTDirectoryRole) return false;
return true;
}

public static bool operator != (RC_6f19ec7945aa4d185bdc790151967a09 a, RC_6f19ec7945aa4d185bdc790151967a09 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6f19ec7945aa4d185bdc790151967a09)) return false;
return (this == (RC_6f19ec7945aa4d185bdc790151967a09)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDirectoryRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDirectoryRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDirectoryRole.InternalRecursiveSave();
}


public RC_6f19ec7945aa4d185bdc790151967a09 Duplicate() {
RC_6f19ec7945aa4d185bdc790151967a09 t;
t.ssSTDirectoryRole = (ST_2d127d12a9d7c02aac84eb45d06f36fbStructure)this.ssSTDirectoryRole.Duplicate();
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
if (head == "directoryrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DirectoryRole")) variable.Value = ssSTDirectoryRole; else variable.Optimized = true;
variable.SetFieldName("directoryrole");
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
if (key == IdDirectoryRole) {
return ssSTDirectoryRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDirectoryRole.Key.AsGuid) {
return ssSTDirectoryRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDirectoryRole.FillFromOther((IRecord) other.AttributeGet(IdDirectoryRole));
}
} // RC_6f19ec7945aa4d185bdc790151967a09
/// <summary>
/// RecordList type <code>DirectoryRoleRecordList</code> that represents a record list of
///  <code>DirectoryRole</code>
/// </summary>
public partial class RL_049f749b81190733cdc3d23e2fcb3343 : GenericRecordList<RC_6f19ec7945aa4d185bdc790151967a09>, IEnumerable, IEnumerator {

protected override RC_6f19ec7945aa4d185bdc790151967a09 GetElementDefaultValue() {
return new RC_6f19ec7945aa4d185bdc790151967a09();
}

public T[] ToArray<T>(Func<RC_6f19ec7945aa4d185bdc790151967a09, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_049f749b81190733cdc3d23e2fcb3343 recordList, Func<RC_6f19ec7945aa4d185bdc790151967a09, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_049f749b81190733cdc3d23e2fcb3343(RC_6f19ec7945aa4d185bdc790151967a09[] array) {
  RL_049f749b81190733cdc3d23e2fcb3343 result = new RL_049f749b81190733cdc3d23e2fcb3343();
result.InnerFromArray(array);
    return result;
}

public static RL_049f749b81190733cdc3d23e2fcb3343 ToList<T>(T[] array, Func <T, RC_6f19ec7945aa4d185bdc790151967a09> converter) {
  RL_049f749b81190733cdc3d23e2fcb3343 result = new RL_049f749b81190733cdc3d23e2fcb3343();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_049f749b81190733cdc3d23e2fcb3343 FromRestList<T>(RestList<T> restList, Func <T, RC_6f19ec7945aa4d185bdc790151967a09> converter) {
  RL_049f749b81190733cdc3d23e2fcb3343 result = new RL_049f749b81190733cdc3d23e2fcb3343();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_049f749b81190733cdc3d23e2fcb3343() : base() {
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
protected override OSList<RC_6f19ec7945aa4d185bdc790151967a09> NewList() {
return new RL_049f749b81190733cdc3d23e2fcb3343();
}


} // RL_049f749b81190733cdc3d23e2fcb3343
}

