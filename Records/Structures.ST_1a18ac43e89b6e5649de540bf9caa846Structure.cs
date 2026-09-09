namespace ssConectaProveedores {
/// <summary>
/// [Structure] Order (YHgVq_J2V0yXrYNDrkSqvw)
///  <code>ST_1a18ac43e89b6e5649de540bf9caa846Structure</code> that represents <code>Order</code
/// > <p>Description: Order</p>
/// </summary>
// Name: Order
public partial struct ST_1a18ac43e89b6e5649de540bf9caa846Structure : ITypedRecord<ST_1a18ac43e89b6e5649de540bf9caa846Structure> {
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uQAD87phfUCJE2WJxNnrHg");
internal static readonly GlobalObjectKey IdOrderDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LnPsUlf3uk+BUTnGYS7qAQ");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*afbw5vXnqECLT8W3jZFpKQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Wv32paay2UW3cKXrvS4p8A");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*f1ngna+38E+etI4OE1VWVw");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_OBy9H13_k+2Q5Lt5Gc0vQ");
internal static readonly GlobalObjectKey IdFirstLevelUserName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wLYAbyefJkm5yM9dRVu3lg");
internal static readonly GlobalObjectKey IdFirstLevelEmail = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*X4tY6KGdkUmaQfEE2uBg0g");
internal static readonly GlobalObjectKey IdFirstLevelJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Q4lbrJUF3Eix2Z8SQhSZ6w");
internal static readonly GlobalObjectKey IdFirstEntraRoleName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2xsoV7NCxkiM3stG788hYQ");
internal static readonly GlobalObjectKey IdCurrLevelUserName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZhHIy8t3TkKqIGkfC09uDg");
internal static readonly GlobalObjectKey IdCurrLevelEmail = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*K7jmF4GxiUSsKy6uPUkRQg");
internal static readonly GlobalObjectKey IdCurrLevelJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*M2W_LdzbLEW5G_vVyi3IDg");
internal static readonly GlobalObjectKey IdCurrEntraRoleName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*g__glY93ukGiliaU0+9fwg");
internal static readonly GlobalObjectKey IdAssignedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HLQR9bF0xkKyzFVnBs_1Og");

public string ssOrderNumber;

public DateTime ssOrderDate;

public string ssOrderStatus;

public string ssRegion;

public string ssSupplierName;

public string ssSupplierNumber;

public string ssFirstLevelUserName;

public string ssFirstLevelEmail;

public string ssFirstLevelJobTitle;

public string ssFirstEntraRoleName;

public string ssCurrLevelUserName;

public string ssCurrLevelEmail;

public string ssCurrLevelJobTitle;

public string ssCurrEntraRoleName;

public DateTime ssAssignedOn;


public BitArray OptimizedAttributes;

public ST_1a18ac43e89b6e5649de540bf9caa846Structure() {
OptimizedAttributes = null;
ssOrderNumber = "";
ssOrderDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssOrderStatus = "";
ssRegion = "";
ssSupplierName = "";
ssSupplierNumber = "";
ssFirstLevelUserName = "";
ssFirstLevelEmail = "";
ssFirstLevelJobTitle = "";
ssFirstEntraRoleName = "";
ssCurrLevelUserName = "";
ssCurrLevelEmail = "";
ssCurrLevelJobTitle = "";
ssCurrEntraRoleName = "";
ssAssignedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssOrderNumber = r.ReadText(index++, "Order.OrderNumber", "");
ssOrderDate = r.ReadDate(index++, "Order.OrderDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssOrderStatus = r.ReadText(index++, "Order.OrderStatus", "");
ssRegion = r.ReadText(index++, "Order.Region", "");
ssSupplierName = r.ReadText(index++, "Order.SupplierName", "");
ssSupplierNumber = r.ReadText(index++, "Order.SupplierNumber", "");
ssFirstLevelUserName = r.ReadText(index++, "Order.FirstLevelUserName", "");
ssFirstLevelEmail = r.ReadText(index++, "Order.FirstLevelEmail", "");
ssFirstLevelJobTitle = r.ReadText(index++, "Order.FirstLevelJobTitle", "");
ssFirstEntraRoleName = r.ReadText(index++, "Order.FirstEntraRoleName", "");
ssCurrLevelUserName = r.ReadText(index++, "Order.CurrLevelUserName", "");
ssCurrLevelEmail = r.ReadText(index++, "Order.CurrLevelEmail", "");
ssCurrLevelJobTitle = r.ReadText(index++, "Order.CurrLevelJobTitle", "");
ssCurrEntraRoleName = r.ReadText(index++, "Order.CurrEntraRoleName", "");
ssAssignedOn = r.ReadDateTime(index++, "Order.AssignedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_1a18ac43e89b6e5649de540bf9caa846Structure r) {
this = r;
}


public static bool operator == (ST_1a18ac43e89b6e5649de540bf9caa846Structure a, ST_1a18ac43e89b6e5649de540bf9caa846Structure b) {
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssOrderDate != b.ssOrderDate) return false;
if (a.ssOrderStatus != b.ssOrderStatus) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssFirstLevelUserName != b.ssFirstLevelUserName) return false;
if (a.ssFirstLevelEmail != b.ssFirstLevelEmail) return false;
if (a.ssFirstLevelJobTitle != b.ssFirstLevelJobTitle) return false;
if (a.ssFirstEntraRoleName != b.ssFirstEntraRoleName) return false;
if (a.ssCurrLevelUserName != b.ssCurrLevelUserName) return false;
if (a.ssCurrLevelEmail != b.ssCurrLevelEmail) return false;
if (a.ssCurrLevelJobTitle != b.ssCurrLevelJobTitle) return false;
if (a.ssCurrEntraRoleName != b.ssCurrEntraRoleName) return false;
if (a.ssAssignedOn != b.ssAssignedOn) return false;
return true;
}

public static bool operator != (ST_1a18ac43e89b6e5649de540bf9caa846Structure a, ST_1a18ac43e89b6e5649de540bf9caa846Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1a18ac43e89b6e5649de540bf9caa846Structure)) return false;
return (this == (ST_1a18ac43e89b6e5649de540bf9caa846Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssOrderDate.GetHashCode()
 ^ ssOrderStatus.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssFirstLevelUserName.GetHashCode()
 ^ ssFirstLevelEmail.GetHashCode()
 ^ ssFirstLevelJobTitle.GetHashCode()
 ^ ssFirstEntraRoleName.GetHashCode()
 ^ ssCurrLevelUserName.GetHashCode()
 ^ ssCurrLevelEmail.GetHashCode()
 ^ ssCurrLevelJobTitle.GetHashCode()
 ^ ssCurrEntraRoleName.GetHashCode()
 ^ ssAssignedOn.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1a18ac43e89b6e5649de540bf9caa846Structure Duplicate() {
ST_1a18ac43e89b6e5649de540bf9caa846Structure t;
t.ssOrderNumber = this.ssOrderNumber;
t.ssOrderDate = this.ssOrderDate;
t.ssOrderStatus = this.ssOrderStatus;
t.ssRegion = this.ssRegion;
t.ssSupplierName = this.ssSupplierName;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssFirstLevelUserName = this.ssFirstLevelUserName;
t.ssFirstLevelEmail = this.ssFirstLevelEmail;
t.ssFirstLevelJobTitle = this.ssFirstLevelJobTitle;
t.ssFirstEntraRoleName = this.ssFirstEntraRoleName;
t.ssCurrLevelUserName = this.ssCurrLevelUserName;
t.ssCurrLevelEmail = this.ssCurrLevelEmail;
t.ssCurrLevelJobTitle = this.ssCurrLevelJobTitle;
t.ssCurrEntraRoleName = this.ssCurrEntraRoleName;
t.ssAssignedOn = this.ssAssignedOn;
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
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "firstlevelusername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstLevelUserName")) variable.Value = ssFirstLevelUserName; else variable.Optimized = true;
} else if (head == "firstlevelemail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstLevelEmail")) variable.Value = ssFirstLevelEmail; else variable.Optimized = true;
} else if (head == "firstleveljobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstLevelJobTitle")) variable.Value = ssFirstLevelJobTitle; else variable.Optimized = true;
} else if (head == "firstentrarolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstEntraRoleName")) variable.Value = ssFirstEntraRoleName; else variable.Optimized = true;
} else if (head == "currlevelusername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrLevelUserName")) variable.Value = ssCurrLevelUserName; else variable.Optimized = true;
} else if (head == "currlevelemail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrLevelEmail")) variable.Value = ssCurrLevelEmail; else variable.Optimized = true;
} else if (head == "currleveljobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrLevelJobTitle")) variable.Value = ssCurrLevelJobTitle; else variable.Optimized = true;
} else if (head == "currentrarolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrEntraRoleName")) variable.Value = ssCurrEntraRoleName; else variable.Optimized = true;
} else if (head == "assignedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssignedOn")) variable.Value = ssAssignedOn; else variable.Optimized = true;
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
if (key == IdRegion) {
return ssRegion;
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
if (key == IdFirstLevelEmail) {
return ssFirstLevelEmail;
}
if (key == IdFirstLevelJobTitle) {
return ssFirstLevelJobTitle;
}
if (key == IdFirstEntraRoleName) {
return ssFirstEntraRoleName;
}
if (key == IdCurrLevelUserName) {
return ssCurrLevelUserName;
}
if (key == IdCurrLevelEmail) {
return ssCurrLevelEmail;
}
if (key == IdCurrLevelJobTitle) {
return ssCurrLevelJobTitle;
}
if (key == IdCurrEntraRoleName) {
return ssCurrEntraRoleName;
}
if (key == IdAssignedOn) {
return ssAssignedOn;
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
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
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
if (attributeKey == IdFirstLevelEmail.Key.AsGuid) {
return ssFirstLevelEmail;
}
if (attributeKey == IdFirstLevelJobTitle.Key.AsGuid) {
return ssFirstLevelJobTitle;
}
if (attributeKey == IdFirstEntraRoleName.Key.AsGuid) {
return ssFirstEntraRoleName;
}
if (attributeKey == IdCurrLevelUserName.Key.AsGuid) {
return ssCurrLevelUserName;
}
if (attributeKey == IdCurrLevelEmail.Key.AsGuid) {
return ssCurrLevelEmail;
}
if (attributeKey == IdCurrLevelJobTitle.Key.AsGuid) {
return ssCurrLevelJobTitle;
}
if (attributeKey == IdCurrEntraRoleName.Key.AsGuid) {
return ssCurrEntraRoleName;
}
if (attributeKey == IdAssignedOn.Key.AsGuid) {
return ssAssignedOn;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssOrderDate = (DateTime) other.AttributeGet(IdOrderDate);
ssOrderStatus = (string) other.AttributeGet(IdOrderStatus);
ssRegion = (string) other.AttributeGet(IdRegion);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssFirstLevelUserName = (string) other.AttributeGet(IdFirstLevelUserName);
ssFirstLevelEmail = (string) other.AttributeGet(IdFirstLevelEmail);
ssFirstLevelJobTitle = (string) other.AttributeGet(IdFirstLevelJobTitle);
ssFirstEntraRoleName = (string) other.AttributeGet(IdFirstEntraRoleName);
ssCurrLevelUserName = (string) other.AttributeGet(IdCurrLevelUserName);
ssCurrLevelEmail = (string) other.AttributeGet(IdCurrLevelEmail);
ssCurrLevelJobTitle = (string) other.AttributeGet(IdCurrLevelJobTitle);
ssCurrEntraRoleName = (string) other.AttributeGet(IdCurrEntraRoleName);
ssAssignedOn = (DateTime) other.AttributeGet(IdAssignedOn);
}
} // ST_1a18ac43e89b6e5649de540bf9caa846Structure
/// <summary>
/// RecordList type <code>OrderList</code> that represents a record list of <code>Order</code>
/// </summary>
public partial class RL_00157e7748c05ddaff72414057b98abf : GenericRecordList<ST_1a18ac43e89b6e5649de540bf9caa846Structure>, IEnumerable, IEnumerator {

protected override ST_1a18ac43e89b6e5649de540bf9caa846Structure GetElementDefaultValue() {
return new ST_1a18ac43e89b6e5649de540bf9caa846Structure();
}

public T[] ToArray<T>(Func<ST_1a18ac43e89b6e5649de540bf9caa846Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_00157e7748c05ddaff72414057b98abf recordList, Func<ST_1a18ac43e89b6e5649de540bf9caa846Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_00157e7748c05ddaff72414057b98abf(ST_1a18ac43e89b6e5649de540bf9caa846Structure[] array) {
  RL_00157e7748c05ddaff72414057b98abf result = new RL_00157e7748c05ddaff72414057b98abf();
result.InnerFromArray(array);
    return result;
}

public static RL_00157e7748c05ddaff72414057b98abf ToList<T>(T[] array, Func <T, ST_1a18ac43e89b6e5649de540bf9caa846Structure> converter) {
  RL_00157e7748c05ddaff72414057b98abf result = new RL_00157e7748c05ddaff72414057b98abf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_00157e7748c05ddaff72414057b98abf FromRestList<T>(RestList<T> restList, Func <T, ST_1a18ac43e89b6e5649de540bf9caa846Structure> converter) {
  RL_00157e7748c05ddaff72414057b98abf result = new RL_00157e7748c05ddaff72414057b98abf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_00157e7748c05ddaff72414057b98abf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1a18ac43e89b6e5649de540bf9caa846Structure> NewList() {
return new RL_00157e7748c05ddaff72414057b98abf();
}


} // RL_00157e7748c05ddaff72414057b98abf
}

