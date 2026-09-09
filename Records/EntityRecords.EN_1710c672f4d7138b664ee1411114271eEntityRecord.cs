using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderRequestFileApproval (75ulHTDiS0aHzBQVaeWDVQ)
///  <code>EN_1710c672f4d7138b664ee1411114271eEntityRecord</code> that represent
/// s <code>OrderRequestFileApproval</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileApproval
public partial struct EN_1710c672f4d7138b664ee1411114271eEntityRecord : ITypedRecord<EN_1710c672f4d7138b664ee1411114271eEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UGaSCsAgREC408+as7Oj8A");
internal static readonly GlobalObjectKey IdOrderRequestFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*r52LM8OxK0y2k66Sd+su9g");
internal static readonly GlobalObjectKey IdCurrentLevel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fo0ZoKqw2062nYwTbrpp0g");
internal static readonly GlobalObjectKey IdMaxLevel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*n44uqQa12EOlFLSP4v+DnA");
internal static readonly GlobalObjectKey IdStartedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LwG8fOhhNkS+Ej1ja8VTnw");
internal static readonly GlobalObjectKey IdFinishedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YxagzLg7I0iIcf11T4BgIA");

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

private int _ssCurrentLevel;
public int ssCurrentLevel{
  get{
      return _ssCurrentLevel;
  }
  set{
      if((_ssCurrentLevel!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssCurrentLevel = value;
      }
  }
}

private int _ssMaxLevel;
public int ssMaxLevel{
  get{
      return _ssMaxLevel;
  }
  set{
      if((_ssMaxLevel!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssMaxLevel = value;
      }
  }
}

private DateTime _ssStartedOn;
public DateTime ssStartedOn{
  get{
      return _ssStartedOn;
  }
  set{
      if((_ssStartedOn!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssFinishedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssFinishedOn = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1710c672f4d7138b664ee1411114271eEntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0L;
_ssOrderRequestFileId = 0L;
_ssCurrentLevel = 0;
_ssMaxLevel = 0;
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
ssId = r.ReadLongInteger(index++, "OrderRequestFileApproval.Id", 0L);
ssOrderRequestFileId = r.ReadEntityReferenceLongInteger(index++, "OrderRequestFileApproval.OrderRequestFileId", 0L);
ssCurrentLevel = r.ReadInteger(index++, "OrderRequestFileApproval.CurrentLevel", 0);
ssMaxLevel = r.ReadInteger(index++, "OrderRequestFileApproval.MaxLevel", 0);
ssStartedOn = r.ReadDateTime(index++, "OrderRequestFileApproval.StartedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFinishedOn = r.ReadDateTime(index++, "OrderRequestFileApproval.FinishedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(EN_1710c672f4d7138b664ee1411114271eEntityRecord r) {
this = r;
}


public static bool operator == (EN_1710c672f4d7138b664ee1411114271eEntityRecord a, EN_1710c672f4d7138b664ee1411114271eEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderRequestFileId != b.ssOrderRequestFileId) return false;
if (a.ssCurrentLevel != b.ssCurrentLevel) return false;
if (a.ssMaxLevel != b.ssMaxLevel) return false;
if (a.ssStartedOn != b.ssStartedOn) return false;
if (a.ssFinishedOn != b.ssFinishedOn) return false;
return true;
}

public static bool operator != (EN_1710c672f4d7138b664ee1411114271eEntityRecord a, EN_1710c672f4d7138b664ee1411114271eEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1710c672f4d7138b664ee1411114271eEntityRecord)) return false;
return (this == (EN_1710c672f4d7138b664ee1411114271eEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderRequestFileId.GetHashCode()
 ^ ssCurrentLevel.GetHashCode()
 ^ ssMaxLevel.GetHashCode()
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


public EN_1710c672f4d7138b664ee1411114271eEntityRecord Duplicate() {
EN_1710c672f4d7138b664ee1411114271eEntityRecord t;
t._ssId = this._ssId;
t._ssOrderRequestFileId = this._ssOrderRequestFileId;
t._ssCurrentLevel = this._ssCurrentLevel;
t._ssMaxLevel = this._ssMaxLevel;
t._ssStartedOn = this._ssStartedOn;
t._ssFinishedOn = this._ssFinishedOn;
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
} else if (head == "orderrequestfileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileId")) variable.Value = ssOrderRequestFileId; else variable.Optimized = true;
} else if (head == "currentlevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrentLevel")) variable.Value = ssCurrentLevel; else variable.Optimized = true;
} else if (head == "maxlevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxLevel")) variable.Value = ssMaxLevel; else variable.Optimized = true;
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
if (key.Equals(IdOrderRequestFileId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdCurrentLevel)) {
return ChangedAttributes[2];
}
if (key.Equals(IdMaxLevel)) {
return ChangedAttributes[3];
}
if (key.Equals(IdStartedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdFinishedOn)) {
return ChangedAttributes[5];
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
if (key.Equals(IdCurrentLevel)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdMaxLevel)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdStartedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdFinishedOn)) {
return OptimizedAttributes[5];
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
if (key == IdCurrentLevel) {
return ssCurrentLevel;
}
if (key == IdMaxLevel) {
return ssMaxLevel;
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
if (attributeKey == IdOrderRequestFileId.Key.AsGuid) {
return ssOrderRequestFileId;
}
if (attributeKey == IdCurrentLevel.Key.AsGuid) {
return ssCurrentLevel;
}
if (attributeKey == IdMaxLevel.Key.AsGuid) {
return ssMaxLevel;
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
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderRequestFileId = (long) other.AttributeGet(IdOrderRequestFileId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderRequestFileId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderRequestFileId);
ssCurrentLevel = (int) other.AttributeGet(IdCurrentLevel);
ChangedAttributes[2] = other.ChangedAttributeGet(IdCurrentLevel);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCurrentLevel);
ssMaxLevel = (int) other.AttributeGet(IdMaxLevel);
ChangedAttributes[3] = other.ChangedAttributeGet(IdMaxLevel);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdMaxLevel);
ssStartedOn = (DateTime) other.AttributeGet(IdStartedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdStartedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdStartedOn);
ssFinishedOn = (DateTime) other.AttributeGet(IdFinishedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdFinishedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdFinishedOn);
}
} // EN_1710c672f4d7138b664ee1411114271eEntityRecord

/// <summary>
/// RecordList type <code>OrderRequestFileApprovalList</code> that represents a record list of
///  <code>OrderRequestFileApproval</code>
/// </summary>
public partial class RL_d20cb7bc37f620a718401900f62f9cce : GenericRecordList<EN_1710c672f4d7138b664ee1411114271eEntityRecord>, IEnumerable, IEnumerator {

protected override EN_1710c672f4d7138b664ee1411114271eEntityRecord GetElementDefaultValue() {
return new EN_1710c672f4d7138b664ee1411114271eEntityRecord();
}

public T[] ToArray<T>(Func<EN_1710c672f4d7138b664ee1411114271eEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d20cb7bc37f620a718401900f62f9cce recordList, Func<EN_1710c672f4d7138b664ee1411114271eEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d20cb7bc37f620a718401900f62f9cce(EN_1710c672f4d7138b664ee1411114271eEntityRecord[] array) {
  RL_d20cb7bc37f620a718401900f62f9cce result = new RL_d20cb7bc37f620a718401900f62f9cce();
result.InnerFromArray(array);
    return result;
}

public static RL_d20cb7bc37f620a718401900f62f9cce ToList<T>(T[] array, Func <T, EN_1710c672f4d7138b664ee1411114271eEntityRecord> converter) {
  RL_d20cb7bc37f620a718401900f62f9cce result = new RL_d20cb7bc37f620a718401900f62f9cce();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d20cb7bc37f620a718401900f62f9cce FromRestList<T>(RestList<T> restList, Func <T, EN_1710c672f4d7138b664ee1411114271eEntityRecord> converter) {
  RL_d20cb7bc37f620a718401900f62f9cce result = new RL_d20cb7bc37f620a718401900f62f9cce();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d20cb7bc37f620a718401900f62f9cce() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1710c672f4d7138b664ee1411114271eEntityRecord> NewList() {
return new RL_d20cb7bc37f620a718401900f62f9cce();
}


} // RL_d20cb7bc37f620a718401900f62f9cce
}
