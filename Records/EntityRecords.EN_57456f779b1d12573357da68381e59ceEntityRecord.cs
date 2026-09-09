using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FileImportLog (hk1Lj8a9KkKvDyzYg7iFHA)
///  <code>EN_57456f779b1d12573357da68381e59ceEntityRecord</code> that represent
/// s <code>FileImportLog</code> <p>Description: Entity that holds File Impots Logs..</p>
/// </summary>
// Name: FileImportLog
public partial struct EN_57456f779b1d12573357da68381e59ceEntityRecord : ITypedRecord<EN_57456f779b1d12573357da68381e59ceEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7SSIuStPgECw_TacfWHYbg");
internal static readonly GlobalObjectKey IdFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hdfwY+T_m0y99Qm2+pDH2g");
internal static readonly GlobalObjectKey IdTimestamp = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OR_DE7tB9Eqq7X0_SEw_tA");
internal static readonly GlobalObjectKey IdImportType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GUWn52rPKkm1UbeNrq_dUA");
internal static readonly GlobalObjectKey IdImportedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*s8Uhz3pGp0OjI8j6f3svbA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

private long _ssFileId;
public long ssFileId{
  get{
      return _ssFileId;
  }
  set{
      if((_ssFileId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFileId = value;
      }
  }
}

private DateTime _ssTimestamp;
public DateTime ssTimestamp{
  get{
      return _ssTimestamp;
  }
  set{
      if((_ssTimestamp!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssTimestamp = value;
      }
  }
}

private string _ssImportType;
public string ssImportType{
  get{
      return _ssImportType;
  }
  set{
      if((_ssImportType!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssImportType = value;
      }
  }
}

private string _ssImportedBy;
public string ssImportedBy{
  get{
      return _ssImportedBy;
  }
  set{
      if((_ssImportedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssImportedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_57456f779b1d12573357da68381e59ceEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssFileId = 0L;
_ssTimestamp = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssImportType = "";
_ssImportedBy = "";
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
ssId = r.ReadLongInteger(index++, "FileImportLog.Id", 0L);
ssFileId = r.ReadEntityReferenceLongInteger(index++, "FileImportLog.FileId", 0L);
ssTimestamp = r.ReadDateTime(index++, "FileImportLog.Timestamp", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssImportType = r.ReadText(index++, "FileImportLog.ImportType", "");
ssImportedBy = r.ReadEntityReferenceText(index++, "FileImportLog.ImportedBy", "");
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_57456f779b1d12573357da68381e59ceEntityRecord r) {
this = r;
}


public static bool operator == (EN_57456f779b1d12573357da68381e59ceEntityRecord a, EN_57456f779b1d12573357da68381e59ceEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFileId != b.ssFileId) return false;
if (a.ssTimestamp != b.ssTimestamp) return false;
if (a.ssImportType != b.ssImportType) return false;
if (a.ssImportedBy != b.ssImportedBy) return false;
return true;
}

public static bool operator != (EN_57456f779b1d12573357da68381e59ceEntityRecord a, EN_57456f779b1d12573357da68381e59ceEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_57456f779b1d12573357da68381e59ceEntityRecord)) return false;
return (this == (EN_57456f779b1d12573357da68381e59ceEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFileId.GetHashCode()
 ^ ssTimestamp.GetHashCode()
 ^ ssImportType.GetHashCode()
 ^ ssImportedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_57456f779b1d12573357da68381e59ceEntityRecord Duplicate() {
EN_57456f779b1d12573357da68381e59ceEntityRecord t;
t._ssId = this._ssId;
t._ssFileId = this._ssFileId;
t._ssTimestamp = this._ssTimestamp;
t._ssImportType = this._ssImportType;
t._ssImportedBy = this._ssImportedBy;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
} else if (head == "fileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileId")) variable.Value = ssFileId; else variable.Optimized = true;
} else if (head == "timestamp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Timestamp")) variable.Value = ssTimestamp; else variable.Optimized = true;
} else if (head == "importtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImportType")) variable.Value = ssImportType; else variable.Optimized = true;
} else if (head == "importedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImportedBy")) variable.Value = ssImportedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFileId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdTimestamp)) {
return ChangedAttributes[2];
}
if (key.Equals(IdImportType)) {
return ChangedAttributes[3];
}
if (key.Equals(IdImportedBy)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFileId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdTimestamp)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdImportType)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdImportedBy)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFileId) {
return ssFileId;
}
if (key == IdTimestamp) {
return ssTimestamp;
}
if (key == IdImportType) {
return ssImportType;
}
if (key == IdImportedBy) {
return ssImportedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFileId.Key.AsGuid) {
return ssFileId;
}
if (attributeKey == IdTimestamp.Key.AsGuid) {
return ssTimestamp;
}
if (attributeKey == IdImportType.Key.AsGuid) {
return ssImportType;
}
if (attributeKey == IdImportedBy.Key.AsGuid) {
return ssImportedBy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFileId = (long) other.AttributeGet(IdFileId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFileId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFileId);
ssTimestamp = (DateTime) other.AttributeGet(IdTimestamp);
ChangedAttributes[2] = other.ChangedAttributeGet(IdTimestamp);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdTimestamp);
ssImportType = (string) other.AttributeGet(IdImportType);
ChangedAttributes[3] = other.ChangedAttributeGet(IdImportType);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdImportType);
ssImportedBy = (string) other.AttributeGet(IdImportedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdImportedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdImportedBy);
}
} // EN_57456f779b1d12573357da68381e59ceEntityRecord

/// <summary>
/// RecordList type <code>FileImportLogList</code> that represents a record list of
///  <code>FileImportLog</code>
/// </summary>
public partial class RL_5e925375dc8a9cf150bf3df0615efbdf : GenericRecordList<EN_57456f779b1d12573357da68381e59ceEntityRecord>, IEnumerable, IEnumerator {

protected override EN_57456f779b1d12573357da68381e59ceEntityRecord GetElementDefaultValue() {
return new EN_57456f779b1d12573357da68381e59ceEntityRecord();
}

public T[] ToArray<T>(Func<EN_57456f779b1d12573357da68381e59ceEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5e925375dc8a9cf150bf3df0615efbdf recordList, Func<EN_57456f779b1d12573357da68381e59ceEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5e925375dc8a9cf150bf3df0615efbdf(EN_57456f779b1d12573357da68381e59ceEntityRecord[] array) {
  RL_5e925375dc8a9cf150bf3df0615efbdf result = new RL_5e925375dc8a9cf150bf3df0615efbdf();
result.InnerFromArray(array);
    return result;
}

public static RL_5e925375dc8a9cf150bf3df0615efbdf ToList<T>(T[] array, Func <T, EN_57456f779b1d12573357da68381e59ceEntityRecord> converter) {
  RL_5e925375dc8a9cf150bf3df0615efbdf result = new RL_5e925375dc8a9cf150bf3df0615efbdf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5e925375dc8a9cf150bf3df0615efbdf FromRestList<T>(RestList<T> restList, Func <T, EN_57456f779b1d12573357da68381e59ceEntityRecord> converter) {
  RL_5e925375dc8a9cf150bf3df0615efbdf result = new RL_5e925375dc8a9cf150bf3df0615efbdf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5e925375dc8a9cf150bf3df0615efbdf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_57456f779b1d12573357da68381e59ceEntityRecord> NewList() {
return new RL_5e925375dc8a9cf150bf3df0615efbdf();
}


} // RL_5e925375dc8a9cf150bf3df0615efbdf
}
