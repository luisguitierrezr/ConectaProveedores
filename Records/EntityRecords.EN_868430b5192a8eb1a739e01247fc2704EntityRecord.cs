using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] FolioItems (mdvOirnmpEuUFU093w4OjA)
///  <code>EN_868430b5192a8eb1a739e01247fc2704EntityRecord</code> that represent
/// s <code>FolioItems</code> <p>Description: </p>
/// </summary>
// Name: FolioItems
public partial struct EN_868430b5192a8eb1a739e01247fc2704EntityRecord : ITypedRecord<EN_868430b5192a8eb1a739e01247fc2704EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WC1b7+a8wUCxDGy5U4Tojw");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*o9Fdty1O0UClZef2WA7sYA");
internal static readonly GlobalObjectKey IdOrderMainItemId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yJWQlLt9w02mKCeKazI5xw");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wTIhfJhqAEC2C0DHXQMrTQ");
internal static readonly GlobalObjectKey IdArticleNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S3J1dd8RNEKezJHCKurQ9g");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Qil5ZyCpikCwQCmcOHEpwg");
internal static readonly GlobalObjectKey IdInputationCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pw3XsARtI0mV8J81Y2V7wA");
internal static readonly GlobalObjectKey IdDeliveryDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YlmpVJA8xU+Qe93lsEoekQ");
internal static readonly GlobalObjectKey IdInvoiceQtt = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1gGGrJKlr0OfvF5a3Y8vUA");
internal static readonly GlobalObjectKey IdRemainingQtt = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PYzkzEjPn0mODRJ8wXtD+Q");
internal static readonly GlobalObjectKey IdUnitPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GOzPYW5ycUm6H_m1rWDd2A");
internal static readonly GlobalObjectKey IdTotalPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8uYY2jAzs0+RkE25H9sQqg");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dYvuvZjtHUmjeIC_RIz6yQ");
internal static readonly GlobalObjectKey IdDeliveryQtt = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eQ9cFw6_Z0+s5__71qy8HQ");
internal static readonly GlobalObjectKey IdImportdelivery = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l6elAJDnE0yGWpXgtRNx7Q");
internal static readonly GlobalObjectKey IdPEP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PynZPLjyH0Gahy3z4NHRUQ");
internal static readonly GlobalObjectKey IdPlaceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ExjHIDqI7EaspgowASs9Vg");
internal static readonly GlobalObjectKey IdPlaceName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8sU0rNfxd0ycOY_qQm4fWA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(18,true);
          _ssId = value;
      }
  }
}

private long _ssFolioId;
public long ssFolioId{
  get{
      return _ssFolioId;
  }
  set{
      if((_ssFolioId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssFolioId = value;
      }
  }
}

private long _ssOrderMainItemId;
public long ssOrderMainItemId{
  get{
      return _ssOrderMainItemId;
  }
  set{
      if((_ssOrderMainItemId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOrderMainItemId = value;
      }
  }
}

private string _ssOrderNumber;
public string ssOrderNumber{
  get{
      return _ssOrderNumber;
  }
  set{
      if((_ssOrderNumber!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssOrderNumber = value;
      }
  }
}

private string _ssArticleNumber;
public string ssArticleNumber{
  get{
      return _ssArticleNumber;
  }
  set{
      if((_ssArticleNumber!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssArticleNumber = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssDescription = value;
      }
  }
}

private string _ssInputationCode;
public string ssInputationCode{
  get{
      return _ssInputationCode;
  }
  set{
      if((_ssInputationCode!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssInputationCode = value;
      }
  }
}

private DateTime _ssDeliveryDate;
public DateTime ssDeliveryDate{
  get{
      return _ssDeliveryDate;
  }
  set{
      if((_ssDeliveryDate!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssDeliveryDate = value;
      }
  }
}

private decimal _ssInvoiceQtt;
public decimal ssInvoiceQtt{
  get{
      return _ssInvoiceQtt;
  }
  set{
      if((_ssInvoiceQtt!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssInvoiceQtt = value;
      }
  }
}

private decimal _ssRemainingQtt;
public decimal ssRemainingQtt{
  get{
      return _ssRemainingQtt;
  }
  set{
      if((_ssRemainingQtt!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssRemainingQtt = value;
      }
  }
}

private decimal _ssUnitPrice;
public decimal ssUnitPrice{
  get{
      return _ssUnitPrice;
  }
  set{
      if((_ssUnitPrice!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssUnitPrice = value;
      }
  }
}

private decimal _ssTotalPrice;
public decimal ssTotalPrice{
  get{
      return _ssTotalPrice;
  }
  set{
      if((_ssTotalPrice!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssTotalPrice = value;
      }
  }
}

private decimal _ssQuantity;
public decimal ssQuantity{
  get{
      return _ssQuantity;
  }
  set{
      if((_ssQuantity!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssQuantity = value;
      }
  }
}

private string _ssDeliveryQtt;
public string ssDeliveryQtt{
  get{
      return _ssDeliveryQtt;
  }
  set{
      if((_ssDeliveryQtt!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssDeliveryQtt = value;
      }
  }
}

private string _ssImportdelivery;
public string ssImportdelivery{
  get{
      return _ssImportdelivery;
  }
  set{
      if((_ssImportdelivery!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssImportdelivery = value;
      }
  }
}

private string _ssPEP;
public string ssPEP{
  get{
      return _ssPEP;
  }
  set{
      if((_ssPEP!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssPEP = value;
      }
  }
}

private string _ssPlaceId;
public string ssPlaceId{
  get{
      return _ssPlaceId;
  }
  set{
      if((_ssPlaceId!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssPlaceId = value;
      }
  }
}

private string _ssPlaceName;
public string ssPlaceName{
  get{
      return _ssPlaceName;
  }
  set{
      if((_ssPlaceName!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssPlaceName = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord() {
ChangedAttributes = new BitArray(18,true);
OptimizedAttributes = new BitArray(18,false);
_ssId = 0L;
_ssFolioId = 0L;
_ssOrderMainItemId = 0L;
_ssOrderNumber = "";
_ssArticleNumber = "";
_ssDescription = "";
_ssInputationCode = "";
_ssDeliveryDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssInvoiceQtt = 0.0M;
_ssRemainingQtt = 0.0M;
_ssUnitPrice = 0.0M;
_ssTotalPrice = 0.0M;
_ssQuantity = 0.0M;
_ssDeliveryQtt = "";
_ssImportdelivery = "";
_ssPEP = "";
_ssPlaceId = "";
_ssPlaceName = "";
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
ssId = r.ReadLongInteger(index++, "FolioItems.Id", 0L);
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioItems.FolioId", 0L);
ssOrderMainItemId = r.ReadEntityReferenceLongInteger(index++, "FolioItems.OrderMainItemId", 0L);
ssOrderNumber = r.ReadText(index++, "FolioItems.OrderNumber", "");
ssArticleNumber = r.ReadText(index++, "FolioItems.ArticleNumber", "");
ssDescription = r.ReadText(index++, "FolioItems.Description", "");
ssInputationCode = r.ReadText(index++, "FolioItems.InputationCode", "");
ssDeliveryDate = r.ReadDate(index++, "FolioItems.DeliveryDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssInvoiceQtt = r.ReadDecimal(index++, "FolioItems.InvoiceQtt", 0.0M);
ssRemainingQtt = r.ReadDecimal(index++, "FolioItems.RemainingQtt", 0.0M);
ssUnitPrice = r.ReadCurrency(index++, "FolioItems.UnitPrice", 0.0M);
ssTotalPrice = r.ReadCurrency(index++, "FolioItems.TotalPrice", 0.0M);
ssQuantity = r.ReadDecimal(index++, "FolioItems.Quantity", 0.0M);
ssDeliveryQtt = r.ReadText(index++, "FolioItems.DeliveryQtt", "");
ssImportdelivery = r.ReadText(index++, "FolioItems.Importdelivery", "");
ssPEP = r.ReadText(index++, "FolioItems.PEP", "");
ssPlaceId = r.ReadText(index++, "FolioItems.PlaceId", "");
ssPlaceName = r.ReadText(index++, "FolioItems.PlaceName", "");
ChangedAttributes = new BitArray(18,false);
OptimizedAttributes = new BitArray(18,false);
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
public void ReadIM(EN_868430b5192a8eb1a739e01247fc2704EntityRecord r) {
this = r;
}


public static bool operator == (EN_868430b5192a8eb1a739e01247fc2704EntityRecord a, EN_868430b5192a8eb1a739e01247fc2704EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssOrderMainItemId != b.ssOrderMainItemId) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssArticleNumber != b.ssArticleNumber) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssInputationCode != b.ssInputationCode) return false;
if (a.ssDeliveryDate != b.ssDeliveryDate) return false;
if (a.ssInvoiceQtt != b.ssInvoiceQtt) return false;
if (a.ssRemainingQtt != b.ssRemainingQtt) return false;
if (a.ssUnitPrice != b.ssUnitPrice) return false;
if (a.ssTotalPrice != b.ssTotalPrice) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssDeliveryQtt != b.ssDeliveryQtt) return false;
if (a.ssImportdelivery != b.ssImportdelivery) return false;
if (a.ssPEP != b.ssPEP) return false;
if (a.ssPlaceId != b.ssPlaceId) return false;
if (a.ssPlaceName != b.ssPlaceName) return false;
return true;
}

public static bool operator != (EN_868430b5192a8eb1a739e01247fc2704EntityRecord a, EN_868430b5192a8eb1a739e01247fc2704EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_868430b5192a8eb1a739e01247fc2704EntityRecord)) return false;
return (this == (EN_868430b5192a8eb1a739e01247fc2704EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssOrderMainItemId.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssArticleNumber.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssInputationCode.GetHashCode()
 ^ ssDeliveryDate.GetHashCode()
 ^ ssInvoiceQtt.GetHashCode()
 ^ ssRemainingQtt.GetHashCode()
 ^ ssUnitPrice.GetHashCode()
 ^ ssTotalPrice.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssDeliveryQtt.GetHashCode()
 ^ ssImportdelivery.GetHashCode()
 ^ ssPEP.GetHashCode()
 ^ ssPlaceId.GetHashCode()
 ^ ssPlaceName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_868430b5192a8eb1a739e01247fc2704EntityRecord Duplicate() {
EN_868430b5192a8eb1a739e01247fc2704EntityRecord t;
t._ssId = this._ssId;
t._ssFolioId = this._ssFolioId;
t._ssOrderMainItemId = this._ssOrderMainItemId;
t._ssOrderNumber = this._ssOrderNumber;
t._ssArticleNumber = this._ssArticleNumber;
t._ssDescription = this._ssDescription;
t._ssInputationCode = this._ssInputationCode;
t._ssDeliveryDate = this._ssDeliveryDate;
t._ssInvoiceQtt = this._ssInvoiceQtt;
t._ssRemainingQtt = this._ssRemainingQtt;
t._ssUnitPrice = this._ssUnitPrice;
t._ssTotalPrice = this._ssTotalPrice;
t._ssQuantity = this._ssQuantity;
t._ssDeliveryQtt = this._ssDeliveryQtt;
t._ssImportdelivery = this._ssImportdelivery;
t._ssPEP = this._ssPEP;
t._ssPlaceId = this._ssPlaceId;
t._ssPlaceName = this._ssPlaceName;
t.ChangedAttributes = new BitArray(18);
t.OptimizedAttributes = new BitArray(18);
for(int i = 0; i < 18; i++){
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
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "ordermainitemid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItemId")) variable.Value = ssOrderMainItemId; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "articlenumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ArticleNumber")) variable.Value = ssArticleNumber; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "inputationcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InputationCode")) variable.Value = ssInputationCode; else variable.Optimized = true;
} else if (head == "deliverydate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveryDate")) variable.Value = ssDeliveryDate; else variable.Optimized = true;
} else if (head == "invoiceqtt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceQtt")) variable.Value = ssInvoiceQtt; else variable.Optimized = true;
} else if (head == "remainingqtt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RemainingQtt")) variable.Value = ssRemainingQtt; else variable.Optimized = true;
} else if (head == "unitprice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitPrice")) variable.Value = ssUnitPrice; else variable.Optimized = true;
} else if (head == "totalprice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalPrice")) variable.Value = ssTotalPrice; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity")) variable.Value = ssQuantity; else variable.Optimized = true;
} else if (head == "deliveryqtt") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveryQtt")) variable.Value = ssDeliveryQtt; else variable.Optimized = true;
} else if (head == "importdelivery") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Importdelivery")) variable.Value = ssImportdelivery; else variable.Optimized = true;
} else if (head == "pep") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEP")) variable.Value = ssPEP; else variable.Optimized = true;
} else if (head == "placeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PlaceId")) variable.Value = ssPlaceId; else variable.Optimized = true;
} else if (head == "placename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PlaceName")) variable.Value = ssPlaceName; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdOrderMainItemId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOrderNumber)) {
return ChangedAttributes[3];
}
if (key.Equals(IdArticleNumber)) {
return ChangedAttributes[4];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[5];
}
if (key.Equals(IdInputationCode)) {
return ChangedAttributes[6];
}
if (key.Equals(IdDeliveryDate)) {
return ChangedAttributes[7];
}
if (key.Equals(IdInvoiceQtt)) {
return ChangedAttributes[8];
}
if (key.Equals(IdRemainingQtt)) {
return ChangedAttributes[9];
}
if (key.Equals(IdUnitPrice)) {
return ChangedAttributes[10];
}
if (key.Equals(IdTotalPrice)) {
return ChangedAttributes[11];
}
if (key.Equals(IdQuantity)) {
return ChangedAttributes[12];
}
if (key.Equals(IdDeliveryQtt)) {
return ChangedAttributes[13];
}
if (key.Equals(IdImportdelivery)) {
return ChangedAttributes[14];
}
if (key.Equals(IdPEP)) {
return ChangedAttributes[15];
}
if (key.Equals(IdPlaceId)) {
return ChangedAttributes[16];
}
if (key.Equals(IdPlaceName)) {
return ChangedAttributes[17];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdFolioId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdOrderMainItemId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOrderNumber)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdArticleNumber)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdInputationCode)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdDeliveryDate)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdInvoiceQtt)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdRemainingQtt)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdUnitPrice)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdTotalPrice)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdQuantity)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdDeliveryQtt)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdImportdelivery)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdPEP)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdPlaceId)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdPlaceName)) {
return OptimizedAttributes[17];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdOrderMainItemId) {
return ssOrderMainItemId;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdArticleNumber) {
return ssArticleNumber;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdInputationCode) {
return ssInputationCode;
}
if (key == IdDeliveryDate) {
return ssDeliveryDate;
}
if (key == IdInvoiceQtt) {
return ssInvoiceQtt;
}
if (key == IdRemainingQtt) {
return ssRemainingQtt;
}
if (key == IdUnitPrice) {
return ssUnitPrice;
}
if (key == IdTotalPrice) {
return ssTotalPrice;
}
if (key == IdQuantity) {
return ssQuantity;
}
if (key == IdDeliveryQtt) {
return ssDeliveryQtt;
}
if (key == IdImportdelivery) {
return ssImportdelivery;
}
if (key == IdPEP) {
return ssPEP;
}
if (key == IdPlaceId) {
return ssPlaceId;
}
if (key == IdPlaceName) {
return ssPlaceName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdOrderMainItemId.Key.AsGuid) {
return ssOrderMainItemId;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdArticleNumber.Key.AsGuid) {
return ssArticleNumber;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdInputationCode.Key.AsGuid) {
return ssInputationCode;
}
if (attributeKey == IdDeliveryDate.Key.AsGuid) {
return ssDeliveryDate;
}
if (attributeKey == IdInvoiceQtt.Key.AsGuid) {
return ssInvoiceQtt;
}
if (attributeKey == IdRemainingQtt.Key.AsGuid) {
return ssRemainingQtt;
}
if (attributeKey == IdUnitPrice.Key.AsGuid) {
return ssUnitPrice;
}
if (attributeKey == IdTotalPrice.Key.AsGuid) {
return ssTotalPrice;
}
if (attributeKey == IdQuantity.Key.AsGuid) {
return ssQuantity;
}
if (attributeKey == IdDeliveryQtt.Key.AsGuid) {
return ssDeliveryQtt;
}
if (attributeKey == IdImportdelivery.Key.AsGuid) {
return ssImportdelivery;
}
if (attributeKey == IdPEP.Key.AsGuid) {
return ssPEP;
}
if (attributeKey == IdPlaceId.Key.AsGuid) {
return ssPlaceId;
}
if (attributeKey == IdPlaceName.Key.AsGuid) {
return ssPlaceName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(18);
OptimizedAttributes = new BitArray(18);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdFolioId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFolioId);
ssOrderMainItemId = (long) other.AttributeGet(IdOrderMainItemId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrderMainItemId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrderMainItemId);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOrderNumber);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOrderNumber);
ssArticleNumber = (string) other.AttributeGet(IdArticleNumber);
ChangedAttributes[4] = other.ChangedAttributeGet(IdArticleNumber);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdArticleNumber);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[5] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdDescription);
ssInputationCode = (string) other.AttributeGet(IdInputationCode);
ChangedAttributes[6] = other.ChangedAttributeGet(IdInputationCode);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdInputationCode);
ssDeliveryDate = (DateTime) other.AttributeGet(IdDeliveryDate);
ChangedAttributes[7] = other.ChangedAttributeGet(IdDeliveryDate);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdDeliveryDate);
ssInvoiceQtt = (decimal) other.AttributeGet(IdInvoiceQtt);
ChangedAttributes[8] = other.ChangedAttributeGet(IdInvoiceQtt);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdInvoiceQtt);
ssRemainingQtt = (decimal) other.AttributeGet(IdRemainingQtt);
ChangedAttributes[9] = other.ChangedAttributeGet(IdRemainingQtt);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdRemainingQtt);
ssUnitPrice = (decimal) other.AttributeGet(IdUnitPrice);
ChangedAttributes[10] = other.ChangedAttributeGet(IdUnitPrice);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdUnitPrice);
ssTotalPrice = (decimal) other.AttributeGet(IdTotalPrice);
ChangedAttributes[11] = other.ChangedAttributeGet(IdTotalPrice);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdTotalPrice);
ssQuantity = (decimal) other.AttributeGet(IdQuantity);
ChangedAttributes[12] = other.ChangedAttributeGet(IdQuantity);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdQuantity);
ssDeliveryQtt = (string) other.AttributeGet(IdDeliveryQtt);
ChangedAttributes[13] = other.ChangedAttributeGet(IdDeliveryQtt);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdDeliveryQtt);
ssImportdelivery = (string) other.AttributeGet(IdImportdelivery);
ChangedAttributes[14] = other.ChangedAttributeGet(IdImportdelivery);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdImportdelivery);
ssPEP = (string) other.AttributeGet(IdPEP);
ChangedAttributes[15] = other.ChangedAttributeGet(IdPEP);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdPEP);
ssPlaceId = (string) other.AttributeGet(IdPlaceId);
ChangedAttributes[16] = other.ChangedAttributeGet(IdPlaceId);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdPlaceId);
ssPlaceName = (string) other.AttributeGet(IdPlaceName);
ChangedAttributes[17] = other.ChangedAttributeGet(IdPlaceName);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdPlaceName);
}
} // EN_868430b5192a8eb1a739e01247fc2704EntityRecord

/// <summary>
/// RecordList type <code>FolioItemsList</code> that represents a record list of
///  <code>FolioItems</code>
/// </summary>
public partial class RL_b77b3da1ad2da36bd119b7509a1a836d : GenericRecordList<EN_868430b5192a8eb1a739e01247fc2704EntityRecord>, IEnumerable, IEnumerator {

protected override EN_868430b5192a8eb1a739e01247fc2704EntityRecord GetElementDefaultValue() {
return new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
}

public T[] ToArray<T>(Func<EN_868430b5192a8eb1a739e01247fc2704EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b77b3da1ad2da36bd119b7509a1a836d recordList, Func<EN_868430b5192a8eb1a739e01247fc2704EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b77b3da1ad2da36bd119b7509a1a836d(EN_868430b5192a8eb1a739e01247fc2704EntityRecord[] array) {
  RL_b77b3da1ad2da36bd119b7509a1a836d result = new RL_b77b3da1ad2da36bd119b7509a1a836d();
result.InnerFromArray(array);
    return result;
}

public static RL_b77b3da1ad2da36bd119b7509a1a836d ToList<T>(T[] array, Func <T, EN_868430b5192a8eb1a739e01247fc2704EntityRecord> converter) {
  RL_b77b3da1ad2da36bd119b7509a1a836d result = new RL_b77b3da1ad2da36bd119b7509a1a836d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b77b3da1ad2da36bd119b7509a1a836d FromRestList<T>(RestList<T> restList, Func <T, EN_868430b5192a8eb1a739e01247fc2704EntityRecord> converter) {
  RL_b77b3da1ad2da36bd119b7509a1a836d result = new RL_b77b3da1ad2da36bd119b7509a1a836d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b77b3da1ad2da36bd119b7509a1a836d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_868430b5192a8eb1a739e01247fc2704EntityRecord> NewList() {
return new RL_b77b3da1ad2da36bd119b7509a1a836d();
}


} // RL_b77b3da1ad2da36bd119b7509a1a836d
}
