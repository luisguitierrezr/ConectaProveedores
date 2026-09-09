namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (dXhP8K6DqUaTWc3ZyJPSkw)
///  <code>RC_7001c2850e85d9dc361469a649a88466</code> that represent
/// s
///  <code>CurrencyOrderStatusOrderMainItemOrdersImportRequestOrderMainOrderDetailAccountingAccounts_Ser
/// viceTypeDistributionCompanySupplierCostCenterSAPRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyOrderStatusOrderMainItemOrdersImportRequestOrderMainOrderDetailAccountingAccounts_ServiceTypeDistributionCompanySupplierCostCenterSAPRegionRecord
public partial struct RC_7001c2850e85d9dc361469a649a88466 : ITypedRecord<RC_7001c2850e85d9dc361469a649a88466> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdOrdersImportRequest = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*q7UHJMuyrv6qjabN6kzPEg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdDistribution = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CCJIpkzC5uLJxroW5XsBhQ");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_8c3668a93870461b8ea1216c2848f298EntityRecord ssENOrdersImportRequest;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_88460e7eac2a65d244abb23fe44af0adEntityRecord ssENDistribution;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_7001c2850e85d9dc361469a649a88466() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENOrdersImportRequest = new EN_8c3668a93870461b8ea1216c2848f298EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENDistribution = new EN_88460e7eac2a65d244abb23fe44af0adEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[12];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(51,false);
    all[3] = new BitArray(10,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(39,false);
    all[6] = new BitArray(8,false);
    all[7] = new BitArray(4,false);
    all[8] = new BitArray(11,false);
    all[9] = new BitArray(28,false);
    all[10] = new BitArray(25,false);
    all[11] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrdersImportRequest.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENDistribution.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[10];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[11];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENOrderStatus.OptimizedAttributes = value[1];
    ssENOrderMainItem.OptimizedAttributes = value[2];
    ssENOrdersImportRequest.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENOrderDetail.OptimizedAttributes = value[5];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[6];
    ssENDistribution.OptimizedAttributes = value[7];
    ssENCompany.OptimizedAttributes = value[8];
    ssENSupplier.OptimizedAttributes = value[9];
    ssENCostCenterSAP.OptimizedAttributes = value[10];
    ssENRegion.OptimizedAttributes = value[11];
    }
}
get{
    BitArray[] all = new BitArray[12];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENOrderStatus.OptimizedAttributes;
    all[2] = ssENOrderMainItem.OptimizedAttributes;
    all[3] = ssENOrdersImportRequest.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENOrderDetail.OptimizedAttributes;
    all[6] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[7] = ssENDistribution.OptimizedAttributes;
    all[8] = ssENCompany.OptimizedAttributes;
    all[9] = ssENSupplier.OptimizedAttributes;
    all[10] = ssENCostCenterSAP.OptimizedAttributes;
    all[11] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENOrderStatus.Read( r, ref index);
ssENOrderMainItem.Read( r, ref index);
ssENOrdersImportRequest.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENAccountingAccounts_ServiceType.Read( r, ref index);
ssENDistribution.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENCostCenterSAP.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_7001c2850e85d9dc361469a649a88466 r) {
this = r;
}


public static bool operator == (RC_7001c2850e85d9dc361469a649a88466 a, RC_7001c2850e85d9dc361469a649a88466 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENOrdersImportRequest != b.ssENOrdersImportRequest) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENDistribution != b.ssENDistribution) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_7001c2850e85d9dc361469a649a88466 a, RC_7001c2850e85d9dc361469a649a88466 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7001c2850e85d9dc361469a649a88466)) return false;
return (this == (RC_7001c2850e85d9dc361469a649a88466)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENOrdersImportRequest.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
 ^ ssENDistribution.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENOrderStatus.RecursiveReset();
ssENOrderMainItem.RecursiveReset();
ssENOrdersImportRequest.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENAccountingAccounts_ServiceType.RecursiveReset();
ssENDistribution.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENOrderStatus.InternalRecursiveSave();
ssENOrderMainItem.InternalRecursiveSave();
ssENOrdersImportRequest.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENDistribution.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_7001c2850e85d9dc361469a649a88466 Duplicate() {
RC_7001c2850e85d9dc361469a649a88466 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENOrdersImportRequest = (EN_8c3668a93870461b8ea1216c2848f298EntityRecord)this.ssENOrdersImportRequest.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
t.ssENDistribution = (EN_88460e7eac2a65d244abb23fe44af0adEntityRecord)this.ssENDistribution.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENCostCenterSAP = (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)this.ssENCostCenterSAP.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssENOrderStatus; else variable.Optimized = true;
variable.SetFieldName("orderstatus");
} else if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
} else if (head == "ordersimportrequest") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersImportRequest")) variable.Value = ssENOrdersImportRequest; else variable.Optimized = true;
variable.SetFieldName("ordersimportrequest");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "accountingaccounts_servicetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingAccounts_ServiceType")) variable.Value = ssENAccountingAccounts_ServiceType; else variable.Optimized = true;
variable.SetFieldName("accountingaccounts_servicetype");
} else if (head == "distribution") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Distribution")) variable.Value = ssENDistribution; else variable.Optimized = true;
variable.SetFieldName("distribution");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAP")) variable.Value = ssENCostCenterSAP; else variable.Optimized = true;
variable.SetFieldName("costcentersap");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdOrderStatus) {
return ssENOrderStatus;
}
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdOrdersImportRequest) {
return ssENOrdersImportRequest;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdAccountingAccounts_ServiceType) {
return ssENAccountingAccounts_ServiceType;
}
if (key == IdDistribution) {
return ssENDistribution;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdCostCenterSAP) {
return ssENCostCenterSAP;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdOrdersImportRequest.Key.AsGuid) {
return ssENOrdersImportRequest;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdAccountingAccounts_ServiceType.Key.AsGuid) {
return ssENAccountingAccounts_ServiceType;
}
if (attributeKey == IdDistribution.Key.AsGuid) {
return ssENDistribution;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENOrdersImportRequest.FillFromOther((IRecord) other.AttributeGet(IdOrdersImportRequest));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
ssENDistribution.FillFromOther((IRecord) other.AttributeGet(IdDistribution));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_7001c2850e85d9dc361469a649a88466
/// <summary>
/// RecordList type
///  <code>CurrencyOrderStatusOrderMainItemOrdersImportRequestOrderMainOrderDetailAccountingAccounts_Ser
/// viceTypeDistributionCompanySupplierCostCenterSAPRegionRecordList</code> that represents a record
///  list of <code>Currency, OrderStatus, OrderMainItem, OrdersImportRequest, OrderMain, OrderDetail
/// , AccountingAccounts_ServiceType, Distribution, Company, Supplier, CostCenterSAP, Region</code>
/// </summary>
public partial class RL_1ded8df557cc19c3bf639ef70eaf909e : GenericRecordList<RC_7001c2850e85d9dc361469a649a88466>, IEnumerable, IEnumerator {

protected override RC_7001c2850e85d9dc361469a649a88466 GetElementDefaultValue() {
return new RC_7001c2850e85d9dc361469a649a88466();
}

public T[] ToArray<T>(Func<RC_7001c2850e85d9dc361469a649a88466, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1ded8df557cc19c3bf639ef70eaf909e recordList, Func<RC_7001c2850e85d9dc361469a649a88466, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1ded8df557cc19c3bf639ef70eaf909e(RC_7001c2850e85d9dc361469a649a88466[] array) {
  RL_1ded8df557cc19c3bf639ef70eaf909e result = new RL_1ded8df557cc19c3bf639ef70eaf909e();
result.InnerFromArray(array);
    return result;
}

public static RL_1ded8df557cc19c3bf639ef70eaf909e ToList<T>(T[] array, Func <T, RC_7001c2850e85d9dc361469a649a88466> converter) {
  RL_1ded8df557cc19c3bf639ef70eaf909e result = new RL_1ded8df557cc19c3bf639ef70eaf909e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1ded8df557cc19c3bf639ef70eaf909e FromRestList<T>(RestList<T> restList, Func <T, RC_7001c2850e85d9dc361469a649a88466> converter) {
  RL_1ded8df557cc19c3bf639ef70eaf909e result = new RL_1ded8df557cc19c3bf639ef70eaf909e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1ded8df557cc19c3bf639ef70eaf909e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[12];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(51,false);
def[3] = new BitArray(10,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(39,false);
def[6] = new BitArray(8,false);
def[7] = new BitArray(4,false);
def[8] = new BitArray(11,false);
def[9] = new BitArray(28,false);
def[10] = new BitArray(25,false);
def[11] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7001c2850e85d9dc361469a649a88466> NewList() {
return new RL_1ded8df557cc19c3bf639ef70eaf909e();
}


} // RL_1ded8df557cc19c3bf639ef70eaf909e
}

