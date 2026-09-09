namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EdoHffolT0Gs5xtHgCIFNA)
///  <code>RC_524c288faf455ce3a30a531f7ff5854e</code> that represent
/// s <code>UserFolioFilesStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: UserFolioFilesStorageRecord
public partial struct RC_524c288faf455ce3a30a531f7ff5854e : ITypedRecord<RC_524c288faf455ce3a30a531f7ff5854e> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFolioFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qLf9KPiu3JGSHF_jQ5OlaQ");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public ENUserEntityRecord ssENUser;

public EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord ssENFolioFiles;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_524c288faf455ce3a30a531f7ff5854e() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENFolioFiles = new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioFiles.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENFolioFiles.OptimizedAttributes = value[1];
    ssENStorage.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENFolioFiles.OptimizedAttributes;
    all[2] = ssENStorage.OptimizedAttributes;
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
public void ReadIM(RC_524c288faf455ce3a30a531f7ff5854e r) {
this = r;
}


public static bool operator == (RC_524c288faf455ce3a30a531f7ff5854e a, RC_524c288faf455ce3a30a531f7ff5854e b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFolioFiles != b.ssENFolioFiles) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_524c288faf455ce3a30a531f7ff5854e a, RC_524c288faf455ce3a30a531f7ff5854e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_524c288faf455ce3a30a531f7ff5854e)) return false;
return (this == (RC_524c288faf455ce3a30a531f7ff5854e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFolioFiles.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENFolioFiles.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENFolioFiles.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_524c288faf455ce3a30a531f7ff5854e Duplicate() {
RC_524c288faf455ce3a30a531f7ff5854e t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "foliofiles") {
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdFolioFiles) {
return ssENFolioFiles;
}
if (key == IdStorage) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
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
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENFolioFiles.FillFromOther((IRecord) other.AttributeGet(IdFolioFiles));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_524c288faf455ce3a30a531f7ff5854e
/// <summary>
/// RecordList type <code>UserFolioFilesStorageRecordList</code> that represents a record list of
///  <code>User, FolioFiles, Storage</code>
/// </summary>
public partial class RL_3a91e4d1ce6fecfc0c9a887200ab0325 : GenericRecordList<RC_524c288faf455ce3a30a531f7ff5854e>, IEnumerable, IEnumerator {

protected override RC_524c288faf455ce3a30a531f7ff5854e GetElementDefaultValue() {
return new RC_524c288faf455ce3a30a531f7ff5854e();
}

public T[] ToArray<T>(Func<RC_524c288faf455ce3a30a531f7ff5854e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3a91e4d1ce6fecfc0c9a887200ab0325 recordList, Func<RC_524c288faf455ce3a30a531f7ff5854e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3a91e4d1ce6fecfc0c9a887200ab0325(RC_524c288faf455ce3a30a531f7ff5854e[] array) {
  RL_3a91e4d1ce6fecfc0c9a887200ab0325 result = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
result.InnerFromArray(array);
    return result;
}

public static RL_3a91e4d1ce6fecfc0c9a887200ab0325 ToList<T>(T[] array, Func <T, RC_524c288faf455ce3a30a531f7ff5854e> converter) {
  RL_3a91e4d1ce6fecfc0c9a887200ab0325 result = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3a91e4d1ce6fecfc0c9a887200ab0325 FromRestList<T>(RestList<T> restList, Func <T, RC_524c288faf455ce3a30a531f7ff5854e> converter) {
  RL_3a91e4d1ce6fecfc0c9a887200ab0325 result = new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3a91e4d1ce6fecfc0c9a887200ab0325() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_524c288faf455ce3a30a531f7ff5854e> NewList() {
return new RL_3a91e4d1ce6fecfc0c9a887200ab0325();
}


} // RL_3a91e4d1ce6fecfc0c9a887200ab0325
}

