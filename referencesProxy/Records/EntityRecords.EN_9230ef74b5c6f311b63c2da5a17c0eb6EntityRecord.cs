using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Applicant (SdvoX67EvEOXdR+GBiUIEw)
///  <code>EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord</code> that represents <code>Applicant</code
/// > <p>Description: Applicant</p>
/// </summary>
// Name: Applicant
public partial struct EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord : ITypedRecord<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*th9M9yJmE0ShL8PRb8QG9w");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*rxymcrKKzUWId+KuYHavtA");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*lHMhH9A3OESCJg7uD15zzA");
internal static readonly GlobalObjectKey IdApprovalProcessTypeId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*e9nykSJRHEatCE9mc5ZXmQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*qmIBhq1uPUeT8Euw_RjPVA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*lgznCukhdU+oJvpLK4pwjQ");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*BiiP_zi_7Ua2yfmkzbQJHg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*xa4KuIVBz0ux_++66s7Mrw");

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

private string _ssApplicant;
public string ssApplicant{
  get{
      return _ssApplicant;
  }
  set{
      if((_ssApplicant!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssApplicant = value;
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

private int _ssApprovalProcessTypeId;
public int ssApprovalProcessTypeId{
  get{
      return _ssApprovalProcessTypeId;
  }
  set{
      if((_ssApprovalProcessTypeId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssApprovalProcessTypeId = value;
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

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUpdatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssApplicant = "";
_ssDescription = "";
_ssApprovalProcessTypeId = 0;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
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
ssId = r.ReadLongInteger(index++, "Applicant.Id", 0L);
ssApplicant = r.ReadText(index++, "Applicant.Applicant", "");
ssDescription = r.ReadText(index++, "Applicant.Description", "");
ssApprovalProcessTypeId = r.ReadEntityReference(index++, "Applicant.ApprovalProcessTypeId", 0);
ssCreatedBy = r.ReadEntityReferenceText(index++, "Applicant.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "Applicant.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedOn = r.ReadDateTime(index++, "Applicant.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Applicant.UpdatedBy", "");
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
public void ReadIM(EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord r) {
this = r;
}


public static bool operator == (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord a, EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssApplicant != b.ssApplicant) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssApprovalProcessTypeId != b.ssApprovalProcessTypeId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord a, EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord)) return false;
return (this == (EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssApplicant.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssApprovalProcessTypeId.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord Duplicate() {
EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord t;
t._ssId = this._ssId;
t._ssApplicant = this._ssApplicant;
t._ssDescription = this._ssDescription;
t._ssApprovalProcessTypeId = this._ssApprovalProcessTypeId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
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
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssApplicant; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "approvalprocesstypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessTypeId")) variable.Value = ssApprovalProcessTypeId; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdApplicant)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApprovalProcessTypeId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdApplicant)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApprovalProcessTypeId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdApplicant) {
return ssApplicant;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdApprovalProcessTypeId) {
return ssApprovalProcessTypeId;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssApplicant;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdApprovalProcessTypeId.Key.AsGuid) {
return ssApprovalProcessTypeId;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
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
ssApplicant = (string) other.AttributeGet(IdApplicant);
ChangedAttributes[1] = other.ChangedAttributeGet(IdApplicant);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdApplicant);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
ssApprovalProcessTypeId = (int) other.AttributeGet(IdApprovalProcessTypeId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApprovalProcessTypeId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApprovalProcessTypeId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord

/// <summary>
/// RecordList type <code>ApplicantList</code> that represents a record list of <code>Applicant</code>
/// </summary>
public partial class RL_0e05eb9d600ec259c65108d36b6b031b : GenericRecordList<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord>, IEnumerable, IEnumerator {

protected override EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord GetElementDefaultValue() {
return new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord();
}

public T[] ToArray<T>(Func<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0e05eb9d600ec259c65108d36b6b031b recordList, Func<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0e05eb9d600ec259c65108d36b6b031b(EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord[] array) {
  RL_0e05eb9d600ec259c65108d36b6b031b result = new RL_0e05eb9d600ec259c65108d36b6b031b();
result.InnerFromArray(array);
    return result;
}

public static RL_0e05eb9d600ec259c65108d36b6b031b ToList<T>(T[] array, Func <T, EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> converter) {
  RL_0e05eb9d600ec259c65108d36b6b031b result = new RL_0e05eb9d600ec259c65108d36b6b031b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0e05eb9d600ec259c65108d36b6b031b FromRestList<T>(RestList<T> restList, Func <T, EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> converter) {
  RL_0e05eb9d600ec259c65108d36b6b031b result = new RL_0e05eb9d600ec259c65108d36b6b031b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0e05eb9d600ec259c65108d36b6b031b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord> NewList() {
return new RL_0e05eb9d600ec259c65108d36b6b031b();
}


} // RL_0e05eb9d600ec259c65108d36b6b031b
}
