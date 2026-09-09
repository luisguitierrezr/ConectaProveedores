using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderComment (73dTTv4H8UCvQk9AA_Qjeg)
///  <code>EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord</code> that represent
/// s <code>OrderComment</code> <p>Description: Entity that holds Comments.</p>
/// </summary>
// Name: OrderComment
public partial struct EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord : ITypedRecord<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*h2kxvzxUSkazYFhdIXykHw");
internal static readonly GlobalObjectKey IdCommentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oIChvvYSQUysf2Aqkh6mqA");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YtoLiB7op0uH3l+GNN87ng");
internal static readonly GlobalObjectKey IdOrderApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rzXKisTi4UuahwhvRnWDsA");
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Q7qwKQjXxUSgIf3i6p_H_A");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dF4eZHBpOk2PNRw1toge7g");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DNBWTyK5xEaMQZpg27qdTA");

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

private long _ssOrderId;
public long ssOrderId{
  get{
      return _ssOrderId;
  }
  set{
      if((_ssOrderId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOrderId = value;
      }
  }
}

private long _ssOrderApprovalLevelId;
public long ssOrderApprovalLevelId{
  get{
      return _ssOrderApprovalLevelId;
  }
  set{
      if((_ssOrderApprovalLevelId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssOrderApprovalLevelId = value;
      }
  }
}

private long _ssEntraRoleId;
public long ssEntraRoleId{
  get{
      return _ssEntraRoleId;
  }
  set{
      if((_ssEntraRoleId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssEntraRoleId = value;
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

private string _ssMessage;
public string ssMessage{
  get{
      return _ssMessage;
  }
  set{
      if((_ssMessage!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssMessage = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssCommentTypeId = 0;
_ssOrderId = 0L;
_ssOrderApprovalLevelId = 0L;
_ssEntraRoleId = 0L;
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
ssId = r.ReadLongInteger(index++, "OrderComment.Id", 0L);
ssCommentTypeId = r.ReadEntityReference(index++, "OrderComment.CommentTypeId", 0);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderComment.OrderId", 0L);
ssOrderApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "OrderComment.OrderApprovalLevelId", 0L);
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "OrderComment.EntraRoleId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderComment.CreatedBy", "");
ssMessage = r.ReadText(index++, "OrderComment.Message", "");
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
public void ReadIM(EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord r) {
this = r;
}


public static bool operator == (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord a, EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCommentTypeId != b.ssCommentTypeId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssOrderApprovalLevelId != b.ssOrderApprovalLevelId) return false;
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord a, EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord)) return false;
return (this == (EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCommentTypeId.GetHashCode()
 ^ ssOrderId.GetHashCode()
 ^ ssOrderApprovalLevelId.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
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


public EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord Duplicate() {
EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord t;
t._ssId = this._ssId;
t._ssCommentTypeId = this._ssCommentTypeId;
t._ssOrderId = this._ssOrderId;
t._ssOrderApprovalLevelId = this._ssOrderApprovalLevelId;
t._ssEntraRoleId = this._ssEntraRoleId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssMessage = this._ssMessage;
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
} else if (head == "commenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommentTypeId")) variable.Value = ssCommentTypeId; else variable.Optimized = true;
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
} else if (head == "orderapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevelId")) variable.Value = ssOrderApprovalLevelId; else variable.Optimized = true;
} else if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
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
if (key.Equals(IdOrderId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOrderApprovalLevelId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdEntraRoleId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[5];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[6];
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
if (key.Equals(IdOrderId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOrderApprovalLevelId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdEntraRoleId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[6];
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
if (key == IdOrderId) {
return ssOrderId;
}
if (key == IdOrderApprovalLevelId) {
return ssOrderApprovalLevelId;
}
if (key == IdEntraRoleId) {
return ssEntraRoleId;
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
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
}
if (attributeKey == IdOrderApprovalLevelId.Key.AsGuid) {
return ssOrderApprovalLevelId;
}
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
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
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssCommentTypeId = (int) other.AttributeGet(IdCommentTypeId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCommentTypeId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCommentTypeId);
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrderId);
ssOrderApprovalLevelId = (long) other.AttributeGet(IdOrderApprovalLevelId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOrderApprovalLevelId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOrderApprovalLevelId);
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdEntraRoleId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdEntraRoleId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedBy);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[6] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdMessage);
}
} // EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord

/// <summary>
/// RecordList type <code>OrderCommentList</code> that represents a record list of
///  <code>OrderComment</code>
/// </summary>
public partial class RL_69805775181e5f16b0f43a032f215f4b : GenericRecordList<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord>, IEnumerable, IEnumerator {

protected override EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord GetElementDefaultValue() {
return new EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord();
}

public T[] ToArray<T>(Func<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_69805775181e5f16b0f43a032f215f4b recordList, Func<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_69805775181e5f16b0f43a032f215f4b(EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord[] array) {
  RL_69805775181e5f16b0f43a032f215f4b result = new RL_69805775181e5f16b0f43a032f215f4b();
result.InnerFromArray(array);
    return result;
}

public static RL_69805775181e5f16b0f43a032f215f4b ToList<T>(T[] array, Func <T, EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> converter) {
  RL_69805775181e5f16b0f43a032f215f4b result = new RL_69805775181e5f16b0f43a032f215f4b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_69805775181e5f16b0f43a032f215f4b FromRestList<T>(RestList<T> restList, Func <T, EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> converter) {
  RL_69805775181e5f16b0f43a032f215f4b result = new RL_69805775181e5f16b0f43a032f215f4b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_69805775181e5f16b0f43a032f215f4b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord> NewList() {
return new RL_69805775181e5f16b0f43a032f215f4b();
}


} // RL_69805775181e5f16b0f43a032f215f4b
}
