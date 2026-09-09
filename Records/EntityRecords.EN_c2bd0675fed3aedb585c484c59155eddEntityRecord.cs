using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceApproval (BJ5SG03a6kKKo2aDZ0cY_A)
///  <code>EN_c2bd0675fed3aedb585c484c59155eddEntityRecord</code> that represent
/// s <code>InvoiceApproval</code> <p>Description: </p>
/// </summary>
// Name: InvoiceApproval
public partial struct EN_c2bd0675fed3aedb585c484c59155eddEntityRecord : ITypedRecord<EN_c2bd0675fed3aedb585c484c59155eddEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ujyZGUCDBUaBxaoF2lE7vQ");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*p5aqNWB9Xk6wCC3P0Qg_rw");
internal static readonly GlobalObjectKey IdAprovalProcessId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*q8jzyvJ3OkShHUenLS9BVw");
internal static readonly GlobalObjectKey IdProcessTypeCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*j+AfJ0cCCE+idIHJAsCr_Q");
internal static readonly GlobalObjectKey IdApprovalProcessVersion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l7BJTchdYUaYO_tNeOdPFQ");
internal static readonly GlobalObjectKey IdCurrentLevel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*b1a99hU_bU6CKkYlKZXr1w");
internal static readonly GlobalObjectKey IdMaxLevel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AvvmFbFK2E6DBaohV6aUJQ");
internal static readonly GlobalObjectKey IdStartedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dO53sXMNmEO8_E_YlesYqQ");
internal static readonly GlobalObjectKey IdFinishedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vsG4y7zeCkCai6xpwZQefA");
internal static readonly GlobalObjectKey IdHasStartedAccounting = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oY+Y4VNHcki4XYjBUWMRZw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(10,true);
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

private long _ssAprovalProcessId;
public long ssAprovalProcessId{
  get{
      return _ssAprovalProcessId;
  }
  set{
      if((_ssAprovalProcessId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssAprovalProcessId = value;
      }
  }
}

private string _ssProcessTypeCode;
public string ssProcessTypeCode{
  get{
      return _ssProcessTypeCode;
  }
  set{
      if((_ssProcessTypeCode!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssProcessTypeCode = value;
      }
  }
}

private string _ssApprovalProcessVersion;
public string ssApprovalProcessVersion{
  get{
      return _ssApprovalProcessVersion;
  }
  set{
      if((_ssApprovalProcessVersion!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssApprovalProcessVersion = value;
      }
  }
}

private int _ssCurrentLevel;
public int ssCurrentLevel{
  get{
      return _ssCurrentLevel;
  }
  set{
      if((_ssCurrentLevel!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssMaxLevel!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssStartedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssFinishedOn!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssFinishedOn = value;
      }
  }
}

private bool _ssHasStartedAccounting;
public bool ssHasStartedAccounting{
  get{
      return _ssHasStartedAccounting;
  }
  set{
      if((_ssHasStartedAccounting!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssHasStartedAccounting = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord() {
ChangedAttributes = new BitArray(10,true);
OptimizedAttributes = new BitArray(10,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssAprovalProcessId = 0L;
_ssProcessTypeCode = "";
_ssApprovalProcessVersion = "";
_ssCurrentLevel = 0;
_ssMaxLevel = 0;
_ssStartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssFinishedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssHasStartedAccounting = false;
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
ssId = r.ReadLongInteger(index++, "InvoiceApproval.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApproval.InvoiceId", 0L);
ssAprovalProcessId = r.ReadLongInteger(index++, "InvoiceApproval.AprovalProcessId", 0L);
ssProcessTypeCode = r.ReadText(index++, "InvoiceApproval.ProcessTypeCode", "");
ssApprovalProcessVersion = r.ReadText(index++, "InvoiceApproval.ApprovalProcessVersion", "");
ssCurrentLevel = r.ReadInteger(index++, "InvoiceApproval.CurrentLevel", 0);
ssMaxLevel = r.ReadInteger(index++, "InvoiceApproval.MaxLevel", 0);
ssStartedOn = r.ReadDateTime(index++, "InvoiceApproval.StartedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFinishedOn = r.ReadDateTime(index++, "InvoiceApproval.FinishedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssHasStartedAccounting = r.ReadBoolean(index++, "InvoiceApproval.HasStartedAccounting", false);
ChangedAttributes = new BitArray(10,false);
OptimizedAttributes = new BitArray(10,false);
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
public void ReadIM(EN_c2bd0675fed3aedb585c484c59155eddEntityRecord r) {
this = r;
}


public static bool operator == (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord a, EN_c2bd0675fed3aedb585c484c59155eddEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssAprovalProcessId != b.ssAprovalProcessId) return false;
if (a.ssProcessTypeCode != b.ssProcessTypeCode) return false;
if (a.ssApprovalProcessVersion != b.ssApprovalProcessVersion) return false;
if (a.ssCurrentLevel != b.ssCurrentLevel) return false;
if (a.ssMaxLevel != b.ssMaxLevel) return false;
if (a.ssStartedOn != b.ssStartedOn) return false;
if (a.ssFinishedOn != b.ssFinishedOn) return false;
if (a.ssHasStartedAccounting != b.ssHasStartedAccounting) return false;
return true;
}

public static bool operator != (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord a, EN_c2bd0675fed3aedb585c484c59155eddEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)) return false;
return (this == (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssAprovalProcessId.GetHashCode()
 ^ ssProcessTypeCode.GetHashCode()
 ^ ssApprovalProcessVersion.GetHashCode()
 ^ ssCurrentLevel.GetHashCode()
 ^ ssMaxLevel.GetHashCode()
 ^ ssStartedOn.GetHashCode()
 ^ ssFinishedOn.GetHashCode()
 ^ ssHasStartedAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord Duplicate() {
EN_c2bd0675fed3aedb585c484c59155eddEntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssAprovalProcessId = this._ssAprovalProcessId;
t._ssProcessTypeCode = this._ssProcessTypeCode;
t._ssApprovalProcessVersion = this._ssApprovalProcessVersion;
t._ssCurrentLevel = this._ssCurrentLevel;
t._ssMaxLevel = this._ssMaxLevel;
t._ssStartedOn = this._ssStartedOn;
t._ssFinishedOn = this._ssFinishedOn;
t._ssHasStartedAccounting = this._ssHasStartedAccounting;
t.ChangedAttributes = new BitArray(10);
t.OptimizedAttributes = new BitArray(10);
for(int i = 0; i < 10; i++){
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
} else if (head == "aprovalprocessid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AprovalProcessId")) variable.Value = ssAprovalProcessId; else variable.Optimized = true;
} else if (head == "processtypecode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessTypeCode")) variable.Value = ssProcessTypeCode; else variable.Optimized = true;
} else if (head == "approvalprocessversion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessVersion")) variable.Value = ssApprovalProcessVersion; else variable.Optimized = true;
} else if (head == "currentlevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrentLevel")) variable.Value = ssCurrentLevel; else variable.Optimized = true;
} else if (head == "maxlevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxLevel")) variable.Value = ssMaxLevel; else variable.Optimized = true;
} else if (head == "startedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartedOn")) variable.Value = ssStartedOn; else variable.Optimized = true;
} else if (head == "finishedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinishedOn")) variable.Value = ssFinishedOn; else variable.Optimized = true;
} else if (head == "hasstartedaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasStartedAccounting")) variable.Value = ssHasStartedAccounting; else variable.Optimized = true;
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
if (key.Equals(IdAprovalProcessId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdProcessTypeCode)) {
return ChangedAttributes[3];
}
if (key.Equals(IdApprovalProcessVersion)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCurrentLevel)) {
return ChangedAttributes[5];
}
if (key.Equals(IdMaxLevel)) {
return ChangedAttributes[6];
}
if (key.Equals(IdStartedOn)) {
return ChangedAttributes[7];
}
if (key.Equals(IdFinishedOn)) {
return ChangedAttributes[8];
}
if (key.Equals(IdHasStartedAccounting)) {
return ChangedAttributes[9];
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
if (key.Equals(IdAprovalProcessId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdProcessTypeCode)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdApprovalProcessVersion)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCurrentLevel)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdMaxLevel)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdStartedOn)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdFinishedOn)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdHasStartedAccounting)) {
return OptimizedAttributes[9];
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
if (key == IdAprovalProcessId) {
return ssAprovalProcessId;
}
if (key == IdProcessTypeCode) {
return ssProcessTypeCode;
}
if (key == IdApprovalProcessVersion) {
return ssApprovalProcessVersion;
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
if (key == IdHasStartedAccounting) {
return ssHasStartedAccounting;
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
if (attributeKey == IdAprovalProcessId.Key.AsGuid) {
return ssAprovalProcessId;
}
if (attributeKey == IdProcessTypeCode.Key.AsGuid) {
return ssProcessTypeCode;
}
if (attributeKey == IdApprovalProcessVersion.Key.AsGuid) {
return ssApprovalProcessVersion;
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
if (attributeKey == IdHasStartedAccounting.Key.AsGuid) {
return ssHasStartedAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(10);
OptimizedAttributes = new BitArray(10);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssAprovalProcessId = (long) other.AttributeGet(IdAprovalProcessId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdAprovalProcessId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAprovalProcessId);
ssProcessTypeCode = (string) other.AttributeGet(IdProcessTypeCode);
ChangedAttributes[3] = other.ChangedAttributeGet(IdProcessTypeCode);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdProcessTypeCode);
ssApprovalProcessVersion = (string) other.AttributeGet(IdApprovalProcessVersion);
ChangedAttributes[4] = other.ChangedAttributeGet(IdApprovalProcessVersion);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdApprovalProcessVersion);
ssCurrentLevel = (int) other.AttributeGet(IdCurrentLevel);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCurrentLevel);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCurrentLevel);
ssMaxLevel = (int) other.AttributeGet(IdMaxLevel);
ChangedAttributes[6] = other.ChangedAttributeGet(IdMaxLevel);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdMaxLevel);
ssStartedOn = (DateTime) other.AttributeGet(IdStartedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdStartedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdStartedOn);
ssFinishedOn = (DateTime) other.AttributeGet(IdFinishedOn);
ChangedAttributes[8] = other.ChangedAttributeGet(IdFinishedOn);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdFinishedOn);
ssHasStartedAccounting = (bool) other.AttributeGet(IdHasStartedAccounting);
ChangedAttributes[9] = other.ChangedAttributeGet(IdHasStartedAccounting);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdHasStartedAccounting);
}
} // EN_c2bd0675fed3aedb585c484c59155eddEntityRecord

/// <summary>
/// RecordList type <code>InvoiceApprovalList</code> that represents a record list of
///  <code>InvoiceApproval</code>
/// </summary>
public partial class RL_86c60818141503f536477bc2eaa63631 : GenericRecordList<EN_c2bd0675fed3aedb585c484c59155eddEntityRecord>, IEnumerable, IEnumerator {

protected override EN_c2bd0675fed3aedb585c484c59155eddEntityRecord GetElementDefaultValue() {
return new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
}

public T[] ToArray<T>(Func<EN_c2bd0675fed3aedb585c484c59155eddEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_86c60818141503f536477bc2eaa63631 recordList, Func<EN_c2bd0675fed3aedb585c484c59155eddEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_86c60818141503f536477bc2eaa63631(EN_c2bd0675fed3aedb585c484c59155eddEntityRecord[] array) {
  RL_86c60818141503f536477bc2eaa63631 result = new RL_86c60818141503f536477bc2eaa63631();
result.InnerFromArray(array);
    return result;
}

public static RL_86c60818141503f536477bc2eaa63631 ToList<T>(T[] array, Func <T, EN_c2bd0675fed3aedb585c484c59155eddEntityRecord> converter) {
  RL_86c60818141503f536477bc2eaa63631 result = new RL_86c60818141503f536477bc2eaa63631();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_86c60818141503f536477bc2eaa63631 FromRestList<T>(RestList<T> restList, Func <T, EN_c2bd0675fed3aedb585c484c59155eddEntityRecord> converter) {
  RL_86c60818141503f536477bc2eaa63631 result = new RL_86c60818141503f536477bc2eaa63631();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_86c60818141503f536477bc2eaa63631() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c2bd0675fed3aedb585c484c59155eddEntityRecord> NewList() {
return new RL_86c60818141503f536477bc2eaa63631();
}


} // RL_86c60818141503f536477bc2eaa63631
}
