namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CGad2nFQCkOn9NSFaCB+xQ)
///  <code>RC_4a8ab393337b882018e44511f7ddbaa8</code> that represents <code>PaymentWaysRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PaymentWaysRecord
public partial struct RC_4a8ab393337b882018e44511f7ddbaa8 : ITypedRecord<RC_4a8ab393337b882018e44511f7ddbaa8> {
internal static readonly GlobalObjectKey IdPaymentWays = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k7OKSnszIIgY5EUR9926qA");

public EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord ssENPaymentWays;


public static implicit operator EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord( RC_4a8ab393337b882018e44511f7ddbaa8 r) {
return r.ssENPaymentWays;
}

public static implicit operator RC_4a8ab393337b882018e44511f7ddbaa8 (EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord r) {
RC_4a8ab393337b882018e44511f7ddbaa8 res = new RC_4a8ab393337b882018e44511f7ddbaa8 ();
res.ssENPaymentWays = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENPaymentWays.ChangedAttributes = value;
}
get {
    return ssENPaymentWays.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_4a8ab393337b882018e44511f7ddbaa8() {
OptimizedAttributes = null;
ssENPaymentWays = new EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENPaymentWays.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENPaymentWays.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENPaymentWays.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENPaymentWays.Read( r, ref index);
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
public void ReadIM(RC_4a8ab393337b882018e44511f7ddbaa8 r) {
this = r;
}


public static bool operator == (RC_4a8ab393337b882018e44511f7ddbaa8 a, RC_4a8ab393337b882018e44511f7ddbaa8 b) {
if (a.ssENPaymentWays != b.ssENPaymentWays) return false;
return true;
}

public static bool operator != (RC_4a8ab393337b882018e44511f7ddbaa8 a, RC_4a8ab393337b882018e44511f7ddbaa8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4a8ab393337b882018e44511f7ddbaa8)) return false;
return (this == (RC_4a8ab393337b882018e44511f7ddbaa8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENPaymentWays.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENPaymentWays.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENPaymentWays.InternalRecursiveSave();
}


public RC_4a8ab393337b882018e44511f7ddbaa8 Duplicate() {
RC_4a8ab393337b882018e44511f7ddbaa8 t;
t.ssENPaymentWays = (EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord)this.ssENPaymentWays.Duplicate();
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
if (head == "paymentways") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentWays")) variable.Value = ssENPaymentWays; else variable.Optimized = true;
variable.SetFieldName("paymentways");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENPaymentWays.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENPaymentWays.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPaymentWays) {
return ssENPaymentWays;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPaymentWays.Key.AsGuid) {
return ssENPaymentWays;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENPaymentWays.FillFromOther((IRecord) other.AttributeGet(IdPaymentWays));
}
} // RC_4a8ab393337b882018e44511f7ddbaa8
/// <summary>
/// RecordList type <code>PaymentWaysRecordList</code> that represents a record list of
///  <code>PaymentWays</code>
/// </summary>
public partial class RL_d98dc7eec8c631266895b622203a6db3 : GenericRecordList<RC_4a8ab393337b882018e44511f7ddbaa8>, IEnumerable, IEnumerator {

protected override RC_4a8ab393337b882018e44511f7ddbaa8 GetElementDefaultValue() {
return new RC_4a8ab393337b882018e44511f7ddbaa8();
}

public T[] ToArray<T>(Func<RC_4a8ab393337b882018e44511f7ddbaa8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d98dc7eec8c631266895b622203a6db3 recordList, Func<RC_4a8ab393337b882018e44511f7ddbaa8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d98dc7eec8c631266895b622203a6db3(RC_4a8ab393337b882018e44511f7ddbaa8[] array) {
  RL_d98dc7eec8c631266895b622203a6db3 result = new RL_d98dc7eec8c631266895b622203a6db3();
result.InnerFromArray(array);
    return result;
}

public static RL_d98dc7eec8c631266895b622203a6db3 ToList<T>(T[] array, Func <T, RC_4a8ab393337b882018e44511f7ddbaa8> converter) {
  RL_d98dc7eec8c631266895b622203a6db3 result = new RL_d98dc7eec8c631266895b622203a6db3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d98dc7eec8c631266895b622203a6db3 FromRestList<T>(RestList<T> restList, Func <T, RC_4a8ab393337b882018e44511f7ddbaa8> converter) {
  RL_d98dc7eec8c631266895b622203a6db3 result = new RL_d98dc7eec8c631266895b622203a6db3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d98dc7eec8c631266895b622203a6db3() : base() {
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
protected override OSList<RC_4a8ab393337b882018e44511f7ddbaa8> NewList() {
return new RL_d98dc7eec8c631266895b622203a6db3();
}


} // RL_d98dc7eec8c631266895b622203a6db3
}

