namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (PojYthd23kyqNMchj0meIA)
///  <code>RC_6edb17c5bf63452ff4ac24d41991a940</code> that represents <code>InvoiceStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceStatusRecord
public partial struct RC_6edb17c5bf63452ff4ac24d41991a940 : ITypedRecord<RC_6edb17c5bf63452ff4ac24d41991a940> {
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;


public static implicit operator EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord( RC_6edb17c5bf63452ff4ac24d41991a940 r) {
return r.ssENInvoiceStatus;
}

public static implicit operator RC_6edb17c5bf63452ff4ac24d41991a940 (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord r) {
RC_6edb17c5bf63452ff4ac24d41991a940 res = new RC_6edb17c5bf63452ff4ac24d41991a940 ();
res.ssENInvoiceStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceStatus.ChangedAttributes = value;
}
get {
    return ssENInvoiceStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_6edb17c5bf63452ff4ac24d41991a940() {
OptimizedAttributes = null;
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceStatus.Read( r, ref index);
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
public void ReadIM(RC_6edb17c5bf63452ff4ac24d41991a940 r) {
this = r;
}


public static bool operator == (RC_6edb17c5bf63452ff4ac24d41991a940 a, RC_6edb17c5bf63452ff4ac24d41991a940 b) {
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
return true;
}

public static bool operator != (RC_6edb17c5bf63452ff4ac24d41991a940 a, RC_6edb17c5bf63452ff4ac24d41991a940 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6edb17c5bf63452ff4ac24d41991a940)) return false;
return (this == (RC_6edb17c5bf63452ff4ac24d41991a940)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceStatus.InternalRecursiveSave();
}


public RC_6edb17c5bf63452ff4ac24d41991a940 Duplicate() {
RC_6edb17c5bf63452ff4ac24d41991a940 t;
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
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
if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
}
} // RC_6edb17c5bf63452ff4ac24d41991a940
/// <summary>
/// RecordList type <code>InvoiceStatusRecordList</code> that represents a record list of
///  <code>InvoiceStatus</code>
/// </summary>
public partial class RL_3262178c68dd5ed5c99ed4279a563975 : GenericRecordList<RC_6edb17c5bf63452ff4ac24d41991a940>, IEnumerable, IEnumerator {

protected override RC_6edb17c5bf63452ff4ac24d41991a940 GetElementDefaultValue() {
return new RC_6edb17c5bf63452ff4ac24d41991a940();
}

public T[] ToArray<T>(Func<RC_6edb17c5bf63452ff4ac24d41991a940, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3262178c68dd5ed5c99ed4279a563975 recordList, Func<RC_6edb17c5bf63452ff4ac24d41991a940, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3262178c68dd5ed5c99ed4279a563975(RC_6edb17c5bf63452ff4ac24d41991a940[] array) {
  RL_3262178c68dd5ed5c99ed4279a563975 result = new RL_3262178c68dd5ed5c99ed4279a563975();
result.InnerFromArray(array);
    return result;
}

public static RL_3262178c68dd5ed5c99ed4279a563975 ToList<T>(T[] array, Func <T, RC_6edb17c5bf63452ff4ac24d41991a940> converter) {
  RL_3262178c68dd5ed5c99ed4279a563975 result = new RL_3262178c68dd5ed5c99ed4279a563975();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3262178c68dd5ed5c99ed4279a563975 FromRestList<T>(RestList<T> restList, Func <T, RC_6edb17c5bf63452ff4ac24d41991a940> converter) {
  RL_3262178c68dd5ed5c99ed4279a563975 result = new RL_3262178c68dd5ed5c99ed4279a563975();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3262178c68dd5ed5c99ed4279a563975() : base() {
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
protected override OSList<RC_6edb17c5bf63452ff4ac24d41991a940> NewList() {
return new RL_3262178c68dd5ed5c99ed4279a563975();
}


} // RL_3262178c68dd5ed5c99ed4279a563975
}

