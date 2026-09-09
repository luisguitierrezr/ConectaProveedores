namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ICpnBeBNTE+0VIwcvccIuw)
///  <code>RC_6dc2ea62d515aadb2abe8127d022eca8</code> that represents <code>CounterRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CounterRecord
public partial struct RC_6dc2ea62d515aadb2abe8127d022eca8 : ITypedRecord<RC_6dc2ea62d515aadb2abe8127d022eca8> {
internal static readonly GlobalObjectKey IdCounter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YurCbRXV26oqvoEn0CLsqA");

public ST_bfed96b4bd29e9b06f0b06e901b1508bStructure ssSTCounter;


public static implicit operator ST_bfed96b4bd29e9b06f0b06e901b1508bStructure( RC_6dc2ea62d515aadb2abe8127d022eca8 r) {
return r.ssSTCounter;
}

public static implicit operator RC_6dc2ea62d515aadb2abe8127d022eca8 (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure r) {
RC_6dc2ea62d515aadb2abe8127d022eca8 res = new RC_6dc2ea62d515aadb2abe8127d022eca8 ();
res.ssSTCounter = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6dc2ea62d515aadb2abe8127d022eca8() {
OptimizedAttributes = null;
ssSTCounter = new ST_bfed96b4bd29e9b06f0b06e901b1508bStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTCounter.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTCounter.Read( r, ref index);
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
public void ReadIM(RC_6dc2ea62d515aadb2abe8127d022eca8 r) {
this = r;
}


public static bool operator == (RC_6dc2ea62d515aadb2abe8127d022eca8 a, RC_6dc2ea62d515aadb2abe8127d022eca8 b) {
if (a.ssSTCounter != b.ssSTCounter) return false;
return true;
}

public static bool operator != (RC_6dc2ea62d515aadb2abe8127d022eca8 a, RC_6dc2ea62d515aadb2abe8127d022eca8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6dc2ea62d515aadb2abe8127d022eca8)) return false;
return (this == (RC_6dc2ea62d515aadb2abe8127d022eca8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCounter.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCounter.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCounter.InternalRecursiveSave();
}


public RC_6dc2ea62d515aadb2abe8127d022eca8 Duplicate() {
RC_6dc2ea62d515aadb2abe8127d022eca8 t;
t.ssSTCounter = (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure)this.ssSTCounter.Duplicate();
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
if (head == "counter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Counter")) variable.Value = ssSTCounter; else variable.Optimized = true;
variable.SetFieldName("counter");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCounter) {
return ssSTCounter;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCounter.Key.AsGuid) {
return ssSTCounter;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCounter.FillFromOther((IRecord) other.AttributeGet(IdCounter));
}
} // RC_6dc2ea62d515aadb2abe8127d022eca8
/// <summary>
/// RecordList type <code>CounterRecordList</code> that represents a record list of
///  <code>Counter</code>
/// </summary>
public partial class RL_5c41e853b96e612f21c832865afaaa1f : GenericRecordList<RC_6dc2ea62d515aadb2abe8127d022eca8>, IEnumerable, IEnumerator {

protected override RC_6dc2ea62d515aadb2abe8127d022eca8 GetElementDefaultValue() {
return new RC_6dc2ea62d515aadb2abe8127d022eca8();
}

public T[] ToArray<T>(Func<RC_6dc2ea62d515aadb2abe8127d022eca8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c41e853b96e612f21c832865afaaa1f recordList, Func<RC_6dc2ea62d515aadb2abe8127d022eca8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c41e853b96e612f21c832865afaaa1f(RC_6dc2ea62d515aadb2abe8127d022eca8[] array) {
  RL_5c41e853b96e612f21c832865afaaa1f result = new RL_5c41e853b96e612f21c832865afaaa1f();
result.InnerFromArray(array);
    return result;
}

public static RL_5c41e853b96e612f21c832865afaaa1f ToList<T>(T[] array, Func <T, RC_6dc2ea62d515aadb2abe8127d022eca8> converter) {
  RL_5c41e853b96e612f21c832865afaaa1f result = new RL_5c41e853b96e612f21c832865afaaa1f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c41e853b96e612f21c832865afaaa1f FromRestList<T>(RestList<T> restList, Func <T, RC_6dc2ea62d515aadb2abe8127d022eca8> converter) {
  RL_5c41e853b96e612f21c832865afaaa1f result = new RL_5c41e853b96e612f21c832865afaaa1f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c41e853b96e612f21c832865afaaa1f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6dc2ea62d515aadb2abe8127d022eca8> NewList() {
return new RL_5c41e853b96e612f21c832865afaaa1f();
}


} // RL_5c41e853b96e612f21c832865afaaa1f
}

