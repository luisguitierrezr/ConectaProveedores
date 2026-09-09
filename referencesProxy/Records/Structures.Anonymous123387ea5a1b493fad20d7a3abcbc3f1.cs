namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (6oczEhtaP0mtINejq8vD8Q)
///  <code>RC_14a12c4391e73b0f0f3e412d9ecca347</code> that represent
/// s <code>T_FAC_PAG_CAB_InRecord</code> <p>Description: </p>
/// </summary>
// Name: T_FAC_PAG_CAB_InRecord
public partial struct RC_14a12c4391e73b0f0f3e412d9ecca347 : ITypedRecord<RC_14a12c4391e73b0f0f3e412d9ecca347> {
internal static readonly GlobalObjectKey IdT_FAC_PAG_CAB_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QyyhFOeRDzsPPkEtnsyjRw");

public ST_828ac715d3b2e46c74367f017543eab1Structure ssSTT_FAC_PAG_CAB_In;


public static implicit operator ST_828ac715d3b2e46c74367f017543eab1Structure( RC_14a12c4391e73b0f0f3e412d9ecca347 r) {
return r.ssSTT_FAC_PAG_CAB_In;
}

public static implicit operator RC_14a12c4391e73b0f0f3e412d9ecca347 (ST_828ac715d3b2e46c74367f017543eab1Structure r) {
RC_14a12c4391e73b0f0f3e412d9ecca347 res = new RC_14a12c4391e73b0f0f3e412d9ecca347 ();
res.ssSTT_FAC_PAG_CAB_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_14a12c4391e73b0f0f3e412d9ecca347() {
OptimizedAttributes = null;
ssSTT_FAC_PAG_CAB_In = new ST_828ac715d3b2e46c74367f017543eab1Structure();
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
    ssSTT_FAC_PAG_CAB_In.OptimizedAttributes = value[0];
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
ssSTT_FAC_PAG_CAB_In.Read( r, ref index);
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
public void ReadIM(RC_14a12c4391e73b0f0f3e412d9ecca347 r) {
this = r;
}


public static bool operator == (RC_14a12c4391e73b0f0f3e412d9ecca347 a, RC_14a12c4391e73b0f0f3e412d9ecca347 b) {
if (a.ssSTT_FAC_PAG_CAB_In != b.ssSTT_FAC_PAG_CAB_In) return false;
return true;
}

public static bool operator != (RC_14a12c4391e73b0f0f3e412d9ecca347 a, RC_14a12c4391e73b0f0f3e412d9ecca347 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_14a12c4391e73b0f0f3e412d9ecca347)) return false;
return (this == (RC_14a12c4391e73b0f0f3e412d9ecca347)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTT_FAC_PAG_CAB_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTT_FAC_PAG_CAB_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTT_FAC_PAG_CAB_In.InternalRecursiveSave();
}


public RC_14a12c4391e73b0f0f3e412d9ecca347 Duplicate() {
RC_14a12c4391e73b0f0f3e412d9ecca347 t;
t.ssSTT_FAC_PAG_CAB_In = (ST_828ac715d3b2e46c74367f017543eab1Structure)this.ssSTT_FAC_PAG_CAB_In.Duplicate();
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
if (head == "t_fac_pag_cab_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_FAC_PAG_CAB_In")) variable.Value = ssSTT_FAC_PAG_CAB_In; else variable.Optimized = true;
variable.SetFieldName("t_fac_pag_cab_in");
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
if (key == IdT_FAC_PAG_CAB_In) {
return ssSTT_FAC_PAG_CAB_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_FAC_PAG_CAB_In.Key.AsGuid) {
return ssSTT_FAC_PAG_CAB_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTT_FAC_PAG_CAB_In.FillFromOther((IRecord) other.AttributeGet(IdT_FAC_PAG_CAB_In));
}
} // RC_14a12c4391e73b0f0f3e412d9ecca347
/// <summary>
/// RecordList type <code>T_FAC_PAG_CAB_InRecordList</code> that represents a record list of
///  <code>T_FAC_PAG_CAB_In</code>
/// </summary>
public partial class RL_0e6a30d25095e755d9178be52f38266c : GenericRecordList<RC_14a12c4391e73b0f0f3e412d9ecca347>, IEnumerable, IEnumerator {

protected override RC_14a12c4391e73b0f0f3e412d9ecca347 GetElementDefaultValue() {
return new RC_14a12c4391e73b0f0f3e412d9ecca347();
}

public T[] ToArray<T>(Func<RC_14a12c4391e73b0f0f3e412d9ecca347, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0e6a30d25095e755d9178be52f38266c recordList, Func<RC_14a12c4391e73b0f0f3e412d9ecca347, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0e6a30d25095e755d9178be52f38266c(RC_14a12c4391e73b0f0f3e412d9ecca347[] array) {
  RL_0e6a30d25095e755d9178be52f38266c result = new RL_0e6a30d25095e755d9178be52f38266c();
result.InnerFromArray(array);
    return result;
}

public static RL_0e6a30d25095e755d9178be52f38266c ToList<T>(T[] array, Func <T, RC_14a12c4391e73b0f0f3e412d9ecca347> converter) {
  RL_0e6a30d25095e755d9178be52f38266c result = new RL_0e6a30d25095e755d9178be52f38266c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0e6a30d25095e755d9178be52f38266c FromRestList<T>(RestList<T> restList, Func <T, RC_14a12c4391e73b0f0f3e412d9ecca347> converter) {
  RL_0e6a30d25095e755d9178be52f38266c result = new RL_0e6a30d25095e755d9178be52f38266c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0e6a30d25095e755d9178be52f38266c() : base() {
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
protected override OSList<RC_14a12c4391e73b0f0f3e412d9ecca347> NewList() {
return new RL_0e6a30d25095e755d9178be52f38266c();
}


} // RL_0e6a30d25095e755d9178be52f38266c
}

