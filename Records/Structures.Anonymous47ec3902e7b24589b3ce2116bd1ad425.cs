namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AjnsR7LniUWzziEWvRrUJQ)
///  <code>RC_965912af30c7fbb7316f17bf8e331782</code> that represent
/// s <code>InvoiceExtendedTaxRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedTaxRecord
public partial struct RC_965912af30c7fbb7316f17bf8e331782 : ITypedRecord<RC_965912af30c7fbb7316f17bf8e331782> {
internal static readonly GlobalObjectKey IdInvoiceExtendedTax = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rxJZlscwt_sxbxe_jjMXgg");

public EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord ssENInvoiceExtendedTax;


public static implicit operator EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord( RC_965912af30c7fbb7316f17bf8e331782 r) {
return r.ssENInvoiceExtendedTax;
}

public static implicit operator RC_965912af30c7fbb7316f17bf8e331782 (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord r) {
RC_965912af30c7fbb7316f17bf8e331782 res = new RC_965912af30c7fbb7316f17bf8e331782 ();
res.ssENInvoiceExtendedTax = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedTax.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedTax.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_965912af30c7fbb7316f17bf8e331782() {
OptimizedAttributes = null;
ssENInvoiceExtendedTax = new EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedTax.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedTax.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedTax.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedTax.Read( r, ref index);
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
public void ReadIM(RC_965912af30c7fbb7316f17bf8e331782 r) {
this = r;
}


public static bool operator == (RC_965912af30c7fbb7316f17bf8e331782 a, RC_965912af30c7fbb7316f17bf8e331782 b) {
if (a.ssENInvoiceExtendedTax != b.ssENInvoiceExtendedTax) return false;
return true;
}

public static bool operator != (RC_965912af30c7fbb7316f17bf8e331782 a, RC_965912af30c7fbb7316f17bf8e331782 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_965912af30c7fbb7316f17bf8e331782)) return false;
return (this == (RC_965912af30c7fbb7316f17bf8e331782)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedTax.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedTax.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedTax.InternalRecursiveSave();
}


public RC_965912af30c7fbb7316f17bf8e331782 Duplicate() {
RC_965912af30c7fbb7316f17bf8e331782 t;
t.ssENInvoiceExtendedTax = (EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord)this.ssENInvoiceExtendedTax.Duplicate();
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
if (head == "invoiceextendedtax") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedTax")) variable.Value = ssENInvoiceExtendedTax; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedtax");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedTax.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedTax.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedTax) {
return ssENInvoiceExtendedTax;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedTax.Key.AsGuid) {
return ssENInvoiceExtendedTax;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedTax.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedTax));
}
} // RC_965912af30c7fbb7316f17bf8e331782
/// <summary>
/// RecordList type <code>InvoiceExtendedTaxRecordList</code> that represents a record list of
///  <code>InvoiceExtendedTax</code>
/// </summary>
public partial class RL_9404dc36b913809894c7e4e44e8e1dd8 : GenericRecordList<RC_965912af30c7fbb7316f17bf8e331782>, IEnumerable, IEnumerator {

protected override RC_965912af30c7fbb7316f17bf8e331782 GetElementDefaultValue() {
return new RC_965912af30c7fbb7316f17bf8e331782();
}

public T[] ToArray<T>(Func<RC_965912af30c7fbb7316f17bf8e331782, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9404dc36b913809894c7e4e44e8e1dd8 recordList, Func<RC_965912af30c7fbb7316f17bf8e331782, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9404dc36b913809894c7e4e44e8e1dd8(RC_965912af30c7fbb7316f17bf8e331782[] array) {
  RL_9404dc36b913809894c7e4e44e8e1dd8 result = new RL_9404dc36b913809894c7e4e44e8e1dd8();
result.InnerFromArray(array);
    return result;
}

public static RL_9404dc36b913809894c7e4e44e8e1dd8 ToList<T>(T[] array, Func <T, RC_965912af30c7fbb7316f17bf8e331782> converter) {
  RL_9404dc36b913809894c7e4e44e8e1dd8 result = new RL_9404dc36b913809894c7e4e44e8e1dd8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9404dc36b913809894c7e4e44e8e1dd8 FromRestList<T>(RestList<T> restList, Func <T, RC_965912af30c7fbb7316f17bf8e331782> converter) {
  RL_9404dc36b913809894c7e4e44e8e1dd8 result = new RL_9404dc36b913809894c7e4e44e8e1dd8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9404dc36b913809894c7e4e44e8e1dd8() : base() {
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
protected override OSList<RC_965912af30c7fbb7316f17bf8e331782> NewList() {
return new RL_9404dc36b913809894c7e4e44e8e1dd8();
}


} // RL_9404dc36b913809894c7e4e44e8e1dd8
}

