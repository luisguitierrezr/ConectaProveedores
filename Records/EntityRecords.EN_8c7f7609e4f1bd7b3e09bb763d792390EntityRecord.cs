using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderAccounting (AqlYjTb8OUm0ztjSufMVsw)
///  <code>EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord</code> that represent
/// s <code>OrderAccounting</code> <p>Description: Order Accounting</p>
/// </summary>
// Name: OrderAccounting
public partial struct EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord : ITypedRecord<EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lpGIpK1+YUeCY0LwiKTioQ");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nES0E8W4PkCKJRC9tauXLg");
internal static readonly GlobalObjectKey IdHasEstim_Equal_AgrePaym_DEPR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2kElMugSXEWhHA+AD7+R6w");
internal static readonly GlobalObjectKey IdHasSettlement_DEPR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*46724yghnE+s2sSHL04i3A");
internal static readonly GlobalObjectKey IdHasCreditNote_DEPR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1xMhr9fqkUuKHnfy1mdFTQ");
internal static readonly GlobalObjectKey IdHasVoucher_DEPR = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UC1qGd9eVU+FbxjUa13dtw");
internal static readonly GlobalObjectKey IdHasSpecialPostDeliveryAuth = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yu9IcaZ69kGABslIHS6l4w");
internal static readonly GlobalObjectKey IdSpecialPostDeliveryAuthId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*x7h6KbJFp0GJjeOik06tPA");
internal static readonly GlobalObjectKey IdAmount_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*70P27T0eaUetCeFp6R5V_w");
internal static readonly GlobalObjectKey IdCurrencyId_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WQAgPxseMkylLxr27kgdEQ");
internal static readonly GlobalObjectKey IdPaymentMethodId_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ADgT+X89kkuzOUzSOCF1uQ");
internal static readonly GlobalObjectKey IdPaymentTermId_DEPREC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*o4sfx1nmoU2vGFNjscZ0hw");
internal static readonly GlobalObjectKey IdNegociatedExchangeRateAcc = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BZdC56Rh6UWzyenbUWvgxA");
internal static readonly GlobalObjectKey IdExchangeRateComment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8xAUfXtUL0uCzzi95LDYtA");
internal static readonly GlobalObjectKey IdEvidenceFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*R1Fzq89rCE+wVQkqjWk+Tw");
internal static readonly GlobalObjectKey IdHasContract = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4zVpihp62kqRFt7Cj34tkA");
internal static readonly GlobalObjectKey IdHasREPSE = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eH+EVcZ+J0SUfcJw6YVfgA");
internal static readonly GlobalObjectKey IdHasPaymentSupplement = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tIUsS0c4DUWY37YAft0Hdg");
internal static readonly GlobalObjectKey IdHasNoticeOfPaymentSuspension = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tzx9Mn57Y0SJtOzTsebs3Q");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(19,true);
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

private bool _ssHasEstim_Equal_AgrePaym_DEPR;
public bool ssHasEstim_Equal_AgrePaym_DEPR{
  get{
      return _ssHasEstim_Equal_AgrePaym_DEPR;
  }
  set{
      if((_ssHasEstim_Equal_AgrePaym_DEPR!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssHasEstim_Equal_AgrePaym_DEPR = value;
      }
  }
}

private bool _ssHasSettlement_DEPR;
public bool ssHasSettlement_DEPR{
  get{
      return _ssHasSettlement_DEPR;
  }
  set{
      if((_ssHasSettlement_DEPR!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssHasSettlement_DEPR = value;
      }
  }
}

private bool _ssHasCreditNote_DEPR;
public bool ssHasCreditNote_DEPR{
  get{
      return _ssHasCreditNote_DEPR;
  }
  set{
      if((_ssHasCreditNote_DEPR!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssHasCreditNote_DEPR = value;
      }
  }
}

private bool _ssHasVoucher_DEPR;
public bool ssHasVoucher_DEPR{
  get{
      return _ssHasVoucher_DEPR;
  }
  set{
      if((_ssHasVoucher_DEPR!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssHasVoucher_DEPR = value;
      }
  }
}

private bool _ssHasSpecialPostDeliveryAuth;
public bool ssHasSpecialPostDeliveryAuth{
  get{
      return _ssHasSpecialPostDeliveryAuth;
  }
  set{
      if((_ssHasSpecialPostDeliveryAuth!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssHasSpecialPostDeliveryAuth = value;
      }
  }
}

private int _ssSpecialPostDeliveryAuthId;
public int ssSpecialPostDeliveryAuthId{
  get{
      return _ssSpecialPostDeliveryAuthId;
  }
  set{
      if((_ssSpecialPostDeliveryAuthId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssSpecialPostDeliveryAuthId = value;
      }
  }
}

private decimal _ssAmount_DEPREC;
public decimal ssAmount_DEPREC{
  get{
      return _ssAmount_DEPREC;
  }
  set{
      if((_ssAmount_DEPREC!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssAmount_DEPREC = value;
      }
  }
}

private string _ssCurrencyId_DEPREC;
public string ssCurrencyId_DEPREC{
  get{
      return _ssCurrencyId_DEPREC;
  }
  set{
      if((_ssCurrencyId_DEPREC!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssCurrencyId_DEPREC = value;
      }
  }
}

private long _ssPaymentMethodId_DEPREC;
public long ssPaymentMethodId_DEPREC{
  get{
      return _ssPaymentMethodId_DEPREC;
  }
  set{
      if((_ssPaymentMethodId_DEPREC!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssPaymentMethodId_DEPREC = value;
      }
  }
}

private long _ssPaymentTermId_DEPREC;
public long ssPaymentTermId_DEPREC{
  get{
      return _ssPaymentTermId_DEPREC;
  }
  set{
      if((_ssPaymentTermId_DEPREC!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssPaymentTermId_DEPREC = value;
      }
  }
}

private decimal _ssNegociatedExchangeRateAcc;
public decimal ssNegociatedExchangeRateAcc{
  get{
      return _ssNegociatedExchangeRateAcc;
  }
  set{
      if((_ssNegociatedExchangeRateAcc!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssNegociatedExchangeRateAcc = value;
      }
  }
}

private string _ssExchangeRateComment;
public string ssExchangeRateComment{
  get{
      return _ssExchangeRateComment;
  }
  set{
      if((_ssExchangeRateComment!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssExchangeRateComment = value;
      }
  }
}

private long _ssEvidenceFileId;
public long ssEvidenceFileId{
  get{
      return _ssEvidenceFileId;
  }
  set{
      if((_ssEvidenceFileId!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssEvidenceFileId = value;
      }
  }
}

private bool _ssHasContract;
public bool ssHasContract{
  get{
      return _ssHasContract;
  }
  set{
      if((_ssHasContract!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssHasContract = value;
      }
  }
}

private bool _ssHasREPSE;
public bool ssHasREPSE{
  get{
      return _ssHasREPSE;
  }
  set{
      if((_ssHasREPSE!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssHasREPSE = value;
      }
  }
}

private bool _ssHasPaymentSupplement;
public bool ssHasPaymentSupplement{
  get{
      return _ssHasPaymentSupplement;
  }
  set{
      if((_ssHasPaymentSupplement!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssHasPaymentSupplement = value;
      }
  }
}

private bool _ssHasNoticeOfPaymentSuspension;
public bool ssHasNoticeOfPaymentSuspension{
  get{
      return _ssHasNoticeOfPaymentSuspension;
  }
  set{
      if((_ssHasNoticeOfPaymentSuspension!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssHasNoticeOfPaymentSuspension = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord() {
ChangedAttributes = new BitArray(19,true);
OptimizedAttributes = new BitArray(19,false);
_ssId = 0L;
_ssOrderId = 0L;
_ssHasEstim_Equal_AgrePaym_DEPR = false;
_ssHasSettlement_DEPR = false;
_ssHasCreditNote_DEPR = false;
_ssHasVoucher_DEPR = false;
_ssHasSpecialPostDeliveryAuth = false;
_ssSpecialPostDeliveryAuthId = 0;
_ssAmount_DEPREC = 0.0M;
_ssCurrencyId_DEPREC = "";
_ssPaymentMethodId_DEPREC = 0L;
_ssPaymentTermId_DEPREC = 0L;
_ssNegociatedExchangeRateAcc = 0.0M;
_ssExchangeRateComment = "";
_ssEvidenceFileId = 0L;
_ssHasContract = false;
_ssHasREPSE = false;
_ssHasPaymentSupplement = false;
_ssHasNoticeOfPaymentSuspension = false;
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
ssId = r.ReadLongInteger(index++, "OrderAccounting.Id", 0L);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderAccounting.OrderId", 0L);
ssHasEstim_Equal_AgrePaym_DEPR = r.ReadBoolean(index++, "OrderAccounting.HasEstim_Equal_AgrePaym_DEPR", false);
ssHasSettlement_DEPR = r.ReadBoolean(index++, "OrderAccounting.HasSettlement_DEPR", false);
ssHasCreditNote_DEPR = r.ReadBoolean(index++, "OrderAccounting.HasCreditNote_DEPR", false);
ssHasVoucher_DEPR = r.ReadBoolean(index++, "OrderAccounting.HasVoucher_DEPR", false);
ssHasSpecialPostDeliveryAuth = r.ReadBoolean(index++, "OrderAccounting.HasSpecialPostDeliveryAuth", false);
ssSpecialPostDeliveryAuthId = r.ReadEntityReference(index++, "OrderAccounting.SpecialPostDeliveryAuthId", 0);
ssAmount_DEPREC = r.ReadDecimal(index++, "OrderAccounting.Amount_DEPREC", 0.0M);
ssCurrencyId_DEPREC = r.ReadEntityReferenceText(index++, "OrderAccounting.CurrencyId_DEPREC", "");
ssPaymentMethodId_DEPREC = r.ReadEntityReferenceLongInteger(index++, "OrderAccounting.PaymentMethodId_DEPREC", 0L);
ssPaymentTermId_DEPREC = r.ReadEntityReferenceLongInteger(index++, "OrderAccounting.PaymentTermId_DEPREC", 0L);
ssNegociatedExchangeRateAcc = r.ReadDecimal(index++, "OrderAccounting.NegociatedExchangeRateAcc", 0.0M);
ssExchangeRateComment = r.ReadText(index++, "OrderAccounting.ExchangeRateComment", "");
ssEvidenceFileId = r.ReadEntityReferenceLongInteger(index++, "OrderAccounting.EvidenceFileId", 0L);
ssHasContract = r.ReadBoolean(index++, "OrderAccounting.HasContract", false);
ssHasREPSE = r.ReadBoolean(index++, "OrderAccounting.HasREPSE", false);
ssHasPaymentSupplement = r.ReadBoolean(index++, "OrderAccounting.HasPaymentSupplement", false);
ssHasNoticeOfPaymentSuspension = r.ReadBoolean(index++, "OrderAccounting.HasNoticeOfPaymentSuspension", false);
ChangedAttributes = new BitArray(19,false);
OptimizedAttributes = new BitArray(19,false);
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
public void ReadIM(EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord r) {
this = r;
}


public static bool operator == (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord a, EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssHasEstim_Equal_AgrePaym_DEPR != b.ssHasEstim_Equal_AgrePaym_DEPR) return false;
if (a.ssHasSettlement_DEPR != b.ssHasSettlement_DEPR) return false;
if (a.ssHasCreditNote_DEPR != b.ssHasCreditNote_DEPR) return false;
if (a.ssHasVoucher_DEPR != b.ssHasVoucher_DEPR) return false;
if (a.ssHasSpecialPostDeliveryAuth != b.ssHasSpecialPostDeliveryAuth) return false;
if (a.ssSpecialPostDeliveryAuthId != b.ssSpecialPostDeliveryAuthId) return false;
if (a.ssAmount_DEPREC != b.ssAmount_DEPREC) return false;
if (a.ssCurrencyId_DEPREC != b.ssCurrencyId_DEPREC) return false;
if (a.ssPaymentMethodId_DEPREC != b.ssPaymentMethodId_DEPREC) return false;
if (a.ssPaymentTermId_DEPREC != b.ssPaymentTermId_DEPREC) return false;
if (a.ssNegociatedExchangeRateAcc != b.ssNegociatedExchangeRateAcc) return false;
if (a.ssExchangeRateComment != b.ssExchangeRateComment) return false;
if (a.ssEvidenceFileId != b.ssEvidenceFileId) return false;
if (a.ssHasContract != b.ssHasContract) return false;
if (a.ssHasREPSE != b.ssHasREPSE) return false;
if (a.ssHasPaymentSupplement != b.ssHasPaymentSupplement) return false;
if (a.ssHasNoticeOfPaymentSuspension != b.ssHasNoticeOfPaymentSuspension) return false;
return true;
}

public static bool operator != (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord a, EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)) return false;
return (this == (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderId.GetHashCode()
 ^ ssHasEstim_Equal_AgrePaym_DEPR.GetHashCode()
 ^ ssHasSettlement_DEPR.GetHashCode()
 ^ ssHasCreditNote_DEPR.GetHashCode()
 ^ ssHasVoucher_DEPR.GetHashCode()
 ^ ssHasSpecialPostDeliveryAuth.GetHashCode()
 ^ ssSpecialPostDeliveryAuthId.GetHashCode()
 ^ ssAmount_DEPREC.GetHashCode()
 ^ ssCurrencyId_DEPREC.GetHashCode()
 ^ ssPaymentMethodId_DEPREC.GetHashCode()
 ^ ssPaymentTermId_DEPREC.GetHashCode()
 ^ ssNegociatedExchangeRateAcc.GetHashCode()
 ^ ssExchangeRateComment.GetHashCode()
 ^ ssEvidenceFileId.GetHashCode()
 ^ ssHasContract.GetHashCode()
 ^ ssHasREPSE.GetHashCode()
 ^ ssHasPaymentSupplement.GetHashCode()
 ^ ssHasNoticeOfPaymentSuspension.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord Duplicate() {
EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord t;
t._ssId = this._ssId;
t._ssOrderId = this._ssOrderId;
t._ssHasEstim_Equal_AgrePaym_DEPR = this._ssHasEstim_Equal_AgrePaym_DEPR;
t._ssHasSettlement_DEPR = this._ssHasSettlement_DEPR;
t._ssHasCreditNote_DEPR = this._ssHasCreditNote_DEPR;
t._ssHasVoucher_DEPR = this._ssHasVoucher_DEPR;
t._ssHasSpecialPostDeliveryAuth = this._ssHasSpecialPostDeliveryAuth;
t._ssSpecialPostDeliveryAuthId = this._ssSpecialPostDeliveryAuthId;
t._ssAmount_DEPREC = this._ssAmount_DEPREC;
t._ssCurrencyId_DEPREC = this._ssCurrencyId_DEPREC;
t._ssPaymentMethodId_DEPREC = this._ssPaymentMethodId_DEPREC;
t._ssPaymentTermId_DEPREC = this._ssPaymentTermId_DEPREC;
t._ssNegociatedExchangeRateAcc = this._ssNegociatedExchangeRateAcc;
t._ssExchangeRateComment = this._ssExchangeRateComment;
t._ssEvidenceFileId = this._ssEvidenceFileId;
t._ssHasContract = this._ssHasContract;
t._ssHasREPSE = this._ssHasREPSE;
t._ssHasPaymentSupplement = this._ssHasPaymentSupplement;
t._ssHasNoticeOfPaymentSuspension = this._ssHasNoticeOfPaymentSuspension;
t.ChangedAttributes = new BitArray(19);
t.OptimizedAttributes = new BitArray(19);
for(int i = 0; i < 19; i++){
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
} else if (head == "hasestim_equal_agrepaym_depr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasEstim_Equal_AgrePaym_DEPR")) variable.Value = ssHasEstim_Equal_AgrePaym_DEPR; else variable.Optimized = true;
} else if (head == "hassettlement_depr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasSettlement_DEPR")) variable.Value = ssHasSettlement_DEPR; else variable.Optimized = true;
} else if (head == "hascreditnote_depr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasCreditNote_DEPR")) variable.Value = ssHasCreditNote_DEPR; else variable.Optimized = true;
} else if (head == "hasvoucher_depr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasVoucher_DEPR")) variable.Value = ssHasVoucher_DEPR; else variable.Optimized = true;
} else if (head == "hasspecialpostdeliveryauth") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasSpecialPostDeliveryAuth")) variable.Value = ssHasSpecialPostDeliveryAuth; else variable.Optimized = true;
} else if (head == "specialpostdeliveryauthid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialPostDeliveryAuthId")) variable.Value = ssSpecialPostDeliveryAuthId; else variable.Optimized = true;
} else if (head == "amount_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amount_DEPREC")) variable.Value = ssAmount_DEPREC; else variable.Optimized = true;
} else if (head == "currencyid_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId_DEPREC")) variable.Value = ssCurrencyId_DEPREC; else variable.Optimized = true;
} else if (head == "paymentmethodid_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethodId_DEPREC")) variable.Value = ssPaymentMethodId_DEPREC; else variable.Optimized = true;
} else if (head == "paymenttermid_deprec") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTermId_DEPREC")) variable.Value = ssPaymentTermId_DEPREC; else variable.Optimized = true;
} else if (head == "negociatedexchangerateacc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NegociatedExchangeRateAcc")) variable.Value = ssNegociatedExchangeRateAcc; else variable.Optimized = true;
} else if (head == "exchangeratecomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExchangeRateComment")) variable.Value = ssExchangeRateComment; else variable.Optimized = true;
} else if (head == "evidencefileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EvidenceFileId")) variable.Value = ssEvidenceFileId; else variable.Optimized = true;
} else if (head == "hascontract") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasContract")) variable.Value = ssHasContract; else variable.Optimized = true;
} else if (head == "hasrepse") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasREPSE")) variable.Value = ssHasREPSE; else variable.Optimized = true;
} else if (head == "haspaymentsupplement") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasPaymentSupplement")) variable.Value = ssHasPaymentSupplement; else variable.Optimized = true;
} else if (head == "hasnoticeofpaymentsuspension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasNoticeOfPaymentSuspension")) variable.Value = ssHasNoticeOfPaymentSuspension; else variable.Optimized = true;
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
if (key.Equals(IdHasEstim_Equal_AgrePaym_DEPR)) {
return ChangedAttributes[2];
}
if (key.Equals(IdHasSettlement_DEPR)) {
return ChangedAttributes[3];
}
if (key.Equals(IdHasCreditNote_DEPR)) {
return ChangedAttributes[4];
}
if (key.Equals(IdHasVoucher_DEPR)) {
return ChangedAttributes[5];
}
if (key.Equals(IdHasSpecialPostDeliveryAuth)) {
return ChangedAttributes[6];
}
if (key.Equals(IdSpecialPostDeliveryAuthId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdAmount_DEPREC)) {
return ChangedAttributes[8];
}
if (key.Equals(IdCurrencyId_DEPREC)) {
return ChangedAttributes[9];
}
if (key.Equals(IdPaymentMethodId_DEPREC)) {
return ChangedAttributes[10];
}
if (key.Equals(IdPaymentTermId_DEPREC)) {
return ChangedAttributes[11];
}
if (key.Equals(IdNegociatedExchangeRateAcc)) {
return ChangedAttributes[12];
}
if (key.Equals(IdExchangeRateComment)) {
return ChangedAttributes[13];
}
if (key.Equals(IdEvidenceFileId)) {
return ChangedAttributes[14];
}
if (key.Equals(IdHasContract)) {
return ChangedAttributes[15];
}
if (key.Equals(IdHasREPSE)) {
return ChangedAttributes[16];
}
if (key.Equals(IdHasPaymentSupplement)) {
return ChangedAttributes[17];
}
if (key.Equals(IdHasNoticeOfPaymentSuspension)) {
return ChangedAttributes[18];
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
if (key.Equals(IdHasEstim_Equal_AgrePaym_DEPR)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdHasSettlement_DEPR)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdHasCreditNote_DEPR)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdHasVoucher_DEPR)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdHasSpecialPostDeliveryAuth)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdSpecialPostDeliveryAuthId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdAmount_DEPREC)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdCurrencyId_DEPREC)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdPaymentMethodId_DEPREC)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdPaymentTermId_DEPREC)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdNegociatedExchangeRateAcc)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdExchangeRateComment)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdEvidenceFileId)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdHasContract)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdHasREPSE)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdHasPaymentSupplement)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdHasNoticeOfPaymentSuspension)) {
return OptimizedAttributes[18];
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
if (key == IdHasEstim_Equal_AgrePaym_DEPR) {
return ssHasEstim_Equal_AgrePaym_DEPR;
}
if (key == IdHasSettlement_DEPR) {
return ssHasSettlement_DEPR;
}
if (key == IdHasCreditNote_DEPR) {
return ssHasCreditNote_DEPR;
}
if (key == IdHasVoucher_DEPR) {
return ssHasVoucher_DEPR;
}
if (key == IdHasSpecialPostDeliveryAuth) {
return ssHasSpecialPostDeliveryAuth;
}
if (key == IdSpecialPostDeliveryAuthId) {
return ssSpecialPostDeliveryAuthId;
}
if (key == IdAmount_DEPREC) {
return ssAmount_DEPREC;
}
if (key == IdCurrencyId_DEPREC) {
return ssCurrencyId_DEPREC;
}
if (key == IdPaymentMethodId_DEPREC) {
return ssPaymentMethodId_DEPREC;
}
if (key == IdPaymentTermId_DEPREC) {
return ssPaymentTermId_DEPREC;
}
if (key == IdNegociatedExchangeRateAcc) {
return ssNegociatedExchangeRateAcc;
}
if (key == IdExchangeRateComment) {
return ssExchangeRateComment;
}
if (key == IdEvidenceFileId) {
return ssEvidenceFileId;
}
if (key == IdHasContract) {
return ssHasContract;
}
if (key == IdHasREPSE) {
return ssHasREPSE;
}
if (key == IdHasPaymentSupplement) {
return ssHasPaymentSupplement;
}
if (key == IdHasNoticeOfPaymentSuspension) {
return ssHasNoticeOfPaymentSuspension;
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
if (attributeKey == IdHasEstim_Equal_AgrePaym_DEPR.Key.AsGuid) {
return ssHasEstim_Equal_AgrePaym_DEPR;
}
if (attributeKey == IdHasSettlement_DEPR.Key.AsGuid) {
return ssHasSettlement_DEPR;
}
if (attributeKey == IdHasCreditNote_DEPR.Key.AsGuid) {
return ssHasCreditNote_DEPR;
}
if (attributeKey == IdHasVoucher_DEPR.Key.AsGuid) {
return ssHasVoucher_DEPR;
}
if (attributeKey == IdHasSpecialPostDeliveryAuth.Key.AsGuid) {
return ssHasSpecialPostDeliveryAuth;
}
if (attributeKey == IdSpecialPostDeliveryAuthId.Key.AsGuid) {
return ssSpecialPostDeliveryAuthId;
}
if (attributeKey == IdAmount_DEPREC.Key.AsGuid) {
return ssAmount_DEPREC;
}
if (attributeKey == IdCurrencyId_DEPREC.Key.AsGuid) {
return ssCurrencyId_DEPREC;
}
if (attributeKey == IdPaymentMethodId_DEPREC.Key.AsGuid) {
return ssPaymentMethodId_DEPREC;
}
if (attributeKey == IdPaymentTermId_DEPREC.Key.AsGuid) {
return ssPaymentTermId_DEPREC;
}
if (attributeKey == IdNegociatedExchangeRateAcc.Key.AsGuid) {
return ssNegociatedExchangeRateAcc;
}
if (attributeKey == IdExchangeRateComment.Key.AsGuid) {
return ssExchangeRateComment;
}
if (attributeKey == IdEvidenceFileId.Key.AsGuid) {
return ssEvidenceFileId;
}
if (attributeKey == IdHasContract.Key.AsGuid) {
return ssHasContract;
}
if (attributeKey == IdHasREPSE.Key.AsGuid) {
return ssHasREPSE;
}
if (attributeKey == IdHasPaymentSupplement.Key.AsGuid) {
return ssHasPaymentSupplement;
}
if (attributeKey == IdHasNoticeOfPaymentSuspension.Key.AsGuid) {
return ssHasNoticeOfPaymentSuspension;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(19);
OptimizedAttributes = new BitArray(19);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderId);
ssHasEstim_Equal_AgrePaym_DEPR = (bool) other.AttributeGet(IdHasEstim_Equal_AgrePaym_DEPR);
ChangedAttributes[2] = other.ChangedAttributeGet(IdHasEstim_Equal_AgrePaym_DEPR);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdHasEstim_Equal_AgrePaym_DEPR);
ssHasSettlement_DEPR = (bool) other.AttributeGet(IdHasSettlement_DEPR);
ChangedAttributes[3] = other.ChangedAttributeGet(IdHasSettlement_DEPR);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdHasSettlement_DEPR);
ssHasCreditNote_DEPR = (bool) other.AttributeGet(IdHasCreditNote_DEPR);
ChangedAttributes[4] = other.ChangedAttributeGet(IdHasCreditNote_DEPR);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdHasCreditNote_DEPR);
ssHasVoucher_DEPR = (bool) other.AttributeGet(IdHasVoucher_DEPR);
ChangedAttributes[5] = other.ChangedAttributeGet(IdHasVoucher_DEPR);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdHasVoucher_DEPR);
ssHasSpecialPostDeliveryAuth = (bool) other.AttributeGet(IdHasSpecialPostDeliveryAuth);
ChangedAttributes[6] = other.ChangedAttributeGet(IdHasSpecialPostDeliveryAuth);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdHasSpecialPostDeliveryAuth);
ssSpecialPostDeliveryAuthId = (int) other.AttributeGet(IdSpecialPostDeliveryAuthId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdSpecialPostDeliveryAuthId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdSpecialPostDeliveryAuthId);
ssAmount_DEPREC = (decimal) other.AttributeGet(IdAmount_DEPREC);
ChangedAttributes[8] = other.ChangedAttributeGet(IdAmount_DEPREC);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdAmount_DEPREC);
ssCurrencyId_DEPREC = (string) other.AttributeGet(IdCurrencyId_DEPREC);
ChangedAttributes[9] = other.ChangedAttributeGet(IdCurrencyId_DEPREC);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdCurrencyId_DEPREC);
ssPaymentMethodId_DEPREC = (long) other.AttributeGet(IdPaymentMethodId_DEPREC);
ChangedAttributes[10] = other.ChangedAttributeGet(IdPaymentMethodId_DEPREC);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdPaymentMethodId_DEPREC);
ssPaymentTermId_DEPREC = (long) other.AttributeGet(IdPaymentTermId_DEPREC);
ChangedAttributes[11] = other.ChangedAttributeGet(IdPaymentTermId_DEPREC);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdPaymentTermId_DEPREC);
ssNegociatedExchangeRateAcc = (decimal) other.AttributeGet(IdNegociatedExchangeRateAcc);
ChangedAttributes[12] = other.ChangedAttributeGet(IdNegociatedExchangeRateAcc);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdNegociatedExchangeRateAcc);
ssExchangeRateComment = (string) other.AttributeGet(IdExchangeRateComment);
ChangedAttributes[13] = other.ChangedAttributeGet(IdExchangeRateComment);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdExchangeRateComment);
ssEvidenceFileId = (long) other.AttributeGet(IdEvidenceFileId);
ChangedAttributes[14] = other.ChangedAttributeGet(IdEvidenceFileId);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdEvidenceFileId);
ssHasContract = (bool) other.AttributeGet(IdHasContract);
ChangedAttributes[15] = other.ChangedAttributeGet(IdHasContract);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdHasContract);
ssHasREPSE = (bool) other.AttributeGet(IdHasREPSE);
ChangedAttributes[16] = other.ChangedAttributeGet(IdHasREPSE);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdHasREPSE);
ssHasPaymentSupplement = (bool) other.AttributeGet(IdHasPaymentSupplement);
ChangedAttributes[17] = other.ChangedAttributeGet(IdHasPaymentSupplement);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdHasPaymentSupplement);
ssHasNoticeOfPaymentSuspension = (bool) other.AttributeGet(IdHasNoticeOfPaymentSuspension);
ChangedAttributes[18] = other.ChangedAttributeGet(IdHasNoticeOfPaymentSuspension);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdHasNoticeOfPaymentSuspension);
}
} // EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord

/// <summary>
/// RecordList type <code>OrderAccountingList</code> that represents a record list of
///  <code>OrderAccounting</code>
/// </summary>
public partial class RL_a559030308d05bce31480a3d4b92bfaf : GenericRecordList<EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord>, IEnumerable, IEnumerator {

protected override EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord GetElementDefaultValue() {
return new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
}

public T[] ToArray<T>(Func<EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a559030308d05bce31480a3d4b92bfaf recordList, Func<EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a559030308d05bce31480a3d4b92bfaf(EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord[] array) {
  RL_a559030308d05bce31480a3d4b92bfaf result = new RL_a559030308d05bce31480a3d4b92bfaf();
result.InnerFromArray(array);
    return result;
}

public static RL_a559030308d05bce31480a3d4b92bfaf ToList<T>(T[] array, Func <T, EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord> converter) {
  RL_a559030308d05bce31480a3d4b92bfaf result = new RL_a559030308d05bce31480a3d4b92bfaf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a559030308d05bce31480a3d4b92bfaf FromRestList<T>(RestList<T> restList, Func <T, EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord> converter) {
  RL_a559030308d05bce31480a3d4b92bfaf result = new RL_a559030308d05bce31480a3d4b92bfaf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a559030308d05bce31480a3d4b92bfaf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord> NewList() {
return new RL_a559030308d05bce31480a3d4b92bfaf();
}


} // RL_a559030308d05bce31480a3d4b92bfaf
}
