namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (4hkPsXnGVUezeJMJ40nBxA)
///  <code>RC_5679bdbd71aac196e22130b3372a6c2b</code> that represent
/// s <code>BAPI_ZMXFFIMF_ACC_DOC_CHANGE_RequestRecord</code> <p>Description: </p>
/// </summary>
// Name: BAPI_ZMXFFIMF_ACC_DOC_CHANGE_RequestRecord
public partial struct RC_5679bdbd71aac196e22130b3372a6c2b : ITypedRecord<RC_5679bdbd71aac196e22130b3372a6c2b> {
internal static readonly GlobalObjectKey IdBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vb15VqpxlsHiITCzNypsKw");

public ST_0cb1a5ee06af693baf5508d00a19d139Structure ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request;


public static implicit operator ST_0cb1a5ee06af693baf5508d00a19d139Structure( RC_5679bdbd71aac196e22130b3372a6c2b r) {
return r.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request;
}

public static implicit operator RC_5679bdbd71aac196e22130b3372a6c2b (ST_0cb1a5ee06af693baf5508d00a19d139Structure r) {
RC_5679bdbd71aac196e22130b3372a6c2b res = new RC_5679bdbd71aac196e22130b3372a6c2b ();
res.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5679bdbd71aac196e22130b3372a6c2b() {
OptimizedAttributes = null;
ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = new ST_0cb1a5ee06af693baf5508d00a19d139Structure();
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
    ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.OptimizedAttributes = value[0];
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
ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.Read( r, ref index);
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
public void ReadIM(RC_5679bdbd71aac196e22130b3372a6c2b r) {
this = r;
}


public static bool operator == (RC_5679bdbd71aac196e22130b3372a6c2b a, RC_5679bdbd71aac196e22130b3372a6c2b b) {
if (a.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request != b.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request) return false;
return true;
}

public static bool operator != (RC_5679bdbd71aac196e22130b3372a6c2b a, RC_5679bdbd71aac196e22130b3372a6c2b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5679bdbd71aac196e22130b3372a6c2b)) return false;
return (this == (RC_5679bdbd71aac196e22130b3372a6c2b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.InternalRecursiveSave();
}


public RC_5679bdbd71aac196e22130b3372a6c2b Duplicate() {
RC_5679bdbd71aac196e22130b3372a6c2b t;
t.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request = (ST_0cb1a5ee06af693baf5508d00a19d139Structure)this.ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.Duplicate();
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
if (head == "bapi_zmxffimf_acc_doc_change_request") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request")) variable.Value = ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request; else variable.Optimized = true;
variable.SetFieldName("bapi_zmxffimf_acc_doc_change_request");
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
if (key == IdBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request) {
return ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.Key.AsGuid) {
return ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request.FillFromOther((IRecord) other.AttributeGet(IdBAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request));
}
} // RC_5679bdbd71aac196e22130b3372a6c2b
/// <summary>
/// RecordList type <code>BAPI_ZMXFFIMF_ACC_DOC_CHANGE_RequestRecordList</code> that represents a
///  record list of <code>BAPI_ZMXFFIMF_ACC_DOC_CHANGE_Request</code>
/// </summary>
public partial class RL_e1cfa0ac9d184fc79ce2f0daee4474bd : GenericRecordList<RC_5679bdbd71aac196e22130b3372a6c2b>, IEnumerable, IEnumerator {

protected override RC_5679bdbd71aac196e22130b3372a6c2b GetElementDefaultValue() {
return new RC_5679bdbd71aac196e22130b3372a6c2b();
}

public T[] ToArray<T>(Func<RC_5679bdbd71aac196e22130b3372a6c2b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e1cfa0ac9d184fc79ce2f0daee4474bd recordList, Func<RC_5679bdbd71aac196e22130b3372a6c2b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e1cfa0ac9d184fc79ce2f0daee4474bd(RC_5679bdbd71aac196e22130b3372a6c2b[] array) {
  RL_e1cfa0ac9d184fc79ce2f0daee4474bd result = new RL_e1cfa0ac9d184fc79ce2f0daee4474bd();
result.InnerFromArray(array);
    return result;
}

public static RL_e1cfa0ac9d184fc79ce2f0daee4474bd ToList<T>(T[] array, Func <T, RC_5679bdbd71aac196e22130b3372a6c2b> converter) {
  RL_e1cfa0ac9d184fc79ce2f0daee4474bd result = new RL_e1cfa0ac9d184fc79ce2f0daee4474bd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e1cfa0ac9d184fc79ce2f0daee4474bd FromRestList<T>(RestList<T> restList, Func <T, RC_5679bdbd71aac196e22130b3372a6c2b> converter) {
  RL_e1cfa0ac9d184fc79ce2f0daee4474bd result = new RL_e1cfa0ac9d184fc79ce2f0daee4474bd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e1cfa0ac9d184fc79ce2f0daee4474bd() : base() {
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
protected override OSList<RC_5679bdbd71aac196e22130b3372a6c2b> NewList() {
return new RL_e1cfa0ac9d184fc79ce2f0daee4474bd();
}


} // RL_e1cfa0ac9d184fc79ce2f0daee4474bd
}

