using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceAccounting (8Nlb+Mhox0u6j+TyiDqMAQ)
///  <code>EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord</code> that represent
/// s <code>InvoiceAccounting</code> <p>Description: Entity that holds Invoice Accounting.</p>
/// </summary>
// Name: InvoiceAccounting
public partial struct EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord : ITypedRecord<EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gZ+anSZapEmwqqoadq8zeg");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2UqXbAtgQE+THltxr2a3Gw");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bm4oS+ucdE6G_8pAy7lvuA");
internal static readonly GlobalObjectKey IdServiceTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7+cb1InDZUSbAy6YHlaTww");
internal static readonly GlobalObjectKey IdFreeText = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mlRvK3OZbU6lzypLXKVWew");
internal static readonly GlobalObjectKey IdDivision = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GWAWRLxeG0CoNABUKdQPXw");
internal static readonly GlobalObjectKey IdIvaAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1FZIYv9XQk6EV6TP2f4k5w");
internal static readonly GlobalObjectKey IdIva_Old = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eWtJSb8GqkeiweIFuMCFMg");
internal static readonly GlobalObjectKey IdIvaIndicatorId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6C_cM7iFTES4__mrxEEUtA");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vJ882kgqbE+rLiANEgjGoA");
internal static readonly GlobalObjectKey IdPaymentMethodId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*biImA4iAZk+sVEi7gbTDFA");
internal static readonly GlobalObjectKey IdPaymentTermsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*R6X7A15qukGVccHkoDibbA");
internal static readonly GlobalObjectKey IdICMEIndicator = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kGddjNg7_kexO5xMW4Go6w");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oEFKH39JU0mYqTPLoVoSgg");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aQ0mOlo8QEWKd0ce3l+48A");
internal static readonly GlobalObjectKey IdSubmissionBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Fq_dRwhmsk+ipuxXUG3RQA");
internal static readonly GlobalObjectKey IdSubmissionOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DpL4z5YFbUyv7JJcpsXhMw");
internal static readonly GlobalObjectKey IdServiceCalledBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fGtRvNutIUytoq_7LPNKKA");
internal static readonly GlobalObjectKey IdServiceCalledOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5W0_04jX3U+ev5lkzglWFA");
internal static readonly GlobalObjectKey IdBuyDocNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mwLLqv+hGUiOgcr8_8LUcw");
internal static readonly GlobalObjectKey IdBuyDocPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BAD0jtJH7kqnIq88w6r9aA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(21,true);
          _ssId = value;
      }
  }
}

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceId = value;
      }
  }
}

private string _ssSupplierNumber;
public string ssSupplierNumber{
  get{
      return _ssSupplierNumber;
  }
  set{
      if((_ssSupplierNumber!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssSupplierNumber = value;
      }
  }
}

private long _ssServiceTypeId;
public long ssServiceTypeId{
  get{
      return _ssServiceTypeId;
  }
  set{
      if((_ssServiceTypeId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssServiceTypeId = value;
      }
  }
}

private string _ssFreeText;
public string ssFreeText{
  get{
      return _ssFreeText;
  }
  set{
      if((_ssFreeText!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssFreeText = value;
      }
  }
}

private string _ssDivision;
public string ssDivision{
  get{
      return _ssDivision;
  }
  set{
      if((_ssDivision!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssDivision = value;
      }
  }
}

private decimal _ssIvaAmount;
public decimal ssIvaAmount{
  get{
      return _ssIvaAmount;
  }
  set{
      if((_ssIvaAmount!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIvaAmount = value;
      }
  }
}

private string _ssIva_Old;
public string ssIva_Old{
  get{
      return _ssIva_Old;
  }
  set{
      if((_ssIva_Old!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIva_Old = value;
      }
  }
}

private long _ssIvaIndicatorId;
public long ssIvaIndicatorId{
  get{
      return _ssIvaIndicatorId;
  }
  set{
      if((_ssIvaIndicatorId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIvaIndicatorId = value;
      }
  }
}

private decimal _ssTotalAmount;
public decimal ssTotalAmount{
  get{
      return _ssTotalAmount;
  }
  set{
      if((_ssTotalAmount!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssTotalAmount = value;
      }
  }
}

private long _ssPaymentMethodId;
public long ssPaymentMethodId{
  get{
      return _ssPaymentMethodId;
  }
  set{
      if((_ssPaymentMethodId!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssPaymentMethodId = value;
      }
  }
}

private long _ssPaymentTermsId;
public long ssPaymentTermsId{
  get{
      return _ssPaymentTermsId;
  }
  set{
      if((_ssPaymentTermsId!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssPaymentTermsId = value;
      }
  }
}

private string _ssICMEIndicator;
public string ssICMEIndicator{
  get{
      return _ssICMEIndicator;
  }
  set{
      if((_ssICMEIndicator!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssICMEIndicator = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
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
      if((_ssCreatedOn!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssSubmissionBy;
public string ssSubmissionBy{
  get{
      return _ssSubmissionBy;
  }
  set{
      if((_ssSubmissionBy!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssSubmissionBy = value;
      }
  }
}

private DateTime _ssSubmissionOn;
public DateTime ssSubmissionOn{
  get{
      return _ssSubmissionOn;
  }
  set{
      if((_ssSubmissionOn!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssSubmissionOn = value;
      }
  }
}

private string _ssServiceCalledBy;
public string ssServiceCalledBy{
  get{
      return _ssServiceCalledBy;
  }
  set{
      if((_ssServiceCalledBy!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssServiceCalledBy = value;
      }
  }
}

private DateTime _ssServiceCalledOn;
public DateTime ssServiceCalledOn{
  get{
      return _ssServiceCalledOn;
  }
  set{
      if((_ssServiceCalledOn!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssServiceCalledOn = value;
      }
  }
}

private string _ssBuyDocNumber;
public string ssBuyDocNumber{
  get{
      return _ssBuyDocNumber;
  }
  set{
      if((_ssBuyDocNumber!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssBuyDocNumber = value;
      }
  }
}

private string _ssBuyDocPosition;
public string ssBuyDocPosition{
  get{
      return _ssBuyDocPosition;
  }
  set{
      if((_ssBuyDocPosition!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssBuyDocPosition = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord() {
ChangedAttributes = new BitArray(21,true);
OptimizedAttributes = new BitArray(21,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssSupplierNumber = "";
_ssServiceTypeId = 0L;
_ssFreeText = "";
_ssDivision = "";
_ssIvaAmount = 0.0M;
_ssIva_Old = "";
_ssIvaIndicatorId = 0L;
_ssTotalAmount = 0.0M;
_ssPaymentMethodId = 0L;
_ssPaymentTermsId = 0L;
_ssICMEIndicator = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssSubmissionBy = "";
_ssSubmissionOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssServiceCalledBy = "";
_ssServiceCalledOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssBuyDocNumber = "";
_ssBuyDocPosition = "";
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
ssId = r.ReadLongInteger(index++, "InvoiceAccounting.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccounting.InvoiceId", 0L);
ssSupplierNumber = r.ReadText(index++, "InvoiceAccounting.SupplierNumber", "");
ssServiceTypeId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccounting.ServiceTypeId", 0L);
ssFreeText = r.ReadText(index++, "InvoiceAccounting.FreeText", "");
ssDivision = r.ReadText(index++, "InvoiceAccounting.Division", "");
ssIvaAmount = r.ReadDecimal(index++, "InvoiceAccounting.IvaAmount", 0.0M);
ssIva_Old = r.ReadText(index++, "InvoiceAccounting.Iva_Old", "");
ssIvaIndicatorId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccounting.IvaIndicatorId", 0L);
ssTotalAmount = r.ReadDecimal(index++, "InvoiceAccounting.TotalAmount", 0.0M);
ssPaymentMethodId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccounting.PaymentMethodId", 0L);
ssPaymentTermsId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccounting.PaymentTermsId", 0L);
ssICMEIndicator = r.ReadText(index++, "InvoiceAccounting.ICMEIndicator", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "InvoiceAccounting.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "InvoiceAccounting.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssSubmissionBy = r.ReadEntityReferenceText(index++, "InvoiceAccounting.SubmissionBy", "");
ssSubmissionOn = r.ReadDateTime(index++, "InvoiceAccounting.SubmissionOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssServiceCalledBy = r.ReadEntityReferenceText(index++, "InvoiceAccounting.ServiceCalledBy", "");
ssServiceCalledOn = r.ReadDateTime(index++, "InvoiceAccounting.ServiceCalledOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssBuyDocNumber = r.ReadText(index++, "InvoiceAccounting.BuyDocNumber", "");
ssBuyDocPosition = r.ReadText(index++, "InvoiceAccounting.BuyDocPosition", "");
ChangedAttributes = new BitArray(21,false);
OptimizedAttributes = new BitArray(21,false);
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
public void ReadIM(EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord r) {
this = r;
}


public static bool operator == (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord a, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssServiceTypeId != b.ssServiceTypeId) return false;
if (a.ssFreeText != b.ssFreeText) return false;
if (a.ssDivision != b.ssDivision) return false;
if (a.ssIvaAmount != b.ssIvaAmount) return false;
if (a.ssIva_Old != b.ssIva_Old) return false;
if (a.ssIvaIndicatorId != b.ssIvaIndicatorId) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssPaymentMethodId != b.ssPaymentMethodId) return false;
if (a.ssPaymentTermsId != b.ssPaymentTermsId) return false;
if (a.ssICMEIndicator != b.ssICMEIndicator) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssSubmissionBy != b.ssSubmissionBy) return false;
if (a.ssSubmissionOn != b.ssSubmissionOn) return false;
if (a.ssServiceCalledBy != b.ssServiceCalledBy) return false;
if (a.ssServiceCalledOn != b.ssServiceCalledOn) return false;
if (a.ssBuyDocNumber != b.ssBuyDocNumber) return false;
if (a.ssBuyDocPosition != b.ssBuyDocPosition) return false;
return true;
}

public static bool operator != (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord a, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)) return false;
return (this == (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssServiceTypeId.GetHashCode()
 ^ ssFreeText.GetHashCode()
 ^ ssDivision.GetHashCode()
 ^ ssIvaAmount.GetHashCode()
 ^ ssIva_Old.GetHashCode()
 ^ ssIvaIndicatorId.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssPaymentMethodId.GetHashCode()
 ^ ssPaymentTermsId.GetHashCode()
 ^ ssICMEIndicator.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssSubmissionBy.GetHashCode()
 ^ ssSubmissionOn.GetHashCode()
 ^ ssServiceCalledBy.GetHashCode()
 ^ ssServiceCalledOn.GetHashCode()
 ^ ssBuyDocNumber.GetHashCode()
 ^ ssBuyDocPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord Duplicate() {
EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssSupplierNumber = this._ssSupplierNumber;
t._ssServiceTypeId = this._ssServiceTypeId;
t._ssFreeText = this._ssFreeText;
t._ssDivision = this._ssDivision;
t._ssIvaAmount = this._ssIvaAmount;
t._ssIva_Old = this._ssIva_Old;
t._ssIvaIndicatorId = this._ssIvaIndicatorId;
t._ssTotalAmount = this._ssTotalAmount;
t._ssPaymentMethodId = this._ssPaymentMethodId;
t._ssPaymentTermsId = this._ssPaymentTermsId;
t._ssICMEIndicator = this._ssICMEIndicator;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssSubmissionBy = this._ssSubmissionBy;
t._ssSubmissionOn = this._ssSubmissionOn;
t._ssServiceCalledBy = this._ssServiceCalledBy;
t._ssServiceCalledOn = this._ssServiceCalledOn;
t._ssBuyDocNumber = this._ssBuyDocNumber;
t._ssBuyDocPosition = this._ssBuyDocPosition;
t.ChangedAttributes = new BitArray(21);
t.OptimizedAttributes = new BitArray(21);
for(int i = 0; i < 21; i++){
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "servicetypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceTypeId")) variable.Value = ssServiceTypeId; else variable.Optimized = true;
} else if (head == "freetext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FreeText")) variable.Value = ssFreeText; else variable.Optimized = true;
} else if (head == "division") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Division")) variable.Value = ssDivision; else variable.Optimized = true;
} else if (head == "ivaamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IvaAmount")) variable.Value = ssIvaAmount; else variable.Optimized = true;
} else if (head == "iva_old") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Iva_Old")) variable.Value = ssIva_Old; else variable.Optimized = true;
} else if (head == "ivaindicatorid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IvaIndicatorId")) variable.Value = ssIvaIndicatorId; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "paymentmethodid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethodId")) variable.Value = ssPaymentMethodId; else variable.Optimized = true;
} else if (head == "paymenttermsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTermsId")) variable.Value = ssPaymentTermsId; else variable.Optimized = true;
} else if (head == "icmeindicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ICMEIndicator")) variable.Value = ssICMEIndicator; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "submissionby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubmissionBy")) variable.Value = ssSubmissionBy; else variable.Optimized = true;
} else if (head == "submissionon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SubmissionOn")) variable.Value = ssSubmissionOn; else variable.Optimized = true;
} else if (head == "servicecalledby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceCalledBy")) variable.Value = ssServiceCalledBy; else variable.Optimized = true;
} else if (head == "servicecalledon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceCalledOn")) variable.Value = ssServiceCalledOn; else variable.Optimized = true;
} else if (head == "buydocnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BuyDocNumber")) variable.Value = ssBuyDocNumber; else variable.Optimized = true;
} else if (head == "buydocposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BuyDocPosition")) variable.Value = ssBuyDocPosition; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdSupplierNumber)) {
return ChangedAttributes[2];
}
if (key.Equals(IdServiceTypeId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdFreeText)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDivision)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIvaAmount)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIva_Old)) {
return ChangedAttributes[7];
}
if (key.Equals(IdIvaIndicatorId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdTotalAmount)) {
return ChangedAttributes[9];
}
if (key.Equals(IdPaymentMethodId)) {
return ChangedAttributes[10];
}
if (key.Equals(IdPaymentTermsId)) {
return ChangedAttributes[11];
}
if (key.Equals(IdICMEIndicator)) {
return ChangedAttributes[12];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[13];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[14];
}
if (key.Equals(IdSubmissionBy)) {
return ChangedAttributes[15];
}
if (key.Equals(IdSubmissionOn)) {
return ChangedAttributes[16];
}
if (key.Equals(IdServiceCalledBy)) {
return ChangedAttributes[17];
}
if (key.Equals(IdServiceCalledOn)) {
return ChangedAttributes[18];
}
if (key.Equals(IdBuyDocNumber)) {
return ChangedAttributes[19];
}
if (key.Equals(IdBuyDocPosition)) {
return ChangedAttributes[20];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdSupplierNumber)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdServiceTypeId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdFreeText)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDivision)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIvaAmount)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIva_Old)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdIvaIndicatorId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdTotalAmount)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdPaymentMethodId)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdPaymentTermsId)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdICMEIndicator)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdSubmissionBy)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdSubmissionOn)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdServiceCalledBy)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdServiceCalledOn)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdBuyDocNumber)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdBuyDocPosition)) {
return OptimizedAttributes[20];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdServiceTypeId) {
return ssServiceTypeId;
}
if (key == IdFreeText) {
return ssFreeText;
}
if (key == IdDivision) {
return ssDivision;
}
if (key == IdIvaAmount) {
return ssIvaAmount;
}
if (key == IdIva_Old) {
return ssIva_Old;
}
if (key == IdIvaIndicatorId) {
return ssIvaIndicatorId;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdPaymentMethodId) {
return ssPaymentMethodId;
}
if (key == IdPaymentTermsId) {
return ssPaymentTermsId;
}
if (key == IdICMEIndicator) {
return ssICMEIndicator;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdSubmissionBy) {
return ssSubmissionBy;
}
if (key == IdSubmissionOn) {
return ssSubmissionOn;
}
if (key == IdServiceCalledBy) {
return ssServiceCalledBy;
}
if (key == IdServiceCalledOn) {
return ssServiceCalledOn;
}
if (key == IdBuyDocNumber) {
return ssBuyDocNumber;
}
if (key == IdBuyDocPosition) {
return ssBuyDocPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdServiceTypeId.Key.AsGuid) {
return ssServiceTypeId;
}
if (attributeKey == IdFreeText.Key.AsGuid) {
return ssFreeText;
}
if (attributeKey == IdDivision.Key.AsGuid) {
return ssDivision;
}
if (attributeKey == IdIvaAmount.Key.AsGuid) {
return ssIvaAmount;
}
if (attributeKey == IdIva_Old.Key.AsGuid) {
return ssIva_Old;
}
if (attributeKey == IdIvaIndicatorId.Key.AsGuid) {
return ssIvaIndicatorId;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdPaymentMethodId.Key.AsGuid) {
return ssPaymentMethodId;
}
if (attributeKey == IdPaymentTermsId.Key.AsGuid) {
return ssPaymentTermsId;
}
if (attributeKey == IdICMEIndicator.Key.AsGuid) {
return ssICMEIndicator;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdSubmissionBy.Key.AsGuid) {
return ssSubmissionBy;
}
if (attributeKey == IdSubmissionOn.Key.AsGuid) {
return ssSubmissionOn;
}
if (attributeKey == IdServiceCalledBy.Key.AsGuid) {
return ssServiceCalledBy;
}
if (attributeKey == IdServiceCalledOn.Key.AsGuid) {
return ssServiceCalledOn;
}
if (attributeKey == IdBuyDocNumber.Key.AsGuid) {
return ssBuyDocNumber;
}
if (attributeKey == IdBuyDocPosition.Key.AsGuid) {
return ssBuyDocPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(21);
OptimizedAttributes = new BitArray(21);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdSupplierNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdSupplierNumber);
ssServiceTypeId = (long) other.AttributeGet(IdServiceTypeId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdServiceTypeId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdServiceTypeId);
ssFreeText = (string) other.AttributeGet(IdFreeText);
ChangedAttributes[4] = other.ChangedAttributeGet(IdFreeText);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdFreeText);
ssDivision = (string) other.AttributeGet(IdDivision);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDivision);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDivision);
ssIvaAmount = (decimal) other.AttributeGet(IdIvaAmount);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIvaAmount);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIvaAmount);
ssIva_Old = (string) other.AttributeGet(IdIva_Old);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIva_Old);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIva_Old);
ssIvaIndicatorId = (long) other.AttributeGet(IdIvaIndicatorId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIvaIndicatorId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIvaIndicatorId);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ChangedAttributes[9] = other.ChangedAttributeGet(IdTotalAmount);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdTotalAmount);
ssPaymentMethodId = (long) other.AttributeGet(IdPaymentMethodId);
ChangedAttributes[10] = other.ChangedAttributeGet(IdPaymentMethodId);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdPaymentMethodId);
ssPaymentTermsId = (long) other.AttributeGet(IdPaymentTermsId);
ChangedAttributes[11] = other.ChangedAttributeGet(IdPaymentTermsId);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdPaymentTermsId);
ssICMEIndicator = (string) other.AttributeGet(IdICMEIndicator);
ChangedAttributes[12] = other.ChangedAttributeGet(IdICMEIndicator);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdICMEIndicator);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[13] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[14] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdCreatedOn);
ssSubmissionBy = (string) other.AttributeGet(IdSubmissionBy);
ChangedAttributes[15] = other.ChangedAttributeGet(IdSubmissionBy);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdSubmissionBy);
ssSubmissionOn = (DateTime) other.AttributeGet(IdSubmissionOn);
ChangedAttributes[16] = other.ChangedAttributeGet(IdSubmissionOn);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdSubmissionOn);
ssServiceCalledBy = (string) other.AttributeGet(IdServiceCalledBy);
ChangedAttributes[17] = other.ChangedAttributeGet(IdServiceCalledBy);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdServiceCalledBy);
ssServiceCalledOn = (DateTime) other.AttributeGet(IdServiceCalledOn);
ChangedAttributes[18] = other.ChangedAttributeGet(IdServiceCalledOn);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdServiceCalledOn);
ssBuyDocNumber = (string) other.AttributeGet(IdBuyDocNumber);
ChangedAttributes[19] = other.ChangedAttributeGet(IdBuyDocNumber);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdBuyDocNumber);
ssBuyDocPosition = (string) other.AttributeGet(IdBuyDocPosition);
ChangedAttributes[20] = other.ChangedAttributeGet(IdBuyDocPosition);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdBuyDocPosition);
}
} // EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord

/// <summary>
/// RecordList type <code>InvoiceAccountingList</code> that represents a record list of
///  <code>InvoiceAccounting</code>
/// </summary>
public partial class RL_2f36e552446053eaa4c1f1641c45b8a7 : GenericRecordList<EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord>, IEnumerable, IEnumerator {

protected override EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord GetElementDefaultValue() {
return new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
}

public T[] ToArray<T>(Func<EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2f36e552446053eaa4c1f1641c45b8a7 recordList, Func<EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2f36e552446053eaa4c1f1641c45b8a7(EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord[] array) {
  RL_2f36e552446053eaa4c1f1641c45b8a7 result = new RL_2f36e552446053eaa4c1f1641c45b8a7();
result.InnerFromArray(array);
    return result;
}

public static RL_2f36e552446053eaa4c1f1641c45b8a7 ToList<T>(T[] array, Func <T, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord> converter) {
  RL_2f36e552446053eaa4c1f1641c45b8a7 result = new RL_2f36e552446053eaa4c1f1641c45b8a7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2f36e552446053eaa4c1f1641c45b8a7 FromRestList<T>(RestList<T> restList, Func <T, EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord> converter) {
  RL_2f36e552446053eaa4c1f1641c45b8a7 result = new RL_2f36e552446053eaa4c1f1641c45b8a7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2f36e552446053eaa4c1f1641c45b8a7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord> NewList() {
return new RL_2f36e552446053eaa4c1f1641c45b8a7();
}


} // RL_2f36e552446053eaa4c1f1641c45b8a7
}
