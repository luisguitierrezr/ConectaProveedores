using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderContractFile (l3MDjIODzUWwF7MO81OCXQ)
///  <code>EN_17538b35348920159ed0ee43b3fb2b50EntityRecord</code> that represent
/// s <code>OrderContractFile</code> <p>Description: Order Contract File</p>
/// </summary>
// Name: OrderContractFile
public partial struct EN_17538b35348920159ed0ee43b3fb2b50EntityRecord : ITypedRecord<EN_17538b35348920159ed0ee43b3fb2b50EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hGfx1cVxQUGB9D07xpTjDQ");
internal static readonly GlobalObjectKey IdOrderId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WIHTSSMBEUeUDpUTDSihqg");
internal static readonly GlobalObjectKey IdOrderFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3Wqvahz+DUKjEA6Uj_+AQw");
internal static readonly GlobalObjectKey IdContractFileTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rIZ8anwk60GrksaeijYQYw");
internal static readonly GlobalObjectKey IdAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QPY_EkuigEC0tPELqpqzGg");
internal static readonly GlobalObjectKey IdTarif = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*duAsuZk7Gka5JVqCwe34IA");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9l3nzwQsCkyeF_FC9EO4Fw");
internal static readonly GlobalObjectKey IdDepositTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+p6NoVC_NEWsV_OOHMVkcg");
internal static readonly GlobalObjectKey IdInsuranceTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UwY5y2bt90aquICdcg5Lyw");
internal static readonly GlobalObjectKey IdAdvancePaymentTypeId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*72b2OZjl20y07yvq7Wwj+A");
internal static readonly GlobalObjectKey IdStartBaseDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nsGWxIDX+kGfUEzmyT7+9g");
internal static readonly GlobalObjectKey IdEndBaseDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7AkZL_NCIEyUtgzy99uUOQ");
internal static readonly GlobalObjectKey IdPaymentTermsId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*W_G2kb94rk2SFB5xKDKIWA");
internal static readonly GlobalObjectKey IdIsForVendorUpload = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JhOhya1WbU2j+udAHNh4qw");

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

private long _ssOrderFileId;
public long ssOrderFileId{
  get{
      return _ssOrderFileId;
  }
  set{
      if((_ssOrderFileId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOrderFileId = value;
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

private decimal _ssTarif;
public decimal ssTarif{
  get{
      return _ssTarif;
  }
  set{
      if((_ssTarif!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssTarif = value;
      }
  }
}

private string _ssCurrencyId;
public string ssCurrencyId{
  get{
      return _ssCurrencyId;
  }
  set{
      if((_ssCurrencyId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
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
      if((_ssDepositTypeId!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
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
      if((_ssInsuranceTypeId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
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
      if((_ssAdvancePaymentTypeId!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssAdvancePaymentTypeId = value;
      }
  }
}

private DateTime _ssStartBaseDate;
public DateTime ssStartBaseDate{
  get{
      return _ssStartBaseDate;
  }
  set{
      if((_ssStartBaseDate!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssStartBaseDate = value;
      }
  }
}

private DateTime _ssEndBaseDate;
public DateTime ssEndBaseDate{
  get{
      return _ssEndBaseDate;
  }
  set{
      if((_ssEndBaseDate!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssEndBaseDate = value;
      }
  }
}

private long _ssPaymentTermsId;
public long ssPaymentTermsId{
  get{
      return _ssPaymentTermsId;
  }
  set{
      if((_ssPaymentTermsId!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssPaymentTermsId = value;
      }
  }
}

private bool _ssIsForVendorUpload;
public bool ssIsForVendorUpload{
  get{
      return _ssIsForVendorUpload;
  }
  set{
      if((_ssIsForVendorUpload!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssIsForVendorUpload = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord() {
ChangedAttributes = new BitArray(14,true);
OptimizedAttributes = new BitArray(14,false);
_ssId = 0L;
_ssOrderId = 0L;
_ssOrderFileId = 0L;
_ssContractFileTypeId = 0;
_ssAmount = 0.0M;
_ssTarif = 0.0M;
_ssCurrencyId = "";
_ssDepositTypeId = 0;
_ssInsuranceTypeId = 0;
_ssAdvancePaymentTypeId = 0;
_ssStartBaseDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssEndBaseDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssPaymentTermsId = 0L;
_ssIsForVendorUpload = false;
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
ssId = r.ReadLongInteger(index++, "OrderContractFile.Id", 0L);
ssOrderId = r.ReadEntityReferenceLongInteger(index++, "OrderContractFile.OrderId", 0L);
ssOrderFileId = r.ReadEntityReferenceLongInteger(index++, "OrderContractFile.OrderFileId", 0L);
ssContractFileTypeId = r.ReadEntityReference(index++, "OrderContractFile.ContractFileTypeId", 0);
ssAmount = r.ReadDecimal(index++, "OrderContractFile.Amount", 0.0M);
ssTarif = r.ReadDecimal(index++, "OrderContractFile.Tarif", 0.0M);
ssCurrencyId = r.ReadEntityReferenceText(index++, "OrderContractFile.CurrencyId", "");
ssDepositTypeId = r.ReadEntityReference(index++, "OrderContractFile.DepositTypeId", 0);
ssInsuranceTypeId = r.ReadEntityReference(index++, "OrderContractFile.InsuranceTypeId", 0);
ssAdvancePaymentTypeId = r.ReadEntityReference(index++, "OrderContractFile.AdvancePaymentTypeId", 0);
ssStartBaseDate = r.ReadDate(index++, "OrderContractFile.StartBaseDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssEndBaseDate = r.ReadDate(index++, "OrderContractFile.EndBaseDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssPaymentTermsId = r.ReadEntityReferenceLongInteger(index++, "OrderContractFile.PaymentTermsId", 0L);
ssIsForVendorUpload = r.ReadBoolean(index++, "OrderContractFile.IsForVendorUpload", false);
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
public void ReadIM(EN_17538b35348920159ed0ee43b3fb2b50EntityRecord r) {
this = r;
}


public static bool operator == (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord a, EN_17538b35348920159ed0ee43b3fb2b50EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssOrderId != b.ssOrderId) return false;
if (a.ssOrderFileId != b.ssOrderFileId) return false;
if (a.ssContractFileTypeId != b.ssContractFileTypeId) return false;
if (a.ssAmount != b.ssAmount) return false;
if (a.ssTarif != b.ssTarif) return false;
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssDepositTypeId != b.ssDepositTypeId) return false;
if (a.ssInsuranceTypeId != b.ssInsuranceTypeId) return false;
if (a.ssAdvancePaymentTypeId != b.ssAdvancePaymentTypeId) return false;
if (a.ssStartBaseDate != b.ssStartBaseDate) return false;
if (a.ssEndBaseDate != b.ssEndBaseDate) return false;
if (a.ssPaymentTermsId != b.ssPaymentTermsId) return false;
if (a.ssIsForVendorUpload != b.ssIsForVendorUpload) return false;
return true;
}

public static bool operator != (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord a, EN_17538b35348920159ed0ee43b3fb2b50EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)) return false;
return (this == (EN_17538b35348920159ed0ee43b3fb2b50EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssOrderId.GetHashCode()
 ^ ssOrderFileId.GetHashCode()
 ^ ssContractFileTypeId.GetHashCode()
 ^ ssAmount.GetHashCode()
 ^ ssTarif.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssDepositTypeId.GetHashCode()
 ^ ssInsuranceTypeId.GetHashCode()
 ^ ssAdvancePaymentTypeId.GetHashCode()
 ^ ssStartBaseDate.GetHashCode()
 ^ ssEndBaseDate.GetHashCode()
 ^ ssPaymentTermsId.GetHashCode()
 ^ ssIsForVendorUpload.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_17538b35348920159ed0ee43b3fb2b50EntityRecord Duplicate() {
EN_17538b35348920159ed0ee43b3fb2b50EntityRecord t;
t._ssId = this._ssId;
t._ssOrderId = this._ssOrderId;
t._ssOrderFileId = this._ssOrderFileId;
t._ssContractFileTypeId = this._ssContractFileTypeId;
t._ssAmount = this._ssAmount;
t._ssTarif = this._ssTarif;
t._ssCurrencyId = this._ssCurrencyId;
t._ssDepositTypeId = this._ssDepositTypeId;
t._ssInsuranceTypeId = this._ssInsuranceTypeId;
t._ssAdvancePaymentTypeId = this._ssAdvancePaymentTypeId;
t._ssStartBaseDate = this._ssStartBaseDate;
t._ssEndBaseDate = this._ssEndBaseDate;
t._ssPaymentTermsId = this._ssPaymentTermsId;
t._ssIsForVendorUpload = this._ssIsForVendorUpload;
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
} else if (head == "orderid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderId")) variable.Value = ssOrderId; else variable.Optimized = true;
} else if (head == "orderfileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderFileId")) variable.Value = ssOrderFileId; else variable.Optimized = true;
} else if (head == "contractfiletypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractFileTypeId")) variable.Value = ssContractFileTypeId; else variable.Optimized = true;
} else if (head == "amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Amount")) variable.Value = ssAmount; else variable.Optimized = true;
} else if (head == "tarif") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tarif")) variable.Value = ssTarif; else variable.Optimized = true;
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "deposittypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DepositTypeId")) variable.Value = ssDepositTypeId; else variable.Optimized = true;
} else if (head == "insurancetypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InsuranceTypeId")) variable.Value = ssInsuranceTypeId; else variable.Optimized = true;
} else if (head == "advancepaymenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvancePaymentTypeId")) variable.Value = ssAdvancePaymentTypeId; else variable.Optimized = true;
} else if (head == "startbasedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StartBaseDate")) variable.Value = ssStartBaseDate; else variable.Optimized = true;
} else if (head == "endbasedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EndBaseDate")) variable.Value = ssEndBaseDate; else variable.Optimized = true;
} else if (head == "paymenttermsid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTermsId")) variable.Value = ssPaymentTermsId; else variable.Optimized = true;
} else if (head == "isforvendorupload") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsForVendorUpload")) variable.Value = ssIsForVendorUpload; else variable.Optimized = true;
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
if (key.Equals(IdOrderFileId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdContractFileTypeId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdAmount)) {
return ChangedAttributes[4];
}
if (key.Equals(IdTarif)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCurrencyId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdDepositTypeId)) {
return ChangedAttributes[7];
}
if (key.Equals(IdInsuranceTypeId)) {
return ChangedAttributes[8];
}
if (key.Equals(IdAdvancePaymentTypeId)) {
return ChangedAttributes[9];
}
if (key.Equals(IdStartBaseDate)) {
return ChangedAttributes[10];
}
if (key.Equals(IdEndBaseDate)) {
return ChangedAttributes[11];
}
if (key.Equals(IdPaymentTermsId)) {
return ChangedAttributes[12];
}
if (key.Equals(IdIsForVendorUpload)) {
return ChangedAttributes[13];
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
if (key.Equals(IdOrderFileId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdContractFileTypeId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdAmount)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdTarif)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCurrencyId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdDepositTypeId)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdInsuranceTypeId)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdAdvancePaymentTypeId)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdStartBaseDate)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdEndBaseDate)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdPaymentTermsId)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdIsForVendorUpload)) {
return OptimizedAttributes[13];
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
if (key == IdOrderFileId) {
return ssOrderFileId;
}
if (key == IdContractFileTypeId) {
return ssContractFileTypeId;
}
if (key == IdAmount) {
return ssAmount;
}
if (key == IdTarif) {
return ssTarif;
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
if (key == IdStartBaseDate) {
return ssStartBaseDate;
}
if (key == IdEndBaseDate) {
return ssEndBaseDate;
}
if (key == IdPaymentTermsId) {
return ssPaymentTermsId;
}
if (key == IdIsForVendorUpload) {
return ssIsForVendorUpload;
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
if (attributeKey == IdOrderFileId.Key.AsGuid) {
return ssOrderFileId;
}
if (attributeKey == IdContractFileTypeId.Key.AsGuid) {
return ssContractFileTypeId;
}
if (attributeKey == IdAmount.Key.AsGuid) {
return ssAmount;
}
if (attributeKey == IdTarif.Key.AsGuid) {
return ssTarif;
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
if (attributeKey == IdStartBaseDate.Key.AsGuid) {
return ssStartBaseDate;
}
if (attributeKey == IdEndBaseDate.Key.AsGuid) {
return ssEndBaseDate;
}
if (attributeKey == IdPaymentTermsId.Key.AsGuid) {
return ssPaymentTermsId;
}
if (attributeKey == IdIsForVendorUpload.Key.AsGuid) {
return ssIsForVendorUpload;
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
ssOrderId = (long) other.AttributeGet(IdOrderId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrderId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrderId);
ssOrderFileId = (long) other.AttributeGet(IdOrderFileId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrderFileId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrderFileId);
ssContractFileTypeId = (int) other.AttributeGet(IdContractFileTypeId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdContractFileTypeId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdContractFileTypeId);
ssAmount = (decimal) other.AttributeGet(IdAmount);
ChangedAttributes[4] = other.ChangedAttributeGet(IdAmount);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdAmount);
ssTarif = (decimal) other.AttributeGet(IdTarif);
ChangedAttributes[5] = other.ChangedAttributeGet(IdTarif);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdTarif);
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCurrencyId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCurrencyId);
ssDepositTypeId = (int) other.AttributeGet(IdDepositTypeId);
ChangedAttributes[7] = other.ChangedAttributeGet(IdDepositTypeId);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdDepositTypeId);
ssInsuranceTypeId = (int) other.AttributeGet(IdInsuranceTypeId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdInsuranceTypeId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdInsuranceTypeId);
ssAdvancePaymentTypeId = (int) other.AttributeGet(IdAdvancePaymentTypeId);
ChangedAttributes[9] = other.ChangedAttributeGet(IdAdvancePaymentTypeId);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdAdvancePaymentTypeId);
ssStartBaseDate = (DateTime) other.AttributeGet(IdStartBaseDate);
ChangedAttributes[10] = other.ChangedAttributeGet(IdStartBaseDate);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdStartBaseDate);
ssEndBaseDate = (DateTime) other.AttributeGet(IdEndBaseDate);
ChangedAttributes[11] = other.ChangedAttributeGet(IdEndBaseDate);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdEndBaseDate);
ssPaymentTermsId = (long) other.AttributeGet(IdPaymentTermsId);
ChangedAttributes[12] = other.ChangedAttributeGet(IdPaymentTermsId);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdPaymentTermsId);
ssIsForVendorUpload = (bool) other.AttributeGet(IdIsForVendorUpload);
ChangedAttributes[13] = other.ChangedAttributeGet(IdIsForVendorUpload);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdIsForVendorUpload);
}
} // EN_17538b35348920159ed0ee43b3fb2b50EntityRecord

/// <summary>
/// RecordList type <code>OrderContractFileList</code> that represents a record list of
///  <code>OrderContractFile</code>
/// </summary>
public partial class RL_48a4ac6ecac3f296e9ecb32f8cae9f34 : GenericRecordList<EN_17538b35348920159ed0ee43b3fb2b50EntityRecord>, IEnumerable, IEnumerator {

protected override EN_17538b35348920159ed0ee43b3fb2b50EntityRecord GetElementDefaultValue() {
return new EN_17538b35348920159ed0ee43b3fb2b50EntityRecord();
}

public T[] ToArray<T>(Func<EN_17538b35348920159ed0ee43b3fb2b50EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_48a4ac6ecac3f296e9ecb32f8cae9f34 recordList, Func<EN_17538b35348920159ed0ee43b3fb2b50EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_48a4ac6ecac3f296e9ecb32f8cae9f34(EN_17538b35348920159ed0ee43b3fb2b50EntityRecord[] array) {
  RL_48a4ac6ecac3f296e9ecb32f8cae9f34 result = new RL_48a4ac6ecac3f296e9ecb32f8cae9f34();
result.InnerFromArray(array);
    return result;
}

public static RL_48a4ac6ecac3f296e9ecb32f8cae9f34 ToList<T>(T[] array, Func <T, EN_17538b35348920159ed0ee43b3fb2b50EntityRecord> converter) {
  RL_48a4ac6ecac3f296e9ecb32f8cae9f34 result = new RL_48a4ac6ecac3f296e9ecb32f8cae9f34();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_48a4ac6ecac3f296e9ecb32f8cae9f34 FromRestList<T>(RestList<T> restList, Func <T, EN_17538b35348920159ed0ee43b3fb2b50EntityRecord> converter) {
  RL_48a4ac6ecac3f296e9ecb32f8cae9f34 result = new RL_48a4ac6ecac3f296e9ecb32f8cae9f34();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_48a4ac6ecac3f296e9ecb32f8cae9f34() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_17538b35348920159ed0ee43b3fb2b50EntityRecord> NewList() {
return new RL_48a4ac6ecac3f296e9ecb32f8cae9f34();
}


} // RL_48a4ac6ecac3f296e9ecb32f8cae9f34
}
