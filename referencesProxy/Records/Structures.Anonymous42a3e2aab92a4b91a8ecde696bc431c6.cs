namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (quKjQiq5kUuo7N5pa8Qxxg)
///  <code>RC_45208e184b912aa1623cdf19760e8e7e</code> that represents <code>PaymentMethodsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PaymentMethodsRecord
public partial struct RC_45208e184b912aa1623cdf19760e8e7e : ITypedRecord<RC_45208e184b912aa1623cdf19760e8e7e> {
internal static readonly GlobalObjectKey IdPaymentMethods = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GI4gRZFLoSpiPN8Zdg6Ofg");

public EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord ssENPaymentMethods;


public static implicit operator EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord( RC_45208e184b912aa1623cdf19760e8e7e r) {
return r.ssENPaymentMethods;
}

public static implicit operator RC_45208e184b912aa1623cdf19760e8e7e (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord r) {
RC_45208e184b912aa1623cdf19760e8e7e res = new RC_45208e184b912aa1623cdf19760e8e7e ();
res.ssENPaymentMethods = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENPaymentMethods.ChangedAttributes = value;
}
get {
    return ssENPaymentMethods.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_45208e184b912aa1623cdf19760e8e7e() {
OptimizedAttributes = null;
ssENPaymentMethods = new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENPaymentMethods.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENPaymentMethods.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENPaymentMethods.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENPaymentMethods.Read( r, ref index);
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
public void ReadIM(RC_45208e184b912aa1623cdf19760e8e7e r) {
this = r;
}


public static bool operator == (RC_45208e184b912aa1623cdf19760e8e7e a, RC_45208e184b912aa1623cdf19760e8e7e b) {
if (a.ssENPaymentMethods != b.ssENPaymentMethods) return false;
return true;
}

public static bool operator != (RC_45208e184b912aa1623cdf19760e8e7e a, RC_45208e184b912aa1623cdf19760e8e7e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_45208e184b912aa1623cdf19760e8e7e)) return false;
return (this == (RC_45208e184b912aa1623cdf19760e8e7e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENPaymentMethods.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENPaymentMethods.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENPaymentMethods.InternalRecursiveSave();
}


public RC_45208e184b912aa1623cdf19760e8e7e Duplicate() {
RC_45208e184b912aa1623cdf19760e8e7e t;
t.ssENPaymentMethods = (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord)this.ssENPaymentMethods.Duplicate();
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
if (head == "paymentmethods") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethods")) variable.Value = ssENPaymentMethods; else variable.Optimized = true;
variable.SetFieldName("paymentmethods");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENPaymentMethods.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENPaymentMethods.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPaymentMethods) {
return ssENPaymentMethods;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPaymentMethods.Key.AsGuid) {
return ssENPaymentMethods;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENPaymentMethods.FillFromOther((IRecord) other.AttributeGet(IdPaymentMethods));
}
} // RC_45208e184b912aa1623cdf19760e8e7e
/// <summary>
/// RecordList type <code>PaymentMethodsRecordList</code> that represents a record list of
///  <code>PaymentMethods</code>
/// </summary>
public partial class RL_0dcbcba642ca8b22e87f690d4de9d077 : GenericRecordList<RC_45208e184b912aa1623cdf19760e8e7e>, IEnumerable, IEnumerator {

protected override RC_45208e184b912aa1623cdf19760e8e7e GetElementDefaultValue() {
return new RC_45208e184b912aa1623cdf19760e8e7e();
}

public T[] ToArray<T>(Func<RC_45208e184b912aa1623cdf19760e8e7e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0dcbcba642ca8b22e87f690d4de9d077 recordList, Func<RC_45208e184b912aa1623cdf19760e8e7e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0dcbcba642ca8b22e87f690d4de9d077(RC_45208e184b912aa1623cdf19760e8e7e[] array) {
  RL_0dcbcba642ca8b22e87f690d4de9d077 result = new RL_0dcbcba642ca8b22e87f690d4de9d077();
result.InnerFromArray(array);
    return result;
}

public static RL_0dcbcba642ca8b22e87f690d4de9d077 ToList<T>(T[] array, Func <T, RC_45208e184b912aa1623cdf19760e8e7e> converter) {
  RL_0dcbcba642ca8b22e87f690d4de9d077 result = new RL_0dcbcba642ca8b22e87f690d4de9d077();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0dcbcba642ca8b22e87f690d4de9d077 FromRestList<T>(RestList<T> restList, Func <T, RC_45208e184b912aa1623cdf19760e8e7e> converter) {
  RL_0dcbcba642ca8b22e87f690d4de9d077 result = new RL_0dcbcba642ca8b22e87f690d4de9d077();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0dcbcba642ca8b22e87f690d4de9d077() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_45208e184b912aa1623cdf19760e8e7e> NewList() {
return new RL_0dcbcba642ca8b22e87f690d4de9d077();
}


} // RL_0dcbcba642ca8b22e87f690d4de9d077
}

