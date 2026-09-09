using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioComment (feF6a7KwXUWVdAsdPOMS7g)
///  <code>EN_a75639301080da49357fc03810b8d65fEntityRecord</code> that represent
/// s <code>FolioComment</code> <p>Description: Entity that holds Folio Comments</p>
/// </summary>
// Name: FolioComment
public partial struct EN_a75639301080da49357fc03810b8d65fEntityRecord : ITypedRecord<EN_a75639301080da49357fc03810b8d65fEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dLcmyQVwE06Uy3cgb6ExMA");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xJAdYH0IQkagLT1_JLMpgg");
internal static readonly GlobalObjectKey IdFolioApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S+qqEAqvNUuIm20C65usfw");
internal static readonly GlobalObjectKey IdCommentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MF1GTeviiEitgbhsEiI11Q");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PTBLWbBNyUWxIh+QiucwEA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TvpMDb3y6kqH6VdOGb53qA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3f_qBIxg00WMoXciuMJfNQ");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OhPmn777SkijCwCWlIZHIQ");
internal static readonly GlobalObjectKey IdIsPublic = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VS9kGg8QJ0K3nyR5k1AJGw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(9,true);
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

private long _ssFolioApprovalLevelId;
public long ssFolioApprovalLevelId{
  get{
      return _ssFolioApprovalLevelId;
  }
  set{
      if((_ssFolioApprovalLevelId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssFolioApprovalLevelId = value;
      }
  }
}

private int _ssCommentTypeId;
public int ssCommentTypeId{
  get{
      return _ssCommentTypeId;
  }
  set{
      if((_ssCommentTypeId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCommentTypeId = value;
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

private bool _ssIsPublic;
public bool ssIsPublic{
  get{
      return _ssIsPublic;
  }
  set{
      if((_ssIsPublic!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIsPublic = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_a75639301080da49357fc03810b8d65fEntityRecord() {
ChangedAttributes = new BitArray(9,true);
OptimizedAttributes = new BitArray(9,false);
_ssId = 0L;
_ssFolioId = 0L;
_ssFolioApprovalLevelId = 0L;
_ssCommentTypeId = 0;
_ssApplicationRoleId = 0L;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssMessage = "";
_ssIsPublic = false;
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
ssId = r.ReadLongInteger(index++, "FolioComment.Id", 0L);
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioComment.FolioId", 0L);
ssFolioApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "FolioComment.FolioApprovalLevelId", 0L);
ssCommentTypeId = r.ReadEntityReference(index++, "FolioComment.CommentTypeId", 0);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "FolioComment.ApplicationRoleId", 0L);
ssCreatedOn = r.ReadDateTime(index++, "FolioComment.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "FolioComment.CreatedBy", "");
ssMessage = r.ReadText(index++, "FolioComment.Message", "");
ssIsPublic = r.ReadBoolean(index++, "FolioComment.IsPublic", false);
ChangedAttributes = new BitArray(9,false);
OptimizedAttributes = new BitArray(9,false);
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
public void ReadIM(EN_a75639301080da49357fc03810b8d65fEntityRecord r) {
this = r;
}


public static bool operator == (EN_a75639301080da49357fc03810b8d65fEntityRecord a, EN_a75639301080da49357fc03810b8d65fEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssFolioApprovalLevelId != b.ssFolioApprovalLevelId) return false;
if (a.ssCommentTypeId != b.ssCommentTypeId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssIsPublic != b.ssIsPublic) return false;
return true;
}

public static bool operator != (EN_a75639301080da49357fc03810b8d65fEntityRecord a, EN_a75639301080da49357fc03810b8d65fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_a75639301080da49357fc03810b8d65fEntityRecord)) return false;
return (this == (EN_a75639301080da49357fc03810b8d65fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssFolioApprovalLevelId.GetHashCode()
 ^ ssCommentTypeId.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssIsPublic.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_a75639301080da49357fc03810b8d65fEntityRecord Duplicate() {
EN_a75639301080da49357fc03810b8d65fEntityRecord t;
t._ssId = this._ssId;
t._ssFolioId = this._ssFolioId;
t._ssFolioApprovalLevelId = this._ssFolioApprovalLevelId;
t._ssCommentTypeId = this._ssCommentTypeId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssMessage = this._ssMessage;
t._ssIsPublic = this._ssIsPublic;
t.ChangedAttributes = new BitArray(9);
t.OptimizedAttributes = new BitArray(9);
for(int i = 0; i < 9; i++){
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
} else if (head == "folioapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevelId")) variable.Value = ssFolioApprovalLevelId; else variable.Optimized = true;
} else if (head == "commenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommentTypeId")) variable.Value = ssCommentTypeId; else variable.Optimized = true;
} else if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "ispublic") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsPublic")) variable.Value = ssIsPublic; else variable.Optimized = true;
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
if (key.Equals(IdFolioApprovalLevelId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCommentTypeId)) {
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
if (key.Equals(IdIsPublic)) {
return ChangedAttributes[8];
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
if (key.Equals(IdFolioApprovalLevelId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCommentTypeId)) {
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
if (key.Equals(IdIsPublic)) {
return OptimizedAttributes[8];
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
if (key == IdFolioApprovalLevelId) {
return ssFolioApprovalLevelId;
}
if (key == IdCommentTypeId) {
return ssCommentTypeId;
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
if (key == IdIsPublic) {
return ssIsPublic;
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
if (attributeKey == IdFolioApprovalLevelId.Key.AsGuid) {
return ssFolioApprovalLevelId;
}
if (attributeKey == IdCommentTypeId.Key.AsGuid) {
return ssCommentTypeId;
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
if (attributeKey == IdIsPublic.Key.AsGuid) {
return ssIsPublic;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(9);
OptimizedAttributes = new BitArray(9);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFolioId);
ssFolioApprovalLevelId = (long) other.AttributeGet(IdFolioApprovalLevelId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdFolioApprovalLevelId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFolioApprovalLevelId);
ssCommentTypeId = (int) other.AttributeGet(IdCommentTypeId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCommentTypeId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCommentTypeId);
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
ssIsPublic = (bool) other.AttributeGet(IdIsPublic);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIsPublic);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIsPublic);
}
} // EN_a75639301080da49357fc03810b8d65fEntityRecord

/// <summary>
/// RecordList type <code>FolioCommentList</code> that represents a record list of
///  <code>FolioComment</code>
/// </summary>
public partial class RL_987eb79735f7cd07a6fb45f0620d3e68 : GenericRecordList<EN_a75639301080da49357fc03810b8d65fEntityRecord>, IEnumerable, IEnumerator {

protected override EN_a75639301080da49357fc03810b8d65fEntityRecord GetElementDefaultValue() {
return new EN_a75639301080da49357fc03810b8d65fEntityRecord();
}

public T[] ToArray<T>(Func<EN_a75639301080da49357fc03810b8d65fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_987eb79735f7cd07a6fb45f0620d3e68 recordList, Func<EN_a75639301080da49357fc03810b8d65fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_987eb79735f7cd07a6fb45f0620d3e68(EN_a75639301080da49357fc03810b8d65fEntityRecord[] array) {
  RL_987eb79735f7cd07a6fb45f0620d3e68 result = new RL_987eb79735f7cd07a6fb45f0620d3e68();
result.InnerFromArray(array);
    return result;
}

public static RL_987eb79735f7cd07a6fb45f0620d3e68 ToList<T>(T[] array, Func <T, EN_a75639301080da49357fc03810b8d65fEntityRecord> converter) {
  RL_987eb79735f7cd07a6fb45f0620d3e68 result = new RL_987eb79735f7cd07a6fb45f0620d3e68();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_987eb79735f7cd07a6fb45f0620d3e68 FromRestList<T>(RestList<T> restList, Func <T, EN_a75639301080da49357fc03810b8d65fEntityRecord> converter) {
  RL_987eb79735f7cd07a6fb45f0620d3e68 result = new RL_987eb79735f7cd07a6fb45f0620d3e68();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_987eb79735f7cd07a6fb45f0620d3e68() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_a75639301080da49357fc03810b8d65fEntityRecord> NewList() {
return new RL_987eb79735f7cd07a6fb45f0620d3e68();
}


} // RL_987eb79735f7cd07a6fb45f0620d3e68
}
