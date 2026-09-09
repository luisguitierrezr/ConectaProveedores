namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrderListTableStructure (rJzNUO3Gm0OTvQu+CQueow)
///  <code>ST_00c299856fb2c1322ea33527b24c9dd0Structure</code> that represent
/// s <code>OrderListTableStructure</code> <p>Description: </p>
/// </summary>
// Name: OrderListTableStructure
public partial struct ST_00c299856fb2c1322ea33527b24c9dd0Structure : ITypedRecord<ST_00c299856fb2c1322ea33527b24c9dd0Structure> {
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+PkxuHQkBEqp5jCcCM2idw");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pMD6cpc63k2M7c0j94jzNA");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*f+gAxpxB1UWAnxb5Qmn2zA");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*T5obyHOxE0Sw5hz_+WrDRg");
internal static readonly GlobalObjectKey IdSupplierName_Number = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5qIgaAE9nU6rm1TnwbGFaA");
internal static readonly GlobalObjectKey IdBuyer = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nrLdNtgRV0Cl67OgqZ9p3A");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vp5Z5rm7MEiubJnZLVCJrw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*RIBoiQayukqv5E4fPOnehg");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FDHNmcTaKku+vpq08rCP2g");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*l4lIfGJRu02PrAoDOHgcXQ");

public long ssOrderMainId;

public string ssApprovalStatus;

public string ssOrderNumber;

public string ssOrderStatus;

public string ssSupplierName_Number;

public string ssBuyer;

public string ssCompany;

public string ssRegion;

public string ssCurrency;

public string ssTotalAmount;


public BitArray OptimizedAttributes;

public ST_00c299856fb2c1322ea33527b24c9dd0Structure() {
OptimizedAttributes = null;
ssOrderMainId = 0L;
ssApprovalStatus = "";
ssOrderNumber = "";
ssOrderStatus = "";
ssSupplierName_Number = "";
ssBuyer = "";
ssCompany = "";
ssRegion = "";
ssCurrency = "";
ssTotalAmount = "";
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
ssOrderMainId = r.ReadEntityReferenceLongInteger(index++, "OrderListTableStructure.OrderMainId", 0L);
ssApprovalStatus = r.ReadText(index++, "OrderListTableStructure.ApprovalStatus", "");
ssOrderNumber = r.ReadText(index++, "OrderListTableStructure.OrderNumber", "");
ssOrderStatus = r.ReadText(index++, "OrderListTableStructure.OrderStatus", "");
ssSupplierName_Number = r.ReadText(index++, "OrderListTableStructure.SupplierName_Number", "");
ssBuyer = r.ReadText(index++, "OrderListTableStructure.Buyer", "");
ssCompany = r.ReadText(index++, "OrderListTableStructure.Company", "");
ssRegion = r.ReadText(index++, "OrderListTableStructure.Region", "");
ssCurrency = r.ReadText(index++, "OrderListTableStructure.Currency", "");
ssTotalAmount = r.ReadText(index++, "OrderListTableStructure.TotalAmount", "");
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
public void ReadIM(ST_00c299856fb2c1322ea33527b24c9dd0Structure r) {
this = r;
}


public static bool operator == (ST_00c299856fb2c1322ea33527b24c9dd0Structure a, ST_00c299856fb2c1322ea33527b24c9dd0Structure b) {
if (a.ssOrderMainId != b.ssOrderMainId) return false;
if (a.ssApprovalStatus != b.ssApprovalStatus) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssOrderStatus != b.ssOrderStatus) return false;
if (a.ssSupplierName_Number != b.ssSupplierName_Number) return false;
if (a.ssBuyer != b.ssBuyer) return false;
if (a.ssCompany != b.ssCompany) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
return true;
}

public static bool operator != (ST_00c299856fb2c1322ea33527b24c9dd0Structure a, ST_00c299856fb2c1322ea33527b24c9dd0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_00c299856fb2c1322ea33527b24c9dd0Structure)) return false;
return (this == (ST_00c299856fb2c1322ea33527b24c9dd0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderMainId.GetHashCode()
 ^ ssApprovalStatus.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssOrderStatus.GetHashCode()
 ^ ssSupplierName_Number.GetHashCode()
 ^ ssBuyer.GetHashCode()
 ^ ssCompany.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_00c299856fb2c1322ea33527b24c9dd0Structure Duplicate() {
ST_00c299856fb2c1322ea33527b24c9dd0Structure t;
t.ssOrderMainId = this.ssOrderMainId;
t.ssApprovalStatus = this.ssApprovalStatus;
t.ssOrderNumber = this.ssOrderNumber;
t.ssOrderStatus = this.ssOrderStatus;
t.ssSupplierName_Number = this.ssSupplierName_Number;
t.ssBuyer = this.ssBuyer;
t.ssCompany = this.ssCompany;
t.ssRegion = this.ssRegion;
t.ssCurrency = this.ssCurrency;
t.ssTotalAmount = this.ssTotalAmount;
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
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssApprovalStatus; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssOrderStatus; else variable.Optimized = true;
} else if (head == "suppliername_number") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName_Number")) variable.Value = ssSupplierName_Number; else variable.Optimized = true;
} else if (head == "buyer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Buyer")) variable.Value = ssBuyer; else variable.Optimized = true;
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssCompany; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
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
if (key == IdApprovalStatus) {
return ssApprovalStatus;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdOrderStatus) {
return ssOrderStatus;
}
if (key == IdSupplierName_Number) {
return ssSupplierName_Number;
}
if (key == IdBuyer) {
return ssBuyer;
}
if (key == IdCompany) {
return ssCompany;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssOrderMainId;
}
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssApprovalStatus;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssOrderStatus;
}
if (attributeKey == IdSupplierName_Number.Key.AsGuid) {
return ssSupplierName_Number;
}
if (attributeKey == IdBuyer.Key.AsGuid) {
return ssBuyer;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssCompany;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderMainId = (long) other.AttributeGet(IdOrderMainId);
ssApprovalStatus = (string) other.AttributeGet(IdApprovalStatus);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssOrderStatus = (string) other.AttributeGet(IdOrderStatus);
ssSupplierName_Number = (string) other.AttributeGet(IdSupplierName_Number);
ssBuyer = (string) other.AttributeGet(IdBuyer);
ssCompany = (string) other.AttributeGet(IdCompany);
ssRegion = (string) other.AttributeGet(IdRegion);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssTotalAmount = (string) other.AttributeGet(IdTotalAmount);
}
} // ST_00c299856fb2c1322ea33527b24c9dd0Structure
/// <summary>
/// RecordList type <code>OrderListTableStructureList</code> that represents a record list of
///  <code>OrderListTableStructure</code>
/// </summary>
public partial class RL_68002bbb4e227fd5533d460e5a56bbd4 : GenericRecordList<ST_00c299856fb2c1322ea33527b24c9dd0Structure>, IEnumerable, IEnumerator {

protected override ST_00c299856fb2c1322ea33527b24c9dd0Structure GetElementDefaultValue() {
return new ST_00c299856fb2c1322ea33527b24c9dd0Structure();
}

public T[] ToArray<T>(Func<ST_00c299856fb2c1322ea33527b24c9dd0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_68002bbb4e227fd5533d460e5a56bbd4 recordList, Func<ST_00c299856fb2c1322ea33527b24c9dd0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_68002bbb4e227fd5533d460e5a56bbd4(ST_00c299856fb2c1322ea33527b24c9dd0Structure[] array) {
  RL_68002bbb4e227fd5533d460e5a56bbd4 result = new RL_68002bbb4e227fd5533d460e5a56bbd4();
result.InnerFromArray(array);
    return result;
}

public static RL_68002bbb4e227fd5533d460e5a56bbd4 ToList<T>(T[] array, Func <T, ST_00c299856fb2c1322ea33527b24c9dd0Structure> converter) {
  RL_68002bbb4e227fd5533d460e5a56bbd4 result = new RL_68002bbb4e227fd5533d460e5a56bbd4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_68002bbb4e227fd5533d460e5a56bbd4 FromRestList<T>(RestList<T> restList, Func <T, ST_00c299856fb2c1322ea33527b24c9dd0Structure> converter) {
  RL_68002bbb4e227fd5533d460e5a56bbd4 result = new RL_68002bbb4e227fd5533d460e5a56bbd4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_68002bbb4e227fd5533d460e5a56bbd4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_00c299856fb2c1322ea33527b24c9dd0Structure> NewList() {
return new RL_68002bbb4e227fd5533d460e5a56bbd4();
}


} // RL_68002bbb4e227fd5533d460e5a56bbd4
}

