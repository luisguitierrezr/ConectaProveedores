using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceLog (23cOZlrW+EGoahsCT+30ag)
///  <code>EN_bf34270fdd0f7785895f41a998e724e8EntityRecord</code> that represent
/// s <code>InvoiceLog</code> <p>Description: Entity that holds Invoice Logs</p>
/// </summary>
// Name: InvoiceLog
public partial struct EN_bf34270fdd0f7785895f41a998e724e8EntityRecord : ITypedRecord<EN_bf34270fdd0f7785895f41a998e724e8EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mAEzI0MtYUGHr3zpKMbnkw");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZSJWQKrq6kK1+MC06lxpLg");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UpAkNIhqYEy2WvrMJVsQCQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tnRvnlK3gUODoi1erk956A");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*evP0SoelTEa8__GxImD57A");
internal static readonly GlobalObjectKey IdIsError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OIhVjEPMWUKs6N_izbtn6Q");

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

private string _ssMessage;
public string ssMessage{
  get{
      return _ssMessage;
  }
  set{
      if((_ssMessage!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssMessage = value;
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

public EN_bf34270fdd0f7785895f41a998e724e8EntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssMessage = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
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
ssId = r.ReadLongInteger(index++, "InvoiceLog.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceLog.InvoiceId", 0L);
ssMessage = r.ReadText(index++, "InvoiceLog.Message", "");
ssCreatedOn = r.ReadDateTime(index++, "InvoiceLog.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceLog.CreatedBy", "");
ssIsError = r.ReadBoolean(index++, "InvoiceLog.IsError", false);
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
public void ReadIM(EN_bf34270fdd0f7785895f41a998e724e8EntityRecord r) {
this = r;
}


public static bool operator == (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord a, EN_bf34270fdd0f7785895f41a998e724e8EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssMessage != b.ssMessage) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssIsError != b.ssIsError) return false;
return true;
}

public static bool operator != (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord a, EN_bf34270fdd0f7785895f41a998e724e8EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord)) return false;
return (this == (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssMessage.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
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


public EN_bf34270fdd0f7785895f41a998e724e8EntityRecord Duplicate() {
EN_bf34270fdd0f7785895f41a998e724e8EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssMessage = this._ssMessage;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "iserror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsError")) variable.Value = ssIsError; else variable.Optimized = true;
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
if (key.Equals(IdMessage)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
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
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdMessage)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
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
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdMessage) {
return ssMessage;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
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
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
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
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssMessage = (string) other.AttributeGet(IdMessage);
ChangedAttributes[2] = other.ChangedAttributeGet(IdMessage);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdMessage);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
ssIsError = (bool) other.AttributeGet(IdIsError);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsError);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsError);
}
} // EN_bf34270fdd0f7785895f41a998e724e8EntityRecord

/// <summary>
/// RecordList type <code>InvoiceLogList</code> that represents a record list of
///  <code>InvoiceLog</code>
/// </summary>
public partial class RL_3c85b6eb7948435e547c7243037d9ca0 : GenericRecordList<EN_bf34270fdd0f7785895f41a998e724e8EntityRecord>, IEnumerable, IEnumerator {

protected override EN_bf34270fdd0f7785895f41a998e724e8EntityRecord GetElementDefaultValue() {
return new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord();
}

public T[] ToArray<T>(Func<EN_bf34270fdd0f7785895f41a998e724e8EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3c85b6eb7948435e547c7243037d9ca0 recordList, Func<EN_bf34270fdd0f7785895f41a998e724e8EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3c85b6eb7948435e547c7243037d9ca0(EN_bf34270fdd0f7785895f41a998e724e8EntityRecord[] array) {
  RL_3c85b6eb7948435e547c7243037d9ca0 result = new RL_3c85b6eb7948435e547c7243037d9ca0();
result.InnerFromArray(array);
    return result;
}

public static RL_3c85b6eb7948435e547c7243037d9ca0 ToList<T>(T[] array, Func <T, EN_bf34270fdd0f7785895f41a998e724e8EntityRecord> converter) {
  RL_3c85b6eb7948435e547c7243037d9ca0 result = new RL_3c85b6eb7948435e547c7243037d9ca0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3c85b6eb7948435e547c7243037d9ca0 FromRestList<T>(RestList<T> restList, Func <T, EN_bf34270fdd0f7785895f41a998e724e8EntityRecord> converter) {
  RL_3c85b6eb7948435e547c7243037d9ca0 result = new RL_3c85b6eb7948435e547c7243037d9ca0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3c85b6eb7948435e547c7243037d9ca0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_bf34270fdd0f7785895f41a998e724e8EntityRecord> NewList() {
return new RL_3c85b6eb7948435e547c7243037d9ca0();
}


} // RL_3c85b6eb7948435e547c7243037d9ca0
}
