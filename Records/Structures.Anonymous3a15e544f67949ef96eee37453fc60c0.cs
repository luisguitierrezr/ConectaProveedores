namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ROUVOnn270mW7uN0U_xgwA)
///  <code>RC_082bf66064d5a51dc7db708fe5577120</code> that represent
/// s <code>OrderMainItemFolioItemsAccountingAccounts_ServiceTypeCostCenterSAPRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: OrderMainItemFolioItemsAccountingAccounts_ServiceTypeCostCenterSAPRegionRecord
public partial struct RC_082bf66064d5a51dc7db708fe5577120 : ITypedRecord<RC_082bf66064d5a51dc7db708fe5577120> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdFolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tfJh+FJZCU2OCYEVavm3qw");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_082bf66064d5a51dc7db708fe5577120() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(18,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(25,false);
    all[4] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioItems.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENFolioItems.OptimizedAttributes = value[1];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[2];
    ssENCostCenterSAP.OptimizedAttributes = value[3];
    ssENRegion.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENFolioItems.OptimizedAttributes;
    all[2] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[3] = ssENCostCenterSAP.OptimizedAttributes;
    all[4] = ssENRegion.OptimizedAttributes;
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
ssENFolioItems.Read( r, ref index);
ssENAccountingAccounts_ServiceType.Read( r, ref index);
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
public void ReadIM(RC_082bf66064d5a51dc7db708fe5577120 r) {
this = r;
}


public static bool operator == (RC_082bf66064d5a51dc7db708fe5577120 a, RC_082bf66064d5a51dc7db708fe5577120 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENFolioItems != b.ssENFolioItems) return false;
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_082bf66064d5a51dc7db708fe5577120 a, RC_082bf66064d5a51dc7db708fe5577120 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_082bf66064d5a51dc7db708fe5577120)) return false;
return (this == (RC_082bf66064d5a51dc7db708fe5577120)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENFolioItems.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
ssENFolioItems.RecursiveReset();
ssENAccountingAccounts_ServiceType.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENFolioItems.InternalRecursiveSave();
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_082bf66064d5a51dc7db708fe5577120 Duplicate() {
RC_082bf66064d5a51dc7db708fe5577120 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENFolioItems = (EN_868430b5192a8eb1a739e01247fc2704EntityRecord)this.ssENFolioItems.Duplicate();
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
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
if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
} else if (head == "folioitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioItems")) variable.Value = ssENFolioItems; else variable.Optimized = true;
variable.SetFieldName("folioitems");
} else if (head == "accountingaccounts_servicetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingAccounts_ServiceType")) variable.Value = ssENAccountingAccounts_ServiceType; else variable.Optimized = true;
variable.SetFieldName("accountingaccounts_servicetype");
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
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdFolioItems) {
return ssENFolioItems;
}
if (key == IdAccountingAccounts_ServiceType) {
return ssENAccountingAccounts_ServiceType;
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
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdFolioItems.Key.AsGuid) {
return ssENFolioItems;
}
if (attributeKey == IdAccountingAccounts_ServiceType.Key.AsGuid) {
return ssENAccountingAccounts_ServiceType;
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
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENFolioItems.FillFromOther((IRecord) other.AttributeGet(IdFolioItems));
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_082bf66064d5a51dc7db708fe5577120
/// <summary>
/// RecordList type
///  <code>OrderMainItemFolioItemsAccountingAccounts_ServiceTypeCostCenterSAPRegionRecordList</code
/// > that represents a record list of <code>OrderMainItem, FolioItems, AccountingAccounts_ServiceType,
///  CostCenterSAP, Region</code>
/// </summary>
public partial class RL_0dc1085ad4cd06d01dea77860d02de63 : GenericRecordList<RC_082bf66064d5a51dc7db708fe5577120>, IEnumerable, IEnumerator {

protected override RC_082bf66064d5a51dc7db708fe5577120 GetElementDefaultValue() {
return new RC_082bf66064d5a51dc7db708fe5577120();
}

public T[] ToArray<T>(Func<RC_082bf66064d5a51dc7db708fe5577120, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0dc1085ad4cd06d01dea77860d02de63 recordList, Func<RC_082bf66064d5a51dc7db708fe5577120, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0dc1085ad4cd06d01dea77860d02de63(RC_082bf66064d5a51dc7db708fe5577120[] array) {
  RL_0dc1085ad4cd06d01dea77860d02de63 result = new RL_0dc1085ad4cd06d01dea77860d02de63();
result.InnerFromArray(array);
    return result;
}

public static RL_0dc1085ad4cd06d01dea77860d02de63 ToList<T>(T[] array, Func <T, RC_082bf66064d5a51dc7db708fe5577120> converter) {
  RL_0dc1085ad4cd06d01dea77860d02de63 result = new RL_0dc1085ad4cd06d01dea77860d02de63();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0dc1085ad4cd06d01dea77860d02de63 FromRestList<T>(RestList<T> restList, Func <T, RC_082bf66064d5a51dc7db708fe5577120> converter) {
  RL_0dc1085ad4cd06d01dea77860d02de63 result = new RL_0dc1085ad4cd06d01dea77860d02de63();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0dc1085ad4cd06d01dea77860d02de63() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(51,false);
def[1] = new BitArray(18,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(25,false);
def[4] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_082bf66064d5a51dc7db708fe5577120> NewList() {
return new RL_0dc1085ad4cd06d01dea77860d02de63();
}


} // RL_0dc1085ad4cd06d01dea77860d02de63
}

