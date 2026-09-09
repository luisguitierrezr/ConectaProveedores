using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionStatusHistory (DnmELHfKVkqjMgIGiFjE3g)
///  <code>EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord</code> that represent
/// s <code>RequisitionStatusHistory</code> <p>Description: Entity that holds Requisition Status
///  History.</p>
/// </summary>
// Name: RequisitionStatusHistory
public partial struct EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord : ITypedRecord<EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oG0fInnvcEiNfg6hKodbag");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YVC15d6nyEKFZVjUJGgLwA");
internal static readonly GlobalObjectKey IdRequisitionStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bIY8ZTRwI0m52SKULmf9Fw");
internal static readonly GlobalObjectKey IdTimeStamp = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gfh1zCAcd0m17BN3cnZOwg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HLHCll8180eGGSwT_UzJsA");

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

private long _ssRequisitionId;
public long ssRequisitionId{
  get{
      return _ssRequisitionId;
  }
  set{
      if((_ssRequisitionId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRequisitionId = value;
      }
  }
}

private int _ssRequisitionStatusId;
public int ssRequisitionStatusId{
  get{
      return _ssRequisitionStatusId;
  }
  set{
      if((_ssRequisitionStatusId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssRequisitionStatusId = value;
      }
  }
}

private DateTime _ssTimeStamp;
public DateTime ssTimeStamp{
  get{
      return _ssTimeStamp;
  }
  set{
      if((_ssTimeStamp!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssTimeStamp = value;
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


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssRequisitionId = 0L;
_ssRequisitionStatusId = 0;
_ssTimeStamp = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
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
ssId = r.ReadLongInteger(index++, "RequisitionStatusHistory.Id", 0L);
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionStatusHistory.RequisitionId", 0L);
ssRequisitionStatusId = r.ReadEntityReference(index++, "RequisitionStatusHistory.RequisitionStatusId", 0);
ssTimeStamp = r.ReadDateTime(index++, "RequisitionStatusHistory.TimeStamp", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "RequisitionStatusHistory.CreatedBy", "");
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
public void ReadIM(EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord r) {
this = r;
}


public static bool operator == (EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord a, EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssRequisitionStatusId != b.ssRequisitionStatusId) return false;
if (a.ssTimeStamp != b.ssTimeStamp) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
return true;
}

public static bool operator != (EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord a, EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord)) return false;
return (this == (EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssRequisitionStatusId.GetHashCode()
 ^ ssTimeStamp.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord Duplicate() {
EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord t;
t._ssId = this._ssId;
t._ssRequisitionId = this._ssRequisitionId;
t._ssRequisitionStatusId = this._ssRequisitionStatusId;
t._ssTimeStamp = this._ssTimeStamp;
t._ssCreatedBy = this._ssCreatedBy;
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
} else if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "requisitionstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionStatusId")) variable.Value = ssRequisitionStatusId; else variable.Optimized = true;
} else if (head == "timestamp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TimeStamp")) variable.Value = ssTimeStamp; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRequisitionId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdRequisitionStatusId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdTimeStamp)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRequisitionId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdRequisitionStatusId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdTimeStamp)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRequisitionId) {
return ssRequisitionId;
}
if (key == IdRequisitionStatusId) {
return ssRequisitionStatusId;
}
if (key == IdTimeStamp) {
return ssTimeStamp;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdRequisitionId.Key.AsGuid) {
return ssRequisitionId;
}
if (attributeKey == IdRequisitionStatusId.Key.AsGuid) {
return ssRequisitionStatusId;
}
if (attributeKey == IdTimeStamp.Key.AsGuid) {
return ssTimeStamp;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
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
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRequisitionId);
ssRequisitionStatusId = (int) other.AttributeGet(IdRequisitionStatusId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdRequisitionStatusId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRequisitionStatusId);
ssTimeStamp = (DateTime) other.AttributeGet(IdTimeStamp);
ChangedAttributes[3] = other.ChangedAttributeGet(IdTimeStamp);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdTimeStamp);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
}
} // EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord

/// <summary>
/// RecordList type <code>RequisitionStatusHistoryList</code> that represents a record list of
///  <code>RequisitionStatusHistory</code>
/// </summary>
public partial class RL_6aa6bb50291f77b81f4482dbc1cdb623 : GenericRecordList<EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord>, IEnumerable, IEnumerator {

protected override EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord GetElementDefaultValue() {
return new EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord();
}

public T[] ToArray<T>(Func<EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6aa6bb50291f77b81f4482dbc1cdb623 recordList, Func<EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6aa6bb50291f77b81f4482dbc1cdb623(EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord[] array) {
  RL_6aa6bb50291f77b81f4482dbc1cdb623 result = new RL_6aa6bb50291f77b81f4482dbc1cdb623();
result.InnerFromArray(array);
    return result;
}

public static RL_6aa6bb50291f77b81f4482dbc1cdb623 ToList<T>(T[] array, Func <T, EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord> converter) {
  RL_6aa6bb50291f77b81f4482dbc1cdb623 result = new RL_6aa6bb50291f77b81f4482dbc1cdb623();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6aa6bb50291f77b81f4482dbc1cdb623 FromRestList<T>(RestList<T> restList, Func <T, EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord> converter) {
  RL_6aa6bb50291f77b81f4482dbc1cdb623 result = new RL_6aa6bb50291f77b81f4482dbc1cdb623();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6aa6bb50291f77b81f4482dbc1cdb623() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d566458a53d0e8cbc28e1eb868fd2ba4EntityRecord> NewList() {
return new RL_6aa6bb50291f77b81f4482dbc1cdb623();
}


} // RL_6aa6bb50291f77b81f4482dbc1cdb623
}
