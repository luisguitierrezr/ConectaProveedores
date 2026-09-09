namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (zMZbTy19BkqMy9H9RF36mQ)
///  <code>RC_0578b8d4fa0f1d821c9958cb37db5e7d</code> that represent
/// s <code>PostCarganovimRequestWrapperRecord</code> <p>Description: </p>
/// </summary>
// Name: PostCarganovimRequestWrapperRecord
public partial struct RC_0578b8d4fa0f1d821c9958cb37db5e7d : ITypedRecord<RC_0578b8d4fa0f1d821c9958cb37db5e7d> {
internal static readonly GlobalObjectKey IdPostCarganovimRequestWrapper = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1Lh4BQ_6gh0cmVjLN9tefQ");

public ST_9b7f85dc32c7c81ceef0a0963388237dStructure ssSTPostCarganovimRequestWrapper;


public static implicit operator ST_9b7f85dc32c7c81ceef0a0963388237dStructure( RC_0578b8d4fa0f1d821c9958cb37db5e7d r) {
return r.ssSTPostCarganovimRequestWrapper;
}

public static implicit operator RC_0578b8d4fa0f1d821c9958cb37db5e7d (ST_9b7f85dc32c7c81ceef0a0963388237dStructure r) {
RC_0578b8d4fa0f1d821c9958cb37db5e7d res = new RC_0578b8d4fa0f1d821c9958cb37db5e7d ();
res.ssSTPostCarganovimRequestWrapper = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0578b8d4fa0f1d821c9958cb37db5e7d() {
OptimizedAttributes = null;
ssSTPostCarganovimRequestWrapper = new ST_9b7f85dc32c7c81ceef0a0963388237dStructure();
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
    ssSTPostCarganovimRequestWrapper.OptimizedAttributes = value[0];
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
ssSTPostCarganovimRequestWrapper.Read( r, ref index);
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
public void ReadIM(RC_0578b8d4fa0f1d821c9958cb37db5e7d r) {
this = r;
}


public static bool operator == (RC_0578b8d4fa0f1d821c9958cb37db5e7d a, RC_0578b8d4fa0f1d821c9958cb37db5e7d b) {
if (a.ssSTPostCarganovimRequestWrapper != b.ssSTPostCarganovimRequestWrapper) return false;
return true;
}

public static bool operator != (RC_0578b8d4fa0f1d821c9958cb37db5e7d a, RC_0578b8d4fa0f1d821c9958cb37db5e7d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0578b8d4fa0f1d821c9958cb37db5e7d)) return false;
return (this == (RC_0578b8d4fa0f1d821c9958cb37db5e7d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPostCarganovimRequestWrapper.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPostCarganovimRequestWrapper.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPostCarganovimRequestWrapper.InternalRecursiveSave();
}


public RC_0578b8d4fa0f1d821c9958cb37db5e7d Duplicate() {
RC_0578b8d4fa0f1d821c9958cb37db5e7d t;
t.ssSTPostCarganovimRequestWrapper = (ST_9b7f85dc32c7c81ceef0a0963388237dStructure)this.ssSTPostCarganovimRequestWrapper.Duplicate();
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
if (head == "postcarganovimrequestwrapper") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PostCarganovimRequestWrapper")) variable.Value = ssSTPostCarganovimRequestWrapper; else variable.Optimized = true;
variable.SetFieldName("postcarganovimrequestwrapper");
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
if (key == IdPostCarganovimRequestWrapper) {
return ssSTPostCarganovimRequestWrapper;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPostCarganovimRequestWrapper.Key.AsGuid) {
return ssSTPostCarganovimRequestWrapper;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPostCarganovimRequestWrapper.FillFromOther((IRecord) other.AttributeGet(IdPostCarganovimRequestWrapper));
}
} // RC_0578b8d4fa0f1d821c9958cb37db5e7d
/// <summary>
/// RecordList type <code>PostCarganovimRequestWrapperRecordList</code> that represents a record list
///  of <code>PostCarganovimRequestWrapper</code>
/// </summary>
public partial class RL_1dbe0e3de24744fedf041855f719e999 : GenericRecordList<RC_0578b8d4fa0f1d821c9958cb37db5e7d>, IEnumerable, IEnumerator {

protected override RC_0578b8d4fa0f1d821c9958cb37db5e7d GetElementDefaultValue() {
return new RC_0578b8d4fa0f1d821c9958cb37db5e7d();
}

public T[] ToArray<T>(Func<RC_0578b8d4fa0f1d821c9958cb37db5e7d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1dbe0e3de24744fedf041855f719e999 recordList, Func<RC_0578b8d4fa0f1d821c9958cb37db5e7d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1dbe0e3de24744fedf041855f719e999(RC_0578b8d4fa0f1d821c9958cb37db5e7d[] array) {
  RL_1dbe0e3de24744fedf041855f719e999 result = new RL_1dbe0e3de24744fedf041855f719e999();
result.InnerFromArray(array);
    return result;
}

public static RL_1dbe0e3de24744fedf041855f719e999 ToList<T>(T[] array, Func <T, RC_0578b8d4fa0f1d821c9958cb37db5e7d> converter) {
  RL_1dbe0e3de24744fedf041855f719e999 result = new RL_1dbe0e3de24744fedf041855f719e999();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1dbe0e3de24744fedf041855f719e999 FromRestList<T>(RestList<T> restList, Func <T, RC_0578b8d4fa0f1d821c9958cb37db5e7d> converter) {
  RL_1dbe0e3de24744fedf041855f719e999 result = new RL_1dbe0e3de24744fedf041855f719e999();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1dbe0e3de24744fedf041855f719e999() : base() {
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
protected override OSList<RC_0578b8d4fa0f1d821c9958cb37db5e7d> NewList() {
return new RL_1dbe0e3de24744fedf041855f719e999();
}


} // RL_1dbe0e3de24744fedf041855f719e999
}

