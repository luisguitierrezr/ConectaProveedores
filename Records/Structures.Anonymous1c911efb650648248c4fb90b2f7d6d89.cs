namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+x6RHAZlJEiMT7kLL31tiQ)
///  <code>RC_66a20a7b8ce3f53dc41a0f7d5901d617</code> that represent
/// s <code>ZMXMIMMF_EM_SM_RM_COSMOZRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_RM_COSMOZRespRecord
public partial struct RC_66a20a7b8ce3f53dc41a0f7d5901d617 : ITypedRecord<RC_66a20a7b8ce3f53dc41a0f7d5901d617> {
internal static readonly GlobalObjectKey IdZMXMIMMF_EM_SM_RM_COSMOZResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ewqiZuOMPfXEGg99WQHWFw");

public ST_b413183d4662c427b8a9318270b9732cStructure ssSTZMXMIMMF_EM_SM_RM_COSMOZResp;


public static implicit operator ST_b413183d4662c427b8a9318270b9732cStructure( RC_66a20a7b8ce3f53dc41a0f7d5901d617 r) {
return r.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp;
}

public static implicit operator RC_66a20a7b8ce3f53dc41a0f7d5901d617 (ST_b413183d4662c427b8a9318270b9732cStructure r) {
RC_66a20a7b8ce3f53dc41a0f7d5901d617 res = new RC_66a20a7b8ce3f53dc41a0f7d5901d617 ();
res.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_66a20a7b8ce3f53dc41a0f7d5901d617() {
OptimizedAttributes = null;
ssSTZMXMIMMF_EM_SM_RM_COSMOZResp = new ST_b413183d4662c427b8a9318270b9732cStructure();
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
    ssSTZMXMIMMF_EM_SM_RM_COSMOZResp.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_EM_SM_RM_COSMOZResp.Read( r, ref index);
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
public void ReadIM(RC_66a20a7b8ce3f53dc41a0f7d5901d617 r) {
this = r;
}


public static bool operator == (RC_66a20a7b8ce3f53dc41a0f7d5901d617 a, RC_66a20a7b8ce3f53dc41a0f7d5901d617 b) {
if (a.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp != b.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp) return false;
return true;
}

public static bool operator != (RC_66a20a7b8ce3f53dc41a0f7d5901d617 a, RC_66a20a7b8ce3f53dc41a0f7d5901d617 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_66a20a7b8ce3f53dc41a0f7d5901d617)) return false;
return (this == (RC_66a20a7b8ce3f53dc41a0f7d5901d617)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_EM_SM_RM_COSMOZResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_EM_SM_RM_COSMOZResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_EM_SM_RM_COSMOZResp.InternalRecursiveSave();
}


public RC_66a20a7b8ce3f53dc41a0f7d5901d617 Duplicate() {
RC_66a20a7b8ce3f53dc41a0f7d5901d617 t;
t.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp = (ST_b413183d4662c427b8a9318270b9732cStructure)this.ssSTZMXMIMMF_EM_SM_RM_COSMOZResp.Duplicate();
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
if (head == "zmxmimmf_em_sm_rm_cosmozresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_EM_SM_RM_COSMOZResp")) variable.Value = ssSTZMXMIMMF_EM_SM_RM_COSMOZResp; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_em_sm_rm_cosmozresp");
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
if (key == IdZMXMIMMF_EM_SM_RM_COSMOZResp) {
return ssSTZMXMIMMF_EM_SM_RM_COSMOZResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_EM_SM_RM_COSMOZResp.Key.AsGuid) {
return ssSTZMXMIMMF_EM_SM_RM_COSMOZResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_EM_SM_RM_COSMOZResp.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_EM_SM_RM_COSMOZResp));
}
} // RC_66a20a7b8ce3f53dc41a0f7d5901d617
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_RM_COSMOZRespRecordList</code> that represents a record list
///  of <code>ZMXMIMMF_EM_SM_RM_COSMOZResp</code>
/// </summary>
public partial class RL_4f2114a6e2da76b69e0c897502f1eac9 : GenericRecordList<RC_66a20a7b8ce3f53dc41a0f7d5901d617>, IEnumerable, IEnumerator {

protected override RC_66a20a7b8ce3f53dc41a0f7d5901d617 GetElementDefaultValue() {
return new RC_66a20a7b8ce3f53dc41a0f7d5901d617();
}

public T[] ToArray<T>(Func<RC_66a20a7b8ce3f53dc41a0f7d5901d617, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4f2114a6e2da76b69e0c897502f1eac9 recordList, Func<RC_66a20a7b8ce3f53dc41a0f7d5901d617, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4f2114a6e2da76b69e0c897502f1eac9(RC_66a20a7b8ce3f53dc41a0f7d5901d617[] array) {
  RL_4f2114a6e2da76b69e0c897502f1eac9 result = new RL_4f2114a6e2da76b69e0c897502f1eac9();
result.InnerFromArray(array);
    return result;
}

public static RL_4f2114a6e2da76b69e0c897502f1eac9 ToList<T>(T[] array, Func <T, RC_66a20a7b8ce3f53dc41a0f7d5901d617> converter) {
  RL_4f2114a6e2da76b69e0c897502f1eac9 result = new RL_4f2114a6e2da76b69e0c897502f1eac9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4f2114a6e2da76b69e0c897502f1eac9 FromRestList<T>(RestList<T> restList, Func <T, RC_66a20a7b8ce3f53dc41a0f7d5901d617> converter) {
  RL_4f2114a6e2da76b69e0c897502f1eac9 result = new RL_4f2114a6e2da76b69e0c897502f1eac9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4f2114a6e2da76b69e0c897502f1eac9() : base() {
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
protected override OSList<RC_66a20a7b8ce3f53dc41a0f7d5901d617> NewList() {
return new RL_4f2114a6e2da76b69e0c897502f1eac9();
}


} // RL_4f2114a6e2da76b69e0c897502f1eac9
}

