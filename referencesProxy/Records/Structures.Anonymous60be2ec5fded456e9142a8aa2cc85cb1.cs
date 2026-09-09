namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (xS6+YO39bkWRQqiqLMhcsQ)
///  <code>RC_f52b5cefcfac404122195213ce1b53ba</code> that represent
/// s <code>AccountingAccounts_ServiceTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: AccountingAccounts_ServiceTypeRecord
public partial struct RC_f52b5cefcfac404122195213ce1b53ba : ITypedRecord<RC_f52b5cefcfac404122195213ce1b53ba> {
internal static readonly GlobalObjectKey IdAccountingAccounts_ServiceType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*71wr9azPQUAiGVITzhtTug");

public EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord ssENAccountingAccounts_ServiceType;


public static implicit operator EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord( RC_f52b5cefcfac404122195213ce1b53ba r) {
return r.ssENAccountingAccounts_ServiceType;
}

public static implicit operator RC_f52b5cefcfac404122195213ce1b53ba (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord r) {
RC_f52b5cefcfac404122195213ce1b53ba res = new RC_f52b5cefcfac404122195213ce1b53ba ();
res.ssENAccountingAccounts_ServiceType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAccountingAccounts_ServiceType.ChangedAttributes = value;
}
get {
    return ssENAccountingAccounts_ServiceType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f52b5cefcfac404122195213ce1b53ba() {
OptimizedAttributes = null;
ssENAccountingAccounts_ServiceType = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAccountingAccounts_ServiceType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAccountingAccounts_ServiceType.OptimizedAttributes;
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
public void ReadIM(RC_f52b5cefcfac404122195213ce1b53ba r) {
this = r;
}


public static bool operator == (RC_f52b5cefcfac404122195213ce1b53ba a, RC_f52b5cefcfac404122195213ce1b53ba b) {
if (a.ssENAccountingAccounts_ServiceType != b.ssENAccountingAccounts_ServiceType) return false;
return true;
}

public static bool operator != (RC_f52b5cefcfac404122195213ce1b53ba a, RC_f52b5cefcfac404122195213ce1b53ba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f52b5cefcfac404122195213ce1b53ba)) return false;
return (this == (RC_f52b5cefcfac404122195213ce1b53ba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAccountingAccounts_ServiceType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAccountingAccounts_ServiceType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAccountingAccounts_ServiceType.InternalRecursiveSave();
}


public RC_f52b5cefcfac404122195213ce1b53ba Duplicate() {
RC_f52b5cefcfac404122195213ce1b53ba t;
t.ssENAccountingAccounts_ServiceType = (EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord)this.ssENAccountingAccounts_ServiceType.Duplicate();
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
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAccountingAccounts_ServiceType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAccountingAccounts_ServiceType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAccountingAccounts_ServiceType) {
return ssENAccountingAccounts_ServiceType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccountingAccounts_ServiceType.Key.AsGuid) {
return ssENAccountingAccounts_ServiceType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAccountingAccounts_ServiceType.FillFromOther((IRecord) other.AttributeGet(IdAccountingAccounts_ServiceType));
}
} // RC_f52b5cefcfac404122195213ce1b53ba
/// <summary>
/// RecordList type <code>AccountingAccounts_ServiceTypeRecordList</code> that represents a record list
///  of <code>AccountingAccounts_ServiceType</code>
/// </summary>
public partial class RL_60b4efe2937800b54618ed04c4847a05 : GenericRecordList<RC_f52b5cefcfac404122195213ce1b53ba>, IEnumerable, IEnumerator {

protected override RC_f52b5cefcfac404122195213ce1b53ba GetElementDefaultValue() {
return new RC_f52b5cefcfac404122195213ce1b53ba();
}

public T[] ToArray<T>(Func<RC_f52b5cefcfac404122195213ce1b53ba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_60b4efe2937800b54618ed04c4847a05 recordList, Func<RC_f52b5cefcfac404122195213ce1b53ba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_60b4efe2937800b54618ed04c4847a05(RC_f52b5cefcfac404122195213ce1b53ba[] array) {
  RL_60b4efe2937800b54618ed04c4847a05 result = new RL_60b4efe2937800b54618ed04c4847a05();
result.InnerFromArray(array);
    return result;
}

public static RL_60b4efe2937800b54618ed04c4847a05 ToList<T>(T[] array, Func <T, RC_f52b5cefcfac404122195213ce1b53ba> converter) {
  RL_60b4efe2937800b54618ed04c4847a05 result = new RL_60b4efe2937800b54618ed04c4847a05();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_60b4efe2937800b54618ed04c4847a05 FromRestList<T>(RestList<T> restList, Func <T, RC_f52b5cefcfac404122195213ce1b53ba> converter) {
  RL_60b4efe2937800b54618ed04c4847a05 result = new RL_60b4efe2937800b54618ed04c4847a05();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_60b4efe2937800b54618ed04c4847a05() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f52b5cefcfac404122195213ce1b53ba> NewList() {
return new RL_60b4efe2937800b54618ed04c4847a05();
}


} // RL_60b4efe2937800b54618ed04c4847a05
}

