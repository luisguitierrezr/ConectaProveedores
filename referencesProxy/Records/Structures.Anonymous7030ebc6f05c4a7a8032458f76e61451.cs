namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (xuswcFzwekqAMkWPduYUUQ)
///  <code>RC_5526bab1a99740bd870dde6a69ba3d9a</code> that represents <code>PaymentTermsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PaymentTermsRecord
public partial struct RC_5526bab1a99740bd870dde6a69ba3d9a : ITypedRecord<RC_5526bab1a99740bd870dde6a69ba3d9a> {
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;


public static implicit operator EN_17720044fda96c0c2d8d0760c429f48aEntityRecord( RC_5526bab1a99740bd870dde6a69ba3d9a r) {
return r.ssENPaymentTerms;
}

public static implicit operator RC_5526bab1a99740bd870dde6a69ba3d9a (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord r) {
RC_5526bab1a99740bd870dde6a69ba3d9a res = new RC_5526bab1a99740bd870dde6a69ba3d9a ();
res.ssENPaymentTerms = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENPaymentTerms.ChangedAttributes = value;
}
get {
    return ssENPaymentTerms.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5526bab1a99740bd870dde6a69ba3d9a() {
OptimizedAttributes = null;
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENPaymentTerms.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENPaymentTerms.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENPaymentTerms.Read( r, ref index);
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
public void ReadIM(RC_5526bab1a99740bd870dde6a69ba3d9a r) {
this = r;
}


public static bool operator == (RC_5526bab1a99740bd870dde6a69ba3d9a a, RC_5526bab1a99740bd870dde6a69ba3d9a b) {
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
return true;
}

public static bool operator != (RC_5526bab1a99740bd870dde6a69ba3d9a a, RC_5526bab1a99740bd870dde6a69ba3d9a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5526bab1a99740bd870dde6a69ba3d9a)) return false;
return (this == (RC_5526bab1a99740bd870dde6a69ba3d9a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENPaymentTerms.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENPaymentTerms.InternalRecursiveSave();
}


public RC_5526bab1a99740bd870dde6a69ba3d9a Duplicate() {
RC_5526bab1a99740bd870dde6a69ba3d9a t;
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
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
if (head == "paymentterms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTerms")) variable.Value = ssENPaymentTerms; else variable.Optimized = true;
variable.SetFieldName("paymentterms");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENPaymentTerms.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENPaymentTerms.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPaymentTerms) {
return ssENPaymentTerms;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
}
} // RC_5526bab1a99740bd870dde6a69ba3d9a
/// <summary>
/// RecordList type <code>PaymentTermsRecordList</code> that represents a record list of
///  <code>PaymentTerms</code>
/// </summary>
public partial class RL_375b9dd8c8b0d6d7bccf4d550f48644d : GenericRecordList<RC_5526bab1a99740bd870dde6a69ba3d9a>, IEnumerable, IEnumerator {

protected override RC_5526bab1a99740bd870dde6a69ba3d9a GetElementDefaultValue() {
return new RC_5526bab1a99740bd870dde6a69ba3d9a();
}

public T[] ToArray<T>(Func<RC_5526bab1a99740bd870dde6a69ba3d9a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_375b9dd8c8b0d6d7bccf4d550f48644d recordList, Func<RC_5526bab1a99740bd870dde6a69ba3d9a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_375b9dd8c8b0d6d7bccf4d550f48644d(RC_5526bab1a99740bd870dde6a69ba3d9a[] array) {
  RL_375b9dd8c8b0d6d7bccf4d550f48644d result = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
result.InnerFromArray(array);
    return result;
}

public static RL_375b9dd8c8b0d6d7bccf4d550f48644d ToList<T>(T[] array, Func <T, RC_5526bab1a99740bd870dde6a69ba3d9a> converter) {
  RL_375b9dd8c8b0d6d7bccf4d550f48644d result = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_375b9dd8c8b0d6d7bccf4d550f48644d FromRestList<T>(RestList<T> restList, Func <T, RC_5526bab1a99740bd870dde6a69ba3d9a> converter) {
  RL_375b9dd8c8b0d6d7bccf4d550f48644d result = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_375b9dd8c8b0d6d7bccf4d550f48644d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5526bab1a99740bd870dde6a69ba3d9a> NewList() {
return new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
}


} // RL_375b9dd8c8b0d6d7bccf4d550f48644d
}

