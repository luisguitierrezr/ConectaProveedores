namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ctmfy1blqUGtnjq8zh8Rqg)
///  <code>RC_f74790f9f925ee8b861e1bdb891704ae</code> that represent
/// s <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_ReqRecord</code> <p>Description: </p>
/// </summary>
// Name: BAPI_ZMXFAPMF_CONSUL_RETENPROV_ReqRecord
public partial struct RC_f74790f9f925ee8b861e1bdb891704ae : ITypedRecord<RC_f74790f9f925ee8b861e1bdb891704ae> {
internal static readonly GlobalObjectKey IdBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+ZBH9yX5i+6GHhvbiRcErg");

public ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req;


public static implicit operator ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure( RC_f74790f9f925ee8b861e1bdb891704ae r) {
return r.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req;
}

public static implicit operator RC_f74790f9f925ee8b861e1bdb891704ae (ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure r) {
RC_f74790f9f925ee8b861e1bdb891704ae res = new RC_f74790f9f925ee8b861e1bdb891704ae ();
res.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f74790f9f925ee8b861e1bdb891704ae() {
OptimizedAttributes = null;
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure();
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
    ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.OptimizedAttributes = value[0];
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
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.Read( r, ref index);
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
public void ReadIM(RC_f74790f9f925ee8b861e1bdb891704ae r) {
this = r;
}


public static bool operator == (RC_f74790f9f925ee8b861e1bdb891704ae a, RC_f74790f9f925ee8b861e1bdb891704ae b) {
if (a.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req != b.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req) return false;
return true;
}

public static bool operator != (RC_f74790f9f925ee8b861e1bdb891704ae a, RC_f74790f9f925ee8b861e1bdb891704ae b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f74790f9f925ee8b861e1bdb891704ae)) return false;
return (this == (RC_f74790f9f925ee8b861e1bdb891704ae)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.InternalRecursiveSave();
}


public RC_f74790f9f925ee8b861e1bdb891704ae Duplicate() {
RC_f74790f9f925ee8b861e1bdb891704ae t;
t.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req = (ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure)this.ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.Duplicate();
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
if (head == "bapi_zmxfapmf_consul_retenprov_req") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req")) variable.Value = ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req; else variable.Optimized = true;
variable.SetFieldName("bapi_zmxfapmf_consul_retenprov_req");
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
if (key == IdBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req) {
return ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.Key.AsGuid) {
return ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req.FillFromOther((IRecord) other.AttributeGet(IdBAPI_ZMXFAPMF_CONSUL_RETENPROV_Req));
}
} // RC_f74790f9f925ee8b861e1bdb891704ae
/// <summary>
/// RecordList type <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_ReqRecordList</code> that represents a record
///  list of <code>BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req</code>
/// </summary>
public partial class RL_21e6a14df5ae8b3391df175a3c537150 : GenericRecordList<RC_f74790f9f925ee8b861e1bdb891704ae>, IEnumerable, IEnumerator {

protected override RC_f74790f9f925ee8b861e1bdb891704ae GetElementDefaultValue() {
return new RC_f74790f9f925ee8b861e1bdb891704ae();
}

public T[] ToArray<T>(Func<RC_f74790f9f925ee8b861e1bdb891704ae, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_21e6a14df5ae8b3391df175a3c537150 recordList, Func<RC_f74790f9f925ee8b861e1bdb891704ae, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_21e6a14df5ae8b3391df175a3c537150(RC_f74790f9f925ee8b861e1bdb891704ae[] array) {
  RL_21e6a14df5ae8b3391df175a3c537150 result = new RL_21e6a14df5ae8b3391df175a3c537150();
result.InnerFromArray(array);
    return result;
}

public static RL_21e6a14df5ae8b3391df175a3c537150 ToList<T>(T[] array, Func <T, RC_f74790f9f925ee8b861e1bdb891704ae> converter) {
  RL_21e6a14df5ae8b3391df175a3c537150 result = new RL_21e6a14df5ae8b3391df175a3c537150();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_21e6a14df5ae8b3391df175a3c537150 FromRestList<T>(RestList<T> restList, Func <T, RC_f74790f9f925ee8b861e1bdb891704ae> converter) {
  RL_21e6a14df5ae8b3391df175a3c537150 result = new RL_21e6a14df5ae8b3391df175a3c537150();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_21e6a14df5ae8b3391df175a3c537150() : base() {
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
protected override OSList<RC_f74790f9f925ee8b861e1bdb891704ae> NewList() {
return new RL_21e6a14df5ae8b3391df175a3c537150();
}


} // RL_21e6a14df5ae8b3391df175a3c537150
}

