namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pwoSTg6Xx0CpI2C_0LvvBw)
///  <code>RC_64471b6df37f8aec653dbc381bfea212</code> that represent
/// s
///  <code>OrderMainItemOrderCostCenterAccountingAccounts_ServiceTypeDocumentTypeCostCenterSAPRecord</co
/// de> <p>Description: </p>
/// </summary>
// Name: OrderMainItemOrderCostCenterAccountingAccounts_ServiceTypeDocumentTypeCostCenterSAPRecord
public partial struct RC_64471b6df37f8aec653dbc381bfea212 : ITypedRecord<RC_64471b6df37f8aec653dbc381bfea212> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdOrderCostCenter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*v8RgVD+bV5ZqCOKa6WnL5w");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdDocumentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1AT3EIne4plVoJ9rG5tWaA");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord ssENOrderCostCenter;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_a70d553ce1458b3952d039852f258a76EntityRecord ssENDocumentType;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;


public BitArray OptimizedAttributes;

public RC_64471b6df37f8aec653dbc381bfea212() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENOrderCostCenter = new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord();
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENDocumentType = new EN_a70d553ce1458b3952d039852f258a76EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(3,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderCostCenter.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENDocumentType.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENOrderCostCenter.OptimizedAttributes = value[1];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[2];
    ssENDocumentType.OptimizedAttributes = value[3];
    ssENCostCenterSAP.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENOrderCostCenter.OptimizedAttributes;
    all[2] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[3] = ssENDocumentType.OptimizedAttributes;
    all[4] = ssENCostCenterSAP.OptimizedAttributes;
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
ssENOrderCostCenter.Read( r, ref index);
ssENAccountingAccounts_ServiceType.Read( r, ref index);
ssENDocumentType.Read( r, ref index);
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
public void ReadIM(RC_64471b6df37f8aec653dbc381bfea212 r) {
this = r;
}


public static bool operator == (RC_64471b6df37f8aec653dbc381bfea212 a, RC_64471b6df37f8aec653dbc381bfea212 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENOrderCostCenter != b.ssENOrderCostCenter) return false;
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENDocumentType != b.ssENDocumentType) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
return true;
}

public static bool operator != (RC_64471b6df37f8aec653dbc381bfea212 a, RC_64471b6df37f8aec653dbc381bfea212 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_64471b6df37f8aec653dbc381bfea212)) return false;
return (this == (RC_64471b6df37f8aec653dbc381bfea212)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENOrderCostCenter.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
 ^ ssENDocumentType.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
ssENOrderCostCenter.RecursiveReset();
ssENAccountingAccounts_ServiceType.RecursiveReset();
ssENDocumentType.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENOrderCostCenter.InternalRecursiveSave();
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENDocumentType.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
}


public RC_64471b6df37f8aec653dbc381bfea212 Duplicate() {
RC_64471b6df37f8aec653dbc381bfea212 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENOrderCostCenter = (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord)this.ssENOrderCostCenter.Duplicate();
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
t.ssENDocumentType = (EN_a70d553ce1458b3952d039852f258a76EntityRecord)this.ssENDocumentType.Duplicate();
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
} else if (head == "ordercostcenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderCostCenter")) variable.Value = ssENOrderCostCenter; else variable.Optimized = true;
variable.SetFieldName("ordercostcenter");
} else if (head == "accountingaccounts_servicetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingAccounts_ServiceType")) variable.Value = ssENAccountingAccounts_ServiceType; else variable.Optimized = true;
variable.SetFieldName("accountingaccounts_servicetype");
} else if (head == "documenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentType")) variable.Value = ssENDocumentType; else variable.Optimized = true;
variable.SetFieldName("documenttype");
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
if (key == IdOrderCostCenter) {
return ssENOrderCostCenter;
}
if (key == IdAccountingAccounts_ServiceType) {
return ssENAccountingAccounts_ServiceType;
}
if (key == IdDocumentType) {
return ssENDocumentType;
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
if (attributeKey == IdOrderCostCenter.Key.AsGuid) {
return ssENOrderCostCenter;
}
if (attributeKey == IdAccountingAccounts_ServiceType.Key.AsGuid) {
return ssENAccountingAccounts_ServiceType;
}
if (attributeKey == IdDocumentType.Key.AsGuid) {
return ssENDocumentType;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENOrderCostCenter.FillFromOther((IRecord) other.AttributeGet(IdOrderCostCenter));
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
ssENDocumentType.FillFromOther((IRecord) other.AttributeGet(IdDocumentType));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
}
} // RC_64471b6df37f8aec653dbc381bfea212
/// <summary>
/// RecordList type
///  <code>OrderMainItemOrderCostCenterAccountingAccounts_ServiceTypeDocumentTypeCostCenterSAPRecordList
/// </code> that represents a record list of <code>OrderMainItem, OrderCostCenter,
///  AccountingAccounts_ServiceType, DocumentType, CostCenterSAP</code>
/// </summary>
public partial class RL_0c15a16c4feb962d6b5de596c77ba175 : GenericRecordList<RC_64471b6df37f8aec653dbc381bfea212>, IEnumerable, IEnumerator {

protected override RC_64471b6df37f8aec653dbc381bfea212 GetElementDefaultValue() {
return new RC_64471b6df37f8aec653dbc381bfea212();
}

public T[] ToArray<T>(Func<RC_64471b6df37f8aec653dbc381bfea212, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0c15a16c4feb962d6b5de596c77ba175 recordList, Func<RC_64471b6df37f8aec653dbc381bfea212, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0c15a16c4feb962d6b5de596c77ba175(RC_64471b6df37f8aec653dbc381bfea212[] array) {
  RL_0c15a16c4feb962d6b5de596c77ba175 result = new RL_0c15a16c4feb962d6b5de596c77ba175();
result.InnerFromArray(array);
    return result;
}

public static RL_0c15a16c4feb962d6b5de596c77ba175 ToList<T>(T[] array, Func <T, RC_64471b6df37f8aec653dbc381bfea212> converter) {
  RL_0c15a16c4feb962d6b5de596c77ba175 result = new RL_0c15a16c4feb962d6b5de596c77ba175();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0c15a16c4feb962d6b5de596c77ba175 FromRestList<T>(RestList<T> restList, Func <T, RC_64471b6df37f8aec653dbc381bfea212> converter) {
  RL_0c15a16c4feb962d6b5de596c77ba175 result = new RL_0c15a16c4feb962d6b5de596c77ba175();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0c15a16c4feb962d6b5de596c77ba175() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(51,false);
def[1] = new BitArray(3,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_64471b6df37f8aec653dbc381bfea212> NewList() {
return new RL_0c15a16c4feb962d6b5de596c77ba175();
}


} // RL_0c15a16c4feb962d6b5de596c77ba175
}

