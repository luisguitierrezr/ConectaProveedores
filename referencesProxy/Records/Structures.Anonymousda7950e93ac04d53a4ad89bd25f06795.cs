namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (6VB52sA6U02krYm9JfBnlQ)
///  <code>RC_b0983648bb0746c42aeb09b62ccb0add</code> that represent
/// s <code>PostTokenResponseRecord</code> <p>Description: </p>
/// </summary>
// Name: PostTokenResponseRecord
public partial struct RC_b0983648bb0746c42aeb09b62ccb0add : ITypedRecord<RC_b0983648bb0746c42aeb09b62ccb0add> {
internal static readonly GlobalObjectKey IdPostTokenResponse = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SDaYsAe7xEYq6wm2LMsK3Q");

public ST_d5188f28891fd075d6bc1034899cfadeStructure ssSTPostTokenResponse;


public static implicit operator ST_d5188f28891fd075d6bc1034899cfadeStructure( RC_b0983648bb0746c42aeb09b62ccb0add r) {
return r.ssSTPostTokenResponse;
}

public static implicit operator RC_b0983648bb0746c42aeb09b62ccb0add (ST_d5188f28891fd075d6bc1034899cfadeStructure r) {
RC_b0983648bb0746c42aeb09b62ccb0add res = new RC_b0983648bb0746c42aeb09b62ccb0add ();
res.ssSTPostTokenResponse = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b0983648bb0746c42aeb09b62ccb0add() {
OptimizedAttributes = null;
ssSTPostTokenResponse = new ST_d5188f28891fd075d6bc1034899cfadeStructure();
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
    ssSTPostTokenResponse.OptimizedAttributes = value[0];
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
ssSTPostTokenResponse.Read( r, ref index);
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
public void ReadIM(RC_b0983648bb0746c42aeb09b62ccb0add r) {
this = r;
}


public static bool operator == (RC_b0983648bb0746c42aeb09b62ccb0add a, RC_b0983648bb0746c42aeb09b62ccb0add b) {
if (a.ssSTPostTokenResponse != b.ssSTPostTokenResponse) return false;
return true;
}

public static bool operator != (RC_b0983648bb0746c42aeb09b62ccb0add a, RC_b0983648bb0746c42aeb09b62ccb0add b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b0983648bb0746c42aeb09b62ccb0add)) return false;
return (this == (RC_b0983648bb0746c42aeb09b62ccb0add)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPostTokenResponse.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPostTokenResponse.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPostTokenResponse.InternalRecursiveSave();
}


public RC_b0983648bb0746c42aeb09b62ccb0add Duplicate() {
RC_b0983648bb0746c42aeb09b62ccb0add t;
t.ssSTPostTokenResponse = (ST_d5188f28891fd075d6bc1034899cfadeStructure)this.ssSTPostTokenResponse.Duplicate();
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
if (head == "posttokenresponse") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PostTokenResponse")) variable.Value = ssSTPostTokenResponse; else variable.Optimized = true;
variable.SetFieldName("posttokenresponse");
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
if (key == IdPostTokenResponse) {
return ssSTPostTokenResponse;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPostTokenResponse.Key.AsGuid) {
return ssSTPostTokenResponse;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPostTokenResponse.FillFromOther((IRecord) other.AttributeGet(IdPostTokenResponse));
}
} // RC_b0983648bb0746c42aeb09b62ccb0add
/// <summary>
/// RecordList type <code>PostTokenResponseRecordList</code> that represents a record list of
///  <code>PostTokenResponse</code>
/// </summary>
public partial class RL_e838de15a2c19accc6eddb1e2187c74f : GenericRecordList<RC_b0983648bb0746c42aeb09b62ccb0add>, IEnumerable, IEnumerator {

protected override RC_b0983648bb0746c42aeb09b62ccb0add GetElementDefaultValue() {
return new RC_b0983648bb0746c42aeb09b62ccb0add();
}

public T[] ToArray<T>(Func<RC_b0983648bb0746c42aeb09b62ccb0add, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e838de15a2c19accc6eddb1e2187c74f recordList, Func<RC_b0983648bb0746c42aeb09b62ccb0add, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e838de15a2c19accc6eddb1e2187c74f(RC_b0983648bb0746c42aeb09b62ccb0add[] array) {
  RL_e838de15a2c19accc6eddb1e2187c74f result = new RL_e838de15a2c19accc6eddb1e2187c74f();
result.InnerFromArray(array);
    return result;
}

public static RL_e838de15a2c19accc6eddb1e2187c74f ToList<T>(T[] array, Func <T, RC_b0983648bb0746c42aeb09b62ccb0add> converter) {
  RL_e838de15a2c19accc6eddb1e2187c74f result = new RL_e838de15a2c19accc6eddb1e2187c74f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e838de15a2c19accc6eddb1e2187c74f FromRestList<T>(RestList<T> restList, Func <T, RC_b0983648bb0746c42aeb09b62ccb0add> converter) {
  RL_e838de15a2c19accc6eddb1e2187c74f result = new RL_e838de15a2c19accc6eddb1e2187c74f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e838de15a2c19accc6eddb1e2187c74f() : base() {
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
protected override OSList<RC_b0983648bb0746c42aeb09b62ccb0add> NewList() {
return new RL_e838de15a2c19accc6eddb1e2187c74f();
}


} // RL_e838de15a2c19accc6eddb1e2187c74f
}

