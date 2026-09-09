namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (M0Zw5gmeXUWry3KlAZC88Q)
///  <code>RC_e3f97a835052a7077c357e00e680711c</code> that represent
/// s <code>ZMXMIMMF_ESTD_CUENTA_COSMOZReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_ESTD_CUENTA_COSMOZReqRecord
public partial struct RC_e3f97a835052a7077c357e00e680711c : ITypedRecord<RC_e3f97a835052a7077c357e00e680711c> {
internal static readonly GlobalObjectKey IdZMXMIMMF_ESTD_CUENTA_COSMOZReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*g3r541JQB6d8NX4A5oBxHA");

public ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq;


public static implicit operator ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure( RC_e3f97a835052a7077c357e00e680711c r) {
return r.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq;
}

public static implicit operator RC_e3f97a835052a7077c357e00e680711c (ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure r) {
RC_e3f97a835052a7077c357e00e680711c res = new RC_e3f97a835052a7077c357e00e680711c ();
res.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e3f97a835052a7077c357e00e680711c() {
OptimizedAttributes = null;
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq = new ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure();
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
    ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq.Read( r, ref index);
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
public void ReadIM(RC_e3f97a835052a7077c357e00e680711c r) {
this = r;
}


public static bool operator == (RC_e3f97a835052a7077c357e00e680711c a, RC_e3f97a835052a7077c357e00e680711c b) {
if (a.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq != b.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq) return false;
return true;
}

public static bool operator != (RC_e3f97a835052a7077c357e00e680711c a, RC_e3f97a835052a7077c357e00e680711c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e3f97a835052a7077c357e00e680711c)) return false;
return (this == (RC_e3f97a835052a7077c357e00e680711c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq.InternalRecursiveSave();
}


public RC_e3f97a835052a7077c357e00e680711c Duplicate() {
RC_e3f97a835052a7077c357e00e680711c t;
t.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq = (ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure)this.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq.Duplicate();
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
if (head == "zmxmimmf_estd_cuenta_cosmozreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_ESTD_CUENTA_COSMOZReq")) variable.Value = ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_estd_cuenta_cosmozreq");
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
if (key == IdZMXMIMMF_ESTD_CUENTA_COSMOZReq) {
return ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_ESTD_CUENTA_COSMOZReq.Key.AsGuid) {
return ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZReq.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_ESTD_CUENTA_COSMOZReq));
}
} // RC_e3f97a835052a7077c357e00e680711c
/// <summary>
/// RecordList type <code>ZMXMIMMF_ESTD_CUENTA_COSMOZReqRecordList</code> that represents a record list
///  of <code>ZMXMIMMF_ESTD_CUENTA_COSMOZReq</code>
/// </summary>
public partial class RL_5fb13fb68d878389a9d1f418ee27c09b : GenericRecordList<RC_e3f97a835052a7077c357e00e680711c>, IEnumerable, IEnumerator {

protected override RC_e3f97a835052a7077c357e00e680711c GetElementDefaultValue() {
return new RC_e3f97a835052a7077c357e00e680711c();
}

public T[] ToArray<T>(Func<RC_e3f97a835052a7077c357e00e680711c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5fb13fb68d878389a9d1f418ee27c09b recordList, Func<RC_e3f97a835052a7077c357e00e680711c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5fb13fb68d878389a9d1f418ee27c09b(RC_e3f97a835052a7077c357e00e680711c[] array) {
  RL_5fb13fb68d878389a9d1f418ee27c09b result = new RL_5fb13fb68d878389a9d1f418ee27c09b();
result.InnerFromArray(array);
    return result;
}

public static RL_5fb13fb68d878389a9d1f418ee27c09b ToList<T>(T[] array, Func <T, RC_e3f97a835052a7077c357e00e680711c> converter) {
  RL_5fb13fb68d878389a9d1f418ee27c09b result = new RL_5fb13fb68d878389a9d1f418ee27c09b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5fb13fb68d878389a9d1f418ee27c09b FromRestList<T>(RestList<T> restList, Func <T, RC_e3f97a835052a7077c357e00e680711c> converter) {
  RL_5fb13fb68d878389a9d1f418ee27c09b result = new RL_5fb13fb68d878389a9d1f418ee27c09b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5fb13fb68d878389a9d1f418ee27c09b() : base() {
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
protected override OSList<RC_e3f97a835052a7077c357e00e680711c> NewList() {
return new RL_5fb13fb68d878389a9d1f418ee27c09b();
}


} // RL_5fb13fb68d878389a9d1f418ee27c09b
}

