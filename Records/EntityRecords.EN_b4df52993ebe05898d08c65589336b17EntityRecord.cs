using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] ApplicantTelcelDirection (yCHKAL9tWEG3xtROFvvOqA)
///  <code>EN_b4df52993ebe05898d08c65589336b17EntityRecord</code> that represent
/// s <code>ApplicantTelcelDirection</code> <p>Description: Entity to hold all relations between
///  applicants and direction to limit first approvers list</p>
/// </summary>
// Name: ApplicantTelcelDirection
public partial struct EN_b4df52993ebe05898d08c65589336b17EntityRecord : ITypedRecord<EN_b4df52993ebe05898d08c65589336b17EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*zX3youDJNUaY0wKTeNwO+g");
internal static readonly GlobalObjectKey IdApplicantId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*KaqIWtUoMkm4tkT_cxEEfw");
internal static readonly GlobalObjectKey IdTelcelDirectionId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*DjLXqC1d6UCqzNuUyKD6xA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ycrECwc8rkuWa7y2Yno0VA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*aC0NH1jwZE21ltQOgchW1A");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*uYC_hOtqI0WqstGkDmM6lQ");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*PV3+kyU6d0qTDT4E8k9phw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(7,true);
          _ssId = value;
      }
  }
}

private long _ssApplicantId;
public long ssApplicantId{
  get{
      return _ssApplicantId;
  }
  set{
      if((_ssApplicantId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssApplicantId = value;
      }
  }
}

private long _ssTelcelDirectionId;
public long ssTelcelDirectionId{
  get{
      return _ssTelcelDirectionId;
  }
  set{
      if((_ssTelcelDirectionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssTelcelDirectionId = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCreatedOn = value;
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

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b4df52993ebe05898d08c65589336b17EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssApplicantId = 0L;
_ssTelcelDirectionId = 0L;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
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
ssId = r.ReadLongInteger(index++, "ApplicantTelcelDirection.Id", 0L);
ssApplicantId = r.ReadEntityReferenceLongInteger(index++, "ApplicantTelcelDirection.ApplicantId", 0L);
ssTelcelDirectionId = r.ReadEntityReferenceLongInteger(index++, "ApplicantTelcelDirection.TelcelDirectionId", 0L);
ssCreatedOn = r.ReadDateTime(index++, "ApplicantTelcelDirection.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "ApplicantTelcelDirection.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "ApplicantTelcelDirection.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "ApplicantTelcelDirection.UpdatedBy", "");
ChangedAttributes = new BitArray(7,false);
OptimizedAttributes = new BitArray(7,false);
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
public void ReadIM(EN_b4df52993ebe05898d08c65589336b17EntityRecord r) {
this = r;
}


public static bool operator == (EN_b4df52993ebe05898d08c65589336b17EntityRecord a, EN_b4df52993ebe05898d08c65589336b17EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssApplicantId != b.ssApplicantId) return false;
if (a.ssTelcelDirectionId != b.ssTelcelDirectionId) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_b4df52993ebe05898d08c65589336b17EntityRecord a, EN_b4df52993ebe05898d08c65589336b17EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b4df52993ebe05898d08c65589336b17EntityRecord)) return false;
return (this == (EN_b4df52993ebe05898d08c65589336b17EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssApplicantId.GetHashCode()
 ^ ssTelcelDirectionId.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
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


public EN_b4df52993ebe05898d08c65589336b17EntityRecord Duplicate() {
EN_b4df52993ebe05898d08c65589336b17EntityRecord t;
t._ssId = this._ssId;
t._ssApplicantId = this._ssApplicantId;
t._ssTelcelDirectionId = this._ssTelcelDirectionId;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(7);
t.OptimizedAttributes = new BitArray(7);
for(int i = 0; i < 7; i++){
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
} else if (head == "applicantid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicantId")) variable.Value = ssApplicantId; else variable.Optimized = true;
} else if (head == "telceldirectionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirectionId")) variable.Value = ssTelcelDirectionId; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
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
if (key.Equals(IdApplicantId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdTelcelDirectionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdApplicantId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdTelcelDirectionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdApplicantId) {
return ssApplicantId;
}
if (key == IdTelcelDirectionId) {
return ssTelcelDirectionId;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
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
if (attributeKey == IdApplicantId.Key.AsGuid) {
return ssApplicantId;
}
if (attributeKey == IdTelcelDirectionId.Key.AsGuid) {
return ssTelcelDirectionId;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
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
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssApplicantId = (long) other.AttributeGet(IdApplicantId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdApplicantId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdApplicantId);
ssTelcelDirectionId = (long) other.AttributeGet(IdTelcelDirectionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdTelcelDirectionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdTelcelDirectionId);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_b4df52993ebe05898d08c65589336b17EntityRecord

/// <summary>
/// RecordList type <code>ApplicantTelcelDirectionList</code> that represents a record list of
///  <code>ApplicantTelcelDirection</code>
/// </summary>
public partial class RL_c62485ef8056277719b5d5aebe939814 : GenericRecordList<EN_b4df52993ebe05898d08c65589336b17EntityRecord>, IEnumerable, IEnumerator {

protected override EN_b4df52993ebe05898d08c65589336b17EntityRecord GetElementDefaultValue() {
return new EN_b4df52993ebe05898d08c65589336b17EntityRecord();
}

public T[] ToArray<T>(Func<EN_b4df52993ebe05898d08c65589336b17EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c62485ef8056277719b5d5aebe939814 recordList, Func<EN_b4df52993ebe05898d08c65589336b17EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c62485ef8056277719b5d5aebe939814(EN_b4df52993ebe05898d08c65589336b17EntityRecord[] array) {
  RL_c62485ef8056277719b5d5aebe939814 result = new RL_c62485ef8056277719b5d5aebe939814();
result.InnerFromArray(array);
    return result;
}

public static RL_c62485ef8056277719b5d5aebe939814 ToList<T>(T[] array, Func <T, EN_b4df52993ebe05898d08c65589336b17EntityRecord> converter) {
  RL_c62485ef8056277719b5d5aebe939814 result = new RL_c62485ef8056277719b5d5aebe939814();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c62485ef8056277719b5d5aebe939814 FromRestList<T>(RestList<T> restList, Func <T, EN_b4df52993ebe05898d08c65589336b17EntityRecord> converter) {
  RL_c62485ef8056277719b5d5aebe939814 result = new RL_c62485ef8056277719b5d5aebe939814();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c62485ef8056277719b5d5aebe939814() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b4df52993ebe05898d08c65589336b17EntityRecord> NewList() {
return new RL_c62485ef8056277719b5d5aebe939814();
}


} // RL_c62485ef8056277719b5d5aebe939814
}
