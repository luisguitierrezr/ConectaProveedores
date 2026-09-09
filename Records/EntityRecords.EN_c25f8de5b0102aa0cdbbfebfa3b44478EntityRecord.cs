using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioApproval (s830Dx3xK0KJ4MN59u9B9g)
///  <code>EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord</code> that represent
/// s <code>FolioApproval</code> <p>Description: Entity that holds Form Approval.</p>
/// </summary>
// Name: FolioApproval
public partial struct EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord : ITypedRecord<EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QNMz1kZMBkST7n15za17gg");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5CHWOq6nIEuRjdCPwQzJjQ");
internal static readonly GlobalObjectKey IdApprovalProcessId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vRA7TYII7U+8ZORq4HG6bw");
internal static readonly GlobalObjectKey IdProcessTypeCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*X7ifrFV9B0mH4Tx9Evby+w");
internal static readonly GlobalObjectKey IdApprovalProcessVersion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hiVfyxZMqE6mSTxaQCi1AA");
internal static readonly GlobalObjectKey IdCurrentLevel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Zm7M0bJM3E6yUBL4FdcHeA");
internal static readonly GlobalObjectKey IdMaxLevel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SGWTaVt+UUyp1zpFvMuH+Q");
internal static readonly GlobalObjectKey IdStartedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FrueDMi7HEGZwQkJQoqc1Q");
internal static readonly GlobalObjectKey IdFinishedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nz1LQmyBT0yg92R8yLzorw");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*R1MUUp3Z4k2YbjuyuGmShA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(10,true);
          _ssId = value;
      }
  }
}

private long _ssFolioId;
public long ssFolioId{
  get{
      return _ssFolioId;
  }
  set{
      if((_ssFolioId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFolioId = value;
      }
  }
}

private long _ssApprovalProcessId;
public long ssApprovalProcessId{
  get{
      return _ssApprovalProcessId;
  }
  set{
      if((_ssApprovalProcessId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssApprovalProcessId = value;
      }
  }
}

private string _ssProcessTypeCode;
public string ssProcessTypeCode{
  get{
      return _ssProcessTypeCode;
  }
  set{
      if((_ssProcessTypeCode!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssProcessTypeCode = value;
      }
  }
}

private string _ssApprovalProcessVersion;
public string ssApprovalProcessVersion{
  get{
      return _ssApprovalProcessVersion;
  }
  set{
      if((_ssApprovalProcessVersion!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssApprovalProcessVersion = value;
      }
  }
}

private int _ssCurrentLevel;
public int ssCurrentLevel{
  get{
      return _ssCurrentLevel;
  }
  set{
      if((_ssCurrentLevel!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCurrentLevel = value;
      }
  }
}

private int _ssMaxLevel;
public int ssMaxLevel{
  get{
      return _ssMaxLevel;
  }
  set{
      if((_ssMaxLevel!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssMaxLevel = value;
      }
  }
}

private DateTime _ssStartedOn;
public DateTime ssStartedOn{
  get{
      return _ssStartedOn;
  }
  set{
      if((_ssStartedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssStartedOn = value;
      }
  }
}

private DateTime _ssFinishedOn;
public DateTime ssFinishedOn{
  get{
      return _ssFinishedOn;
  }
  set{
      if((_ssFinishedOn!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssFinishedOn = value;
      }
  }
}

private long _ssRegionId;
public long ssRegionId{
  get{
      return _ssRegionId;
  }
  set{
      if((_ssRegionId!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssRegionId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord() {
ChangedAttributes = new BitArray(10,true);
OptimizedAttributes = new BitArray(10,false);
_ssId = 0L;
_ssFolioId = 0L;
_ssApprovalProcessId = 0L;
_ssProcessTypeCode = "";
_ssApprovalProcessVersion = "";
_ssCurrentLevel = 0;
_ssMaxLevel = 0;
_ssStartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssFinishedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssRegionId = 0L;
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
ssId = r.ReadLongInteger(index++, "FolioApproval.Id", 0L);
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioApproval.FolioId", 0L);
ssApprovalProcessId = r.ReadLongInteger(index++, "FolioApproval.ApprovalProcessId", 0L);
ssProcessTypeCode = r.ReadText(index++, "FolioApproval.ProcessTypeCode", "");
ssApprovalProcessVersion = r.ReadText(index++, "FolioApproval.ApprovalProcessVersion", "");
ssCurrentLevel = r.ReadInteger(index++, "FolioApproval.CurrentLevel", 0);
ssMaxLevel = r.ReadInteger(index++, "FolioApproval.MaxLevel", 0);
ssStartedOn = r.ReadDateTime(index++, "FolioApproval.StartedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFinishedOn = r.ReadDateTime(index++, "FolioApproval.FinishedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "FolioApproval.RegionId", 0L);
ChangedAttributes = new BitArray(10,false);
OptimizedAttributes = new BitArray(10,false);
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
public void ReadIM(EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord r) {
this = r;
}


public static bool operator == (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord a, EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssApprovalProcessId != b.ssApprovalProcessId) return false;
if (a.ssProcessTypeCode != b.ssProcessTypeCode) return false;
if (a.ssApprovalProcessVersion != b.ssApprovalProcessVersion) return false;
if (a.ssCurrentLevel != b.ssCurrentLevel) return false;
if (a.ssMaxLevel != b.ssMaxLevel) return false;
if (a.ssStartedOn != b.ssStartedOn) return false;
if (a.ssFinishedOn != b.ssFinishedOn) return false;
if (a.ssRegionId != b.ssRegionId) return false;
return true;
}

public static bool operator != (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord a, EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)) return false;
return (this == (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssApprovalProcessId.GetHashCode()
 ^ ssProcessTypeCode.GetHashCode()
 ^ ssApprovalProcessVersion.GetHashCode()
 ^ ssCurrentLevel.GetHashCode()
 ^ ssMaxLevel.GetHashCode()
 ^ ssStartedOn.GetHashCode()
 ^ ssFinishedOn.GetHashCode()
 ^ ssRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord Duplicate() {
EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord t;
t._ssId = this._ssId;
t._ssFolioId = this._ssFolioId;
t._ssApprovalProcessId = this._ssApprovalProcessId;
t._ssProcessTypeCode = this._ssProcessTypeCode;
t._ssApprovalProcessVersion = this._ssApprovalProcessVersion;
t._ssCurrentLevel = this._ssCurrentLevel;
t._ssMaxLevel = this._ssMaxLevel;
t._ssStartedOn = this._ssStartedOn;
t._ssFinishedOn = this._ssFinishedOn;
t._ssRegionId = this._ssRegionId;
t.ChangedAttributes = new BitArray(10);
t.OptimizedAttributes = new BitArray(10);
for(int i = 0; i < 10; i++){
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
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "approvalprocessid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessId")) variable.Value = ssApprovalProcessId; else variable.Optimized = true;
} else if (head == "processtypecode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessTypeCode")) variable.Value = ssProcessTypeCode; else variable.Optimized = true;
} else if (head == "approvalprocessversion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessVersion")) variable.Value = ssApprovalProcessVersion; else variable.Optimized = true;
} else if (head == "currentlevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrentLevel")) variable.Value = ssCurrentLevel; else variable.Optimized = true;
} else if (head == "maxlevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxLevel")) variable.Value = ssMaxLevel; else variable.Optimized = true;
} else if (head == "startedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartedOn")) variable.Value = ssStartedOn; else variable.Optimized = true;
} else if (head == "finishedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishedOn")) variable.Value = ssFinishedOn; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdApprovalProcessId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdProcessTypeCode)) {
return ChangedAttributes[3];
}
if (key.Equals(IdApprovalProcessVersion)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCurrentLevel)) {
return ChangedAttributes[5];
}
if (key.Equals(IdMaxLevel)) {
return ChangedAttributes[6];
}
if (key.Equals(IdStartedOn)) {
return ChangedAttributes[7];
}
if (key.Equals(IdFinishedOn)) {
return ChangedAttributes[8];
}
if (key.Equals(IdRegionId)) {
return ChangedAttributes[9];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdApprovalProcessId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdProcessTypeCode)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdApprovalProcessVersion)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCurrentLevel)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdMaxLevel)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdStartedOn)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdFinishedOn)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdRegionId)) {
return OptimizedAttributes[9];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdApprovalProcessId) {
return ssApprovalProcessId;
}
if (key == IdProcessTypeCode) {
return ssProcessTypeCode;
}
if (key == IdApprovalProcessVersion) {
return ssApprovalProcessVersion;
}
if (key == IdCurrentLevel) {
return ssCurrentLevel;
}
if (key == IdMaxLevel) {
return ssMaxLevel;
}
if (key == IdStartedOn) {
return ssStartedOn;
}
if (key == IdFinishedOn) {
return ssFinishedOn;
}
if (key == IdRegionId) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdApprovalProcessId.Key.AsGuid) {
return ssApprovalProcessId;
}
if (attributeKey == IdProcessTypeCode.Key.AsGuid) {
return ssProcessTypeCode;
}
if (attributeKey == IdApprovalProcessVersion.Key.AsGuid) {
return ssApprovalProcessVersion;
}
if (attributeKey == IdCurrentLevel.Key.AsGuid) {
return ssCurrentLevel;
}
if (attributeKey == IdMaxLevel.Key.AsGuid) {
return ssMaxLevel;
}
if (attributeKey == IdStartedOn.Key.AsGuid) {
return ssStartedOn;
}
if (attributeKey == IdFinishedOn.Key.AsGuid) {
return ssFinishedOn;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(10);
OptimizedAttributes = new BitArray(10);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFolioId);
ssApprovalProcessId = (long) other.AttributeGet(IdApprovalProcessId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdApprovalProcessId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdApprovalProcessId);
ssProcessTypeCode = (string) other.AttributeGet(IdProcessTypeCode);
ChangedAttributes[3] = other.ChangedAttributeGet(IdProcessTypeCode);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdProcessTypeCode);
ssApprovalProcessVersion = (string) other.AttributeGet(IdApprovalProcessVersion);
ChangedAttributes[4] = other.ChangedAttributeGet(IdApprovalProcessVersion);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdApprovalProcessVersion);
ssCurrentLevel = (int) other.AttributeGet(IdCurrentLevel);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCurrentLevel);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCurrentLevel);
ssMaxLevel = (int) other.AttributeGet(IdMaxLevel);
ChangedAttributes[6] = other.ChangedAttributeGet(IdMaxLevel);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdMaxLevel);
ssStartedOn = (DateTime) other.AttributeGet(IdStartedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdStartedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdStartedOn);
ssFinishedOn = (DateTime) other.AttributeGet(IdFinishedOn);
ChangedAttributes[8] = other.ChangedAttributeGet(IdFinishedOn);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdFinishedOn);
ssRegionId = (long) other.AttributeGet(IdRegionId);
ChangedAttributes[9] = other.ChangedAttributeGet(IdRegionId);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdRegionId);
}
} // EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord

/// <summary>
/// RecordList type <code>FolioApprovalList</code> that represents a record list of
///  <code>FolioApproval</code>
/// </summary>
public partial class RL_4961fcbf3ab00622ee245175e9341e9b : GenericRecordList<EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord>, IEnumerable, IEnumerator {

protected override EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord GetElementDefaultValue() {
return new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
}

public T[] ToArray<T>(Func<EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4961fcbf3ab00622ee245175e9341e9b recordList, Func<EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4961fcbf3ab00622ee245175e9341e9b(EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord[] array) {
  RL_4961fcbf3ab00622ee245175e9341e9b result = new RL_4961fcbf3ab00622ee245175e9341e9b();
result.InnerFromArray(array);
    return result;
}

public static RL_4961fcbf3ab00622ee245175e9341e9b ToList<T>(T[] array, Func <T, EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord> converter) {
  RL_4961fcbf3ab00622ee245175e9341e9b result = new RL_4961fcbf3ab00622ee245175e9341e9b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4961fcbf3ab00622ee245175e9341e9b FromRestList<T>(RestList<T> restList, Func <T, EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord> converter) {
  RL_4961fcbf3ab00622ee245175e9341e9b result = new RL_4961fcbf3ab00622ee245175e9341e9b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4961fcbf3ab00622ee245175e9341e9b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord> NewList() {
return new RL_4961fcbf3ab00622ee245175e9341e9b();
}


} // RL_4961fcbf3ab00622ee245175e9341e9b
}
