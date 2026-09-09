namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (ME_9WKtp7UqFD0CnRJ1kaA)
///  <code>RC_005bcb84b613dbc7d93b98c3c1aa6999</code> that represent
/// s <code>EM_SM_RM_COSMOZ_Response_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_RM_COSMOZ_Response_StructRecord
public partial struct RC_005bcb84b613dbc7d93b98c3c1aa6999 : ITypedRecord<RC_005bcb84b613dbc7d93b98c3c1aa6999> {
internal static readonly GlobalObjectKey IdEM_SM_RM_COSMOZ_Response_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hMtbABO2x9vZO5jDwappmQ");

public ST_e4cfb5ae163d3591da9f760267d740aaStructure ssSTEM_SM_RM_COSMOZ_Response_Struct;


public static implicit operator ST_e4cfb5ae163d3591da9f760267d740aaStructure( RC_005bcb84b613dbc7d93b98c3c1aa6999 r) {
return r.ssSTEM_SM_RM_COSMOZ_Response_Struct;
}

public static implicit operator RC_005bcb84b613dbc7d93b98c3c1aa6999 (ST_e4cfb5ae163d3591da9f760267d740aaStructure r) {
RC_005bcb84b613dbc7d93b98c3c1aa6999 res = new RC_005bcb84b613dbc7d93b98c3c1aa6999 ();
res.ssSTEM_SM_RM_COSMOZ_Response_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_005bcb84b613dbc7d93b98c3c1aa6999() {
OptimizedAttributes = null;
ssSTEM_SM_RM_COSMOZ_Response_Struct = new ST_e4cfb5ae163d3591da9f760267d740aaStructure();
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
    ssSTEM_SM_RM_COSMOZ_Response_Struct.OptimizedAttributes = value[0];
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
ssSTEM_SM_RM_COSMOZ_Response_Struct.Read( r, ref index);
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
public void ReadIM(RC_005bcb84b613dbc7d93b98c3c1aa6999 r) {
this = r;
}


public static bool operator == (RC_005bcb84b613dbc7d93b98c3c1aa6999 a, RC_005bcb84b613dbc7d93b98c3c1aa6999 b) {
if (a.ssSTEM_SM_RM_COSMOZ_Response_Struct != b.ssSTEM_SM_RM_COSMOZ_Response_Struct) return false;
return true;
}

public static bool operator != (RC_005bcb84b613dbc7d93b98c3c1aa6999 a, RC_005bcb84b613dbc7d93b98c3c1aa6999 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_005bcb84b613dbc7d93b98c3c1aa6999)) return false;
return (this == (RC_005bcb84b613dbc7d93b98c3c1aa6999)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_RM_COSMOZ_Response_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_RM_COSMOZ_Response_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_RM_COSMOZ_Response_Struct.InternalRecursiveSave();
}


public RC_005bcb84b613dbc7d93b98c3c1aa6999 Duplicate() {
RC_005bcb84b613dbc7d93b98c3c1aa6999 t;
t.ssSTEM_SM_RM_COSMOZ_Response_Struct = (ST_e4cfb5ae163d3591da9f760267d740aaStructure)this.ssSTEM_SM_RM_COSMOZ_Response_Struct.Duplicate();
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
if (head == "em_sm_rm_cosmoz_response_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_RM_COSMOZ_Response_Struct")) variable.Value = ssSTEM_SM_RM_COSMOZ_Response_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_rm_cosmoz_response_struct");
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
if (key == IdEM_SM_RM_COSMOZ_Response_Struct) {
return ssSTEM_SM_RM_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_RM_COSMOZ_Response_Struct.Key.AsGuid) {
return ssSTEM_SM_RM_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_RM_COSMOZ_Response_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_RM_COSMOZ_Response_Struct));
}
} // RC_005bcb84b613dbc7d93b98c3c1aa6999
/// <summary>
/// RecordList type <code>EM_SM_RM_COSMOZ_Response_StructRecordList</code> that represents a record
///  list of <code>EM_SM_RM_COSMOZ_Response_Struct</code>
/// </summary>
public partial class RL_828f92aaab8aae30092b910510ceadf8 : GenericRecordList<RC_005bcb84b613dbc7d93b98c3c1aa6999>, IEnumerable, IEnumerator {

protected override RC_005bcb84b613dbc7d93b98c3c1aa6999 GetElementDefaultValue() {
return new RC_005bcb84b613dbc7d93b98c3c1aa6999();
}

public T[] ToArray<T>(Func<RC_005bcb84b613dbc7d93b98c3c1aa6999, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_828f92aaab8aae30092b910510ceadf8 recordList, Func<RC_005bcb84b613dbc7d93b98c3c1aa6999, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_828f92aaab8aae30092b910510ceadf8(RC_005bcb84b613dbc7d93b98c3c1aa6999[] array) {
  RL_828f92aaab8aae30092b910510ceadf8 result = new RL_828f92aaab8aae30092b910510ceadf8();
result.InnerFromArray(array);
    return result;
}

public static RL_828f92aaab8aae30092b910510ceadf8 ToList<T>(T[] array, Func <T, RC_005bcb84b613dbc7d93b98c3c1aa6999> converter) {
  RL_828f92aaab8aae30092b910510ceadf8 result = new RL_828f92aaab8aae30092b910510ceadf8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_828f92aaab8aae30092b910510ceadf8 FromRestList<T>(RestList<T> restList, Func <T, RC_005bcb84b613dbc7d93b98c3c1aa6999> converter) {
  RL_828f92aaab8aae30092b910510ceadf8 result = new RL_828f92aaab8aae30092b910510ceadf8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_828f92aaab8aae30092b910510ceadf8() : base() {
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
protected override OSList<RC_005bcb84b613dbc7d93b98c3c1aa6999> NewList() {
return new RL_828f92aaab8aae30092b910510ceadf8();
}


} // RL_828f92aaab8aae30092b910510ceadf8
}

