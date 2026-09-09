using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionService (dvh1kw7SeUqyNN7n4XgIzQ)
///  <code>EN_455768e63ed34ad2746f7c539b65e1caEntityRecord</code> that represent
/// s <code>RequisitionService</code> <p>Description: Entity that holds Requisition Service.</p>
/// </summary>
// Name: RequisitionService
public partial struct EN_455768e63ed34ad2746f7c539b65e1caEntityRecord : ITypedRecord<EN_455768e63ed34ad2746f7c539b65e1caEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*I5m5Yr2KSkmUWajlLVCN8g");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tQAIeK1HLEux2Wg93wCTNQ");
internal static readonly GlobalObjectKey IdAccountingServiceTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tQs+b2zXx0u6Z_N+XszeeQ");
internal static readonly GlobalObjectKey IdFrequencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qmhhMHnTJkOmROzTYZsTWg");
internal static readonly GlobalObjectKey IdAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Kry_e4jwV0KeUlyxl8LRHA");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3rmdWjF+BEqEKferp1lyaQ");
internal static readonly GlobalObjectKey IdInvoiceUsageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kuESXk0ayUmXtJ6KQn31Pg");

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

private long _ssAccountingServiceTypeId;
public long ssAccountingServiceTypeId{
  get{
      return _ssAccountingServiceTypeId;
  }
  set{
      if((_ssAccountingServiceTypeId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssAccountingServiceTypeId = value;
      }
  }
}

private int _ssFrequencyId;
public int ssFrequencyId{
  get{
      return _ssFrequencyId;
  }
  set{
      if((_ssFrequencyId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssFrequencyId = value;
      }
  }
}

private decimal _ssAmount;
public decimal ssAmount{
  get{
      return _ssAmount;
  }
  set{
      if((_ssAmount!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssAmount = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssDescription = value;
      }
  }
}

private long _ssInvoiceUsageId;
public long ssInvoiceUsageId{
  get{
      return _ssInvoiceUsageId;
  }
  set{
      if((_ssInvoiceUsageId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssInvoiceUsageId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_455768e63ed34ad2746f7c539b65e1caEntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssRequisitionId = 0L;
_ssAccountingServiceTypeId = 0L;
_ssFrequencyId = 0;
_ssAmount = 0.0M;
_ssDescription = "";
_ssInvoiceUsageId = 0L;
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
ssId = r.ReadLongInteger(index++, "RequisitionService.Id", 0L);
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionService.RequisitionId", 0L);
ssAccountingServiceTypeId = r.ReadEntityReferenceLongInteger(index++, "RequisitionService.AccountingServiceTypeId", 0L);
ssFrequencyId = r.ReadEntityReference(index++, "RequisitionService.FrequencyId", 0);
ssAmount = r.ReadDecimal(index++, "RequisitionService.Amount", 0.0M);
ssDescription = r.ReadText(index++, "RequisitionService.Description", "");
ssInvoiceUsageId = r.ReadEntityReferenceLongInteger(index++, "RequisitionService.InvoiceUsageId", 0L);
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
public void ReadIM(EN_455768e63ed34ad2746f7c539b65e1caEntityRecord r) {
this = r;
}


public static bool operator == (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord a, EN_455768e63ed34ad2746f7c539b65e1caEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssAccountingServiceTypeId != b.ssAccountingServiceTypeId) return false;
if (a.ssFrequencyId != b.ssFrequencyId) return false;
if (a.ssAmount != b.ssAmount) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssInvoiceUsageId != b.ssInvoiceUsageId) return false;
return true;
}

public static bool operator != (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord a, EN_455768e63ed34ad2746f7c539b65e1caEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord)) return false;
return (this == (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssAccountingServiceTypeId.GetHashCode()
 ^ ssFrequencyId.GetHashCode()
 ^ ssAmount.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssInvoiceUsageId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_455768e63ed34ad2746f7c539b65e1caEntityRecord Duplicate() {
EN_455768e63ed34ad2746f7c539b65e1caEntityRecord t;
t._ssId = this._ssId;
t._ssRequisitionId = this._ssRequisitionId;
t._ssAccountingServiceTypeId = this._ssAccountingServiceTypeId;
t._ssFrequencyId = this._ssFrequencyId;
t._ssAmount = this._ssAmount;
t._ssDescription = this._ssDescription;
t._ssInvoiceUsageId = this._ssInvoiceUsageId;
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
} else if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "accountingservicetypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingServiceTypeId")) variable.Value = ssAccountingServiceTypeId; else variable.Optimized = true;
} else if (head == "frequencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FrequencyId")) variable.Value = ssFrequencyId; else variable.Optimized = true;
} else if (head == "amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amount")) variable.Value = ssAmount; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "invoiceusageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsageId")) variable.Value = ssInvoiceUsageId; else variable.Optimized = true;
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
if (key.Equals(IdAccountingServiceTypeId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdFrequencyId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdAmount)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[5];
}
if (key.Equals(IdInvoiceUsageId)) {
return ChangedAttributes[6];
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
if (key.Equals(IdAccountingServiceTypeId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdFrequencyId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdAmount)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdInvoiceUsageId)) {
return OptimizedAttributes[6];
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
if (key == IdAccountingServiceTypeId) {
return ssAccountingServiceTypeId;
}
if (key == IdFrequencyId) {
return ssFrequencyId;
}
if (key == IdAmount) {
return ssAmount;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdInvoiceUsageId) {
return ssInvoiceUsageId;
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
if (attributeKey == IdAccountingServiceTypeId.Key.AsGuid) {
return ssAccountingServiceTypeId;
}
if (attributeKey == IdFrequencyId.Key.AsGuid) {
return ssFrequencyId;
}
if (attributeKey == IdAmount.Key.AsGuid) {
return ssAmount;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdInvoiceUsageId.Key.AsGuid) {
return ssInvoiceUsageId;
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
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRequisitionId);
ssAccountingServiceTypeId = (long) other.AttributeGet(IdAccountingServiceTypeId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdAccountingServiceTypeId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAccountingServiceTypeId);
ssFrequencyId = (int) other.AttributeGet(IdFrequencyId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdFrequencyId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdFrequencyId);
ssAmount = (decimal) other.AttributeGet(IdAmount);
ChangedAttributes[4] = other.ChangedAttributeGet(IdAmount);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdAmount);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDescription);
ssInvoiceUsageId = (long) other.AttributeGet(IdInvoiceUsageId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdInvoiceUsageId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdInvoiceUsageId);
}
} // EN_455768e63ed34ad2746f7c539b65e1caEntityRecord

/// <summary>
/// RecordList type <code>RequisitionServiceList</code> that represents a record list of
///  <code>RequisitionService</code>
/// </summary>
public partial class RL_f631cdf92d6e85a1d6f52da923631909 : GenericRecordList<EN_455768e63ed34ad2746f7c539b65e1caEntityRecord>, IEnumerable, IEnumerator {

protected override EN_455768e63ed34ad2746f7c539b65e1caEntityRecord GetElementDefaultValue() {
return new EN_455768e63ed34ad2746f7c539b65e1caEntityRecord();
}

public T[] ToArray<T>(Func<EN_455768e63ed34ad2746f7c539b65e1caEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f631cdf92d6e85a1d6f52da923631909 recordList, Func<EN_455768e63ed34ad2746f7c539b65e1caEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f631cdf92d6e85a1d6f52da923631909(EN_455768e63ed34ad2746f7c539b65e1caEntityRecord[] array) {
  RL_f631cdf92d6e85a1d6f52da923631909 result = new RL_f631cdf92d6e85a1d6f52da923631909();
result.InnerFromArray(array);
    return result;
}

public static RL_f631cdf92d6e85a1d6f52da923631909 ToList<T>(T[] array, Func <T, EN_455768e63ed34ad2746f7c539b65e1caEntityRecord> converter) {
  RL_f631cdf92d6e85a1d6f52da923631909 result = new RL_f631cdf92d6e85a1d6f52da923631909();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f631cdf92d6e85a1d6f52da923631909 FromRestList<T>(RestList<T> restList, Func <T, EN_455768e63ed34ad2746f7c539b65e1caEntityRecord> converter) {
  RL_f631cdf92d6e85a1d6f52da923631909 result = new RL_f631cdf92d6e85a1d6f52da923631909();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f631cdf92d6e85a1d6f52da923631909() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_455768e63ed34ad2746f7c539b65e1caEntityRecord> NewList() {
return new RL_f631cdf92d6e85a1d6f52da923631909();
}


} // RL_f631cdf92d6e85a1d6f52da923631909
}
