namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (DZfFH8GNO0qoGMi89BxfXQ)
///  <code>RC_a668f8121762731dd2d951328537ae6f</code> that represent
/// s <code>PostValidacfdiprovResponseWrapperRecord</code> <p>Description: </p>
/// </summary>
// Name: PostValidacfdiprovResponseWrapperRecord
public partial struct RC_a668f8121762731dd2d951328537ae6f : ITypedRecord<RC_a668f8121762731dd2d951328537ae6f> {
internal static readonly GlobalObjectKey IdPostValidacfdiprovResponseWrapper = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*EvhopmIXHXPS2VEyhTeubw");

public ST_13caff817360521524d01995a65282cdStructure ssSTPostValidacfdiprovResponseWrapper;


public static implicit operator ST_13caff817360521524d01995a65282cdStructure( RC_a668f8121762731dd2d951328537ae6f r) {
return r.ssSTPostValidacfdiprovResponseWrapper;
}

public static implicit operator RC_a668f8121762731dd2d951328537ae6f (ST_13caff817360521524d01995a65282cdStructure r) {
RC_a668f8121762731dd2d951328537ae6f res = new RC_a668f8121762731dd2d951328537ae6f ();
res.ssSTPostValidacfdiprovResponseWrapper = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a668f8121762731dd2d951328537ae6f() {
OptimizedAttributes = null;
ssSTPostValidacfdiprovResponseWrapper = new ST_13caff817360521524d01995a65282cdStructure();
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
    ssSTPostValidacfdiprovResponseWrapper.OptimizedAttributes = value[0];
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
ssSTPostValidacfdiprovResponseWrapper.Read( r, ref index);
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
public void ReadIM(RC_a668f8121762731dd2d951328537ae6f r) {
this = r;
}


public static bool operator == (RC_a668f8121762731dd2d951328537ae6f a, RC_a668f8121762731dd2d951328537ae6f b) {
if (a.ssSTPostValidacfdiprovResponseWrapper != b.ssSTPostValidacfdiprovResponseWrapper) return false;
return true;
}

public static bool operator != (RC_a668f8121762731dd2d951328537ae6f a, RC_a668f8121762731dd2d951328537ae6f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a668f8121762731dd2d951328537ae6f)) return false;
return (this == (RC_a668f8121762731dd2d951328537ae6f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPostValidacfdiprovResponseWrapper.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPostValidacfdiprovResponseWrapper.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPostValidacfdiprovResponseWrapper.InternalRecursiveSave();
}


public RC_a668f8121762731dd2d951328537ae6f Duplicate() {
RC_a668f8121762731dd2d951328537ae6f t;
t.ssSTPostValidacfdiprovResponseWrapper = (ST_13caff817360521524d01995a65282cdStructure)this.ssSTPostValidacfdiprovResponseWrapper.Duplicate();
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
if (head == "postvalidacfdiprovresponsewrapper") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PostValidacfdiprovResponseWrapper")) variable.Value = ssSTPostValidacfdiprovResponseWrapper; else variable.Optimized = true;
variable.SetFieldName("postvalidacfdiprovresponsewrapper");
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
if (key == IdPostValidacfdiprovResponseWrapper) {
return ssSTPostValidacfdiprovResponseWrapper;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPostValidacfdiprovResponseWrapper.Key.AsGuid) {
return ssSTPostValidacfdiprovResponseWrapper;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPostValidacfdiprovResponseWrapper.FillFromOther((IRecord) other.AttributeGet(IdPostValidacfdiprovResponseWrapper));
}
} // RC_a668f8121762731dd2d951328537ae6f
/// <summary>
/// RecordList type <code>PostValidacfdiprovResponseWrapperRecordList</code> that represents a record
///  list of <code>PostValidacfdiprovResponseWrapper</code>
/// </summary>
public partial class RL_e20bee54e562652a3b299822c111370e : GenericRecordList<RC_a668f8121762731dd2d951328537ae6f>, IEnumerable, IEnumerator {

protected override RC_a668f8121762731dd2d951328537ae6f GetElementDefaultValue() {
return new RC_a668f8121762731dd2d951328537ae6f();
}

public T[] ToArray<T>(Func<RC_a668f8121762731dd2d951328537ae6f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e20bee54e562652a3b299822c111370e recordList, Func<RC_a668f8121762731dd2d951328537ae6f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e20bee54e562652a3b299822c111370e(RC_a668f8121762731dd2d951328537ae6f[] array) {
  RL_e20bee54e562652a3b299822c111370e result = new RL_e20bee54e562652a3b299822c111370e();
result.InnerFromArray(array);
    return result;
}

public static RL_e20bee54e562652a3b299822c111370e ToList<T>(T[] array, Func <T, RC_a668f8121762731dd2d951328537ae6f> converter) {
  RL_e20bee54e562652a3b299822c111370e result = new RL_e20bee54e562652a3b299822c111370e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e20bee54e562652a3b299822c111370e FromRestList<T>(RestList<T> restList, Func <T, RC_a668f8121762731dd2d951328537ae6f> converter) {
  RL_e20bee54e562652a3b299822c111370e result = new RL_e20bee54e562652a3b299822c111370e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e20bee54e562652a3b299822c111370e() : base() {
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
protected override OSList<RC_a668f8121762731dd2d951328537ae6f> NewList() {
return new RL_e20bee54e562652a3b299822c111370e();
}


} // RL_e20bee54e562652a3b299822c111370e
}

