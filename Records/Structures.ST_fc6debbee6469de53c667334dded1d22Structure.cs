namespace ssConectaProveedores {
/// <summary>
/// [Structure] ReportSAPStatus_Item (mR7hFd2EoEeS_6R9zWoBVA)
///  <code>ST_fc6debbee6469de53c667334dded1d22Structure</code> that represent
/// s <code>ReportSAPStatus_Item</code> <p>Description: </p>
/// </summary>
// Name: ReportSAPStatus_Item
public partial struct ST_fc6debbee6469de53c667334dded1d22Structure : ITypedRecord<ST_fc6debbee6469de53c667334dded1d22Structure> {
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*H+9YEspBXECd+7mmIa5vQA");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rlB7q9xh0USsLq0m8BvUAQ");
internal static readonly GlobalObjectKey IdInvoiceName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3dtP7+K_kEC5LO+67SXYgQ");
internal static readonly GlobalObjectKey IdFolioNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Dwj08A8Jdka0Mzni5j9A3Q");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*F_1oWjzsGECNkp6pV5XeaA");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4_xe58R6QUanRwdGIuYlsA");
internal static readonly GlobalObjectKey IdAssignedTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5beNMp1WuUS5zbr2dfKKeg");
internal static readonly GlobalObjectKey IdAssetServiceDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5k9OHoaW1EiSeUUxSDTtlg");
internal static readonly GlobalObjectKey IdIssueDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ProQ25hCGkeS_ILtFXuf1w");
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JT3Cq9QH1kialBtu+3suuw");
internal static readonly GlobalObjectKey IdBusinessValueCategory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OyVFcy8M0kigggCi7LrSEQ");
internal static readonly GlobalObjectKey IdBusinessValueSubCategory = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZqHCxLypfEGqkvsyYHiSzA");
internal static readonly GlobalObjectKey IdPaidOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*myfDkYx1n02lkGrXxaBl3Q");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LsahfC4toEmyte+GSDzmNQ");
internal static readonly GlobalObjectKey IdInvoiceDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CnIX0Hr3Z0ewVRYghWmKZA");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*u2O8P0c8t0uZg1+0hQgvEw");
internal static readonly GlobalObjectKey IdInvoiceCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*M1Y+U2o6jEWvAqsiCElyhw");
internal static readonly GlobalObjectKey IdSpecialApproval = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_J0vT7rFGk+UOUaNxwUIew");
internal static readonly GlobalObjectKey IdTags = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*C+5_KlrRV0+YJ1Rk03i5sg");
internal static readonly GlobalObjectKey IdTypeCFDI = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*m4lmsq_lz0WqAsnPLfVwXQ");
internal static readonly GlobalObjectKey IdAvailableTasks = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hJ8IqrgVP0KQkYjkFUP4ww");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JcfR_pKOOk6nZH6mr24+vA");

public string ssSupplierName;

public string ssSupplierNumber;

public string ssInvoiceName;

public string ssFolioNumber;

public string ssInvoiceStatus;

public string ssOrderNumber;

public string ssAssignedTo;

public string ssAssetServiceDescription;

public string ssIssueDate;

public string ssFrequency;

public string ssBusinessValueCategory;

public string ssBusinessValueSubCategory;

public string ssPaidOn;

public decimal ssTotalAmount;

public string ssInvoiceDate;

public string ssCurrency;

public string ssInvoiceCreatedOn;

public string ssSpecialApproval;

public string ssTags;

public string ssTypeCFDI;

public string ssAvailableTasks;

public bool ssIsSelected;


public BitArray OptimizedAttributes;

public ST_fc6debbee6469de53c667334dded1d22Structure() {
OptimizedAttributes = null;
ssSupplierName = "";
ssSupplierNumber = "";
ssInvoiceName = "";
ssFolioNumber = "";
ssInvoiceStatus = "";
ssOrderNumber = "";
ssAssignedTo = "";
ssAssetServiceDescription = "";
ssIssueDate = "";
ssFrequency = "";
ssBusinessValueCategory = "";
ssBusinessValueSubCategory = "";
ssPaidOn = "";
ssTotalAmount = 0.0M;
ssInvoiceDate = "";
ssCurrency = "";
ssInvoiceCreatedOn = "";
ssSpecialApproval = "";
ssTags = "";
ssTypeCFDI = "";
ssAvailableTasks = "";
ssIsSelected = false;
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
ssSupplierName = r.ReadText(index++, "ReportSAPStatus_Item.SupplierName", "");
ssSupplierNumber = r.ReadText(index++, "ReportSAPStatus_Item.SupplierNumber", "");
ssInvoiceName = r.ReadText(index++, "ReportSAPStatus_Item.InvoiceName", "");
ssFolioNumber = r.ReadText(index++, "ReportSAPStatus_Item.FolioNumber", "");
ssInvoiceStatus = r.ReadText(index++, "ReportSAPStatus_Item.InvoiceStatus", "");
ssOrderNumber = r.ReadText(index++, "ReportSAPStatus_Item.OrderNumber", "");
ssAssignedTo = r.ReadText(index++, "ReportSAPStatus_Item.AssignedTo", "");
ssAssetServiceDescription = r.ReadText(index++, "ReportSAPStatus_Item.AssetServiceDescription", "");
ssIssueDate = r.ReadText(index++, "ReportSAPStatus_Item.IssueDate", "");
ssFrequency = r.ReadText(index++, "ReportSAPStatus_Item.Frequency", "");
ssBusinessValueCategory = r.ReadText(index++, "ReportSAPStatus_Item.BusinessValueCategory", "");
ssBusinessValueSubCategory = r.ReadText(index++, "ReportSAPStatus_Item.BusinessValueSubCategory", "");
ssPaidOn = r.ReadText(index++, "ReportSAPStatus_Item.PaidOn", "");
ssTotalAmount = r.ReadDecimal(index++, "ReportSAPStatus_Item.TotalAmount", 0.0M);
ssInvoiceDate = r.ReadText(index++, "ReportSAPStatus_Item.InvoiceDate", "");
ssCurrency = r.ReadText(index++, "ReportSAPStatus_Item.Currency", "");
ssInvoiceCreatedOn = r.ReadText(index++, "ReportSAPStatus_Item.InvoiceCreatedOn", "");
ssSpecialApproval = r.ReadText(index++, "ReportSAPStatus_Item.SpecialApproval", "");
ssTags = r.ReadText(index++, "ReportSAPStatus_Item.Tags", "");
ssTypeCFDI = r.ReadText(index++, "ReportSAPStatus_Item.TypeCFDI", "");
ssAvailableTasks = r.ReadText(index++, "ReportSAPStatus_Item.AvailableTasks", "");
ssIsSelected = r.ReadBoolean(index++, "ReportSAPStatus_Item.IsSelected", false);
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
public void ReadIM(ST_fc6debbee6469de53c667334dded1d22Structure r) {
this = r;
}


public static bool operator == (ST_fc6debbee6469de53c667334dded1d22Structure a, ST_fc6debbee6469de53c667334dded1d22Structure b) {
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssInvoiceName != b.ssInvoiceName) return false;
if (a.ssFolioNumber != b.ssFolioNumber) return false;
if (a.ssInvoiceStatus != b.ssInvoiceStatus) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssAssignedTo != b.ssAssignedTo) return false;
if (a.ssAssetServiceDescription != b.ssAssetServiceDescription) return false;
if (a.ssIssueDate != b.ssIssueDate) return false;
if (a.ssFrequency != b.ssFrequency) return false;
if (a.ssBusinessValueCategory != b.ssBusinessValueCategory) return false;
if (a.ssBusinessValueSubCategory != b.ssBusinessValueSubCategory) return false;
if (a.ssPaidOn != b.ssPaidOn) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssInvoiceDate != b.ssInvoiceDate) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssInvoiceCreatedOn != b.ssInvoiceCreatedOn) return false;
if (a.ssSpecialApproval != b.ssSpecialApproval) return false;
if (a.ssTags != b.ssTags) return false;
if (a.ssTypeCFDI != b.ssTypeCFDI) return false;
if (a.ssAvailableTasks != b.ssAvailableTasks) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
return true;
}

public static bool operator != (ST_fc6debbee6469de53c667334dded1d22Structure a, ST_fc6debbee6469de53c667334dded1d22Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_fc6debbee6469de53c667334dded1d22Structure)) return false;
return (this == (ST_fc6debbee6469de53c667334dded1d22Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssInvoiceName.GetHashCode()
 ^ ssFolioNumber.GetHashCode()
 ^ ssInvoiceStatus.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssAssignedTo.GetHashCode()
 ^ ssAssetServiceDescription.GetHashCode()
 ^ ssIssueDate.GetHashCode()
 ^ ssFrequency.GetHashCode()
 ^ ssBusinessValueCategory.GetHashCode()
 ^ ssBusinessValueSubCategory.GetHashCode()
 ^ ssPaidOn.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssInvoiceDate.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssInvoiceCreatedOn.GetHashCode()
 ^ ssSpecialApproval.GetHashCode()
 ^ ssTags.GetHashCode()
 ^ ssTypeCFDI.GetHashCode()
 ^ ssAvailableTasks.GetHashCode()
 ^ ssIsSelected.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_fc6debbee6469de53c667334dded1d22Structure Duplicate() {
ST_fc6debbee6469de53c667334dded1d22Structure t;
t.ssSupplierName = this.ssSupplierName;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssInvoiceName = this.ssInvoiceName;
t.ssFolioNumber = this.ssFolioNumber;
t.ssInvoiceStatus = this.ssInvoiceStatus;
t.ssOrderNumber = this.ssOrderNumber;
t.ssAssignedTo = this.ssAssignedTo;
t.ssAssetServiceDescription = this.ssAssetServiceDescription;
t.ssIssueDate = this.ssIssueDate;
t.ssFrequency = this.ssFrequency;
t.ssBusinessValueCategory = this.ssBusinessValueCategory;
t.ssBusinessValueSubCategory = this.ssBusinessValueSubCategory;
t.ssPaidOn = this.ssPaidOn;
t.ssTotalAmount = this.ssTotalAmount;
t.ssInvoiceDate = this.ssInvoiceDate;
t.ssCurrency = this.ssCurrency;
t.ssInvoiceCreatedOn = this.ssInvoiceCreatedOn;
t.ssSpecialApproval = this.ssSpecialApproval;
t.ssTags = this.ssTags;
t.ssTypeCFDI = this.ssTypeCFDI;
t.ssAvailableTasks = this.ssAvailableTasks;
t.ssIsSelected = this.ssIsSelected;
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
if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "invoicename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceName")) variable.Value = ssInvoiceName; else variable.Optimized = true;
} else if (head == "folionumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioNumber")) variable.Value = ssFolioNumber; else variable.Optimized = true;
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssInvoiceStatus; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "assignedto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedTo")) variable.Value = ssAssignedTo; else variable.Optimized = true;
} else if (head == "assetservicedescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssetServiceDescription")) variable.Value = ssAssetServiceDescription; else variable.Optimized = true;
} else if (head == "issuedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IssueDate")) variable.Value = ssIssueDate; else variable.Optimized = true;
} else if (head == "frequency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Frequency")) variable.Value = ssFrequency; else variable.Optimized = true;
} else if (head == "businessvaluecategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueCategory")) variable.Value = ssBusinessValueCategory; else variable.Optimized = true;
} else if (head == "businessvaluesubcategory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessValueSubCategory")) variable.Value = ssBusinessValueSubCategory; else variable.Optimized = true;
} else if (head == "paidon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaidOn")) variable.Value = ssPaidOn; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "invoicedate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceDate")) variable.Value = ssInvoiceDate; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "invoicecreatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceCreatedOn")) variable.Value = ssInvoiceCreatedOn; else variable.Optimized = true;
} else if (head == "specialapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialApproval")) variable.Value = ssSpecialApproval; else variable.Optimized = true;
} else if (head == "tags") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Tags")) variable.Value = ssTags; else variable.Optimized = true;
} else if (head == "typecfdi") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TypeCFDI")) variable.Value = ssTypeCFDI; else variable.Optimized = true;
} else if (head == "availabletasks") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AvailableTasks")) variable.Value = ssAvailableTasks; else variable.Optimized = true;
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
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
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdInvoiceName) {
return ssInvoiceName;
}
if (key == IdFolioNumber) {
return ssFolioNumber;
}
if (key == IdInvoiceStatus) {
return ssInvoiceStatus;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdAssignedTo) {
return ssAssignedTo;
}
if (key == IdAssetServiceDescription) {
return ssAssetServiceDescription;
}
if (key == IdIssueDate) {
return ssIssueDate;
}
if (key == IdFrequency) {
return ssFrequency;
}
if (key == IdBusinessValueCategory) {
return ssBusinessValueCategory;
}
if (key == IdBusinessValueSubCategory) {
return ssBusinessValueSubCategory;
}
if (key == IdPaidOn) {
return ssPaidOn;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdInvoiceDate) {
return ssInvoiceDate;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdInvoiceCreatedOn) {
return ssInvoiceCreatedOn;
}
if (key == IdSpecialApproval) {
return ssSpecialApproval;
}
if (key == IdTags) {
return ssTags;
}
if (key == IdTypeCFDI) {
return ssTypeCFDI;
}
if (key == IdAvailableTasks) {
return ssAvailableTasks;
}
if (key == IdIsSelected) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdInvoiceName.Key.AsGuid) {
return ssInvoiceName;
}
if (attributeKey == IdFolioNumber.Key.AsGuid) {
return ssFolioNumber;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssInvoiceStatus;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdAssignedTo.Key.AsGuid) {
return ssAssignedTo;
}
if (attributeKey == IdAssetServiceDescription.Key.AsGuid) {
return ssAssetServiceDescription;
}
if (attributeKey == IdIssueDate.Key.AsGuid) {
return ssIssueDate;
}
if (attributeKey == IdFrequency.Key.AsGuid) {
return ssFrequency;
}
if (attributeKey == IdBusinessValueCategory.Key.AsGuid) {
return ssBusinessValueCategory;
}
if (attributeKey == IdBusinessValueSubCategory.Key.AsGuid) {
return ssBusinessValueSubCategory;
}
if (attributeKey == IdPaidOn.Key.AsGuid) {
return ssPaidOn;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdInvoiceDate.Key.AsGuid) {
return ssInvoiceDate;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdInvoiceCreatedOn.Key.AsGuid) {
return ssInvoiceCreatedOn;
}
if (attributeKey == IdSpecialApproval.Key.AsGuid) {
return ssSpecialApproval;
}
if (attributeKey == IdTags.Key.AsGuid) {
return ssTags;
}
if (attributeKey == IdTypeCFDI.Key.AsGuid) {
return ssTypeCFDI;
}
if (attributeKey == IdAvailableTasks.Key.AsGuid) {
return ssAvailableTasks;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssInvoiceName = (string) other.AttributeGet(IdInvoiceName);
ssFolioNumber = (string) other.AttributeGet(IdFolioNumber);
ssInvoiceStatus = (string) other.AttributeGet(IdInvoiceStatus);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssAssignedTo = (string) other.AttributeGet(IdAssignedTo);
ssAssetServiceDescription = (string) other.AttributeGet(IdAssetServiceDescription);
ssIssueDate = (string) other.AttributeGet(IdIssueDate);
ssFrequency = (string) other.AttributeGet(IdFrequency);
ssBusinessValueCategory = (string) other.AttributeGet(IdBusinessValueCategory);
ssBusinessValueSubCategory = (string) other.AttributeGet(IdBusinessValueSubCategory);
ssPaidOn = (string) other.AttributeGet(IdPaidOn);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ssInvoiceDate = (string) other.AttributeGet(IdInvoiceDate);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssInvoiceCreatedOn = (string) other.AttributeGet(IdInvoiceCreatedOn);
ssSpecialApproval = (string) other.AttributeGet(IdSpecialApproval);
ssTags = (string) other.AttributeGet(IdTags);
ssTypeCFDI = (string) other.AttributeGet(IdTypeCFDI);
ssAvailableTasks = (string) other.AttributeGet(IdAvailableTasks);
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
}
} // ST_fc6debbee6469de53c667334dded1d22Structure
/// <summary>
/// RecordList type <code>ReportSAPStatus_ItemList</code> that represents a record list of
///  <code>ReportSAPStatus_Item</code>
/// </summary>
public partial class RL_c94b937e248ffb05391a1f227e9d9277 : GenericRecordList<ST_fc6debbee6469de53c667334dded1d22Structure>, IEnumerable, IEnumerator {

protected override ST_fc6debbee6469de53c667334dded1d22Structure GetElementDefaultValue() {
return new ST_fc6debbee6469de53c667334dded1d22Structure();
}

public T[] ToArray<T>(Func<ST_fc6debbee6469de53c667334dded1d22Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c94b937e248ffb05391a1f227e9d9277 recordList, Func<ST_fc6debbee6469de53c667334dded1d22Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c94b937e248ffb05391a1f227e9d9277(ST_fc6debbee6469de53c667334dded1d22Structure[] array) {
  RL_c94b937e248ffb05391a1f227e9d9277 result = new RL_c94b937e248ffb05391a1f227e9d9277();
result.InnerFromArray(array);
    return result;
}

public static RL_c94b937e248ffb05391a1f227e9d9277 ToList<T>(T[] array, Func <T, ST_fc6debbee6469de53c667334dded1d22Structure> converter) {
  RL_c94b937e248ffb05391a1f227e9d9277 result = new RL_c94b937e248ffb05391a1f227e9d9277();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c94b937e248ffb05391a1f227e9d9277 FromRestList<T>(RestList<T> restList, Func <T, ST_fc6debbee6469de53c667334dded1d22Structure> converter) {
  RL_c94b937e248ffb05391a1f227e9d9277 result = new RL_c94b937e248ffb05391a1f227e9d9277();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c94b937e248ffb05391a1f227e9d9277() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_fc6debbee6469de53c667334dded1d22Structure> NewList() {
return new RL_c94b937e248ffb05391a1f227e9d9277();
}


} // RL_c94b937e248ffb05391a1f227e9d9277
}

