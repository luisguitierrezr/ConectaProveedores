namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KVT2S0Hzk02U4LHGzJ9bPw)
///  <code>RC_286d2bb37686f509eeb33164e8470439</code> that represent
/// s <code>AccountingAccounts_ServiceTypeEntryBlockDatesRecord</code> <p>Description: </p>
/// </summary>
// Name: AccountingAccounts_ServiceTypeEntryBlockDatesRecord
public partial struct RC_286d2bb37686f509eeb33164e8470439 : ITypedRecord<RC_286d2bb37686f509eeb33164e8470439> {
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");
internal static readonly GlobalObjectKey IdEntryBlockDates = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RO_YLKMpBAQBCAOQpDwt3A");

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;

public EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord ssENEntryBlockDates;


public BitArray OptimizedAttributes;

public RC_286d2bb37686f509eeb33164e8470439() {
OptimizedAttributes = null;
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
ssENEntryBlockDates = new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENEntryBlockDates.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[0];
    ssENEntryBlockDates.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
    all[1] = ssENEntryBlockDates.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAccountingAccounts_ServiceType.Read( r, ref index);
ssENEntryBlockDates.Read( r, ref index);
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
public void ReadIM(RC_286d2bb37686f509eeb33164e8470439 r) {
this = r;
}


public static bool operator == (RC_286d2bb37686f509eeb33164e8470439 a, RC_286d2bb37686f509eeb33164e8470439 b) {
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
if (a.ssENEntryBlockDates != b.ssENEntryBlockDates) return false;
return true;
}

public static bool operator != (RC_286d2bb37686f509eeb33164e8470439 a, RC_286d2bb37686f509eeb33164e8470439 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_286d2bb37686f509eeb33164e8470439)) return false;
return (this == (RC_286d2bb37686f509eeb33164e8470439)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
 ^ ssENEntryBlockDates.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAccountingAccounts_ServiceType.RecursiveReset();
ssENEntryBlockDates.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
ssENEntryBlockDates.InternalRecursiveSave();
}


public RC_286d2bb37686f509eeb33164e8470439 Duplicate() {
RC_286d2bb37686f509eeb33164e8470439 t;
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
t.ssENEntryBlockDates = (EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord)this.ssENEntryBlockDates.Duplicate();
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
if (head == "accountingaccounts_servicetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingAccounts_ServiceType")) variable.Value = ssENAccountingAccounts_ServiceType; else variable.Optimized = true;
variable.SetFieldName("accountingaccounts_servicetype");
} else if (head == "entryblockdates") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntryBlockDates")) variable.Value = ssENEntryBlockDates; else variable.Optimized = true;
variable.SetFieldName("entryblockdates");
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
if (key == IdAccountingAccounts_ServiceType) {
return ssENAccountingAccounts_ServiceType;
}
if (key == IdEntryBlockDates) {
return ssENEntryBlockDates;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccountingAccounts_ServiceType.Key.AsGuid) {
return ssENAccountingAccounts_ServiceType;
}
if (attributeKey == IdEntryBlockDates.Key.AsGuid) {
return ssENEntryBlockDates;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
ssENEntryBlockDates.FillFromOther((IRecord) other.AttributeGet(IdEntryBlockDates));
}
} // RC_286d2bb37686f509eeb33164e8470439
/// <summary>
/// RecordList type <code>AccountingAccounts_ServiceTypeEntryBlockDatesRecordList</code> that
///  represents a record list of <code>AccountingAccounts_ServiceType, EntryBlockDates</code>
/// </summary>
public partial class RL_da67905e31707902c7c69f546185ad6c : GenericRecordList<RC_286d2bb37686f509eeb33164e8470439>, IEnumerable, IEnumerator {

protected override RC_286d2bb37686f509eeb33164e8470439 GetElementDefaultValue() {
return new RC_286d2bb37686f509eeb33164e8470439();
}

public T[] ToArray<T>(Func<RC_286d2bb37686f509eeb33164e8470439, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_da67905e31707902c7c69f546185ad6c recordList, Func<RC_286d2bb37686f509eeb33164e8470439, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_da67905e31707902c7c69f546185ad6c(RC_286d2bb37686f509eeb33164e8470439[] array) {
  RL_da67905e31707902c7c69f546185ad6c result = new RL_da67905e31707902c7c69f546185ad6c();
result.InnerFromArray(array);
    return result;
}

public static RL_da67905e31707902c7c69f546185ad6c ToList<T>(T[] array, Func <T, RC_286d2bb37686f509eeb33164e8470439> converter) {
  RL_da67905e31707902c7c69f546185ad6c result = new RL_da67905e31707902c7c69f546185ad6c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_da67905e31707902c7c69f546185ad6c FromRestList<T>(RestList<T> restList, Func <T, RC_286d2bb37686f509eeb33164e8470439> converter) {
  RL_da67905e31707902c7c69f546185ad6c result = new RL_da67905e31707902c7c69f546185ad6c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_da67905e31707902c7c69f546185ad6c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_286d2bb37686f509eeb33164e8470439> NewList() {
return new RL_da67905e31707902c7c69f546185ad6c();
}


} // RL_da67905e31707902c7c69f546185ad6c
}

