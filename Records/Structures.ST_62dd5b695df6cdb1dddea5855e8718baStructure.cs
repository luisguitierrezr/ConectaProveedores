namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioDetailInfo (vB8yCCCI8UGisgC6L+OENw)
///  <code>ST_62dd5b695df6cdb1dddea5855e8718baStructure</code> that represent
/// s <code>FolioDetailInfo</code> <p>Description: </p>
/// </summary>
// Name: FolioDetailInfo
public partial struct ST_62dd5b695df6cdb1dddea5855e8718baStructure : ITypedRecord<ST_62dd5b695df6cdb1dddea5855e8718baStructure> {
internal static readonly GlobalObjectKey IdSupplierName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xsZZoh1HHUOPogndZD4e3w");
internal static readonly GlobalObjectKey IdSupplierRFC = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7Ord6Ea50k2w9UKNPMOBHQ");
internal static readonly GlobalObjectKey IdSupplierNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*T3ih_DnfyECyhy355Zl7lQ");
internal static readonly GlobalObjectKey IdSupplierRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LoKaa7lLDE2YdHKtIs1a6A");
internal static readonly GlobalObjectKey IdCompanyName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3fVbq2nQMUqRJVTuYXCegQ");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_d2ZTGFSrUair3JtJP2zHg");
internal static readonly GlobalObjectKey IdCurrencyCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QDU0hZ1K0km8lSim2n02wg");
internal static readonly GlobalObjectKey IdCurrencyText = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YoX3YhQheUCnZc3esXN83w");
internal static readonly GlobalObjectKey IdCreationDays = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YE8JL3l6A0O+MAjAKUi7Yg");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_nRFQ9nqy02ZdFVInY7yQA");
internal static readonly GlobalObjectKey IdFlux = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ga7QITSrKEaK+_I+6A6fwA");
internal static readonly GlobalObjectKey IdFluxType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Hul2ho7rO0+_ReM2nEWXzg");

public string ssSupplierName;

public string ssSupplierRFC;

public string ssSupplierNumber;

public string ssSupplierRegion;

public string ssCompanyName;

public string ssOrderNumber;

public string ssCurrencyCode;

public string ssCurrencyText;

public int ssCreationDays;

public decimal ssTotalAmount;

public string ssFlux;

public string ssFluxType;


public BitArray OptimizedAttributes;

public ST_62dd5b695df6cdb1dddea5855e8718baStructure() {
OptimizedAttributes = null;
ssSupplierName = "";
ssSupplierRFC = "";
ssSupplierNumber = "";
ssSupplierRegion = "";
ssCompanyName = "";
ssOrderNumber = "";
ssCurrencyCode = "";
ssCurrencyText = "";
ssCreationDays = 0;
ssTotalAmount = 0.0M;
ssFlux = "";
ssFluxType = "";
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
ssSupplierName = r.ReadText(index++, "FolioDetailInfo.SupplierName", "");
ssSupplierRFC = r.ReadText(index++, "FolioDetailInfo.SupplierRFC", "");
ssSupplierNumber = r.ReadText(index++, "FolioDetailInfo.SupplierNumber", "");
ssSupplierRegion = r.ReadText(index++, "FolioDetailInfo.SupplierRegion", "");
ssCompanyName = r.ReadText(index++, "FolioDetailInfo.CompanyName", "");
ssOrderNumber = r.ReadText(index++, "FolioDetailInfo.OrderNumber", "");
ssCurrencyCode = r.ReadText(index++, "FolioDetailInfo.CurrencyCode", "");
ssCurrencyText = r.ReadText(index++, "FolioDetailInfo.CurrencyText", "");
ssCreationDays = r.ReadInteger(index++, "FolioDetailInfo.CreationDays", 0);
ssTotalAmount = r.ReadDecimal(index++, "FolioDetailInfo.TotalAmount", 0.0M);
ssFlux = r.ReadText(index++, "FolioDetailInfo.Flux", "");
ssFluxType = r.ReadText(index++, "FolioDetailInfo.FluxType", "");
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
public void ReadIM(ST_62dd5b695df6cdb1dddea5855e8718baStructure r) {
this = r;
}


public static bool operator == (ST_62dd5b695df6cdb1dddea5855e8718baStructure a, ST_62dd5b695df6cdb1dddea5855e8718baStructure b) {
if (a.ssSupplierName != b.ssSupplierName) return false;
if (a.ssSupplierRFC != b.ssSupplierRFC) return false;
if (a.ssSupplierNumber != b.ssSupplierNumber) return false;
if (a.ssSupplierRegion != b.ssSupplierRegion) return false;
if (a.ssCompanyName != b.ssCompanyName) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
if (a.ssCurrencyCode != b.ssCurrencyCode) return false;
if (a.ssCurrencyText != b.ssCurrencyText) return false;
if (a.ssCreationDays != b.ssCreationDays) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
if (a.ssFlux != b.ssFlux) return false;
if (a.ssFluxType != b.ssFluxType) return false;
return true;
}

public static bool operator != (ST_62dd5b695df6cdb1dddea5855e8718baStructure a, ST_62dd5b695df6cdb1dddea5855e8718baStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_62dd5b695df6cdb1dddea5855e8718baStructure)) return false;
return (this == (ST_62dd5b695df6cdb1dddea5855e8718baStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSupplierName.GetHashCode()
 ^ ssSupplierRFC.GetHashCode()
 ^ ssSupplierNumber.GetHashCode()
 ^ ssSupplierRegion.GetHashCode()
 ^ ssCompanyName.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
 ^ ssCurrencyCode.GetHashCode()
 ^ ssCurrencyText.GetHashCode()
 ^ ssCreationDays.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
 ^ ssFlux.GetHashCode()
 ^ ssFluxType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_62dd5b695df6cdb1dddea5855e8718baStructure Duplicate() {
ST_62dd5b695df6cdb1dddea5855e8718baStructure t;
t.ssSupplierName = this.ssSupplierName;
t.ssSupplierRFC = this.ssSupplierRFC;
t.ssSupplierNumber = this.ssSupplierNumber;
t.ssSupplierRegion = this.ssSupplierRegion;
t.ssCompanyName = this.ssCompanyName;
t.ssOrderNumber = this.ssOrderNumber;
t.ssCurrencyCode = this.ssCurrencyCode;
t.ssCurrencyText = this.ssCurrencyText;
t.ssCreationDays = this.ssCreationDays;
t.ssTotalAmount = this.ssTotalAmount;
t.ssFlux = this.ssFlux;
t.ssFluxType = this.ssFluxType;
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
} else if (head == "supplierrfc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierRFC")) variable.Value = ssSupplierRFC; else variable.Optimized = true;
} else if (head == "suppliernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierNumber")) variable.Value = ssSupplierNumber; else variable.Optimized = true;
} else if (head == "supplierregion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierRegion")) variable.Value = ssSupplierRegion; else variable.Optimized = true;
} else if (head == "companyname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyName")) variable.Value = ssCompanyName; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
} else if (head == "currencycode") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyCode")) variable.Value = ssCurrencyCode; else variable.Optimized = true;
} else if (head == "currencytext") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyText")) variable.Value = ssCurrencyText; else variable.Optimized = true;
} else if (head == "creationdays") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreationDays")) variable.Value = ssCreationDays; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
} else if (head == "flux") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Flux")) variable.Value = ssFlux; else variable.Optimized = true;
} else if (head == "fluxtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FluxType")) variable.Value = ssFluxType; else variable.Optimized = true;
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
if (key == IdSupplierRFC) {
return ssSupplierRFC;
}
if (key == IdSupplierNumber) {
return ssSupplierNumber;
}
if (key == IdSupplierRegion) {
return ssSupplierRegion;
}
if (key == IdCompanyName) {
return ssCompanyName;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
}
if (key == IdCurrencyCode) {
return ssCurrencyCode;
}
if (key == IdCurrencyText) {
return ssCurrencyText;
}
if (key == IdCreationDays) {
return ssCreationDays;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
if (key == IdFlux) {
return ssFlux;
}
if (key == IdFluxType) {
return ssFluxType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSupplierName.Key.AsGuid) {
return ssSupplierName;
}
if (attributeKey == IdSupplierRFC.Key.AsGuid) {
return ssSupplierRFC;
}
if (attributeKey == IdSupplierNumber.Key.AsGuid) {
return ssSupplierNumber;
}
if (attributeKey == IdSupplierRegion.Key.AsGuid) {
return ssSupplierRegion;
}
if (attributeKey == IdCompanyName.Key.AsGuid) {
return ssCompanyName;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
if (attributeKey == IdCurrencyCode.Key.AsGuid) {
return ssCurrencyCode;
}
if (attributeKey == IdCurrencyText.Key.AsGuid) {
return ssCurrencyText;
}
if (attributeKey == IdCreationDays.Key.AsGuid) {
return ssCreationDays;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
if (attributeKey == IdFlux.Key.AsGuid) {
return ssFlux;
}
if (attributeKey == IdFluxType.Key.AsGuid) {
return ssFluxType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSupplierName = (string) other.AttributeGet(IdSupplierName);
ssSupplierRFC = (string) other.AttributeGet(IdSupplierRFC);
ssSupplierNumber = (string) other.AttributeGet(IdSupplierNumber);
ssSupplierRegion = (string) other.AttributeGet(IdSupplierRegion);
ssCompanyName = (string) other.AttributeGet(IdCompanyName);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
ssCurrencyCode = (string) other.AttributeGet(IdCurrencyCode);
ssCurrencyText = (string) other.AttributeGet(IdCurrencyText);
ssCreationDays = (int) other.AttributeGet(IdCreationDays);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
ssFlux = (string) other.AttributeGet(IdFlux);
ssFluxType = (string) other.AttributeGet(IdFluxType);
}
} // ST_62dd5b695df6cdb1dddea5855e8718baStructure
/// <summary>
/// RecordList type <code>FolioDetailInfoList</code> that represents a record list of
///  <code>FolioDetailInfo</code>
/// </summary>
public partial class RL_421e1466e87a9402130fb7dd1b31621f : GenericRecordList<ST_62dd5b695df6cdb1dddea5855e8718baStructure>, IEnumerable, IEnumerator {

protected override ST_62dd5b695df6cdb1dddea5855e8718baStructure GetElementDefaultValue() {
return new ST_62dd5b695df6cdb1dddea5855e8718baStructure();
}

public T[] ToArray<T>(Func<ST_62dd5b695df6cdb1dddea5855e8718baStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_421e1466e87a9402130fb7dd1b31621f recordList, Func<ST_62dd5b695df6cdb1dddea5855e8718baStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_421e1466e87a9402130fb7dd1b31621f(ST_62dd5b695df6cdb1dddea5855e8718baStructure[] array) {
  RL_421e1466e87a9402130fb7dd1b31621f result = new RL_421e1466e87a9402130fb7dd1b31621f();
result.InnerFromArray(array);
    return result;
}

public static RL_421e1466e87a9402130fb7dd1b31621f ToList<T>(T[] array, Func <T, ST_62dd5b695df6cdb1dddea5855e8718baStructure> converter) {
  RL_421e1466e87a9402130fb7dd1b31621f result = new RL_421e1466e87a9402130fb7dd1b31621f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_421e1466e87a9402130fb7dd1b31621f FromRestList<T>(RestList<T> restList, Func <T, ST_62dd5b695df6cdb1dddea5855e8718baStructure> converter) {
  RL_421e1466e87a9402130fb7dd1b31621f result = new RL_421e1466e87a9402130fb7dd1b31621f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_421e1466e87a9402130fb7dd1b31621f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_62dd5b695df6cdb1dddea5855e8718baStructure> NewList() {
return new RL_421e1466e87a9402130fb7dd1b31621f();
}


} // RL_421e1466e87a9402130fb7dd1b31621f
}

