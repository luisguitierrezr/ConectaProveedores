namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (vAEA_d43zkKsV8Rh9NCf8g)
///  <code>RC_ae943cb2defc9034e3c3c726ea9742f4</code> that represent
/// s <code>ZMXMIMMF_EM_SM_MO_COSMOZREqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_MO_COSMOZREqRecord
public partial struct RC_ae943cb2defc9034e3c3c726ea9742f4 : ITypedRecord<RC_ae943cb2defc9034e3c3c726ea9742f4> {
internal static readonly GlobalObjectKey IdZMXMIMMF_EM_SM_MO_COSMOZREq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sjyUrvzeNJDjw8cm6pdC9A");

public ST_0d774220c0b1db165444568fabc9b253Structure ssSTZMXMIMMF_EM_SM_MO_COSMOZREq;


public static implicit operator ST_0d774220c0b1db165444568fabc9b253Structure( RC_ae943cb2defc9034e3c3c726ea9742f4 r) {
return r.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq;
}

public static implicit operator RC_ae943cb2defc9034e3c3c726ea9742f4 (ST_0d774220c0b1db165444568fabc9b253Structure r) {
RC_ae943cb2defc9034e3c3c726ea9742f4 res = new RC_ae943cb2defc9034e3c3c726ea9742f4 ();
res.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ae943cb2defc9034e3c3c726ea9742f4() {
OptimizedAttributes = null;
ssSTZMXMIMMF_EM_SM_MO_COSMOZREq = new ST_0d774220c0b1db165444568fabc9b253Structure();
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
    ssSTZMXMIMMF_EM_SM_MO_COSMOZREq.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_EM_SM_MO_COSMOZREq.Read( r, ref index);
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
public void ReadIM(RC_ae943cb2defc9034e3c3c726ea9742f4 r) {
this = r;
}


public static bool operator == (RC_ae943cb2defc9034e3c3c726ea9742f4 a, RC_ae943cb2defc9034e3c3c726ea9742f4 b) {
if (a.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq != b.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq) return false;
return true;
}

public static bool operator != (RC_ae943cb2defc9034e3c3c726ea9742f4 a, RC_ae943cb2defc9034e3c3c726ea9742f4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ae943cb2defc9034e3c3c726ea9742f4)) return false;
return (this == (RC_ae943cb2defc9034e3c3c726ea9742f4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_EM_SM_MO_COSMOZREq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_EM_SM_MO_COSMOZREq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_EM_SM_MO_COSMOZREq.InternalRecursiveSave();
}


public RC_ae943cb2defc9034e3c3c726ea9742f4 Duplicate() {
RC_ae943cb2defc9034e3c3c726ea9742f4 t;
t.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq = (ST_0d774220c0b1db165444568fabc9b253Structure)this.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq.Duplicate();
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
if (head == "zmxmimmf_em_sm_mo_cosmozreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_EM_SM_MO_COSMOZREq")) variable.Value = ssSTZMXMIMMF_EM_SM_MO_COSMOZREq; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_em_sm_mo_cosmozreq");
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
if (key == IdZMXMIMMF_EM_SM_MO_COSMOZREq) {
return ssSTZMXMIMMF_EM_SM_MO_COSMOZREq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_EM_SM_MO_COSMOZREq.Key.AsGuid) {
return ssSTZMXMIMMF_EM_SM_MO_COSMOZREq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_EM_SM_MO_COSMOZREq.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_EM_SM_MO_COSMOZREq));
}
} // RC_ae943cb2defc9034e3c3c726ea9742f4
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_MO_COSMOZREqRecordList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_SM_MO_COSMOZREq</code>
/// </summary>
public partial class RL_f10dee8004976df2c128a86afc09cda1 : GenericRecordList<RC_ae943cb2defc9034e3c3c726ea9742f4>, IEnumerable, IEnumerator {

protected override RC_ae943cb2defc9034e3c3c726ea9742f4 GetElementDefaultValue() {
return new RC_ae943cb2defc9034e3c3c726ea9742f4();
}

public T[] ToArray<T>(Func<RC_ae943cb2defc9034e3c3c726ea9742f4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f10dee8004976df2c128a86afc09cda1 recordList, Func<RC_ae943cb2defc9034e3c3c726ea9742f4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f10dee8004976df2c128a86afc09cda1(RC_ae943cb2defc9034e3c3c726ea9742f4[] array) {
  RL_f10dee8004976df2c128a86afc09cda1 result = new RL_f10dee8004976df2c128a86afc09cda1();
result.InnerFromArray(array);
    return result;
}

public static RL_f10dee8004976df2c128a86afc09cda1 ToList<T>(T[] array, Func <T, RC_ae943cb2defc9034e3c3c726ea9742f4> converter) {
  RL_f10dee8004976df2c128a86afc09cda1 result = new RL_f10dee8004976df2c128a86afc09cda1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f10dee8004976df2c128a86afc09cda1 FromRestList<T>(RestList<T> restList, Func <T, RC_ae943cb2defc9034e3c3c726ea9742f4> converter) {
  RL_f10dee8004976df2c128a86afc09cda1 result = new RL_f10dee8004976df2c128a86afc09cda1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f10dee8004976df2c128a86afc09cda1() : base() {
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
protected override OSList<RC_ae943cb2defc9034e3c3c726ea9742f4> NewList() {
return new RL_f10dee8004976df2c128a86afc09cda1();
}


} // RL_f10dee8004976df2c128a86afc09cda1
}

