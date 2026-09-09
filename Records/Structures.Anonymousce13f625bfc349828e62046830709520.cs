namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (JfYTzsO_gkmOYgRoMHCVIA)
///  <code>RC_8a4029ca829f8e0c0b6507e5280556a7</code> that represent
/// s <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_RespRecord</code> <p>Description: </p>
/// </summary>
// Name: BAPI_ZMXFAPMF_CONSUL_RETENPROV_RespRecord
public partial struct RC_8a4029ca829f8e0c0b6507e5280556a7 : ITypedRecord<RC_8a4029ca829f8e0c0b6507e5280556a7> {
internal static readonly GlobalObjectKey IdBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yilAip+CDI4LZQflKAVWpw");

public ST_24353ddcec93ac51b13ce9ab94fe4001Structure ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp;


public static implicit operator ST_24353ddcec93ac51b13ce9ab94fe4001Structure( RC_8a4029ca829f8e0c0b6507e5280556a7 r) {
return r.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp;
}

public static implicit operator RC_8a4029ca829f8e0c0b6507e5280556a7 (ST_24353ddcec93ac51b13ce9ab94fe4001Structure r) {
RC_8a4029ca829f8e0c0b6507e5280556a7 res = new RC_8a4029ca829f8e0c0b6507e5280556a7 ();
res.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8a4029ca829f8e0c0b6507e5280556a7() {
OptimizedAttributes = null;
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = new ST_24353ddcec93ac51b13ce9ab94fe4001Structure();
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
    ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.OptimizedAttributes = value[0];
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
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.Read( r, ref index);
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
public void ReadIM(RC_8a4029ca829f8e0c0b6507e5280556a7 r) {
this = r;
}


public static bool operator == (RC_8a4029ca829f8e0c0b6507e5280556a7 a, RC_8a4029ca829f8e0c0b6507e5280556a7 b) {
if (a.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp != b.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp) return false;
return true;
}

public static bool operator != (RC_8a4029ca829f8e0c0b6507e5280556a7 a, RC_8a4029ca829f8e0c0b6507e5280556a7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8a4029ca829f8e0c0b6507e5280556a7)) return false;
return (this == (RC_8a4029ca829f8e0c0b6507e5280556a7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.InternalRecursiveSave();
}


public RC_8a4029ca829f8e0c0b6507e5280556a7 Duplicate() {
RC_8a4029ca829f8e0c0b6507e5280556a7 t;
t.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp = (ST_24353ddcec93ac51b13ce9ab94fe4001Structure)this.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.Duplicate();
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
if (head == "bapi_zmxfapmf_consul_retenprov_resp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp")) variable.Value = ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp; else variable.Optimized = true;
variable.SetFieldName("bapi_zmxfapmf_consul_retenprov_resp");
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
if (key == IdBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp) {
return ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.Key.AsGuid) {
return ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp.FillFromOther((IRecord) other.AttributeGet(IdBAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp));
}
} // RC_8a4029ca829f8e0c0b6507e5280556a7
/// <summary>
/// RecordList type <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_RespRecordList</code> that represents a record
///  list of <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_Resp</code>
/// </summary>
public partial class RL_b60fb98048b61d02760f6138dac069bc : GenericRecordList<RC_8a4029ca829f8e0c0b6507e5280556a7>, IEnumerable, IEnumerator {

protected override RC_8a4029ca829f8e0c0b6507e5280556a7 GetElementDefaultValue() {
return new RC_8a4029ca829f8e0c0b6507e5280556a7();
}

public T[] ToArray<T>(Func<RC_8a4029ca829f8e0c0b6507e5280556a7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b60fb98048b61d02760f6138dac069bc recordList, Func<RC_8a4029ca829f8e0c0b6507e5280556a7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b60fb98048b61d02760f6138dac069bc(RC_8a4029ca829f8e0c0b6507e5280556a7[] array) {
  RL_b60fb98048b61d02760f6138dac069bc result = new RL_b60fb98048b61d02760f6138dac069bc();
result.InnerFromArray(array);
    return result;
}

public static RL_b60fb98048b61d02760f6138dac069bc ToList<T>(T[] array, Func <T, RC_8a4029ca829f8e0c0b6507e5280556a7> converter) {
  RL_b60fb98048b61d02760f6138dac069bc result = new RL_b60fb98048b61d02760f6138dac069bc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b60fb98048b61d02760f6138dac069bc FromRestList<T>(RestList<T> restList, Func <T, RC_8a4029ca829f8e0c0b6507e5280556a7> converter) {
  RL_b60fb98048b61d02760f6138dac069bc result = new RL_b60fb98048b61d02760f6138dac069bc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b60fb98048b61d02760f6138dac069bc() : base() {
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
protected override OSList<RC_8a4029ca829f8e0c0b6507e5280556a7> NewList() {
return new RL_b60fb98048b61d02760f6138dac069bc();
}


} // RL_b60fb98048b61d02760f6138dac069bc
}

