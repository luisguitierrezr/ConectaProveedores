namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (peMzlSwHJE6wbHvuaG7ODQ)
///  <code>RC_027dc494fad7472a5ec9709173f161a6</code> that represent
/// s <code>BAPI_GL_ACC_GETDETAILRespRecord</code> <p>Description: </p>
/// </summary>
// Name: BAPI_GL_ACC_GETDETAILRespRecord
public partial struct RC_027dc494fad7472a5ec9709173f161a6 : ITypedRecord<RC_027dc494fad7472a5ec9709173f161a6> {
internal static readonly GlobalObjectKey IdBAPI_GL_ACC_GETDETAILResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lMR9Atf6KkdeyXCRc_Fhpg");

public ST_0f0d90fe4adeeddf082edffc80174eb8Structure ssSTBAPI_GL_ACC_GETDETAILResp;


public static implicit operator ST_0f0d90fe4adeeddf082edffc80174eb8Structure( RC_027dc494fad7472a5ec9709173f161a6 r) {
return r.ssSTBAPI_GL_ACC_GETDETAILResp;
}

public static implicit operator RC_027dc494fad7472a5ec9709173f161a6 (ST_0f0d90fe4adeeddf082edffc80174eb8Structure r) {
RC_027dc494fad7472a5ec9709173f161a6 res = new RC_027dc494fad7472a5ec9709173f161a6 ();
res.ssSTBAPI_GL_ACC_GETDETAILResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_027dc494fad7472a5ec9709173f161a6() {
OptimizedAttributes = null;
ssSTBAPI_GL_ACC_GETDETAILResp = new ST_0f0d90fe4adeeddf082edffc80174eb8Structure();
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
    ssSTBAPI_GL_ACC_GETDETAILResp.OptimizedAttributes = value[0];
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
ssSTBAPI_GL_ACC_GETDETAILResp.Read( r, ref index);
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
public void ReadIM(RC_027dc494fad7472a5ec9709173f161a6 r) {
this = r;
}


public static bool operator == (RC_027dc494fad7472a5ec9709173f161a6 a, RC_027dc494fad7472a5ec9709173f161a6 b) {
if (a.ssSTBAPI_GL_ACC_GETDETAILResp != b.ssSTBAPI_GL_ACC_GETDETAILResp) return false;
return true;
}

public static bool operator != (RC_027dc494fad7472a5ec9709173f161a6 a, RC_027dc494fad7472a5ec9709173f161a6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_027dc494fad7472a5ec9709173f161a6)) return false;
return (this == (RC_027dc494fad7472a5ec9709173f161a6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTBAPI_GL_ACC_GETDETAILResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTBAPI_GL_ACC_GETDETAILResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTBAPI_GL_ACC_GETDETAILResp.InternalRecursiveSave();
}


public RC_027dc494fad7472a5ec9709173f161a6 Duplicate() {
RC_027dc494fad7472a5ec9709173f161a6 t;
t.ssSTBAPI_GL_ACC_GETDETAILResp = (ST_0f0d90fe4adeeddf082edffc80174eb8Structure)this.ssSTBAPI_GL_ACC_GETDETAILResp.Duplicate();
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
if (head == "bapi_gl_acc_getdetailresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BAPI_GL_ACC_GETDETAILResp")) variable.Value = ssSTBAPI_GL_ACC_GETDETAILResp; else variable.Optimized = true;
variable.SetFieldName("bapi_gl_acc_getdetailresp");
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
if (key == IdBAPI_GL_ACC_GETDETAILResp) {
return ssSTBAPI_GL_ACC_GETDETAILResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBAPI_GL_ACC_GETDETAILResp.Key.AsGuid) {
return ssSTBAPI_GL_ACC_GETDETAILResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTBAPI_GL_ACC_GETDETAILResp.FillFromOther((IRecord) other.AttributeGet(IdBAPI_GL_ACC_GETDETAILResp));
}
} // RC_027dc494fad7472a5ec9709173f161a6
/// <summary>
/// RecordList type <code>BAPI_GL_ACC_GETDETAILRespRecordList</code> that represents a record list of
///  <code>BAPI_GL_ACC_GETDETAILResp</code>
/// </summary>
public partial class RL_917d112af5f9475c3b65381e25e046d7 : GenericRecordList<RC_027dc494fad7472a5ec9709173f161a6>, IEnumerable, IEnumerator {

protected override RC_027dc494fad7472a5ec9709173f161a6 GetElementDefaultValue() {
return new RC_027dc494fad7472a5ec9709173f161a6();
}

public T[] ToArray<T>(Func<RC_027dc494fad7472a5ec9709173f161a6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_917d112af5f9475c3b65381e25e046d7 recordList, Func<RC_027dc494fad7472a5ec9709173f161a6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_917d112af5f9475c3b65381e25e046d7(RC_027dc494fad7472a5ec9709173f161a6[] array) {
  RL_917d112af5f9475c3b65381e25e046d7 result = new RL_917d112af5f9475c3b65381e25e046d7();
result.InnerFromArray(array);
    return result;
}

public static RL_917d112af5f9475c3b65381e25e046d7 ToList<T>(T[] array, Func <T, RC_027dc494fad7472a5ec9709173f161a6> converter) {
  RL_917d112af5f9475c3b65381e25e046d7 result = new RL_917d112af5f9475c3b65381e25e046d7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_917d112af5f9475c3b65381e25e046d7 FromRestList<T>(RestList<T> restList, Func <T, RC_027dc494fad7472a5ec9709173f161a6> converter) {
  RL_917d112af5f9475c3b65381e25e046d7 result = new RL_917d112af5f9475c3b65381e25e046d7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_917d112af5f9475c3b65381e25e046d7() : base() {
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
protected override OSList<RC_027dc494fad7472a5ec9709173f161a6> NewList() {
return new RL_917d112af5f9475c3b65381e25e046d7();
}


} // RL_917d112af5f9475c3b65381e25e046d7
}

