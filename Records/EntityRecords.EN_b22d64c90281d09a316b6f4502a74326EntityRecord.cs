using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ActionTimestamps (Z2bAz6ndIkWE8fFrFQtZ2g)
///  <code>EN_b22d64c90281d09a316b6f4502a74326EntityRecord</code> that represent
/// s <code>ActionTimestamps</code> <p>Description: </p>
/// </summary>
// Name: ActionTimestamps
public partial struct EN_b22d64c90281d09a316b6f4502a74326EntityRecord : ITypedRecord<EN_b22d64c90281d09a316b6f4502a74326EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vL+Fi3T060mey8XR57SyTw");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DywHZ6awbEaPz9m4mNzcFQ");
internal static readonly GlobalObjectKey IdStartedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Zc7toE4YDE+avRD8cAzmmQ");
internal static readonly GlobalObjectKey IdFinishedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*btHUStD5N0aVoF7Mqc0Y2A");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssId = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssDescription = value;
      }
  }
}

private DateTime _ssStartedOn;
public DateTime ssStartedOn{
  get{
      return _ssStartedOn;
  }
  set{
      if((_ssStartedOn!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssStartedOn = value;
      }
  }
}

private DateTime _ssFinishedOn;
public DateTime ssFinishedOn{
  get{
      return _ssFinishedOn;
  }
  set{
      if((_ssFinishedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssFinishedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b22d64c90281d09a316b6f4502a74326EntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssDescription = "";
_ssStartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssFinishedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssId = r.ReadLongInteger(index++, "ActionTimestamps.Id", 0L);
ssDescription = r.ReadText(index++, "ActionTimestamps.Description", "");
ssStartedOn = r.ReadDateTime(index++, "ActionTimestamps.StartedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFinishedOn = r.ReadDateTime(index++, "ActionTimestamps.FinishedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(EN_b22d64c90281d09a316b6f4502a74326EntityRecord r) {
this = r;
}


public static bool operator == (EN_b22d64c90281d09a316b6f4502a74326EntityRecord a, EN_b22d64c90281d09a316b6f4502a74326EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssStartedOn != b.ssStartedOn) return false;
if (a.ssFinishedOn != b.ssFinishedOn) return false;
return true;
}

public static bool operator != (EN_b22d64c90281d09a316b6f4502a74326EntityRecord a, EN_b22d64c90281d09a316b6f4502a74326EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b22d64c90281d09a316b6f4502a74326EntityRecord)) return false;
return (this == (EN_b22d64c90281d09a316b6f4502a74326EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssStartedOn.GetHashCode()
 ^ ssFinishedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b22d64c90281d09a316b6f4502a74326EntityRecord Duplicate() {
EN_b22d64c90281d09a316b6f4502a74326EntityRecord t;
t._ssId = this._ssId;
t._ssDescription = this._ssDescription;
t._ssStartedOn = this._ssStartedOn;
t._ssFinishedOn = this._ssFinishedOn;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
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
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "startedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartedOn")) variable.Value = ssStartedOn; else variable.Optimized = true;
} else if (head == "finishedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishedOn")) variable.Value = ssFinishedOn; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[1];
}
if (key.Equals(IdStartedOn)) {
return ChangedAttributes[2];
}
if (key.Equals(IdFinishedOn)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdStartedOn)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdFinishedOn)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdStartedOn) {
return ssStartedOn;
}
if (key == IdFinishedOn) {
return ssFinishedOn;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdStartedOn.Key.AsGuid) {
return ssStartedOn;
}
if (attributeKey == IdFinishedOn.Key.AsGuid) {
return ssFinishedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[1] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDescription);
ssStartedOn = (DateTime) other.AttributeGet(IdStartedOn);
ChangedAttributes[2] = other.ChangedAttributeGet(IdStartedOn);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdStartedOn);
ssFinishedOn = (DateTime) other.AttributeGet(IdFinishedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdFinishedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdFinishedOn);
}
} // EN_b22d64c90281d09a316b6f4502a74326EntityRecord

/// <summary>
/// RecordList type <code>ActionTimestampsList</code> that represents a record list of
///  <code>ActionTimestamps</code>
/// </summary>
public partial class RL_370677b009c72dd7f0f96c221ec03081 : GenericRecordList<EN_b22d64c90281d09a316b6f4502a74326EntityRecord>, IEnumerable, IEnumerator {

protected override EN_b22d64c90281d09a316b6f4502a74326EntityRecord GetElementDefaultValue() {
return new EN_b22d64c90281d09a316b6f4502a74326EntityRecord();
}

public T[] ToArray<T>(Func<EN_b22d64c90281d09a316b6f4502a74326EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_370677b009c72dd7f0f96c221ec03081 recordList, Func<EN_b22d64c90281d09a316b6f4502a74326EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_370677b009c72dd7f0f96c221ec03081(EN_b22d64c90281d09a316b6f4502a74326EntityRecord[] array) {
  RL_370677b009c72dd7f0f96c221ec03081 result = new RL_370677b009c72dd7f0f96c221ec03081();
result.InnerFromArray(array);
    return result;
}

public static RL_370677b009c72dd7f0f96c221ec03081 ToList<T>(T[] array, Func <T, EN_b22d64c90281d09a316b6f4502a74326EntityRecord> converter) {
  RL_370677b009c72dd7f0f96c221ec03081 result = new RL_370677b009c72dd7f0f96c221ec03081();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_370677b009c72dd7f0f96c221ec03081 FromRestList<T>(RestList<T> restList, Func <T, EN_b22d64c90281d09a316b6f4502a74326EntityRecord> converter) {
  RL_370677b009c72dd7f0f96c221ec03081 result = new RL_370677b009c72dd7f0f96c221ec03081();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_370677b009c72dd7f0f96c221ec03081() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b22d64c90281d09a316b6f4502a74326EntityRecord> NewList() {
return new RL_370677b009c72dd7f0f96c221ec03081();
}


} // RL_370677b009c72dd7f0f96c221ec03081
}
