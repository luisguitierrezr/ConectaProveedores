using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ProposalStatusHistory (+auVPBL9R0KhnjmybyvWLQ)
///  <code>EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord</code> that represent
/// s <code>ProposalStatusHistory</code> <p>Description: Entity that holds timestamps of Proposal
///  Status History .</p>
/// </summary>
// Name: ProposalStatusHistory
public partial struct EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord : ITypedRecord<EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yRNjtxMnFkCKJA3xSVAVYA");
internal static readonly GlobalObjectKey IdProposalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qypvYnf9pEWciyuZDHYJdQ");
internal static readonly GlobalObjectKey IdProposalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0_eDwZ44UEKvzV904z4vmg");
internal static readonly GlobalObjectKey IdTimeStamp = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*neGWbk7EXkCQxXWU7UYrnA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oi08kRcG4Ui_VMFUThK7xQ");

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

private long _ssProposalId;
public long ssProposalId{
  get{
      return _ssProposalId;
  }
  set{
      if((_ssProposalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProposalId = value;
      }
  }
}

private int _ssProposalStatusId;
public int ssProposalStatusId{
  get{
      return _ssProposalStatusId;
  }
  set{
      if((_ssProposalStatusId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProposalStatusId = value;
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

public EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssProposalId = 0L;
_ssProposalStatusId = 0;
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
ssId = r.ReadLongInteger(index++, "ProposalStatusHistory.Id", 0L);
ssProposalId = r.ReadEntityReferenceLongInteger(index++, "ProposalStatusHistory.ProposalId", 0L);
ssProposalStatusId = r.ReadEntityReference(index++, "ProposalStatusHistory.ProposalStatusId", 0);
ssTimeStamp = r.ReadDateTime(index++, "ProposalStatusHistory.TimeStamp", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "ProposalStatusHistory.CreatedBy", "");
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
public void ReadIM(EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord r) {
this = r;
}


public static bool operator == (EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord a, EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProposalId != b.ssProposalId) return false;
if (a.ssProposalStatusId != b.ssProposalStatusId) return false;
if (a.ssTimeStamp != b.ssTimeStamp) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
return true;
}

public static bool operator != (EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord a, EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord)) return false;
return (this == (EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProposalId.GetHashCode()
 ^ ssProposalStatusId.GetHashCode()
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


public EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord Duplicate() {
EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord t;
t._ssId = this._ssId;
t._ssProposalId = this._ssProposalId;
t._ssProposalStatusId = this._ssProposalStatusId;
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
} else if (head == "proposalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalId")) variable.Value = ssProposalId; else variable.Optimized = true;
} else if (head == "proposalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalStatusId")) variable.Value = ssProposalStatusId; else variable.Optimized = true;
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
if (key.Equals(IdProposalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdProposalStatusId)) {
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
if (key.Equals(IdProposalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdProposalStatusId)) {
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
if (key == IdProposalId) {
return ssProposalId;
}
if (key == IdProposalStatusId) {
return ssProposalStatusId;
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
if (attributeKey == IdProposalId.Key.AsGuid) {
return ssProposalId;
}
if (attributeKey == IdProposalStatusId.Key.AsGuid) {
return ssProposalStatusId;
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
ssProposalId = (long) other.AttributeGet(IdProposalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProposalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProposalId);
ssProposalStatusId = (int) other.AttributeGet(IdProposalStatusId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProposalStatusId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProposalStatusId);
ssTimeStamp = (DateTime) other.AttributeGet(IdTimeStamp);
ChangedAttributes[3] = other.ChangedAttributeGet(IdTimeStamp);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdTimeStamp);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
}
} // EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord

/// <summary>
/// RecordList type <code>ProposalStatusHistoryList</code> that represents a record list of
///  <code>ProposalStatusHistory</code>
/// </summary>
public partial class RL_e7dbaa9f7769c54aab4d1349cf20c071 : GenericRecordList<EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord>, IEnumerable, IEnumerator {

protected override EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord GetElementDefaultValue() {
return new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord();
}

public T[] ToArray<T>(Func<EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e7dbaa9f7769c54aab4d1349cf20c071 recordList, Func<EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e7dbaa9f7769c54aab4d1349cf20c071(EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord[] array) {
  RL_e7dbaa9f7769c54aab4d1349cf20c071 result = new RL_e7dbaa9f7769c54aab4d1349cf20c071();
result.InnerFromArray(array);
    return result;
}

public static RL_e7dbaa9f7769c54aab4d1349cf20c071 ToList<T>(T[] array, Func <T, EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord> converter) {
  RL_e7dbaa9f7769c54aab4d1349cf20c071 result = new RL_e7dbaa9f7769c54aab4d1349cf20c071();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e7dbaa9f7769c54aab4d1349cf20c071 FromRestList<T>(RestList<T> restList, Func <T, EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord> converter) {
  RL_e7dbaa9f7769c54aab4d1349cf20c071 result = new RL_e7dbaa9f7769c54aab4d1349cf20c071();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e7dbaa9f7769c54aab4d1349cf20c071() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord> NewList() {
return new RL_e7dbaa9f7769c54aab4d1349cf20c071();
}


} // RL_e7dbaa9f7769c54aab4d1349cf20c071
}
