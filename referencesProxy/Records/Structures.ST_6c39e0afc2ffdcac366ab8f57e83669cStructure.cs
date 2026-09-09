namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_EM_COSMOZReq (dtm1cx22_0GPJW0l7bG5Kw)
///  <code>ST_6c39e0afc2ffdcac366ab8f57e83669cStructure</code> that represent
/// s <code>ZMXMIMMF_EM_COSMOZReq</code> <p>Description: ZMXMIMMF_EM_COSMOZReq</p>
/// </summary>
// Name: ZMXMIMMF_EM_COSMOZReq
public partial struct ST_6c39e0afc2ffdcac366ab8f57e83669cStructure : ITypedRecord<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure> {
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*TxKQVg87V0qSKjp_jd4cfA");
internal static readonly GlobalObjectKey IdPI_ITEM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*DQF8oMf+T0G2Cwz4NYWwPw");

public ST_af46d22a4ab690d6a003acf927bb2771Structure ssPI_HEADER;

public RL_5f4f6d8d3b3fb597b315a01bc1951a9b ssPI_ITEM;


public BitArray OptimizedAttributes;

public ST_6c39e0afc2ffdcac366ab8f57e83669cStructure() {
OptimizedAttributes = null;
ssPI_HEADER = new ST_af46d22a4ab690d6a003acf927bb2771Structure();
ssPI_ITEM = new RL_5f4f6d8d3b3fb597b315a01bc1951a9b();
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
    ssPI_HEADER.OptimizedAttributes = value[0];
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
public void ReadIM(ST_6c39e0afc2ffdcac366ab8f57e83669cStructure r) {
this = r;
}


public static bool operator == (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure a, ST_6c39e0afc2ffdcac366ab8f57e83669cStructure b) {
if (a.ssPI_HEADER != b.ssPI_HEADER) return false;
if (a.ssPI_ITEM != b.ssPI_ITEM) return false;
return true;
}

public static bool operator != (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure a, ST_6c39e0afc2ffdcac366ab8f57e83669cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure)) return false;
return (this == (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_HEADER.GetHashCode()
 ^ ssPI_ITEM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssPI_HEADER.RecursiveReset();
ssPI_ITEM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssPI_HEADER.InternalRecursiveSave();
ssPI_ITEM.InternalRecursiveSave();
}


public ST_6c39e0afc2ffdcac366ab8f57e83669cStructure Duplicate() {
ST_6c39e0afc2ffdcac366ab8f57e83669cStructure t;
t.ssPI_HEADER = (ST_af46d22a4ab690d6a003acf927bb2771Structure)this.ssPI_HEADER.Duplicate();
t.ssPI_ITEM = (RL_5f4f6d8d3b3fb597b315a01bc1951a9b)this.ssPI_ITEM.Duplicate();
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
if (head == "pi_header") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER")) variable.Value = ssPI_HEADER; else variable.Optimized = true;
variable.SetFieldName("pi_header");
} else if (head == "pi_item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM")) variable.Value = ssPI_ITEM; else variable.Optimized = true;
variable.SetFieldName("pi_item");
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
if (key == IdPI_HEADER) {
return ssPI_HEADER;
}
if (key == IdPI_ITEM) {
return ssPI_ITEM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER.Key.AsGuid) {
return ssPI_HEADER;
}
if (attributeKey == IdPI_ITEM.Key.AsGuid) {
return ssPI_ITEM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_HEADER.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER));
ssPI_ITEM = new RL_5f4f6d8d3b3fb597b315a01bc1951a9b();
ssPI_ITEM.FillFromOther((IOSList) other.AttributeGet(IdPI_ITEM));
}
} // ST_6c39e0afc2ffdcac366ab8f57e83669cStructure
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_COSMOZReqList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_COSMOZReq</code>
/// </summary>
public partial class RL_7d534781293948407298236576535a19 : GenericRecordList<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure>, IEnumerable, IEnumerator {

protected override ST_6c39e0afc2ffdcac366ab8f57e83669cStructure GetElementDefaultValue() {
return new ST_6c39e0afc2ffdcac366ab8f57e83669cStructure();
}

public T[] ToArray<T>(Func<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7d534781293948407298236576535a19 recordList, Func<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7d534781293948407298236576535a19(ST_6c39e0afc2ffdcac366ab8f57e83669cStructure[] array) {
  RL_7d534781293948407298236576535a19 result = new RL_7d534781293948407298236576535a19();
result.InnerFromArray(array);
    return result;
}

public static RL_7d534781293948407298236576535a19 ToList<T>(T[] array, Func <T, ST_6c39e0afc2ffdcac366ab8f57e83669cStructure> converter) {
  RL_7d534781293948407298236576535a19 result = new RL_7d534781293948407298236576535a19();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7d534781293948407298236576535a19 FromRestList<T>(RestList<T> restList, Func <T, ST_6c39e0afc2ffdcac366ab8f57e83669cStructure> converter) {
  RL_7d534781293948407298236576535a19 result = new RL_7d534781293948407298236576535a19();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7d534781293948407298236576535a19() : base() {
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
protected override OSList<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure> NewList() {
return new RL_7d534781293948407298236576535a19();
}


} // RL_7d534781293948407298236576535a19
}

