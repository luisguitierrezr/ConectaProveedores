namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (1+JtbIjzCUq9e7RDlVOe3A)
///  <code>RC_fb2347f1fe6bd56b4233b13a791f4550</code> that represent
/// s <code>ZMXFFIMF_0250_FI_CREATE_RELATRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXFFIMF_0250_FI_CREATE_RELATRespRecord
public partial struct RC_fb2347f1fe6bd56b4233b13a791f4550 : ITypedRecord<RC_fb2347f1fe6bd56b4233b13a791f4550> {
internal static readonly GlobalObjectKey IdZMXFFIMF_0250_FI_CREATE_RELATResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8Ucj+2v+a9VCM7E6eR9FUA");

public ST_31a464e509d55210f80b735594283423Structure ssSTZMXFFIMF_0250_FI_CREATE_RELATResp;


public static implicit operator ST_31a464e509d55210f80b735594283423Structure( RC_fb2347f1fe6bd56b4233b13a791f4550 r) {
return r.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp;
}

public static implicit operator RC_fb2347f1fe6bd56b4233b13a791f4550 (ST_31a464e509d55210f80b735594283423Structure r) {
RC_fb2347f1fe6bd56b4233b13a791f4550 res = new RC_fb2347f1fe6bd56b4233b13a791f4550 ();
res.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fb2347f1fe6bd56b4233b13a791f4550() {
OptimizedAttributes = null;
ssSTZMXFFIMF_0250_FI_CREATE_RELATResp = new ST_31a464e509d55210f80b735594283423Structure();
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
    ssSTZMXFFIMF_0250_FI_CREATE_RELATResp.OptimizedAttributes = value[0];
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
ssSTZMXFFIMF_0250_FI_CREATE_RELATResp.Read( r, ref index);
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
public void ReadIM(RC_fb2347f1fe6bd56b4233b13a791f4550 r) {
this = r;
}


public static bool operator == (RC_fb2347f1fe6bd56b4233b13a791f4550 a, RC_fb2347f1fe6bd56b4233b13a791f4550 b) {
if (a.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp != b.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp) return false;
return true;
}

public static bool operator != (RC_fb2347f1fe6bd56b4233b13a791f4550 a, RC_fb2347f1fe6bd56b4233b13a791f4550 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fb2347f1fe6bd56b4233b13a791f4550)) return false;
return (this == (RC_fb2347f1fe6bd56b4233b13a791f4550)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXFFIMF_0250_FI_CREATE_RELATResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXFFIMF_0250_FI_CREATE_RELATResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXFFIMF_0250_FI_CREATE_RELATResp.InternalRecursiveSave();
}


public RC_fb2347f1fe6bd56b4233b13a791f4550 Duplicate() {
RC_fb2347f1fe6bd56b4233b13a791f4550 t;
t.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp = (ST_31a464e509d55210f80b735594283423Structure)this.ssSTZMXFFIMF_0250_FI_CREATE_RELATResp.Duplicate();
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
if (head == "zmxffimf_0250_fi_create_relatresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXFFIMF_0250_FI_CREATE_RELATResp")) variable.Value = ssSTZMXFFIMF_0250_FI_CREATE_RELATResp; else variable.Optimized = true;
variable.SetFieldName("zmxffimf_0250_fi_create_relatresp");
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
if (key == IdZMXFFIMF_0250_FI_CREATE_RELATResp) {
return ssSTZMXFFIMF_0250_FI_CREATE_RELATResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXFFIMF_0250_FI_CREATE_RELATResp.Key.AsGuid) {
return ssSTZMXFFIMF_0250_FI_CREATE_RELATResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXFFIMF_0250_FI_CREATE_RELATResp.FillFromOther((IRecord) other.AttributeGet(IdZMXFFIMF_0250_FI_CREATE_RELATResp));
}
} // RC_fb2347f1fe6bd56b4233b13a791f4550
/// <summary>
/// RecordList type <code>ZMXFFIMF_0250_FI_CREATE_RELATRespRecordList</code> that represents a record
///  list of <code>ZMXFFIMF_0250_FI_CREATE_RELATResp</code>
/// </summary>
public partial class RL_1619f878118f2ba3bafef604e4ac5ce0 : GenericRecordList<RC_fb2347f1fe6bd56b4233b13a791f4550>, IEnumerable, IEnumerator {

protected override RC_fb2347f1fe6bd56b4233b13a791f4550 GetElementDefaultValue() {
return new RC_fb2347f1fe6bd56b4233b13a791f4550();
}

public T[] ToArray<T>(Func<RC_fb2347f1fe6bd56b4233b13a791f4550, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1619f878118f2ba3bafef604e4ac5ce0 recordList, Func<RC_fb2347f1fe6bd56b4233b13a791f4550, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1619f878118f2ba3bafef604e4ac5ce0(RC_fb2347f1fe6bd56b4233b13a791f4550[] array) {
  RL_1619f878118f2ba3bafef604e4ac5ce0 result = new RL_1619f878118f2ba3bafef604e4ac5ce0();
result.InnerFromArray(array);
    return result;
}

public static RL_1619f878118f2ba3bafef604e4ac5ce0 ToList<T>(T[] array, Func <T, RC_fb2347f1fe6bd56b4233b13a791f4550> converter) {
  RL_1619f878118f2ba3bafef604e4ac5ce0 result = new RL_1619f878118f2ba3bafef604e4ac5ce0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1619f878118f2ba3bafef604e4ac5ce0 FromRestList<T>(RestList<T> restList, Func <T, RC_fb2347f1fe6bd56b4233b13a791f4550> converter) {
  RL_1619f878118f2ba3bafef604e4ac5ce0 result = new RL_1619f878118f2ba3bafef604e4ac5ce0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1619f878118f2ba3bafef604e4ac5ce0() : base() {
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
protected override OSList<RC_fb2347f1fe6bd56b4233b13a791f4550> NewList() {
return new RL_1619f878118f2ba3bafef604e4ac5ce0();
}


} // RL_1619f878118f2ba3bafef604e4ac5ce0
}

