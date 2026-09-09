namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (NNgcArO+tEWZXFZo6GD8wg)
///  <code>RC_8683fa01451331ed9f0e01f837305895</code> that represent
/// s <code>PostValidacfdiprovRequestWrapperRecord</code> <p>Description: </p>
/// </summary>
// Name: PostValidacfdiprovRequestWrapperRecord
public partial struct RC_8683fa01451331ed9f0e01f837305895 : ITypedRecord<RC_8683fa01451331ed9f0e01f837305895> {
internal static readonly GlobalObjectKey IdPostValidacfdiprovRequestWrapper = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AfqDhhNF7TGfDgH4NzBYlQ");

public ST_1e5384bdcb5c8be6badd45c0e821aec6Structure ssSTPostValidacfdiprovRequestWrapper;


public static implicit operator ST_1e5384bdcb5c8be6badd45c0e821aec6Structure( RC_8683fa01451331ed9f0e01f837305895 r) {
return r.ssSTPostValidacfdiprovRequestWrapper;
}

public static implicit operator RC_8683fa01451331ed9f0e01f837305895 (ST_1e5384bdcb5c8be6badd45c0e821aec6Structure r) {
RC_8683fa01451331ed9f0e01f837305895 res = new RC_8683fa01451331ed9f0e01f837305895 ();
res.ssSTPostValidacfdiprovRequestWrapper = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8683fa01451331ed9f0e01f837305895() {
OptimizedAttributes = null;
ssSTPostValidacfdiprovRequestWrapper = new ST_1e5384bdcb5c8be6badd45c0e821aec6Structure();
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
    ssSTPostValidacfdiprovRequestWrapper.OptimizedAttributes = value[0];
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
ssSTPostValidacfdiprovRequestWrapper.Read( r, ref index);
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
public void ReadIM(RC_8683fa01451331ed9f0e01f837305895 r) {
this = r;
}


public static bool operator == (RC_8683fa01451331ed9f0e01f837305895 a, RC_8683fa01451331ed9f0e01f837305895 b) {
if (a.ssSTPostValidacfdiprovRequestWrapper != b.ssSTPostValidacfdiprovRequestWrapper) return false;
return true;
}

public static bool operator != (RC_8683fa01451331ed9f0e01f837305895 a, RC_8683fa01451331ed9f0e01f837305895 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8683fa01451331ed9f0e01f837305895)) return false;
return (this == (RC_8683fa01451331ed9f0e01f837305895)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPostValidacfdiprovRequestWrapper.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPostValidacfdiprovRequestWrapper.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPostValidacfdiprovRequestWrapper.InternalRecursiveSave();
}


public RC_8683fa01451331ed9f0e01f837305895 Duplicate() {
RC_8683fa01451331ed9f0e01f837305895 t;
t.ssSTPostValidacfdiprovRequestWrapper = (ST_1e5384bdcb5c8be6badd45c0e821aec6Structure)this.ssSTPostValidacfdiprovRequestWrapper.Duplicate();
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
if (head == "postvalidacfdiprovrequestwrapper") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PostValidacfdiprovRequestWrapper")) variable.Value = ssSTPostValidacfdiprovRequestWrapper; else variable.Optimized = true;
variable.SetFieldName("postvalidacfdiprovrequestwrapper");
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
if (key == IdPostValidacfdiprovRequestWrapper) {
return ssSTPostValidacfdiprovRequestWrapper;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPostValidacfdiprovRequestWrapper.Key.AsGuid) {
return ssSTPostValidacfdiprovRequestWrapper;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPostValidacfdiprovRequestWrapper.FillFromOther((IRecord) other.AttributeGet(IdPostValidacfdiprovRequestWrapper));
}
} // RC_8683fa01451331ed9f0e01f837305895
/// <summary>
/// RecordList type <code>PostValidacfdiprovRequestWrapperRecordList</code> that represents a record
///  list of <code>PostValidacfdiprovRequestWrapper</code>
/// </summary>
public partial class RL_dc1018cd54704f8c0b51a09231fe37a6 : GenericRecordList<RC_8683fa01451331ed9f0e01f837305895>, IEnumerable, IEnumerator {

protected override RC_8683fa01451331ed9f0e01f837305895 GetElementDefaultValue() {
return new RC_8683fa01451331ed9f0e01f837305895();
}

public T[] ToArray<T>(Func<RC_8683fa01451331ed9f0e01f837305895, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dc1018cd54704f8c0b51a09231fe37a6 recordList, Func<RC_8683fa01451331ed9f0e01f837305895, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dc1018cd54704f8c0b51a09231fe37a6(RC_8683fa01451331ed9f0e01f837305895[] array) {
  RL_dc1018cd54704f8c0b51a09231fe37a6 result = new RL_dc1018cd54704f8c0b51a09231fe37a6();
result.InnerFromArray(array);
    return result;
}

public static RL_dc1018cd54704f8c0b51a09231fe37a6 ToList<T>(T[] array, Func <T, RC_8683fa01451331ed9f0e01f837305895> converter) {
  RL_dc1018cd54704f8c0b51a09231fe37a6 result = new RL_dc1018cd54704f8c0b51a09231fe37a6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dc1018cd54704f8c0b51a09231fe37a6 FromRestList<T>(RestList<T> restList, Func <T, RC_8683fa01451331ed9f0e01f837305895> converter) {
  RL_dc1018cd54704f8c0b51a09231fe37a6 result = new RL_dc1018cd54704f8c0b51a09231fe37a6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dc1018cd54704f8c0b51a09231fe37a6() : base() {
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
protected override OSList<RC_8683fa01451331ed9f0e01f837305895> NewList() {
return new RL_dc1018cd54704f8c0b51a09231fe37a6();
}


} // RL_dc1018cd54704f8c0b51a09231fe37a6
}

