namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Bfijbk5kwkeDhGIJAZtsYA)
///  <code>RC_6bb7219d5e0c95ac87eb2e8fd881c9c0</code> that represent
/// s <code>ZMXMIMMF_EM_SM_MO_COSMOZRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_MO_COSMOZRespRecord
public partial struct RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 : ITypedRecord<RC_6bb7219d5e0c95ac87eb2e8fd881c9c0> {
internal static readonly GlobalObjectKey IdZMXMIMMF_EM_SM_MO_COSMOZResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nSG3awxerJWH6y6P2IHJwA");

public ST_39fca1fbc45889b86a3f10d9a278767bStructure ssSTZMXMIMMF_EM_SM_MO_COSMOZResp;


public static implicit operator ST_39fca1fbc45889b86a3f10d9a278767bStructure( RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 r) {
return r.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp;
}

public static implicit operator RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 (ST_39fca1fbc45889b86a3f10d9a278767bStructure r) {
RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 res = new RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 ();
res.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6bb7219d5e0c95ac87eb2e8fd881c9c0() {
OptimizedAttributes = null;
ssSTZMXMIMMF_EM_SM_MO_COSMOZResp = new ST_39fca1fbc45889b86a3f10d9a278767bStructure();
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
    ssSTZMXMIMMF_EM_SM_MO_COSMOZResp.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_EM_SM_MO_COSMOZResp.Read( r, ref index);
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
public void ReadIM(RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 r) {
this = r;
}


public static bool operator == (RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 a, RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 b) {
if (a.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp != b.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp) return false;
return true;
}

public static bool operator != (RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 a, RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6bb7219d5e0c95ac87eb2e8fd881c9c0)) return false;
return (this == (RC_6bb7219d5e0c95ac87eb2e8fd881c9c0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_EM_SM_MO_COSMOZResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_EM_SM_MO_COSMOZResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_EM_SM_MO_COSMOZResp.InternalRecursiveSave();
}


public RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 Duplicate() {
RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 t;
t.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp = (ST_39fca1fbc45889b86a3f10d9a278767bStructure)this.ssSTZMXMIMMF_EM_SM_MO_COSMOZResp.Duplicate();
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
if (head == "zmxmimmf_em_sm_mo_cosmozresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_EM_SM_MO_COSMOZResp")) variable.Value = ssSTZMXMIMMF_EM_SM_MO_COSMOZResp; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_em_sm_mo_cosmozresp");
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
if (key == IdZMXMIMMF_EM_SM_MO_COSMOZResp) {
return ssSTZMXMIMMF_EM_SM_MO_COSMOZResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_EM_SM_MO_COSMOZResp.Key.AsGuid) {
return ssSTZMXMIMMF_EM_SM_MO_COSMOZResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_EM_SM_MO_COSMOZResp.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_EM_SM_MO_COSMOZResp));
}
} // RC_6bb7219d5e0c95ac87eb2e8fd881c9c0
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_MO_COSMOZRespRecordList</code> that represents a record list
///  of <code>ZMXMIMMF_EM_SM_MO_COSMOZResp</code>
/// </summary>
public partial class RL_01cba463356714feb2321500e5c180d0 : GenericRecordList<RC_6bb7219d5e0c95ac87eb2e8fd881c9c0>, IEnumerable, IEnumerator {

protected override RC_6bb7219d5e0c95ac87eb2e8fd881c9c0 GetElementDefaultValue() {
return new RC_6bb7219d5e0c95ac87eb2e8fd881c9c0();
}

public T[] ToArray<T>(Func<RC_6bb7219d5e0c95ac87eb2e8fd881c9c0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_01cba463356714feb2321500e5c180d0 recordList, Func<RC_6bb7219d5e0c95ac87eb2e8fd881c9c0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_01cba463356714feb2321500e5c180d0(RC_6bb7219d5e0c95ac87eb2e8fd881c9c0[] array) {
  RL_01cba463356714feb2321500e5c180d0 result = new RL_01cba463356714feb2321500e5c180d0();
result.InnerFromArray(array);
    return result;
}

public static RL_01cba463356714feb2321500e5c180d0 ToList<T>(T[] array, Func <T, RC_6bb7219d5e0c95ac87eb2e8fd881c9c0> converter) {
  RL_01cba463356714feb2321500e5c180d0 result = new RL_01cba463356714feb2321500e5c180d0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_01cba463356714feb2321500e5c180d0 FromRestList<T>(RestList<T> restList, Func <T, RC_6bb7219d5e0c95ac87eb2e8fd881c9c0> converter) {
  RL_01cba463356714feb2321500e5c180d0 result = new RL_01cba463356714feb2321500e5c180d0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_01cba463356714feb2321500e5c180d0() : base() {
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
protected override OSList<RC_6bb7219d5e0c95ac87eb2e8fd881c9c0> NewList() {
return new RL_01cba463356714feb2321500e5c180d0();
}


} // RL_01cba463356714feb2321500e5c180d0
}

