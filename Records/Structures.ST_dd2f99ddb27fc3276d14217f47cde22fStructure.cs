namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrdersToConsultReport (3k7tQ9E5d0euVXPlE70kIQ)
///  <code>ST_dd2f99ddb27fc3276d14217f47cde22fStructure</code> that represent
/// s <code>OrdersToConsultReport</code> <p>Description: Orders To Consult Report.</p>
/// </summary>
// Name: OrdersToConsultReport
public partial struct ST_dd2f99ddb27fc3276d14217f47cde22fStructure : ITypedRecord<ST_dd2f99ddb27fc3276d14217f47cde22fStructure> {
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lFdHTG8+2EWmnTrR4m8ZfQ");
internal static readonly GlobalObjectKey IdOrderDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XCHv_M4IMUKcNbOxG_TWhA");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0GiwoBjPUkyVdsfr1e+sAQ");
internal static readonly GlobalObjectKey IdOrderImportDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EcFssQUTj0645fK8irAmZQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KCx1dNLt9EWAvjSoFHteDw");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KDQg_mg7xU6l_UyUg3kdyA");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*P8U4iQvfP02SQfWscI7mPA");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dhIfTEY9XEGhCh0jsKkhZw");
internal static readonly GlobalObjectKey IdFirstLevelUserName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HQjUWdfB2EOKOew6xng4cw");
internal static readonly GlobalObjectKey IdFirstLevelJobTitle_EntraRoleName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*aZ1NwI1H0UenTL4gXrFbzg");
internal static readonly GlobalObjectKey IdCurrLevelUserName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nhI2eAulP0uesOlcYugFuA");
internal static readonly GlobalObjectKey IdCurrLevelJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Zyj9VOlvr0GTjOcpJ5iCRw");
internal static readonly GlobalObjectKey IdAssignedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ityFZvVMnECfouWqGPKy8Q");
internal static readonly GlobalObjectKey IdAssignedOnTime = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EKc12CUG90ipLnCU7V4Mgw");

public string ssOrderNumber;

public DateTime ssOrderDate;

public string ssOrderStatus;

public DateTime ssOrderImportDate;

public string ssRegion;

public string ssTelcelDirection;

public string ssSupplierName;

public string ssSupplierNumber;

public string ssFirstLevelUserName;

public string ssFirstLevelJobTitle_EntraRoleName;

public string ssCurrLevelUserName;

public string ssCurrLevelJobTitle;

public DateTime ssAssignedOn;

public DateTime ssAssignedOnTime;


public BitArray OptimizedAttributes;

public ST_dd2f99ddb27fc3276d14217f47cde22fStructure() {
OptimizedAttributes = null;
ssOrderNumber = "";
ssOrderDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssOrderStatus = "";
ssOrderImportDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssRegion = "";
ssTelcelDirection = "";
ssSupplierName = "";
ssSupplierNumber = "";
ssFirstLevelUserName = "";
ssFirstLevelJobTitle_EntraRoleName = "";
ssCurrLevelUserName = "";
ssCurrLevelJobTitle = "";
ssAssignedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssAssignedOnTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssOrderNumber = r.ReadText(index++, "OrdersToConsultReport.OrderNumber", "");
ssOrderDate = r.ReadDate(index++, "OrdersToConsultReport.OrderDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssOrderStatus = r.ReadText(index++, "OrdersToConsultReport.OrderStatus", "");
ssOrderImportDate = r.ReadDate(index++, "OrdersToConsultReport.OrderImportDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRegion = r.ReadText(index++, "OrdersToConsultReport.Region", "");
ssTelcelDirection = r.ReadText(index++, "OrdersToConsultReport.TelcelDirection", "");
ssSupplierName = r.ReadText(index++, "OrdersToConsultReport.SupplierName", "");
ssSupplierNumber = r.ReadText(index++, "OrdersToConsultReport.SupplierNumber", "");
ssFirstLevelUserName = r.ReadText(index++, "OrdersToConsultReport.FirstLevelUserName", "");
ssFirstLevelJobTitle_EntraRoleName = r.ReadText(index++, "OrdersToConsultReport.FirstLevelJobTitle_EntraRoleName", "");
ssCurrLevelUserName = r.ReadText(index++, "OrdersToConsultReport.CurrLevelUserName", "");
ssCurrLevelJobTitle = r.ReadText(index++, "OrdersToConsultReport.CurrLevelJobTitle", "");
ssAssignedOn = r.ReadDate(index++, "OrdersToConsultReport.AssignedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssAssignedOnTime = r.ReadTime(index++, "OrdersToConsultReport.AssignedOnTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_dd2f99ddb27fc3276d14217f47cde22fStructure r) {
this = r;
}


public static bool operator == (ST_dd2f99ddb27fc3276d14217f47cde22fStructure a, ST_dd2f99ddb27fc3276d14217f47cde22fStructure b) {
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssOrderDate != b.ssOrderDate) return false;
if (a.ssOrderStatus != b.ssOrderStatus) return false;
if (a.ssOrderImportDate != b.ssOrderImportDate) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssTelcelDirection != b.ssTelcelDirection) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssFirstLevelUserName != b.ssFirstLevelUserName) return false;
if (a.ssFirstLevelJobTitle_EntraRoleName != b.ssFirstLevelJobTitle_EntraRoleName) return false;
if (a.ssCurrLevelUserName != b.ssCurrLevelUserName) return false;
if (a.ssCurrLevelJobTitle != b.ssCurrLevelJobTitle) return false;
if (a.ssAssignedOn != b.ssAssignedOn) return false;
if (a.ssAssignedOnTime != b.ssAssignedOnTime) return false;
return true;
}

public static bool operator != (ST_dd2f99ddb27fc3276d14217f47cde22fStructure a, ST_dd2f99ddb27fc3276d14217f47cde22fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_dd2f99ddb27fc3276d14217f47cde22fStructure)) return false;
return (this == (ST_dd2f99ddb27fc3276d14217f47cde22fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssOrderDate.GetHashCode()
 ^ ssOrderStatus.GetHashCode()
 ^ ssOrderImportDate.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssTelcelDirection.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssFirstLevelUserName.GetHashCode()
 ^ ssFirstLevelJobTitle_EntraRoleName.GetHashCode()
 ^ ssCurrLevelUserName.GetHashCode()
 ^ ssCurrLevelJobTitle.GetHashCode()
 ^ ssAssignedOn.GetHashCode()
 ^ ssAssignedOnTime.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_dd2f99ddb27fc3276d14217f47cde22fStructure Duplicate() {
ST_dd2f99ddb27fc3276d14217f47cde22fStructure t;
t.ssOrderNumber = this.ssOrderNumber;
t.ssOrderDate = this.ssOrderDate;
t.ssOrderStatus = this.ssOrderStatus;
t.ssOrderImportDate = this.ssOrderImportDate;
t.ssRegion = this.ssRegion;
t.ssTelcelDirection = this.ssTelcelDirection;
t.ssSupplierName = this.ssSupplierName;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssFirstLevelUserName = this.ssFirstLevelUserName;
t.ssFirstLevelJobTitle_EntraRoleName = this.ssFirstLevelJobTitle_EntraRoleName;
t.ssCurrLevelUserName = this.ssCurrLevelUserName;
t.ssCurrLevelJobTitle = this.ssCurrLevelJobTitle;
t.ssAssignedOn = this.ssAssignedOn;
t.ssAssignedOnTime = this.ssAssignedOnTime;
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
} else if (head == "orderdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDate")) variable.Value = ssOrderDate; else variable.Optimized = true;
} else if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssOrderStatus; else variable.Optimized = true;
} else if (head == "orderimportdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderImportDate")) variable.Value = ssOrderImportDate; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssTelcelDirection; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "firstlevelusername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstLevelUserName")) variable.Value = ssFirstLevelUserName; else variable.Optimized = true;
} else if (head == "firstleveljobtitle_entrarolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstLevelJobTitle_EntraRoleName")) variable.Value = ssFirstLevelJobTitle_EntraRoleName; else variable.Optimized = true;
} else if (head == "currlevelusername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrLevelUserName")) variable.Value = ssCurrLevelUserName; else variable.Optimized = true;
} else if (head == "currleveljobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrLevelJobTitle")) variable.Value = ssCurrLevelJobTitle; else variable.Optimized = true;
} else if (head == "assignedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedOn")) variable.Value = ssAssignedOn; else variable.Optimized = true;
} else if (head == "assignedontime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedOnTime")) variable.Value = ssAssignedOnTime; else variable.Optimized = true;
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
if (key == IdOrderDate) {
return ssOrderDate;
}
if (key == IdOrderStatus) {
return ssOrderStatus;
}
if (key == IdOrderImportDate) {
return ssOrderImportDate;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdTelcelDirection) {
return ssTelcelDirection;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdFirstLevelUserName) {
return ssFirstLevelUserName;
}
if (key == IdFirstLevelJobTitle_EntraRoleName) {
return ssFirstLevelJobTitle_EntraRoleName;
}
if (key == IdCurrLevelUserName) {
return ssCurrLevelUserName;
}
if (key == IdCurrLevelJobTitle) {
return ssCurrLevelJobTitle;
}
if (key == IdAssignedOn) {
return ssAssignedOn;
}
if (key == IdAssignedOnTime) {
return ssAssignedOnTime;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdOrderDate.Key.AsGuid) {
return ssOrderDate;
}
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssOrderStatus;
}
if (attributeKey == IdOrderImportDate.Key.AsGuid) {
return ssOrderImportDate;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssTelcelDirection;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdFirstLevelUserName.Key.AsGuid) {
return ssFirstLevelUserName;
}
if (attributeKey == IdFirstLevelJobTitle_EntraRoleName.Key.AsGuid) {
return ssFirstLevelJobTitle_EntraRoleName;
}
if (attributeKey == IdCurrLevelUserName.Key.AsGuid) {
return ssCurrLevelUserName;
}
if (attributeKey == IdCurrLevelJobTitle.Key.AsGuid) {
return ssCurrLevelJobTitle;
}
if (attributeKey == IdAssignedOn.Key.AsGuid) {
return ssAssignedOn;
}
if (attributeKey == IdAssignedOnTime.Key.AsGuid) {
return ssAssignedOnTime;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssOrderDate = (DateTime) other.AttributeGet(IdOrderDate);
ssOrderStatus = (string) other.AttributeGet(IdOrderStatus);
ssOrderImportDate = (DateTime) other.AttributeGet(IdOrderImportDate);
ssRegion = (string) other.AttributeGet(IdRegion);
ssTelcelDirection = (string) other.AttributeGet(IdTelcelDirection);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssFirstLevelUserName = (string) other.AttributeGet(IdFirstLevelUserName);
ssFirstLevelJobTitle_EntraRoleName = (string) other.AttributeGet(IdFirstLevelJobTitle_EntraRoleName);
ssCurrLevelUserName = (string) other.AttributeGet(IdCurrLevelUserName);
ssCurrLevelJobTitle = (string) other.AttributeGet(IdCurrLevelJobTitle);
ssAssignedOn = (DateTime) other.AttributeGet(IdAssignedOn);
ssAssignedOnTime = (DateTime) other.AttributeGet(IdAssignedOnTime);
}
} // ST_dd2f99ddb27fc3276d14217f47cde22fStructure
/// <summary>
/// RecordList type <code>OrdersToConsultReportList</code> that represents a record list of
///  <code>OrdersToConsultReport</code>
/// </summary>
public partial class RL_56e4627e83bd01097b2e39e8d7867dce : GenericRecordList<ST_dd2f99ddb27fc3276d14217f47cde22fStructure>, IEnumerable, IEnumerator {

protected override ST_dd2f99ddb27fc3276d14217f47cde22fStructure GetElementDefaultValue() {
return new ST_dd2f99ddb27fc3276d14217f47cde22fStructure();
}

public T[] ToArray<T>(Func<ST_dd2f99ddb27fc3276d14217f47cde22fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_56e4627e83bd01097b2e39e8d7867dce recordList, Func<ST_dd2f99ddb27fc3276d14217f47cde22fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_56e4627e83bd01097b2e39e8d7867dce(ST_dd2f99ddb27fc3276d14217f47cde22fStructure[] array) {
  RL_56e4627e83bd01097b2e39e8d7867dce result = new RL_56e4627e83bd01097b2e39e8d7867dce();
result.InnerFromArray(array);
    return result;
}

public static RL_56e4627e83bd01097b2e39e8d7867dce ToList<T>(T[] array, Func <T, ST_dd2f99ddb27fc3276d14217f47cde22fStructure> converter) {
  RL_56e4627e83bd01097b2e39e8d7867dce result = new RL_56e4627e83bd01097b2e39e8d7867dce();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_56e4627e83bd01097b2e39e8d7867dce FromRestList<T>(RestList<T> restList, Func <T, ST_dd2f99ddb27fc3276d14217f47cde22fStructure> converter) {
  RL_56e4627e83bd01097b2e39e8d7867dce result = new RL_56e4627e83bd01097b2e39e8d7867dce();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_56e4627e83bd01097b2e39e8d7867dce() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_dd2f99ddb27fc3276d14217f47cde22fStructure> NewList() {
return new RL_56e4627e83bd01097b2e39e8d7867dce();
}


} // RL_56e4627e83bd01097b2e39e8d7867dce
}

