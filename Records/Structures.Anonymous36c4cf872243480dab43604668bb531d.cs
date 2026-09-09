namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (h8_ENkMiDUirQ2BGaLtTHQ)
///  <code>RC_c9e767f458efda82eb9e48ffda41df1b</code> that represent
/// s <code>ZMXMIMMF_ESTD_CUENTA_COSMOZRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZMXMIMMF_ESTD_CUENTA_COSMOZRespRecord
public partial struct RC_c9e767f458efda82eb9e48ffda41df1b : ITypedRecord<RC_c9e767f458efda82eb9e48ffda41df1b> {
internal static readonly GlobalObjectKey IdZMXMIMMF_ESTD_CUENTA_COSMOZResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9Gfnye9Ygtrrnkj_2kHfGw");

public ST_382afa1d8361f400b6ea03403d75e294Structure ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp;


public static implicit operator ST_382afa1d8361f400b6ea03403d75e294Structure( RC_c9e767f458efda82eb9e48ffda41df1b r) {
return r.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp;
}

public static implicit operator RC_c9e767f458efda82eb9e48ffda41df1b (ST_382afa1d8361f400b6ea03403d75e294Structure r) {
RC_c9e767f458efda82eb9e48ffda41df1b res = new RC_c9e767f458efda82eb9e48ffda41df1b ();
res.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c9e767f458efda82eb9e48ffda41df1b() {
OptimizedAttributes = null;
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp = new ST_382afa1d8361f400b6ea03403d75e294Structure();
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
    ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp.OptimizedAttributes = value[0];
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
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp.Read( r, ref index);
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
public void ReadIM(RC_c9e767f458efda82eb9e48ffda41df1b r) {
this = r;
}


public static bool operator == (RC_c9e767f458efda82eb9e48ffda41df1b a, RC_c9e767f458efda82eb9e48ffda41df1b b) {
if (a.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp != b.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp) return false;
return true;
}

public static bool operator != (RC_c9e767f458efda82eb9e48ffda41df1b a, RC_c9e767f458efda82eb9e48ffda41df1b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c9e767f458efda82eb9e48ffda41df1b)) return false;
return (this == (RC_c9e767f458efda82eb9e48ffda41df1b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp.InternalRecursiveSave();
}


public RC_c9e767f458efda82eb9e48ffda41df1b Duplicate() {
RC_c9e767f458efda82eb9e48ffda41df1b t;
t.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp = (ST_382afa1d8361f400b6ea03403d75e294Structure)this.ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp.Duplicate();
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
if (head == "zmxmimmf_estd_cuenta_cosmozresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZMXMIMMF_ESTD_CUENTA_COSMOZResp")) variable.Value = ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp; else variable.Optimized = true;
variable.SetFieldName("zmxmimmf_estd_cuenta_cosmozresp");
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
if (key == IdZMXMIMMF_ESTD_CUENTA_COSMOZResp) {
return ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZMXMIMMF_ESTD_CUENTA_COSMOZResp.Key.AsGuid) {
return ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZMXMIMMF_ESTD_CUENTA_COSMOZResp.FillFromOther((IRecord) other.AttributeGet(IdZMXMIMMF_ESTD_CUENTA_COSMOZResp));
}
} // RC_c9e767f458efda82eb9e48ffda41df1b
/// <summary>
/// RecordList type <code>ZMXMIMMF_ESTD_CUENTA_COSMOZRespRecordList</code> that represents a record
///  list of <code>ZMXMIMMF_ESTD_CUENTA_COSMOZResp</code>
/// </summary>
public partial class RL_d9b015576ee9a4d641e260a888f03447 : GenericRecordList<RC_c9e767f458efda82eb9e48ffda41df1b>, IEnumerable, IEnumerator {

protected override RC_c9e767f458efda82eb9e48ffda41df1b GetElementDefaultValue() {
return new RC_c9e767f458efda82eb9e48ffda41df1b();
}

public T[] ToArray<T>(Func<RC_c9e767f458efda82eb9e48ffda41df1b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d9b015576ee9a4d641e260a888f03447 recordList, Func<RC_c9e767f458efda82eb9e48ffda41df1b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d9b015576ee9a4d641e260a888f03447(RC_c9e767f458efda82eb9e48ffda41df1b[] array) {
  RL_d9b015576ee9a4d641e260a888f03447 result = new RL_d9b015576ee9a4d641e260a888f03447();
result.InnerFromArray(array);
    return result;
}

public static RL_d9b015576ee9a4d641e260a888f03447 ToList<T>(T[] array, Func <T, RC_c9e767f458efda82eb9e48ffda41df1b> converter) {
  RL_d9b015576ee9a4d641e260a888f03447 result = new RL_d9b015576ee9a4d641e260a888f03447();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d9b015576ee9a4d641e260a888f03447 FromRestList<T>(RestList<T> restList, Func <T, RC_c9e767f458efda82eb9e48ffda41df1b> converter) {
  RL_d9b015576ee9a4d641e260a888f03447 result = new RL_d9b015576ee9a4d641e260a888f03447();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d9b015576ee9a4d641e260a888f03447() : base() {
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
protected override OSList<RC_c9e767f458efda82eb9e48ffda41df1b> NewList() {
return new RL_d9b015576ee9a4d641e260a888f03447();
}


} // RL_d9b015576ee9a4d641e260a888f03447
}

