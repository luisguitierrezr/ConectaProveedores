namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (JWNeANf1lUC2meUz_AXWcQ)
///  <code>RC_decbed55750bb4030b04e46c0306e56b</code> that represent
/// s <code>InvoiceExtendedForeignerRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedForeignerRecord
public partial struct RC_decbed55750bb4030b04e46c0306e56b : ITypedRecord<RC_decbed55750bb4030b04e46c0306e56b> {
internal static readonly GlobalObjectKey IdInvoiceExtendedForeigner = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ve3L3gt1A7QLBORsAwblaw");

public EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord ssENInvoiceExtendedForeigner;


public static implicit operator EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord( RC_decbed55750bb4030b04e46c0306e56b r) {
return r.ssENInvoiceExtendedForeigner;
}

public static implicit operator RC_decbed55750bb4030b04e46c0306e56b (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord r) {
RC_decbed55750bb4030b04e46c0306e56b res = new RC_decbed55750bb4030b04e46c0306e56b ();
res.ssENInvoiceExtendedForeigner = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedForeigner.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedForeigner.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_decbed55750bb4030b04e46c0306e56b() {
OptimizedAttributes = null;
ssENInvoiceExtendedForeigner = new EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedForeigner.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedForeigner.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedForeigner.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedForeigner.Read( r, ref index);
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
public void ReadIM(RC_decbed55750bb4030b04e46c0306e56b r) {
this = r;
}


public static bool operator == (RC_decbed55750bb4030b04e46c0306e56b a, RC_decbed55750bb4030b04e46c0306e56b b) {
if (a.ssENInvoiceExtendedForeigner != b.ssENInvoiceExtendedForeigner) return false;
return true;
}

public static bool operator != (RC_decbed55750bb4030b04e46c0306e56b a, RC_decbed55750bb4030b04e46c0306e56b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_decbed55750bb4030b04e46c0306e56b)) return false;
return (this == (RC_decbed55750bb4030b04e46c0306e56b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedForeigner.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedForeigner.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedForeigner.InternalRecursiveSave();
}


public RC_decbed55750bb4030b04e46c0306e56b Duplicate() {
RC_decbed55750bb4030b04e46c0306e56b t;
t.ssENInvoiceExtendedForeigner = (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord)this.ssENInvoiceExtendedForeigner.Duplicate();
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
if (head == "invoiceextendedforeigner") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedForeigner")) variable.Value = ssENInvoiceExtendedForeigner; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedforeigner");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedForeigner.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedForeigner.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedForeigner) {
return ssENInvoiceExtendedForeigner;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedForeigner.Key.AsGuid) {
return ssENInvoiceExtendedForeigner;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedForeigner.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedForeigner));
}
} // RC_decbed55750bb4030b04e46c0306e56b
/// <summary>
/// RecordList type <code>InvoiceExtendedForeignerRecordList</code> that represents a record list of
///  <code>InvoiceExtendedForeigner</code>
/// </summary>
public partial class RL_5198a019df57be180483639cd138aad4 : GenericRecordList<RC_decbed55750bb4030b04e46c0306e56b>, IEnumerable, IEnumerator {

protected override RC_decbed55750bb4030b04e46c0306e56b GetElementDefaultValue() {
return new RC_decbed55750bb4030b04e46c0306e56b();
}

public T[] ToArray<T>(Func<RC_decbed55750bb4030b04e46c0306e56b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5198a019df57be180483639cd138aad4 recordList, Func<RC_decbed55750bb4030b04e46c0306e56b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5198a019df57be180483639cd138aad4(RC_decbed55750bb4030b04e46c0306e56b[] array) {
  RL_5198a019df57be180483639cd138aad4 result = new RL_5198a019df57be180483639cd138aad4();
result.InnerFromArray(array);
    return result;
}

public static RL_5198a019df57be180483639cd138aad4 ToList<T>(T[] array, Func <T, RC_decbed55750bb4030b04e46c0306e56b> converter) {
  RL_5198a019df57be180483639cd138aad4 result = new RL_5198a019df57be180483639cd138aad4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5198a019df57be180483639cd138aad4 FromRestList<T>(RestList<T> restList, Func <T, RC_decbed55750bb4030b04e46c0306e56b> converter) {
  RL_5198a019df57be180483639cd138aad4 result = new RL_5198a019df57be180483639cd138aad4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5198a019df57be180483639cd138aad4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_decbed55750bb4030b04e46c0306e56b> NewList() {
return new RL_5198a019df57be180483639cd138aad4();
}


} // RL_5198a019df57be180483639cd138aad4
}

