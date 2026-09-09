namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (3cxPuSoMV0G80JmGI+ZkrQ)
///  <code>RC_0f5ff14dc8300879cf7234ab714e1aa5</code> that represent
/// s <code>ZMXFFIMF_RETEN_PROVEEDORESReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXFFIMF_RETEN_PROVEEDORESReqRecord
public partial struct RC_0f5ff14dc8300879cf7234ab714e1aa5 : ITypedRecord<RC_0f5ff14dc8300879cf7234ab714e1aa5> {
internal static readonly GlobalObjectKey IdZMXFFIMF_RETEN_PROVEEDORESReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TfFfDzDIeQjPcjSrcU4apQ");

public ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure ssSTZMXFFIMF_RETEN_PROVEEDORESReq;


public static implicit operator ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure( RC_0f5ff14dc8300879cf7234ab714e1aa5 r) {
return r.ssSTZMXFFIMF_RETEN_PROVEEDORESReq;
}

public static implicit operator RC_0f5ff14dc8300879cf7234ab714e1aa5 (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure r) {
RC_0f5ff14dc8300879cf7234ab714e1aa5 res = new RC_0f5ff14dc8300879cf7234ab714e1aa5 ();
res.ssSTZMXFFIMF_RETEN_PROVEEDORESReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0f5ff14dc8300879cf7234ab714e1aa5() {
OptimizedAttributes = null;
ssSTZMXFFIMF_RETEN_PROVEEDORESReq = new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure();
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
    ssSTZMXFFIMF_RETEN_PROVEEDORESReq.OptimizedAttributes = value[0];
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
ssSTZMXFFIMF_RETEN_PROVEEDORESReq.Read( r, ref index);
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
public void ReadIM(RC_0f5ff14dc8300879cf7234ab714e1aa5 r) {
this = r;
}


public static bool operator == (RC_0f5ff14dc8300879cf7234ab714e1aa5 a, RC_0f5ff14dc8300879cf7234ab714e1aa5 b) {
if (a.ssSTZMXFFIMF_RETEN_PROVEEDORESReq != b.ssSTZMXFFIMF_RETEN_PROVEEDORESReq) return false;
return true;
}

public static bool operator != (RC_0f5ff14dc8300879cf7234ab714e1aa5 a, RC_0f5ff14dc8300879cf7234ab714e1aa5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0f5ff14dc8300879cf7234ab714e1aa5)) return false;
return (this == (RC_0f5ff14dc8300879cf7234ab714e1aa5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXFFIMF_RETEN_PROVEEDORESReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXFFIMF_RETEN_PROVEEDORESReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXFFIMF_RETEN_PROVEEDORESReq.InternalRecursiveSave();
}


public RC_0f5ff14dc8300879cf7234ab714e1aa5 Duplicate() {
RC_0f5ff14dc8300879cf7234ab714e1aa5 t;
t.ssSTZMXFFIMF_RETEN_PROVEEDORESReq = (ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure)this.ssSTZMXFFIMF_RETEN_PROVEEDORESReq.Duplicate();
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
if (head == "zmxffimf_reten_proveedoresreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXFFIMF_RETEN_PROVEEDORESReq")) variable.Value = ssSTZMXFFIMF_RETEN_PROVEEDORESReq; else variable.Optimized = true;
variable.SetFieldName("zmxffimf_reten_proveedoresreq");
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
if (key == IdZMXFFIMF_RETEN_PROVEEDORESReq) {
return ssSTZMXFFIMF_RETEN_PROVEEDORESReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXFFIMF_RETEN_PROVEEDORESReq.Key.AsGuid) {
return ssSTZMXFFIMF_RETEN_PROVEEDORESReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXFFIMF_RETEN_PROVEEDORESReq.FillFromOther((IRecord) other.AttributeGet(IdZMXFFIMF_RETEN_PROVEEDORESReq));
}
} // RC_0f5ff14dc8300879cf7234ab714e1aa5
/// <summary>
/// RecordList type <code>ZMXFFIMF_RETEN_PROVEEDORESReqRecordList</code> that represents a record list
///  of <code>ZMXFFIMF_RETEN_PROVEEDORESReq</code>
/// </summary>
public partial class RL_a22aa58f3a9e28b9690754fdf612d8f3 : GenericRecordList<RC_0f5ff14dc8300879cf7234ab714e1aa5>, IEnumerable, IEnumerator {

protected override RC_0f5ff14dc8300879cf7234ab714e1aa5 GetElementDefaultValue() {
return new RC_0f5ff14dc8300879cf7234ab714e1aa5();
}

public T[] ToArray<T>(Func<RC_0f5ff14dc8300879cf7234ab714e1aa5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a22aa58f3a9e28b9690754fdf612d8f3 recordList, Func<RC_0f5ff14dc8300879cf7234ab714e1aa5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a22aa58f3a9e28b9690754fdf612d8f3(RC_0f5ff14dc8300879cf7234ab714e1aa5[] array) {
  RL_a22aa58f3a9e28b9690754fdf612d8f3 result = new RL_a22aa58f3a9e28b9690754fdf612d8f3();
result.InnerFromArray(array);
    return result;
}

public static RL_a22aa58f3a9e28b9690754fdf612d8f3 ToList<T>(T[] array, Func <T, RC_0f5ff14dc8300879cf7234ab714e1aa5> converter) {
  RL_a22aa58f3a9e28b9690754fdf612d8f3 result = new RL_a22aa58f3a9e28b9690754fdf612d8f3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a22aa58f3a9e28b9690754fdf612d8f3 FromRestList<T>(RestList<T> restList, Func <T, RC_0f5ff14dc8300879cf7234ab714e1aa5> converter) {
  RL_a22aa58f3a9e28b9690754fdf612d8f3 result = new RL_a22aa58f3a9e28b9690754fdf612d8f3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a22aa58f3a9e28b9690754fdf612d8f3() : base() {
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
protected override OSList<RC_0f5ff14dc8300879cf7234ab714e1aa5> NewList() {
return new RL_a22aa58f3a9e28b9690754fdf612d8f3();
}


} // RL_a22aa58f3a9e28b9690754fdf612d8f3
}

