namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (RiNgwipbmUOHnpK10oe9kg)
///  <code>RC_4b9181ec00d2ca6b946c45d8bcadc2a6</code> that represent
/// s <code>ZMXMIMMF_EM_SM_CECO_COSMOZREspRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_CECO_COSMOZREspRecord
public partial struct RC_4b9181ec00d2ca6b946c45d8bcadc2a6 : ITypedRecord<RC_4b9181ec00d2ca6b946c45d8bcadc2a6> {
internal static readonly GlobalObjectKey IdZMXMIMMF_EM_SM_CECO_COSMOZREsp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7IGRS9IAa8qUbEXYvK3Cpg");

public ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp;


public static implicit operator ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure( RC_4b9181ec00d2ca6b946c45d8bcadc2a6 r) {
return r.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp;
}

public static implicit operator RC_4b9181ec00d2ca6b946c45d8bcadc2a6 (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure r) {
RC_4b9181ec00d2ca6b946c45d8bcadc2a6 res = new RC_4b9181ec00d2ca6b946c45d8bcadc2a6 ();
res.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4b9181ec00d2ca6b946c45d8bcadc2a6() {
OptimizedAttributes = null;
ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp = new ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure();
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
    ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp.Read( r, ref index);
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
public void ReadIM(RC_4b9181ec00d2ca6b946c45d8bcadc2a6 r) {
this = r;
}


public static bool operator == (RC_4b9181ec00d2ca6b946c45d8bcadc2a6 a, RC_4b9181ec00d2ca6b946c45d8bcadc2a6 b) {
if (a.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp != b.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp) return false;
return true;
}

public static bool operator != (RC_4b9181ec00d2ca6b946c45d8bcadc2a6 a, RC_4b9181ec00d2ca6b946c45d8bcadc2a6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4b9181ec00d2ca6b946c45d8bcadc2a6)) return false;
return (this == (RC_4b9181ec00d2ca6b946c45d8bcadc2a6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp.InternalRecursiveSave();
}


public RC_4b9181ec00d2ca6b946c45d8bcadc2a6 Duplicate() {
RC_4b9181ec00d2ca6b946c45d8bcadc2a6 t;
t.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp = (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure)this.ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp.Duplicate();
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
if (head == "zmxmimmf_em_sm_ceco_cosmozresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_EM_SM_CECO_COSMOZREsp")) variable.Value = ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_em_sm_ceco_cosmozresp");
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
if (key == IdZMXMIMMF_EM_SM_CECO_COSMOZREsp) {
return ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_EM_SM_CECO_COSMOZREsp.Key.AsGuid) {
return ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_EM_SM_CECO_COSMOZREsp.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_EM_SM_CECO_COSMOZREsp));
}
} // RC_4b9181ec00d2ca6b946c45d8bcadc2a6
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_CECO_COSMOZREspRecordList</code> that represents a record list
///  of <code>ZMXMIMMF_EM_SM_CECO_COSMOZREsp</code>
/// </summary>
public partial class RL_f4ae6389852598e944f7f7640f827da5 : GenericRecordList<RC_4b9181ec00d2ca6b946c45d8bcadc2a6>, IEnumerable, IEnumerator {

protected override RC_4b9181ec00d2ca6b946c45d8bcadc2a6 GetElementDefaultValue() {
return new RC_4b9181ec00d2ca6b946c45d8bcadc2a6();
}

public T[] ToArray<T>(Func<RC_4b9181ec00d2ca6b946c45d8bcadc2a6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f4ae6389852598e944f7f7640f827da5 recordList, Func<RC_4b9181ec00d2ca6b946c45d8bcadc2a6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f4ae6389852598e944f7f7640f827da5(RC_4b9181ec00d2ca6b946c45d8bcadc2a6[] array) {
  RL_f4ae6389852598e944f7f7640f827da5 result = new RL_f4ae6389852598e944f7f7640f827da5();
result.InnerFromArray(array);
    return result;
}

public static RL_f4ae6389852598e944f7f7640f827da5 ToList<T>(T[] array, Func <T, RC_4b9181ec00d2ca6b946c45d8bcadc2a6> converter) {
  RL_f4ae6389852598e944f7f7640f827da5 result = new RL_f4ae6389852598e944f7f7640f827da5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f4ae6389852598e944f7f7640f827da5 FromRestList<T>(RestList<T> restList, Func <T, RC_4b9181ec00d2ca6b946c45d8bcadc2a6> converter) {
  RL_f4ae6389852598e944f7f7640f827da5 result = new RL_f4ae6389852598e944f7f7640f827da5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f4ae6389852598e944f7f7640f827da5() : base() {
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
protected override OSList<RC_4b9181ec00d2ca6b946c45d8bcadc2a6> NewList() {
return new RL_f4ae6389852598e944f7f7640f827da5();
}


} // RL_f4ae6389852598e944f7f7640f827da5
}

