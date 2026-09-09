using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionLogs (C+9hKs1bVk+TK8I5Lboj8g)
///  <code>EN_fca813b8ca96d6759e00225744caa7d4EntityRecord</code> that represent
/// s <code>RequisitionLogs</code> <p>Description: </p>
/// </summary>
// Name: RequisitionLogs
public partial struct EN_fca813b8ca96d6759e00225744caa7d4EntityRecord : ITypedRecord<EN_fca813b8ca96d6759e00225744caa7d4EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HR87xaWFsUKESwz2iIdcQQ");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VuiK4ZghCUeUuUp0wOELRQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3_QEqKBrXUqj2xWE4+jq6Q");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Zo_nmTKVlUyorlHLjvXoTw");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Vu+ra53wj02Z6lGVEXlsDg");
internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nWLNw66w7kKA79ybN3+2ZQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(6,true);
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

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCreatedBy = value;
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

private bool _ssIsError;
public bool ssIsError{
  get{
      return _ssIsError;
  }
  set{
      if((_ssIsError!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIsError = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_fca813b8ca96d6759e00225744caa7d4EntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0L;
_ssRequisitionId = 0L;
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssMessage = "";
_ssIsError = false;
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
ssId = r.ReadLongInteger(index++, "RequisitionLogs.Id", 0L);
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionLogs.RequisitionId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "RequisitionLogs.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "RequisitionLogs.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMessage = r.ReadText(index++, "RequisitionLogs.Message", "");
ssIsError = r.ReadBoolean(index++, "RequisitionLogs.IsError", false);
ChangedAttributes = new BitArray(6,false);
OptimizedAttributes = new BitArray(6,false);
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
public void ReadIM(EN_fca813b8ca96d6759e00225744caa7d4EntityRecord r) {
this = r;
}


public static bool operator == (EN_fca813b8ca96d6759e00225744caa7d4EntityRecord a, EN_fca813b8ca96d6759e00225744caa7d4EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssIsError != b.ssIsError) return false;
return true;
}

public static bool operator != (EN_fca813b8ca96d6759e00225744caa7d4EntityRecord a, EN_fca813b8ca96d6759e00225744caa7d4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_fca813b8ca96d6759e00225744caa7d4EntityRecord)) return false;
return (this == (EN_fca813b8ca96d6759e00225744caa7d4EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssIsError.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_fca813b8ca96d6759e00225744caa7d4EntityRecord Duplicate() {
EN_fca813b8ca96d6759e00225744caa7d4EntityRecord t;
t._ssId = this._ssId;
t._ssRequisitionId = this._ssRequisitionId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssMessage = this._ssMessage;
t._ssIsError = this._ssIsError;
t.ChangedAttributes = new BitArray(6);
t.OptimizedAttributes = new BitArray(6);
for(int i = 0; i < 6; i++){
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
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "iserror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsError")) variable.Value = ssIsError; else variable.Optimized = true;
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
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsError)) {
return ChangedAttributes[5];
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
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsError)) {
return OptimizedAttributes[5];
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
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdIsError) {
return ssIsError;
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
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdIsError.Key.AsGuid) {
return ssIsError;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRequisitionId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedOn);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[4] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdMessage);
ssIsError = (bool) other.AttributeGet(IdIsError);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsError);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsError);
}
} // EN_fca813b8ca96d6759e00225744caa7d4EntityRecord

/// <summary>
/// RecordList type <code>RequisitionLogsList</code> that represents a record list of
///  <code>RequisitionLogs</code>
/// </summary>
public partial class RL_fdafd442807cd919d566b3ebfe8b6822 : GenericRecordList<EN_fca813b8ca96d6759e00225744caa7d4EntityRecord>, IEnumerable, IEnumerator {

protected override EN_fca813b8ca96d6759e00225744caa7d4EntityRecord GetElementDefaultValue() {
return new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord();
}

public T[] ToArray<T>(Func<EN_fca813b8ca96d6759e00225744caa7d4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fdafd442807cd919d566b3ebfe8b6822 recordList, Func<EN_fca813b8ca96d6759e00225744caa7d4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fdafd442807cd919d566b3ebfe8b6822(EN_fca813b8ca96d6759e00225744caa7d4EntityRecord[] array) {
  RL_fdafd442807cd919d566b3ebfe8b6822 result = new RL_fdafd442807cd919d566b3ebfe8b6822();
result.InnerFromArray(array);
    return result;
}

public static RL_fdafd442807cd919d566b3ebfe8b6822 ToList<T>(T[] array, Func <T, EN_fca813b8ca96d6759e00225744caa7d4EntityRecord> converter) {
  RL_fdafd442807cd919d566b3ebfe8b6822 result = new RL_fdafd442807cd919d566b3ebfe8b6822();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fdafd442807cd919d566b3ebfe8b6822 FromRestList<T>(RestList<T> restList, Func <T, EN_fca813b8ca96d6759e00225744caa7d4EntityRecord> converter) {
  RL_fdafd442807cd919d566b3ebfe8b6822 result = new RL_fdafd442807cd919d566b3ebfe8b6822();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fdafd442807cd919d566b3ebfe8b6822() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_fca813b8ca96d6759e00225744caa7d4EntityRecord> NewList() {
return new RL_fdafd442807cd919d566b3ebfe8b6822();
}


} // RL_fdafd442807cd919d566b3ebfe8b6822
}
