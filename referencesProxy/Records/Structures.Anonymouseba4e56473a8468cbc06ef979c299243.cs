namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (ZOWk66hzjEa8Bu+XnCmSQw)
///  <code>RC_c6cff6fd026285ecdd3213ebaf518541</code> that represent
/// s <code>EM_SM_MO_COSMOZ_ResponseRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_MO_COSMOZ_ResponseRecord
public partial struct RC_c6cff6fd026285ecdd3213ebaf518541 : ITypedRecord<RC_c6cff6fd026285ecdd3213ebaf518541> {
internal static readonly GlobalObjectKey IdEM_SM_MO_COSMOZ_Response = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_fbPxmIC7IXdMhPrr1GFQQ");

public ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure ssSTEM_SM_MO_COSMOZ_Response;


public static implicit operator ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure( RC_c6cff6fd026285ecdd3213ebaf518541 r) {
return r.ssSTEM_SM_MO_COSMOZ_Response;
}

public static implicit operator RC_c6cff6fd026285ecdd3213ebaf518541 (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure r) {
RC_c6cff6fd026285ecdd3213ebaf518541 res = new RC_c6cff6fd026285ecdd3213ebaf518541 ();
res.ssSTEM_SM_MO_COSMOZ_Response = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c6cff6fd026285ecdd3213ebaf518541() {
OptimizedAttributes = null;
ssSTEM_SM_MO_COSMOZ_Response = new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure();
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
    ssSTEM_SM_MO_COSMOZ_Response.OptimizedAttributes = value[0];
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
ssSTEM_SM_MO_COSMOZ_Response.Read( r, ref index);
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
public void ReadIM(RC_c6cff6fd026285ecdd3213ebaf518541 r) {
this = r;
}


public static bool operator == (RC_c6cff6fd026285ecdd3213ebaf518541 a, RC_c6cff6fd026285ecdd3213ebaf518541 b) {
if (a.ssSTEM_SM_MO_COSMOZ_Response != b.ssSTEM_SM_MO_COSMOZ_Response) return false;
return true;
}

public static bool operator != (RC_c6cff6fd026285ecdd3213ebaf518541 a, RC_c6cff6fd026285ecdd3213ebaf518541 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c6cff6fd026285ecdd3213ebaf518541)) return false;
return (this == (RC_c6cff6fd026285ecdd3213ebaf518541)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_MO_COSMOZ_Response.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_MO_COSMOZ_Response.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_MO_COSMOZ_Response.InternalRecursiveSave();
}


public RC_c6cff6fd026285ecdd3213ebaf518541 Duplicate() {
RC_c6cff6fd026285ecdd3213ebaf518541 t;
t.ssSTEM_SM_MO_COSMOZ_Response = (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure)this.ssSTEM_SM_MO_COSMOZ_Response.Duplicate();
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
if (head == "em_sm_mo_cosmoz_response") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_MO_COSMOZ_Response")) variable.Value = ssSTEM_SM_MO_COSMOZ_Response; else variable.Optimized = true;
variable.SetFieldName("em_sm_mo_cosmoz_response");
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
if (key == IdEM_SM_MO_COSMOZ_Response) {
return ssSTEM_SM_MO_COSMOZ_Response;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_MO_COSMOZ_Response.Key.AsGuid) {
return ssSTEM_SM_MO_COSMOZ_Response;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_MO_COSMOZ_Response.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_MO_COSMOZ_Response));
}
} // RC_c6cff6fd026285ecdd3213ebaf518541
/// <summary>
/// RecordList type <code>EM_SM_MO_COSMOZ_ResponseRecordList</code> that represents a record list of
///  <code>EM_SM_MO_COSMOZ_Response</code>
/// </summary>
public partial class RL_45d87abff973c8d38d3c94d63e5ecd4f : GenericRecordList<RC_c6cff6fd026285ecdd3213ebaf518541>, IEnumerable, IEnumerator {

protected override RC_c6cff6fd026285ecdd3213ebaf518541 GetElementDefaultValue() {
return new RC_c6cff6fd026285ecdd3213ebaf518541();
}

public T[] ToArray<T>(Func<RC_c6cff6fd026285ecdd3213ebaf518541, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_45d87abff973c8d38d3c94d63e5ecd4f recordList, Func<RC_c6cff6fd026285ecdd3213ebaf518541, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_45d87abff973c8d38d3c94d63e5ecd4f(RC_c6cff6fd026285ecdd3213ebaf518541[] array) {
  RL_45d87abff973c8d38d3c94d63e5ecd4f result = new RL_45d87abff973c8d38d3c94d63e5ecd4f();
result.InnerFromArray(array);
    return result;
}

public static RL_45d87abff973c8d38d3c94d63e5ecd4f ToList<T>(T[] array, Func <T, RC_c6cff6fd026285ecdd3213ebaf518541> converter) {
  RL_45d87abff973c8d38d3c94d63e5ecd4f result = new RL_45d87abff973c8d38d3c94d63e5ecd4f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_45d87abff973c8d38d3c94d63e5ecd4f FromRestList<T>(RestList<T> restList, Func <T, RC_c6cff6fd026285ecdd3213ebaf518541> converter) {
  RL_45d87abff973c8d38d3c94d63e5ecd4f result = new RL_45d87abff973c8d38d3c94d63e5ecd4f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_45d87abff973c8d38d3c94d63e5ecd4f() : base() {
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
protected override OSList<RC_c6cff6fd026285ecdd3213ebaf518541> NewList() {
return new RL_45d87abff973c8d38d3c94d63e5ecd4f();
}


} // RL_45d87abff973c8d38d3c94d63e5ecd4f
}

