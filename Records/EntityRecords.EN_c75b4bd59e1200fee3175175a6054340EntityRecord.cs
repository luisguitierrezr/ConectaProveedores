using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ProposalComment (17qkpdh0Q0i_64FbPSFtAA)
///  <code>EN_c75b4bd59e1200fee3175175a6054340EntityRecord</code> that represent
/// s <code>ProposalComment</code> <p>Description: Entity that holds the Comments.</p>
/// </summary>
// Name: ProposalComment
public partial struct EN_c75b4bd59e1200fee3175175a6054340EntityRecord : ITypedRecord<EN_c75b4bd59e1200fee3175175a6054340EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RMRzhx5jPEio884pUmIpag");
internal static readonly GlobalObjectKey IdCommentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yZBKuNzyV0e4LYLzeMC4rQ");
internal static readonly GlobalObjectKey IdProposalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*J6G4S8QYt0CJ_qoxm4XUbQ");
internal static readonly GlobalObjectKey IdProposalLineId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*U5Vx0b5e8kC_HcgU4Ln0Kw");
internal static readonly GlobalObjectKey IdProposalLineApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PDJqZbeoo0KDgMkc43fKtA");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KRF5friV2keVKiioAryI0g");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*r7WL9pW0hkmWz2NhzhiLJQ");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5PZXZ44e8EqXQvJcBytbWw");

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

private long _ssProposalId;
public long ssProposalId{
  get{
      return _ssProposalId;
  }
  set{
      if((_ssProposalId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProposalId = value;
      }
  }
}

private long _ssProposalLineId;
public long ssProposalLineId{
  get{
      return _ssProposalLineId;
  }
  set{
      if((_ssProposalLineId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssProposalLineId = value;
      }
  }
}

private long _ssProposalLineApprovalLevelId;
public long ssProposalLineApprovalLevelId{
  get{
      return _ssProposalLineApprovalLevelId;
  }
  set{
      if((_ssProposalLineApprovalLevelId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssProposalLineApprovalLevelId = value;
      }
  }
}

private long _ssApplicationRoleId;
public long ssApplicationRoleId{
  get{
      return _ssApplicationRoleId;
  }
  set{
      if((_ssApplicationRoleId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssApplicationRoleId = value;
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

public EN_c75b4bd59e1200fee3175175a6054340EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssCommentTypeId = 0;
_ssProposalId = 0L;
_ssProposalLineId = 0L;
_ssProposalLineApprovalLevelId = 0L;
_ssApplicationRoleId = 0L;
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
ssId = r.ReadLongInteger(index++, "ProposalComment.Id", 0L);
ssCommentTypeId = r.ReadEntityReference(index++, "ProposalComment.CommentTypeId", 0);
ssProposalId = r.ReadEntityReferenceLongInteger(index++, "ProposalComment.ProposalId", 0L);
ssProposalLineId = r.ReadEntityReferenceLongInteger(index++, "ProposalComment.ProposalLineId", 0L);
ssProposalLineApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "ProposalComment.ProposalLineApprovalLevelId", 0L);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "ProposalComment.ApplicationRoleId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "ProposalComment.CreatedBy", "");
ssMessage = r.ReadText(index++, "ProposalComment.Message", "");
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
public void ReadIM(EN_c75b4bd59e1200fee3175175a6054340EntityRecord r) {
this = r;
}


public static bool operator == (EN_c75b4bd59e1200fee3175175a6054340EntityRecord a, EN_c75b4bd59e1200fee3175175a6054340EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCommentTypeId != b.ssCommentTypeId) return false;
if (a.ssProposalId != b.ssProposalId) return false;
if (a.ssProposalLineId != b.ssProposalLineId) return false;
if (a.ssProposalLineApprovalLevelId != b.ssProposalLineApprovalLevelId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (EN_c75b4bd59e1200fee3175175a6054340EntityRecord a, EN_c75b4bd59e1200fee3175175a6054340EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c75b4bd59e1200fee3175175a6054340EntityRecord)) return false;
return (this == (EN_c75b4bd59e1200fee3175175a6054340EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCommentTypeId.GetHashCode()
 ^ ssProposalId.GetHashCode()
 ^ ssProposalLineId.GetHashCode()
 ^ ssProposalLineApprovalLevelId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
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


public EN_c75b4bd59e1200fee3175175a6054340EntityRecord Duplicate() {
EN_c75b4bd59e1200fee3175175a6054340EntityRecord t;
t._ssId = this._ssId;
t._ssCommentTypeId = this._ssCommentTypeId;
t._ssProposalId = this._ssProposalId;
t._ssProposalLineId = this._ssProposalLineId;
t._ssProposalLineApprovalLevelId = this._ssProposalLineApprovalLevelId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
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
} else if (head == "proposalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalId")) variable.Value = ssProposalId; else variable.Optimized = true;
} else if (head == "proposallineid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineId")) variable.Value = ssProposalLineId; else variable.Optimized = true;
} else if (head == "proposallineapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineApprovalLevelId")) variable.Value = ssProposalLineApprovalLevelId; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
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
if (key.Equals(IdProposalId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdProposalLineId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdProposalLineApprovalLevelId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdApplicationRoleId)) {
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
if (key.Equals(IdProposalId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdProposalLineId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdProposalLineApprovalLevelId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdApplicationRoleId)) {
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
if (key == IdProposalId) {
return ssProposalId;
}
if (key == IdProposalLineId) {
return ssProposalLineId;
}
if (key == IdProposalLineApprovalLevelId) {
return ssProposalLineApprovalLevelId;
}
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
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
if (attributeKey == IdProposalId.Key.AsGuid) {
return ssProposalId;
}
if (attributeKey == IdProposalLineId.Key.AsGuid) {
return ssProposalLineId;
}
if (attributeKey == IdProposalLineApprovalLevelId.Key.AsGuid) {
return ssProposalLineApprovalLevelId;
}
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
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
ssProposalId = (long) other.AttributeGet(IdProposalId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProposalId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProposalId);
ssProposalLineId = (long) other.AttributeGet(IdProposalLineId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdProposalLineId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdProposalLineId);
ssProposalLineApprovalLevelId = (long) other.AttributeGet(IdProposalLineApprovalLevelId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdProposalLineApprovalLevelId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdProposalLineApprovalLevelId);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[7] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdMessage);
}
} // EN_c75b4bd59e1200fee3175175a6054340EntityRecord

/// <summary>
/// RecordList type <code>ProposalCommentList</code> that represents a record list of
///  <code>ProposalComment</code>
/// </summary>
public partial class RL_c672761695f40aa29881ae9d2f12e19b : GenericRecordList<EN_c75b4bd59e1200fee3175175a6054340EntityRecord>, IEnumerable, IEnumerator {

protected override EN_c75b4bd59e1200fee3175175a6054340EntityRecord GetElementDefaultValue() {
return new EN_c75b4bd59e1200fee3175175a6054340EntityRecord();
}

public T[] ToArray<T>(Func<EN_c75b4bd59e1200fee3175175a6054340EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c672761695f40aa29881ae9d2f12e19b recordList, Func<EN_c75b4bd59e1200fee3175175a6054340EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c672761695f40aa29881ae9d2f12e19b(EN_c75b4bd59e1200fee3175175a6054340EntityRecord[] array) {
  RL_c672761695f40aa29881ae9d2f12e19b result = new RL_c672761695f40aa29881ae9d2f12e19b();
result.InnerFromArray(array);
    return result;
}

public static RL_c672761695f40aa29881ae9d2f12e19b ToList<T>(T[] array, Func <T, EN_c75b4bd59e1200fee3175175a6054340EntityRecord> converter) {
  RL_c672761695f40aa29881ae9d2f12e19b result = new RL_c672761695f40aa29881ae9d2f12e19b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c672761695f40aa29881ae9d2f12e19b FromRestList<T>(RestList<T> restList, Func <T, EN_c75b4bd59e1200fee3175175a6054340EntityRecord> converter) {
  RL_c672761695f40aa29881ae9d2f12e19b result = new RL_c672761695f40aa29881ae9d2f12e19b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c672761695f40aa29881ae9d2f12e19b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c75b4bd59e1200fee3175175a6054340EntityRecord> NewList() {
return new RL_c672761695f40aa29881ae9d2f12e19b();
}


} // RL_c672761695f40aa29881ae9d2f12e19b
}
