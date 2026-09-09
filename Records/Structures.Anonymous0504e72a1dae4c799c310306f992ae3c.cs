namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (KucEBa4deUycMQMG+ZKuPA)
///  <code>RC_0e7ae7b08ef9d51cb994ca1e00306a2a</code> that represent
/// s <code>EM_SM_RM_COSMOZ_ResponseRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_RM_COSMOZ_ResponseRecord
public partial struct RC_0e7ae7b08ef9d51cb994ca1e00306a2a : ITypedRecord<RC_0e7ae7b08ef9d51cb994ca1e00306a2a> {
internal static readonly GlobalObjectKey IdEM_SM_RM_COSMOZ_Response = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sOd6DvmOHNW5lMoeADBqKg");

public ST_b3b2573902c6e22d9647e405d3baf728Structure ssSTEM_SM_RM_COSMOZ_Response;


public static implicit operator ST_b3b2573902c6e22d9647e405d3baf728Structure( RC_0e7ae7b08ef9d51cb994ca1e00306a2a r) {
return r.ssSTEM_SM_RM_COSMOZ_Response;
}

public static implicit operator RC_0e7ae7b08ef9d51cb994ca1e00306a2a (ST_b3b2573902c6e22d9647e405d3baf728Structure r) {
RC_0e7ae7b08ef9d51cb994ca1e00306a2a res = new RC_0e7ae7b08ef9d51cb994ca1e00306a2a ();
res.ssSTEM_SM_RM_COSMOZ_Response = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0e7ae7b08ef9d51cb994ca1e00306a2a() {
OptimizedAttributes = null;
ssSTEM_SM_RM_COSMOZ_Response = new ST_b3b2573902c6e22d9647e405d3baf728Structure();
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
    ssSTEM_SM_RM_COSMOZ_Response.OptimizedAttributes = value[0];
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
ssSTEM_SM_RM_COSMOZ_Response.Read( r, ref index);
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
public void ReadIM(RC_0e7ae7b08ef9d51cb994ca1e00306a2a r) {
this = r;
}


public static bool operator == (RC_0e7ae7b08ef9d51cb994ca1e00306a2a a, RC_0e7ae7b08ef9d51cb994ca1e00306a2a b) {
if (a.ssSTEM_SM_RM_COSMOZ_Response != b.ssSTEM_SM_RM_COSMOZ_Response) return false;
return true;
}

public static bool operator != (RC_0e7ae7b08ef9d51cb994ca1e00306a2a a, RC_0e7ae7b08ef9d51cb994ca1e00306a2a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0e7ae7b08ef9d51cb994ca1e00306a2a)) return false;
return (this == (RC_0e7ae7b08ef9d51cb994ca1e00306a2a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_RM_COSMOZ_Response.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_RM_COSMOZ_Response.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_RM_COSMOZ_Response.InternalRecursiveSave();
}


public RC_0e7ae7b08ef9d51cb994ca1e00306a2a Duplicate() {
RC_0e7ae7b08ef9d51cb994ca1e00306a2a t;
t.ssSTEM_SM_RM_COSMOZ_Response = (ST_b3b2573902c6e22d9647e405d3baf728Structure)this.ssSTEM_SM_RM_COSMOZ_Response.Duplicate();
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
if (head == "em_sm_rm_cosmoz_response") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_RM_COSMOZ_Response")) variable.Value = ssSTEM_SM_RM_COSMOZ_Response; else variable.Optimized = true;
variable.SetFieldName("em_sm_rm_cosmoz_response");
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
if (key == IdEM_SM_RM_COSMOZ_Response) {
return ssSTEM_SM_RM_COSMOZ_Response;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_RM_COSMOZ_Response.Key.AsGuid) {
return ssSTEM_SM_RM_COSMOZ_Response;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_RM_COSMOZ_Response.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_RM_COSMOZ_Response));
}
} // RC_0e7ae7b08ef9d51cb994ca1e00306a2a
/// <summary>
/// RecordList type <code>EM_SM_RM_COSMOZ_ResponseRecordList</code> that represents a record list of
///  <code>EM_SM_RM_COSMOZ_Response</code>
/// </summary>
public partial class RL_fcda5c0fe077381ca08741fad5b2a4fe : GenericRecordList<RC_0e7ae7b08ef9d51cb994ca1e00306a2a>, IEnumerable, IEnumerator {

protected override RC_0e7ae7b08ef9d51cb994ca1e00306a2a GetElementDefaultValue() {
return new RC_0e7ae7b08ef9d51cb994ca1e00306a2a();
}

public T[] ToArray<T>(Func<RC_0e7ae7b08ef9d51cb994ca1e00306a2a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fcda5c0fe077381ca08741fad5b2a4fe recordList, Func<RC_0e7ae7b08ef9d51cb994ca1e00306a2a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fcda5c0fe077381ca08741fad5b2a4fe(RC_0e7ae7b08ef9d51cb994ca1e00306a2a[] array) {
  RL_fcda5c0fe077381ca08741fad5b2a4fe result = new RL_fcda5c0fe077381ca08741fad5b2a4fe();
result.InnerFromArray(array);
    return result;
}

public static RL_fcda5c0fe077381ca08741fad5b2a4fe ToList<T>(T[] array, Func <T, RC_0e7ae7b08ef9d51cb994ca1e00306a2a> converter) {
  RL_fcda5c0fe077381ca08741fad5b2a4fe result = new RL_fcda5c0fe077381ca08741fad5b2a4fe();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fcda5c0fe077381ca08741fad5b2a4fe FromRestList<T>(RestList<T> restList, Func <T, RC_0e7ae7b08ef9d51cb994ca1e00306a2a> converter) {
  RL_fcda5c0fe077381ca08741fad5b2a4fe result = new RL_fcda5c0fe077381ca08741fad5b2a4fe();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fcda5c0fe077381ca08741fad5b2a4fe() : base() {
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
protected override OSList<RC_0e7ae7b08ef9d51cb994ca1e00306a2a> NewList() {
return new RL_fcda5c0fe077381ca08741fad5b2a4fe();
}


} // RL_fcda5c0fe077381ca08741fad5b2a4fe
}

