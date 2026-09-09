using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] AccountingAccounts_ServiceType (ZSM5yHBxZEOY5XLhEwGe6g)
///  <code>EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord</code> that represent
/// s <code>AccountingAccounts_ServiceType</code> <p>Description: Entity holds accouting accounts
///  service types.</p>
/// </summary>
// Name: AccountingAccounts_ServiceType
public partial struct EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord : ITypedRecord<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*UGAAGSbyFkqrSzuIiavL_g");
internal static readonly GlobalObjectKey IdCC = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*SFgAKq1UKkGvz_htAku_nA");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*0uQFT1ilrUu+udtl7CiHFg");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*MYoSqcMtIkC7e5_ZSwhejw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*H6aQ_WXWE0OMyi61aziW7A");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*oEeIGccBjUKvZaYSNbLeHg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*yNXZoz45EEibNYykaYSOyw");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*hp7vwdFaaE+aU2Sl6f_ZTg");

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

private string _ssCC;
public string ssCC{
  get{
      return _ssCC;
  }
  set{
      if((_ssCC!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssCC = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssDescription = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsActive = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUpdatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssUpdatedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssCC = "";
_ssDescription = "";
_ssIsActive = true;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "AccountingAccounts_ServiceType.Id", 0L);
ssCC = r.ReadText(index++, "AccountingAccounts_ServiceType.CC", "");
ssDescription = r.ReadText(index++, "AccountingAccounts_ServiceType.Description", "");
ssIsActive = r.ReadBoolean(index++, "AccountingAccounts_ServiceType.IsActive", true);
ssCreatedBy = r.ReadEntityReferenceText(index++, "AccountingAccounts_ServiceType.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "AccountingAccounts_ServiceType.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "AccountingAccounts_ServiceType.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "AccountingAccounts_ServiceType.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord r) {
this = r;
}


public static bool operator == (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord a, EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCC != b.ssCC) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
return true;
}

public static bool operator != (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord a, EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)) return false;
return (this == (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCC.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord Duplicate() {
EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord t;
t._ssId = this._ssId;
t._ssCC = this._ssCC;
t._ssDescription = this._ssDescription;
t._ssIsActive = this._ssIsActive;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
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
} else if (head == "cc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CC")) variable.Value = ssCC; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdCC)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[6];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdCC)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdCC) {
return ssCC;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdCC.Key.AsGuid) {
return ssCC;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
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
ssCC = (string) other.AttributeGet(IdCC);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCC);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCC);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsActive);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdatedOn);
}
} // EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord

/// <summary>
/// RecordList type <code>AccountingAccounts_ServiceTypeList</code> that represents a record list of
///  <code>AccountingAccounts_ServiceType</code>
/// </summary>
public partial class RL_d32f6374f483ce61daee565f6dd14b7c : GenericRecordList<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord>, IEnumerable, IEnumerator {

protected override EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord GetElementDefaultValue() {
return new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
}

public T[] ToArray<T>(Func<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d32f6374f483ce61daee565f6dd14b7c recordList, Func<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d32f6374f483ce61daee565f6dd14b7c(EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord[] array) {
  RL_d32f6374f483ce61daee565f6dd14b7c result = new RL_d32f6374f483ce61daee565f6dd14b7c();
result.InnerFromArray(array);
    return result;
}

public static RL_d32f6374f483ce61daee565f6dd14b7c ToList<T>(T[] array, Func <T, EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> converter) {
  RL_d32f6374f483ce61daee565f6dd14b7c result = new RL_d32f6374f483ce61daee565f6dd14b7c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d32f6374f483ce61daee565f6dd14b7c FromRestList<T>(RestList<T> restList, Func <T, EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> converter) {
  RL_d32f6374f483ce61daee565f6dd14b7c result = new RL_d32f6374f483ce61daee565f6dd14b7c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d32f6374f483ce61daee565f6dd14b7c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord> NewList() {
return new RL_d32f6374f483ce61daee565f6dd14b7c();
}


} // RL_d32f6374f483ce61daee565f6dd14b7c
}
