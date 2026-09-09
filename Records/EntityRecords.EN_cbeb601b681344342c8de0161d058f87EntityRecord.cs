using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionComment (fV3a8mZpC0yCiN3rSuxAMw)
///  <code>EN_cbeb601b681344342c8de0161d058f87EntityRecord</code> that represent
/// s <code>RequisitionComment</code> <p>Description: Entity that holds RequisitionComment.</p>
/// </summary>
// Name: RequisitionComment
public partial struct EN_cbeb601b681344342c8de0161d058f87EntityRecord : ITypedRecord<EN_cbeb601b681344342c8de0161d058f87EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sXZpW94RjEWhJNSbWZOoQA");
internal static readonly GlobalObjectKey IdCommentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sL51GiPUPUGto0MsJQsaqA");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5R+bEMveME6tg6rTYcdn_Q");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l4zEKT4KTUa9EFksso1tdQ");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*j4HDR5VjMUiYeOt5VAd9eA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0zdG9ycqjU26SiNQNqrjaQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uQ3mX7O+7U6OIzWQ68bKdg");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Isc0BXkZkk+TaDmXaTgHHw");

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

private int _ssCommentTypeId;
public int ssCommentTypeId{
  get{
      return _ssCommentTypeId;
  }
  set{
      if((_ssCommentTypeId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssCommentTypeId = value;
      }
  }
}

private long _ssRequisitionId;
public long ssRequisitionId{
  get{
      return _ssRequisitionId;
  }
  set{
      if((_ssRequisitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssRequisitionId = value;
      }
  }
}

private long _ssRequisitionApprovalLevelId;
public long ssRequisitionApprovalLevelId{
  get{
      return _ssRequisitionApprovalLevelId;
  }
  set{
      if((_ssRequisitionApprovalLevelId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssRequisitionApprovalLevelId = value;
      }
  }
}

private long _ssApplicationRoleId;
public long ssApplicationRoleId{
  get{
      return _ssApplicationRoleId;
  }
  set{
      if((_ssApplicationRoleId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssApplicationRoleId = value;
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

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCreatedBy = value;
      }
  }
}

private string _ssMessage;
public string ssMessage{
  get{
      return _ssMessage;
  }
  set{
      if((_ssMessage!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssMessage = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_cbeb601b681344342c8de0161d058f87EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssCommentTypeId = 0;
_ssRequisitionId = 0L;
_ssRequisitionApprovalLevelId = 0L;
_ssApplicationRoleId = 0L;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssMessage = "";
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
ssId = r.ReadLongInteger(index++, "RequisitionComment.Id", 0L);
ssCommentTypeId = r.ReadEntityReference(index++, "RequisitionComment.CommentTypeId", 0);
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionComment.RequisitionId", 0L);
ssRequisitionApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "RequisitionComment.RequisitionApprovalLevelId", 0L);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "RequisitionComment.ApplicationRoleId", 0L);
ssCreatedOn = r.ReadDateTime(index++, "RequisitionComment.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "RequisitionComment.CreatedBy", "");
ssMessage = r.ReadText(index++, "RequisitionComment.Message", "");
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
public void ReadIM(EN_cbeb601b681344342c8de0161d058f87EntityRecord r) {
this = r;
}


public static bool operator == (EN_cbeb601b681344342c8de0161d058f87EntityRecord a, EN_cbeb601b681344342c8de0161d058f87EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCommentTypeId != b.ssCommentTypeId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssRequisitionApprovalLevelId != b.ssRequisitionApprovalLevelId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (EN_cbeb601b681344342c8de0161d058f87EntityRecord a, EN_cbeb601b681344342c8de0161d058f87EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_cbeb601b681344342c8de0161d058f87EntityRecord)) return false;
return (this == (EN_cbeb601b681344342c8de0161d058f87EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCommentTypeId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssRequisitionApprovalLevelId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_cbeb601b681344342c8de0161d058f87EntityRecord Duplicate() {
EN_cbeb601b681344342c8de0161d058f87EntityRecord t;
t._ssId = this._ssId;
t._ssCommentTypeId = this._ssCommentTypeId;
t._ssRequisitionId = this._ssRequisitionId;
t._ssRequisitionApprovalLevelId = this._ssRequisitionApprovalLevelId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssMessage = this._ssMessage;
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
} else if (head == "commenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommentTypeId")) variable.Value = ssCommentTypeId; else variable.Optimized = true;
} else if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "requisitionapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevelId")) variable.Value = ssRequisitionApprovalLevelId; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdCommentTypeId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdRequisitionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdRequisitionApprovalLevelId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[6];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdCommentTypeId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdRequisitionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdRequisitionApprovalLevelId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdCommentTypeId) {
return ssCommentTypeId;
}
if (key == IdRequisitionId) {
return ssRequisitionId;
}
if (key == IdRequisitionApprovalLevelId) {
return ssRequisitionApprovalLevelId;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdCommentTypeId.Key.AsGuid) {
return ssCommentTypeId;
}
if (attributeKey == IdRequisitionId.Key.AsGuid) {
return ssRequisitionId;
}
if (attributeKey == IdRequisitionApprovalLevelId.Key.AsGuid) {
return ssRequisitionApprovalLevelId;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
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
ssCommentTypeId = (int) other.AttributeGet(IdCommentTypeId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCommentTypeId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCommentTypeId);
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRequisitionId);
ssRequisitionApprovalLevelId = (long) other.AttributeGet(IdRequisitionApprovalLevelId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdRequisitionApprovalLevelId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdRequisitionApprovalLevelId);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[7] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdMessage);
}
} // EN_cbeb601b681344342c8de0161d058f87EntityRecord

/// <summary>
/// RecordList type <code>RequisitionCommentList</code> that represents a record list of
///  <code>RequisitionComment</code>
/// </summary>
public partial class RL_7c535deb7c739955440288212af4c0dc : GenericRecordList<EN_cbeb601b681344342c8de0161d058f87EntityRecord>, IEnumerable, IEnumerator {

protected override EN_cbeb601b681344342c8de0161d058f87EntityRecord GetElementDefaultValue() {
return new EN_cbeb601b681344342c8de0161d058f87EntityRecord();
}

public T[] ToArray<T>(Func<EN_cbeb601b681344342c8de0161d058f87EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7c535deb7c739955440288212af4c0dc recordList, Func<EN_cbeb601b681344342c8de0161d058f87EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7c535deb7c739955440288212af4c0dc(EN_cbeb601b681344342c8de0161d058f87EntityRecord[] array) {
  RL_7c535deb7c739955440288212af4c0dc result = new RL_7c535deb7c739955440288212af4c0dc();
result.InnerFromArray(array);
    return result;
}

public static RL_7c535deb7c739955440288212af4c0dc ToList<T>(T[] array, Func <T, EN_cbeb601b681344342c8de0161d058f87EntityRecord> converter) {
  RL_7c535deb7c739955440288212af4c0dc result = new RL_7c535deb7c739955440288212af4c0dc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7c535deb7c739955440288212af4c0dc FromRestList<T>(RestList<T> restList, Func <T, EN_cbeb601b681344342c8de0161d058f87EntityRecord> converter) {
  RL_7c535deb7c739955440288212af4c0dc result = new RL_7c535deb7c739955440288212af4c0dc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7c535deb7c739955440288212af4c0dc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_cbeb601b681344342c8de0161d058f87EntityRecord> NewList() {
return new RL_7c535deb7c739955440288212af4c0dc();
}


} // RL_7c535deb7c739955440288212af4c0dc
}
