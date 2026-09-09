namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (1UcnV_PGL0KWz+WTNCWo2A)
///  <code>RC_a8c523bc4a14ce1cf905293530597bc7</code> that represents <code>DepositTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DepositTypeRecord
public partial struct RC_a8c523bc4a14ce1cf905293530597bc7 : ITypedRecord<RC_a8c523bc4a14ce1cf905293530597bc7> {
internal static readonly GlobalObjectKey IdDepositType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vCPFqBRKHM75BSk1MFl7xw");

public EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord ssENDepositType;


public static implicit operator EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord( RC_a8c523bc4a14ce1cf905293530597bc7 r) {
return r.ssENDepositType;
}

public static implicit operator RC_a8c523bc4a14ce1cf905293530597bc7 (EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord r) {
RC_a8c523bc4a14ce1cf905293530597bc7 res = new RC_a8c523bc4a14ce1cf905293530597bc7 ();
res.ssENDepositType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDepositType.ChangedAttributes = value;
}
get {
    return ssENDepositType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a8c523bc4a14ce1cf905293530597bc7() {
OptimizedAttributes = null;
ssENDepositType = new EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDepositType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDepositType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDepositType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDepositType.Read( r, ref index);
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
public void ReadIM(RC_a8c523bc4a14ce1cf905293530597bc7 r) {
this = r;
}


public static bool operator == (RC_a8c523bc4a14ce1cf905293530597bc7 a, RC_a8c523bc4a14ce1cf905293530597bc7 b) {
if (a.ssENDepositType != b.ssENDepositType) return false;
return true;
}

public static bool operator != (RC_a8c523bc4a14ce1cf905293530597bc7 a, RC_a8c523bc4a14ce1cf905293530597bc7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a8c523bc4a14ce1cf905293530597bc7)) return false;
return (this == (RC_a8c523bc4a14ce1cf905293530597bc7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDepositType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDepositType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDepositType.InternalRecursiveSave();
}


public RC_a8c523bc4a14ce1cf905293530597bc7 Duplicate() {
RC_a8c523bc4a14ce1cf905293530597bc7 t;
t.ssENDepositType = (EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord)this.ssENDepositType.Duplicate();
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
if (head == "deposittype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DepositType")) variable.Value = ssENDepositType; else variable.Optimized = true;
variable.SetFieldName("deposittype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDepositType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDepositType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDepositType) {
return ssENDepositType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDepositType.Key.AsGuid) {
return ssENDepositType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDepositType.FillFromOther((IRecord) other.AttributeGet(IdDepositType));
}
} // RC_a8c523bc4a14ce1cf905293530597bc7
/// <summary>
/// RecordList type <code>DepositTypeRecordList</code> that represents a record list of
///  <code>DepositType</code>
/// </summary>
public partial class RL_cda7ed93cc851adc2316965418c61e6f : GenericRecordList<RC_a8c523bc4a14ce1cf905293530597bc7>, IEnumerable, IEnumerator {

protected override RC_a8c523bc4a14ce1cf905293530597bc7 GetElementDefaultValue() {
return new RC_a8c523bc4a14ce1cf905293530597bc7();
}

public T[] ToArray<T>(Func<RC_a8c523bc4a14ce1cf905293530597bc7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cda7ed93cc851adc2316965418c61e6f recordList, Func<RC_a8c523bc4a14ce1cf905293530597bc7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cda7ed93cc851adc2316965418c61e6f(RC_a8c523bc4a14ce1cf905293530597bc7[] array) {
  RL_cda7ed93cc851adc2316965418c61e6f result = new RL_cda7ed93cc851adc2316965418c61e6f();
result.InnerFromArray(array);
    return result;
}

public static RL_cda7ed93cc851adc2316965418c61e6f ToList<T>(T[] array, Func <T, RC_a8c523bc4a14ce1cf905293530597bc7> converter) {
  RL_cda7ed93cc851adc2316965418c61e6f result = new RL_cda7ed93cc851adc2316965418c61e6f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cda7ed93cc851adc2316965418c61e6f FromRestList<T>(RestList<T> restList, Func <T, RC_a8c523bc4a14ce1cf905293530597bc7> converter) {
  RL_cda7ed93cc851adc2316965418c61e6f result = new RL_cda7ed93cc851adc2316965418c61e6f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cda7ed93cc851adc2316965418c61e6f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a8c523bc4a14ce1cf905293530597bc7> NewList() {
return new RL_cda7ed93cc851adc2316965418c61e6f();
}


} // RL_cda7ed93cc851adc2316965418c61e6f
}

