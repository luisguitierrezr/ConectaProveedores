namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (qgDlTIBeTkytIy55a07yrA)
///  <code>RC_0af43c1e2c7fa4a11aabdc946b7d5f8b</code> that represent
/// s <code>ZMXMIMMF_VISUALIZAR_SAL_ANTReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_VISUALIZAR_SAL_ANTReqRecord
public partial struct RC_0af43c1e2c7fa4a11aabdc946b7d5f8b : ITypedRecord<RC_0af43c1e2c7fa4a11aabdc946b7d5f8b> {
internal static readonly GlobalObjectKey IdZMXMIMMF_VISUALIZAR_SAL_ANTReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Hjz0Cn8soaQaq9yUa31fiw");

public ST_f68ab54e767928bb7cc21e9801e8642bStructure ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq;


public static implicit operator ST_f68ab54e767928bb7cc21e9801e8642bStructure( RC_0af43c1e2c7fa4a11aabdc946b7d5f8b r) {
return r.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq;
}

public static implicit operator RC_0af43c1e2c7fa4a11aabdc946b7d5f8b (ST_f68ab54e767928bb7cc21e9801e8642bStructure r) {
RC_0af43c1e2c7fa4a11aabdc946b7d5f8b res = new RC_0af43c1e2c7fa4a11aabdc946b7d5f8b ();
res.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_0af43c1e2c7fa4a11aabdc946b7d5f8b() {
OptimizedAttributes = null;
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq = new ST_f68ab54e767928bb7cc21e9801e8642bStructure();
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
    ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq.Read( r, ref index);
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
public void ReadIM(RC_0af43c1e2c7fa4a11aabdc946b7d5f8b r) {
this = r;
}


public static bool operator == (RC_0af43c1e2c7fa4a11aabdc946b7d5f8b a, RC_0af43c1e2c7fa4a11aabdc946b7d5f8b b) {
if (a.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq != b.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq) return false;
return true;
}

public static bool operator != (RC_0af43c1e2c7fa4a11aabdc946b7d5f8b a, RC_0af43c1e2c7fa4a11aabdc946b7d5f8b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0af43c1e2c7fa4a11aabdc946b7d5f8b)) return false;
return (this == (RC_0af43c1e2c7fa4a11aabdc946b7d5f8b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq.InternalRecursiveSave();
}


public RC_0af43c1e2c7fa4a11aabdc946b7d5f8b Duplicate() {
RC_0af43c1e2c7fa4a11aabdc946b7d5f8b t;
t.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq = (ST_f68ab54e767928bb7cc21e9801e8642bStructure)this.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq.Duplicate();
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
if (head == "zmxmimmf_visualizar_sal_antreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_VISUALIZAR_SAL_ANTReq")) variable.Value = ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_visualizar_sal_antreq");
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
if (key == IdZMXMIMMF_VISUALIZAR_SAL_ANTReq) {
return ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_VISUALIZAR_SAL_ANTReq.Key.AsGuid) {
return ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTReq.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_VISUALIZAR_SAL_ANTReq));
}
} // RC_0af43c1e2c7fa4a11aabdc946b7d5f8b
/// <summary>
/// RecordList type <code>ZMXMIMMF_VISUALIZAR_SAL_ANTReqRecordList</code> that represents a record list
///  of <code>ZMXMIMMF_VISUALIZAR_SAL_ANTReq</code>
/// </summary>
public partial class RL_961aac84265ce61aa28ab6c669721fd9 : GenericRecordList<RC_0af43c1e2c7fa4a11aabdc946b7d5f8b>, IEnumerable, IEnumerator {

protected override RC_0af43c1e2c7fa4a11aabdc946b7d5f8b GetElementDefaultValue() {
return new RC_0af43c1e2c7fa4a11aabdc946b7d5f8b();
}

public T[] ToArray<T>(Func<RC_0af43c1e2c7fa4a11aabdc946b7d5f8b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_961aac84265ce61aa28ab6c669721fd9 recordList, Func<RC_0af43c1e2c7fa4a11aabdc946b7d5f8b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_961aac84265ce61aa28ab6c669721fd9(RC_0af43c1e2c7fa4a11aabdc946b7d5f8b[] array) {
  RL_961aac84265ce61aa28ab6c669721fd9 result = new RL_961aac84265ce61aa28ab6c669721fd9();
result.InnerFromArray(array);
    return result;
}

public static RL_961aac84265ce61aa28ab6c669721fd9 ToList<T>(T[] array, Func <T, RC_0af43c1e2c7fa4a11aabdc946b7d5f8b> converter) {
  RL_961aac84265ce61aa28ab6c669721fd9 result = new RL_961aac84265ce61aa28ab6c669721fd9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_961aac84265ce61aa28ab6c669721fd9 FromRestList<T>(RestList<T> restList, Func <T, RC_0af43c1e2c7fa4a11aabdc946b7d5f8b> converter) {
  RL_961aac84265ce61aa28ab6c669721fd9 result = new RL_961aac84265ce61aa28ab6c669721fd9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_961aac84265ce61aa28ab6c669721fd9() : base() {
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
protected override OSList<RC_0af43c1e2c7fa4a11aabdc946b7d5f8b> NewList() {
return new RL_961aac84265ce61aa28ab6c669721fd9();
}


} // RL_961aac84265ce61aa28ab6c669721fd9
}

