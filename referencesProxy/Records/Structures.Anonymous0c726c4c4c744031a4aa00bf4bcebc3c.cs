namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (TGxyDHRMMUCkqgC_S868PA)
///  <code>RC_fb484da40dd0ef932a872c89efe253b4</code> that represent
/// s <code>ZMXFFIMF_RETEN_PROVEEDORESRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXFFIMF_RETEN_PROVEEDORESRespRecord
public partial struct RC_fb484da40dd0ef932a872c89efe253b4 : ITypedRecord<RC_fb484da40dd0ef932a872c89efe253b4> {
internal static readonly GlobalObjectKey IdZMXFFIMF_RETEN_PROVEEDORESResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pE1I+9ANk+8qhyyJ7+JTtA");

public ST_b29967856499aeaa8c796dc87fe4c6e8Structure ssSTZMXFFIMF_RETEN_PROVEEDORESResp;


public static implicit operator ST_b29967856499aeaa8c796dc87fe4c6e8Structure( RC_fb484da40dd0ef932a872c89efe253b4 r) {
return r.ssSTZMXFFIMF_RETEN_PROVEEDORESResp;
}

public static implicit operator RC_fb484da40dd0ef932a872c89efe253b4 (ST_b29967856499aeaa8c796dc87fe4c6e8Structure r) {
RC_fb484da40dd0ef932a872c89efe253b4 res = new RC_fb484da40dd0ef932a872c89efe253b4 ();
res.ssSTZMXFFIMF_RETEN_PROVEEDORESResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fb484da40dd0ef932a872c89efe253b4() {
OptimizedAttributes = null;
ssSTZMXFFIMF_RETEN_PROVEEDORESResp = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();
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
    ssSTZMXFFIMF_RETEN_PROVEEDORESResp.OptimizedAttributes = value[0];
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
ssSTZMXFFIMF_RETEN_PROVEEDORESResp.Read( r, ref index);
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
public void ReadIM(RC_fb484da40dd0ef932a872c89efe253b4 r) {
this = r;
}


public static bool operator == (RC_fb484da40dd0ef932a872c89efe253b4 a, RC_fb484da40dd0ef932a872c89efe253b4 b) {
if (a.ssSTZMXFFIMF_RETEN_PROVEEDORESResp != b.ssSTZMXFFIMF_RETEN_PROVEEDORESResp) return false;
return true;
}

public static bool operator != (RC_fb484da40dd0ef932a872c89efe253b4 a, RC_fb484da40dd0ef932a872c89efe253b4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fb484da40dd0ef932a872c89efe253b4)) return false;
return (this == (RC_fb484da40dd0ef932a872c89efe253b4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXFFIMF_RETEN_PROVEEDORESResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXFFIMF_RETEN_PROVEEDORESResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXFFIMF_RETEN_PROVEEDORESResp.InternalRecursiveSave();
}


public RC_fb484da40dd0ef932a872c89efe253b4 Duplicate() {
RC_fb484da40dd0ef932a872c89efe253b4 t;
t.ssSTZMXFFIMF_RETEN_PROVEEDORESResp = (ST_b29967856499aeaa8c796dc87fe4c6e8Structure)this.ssSTZMXFFIMF_RETEN_PROVEEDORESResp.Duplicate();
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
if (head == "zmxffimf_reten_proveedoresresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXFFIMF_RETEN_PROVEEDORESResp")) variable.Value = ssSTZMXFFIMF_RETEN_PROVEEDORESResp; else variable.Optimized = true;
variable.SetFieldName("zmxffimf_reten_proveedoresresp");
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
if (key == IdZMXFFIMF_RETEN_PROVEEDORESResp) {
return ssSTZMXFFIMF_RETEN_PROVEEDORESResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXFFIMF_RETEN_PROVEEDORESResp.Key.AsGuid) {
return ssSTZMXFFIMF_RETEN_PROVEEDORESResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXFFIMF_RETEN_PROVEEDORESResp.FillFromOther((IRecord) other.AttributeGet(IdZMXFFIMF_RETEN_PROVEEDORESResp));
}
} // RC_fb484da40dd0ef932a872c89efe253b4
/// <summary>
/// RecordList type <code>ZMXFFIMF_RETEN_PROVEEDORESRespRecordList</code> that represents a record list
///  of <code>ZMXFFIMF_RETEN_PROVEEDORESResp</code>
/// </summary>
public partial class RL_472fd1713a86597b48c88ff8f5680ed0 : GenericRecordList<RC_fb484da40dd0ef932a872c89efe253b4>, IEnumerable, IEnumerator {

protected override RC_fb484da40dd0ef932a872c89efe253b4 GetElementDefaultValue() {
return new RC_fb484da40dd0ef932a872c89efe253b4();
}

public T[] ToArray<T>(Func<RC_fb484da40dd0ef932a872c89efe253b4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_472fd1713a86597b48c88ff8f5680ed0 recordList, Func<RC_fb484da40dd0ef932a872c89efe253b4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_472fd1713a86597b48c88ff8f5680ed0(RC_fb484da40dd0ef932a872c89efe253b4[] array) {
  RL_472fd1713a86597b48c88ff8f5680ed0 result = new RL_472fd1713a86597b48c88ff8f5680ed0();
result.InnerFromArray(array);
    return result;
}

public static RL_472fd1713a86597b48c88ff8f5680ed0 ToList<T>(T[] array, Func <T, RC_fb484da40dd0ef932a872c89efe253b4> converter) {
  RL_472fd1713a86597b48c88ff8f5680ed0 result = new RL_472fd1713a86597b48c88ff8f5680ed0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_472fd1713a86597b48c88ff8f5680ed0 FromRestList<T>(RestList<T> restList, Func <T, RC_fb484da40dd0ef932a872c89efe253b4> converter) {
  RL_472fd1713a86597b48c88ff8f5680ed0 result = new RL_472fd1713a86597b48c88ff8f5680ed0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_472fd1713a86597b48c88ff8f5680ed0() : base() {
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
protected override OSList<RC_fb484da40dd0ef932a872c89efe253b4> NewList() {
return new RL_472fd1713a86597b48c88ff8f5680ed0();
}


} // RL_472fd1713a86597b48c88ff8f5680ed0
}

