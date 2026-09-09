using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioExtended (k8PfOvR2pUy5TuFCnFZgCw)
///  <code>EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord</code> that represent
/// s <code>FolioExtended</code> <p>Description: Folio Extended</p>
/// </summary>
// Name: FolioExtended
public partial struct EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord : ITypedRecord<EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OPbqBHnzi0e9EfQHQ4xfLQ");
internal static readonly GlobalObjectKey IdIsAdvPayment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*anAhA+3eMUOBf426NL2uKQ");
internal static readonly GlobalObjectKey IdAdvPaymentValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ifAboVigykOfudHE_wob0A");
internal static readonly GlobalObjectKey IdIsCreditNote = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WTPwQhIBfk+mCR_Cfi+htQ");
internal static readonly GlobalObjectKey IdCreditNoteValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Q9KAfrWC5U2reTAK6HyXyQ");
internal static readonly GlobalObjectKey IdIsVoucher = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tMgvHzkd8k6rsRk8w8yuew");
internal static readonly GlobalObjectKey IdVoucherValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9VGNebn3bEuCzGCvCTIypg");
internal static readonly GlobalObjectKey IdIsNa = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_OoiTXGPzk+yJCmqFxi_Ug");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
          _ssId = value;
      }
  }
}

private bool _ssIsAdvPayment;
public bool ssIsAdvPayment{
  get{
      return _ssIsAdvPayment;
  }
  set{
      if((_ssIsAdvPayment!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssIsAdvPayment = value;
      }
  }
}

private decimal _ssAdvPaymentValue;
public decimal ssAdvPaymentValue{
  get{
      return _ssAdvPaymentValue;
  }
  set{
      if((_ssAdvPaymentValue!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssAdvPaymentValue = value;
      }
  }
}

private bool _ssIsCreditNote;
public bool ssIsCreditNote{
  get{
      return _ssIsCreditNote;
  }
  set{
      if((_ssIsCreditNote!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIsCreditNote = value;
      }
  }
}

private decimal _ssCreditNoteValue;
public decimal ssCreditNoteValue{
  get{
      return _ssCreditNoteValue;
  }
  set{
      if((_ssCreditNoteValue!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCreditNoteValue = value;
      }
  }
}

private bool _ssIsVoucher;
public bool ssIsVoucher{
  get{
      return _ssIsVoucher;
  }
  set{
      if((_ssIsVoucher!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIsVoucher = value;
      }
  }
}

private decimal _ssVoucherValue;
public decimal ssVoucherValue{
  get{
      return _ssVoucherValue;
  }
  set{
      if((_ssVoucherValue!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssVoucherValue = value;
      }
  }
}

private bool _ssIsNa;
public bool ssIsNa{
  get{
      return _ssIsNa;
  }
  set{
      if((_ssIsNa!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsNa = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssIsAdvPayment = false;
_ssAdvPaymentValue = 0.0M;
_ssIsCreditNote = false;
_ssCreditNoteValue = 0.0M;
_ssIsVoucher = false;
_ssVoucherValue = 0.0M;
_ssIsNa = false;
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
ssId = r.ReadEntityReferenceLongInteger(index++, "FolioExtended.Id", 0L);
ssIsAdvPayment = r.ReadBoolean(index++, "FolioExtended.IsAdvPayment", false);
ssAdvPaymentValue = r.ReadDecimal(index++, "FolioExtended.AdvPaymentValue", 0.0M);
ssIsCreditNote = r.ReadBoolean(index++, "FolioExtended.IsCreditNote", false);
ssCreditNoteValue = r.ReadDecimal(index++, "FolioExtended.CreditNoteValue", 0.0M);
ssIsVoucher = r.ReadBoolean(index++, "FolioExtended.IsVoucher", false);
ssVoucherValue = r.ReadDecimal(index++, "FolioExtended.VoucherValue", 0.0M);
ssIsNa = r.ReadBoolean(index++, "FolioExtended.IsNa", false);
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord r) {
this = r;
}


public static bool operator == (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord a, EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssIsAdvPayment != b.ssIsAdvPayment) return false;
if (a.ssAdvPaymentValue != b.ssAdvPaymentValue) return false;
if (a.ssIsCreditNote != b.ssIsCreditNote) return false;
if (a.ssCreditNoteValue != b.ssCreditNoteValue) return false;
if (a.ssIsVoucher != b.ssIsVoucher) return false;
if (a.ssVoucherValue != b.ssVoucherValue) return false;
if (a.ssIsNa != b.ssIsNa) return false;
return true;
}

public static bool operator != (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord a, EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord)) return false;
return (this == (EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssIsAdvPayment.GetHashCode()
 ^ ssAdvPaymentValue.GetHashCode()
 ^ ssIsCreditNote.GetHashCode()
 ^ ssCreditNoteValue.GetHashCode()
 ^ ssIsVoucher.GetHashCode()
 ^ ssVoucherValue.GetHashCode()
 ^ ssIsNa.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord Duplicate() {
EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord t;
t._ssId = this._ssId;
t._ssIsAdvPayment = this._ssIsAdvPayment;
t._ssAdvPaymentValue = this._ssAdvPaymentValue;
t._ssIsCreditNote = this._ssIsCreditNote;
t._ssCreditNoteValue = this._ssCreditNoteValue;
t._ssIsVoucher = this._ssIsVoucher;
t._ssVoucherValue = this._ssVoucherValue;
t._ssIsNa = this._ssIsNa;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
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
} else if (head == "isadvpayment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAdvPayment")) variable.Value = ssIsAdvPayment; else variable.Optimized = true;
} else if (head == "advpaymentvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvPaymentValue")) variable.Value = ssAdvPaymentValue; else variable.Optimized = true;
} else if (head == "iscreditnote") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsCreditNote")) variable.Value = ssIsCreditNote; else variable.Optimized = true;
} else if (head == "creditnotevalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreditNoteValue")) variable.Value = ssCreditNoteValue; else variable.Optimized = true;
} else if (head == "isvoucher") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsVoucher")) variable.Value = ssIsVoucher; else variable.Optimized = true;
} else if (head == "vouchervalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VoucherValue")) variable.Value = ssVoucherValue; else variable.Optimized = true;
} else if (head == "isna") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsNa")) variable.Value = ssIsNa; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdIsAdvPayment)) {
return ChangedAttributes[1];
}
if (key.Equals(IdAdvPaymentValue)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIsCreditNote)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreditNoteValue)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsVoucher)) {
return ChangedAttributes[5];
}
if (key.Equals(IdVoucherValue)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsNa)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdIsAdvPayment)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdAdvPaymentValue)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIsCreditNote)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreditNoteValue)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsVoucher)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdVoucherValue)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsNa)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdIsAdvPayment) {
return ssIsAdvPayment;
}
if (key == IdAdvPaymentValue) {
return ssAdvPaymentValue;
}
if (key == IdIsCreditNote) {
return ssIsCreditNote;
}
if (key == IdCreditNoteValue) {
return ssCreditNoteValue;
}
if (key == IdIsVoucher) {
return ssIsVoucher;
}
if (key == IdVoucherValue) {
return ssVoucherValue;
}
if (key == IdIsNa) {
return ssIsNa;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdIsAdvPayment.Key.AsGuid) {
return ssIsAdvPayment;
}
if (attributeKey == IdAdvPaymentValue.Key.AsGuid) {
return ssAdvPaymentValue;
}
if (attributeKey == IdIsCreditNote.Key.AsGuid) {
return ssIsCreditNote;
}
if (attributeKey == IdCreditNoteValue.Key.AsGuid) {
return ssCreditNoteValue;
}
if (attributeKey == IdIsVoucher.Key.AsGuid) {
return ssIsVoucher;
}
if (attributeKey == IdVoucherValue.Key.AsGuid) {
return ssVoucherValue;
}
if (attributeKey == IdIsNa.Key.AsGuid) {
return ssIsNa;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssIsAdvPayment = (bool) other.AttributeGet(IdIsAdvPayment);
ChangedAttributes[1] = other.ChangedAttributeGet(IdIsAdvPayment);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdIsAdvPayment);
ssAdvPaymentValue = (decimal) other.AttributeGet(IdAdvPaymentValue);
ChangedAttributes[2] = other.ChangedAttributeGet(IdAdvPaymentValue);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAdvPaymentValue);
ssIsCreditNote = (bool) other.AttributeGet(IdIsCreditNote);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIsCreditNote);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIsCreditNote);
ssCreditNoteValue = (decimal) other.AttributeGet(IdCreditNoteValue);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreditNoteValue);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreditNoteValue);
ssIsVoucher = (bool) other.AttributeGet(IdIsVoucher);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsVoucher);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsVoucher);
ssVoucherValue = (decimal) other.AttributeGet(IdVoucherValue);
ChangedAttributes[6] = other.ChangedAttributeGet(IdVoucherValue);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdVoucherValue);
ssIsNa = (bool) other.AttributeGet(IdIsNa);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsNa);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsNa);
}
} // EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord

/// <summary>
/// RecordList type <code>FolioExtendedList</code> that represents a record list of
///  <code>FolioExtended</code>
/// </summary>
public partial class RL_d4ffeffb74201b7d68373dafcf992368 : GenericRecordList<EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord>, IEnumerable, IEnumerator {

protected override EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord GetElementDefaultValue() {
return new EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord();
}

public T[] ToArray<T>(Func<EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d4ffeffb74201b7d68373dafcf992368 recordList, Func<EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d4ffeffb74201b7d68373dafcf992368(EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord[] array) {
  RL_d4ffeffb74201b7d68373dafcf992368 result = new RL_d4ffeffb74201b7d68373dafcf992368();
result.InnerFromArray(array);
    return result;
}

public static RL_d4ffeffb74201b7d68373dafcf992368 ToList<T>(T[] array, Func <T, EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord> converter) {
  RL_d4ffeffb74201b7d68373dafcf992368 result = new RL_d4ffeffb74201b7d68373dafcf992368();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d4ffeffb74201b7d68373dafcf992368 FromRestList<T>(RestList<T> restList, Func <T, EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord> converter) {
  RL_d4ffeffb74201b7d68373dafcf992368 result = new RL_d4ffeffb74201b7d68373dafcf992368();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d4ffeffb74201b7d68373dafcf992368() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord> NewList() {
return new RL_d4ffeffb74201b7d68373dafcf992368();
}


} // RL_d4ffeffb74201b7d68373dafcf992368
}
