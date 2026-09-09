using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceStatusHistory (F3SLd935j0S3FJUfOavdYQ)
///  <code>EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord</code> that represent
/// s <code>InvoiceStatusHistory</code> <p>Description: Entity that holds Invoice Statuses History</p>
/// </summary>
// Name: InvoiceStatusHistory
public partial struct EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord : ITypedRecord<EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2kOURu1WkE6nkRep3Fn21w");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UmgGOji78UWCQ4CEPPXdRQ");
internal static readonly GlobalObjectKey IdInvoiceStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_cYtlaa7Z0WCCGnQkL_0Pg");
internal static readonly GlobalObjectKey IdTimeStamp = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Qe+WS8rSvE6aTQb+5EDTkw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vGsemMzXk06G_x_vpSzqcw");

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

private int _ssInvoiceStatusId;
public int ssInvoiceStatusId{
  get{
      return _ssInvoiceStatusId;
  }
  set{
      if((_ssInvoiceStatusId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssInvoiceStatusId = value;
      }
  }
}

private DateTime _ssTimeStamp;
public DateTime ssTimeStamp{
  get{
      return _ssTimeStamp;
  }
  set{
      if((_ssTimeStamp!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssTimeStamp = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCreatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssInvoiceStatusId = 0;
_ssTimeStamp = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
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
ssId = r.ReadLongInteger(index++, "InvoiceStatusHistory.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceStatusHistory.InvoiceId", 0L);
ssInvoiceStatusId = r.ReadEntityReference(index++, "InvoiceStatusHistory.InvoiceStatusId", 0);
ssTimeStamp = r.ReadDateTime(index++, "InvoiceStatusHistory.TimeStamp", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceStatusHistory.CreatedBy", "");
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
public void ReadIM(EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord r) {
this = r;
}


public static bool operator == (EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord a, EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceStatusId != b.ssInvoiceStatusId) return false;
if (a.ssTimeStamp != b.ssTimeStamp) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
return true;
}

public static bool operator != (EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord a, EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord)) return false;
return (this == (EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceStatusId.GetHashCode()
 ^ ssTimeStamp.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord Duplicate() {
EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssInvoiceStatusId = this._ssInvoiceStatusId;
t._ssTimeStamp = this._ssTimeStamp;
t._ssCreatedBy = this._ssCreatedBy;
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "invoicestatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatusId")) variable.Value = ssInvoiceStatusId; else variable.Optimized = true;
} else if (head == "timestamp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TimeStamp")) variable.Value = ssTimeStamp; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
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
if (key.Equals(IdInvoiceStatusId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdTimeStamp)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
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
if (key.Equals(IdInvoiceStatusId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdTimeStamp)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
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
if (key == IdInvoiceStatusId) {
return ssInvoiceStatusId;
}
if (key == IdTimeStamp) {
return ssTimeStamp;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
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
if (attributeKey == IdInvoiceStatusId.Key.AsGuid) {
return ssInvoiceStatusId;
}
if (attributeKey == IdTimeStamp.Key.AsGuid) {
return ssTimeStamp;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
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
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssInvoiceStatusId = (int) other.AttributeGet(IdInvoiceStatusId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdInvoiceStatusId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInvoiceStatusId);
ssTimeStamp = (DateTime) other.AttributeGet(IdTimeStamp);
ChangedAttributes[3] = other.ChangedAttributeGet(IdTimeStamp);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdTimeStamp);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
}
} // EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord

/// <summary>
/// RecordList type <code>InvoiceStatusHistoryList</code> that represents a record list of
///  <code>InvoiceStatusHistory</code>
/// </summary>
public partial class RL_13d384c876a69e349b633742e004c969 : GenericRecordList<EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord>, IEnumerable, IEnumerator {

protected override EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord GetElementDefaultValue() {
return new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord();
}

public T[] ToArray<T>(Func<EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_13d384c876a69e349b633742e004c969 recordList, Func<EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_13d384c876a69e349b633742e004c969(EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord[] array) {
  RL_13d384c876a69e349b633742e004c969 result = new RL_13d384c876a69e349b633742e004c969();
result.InnerFromArray(array);
    return result;
}

public static RL_13d384c876a69e349b633742e004c969 ToList<T>(T[] array, Func <T, EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord> converter) {
  RL_13d384c876a69e349b633742e004c969 result = new RL_13d384c876a69e349b633742e004c969();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_13d384c876a69e349b633742e004c969 FromRestList<T>(RestList<T> restList, Func <T, EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord> converter) {
  RL_13d384c876a69e349b633742e004c969 result = new RL_13d384c876a69e349b633742e004c969();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_13d384c876a69e349b633742e004c969() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord> NewList() {
return new RL_13d384c876a69e349b633742e004c969();
}


} // RL_13d384c876a69e349b633742e004c969
}
