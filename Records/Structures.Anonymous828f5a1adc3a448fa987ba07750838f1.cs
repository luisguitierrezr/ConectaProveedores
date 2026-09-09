namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GlqPgjrcj0Sph7oHdQg48Q)
///  <code>RC_5a6246801ed2c6cdc40cd9bd72ee2c64</code> that represent
/// s
///  <code>OrderMainItemFolioFolioItemsOrderMainOrderDetailAccountingAccounts_ServiceTypeSupplierCostCen
/// terSAPRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainItemFolioFolioItemsOrderMainOrderDetailAccountingAccounts_ServiceTypeSupplierCostCenterSAPRecord
public partial struct RC_5a6246801ed2c6cdc40cd9bd72ee2c64 : ITypedRecord<RC_5a6246801ed2c6cdc40cd9bd72ee2c64> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tfJh+FJZCU2OCYEVavm3qw");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;


public BitArray OptimizedAttributes;

public RC_5a6246801ed2c6cdc40cd9bd72ee2c64() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(18,false);
    all[3] = new BitArray(29,false);
    all[4] = new BitArray(39,false);
    all[5] = new BitArray(8,false);
    all[6] = new BitArray(28,false);
    all[7] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioItems.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENFolioItems.OptimizedAttributes = value[2];
    ssENOrderMain.OptimizedAttributes = value[3];
    ssENOrderDetail.OptimizedAttributes = value[4];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[5];
    ssENSupplier.OptimizedAttributes = value[6];
    ssENCostCenterSAP.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENFolioItems.OptimizedAttributes;
    all[3] = ssENOrderMain.OptimizedAttributes;
    all[4] = ssENOrderDetail.OptimizedAttributes;
    all[5] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[6] = ssENSupplier.OptimizedAttributes;
    all[7] = ssENCostCenterSAP.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMainItem.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioItems.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
ssENAccountingAccounts_ServiceType.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENCostCenterSAP.Read( r, ref index);
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
public void ReadIM(RC_5a6246801ed2c6cdc40cd9bd72ee2c64 r) {
this = r;
}


public static bool operator == (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 a, RC_5a6246801ed2c6cdc40cd9bd72ee2c64 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioItems != b.ssENFolioItems) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
return true;
}

public static bool operator != (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 a, RC_5a6246801ed2c6cdc40cd9bd72ee2c64 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5a6246801ed2c6cdc40cd9bd72ee2c64)) return false;
return (this == (RC_5a6246801ed2c6cdc40cd9bd72ee2c64)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioItems.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioItems.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssENAccountingAccounts_ServiceType.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioItems.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
}


public RC_5a6246801ed2c6cdc40cd9bd72ee2c64 Duplicate() {
RC_5a6246801ed2c6cdc40cd9bd72ee2c64 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioItems = (EN_868430b5192a8eb1a739e01247fc2704EntityRecord)this.ssENFolioItems.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENCostCenterSAP = (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)this.ssENCostCenterSAP.Duplicate();
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
if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "folioitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioItems")) variable.Value = ssENFolioItems; else variable.Optimized = true;
variable.SetFieldName("folioitems");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "accountingaccounts_servicetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingAccounts_ServiceType")) variable.Value = ssENAccountingAccounts_ServiceType; else variable.Optimized = true;
variable.SetFieldName("accountingaccounts_servicetype");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAP")) variable.Value = ssENCostCenterSAP; else variable.Optimized = true;
variable.SetFieldName("costcentersap");
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
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioItems) {
return ssENFolioItems;
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
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdCostCenterSAP) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioItems.Key.AsGuid) {
return ssENFolioItems;
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
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioItems.FillFromOther((IRecord) other.AttributeGet(IdFolioItems));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
}
} // RC_5a6246801ed2c6cdc40cd9bd72ee2c64
/// <summary>
/// RecordList type
///  <code>OrderMainItemFolioFolioItemsOrderMainOrderDetailAccountingAccounts_ServiceTypeSupplierCostCen
/// terSAPRecordList</code> that represents a record list of <code>OrderMainItem, Folio, FolioItems,
///  OrderMain, OrderDetail, AccountingAccounts_ServiceType, Supplier, CostCenterSAP</code>
/// </summary>
public partial class RL_be0bc7b85db7b39f4a70be07d98b5bef : GenericRecordList<RC_5a6246801ed2c6cdc40cd9bd72ee2c64>, IEnumerable, IEnumerator {

protected override RC_5a6246801ed2c6cdc40cd9bd72ee2c64 GetElementDefaultValue() {
return new RC_5a6246801ed2c6cdc40cd9bd72ee2c64();
}

public T[] ToArray<T>(Func<RC_5a6246801ed2c6cdc40cd9bd72ee2c64, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_be0bc7b85db7b39f4a70be07d98b5bef recordList, Func<RC_5a6246801ed2c6cdc40cd9bd72ee2c64, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_be0bc7b85db7b39f4a70be07d98b5bef(RC_5a6246801ed2c6cdc40cd9bd72ee2c64[] array) {
  RL_be0bc7b85db7b39f4a70be07d98b5bef result = new RL_be0bc7b85db7b39f4a70be07d98b5bef();
result.InnerFromArray(array);
    return result;
}

public static RL_be0bc7b85db7b39f4a70be07d98b5bef ToList<T>(T[] array, Func <T, RC_5a6246801ed2c6cdc40cd9bd72ee2c64> converter) {
  RL_be0bc7b85db7b39f4a70be07d98b5bef result = new RL_be0bc7b85db7b39f4a70be07d98b5bef();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_be0bc7b85db7b39f4a70be07d98b5bef FromRestList<T>(RestList<T> restList, Func <T, RC_5a6246801ed2c6cdc40cd9bd72ee2c64> converter) {
  RL_be0bc7b85db7b39f4a70be07d98b5bef result = new RL_be0bc7b85db7b39f4a70be07d98b5bef();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_be0bc7b85db7b39f4a70be07d98b5bef() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(51,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(18,false);
def[3] = new BitArray(29,false);
def[4] = new BitArray(39,false);
def[5] = new BitArray(8,false);
def[6] = new BitArray(28,false);
def[7] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5a6246801ed2c6cdc40cd9bd72ee2c64> NewList() {
return new RL_be0bc7b85db7b39f4a70be07d98b5bef();
}


} // RL_be0bc7b85db7b39f4a70be07d98b5bef
}

