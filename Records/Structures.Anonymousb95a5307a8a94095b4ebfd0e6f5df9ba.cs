namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (B1NauamolUC06_0Ob135ug)
///  <code>RC_3ad4ffb8938fb171b63db568e2bf5412</code> that represent
/// s <code>ZMXMIMMF_EM_SM_CECO_COSMOZReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_CECO_COSMOZReqRecord
public partial struct RC_3ad4ffb8938fb171b63db568e2bf5412 : ITypedRecord<RC_3ad4ffb8938fb171b63db568e2bf5412> {
internal static readonly GlobalObjectKey IdZMXMIMMF_EM_SM_CECO_COSMOZReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uP_UOo+TcbG2PbVo4r9UEg");

public ST_f9c1c13a018839a3b7bd285f1331e967Structure ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq;


public static implicit operator ST_f9c1c13a018839a3b7bd285f1331e967Structure( RC_3ad4ffb8938fb171b63db568e2bf5412 r) {
return r.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq;
}

public static implicit operator RC_3ad4ffb8938fb171b63db568e2bf5412 (ST_f9c1c13a018839a3b7bd285f1331e967Structure r) {
RC_3ad4ffb8938fb171b63db568e2bf5412 res = new RC_3ad4ffb8938fb171b63db568e2bf5412 ();
res.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3ad4ffb8938fb171b63db568e2bf5412() {
OptimizedAttributes = null;
ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq = new ST_f9c1c13a018839a3b7bd285f1331e967Structure();
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
    ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq.Read( r, ref index);
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
public void ReadIM(RC_3ad4ffb8938fb171b63db568e2bf5412 r) {
this = r;
}


public static bool operator == (RC_3ad4ffb8938fb171b63db568e2bf5412 a, RC_3ad4ffb8938fb171b63db568e2bf5412 b) {
if (a.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq != b.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq) return false;
return true;
}

public static bool operator != (RC_3ad4ffb8938fb171b63db568e2bf5412 a, RC_3ad4ffb8938fb171b63db568e2bf5412 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3ad4ffb8938fb171b63db568e2bf5412)) return false;
return (this == (RC_3ad4ffb8938fb171b63db568e2bf5412)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq.InternalRecursiveSave();
}


public RC_3ad4ffb8938fb171b63db568e2bf5412 Duplicate() {
RC_3ad4ffb8938fb171b63db568e2bf5412 t;
t.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq = (ST_f9c1c13a018839a3b7bd285f1331e967Structure)this.ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq.Duplicate();
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
if (head == "zmxmimmf_em_sm_ceco_cosmozreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_EM_SM_CECO_COSMOZReq")) variable.Value = ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_em_sm_ceco_cosmozreq");
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
if (key == IdZMXMIMMF_EM_SM_CECO_COSMOZReq) {
return ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_EM_SM_CECO_COSMOZReq.Key.AsGuid) {
return ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_EM_SM_CECO_COSMOZReq.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_EM_SM_CECO_COSMOZReq));
}
} // RC_3ad4ffb8938fb171b63db568e2bf5412
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_CECO_COSMOZReqRecordList</code> that represents a record list
///  of <code>ZMXMIMMF_EM_SM_CECO_COSMOZReq</code>
/// </summary>
public partial class RL_709663fd195c7a46a0c5cdc8ee339eec : GenericRecordList<RC_3ad4ffb8938fb171b63db568e2bf5412>, IEnumerable, IEnumerator {

protected override RC_3ad4ffb8938fb171b63db568e2bf5412 GetElementDefaultValue() {
return new RC_3ad4ffb8938fb171b63db568e2bf5412();
}

public T[] ToArray<T>(Func<RC_3ad4ffb8938fb171b63db568e2bf5412, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_709663fd195c7a46a0c5cdc8ee339eec recordList, Func<RC_3ad4ffb8938fb171b63db568e2bf5412, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_709663fd195c7a46a0c5cdc8ee339eec(RC_3ad4ffb8938fb171b63db568e2bf5412[] array) {
  RL_709663fd195c7a46a0c5cdc8ee339eec result = new RL_709663fd195c7a46a0c5cdc8ee339eec();
result.InnerFromArray(array);
    return result;
}

public static RL_709663fd195c7a46a0c5cdc8ee339eec ToList<T>(T[] array, Func <T, RC_3ad4ffb8938fb171b63db568e2bf5412> converter) {
  RL_709663fd195c7a46a0c5cdc8ee339eec result = new RL_709663fd195c7a46a0c5cdc8ee339eec();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_709663fd195c7a46a0c5cdc8ee339eec FromRestList<T>(RestList<T> restList, Func <T, RC_3ad4ffb8938fb171b63db568e2bf5412> converter) {
  RL_709663fd195c7a46a0c5cdc8ee339eec result = new RL_709663fd195c7a46a0c5cdc8ee339eec();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_709663fd195c7a46a0c5cdc8ee339eec() : base() {
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
protected override OSList<RC_3ad4ffb8938fb171b63db568e2bf5412> NewList() {
return new RL_709663fd195c7a46a0c5cdc8ee339eec();
}


} // RL_709663fd195c7a46a0c5cdc8ee339eec
}

