using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderService (lzexmMRxdU6a4h5lhKNW0g)
///  <code>EN_476685ea0a242c4f2681d09188dc12dfEntityRecord</code> that represent
/// s <code>OrderService</code> <p>Description: Order Service</p>
/// </summary>
// Name: OrderService
public partial struct EN_476685ea0a242c4f2681d09188dc12dfEntityRecord : ITypedRecord<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*w1PWCq1_UU6r4GEAUArfMQ");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mHJKUJ8QgEq+SJJyd8Gyuw");
internal static readonly GlobalObjectKey IdAccountingServiceTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tQJpCQZpn0aqzIfiHS6UCw");
internal static readonly GlobalObjectKey IdFrequencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bLDnZpRqOEyCHwlapAbWKg");
internal static readonly GlobalObjectKey IdAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dCCUI3289kuM0v2ja4DhVQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xNwRArGamkGH7XMRmHqCgA");
internal static readonly GlobalObjectKey IdInvoiceUsageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gIoyV+1cW02izcO7ILYqCQ");

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

public EN_476685ea0a242c4f2681d09188dc12dfEntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssOrderId = 0L;
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
ssId = r.ReadLongInteger(index++, "OrderService.Id", 0L);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderService.OrderId", 0L);
ssAccountingServiceTypeId = r.ReadEntityReferenceLongInteger(index++, "OrderService.AccountingServiceTypeId", 0L);
ssFrequencyId = r.ReadEntityReference(index++, "OrderService.FrequencyId", 0);
ssAmount = r.ReadDecimal(index++, "OrderService.Amount", 0.0M);
ssDescription = r.ReadText(index++, "OrderService.Description", "");
ssInvoiceUsageId = r.ReadEntityReferenceLongInteger(index++, "OrderService.InvoiceUsageId", 0L);
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
public void ReadIM(EN_476685ea0a242c4f2681d09188dc12dfEntityRecord r) {
this = r;
}


public static bool operator == (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord a, EN_476685ea0a242c4f2681d09188dc12dfEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssAccountingServiceTypeId != b.ssAccountingServiceTypeId) return false;
if (a.ssFrequencyId != b.ssFrequencyId) return false;
if (a.ssAmount != b.ssAmount) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssInvoiceUsageId != b.ssInvoiceUsageId) return false;
return true;
}

public static bool operator != (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord a, EN_476685ea0a242c4f2681d09188dc12dfEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord)) return false;
return (this == (EN_476685ea0a242c4f2681d09188dc12dfEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderId.GetHashCode()
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


public EN_476685ea0a242c4f2681d09188dc12dfEntityRecord Duplicate() {
EN_476685ea0a242c4f2681d09188dc12dfEntityRecord t;
t._ssId = this._ssId;
t._ssOrderId = this._ssOrderId;
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
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
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
if (key.Equals(IdOrderId)) {
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
if (key.Equals(IdOrderId)) {
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
if (key == IdOrderId) {
return ssOrderId;
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
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
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
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderId);
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
} // EN_476685ea0a242c4f2681d09188dc12dfEntityRecord

/// <summary>
/// RecordList type <code>OrderServiceList</code> that represents a record list of
///  <code>OrderService</code>
/// </summary>
public partial class RL_259894dce3212e18ca34cc99b4f08bea : GenericRecordList<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord>, IEnumerable, IEnumerator {

protected override EN_476685ea0a242c4f2681d09188dc12dfEntityRecord GetElementDefaultValue() {
return new EN_476685ea0a242c4f2681d09188dc12dfEntityRecord();
}

public T[] ToArray<T>(Func<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_259894dce3212e18ca34cc99b4f08bea recordList, Func<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_259894dce3212e18ca34cc99b4f08bea(EN_476685ea0a242c4f2681d09188dc12dfEntityRecord[] array) {
  RL_259894dce3212e18ca34cc99b4f08bea result = new RL_259894dce3212e18ca34cc99b4f08bea();
result.InnerFromArray(array);
    return result;
}

public static RL_259894dce3212e18ca34cc99b4f08bea ToList<T>(T[] array, Func <T, EN_476685ea0a242c4f2681d09188dc12dfEntityRecord> converter) {
  RL_259894dce3212e18ca34cc99b4f08bea result = new RL_259894dce3212e18ca34cc99b4f08bea();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_259894dce3212e18ca34cc99b4f08bea FromRestList<T>(RestList<T> restList, Func <T, EN_476685ea0a242c4f2681d09188dc12dfEntityRecord> converter) {
  RL_259894dce3212e18ca34cc99b4f08bea result = new RL_259894dce3212e18ca34cc99b4f08bea();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_259894dce3212e18ca34cc99b4f08bea() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_476685ea0a242c4f2681d09188dc12dfEntityRecord> NewList() {
return new RL_259894dce3212e18ca34cc99b4f08bea();
}


} // RL_259894dce3212e18ca34cc99b4f08bea
}
