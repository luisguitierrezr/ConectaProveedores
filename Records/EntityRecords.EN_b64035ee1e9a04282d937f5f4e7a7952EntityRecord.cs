using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioFiles (6M+3dQIwJ0KS1zgC5Rshsg)
///  <code>EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord</code> that represent
/// s <code>FolioFiles</code> <p>Description: Folio Files</p>
/// </summary>
// Name: FolioFiles
public partial struct EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord : ITypedRecord<EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*f0DzJmvN6UWFsPElTZlU8g");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*h_j1MPRp4UaVukIUybMgXw");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*68hjQmiqF0iD0_Jt0zP4gg");
internal static readonly GlobalObjectKey IdIsExtra = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*laaaSHErR0a4eFG_xkYDSw");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*b46FYfF1Vka8xDtk+++Xpw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mACuFg152kKWiIrkdUw_OQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jWyDv4aBn063GyQs1sXEyg");
internal static readonly GlobalObjectKey IdIsNewFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Jnpi4tvyPEuNhzn44M5f2w");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

private string _ssFilename;
public string ssFilename{
  get{
      return _ssFilename;
  }
  set{
      if((_ssFilename!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFilename = value;
      }
  }
}

private long _ssFolioId;
public long ssFolioId{
  get{
      return _ssFolioId;
  }
  set{
      if((_ssFolioId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssFolioId = value;
      }
  }
}

private bool _ssIsExtra;
public bool ssIsExtra{
  get{
      return _ssIsExtra;
  }
  set{
      if((_ssIsExtra!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsExtra = value;
      }
  }
}

private long _ssStorageId;
public long ssStorageId{
  get{
      return _ssStorageId;
  }
  set{
      if((_ssStorageId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssStorageId = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCreatedOn = value;
      }
  }
}

private bool _ssIsNewFile;
public bool ssIsNewFile{
  get{
      return _ssIsNewFile;
  }
  set{
      if((_ssIsNewFile!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsNewFile = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssFilename = "";
_ssFolioId = 0L;
_ssIsExtra = false;
_ssStorageId = 0L;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsNewFile = false;
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
ssId = r.ReadLongInteger(index++, "FolioFiles.Id", 0L);
ssFilename = r.ReadText(index++, "FolioFiles.Filename", "");
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioFiles.FolioId", 0L);
ssIsExtra = r.ReadBoolean(index++, "FolioFiles.IsExtra", false);
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "FolioFiles.StorageId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "FolioFiles.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "FolioFiles.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsNewFile = r.ReadBoolean(index++, "FolioFiles.IsNewFile", false);
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord r) {
this = r;
}


public static bool operator == (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord a, EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssIsExtra != b.ssIsExtra) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssIsNewFile != b.ssIsNewFile) return false;
return true;
}

public static bool operator != (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord a, EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord)) return false;
return (this == (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssIsExtra.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssIsNewFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord Duplicate() {
EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord t;
t._ssId = this._ssId;
t._ssFilename = this._ssFilename;
t._ssFolioId = this._ssFolioId;
t._ssIsExtra = this._ssIsExtra;
t._ssStorageId = this._ssStorageId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssIsNewFile = this._ssIsNewFile;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "isextra") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsExtra")) variable.Value = ssIsExtra; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "isnewfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsNewFile")) variable.Value = ssIsNewFile; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFilename)) {
return ChangedAttributes[1];
}
if (key.Equals(IdFolioId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsExtra)) {
return ChangedAttributes[3];
}
if (key.Equals(IdStorageId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsNewFile)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFilename)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdFolioId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsExtra)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdStorageId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsNewFile)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdIsExtra) {
return ssIsExtra;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdIsNewFile) {
return ssIsNewFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdIsExtra.Key.AsGuid) {
return ssIsExtra;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdIsNewFile.Key.AsGuid) {
return ssIsNewFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFilename = (string) other.AttributeGet(IdFilename);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFilename);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFilename);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFolioId);
ssIsExtra = (bool) other.AttributeGet(IdIsExtra);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsExtra);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsExtra);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdStorageId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdStorageId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedOn);
ssIsNewFile = (bool) other.AttributeGet(IdIsNewFile);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsNewFile);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsNewFile);
}
} // EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord

/// <summary>
/// RecordList type <code>FolioFilesList</code> that represents a record list of
///  <code>FolioFiles</code>
/// </summary>
public partial class RL_599848762fec5e3551788414bd89d254 : GenericRecordList<EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord>, IEnumerable, IEnumerator {

protected override EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord GetElementDefaultValue() {
return new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord();
}

public T[] ToArray<T>(Func<EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_599848762fec5e3551788414bd89d254 recordList, Func<EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_599848762fec5e3551788414bd89d254(EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord[] array) {
  RL_599848762fec5e3551788414bd89d254 result = new RL_599848762fec5e3551788414bd89d254();
result.InnerFromArray(array);
    return result;
}

public static RL_599848762fec5e3551788414bd89d254 ToList<T>(T[] array, Func <T, EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord> converter) {
  RL_599848762fec5e3551788414bd89d254 result = new RL_599848762fec5e3551788414bd89d254();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_599848762fec5e3551788414bd89d254 FromRestList<T>(RestList<T> restList, Func <T, EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord> converter) {
  RL_599848762fec5e3551788414bd89d254 result = new RL_599848762fec5e3551788414bd89d254();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_599848762fec5e3551788414bd89d254() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord> NewList() {
return new RL_599848762fec5e3551788414bd89d254();
}


} // RL_599848762fec5e3551788414bd89d254
}
