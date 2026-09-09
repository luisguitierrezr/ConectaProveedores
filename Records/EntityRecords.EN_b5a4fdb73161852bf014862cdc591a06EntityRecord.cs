using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceAccountingProcessRetentions (rcWg3H9yHEK7TGJCo3rytg)
///  <code>EN_b5a4fdb73161852bf014862cdc591a06EntityRecord</code> that represent
/// s <code>InvoiceAccountingProcessRetentions</code> <p>Description: Saves retentions to call after
///  invoice accounting</p>
/// </summary>
// Name: InvoiceAccountingProcessRetentions
public partial struct EN_b5a4fdb73161852bf014862cdc591a06EntityRecord : ITypedRecord<EN_b5a4fdb73161852bf014862cdc591a06EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JucFlin4Vken2XGwMzJCFA");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcessId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iJoyfbSPzE2jEwu+XNL6_w");
internal static readonly GlobalObjectKey IdWITHT = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Cthg0_269kuM1sLVo_7syQ");
internal static readonly GlobalObjectKey IdWT_WITHCD = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jZkJaPD6skyYw80wzNW3Sw");
internal static readonly GlobalObjectKey IdWT_SUBJCT = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NrLmzQjXxUSqgPlEE4MQnQ");

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

private long _ssInvoiceAccountingProcessId;
public long ssInvoiceAccountingProcessId{
  get{
      return _ssInvoiceAccountingProcessId;
  }
  set{
      if((_ssInvoiceAccountingProcessId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceAccountingProcessId = value;
      }
  }
}

private string _ssWITHT;
public string ssWITHT{
  get{
      return _ssWITHT;
  }
  set{
      if((_ssWITHT!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssWITHT = value;
      }
  }
}

private string _ssWT_WITHCD;
public string ssWT_WITHCD{
  get{
      return _ssWT_WITHCD;
  }
  set{
      if((_ssWT_WITHCD!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssWT_WITHCD = value;
      }
  }
}

private string _ssWT_SUBJCT;
public string ssWT_SUBJCT{
  get{
      return _ssWT_SUBJCT;
  }
  set{
      if((_ssWT_SUBJCT!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssWT_SUBJCT = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b5a4fdb73161852bf014862cdc591a06EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssInvoiceAccountingProcessId = 0L;
_ssWITHT = "";
_ssWT_WITHCD = "";
_ssWT_SUBJCT = "";
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
ssId = r.ReadLongInteger(index++, "InvoiceAccountingProcessRetentions.Id", 0L);
ssInvoiceAccountingProcessId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingProcessRetentions.InvoiceAccountingProcessId", 0L);
ssWITHT = r.ReadText(index++, "InvoiceAccountingProcessRetentions.WITHT", "");
ssWT_WITHCD = r.ReadText(index++, "InvoiceAccountingProcessRetentions.WT_WITHCD", "");
ssWT_SUBJCT = r.ReadText(index++, "InvoiceAccountingProcessRetentions.WT_SUBJCT", "");
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
public void ReadIM(EN_b5a4fdb73161852bf014862cdc591a06EntityRecord r) {
this = r;
}


public static bool operator == (EN_b5a4fdb73161852bf014862cdc591a06EntityRecord a, EN_b5a4fdb73161852bf014862cdc591a06EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceAccountingProcessId != b.ssInvoiceAccountingProcessId) return false;
if (a.ssWITHT != b.ssWITHT) return false;
if (a.ssWT_WITHCD != b.ssWT_WITHCD) return false;
if (a.ssWT_SUBJCT != b.ssWT_SUBJCT) return false;
return true;
}

public static bool operator != (EN_b5a4fdb73161852bf014862cdc591a06EntityRecord a, EN_b5a4fdb73161852bf014862cdc591a06EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b5a4fdb73161852bf014862cdc591a06EntityRecord)) return false;
return (this == (EN_b5a4fdb73161852bf014862cdc591a06EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceAccountingProcessId.GetHashCode()
 ^ ssWITHT.GetHashCode()
 ^ ssWT_WITHCD.GetHashCode()
 ^ ssWT_SUBJCT.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b5a4fdb73161852bf014862cdc591a06EntityRecord Duplicate() {
EN_b5a4fdb73161852bf014862cdc591a06EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceAccountingProcessId = this._ssInvoiceAccountingProcessId;
t._ssWITHT = this._ssWITHT;
t._ssWT_WITHCD = this._ssWT_WITHCD;
t._ssWT_SUBJCT = this._ssWT_SUBJCT;
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
} else if (head == "invoiceaccountingprocessid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcessId")) variable.Value = ssInvoiceAccountingProcessId; else variable.Optimized = true;
} else if (head == "witht") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WITHT")) variable.Value = ssWITHT; else variable.Optimized = true;
} else if (head == "wt_withcd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_WITHCD")) variable.Value = ssWT_WITHCD; else variable.Optimized = true;
} else if (head == "wt_subjct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_SUBJCT")) variable.Value = ssWT_SUBJCT; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceAccountingProcessId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdWITHT)) {
return ChangedAttributes[2];
}
if (key.Equals(IdWT_WITHCD)) {
return ChangedAttributes[3];
}
if (key.Equals(IdWT_SUBJCT)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceAccountingProcessId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdWITHT)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdWT_WITHCD)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdWT_SUBJCT)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceAccountingProcessId) {
return ssInvoiceAccountingProcessId;
}
if (key == IdWITHT) {
return ssWITHT;
}
if (key == IdWT_WITHCD) {
return ssWT_WITHCD;
}
if (key == IdWT_SUBJCT) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceAccountingProcessId.Key.AsGuid) {
return ssInvoiceAccountingProcessId;
}
if (attributeKey == IdWITHT.Key.AsGuid) {
return ssWITHT;
}
if (attributeKey == IdWT_WITHCD.Key.AsGuid) {
return ssWT_WITHCD;
}
if (attributeKey == IdWT_SUBJCT.Key.AsGuid) {
return ssWT_SUBJCT;
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
ssInvoiceAccountingProcessId = (long) other.AttributeGet(IdInvoiceAccountingProcessId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceAccountingProcessId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceAccountingProcessId);
ssWITHT = (string) other.AttributeGet(IdWITHT);
ChangedAttributes[2] = other.ChangedAttributeGet(IdWITHT);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdWITHT);
ssWT_WITHCD = (string) other.AttributeGet(IdWT_WITHCD);
ChangedAttributes[3] = other.ChangedAttributeGet(IdWT_WITHCD);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdWT_WITHCD);
ssWT_SUBJCT = (string) other.AttributeGet(IdWT_SUBJCT);
ChangedAttributes[4] = other.ChangedAttributeGet(IdWT_SUBJCT);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdWT_SUBJCT);
}
} // EN_b5a4fdb73161852bf014862cdc591a06EntityRecord

/// <summary>
/// RecordList type <code>InvoiceAccountingProcessRetentionsList</code> that represents a record list
///  of <code>InvoiceAccountingProcessRetentions</code>
/// </summary>
public partial class RL_453e48d36fee1cd8cc56ebbd231f6bbd : GenericRecordList<EN_b5a4fdb73161852bf014862cdc591a06EntityRecord>, IEnumerable, IEnumerator {

protected override EN_b5a4fdb73161852bf014862cdc591a06EntityRecord GetElementDefaultValue() {
return new EN_b5a4fdb73161852bf014862cdc591a06EntityRecord();
}

public T[] ToArray<T>(Func<EN_b5a4fdb73161852bf014862cdc591a06EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_453e48d36fee1cd8cc56ebbd231f6bbd recordList, Func<EN_b5a4fdb73161852bf014862cdc591a06EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_453e48d36fee1cd8cc56ebbd231f6bbd(EN_b5a4fdb73161852bf014862cdc591a06EntityRecord[] array) {
  RL_453e48d36fee1cd8cc56ebbd231f6bbd result = new RL_453e48d36fee1cd8cc56ebbd231f6bbd();
result.InnerFromArray(array);
    return result;
}

public static RL_453e48d36fee1cd8cc56ebbd231f6bbd ToList<T>(T[] array, Func <T, EN_b5a4fdb73161852bf014862cdc591a06EntityRecord> converter) {
  RL_453e48d36fee1cd8cc56ebbd231f6bbd result = new RL_453e48d36fee1cd8cc56ebbd231f6bbd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_453e48d36fee1cd8cc56ebbd231f6bbd FromRestList<T>(RestList<T> restList, Func <T, EN_b5a4fdb73161852bf014862cdc591a06EntityRecord> converter) {
  RL_453e48d36fee1cd8cc56ebbd231f6bbd result = new RL_453e48d36fee1cd8cc56ebbd231f6bbd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_453e48d36fee1cd8cc56ebbd231f6bbd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b5a4fdb73161852bf014862cdc591a06EntityRecord> NewList() {
return new RL_453e48d36fee1cd8cc56ebbd231f6bbd();
}


} // RL_453e48d36fee1cd8cc56ebbd231f6bbd
}
