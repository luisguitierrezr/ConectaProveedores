namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (njKwURnSe0Wg4rlTUOSC2A)
///  <code>RC_34d74f643477f98fc1cbb3375068d112</code> that represent
/// s <code>OrderMainItemAccountingAccounts_ServiceTypeCostCenterSAPRegionRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: OrderMainItemAccountingAccounts_ServiceTypeCostCenterSAPRegionRecord
public partial struct RC_34d74f643477f98fc1cbb3375068d112 : ITypedRecord<RC_34d74f643477f98fc1cbb3375068d112> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_34d74f643477f98fc1cbb3375068d112() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(25,false);
    all[3] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[1];
    ssENCostCenterSAP.OptimizedAttributes = value[2];
    ssENRegion.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[2] = ssENCostCenterSAP.OptimizedAttributes;
    all[3] = ssENRegion.OptimizedAttributes;
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
public void ReadIM(RC_34d74f643477f98fc1cbb3375068d112 r) {
this = r;
}


public static bool operator == (RC_34d74f643477f98fc1cbb3375068d112 a, RC_34d74f643477f98fc1cbb3375068d112 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_34d74f643477f98fc1cbb3375068d112 a, RC_34d74f643477f98fc1cbb3375068d112 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_34d74f643477f98fc1cbb3375068d112)) return false;
return (this == (RC_34d74f643477f98fc1cbb3375068d112)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
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
ssENAccountingAccounts_ServiceType.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_34d74f643477f98fc1cbb3375068d112 Duplicate() {
RC_34d74f643477f98fc1cbb3375068d112 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
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
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_34d74f643477f98fc1cbb3375068d112
/// <summary>
/// RecordList type
///  <code>OrderMainItemAccountingAccounts_ServiceTypeCostCenterSAPRegionRecordList</code> tha
/// t represents a record list of <code>OrderMainItem, AccountingAccounts_ServiceType, CostCenterSAP,
///  Region</code>
/// </summary>
public partial class RL_68685adfd889e1cc20ee9267e233e63b : GenericRecordList<RC_34d74f643477f98fc1cbb3375068d112>, IEnumerable, IEnumerator {

protected override RC_34d74f643477f98fc1cbb3375068d112 GetElementDefaultValue() {
return new RC_34d74f643477f98fc1cbb3375068d112();
}

public T[] ToArray<T>(Func<RC_34d74f643477f98fc1cbb3375068d112, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_68685adfd889e1cc20ee9267e233e63b recordList, Func<RC_34d74f643477f98fc1cbb3375068d112, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_68685adfd889e1cc20ee9267e233e63b(RC_34d74f643477f98fc1cbb3375068d112[] array) {
  RL_68685adfd889e1cc20ee9267e233e63b result = new RL_68685adfd889e1cc20ee9267e233e63b();
result.InnerFromArray(array);
    return result;
}

public static RL_68685adfd889e1cc20ee9267e233e63b ToList<T>(T[] array, Func <T, RC_34d74f643477f98fc1cbb3375068d112> converter) {
  RL_68685adfd889e1cc20ee9267e233e63b result = new RL_68685adfd889e1cc20ee9267e233e63b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_68685adfd889e1cc20ee9267e233e63b FromRestList<T>(RestList<T> restList, Func <T, RC_34d74f643477f98fc1cbb3375068d112> converter) {
  RL_68685adfd889e1cc20ee9267e233e63b result = new RL_68685adfd889e1cc20ee9267e233e63b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_68685adfd889e1cc20ee9267e233e63b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(51,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(25,false);
def[3] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_34d74f643477f98fc1cbb3375068d112> NewList() {
return new RL_68685adfd889e1cc20ee9267e233e63b();
}


} // RL_68685adfd889e1cc20ee9267e233e63b
}

