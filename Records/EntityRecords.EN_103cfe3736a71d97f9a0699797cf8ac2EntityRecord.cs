using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceAccountingServices (XHaOke0iJUSRlyn+wMzEHw)
///  <code>EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord</code> that represent
/// s <code>InvoiceAccountingServices</code> <p>Description: Entity that holds Invoice Accounting
///  Services.</p>
/// </summary>
// Name: InvoiceAccountingServices
public partial struct EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord : ITypedRecord<EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KFBV3p9fcEa73Uuy6TThyg");
internal static readonly GlobalObjectKey IdInvoiceAccountingId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*68vvTrBVN0yWtuy59rLbqg");
internal static readonly GlobalObjectKey IdServiceTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EK47AE7IG0ih25bsIpJclQ");
internal static readonly GlobalObjectKey IdAccount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6Kcmm6TM+kyEA29liF6gSQ");
internal static readonly GlobalObjectKey IdCostCenterId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DBqJoxtC30e_3bpjDdAimA");
internal static readonly GlobalObjectKey IdCeBeCostCenterId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BCdFIc_WHkWFy6qxZ0fANA");
internal static readonly GlobalObjectKey IdAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZiRY1FuV50Orp2vx6aZTkA");
internal static readonly GlobalObjectKey IdIVA_Old = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ex0iVny3L0yHUrE88jUUQw");
internal static readonly GlobalObjectKey IdIVAIndicatorId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uuljXXCXvU2vmlVKkjuKiw");
internal static readonly GlobalObjectKey IdBuyDocNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*y09TkukY9kmLnJmW1Kj2zg");
internal static readonly GlobalObjectKey IdBuyDocPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1GKh2z6cyk63JvMMXfmZfA");
internal static readonly GlobalObjectKey IdFreeText = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nyKiczUG3kSfoEazS4C2dA");
internal static readonly GlobalObjectKey IdDivision = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7p0OMpkfJ0i_lMnd_fUyYg");
internal static readonly GlobalObjectKey IdICME = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*W+ZgmWkbj0+2x72jYcqN9A");

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

private long _ssInvoiceAccountingId;
public long ssInvoiceAccountingId{
  get{
      return _ssInvoiceAccountingId;
  }
  set{
      if((_ssInvoiceAccountingId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceAccountingId = value;
      }
  }
}

private long _ssServiceTypeId;
public long ssServiceTypeId{
  get{
      return _ssServiceTypeId;
  }
  set{
      if((_ssServiceTypeId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssServiceTypeId = value;
      }
  }
}

private string _ssAccount;
public string ssAccount{
  get{
      return _ssAccount;
  }
  set{
      if((_ssAccount!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssAccount = value;
      }
  }
}

private long _ssCostCenterId;
public long ssCostCenterId{
  get{
      return _ssCostCenterId;
  }
  set{
      if((_ssCostCenterId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCostCenterId = value;
      }
  }
}

private long _ssCeBeCostCenterId;
public long ssCeBeCostCenterId{
  get{
      return _ssCeBeCostCenterId;
  }
  set{
      if((_ssCeBeCostCenterId!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCeBeCostCenterId = value;
      }
  }
}

private decimal _ssAmount;
public decimal ssAmount{
  get{
      return _ssAmount;
  }
  set{
      if((_ssAmount!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssAmount = value;
      }
  }
}

private string _ssIVA_Old;
public string ssIVA_Old{
  get{
      return _ssIVA_Old;
  }
  set{
      if((_ssIVA_Old!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIVA_Old = value;
      }
  }
}

private long _ssIVAIndicatorId;
public long ssIVAIndicatorId{
  get{
      return _ssIVAIndicatorId;
  }
  set{
      if((_ssIVAIndicatorId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssIVAIndicatorId = value;
      }
  }
}

private string _ssBuyDocNumber;
public string ssBuyDocNumber{
  get{
      return _ssBuyDocNumber;
  }
  set{
      if((_ssBuyDocNumber!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
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
      if((_ssBuyDocPosition!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssBuyDocPosition = value;
      }
  }
}

private string _ssFreeText;
public string ssFreeText{
  get{
      return _ssFreeText;
  }
  set{
      if((_ssFreeText!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
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
      if((_ssDivision!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssDivision = value;
      }
  }
}

private string _ssICME;
public string ssICME{
  get{
      return _ssICME;
  }
  set{
      if((_ssICME!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssICME = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord() {
ChangedAttributes = new BitArray(14,true);
OptimizedAttributes = new BitArray(14,false);
_ssId = 0L;
_ssInvoiceAccountingId = 0L;
_ssServiceTypeId = 0L;
_ssAccount = "";
_ssCostCenterId = 0L;
_ssCeBeCostCenterId = 0L;
_ssAmount = 0.0M;
_ssIVA_Old = "";
_ssIVAIndicatorId = 0L;
_ssBuyDocNumber = "";
_ssBuyDocPosition = "";
_ssFreeText = "";
_ssDivision = "";
_ssICME = "";
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
ssId = r.ReadLongInteger(index++, "InvoiceAccountingServices.Id", 0L);
ssInvoiceAccountingId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingServices.InvoiceAccountingId", 0L);
ssServiceTypeId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingServices.ServiceTypeId", 0L);
ssAccount = r.ReadText(index++, "InvoiceAccountingServices.Account", "");
ssCostCenterId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingServices.CostCenterId", 0L);
ssCeBeCostCenterId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingServices.CeBeCostCenterId", 0L);
ssAmount = r.ReadDecimal(index++, "InvoiceAccountingServices.Amount", 0.0M);
ssIVA_Old = r.ReadText(index++, "InvoiceAccountingServices.IVA_Old", "");
ssIVAIndicatorId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingServices.IVAIndicatorId", 0L);
ssBuyDocNumber = r.ReadText(index++, "InvoiceAccountingServices.BuyDocNumber", "");
ssBuyDocPosition = r.ReadText(index++, "InvoiceAccountingServices.BuyDocPosition", "");
ssFreeText = r.ReadText(index++, "InvoiceAccountingServices.FreeText", "");
ssDivision = r.ReadText(index++, "InvoiceAccountingServices.Division", "");
ssICME = r.ReadText(index++, "InvoiceAccountingServices.ICME", "");
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
public void ReadIM(EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord r) {
this = r;
}


public static bool operator == (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord a, EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceAccountingId != b.ssInvoiceAccountingId) return false;
if (a.ssServiceTypeId != b.ssServiceTypeId) return false;
if (a.ssAccount != b.ssAccount) return false;
if (a.ssCostCenterId != b.ssCostCenterId) return false;
if (a.ssCeBeCostCenterId != b.ssCeBeCostCenterId) return false;
if (a.ssAmount != b.ssAmount) return false;
if (a.ssIVA_Old != b.ssIVA_Old) return false;
if (a.ssIVAIndicatorId != b.ssIVAIndicatorId) return false;
if (a.ssBuyDocNumber != b.ssBuyDocNumber) return false;
if (a.ssBuyDocPosition != b.ssBuyDocPosition) return false;
if (a.ssFreeText != b.ssFreeText) return false;
if (a.ssDivision != b.ssDivision) return false;
if (a.ssICME != b.ssICME) return false;
return true;
}

public static bool operator != (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord a, EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord)) return false;
return (this == (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceAccountingId.GetHashCode()
 ^ ssServiceTypeId.GetHashCode()
 ^ ssAccount.GetHashCode()
 ^ ssCostCenterId.GetHashCode()
 ^ ssCeBeCostCenterId.GetHashCode()
 ^ ssAmount.GetHashCode()
 ^ ssIVA_Old.GetHashCode()
 ^ ssIVAIndicatorId.GetHashCode()
 ^ ssBuyDocNumber.GetHashCode()
 ^ ssBuyDocPosition.GetHashCode()
 ^ ssFreeText.GetHashCode()
 ^ ssDivision.GetHashCode()
 ^ ssICME.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord Duplicate() {
EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceAccountingId = this._ssInvoiceAccountingId;
t._ssServiceTypeId = this._ssServiceTypeId;
t._ssAccount = this._ssAccount;
t._ssCostCenterId = this._ssCostCenterId;
t._ssCeBeCostCenterId = this._ssCeBeCostCenterId;
t._ssAmount = this._ssAmount;
t._ssIVA_Old = this._ssIVA_Old;
t._ssIVAIndicatorId = this._ssIVAIndicatorId;
t._ssBuyDocNumber = this._ssBuyDocNumber;
t._ssBuyDocPosition = this._ssBuyDocPosition;
t._ssFreeText = this._ssFreeText;
t._ssDivision = this._ssDivision;
t._ssICME = this._ssICME;
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
} else if (head == "invoiceaccountingid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingId")) variable.Value = ssInvoiceAccountingId; else variable.Optimized = true;
} else if (head == "servicetypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceTypeId")) variable.Value = ssServiceTypeId; else variable.Optimized = true;
} else if (head == "account") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Account")) variable.Value = ssAccount; else variable.Optimized = true;
} else if (head == "costcenterid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterId")) variable.Value = ssCostCenterId; else variable.Optimized = true;
} else if (head == "cebecostcenterid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CeBeCostCenterId")) variable.Value = ssCeBeCostCenterId; else variable.Optimized = true;
} else if (head == "amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amount")) variable.Value = ssAmount; else variable.Optimized = true;
} else if (head == "iva_old") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IVA_Old")) variable.Value = ssIVA_Old; else variable.Optimized = true;
} else if (head == "ivaindicatorid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IVAIndicatorId")) variable.Value = ssIVAIndicatorId; else variable.Optimized = true;
} else if (head == "buydocnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BuyDocNumber")) variable.Value = ssBuyDocNumber; else variable.Optimized = true;
} else if (head == "buydocposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BuyDocPosition")) variable.Value = ssBuyDocPosition; else variable.Optimized = true;
} else if (head == "freetext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FreeText")) variable.Value = ssFreeText; else variable.Optimized = true;
} else if (head == "division") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Division")) variable.Value = ssDivision; else variable.Optimized = true;
} else if (head == "icme") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ICME")) variable.Value = ssICME; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceAccountingId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdServiceTypeId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdAccount)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCostCenterId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCeBeCostCenterId)) {
return ChangedAttributes[5];
}
if (key.Equals(IdAmount)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIVA_Old)) {
return ChangedAttributes[7];
}
if (key.Equals(IdIVAIndicatorId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdBuyDocNumber)) {
return ChangedAttributes[9];
}
if (key.Equals(IdBuyDocPosition)) {
return ChangedAttributes[10];
}
if (key.Equals(IdFreeText)) {
return ChangedAttributes[11];
}
if (key.Equals(IdDivision)) {
return ChangedAttributes[12];
}
if (key.Equals(IdICME)) {
return ChangedAttributes[13];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceAccountingId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdServiceTypeId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdAccount)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCostCenterId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCeBeCostCenterId)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdAmount)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIVA_Old)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdIVAIndicatorId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdBuyDocNumber)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdBuyDocPosition)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdFreeText)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdDivision)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdICME)) {
return OptimizedAttributes[13];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceAccountingId) {
return ssInvoiceAccountingId;
}
if (key == IdServiceTypeId) {
return ssServiceTypeId;
}
if (key == IdAccount) {
return ssAccount;
}
if (key == IdCostCenterId) {
return ssCostCenterId;
}
if (key == IdCeBeCostCenterId) {
return ssCeBeCostCenterId;
}
if (key == IdAmount) {
return ssAmount;
}
if (key == IdIVA_Old) {
return ssIVA_Old;
}
if (key == IdIVAIndicatorId) {
return ssIVAIndicatorId;
}
if (key == IdBuyDocNumber) {
return ssBuyDocNumber;
}
if (key == IdBuyDocPosition) {
return ssBuyDocPosition;
}
if (key == IdFreeText) {
return ssFreeText;
}
if (key == IdDivision) {
return ssDivision;
}
if (key == IdICME) {
return ssICME;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceAccountingId.Key.AsGuid) {
return ssInvoiceAccountingId;
}
if (attributeKey == IdServiceTypeId.Key.AsGuid) {
return ssServiceTypeId;
}
if (attributeKey == IdAccount.Key.AsGuid) {
return ssAccount;
}
if (attributeKey == IdCostCenterId.Key.AsGuid) {
return ssCostCenterId;
}
if (attributeKey == IdCeBeCostCenterId.Key.AsGuid) {
return ssCeBeCostCenterId;
}
if (attributeKey == IdAmount.Key.AsGuid) {
return ssAmount;
}
if (attributeKey == IdIVA_Old.Key.AsGuid) {
return ssIVA_Old;
}
if (attributeKey == IdIVAIndicatorId.Key.AsGuid) {
return ssIVAIndicatorId;
}
if (attributeKey == IdBuyDocNumber.Key.AsGuid) {
return ssBuyDocNumber;
}
if (attributeKey == IdBuyDocPosition.Key.AsGuid) {
return ssBuyDocPosition;
}
if (attributeKey == IdFreeText.Key.AsGuid) {
return ssFreeText;
}
if (attributeKey == IdDivision.Key.AsGuid) {
return ssDivision;
}
if (attributeKey == IdICME.Key.AsGuid) {
return ssICME;
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
ssInvoiceAccountingId = (long) other.AttributeGet(IdInvoiceAccountingId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceAccountingId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceAccountingId);
ssServiceTypeId = (long) other.AttributeGet(IdServiceTypeId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdServiceTypeId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdServiceTypeId);
ssAccount = (string) other.AttributeGet(IdAccount);
ChangedAttributes[3] = other.ChangedAttributeGet(IdAccount);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdAccount);
ssCostCenterId = (long) other.AttributeGet(IdCostCenterId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCostCenterId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCostCenterId);
ssCeBeCostCenterId = (long) other.AttributeGet(IdCeBeCostCenterId);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCeBeCostCenterId);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCeBeCostCenterId);
ssAmount = (decimal) other.AttributeGet(IdAmount);
ChangedAttributes[6] = other.ChangedAttributeGet(IdAmount);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdAmount);
ssIVA_Old = (string) other.AttributeGet(IdIVA_Old);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIVA_Old);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIVA_Old);
ssIVAIndicatorId = (long) other.AttributeGet(IdIVAIndicatorId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdIVAIndicatorId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdIVAIndicatorId);
ssBuyDocNumber = (string) other.AttributeGet(IdBuyDocNumber);
ChangedAttributes[9] = other.ChangedAttributeGet(IdBuyDocNumber);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdBuyDocNumber);
ssBuyDocPosition = (string) other.AttributeGet(IdBuyDocPosition);
ChangedAttributes[10] = other.ChangedAttributeGet(IdBuyDocPosition);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdBuyDocPosition);
ssFreeText = (string) other.AttributeGet(IdFreeText);
ChangedAttributes[11] = other.ChangedAttributeGet(IdFreeText);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdFreeText);
ssDivision = (string) other.AttributeGet(IdDivision);
ChangedAttributes[12] = other.ChangedAttributeGet(IdDivision);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdDivision);
ssICME = (string) other.AttributeGet(IdICME);
ChangedAttributes[13] = other.ChangedAttributeGet(IdICME);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdICME);
}
} // EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord

/// <summary>
/// RecordList type <code>InvoiceAccountingServicesList</code> that represents a record list of
///  <code>InvoiceAccountingServices</code>
/// </summary>
public partial class RL_500d3f017443846ad96a3e45e41bf158 : GenericRecordList<EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord>, IEnumerable, IEnumerator {

protected override EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord GetElementDefaultValue() {
return new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
}

public T[] ToArray<T>(Func<EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_500d3f017443846ad96a3e45e41bf158 recordList, Func<EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_500d3f017443846ad96a3e45e41bf158(EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord[] array) {
  RL_500d3f017443846ad96a3e45e41bf158 result = new RL_500d3f017443846ad96a3e45e41bf158();
result.InnerFromArray(array);
    return result;
}

public static RL_500d3f017443846ad96a3e45e41bf158 ToList<T>(T[] array, Func <T, EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord> converter) {
  RL_500d3f017443846ad96a3e45e41bf158 result = new RL_500d3f017443846ad96a3e45e41bf158();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_500d3f017443846ad96a3e45e41bf158 FromRestList<T>(RestList<T> restList, Func <T, EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord> converter) {
  RL_500d3f017443846ad96a3e45e41bf158 result = new RL_500d3f017443846ad96a3e45e41bf158();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_500d3f017443846ad96a3e45e41bf158() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord> NewList() {
return new RL_500d3f017443846ad96a3e45e41bf158();
}


} // RL_500d3f017443846ad96a3e45e41bf158
}
