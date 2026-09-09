using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] Invoice (JUzfFS2ruku0F9VE0lWh_w)
///  <code>EN_d1d0320db36efbb094ad0082361435a0EntityRecord</code> that represents <code>Invoice</code
/// > <p>Description: Entity that holds Invoice main details.</p>
/// </summary>
// Name: Invoice
public partial struct EN_d1d0320db36efbb094ad0082361435a0EntityRecord : ITypedRecord<EN_d1d0320db36efbb094ad0082361435a0EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LRTehBa5m0mcQ9E4aiMRXg");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HowiQss2HkiLkYG13n0nWg");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qp4t5V25ZU2p6lTcdPNzyQ");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1tqA3nRLDk6pzGdCqZA_Rw");
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jFvvYYMGsUKteLjVsInIfQ");
internal static readonly GlobalObjectKey IdCFDITypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*t3Z4TQk00keYj0zs4HFBSg");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZDQbp7GoNEKREXpEyJeNng");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FXGStK+kEEqaBuEG5Tpksg");
internal static readonly GlobalObjectKey IdInvoiceStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IhuhlE0tYEyPv2skV9WQHg");
internal static readonly GlobalObjectKey IdAccountingDateTime = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IMFgAX2BBUqbVUp1213xGA");
internal static readonly GlobalObjectKey IdPaymentDateTime = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZGlxqqXkWk680Lna5HX73g");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bPnwjCxwWkWX1JZ3+Lj9AA");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DpRANntj_EiqXJ6nPXSfUA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rQxrLxSiG0qLG+l23wDdzw");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*a0xljaV4VUGMjpwqRCBcaw");
internal static readonly GlobalObjectKey IdSubmittedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wRcxGimO6kKT4rEn8EIIKQ");
internal static readonly GlobalObjectKey IdIsNewVersion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*StaIJhcvX0q20gLtaIxGOA");
internal static readonly GlobalObjectKey IdID_POLIZA = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*t56V3NYMCES3KiF51VJjfA");
internal static readonly GlobalObjectKey IdID_POLIZA_SAP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*E_jEKaaElkKws7POx3XIFQ");
internal static readonly GlobalObjectKey IdDoc51 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ICGRLfTyBUK48HCXaAVugA");
internal static readonly GlobalObjectKey IdAccountingError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TinvklR3Ok+hWvaHSAA2PA");
internal static readonly GlobalObjectKey IdOrderAccConceptsID = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*e9NVhUQCoE2mC_qyALYTUg");
internal static readonly GlobalObjectKey IdAmortization = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZKDzE0Y6fESugNOpyggxiA");
internal static readonly GlobalObjectKey IdCreditNoteInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tZ4m0NQX70KHmyTeiGv7qA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(24,true);
          _ssId = value;
      }
  }
}

private string _ssName;
public string ssName{
  get{
      return _ssName;
  }
  set{
      if((_ssName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssName = value;
      }
  }
}

private long _ssRequisitionId;
public long ssRequisitionId{
  get{
      return _ssRequisitionId;
  }
  set{
      if((_ssRequisitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssRequisitionId = value;
      }
  }
}

private long _ssFolioId;
public long ssFolioId{
  get{
      return _ssFolioId;
  }
  set{
      if((_ssFolioId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssFolioId = value;
      }
  }
}

private long _ssOrderMainId;
public long ssOrderMainId{
  get{
      return _ssOrderMainId;
  }
  set{
      if((_ssOrderMainId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssOrderMainId = value;
      }
  }
}

private int _ssCFDITypeId;
public int ssCFDITypeId{
  get{
      return _ssCFDITypeId;
  }
  set{
      if((_ssCFDITypeId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCFDITypeId = value;
      }
  }
}

private decimal _ssTotalAmount;
public decimal ssTotalAmount{
  get{
      return _ssTotalAmount;
  }
  set{
      if((_ssTotalAmount!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssTotalAmount = value;
      }
  }
}

private string _ssCurrency;
public string ssCurrency{
  get{
      return _ssCurrency;
  }
  set{
      if((_ssCurrency!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCurrency = value;
      }
  }
}

private int _ssInvoiceStatusId;
public int ssInvoiceStatusId{
  get{
      return _ssInvoiceStatusId;
  }
  set{
      if((_ssInvoiceStatusId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssInvoiceStatusId = value;
      }
  }
}

private DateTime _ssAccountingDateTime;
public DateTime ssAccountingDateTime{
  get{
      return _ssAccountingDateTime;
  }
  set{
      if((_ssAccountingDateTime!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssAccountingDateTime = value;
      }
  }
}

private DateTime _ssPaymentDateTime;
public DateTime ssPaymentDateTime{
  get{
      return _ssPaymentDateTime;
  }
  set{
      if((_ssPaymentDateTime!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssPaymentDateTime = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssUpdatedBy = value;
      }
  }
}

private DateTime _ssSubmittedOn;
public DateTime ssSubmittedOn{
  get{
      return _ssSubmittedOn;
  }
  set{
      if((_ssSubmittedOn!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssSubmittedOn = value;
      }
  }
}

private bool _ssIsNewVersion;
public bool ssIsNewVersion{
  get{
      return _ssIsNewVersion;
  }
  set{
      if((_ssIsNewVersion!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssIsNewVersion = value;
      }
  }
}

private string _ssID_POLIZA;
public string ssID_POLIZA{
  get{
      return _ssID_POLIZA;
  }
  set{
      if((_ssID_POLIZA!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssID_POLIZA = value;
      }
  }
}

private string _ssID_POLIZA_SAP;
public string ssID_POLIZA_SAP{
  get{
      return _ssID_POLIZA_SAP;
  }
  set{
      if((_ssID_POLIZA_SAP!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssID_POLIZA_SAP = value;
      }
  }
}

private string _ssDoc51;
public string ssDoc51{
  get{
      return _ssDoc51;
  }
  set{
      if((_ssDoc51!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssDoc51 = value;
      }
  }
}

private string _ssAccountingError;
public string ssAccountingError{
  get{
      return _ssAccountingError;
  }
  set{
      if((_ssAccountingError!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssAccountingError = value;
      }
  }
}

private long _ssOrderAccConceptsID;
public long ssOrderAccConceptsID{
  get{
      return _ssOrderAccConceptsID;
  }
  set{
      if((_ssOrderAccConceptsID!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssOrderAccConceptsID = value;
      }
  }
}

private decimal _ssAmortization;
public decimal ssAmortization{
  get{
      return _ssAmortization;
  }
  set{
      if((_ssAmortization!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssAmortization = value;
      }
  }
}

private long _ssCreditNoteInvoiceId;
public long ssCreditNoteInvoiceId{
  get{
      return _ssCreditNoteInvoiceId;
  }
  set{
      if((_ssCreditNoteInvoiceId!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssCreditNoteInvoiceId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord() {
ChangedAttributes = new BitArray(24,true);
OptimizedAttributes = new BitArray(24,false);
_ssId = 0L;
_ssName = "";
_ssRequisitionId = 0L;
_ssFolioId = 0L;
_ssOrderMainId = 0L;
_ssCFDITypeId = 0;
_ssTotalAmount = 0.0M;
_ssCurrency = "";
_ssInvoiceStatusId = 0;
_ssAccountingDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssPaymentDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
_ssSubmittedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssIsNewVersion = false;
_ssID_POLIZA = "";
_ssID_POLIZA_SAP = "";
_ssDoc51 = "";
_ssAccountingError = "";
_ssOrderAccConceptsID = 0L;
_ssAmortization = 0.0M;
_ssCreditNoteInvoiceId = 0L;
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
ssId = r.ReadLongInteger(index++, "Invoice.Id", 0L);
ssName = r.ReadText(index++, "Invoice.Name", "");
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "Invoice.RequisitionId", 0L);
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "Invoice.FolioId", 0L);
ssOrderMainId = r.ReadEntityReferenceLongInteger(index++, "Invoice.OrderMainId", 0L);
ssCFDITypeId = r.ReadEntityReference(index++, "Invoice.CFDITypeId", 0);
ssTotalAmount = r.ReadDecimal(index++, "Invoice.TotalAmount", 0.0M);
ssCurrency = r.ReadText(index++, "Invoice.Currency", "");
ssInvoiceStatusId = r.ReadEntityReference(index++, "Invoice.InvoiceStatusId", 0);
ssAccountingDateTime = r.ReadDateTime(index++, "Invoice.AccountingDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPaymentDateTime = r.ReadDateTime(index++, "Invoice.PaymentDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedOn = r.ReadDateTime(index++, "Invoice.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "Invoice.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "Invoice.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "Invoice.UpdatedBy", "");
ssSubmittedOn = r.ReadDateTime(index++, "Invoice.SubmittedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssIsNewVersion = r.ReadBoolean(index++, "Invoice.IsNewVersion", false);
ssID_POLIZA = r.ReadText(index++, "Invoice.ID_POLIZA", "");
ssID_POLIZA_SAP = r.ReadText(index++, "Invoice.ID_POLIZA_SAP", "");
ssDoc51 = r.ReadText(index++, "Invoice.Doc51", "");
ssAccountingError = r.ReadText(index++, "Invoice.AccountingError", "");
ssOrderAccConceptsID = r.ReadEntityReferenceLongInteger(index++, "Invoice.OrderAccConceptsID", 0L);
ssAmortization = r.ReadDecimal(index++, "Invoice.Amortization", 0.0M);
ssCreditNoteInvoiceId = r.ReadEntityReferenceLongInteger(index++, "Invoice.CreditNoteInvoiceId", 0L);
ChangedAttributes = new BitArray(24,false);
OptimizedAttributes = new BitArray(24,false);
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
public void ReadIM(EN_d1d0320db36efbb094ad0082361435a0EntityRecord r) {
this = r;
}


public static bool operator == (EN_d1d0320db36efbb094ad0082361435a0EntityRecord a, EN_d1d0320db36efbb094ad0082361435a0EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssOrderMainId != b.ssOrderMainId) return false;
if (a.ssCFDITypeId != b.ssCFDITypeId) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssInvoiceStatusId != b.ssInvoiceStatusId) return false;
if (a.ssAccountingDateTime != b.ssAccountingDateTime) return false;
if (a.ssPaymentDateTime != b.ssPaymentDateTime) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
if (a.ssSubmittedOn != b.ssSubmittedOn) return false;
if (a.ssIsNewVersion != b.ssIsNewVersion) return false;
if (a.ssID_POLIZA != b.ssID_POLIZA) return false;
if (a.ssID_POLIZA_SAP != b.ssID_POLIZA_SAP) return false;
if (a.ssDoc51 != b.ssDoc51) return false;
if (a.ssAccountingError != b.ssAccountingError) return false;
if (a.ssOrderAccConceptsID != b.ssOrderAccConceptsID) return false;
if (a.ssAmortization != b.ssAmortization) return false;
if (a.ssCreditNoteInvoiceId != b.ssCreditNoteInvoiceId) return false;
return true;
}

public static bool operator != (EN_d1d0320db36efbb094ad0082361435a0EntityRecord a, EN_d1d0320db36efbb094ad0082361435a0EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)) return false;
return (this == (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssOrderMainId.GetHashCode()
 ^ ssCFDITypeId.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssInvoiceStatusId.GetHashCode()
 ^ ssAccountingDateTime.GetHashCode()
 ^ ssPaymentDateTime.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
 ^ ssSubmittedOn.GetHashCode()
 ^ ssIsNewVersion.GetHashCode()
 ^ ssID_POLIZA.GetHashCode()
 ^ ssID_POLIZA_SAP.GetHashCode()
 ^ ssDoc51.GetHashCode()
 ^ ssAccountingError.GetHashCode()
 ^ ssOrderAccConceptsID.GetHashCode()
 ^ ssAmortization.GetHashCode()
 ^ ssCreditNoteInvoiceId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_d1d0320db36efbb094ad0082361435a0EntityRecord Duplicate() {
EN_d1d0320db36efbb094ad0082361435a0EntityRecord t;
t._ssId = this._ssId;
t._ssName = this._ssName;
t._ssRequisitionId = this._ssRequisitionId;
t._ssFolioId = this._ssFolioId;
t._ssOrderMainId = this._ssOrderMainId;
t._ssCFDITypeId = this._ssCFDITypeId;
t._ssTotalAmount = this._ssTotalAmount;
t._ssCurrency = this._ssCurrency;
t._ssInvoiceStatusId = this._ssInvoiceStatusId;
t._ssAccountingDateTime = this._ssAccountingDateTime;
t._ssPaymentDateTime = this._ssPaymentDateTime;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t._ssSubmittedOn = this._ssSubmittedOn;
t._ssIsNewVersion = this._ssIsNewVersion;
t._ssID_POLIZA = this._ssID_POLIZA;
t._ssID_POLIZA_SAP = this._ssID_POLIZA_SAP;
t._ssDoc51 = this._ssDoc51;
t._ssAccountingError = this._ssAccountingError;
t._ssOrderAccConceptsID = this._ssOrderAccConceptsID;
t._ssAmortization = this._ssAmortization;
t._ssCreditNoteInvoiceId = this._ssCreditNoteInvoiceId;
t.ChangedAttributes = new BitArray(24);
t.OptimizedAttributes = new BitArray(24);
for(int i = 0; i < 24; i++){
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "ordermainid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId")) variable.Value = ssOrderMainId; else variable.Optimized = true;
} else if (head == "cfditypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CFDITypeId")) variable.Value = ssCFDITypeId; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "invoicestatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatusId")) variable.Value = ssInvoiceStatusId; else variable.Optimized = true;
} else if (head == "accountingdatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDateTime")) variable.Value = ssAccountingDateTime; else variable.Optimized = true;
} else if (head == "paymentdatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDateTime")) variable.Value = ssPaymentDateTime; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
} else if (head == "submittedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubmittedOn")) variable.Value = ssSubmittedOn; else variable.Optimized = true;
} else if (head == "isnewversion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsNewVersion")) variable.Value = ssIsNewVersion; else variable.Optimized = true;
} else if (head == "id_poliza") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ID_POLIZA")) variable.Value = ssID_POLIZA; else variable.Optimized = true;
} else if (head == "id_poliza_sap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ID_POLIZA_SAP")) variable.Value = ssID_POLIZA_SAP; else variable.Optimized = true;
} else if (head == "doc51") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Doc51")) variable.Value = ssDoc51; else variable.Optimized = true;
} else if (head == "accountingerror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingError")) variable.Value = ssAccountingError; else variable.Optimized = true;
} else if (head == "orderaccconceptsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConceptsID")) variable.Value = ssOrderAccConceptsID; else variable.Optimized = true;
} else if (head == "amortization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amortization")) variable.Value = ssAmortization; else variable.Optimized = true;
} else if (head == "creditnoteinvoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreditNoteInvoiceId")) variable.Value = ssCreditNoteInvoiceId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdRequisitionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdFolioId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdOrderMainId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCFDITypeId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdTotalAmount)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCurrency)) {
return ChangedAttributes[7];
}
if (key.Equals(IdInvoiceStatusId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdAccountingDateTime)) {
return ChangedAttributes[9];
}
if (key.Equals(IdPaymentDateTime)) {
return ChangedAttributes[10];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[11];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[12];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[13];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[14];
}
if (key.Equals(IdSubmittedOn)) {
return ChangedAttributes[15];
}
if (key.Equals(IdIsNewVersion)) {
return ChangedAttributes[16];
}
if (key.Equals(IdID_POLIZA)) {
return ChangedAttributes[17];
}
if (key.Equals(IdID_POLIZA_SAP)) {
return ChangedAttributes[18];
}
if (key.Equals(IdDoc51)) {
return ChangedAttributes[19];
}
if (key.Equals(IdAccountingError)) {
return ChangedAttributes[20];
}
if (key.Equals(IdOrderAccConceptsID)) {
return ChangedAttributes[21];
}
if (key.Equals(IdAmortization)) {
return ChangedAttributes[22];
}
if (key.Equals(IdCreditNoteInvoiceId)) {
return ChangedAttributes[23];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdRequisitionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdFolioId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdOrderMainId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCFDITypeId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdTotalAmount)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCurrency)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdInvoiceStatusId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdAccountingDateTime)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdPaymentDateTime)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdSubmittedOn)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdIsNewVersion)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdID_POLIZA)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdID_POLIZA_SAP)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdDoc51)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdAccountingError)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdOrderAccConceptsID)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdAmortization)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdCreditNoteInvoiceId)) {
return OptimizedAttributes[23];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdName) {
return ssName;
}
if (key == IdRequisitionId) {
return ssRequisitionId;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdOrderMainId) {
return ssOrderMainId;
}
if (key == IdCFDITypeId) {
return ssCFDITypeId;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdInvoiceStatusId) {
return ssInvoiceStatusId;
}
if (key == IdAccountingDateTime) {
return ssAccountingDateTime;
}
if (key == IdPaymentDateTime) {
return ssPaymentDateTime;
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
if (key == IdSubmittedOn) {
return ssSubmittedOn;
}
if (key == IdIsNewVersion) {
return ssIsNewVersion;
}
if (key == IdID_POLIZA) {
return ssID_POLIZA;
}
if (key == IdID_POLIZA_SAP) {
return ssID_POLIZA_SAP;
}
if (key == IdDoc51) {
return ssDoc51;
}
if (key == IdAccountingError) {
return ssAccountingError;
}
if (key == IdOrderAccConceptsID) {
return ssOrderAccConceptsID;
}
if (key == IdAmortization) {
return ssAmortization;
}
if (key == IdCreditNoteInvoiceId) {
return ssCreditNoteInvoiceId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdRequisitionId.Key.AsGuid) {
return ssRequisitionId;
}
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssOrderMainId;
}
if (attributeKey == IdCFDITypeId.Key.AsGuid) {
return ssCFDITypeId;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdInvoiceStatusId.Key.AsGuid) {
return ssInvoiceStatusId;
}
if (attributeKey == IdAccountingDateTime.Key.AsGuid) {
return ssAccountingDateTime;
}
if (attributeKey == IdPaymentDateTime.Key.AsGuid) {
return ssPaymentDateTime;
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
if (attributeKey == IdSubmittedOn.Key.AsGuid) {
return ssSubmittedOn;
}
if (attributeKey == IdIsNewVersion.Key.AsGuid) {
return ssIsNewVersion;
}
if (attributeKey == IdID_POLIZA.Key.AsGuid) {
return ssID_POLIZA;
}
if (attributeKey == IdID_POLIZA_SAP.Key.AsGuid) {
return ssID_POLIZA_SAP;
}
if (attributeKey == IdDoc51.Key.AsGuid) {
return ssDoc51;
}
if (attributeKey == IdAccountingError.Key.AsGuid) {
return ssAccountingError;
}
if (attributeKey == IdOrderAccConceptsID.Key.AsGuid) {
return ssOrderAccConceptsID;
}
if (attributeKey == IdAmortization.Key.AsGuid) {
return ssAmortization;
}
if (attributeKey == IdCreditNoteInvoiceId.Key.AsGuid) {
return ssCreditNoteInvoiceId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(24);
OptimizedAttributes = new BitArray(24);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssName = (string) other.AttributeGet(IdName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRequisitionId);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdFolioId);
ssOrderMainId = (long) other.AttributeGet(IdOrderMainId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdOrderMainId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdOrderMainId);
ssCFDITypeId = (int) other.AttributeGet(IdCFDITypeId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCFDITypeId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCFDITypeId);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ChangedAttributes[6] = other.ChangedAttributeGet(IdTotalAmount);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdTotalAmount);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCurrency);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCurrency);
ssInvoiceStatusId = (int) other.AttributeGet(IdInvoiceStatusId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdInvoiceStatusId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdInvoiceStatusId);
ssAccountingDateTime = (DateTime) other.AttributeGet(IdAccountingDateTime);
ChangedAttributes[9] = other.ChangedAttributeGet(IdAccountingDateTime);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdAccountingDateTime);
ssPaymentDateTime = (DateTime) other.AttributeGet(IdPaymentDateTime);
ChangedAttributes[10] = other.ChangedAttributeGet(IdPaymentDateTime);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdPaymentDateTime);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[11] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[12] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[13] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[14] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdUpdatedBy);
ssSubmittedOn = (DateTime) other.AttributeGet(IdSubmittedOn);
ChangedAttributes[15] = other.ChangedAttributeGet(IdSubmittedOn);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdSubmittedOn);
ssIsNewVersion = (bool) other.AttributeGet(IdIsNewVersion);
ChangedAttributes[16] = other.ChangedAttributeGet(IdIsNewVersion);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdIsNewVersion);
ssID_POLIZA = (string) other.AttributeGet(IdID_POLIZA);
ChangedAttributes[17] = other.ChangedAttributeGet(IdID_POLIZA);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdID_POLIZA);
ssID_POLIZA_SAP = (string) other.AttributeGet(IdID_POLIZA_SAP);
ChangedAttributes[18] = other.ChangedAttributeGet(IdID_POLIZA_SAP);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdID_POLIZA_SAP);
ssDoc51 = (string) other.AttributeGet(IdDoc51);
ChangedAttributes[19] = other.ChangedAttributeGet(IdDoc51);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdDoc51);
ssAccountingError = (string) other.AttributeGet(IdAccountingError);
ChangedAttributes[20] = other.ChangedAttributeGet(IdAccountingError);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdAccountingError);
ssOrderAccConceptsID = (long) other.AttributeGet(IdOrderAccConceptsID);
ChangedAttributes[21] = other.ChangedAttributeGet(IdOrderAccConceptsID);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdOrderAccConceptsID);
ssAmortization = (decimal) other.AttributeGet(IdAmortization);
ChangedAttributes[22] = other.ChangedAttributeGet(IdAmortization);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdAmortization);
ssCreditNoteInvoiceId = (long) other.AttributeGet(IdCreditNoteInvoiceId);
ChangedAttributes[23] = other.ChangedAttributeGet(IdCreditNoteInvoiceId);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdCreditNoteInvoiceId);
}
} // EN_d1d0320db36efbb094ad0082361435a0EntityRecord

/// <summary>
/// RecordList type <code>InvoiceList</code> that represents a record list of <code>Invoice</code>
/// </summary>
public partial class RL_2d16aaaf46aa59a96936af8c3c3547a0 : GenericRecordList<EN_d1d0320db36efbb094ad0082361435a0EntityRecord>, IEnumerable, IEnumerator {

protected override EN_d1d0320db36efbb094ad0082361435a0EntityRecord GetElementDefaultValue() {
return new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
}

public T[] ToArray<T>(Func<EN_d1d0320db36efbb094ad0082361435a0EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2d16aaaf46aa59a96936af8c3c3547a0 recordList, Func<EN_d1d0320db36efbb094ad0082361435a0EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2d16aaaf46aa59a96936af8c3c3547a0(EN_d1d0320db36efbb094ad0082361435a0EntityRecord[] array) {
  RL_2d16aaaf46aa59a96936af8c3c3547a0 result = new RL_2d16aaaf46aa59a96936af8c3c3547a0();
result.InnerFromArray(array);
    return result;
}

public static RL_2d16aaaf46aa59a96936af8c3c3547a0 ToList<T>(T[] array, Func <T, EN_d1d0320db36efbb094ad0082361435a0EntityRecord> converter) {
  RL_2d16aaaf46aa59a96936af8c3c3547a0 result = new RL_2d16aaaf46aa59a96936af8c3c3547a0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2d16aaaf46aa59a96936af8c3c3547a0 FromRestList<T>(RestList<T> restList, Func <T, EN_d1d0320db36efbb094ad0082361435a0EntityRecord> converter) {
  RL_2d16aaaf46aa59a96936af8c3c3547a0 result = new RL_2d16aaaf46aa59a96936af8c3c3547a0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2d16aaaf46aa59a96936af8c3c3547a0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d1d0320db36efbb094ad0082361435a0EntityRecord> NewList() {
return new RL_2d16aaaf46aa59a96936af8c3c3547a0();
}


} // RL_2d16aaaf46aa59a96936af8c3c3547a0
}
