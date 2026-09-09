using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderLogs (J3sqj3h3VEq5YOAYy352LA)
///  <code>EN_a8e484428097204171df8a1feecb2534EntityRecord</code> that represents <code>OrderLogs</code
/// > <p>Description: Order Logs</p>
/// </summary>
// Name: OrderLogs
public partial struct EN_a8e484428097204171df8a1feecb2534EntityRecord : ITypedRecord<EN_a8e484428097204171df8a1feecb2534EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*luj8tkdBuUGCHWvvYRX+kQ");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*z98uYhxrK0er_xCYcpxxnA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WSHlclCTI06EZHPLMIExpQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yY0kw+CFKUG7Fg1DVUVzKA");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ggdgidBNikmdctj4kOuzOw");
internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Hg_Ns8ls_Eal9vwARZfFag");

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

private long _ssOrderId;
public long ssOrderId{
  get{
      return _ssOrderId;
  }
  set{
      if((_ssOrderId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderId = value;
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

public EN_a8e484428097204171df8a1feecb2534EntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0L;
_ssOrderId = 0L;
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
ssId = r.ReadLongInteger(index++, "OrderLogs.Id", 0L);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderLogs.OrderId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "OrderLogs.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "OrderLogs.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMessage = r.ReadText(index++, "OrderLogs.Message", "");
ssIsError = r.ReadBoolean(index++, "OrderLogs.IsError", false);
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
public void ReadIM(EN_a8e484428097204171df8a1feecb2534EntityRecord r) {
this = r;
}


public static bool operator == (EN_a8e484428097204171df8a1feecb2534EntityRecord a, EN_a8e484428097204171df8a1feecb2534EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssIsError != b.ssIsError) return false;
return true;
}

public static bool operator != (EN_a8e484428097204171df8a1feecb2534EntityRecord a, EN_a8e484428097204171df8a1feecb2534EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_a8e484428097204171df8a1feecb2534EntityRecord)) return false;
return (this == (EN_a8e484428097204171df8a1feecb2534EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderId.GetHashCode()
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


public EN_a8e484428097204171df8a1feecb2534EntityRecord Duplicate() {
EN_a8e484428097204171df8a1feecb2534EntityRecord t;
t._ssId = this._ssId;
t._ssOrderId = this._ssOrderId;
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
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
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
if (key.Equals(IdOrderId)) {
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
if (key.Equals(IdOrderId)) {
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
if (key == IdOrderId) {
return ssOrderId;
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
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
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
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderId);
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
} // EN_a8e484428097204171df8a1feecb2534EntityRecord

/// <summary>
/// RecordList type <code>OrderLogsList</code> that represents a record list of <code>OrderLogs</code>
/// </summary>
public partial class RL_7dd04f368476f385a8c61ce0d388ed86 : GenericRecordList<EN_a8e484428097204171df8a1feecb2534EntityRecord>, IEnumerable, IEnumerator {

protected override EN_a8e484428097204171df8a1feecb2534EntityRecord GetElementDefaultValue() {
return new EN_a8e484428097204171df8a1feecb2534EntityRecord();
}

public T[] ToArray<T>(Func<EN_a8e484428097204171df8a1feecb2534EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7dd04f368476f385a8c61ce0d388ed86 recordList, Func<EN_a8e484428097204171df8a1feecb2534EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7dd04f368476f385a8c61ce0d388ed86(EN_a8e484428097204171df8a1feecb2534EntityRecord[] array) {
  RL_7dd04f368476f385a8c61ce0d388ed86 result = new RL_7dd04f368476f385a8c61ce0d388ed86();
result.InnerFromArray(array);
    return result;
}

public static RL_7dd04f368476f385a8c61ce0d388ed86 ToList<T>(T[] array, Func <T, EN_a8e484428097204171df8a1feecb2534EntityRecord> converter) {
  RL_7dd04f368476f385a8c61ce0d388ed86 result = new RL_7dd04f368476f385a8c61ce0d388ed86();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7dd04f368476f385a8c61ce0d388ed86 FromRestList<T>(RestList<T> restList, Func <T, EN_a8e484428097204171df8a1feecb2534EntityRecord> converter) {
  RL_7dd04f368476f385a8c61ce0d388ed86 result = new RL_7dd04f368476f385a8c61ce0d388ed86();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7dd04f368476f385a8c61ce0d388ed86() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_a8e484428097204171df8a1feecb2534EntityRecord> NewList() {
return new RL_7dd04f368476f385a8c61ce0d388ed86();
}


} // RL_7dd04f368476f385a8c61ce0d388ed86
}
