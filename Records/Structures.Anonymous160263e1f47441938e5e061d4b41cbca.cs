namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4WMCFnT0k0GOXgYdS0HLyg)
///  <code>RC_e9778c0a791f25dad6b0c1f1b26da61c</code> that represent
/// s <code>BAPI_GL_ACC_GETDETAILReqRecord</code> <p>Description: </p>
/// </summary>
// Name: BAPI_GL_ACC_GETDETAILReqRecord
public partial struct RC_e9778c0a791f25dad6b0c1f1b26da61c : ITypedRecord<RC_e9778c0a791f25dad6b0c1f1b26da61c> {
internal static readonly GlobalObjectKey IdBAPI_GL_ACC_GETDETAILReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Cox36R952iXWsMHxsm2mHA");

public ST_442654d6c8649545cfc0a9d6bfc9f12cStructure ssSTBAPI_GL_ACC_GETDETAILReq;


public static implicit operator ST_442654d6c8649545cfc0a9d6bfc9f12cStructure( RC_e9778c0a791f25dad6b0c1f1b26da61c r) {
return r.ssSTBAPI_GL_ACC_GETDETAILReq;
}

public static implicit operator RC_e9778c0a791f25dad6b0c1f1b26da61c (ST_442654d6c8649545cfc0a9d6bfc9f12cStructure r) {
RC_e9778c0a791f25dad6b0c1f1b26da61c res = new RC_e9778c0a791f25dad6b0c1f1b26da61c ();
res.ssSTBAPI_GL_ACC_GETDETAILReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_e9778c0a791f25dad6b0c1f1b26da61c() {
OptimizedAttributes = null;
ssSTBAPI_GL_ACC_GETDETAILReq = new ST_442654d6c8649545cfc0a9d6bfc9f12cStructure();
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
    ssSTBAPI_GL_ACC_GETDETAILReq.OptimizedAttributes = value[0];
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
ssSTBAPI_GL_ACC_GETDETAILReq.Read( r, ref index);
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
public void ReadIM(RC_e9778c0a791f25dad6b0c1f1b26da61c r) {
this = r;
}


public static bool operator == (RC_e9778c0a791f25dad6b0c1f1b26da61c a, RC_e9778c0a791f25dad6b0c1f1b26da61c b) {
if (a.ssSTBAPI_GL_ACC_GETDETAILReq != b.ssSTBAPI_GL_ACC_GETDETAILReq) return false;
return true;
}

public static bool operator != (RC_e9778c0a791f25dad6b0c1f1b26da61c a, RC_e9778c0a791f25dad6b0c1f1b26da61c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e9778c0a791f25dad6b0c1f1b26da61c)) return false;
return (this == (RC_e9778c0a791f25dad6b0c1f1b26da61c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBAPI_GL_ACC_GETDETAILReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBAPI_GL_ACC_GETDETAILReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBAPI_GL_ACC_GETDETAILReq.InternalRecursiveSave();
}


public RC_e9778c0a791f25dad6b0c1f1b26da61c Duplicate() {
RC_e9778c0a791f25dad6b0c1f1b26da61c t;
t.ssSTBAPI_GL_ACC_GETDETAILReq = (ST_442654d6c8649545cfc0a9d6bfc9f12cStructure)this.ssSTBAPI_GL_ACC_GETDETAILReq.Duplicate();
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
if (head == "bapi_gl_acc_getdetailreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BAPI_GL_ACC_GETDETAILReq")) variable.Value = ssSTBAPI_GL_ACC_GETDETAILReq; else variable.Optimized = true;
variable.SetFieldName("bapi_gl_acc_getdetailreq");
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
if (key == IdBAPI_GL_ACC_GETDETAILReq) {
return ssSTBAPI_GL_ACC_GETDETAILReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBAPI_GL_ACC_GETDETAILReq.Key.AsGuid) {
return ssSTBAPI_GL_ACC_GETDETAILReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBAPI_GL_ACC_GETDETAILReq.FillFromOther((IRecord) other.AttributeGet(IdBAPI_GL_ACC_GETDETAILReq));
}
} // RC_e9778c0a791f25dad6b0c1f1b26da61c
/// <summary>
/// RecordList type <code>BAPI_GL_ACC_GETDETAILReqRecordList</code> that represents a record list of
///  <code>BAPI_GL_ACC_GETDETAILReq</code>
/// </summary>
public partial class RL_4ae8077bfecfadcdbc24394a2b742686 : GenericRecordList<RC_e9778c0a791f25dad6b0c1f1b26da61c>, IEnumerable, IEnumerator {

protected override RC_e9778c0a791f25dad6b0c1f1b26da61c GetElementDefaultValue() {
return new RC_e9778c0a791f25dad6b0c1f1b26da61c();
}

public T[] ToArray<T>(Func<RC_e9778c0a791f25dad6b0c1f1b26da61c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4ae8077bfecfadcdbc24394a2b742686 recordList, Func<RC_e9778c0a791f25dad6b0c1f1b26da61c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4ae8077bfecfadcdbc24394a2b742686(RC_e9778c0a791f25dad6b0c1f1b26da61c[] array) {
  RL_4ae8077bfecfadcdbc24394a2b742686 result = new RL_4ae8077bfecfadcdbc24394a2b742686();
result.InnerFromArray(array);
    return result;
}

public static RL_4ae8077bfecfadcdbc24394a2b742686 ToList<T>(T[] array, Func <T, RC_e9778c0a791f25dad6b0c1f1b26da61c> converter) {
  RL_4ae8077bfecfadcdbc24394a2b742686 result = new RL_4ae8077bfecfadcdbc24394a2b742686();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4ae8077bfecfadcdbc24394a2b742686 FromRestList<T>(RestList<T> restList, Func <T, RC_e9778c0a791f25dad6b0c1f1b26da61c> converter) {
  RL_4ae8077bfecfadcdbc24394a2b742686 result = new RL_4ae8077bfecfadcdbc24394a2b742686();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4ae8077bfecfadcdbc24394a2b742686() : base() {
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
protected override OSList<RC_e9778c0a791f25dad6b0c1f1b26da61c> NewList() {
return new RL_4ae8077bfecfadcdbc24394a2b742686();
}


} // RL_4ae8077bfecfadcdbc24394a2b742686
}

