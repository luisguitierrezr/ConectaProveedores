namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrdersRequest (OpLoo_VSM0CNYG2kPO2pEA)
///  <code>ST_9c87dd52bd762501ef8a064794927f08Structure</code> that represent
/// s <code>OrdersRequest</code> <p>Description: Orders Request Structure</p>
/// </summary>
// Name: OrdersRequest
public partial struct ST_9c87dd52bd762501ef8a064794927f08Structure : ITypedRecord<ST_9c87dd52bd762501ef8a064794927f08Structure> {
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TZpusXCPEk2mGHmj6DGwow");
internal static readonly GlobalObjectKey IdCompanyCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RRDGsZRvMEKYIWPsRFPfjQ");
internal static readonly GlobalObjectKey IdClassDocument = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2uGn13iWukanR_kAKWIEUg");
internal static readonly GlobalObjectKey IdDeletedIndicator = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*F7DKKLf_KUyV9fFTLjKhLg");
internal static readonly GlobalObjectKey IdOrderDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1tZ_JXCXLkGBJwvM8vF9iw");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*24Q048fUi0CG90m3Bulvnw");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HveK7ArE402SamQlmouF+g");
internal static readonly GlobalObjectKey IdProcurementGroup = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cyn5cA43s0aCQzwHVfi2lw");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bC9SvRUDw0qxlEYrpufQcQ");
internal static readonly GlobalObjectKey IdCreatedByName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NUK1iJy5e0Ckhp3t+6FvTQ");
internal static readonly GlobalObjectKey IdCountryCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Y5YrFT8q2Em3wzqGT1d_IA");
internal static readonly GlobalObjectKey IdReleased = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2j1MSMwhcUaYhSDlkJDZFQ");
internal static readonly GlobalObjectKey IdExchangeRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GIRGy8RpGkqvmHRv91MyJg");
internal static readonly GlobalObjectKey IdCurrencyCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mccHj0mZHky7dPisEV9ovA");
internal static readonly GlobalObjectKey IdSustainabilityCategory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QRV7EjPBsUO98A0OPcSjjQ");
internal static readonly GlobalObjectKey IdSustainabilitySubcategory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AOE57Yu8NEGzcHpjPPPc3Q");
internal static readonly GlobalObjectKey IdOrderItems = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S8zf9kelrUicYBhp6XZlyg");

public string ssOrderNumber;

public string ssCompanyCode;

public string ssClassDocument;

public string ssDeletedIndicator;

public string ssOrderDate;

public string ssSupplierNumber;

public string ssSupplierName;

public string ssProcurementGroup;

public string ssCreatedBy;

public string ssCreatedByName;

public string ssCountryCode;

public string ssReleased;

public decimal ssExchangeRate;

public string ssCurrencyCode;

public string ssSustainabilityCategory;

public string ssSustainabilitySubcategory;

public RL_5a5dc4e5843197429d3408a507236d6a ssOrderItems;


public BitArray OptimizedAttributes;

public ST_9c87dd52bd762501ef8a064794927f08Structure() {
OptimizedAttributes = null;
ssOrderNumber = "";
ssCompanyCode = "";
ssClassDocument = "";
ssDeletedIndicator = "False";
ssOrderDate = "";
ssSupplierNumber = "";
ssSupplierName = "";
ssProcurementGroup = "";
ssCreatedBy = "";
ssCreatedByName = "";
ssCountryCode = "";
ssReleased = "False";
ssExchangeRate = 0.0M;
ssCurrencyCode = "";
ssSustainabilityCategory = "";
ssSustainabilitySubcategory = "";
ssOrderItems = new RL_5a5dc4e5843197429d3408a507236d6a();
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
ssOrderNumber = r.ReadText(index++, "OrdersRequest.OrderNumber", "");
ssCompanyCode = r.ReadText(index++, "OrdersRequest.CompanyCode", "");
ssClassDocument = r.ReadText(index++, "OrdersRequest.ClassDocument", "");
ssDeletedIndicator = r.ReadText(index++, "OrdersRequest.DeletedIndicator", "");
ssOrderDate = r.ReadText(index++, "OrdersRequest.OrderDate", "");
ssSupplierNumber = r.ReadText(index++, "OrdersRequest.SupplierNumber", "");
ssSupplierName = r.ReadText(index++, "OrdersRequest.SupplierName", "");
ssProcurementGroup = r.ReadText(index++, "OrdersRequest.ProcurementGroup", "");
ssCreatedBy = r.ReadText(index++, "OrdersRequest.CreatedBy", "");
ssCreatedByName = r.ReadText(index++, "OrdersRequest.CreatedByName", "");
ssCountryCode = r.ReadText(index++, "OrdersRequest.CountryCode", "");
ssReleased = r.ReadText(index++, "OrdersRequest.Released", "");
ssExchangeRate = r.ReadDecimal(index++, "OrdersRequest.ExchangeRate", 0.0M);
ssCurrencyCode = r.ReadText(index++, "OrdersRequest.CurrencyCode", "");
ssSustainabilityCategory = r.ReadText(index++, "OrdersRequest.SustainabilityCategory", "");
ssSustainabilitySubcategory = r.ReadText(index++, "OrdersRequest.SustainabilitySubcategory", "");
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
public void ReadIM(ST_9c87dd52bd762501ef8a064794927f08Structure r) {
this = r;
}


public static bool operator == (ST_9c87dd52bd762501ef8a064794927f08Structure a, ST_9c87dd52bd762501ef8a064794927f08Structure b) {
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssCompanyCode != b.ssCompanyCode) return false;
if (a.ssClassDocument != b.ssClassDocument) return false;
if (a.ssDeletedIndicator != b.ssDeletedIndicator) return false;
if (a.ssOrderDate != b.ssOrderDate) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssProcurementGroup != b.ssProcurementGroup) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedByName != b.ssCreatedByName) return false;
if (a.ssCountryCode != b.ssCountryCode) return false;
if (a.ssReleased != b.ssReleased) return false;
if (a.ssExchangeRate != b.ssExchangeRate) return false;
if (a.ssCurrencyCode != b.ssCurrencyCode) return false;
if (a.ssSustainabilityCategory != b.ssSustainabilityCategory) return false;
if (a.ssSustainabilitySubcategory != b.ssSustainabilitySubcategory) return false;
if (a.ssOrderItems != b.ssOrderItems) return false;
return true;
}

public static bool operator != (ST_9c87dd52bd762501ef8a064794927f08Structure a, ST_9c87dd52bd762501ef8a064794927f08Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9c87dd52bd762501ef8a064794927f08Structure)) return false;
return (this == (ST_9c87dd52bd762501ef8a064794927f08Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssCompanyCode.GetHashCode()
 ^ ssClassDocument.GetHashCode()
 ^ ssDeletedIndicator.GetHashCode()
 ^ ssOrderDate.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssProcurementGroup.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedByName.GetHashCode()
 ^ ssCountryCode.GetHashCode()
 ^ ssReleased.GetHashCode()
 ^ ssExchangeRate.GetHashCode()
 ^ ssCurrencyCode.GetHashCode()
 ^ ssSustainabilityCategory.GetHashCode()
 ^ ssSustainabilitySubcategory.GetHashCode()
 ^ ssOrderItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssOrderItems.RecursiveReset();
}

public void InternalRecursiveSave() {
ssOrderItems.InternalRecursiveSave();
}


public ST_9c87dd52bd762501ef8a064794927f08Structure Duplicate() {
ST_9c87dd52bd762501ef8a064794927f08Structure t;
t.ssOrderNumber = this.ssOrderNumber;
t.ssCompanyCode = this.ssCompanyCode;
t.ssClassDocument = this.ssClassDocument;
t.ssDeletedIndicator = this.ssDeletedIndicator;
t.ssOrderDate = this.ssOrderDate;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssSupplierName = this.ssSupplierName;
t.ssProcurementGroup = this.ssProcurementGroup;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedByName = this.ssCreatedByName;
t.ssCountryCode = this.ssCountryCode;
t.ssReleased = this.ssReleased;
t.ssExchangeRate = this.ssExchangeRate;
t.ssCurrencyCode = this.ssCurrencyCode;
t.ssSustainabilityCategory = this.ssSustainabilityCategory;
t.ssSustainabilitySubcategory = this.ssSustainabilitySubcategory;
t.ssOrderItems = (RL_5a5dc4e5843197429d3408a507236d6a)this.ssOrderItems.Duplicate();
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
if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "companycode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyCode")) variable.Value = ssCompanyCode; else variable.Optimized = true;
} else if (head == "classdocument") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ClassDocument")) variable.Value = ssClassDocument; else variable.Optimized = true;
} else if (head == "deletedindicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeletedIndicator")) variable.Value = ssDeletedIndicator; else variable.Optimized = true;
} else if (head == "orderdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDate")) variable.Value = ssOrderDate; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "procurementgroup") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcurementGroup")) variable.Value = ssProcurementGroup; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdbyname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedByName")) variable.Value = ssCreatedByName; else variable.Optimized = true;
} else if (head == "countrycode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CountryCode")) variable.Value = ssCountryCode; else variable.Optimized = true;
} else if (head == "released") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Released")) variable.Value = ssReleased; else variable.Optimized = true;
} else if (head == "exchangerate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExchangeRate")) variable.Value = ssExchangeRate; else variable.Optimized = true;
} else if (head == "currencycode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyCode")) variable.Value = ssCurrencyCode; else variable.Optimized = true;
} else if (head == "sustainabilitycategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SustainabilityCategory")) variable.Value = ssSustainabilityCategory; else variable.Optimized = true;
} else if (head == "sustainabilitysubcategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SustainabilitySubcategory")) variable.Value = ssSustainabilitySubcategory; else variable.Optimized = true;
} else if (head == "orderitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderItems")) variable.Value = ssOrderItems; else variable.Optimized = true;
variable.SetFieldName("orderitems");
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
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdCompanyCode) {
return ssCompanyCode;
}
if (key == IdClassDocument) {
return ssClassDocument;
}
if (key == IdDeletedIndicator) {
return ssDeletedIndicator;
}
if (key == IdOrderDate) {
return ssOrderDate;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdProcurementGroup) {
return ssProcurementGroup;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedByName) {
return ssCreatedByName;
}
if (key == IdCountryCode) {
return ssCountryCode;
}
if (key == IdReleased) {
return ssReleased;
}
if (key == IdExchangeRate) {
return ssExchangeRate;
}
if (key == IdCurrencyCode) {
return ssCurrencyCode;
}
if (key == IdSustainabilityCategory) {
return ssSustainabilityCategory;
}
if (key == IdSustainabilitySubcategory) {
return ssSustainabilitySubcategory;
}
if (key == IdOrderItems) {
return ssOrderItems;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdCompanyCode.Key.AsGuid) {
return ssCompanyCode;
}
if (attributeKey == IdClassDocument.Key.AsGuid) {
return ssClassDocument;
}
if (attributeKey == IdDeletedIndicator.Key.AsGuid) {
return ssDeletedIndicator;
}
if (attributeKey == IdOrderDate.Key.AsGuid) {
return ssOrderDate;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdProcurementGroup.Key.AsGuid) {
return ssProcurementGroup;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedByName.Key.AsGuid) {
return ssCreatedByName;
}
if (attributeKey == IdCountryCode.Key.AsGuid) {
return ssCountryCode;
}
if (attributeKey == IdReleased.Key.AsGuid) {
return ssReleased;
}
if (attributeKey == IdExchangeRate.Key.AsGuid) {
return ssExchangeRate;
}
if (attributeKey == IdCurrencyCode.Key.AsGuid) {
return ssCurrencyCode;
}
if (attributeKey == IdSustainabilityCategory.Key.AsGuid) {
return ssSustainabilityCategory;
}
if (attributeKey == IdSustainabilitySubcategory.Key.AsGuid) {
return ssSustainabilitySubcategory;
}
if (attributeKey == IdOrderItems.Key.AsGuid) {
return ssOrderItems;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssCompanyCode = (string) other.AttributeGet(IdCompanyCode);
ssClassDocument = (string) other.AttributeGet(IdClassDocument);
ssDeletedIndicator = (string) other.AttributeGet(IdDeletedIndicator);
ssOrderDate = (string) other.AttributeGet(IdOrderDate);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssProcurementGroup = (string) other.AttributeGet(IdProcurementGroup);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedByName = (string) other.AttributeGet(IdCreatedByName);
ssCountryCode = (string) other.AttributeGet(IdCountryCode);
ssReleased = (string) other.AttributeGet(IdReleased);
ssExchangeRate = (decimal) other.AttributeGet(IdExchangeRate);
ssCurrencyCode = (string) other.AttributeGet(IdCurrencyCode);
ssSustainabilityCategory = (string) other.AttributeGet(IdSustainabilityCategory);
ssSustainabilitySubcategory = (string) other.AttributeGet(IdSustainabilitySubcategory);
ssOrderItems = new RL_5a5dc4e5843197429d3408a507236d6a();
ssOrderItems.FillFromOther((IOSList) other.AttributeGet(IdOrderItems));
}
} // ST_9c87dd52bd762501ef8a064794927f08Structure
/// <summary>
/// RecordList type <code>OrdersRequestList</code> that represents a record list of
///  <code>OrdersRequest</code>
/// </summary>
public partial class RL_d8b7526bb177182c922f69815bb6eb34 : GenericRecordList<ST_9c87dd52bd762501ef8a064794927f08Structure>, IEnumerable, IEnumerator {

protected override ST_9c87dd52bd762501ef8a064794927f08Structure GetElementDefaultValue() {
return new ST_9c87dd52bd762501ef8a064794927f08Structure();
}

public T[] ToArray<T>(Func<ST_9c87dd52bd762501ef8a064794927f08Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8b7526bb177182c922f69815bb6eb34 recordList, Func<ST_9c87dd52bd762501ef8a064794927f08Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8b7526bb177182c922f69815bb6eb34(ST_9c87dd52bd762501ef8a064794927f08Structure[] array) {
  RL_d8b7526bb177182c922f69815bb6eb34 result = new RL_d8b7526bb177182c922f69815bb6eb34();
result.InnerFromArray(array);
    return result;
}

public static RL_d8b7526bb177182c922f69815bb6eb34 ToList<T>(T[] array, Func <T, ST_9c87dd52bd762501ef8a064794927f08Structure> converter) {
  RL_d8b7526bb177182c922f69815bb6eb34 result = new RL_d8b7526bb177182c922f69815bb6eb34();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8b7526bb177182c922f69815bb6eb34 FromRestList<T>(RestList<T> restList, Func <T, ST_9c87dd52bd762501ef8a064794927f08Structure> converter) {
  RL_d8b7526bb177182c922f69815bb6eb34 result = new RL_d8b7526bb177182c922f69815bb6eb34();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8b7526bb177182c922f69815bb6eb34() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9c87dd52bd762501ef8a064794927f08Structure> NewList() {
return new RL_d8b7526bb177182c922f69815bb6eb34();
}


} // RL_d8b7526bb177182c922f69815bb6eb34
}

