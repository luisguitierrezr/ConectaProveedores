using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] Folio (dNiKJzysv0+zMg9RKAnV+A)
///  <code>EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord</code> that represents <code>Folio</code
/// > <p>Description: </p>
/// </summary>
// Name: Folio
public partial struct EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord : ITypedRecord<EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xYAqvYY290WilUoeOIC7KQ");
internal static readonly GlobalObjectKey IdIsDraft = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uHkzA1PHNUuDz5xr8YkZbg");
internal static readonly GlobalObjectKey IdFolioNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jdHe7iqTMEm4CIOYwVU0UA");
internal static readonly GlobalObjectKey IdCanProveedorCancel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eff3I_mj6UafKCjxrGRR+g");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*K8nF5BPkyEmiEctCRJ228w");
internal static readonly GlobalObjectKey IdSupplierId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7coM_mZuo0Kr3gac4dTw9Q");
internal static readonly GlobalObjectKey IdCompanyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jbPirNCHb0ayHXYtz5nB4w");
internal static readonly GlobalObjectKey IdFolioStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fhTZMZgJBECP+daJsDY9pA");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hzKPYPTydE+TapnXlxTfbg");
internal static readonly GlobalObjectKey IdTotalIVA_Amount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S2_irFPIxUO6bzqfoo1ulQ");
internal static readonly GlobalObjectKey IdPartialAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*I3OVL_GK3EaXaCZp2Be+ng");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TJ17YAeDg0y0C3WKm3Fz8g");
internal static readonly GlobalObjectKey IdFirstApproverUserId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IO0CJnSQaEiSTurJP0OIBg");
internal static readonly GlobalObjectKey IdApprovalProcessTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WUa7WhPOq0+0uGD8caZU_g");
internal static readonly GlobalObjectKey IdSAPEntryError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*w0iJusYBZU6EbDaI8vs9Tw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sNOBie9chEWUQ5BKtegRJQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mq6VCQJJYke10FDjxxZglQ");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*d1kMJrdxuEiRsvlNG5rF0A");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TAsPJ1b4lEq2npPgrvARZA");
internal static readonly GlobalObjectKey IdMinuteSelected = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9qF+svNKGketh8W5bJXE7g");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(20,true);
          _ssId = value;
      }
  }
}

private bool _ssIsDraft;
public bool ssIsDraft{
  get{
      return _ssIsDraft;
  }
  set{
      if((_ssIsDraft!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssIsDraft = value;
      }
  }
}

private string _ssFolioNumber;
public string ssFolioNumber{
  get{
      return _ssFolioNumber;
  }
  set{
      if((_ssFolioNumber!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssFolioNumber = value;
      }
  }
}

private bool _ssCanProveedorCancel;
public bool ssCanProveedorCancel{
  get{
      return _ssCanProveedorCancel;
  }
  set{
      if((_ssCanProveedorCancel!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCanProveedorCancel = value;
      }
  }
}

private long _ssOrderId;
public long ssOrderId{
  get{
      return _ssOrderId;
  }
  set{
      if((_ssOrderId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssOrderId = value;
      }
  }
}

private long _ssSupplierId;
public long ssSupplierId{
  get{
      return _ssSupplierId;
  }
  set{
      if((_ssSupplierId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssSupplierId = value;
      }
  }
}

private long _ssCompanyId;
public long ssCompanyId{
  get{
      return _ssCompanyId;
  }
  set{
      if((_ssCompanyId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCompanyId = value;
      }
  }
}

private int _ssFolioStatusId;
public int ssFolioStatusId{
  get{
      return _ssFolioStatusId;
  }
  set{
      if((_ssFolioStatusId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssFolioStatusId = value;
      }
  }
}

private decimal _ssTotalAmount;
public decimal ssTotalAmount{
  get{
      return _ssTotalAmount;
  }
  set{
      if((_ssTotalAmount!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssTotalAmount = value;
      }
  }
}

private decimal _ssTotalIVA_Amount;
public decimal ssTotalIVA_Amount{
  get{
      return _ssTotalIVA_Amount;
  }
  set{
      if((_ssTotalIVA_Amount!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssTotalIVA_Amount = value;
      }
  }
}

private decimal _ssPartialAmount;
public decimal ssPartialAmount{
  get{
      return _ssPartialAmount;
  }
  set{
      if((_ssPartialAmount!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssPartialAmount = value;
      }
  }
}

private string _ssCurrencyId;
public string ssCurrencyId{
  get{
      return _ssCurrencyId;
  }
  set{
      if((_ssCurrencyId!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssCurrencyId = value;
      }
  }
}

private string _ssFirstApproverUserId;
public string ssFirstApproverUserId{
  get{
      return _ssFirstApproverUserId;
  }
  set{
      if((_ssFirstApproverUserId!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssFirstApproverUserId = value;
      }
  }
}

private int _ssApprovalProcessTypeId;
public int ssApprovalProcessTypeId{
  get{
      return _ssApprovalProcessTypeId;
  }
  set{
      if((_ssApprovalProcessTypeId!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssApprovalProcessTypeId = value;
      }
  }
}

private string _ssSAPEntryError;
public string ssSAPEntryError{
  get{
      return _ssSAPEntryError;
  }
  set{
      if((_ssSAPEntryError!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssSAPEntryError = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssUpdatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssUpdatedOn = value;
      }
  }
}

private int _ssMinuteSelected;
public int ssMinuteSelected{
  get{
      return _ssMinuteSelected;
  }
  set{
      if((_ssMinuteSelected!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssMinuteSelected = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord() {
ChangedAttributes = new BitArray(20,true);
OptimizedAttributes = new BitArray(20,false);
_ssId = 0L;
_ssIsDraft = false;
_ssFolioNumber = "";
_ssCanProveedorCancel = false;
_ssOrderId = 0L;
_ssSupplierId = 0L;
_ssCompanyId = 0L;
_ssFolioStatusId = 0;
_ssTotalAmount = 0.0M;
_ssTotalIVA_Amount = 0.0M;
_ssPartialAmount = 0.0M;
_ssCurrencyId = "";
_ssFirstApproverUserId = "";
_ssApprovalProcessTypeId = 0;
_ssSAPEntryError = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssMinuteSelected = 0;
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
ssId = r.ReadLongInteger(index++, "Folio.Id", 0L);
ssIsDraft = r.ReadBoolean(index++, "Folio.IsDraft", false);
ssFolioNumber = r.ReadText(index++, "Folio.FolioNumber", "");
ssCanProveedorCancel = r.ReadBoolean(index++, "Folio.CanProveedorCancel", false);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "Folio.OrderId", 0L);
ssSupplierId = r.ReadEntityReferenceLongInteger(index++, "Folio.SupplierId", 0L);
ssCompanyId = r.ReadEntityReferenceLongInteger(index++, "Folio.CompanyId", 0L);
ssFolioStatusId = r.ReadEntityReference(index++, "Folio.FolioStatusId", 0);
ssTotalAmount = r.ReadDecimal(index++, "Folio.TotalAmount", 0.0M);
ssTotalIVA_Amount = r.ReadDecimal(index++, "Folio.TotalIVA_Amount", 0.0M);
ssPartialAmount = r.ReadDecimal(index++, "Folio.PartialAmount", 0.0M);
ssCurrencyId = r.ReadEntityReferenceText(index++, "Folio.CurrencyId", "");
ssFirstApproverUserId = r.ReadEntityReferenceText(index++, "Folio.FirstApproverUserId", "");
ssApprovalProcessTypeId = r.ReadEntityReference(index++, "Folio.ApprovalProcessTypeId", 0);
ssSAPEntryError = r.ReadText(index++, "Folio.SAPEntryError", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "Folio.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "Folio.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Folio.UpdatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "Folio.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMinuteSelected = r.ReadInteger(index++, "Folio.MinuteSelected", 0);
ChangedAttributes = new BitArray(20,false);
OptimizedAttributes = new BitArray(20,false);
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
public void ReadIM(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord r) {
this = r;
}


public static bool operator == (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord a, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssIsDraft != b.ssIsDraft) return false;
if (a.ssFolioNumber != b.ssFolioNumber) return false;
if (a.ssCanProveedorCancel != b.ssCanProveedorCancel) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssSupplierId != b.ssSupplierId) return false;
if (a.ssCompanyId != b.ssCompanyId) return false;
if (a.ssFolioStatusId != b.ssFolioStatusId) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssTotalIVA_Amount != b.ssTotalIVA_Amount) return false;
if (a.ssPartialAmount != b.ssPartialAmount) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssFirstApproverUserId != b.ssFirstApproverUserId) return false;
if (a.ssApprovalProcessTypeId != b.ssApprovalProcessTypeId) return false;
if (a.ssSAPEntryError != b.ssSAPEntryError) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssMinuteSelected != b.ssMinuteSelected) return false;
return true;
}

public static bool operator != (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord a, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)) return false;
return (this == (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssIsDraft.GetHashCode()
 ^ ssFolioNumber.GetHashCode()
 ^ ssCanProveedorCancel.GetHashCode()
 ^ ssOrderId.GetHashCode()
 ^ ssSupplierId.GetHashCode()
 ^ ssCompanyId.GetHashCode()
 ^ ssFolioStatusId.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssTotalIVA_Amount.GetHashCode()
 ^ ssPartialAmount.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssFirstApproverUserId.GetHashCode()
 ^ ssApprovalProcessTypeId.GetHashCode()
 ^ ssSAPEntryError.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssMinuteSelected.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord Duplicate() {
EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord t;
t._ssId = this._ssId;
t._ssIsDraft = this._ssIsDraft;
t._ssFolioNumber = this._ssFolioNumber;
t._ssCanProveedorCancel = this._ssCanProveedorCancel;
t._ssOrderId = this._ssOrderId;
t._ssSupplierId = this._ssSupplierId;
t._ssCompanyId = this._ssCompanyId;
t._ssFolioStatusId = this._ssFolioStatusId;
t._ssTotalAmount = this._ssTotalAmount;
t._ssTotalIVA_Amount = this._ssTotalIVA_Amount;
t._ssPartialAmount = this._ssPartialAmount;
t._ssCurrencyId = this._ssCurrencyId;
t._ssFirstApproverUserId = this._ssFirstApproverUserId;
t._ssApprovalProcessTypeId = this._ssApprovalProcessTypeId;
t._ssSAPEntryError = this._ssSAPEntryError;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssMinuteSelected = this._ssMinuteSelected;
t.ChangedAttributes = new BitArray(20);
t.OptimizedAttributes = new BitArray(20);
for(int i = 0; i < 20; i++){
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
} else if (head == "isdraft") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDraft")) variable.Value = ssIsDraft; else variable.Optimized = true;
} else if (head == "folionumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioNumber")) variable.Value = ssFolioNumber; else variable.Optimized = true;
} else if (head == "canproveedorcancel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanProveedorCancel")) variable.Value = ssCanProveedorCancel; else variable.Optimized = true;
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
} else if (head == "supplierid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierId")) variable.Value = ssSupplierId; else variable.Optimized = true;
} else if (head == "companyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyId")) variable.Value = ssCompanyId; else variable.Optimized = true;
} else if (head == "foliostatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioStatusId")) variable.Value = ssFolioStatusId; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "totaliva_amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalIVA_Amount")) variable.Value = ssTotalIVA_Amount; else variable.Optimized = true;
} else if (head == "partialamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PartialAmount")) variable.Value = ssPartialAmount; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "firstapproveruserid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstApproverUserId")) variable.Value = ssFirstApproverUserId; else variable.Optimized = true;
} else if (head == "approvalprocesstypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcessTypeId")) variable.Value = ssApprovalProcessTypeId; else variable.Optimized = true;
} else if (head == "sapentryerror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SAPEntryError")) variable.Value = ssSAPEntryError; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "minuteselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinuteSelected")) variable.Value = ssMinuteSelected; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdIsDraft)) {
return ChangedAttributes[1];
}
if (key.Equals(IdFolioNumber)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCanProveedorCancel)) {
return ChangedAttributes[3];
}
if (key.Equals(IdOrderId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdSupplierId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCompanyId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdFolioStatusId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdTotalAmount)) {
return ChangedAttributes[8];
}
if (key.Equals(IdTotalIVA_Amount)) {
return ChangedAttributes[9];
}
if (key.Equals(IdPartialAmount)) {
return ChangedAttributes[10];
}
if (key.Equals(IdCurrencyId)) {
return ChangedAttributes[11];
}
if (key.Equals(IdFirstApproverUserId)) {
return ChangedAttributes[12];
}
if (key.Equals(IdApprovalProcessTypeId)) {
return ChangedAttributes[13];
}
if (key.Equals(IdSAPEntryError)) {
return ChangedAttributes[14];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[15];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[16];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[17];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[18];
}
if (key.Equals(IdMinuteSelected)) {
return ChangedAttributes[19];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdIsDraft)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdFolioNumber)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCanProveedorCancel)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdOrderId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdSupplierId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCompanyId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdFolioStatusId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdTotalAmount)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdTotalIVA_Amount)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdPartialAmount)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdCurrencyId)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdFirstApproverUserId)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdApprovalProcessTypeId)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdSAPEntryError)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdMinuteSelected)) {
return OptimizedAttributes[19];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdIsDraft) {
return ssIsDraft;
}
if (key == IdFolioNumber) {
return ssFolioNumber;
}
if (key == IdCanProveedorCancel) {
return ssCanProveedorCancel;
}
if (key == IdOrderId) {
return ssOrderId;
}
if (key == IdSupplierId) {
return ssSupplierId;
}
if (key == IdCompanyId) {
return ssCompanyId;
}
if (key == IdFolioStatusId) {
return ssFolioStatusId;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdTotalIVA_Amount) {
return ssTotalIVA_Amount;
}
if (key == IdPartialAmount) {
return ssPartialAmount;
}
if (key == IdCurrencyId) {
return ssCurrencyId;
}
if (key == IdFirstApproverUserId) {
return ssFirstApproverUserId;
}
if (key == IdApprovalProcessTypeId) {
return ssApprovalProcessTypeId;
}
if (key == IdSAPEntryError) {
return ssSAPEntryError;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdMinuteSelected) {
return ssMinuteSelected;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdIsDraft.Key.AsGuid) {
return ssIsDraft;
}
if (attributeKey == IdFolioNumber.Key.AsGuid) {
return ssFolioNumber;
}
if (attributeKey == IdCanProveedorCancel.Key.AsGuid) {
return ssCanProveedorCancel;
}
if (attributeKey == IdOrderId.Key.AsGuid) {
return ssOrderId;
}
if (attributeKey == IdSupplierId.Key.AsGuid) {
return ssSupplierId;
}
if (attributeKey == IdCompanyId.Key.AsGuid) {
return ssCompanyId;
}
if (attributeKey == IdFolioStatusId.Key.AsGuid) {
return ssFolioStatusId;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdTotalIVA_Amount.Key.AsGuid) {
return ssTotalIVA_Amount;
}
if (attributeKey == IdPartialAmount.Key.AsGuid) {
return ssPartialAmount;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssCurrencyId;
}
if (attributeKey == IdFirstApproverUserId.Key.AsGuid) {
return ssFirstApproverUserId;
}
if (attributeKey == IdApprovalProcessTypeId.Key.AsGuid) {
return ssApprovalProcessTypeId;
}
if (attributeKey == IdSAPEntryError.Key.AsGuid) {
return ssSAPEntryError;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdMinuteSelected.Key.AsGuid) {
return ssMinuteSelected;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(20);
OptimizedAttributes = new BitArray(20);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssIsDraft = (bool) other.AttributeGet(IdIsDraft);
ChangedAttributes[1] = other.ChangedAttributeGet(IdIsDraft);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdIsDraft);
ssFolioNumber = (string) other.AttributeGet(IdFolioNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdFolioNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdFolioNumber);
ssCanProveedorCancel = (bool) other.AttributeGet(IdCanProveedorCancel);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCanProveedorCancel);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCanProveedorCancel);
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdOrderId);
ssSupplierId = (long) other.AttributeGet(IdSupplierId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdSupplierId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdSupplierId);
ssCompanyId = (long) other.AttributeGet(IdCompanyId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCompanyId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCompanyId);
ssFolioStatusId = (int) other.AttributeGet(IdFolioStatusId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdFolioStatusId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdFolioStatusId);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ChangedAttributes[8] = other.ChangedAttributeGet(IdTotalAmount);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdTotalAmount);
ssTotalIVA_Amount = (decimal) other.AttributeGet(IdTotalIVA_Amount);
ChangedAttributes[9] = other.ChangedAttributeGet(IdTotalIVA_Amount);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdTotalIVA_Amount);
ssPartialAmount = (decimal) other.AttributeGet(IdPartialAmount);
ChangedAttributes[10] = other.ChangedAttributeGet(IdPartialAmount);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdPartialAmount);
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ChangedAttributes[11] = other.ChangedAttributeGet(IdCurrencyId);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdCurrencyId);
ssFirstApproverUserId = (string) other.AttributeGet(IdFirstApproverUserId);
ChangedAttributes[12] = other.ChangedAttributeGet(IdFirstApproverUserId);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdFirstApproverUserId);
ssApprovalProcessTypeId = (int) other.AttributeGet(IdApprovalProcessTypeId);
ChangedAttributes[13] = other.ChangedAttributeGet(IdApprovalProcessTypeId);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdApprovalProcessTypeId);
ssSAPEntryError = (string) other.AttributeGet(IdSAPEntryError);
ChangedAttributes[14] = other.ChangedAttributeGet(IdSAPEntryError);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdSAPEntryError);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[15] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[16] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdCreatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[17] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdUpdatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[18] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdUpdatedOn);
ssMinuteSelected = (int) other.AttributeGet(IdMinuteSelected);
ChangedAttributes[19] = other.ChangedAttributeGet(IdMinuteSelected);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdMinuteSelected);
}
} // EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord

/// <summary>
/// RecordList type <code>FolioList</code> that represents a record list of <code>Folio</code>
/// </summary>
public partial class RL_da71cc5a3e7d9f2dad0a44739e059aa3 : GenericRecordList<EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord>, IEnumerable, IEnumerator {

protected override EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord GetElementDefaultValue() {
return new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
}

public T[] ToArray<T>(Func<EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_da71cc5a3e7d9f2dad0a44739e059aa3 recordList, Func<EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_da71cc5a3e7d9f2dad0a44739e059aa3(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord[] array) {
  RL_da71cc5a3e7d9f2dad0a44739e059aa3 result = new RL_da71cc5a3e7d9f2dad0a44739e059aa3();
result.InnerFromArray(array);
    return result;
}

public static RL_da71cc5a3e7d9f2dad0a44739e059aa3 ToList<T>(T[] array, Func <T, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord> converter) {
  RL_da71cc5a3e7d9f2dad0a44739e059aa3 result = new RL_da71cc5a3e7d9f2dad0a44739e059aa3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_da71cc5a3e7d9f2dad0a44739e059aa3 FromRestList<T>(RestList<T> restList, Func <T, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord> converter) {
  RL_da71cc5a3e7d9f2dad0a44739e059aa3 result = new RL_da71cc5a3e7d9f2dad0a44739e059aa3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_da71cc5a3e7d9f2dad0a44739e059aa3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord> NewList() {
return new RL_da71cc5a3e7d9f2dad0a44739e059aa3();
}


} // RL_da71cc5a3e7d9f2dad0a44739e059aa3
}
