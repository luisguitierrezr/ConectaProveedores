namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5WPhmBVT1kKOqb2tNUdz_Q)
///  <code>RC_c6cf3e200ddc2179c3439116cd77a508</code> that represent
/// s <code>ZMXFFIMF_0250_FI_CREATE_RELATReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXFFIMF_0250_FI_CREATE_RELATReqRecord
public partial struct RC_c6cf3e200ddc2179c3439116cd77a508 : ITypedRecord<RC_c6cf3e200ddc2179c3439116cd77a508> {
internal static readonly GlobalObjectKey IdZMXFFIMF_0250_FI_CREATE_RELATReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ID7PxtwNeSHDQ5EWzXelCA");

public ST_b9515582922fdbd4d217706a5c5c0f3fStructure ssSTZMXFFIMF_0250_FI_CREATE_RELATReq;


public static implicit operator ST_b9515582922fdbd4d217706a5c5c0f3fStructure( RC_c6cf3e200ddc2179c3439116cd77a508 r) {
return r.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq;
}

public static implicit operator RC_c6cf3e200ddc2179c3439116cd77a508 (ST_b9515582922fdbd4d217706a5c5c0f3fStructure r) {
RC_c6cf3e200ddc2179c3439116cd77a508 res = new RC_c6cf3e200ddc2179c3439116cd77a508 ();
res.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c6cf3e200ddc2179c3439116cd77a508() {
OptimizedAttributes = null;
ssSTZMXFFIMF_0250_FI_CREATE_RELATReq = new ST_b9515582922fdbd4d217706a5c5c0f3fStructure();
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
    ssSTZMXFFIMF_0250_FI_CREATE_RELATReq.OptimizedAttributes = value[0];
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
ssSTZMXFFIMF_0250_FI_CREATE_RELATReq.Read( r, ref index);
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
public void ReadIM(RC_c6cf3e200ddc2179c3439116cd77a508 r) {
this = r;
}


public static bool operator == (RC_c6cf3e200ddc2179c3439116cd77a508 a, RC_c6cf3e200ddc2179c3439116cd77a508 b) {
if (a.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq != b.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq) return false;
return true;
}

public static bool operator != (RC_c6cf3e200ddc2179c3439116cd77a508 a, RC_c6cf3e200ddc2179c3439116cd77a508 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c6cf3e200ddc2179c3439116cd77a508)) return false;
return (this == (RC_c6cf3e200ddc2179c3439116cd77a508)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXFFIMF_0250_FI_CREATE_RELATReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXFFIMF_0250_FI_CREATE_RELATReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXFFIMF_0250_FI_CREATE_RELATReq.InternalRecursiveSave();
}


public RC_c6cf3e200ddc2179c3439116cd77a508 Duplicate() {
RC_c6cf3e200ddc2179c3439116cd77a508 t;
t.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq = (ST_b9515582922fdbd4d217706a5c5c0f3fStructure)this.ssSTZMXFFIMF_0250_FI_CREATE_RELATReq.Duplicate();
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
if (head == "zmxffimf_0250_fi_create_relatreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXFFIMF_0250_FI_CREATE_RELATReq")) variable.Value = ssSTZMXFFIMF_0250_FI_CREATE_RELATReq; else variable.Optimized = true;
variable.SetFieldName("zmxffimf_0250_fi_create_relatreq");
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
if (key == IdZMXFFIMF_0250_FI_CREATE_RELATReq) {
return ssSTZMXFFIMF_0250_FI_CREATE_RELATReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXFFIMF_0250_FI_CREATE_RELATReq.Key.AsGuid) {
return ssSTZMXFFIMF_0250_FI_CREATE_RELATReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXFFIMF_0250_FI_CREATE_RELATReq.FillFromOther((IRecord) other.AttributeGet(IdZMXFFIMF_0250_FI_CREATE_RELATReq));
}
} // RC_c6cf3e200ddc2179c3439116cd77a508
/// <summary>
/// RecordList type <code>ZMXFFIMF_0250_FI_CREATE_RELATReqRecordList</code> that represents a record
///  list of <code>ZMXFFIMF_0250_FI_CREATE_RELATReq</code>
/// </summary>
public partial class RL_e233c95c39992bc1dc781042b67aad2c : GenericRecordList<RC_c6cf3e200ddc2179c3439116cd77a508>, IEnumerable, IEnumerator {

protected override RC_c6cf3e200ddc2179c3439116cd77a508 GetElementDefaultValue() {
return new RC_c6cf3e200ddc2179c3439116cd77a508();
}

public T[] ToArray<T>(Func<RC_c6cf3e200ddc2179c3439116cd77a508, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e233c95c39992bc1dc781042b67aad2c recordList, Func<RC_c6cf3e200ddc2179c3439116cd77a508, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e233c95c39992bc1dc781042b67aad2c(RC_c6cf3e200ddc2179c3439116cd77a508[] array) {
  RL_e233c95c39992bc1dc781042b67aad2c result = new RL_e233c95c39992bc1dc781042b67aad2c();
result.InnerFromArray(array);
    return result;
}

public static RL_e233c95c39992bc1dc781042b67aad2c ToList<T>(T[] array, Func <T, RC_c6cf3e200ddc2179c3439116cd77a508> converter) {
  RL_e233c95c39992bc1dc781042b67aad2c result = new RL_e233c95c39992bc1dc781042b67aad2c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e233c95c39992bc1dc781042b67aad2c FromRestList<T>(RestList<T> restList, Func <T, RC_c6cf3e200ddc2179c3439116cd77a508> converter) {
  RL_e233c95c39992bc1dc781042b67aad2c result = new RL_e233c95c39992bc1dc781042b67aad2c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e233c95c39992bc1dc781042b67aad2c() : base() {
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
protected override OSList<RC_c6cf3e200ddc2179c3439116cd77a508> NewList() {
return new RL_e233c95c39992bc1dc781042b67aad2c();
}


} // RL_e233c95c39992bc1dc781042b67aad2c
}

