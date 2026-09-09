using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderAccConcepts (ay+IW8rCf0m38JTzrkeJqA)
///  <code>EN_3e07a23619060cc7dc5624548803f5fdEntityRecord</code> that represent
/// s <code>OrderAccConcepts</code> <p>Description: Order AccConcepts</p>
/// </summary>
// Name: OrderAccConcepts
public partial struct EN_3e07a23619060cc7dc5624548803f5fdEntityRecord : ITypedRecord<EN_3e07a23619060cc7dc5624548803f5fdEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zDxcw1Hny0S2Z862UJ8U6Q");
internal static readonly GlobalObjectKey IdOrderAccountingId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xYX9kggTH0mwKlrlrB2xww");
internal static readonly GlobalObjectKey IdAccountingDataTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YXf9W3g4JkOfj2QVuodOnw");
internal static readonly GlobalObjectKey IdNumberOfPayments = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*797X_q1bxkqb0_1yND57ow");
internal static readonly GlobalObjectKey IdAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*y6X0odvfekmLQ2JKRIJVMQ");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S62mVusL3EGbwInf9R_kbQ");
internal static readonly GlobalObjectKey IdOrderAccConceptsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9fcokh7OHU+IRwSKAx1kdA");
internal static readonly GlobalObjectKey IdApplyForRequestProject = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kwSRUzeyIUqB5O7JNBnX5g");
internal static readonly GlobalObjectKey IdPaymentTermId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YgtR0kbceUSsfDlGO0mWnw");
internal static readonly GlobalObjectKey IdPaymentTermCustomDays = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0F+Iej6KNkCtxVwbBDaorQ");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0ZJceAmSVUGmRgSLYXWVFw");
internal static readonly GlobalObjectKey IdAdvancePaymentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*X617USnptEmtPHvm5fdnEA");
internal static readonly GlobalObjectKey IdPaymentDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IAfdpF96eEmsjQPNDP9zjw");
internal static readonly GlobalObjectKey IdPaymentMethodsIdToDelete = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ptAufvABhE2HY798nog7Fg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(14,true);
          _ssId = value;
      }
  }
}

private long _ssOrderAccountingId;
public long ssOrderAccountingId{
  get{
      return _ssOrderAccountingId;
  }
  set{
      if((_ssOrderAccountingId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrderAccountingId = value;
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

private long _ssOrderAccConceptsId;
public long ssOrderAccConceptsId{
  get{
      return _ssOrderAccConceptsId;
  }
  set{
      if((_ssOrderAccConceptsId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssOrderAccConceptsId = value;
      }
  }
}

private bool _ssApplyForRequestProject;
public bool ssApplyForRequestProject{
  get{
      return _ssApplyForRequestProject;
  }
  set{
      if((_ssApplyForRequestProject!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssApplyForRequestProject = value;
      }
  }
}

private long _ssPaymentTermId;
public long ssPaymentTermId{
  get{
      return _ssPaymentTermId;
  }
  set{
      if((_ssPaymentTermId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssPaymentTermId = value;
      }
  }
}

private int _ssPaymentTermCustomDays;
public int ssPaymentTermCustomDays{
  get{
      return _ssPaymentTermCustomDays;
  }
  set{
      if((_ssPaymentTermCustomDays!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssPaymentTermCustomDays = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssIsActive = value;
      }
  }
}

private int _ssAdvancePaymentTypeId;
public int ssAdvancePaymentTypeId{
  get{
      return _ssAdvancePaymentTypeId;
  }
  set{
      if((_ssAdvancePaymentTypeId!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssAdvancePaymentTypeId = value;
      }
  }
}

private DateTime _ssPaymentDate;
public DateTime ssPaymentDate{
  get{
      return _ssPaymentDate;
  }
  set{
      if((_ssPaymentDate!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssPaymentDate = value;
      }
  }
}

private long _ssPaymentMethodsIdToDelete;
public long ssPaymentMethodsIdToDelete{
  get{
      return _ssPaymentMethodsIdToDelete;
  }
  set{
      if((_ssPaymentMethodsIdToDelete!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssPaymentMethodsIdToDelete = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord() {
ChangedAttributes = new BitArray(14,true);
OptimizedAttributes = new BitArray(14,false);
_ssId = 0L;
_ssOrderAccountingId = 0L;
_ssAccountingDataTypeId = 0;
_ssNumberOfPayments = 0;
_ssAmount = 0.0M;
_ssCurrencyId = "";
_ssOrderAccConceptsId = 0L;
_ssApplyForRequestProject = false;
_ssPaymentTermId = 0L;
_ssPaymentTermCustomDays = 0;
_ssIsActive = false;
_ssAdvancePaymentTypeId = 0;
_ssPaymentDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssPaymentMethodsIdToDelete = 0L;
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
ssId = r.ReadLongInteger(index++, "OrderAccConcepts.Id", 0L);
ssOrderAccountingId = r.ReadEntityReferenceLongInteger(index++, "OrderAccConcepts.OrderAccountingId", 0L);
ssAccountingDataTypeId = r.ReadEntityReference(index++, "OrderAccConcepts.AccountingDataTypeId", 0);
ssNumberOfPayments = r.ReadInteger(index++, "OrderAccConcepts.NumberOfPayments", 0);
ssAmount = r.ReadDecimal(index++, "OrderAccConcepts.Amount", 0.0M);
ssCurrencyId = r.ReadEntityReferenceText(index++, "OrderAccConcepts.CurrencyId", "");
ssOrderAccConceptsId = r.ReadEntityReferenceLongInteger(index++, "OrderAccConcepts.OrderAccConceptsId", 0L);
ssApplyForRequestProject = r.ReadBoolean(index++, "OrderAccConcepts.ApplyForRequestProject", false);
ssPaymentTermId = r.ReadEntityReferenceLongInteger(index++, "OrderAccConcepts.PaymentTermId", 0L);
ssPaymentTermCustomDays = r.ReadInteger(index++, "OrderAccConcepts.PaymentTermCustomDays", 0);
ssIsActive = r.ReadBoolean(index++, "OrderAccConcepts.IsActive", false);
ssAdvancePaymentTypeId = r.ReadEntityReference(index++, "OrderAccConcepts.AdvancePaymentTypeId", 0);
ssPaymentDate = r.ReadDate(index++, "OrderAccConcepts.PaymentDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPaymentMethodsIdToDelete = r.ReadEntityReferenceLongInteger(index++, "OrderAccConcepts.PaymentMethodsIdToDelete", 0L);
ChangedAttributes = new BitArray(14,false);
OptimizedAttributes = new BitArray(14,false);
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
public void ReadIM(EN_3e07a23619060cc7dc5624548803f5fdEntityRecord r) {
this = r;
}


public static bool operator == (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord a, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderAccountingId != b.ssOrderAccountingId) return false;
if (a.ssAccountingDataTypeId != b.ssAccountingDataTypeId) return false;
if (a.ssNumberOfPayments != b.ssNumberOfPayments) return false;
if (a.ssAmount != b.ssAmount) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssOrderAccConceptsId != b.ssOrderAccConceptsId) return false;
if (a.ssApplyForRequestProject != b.ssApplyForRequestProject) return false;
if (a.ssPaymentTermId != b.ssPaymentTermId) return false;
if (a.ssPaymentTermCustomDays != b.ssPaymentTermCustomDays) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssAdvancePaymentTypeId != b.ssAdvancePaymentTypeId) return false;
if (a.ssPaymentDate != b.ssPaymentDate) return false;
if (a.ssPaymentMethodsIdToDelete != b.ssPaymentMethodsIdToDelete) return false;
return true;
}

public static bool operator != (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord a, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)) return false;
return (this == (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderAccountingId.GetHashCode()
 ^ ssAccountingDataTypeId.GetHashCode()
 ^ ssNumberOfPayments.GetHashCode()
 ^ ssAmount.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssOrderAccConceptsId.GetHashCode()
 ^ ssApplyForRequestProject.GetHashCode()
 ^ ssPaymentTermId.GetHashCode()
 ^ ssPaymentTermCustomDays.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssAdvancePaymentTypeId.GetHashCode()
 ^ ssPaymentDate.GetHashCode()
 ^ ssPaymentMethodsIdToDelete.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord Duplicate() {
EN_3e07a23619060cc7dc5624548803f5fdEntityRecord t;
t._ssId = this._ssId;
t._ssOrderAccountingId = this._ssOrderAccountingId;
t._ssAccountingDataTypeId = this._ssAccountingDataTypeId;
t._ssNumberOfPayments = this._ssNumberOfPayments;
t._ssAmount = this._ssAmount;
t._ssCurrencyId = this._ssCurrencyId;
t._ssOrderAccConceptsId = this._ssOrderAccConceptsId;
t._ssApplyForRequestProject = this._ssApplyForRequestProject;
t._ssPaymentTermId = this._ssPaymentTermId;
t._ssPaymentTermCustomDays = this._ssPaymentTermCustomDays;
t._ssIsActive = this._ssIsActive;
t._ssAdvancePaymentTypeId = this._ssAdvancePaymentTypeId;
t._ssPaymentDate = this._ssPaymentDate;
t._ssPaymentMethodsIdToDelete = this._ssPaymentMethodsIdToDelete;
t.ChangedAttributes = new BitArray(14);
t.OptimizedAttributes = new BitArray(14);
for(int i = 0; i < 14; i++){
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
} else if (head == "orderaccountingid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccountingId")) variable.Value = ssOrderAccountingId; else variable.Optimized = true;
} else if (head == "accountingdatatypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDataTypeId")) variable.Value = ssAccountingDataTypeId; else variable.Optimized = true;
} else if (head == "numberofpayments") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NumberOfPayments")) variable.Value = ssNumberOfPayments; else variable.Optimized = true;
} else if (head == "amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amount")) variable.Value = ssAmount; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "orderaccconceptsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConceptsId")) variable.Value = ssOrderAccConceptsId; else variable.Optimized = true;
} else if (head == "applyforrequestproject") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplyForRequestProject")) variable.Value = ssApplyForRequestProject; else variable.Optimized = true;
} else if (head == "paymenttermid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTermId")) variable.Value = ssPaymentTermId; else variable.Optimized = true;
} else if (head == "paymenttermcustomdays") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTermCustomDays")) variable.Value = ssPaymentTermCustomDays; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "advancepaymenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvancePaymentTypeId")) variable.Value = ssAdvancePaymentTypeId; else variable.Optimized = true;
} else if (head == "paymentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDate")) variable.Value = ssPaymentDate; else variable.Optimized = true;
} else if (head == "paymentmethodsidtodelete") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethodsIdToDelete")) variable.Value = ssPaymentMethodsIdToDelete; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrderAccountingId)) {
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
if (key.Equals(IdOrderAccConceptsId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdApplyForRequestProject)) {
return ChangedAttributes[7];
}
if (key.Equals(IdPaymentTermId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdPaymentTermCustomDays)) {
return ChangedAttributes[9];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[10];
}
if (key.Equals(IdAdvancePaymentTypeId)) {
return ChangedAttributes[11];
}
if (key.Equals(IdPaymentDate)) {
return ChangedAttributes[12];
}
if (key.Equals(IdPaymentMethodsIdToDelete)) {
return ChangedAttributes[13];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrderAccountingId)) {
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
if (key.Equals(IdOrderAccConceptsId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdApplyForRequestProject)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdPaymentTermId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdPaymentTermCustomDays)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdAdvancePaymentTypeId)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdPaymentDate)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdPaymentMethodsIdToDelete)) {
return OptimizedAttributes[13];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdOrderAccountingId) {
return ssOrderAccountingId;
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
if (key == IdOrderAccConceptsId) {
return ssOrderAccConceptsId;
}
if (key == IdApplyForRequestProject) {
return ssApplyForRequestProject;
}
if (key == IdPaymentTermId) {
return ssPaymentTermId;
}
if (key == IdPaymentTermCustomDays) {
return ssPaymentTermCustomDays;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdAdvancePaymentTypeId) {
return ssAdvancePaymentTypeId;
}
if (key == IdPaymentDate) {
return ssPaymentDate;
}
if (key == IdPaymentMethodsIdToDelete) {
return ssPaymentMethodsIdToDelete;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdOrderAccountingId.Key.AsGuid) {
return ssOrderAccountingId;
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
if (attributeKey == IdOrderAccConceptsId.Key.AsGuid) {
return ssOrderAccConceptsId;
}
if (attributeKey == IdApplyForRequestProject.Key.AsGuid) {
return ssApplyForRequestProject;
}
if (attributeKey == IdPaymentTermId.Key.AsGuid) {
return ssPaymentTermId;
}
if (attributeKey == IdPaymentTermCustomDays.Key.AsGuid) {
return ssPaymentTermCustomDays;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdAdvancePaymentTypeId.Key.AsGuid) {
return ssAdvancePaymentTypeId;
}
if (attributeKey == IdPaymentDate.Key.AsGuid) {
return ssPaymentDate;
}
if (attributeKey == IdPaymentMethodsIdToDelete.Key.AsGuid) {
return ssPaymentMethodsIdToDelete;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(14);
OptimizedAttributes = new BitArray(14);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderAccountingId = (long) other.AttributeGet(IdOrderAccountingId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderAccountingId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderAccountingId);
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
ssOrderAccConceptsId = (long) other.AttributeGet(IdOrderAccConceptsId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdOrderAccConceptsId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdOrderAccConceptsId);
ssApplyForRequestProject = (bool) other.AttributeGet(IdApplyForRequestProject);
ChangedAttributes[7] = other.ChangedAttributeGet(IdApplyForRequestProject);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdApplyForRequestProject);
ssPaymentTermId = (long) other.AttributeGet(IdPaymentTermId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdPaymentTermId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdPaymentTermId);
ssPaymentTermCustomDays = (int) other.AttributeGet(IdPaymentTermCustomDays);
ChangedAttributes[9] = other.ChangedAttributeGet(IdPaymentTermCustomDays);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdPaymentTermCustomDays);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[10] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdIsActive);
ssAdvancePaymentTypeId = (int) other.AttributeGet(IdAdvancePaymentTypeId);
ChangedAttributes[11] = other.ChangedAttributeGet(IdAdvancePaymentTypeId);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdAdvancePaymentTypeId);
ssPaymentDate = (DateTime) other.AttributeGet(IdPaymentDate);
ChangedAttributes[12] = other.ChangedAttributeGet(IdPaymentDate);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdPaymentDate);
ssPaymentMethodsIdToDelete = (long) other.AttributeGet(IdPaymentMethodsIdToDelete);
ChangedAttributes[13] = other.ChangedAttributeGet(IdPaymentMethodsIdToDelete);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdPaymentMethodsIdToDelete);
}
} // EN_3e07a23619060cc7dc5624548803f5fdEntityRecord

/// <summary>
/// RecordList type <code>OrderAccConceptsList</code> that represents a record list of
///  <code>OrderAccConcepts</code>
/// </summary>
public partial class RL_8927ac1c2e0370738b28382fb988b5ee : GenericRecordList<EN_3e07a23619060cc7dc5624548803f5fdEntityRecord>, IEnumerable, IEnumerator {

protected override EN_3e07a23619060cc7dc5624548803f5fdEntityRecord GetElementDefaultValue() {
return new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
}

public T[] ToArray<T>(Func<EN_3e07a23619060cc7dc5624548803f5fdEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8927ac1c2e0370738b28382fb988b5ee recordList, Func<EN_3e07a23619060cc7dc5624548803f5fdEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8927ac1c2e0370738b28382fb988b5ee(EN_3e07a23619060cc7dc5624548803f5fdEntityRecord[] array) {
  RL_8927ac1c2e0370738b28382fb988b5ee result = new RL_8927ac1c2e0370738b28382fb988b5ee();
result.InnerFromArray(array);
    return result;
}

public static RL_8927ac1c2e0370738b28382fb988b5ee ToList<T>(T[] array, Func <T, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord> converter) {
  RL_8927ac1c2e0370738b28382fb988b5ee result = new RL_8927ac1c2e0370738b28382fb988b5ee();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8927ac1c2e0370738b28382fb988b5ee FromRestList<T>(RestList<T> restList, Func <T, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord> converter) {
  RL_8927ac1c2e0370738b28382fb988b5ee result = new RL_8927ac1c2e0370738b28382fb988b5ee();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8927ac1c2e0370738b28382fb988b5ee() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_3e07a23619060cc7dc5624548803f5fdEntityRecord> NewList() {
return new RL_8927ac1c2e0370738b28382fb988b5ee();
}


} // RL_8927ac1c2e0370738b28382fb988b5ee
}
