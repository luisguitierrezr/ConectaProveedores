namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3RbIfx84AUKIQJ0NK4rFsg)
///  <code>RC_8e7b41268a95e1ad7ec0b5b322dfb1e7</code> that represent
/// s <code>ZMXFFIMF_CONTA_FACTURASRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXFFIMF_CONTA_FACTURASRespRecord
public partial struct RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 : ITypedRecord<RC_8e7b41268a95e1ad7ec0b5b322dfb1e7> {
internal static readonly GlobalObjectKey IdZMXFFIMF_CONTA_FACTURASResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*JkF7jpWKreF+wLWzIt+x5w");

public ST_926df962559a6c34055113c885aa4885Structure ssSTZMXFFIMF_CONTA_FACTURASResp;


public static implicit operator ST_926df962559a6c34055113c885aa4885Structure( RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 r) {
return r.ssSTZMXFFIMF_CONTA_FACTURASResp;
}

public static implicit operator RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 (ST_926df962559a6c34055113c885aa4885Structure r) {
RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 res = new RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 ();
res.ssSTZMXFFIMF_CONTA_FACTURASResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8e7b41268a95e1ad7ec0b5b322dfb1e7() {
OptimizedAttributes = null;
ssSTZMXFFIMF_CONTA_FACTURASResp = new ST_926df962559a6c34055113c885aa4885Structure();
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
    ssSTZMXFFIMF_CONTA_FACTURASResp.OptimizedAttributes = value[0];
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
ssSTZMXFFIMF_CONTA_FACTURASResp.Read( r, ref index);
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
public void ReadIM(RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 r) {
this = r;
}


public static bool operator == (RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 a, RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 b) {
if (a.ssSTZMXFFIMF_CONTA_FACTURASResp != b.ssSTZMXFFIMF_CONTA_FACTURASResp) return false;
return true;
}

public static bool operator != (RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 a, RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8e7b41268a95e1ad7ec0b5b322dfb1e7)) return false;
return (this == (RC_8e7b41268a95e1ad7ec0b5b322dfb1e7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXFFIMF_CONTA_FACTURASResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXFFIMF_CONTA_FACTURASResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXFFIMF_CONTA_FACTURASResp.InternalRecursiveSave();
}


public RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 Duplicate() {
RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 t;
t.ssSTZMXFFIMF_CONTA_FACTURASResp = (ST_926df962559a6c34055113c885aa4885Structure)this.ssSTZMXFFIMF_CONTA_FACTURASResp.Duplicate();
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
if (head == "zmxffimf_conta_facturasresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXFFIMF_CONTA_FACTURASResp")) variable.Value = ssSTZMXFFIMF_CONTA_FACTURASResp; else variable.Optimized = true;
variable.SetFieldName("zmxffimf_conta_facturasresp");
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
if (key == IdZMXFFIMF_CONTA_FACTURASResp) {
return ssSTZMXFFIMF_CONTA_FACTURASResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXFFIMF_CONTA_FACTURASResp.Key.AsGuid) {
return ssSTZMXFFIMF_CONTA_FACTURASResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXFFIMF_CONTA_FACTURASResp.FillFromOther((IRecord) other.AttributeGet(IdZMXFFIMF_CONTA_FACTURASResp));
}
} // RC_8e7b41268a95e1ad7ec0b5b322dfb1e7
/// <summary>
/// RecordList type <code>ZMXFFIMF_CONTA_FACTURASRespRecordList</code> that represents a record list of
///  <code>ZMXFFIMF_CONTA_FACTURASResp</code>
/// </summary>
public partial class RL_8f75b5c2359afcc88bc90a0efd275978 : GenericRecordList<RC_8e7b41268a95e1ad7ec0b5b322dfb1e7>, IEnumerable, IEnumerator {

protected override RC_8e7b41268a95e1ad7ec0b5b322dfb1e7 GetElementDefaultValue() {
return new RC_8e7b41268a95e1ad7ec0b5b322dfb1e7();
}

public T[] ToArray<T>(Func<RC_8e7b41268a95e1ad7ec0b5b322dfb1e7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8f75b5c2359afcc88bc90a0efd275978 recordList, Func<RC_8e7b41268a95e1ad7ec0b5b322dfb1e7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8f75b5c2359afcc88bc90a0efd275978(RC_8e7b41268a95e1ad7ec0b5b322dfb1e7[] array) {
  RL_8f75b5c2359afcc88bc90a0efd275978 result = new RL_8f75b5c2359afcc88bc90a0efd275978();
result.InnerFromArray(array);
    return result;
}

public static RL_8f75b5c2359afcc88bc90a0efd275978 ToList<T>(T[] array, Func <T, RC_8e7b41268a95e1ad7ec0b5b322dfb1e7> converter) {
  RL_8f75b5c2359afcc88bc90a0efd275978 result = new RL_8f75b5c2359afcc88bc90a0efd275978();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8f75b5c2359afcc88bc90a0efd275978 FromRestList<T>(RestList<T> restList, Func <T, RC_8e7b41268a95e1ad7ec0b5b322dfb1e7> converter) {
  RL_8f75b5c2359afcc88bc90a0efd275978 result = new RL_8f75b5c2359afcc88bc90a0efd275978();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8f75b5c2359afcc88bc90a0efd275978() : base() {
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
protected override OSList<RC_8e7b41268a95e1ad7ec0b5b322dfb1e7> NewList() {
return new RL_8f75b5c2359afcc88bc90a0efd275978();
}


} // RL_8f75b5c2359afcc88bc90a0efd275978
}

