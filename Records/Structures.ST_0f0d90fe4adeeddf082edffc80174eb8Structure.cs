namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] BAPI_GL_ACC_GETDETAILResp (gB2JfX32hUyYTLdbPo8ZEg)
///  <code>ST_0f0d90fe4adeeddf082edffc80174eb8Structure</code> that represent
/// s <code>BAPI_GL_ACC_GETDETAILResp</code> <p>Description: BAPI_GL_ACC_GETDETAILResp</p>
/// </summary>
// Name: BAPI_GL_ACC_GETDETAILResp
public partial struct ST_0f0d90fe4adeeddf082edffc80174eb8Structure : ITypedRecord<ST_0f0d90fe4adeeddf082edffc80174eb8Structure> {
internal static readonly GlobalObjectKey IdACCOUNT_DETAIL = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*LMk5uAN3UUK7XI19daBepQ");
internal static readonly GlobalObjectKey IdRETURN = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Aby8rsNt2kCwJwekEitnFQ");

public ST_d2beaf811f074c88054765b10d929011Structure ssACCOUNT_DETAIL;

public ST_e5256660414a7d3dddc63b7cbdd21e9cStructure ssRETURN;


public BitArray OptimizedAttributes;

public ST_0f0d90fe4adeeddf082edffc80174eb8Structure() {
OptimizedAttributes = null;
ssACCOUNT_DETAIL = new ST_d2beaf811f074c88054765b10d929011Structure();
ssRETURN = new ST_e5256660414a7d3dddc63b7cbdd21e9cStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssACCOUNT_DETAIL.OptimizedAttributes = value[0];
    ssRETURN.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
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
public void ReadIM(ST_0f0d90fe4adeeddf082edffc80174eb8Structure r) {
this = r;
}


public static bool operator == (ST_0f0d90fe4adeeddf082edffc80174eb8Structure a, ST_0f0d90fe4adeeddf082edffc80174eb8Structure b) {
if (a.ssACCOUNT_DETAIL != b.ssACCOUNT_DETAIL) return false;
if (a.ssRETURN != b.ssRETURN) return false;
return true;
}

public static bool operator != (ST_0f0d90fe4adeeddf082edffc80174eb8Structure a, ST_0f0d90fe4adeeddf082edffc80174eb8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0f0d90fe4adeeddf082edffc80174eb8Structure)) return false;
return (this == (ST_0f0d90fe4adeeddf082edffc80174eb8Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssACCOUNT_DETAIL.GetHashCode()
 ^ ssRETURN.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssACCOUNT_DETAIL.RecursiveReset();
ssRETURN.RecursiveReset();
}

public void InternalRecursiveSave() {
ssACCOUNT_DETAIL.InternalRecursiveSave();
ssRETURN.InternalRecursiveSave();
}


public ST_0f0d90fe4adeeddf082edffc80174eb8Structure Duplicate() {
ST_0f0d90fe4adeeddf082edffc80174eb8Structure t;
t.ssACCOUNT_DETAIL = (ST_d2beaf811f074c88054765b10d929011Structure)this.ssACCOUNT_DETAIL.Duplicate();
t.ssRETURN = (ST_e5256660414a7d3dddc63b7cbdd21e9cStructure)this.ssRETURN.Duplicate();
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
if (head == "account_detail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ACCOUNT_DETAIL")) variable.Value = ssACCOUNT_DETAIL; else variable.Optimized = true;
variable.SetFieldName("account_detail");
} else if (head == "return") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RETURN")) variable.Value = ssRETURN; else variable.Optimized = true;
variable.SetFieldName("return");
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
if (key == IdACCOUNT_DETAIL) {
return ssACCOUNT_DETAIL;
}
if (key == IdRETURN) {
return ssRETURN;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdACCOUNT_DETAIL.Key.AsGuid) {
return ssACCOUNT_DETAIL;
}
if (attributeKey == IdRETURN.Key.AsGuid) {
return ssRETURN;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssACCOUNT_DETAIL.FillFromOther((IRecord) other.AttributeGet(IdACCOUNT_DETAIL));
ssRETURN.FillFromOther((IRecord) other.AttributeGet(IdRETURN));
}
} // ST_0f0d90fe4adeeddf082edffc80174eb8Structure
/// <summary>
/// RecordList type <code>BAPI_GL_ACC_GETDETAILRespList</code> that represents a record list of
///  <code>BAPI_GL_ACC_GETDETAILResp</code>
/// </summary>
public partial class RL_a56a25eca22cf3376e63d8e3e733e8a8 : GenericRecordList<ST_0f0d90fe4adeeddf082edffc80174eb8Structure>, IEnumerable, IEnumerator {

protected override ST_0f0d90fe4adeeddf082edffc80174eb8Structure GetElementDefaultValue() {
return new ST_0f0d90fe4adeeddf082edffc80174eb8Structure();
}

public T[] ToArray<T>(Func<ST_0f0d90fe4adeeddf082edffc80174eb8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a56a25eca22cf3376e63d8e3e733e8a8 recordList, Func<ST_0f0d90fe4adeeddf082edffc80174eb8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a56a25eca22cf3376e63d8e3e733e8a8(ST_0f0d90fe4adeeddf082edffc80174eb8Structure[] array) {
  RL_a56a25eca22cf3376e63d8e3e733e8a8 result = new RL_a56a25eca22cf3376e63d8e3e733e8a8();
result.InnerFromArray(array);
    return result;
}

public static RL_a56a25eca22cf3376e63d8e3e733e8a8 ToList<T>(T[] array, Func <T, ST_0f0d90fe4adeeddf082edffc80174eb8Structure> converter) {
  RL_a56a25eca22cf3376e63d8e3e733e8a8 result = new RL_a56a25eca22cf3376e63d8e3e733e8a8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a56a25eca22cf3376e63d8e3e733e8a8 FromRestList<T>(RestList<T> restList, Func <T, ST_0f0d90fe4adeeddf082edffc80174eb8Structure> converter) {
  RL_a56a25eca22cf3376e63d8e3e733e8a8 result = new RL_a56a25eca22cf3376e63d8e3e733e8a8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a56a25eca22cf3376e63d8e3e733e8a8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = null;
def[1] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0f0d90fe4adeeddf082edffc80174eb8Structure> NewList() {
return new RL_a56a25eca22cf3376e63d8e3e733e8a8();
}


} // RL_a56a25eca22cf3376e63d8e3e733e8a8
}

