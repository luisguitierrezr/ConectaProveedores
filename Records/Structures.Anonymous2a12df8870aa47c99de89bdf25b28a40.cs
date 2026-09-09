namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (iN8SKqpwyUed6JvfJbKKQA)
///  <code>RC_db98be0f77f582e2a41dd64bb6a4005e</code> that represent
/// s <code>FolioFilesStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioFilesStorageRecord
public partial struct RC_db98be0f77f582e2a41dd64bb6a4005e : ITypedRecord<RC_db98be0f77f582e2a41dd64bb6a4005e> {
internal static readonly GlobalObjectKey IdFolioFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qLf9KPiu3JGSHF_jQ5OlaQ");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord ssENFolioFiles;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_db98be0f77f582e2a41dd64bb6a4005e() {
OptimizedAttributes = null;
ssENFolioFiles = new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioFiles.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolioFiles.OptimizedAttributes = value[0];
    ssENStorage.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolioFiles.OptimizedAttributes;
    all[1] = ssENStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioFiles.Read( r, ref index);
ssENStorage.Read( r, ref index);
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
public void ReadIM(RC_db98be0f77f582e2a41dd64bb6a4005e r) {
this = r;
}


public static bool operator == (RC_db98be0f77f582e2a41dd64bb6a4005e a, RC_db98be0f77f582e2a41dd64bb6a4005e b) {
if (a.ssENFolioFiles != b.ssENFolioFiles) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_db98be0f77f582e2a41dd64bb6a4005e a, RC_db98be0f77f582e2a41dd64bb6a4005e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_db98be0f77f582e2a41dd64bb6a4005e)) return false;
return (this == (RC_db98be0f77f582e2a41dd64bb6a4005e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioFiles.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioFiles.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioFiles.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_db98be0f77f582e2a41dd64bb6a4005e Duplicate() {
RC_db98be0f77f582e2a41dd64bb6a4005e t;
t.ssENFolioFiles = (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord)this.ssENFolioFiles.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
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
if (head == "foliofiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioFiles")) variable.Value = ssENFolioFiles; else variable.Optimized = true;
variable.SetFieldName("foliofiles");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
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
if (key == IdFolioFiles) {
return ssENFolioFiles;
}
if (key == IdStorage) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioFiles.Key.AsGuid) {
return ssENFolioFiles;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioFiles.FillFromOther((IRecord) other.AttributeGet(IdFolioFiles));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_db98be0f77f582e2a41dd64bb6a4005e
/// <summary>
/// RecordList type <code>FolioFilesStorageRecordList</code> that represents a record list of
///  <code>FolioFiles, Storage</code>
/// </summary>
public partial class RL_599a55f2ca551e3817b27381ea3fcd80 : GenericRecordList<RC_db98be0f77f582e2a41dd64bb6a4005e>, IEnumerable, IEnumerator {

protected override RC_db98be0f77f582e2a41dd64bb6a4005e GetElementDefaultValue() {
return new RC_db98be0f77f582e2a41dd64bb6a4005e();
}

public T[] ToArray<T>(Func<RC_db98be0f77f582e2a41dd64bb6a4005e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_599a55f2ca551e3817b27381ea3fcd80 recordList, Func<RC_db98be0f77f582e2a41dd64bb6a4005e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_599a55f2ca551e3817b27381ea3fcd80(RC_db98be0f77f582e2a41dd64bb6a4005e[] array) {
  RL_599a55f2ca551e3817b27381ea3fcd80 result = new RL_599a55f2ca551e3817b27381ea3fcd80();
result.InnerFromArray(array);
    return result;
}

public static RL_599a55f2ca551e3817b27381ea3fcd80 ToList<T>(T[] array, Func <T, RC_db98be0f77f582e2a41dd64bb6a4005e> converter) {
  RL_599a55f2ca551e3817b27381ea3fcd80 result = new RL_599a55f2ca551e3817b27381ea3fcd80();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_599a55f2ca551e3817b27381ea3fcd80 FromRestList<T>(RestList<T> restList, Func <T, RC_db98be0f77f582e2a41dd64bb6a4005e> converter) {
  RL_599a55f2ca551e3817b27381ea3fcd80 result = new RL_599a55f2ca551e3817b27381ea3fcd80();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_599a55f2ca551e3817b27381ea3fcd80() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_db98be0f77f582e2a41dd64bb6a4005e> NewList() {
return new RL_599a55f2ca551e3817b27381ea3fcd80();
}


} // RL_599a55f2ca551e3817b27381ea3fcd80
}

