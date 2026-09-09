namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (7eHemzFiU0ayL1tRtFijdA)
///  <code>RC_60d938a257fca2197ed801370b55468f</code> that represent
/// s <code>URLQueryParameterRecord</code> <p>Description: </p>
/// </summary>
// Name: URLQueryParameterRecord
public partial struct RC_60d938a257fca2197ed801370b55468f : ITypedRecord<RC_60d938a257fca2197ed801370b55468f> {
internal static readonly GlobalObjectKey IdURLQueryParameter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ojjZYPxXGaJ+2AE3C1VGjw");

public ST_f9be77c0ae9485d53ded05b1557548f9Structure ssSTURLQueryParameter;


public static implicit operator ST_f9be77c0ae9485d53ded05b1557548f9Structure( RC_60d938a257fca2197ed801370b55468f r) {
return r.ssSTURLQueryParameter;
}

public static implicit operator RC_60d938a257fca2197ed801370b55468f (ST_f9be77c0ae9485d53ded05b1557548f9Structure r) {
RC_60d938a257fca2197ed801370b55468f res = new RC_60d938a257fca2197ed801370b55468f ();
res.ssSTURLQueryParameter = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_60d938a257fca2197ed801370b55468f() {
OptimizedAttributes = null;
ssSTURLQueryParameter = new ST_f9be77c0ae9485d53ded05b1557548f9Structure();
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
    ssSTURLQueryParameter.OptimizedAttributes = value[0];
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
ssSTURLQueryParameter.Read( r, ref index);
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
public void ReadIM(RC_60d938a257fca2197ed801370b55468f r) {
this = r;
}


public static bool operator == (RC_60d938a257fca2197ed801370b55468f a, RC_60d938a257fca2197ed801370b55468f b) {
if (a.ssSTURLQueryParameter != b.ssSTURLQueryParameter) return false;
return true;
}

public static bool operator != (RC_60d938a257fca2197ed801370b55468f a, RC_60d938a257fca2197ed801370b55468f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_60d938a257fca2197ed801370b55468f)) return false;
return (this == (RC_60d938a257fca2197ed801370b55468f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTURLQueryParameter.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTURLQueryParameter.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTURLQueryParameter.InternalRecursiveSave();
}


public RC_60d938a257fca2197ed801370b55468f Duplicate() {
RC_60d938a257fca2197ed801370b55468f t;
t.ssSTURLQueryParameter = (ST_f9be77c0ae9485d53ded05b1557548f9Structure)this.ssSTURLQueryParameter.Duplicate();
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
if (head == "urlqueryparameter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".URLQueryParameter")) variable.Value = ssSTURLQueryParameter; else variable.Optimized = true;
variable.SetFieldName("urlqueryparameter");
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
if (key == IdURLQueryParameter) {
return ssSTURLQueryParameter;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdURLQueryParameter.Key.AsGuid) {
return ssSTURLQueryParameter;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTURLQueryParameter.FillFromOther((IRecord) other.AttributeGet(IdURLQueryParameter));
}
} // RC_60d938a257fca2197ed801370b55468f
/// <summary>
/// RecordList type <code>URLQueryParameterRecordList</code> that represents a record list of
///  <code>URLQueryParameter</code>
/// </summary>
public partial class RL_faac3c664d98563bb86c4fd141360fd1 : GenericRecordList<RC_60d938a257fca2197ed801370b55468f>, IEnumerable, IEnumerator {

protected override RC_60d938a257fca2197ed801370b55468f GetElementDefaultValue() {
return new RC_60d938a257fca2197ed801370b55468f();
}

public T[] ToArray<T>(Func<RC_60d938a257fca2197ed801370b55468f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_faac3c664d98563bb86c4fd141360fd1 recordList, Func<RC_60d938a257fca2197ed801370b55468f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_faac3c664d98563bb86c4fd141360fd1(RC_60d938a257fca2197ed801370b55468f[] array) {
  RL_faac3c664d98563bb86c4fd141360fd1 result = new RL_faac3c664d98563bb86c4fd141360fd1();
result.InnerFromArray(array);
    return result;
}

public static RL_faac3c664d98563bb86c4fd141360fd1 ToList<T>(T[] array, Func <T, RC_60d938a257fca2197ed801370b55468f> converter) {
  RL_faac3c664d98563bb86c4fd141360fd1 result = new RL_faac3c664d98563bb86c4fd141360fd1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_faac3c664d98563bb86c4fd141360fd1 FromRestList<T>(RestList<T> restList, Func <T, RC_60d938a257fca2197ed801370b55468f> converter) {
  RL_faac3c664d98563bb86c4fd141360fd1 result = new RL_faac3c664d98563bb86c4fd141360fd1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_faac3c664d98563bb86c4fd141360fd1() : base() {
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
protected override OSList<RC_60d938a257fca2197ed801370b55468f> NewList() {
return new RL_faac3c664d98563bb86c4fd141360fd1();
}


} // RL_faac3c664d98563bb86c4fd141360fd1
}

