using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceComment (5XuWPb6k2U2IsL_enBxv_g)
///  <code>EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord</code> that represent
/// s <code>InvoiceComment</code> <p>Description: Entity that holds Invoice Comments</p>
/// </summary>
// Name: InvoiceComment
public partial struct EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord : ITypedRecord<EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0fb4t0oTDU+UeIJrkt2cBg");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4QaqTWt1u0WmmFGULlMQhQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevelId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eRDuwM_LC0KNFH_qbD8oKA");
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8UXX3IqrlUKPVS9NvTJlMQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rkY2CW+ZuUe3noSe1U+z8g");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1ZkViH5O9025Jff8KIiAZQ");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yXjKo55OuEiQw+NezMWL+w");
internal static readonly GlobalObjectKey IdIsPublic = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7Wsbl+2BVU+IwQsN7ZNpXQ");

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

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceId = value;
      }
  }
}

private long _ssInvoiceApprovalLevelId;
public long ssInvoiceApprovalLevelId{
  get{
      return _ssInvoiceApprovalLevelId;
  }
  set{
      if((_ssInvoiceApprovalLevelId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssInvoiceApprovalLevelId = value;
      }
  }
}

private long _ssApplicationRoleId;
public long ssApplicationRoleId{
  get{
      return _ssApplicationRoleId;
  }
  set{
      if((_ssApplicationRoleId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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

private bool _ssIsPublic;
public bool ssIsPublic{
  get{
      return _ssIsPublic;
  }
  set{
      if((_ssIsPublic!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsPublic = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssInvoiceApprovalLevelId = 0L;
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
ssId = r.ReadLongInteger(index++, "InvoiceComment.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceComment.InvoiceId", 0L);
ssInvoiceApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "InvoiceComment.InvoiceApprovalLevelId", 0L);
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "InvoiceComment.ApplicationRoleId", 0L);
ssCreatedOn = r.ReadDateTime(index++, "InvoiceComment.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceComment.CreatedBy", "");
ssMessage = r.ReadText(index++, "InvoiceComment.Message", "");
ssIsPublic = r.ReadBoolean(index++, "InvoiceComment.IsPublic", false);
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
public void ReadIM(EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord r) {
this = r;
}


public static bool operator == (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord a, EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceApprovalLevelId != b.ssInvoiceApprovalLevelId) return false;
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssIsPublic != b.ssIsPublic) return false;
return true;
}

public static bool operator != (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord a, EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord)) return false;
return (this == (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceApprovalLevelId.GetHashCode()
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


public EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord Duplicate() {
EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssInvoiceApprovalLevelId = this._ssInvoiceApprovalLevelId;
t._ssApplicationRoleId = this._ssApplicationRoleId;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssMessage = this._ssMessage;
t._ssIsPublic = this._ssIsPublic;
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "invoiceapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevelId")) variable.Value = ssInvoiceApprovalLevelId; else variable.Optimized = true;
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
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdInvoiceApprovalLevelId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[5];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsPublic)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdInvoiceApprovalLevelId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdApplicationRoleId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsPublic)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdInvoiceApprovalLevelId) {
return ssInvoiceApprovalLevelId;
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
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdInvoiceApprovalLevelId.Key.AsGuid) {
return ssInvoiceApprovalLevelId;
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
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssInvoiceApprovalLevelId = (long) other.AttributeGet(IdInvoiceApprovalLevelId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdInvoiceApprovalLevelId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInvoiceApprovalLevelId);
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdApplicationRoleId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdApplicationRoleId);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedBy);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[6] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdMessage);
ssIsPublic = (bool) other.AttributeGet(IdIsPublic);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsPublic);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsPublic);
}
} // EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord

/// <summary>
/// RecordList type <code>InvoiceCommentList</code> that represents a record list of
///  <code>InvoiceComment</code>
/// </summary>
public partial class RL_66b967a6adb0a5fa5dee7801e8ba2cb8 : GenericRecordList<EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord>, IEnumerable, IEnumerator {

protected override EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord GetElementDefaultValue() {
return new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord();
}

public T[] ToArray<T>(Func<EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_66b967a6adb0a5fa5dee7801e8ba2cb8 recordList, Func<EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_66b967a6adb0a5fa5dee7801e8ba2cb8(EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord[] array) {
  RL_66b967a6adb0a5fa5dee7801e8ba2cb8 result = new RL_66b967a6adb0a5fa5dee7801e8ba2cb8();
result.InnerFromArray(array);
    return result;
}

public static RL_66b967a6adb0a5fa5dee7801e8ba2cb8 ToList<T>(T[] array, Func <T, EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord> converter) {
  RL_66b967a6adb0a5fa5dee7801e8ba2cb8 result = new RL_66b967a6adb0a5fa5dee7801e8ba2cb8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_66b967a6adb0a5fa5dee7801e8ba2cb8 FromRestList<T>(RestList<T> restList, Func <T, EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord> converter) {
  RL_66b967a6adb0a5fa5dee7801e8ba2cb8 result = new RL_66b967a6adb0a5fa5dee7801e8ba2cb8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_66b967a6adb0a5fa5dee7801e8ba2cb8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord> NewList() {
return new RL_66b967a6adb0a5fa5dee7801e8ba2cb8();
}


} // RL_66b967a6adb0a5fa5dee7801e8ba2cb8
}
