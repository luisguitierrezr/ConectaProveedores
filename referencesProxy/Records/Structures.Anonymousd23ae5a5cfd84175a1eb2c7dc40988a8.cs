namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (peU60tjPdUGh6yx9xAmIqA)
///  <code>RC_0876bbc223697f964aa1316bf14d647e</code> that represent
/// s <code>ZMXMIMMF_EM_SM_RM_COSMOZReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_RM_COSMOZReqRecord
public partial struct RC_0876bbc223697f964aa1316bf14d647e : ITypedRecord<RC_0876bbc223697f964aa1316bf14d647e> {
internal static readonly GlobalObjectKey IdZMXMIMMF_EM_SM_RM_COSMOZReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wrt2CGkjln9KoTFr8U1kfg");

public ST_e629b825a45e94758f239d11120cb772Structure ssSTZMXMIMMF_EM_SM_RM_COSMOZReq;


public static implicit operator ST_e629b825a45e94758f239d11120cb772Structure( RC_0876bbc223697f964aa1316bf14d647e r) {
return r.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq;
}

public static implicit operator RC_0876bbc223697f964aa1316bf14d647e (ST_e629b825a45e94758f239d11120cb772Structure r) {
RC_0876bbc223697f964aa1316bf14d647e res = new RC_0876bbc223697f964aa1316bf14d647e ();
res.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0876bbc223697f964aa1316bf14d647e() {
OptimizedAttributes = null;
ssSTZMXMIMMF_EM_SM_RM_COSMOZReq = new ST_e629b825a45e94758f239d11120cb772Structure();
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
    ssSTZMXMIMMF_EM_SM_RM_COSMOZReq.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_EM_SM_RM_COSMOZReq.Read( r, ref index);
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
public void ReadIM(RC_0876bbc223697f964aa1316bf14d647e r) {
this = r;
}


public static bool operator == (RC_0876bbc223697f964aa1316bf14d647e a, RC_0876bbc223697f964aa1316bf14d647e b) {
if (a.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq != b.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq) return false;
return true;
}

public static bool operator != (RC_0876bbc223697f964aa1316bf14d647e a, RC_0876bbc223697f964aa1316bf14d647e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0876bbc223697f964aa1316bf14d647e)) return false;
return (this == (RC_0876bbc223697f964aa1316bf14d647e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_EM_SM_RM_COSMOZReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_EM_SM_RM_COSMOZReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_EM_SM_RM_COSMOZReq.InternalRecursiveSave();
}


public RC_0876bbc223697f964aa1316bf14d647e Duplicate() {
RC_0876bbc223697f964aa1316bf14d647e t;
t.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq = (ST_e629b825a45e94758f239d11120cb772Structure)this.ssSTZMXMIMMF_EM_SM_RM_COSMOZReq.Duplicate();
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
if (head == "zmxmimmf_em_sm_rm_cosmozreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_EM_SM_RM_COSMOZReq")) variable.Value = ssSTZMXMIMMF_EM_SM_RM_COSMOZReq; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_em_sm_rm_cosmozreq");
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
if (key == IdZMXMIMMF_EM_SM_RM_COSMOZReq) {
return ssSTZMXMIMMF_EM_SM_RM_COSMOZReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_EM_SM_RM_COSMOZReq.Key.AsGuid) {
return ssSTZMXMIMMF_EM_SM_RM_COSMOZReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_EM_SM_RM_COSMOZReq.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_EM_SM_RM_COSMOZReq));
}
} // RC_0876bbc223697f964aa1316bf14d647e
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_RM_COSMOZReqRecordList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_SM_RM_COSMOZReq</code>
/// </summary>
public partial class RL_cd144944027d75c8d12a4bbe33c59076 : GenericRecordList<RC_0876bbc223697f964aa1316bf14d647e>, IEnumerable, IEnumerator {

protected override RC_0876bbc223697f964aa1316bf14d647e GetElementDefaultValue() {
return new RC_0876bbc223697f964aa1316bf14d647e();
}

public T[] ToArray<T>(Func<RC_0876bbc223697f964aa1316bf14d647e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cd144944027d75c8d12a4bbe33c59076 recordList, Func<RC_0876bbc223697f964aa1316bf14d647e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cd144944027d75c8d12a4bbe33c59076(RC_0876bbc223697f964aa1316bf14d647e[] array) {
  RL_cd144944027d75c8d12a4bbe33c59076 result = new RL_cd144944027d75c8d12a4bbe33c59076();
result.InnerFromArray(array);
    return result;
}

public static RL_cd144944027d75c8d12a4bbe33c59076 ToList<T>(T[] array, Func <T, RC_0876bbc223697f964aa1316bf14d647e> converter) {
  RL_cd144944027d75c8d12a4bbe33c59076 result = new RL_cd144944027d75c8d12a4bbe33c59076();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cd144944027d75c8d12a4bbe33c59076 FromRestList<T>(RestList<T> restList, Func <T, RC_0876bbc223697f964aa1316bf14d647e> converter) {
  RL_cd144944027d75c8d12a4bbe33c59076 result = new RL_cd144944027d75c8d12a4bbe33c59076();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cd144944027d75c8d12a4bbe33c59076() : base() {
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
protected override OSList<RC_0876bbc223697f964aa1316bf14d647e> NewList() {
return new RL_cd144944027d75c8d12a4bbe33c59076();
}


} // RL_cd144944027d75c8d12a4bbe33c59076
}

