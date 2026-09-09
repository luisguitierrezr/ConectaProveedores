using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedForeigner (J_yvNWdLsUiJB8mbNA3HVQ)
///  <code>EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord</code> that represent
/// s <code>InvoiceExtendedForeigner</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedForeigner
public partial struct EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord : ITypedRecord<EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*djOcYfVIDkqqMc3nklKhtQ");
internal static readonly GlobalObjectKey IdInvoiceNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8l1xLm8oA0K4jMWim8TY2w");
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*emCBSYgkSEu6L4TRBue8IA");
internal static readonly GlobalObjectKey IdReceiverSocialReason = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HnnAP2nk9kGOQqSnIaotxQ");
internal static readonly GlobalObjectKey IdReceiverRFC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FjYQuJk_mEabCEo+mrMcAQ");
internal static readonly GlobalObjectKey IdIssuerSocialReason = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*837C1Z3BMEyOY6sbf0Uz3A");
internal static readonly GlobalObjectKey IdIssuerTaxId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XOLochNfP0qD_u+5MlbQQg");
internal static readonly GlobalObjectKey IdInvoiceDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YoDtK1EnX0ieEhmVFkcRXA");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*K8Mq0dylv0arB19mUBjuPA");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YwMyyALfKUeidfb3pEQHiQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(10,true);
          _ssId = value;
      }
  }
}

private string _ssInvoiceNumber;
public string ssInvoiceNumber{
  get{
      return _ssInvoiceNumber;
  }
  set{
      if((_ssInvoiceNumber!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceNumber = value;
      }
  }
}

private string _ssDirection;
public string ssDirection{
  get{
      return _ssDirection;
  }
  set{
      if((_ssDirection!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssDirection = value;
      }
  }
}

private string _ssReceiverSocialReason;
public string ssReceiverSocialReason{
  get{
      return _ssReceiverSocialReason;
  }
  set{
      if((_ssReceiverSocialReason!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssReceiverSocialReason = value;
      }
  }
}

private string _ssReceiverRFC;
public string ssReceiverRFC{
  get{
      return _ssReceiverRFC;
  }
  set{
      if((_ssReceiverRFC!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssReceiverRFC = value;
      }
  }
}

private string _ssIssuerSocialReason;
public string ssIssuerSocialReason{
  get{
      return _ssIssuerSocialReason;
  }
  set{
      if((_ssIssuerSocialReason!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIssuerSocialReason = value;
      }
  }
}

private string _ssIssuerTaxId;
public string ssIssuerTaxId{
  get{
      return _ssIssuerTaxId;
  }
  set{
      if((_ssIssuerTaxId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIssuerTaxId = value;
      }
  }
}

private DateTime _ssInvoiceDate;
public DateTime ssInvoiceDate{
  get{
      return _ssInvoiceDate;
  }
  set{
      if((_ssInvoiceDate!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssInvoiceDate = value;
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

private string _ssCurrency;
public string ssCurrency{
  get{
      return _ssCurrency;
  }
  set{
      if((_ssCurrency!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssCurrency = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord() {
ChangedAttributes = new BitArray(10,true);
OptimizedAttributes = new BitArray(10,false);
_ssId = 0L;
_ssInvoiceNumber = "";
_ssDirection = "";
_ssReceiverSocialReason = "";
_ssReceiverRFC = "";
_ssIssuerSocialReason = "";
_ssIssuerTaxId = "";
_ssInvoiceDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssTotalAmount = 0.0M;
_ssCurrency = "";
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
ssId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedForeigner.Id", 0L);
ssInvoiceNumber = r.ReadText(index++, "InvoiceExtendedForeigner.InvoiceNumber", "");
ssDirection = r.ReadText(index++, "InvoiceExtendedForeigner.Direction", "");
ssReceiverSocialReason = r.ReadText(index++, "InvoiceExtendedForeigner.ReceiverSocialReason", "");
ssReceiverRFC = r.ReadText(index++, "InvoiceExtendedForeigner.ReceiverRFC", "");
ssIssuerSocialReason = r.ReadText(index++, "InvoiceExtendedForeigner.IssuerSocialReason", "");
ssIssuerTaxId = r.ReadText(index++, "InvoiceExtendedForeigner.IssuerTaxId", "");
ssInvoiceDate = r.ReadDate(index++, "InvoiceExtendedForeigner.InvoiceDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssTotalAmount = r.ReadDecimal(index++, "InvoiceExtendedForeigner.TotalAmount", 0.0M);
ssCurrency = r.ReadEntityReferenceText(index++, "InvoiceExtendedForeigner.Currency", "");
ChangedAttributes = new BitArray(10,false);
OptimizedAttributes = new BitArray(10,false);
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
public void ReadIM(EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord r) {
this = r;
}


public static bool operator == (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord a, EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceNumber != b.ssInvoiceNumber) return false;
if (a.ssDirection != b.ssDirection) return false;
if (a.ssReceiverSocialReason != b.ssReceiverSocialReason) return false;
if (a.ssReceiverRFC != b.ssReceiverRFC) return false;
if (a.ssIssuerSocialReason != b.ssIssuerSocialReason) return false;
if (a.ssIssuerTaxId != b.ssIssuerTaxId) return false;
if (a.ssInvoiceDate != b.ssInvoiceDate) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssCurrency != b.ssCurrency) return false;
return true;
}

public static bool operator != (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord a, EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord)) return false;
return (this == (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceNumber.GetHashCode()
 ^ ssDirection.GetHashCode()
 ^ ssReceiverSocialReason.GetHashCode()
 ^ ssReceiverRFC.GetHashCode()
 ^ ssIssuerSocialReason.GetHashCode()
 ^ ssIssuerTaxId.GetHashCode()
 ^ ssInvoiceDate.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssCurrency.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord Duplicate() {
EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceNumber = this._ssInvoiceNumber;
t._ssDirection = this._ssDirection;
t._ssReceiverSocialReason = this._ssReceiverSocialReason;
t._ssReceiverRFC = this._ssReceiverRFC;
t._ssIssuerSocialReason = this._ssIssuerSocialReason;
t._ssIssuerTaxId = this._ssIssuerTaxId;
t._ssInvoiceDate = this._ssInvoiceDate;
t._ssTotalAmount = this._ssTotalAmount;
t._ssCurrency = this._ssCurrency;
t.ChangedAttributes = new BitArray(10);
t.OptimizedAttributes = new BitArray(10);
for(int i = 0; i < 10; i++){
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
} else if (head == "invoicenumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceNumber")) variable.Value = ssInvoiceNumber; else variable.Optimized = true;
} else if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "receiversocialreason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ReceiverSocialReason")) variable.Value = ssReceiverSocialReason; else variable.Optimized = true;
} else if (head == "receiverrfc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ReceiverRFC")) variable.Value = ssReceiverRFC; else variable.Optimized = true;
} else if (head == "issuersocialreason") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IssuerSocialReason")) variable.Value = ssIssuerSocialReason; else variable.Optimized = true;
} else if (head == "issuertaxid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IssuerTaxId")) variable.Value = ssIssuerTaxId; else variable.Optimized = true;
} else if (head == "invoicedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceDate")) variable.Value = ssInvoiceDate; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceNumber)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDirection)) {
return ChangedAttributes[2];
}
if (key.Equals(IdReceiverSocialReason)) {
return ChangedAttributes[3];
}
if (key.Equals(IdReceiverRFC)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIssuerSocialReason)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIssuerTaxId)) {
return ChangedAttributes[6];
}
if (key.Equals(IdInvoiceDate)) {
return ChangedAttributes[7];
}
if (key.Equals(IdTotalAmount)) {
return ChangedAttributes[8];
}
if (key.Equals(IdCurrency)) {
return ChangedAttributes[9];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceNumber)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDirection)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdReceiverSocialReason)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdReceiverRFC)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIssuerSocialReason)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIssuerTaxId)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdInvoiceDate)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdTotalAmount)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdCurrency)) {
return OptimizedAttributes[9];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceNumber) {
return ssInvoiceNumber;
}
if (key == IdDirection) {
return ssDirection;
}
if (key == IdReceiverSocialReason) {
return ssReceiverSocialReason;
}
if (key == IdReceiverRFC) {
return ssReceiverRFC;
}
if (key == IdIssuerSocialReason) {
return ssIssuerSocialReason;
}
if (key == IdIssuerTaxId) {
return ssIssuerTaxId;
}
if (key == IdInvoiceDate) {
return ssInvoiceDate;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdCurrency) {
return ssCurrency;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceNumber.Key.AsGuid) {
return ssInvoiceNumber;
}
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
}
if (attributeKey == IdReceiverSocialReason.Key.AsGuid) {
return ssReceiverSocialReason;
}
if (attributeKey == IdReceiverRFC.Key.AsGuid) {
return ssReceiverRFC;
}
if (attributeKey == IdIssuerSocialReason.Key.AsGuid) {
return ssIssuerSocialReason;
}
if (attributeKey == IdIssuerTaxId.Key.AsGuid) {
return ssIssuerTaxId;
}
if (attributeKey == IdInvoiceDate.Key.AsGuid) {
return ssInvoiceDate;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(10);
OptimizedAttributes = new BitArray(10);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssInvoiceNumber = (string) other.AttributeGet(IdInvoiceNumber);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceNumber);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceNumber);
ssDirection = (string) other.AttributeGet(IdDirection);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDirection);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDirection);
ssReceiverSocialReason = (string) other.AttributeGet(IdReceiverSocialReason);
ChangedAttributes[3] = other.ChangedAttributeGet(IdReceiverSocialReason);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdReceiverSocialReason);
ssReceiverRFC = (string) other.AttributeGet(IdReceiverRFC);
ChangedAttributes[4] = other.ChangedAttributeGet(IdReceiverRFC);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdReceiverRFC);
ssIssuerSocialReason = (string) other.AttributeGet(IdIssuerSocialReason);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIssuerSocialReason);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIssuerSocialReason);
ssIssuerTaxId = (string) other.AttributeGet(IdIssuerTaxId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIssuerTaxId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIssuerTaxId);
ssInvoiceDate = (DateTime) other.AttributeGet(IdInvoiceDate);
ChangedAttributes[7] = other.ChangedAttributeGet(IdInvoiceDate);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdInvoiceDate);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ChangedAttributes[8] = other.ChangedAttributeGet(IdTotalAmount);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdTotalAmount);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ChangedAttributes[9] = other.ChangedAttributeGet(IdCurrency);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdCurrency);
}
} // EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedForeignerList</code> that represents a record list of
///  <code>InvoiceExtendedForeigner</code>
/// </summary>
public partial class RL_b5dd6f62c15c6316371bf942b5375407 : GenericRecordList<EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord>, IEnumerable, IEnumerator {

protected override EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord GetElementDefaultValue() {
return new EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord();
}

public T[] ToArray<T>(Func<EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b5dd6f62c15c6316371bf942b5375407 recordList, Func<EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b5dd6f62c15c6316371bf942b5375407(EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord[] array) {
  RL_b5dd6f62c15c6316371bf942b5375407 result = new RL_b5dd6f62c15c6316371bf942b5375407();
result.InnerFromArray(array);
    return result;
}

public static RL_b5dd6f62c15c6316371bf942b5375407 ToList<T>(T[] array, Func <T, EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord> converter) {
  RL_b5dd6f62c15c6316371bf942b5375407 result = new RL_b5dd6f62c15c6316371bf942b5375407();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b5dd6f62c15c6316371bf942b5375407 FromRestList<T>(RestList<T> restList, Func <T, EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord> converter) {
  RL_b5dd6f62c15c6316371bf942b5375407 result = new RL_b5dd6f62c15c6316371bf942b5375407();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b5dd6f62c15c6316371bf942b5375407() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord> NewList() {
return new RL_b5dd6f62c15c6316371bf942b5375407();
}


} // RL_b5dd6f62c15c6316371bf942b5375407
}
