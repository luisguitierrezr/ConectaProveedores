using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionContractFile (BSOZHUSyOkSXZDYX2zzCOw)
///  <code>EN_aeab0089a9236dfc6c684ea98f650647EntityRecord</code> that represent
/// s <code>RequisitionContractFile</code> <p>Description: Entity that holds Requisition Contract
///  File.</p>
/// </summary>
// Name: RequisitionContractFile
public partial struct EN_aeab0089a9236dfc6c684ea98f650647EntityRecord : ITypedRecord<EN_aeab0089a9236dfc6c684ea98f650647EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MpCITuNjOUKt19ZapCvmsw");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*L0XFmf8vJkCoMWPR_dgQHw");
internal static readonly GlobalObjectKey IdRequisitionFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mykKVhgeCEGMZNegVnh0WA");
internal static readonly GlobalObjectKey IdContractFileTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vheOO_8viEe+UANJYRWqSA");
internal static readonly GlobalObjectKey IdAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PxIfUpUYr0+ZCQyDEFR4mg");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3mcO_Zd_DEuM+PHjKvTQJg");
internal static readonly GlobalObjectKey IdDepositTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_80Yp80qAE+aVRpJn1go2Q");
internal static readonly GlobalObjectKey IdInsuranceTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iIHA7c72u0+IRm2o7N9yag");
internal static readonly GlobalObjectKey IdAdvancePaymentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*D2AVQReVZU2q1uubaat2YA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(9,true);
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

private long _ssRequisitionFileId;
public long ssRequisitionFileId{
  get{
      return _ssRequisitionFileId;
  }
  set{
      if((_ssRequisitionFileId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssRequisitionFileId = value;
      }
  }
}

private int _ssContractFileTypeId;
public int ssContractFileTypeId{
  get{
      return _ssContractFileTypeId;
  }
  set{
      if((_ssContractFileTypeId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssContractFileTypeId = value;
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

private string _ssCurrencyId;
public string ssCurrencyId{
  get{
      return _ssCurrencyId;
  }
  set{
      if((_ssCurrencyId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCurrencyId = value;
      }
  }
}

private int _ssDepositTypeId;
public int ssDepositTypeId{
  get{
      return _ssDepositTypeId;
  }
  set{
      if((_ssDepositTypeId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssDepositTypeId = value;
      }
  }
}

private int _ssInsuranceTypeId;
public int ssInsuranceTypeId{
  get{
      return _ssInsuranceTypeId;
  }
  set{
      if((_ssInsuranceTypeId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssInsuranceTypeId = value;
      }
  }
}

private int _ssAdvancePaymentTypeId;
public int ssAdvancePaymentTypeId{
  get{
      return _ssAdvancePaymentTypeId;
  }
  set{
      if((_ssAdvancePaymentTypeId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssAdvancePaymentTypeId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord() {
ChangedAttributes = new BitArray(9,true);
OptimizedAttributes = new BitArray(9,false);
_ssId = 0L;
_ssRequisitionId = 0L;
_ssRequisitionFileId = 0L;
_ssContractFileTypeId = 0;
_ssAmount = 0.0M;
_ssCurrencyId = "";
_ssDepositTypeId = 0;
_ssInsuranceTypeId = 0;
_ssAdvancePaymentTypeId = 0;
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
ssId = r.ReadLongInteger(index++, "RequisitionContractFile.Id", 0L);
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionContractFile.RequisitionId", 0L);
ssRequisitionFileId = r.ReadEntityReferenceLongInteger(index++, "RequisitionContractFile.RequisitionFileId", 0L);
ssContractFileTypeId = r.ReadEntityReference(index++, "RequisitionContractFile.ContractFileTypeId", 0);
ssAmount = r.ReadDecimal(index++, "RequisitionContractFile.Amount", 0.0M);
ssCurrencyId = r.ReadEntityReferenceText(index++, "RequisitionContractFile.CurrencyId", "");
ssDepositTypeId = r.ReadEntityReference(index++, "RequisitionContractFile.DepositTypeId", 0);
ssInsuranceTypeId = r.ReadEntityReference(index++, "RequisitionContractFile.InsuranceTypeId", 0);
ssAdvancePaymentTypeId = r.ReadEntityReference(index++, "RequisitionContractFile.AdvancePaymentTypeId", 0);
ChangedAttributes = new BitArray(9,false);
OptimizedAttributes = new BitArray(9,false);
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
public void ReadIM(EN_aeab0089a9236dfc6c684ea98f650647EntityRecord r) {
this = r;
}


public static bool operator == (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord a, EN_aeab0089a9236dfc6c684ea98f650647EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssRequisitionFileId != b.ssRequisitionFileId) return false;
if (a.ssContractFileTypeId != b.ssContractFileTypeId) return false;
if (a.ssAmount != b.ssAmount) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssDepositTypeId != b.ssDepositTypeId) return false;
if (a.ssInsuranceTypeId != b.ssInsuranceTypeId) return false;
if (a.ssAdvancePaymentTypeId != b.ssAdvancePaymentTypeId) return false;
return true;
}

public static bool operator != (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord a, EN_aeab0089a9236dfc6c684ea98f650647EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)) return false;
return (this == (EN_aeab0089a9236dfc6c684ea98f650647EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssRequisitionFileId.GetHashCode()
 ^ ssContractFileTypeId.GetHashCode()
 ^ ssAmount.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssDepositTypeId.GetHashCode()
 ^ ssInsuranceTypeId.GetHashCode()
 ^ ssAdvancePaymentTypeId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_aeab0089a9236dfc6c684ea98f650647EntityRecord Duplicate() {
EN_aeab0089a9236dfc6c684ea98f650647EntityRecord t;
t._ssId = this._ssId;
t._ssRequisitionId = this._ssRequisitionId;
t._ssRequisitionFileId = this._ssRequisitionFileId;
t._ssContractFileTypeId = this._ssContractFileTypeId;
t._ssAmount = this._ssAmount;
t._ssCurrencyId = this._ssCurrencyId;
t._ssDepositTypeId = this._ssDepositTypeId;
t._ssInsuranceTypeId = this._ssInsuranceTypeId;
t._ssAdvancePaymentTypeId = this._ssAdvancePaymentTypeId;
t.ChangedAttributes = new BitArray(9);
t.OptimizedAttributes = new BitArray(9);
for(int i = 0; i < 9; i++){
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
} else if (head == "requisitionfileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFileId")) variable.Value = ssRequisitionFileId; else variable.Optimized = true;
} else if (head == "contractfiletypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractFileTypeId")) variable.Value = ssContractFileTypeId; else variable.Optimized = true;
} else if (head == "amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amount")) variable.Value = ssAmount; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "deposittypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DepositTypeId")) variable.Value = ssDepositTypeId; else variable.Optimized = true;
} else if (head == "insurancetypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InsuranceTypeId")) variable.Value = ssInsuranceTypeId; else variable.Optimized = true;
} else if (head == "advancepaymenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvancePaymentTypeId")) variable.Value = ssAdvancePaymentTypeId; else variable.Optimized = true;
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
if (key.Equals(IdRequisitionFileId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdContractFileTypeId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdAmount)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCurrencyId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdDepositTypeId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdInsuranceTypeId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdAdvancePaymentTypeId)) {
return ChangedAttributes[8];
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
if (key.Equals(IdRequisitionFileId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdContractFileTypeId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdAmount)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCurrencyId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdDepositTypeId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdInsuranceTypeId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdAdvancePaymentTypeId)) {
return OptimizedAttributes[8];
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
if (key == IdRequisitionFileId) {
return ssRequisitionFileId;
}
if (key == IdContractFileTypeId) {
return ssContractFileTypeId;
}
if (key == IdAmount) {
return ssAmount;
}
if (key == IdCurrencyId) {
return ssCurrencyId;
}
if (key == IdDepositTypeId) {
return ssDepositTypeId;
}
if (key == IdInsuranceTypeId) {
return ssInsuranceTypeId;
}
if (key == IdAdvancePaymentTypeId) {
return ssAdvancePaymentTypeId;
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
if (attributeKey == IdRequisitionFileId.Key.AsGuid) {
return ssRequisitionFileId;
}
if (attributeKey == IdContractFileTypeId.Key.AsGuid) {
return ssContractFileTypeId;
}
if (attributeKey == IdAmount.Key.AsGuid) {
return ssAmount;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssCurrencyId;
}
if (attributeKey == IdDepositTypeId.Key.AsGuid) {
return ssDepositTypeId;
}
if (attributeKey == IdInsuranceTypeId.Key.AsGuid) {
return ssInsuranceTypeId;
}
if (attributeKey == IdAdvancePaymentTypeId.Key.AsGuid) {
return ssAdvancePaymentTypeId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(9);
OptimizedAttributes = new BitArray(9);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRequisitionId);
ssRequisitionFileId = (long) other.AttributeGet(IdRequisitionFileId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdRequisitionFileId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRequisitionFileId);
ssContractFileTypeId = (int) other.AttributeGet(IdContractFileTypeId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdContractFileTypeId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdContractFileTypeId);
ssAmount = (decimal) other.AttributeGet(IdAmount);
ChangedAttributes[4] = other.ChangedAttributeGet(IdAmount);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdAmount);
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCurrencyId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCurrencyId);
ssDepositTypeId = (int) other.AttributeGet(IdDepositTypeId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdDepositTypeId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdDepositTypeId);
ssInsuranceTypeId = (int) other.AttributeGet(IdInsuranceTypeId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdInsuranceTypeId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdInsuranceTypeId);
ssAdvancePaymentTypeId = (int) other.AttributeGet(IdAdvancePaymentTypeId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdAdvancePaymentTypeId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdAdvancePaymentTypeId);
}
} // EN_aeab0089a9236dfc6c684ea98f650647EntityRecord

/// <summary>
/// RecordList type <code>RequisitionContractFileList</code> that represents a record list of
///  <code>RequisitionContractFile</code>
/// </summary>
public partial class RL_bf044edd6334a5564934f87f1d33b9ba : GenericRecordList<EN_aeab0089a9236dfc6c684ea98f650647EntityRecord>, IEnumerable, IEnumerator {

protected override EN_aeab0089a9236dfc6c684ea98f650647EntityRecord GetElementDefaultValue() {
return new EN_aeab0089a9236dfc6c684ea98f650647EntityRecord();
}

public T[] ToArray<T>(Func<EN_aeab0089a9236dfc6c684ea98f650647EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bf044edd6334a5564934f87f1d33b9ba recordList, Func<EN_aeab0089a9236dfc6c684ea98f650647EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bf044edd6334a5564934f87f1d33b9ba(EN_aeab0089a9236dfc6c684ea98f650647EntityRecord[] array) {
  RL_bf044edd6334a5564934f87f1d33b9ba result = new RL_bf044edd6334a5564934f87f1d33b9ba();
result.InnerFromArray(array);
    return result;
}

public static RL_bf044edd6334a5564934f87f1d33b9ba ToList<T>(T[] array, Func <T, EN_aeab0089a9236dfc6c684ea98f650647EntityRecord> converter) {
  RL_bf044edd6334a5564934f87f1d33b9ba result = new RL_bf044edd6334a5564934f87f1d33b9ba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bf044edd6334a5564934f87f1d33b9ba FromRestList<T>(RestList<T> restList, Func <T, EN_aeab0089a9236dfc6c684ea98f650647EntityRecord> converter) {
  RL_bf044edd6334a5564934f87f1d33b9ba result = new RL_bf044edd6334a5564934f87f1d33b9ba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bf044edd6334a5564934f87f1d33b9ba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_aeab0089a9236dfc6c684ea98f650647EntityRecord> NewList() {
return new RL_bf044edd6334a5564934f87f1d33b9ba();
}


} // RL_bf044edd6334a5564934f87f1d33b9ba
}
