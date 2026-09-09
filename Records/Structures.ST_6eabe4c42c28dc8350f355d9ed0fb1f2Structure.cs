namespace ssConectaProveedores {
/// <summary>
/// [Structure] LinesReport62 (XkCG0mxj5k64jKCUTnfjIw)
///  <code>ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure</code> that represent
/// s <code>LinesReport62</code> <p>Description: </p>
/// </summary>
// Name: LinesReport62
public partial struct ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure : ITypedRecord<ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure> {
internal static readonly GlobalObjectKey IdInvoiceNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Hr2F_07QrEmmGwNFCD7djw");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wTYvB4OVQUuuGAbs1TwDzQ");
internal static readonly GlobalObjectKey IdAccountingDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*c9Kbh41q3kOIGbX+_Kg+RQ");
internal static readonly GlobalObjectKey IdAccountingUser = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hYFz+mUEaUC17d0DJ_Flbg");
internal static readonly GlobalObjectKey IdEmployedNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LAv4WhI2b0GQYybMirXNiQ");
internal static readonly GlobalObjectKey IdDocNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jB0r3QxCZUGFjYilU32w5A");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PIxJvaAUUEiBOSGNGQWiNQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*giI2FJa9K0WKtgtg5uYnuA");
internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wVLtF4YT+0CpK8FjzVWp1Q");
internal static readonly GlobalObjectKey IdManagement = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*96BmEZnzcEeSYA0BQjKtwg");
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UN+ngNn_H06oE7AoeV65fA");
internal static readonly GlobalObjectKey IdInvoiceCreationDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*uvs24qgSkUWMM4QB6eJnHQ");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*OZVggcxTmk2ty86jHSCg2A");
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ORi8SnAvmEGvXzZvKgUSvw");
internal static readonly GlobalObjectKey IdPaymentDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*26iRs0FffUGH1IdK1WWmow");
internal static readonly GlobalObjectKey IdExchangeType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NKrYh69A8UeNTrKB19zc5w");

public string ssInvoiceNumber;

public decimal ssTotalAmount;

public string ssAccountingDate;

public string ssAccountingUser;

public string ssEmployedNumber;

public string ssDocNumber;

public string ssSupplierNumber;

public string ssRegion;

public string ssDepartment;

public string ssManagement;

public string ssDirection;

public string ssInvoiceCreationDate;

public string ssCurrency;

public string ssSupplierName;

public string ssPaymentDate;

public string ssExchangeType;


public BitArray OptimizedAttributes;

public ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure() {
OptimizedAttributes = null;
ssInvoiceNumber = "";
ssTotalAmount = 0.0M;
ssAccountingDate = "";
ssAccountingUser = "";
ssEmployedNumber = "";
ssDocNumber = "";
ssSupplierNumber = "";
ssRegion = "";
ssDepartment = "";
ssManagement = "";
ssDirection = "";
ssInvoiceCreationDate = "";
ssCurrency = "";
ssSupplierName = "";
ssPaymentDate = "";
ssExchangeType = "";
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
ssInvoiceNumber = r.ReadText(index++, "LinesReport62.InvoiceNumber", "");
ssTotalAmount = r.ReadDecimal(index++, "LinesReport62.TotalAmount", 0.0M);
ssAccountingDate = r.ReadText(index++, "LinesReport62.AccountingDate", "");
ssAccountingUser = r.ReadText(index++, "LinesReport62.AccountingUser", "");
ssEmployedNumber = r.ReadText(index++, "LinesReport62.EmployedNumber", "");
ssDocNumber = r.ReadText(index++, "LinesReport62.DocNumber", "");
ssSupplierNumber = r.ReadText(index++, "LinesReport62.SupplierNumber", "");
ssRegion = r.ReadText(index++, "LinesReport62.Region", "");
ssDepartment = r.ReadText(index++, "LinesReport62.Department", "");
ssManagement = r.ReadText(index++, "LinesReport62.Management", "");
ssDirection = r.ReadText(index++, "LinesReport62.Direction", "");
ssInvoiceCreationDate = r.ReadText(index++, "LinesReport62.InvoiceCreationDate", "");
ssCurrency = r.ReadText(index++, "LinesReport62.Currency", "");
ssSupplierName = r.ReadText(index++, "LinesReport62.SupplierName", "");
ssPaymentDate = r.ReadText(index++, "LinesReport62.PaymentDate", "");
ssExchangeType = r.ReadText(index++, "LinesReport62.ExchangeType", "");
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
public void ReadIM(ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure r) {
this = r;
}


public static bool operator == (ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure a, ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure b) {
if (a.ssInvoiceNumber != b.ssInvoiceNumber) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssAccountingDate != b.ssAccountingDate) return false;
if (a.ssAccountingUser != b.ssAccountingUser) return false;
if (a.ssEmployedNumber != b.ssEmployedNumber) return false;
if (a.ssDocNumber != b.ssDocNumber) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssDepartment != b.ssDepartment) return false;
if (a.ssManagement != b.ssManagement) return false;
if (a.ssDirection != b.ssDirection) return false;
if (a.ssInvoiceCreationDate != b.ssInvoiceCreationDate) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssPaymentDate != b.ssPaymentDate) return false;
if (a.ssExchangeType != b.ssExchangeType) return false;
return true;
}

public static bool operator != (ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure a, ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure)) return false;
return (this == (ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceNumber.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssAccountingDate.GetHashCode()
 ^ ssAccountingUser.GetHashCode()
 ^ ssEmployedNumber.GetHashCode()
 ^ ssDocNumber.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssDepartment.GetHashCode()
 ^ ssManagement.GetHashCode()
 ^ ssDirection.GetHashCode()
 ^ ssInvoiceCreationDate.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssPaymentDate.GetHashCode()
 ^ ssExchangeType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure Duplicate() {
ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure t;
t.ssInvoiceNumber = this.ssInvoiceNumber;
t.ssTotalAmount = this.ssTotalAmount;
t.ssAccountingDate = this.ssAccountingDate;
t.ssAccountingUser = this.ssAccountingUser;
t.ssEmployedNumber = this.ssEmployedNumber;
t.ssDocNumber = this.ssDocNumber;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssRegion = this.ssRegion;
t.ssDepartment = this.ssDepartment;
t.ssManagement = this.ssManagement;
t.ssDirection = this.ssDirection;
t.ssInvoiceCreationDate = this.ssInvoiceCreationDate;
t.ssCurrency = this.ssCurrency;
t.ssSupplierName = this.ssSupplierName;
t.ssPaymentDate = this.ssPaymentDate;
t.ssExchangeType = this.ssExchangeType;
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
if (head == "invoicenumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceNumber")) variable.Value = ssInvoiceNumber; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "accountingdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDate")) variable.Value = ssAccountingDate; else variable.Optimized = true;
} else if (head == "accountinguser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingUser")) variable.Value = ssAccountingUser; else variable.Optimized = true;
} else if (head == "employednumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EmployedNumber")) variable.Value = ssEmployedNumber; else variable.Optimized = true;
} else if (head == "docnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocNumber")) variable.Value = ssDocNumber; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "department") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssDepartment; else variable.Optimized = true;
} else if (head == "management") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Management")) variable.Value = ssManagement; else variable.Optimized = true;
} else if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "invoicecreationdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceCreationDate")) variable.Value = ssInvoiceCreationDate; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "suppliername") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierName")) variable.Value = ssSupplierName; else variable.Optimized = true;
} else if (head == "paymentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDate")) variable.Value = ssPaymentDate; else variable.Optimized = true;
} else if (head == "exchangetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExchangeType")) variable.Value = ssExchangeType; else variable.Optimized = true;
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
if (key == IdInvoiceNumber) {
return ssInvoiceNumber;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdAccountingDate) {
return ssAccountingDate;
}
if (key == IdAccountingUser) {
return ssAccountingUser;
}
if (key == IdEmployedNumber) {
return ssEmployedNumber;
}
if (key == IdDocNumber) {
return ssDocNumber;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdDepartment) {
return ssDepartment;
}
if (key == IdManagement) {
return ssManagement;
}
if (key == IdDirection) {
return ssDirection;
}
if (key == IdInvoiceCreationDate) {
return ssInvoiceCreationDate;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdSupplierName) {
return ssSupplierName;
}
if (key == IdPaymentDate) {
return ssPaymentDate;
}
if (key == IdExchangeType) {
return ssExchangeType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceNumber.Key.AsGuid) {
return ssInvoiceNumber;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdAccountingDate.Key.AsGuid) {
return ssAccountingDate;
}
if (attributeKey == IdAccountingUser.Key.AsGuid) {
return ssAccountingUser;
}
if (attributeKey == IdEmployedNumber.Key.AsGuid) {
return ssEmployedNumber;
}
if (attributeKey == IdDocNumber.Key.AsGuid) {
return ssDocNumber;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdDepartment.Key.AsGuid) {
return ssDepartment;
}
if (attributeKey == IdManagement.Key.AsGuid) {
return ssManagement;
}
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
}
if (attributeKey == IdInvoiceCreationDate.Key.AsGuid) {
return ssInvoiceCreationDate;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdPaymentDate.Key.AsGuid) {
return ssPaymentDate;
}
if (attributeKey == IdExchangeType.Key.AsGuid) {
return ssExchangeType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceNumber = (string) other.AttributeGet(IdInvoiceNumber);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ssAccountingDate = (string) other.AttributeGet(IdAccountingDate);
ssAccountingUser = (string) other.AttributeGet(IdAccountingUser);
ssEmployedNumber = (string) other.AttributeGet(IdEmployedNumber);
ssDocNumber = (string) other.AttributeGet(IdDocNumber);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssRegion = (string) other.AttributeGet(IdRegion);
ssDepartment = (string) other.AttributeGet(IdDepartment);
ssManagement = (string) other.AttributeGet(IdManagement);
ssDirection = (string) other.AttributeGet(IdDirection);
ssInvoiceCreationDate = (string) other.AttributeGet(IdInvoiceCreationDate);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssPaymentDate = (string) other.AttributeGet(IdPaymentDate);
ssExchangeType = (string) other.AttributeGet(IdExchangeType);
}
} // ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure
/// <summary>
/// RecordList type <code>LinesReport62List</code> that represents a record list of
///  <code>LinesReport62</code>
/// </summary>
public partial class RL_24b2300ac02e220a1b13ce501090881d : GenericRecordList<ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure>, IEnumerable, IEnumerator {

protected override ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure GetElementDefaultValue() {
return new ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure();
}

public T[] ToArray<T>(Func<ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_24b2300ac02e220a1b13ce501090881d recordList, Func<ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_24b2300ac02e220a1b13ce501090881d(ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure[] array) {
  RL_24b2300ac02e220a1b13ce501090881d result = new RL_24b2300ac02e220a1b13ce501090881d();
result.InnerFromArray(array);
    return result;
}

public static RL_24b2300ac02e220a1b13ce501090881d ToList<T>(T[] array, Func <T, ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure> converter) {
  RL_24b2300ac02e220a1b13ce501090881d result = new RL_24b2300ac02e220a1b13ce501090881d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_24b2300ac02e220a1b13ce501090881d FromRestList<T>(RestList<T> restList, Func <T, ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure> converter) {
  RL_24b2300ac02e220a1b13ce501090881d result = new RL_24b2300ac02e220a1b13ce501090881d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_24b2300ac02e220a1b13ce501090881d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6eabe4c42c28dc8350f355d9ed0fb1f2Structure> NewList() {
return new RL_24b2300ac02e220a1b13ce501090881d();
}


} // RL_24b2300ac02e220a1b13ce501090881d
}

