namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (+HbTFQNL4kO8LHKepPuvbw)
///  <code>RC_889992011346c72f40c5df9c68ce8075</code> that represent
/// s <code>ZMXMIMMF_EM_COSMOZRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_EM_COSMOZRespRecord
public partial struct RC_889992011346c72f40c5df9c68ce8075 : ITypedRecord<RC_889992011346c72f40c5df9c68ce8075> {
internal static readonly GlobalObjectKey IdZMXMIMMF_EM_COSMOZResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AZKZiEYTL8dAxd+caM6AdQ");

public ST_9142fa8204e8ba0b33acb137d6acbbd3Structure ssSTZMXMIMMF_EM_COSMOZResp;


public static implicit operator ST_9142fa8204e8ba0b33acb137d6acbbd3Structure( RC_889992011346c72f40c5df9c68ce8075 r) {
return r.ssSTZMXMIMMF_EM_COSMOZResp;
}

public static implicit operator RC_889992011346c72f40c5df9c68ce8075 (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure r) {
RC_889992011346c72f40c5df9c68ce8075 res = new RC_889992011346c72f40c5df9c68ce8075 ();
res.ssSTZMXMIMMF_EM_COSMOZResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_889992011346c72f40c5df9c68ce8075() {
OptimizedAttributes = null;
ssSTZMXMIMMF_EM_COSMOZResp = new ST_9142fa8204e8ba0b33acb137d6acbbd3Structure();
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
    ssSTZMXMIMMF_EM_COSMOZResp.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_EM_COSMOZResp.Read( r, ref index);
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
public void ReadIM(RC_889992011346c72f40c5df9c68ce8075 r) {
this = r;
}


public static bool operator == (RC_889992011346c72f40c5df9c68ce8075 a, RC_889992011346c72f40c5df9c68ce8075 b) {
if (a.ssSTZMXMIMMF_EM_COSMOZResp != b.ssSTZMXMIMMF_EM_COSMOZResp) return false;
return true;
}

public static bool operator != (RC_889992011346c72f40c5df9c68ce8075 a, RC_889992011346c72f40c5df9c68ce8075 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_889992011346c72f40c5df9c68ce8075)) return false;
return (this == (RC_889992011346c72f40c5df9c68ce8075)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_EM_COSMOZResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_EM_COSMOZResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_EM_COSMOZResp.InternalRecursiveSave();
}


public RC_889992011346c72f40c5df9c68ce8075 Duplicate() {
RC_889992011346c72f40c5df9c68ce8075 t;
t.ssSTZMXMIMMF_EM_COSMOZResp = (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure)this.ssSTZMXMIMMF_EM_COSMOZResp.Duplicate();
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
if (head == "zmxmimmf_em_cosmozresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_EM_COSMOZResp")) variable.Value = ssSTZMXMIMMF_EM_COSMOZResp; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_em_cosmozresp");
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
if (key == IdZMXMIMMF_EM_COSMOZResp) {
return ssSTZMXMIMMF_EM_COSMOZResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_EM_COSMOZResp.Key.AsGuid) {
return ssSTZMXMIMMF_EM_COSMOZResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_EM_COSMOZResp.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_EM_COSMOZResp));
}
} // RC_889992011346c72f40c5df9c68ce8075
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_COSMOZRespRecordList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_COSMOZResp</code>
/// </summary>
public partial class RL_53aae726406fa86ef85b629e933edc31 : GenericRecordList<RC_889992011346c72f40c5df9c68ce8075>, IEnumerable, IEnumerator {

protected override RC_889992011346c72f40c5df9c68ce8075 GetElementDefaultValue() {
return new RC_889992011346c72f40c5df9c68ce8075();
}

public T[] ToArray<T>(Func<RC_889992011346c72f40c5df9c68ce8075, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_53aae726406fa86ef85b629e933edc31 recordList, Func<RC_889992011346c72f40c5df9c68ce8075, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_53aae726406fa86ef85b629e933edc31(RC_889992011346c72f40c5df9c68ce8075[] array) {
  RL_53aae726406fa86ef85b629e933edc31 result = new RL_53aae726406fa86ef85b629e933edc31();
result.InnerFromArray(array);
    return result;
}

public static RL_53aae726406fa86ef85b629e933edc31 ToList<T>(T[] array, Func <T, RC_889992011346c72f40c5df9c68ce8075> converter) {
  RL_53aae726406fa86ef85b629e933edc31 result = new RL_53aae726406fa86ef85b629e933edc31();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_53aae726406fa86ef85b629e933edc31 FromRestList<T>(RestList<T> restList, Func <T, RC_889992011346c72f40c5df9c68ce8075> converter) {
  RL_53aae726406fa86ef85b629e933edc31 result = new RL_53aae726406fa86ef85b629e933edc31();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_53aae726406fa86ef85b629e933edc31() : base() {
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
protected override OSList<RC_889992011346c72f40c5df9c68ce8075> NewList() {
return new RL_53aae726406fa86ef85b629e933edc31();
}


} // RL_53aae726406fa86ef85b629e933edc31
}

