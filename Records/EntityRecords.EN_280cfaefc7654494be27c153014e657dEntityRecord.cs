using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] ProcessTypeDatesAllowed (MmYHaAFMQEieMQffDeJbOA)
///  <code>EN_280cfaefc7654494be27c153014e657dEntityRecord</code> that represent
/// s <code>ProcessTypeDatesAllowed</code> <p>Description: Entity holds Procress Type Dates that are
///  allowed</p>
/// </summary>
// Name: ProcessTypeDatesAllowed
public partial struct EN_280cfaefc7654494be27c153014e657dEntityRecord : ITypedRecord<EN_280cfaefc7654494be27c153014e657dEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Tnj6IawVwE+Sd27GOuEFUQ");
internal static readonly GlobalObjectKey IdProcessTypeCode = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*UEtAt1fQaUq4pzYyc6uCLw");
internal static readonly GlobalObjectKey IdDayOfWeekId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*yeO_Ii2oK0qG0PjFsrOSgg");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+fZfI4hyt0OEFtcYe0JrXw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*79XrS037d0KZA53jzPWFMg");

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

private string _ssProcessTypeCode;
public string ssProcessTypeCode{
  get{
      return _ssProcessTypeCode;
  }
  set{
      if((_ssProcessTypeCode!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProcessTypeCode = value;
      }
  }
}

private int _ssDayOfWeekId;
public int ssDayOfWeekId{
  get{
      return _ssDayOfWeekId;
  }
  set{
      if((_ssDayOfWeekId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssDayOfWeekId = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_280cfaefc7654494be27c153014e657dEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssProcessTypeCode = "";
_ssDayOfWeekId = 0;
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
ssId = r.ReadLongInteger(index++, "ProcessTypeDatesAllowed.Id", 0L);
ssProcessTypeCode = r.ReadText(index++, "ProcessTypeDatesAllowed.ProcessTypeCode", "");
ssDayOfWeekId = r.ReadEntityReference(index++, "ProcessTypeDatesAllowed.DayOfWeekId", 0);
ssUpdatedOn = r.ReadDateTime(index++, "ProcessTypeDatesAllowed.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "ProcessTypeDatesAllowed.UpdatedBy", "");
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
public void ReadIM(EN_280cfaefc7654494be27c153014e657dEntityRecord r) {
this = r;
}


public static bool operator == (EN_280cfaefc7654494be27c153014e657dEntityRecord a, EN_280cfaefc7654494be27c153014e657dEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProcessTypeCode != b.ssProcessTypeCode) return false;
if (a.ssDayOfWeekId != b.ssDayOfWeekId) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_280cfaefc7654494be27c153014e657dEntityRecord a, EN_280cfaefc7654494be27c153014e657dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_280cfaefc7654494be27c153014e657dEntityRecord)) return false;
return (this == (EN_280cfaefc7654494be27c153014e657dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProcessTypeCode.GetHashCode()
 ^ ssDayOfWeekId.GetHashCode()
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


public EN_280cfaefc7654494be27c153014e657dEntityRecord Duplicate() {
EN_280cfaefc7654494be27c153014e657dEntityRecord t;
t._ssId = this._ssId;
t._ssProcessTypeCode = this._ssProcessTypeCode;
t._ssDayOfWeekId = this._ssDayOfWeekId;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
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
} else if (head == "processtypecode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessTypeCode")) variable.Value = ssProcessTypeCode; else variable.Optimized = true;
} else if (head == "dayofweekid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DayOfWeekId")) variable.Value = ssDayOfWeekId; else variable.Optimized = true;
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
if (key.Equals(IdProcessTypeCode)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDayOfWeekId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProcessTypeCode)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDayOfWeekId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProcessTypeCode) {
return ssProcessTypeCode;
}
if (key == IdDayOfWeekId) {
return ssDayOfWeekId;
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
if (attributeKey == IdProcessTypeCode.Key.AsGuid) {
return ssProcessTypeCode;
}
if (attributeKey == IdDayOfWeekId.Key.AsGuid) {
return ssDayOfWeekId;
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
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProcessTypeCode = (string) other.AttributeGet(IdProcessTypeCode);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProcessTypeCode);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProcessTypeCode);
ssDayOfWeekId = (int) other.AttributeGet(IdDayOfWeekId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDayOfWeekId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDayOfWeekId);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_280cfaefc7654494be27c153014e657dEntityRecord

/// <summary>
/// RecordList type <code>ProcessTypeDatesAllowedList</code> that represents a record list of
///  <code>ProcessTypeDatesAllowed</code>
/// </summary>
public partial class RL_0634f3842df711824255e4232e4e5f75 : GenericRecordList<EN_280cfaefc7654494be27c153014e657dEntityRecord>, IEnumerable, IEnumerator {

protected override EN_280cfaefc7654494be27c153014e657dEntityRecord GetElementDefaultValue() {
return new EN_280cfaefc7654494be27c153014e657dEntityRecord();
}

public T[] ToArray<T>(Func<EN_280cfaefc7654494be27c153014e657dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0634f3842df711824255e4232e4e5f75 recordList, Func<EN_280cfaefc7654494be27c153014e657dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0634f3842df711824255e4232e4e5f75(EN_280cfaefc7654494be27c153014e657dEntityRecord[] array) {
  RL_0634f3842df711824255e4232e4e5f75 result = new RL_0634f3842df711824255e4232e4e5f75();
result.InnerFromArray(array);
    return result;
}

public static RL_0634f3842df711824255e4232e4e5f75 ToList<T>(T[] array, Func <T, EN_280cfaefc7654494be27c153014e657dEntityRecord> converter) {
  RL_0634f3842df711824255e4232e4e5f75 result = new RL_0634f3842df711824255e4232e4e5f75();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0634f3842df711824255e4232e4e5f75 FromRestList<T>(RestList<T> restList, Func <T, EN_280cfaefc7654494be27c153014e657dEntityRecord> converter) {
  RL_0634f3842df711824255e4232e4e5f75 result = new RL_0634f3842df711824255e4232e4e5f75();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0634f3842df711824255e4232e4e5f75() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_280cfaefc7654494be27c153014e657dEntityRecord> NewList() {
return new RL_0634f3842df711824255e4232e4e5f75();
}


} // RL_0634f3842df711824255e4232e4e5f75
}
