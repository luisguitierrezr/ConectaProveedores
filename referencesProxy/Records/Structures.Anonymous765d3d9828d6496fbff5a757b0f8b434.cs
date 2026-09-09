namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (mD1ddtYob0m_9adXsPi0NA)
///  <code>RC_a6177074bb5c56dd37245c971e55737e</code> that represent
/// s <code>InvoicesUsageAccountsRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoicesUsageAccountsRecord
public partial struct RC_a6177074bb5c56dd37245c971e55737e : ITypedRecord<RC_a6177074bb5c56dd37245c971e55737e> {
internal static readonly GlobalObjectKey IdInvoicesUsageAccounts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dHAXply73VY3JFyXHlVzfg");

public EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord ssENInvoicesUsageAccounts;


public static implicit operator EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord( RC_a6177074bb5c56dd37245c971e55737e r) {
return r.ssENInvoicesUsageAccounts;
}

public static implicit operator RC_a6177074bb5c56dd37245c971e55737e (EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord r) {
RC_a6177074bb5c56dd37245c971e55737e res = new RC_a6177074bb5c56dd37245c971e55737e ();
res.ssENInvoicesUsageAccounts = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoicesUsageAccounts.ChangedAttributes = value;
}
get {
    return ssENInvoicesUsageAccounts.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a6177074bb5c56dd37245c971e55737e() {
OptimizedAttributes = null;
ssENInvoicesUsageAccounts = new EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoicesUsageAccounts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoicesUsageAccounts.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoicesUsageAccounts.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoicesUsageAccounts.Read( r, ref index);
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
public void ReadIM(RC_a6177074bb5c56dd37245c971e55737e r) {
this = r;
}


public static bool operator == (RC_a6177074bb5c56dd37245c971e55737e a, RC_a6177074bb5c56dd37245c971e55737e b) {
if (a.ssENInvoicesUsageAccounts != b.ssENInvoicesUsageAccounts) return false;
return true;
}

public static bool operator != (RC_a6177074bb5c56dd37245c971e55737e a, RC_a6177074bb5c56dd37245c971e55737e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a6177074bb5c56dd37245c971e55737e)) return false;
return (this == (RC_a6177074bb5c56dd37245c971e55737e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoicesUsageAccounts.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoicesUsageAccounts.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoicesUsageAccounts.InternalRecursiveSave();
}


public RC_a6177074bb5c56dd37245c971e55737e Duplicate() {
RC_a6177074bb5c56dd37245c971e55737e t;
t.ssENInvoicesUsageAccounts = (EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord)this.ssENInvoicesUsageAccounts.Duplicate();
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
if (head == "invoicesusageaccounts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicesUsageAccounts")) variable.Value = ssENInvoicesUsageAccounts; else variable.Optimized = true;
variable.SetFieldName("invoicesusageaccounts");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoicesUsageAccounts.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoicesUsageAccounts.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoicesUsageAccounts) {
return ssENInvoicesUsageAccounts;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoicesUsageAccounts.Key.AsGuid) {
return ssENInvoicesUsageAccounts;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoicesUsageAccounts.FillFromOther((IRecord) other.AttributeGet(IdInvoicesUsageAccounts));
}
} // RC_a6177074bb5c56dd37245c971e55737e
/// <summary>
/// RecordList type <code>InvoicesUsageAccountsRecordList</code> that represents a record list of
///  <code>InvoicesUsageAccounts</code>
/// </summary>
public partial class RL_f9b68d8d5325c3c75577997d5d1162cc : GenericRecordList<RC_a6177074bb5c56dd37245c971e55737e>, IEnumerable, IEnumerator {

protected override RC_a6177074bb5c56dd37245c971e55737e GetElementDefaultValue() {
return new RC_a6177074bb5c56dd37245c971e55737e();
}

public T[] ToArray<T>(Func<RC_a6177074bb5c56dd37245c971e55737e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f9b68d8d5325c3c75577997d5d1162cc recordList, Func<RC_a6177074bb5c56dd37245c971e55737e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f9b68d8d5325c3c75577997d5d1162cc(RC_a6177074bb5c56dd37245c971e55737e[] array) {
  RL_f9b68d8d5325c3c75577997d5d1162cc result = new RL_f9b68d8d5325c3c75577997d5d1162cc();
result.InnerFromArray(array);
    return result;
}

public static RL_f9b68d8d5325c3c75577997d5d1162cc ToList<T>(T[] array, Func <T, RC_a6177074bb5c56dd37245c971e55737e> converter) {
  RL_f9b68d8d5325c3c75577997d5d1162cc result = new RL_f9b68d8d5325c3c75577997d5d1162cc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f9b68d8d5325c3c75577997d5d1162cc FromRestList<T>(RestList<T> restList, Func <T, RC_a6177074bb5c56dd37245c971e55737e> converter) {
  RL_f9b68d8d5325c3c75577997d5d1162cc result = new RL_f9b68d8d5325c3c75577997d5d1162cc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f9b68d8d5325c3c75577997d5d1162cc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a6177074bb5c56dd37245c971e55737e> NewList() {
return new RL_f9b68d8d5325c3c75577997d5d1162cc();
}


} // RL_f9b68d8d5325c3c75577997d5d1162cc
}

