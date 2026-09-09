using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderRequestFileComment (UY9R+5Ad3UO5wngpNx_ZPA)
///  <code>EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord</code> that represent
/// s <code>OrderRequestFileComment</code> <p>Description: Entity that holds the Comments.</p>
/// </summary>
// Name: OrderRequestFileComment
public partial struct EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord : ITypedRecord<EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AvsUUfBu2E6DD6Kr1JiBlQ");
internal static readonly GlobalObjectKey IdOrderRequestFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*R9ZIPfjtVUukcuwG1lQL+w");
internal static readonly GlobalObjectKey IdCommentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cXdBQyAUgUOt4qPTJ6ZLRA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kmsWzho1ik2tIrqvNmhr8g");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dVQbs8Lwf0+HW9gIRP6mpg");

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

private long _ssOrderRequestFileId;
public long ssOrderRequestFileId{
  get{
      return _ssOrderRequestFileId;
  }
  set{
      if((_ssOrderRequestFileId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderRequestFileId = value;
      }
  }
}

private int _ssCommentTypeId;
public int ssCommentTypeId{
  get{
      return _ssCommentTypeId;
  }
  set{
      if((_ssCommentTypeId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCommentTypeId = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssMessage!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssMessage = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssOrderRequestFileId = 0L;
_ssCommentTypeId = 0;
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
ssId = r.ReadLongInteger(index++, "OrderRequestFileComment.Id", 0L);
ssOrderRequestFileId = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFileComment.OrderRequestFileId", 0L);
ssCommentTypeId = r.ReadEntityReference(index++, "OrderRequestFileComment.CommentTypeId", 0);
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderRequestFileComment.CreatedBy", "");
ssMessage = r.ReadText(index++, "OrderRequestFileComment.Message", "");
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
public void ReadIM(EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord r) {
this = r;
}


public static bool operator == (EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord a, EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderRequestFileId != b.ssOrderRequestFileId) return false;
if (a.ssCommentTypeId != b.ssCommentTypeId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord a, EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord)) return false;
return (this == (EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderRequestFileId.GetHashCode()
 ^ ssCommentTypeId.GetHashCode()
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


public EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord Duplicate() {
EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord t;
t._ssId = this._ssId;
t._ssOrderRequestFileId = this._ssOrderRequestFileId;
t._ssCommentTypeId = this._ssCommentTypeId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssMessage = this._ssMessage;
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
} else if (head == "orderrequestfileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileId")) variable.Value = ssOrderRequestFileId; else variable.Optimized = true;
} else if (head == "commenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommentTypeId")) variable.Value = ssCommentTypeId; else variable.Optimized = true;
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
if (key.Equals(IdOrderRequestFileId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCommentTypeId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[3];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderRequestFileId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdCommentTypeId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderRequestFileId) {
return ssOrderRequestFileId;
}
if (key == IdCommentTypeId) {
return ssCommentTypeId;
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
if (attributeKey == IdOrderRequestFileId.Key.AsGuid) {
return ssOrderRequestFileId;
}
if (attributeKey == IdCommentTypeId.Key.AsGuid) {
return ssCommentTypeId;
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
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderRequestFileId = (long) other.AttributeGet(IdOrderRequestFileId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderRequestFileId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderRequestFileId);
ssCommentTypeId = (int) other.AttributeGet(IdCommentTypeId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCommentTypeId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCommentTypeId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedBy);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[4] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdMessage);
}
} // EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord

/// <summary>
/// RecordList type <code>OrderRequestFileCommentList</code> that represents a record list of
///  <code>OrderRequestFileComment</code>
/// </summary>
public partial class RL_eab83ff333575b87f9926e3042a85ae3 : GenericRecordList<EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord>, IEnumerable, IEnumerator {

protected override EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord GetElementDefaultValue() {
return new EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord();
}

public T[] ToArray<T>(Func<EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eab83ff333575b87f9926e3042a85ae3 recordList, Func<EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eab83ff333575b87f9926e3042a85ae3(EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord[] array) {
  RL_eab83ff333575b87f9926e3042a85ae3 result = new RL_eab83ff333575b87f9926e3042a85ae3();
result.InnerFromArray(array);
    return result;
}

public static RL_eab83ff333575b87f9926e3042a85ae3 ToList<T>(T[] array, Func <T, EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord> converter) {
  RL_eab83ff333575b87f9926e3042a85ae3 result = new RL_eab83ff333575b87f9926e3042a85ae3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eab83ff333575b87f9926e3042a85ae3 FromRestList<T>(RestList<T> restList, Func <T, EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord> converter) {
  RL_eab83ff333575b87f9926e3042a85ae3 result = new RL_eab83ff333575b87f9926e3042a85ae3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eab83ff333575b87f9926e3042a85ae3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord> NewList() {
return new RL_eab83ff333575b87f9926e3042a85ae3();
}


} // RL_eab83ff333575b87f9926e3042a85ae3
}
