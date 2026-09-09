namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (U8eg_bqWo02wMWvyj3Jcfg)
///  <code>RC_c398a83ea7d109886e6be693f6d07867</code> that represent
/// s <code>InvoiceAccountingRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingRecord
public partial struct RC_c398a83ea7d109886e6be693f6d07867 : ITypedRecord<RC_c398a83ea7d109886e6be693f6d07867> {
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;


public static implicit operator EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord( RC_c398a83ea7d109886e6be693f6d07867 r) {
return r.ssENInvoiceAccounting;
}

public static implicit operator RC_c398a83ea7d109886e6be693f6d07867 (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord r) {
RC_c398a83ea7d109886e6be693f6d07867 res = new RC_c398a83ea7d109886e6be693f6d07867 ();
res.ssENInvoiceAccounting = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceAccounting.ChangedAttributes = value;
}
get {
    return ssENInvoiceAccounting.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_c398a83ea7d109886e6be693f6d07867() {
OptimizedAttributes = null;
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(21,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccounting.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccounting.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccounting.Read( r, ref index);
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
public void ReadIM(RC_c398a83ea7d109886e6be693f6d07867 r) {
this = r;
}


public static bool operator == (RC_c398a83ea7d109886e6be693f6d07867 a, RC_c398a83ea7d109886e6be693f6d07867 b) {
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
return true;
}

public static bool operator != (RC_c398a83ea7d109886e6be693f6d07867 a, RC_c398a83ea7d109886e6be693f6d07867 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c398a83ea7d109886e6be693f6d07867)) return false;
return (this == (RC_c398a83ea7d109886e6be693f6d07867)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccounting.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccounting.InternalRecursiveSave();
}


public RC_c398a83ea7d109886e6be693f6d07867 Duplicate() {
RC_c398a83ea7d109886e6be693f6d07867 t;
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
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
if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccounting.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccounting.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
}
} // RC_c398a83ea7d109886e6be693f6d07867
/// <summary>
/// RecordList type <code>InvoiceAccountingRecordList</code> that represents a record list of
///  <code>InvoiceAccounting</code>
/// </summary>
public partial class RL_ccf70f600f06def33a14ca10a1120a68 : GenericRecordList<RC_c398a83ea7d109886e6be693f6d07867>, IEnumerable, IEnumerator {

protected override RC_c398a83ea7d109886e6be693f6d07867 GetElementDefaultValue() {
return new RC_c398a83ea7d109886e6be693f6d07867();
}

public T[] ToArray<T>(Func<RC_c398a83ea7d109886e6be693f6d07867, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ccf70f600f06def33a14ca10a1120a68 recordList, Func<RC_c398a83ea7d109886e6be693f6d07867, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ccf70f600f06def33a14ca10a1120a68(RC_c398a83ea7d109886e6be693f6d07867[] array) {
  RL_ccf70f600f06def33a14ca10a1120a68 result = new RL_ccf70f600f06def33a14ca10a1120a68();
result.InnerFromArray(array);
    return result;
}

public static RL_ccf70f600f06def33a14ca10a1120a68 ToList<T>(T[] array, Func <T, RC_c398a83ea7d109886e6be693f6d07867> converter) {
  RL_ccf70f600f06def33a14ca10a1120a68 result = new RL_ccf70f600f06def33a14ca10a1120a68();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ccf70f600f06def33a14ca10a1120a68 FromRestList<T>(RestList<T> restList, Func <T, RC_c398a83ea7d109886e6be693f6d07867> converter) {
  RL_ccf70f600f06def33a14ca10a1120a68 result = new RL_ccf70f600f06def33a14ca10a1120a68();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ccf70f600f06def33a14ca10a1120a68() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(21,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c398a83ea7d109886e6be693f6d07867> NewList() {
return new RL_ccf70f600f06def33a14ca10a1120a68();
}


} // RL_ccf70f600f06def33a14ca10a1120a68
}

