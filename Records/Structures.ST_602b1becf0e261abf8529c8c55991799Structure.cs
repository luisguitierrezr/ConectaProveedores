namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrderItemLine (gI4qSCQ1_E6a1Q+uS0gcvQ)
///  <code>ST_602b1becf0e261abf8529c8c55991799Structure</code> that represent
/// s <code>OrderItemLine</code> <p>Description: OrderItem Line Structure</p>
/// </summary>
// Name: OrderItemLine
public partial struct ST_602b1becf0e261abf8529c8c55991799Structure : ITypedRecord<ST_602b1becf0e261abf8529c8c55991799Structure> {
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Giia4uNDnEOWvK9dL9TJhA");
internal static readonly GlobalObjectKey IdArticleNr = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BU1Tl53FNk+nyCBCOwAPSw");
internal static readonly GlobalObjectKey IdArticleDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8t7_NF0kgU2jhM28lzCDLQ");
internal static readonly GlobalObjectKey IdImputationCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qxcw26XPEE+3wV6fvC96vw");
internal static readonly GlobalObjectKey IdDocumentClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vPVCrOQxGkeINnDveulmXA");
internal static readonly GlobalObjectKey IdDeliveryDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*llqRRPw7p0SlpRE+y0ezmg");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uair81yoBkaJkLG9kAUkog");
internal static readonly GlobalObjectKey IdUnitType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eKh0bkV+QECfA4w2Pu5EmA");
internal static readonly GlobalObjectKey IdUnitPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DIhf3+IfyEalkqihS6of2w");
internal static readonly GlobalObjectKey IdBaseQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*df_nabaypk2KW1gohv1g3Q");
internal static readonly GlobalObjectKey IdChangeIndicator = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8CUrxOOKeEai2AzPi0grdw");
internal static readonly GlobalObjectKey IdFinalDelivery = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KNHyx7lYgEijEWJh3YCHvw");
internal static readonly GlobalObjectKey IdGLAccountNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fr0Vfdl5CkSGN5kAEGtUow");
internal static readonly GlobalObjectKey IdCostCenter = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*e0m3Er7PCkmJMevVBhdbqg");
internal static readonly GlobalObjectKey IdFundsCenter = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wyApCiTBVUOKF9hseifVuA");
internal static readonly GlobalObjectKey IdFund = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1ogyicAlIk2aIDtr_kmEiw");
internal static readonly GlobalObjectKey IdCommitmentItem = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ttm3Mq0I6EqJDAjENe8yKA");
internal static readonly GlobalObjectKey IdVATIndicator = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bc2BU54Nt02+1jm6lW+TlA");
internal static readonly GlobalObjectKey IdVATProcedure = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*b+wiEvt8cEaWOw7qQzIsKA");
internal static readonly GlobalObjectKey IdVATRate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BIfix_5cjkS2yDhnSCT3lA");
internal static readonly GlobalObjectKey IdPurchaseRequisitionNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8bFYHQVzpkS0Fpn0X710JQ");
internal static readonly GlobalObjectKey IdPurchaseRequisitionItemNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wNT47RQ6mkCAXLC+UUzWyg");
internal static readonly GlobalObjectKey IdBusinessArea = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*b+jyWBA9C0epCZbG8uKKBg");
internal static readonly GlobalObjectKey IdCenter = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2z4BbJPhOkCnLuhpmPkOMw");
internal static readonly GlobalObjectKey IdPEPElement = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ErNQPreKZ0yIeF_faoNcpg");
internal static readonly GlobalObjectKey IdDeliveredQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_XDxDLfGckiZyUftOu_Q8A");
internal static readonly GlobalObjectKey IdUMP = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kSNc0g6byEGz0y+FwxKmMQ");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UZR9Eh2aoUi22QequYZZlQ");
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pK5wQ+phXEm_0tnfcl1fwQ");
internal static readonly GlobalObjectKey IdContractNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9oh3ESMq+EmfkWTlcykkVQ");
internal static readonly GlobalObjectKey IdContractPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eG90mpSnFkS+o9BXJMsRlA");
internal static readonly GlobalObjectKey IdContractStartDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MbfMdgZ8p0aaeM4O7hNHGw");
internal static readonly GlobalObjectKey IdContractEndDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Wk8h1osOiUCCGosrDmF3Ow");
internal static readonly GlobalObjectKey IdContractPlannedValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aF_kagSvCEykKYxETvKEEw");
internal static readonly GlobalObjectKey IdPositionType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OMerC7Nl+0u6mkSBuzYsLw");
internal static readonly GlobalObjectKey IdSerialNumberProfile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*A9skuQc2Ckup9ZADXTO2oQ");
internal static readonly GlobalObjectKey IdBatchManaged = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*46SoRPzQbE61jTk3nCP7xg");
internal static readonly GlobalObjectKey IdMaterialType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aTwb+WOpbUqLK6E1yOAG4A");
internal static readonly GlobalObjectKey IdItemGroup = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OKgYcPtm6EWO7JsUYXTrSQ");
internal static readonly GlobalObjectKey IdCreatingUser = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TjOZUtlGBEeUT+0cdXp2mA");

public int ssPosition;

public string ssArticleNr;

public string ssArticleDescription;

public string ssImputationCode;

public string ssDocumentClass;

public string ssDeliveryDate;

public decimal ssQuantity;

public string ssUnitType;

public decimal ssUnitPrice;

public int ssBaseQuantity;

public string ssChangeIndicator;

public string ssFinalDelivery;

public string ssGLAccountNumber;

public string ssCostCenter;

public string ssFundsCenter;

public string ssFund;

public string ssCommitmentItem;

public string ssVATIndicator;

public string ssVATProcedure;

public decimal ssVATRate;

public string ssPurchaseRequisitionNumber;

public int ssPurchaseRequisitionItemNumber;

public string ssBusinessArea;

public string ssCenter;

public string ssPEPElement;

public decimal ssDeliveredQuantity;

public string ssUMP;

public string ssApplicant;

public string ssDirection;

public string ssContractNumber;

public int ssContractPosition;

public string ssContractStartDate;

public string ssContractEndDate;

public decimal ssContractPlannedValue;

public string ssPositionType;

public string ssSerialNumberProfile;

public string ssBatchManaged;

public string ssMaterialType;

public string ssItemGroup;

public string ssCreatingUser;


public BitArray OptimizedAttributes;

public ST_602b1becf0e261abf8529c8c55991799Structure() {
OptimizedAttributes = null;
ssPosition = 0;
ssArticleNr = "";
ssArticleDescription = "";
ssImputationCode = "";
ssDocumentClass = "";
ssDeliveryDate = "";
ssQuantity = 0.0M;
ssUnitType = "";
ssUnitPrice = 0.0M;
ssBaseQuantity = 0;
ssChangeIndicator = "False";
ssFinalDelivery = "False";
ssGLAccountNumber = "";
ssCostCenter = "";
ssFundsCenter = "";
ssFund = "";
ssCommitmentItem = "";
ssVATIndicator = "";
ssVATProcedure = "";
ssVATRate = 0.0M;
ssPurchaseRequisitionNumber = "";
ssPurchaseRequisitionItemNumber = 0;
ssBusinessArea = "";
ssCenter = "";
ssPEPElement = "";
ssDeliveredQuantity = 0.0M;
ssUMP = "";
ssApplicant = "";
ssDirection = "";
ssContractNumber = "";
ssContractPosition = 0;
ssContractStartDate = "";
ssContractEndDate = "";
ssContractPlannedValue = 0.0M;
ssPositionType = "";
ssSerialNumberProfile = "";
ssBatchManaged = "";
ssMaterialType = "";
ssItemGroup = "";
ssCreatingUser = "";
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
ssPosition = r.ReadInteger(index++, "OrderItemLine.Position", 0);
ssArticleNr = r.ReadText(index++, "OrderItemLine.ArticleNr", "");
ssArticleDescription = r.ReadText(index++, "OrderItemLine.ArticleDescription", "");
ssImputationCode = r.ReadText(index++, "OrderItemLine.ImputationCode", "");
ssDocumentClass = r.ReadText(index++, "OrderItemLine.DocumentClass", "");
ssDeliveryDate = r.ReadText(index++, "OrderItemLine.DeliveryDate", "");
ssQuantity = r.ReadDecimal(index++, "OrderItemLine.Quantity", 0.0M);
ssUnitType = r.ReadText(index++, "OrderItemLine.UnitType", "");
ssUnitPrice = r.ReadDecimal(index++, "OrderItemLine.UnitPrice", 0.0M);
ssBaseQuantity = r.ReadInteger(index++, "OrderItemLine.BaseQuantity", 0);
ssChangeIndicator = r.ReadText(index++, "OrderItemLine.ChangeIndicator", "");
ssFinalDelivery = r.ReadText(index++, "OrderItemLine.FinalDelivery", "");
ssGLAccountNumber = r.ReadText(index++, "OrderItemLine.GLAccountNumber", "");
ssCostCenter = r.ReadText(index++, "OrderItemLine.CostCenter", "");
ssFundsCenter = r.ReadText(index++, "OrderItemLine.FundsCenter", "");
ssFund = r.ReadText(index++, "OrderItemLine.Fund", "");
ssCommitmentItem = r.ReadText(index++, "OrderItemLine.CommitmentItem", "");
ssVATIndicator = r.ReadText(index++, "OrderItemLine.VATIndicator", "");
ssVATProcedure = r.ReadText(index++, "OrderItemLine.VATProcedure", "");
ssVATRate = r.ReadDecimal(index++, "OrderItemLine.VATRate", 0.0M);
ssPurchaseRequisitionNumber = r.ReadText(index++, "OrderItemLine.PurchaseRequisitionNumber", "");
ssPurchaseRequisitionItemNumber = r.ReadInteger(index++, "OrderItemLine.PurchaseRequisitionItemNumber", 0);
ssBusinessArea = r.ReadText(index++, "OrderItemLine.BusinessArea", "");
ssCenter = r.ReadText(index++, "OrderItemLine.Center", "");
ssPEPElement = r.ReadText(index++, "OrderItemLine.PEPElement", "");
ssDeliveredQuantity = r.ReadDecimal(index++, "OrderItemLine.DeliveredQuantity", 0.0M);
ssUMP = r.ReadText(index++, "OrderItemLine.UMP", "");
ssApplicant = r.ReadText(index++, "OrderItemLine.Applicant", "");
ssDirection = r.ReadText(index++, "OrderItemLine.Direction", "");
ssContractNumber = r.ReadText(index++, "OrderItemLine.ContractNumber", "");
ssContractPosition = r.ReadInteger(index++, "OrderItemLine.ContractPosition", 0);
ssContractStartDate = r.ReadText(index++, "OrderItemLine.ContractStartDate", "");
ssContractEndDate = r.ReadText(index++, "OrderItemLine.ContractEndDate", "");
ssContractPlannedValue = r.ReadDecimal(index++, "OrderItemLine.ContractPlannedValue", 0.0M);
ssPositionType = r.ReadText(index++, "OrderItemLine.PositionType", "");
ssSerialNumberProfile = r.ReadText(index++, "OrderItemLine.SerialNumberProfile", "");
ssBatchManaged = r.ReadText(index++, "OrderItemLine.BatchManaged", "");
ssMaterialType = r.ReadText(index++, "OrderItemLine.MaterialType", "");
ssItemGroup = r.ReadText(index++, "OrderItemLine.ItemGroup", "");
ssCreatingUser = r.ReadText(index++, "OrderItemLine.CreatingUser", "");
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
public void ReadIM(ST_602b1becf0e261abf8529c8c55991799Structure r) {
this = r;
}


public static bool operator == (ST_602b1becf0e261abf8529c8c55991799Structure a, ST_602b1becf0e261abf8529c8c55991799Structure b) {
if (a.ssPosition != b.ssPosition) return false;
if (a.ssArticleNr != b.ssArticleNr) return false;
if (a.ssArticleDescription != b.ssArticleDescription) return false;
if (a.ssImputationCode != b.ssImputationCode) return false;
if (a.ssDocumentClass != b.ssDocumentClass) return false;
if (a.ssDeliveryDate != b.ssDeliveryDate) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssUnitType != b.ssUnitType) return false;
if (a.ssUnitPrice != b.ssUnitPrice) return false;
if (a.ssBaseQuantity != b.ssBaseQuantity) return false;
if (a.ssChangeIndicator != b.ssChangeIndicator) return false;
if (a.ssFinalDelivery != b.ssFinalDelivery) return false;
if (a.ssGLAccountNumber != b.ssGLAccountNumber) return false;
if (a.ssCostCenter != b.ssCostCenter) return false;
if (a.ssFundsCenter != b.ssFundsCenter) return false;
if (a.ssFund != b.ssFund) return false;
if (a.ssCommitmentItem != b.ssCommitmentItem) return false;
if (a.ssVATIndicator != b.ssVATIndicator) return false;
if (a.ssVATProcedure != b.ssVATProcedure) return false;
if (a.ssVATRate != b.ssVATRate) return false;
if (a.ssPurchaseRequisitionNumber != b.ssPurchaseRequisitionNumber) return false;
if (a.ssPurchaseRequisitionItemNumber != b.ssPurchaseRequisitionItemNumber) return false;
if (a.ssBusinessArea != b.ssBusinessArea) return false;
if (a.ssCenter != b.ssCenter) return false;
if (a.ssPEPElement != b.ssPEPElement) return false;
if (a.ssDeliveredQuantity != b.ssDeliveredQuantity) return false;
if (a.ssUMP != b.ssUMP) return false;
if (a.ssApplicant != b.ssApplicant) return false;
if (a.ssDirection != b.ssDirection) return false;
if (a.ssContractNumber != b.ssContractNumber) return false;
if (a.ssContractPosition != b.ssContractPosition) return false;
if (a.ssContractStartDate != b.ssContractStartDate) return false;
if (a.ssContractEndDate != b.ssContractEndDate) return false;
if (a.ssContractPlannedValue != b.ssContractPlannedValue) return false;
if (a.ssPositionType != b.ssPositionType) return false;
if (a.ssSerialNumberProfile != b.ssSerialNumberProfile) return false;
if (a.ssBatchManaged != b.ssBatchManaged) return false;
if (a.ssMaterialType != b.ssMaterialType) return false;
if (a.ssItemGroup != b.ssItemGroup) return false;
if (a.ssCreatingUser != b.ssCreatingUser) return false;
return true;
}

public static bool operator != (ST_602b1becf0e261abf8529c8c55991799Structure a, ST_602b1becf0e261abf8529c8c55991799Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_602b1becf0e261abf8529c8c55991799Structure)) return false;
return (this == (ST_602b1becf0e261abf8529c8c55991799Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPosition.GetHashCode()
 ^ ssArticleNr.GetHashCode()
 ^ ssArticleDescription.GetHashCode()
 ^ ssImputationCode.GetHashCode()
 ^ ssDocumentClass.GetHashCode()
 ^ ssDeliveryDate.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssUnitType.GetHashCode()
 ^ ssUnitPrice.GetHashCode()
 ^ ssBaseQuantity.GetHashCode()
 ^ ssChangeIndicator.GetHashCode()
 ^ ssFinalDelivery.GetHashCode()
 ^ ssGLAccountNumber.GetHashCode()
 ^ ssCostCenter.GetHashCode()
 ^ ssFundsCenter.GetHashCode()
 ^ ssFund.GetHashCode()
 ^ ssCommitmentItem.GetHashCode()
 ^ ssVATIndicator.GetHashCode()
 ^ ssVATProcedure.GetHashCode()
 ^ ssVATRate.GetHashCode()
 ^ ssPurchaseRequisitionNumber.GetHashCode()
 ^ ssPurchaseRequisitionItemNumber.GetHashCode()
 ^ ssBusinessArea.GetHashCode()
 ^ ssCenter.GetHashCode()
 ^ ssPEPElement.GetHashCode()
 ^ ssDeliveredQuantity.GetHashCode()
 ^ ssUMP.GetHashCode()
 ^ ssApplicant.GetHashCode()
 ^ ssDirection.GetHashCode()
 ^ ssContractNumber.GetHashCode()
 ^ ssContractPosition.GetHashCode()
 ^ ssContractStartDate.GetHashCode()
 ^ ssContractEndDate.GetHashCode()
 ^ ssContractPlannedValue.GetHashCode()
 ^ ssPositionType.GetHashCode()
 ^ ssSerialNumberProfile.GetHashCode()
 ^ ssBatchManaged.GetHashCode()
 ^ ssMaterialType.GetHashCode()
 ^ ssItemGroup.GetHashCode()
 ^ ssCreatingUser.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_602b1becf0e261abf8529c8c55991799Structure Duplicate() {
ST_602b1becf0e261abf8529c8c55991799Structure t;
t.ssPosition = this.ssPosition;
t.ssArticleNr = this.ssArticleNr;
t.ssArticleDescription = this.ssArticleDescription;
t.ssImputationCode = this.ssImputationCode;
t.ssDocumentClass = this.ssDocumentClass;
t.ssDeliveryDate = this.ssDeliveryDate;
t.ssQuantity = this.ssQuantity;
t.ssUnitType = this.ssUnitType;
t.ssUnitPrice = this.ssUnitPrice;
t.ssBaseQuantity = this.ssBaseQuantity;
t.ssChangeIndicator = this.ssChangeIndicator;
t.ssFinalDelivery = this.ssFinalDelivery;
t.ssGLAccountNumber = this.ssGLAccountNumber;
t.ssCostCenter = this.ssCostCenter;
t.ssFundsCenter = this.ssFundsCenter;
t.ssFund = this.ssFund;
t.ssCommitmentItem = this.ssCommitmentItem;
t.ssVATIndicator = this.ssVATIndicator;
t.ssVATProcedure = this.ssVATProcedure;
t.ssVATRate = this.ssVATRate;
t.ssPurchaseRequisitionNumber = this.ssPurchaseRequisitionNumber;
t.ssPurchaseRequisitionItemNumber = this.ssPurchaseRequisitionItemNumber;
t.ssBusinessArea = this.ssBusinessArea;
t.ssCenter = this.ssCenter;
t.ssPEPElement = this.ssPEPElement;
t.ssDeliveredQuantity = this.ssDeliveredQuantity;
t.ssUMP = this.ssUMP;
t.ssApplicant = this.ssApplicant;
t.ssDirection = this.ssDirection;
t.ssContractNumber = this.ssContractNumber;
t.ssContractPosition = this.ssContractPosition;
t.ssContractStartDate = this.ssContractStartDate;
t.ssContractEndDate = this.ssContractEndDate;
t.ssContractPlannedValue = this.ssContractPlannedValue;
t.ssPositionType = this.ssPositionType;
t.ssSerialNumberProfile = this.ssSerialNumberProfile;
t.ssBatchManaged = this.ssBatchManaged;
t.ssMaterialType = this.ssMaterialType;
t.ssItemGroup = this.ssItemGroup;
t.ssCreatingUser = this.ssCreatingUser;
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
if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
} else if (head == "articlenr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ArticleNr")) variable.Value = ssArticleNr; else variable.Optimized = true;
} else if (head == "articledescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ArticleDescription")) variable.Value = ssArticleDescription; else variable.Optimized = true;
} else if (head == "imputationcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImputationCode")) variable.Value = ssImputationCode; else variable.Optimized = true;
} else if (head == "documentclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentClass")) variable.Value = ssDocumentClass; else variable.Optimized = true;
} else if (head == "deliverydate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveryDate")) variable.Value = ssDeliveryDate; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Quantity")) variable.Value = ssQuantity; else variable.Optimized = true;
} else if (head == "unittype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitType")) variable.Value = ssUnitType; else variable.Optimized = true;
} else if (head == "unitprice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitPrice")) variable.Value = ssUnitPrice; else variable.Optimized = true;
} else if (head == "basequantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BaseQuantity")) variable.Value = ssBaseQuantity; else variable.Optimized = true;
} else if (head == "changeindicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ChangeIndicator")) variable.Value = ssChangeIndicator; else variable.Optimized = true;
} else if (head == "finaldelivery") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FinalDelivery")) variable.Value = ssFinalDelivery; else variable.Optimized = true;
} else if (head == "glaccountnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GLAccountNumber")) variable.Value = ssGLAccountNumber; else variable.Optimized = true;
} else if (head == "costcenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenter")) variable.Value = ssCostCenter; else variable.Optimized = true;
} else if (head == "fundscenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FundsCenter")) variable.Value = ssFundsCenter; else variable.Optimized = true;
} else if (head == "fund") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fund")) variable.Value = ssFund; else variable.Optimized = true;
} else if (head == "commitmentitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommitmentItem")) variable.Value = ssCommitmentItem; else variable.Optimized = true;
} else if (head == "vatindicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VATIndicator")) variable.Value = ssVATIndicator; else variable.Optimized = true;
} else if (head == "vatprocedure") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VATProcedure")) variable.Value = ssVATProcedure; else variable.Optimized = true;
} else if (head == "vatrate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VATRate")) variable.Value = ssVATRate; else variable.Optimized = true;
} else if (head == "purchaserequisitionnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PurchaseRequisitionNumber")) variable.Value = ssPurchaseRequisitionNumber; else variable.Optimized = true;
} else if (head == "purchaserequisitionitemnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PurchaseRequisitionItemNumber")) variable.Value = ssPurchaseRequisitionItemNumber; else variable.Optimized = true;
} else if (head == "businessarea") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BusinessArea")) variable.Value = ssBusinessArea; else variable.Optimized = true;
} else if (head == "center") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Center")) variable.Value = ssCenter; else variable.Optimized = true;
} else if (head == "pepelement") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PEPElement")) variable.Value = ssPEPElement; else variable.Optimized = true;
} else if (head == "deliveredquantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveredQuantity")) variable.Value = ssDeliveredQuantity; else variable.Optimized = true;
} else if (head == "ump") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UMP")) variable.Value = ssUMP; else variable.Optimized = true;
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssApplicant; else variable.Optimized = true;
} else if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "contractnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractNumber")) variable.Value = ssContractNumber; else variable.Optimized = true;
} else if (head == "contractposition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractPosition")) variable.Value = ssContractPosition; else variable.Optimized = true;
} else if (head == "contractstartdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractStartDate")) variable.Value = ssContractStartDate; else variable.Optimized = true;
} else if (head == "contractenddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractEndDate")) variable.Value = ssContractEndDate; else variable.Optimized = true;
} else if (head == "contractplannedvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContractPlannedValue")) variable.Value = ssContractPlannedValue; else variable.Optimized = true;
} else if (head == "positiontype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PositionType")) variable.Value = ssPositionType; else variable.Optimized = true;
} else if (head == "serialnumberprofile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SerialNumberProfile")) variable.Value = ssSerialNumberProfile; else variable.Optimized = true;
} else if (head == "batchmanaged") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BatchManaged")) variable.Value = ssBatchManaged; else variable.Optimized = true;
} else if (head == "materialtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaterialType")) variable.Value = ssMaterialType; else variable.Optimized = true;
} else if (head == "itemgroup") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemGroup")) variable.Value = ssItemGroup; else variable.Optimized = true;
} else if (head == "creatinguser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatingUser")) variable.Value = ssCreatingUser; else variable.Optimized = true;
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
if (key == IdPosition) {
return ssPosition;
}
if (key == IdArticleNr) {
return ssArticleNr;
}
if (key == IdArticleDescription) {
return ssArticleDescription;
}
if (key == IdImputationCode) {
return ssImputationCode;
}
if (key == IdDocumentClass) {
return ssDocumentClass;
}
if (key == IdDeliveryDate) {
return ssDeliveryDate;
}
if (key == IdQuantity) {
return ssQuantity;
}
if (key == IdUnitType) {
return ssUnitType;
}
if (key == IdUnitPrice) {
return ssUnitPrice;
}
if (key == IdBaseQuantity) {
return ssBaseQuantity;
}
if (key == IdChangeIndicator) {
return ssChangeIndicator;
}
if (key == IdFinalDelivery) {
return ssFinalDelivery;
}
if (key == IdGLAccountNumber) {
return ssGLAccountNumber;
}
if (key == IdCostCenter) {
return ssCostCenter;
}
if (key == IdFundsCenter) {
return ssFundsCenter;
}
if (key == IdFund) {
return ssFund;
}
if (key == IdCommitmentItem) {
return ssCommitmentItem;
}
if (key == IdVATIndicator) {
return ssVATIndicator;
}
if (key == IdVATProcedure) {
return ssVATProcedure;
}
if (key == IdVATRate) {
return ssVATRate;
}
if (key == IdPurchaseRequisitionNumber) {
return ssPurchaseRequisitionNumber;
}
if (key == IdPurchaseRequisitionItemNumber) {
return ssPurchaseRequisitionItemNumber;
}
if (key == IdBusinessArea) {
return ssBusinessArea;
}
if (key == IdCenter) {
return ssCenter;
}
if (key == IdPEPElement) {
return ssPEPElement;
}
if (key == IdDeliveredQuantity) {
return ssDeliveredQuantity;
}
if (key == IdUMP) {
return ssUMP;
}
if (key == IdApplicant) {
return ssApplicant;
}
if (key == IdDirection) {
return ssDirection;
}
if (key == IdContractNumber) {
return ssContractNumber;
}
if (key == IdContractPosition) {
return ssContractPosition;
}
if (key == IdContractStartDate) {
return ssContractStartDate;
}
if (key == IdContractEndDate) {
return ssContractEndDate;
}
if (key == IdContractPlannedValue) {
return ssContractPlannedValue;
}
if (key == IdPositionType) {
return ssPositionType;
}
if (key == IdSerialNumberProfile) {
return ssSerialNumberProfile;
}
if (key == IdBatchManaged) {
return ssBatchManaged;
}
if (key == IdMaterialType) {
return ssMaterialType;
}
if (key == IdItemGroup) {
return ssItemGroup;
}
if (key == IdCreatingUser) {
return ssCreatingUser;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
if (attributeKey == IdArticleNr.Key.AsGuid) {
return ssArticleNr;
}
if (attributeKey == IdArticleDescription.Key.AsGuid) {
return ssArticleDescription;
}
if (attributeKey == IdImputationCode.Key.AsGuid) {
return ssImputationCode;
}
if (attributeKey == IdDocumentClass.Key.AsGuid) {
return ssDocumentClass;
}
if (attributeKey == IdDeliveryDate.Key.AsGuid) {
return ssDeliveryDate;
}
if (attributeKey == IdQuantity.Key.AsGuid) {
return ssQuantity;
}
if (attributeKey == IdUnitType.Key.AsGuid) {
return ssUnitType;
}
if (attributeKey == IdUnitPrice.Key.AsGuid) {
return ssUnitPrice;
}
if (attributeKey == IdBaseQuantity.Key.AsGuid) {
return ssBaseQuantity;
}
if (attributeKey == IdChangeIndicator.Key.AsGuid) {
return ssChangeIndicator;
}
if (attributeKey == IdFinalDelivery.Key.AsGuid) {
return ssFinalDelivery;
}
if (attributeKey == IdGLAccountNumber.Key.AsGuid) {
return ssGLAccountNumber;
}
if (attributeKey == IdCostCenter.Key.AsGuid) {
return ssCostCenter;
}
if (attributeKey == IdFundsCenter.Key.AsGuid) {
return ssFundsCenter;
}
if (attributeKey == IdFund.Key.AsGuid) {
return ssFund;
}
if (attributeKey == IdCommitmentItem.Key.AsGuid) {
return ssCommitmentItem;
}
if (attributeKey == IdVATIndicator.Key.AsGuid) {
return ssVATIndicator;
}
if (attributeKey == IdVATProcedure.Key.AsGuid) {
return ssVATProcedure;
}
if (attributeKey == IdVATRate.Key.AsGuid) {
return ssVATRate;
}
if (attributeKey == IdPurchaseRequisitionNumber.Key.AsGuid) {
return ssPurchaseRequisitionNumber;
}
if (attributeKey == IdPurchaseRequisitionItemNumber.Key.AsGuid) {
return ssPurchaseRequisitionItemNumber;
}
if (attributeKey == IdBusinessArea.Key.AsGuid) {
return ssBusinessArea;
}
if (attributeKey == IdCenter.Key.AsGuid) {
return ssCenter;
}
if (attributeKey == IdPEPElement.Key.AsGuid) {
return ssPEPElement;
}
if (attributeKey == IdDeliveredQuantity.Key.AsGuid) {
return ssDeliveredQuantity;
}
if (attributeKey == IdUMP.Key.AsGuid) {
return ssUMP;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssApplicant;
}
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
}
if (attributeKey == IdContractNumber.Key.AsGuid) {
return ssContractNumber;
}
if (attributeKey == IdContractPosition.Key.AsGuid) {
return ssContractPosition;
}
if (attributeKey == IdContractStartDate.Key.AsGuid) {
return ssContractStartDate;
}
if (attributeKey == IdContractEndDate.Key.AsGuid) {
return ssContractEndDate;
}
if (attributeKey == IdContractPlannedValue.Key.AsGuid) {
return ssContractPlannedValue;
}
if (attributeKey == IdPositionType.Key.AsGuid) {
return ssPositionType;
}
if (attributeKey == IdSerialNumberProfile.Key.AsGuid) {
return ssSerialNumberProfile;
}
if (attributeKey == IdBatchManaged.Key.AsGuid) {
return ssBatchManaged;
}
if (attributeKey == IdMaterialType.Key.AsGuid) {
return ssMaterialType;
}
if (attributeKey == IdItemGroup.Key.AsGuid) {
return ssItemGroup;
}
if (attributeKey == IdCreatingUser.Key.AsGuid) {
return ssCreatingUser;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPosition = (int) other.AttributeGet(IdPosition);
ssArticleNr = (string) other.AttributeGet(IdArticleNr);
ssArticleDescription = (string) other.AttributeGet(IdArticleDescription);
ssImputationCode = (string) other.AttributeGet(IdImputationCode);
ssDocumentClass = (string) other.AttributeGet(IdDocumentClass);
ssDeliveryDate = (string) other.AttributeGet(IdDeliveryDate);
ssQuantity = (decimal) other.AttributeGet(IdQuantity);
ssUnitType = (string) other.AttributeGet(IdUnitType);
ssUnitPrice = (decimal) other.AttributeGet(IdUnitPrice);
ssBaseQuantity = (int) other.AttributeGet(IdBaseQuantity);
ssChangeIndicator = (string) other.AttributeGet(IdChangeIndicator);
ssFinalDelivery = (string) other.AttributeGet(IdFinalDelivery);
ssGLAccountNumber = (string) other.AttributeGet(IdGLAccountNumber);
ssCostCenter = (string) other.AttributeGet(IdCostCenter);
ssFundsCenter = (string) other.AttributeGet(IdFundsCenter);
ssFund = (string) other.AttributeGet(IdFund);
ssCommitmentItem = (string) other.AttributeGet(IdCommitmentItem);
ssVATIndicator = (string) other.AttributeGet(IdVATIndicator);
ssVATProcedure = (string) other.AttributeGet(IdVATProcedure);
ssVATRate = (decimal) other.AttributeGet(IdVATRate);
ssPurchaseRequisitionNumber = (string) other.AttributeGet(IdPurchaseRequisitionNumber);
ssPurchaseRequisitionItemNumber = (int) other.AttributeGet(IdPurchaseRequisitionItemNumber);
ssBusinessArea = (string) other.AttributeGet(IdBusinessArea);
ssCenter = (string) other.AttributeGet(IdCenter);
ssPEPElement = (string) other.AttributeGet(IdPEPElement);
ssDeliveredQuantity = (decimal) other.AttributeGet(IdDeliveredQuantity);
ssUMP = (string) other.AttributeGet(IdUMP);
ssApplicant = (string) other.AttributeGet(IdApplicant);
ssDirection = (string) other.AttributeGet(IdDirection);
ssContractNumber = (string) other.AttributeGet(IdContractNumber);
ssContractPosition = (int) other.AttributeGet(IdContractPosition);
ssContractStartDate = (string) other.AttributeGet(IdContractStartDate);
ssContractEndDate = (string) other.AttributeGet(IdContractEndDate);
ssContractPlannedValue = (decimal) other.AttributeGet(IdContractPlannedValue);
ssPositionType = (string) other.AttributeGet(IdPositionType);
ssSerialNumberProfile = (string) other.AttributeGet(IdSerialNumberProfile);
ssBatchManaged = (string) other.AttributeGet(IdBatchManaged);
ssMaterialType = (string) other.AttributeGet(IdMaterialType);
ssItemGroup = (string) other.AttributeGet(IdItemGroup);
ssCreatingUser = (string) other.AttributeGet(IdCreatingUser);
}
} // ST_602b1becf0e261abf8529c8c55991799Structure
/// <summary>
/// RecordList type <code>OrderItemLineList</code> that represents a record list of
///  <code>OrderItemLine</code>
/// </summary>
public partial class RL_5a5dc4e5843197429d3408a507236d6a : GenericRecordList<ST_602b1becf0e261abf8529c8c55991799Structure>, IEnumerable, IEnumerator {

protected override ST_602b1becf0e261abf8529c8c55991799Structure GetElementDefaultValue() {
return new ST_602b1becf0e261abf8529c8c55991799Structure();
}

public T[] ToArray<T>(Func<ST_602b1becf0e261abf8529c8c55991799Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5a5dc4e5843197429d3408a507236d6a recordList, Func<ST_602b1becf0e261abf8529c8c55991799Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5a5dc4e5843197429d3408a507236d6a(ST_602b1becf0e261abf8529c8c55991799Structure[] array) {
  RL_5a5dc4e5843197429d3408a507236d6a result = new RL_5a5dc4e5843197429d3408a507236d6a();
result.InnerFromArray(array);
    return result;
}

public static RL_5a5dc4e5843197429d3408a507236d6a ToList<T>(T[] array, Func <T, ST_602b1becf0e261abf8529c8c55991799Structure> converter) {
  RL_5a5dc4e5843197429d3408a507236d6a result = new RL_5a5dc4e5843197429d3408a507236d6a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5a5dc4e5843197429d3408a507236d6a FromRestList<T>(RestList<T> restList, Func <T, ST_602b1becf0e261abf8529c8c55991799Structure> converter) {
  RL_5a5dc4e5843197429d3408a507236d6a result = new RL_5a5dc4e5843197429d3408a507236d6a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5a5dc4e5843197429d3408a507236d6a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_602b1becf0e261abf8529c8c55991799Structure> NewList() {
return new RL_5a5dc4e5843197429d3408a507236d6a();
}


} // RL_5a5dc4e5843197429d3408a507236d6a
}

