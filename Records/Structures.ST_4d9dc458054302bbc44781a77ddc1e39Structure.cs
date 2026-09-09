namespace ssConectaProveedores {
/// <summary>
/// [Structure] LinesReport63 (jIRu2jd7u0K98a1nEpiSKQ)
///  <code>ST_4d9dc458054302bbc44781a77ddc1e39Structure</code> that represent
/// s <code>LinesReport63</code> <p>Description: </p>
/// </summary>
// Name: LinesReport63
public partial struct ST_4d9dc458054302bbc44781a77ddc1e39Structure : ITypedRecord<ST_4d9dc458054302bbc44781a77ddc1e39Structure> {
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Kn7E1Yer_UmKEke4s0IfSA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aM4S2no1u0GLN7J51kzAEQ");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6ZsLRkKucke1Dt95M_KOiQ");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GqWHVgdOp0KBj2+Mzcp4vw");
internal static readonly GlobalObjectKey IdIsDeleted = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Vx4oE3hJ8Uanz+BPqlfbfw");
internal static readonly GlobalObjectKey IdIsReleased = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mq9JLbwRsEaGQzTWbrV8Qg");
internal static readonly GlobalObjectKey IdisFinalDelivery = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7Dhw+Dkx00+MhOrUpavGJA");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*X4Eaoqe320GPYnu4xiJDKQ");
internal static readonly GlobalObjectKey IdAssignmentCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*cnT_hasqvEOBQUgvLR49KQ");
internal static readonly GlobalObjectKey IdSociedad = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+PXeC4j3okGhY5BOEbzhOA");
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nUiRhuSPMEKK333TEDh2UQ");
internal static readonly GlobalObjectKey IdMaterialCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*48WcLbZUtEuhevZde8m1rQ");
internal static readonly GlobalObjectKey IdMaterialDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mZCiDj6zdUepxOOsdQU3jQ");
internal static readonly GlobalObjectKey IdQuantity = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9Y0cUIV_R0aPzCOSCMY35A");
internal static readonly GlobalObjectKey IdQuantityDelivered = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NTrqk+sER0Gb4OOIutfNAg");
internal static readonly GlobalObjectKey IdQuantityAvailable = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CNAstRftgkS62w9rYEoehg");
internal static readonly GlobalObjectKey IdUnitPrice = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BNLoAwWw1kGPlQS1wFYzmw");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jzFJFzfbsE6uULVl2WtTYA");
internal static readonly GlobalObjectKey IdTotal = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Zq1ohf2cC0ecYh9hXCrC4A");
internal static readonly GlobalObjectKey IdDeliveryStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*O920C3yrPkasvX4A8cXPIw");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*54POV1cKyEqXlp8BO4czhg");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XJkF5jP8+0abkSIc0MVHQg");
internal static readonly GlobalObjectKey IdUserJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Is0MOCvTL02fbcoX_Z0igQ");

public string ssOrderNumber;

public string ssCreatedOn;

public string ssSupplierNumber;

public string ssSupplierName;

public string ssIsDeleted;

public string ssIsReleased;

public string ssisFinalDelivery;

public string ssApplicant;

public string ssAssignmentCode;

public string ssSociedad;

public int ssPosition;

public string ssMaterialCode;

public string ssMaterialDescription;

public string ssQuantity;

public string ssQuantityDelivered;

public string ssQuantityAvailable;

public string ssUnitPrice;

public string ssCurrency;

public string ssTotal;

public string ssDeliveryStatus;

public string ssOrderStatus;

public string ssUser;

public string ssUserJobTitle;


public BitArray OptimizedAttributes;

public ST_4d9dc458054302bbc44781a77ddc1e39Structure() {
OptimizedAttributes = null;
ssOrderNumber = "";
ssCreatedOn = "";
ssSupplierNumber = "";
ssSupplierName = "";
ssIsDeleted = "";
ssIsReleased = "";
ssisFinalDelivery = "";
ssApplicant = "";
ssAssignmentCode = "";
ssSociedad = "";
ssPosition = 0;
ssMaterialCode = "";
ssMaterialDescription = "";
ssQuantity = "";
ssQuantityDelivered = "";
ssQuantityAvailable = "";
ssUnitPrice = "";
ssCurrency = "";
ssTotal = "";
ssDeliveryStatus = "";
ssOrderStatus = "";
ssUser = "";
ssUserJobTitle = "";
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
ssOrderNumber = r.ReadText(index++, "LinesReport63.OrderNumber", "");
ssCreatedOn = r.ReadText(index++, "LinesReport63.CreatedOn", "");
ssSupplierNumber = r.ReadText(index++, "LinesReport63.SupplierNumber", "");
ssSupplierName = r.ReadText(index++, "LinesReport63.SupplierName", "");
ssIsDeleted = r.ReadText(index++, "LinesReport63.IsDeleted", "");
ssIsReleased = r.ReadText(index++, "LinesReport63.IsReleased", "");
ssisFinalDelivery = r.ReadText(index++, "LinesReport63.isFinalDelivery", "");
ssApplicant = r.ReadText(index++, "LinesReport63.Applicant", "");
ssAssignmentCode = r.ReadText(index++, "LinesReport63.AssignmentCode", "");
ssSociedad = r.ReadText(index++, "LinesReport63.Sociedad", "");
ssPosition = r.ReadInteger(index++, "LinesReport63.Position", 0);
ssMaterialCode = r.ReadText(index++, "LinesReport63.MaterialCode", "");
ssMaterialDescription = r.ReadText(index++, "LinesReport63.MaterialDescription", "");
ssQuantity = r.ReadText(index++, "LinesReport63.Quantity", "");
ssQuantityDelivered = r.ReadText(index++, "LinesReport63.QuantityDelivered", "");
ssQuantityAvailable = r.ReadText(index++, "LinesReport63.QuantityAvailable", "");
ssUnitPrice = r.ReadText(index++, "LinesReport63.UnitPrice", "");
ssCurrency = r.ReadText(index++, "LinesReport63.Currency", "");
ssTotal = r.ReadText(index++, "LinesReport63.Total", "");
ssDeliveryStatus = r.ReadText(index++, "LinesReport63.DeliveryStatus", "");
ssOrderStatus = r.ReadText(index++, "LinesReport63.OrderStatus", "");
ssUser = r.ReadText(index++, "LinesReport63.User", "");
ssUserJobTitle = r.ReadText(index++, "LinesReport63.UserJobTitle", "");
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
public void ReadIM(ST_4d9dc458054302bbc44781a77ddc1e39Structure r) {
this = r;
}


public static bool operator == (ST_4d9dc458054302bbc44781a77ddc1e39Structure a, ST_4d9dc458054302bbc44781a77ddc1e39Structure b) {
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssIsDeleted != b.ssIsDeleted) return false;
if (a.ssIsReleased != b.ssIsReleased) return false;
if (a.ssisFinalDelivery != b.ssisFinalDelivery) return false;
if (a.ssApplicant != b.ssApplicant) return false;
if (a.ssAssignmentCode != b.ssAssignmentCode) return false;
if (a.ssSociedad != b.ssSociedad) return false;
if (a.ssPosition != b.ssPosition) return false;
if (a.ssMaterialCode != b.ssMaterialCode) return false;
if (a.ssMaterialDescription != b.ssMaterialDescription) return false;
if (a.ssQuantity != b.ssQuantity) return false;
if (a.ssQuantityDelivered != b.ssQuantityDelivered) return false;
if (a.ssQuantityAvailable != b.ssQuantityAvailable) return false;
if (a.ssUnitPrice != b.ssUnitPrice) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssTotal != b.ssTotal) return false;
if (a.ssDeliveryStatus != b.ssDeliveryStatus) return false;
if (a.ssOrderStatus != b.ssOrderStatus) return false;
if (a.ssUser != b.ssUser) return false;
if (a.ssUserJobTitle != b.ssUserJobTitle) return false;
return true;
}

public static bool operator != (ST_4d9dc458054302bbc44781a77ddc1e39Structure a, ST_4d9dc458054302bbc44781a77ddc1e39Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_4d9dc458054302bbc44781a77ddc1e39Structure)) return false;
return (this == (ST_4d9dc458054302bbc44781a77ddc1e39Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssIsDeleted.GetHashCode()
 ^ ssIsReleased.GetHashCode()
 ^ ssisFinalDelivery.GetHashCode()
 ^ ssApplicant.GetHashCode()
 ^ ssAssignmentCode.GetHashCode()
 ^ ssSociedad.GetHashCode()
 ^ ssPosition.GetHashCode()
 ^ ssMaterialCode.GetHashCode()
 ^ ssMaterialDescription.GetHashCode()
 ^ ssQuantity.GetHashCode()
 ^ ssQuantityDelivered.GetHashCode()
 ^ ssQuantityAvailable.GetHashCode()
 ^ ssUnitPrice.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssTotal.GetHashCode()
 ^ ssDeliveryStatus.GetHashCode()
 ^ ssOrderStatus.GetHashCode()
 ^ ssUser.GetHashCode()
 ^ ssUserJobTitle.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_4d9dc458054302bbc44781a77ddc1e39Structure Duplicate() {
ST_4d9dc458054302bbc44781a77ddc1e39Structure t;
t.ssOrderNumber = this.ssOrderNumber;
t.ssCreatedOn = this.ssCreatedOn;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssSupplierName = this.ssSupplierName;
t.ssIsDeleted = this.ssIsDeleted;
t.ssIsReleased = this.ssIsReleased;
t.ssisFinalDelivery = this.ssisFinalDelivery;
t.ssApplicant = this.ssApplicant;
t.ssAssignmentCode = this.ssAssignmentCode;
t.ssSociedad = this.ssSociedad;
t.ssPosition = this.ssPosition;
t.ssMaterialCode = this.ssMaterialCode;
t.ssMaterialDescription = this.ssMaterialDescription;
t.ssQuantity = this.ssQuantity;
t.ssQuantityDelivered = this.ssQuantityDelivered;
t.ssQuantityAvailable = this.ssQuantityAvailable;
t.ssUnitPrice = this.ssUnitPrice;
t.ssCurrency = this.ssCurrency;
t.ssTotal = this.ssTotal;
t.ssDeliveryStatus = this.ssDeliveryStatus;
t.ssOrderStatus = this.ssOrderStatus;
t.ssUser = this.ssUser;
t.ssUserJobTitle = this.ssUserJobTitle;
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
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "isdeleted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDeleted")) variable.Value = ssIsDeleted; else variable.Optimized = true;
} else if (head == "isreleased") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReleased")) variable.Value = ssIsReleased; else variable.Optimized = true;
} else if (head == "isfinaldelivery") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".isFinalDelivery")) variable.Value = ssisFinalDelivery; else variable.Optimized = true;
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssApplicant; else variable.Optimized = true;
} else if (head == "assignmentcode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignmentCode")) variable.Value = ssAssignmentCode; else variable.Optimized = true;
} else if (head == "sociedad") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Sociedad")) variable.Value = ssSociedad; else variable.Optimized = true;
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
} else if (head == "unitprice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitPrice")) variable.Value = ssUnitPrice; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "total") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Total")) variable.Value = ssTotal; else variable.Optimized = true;
} else if (head == "deliverystatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DeliveryStatus")) variable.Value = ssDeliveryStatus; else variable.Optimized = true;
} else if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssOrderStatus; else variable.Optimized = true;
} else if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssUser; else variable.Optimized = true;
} else if (head == "userjobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserJobTitle")) variable.Value = ssUserJobTitle; else variable.Optimized = true;
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
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdIsDeleted) {
return ssIsDeleted;
}
if (key == IdIsReleased) {
return ssIsReleased;
}
if (key == IdisFinalDelivery) {
return ssisFinalDelivery;
}
if (key == IdApplicant) {
return ssApplicant;
}
if (key == IdAssignmentCode) {
return ssAssignmentCode;
}
if (key == IdSociedad) {
return ssSociedad;
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
if (key == IdUnitPrice) {
return ssUnitPrice;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdTotal) {
return ssTotal;
}
if (key == IdDeliveryStatus) {
return ssDeliveryStatus;
}
if (key == IdOrderStatus) {
return ssOrderStatus;
}
if (key == IdUser) {
return ssUser;
}
if (key == IdUserJobTitle) {
return ssUserJobTitle;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdIsDeleted.Key.AsGuid) {
return ssIsDeleted;
}
if (attributeKey == IdIsReleased.Key.AsGuid) {
return ssIsReleased;
}
if (attributeKey == IdisFinalDelivery.Key.AsGuid) {
return ssisFinalDelivery;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssApplicant;
}
if (attributeKey == IdAssignmentCode.Key.AsGuid) {
return ssAssignmentCode;
}
if (attributeKey == IdSociedad.Key.AsGuid) {
return ssSociedad;
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
if (attributeKey == IdUnitPrice.Key.AsGuid) {
return ssUnitPrice;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdTotal.Key.AsGuid) {
return ssTotal;
}
if (attributeKey == IdDeliveryStatus.Key.AsGuid) {
return ssDeliveryStatus;
}
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssOrderStatus;
}
if (attributeKey == IdUser.Key.AsGuid) {
return ssUser;
}
if (attributeKey == IdUserJobTitle.Key.AsGuid) {
return ssUserJobTitle;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssCreatedOn = (string) other.AttributeGet(IdCreatedOn);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssIsDeleted = (string) other.AttributeGet(IdIsDeleted);
ssIsReleased = (string) other.AttributeGet(IdIsReleased);
ssisFinalDelivery = (string) other.AttributeGet(IdisFinalDelivery);
ssApplicant = (string) other.AttributeGet(IdApplicant);
ssAssignmentCode = (string) other.AttributeGet(IdAssignmentCode);
ssSociedad = (string) other.AttributeGet(IdSociedad);
ssPosition = (int) other.AttributeGet(IdPosition);
ssMaterialCode = (string) other.AttributeGet(IdMaterialCode);
ssMaterialDescription = (string) other.AttributeGet(IdMaterialDescription);
ssQuantity = (string) other.AttributeGet(IdQuantity);
ssQuantityDelivered = (string) other.AttributeGet(IdQuantityDelivered);
ssQuantityAvailable = (string) other.AttributeGet(IdQuantityAvailable);
ssUnitPrice = (string) other.AttributeGet(IdUnitPrice);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssTotal = (string) other.AttributeGet(IdTotal);
ssDeliveryStatus = (string) other.AttributeGet(IdDeliveryStatus);
ssOrderStatus = (string) other.AttributeGet(IdOrderStatus);
ssUser = (string) other.AttributeGet(IdUser);
ssUserJobTitle = (string) other.AttributeGet(IdUserJobTitle);
}
} // ST_4d9dc458054302bbc44781a77ddc1e39Structure
/// <summary>
/// RecordList type <code>LinesReport63List</code> that represents a record list of
///  <code>LinesReport63</code>
/// </summary>
public partial class RL_5c9c2f90b5c4a20f64fc5db975393a5e : GenericRecordList<ST_4d9dc458054302bbc44781a77ddc1e39Structure>, IEnumerable, IEnumerator {

protected override ST_4d9dc458054302bbc44781a77ddc1e39Structure GetElementDefaultValue() {
return new ST_4d9dc458054302bbc44781a77ddc1e39Structure();
}

public T[] ToArray<T>(Func<ST_4d9dc458054302bbc44781a77ddc1e39Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c9c2f90b5c4a20f64fc5db975393a5e recordList, Func<ST_4d9dc458054302bbc44781a77ddc1e39Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c9c2f90b5c4a20f64fc5db975393a5e(ST_4d9dc458054302bbc44781a77ddc1e39Structure[] array) {
  RL_5c9c2f90b5c4a20f64fc5db975393a5e result = new RL_5c9c2f90b5c4a20f64fc5db975393a5e();
result.InnerFromArray(array);
    return result;
}

public static RL_5c9c2f90b5c4a20f64fc5db975393a5e ToList<T>(T[] array, Func <T, ST_4d9dc458054302bbc44781a77ddc1e39Structure> converter) {
  RL_5c9c2f90b5c4a20f64fc5db975393a5e result = new RL_5c9c2f90b5c4a20f64fc5db975393a5e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c9c2f90b5c4a20f64fc5db975393a5e FromRestList<T>(RestList<T> restList, Func <T, ST_4d9dc458054302bbc44781a77ddc1e39Structure> converter) {
  RL_5c9c2f90b5c4a20f64fc5db975393a5e result = new RL_5c9c2f90b5c4a20f64fc5db975393a5e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c9c2f90b5c4a20f64fc5db975393a5e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_4d9dc458054302bbc44781a77ddc1e39Structure> NewList() {
return new RL_5c9c2f90b5c4a20f64fc5db975393a5e();
}


} // RL_5c9c2f90b5c4a20f64fc5db975393a5e
}

