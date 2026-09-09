using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] RequisitionAccConcepts (aQKKPcY0YkGAG78zxrOYdg)
///  <code>EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord</code> that represent
/// s <code>RequisitionAccConcepts</code> <p>Description: Entity that holds Requisition Accounting
///  Concepts.</p>
/// </summary>
// Name: RequisitionAccConcepts
public partial struct EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord : ITypedRecord<EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KtDCDY8BZ0C0sjmLQoG5mg");
internal static readonly GlobalObjectKey IdRequisitionAccountingId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bQ++WauVpEuF4Pq2ByzE+Q");
internal static readonly GlobalObjectKey IdAccountingDataTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KWdNSlxozUilNy6nIvF_Eg");
internal static readonly GlobalObjectKey IdNumberOfPayments = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+NEvN_UMAkW0pfYE93oC3w");
internal static readonly GlobalObjectKey IdAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ODP2lYJ0Ek6Glfztm6kZqA");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YoBUTeRxz0GVy+zIJnh+jQ");
internal static readonly GlobalObjectKey IdRequisitionAccConceptsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8N_Eo+8GqUy9mSacIuPv1g");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gixXv2Y+NkOB5zL78fUE_w");

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

private long _ssRequisitionAccountingId;
public long ssRequisitionAccountingId{
  get{
      return _ssRequisitionAccountingId;
  }
  set{
      if((_ssRequisitionAccountingId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssRequisitionAccountingId = value;
      }
  }
}

private int _ssAccountingDataTypeId;
public int ssAccountingDataTypeId{
  get{
      return _ssAccountingDataTypeId;
  }
  set{
      if((_ssAccountingDataTypeId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssAccountingDataTypeId = value;
      }
  }
}

private int _ssNumberOfPayments;
public int ssNumberOfPayments{
  get{
      return _ssNumberOfPayments;
  }
  set{
      if((_ssNumberOfPayments!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssNumberOfPayments = value;
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

private long _ssRequisitionAccConceptsId;
public long ssRequisitionAccConceptsId{
  get{
      return _ssRequisitionAccConceptsId;
  }
  set{
      if((_ssRequisitionAccConceptsId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssRequisitionAccConceptsId = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsActive = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssRequisitionAccountingId = 0L;
_ssAccountingDataTypeId = 0;
_ssNumberOfPayments = 0;
_ssAmount = 0.0M;
_ssCurrencyId = "";
_ssRequisitionAccConceptsId = 0L;
_ssIsActive = false;
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
ssId = r.ReadLongInteger(index++, "RequisitionAccConcepts.Id", 0L);
ssRequisitionAccountingId = r.ReadEntityReferenceLongInteger(index++, "RequisitionAccConcepts.RequisitionAccountingId", 0L);
ssAccountingDataTypeId = r.ReadEntityReference(index++, "RequisitionAccConcepts.AccountingDataTypeId", 0);
ssNumberOfPayments = r.ReadInteger(index++, "RequisitionAccConcepts.NumberOfPayments", 0);
ssAmount = r.ReadDecimal(index++, "RequisitionAccConcepts.Amount", 0.0M);
ssCurrencyId = r.ReadEntityReferenceText(index++, "RequisitionAccConcepts.CurrencyId", "");
ssRequisitionAccConceptsId = r.ReadEntityReferenceLongInteger(index++, "RequisitionAccConcepts.RequisitionAccConceptsId", 0L);
ssIsActive = r.ReadBoolean(index++, "RequisitionAccConcepts.IsActive", false);
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
public void ReadIM(EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord r) {
this = r;
}


public static bool operator == (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord a, EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssRequisitionAccountingId != b.ssRequisitionAccountingId) return false;
if (a.ssAccountingDataTypeId != b.ssAccountingDataTypeId) return false;
if (a.ssNumberOfPayments != b.ssNumberOfPayments) return false;
if (a.ssAmount != b.ssAmount) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssRequisitionAccConceptsId != b.ssRequisitionAccConceptsId) return false;
if (a.ssIsActive != b.ssIsActive) return false;
return true;
}

public static bool operator != (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord a, EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord)) return false;
return (this == (EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssRequisitionAccountingId.GetHashCode()
 ^ ssAccountingDataTypeId.GetHashCode()
 ^ ssNumberOfPayments.GetHashCode()
 ^ ssAmount.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssRequisitionAccConceptsId.GetHashCode()
 ^ ssIsActive.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord Duplicate() {
EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord t;
t._ssId = this._ssId;
t._ssRequisitionAccountingId = this._ssRequisitionAccountingId;
t._ssAccountingDataTypeId = this._ssAccountingDataTypeId;
t._ssNumberOfPayments = this._ssNumberOfPayments;
t._ssAmount = this._ssAmount;
t._ssCurrencyId = this._ssCurrencyId;
t._ssRequisitionAccConceptsId = this._ssRequisitionAccConceptsId;
t._ssIsActive = this._ssIsActive;
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
} else if (head == "requisitionaccountingid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccountingId")) variable.Value = ssRequisitionAccountingId; else variable.Optimized = true;
} else if (head == "accountingdatatypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDataTypeId")) variable.Value = ssAccountingDataTypeId; else variable.Optimized = true;
} else if (head == "numberofpayments") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NumberOfPayments")) variable.Value = ssNumberOfPayments; else variable.Optimized = true;
} else if (head == "amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amount")) variable.Value = ssAmount; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "requisitionaccconceptsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccConceptsId")) variable.Value = ssRequisitionAccConceptsId; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdRequisitionAccountingId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdAccountingDataTypeId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdNumberOfPayments)) {
return ChangedAttributes[3];
}
if (key.Equals(IdAmount)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCurrencyId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdRequisitionAccConceptsId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[7];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdRequisitionAccountingId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdAccountingDataTypeId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdNumberOfPayments)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdAmount)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCurrencyId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdRequisitionAccConceptsId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[7];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdRequisitionAccountingId) {
return ssRequisitionAccountingId;
}
if (key == IdAccountingDataTypeId) {
return ssAccountingDataTypeId;
}
if (key == IdNumberOfPayments) {
return ssNumberOfPayments;
}
if (key == IdAmount) {
return ssAmount;
}
if (key == IdCurrencyId) {
return ssCurrencyId;
}
if (key == IdRequisitionAccConceptsId) {
return ssRequisitionAccConceptsId;
}
if (key == IdIsActive) {
return ssIsActive;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdRequisitionAccountingId.Key.AsGuid) {
return ssRequisitionAccountingId;
}
if (attributeKey == IdAccountingDataTypeId.Key.AsGuid) {
return ssAccountingDataTypeId;
}
if (attributeKey == IdNumberOfPayments.Key.AsGuid) {
return ssNumberOfPayments;
}
if (attributeKey == IdAmount.Key.AsGuid) {
return ssAmount;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssCurrencyId;
}
if (attributeKey == IdRequisitionAccConceptsId.Key.AsGuid) {
return ssRequisitionAccConceptsId;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
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
ssRequisitionAccountingId = (long) other.AttributeGet(IdRequisitionAccountingId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdRequisitionAccountingId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdRequisitionAccountingId);
ssAccountingDataTypeId = (int) other.AttributeGet(IdAccountingDataTypeId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdAccountingDataTypeId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAccountingDataTypeId);
ssNumberOfPayments = (int) other.AttributeGet(IdNumberOfPayments);
ChangedAttributes[3] = other.ChangedAttributeGet(IdNumberOfPayments);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdNumberOfPayments);
ssAmount = (decimal) other.AttributeGet(IdAmount);
ChangedAttributes[4] = other.ChangedAttributeGet(IdAmount);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdAmount);
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCurrencyId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCurrencyId);
ssRequisitionAccConceptsId = (long) other.AttributeGet(IdRequisitionAccConceptsId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdRequisitionAccConceptsId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdRequisitionAccConceptsId);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsActive);
}
} // EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord

/// <summary>
/// RecordList type <code>RequisitionAccConceptsList</code> that represents a record list of
///  <code>RequisitionAccConcepts</code>
/// </summary>
public partial class RL_eb1e4f883a237aab70c23418de71281c : GenericRecordList<EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord>, IEnumerable, IEnumerator {

protected override EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord GetElementDefaultValue() {
return new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord();
}

public T[] ToArray<T>(Func<EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eb1e4f883a237aab70c23418de71281c recordList, Func<EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eb1e4f883a237aab70c23418de71281c(EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord[] array) {
  RL_eb1e4f883a237aab70c23418de71281c result = new RL_eb1e4f883a237aab70c23418de71281c();
result.InnerFromArray(array);
    return result;
}

public static RL_eb1e4f883a237aab70c23418de71281c ToList<T>(T[] array, Func <T, EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord> converter) {
  RL_eb1e4f883a237aab70c23418de71281c result = new RL_eb1e4f883a237aab70c23418de71281c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eb1e4f883a237aab70c23418de71281c FromRestList<T>(RestList<T> restList, Func <T, EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord> converter) {
  RL_eb1e4f883a237aab70c23418de71281c result = new RL_eb1e4f883a237aab70c23418de71281c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eb1e4f883a237aab70c23418de71281c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord> NewList() {
return new RL_eb1e4f883a237aab70c23418de71281c();
}


} // RL_eb1e4f883a237aab70c23418de71281c
}
