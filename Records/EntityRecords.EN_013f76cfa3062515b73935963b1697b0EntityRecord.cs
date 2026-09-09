using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ProposalLogs (b6o7GqrlB02vl+1YOjY9bQ)
///  <code>EN_013f76cfa3062515b73935963b1697b0EntityRecord</code> that represent
/// s <code>ProposalLogs</code> <p>Description: Entity that holds Proposals Logs.</p>
/// </summary>
// Name: ProposalLogs
public partial struct EN_013f76cfa3062515b73935963b1697b0EntityRecord : ITypedRecord<EN_013f76cfa3062515b73935963b1697b0EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Uhc7oAeCVU2GvrRT9f8OLA");
internal static readonly GlobalObjectKey IdProposalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*a4zWWS5r4k+UElsYCKc3AQ");
internal static readonly GlobalObjectKey IdProposalLineId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PP4DkdK+YUSJ7ntBe0iMBA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FZp1rHMiqk6xLV5oWdFdOw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Qvaegeqj8kmIEuTebW2xMw");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QmJkRC2gWUqqLH068f53tw");
internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EImB+sutrUKdocGkLhXJ5Q");

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

private long _ssProposalId;
public long ssProposalId{
  get{
      return _ssProposalId;
  }
  set{
      if((_ssProposalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
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
      if((_ssProposalLineId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProposalLineId = value;
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

private string _ssMessage;
public string ssMessage{
  get{
      return _ssMessage;
  }
  set{
      if((_ssMessage!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssIsError!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIsError = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_013f76cfa3062515b73935963b1697b0EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssProposalId = 0L;
_ssProposalLineId = 0L;
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
ssId = r.ReadLongInteger(index++, "ProposalLogs.Id", 0L);
ssProposalId = r.ReadEntityReferenceLongInteger(index++, "ProposalLogs.ProposalId", 0L);
ssProposalLineId = r.ReadEntityReferenceLongInteger(index++, "ProposalLogs.ProposalLineId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "ProposalLogs.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "ProposalLogs.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMessage = r.ReadText(index++, "ProposalLogs.Message", "");
ssIsError = r.ReadBoolean(index++, "ProposalLogs.IsError", false);
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
public void ReadIM(EN_013f76cfa3062515b73935963b1697b0EntityRecord r) {
this = r;
}


public static bool operator == (EN_013f76cfa3062515b73935963b1697b0EntityRecord a, EN_013f76cfa3062515b73935963b1697b0EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProposalId != b.ssProposalId) return false;
if (a.ssProposalLineId != b.ssProposalLineId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssIsError != b.ssIsError) return false;
return true;
}

public static bool operator != (EN_013f76cfa3062515b73935963b1697b0EntityRecord a, EN_013f76cfa3062515b73935963b1697b0EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_013f76cfa3062515b73935963b1697b0EntityRecord)) return false;
return (this == (EN_013f76cfa3062515b73935963b1697b0EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProposalId.GetHashCode()
 ^ ssProposalLineId.GetHashCode()
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


public EN_013f76cfa3062515b73935963b1697b0EntityRecord Duplicate() {
EN_013f76cfa3062515b73935963b1697b0EntityRecord t;
t._ssId = this._ssId;
t._ssProposalId = this._ssProposalId;
t._ssProposalLineId = this._ssProposalLineId;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssMessage = this._ssMessage;
t._ssIsError = this._ssIsError;
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
} else if (head == "proposalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalId")) variable.Value = ssProposalId; else variable.Optimized = true;
} else if (head == "proposallineid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLineId")) variable.Value = ssProposalLineId; else variable.Optimized = true;
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
if (key.Equals(IdProposalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdProposalLineId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[4];
}
if (key.Equals(IdMessage)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIsError)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProposalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdProposalLineId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIsError)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProposalId) {
return ssProposalId;
}
if (key == IdProposalLineId) {
return ssProposalLineId;
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
if (attributeKey == IdProposalId.Key.AsGuid) {
return ssProposalId;
}
if (attributeKey == IdProposalLineId.Key.AsGuid) {
return ssProposalLineId;
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
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProposalId = (long) other.AttributeGet(IdProposalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProposalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProposalId);
ssProposalLineId = (long) other.AttributeGet(IdProposalLineId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProposalLineId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProposalLineId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedOn);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[5] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdMessage);
ssIsError = (bool) other.AttributeGet(IdIsError);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsError);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsError);
}
} // EN_013f76cfa3062515b73935963b1697b0EntityRecord

/// <summary>
/// RecordList type <code>ProposalLogsList</code> that represents a record list of
///  <code>ProposalLogs</code>
/// </summary>
public partial class RL_e7be68a2c10d5e675551ff10858d9384 : GenericRecordList<EN_013f76cfa3062515b73935963b1697b0EntityRecord>, IEnumerable, IEnumerator {

protected override EN_013f76cfa3062515b73935963b1697b0EntityRecord GetElementDefaultValue() {
return new EN_013f76cfa3062515b73935963b1697b0EntityRecord();
}

public T[] ToArray<T>(Func<EN_013f76cfa3062515b73935963b1697b0EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e7be68a2c10d5e675551ff10858d9384 recordList, Func<EN_013f76cfa3062515b73935963b1697b0EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e7be68a2c10d5e675551ff10858d9384(EN_013f76cfa3062515b73935963b1697b0EntityRecord[] array) {
  RL_e7be68a2c10d5e675551ff10858d9384 result = new RL_e7be68a2c10d5e675551ff10858d9384();
result.InnerFromArray(array);
    return result;
}

public static RL_e7be68a2c10d5e675551ff10858d9384 ToList<T>(T[] array, Func <T, EN_013f76cfa3062515b73935963b1697b0EntityRecord> converter) {
  RL_e7be68a2c10d5e675551ff10858d9384 result = new RL_e7be68a2c10d5e675551ff10858d9384();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e7be68a2c10d5e675551ff10858d9384 FromRestList<T>(RestList<T> restList, Func <T, EN_013f76cfa3062515b73935963b1697b0EntityRecord> converter) {
  RL_e7be68a2c10d5e675551ff10858d9384 result = new RL_e7be68a2c10d5e675551ff10858d9384();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e7be68a2c10d5e675551ff10858d9384() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_013f76cfa3062515b73935963b1697b0EntityRecord> NewList() {
return new RL_e7be68a2c10d5e675551ff10858d9384();
}


} // RL_e7be68a2c10d5e675551ff10858d9384
}
