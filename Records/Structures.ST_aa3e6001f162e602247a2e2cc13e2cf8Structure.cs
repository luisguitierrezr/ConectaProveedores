namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioStruct (MtgDLaWsEk2ueVeemrz74w)
///  <code>ST_aa3e6001f162e602247a2e2cc13e2cf8Structure</code> that represents <code>FolioStruct</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioStruct
public partial struct ST_aa3e6001f162e602247a2e2cc13e2cf8Structure : ITypedRecord<ST_aa3e6001f162e602247a2e2cc13e2cf8Structure> {
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8qqDywu9FEWLw8uyWHVRrw");
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*y6aWR2C1+E+2lPHh0LYYDw");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+zTvqxJUDE+BjK7jdF8Qhg");
internal static readonly GlobalObjectKey IdArticleNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tKlFL76PPUuR+1eYfIlpdA");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*moRoRJ5r40GvwmU5RBbwKQ");
internal static readonly GlobalObjectKey IdInputationCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WKzAet+Po0i33PXDTahxaA");
internal static readonly GlobalObjectKey IdDeliveryDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jJphbXNZ+0OKAIPpezhgCg");
internal static readonly GlobalObjectKey IdInvoiceQtt = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*P+4Ec567A0KkPlU7ri+iZA");
internal static readonly GlobalObjectKey IdRemainingQtt = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SP7EGyvn6EGPlX35J9WH4g");
internal static readonly GlobalObjectKey IdRemainingQttTotal = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eRPef5AuekOdB39Tnku61Q");
internal static readonly GlobalObjectKey IdUnitPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5zfGVEJMTUKENFPwlHYnRQ");
internal static readonly GlobalObjectKey IdTotalPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DR7m_jm+NU6UOZ5ORZuh8w");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AyIHTE42ekyrHE5nE8YQrA");
internal static readonly GlobalObjectKey IdDeliveryQtt = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sgDIP_1b_UWLzo5LWzp8kw");
internal static readonly GlobalObjectKey IdImportdelivery = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*osNCXKK3FUqGvDYQ+PyoXw");
internal static readonly GlobalObjectKey IdIsInvoiceError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*K6tLqXAayUK682tuPNpXQg");
internal static readonly GlobalObjectKey IdIsDateError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0EeSLxRyXUq9XAIWeMes8w");
internal static readonly GlobalObjectKey IdIsPEPError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fN7ly5l5fkKqXcnYti0Q6g");
internal static readonly GlobalObjectKey IdPEP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*umZzEB0j7kWVNBDCzv6fbw");
internal static readonly GlobalObjectKey IdPlaceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jYg7UAkqtkSwn5Q7_StvBg");
internal static readonly GlobalObjectKey IdPlaceName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*m2VB8z6s9EWeuik4KiMaew");
internal static readonly GlobalObjectKey IdBaseQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1Ldu+myVf0KBYkMFRa0nGQ");
internal static readonly GlobalObjectKey IdVatRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MKZamKMoV0eqwnvKZZpRvQ");
internal static readonly GlobalObjectKey IdIsMultipleImputation = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*s9s5VYqRukeAyuQQjgaE7g");

public long ssOrderMainId;

public string ssPosition;

public string ssOrderNumber;

public string ssArticleNumber;

public string ssDescription;

public string ssInputationCode;

public DateTime ssDeliveryDate;

public decimal ssInvoiceQtt;

public decimal ssRemainingQtt;

public decimal ssRemainingQttTotal;

public decimal ssUnitPrice;

public decimal ssTotalPrice;

public decimal ssQuantity;

public string ssDeliveryQtt;

public decimal ssImportdelivery;

public bool ssIsInvoiceError;

public bool ssIsDateError;

public bool ssIsPEPError;

public string ssPEP;

public string ssPlaceId;

public string ssPlaceName;

public int ssBaseQuantity;

public decimal ssVatRate;

public bool ssIsMultipleImputation;


public BitArray OptimizedAttributes;

public ST_aa3e6001f162e602247a2e2cc13e2cf8Structure() {
OptimizedAttributes = null;
ssOrderMainId = 0L;
ssPosition = "";
ssOrderNumber = "";
ssArticleNumber = "";
ssDescription = "";
ssInputationCode = "";
ssDeliveryDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssInvoiceQtt = 0.0M;
ssRemainingQtt = 0.0M;
ssRemainingQttTotal = 0.0M;
ssUnitPrice = 0.0M;
ssTotalPrice = 0.0M;
ssQuantity = 0.0M;
ssDeliveryQtt = "";
ssImportdelivery = 0.0M;
ssIsInvoiceError = false;
ssIsDateError = false;
ssIsPEPError = false;
ssPEP = "";
ssPlaceId = "";
ssPlaceName = "";
ssBaseQuantity = 0;
ssVatRate = 0.0M;
ssIsMultipleImputation = false;
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
ssOrderMainId = r.ReadEntityReferenceLongInteger(index++, "FolioStruct.OrderMainId", 0L);
ssPosition = r.ReadText(index++, "FolioStruct.Position", "");
ssOrderNumber = r.ReadText(index++, "FolioStruct.OrderNumber", "");
ssArticleNumber = r.ReadText(index++, "FolioStruct.ArticleNumber", "");
ssDescription = r.ReadText(index++, "FolioStruct.Description", "");
ssInputationCode = r.ReadText(index++, "FolioStruct.InputationCode", "");
ssDeliveryDate = r.ReadDate(index++, "FolioStruct.DeliveryDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssInvoiceQtt = r.ReadDecimal(index++, "FolioStruct.InvoiceQtt", 0.0M);
ssRemainingQtt = r.ReadDecimal(index++, "FolioStruct.RemainingQtt", 0.0M);
ssRemainingQttTotal = r.ReadDecimal(index++, "FolioStruct.RemainingQttTotal", 0.0M);
ssUnitPrice = r.ReadDecimal(index++, "FolioStruct.UnitPrice", 0.0M);
ssTotalPrice = r.ReadDecimal(index++, "FolioStruct.TotalPrice", 0.0M);
ssQuantity = r.ReadDecimal(index++, "FolioStruct.Quantity", 0.0M);
ssDeliveryQtt = r.ReadText(index++, "FolioStruct.DeliveryQtt", "");
ssImportdelivery = r.ReadDecimal(index++, "FolioStruct.Importdelivery", 0.0M);
ssIsInvoiceError = r.ReadBoolean(index++, "FolioStruct.IsInvoiceError", false);
ssIsDateError = r.ReadBoolean(index++, "FolioStruct.IsDateError", false);
ssIsPEPError = r.ReadBoolean(index++, "FolioStruct.IsPEPError", false);
ssPEP = r.ReadText(index++, "FolioStruct.PEP", "");
ssPlaceId = r.ReadText(index++, "FolioStruct.PlaceId", "");
ssPlaceName = r.ReadText(index++, "FolioStruct.PlaceName", "");
ssBaseQuantity = r.ReadInteger(index++, "FolioStruct.BaseQuantity", 0);
ssVatRate = r.ReadDecimal(index++, "FolioStruct.VatRate", 0.0M);
ssIsMultipleImputation = r.ReadBoolean(index++, "FolioStruct.IsMultipleImputation", false);
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
public void ReadIM(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure r) {
this = r;
}


public static bool operator == (ST_aa3e6001f162e602247a2e2cc13e2cf8Structure a, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure b) {
if (a.ssOrderMainId != b.ssOrderMainId) return false;
if (a.ssPosition != b.ssPosition) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssArticleNumber != b.ssArticleNumber) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssInputationCode != b.ssInputationCode) return false;
if (a.ssDeliveryDate != b.ssDeliveryDate) return false;
if (a.ssInvoiceQtt != b.ssInvoiceQtt) return false;
if (a.ssRemainingQtt != b.ssRemainingQtt) return false;
if (a.ssRemainingQttTotal != b.ssRemainingQttTotal) return false;
if (a.ssUnitPrice != b.ssUnitPrice) return false;
if (a.ssTotalPrice != b.ssTotalPrice) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssDeliveryQtt != b.ssDeliveryQtt) return false;
if (a.ssImportdelivery != b.ssImportdelivery) return false;
if (a.ssIsInvoiceError != b.ssIsInvoiceError) return false;
if (a.ssIsDateError != b.ssIsDateError) return false;
if (a.ssIsPEPError != b.ssIsPEPError) return false;
if (a.ssPEP != b.ssPEP) return false;
if (a.ssPlaceId != b.ssPlaceId) return false;
if (a.ssPlaceName != b.ssPlaceName) return false;
if (a.ssBaseQuantity != b.ssBaseQuantity) return false;
if (a.ssVatRate != b.ssVatRate) return false;
if (a.ssIsMultipleImputation != b.ssIsMultipleImputation) return false;
return true;
}

public static bool operator != (ST_aa3e6001f162e602247a2e2cc13e2cf8Structure a, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_aa3e6001f162e602247a2e2cc13e2cf8Structure)) return false;
return (this == (ST_aa3e6001f162e602247a2e2cc13e2cf8Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderMainId.GetHashCode()
 ^ ssPosition.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssArticleNumber.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssInputationCode.GetHashCode()
 ^ ssDeliveryDate.GetHashCode()
 ^ ssInvoiceQtt.GetHashCode()
 ^ ssRemainingQtt.GetHashCode()
 ^ ssRemainingQttTotal.GetHashCode()
 ^ ssUnitPrice.GetHashCode()
 ^ ssTotalPrice.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssDeliveryQtt.GetHashCode()
 ^ ssImportdelivery.GetHashCode()
 ^ ssIsInvoiceError.GetHashCode()
 ^ ssIsDateError.GetHashCode()
 ^ ssIsPEPError.GetHashCode()
 ^ ssPEP.GetHashCode()
 ^ ssPlaceId.GetHashCode()
 ^ ssPlaceName.GetHashCode()
 ^ ssBaseQuantity.GetHashCode()
 ^ ssVatRate.GetHashCode()
 ^ ssIsMultipleImputation.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_aa3e6001f162e602247a2e2cc13e2cf8Structure Duplicate() {
ST_aa3e6001f162e602247a2e2cc13e2cf8Structure t;
t.ssOrderMainId = this.ssOrderMainId;
t.ssPosition = this.ssPosition;
t.ssOrderNumber = this.ssOrderNumber;
t.ssArticleNumber = this.ssArticleNumber;
t.ssDescription = this.ssDescription;
t.ssInputationCode = this.ssInputationCode;
t.ssDeliveryDate = this.ssDeliveryDate;
t.ssInvoiceQtt = this.ssInvoiceQtt;
t.ssRemainingQtt = this.ssRemainingQtt;
t.ssRemainingQttTotal = this.ssRemainingQttTotal;
t.ssUnitPrice = this.ssUnitPrice;
t.ssTotalPrice = this.ssTotalPrice;
t.ssQuantity = this.ssQuantity;
t.ssDeliveryQtt = this.ssDeliveryQtt;
t.ssImportdelivery = this.ssImportdelivery;
t.ssIsInvoiceError = this.ssIsInvoiceError;
t.ssIsDateError = this.ssIsDateError;
t.ssIsPEPError = this.ssIsPEPError;
t.ssPEP = this.ssPEP;
t.ssPlaceId = this.ssPlaceId;
t.ssPlaceName = this.ssPlaceName;
t.ssBaseQuantity = this.ssBaseQuantity;
t.ssVatRate = this.ssVatRate;
t.ssIsMultipleImputation = this.ssIsMultipleImputation;
t.OptimizedAttributes = null;
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
if (head == "ordermainid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId")) variable.Value = ssOrderMainId; else variable.Optimized = true;
} else if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
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
} else if (head == "remainingqtttotal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RemainingQttTotal")) variable.Value = ssRemainingQttTotal; else variable.Optimized = true;
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
} else if (head == "isinvoiceerror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsInvoiceError")) variable.Value = ssIsInvoiceError; else variable.Optimized = true;
} else if (head == "isdateerror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDateError")) variable.Value = ssIsDateError; else variable.Optimized = true;
} else if (head == "ispeperror") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsPEPError")) variable.Value = ssIsPEPError; else variable.Optimized = true;
} else if (head == "pep") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEP")) variable.Value = ssPEP; else variable.Optimized = true;
} else if (head == "placeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PlaceId")) variable.Value = ssPlaceId; else variable.Optimized = true;
} else if (head == "placename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PlaceName")) variable.Value = ssPlaceName; else variable.Optimized = true;
} else if (head == "basequantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BaseQuantity")) variable.Value = ssBaseQuantity; else variable.Optimized = true;
} else if (head == "vatrate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VatRate")) variable.Value = ssVatRate; else variable.Optimized = true;
} else if (head == "ismultipleimputation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsMultipleImputation")) variable.Value = ssIsMultipleImputation; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderMainId) {
return ssOrderMainId;
}
if (key == IdPosition) {
return ssPosition;
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
if (key == IdRemainingQttTotal) {
return ssRemainingQttTotal;
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
if (key == IdIsInvoiceError) {
return ssIsInvoiceError;
}
if (key == IdIsDateError) {
return ssIsDateError;
}
if (key == IdIsPEPError) {
return ssIsPEPError;
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
if (key == IdBaseQuantity) {
return ssBaseQuantity;
}
if (key == IdVatRate) {
return ssVatRate;
}
if (key == IdIsMultipleImputation) {
return ssIsMultipleImputation;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssOrderMainId;
}
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
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
if (attributeKey == IdRemainingQttTotal.Key.AsGuid) {
return ssRemainingQttTotal;
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
if (attributeKey == IdIsInvoiceError.Key.AsGuid) {
return ssIsInvoiceError;
}
if (attributeKey == IdIsDateError.Key.AsGuid) {
return ssIsDateError;
}
if (attributeKey == IdIsPEPError.Key.AsGuid) {
return ssIsPEPError;
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
if (attributeKey == IdBaseQuantity.Key.AsGuid) {
return ssBaseQuantity;
}
if (attributeKey == IdVatRate.Key.AsGuid) {
return ssVatRate;
}
if (attributeKey == IdIsMultipleImputation.Key.AsGuid) {
return ssIsMultipleImputation;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderMainId = (long) other.AttributeGet(IdOrderMainId);
ssPosition = (string) other.AttributeGet(IdPosition);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssArticleNumber = (string) other.AttributeGet(IdArticleNumber);
ssDescription = (string) other.AttributeGet(IdDescription);
ssInputationCode = (string) other.AttributeGet(IdInputationCode);
ssDeliveryDate = (DateTime) other.AttributeGet(IdDeliveryDate);
ssInvoiceQtt = (decimal) other.AttributeGet(IdInvoiceQtt);
ssRemainingQtt = (decimal) other.AttributeGet(IdRemainingQtt);
ssRemainingQttTotal = (decimal) other.AttributeGet(IdRemainingQttTotal);
ssUnitPrice = (decimal) other.AttributeGet(IdUnitPrice);
ssTotalPrice = (decimal) other.AttributeGet(IdTotalPrice);
ssQuantity = (decimal) other.AttributeGet(IdQuantity);
ssDeliveryQtt = (string) other.AttributeGet(IdDeliveryQtt);
ssImportdelivery = (decimal) other.AttributeGet(IdImportdelivery);
ssIsInvoiceError = (bool) other.AttributeGet(IdIsInvoiceError);
ssIsDateError = (bool) other.AttributeGet(IdIsDateError);
ssIsPEPError = (bool) other.AttributeGet(IdIsPEPError);
ssPEP = (string) other.AttributeGet(IdPEP);
ssPlaceId = (string) other.AttributeGet(IdPlaceId);
ssPlaceName = (string) other.AttributeGet(IdPlaceName);
ssBaseQuantity = (int) other.AttributeGet(IdBaseQuantity);
ssVatRate = (decimal) other.AttributeGet(IdVatRate);
ssIsMultipleImputation = (bool) other.AttributeGet(IdIsMultipleImputation);
}
} // ST_aa3e6001f162e602247a2e2cc13e2cf8Structure
/// <summary>
/// RecordList type <code>FolioStructList</code> that represents a record list of
///  <code>FolioStruct</code>
/// </summary>
public partial class RL_123aa03224ec08dab8cbe26021987012 : GenericRecordList<ST_aa3e6001f162e602247a2e2cc13e2cf8Structure>, IEnumerable, IEnumerator {

protected override ST_aa3e6001f162e602247a2e2cc13e2cf8Structure GetElementDefaultValue() {
return new ST_aa3e6001f162e602247a2e2cc13e2cf8Structure();
}

public T[] ToArray<T>(Func<ST_aa3e6001f162e602247a2e2cc13e2cf8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_123aa03224ec08dab8cbe26021987012 recordList, Func<ST_aa3e6001f162e602247a2e2cc13e2cf8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_123aa03224ec08dab8cbe26021987012(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure[] array) {
  RL_123aa03224ec08dab8cbe26021987012 result = new RL_123aa03224ec08dab8cbe26021987012();
result.InnerFromArray(array);
    return result;
}

public static RL_123aa03224ec08dab8cbe26021987012 ToList<T>(T[] array, Func <T, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure> converter) {
  RL_123aa03224ec08dab8cbe26021987012 result = new RL_123aa03224ec08dab8cbe26021987012();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_123aa03224ec08dab8cbe26021987012 FromRestList<T>(RestList<T> restList, Func <T, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure> converter) {
  RL_123aa03224ec08dab8cbe26021987012 result = new RL_123aa03224ec08dab8cbe26021987012();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_123aa03224ec08dab8cbe26021987012() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_aa3e6001f162e602247a2e2cc13e2cf8Structure> NewList() {
return new RL_123aa03224ec08dab8cbe26021987012();
}


} // RL_123aa03224ec08dab8cbe26021987012
}

