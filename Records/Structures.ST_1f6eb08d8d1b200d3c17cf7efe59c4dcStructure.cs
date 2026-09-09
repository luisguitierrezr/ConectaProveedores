namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrdersToConsult (yqRSZ+vMx0Gg4yjM85ipZg)
///  <code>ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure</code> that represent
/// s <code>OrdersToConsult</code> <p>Description: </p>
/// </summary>
// Name: OrdersToConsult
public partial struct ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure : ITypedRecord<ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure> {
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*b5JsNi0IMEaR2Mb3XIGDqA");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NBVqnZXYqEKpwJfMocEBMA");
internal static readonly GlobalObjectKey IdOrderDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*asd+rQ9YD0CUPnRm6ncyUQ");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GsjE2vet3EaLs09EzyOhwg");
internal static readonly GlobalObjectKey IdOrderStatusClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*L1WDpqidcUaaCH6RNgwQUA");
internal static readonly GlobalObjectKey IdOrderImportDateTime = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LQ+wpzXLIkuNun3z2yobiw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*BR_2MyEnKkO6PqNS1R95ig");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DSl9u1UM40qdAoTJ8PiVyg");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CWUeDqWKnUW6kUAcqKIr0w");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DO0deSmttUyfAzUh33XvHQ");
internal static readonly GlobalObjectKey IdFirstLevelUserName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*O73KhxujTU2InUm8N2uIDA");
internal static readonly GlobalObjectKey IdFirstLevelJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4COkJpjnE0SjgLG8zI91pA");
internal static readonly GlobalObjectKey IdFirstEntraRoleName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dGfMNRLMi0+Qg7o7on1GuQ");
internal static readonly GlobalObjectKey IdCurrLevelUserName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WiZL2Hz0ok6sZe1DwOtcZA");
internal static readonly GlobalObjectKey IdCurrLevelJobTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dTue1YlJO0SCEJJtilagxg");
internal static readonly GlobalObjectKey IdCurrEntraRoleName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*mOrzJQBonEuQU2amo3dp_g");
internal static readonly GlobalObjectKey IdAssignedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HuCbFSYC10WDsXmT8rZMVg");

public long ssOrderMainId;

public string ssOrderNumber;

public DateTime ssOrderDate;

public string ssOrderStatus;

public string ssOrderStatusClass;

public DateTime ssOrderImportDateTime;

public string ssRegion;

public string ssTelcelDirection;

public string ssSupplierName;

public string ssSupplierNumber;

public string ssFirstLevelUserName;

public string ssFirstLevelJobTitle;

public string ssFirstEntraRoleName;

public string ssCurrLevelUserName;

public string ssCurrLevelJobTitle;

public string ssCurrEntraRoleName;

public DateTime ssAssignedOn;


public BitArray OptimizedAttributes;

public ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure() {
OptimizedAttributes = null;
ssOrderMainId = 0L;
ssOrderNumber = "";
ssOrderDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssOrderStatus = "";
ssOrderStatusClass = "";
ssOrderImportDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssRegion = "";
ssTelcelDirection = "";
ssSupplierName = "";
ssSupplierNumber = "";
ssFirstLevelUserName = "";
ssFirstLevelJobTitle = "";
ssFirstEntraRoleName = "";
ssCurrLevelUserName = "";
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
ssOrderMainId = r.ReadEntityReferenceLongInteger(index++, "OrdersToConsult.OrderMainId", 0L);
ssOrderNumber = r.ReadText(index++, "OrdersToConsult.OrderNumber", "");
ssOrderDate = r.ReadDate(index++, "OrdersToConsult.OrderDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssOrderStatus = r.ReadText(index++, "OrdersToConsult.OrderStatus", "");
ssOrderStatusClass = r.ReadText(index++, "OrdersToConsult.OrderStatusClass", "");
ssOrderImportDateTime = r.ReadDateTime(index++, "OrdersToConsult.OrderImportDateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssRegion = r.ReadText(index++, "OrdersToConsult.Region", "");
ssTelcelDirection = r.ReadText(index++, "OrdersToConsult.TelcelDirection", "");
ssSupplierName = r.ReadText(index++, "OrdersToConsult.SupplierName", "");
ssSupplierNumber = r.ReadText(index++, "OrdersToConsult.SupplierNumber", "");
ssFirstLevelUserName = r.ReadText(index++, "OrdersToConsult.FirstLevelUserName", "");
ssFirstLevelJobTitle = r.ReadText(index++, "OrdersToConsult.FirstLevelJobTitle", "");
ssFirstEntraRoleName = r.ReadText(index++, "OrdersToConsult.FirstEntraRoleName", "");
ssCurrLevelUserName = r.ReadText(index++, "OrdersToConsult.CurrLevelUserName", "");
ssCurrLevelJobTitle = r.ReadText(index++, "OrdersToConsult.CurrLevelJobTitle", "");
ssCurrEntraRoleName = r.ReadText(index++, "OrdersToConsult.CurrEntraRoleName", "");
ssAssignedOn = r.ReadDateTime(index++, "OrdersToConsult.AssignedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure r) {
this = r;
}


public static bool operator == (ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure a, ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure b) {
if (a.ssOrderMainId != b.ssOrderMainId) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssOrderDate != b.ssOrderDate) return false;
if (a.ssOrderStatus != b.ssOrderStatus) return false;
if (a.ssOrderStatusClass != b.ssOrderStatusClass) return false;
if (a.ssOrderImportDateTime != b.ssOrderImportDateTime) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssTelcelDirection != b.ssTelcelDirection) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssFirstLevelUserName != b.ssFirstLevelUserName) return false;
if (a.ssFirstLevelJobTitle != b.ssFirstLevelJobTitle) return false;
if (a.ssFirstEntraRoleName != b.ssFirstEntraRoleName) return false;
if (a.ssCurrLevelUserName != b.ssCurrLevelUserName) return false;
if (a.ssCurrLevelJobTitle != b.ssCurrLevelJobTitle) return false;
if (a.ssCurrEntraRoleName != b.ssCurrEntraRoleName) return false;
if (a.ssAssignedOn != b.ssAssignedOn) return false;
return true;
}

public static bool operator != (ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure a, ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure)) return false;
return (this == (ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderMainId.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssOrderDate.GetHashCode()
 ^ ssOrderStatus.GetHashCode()
 ^ ssOrderStatusClass.GetHashCode()
 ^ ssOrderImportDateTime.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssTelcelDirection.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssFirstLevelUserName.GetHashCode()
 ^ ssFirstLevelJobTitle.GetHashCode()
 ^ ssFirstEntraRoleName.GetHashCode()
 ^ ssCurrLevelUserName.GetHashCode()
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


public ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure Duplicate() {
ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure t;
t.ssOrderMainId = this.ssOrderMainId;
t.ssOrderNumber = this.ssOrderNumber;
t.ssOrderDate = this.ssOrderDate;
t.ssOrderStatus = this.ssOrderStatus;
t.ssOrderStatusClass = this.ssOrderStatusClass;
t.ssOrderImportDateTime = this.ssOrderImportDateTime;
t.ssRegion = this.ssRegion;
t.ssTelcelDirection = this.ssTelcelDirection;
t.ssSupplierName = this.ssSupplierName;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssFirstLevelUserName = this.ssFirstLevelUserName;
t.ssFirstLevelJobTitle = this.ssFirstLevelJobTitle;
t.ssFirstEntraRoleName = this.ssFirstEntraRoleName;
t.ssCurrLevelUserName = this.ssCurrLevelUserName;
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
if (head == "ordermainid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId")) variable.Value = ssOrderMainId; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "orderdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDate")) variable.Value = ssOrderDate; else variable.Optimized = true;
} else if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssOrderStatus; else variable.Optimized = true;
} else if (head == "orderstatusclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatusClass")) variable.Value = ssOrderStatusClass; else variable.Optimized = true;
} else if (head == "orderimportdatetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderImportDateTime")) variable.Value = ssOrderImportDateTime; else variable.Optimized = true;
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
} else if (head == "firstleveljobtitle") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstLevelJobTitle")) variable.Value = ssFirstLevelJobTitle; else variable.Optimized = true;
} else if (head == "firstentrarolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstEntraRoleName")) variable.Value = ssFirstEntraRoleName; else variable.Optimized = true;
} else if (head == "currlevelusername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrLevelUserName")) variable.Value = ssCurrLevelUserName; else variable.Optimized = true;
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
if (key == IdOrderMainId) {
return ssOrderMainId;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdOrderDate) {
return ssOrderDate;
}
if (key == IdOrderStatus) {
return ssOrderStatus;
}
if (key == IdOrderStatusClass) {
return ssOrderStatusClass;
}
if (key == IdOrderImportDateTime) {
return ssOrderImportDateTime;
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
if (key == IdFirstLevelJobTitle) {
return ssFirstLevelJobTitle;
}
if (key == IdFirstEntraRoleName) {
return ssFirstEntraRoleName;
}
if (key == IdCurrLevelUserName) {
return ssCurrLevelUserName;
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
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssOrderMainId;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdOrderDate.Key.AsGuid) {
return ssOrderDate;
}
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssOrderStatus;
}
if (attributeKey == IdOrderStatusClass.Key.AsGuid) {
return ssOrderStatusClass;
}
if (attributeKey == IdOrderImportDateTime.Key.AsGuid) {
return ssOrderImportDateTime;
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
if (attributeKey == IdFirstLevelJobTitle.Key.AsGuid) {
return ssFirstLevelJobTitle;
}
if (attributeKey == IdFirstEntraRoleName.Key.AsGuid) {
return ssFirstEntraRoleName;
}
if (attributeKey == IdCurrLevelUserName.Key.AsGuid) {
return ssCurrLevelUserName;
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
ssOrderMainId = (long) other.AttributeGet(IdOrderMainId);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssOrderDate = (DateTime) other.AttributeGet(IdOrderDate);
ssOrderStatus = (string) other.AttributeGet(IdOrderStatus);
ssOrderStatusClass = (string) other.AttributeGet(IdOrderStatusClass);
ssOrderImportDateTime = (DateTime) other.AttributeGet(IdOrderImportDateTime);
ssRegion = (string) other.AttributeGet(IdRegion);
ssTelcelDirection = (string) other.AttributeGet(IdTelcelDirection);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssFirstLevelUserName = (string) other.AttributeGet(IdFirstLevelUserName);
ssFirstLevelJobTitle = (string) other.AttributeGet(IdFirstLevelJobTitle);
ssFirstEntraRoleName = (string) other.AttributeGet(IdFirstEntraRoleName);
ssCurrLevelUserName = (string) other.AttributeGet(IdCurrLevelUserName);
ssCurrLevelJobTitle = (string) other.AttributeGet(IdCurrLevelJobTitle);
ssCurrEntraRoleName = (string) other.AttributeGet(IdCurrEntraRoleName);
ssAssignedOn = (DateTime) other.AttributeGet(IdAssignedOn);
}
} // ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure
/// <summary>
/// RecordList type <code>OrdersToConsultList</code> that represents a record list of
///  <code>OrdersToConsult</code>
/// </summary>
public partial class RL_e48e3539313f992e2f1ace5c3cb135f5 : GenericRecordList<ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure>, IEnumerable, IEnumerator {

protected override ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure GetElementDefaultValue() {
return new ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure();
}

public T[] ToArray<T>(Func<ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e48e3539313f992e2f1ace5c3cb135f5 recordList, Func<ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e48e3539313f992e2f1ace5c3cb135f5(ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure[] array) {
  RL_e48e3539313f992e2f1ace5c3cb135f5 result = new RL_e48e3539313f992e2f1ace5c3cb135f5();
result.InnerFromArray(array);
    return result;
}

public static RL_e48e3539313f992e2f1ace5c3cb135f5 ToList<T>(T[] array, Func <T, ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure> converter) {
  RL_e48e3539313f992e2f1ace5c3cb135f5 result = new RL_e48e3539313f992e2f1ace5c3cb135f5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e48e3539313f992e2f1ace5c3cb135f5 FromRestList<T>(RestList<T> restList, Func <T, ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure> converter) {
  RL_e48e3539313f992e2f1ace5c3cb135f5 result = new RL_e48e3539313f992e2f1ace5c3cb135f5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e48e3539313f992e2f1ace5c3cb135f5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1f6eb08d8d1b200d3c17cf7efe59c4dcStructure> NewList() {
return new RL_e48e3539313f992e2f1ace5c3cb135f5();
}


} // RL_e48e3539313f992e2f1ace5c3cb135f5
}

