namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (ugDDpHyEdk6JCp0xhPJ0+Q)
///  <code>RC_2813028c34d1b3ce080a3e2c9febe797</code> that represents <code>PaymentOptionsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PaymentOptionsRecord
public partial struct RC_2813028c34d1b3ce080a3e2c9febe797 : ITypedRecord<RC_2813028c34d1b3ce080a3e2c9febe797> {
internal static readonly GlobalObjectKey IdPaymentOptions = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jAITKNE0zrMICj4sn+vnlw");

public EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord ssENPaymentOptions;


public static implicit operator EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord( RC_2813028c34d1b3ce080a3e2c9febe797 r) {
return r.ssENPaymentOptions;
}

public static implicit operator RC_2813028c34d1b3ce080a3e2c9febe797 (EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord r) {
RC_2813028c34d1b3ce080a3e2c9febe797 res = new RC_2813028c34d1b3ce080a3e2c9febe797 ();
res.ssENPaymentOptions = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENPaymentOptions.ChangedAttributes = value;
}
get {
    return ssENPaymentOptions.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2813028c34d1b3ce080a3e2c9febe797() {
OptimizedAttributes = null;
ssENPaymentOptions = new EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENPaymentOptions.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENPaymentOptions.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENPaymentOptions.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENPaymentOptions.Read( r, ref index);
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
public void ReadIM(RC_2813028c34d1b3ce080a3e2c9febe797 r) {
this = r;
}


public static bool operator == (RC_2813028c34d1b3ce080a3e2c9febe797 a, RC_2813028c34d1b3ce080a3e2c9febe797 b) {
if (a.ssENPaymentOptions != b.ssENPaymentOptions) return false;
return true;
}

public static bool operator != (RC_2813028c34d1b3ce080a3e2c9febe797 a, RC_2813028c34d1b3ce080a3e2c9febe797 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2813028c34d1b3ce080a3e2c9febe797)) return false;
return (this == (RC_2813028c34d1b3ce080a3e2c9febe797)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENPaymentOptions.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENPaymentOptions.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENPaymentOptions.InternalRecursiveSave();
}


public RC_2813028c34d1b3ce080a3e2c9febe797 Duplicate() {
RC_2813028c34d1b3ce080a3e2c9febe797 t;
t.ssENPaymentOptions = (EN_7a1403ba58c6cea2d2bf07fe0448aa32EntityRecord)this.ssENPaymentOptions.Duplicate();
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
if (head == "paymentoptions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentOptions")) variable.Value = ssENPaymentOptions; else variable.Optimized = true;
variable.SetFieldName("paymentoptions");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENPaymentOptions.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENPaymentOptions.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPaymentOptions) {
return ssENPaymentOptions;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPaymentOptions.Key.AsGuid) {
return ssENPaymentOptions;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENPaymentOptions.FillFromOther((IRecord) other.AttributeGet(IdPaymentOptions));
}
} // RC_2813028c34d1b3ce080a3e2c9febe797
/// <summary>
/// RecordList type <code>PaymentOptionsRecordList</code> that represents a record list of
///  <code>PaymentOptions</code>
/// </summary>
public partial class RL_251acb2daece433ee402c9709ec88356 : GenericRecordList<RC_2813028c34d1b3ce080a3e2c9febe797>, IEnumerable, IEnumerator {

protected override RC_2813028c34d1b3ce080a3e2c9febe797 GetElementDefaultValue() {
return new RC_2813028c34d1b3ce080a3e2c9febe797();
}

public T[] ToArray<T>(Func<RC_2813028c34d1b3ce080a3e2c9febe797, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_251acb2daece433ee402c9709ec88356 recordList, Func<RC_2813028c34d1b3ce080a3e2c9febe797, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_251acb2daece433ee402c9709ec88356(RC_2813028c34d1b3ce080a3e2c9febe797[] array) {
  RL_251acb2daece433ee402c9709ec88356 result = new RL_251acb2daece433ee402c9709ec88356();
result.InnerFromArray(array);
    return result;
}

public static RL_251acb2daece433ee402c9709ec88356 ToList<T>(T[] array, Func <T, RC_2813028c34d1b3ce080a3e2c9febe797> converter) {
  RL_251acb2daece433ee402c9709ec88356 result = new RL_251acb2daece433ee402c9709ec88356();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_251acb2daece433ee402c9709ec88356 FromRestList<T>(RestList<T> restList, Func <T, RC_2813028c34d1b3ce080a3e2c9febe797> converter) {
  RL_251acb2daece433ee402c9709ec88356 result = new RL_251acb2daece433ee402c9709ec88356();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_251acb2daece433ee402c9709ec88356() : base() {
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
protected override OSList<RC_2813028c34d1b3ce080a3e2c9febe797> NewList() {
return new RL_251acb2daece433ee402c9709ec88356();
}


} // RL_251acb2daece433ee402c9709ec88356
}

