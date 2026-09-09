using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceExtendedItem (dpUhkfiNc0GalJUIJt466Q)
///  <code>EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord</code> that represent
/// s <code>InvoiceExtendedItem</code> <p>Description: Entity that holds Invoice Item details</p>
/// </summary>
// Name: InvoiceExtendedItem
public partial struct EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord : ITypedRecord<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aQ3g7lzNWU6zcMt2iaEipw");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*s2Ytml1Ff0aIhANF_a1Zcw");
internal static readonly GlobalObjectKey IdProductNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fG6YnfBN70mlX0y6T0iSnQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DgoORzOIV02JDsbDPux1sg");
internal static readonly GlobalObjectKey IdMaterialCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NXTaJv5Kw0e1FdikrttRQQ");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nObvRQihVkeuVbehAsA+mQ");
internal static readonly GlobalObjectKey IdUnityPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZvNIJ7mA6E6zMJ7UuQwYoQ");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bLNm7XODBkGLG8dyNj0NYw");

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

private string _ssProductNumber;
public string ssProductNumber{
  get{
      return _ssProductNumber;
  }
  set{
      if((_ssProductNumber!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssProductNumber = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssDescription = value;
      }
  }
}

private string _ssMaterialCode;
public string ssMaterialCode{
  get{
      return _ssMaterialCode;
  }
  set{
      if((_ssMaterialCode!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssMaterialCode = value;
      }
  }
}

private int _ssQuantity;
public int ssQuantity{
  get{
      return _ssQuantity;
  }
  set{
      if((_ssQuantity!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssQuantity = value;
      }
  }
}

private decimal _ssUnityPrice;
public decimal ssUnityPrice{
  get{
      return _ssUnityPrice;
  }
  set{
      if((_ssUnityPrice!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUnityPrice = value;
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


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssProductNumber = "";
_ssDescription = "";
_ssMaterialCode = "";
_ssQuantity = 0;
_ssUnityPrice = 0.0M;
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
ssId = r.ReadLongInteger(index++, "InvoiceExtendedItem.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceExtendedItem.InvoiceId", 0L);
ssProductNumber = r.ReadText(index++, "InvoiceExtendedItem.ProductNumber", "");
ssDescription = r.ReadText(index++, "InvoiceExtendedItem.Description", "");
ssMaterialCode = r.ReadText(index++, "InvoiceExtendedItem.MaterialCode", "");
ssQuantity = r.ReadInteger(index++, "InvoiceExtendedItem.Quantity", 0);
ssUnityPrice = r.ReadCurrency(index++, "InvoiceExtendedItem.UnityPrice", 0.0M);
ssCurrency = r.ReadText(index++, "InvoiceExtendedItem.Currency", "");
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
public void ReadIM(EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord r) {
this = r;
}


public static bool operator == (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord a, EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssProductNumber != b.ssProductNumber) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssMaterialCode != b.ssMaterialCode) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssUnityPrice != b.ssUnityPrice) return false;
if (a.ssCurrency != b.ssCurrency) return false;
return true;
}

public static bool operator != (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord a, EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord)) return false;
return (this == (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssProductNumber.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssMaterialCode.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssUnityPrice.GetHashCode()
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


public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord Duplicate() {
EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssProductNumber = this._ssProductNumber;
t._ssDescription = this._ssDescription;
t._ssMaterialCode = this._ssMaterialCode;
t._ssQuantity = this._ssQuantity;
t._ssUnityPrice = this._ssUnityPrice;
t._ssCurrency = this._ssCurrency;
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "productnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProductNumber")) variable.Value = ssProductNumber; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "materialcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaterialCode")) variable.Value = ssMaterialCode; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity")) variable.Value = ssQuantity; else variable.Optimized = true;
} else if (head == "unityprice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnityPrice")) variable.Value = ssUnityPrice; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
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
if (key.Equals(IdProductNumber)) {
return ChangedAttributes[2];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[3];
}
if (key.Equals(IdMaterialCode)) {
return ChangedAttributes[4];
}
if (key.Equals(IdQuantity)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUnityPrice)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCurrency)) {
return ChangedAttributes[7];
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
if (key.Equals(IdProductNumber)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdMaterialCode)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdQuantity)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUnityPrice)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCurrency)) {
return OptimizedAttributes[7];
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
if (key == IdProductNumber) {
return ssProductNumber;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdMaterialCode) {
return ssMaterialCode;
}
if (key == IdQuantity) {
return ssQuantity;
}
if (key == IdUnityPrice) {
return ssUnityPrice;
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
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdProductNumber.Key.AsGuid) {
return ssProductNumber;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdMaterialCode.Key.AsGuid) {
return ssMaterialCode;
}
if (attributeKey == IdQuantity.Key.AsGuid) {
return ssQuantity;
}
if (attributeKey == IdUnityPrice.Key.AsGuid) {
return ssUnityPrice;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
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
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssProductNumber = (string) other.AttributeGet(IdProductNumber);
ChangedAttributes[2] = other.ChangedAttributeGet(IdProductNumber);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdProductNumber);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[3] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDescription);
ssMaterialCode = (string) other.AttributeGet(IdMaterialCode);
ChangedAttributes[4] = other.ChangedAttributeGet(IdMaterialCode);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdMaterialCode);
ssQuantity = (int) other.AttributeGet(IdQuantity);
ChangedAttributes[5] = other.ChangedAttributeGet(IdQuantity);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdQuantity);
ssUnityPrice = (decimal) other.AttributeGet(IdUnityPrice);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUnityPrice);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUnityPrice);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCurrency);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCurrency);
}
} // EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord

/// <summary>
/// RecordList type <code>InvoiceExtendedItemList</code> that represents a record list of
///  <code>InvoiceExtendedItem</code>
/// </summary>
public partial class RL_61d55f2f4678e3ec169973bbef64e210 : GenericRecordList<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord>, IEnumerable, IEnumerator {

protected override EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord GetElementDefaultValue() {
return new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord();
}

public T[] ToArray<T>(Func<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_61d55f2f4678e3ec169973bbef64e210 recordList, Func<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_61d55f2f4678e3ec169973bbef64e210(EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord[] array) {
  RL_61d55f2f4678e3ec169973bbef64e210 result = new RL_61d55f2f4678e3ec169973bbef64e210();
result.InnerFromArray(array);
    return result;
}

public static RL_61d55f2f4678e3ec169973bbef64e210 ToList<T>(T[] array, Func <T, EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> converter) {
  RL_61d55f2f4678e3ec169973bbef64e210 result = new RL_61d55f2f4678e3ec169973bbef64e210();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_61d55f2f4678e3ec169973bbef64e210 FromRestList<T>(RestList<T> restList, Func <T, EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> converter) {
  RL_61d55f2f4678e3ec169973bbef64e210 result = new RL_61d55f2f4678e3ec169973bbef64e210();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_61d55f2f4678e3ec169973bbef64e210() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord> NewList() {
return new RL_61d55f2f4678e3ec169973bbef64e210();
}


} // RL_61d55f2f4678e3ec169973bbef64e210
}
