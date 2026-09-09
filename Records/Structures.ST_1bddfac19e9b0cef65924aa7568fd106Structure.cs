namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioItem (iYxwBtHdwEa5wfoOkK8qPQ)
///  <code>ST_1bddfac19e9b0cef65924aa7568fd106Structure</code> that represents <code>FolioItem</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioItem
public partial struct ST_1bddfac19e9b0cef65924aa7568fd106Structure : ITypedRecord<ST_1bddfac19e9b0cef65924aa7568fd106Structure> {
internal static readonly GlobalObjectKey IdSelect = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bcx5NnqdgkChH2n0NeKiBw");
internal static readonly GlobalObjectKey IdOrderMainItemId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pWq08n2lZkGavy6ZNtuaQA");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HTQF6t+CnUaIyzBgfOql1Q");
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zz17iVNktUCWuE5svO6H1A");
internal static readonly GlobalObjectKey IdMaterialCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7B84y0peQEaCNdsuHsI4bg");
internal static readonly GlobalObjectKey IdMaterialDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ddW1q7YwA0GApvxs7R6dhw");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IXpIu5EIy0mpbwrAa0qDuA");
internal static readonly GlobalObjectKey IdQuantityDelivered = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*atvkhDX4U06+x_9GidfjtA");
internal static readonly GlobalObjectKey IdQuantityAvailable = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qZiNpeSV0EGdgN2ptWpjvw");
internal static readonly GlobalObjectKey IdOrderUnitOfMeasure = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7QKEPHnTZUSRgYyed5TDng");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SEbC8ivos0KVQzUGOGhMag");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4rXREn1900GvvTRij5Jphw");
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*F91jPljG+ESex9nSAW4EzA");
internal static readonly GlobalObjectKey IdStatusClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*84jIcl7_HEuf7gVJCPDZdA");
internal static readonly GlobalObjectKey IdDeliveryDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*c9LYNUy+rkKelaUZpAlVeg");
internal static readonly GlobalObjectKey IdUnitPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cUFGOKvkiE+78Omw1mrFjA");
internal static readonly GlobalObjectKey IdAssigmentCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*e_hAUW2cqUymMSimy8WEtA");
internal static readonly GlobalObjectKey IdVATRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RhtaBrF9hkO34VqidjN4pQ");
internal static readonly GlobalObjectKey IdImportDelivered = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*er2YXt9wf0CrYfv63LeTTw");
internal static readonly GlobalObjectKey IdIsDeleted = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+XMdgysNQUCBgxuCjnA6_g");
internal static readonly GlobalObjectKey IdIsBlocked = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uB33bNNtSEy+87Ywj4HNBg");
internal static readonly GlobalObjectKey IdBaseQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rLlmrTzgwk2U0pjk3g0xgg");
internal static readonly GlobalObjectKey IdIsFinalDelivered = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GpH0xiOABUC4ePbs3nrkgQ");
internal static readonly GlobalObjectKey IdPEP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FmKYfJuUUkGAp_w6hIuCow");
internal static readonly GlobalObjectKey IdIsMultipleImputation = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TUaAOE9zjka1ieFzKjMXsQ");

public bool ssSelect;

public long ssOrderMainItemId;

public string ssOrderNumber;

public string ssPosition;

public string ssMaterialCode;

public string ssMaterialDescription;

public decimal ssQuantity;

public decimal ssQuantityDelivered;

public decimal ssQuantityAvailable;

public string ssOrderUnitOfMeasure;

public string ssCurrency;

public decimal ssTotalAmount;

public string ssStatus;

public string ssStatusClass;

public DateTime ssDeliveryDate;

public decimal ssUnitPrice;

public string ssAssigmentCode;

public decimal ssVATRate;

public decimal ssImportDelivered;

public bool ssIsDeleted;

public bool ssIsBlocked;

public int ssBaseQuantity;

public bool ssIsFinalDelivered;

public string ssPEP;

public bool ssIsMultipleImputation;


public BitArray OptimizedAttributes;

public ST_1bddfac19e9b0cef65924aa7568fd106Structure() {
OptimizedAttributes = null;
ssSelect = false;
ssOrderMainItemId = 0L;
ssOrderNumber = "";
ssPosition = "";
ssMaterialCode = "";
ssMaterialDescription = "";
ssQuantity = 0.0M;
ssQuantityDelivered = 0.0M;
ssQuantityAvailable = 0.0M;
ssOrderUnitOfMeasure = "";
ssCurrency = "";
ssTotalAmount = 0.0M;
ssStatus = "";
ssStatusClass = "";
ssDeliveryDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssUnitPrice = 0.0M;
ssAssigmentCode = "";
ssVATRate = 0.0M;
ssImportDelivered = 0.0M;
ssIsDeleted = false;
ssIsBlocked = false;
ssBaseQuantity = 0;
ssIsFinalDelivered = false;
ssPEP = "";
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
ssSelect = r.ReadBoolean(index++, "FolioItem.Select", false);
ssOrderMainItemId = r.ReadEntityReferenceLongInteger(index++, "FolioItem.OrderMainItemId", 0L);
ssOrderNumber = r.ReadText(index++, "FolioItem.OrderNumber", "");
ssPosition = r.ReadText(index++, "FolioItem.Position", "");
ssMaterialCode = r.ReadText(index++, "FolioItem.MaterialCode", "");
ssMaterialDescription = r.ReadText(index++, "FolioItem.MaterialDescription", "");
ssQuantity = r.ReadDecimal(index++, "FolioItem.Quantity", 0.0M);
ssQuantityDelivered = r.ReadDecimal(index++, "FolioItem.QuantityDelivered", 0.0M);
ssQuantityAvailable = r.ReadDecimal(index++, "FolioItem.QuantityAvailable", 0.0M);
ssOrderUnitOfMeasure = r.ReadText(index++, "FolioItem.OrderUnitOfMeasure", "");
ssCurrency = r.ReadText(index++, "FolioItem.Currency", "");
ssTotalAmount = r.ReadDecimal(index++, "FolioItem.TotalAmount", 0.0M);
ssStatus = r.ReadText(index++, "FolioItem.Status", "");
ssStatusClass = r.ReadText(index++, "FolioItem.StatusClass", "");
ssDeliveryDate = r.ReadDate(index++, "FolioItem.DeliveryDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUnitPrice = r.ReadCurrency(index++, "FolioItem.UnitPrice", 0.0M);
ssAssigmentCode = r.ReadText(index++, "FolioItem.AssigmentCode", "");
ssVATRate = r.ReadDecimal(index++, "FolioItem.VATRate", 0.0M);
ssImportDelivered = r.ReadDecimal(index++, "FolioItem.ImportDelivered", 0.0M);
ssIsDeleted = r.ReadBoolean(index++, "FolioItem.IsDeleted", false);
ssIsBlocked = r.ReadBoolean(index++, "FolioItem.IsBlocked", false);
ssBaseQuantity = r.ReadInteger(index++, "FolioItem.BaseQuantity", 0);
ssIsFinalDelivered = r.ReadBoolean(index++, "FolioItem.IsFinalDelivered", false);
ssPEP = r.ReadText(index++, "FolioItem.PEP", "");
ssIsMultipleImputation = r.ReadBoolean(index++, "FolioItem.IsMultipleImputation", false);
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
public void ReadIM(ST_1bddfac19e9b0cef65924aa7568fd106Structure r) {
this = r;
}


public static bool operator == (ST_1bddfac19e9b0cef65924aa7568fd106Structure a, ST_1bddfac19e9b0cef65924aa7568fd106Structure b) {
if (a.ssSelect != b.ssSelect) return false;
if (a.ssOrderMainItemId != b.ssOrderMainItemId) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssPosition != b.ssPosition) return false;
if (a.ssMaterialCode != b.ssMaterialCode) return false;
if (a.ssMaterialDescription != b.ssMaterialDescription) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssQuantityDelivered != b.ssQuantityDelivered) return false;
if (a.ssQuantityAvailable != b.ssQuantityAvailable) return false;
if (a.ssOrderUnitOfMeasure != b.ssOrderUnitOfMeasure) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssStatus != b.ssStatus) return false;
if (a.ssStatusClass != b.ssStatusClass) return false;
if (a.ssDeliveryDate != b.ssDeliveryDate) return false;
if (a.ssUnitPrice != b.ssUnitPrice) return false;
if (a.ssAssigmentCode != b.ssAssigmentCode) return false;
if (a.ssVATRate != b.ssVATRate) return false;
if (a.ssImportDelivered != b.ssImportDelivered) return false;
if (a.ssIsDeleted != b.ssIsDeleted) return false;
if (a.ssIsBlocked != b.ssIsBlocked) return false;
if (a.ssBaseQuantity != b.ssBaseQuantity) return false;
if (a.ssIsFinalDelivered != b.ssIsFinalDelivered) return false;
if (a.ssPEP != b.ssPEP) return false;
if (a.ssIsMultipleImputation != b.ssIsMultipleImputation) return false;
return true;
}

public static bool operator != (ST_1bddfac19e9b0cef65924aa7568fd106Structure a, ST_1bddfac19e9b0cef65924aa7568fd106Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1bddfac19e9b0cef65924aa7568fd106Structure)) return false;
return (this == (ST_1bddfac19e9b0cef65924aa7568fd106Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSelect.GetHashCode()
 ^ ssOrderMainItemId.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssPosition.GetHashCode()
 ^ ssMaterialCode.GetHashCode()
 ^ ssMaterialDescription.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssQuantityDelivered.GetHashCode()
 ^ ssQuantityAvailable.GetHashCode()
 ^ ssOrderUnitOfMeasure.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssStatus.GetHashCode()
 ^ ssStatusClass.GetHashCode()
 ^ ssDeliveryDate.GetHashCode()
 ^ ssUnitPrice.GetHashCode()
 ^ ssAssigmentCode.GetHashCode()
 ^ ssVATRate.GetHashCode()
 ^ ssImportDelivered.GetHashCode()
 ^ ssIsDeleted.GetHashCode()
 ^ ssIsBlocked.GetHashCode()
 ^ ssBaseQuantity.GetHashCode()
 ^ ssIsFinalDelivered.GetHashCode()
 ^ ssPEP.GetHashCode()
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


public ST_1bddfac19e9b0cef65924aa7568fd106Structure Duplicate() {
ST_1bddfac19e9b0cef65924aa7568fd106Structure t;
t.ssSelect = this.ssSelect;
t.ssOrderMainItemId = this.ssOrderMainItemId;
t.ssOrderNumber = this.ssOrderNumber;
t.ssPosition = this.ssPosition;
t.ssMaterialCode = this.ssMaterialCode;
t.ssMaterialDescription = this.ssMaterialDescription;
t.ssQuantity = this.ssQuantity;
t.ssQuantityDelivered = this.ssQuantityDelivered;
t.ssQuantityAvailable = this.ssQuantityAvailable;
t.ssOrderUnitOfMeasure = this.ssOrderUnitOfMeasure;
t.ssCurrency = this.ssCurrency;
t.ssTotalAmount = this.ssTotalAmount;
t.ssStatus = this.ssStatus;
t.ssStatusClass = this.ssStatusClass;
t.ssDeliveryDate = this.ssDeliveryDate;
t.ssUnitPrice = this.ssUnitPrice;
t.ssAssigmentCode = this.ssAssigmentCode;
t.ssVATRate = this.ssVATRate;
t.ssImportDelivered = this.ssImportDelivered;
t.ssIsDeleted = this.ssIsDeleted;
t.ssIsBlocked = this.ssIsBlocked;
t.ssBaseQuantity = this.ssBaseQuantity;
t.ssIsFinalDelivered = this.ssIsFinalDelivered;
t.ssPEP = this.ssPEP;
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
if (head == "select") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Select")) variable.Value = ssSelect; else variable.Optimized = true;
} else if (head == "ordermainitemid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItemId")) variable.Value = ssOrderMainItemId; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
} else if (head == "materialcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaterialCode")) variable.Value = ssMaterialCode; else variable.Optimized = true;
} else if (head == "materialdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaterialDescription")) variable.Value = ssMaterialDescription; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity")) variable.Value = ssQuantity; else variable.Optimized = true;
} else if (head == "quantitydelivered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".QuantityDelivered")) variable.Value = ssQuantityDelivered; else variable.Optimized = true;
} else if (head == "quantityavailable") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".QuantityAvailable")) variable.Value = ssQuantityAvailable; else variable.Optimized = true;
} else if (head == "orderunitofmeasure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderUnitOfMeasure")) variable.Value = ssOrderUnitOfMeasure; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
} else if (head == "statusclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StatusClass")) variable.Value = ssStatusClass; else variable.Optimized = true;
} else if (head == "deliverydate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveryDate")) variable.Value = ssDeliveryDate; else variable.Optimized = true;
} else if (head == "unitprice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitPrice")) variable.Value = ssUnitPrice; else variable.Optimized = true;
} else if (head == "assigmentcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssigmentCode")) variable.Value = ssAssigmentCode; else variable.Optimized = true;
} else if (head == "vatrate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VATRate")) variable.Value = ssVATRate; else variable.Optimized = true;
} else if (head == "importdelivered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImportDelivered")) variable.Value = ssImportDelivered; else variable.Optimized = true;
} else if (head == "isdeleted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDeleted")) variable.Value = ssIsDeleted; else variable.Optimized = true;
} else if (head == "isblocked") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsBlocked")) variable.Value = ssIsBlocked; else variable.Optimized = true;
} else if (head == "basequantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BaseQuantity")) variable.Value = ssBaseQuantity; else variable.Optimized = true;
} else if (head == "isfinaldelivered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsFinalDelivered")) variable.Value = ssIsFinalDelivered; else variable.Optimized = true;
} else if (head == "pep") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEP")) variable.Value = ssPEP; else variable.Optimized = true;
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
if (key == IdSelect) {
return ssSelect;
}
if (key == IdOrderMainItemId) {
return ssOrderMainItemId;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdPosition) {
return ssPosition;
}
if (key == IdMaterialCode) {
return ssMaterialCode;
}
if (key == IdMaterialDescription) {
return ssMaterialDescription;
}
if (key == IdQuantity) {
return ssQuantity;
}
if (key == IdQuantityDelivered) {
return ssQuantityDelivered;
}
if (key == IdQuantityAvailable) {
return ssQuantityAvailable;
}
if (key == IdOrderUnitOfMeasure) {
return ssOrderUnitOfMeasure;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdStatus) {
return ssStatus;
}
if (key == IdStatusClass) {
return ssStatusClass;
}
if (key == IdDeliveryDate) {
return ssDeliveryDate;
}
if (key == IdUnitPrice) {
return ssUnitPrice;
}
if (key == IdAssigmentCode) {
return ssAssigmentCode;
}
if (key == IdVATRate) {
return ssVATRate;
}
if (key == IdImportDelivered) {
return ssImportDelivered;
}
if (key == IdIsDeleted) {
return ssIsDeleted;
}
if (key == IdIsBlocked) {
return ssIsBlocked;
}
if (key == IdBaseQuantity) {
return ssBaseQuantity;
}
if (key == IdIsFinalDelivered) {
return ssIsFinalDelivered;
}
if (key == IdPEP) {
return ssPEP;
}
if (key == IdIsMultipleImputation) {
return ssIsMultipleImputation;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSelect.Key.AsGuid) {
return ssSelect;
}
if (attributeKey == IdOrderMainItemId.Key.AsGuid) {
return ssOrderMainItemId;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
if (attributeKey == IdMaterialCode.Key.AsGuid) {
return ssMaterialCode;
}
if (attributeKey == IdMaterialDescription.Key.AsGuid) {
return ssMaterialDescription;
}
if (attributeKey == IdQuantity.Key.AsGuid) {
return ssQuantity;
}
if (attributeKey == IdQuantityDelivered.Key.AsGuid) {
return ssQuantityDelivered;
}
if (attributeKey == IdQuantityAvailable.Key.AsGuid) {
return ssQuantityAvailable;
}
if (attributeKey == IdOrderUnitOfMeasure.Key.AsGuid) {
return ssOrderUnitOfMeasure;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdStatus.Key.AsGuid) {
return ssStatus;
}
if (attributeKey == IdStatusClass.Key.AsGuid) {
return ssStatusClass;
}
if (attributeKey == IdDeliveryDate.Key.AsGuid) {
return ssDeliveryDate;
}
if (attributeKey == IdUnitPrice.Key.AsGuid) {
return ssUnitPrice;
}
if (attributeKey == IdAssigmentCode.Key.AsGuid) {
return ssAssigmentCode;
}
if (attributeKey == IdVATRate.Key.AsGuid) {
return ssVATRate;
}
if (attributeKey == IdImportDelivered.Key.AsGuid) {
return ssImportDelivered;
}
if (attributeKey == IdIsDeleted.Key.AsGuid) {
return ssIsDeleted;
}
if (attributeKey == IdIsBlocked.Key.AsGuid) {
return ssIsBlocked;
}
if (attributeKey == IdBaseQuantity.Key.AsGuid) {
return ssBaseQuantity;
}
if (attributeKey == IdIsFinalDelivered.Key.AsGuid) {
return ssIsFinalDelivered;
}
if (attributeKey == IdPEP.Key.AsGuid) {
return ssPEP;
}
if (attributeKey == IdIsMultipleImputation.Key.AsGuid) {
return ssIsMultipleImputation;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSelect = (bool) other.AttributeGet(IdSelect);
ssOrderMainItemId = (long) other.AttributeGet(IdOrderMainItemId);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssPosition = (string) other.AttributeGet(IdPosition);
ssMaterialCode = (string) other.AttributeGet(IdMaterialCode);
ssMaterialDescription = (string) other.AttributeGet(IdMaterialDescription);
ssQuantity = (decimal) other.AttributeGet(IdQuantity);
ssQuantityDelivered = (decimal) other.AttributeGet(IdQuantityDelivered);
ssQuantityAvailable = (decimal) other.AttributeGet(IdQuantityAvailable);
ssOrderUnitOfMeasure = (string) other.AttributeGet(IdOrderUnitOfMeasure);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ssStatus = (string) other.AttributeGet(IdStatus);
ssStatusClass = (string) other.AttributeGet(IdStatusClass);
ssDeliveryDate = (DateTime) other.AttributeGet(IdDeliveryDate);
ssUnitPrice = (decimal) other.AttributeGet(IdUnitPrice);
ssAssigmentCode = (string) other.AttributeGet(IdAssigmentCode);
ssVATRate = (decimal) other.AttributeGet(IdVATRate);
ssImportDelivered = (decimal) other.AttributeGet(IdImportDelivered);
ssIsDeleted = (bool) other.AttributeGet(IdIsDeleted);
ssIsBlocked = (bool) other.AttributeGet(IdIsBlocked);
ssBaseQuantity = (int) other.AttributeGet(IdBaseQuantity);
ssIsFinalDelivered = (bool) other.AttributeGet(IdIsFinalDelivered);
ssPEP = (string) other.AttributeGet(IdPEP);
ssIsMultipleImputation = (bool) other.AttributeGet(IdIsMultipleImputation);
}
} // ST_1bddfac19e9b0cef65924aa7568fd106Structure
/// <summary>
/// RecordList type <code>FolioItemList</code> that represents a record list of <code>FolioItem</code>
/// </summary>
public partial class RL_4e1292c876d12cf32f3c04367498157e : GenericRecordList<ST_1bddfac19e9b0cef65924aa7568fd106Structure>, IEnumerable, IEnumerator {

protected override ST_1bddfac19e9b0cef65924aa7568fd106Structure GetElementDefaultValue() {
return new ST_1bddfac19e9b0cef65924aa7568fd106Structure();
}

public T[] ToArray<T>(Func<ST_1bddfac19e9b0cef65924aa7568fd106Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4e1292c876d12cf32f3c04367498157e recordList, Func<ST_1bddfac19e9b0cef65924aa7568fd106Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4e1292c876d12cf32f3c04367498157e(ST_1bddfac19e9b0cef65924aa7568fd106Structure[] array) {
  RL_4e1292c876d12cf32f3c04367498157e result = new RL_4e1292c876d12cf32f3c04367498157e();
result.InnerFromArray(array);
    return result;
}

public static RL_4e1292c876d12cf32f3c04367498157e ToList<T>(T[] array, Func <T, ST_1bddfac19e9b0cef65924aa7568fd106Structure> converter) {
  RL_4e1292c876d12cf32f3c04367498157e result = new RL_4e1292c876d12cf32f3c04367498157e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4e1292c876d12cf32f3c04367498157e FromRestList<T>(RestList<T> restList, Func <T, ST_1bddfac19e9b0cef65924aa7568fd106Structure> converter) {
  RL_4e1292c876d12cf32f3c04367498157e result = new RL_4e1292c876d12cf32f3c04367498157e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4e1292c876d12cf32f3c04367498157e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1bddfac19e9b0cef65924aa7568fd106Structure> NewList() {
return new RL_4e1292c876d12cf32f3c04367498157e();
}


} // RL_4e1292c876d12cf32f3c04367498157e
}

