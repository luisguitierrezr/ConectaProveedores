namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (OyIebrBr20i6KJd22EOXKA)
///  <code>RC_dfc12769dee17fa6a0d26c41f4862476</code> that represent
/// s <code>ZMXMIMMF_VISUALIZAR_SAL_ANTRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_VISUALIZAR_SAL_ANTRespRecord
public partial struct RC_dfc12769dee17fa6a0d26c41f4862476 : ITypedRecord<RC_dfc12769dee17fa6a0d26c41f4862476> {
internal static readonly GlobalObjectKey IdZMXMIMMF_VISUALIZAR_SAL_ANTResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aSfB3+Hepn+g0mxB9IYkdg");

public ST_cbb2055cf19f871ed882642269bd43ceStructure ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp;


public static implicit operator ST_cbb2055cf19f871ed882642269bd43ceStructure( RC_dfc12769dee17fa6a0d26c41f4862476 r) {
return r.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp;
}

public static implicit operator RC_dfc12769dee17fa6a0d26c41f4862476 (ST_cbb2055cf19f871ed882642269bd43ceStructure r) {
RC_dfc12769dee17fa6a0d26c41f4862476 res = new RC_dfc12769dee17fa6a0d26c41f4862476 ();
res.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_dfc12769dee17fa6a0d26c41f4862476() {
OptimizedAttributes = null;
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp = new ST_cbb2055cf19f871ed882642269bd43ceStructure();
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
    ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp.Read( r, ref index);
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
public void ReadIM(RC_dfc12769dee17fa6a0d26c41f4862476 r) {
this = r;
}


public static bool operator == (RC_dfc12769dee17fa6a0d26c41f4862476 a, RC_dfc12769dee17fa6a0d26c41f4862476 b) {
if (a.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp != b.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp) return false;
return true;
}

public static bool operator != (RC_dfc12769dee17fa6a0d26c41f4862476 a, RC_dfc12769dee17fa6a0d26c41f4862476 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dfc12769dee17fa6a0d26c41f4862476)) return false;
return (this == (RC_dfc12769dee17fa6a0d26c41f4862476)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp.InternalRecursiveSave();
}


public RC_dfc12769dee17fa6a0d26c41f4862476 Duplicate() {
RC_dfc12769dee17fa6a0d26c41f4862476 t;
t.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp = (ST_cbb2055cf19f871ed882642269bd43ceStructure)this.ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp.Duplicate();
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
if (head == "zmxmimmf_visualizar_sal_antresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_VISUALIZAR_SAL_ANTResp")) variable.Value = ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_visualizar_sal_antresp");
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
if (key == IdZMXMIMMF_VISUALIZAR_SAL_ANTResp) {
return ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_VISUALIZAR_SAL_ANTResp.Key.AsGuid) {
return ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_VISUALIZAR_SAL_ANTResp.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_VISUALIZAR_SAL_ANTResp));
}
} // RC_dfc12769dee17fa6a0d26c41f4862476
/// <summary>
/// RecordList type <code>ZMXMIMMF_VISUALIZAR_SAL_ANTRespRecordList</code> that represents a record
///  list of <code>ZMXMIMMF_VISUALIZAR_SAL_ANTResp</code>
/// </summary>
public partial class RL_b35d4d4f5cc072589d64c60421ee47b6 : GenericRecordList<RC_dfc12769dee17fa6a0d26c41f4862476>, IEnumerable, IEnumerator {

protected override RC_dfc12769dee17fa6a0d26c41f4862476 GetElementDefaultValue() {
return new RC_dfc12769dee17fa6a0d26c41f4862476();
}

public T[] ToArray<T>(Func<RC_dfc12769dee17fa6a0d26c41f4862476, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b35d4d4f5cc072589d64c60421ee47b6 recordList, Func<RC_dfc12769dee17fa6a0d26c41f4862476, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b35d4d4f5cc072589d64c60421ee47b6(RC_dfc12769dee17fa6a0d26c41f4862476[] array) {
  RL_b35d4d4f5cc072589d64c60421ee47b6 result = new RL_b35d4d4f5cc072589d64c60421ee47b6();
result.InnerFromArray(array);
    return result;
}

public static RL_b35d4d4f5cc072589d64c60421ee47b6 ToList<T>(T[] array, Func <T, RC_dfc12769dee17fa6a0d26c41f4862476> converter) {
  RL_b35d4d4f5cc072589d64c60421ee47b6 result = new RL_b35d4d4f5cc072589d64c60421ee47b6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b35d4d4f5cc072589d64c60421ee47b6 FromRestList<T>(RestList<T> restList, Func <T, RC_dfc12769dee17fa6a0d26c41f4862476> converter) {
  RL_b35d4d4f5cc072589d64c60421ee47b6 result = new RL_b35d4d4f5cc072589d64c60421ee47b6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b35d4d4f5cc072589d64c60421ee47b6() : base() {
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
protected override OSList<RC_dfc12769dee17fa6a0d26c41f4862476> NewList() {
return new RL_b35d4d4f5cc072589d64c60421ee47b6();
}


} // RL_b35d4d4f5cc072589d64c60421ee47b6
}

