namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (SIa5HQFR7UuQe9VZPbyOrg)
///  <code>RC_16678e1ac2e17d1b5db4a9a7f4681e64</code> that represent
/// s <code>OrderMainItemAccountingAccounts_ServiceTypeInvoiceUsageRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainItemAccountingAccounts_ServiceTypeInvoiceUsageRecord
public partial struct RC_16678e1ac2e17d1b5db4a9a7f4681e64 : ITypedRecord<RC_16678e1ac2e17d1b5db4a9a7f4681e64> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdInvoiceUsage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PM0SJfnH44ZrTV7fKQ1Dgw");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord ssENInvoiceUsage;


public BitArray OptimizedAttributes;

public RC_16678e1ac2e17d1b5db4a9a7f4681e64() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENInvoiceUsage = new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceUsage.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[1];
    ssENInvoiceUsage.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[2] = ssENInvoiceUsage.OptimizedAttributes;
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
ssENInvoiceUsage.Read( r, ref index);
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
public void ReadIM(RC_16678e1ac2e17d1b5db4a9a7f4681e64 r) {
this = r;
}


public static bool operator == (RC_16678e1ac2e17d1b5db4a9a7f4681e64 a, RC_16678e1ac2e17d1b5db4a9a7f4681e64 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENInvoiceUsage != b.ssENInvoiceUsage) return false;
return true;
}

public static bool operator != (RC_16678e1ac2e17d1b5db4a9a7f4681e64 a, RC_16678e1ac2e17d1b5db4a9a7f4681e64 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_16678e1ac2e17d1b5db4a9a7f4681e64)) return false;
return (this == (RC_16678e1ac2e17d1b5db4a9a7f4681e64)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
 ^ ssENInvoiceUsage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
ssENAccountingAccounts_ServiceType.RecursiveReset();
ssENInvoiceUsage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENInvoiceUsage.InternalRecursiveSave();
}


public RC_16678e1ac2e17d1b5db4a9a7f4681e64 Duplicate() {
RC_16678e1ac2e17d1b5db4a9a7f4681e64 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
t.ssENInvoiceUsage = (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord)this.ssENInvoiceUsage.Duplicate();
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
} else if (head == "invoiceusage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsage")) variable.Value = ssENInvoiceUsage; else variable.Optimized = true;
variable.SetFieldName("invoiceusage");
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
if (key == IdInvoiceUsage) {
return ssENInvoiceUsage;
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
if (attributeKey == IdInvoiceUsage.Key.AsGuid) {
return ssENInvoiceUsage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
ssENInvoiceUsage.FillFromOther((IRecord) other.AttributeGet(IdInvoiceUsage));
}
} // RC_16678e1ac2e17d1b5db4a9a7f4681e64
/// <summary>
/// RecordList type <code>OrderMainItemAccountingAccounts_ServiceTypeInvoiceUsageRecordList</code> that
///  represents a record list of <code>OrderMainItem, AccountingAccounts_ServiceType
/// , InvoiceUsage</code>
/// </summary>
public partial class RL_663d4acde686fb13f7cb44965555ab7f : GenericRecordList<RC_16678e1ac2e17d1b5db4a9a7f4681e64>, IEnumerable, IEnumerator {

protected override RC_16678e1ac2e17d1b5db4a9a7f4681e64 GetElementDefaultValue() {
return new RC_16678e1ac2e17d1b5db4a9a7f4681e64();
}

public T[] ToArray<T>(Func<RC_16678e1ac2e17d1b5db4a9a7f4681e64, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_663d4acde686fb13f7cb44965555ab7f recordList, Func<RC_16678e1ac2e17d1b5db4a9a7f4681e64, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_663d4acde686fb13f7cb44965555ab7f(RC_16678e1ac2e17d1b5db4a9a7f4681e64[] array) {
  RL_663d4acde686fb13f7cb44965555ab7f result = new RL_663d4acde686fb13f7cb44965555ab7f();
result.InnerFromArray(array);
    return result;
}

public static RL_663d4acde686fb13f7cb44965555ab7f ToList<T>(T[] array, Func <T, RC_16678e1ac2e17d1b5db4a9a7f4681e64> converter) {
  RL_663d4acde686fb13f7cb44965555ab7f result = new RL_663d4acde686fb13f7cb44965555ab7f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_663d4acde686fb13f7cb44965555ab7f FromRestList<T>(RestList<T> restList, Func <T, RC_16678e1ac2e17d1b5db4a9a7f4681e64> converter) {
  RL_663d4acde686fb13f7cb44965555ab7f result = new RL_663d4acde686fb13f7cb44965555ab7f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_663d4acde686fb13f7cb44965555ab7f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(51,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_16678e1ac2e17d1b5db4a9a7f4681e64> NewList() {
return new RL_663d4acde686fb13f7cb44965555ab7f();
}


} // RL_663d4acde686fb13f7cb44965555ab7f
}

