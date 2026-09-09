using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] InvoicesUsageAccounts (hfo_0haY_0CyfwTEyo6FYA)
///  <code>EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord</code> that represent
/// s <code>InvoicesUsageAccounts</code> <p>Description: Hold Invoice Usages and Matchs them to an
///  Accounting Account</p>
/// </summary>
// Name: InvoicesUsageAccounts
public partial struct EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord : ITypedRecord<EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Y0R+RegsW0SBVPp86RzF8w");
internal static readonly GlobalObjectKey IdInvoiceUsageId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+cHgNLXE+UWzLekrOMVM7A");
internal static readonly GlobalObjectKey IdAccountingAccount = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*FwfaUsBlZUWXM0WnXY3x6g");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*xGGYdorjJkyrhJ3QeMc3zA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*W85DmeA6F0iVqB9MIIvIsw");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*yrMOdjLGu0yvnGMgaLtXWg");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*JZ5abOfJJ0Kxxn4AkuA4Eg");

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

private long _ssInvoiceUsageId;
public long ssInvoiceUsageId{
  get{
      return _ssInvoiceUsageId;
  }
  set{
      if((_ssInvoiceUsageId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceUsageId = value;
      }
  }
}

private string _ssAccountingAccount;
public string ssAccountingAccount{
  get{
      return _ssAccountingAccount;
  }
  set{
      if((_ssAccountingAccount!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssAccountingAccount = value;
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

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssUpdatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssInvoiceUsageId = 0L;
_ssAccountingAccount = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
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
ssId = r.ReadLongInteger(index++, "InvoicesUsageAccounts.Id", 0L);
ssInvoiceUsageId = r.ReadEntityReferenceLongInteger(index++, "InvoicesUsageAccounts.InvoiceUsageId", 0L);
ssAccountingAccount = r.ReadText(index++, "InvoicesUsageAccounts.AccountingAccount", "");
ssCreatedOn = r.ReadDateTime(index++, "InvoicesUsageAccounts.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoicesUsageAccounts.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "InvoicesUsageAccounts.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "InvoicesUsageAccounts.UpdatedBy", "");
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
public void ReadIM(EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord r) {
this = r;
}


public static bool operator == (EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord a, EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceUsageId != b.ssInvoiceUsageId) return false;
if (a.ssAccountingAccount != b.ssAccountingAccount) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord a, EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord)) return false;
return (this == (EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceUsageId.GetHashCode()
 ^ ssAccountingAccount.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord Duplicate() {
EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceUsageId = this._ssInvoiceUsageId;
t._ssAccountingAccount = this._ssAccountingAccount;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
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
} else if (head == "invoiceusageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsageId")) variable.Value = ssInvoiceUsageId; else variable.Optimized = true;
} else if (head == "accountingaccount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingAccount")) variable.Value = ssAccountingAccount; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceUsageId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdAccountingAccount)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceUsageId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdAccountingAccount)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceUsageId) {
return ssInvoiceUsageId;
}
if (key == IdAccountingAccount) {
return ssAccountingAccount;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceUsageId.Key.AsGuid) {
return ssInvoiceUsageId;
}
if (attributeKey == IdAccountingAccount.Key.AsGuid) {
return ssAccountingAccount;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
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
ssInvoiceUsageId = (long) other.AttributeGet(IdInvoiceUsageId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceUsageId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceUsageId);
ssAccountingAccount = (string) other.AttributeGet(IdAccountingAccount);
ChangedAttributes[2] = other.ChangedAttributeGet(IdAccountingAccount);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAccountingAccount);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord

/// <summary>
/// RecordList type <code>InvoicesUsageAccountsList</code> that represents a record list of
///  <code>InvoicesUsageAccounts</code>
/// </summary>
public partial class RL_6672689baf5242c772d5c80e8203b28e : GenericRecordList<EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord>, IEnumerable, IEnumerator {

protected override EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord GetElementDefaultValue() {
return new EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord();
}

public T[] ToArray<T>(Func<EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6672689baf5242c772d5c80e8203b28e recordList, Func<EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6672689baf5242c772d5c80e8203b28e(EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord[] array) {
  RL_6672689baf5242c772d5c80e8203b28e result = new RL_6672689baf5242c772d5c80e8203b28e();
result.InnerFromArray(array);
    return result;
}

public static RL_6672689baf5242c772d5c80e8203b28e ToList<T>(T[] array, Func <T, EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord> converter) {
  RL_6672689baf5242c772d5c80e8203b28e result = new RL_6672689baf5242c772d5c80e8203b28e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6672689baf5242c772d5c80e8203b28e FromRestList<T>(RestList<T> restList, Func <T, EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord> converter) {
  RL_6672689baf5242c772d5c80e8203b28e result = new RL_6672689baf5242c772d5c80e8203b28e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6672689baf5242c772d5c80e8203b28e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord> NewList() {
return new RL_6672689baf5242c772d5c80e8203b28e();
}


} // RL_6672689baf5242c772d5c80e8203b28e
}
