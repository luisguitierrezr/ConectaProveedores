namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (1sBufmSkd0WH56RwpVEosQ)
///  <code>RC_30fde7bd8b6b69ef09faede048f7361d</code> that represent
/// s <code>UserFileImportLogRecord</code> <p>Description: </p>
/// </summary>
// Name: UserFileImportLogRecord
public partial struct RC_30fde7bd8b6b69ef09faede048f7361d : ITypedRecord<RC_30fde7bd8b6b69ef09faede048f7361d> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFileImportLog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AkZhHSsD1qFCYyfKsVwaNw");

public ENUserEntityRecord ssENUser;

public EN_57456f779b1d12573357da68381e59ceEntityRecord ssENFileImportLog;


public BitArray OptimizedAttributes;

public RC_30fde7bd8b6b69ef09faede048f7361d() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENFileImportLog = new EN_57456f779b1d12573357da68381e59ceEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFileImportLog.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENFileImportLog.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENFileImportLog.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENFileImportLog.Read( r, ref index);
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
public void ReadIM(RC_30fde7bd8b6b69ef09faede048f7361d r) {
this = r;
}


public static bool operator == (RC_30fde7bd8b6b69ef09faede048f7361d a, RC_30fde7bd8b6b69ef09faede048f7361d b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFileImportLog != b.ssENFileImportLog) return false;
return true;
}

public static bool operator != (RC_30fde7bd8b6b69ef09faede048f7361d a, RC_30fde7bd8b6b69ef09faede048f7361d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_30fde7bd8b6b69ef09faede048f7361d)) return false;
return (this == (RC_30fde7bd8b6b69ef09faede048f7361d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFileImportLog.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENFileImportLog.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENFileImportLog.InternalRecursiveSave();
}


public RC_30fde7bd8b6b69ef09faede048f7361d Duplicate() {
RC_30fde7bd8b6b69ef09faede048f7361d t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENFileImportLog = (EN_57456f779b1d12573357da68381e59ceEntityRecord)this.ssENFileImportLog.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "fileimportlog") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileImportLog")) variable.Value = ssENFileImportLog; else variable.Optimized = true;
variable.SetFieldName("fileimportlog");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdFileImportLog) {
return ssENFileImportLog;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdFileImportLog.Key.AsGuid) {
return ssENFileImportLog;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENFileImportLog.FillFromOther((IRecord) other.AttributeGet(IdFileImportLog));
}
} // RC_30fde7bd8b6b69ef09faede048f7361d
/// <summary>
/// RecordList type <code>UserFileImportLogRecordList</code> that represents a record list of
///  <code>User, FileImportLog</code>
/// </summary>
public partial class RL_0a29febe5e5b3c22dc11930cd3be5c9e : GenericRecordList<RC_30fde7bd8b6b69ef09faede048f7361d>, IEnumerable, IEnumerator {

protected override RC_30fde7bd8b6b69ef09faede048f7361d GetElementDefaultValue() {
return new RC_30fde7bd8b6b69ef09faede048f7361d();
}

public T[] ToArray<T>(Func<RC_30fde7bd8b6b69ef09faede048f7361d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0a29febe5e5b3c22dc11930cd3be5c9e recordList, Func<RC_30fde7bd8b6b69ef09faede048f7361d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0a29febe5e5b3c22dc11930cd3be5c9e(RC_30fde7bd8b6b69ef09faede048f7361d[] array) {
  RL_0a29febe5e5b3c22dc11930cd3be5c9e result = new RL_0a29febe5e5b3c22dc11930cd3be5c9e();
result.InnerFromArray(array);
    return result;
}

public static RL_0a29febe5e5b3c22dc11930cd3be5c9e ToList<T>(T[] array, Func <T, RC_30fde7bd8b6b69ef09faede048f7361d> converter) {
  RL_0a29febe5e5b3c22dc11930cd3be5c9e result = new RL_0a29febe5e5b3c22dc11930cd3be5c9e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0a29febe5e5b3c22dc11930cd3be5c9e FromRestList<T>(RestList<T> restList, Func <T, RC_30fde7bd8b6b69ef09faede048f7361d> converter) {
  RL_0a29febe5e5b3c22dc11930cd3be5c9e result = new RL_0a29febe5e5b3c22dc11930cd3be5c9e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0a29febe5e5b3c22dc11930cd3be5c9e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_30fde7bd8b6b69ef09faede048f7361d> NewList() {
return new RL_0a29febe5e5b3c22dc11930cd3be5c9e();
}


} // RL_0a29febe5e5b3c22dc11930cd3be5c9e
}

