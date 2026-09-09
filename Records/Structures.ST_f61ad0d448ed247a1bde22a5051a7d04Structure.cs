namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_SM_MO_COSMOZ_Request (7JEQDWdRVEiFScrIDT1RMw)
///  <code>ST_f61ad0d448ed247a1bde22a5051a7d04Structure</code> that represent
/// s <code>EM_SM_MO_COSMOZ_Request</code> <p>Description: EM_SM_MO_COSMOZ_Request</p>
/// </summary>
// Name: EM_SM_MO_COSMOZ_Request
public partial struct ST_f61ad0d448ed247a1bde22a5051a7d04Structure : ITypedRecord<ST_f61ad0d448ed247a1bde22a5051a7d04Structure> {
internal static readonly GlobalObjectKey IdEM_SM_MO_COSMOZ_Request_Struct = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*x2fDLTIDLU+vXEo0ehLgqw");

public ST_e88e810a3be3c7b278de1b477e897388Structure ssEM_SM_MO_COSMOZ_Request_Struct;


public BitArray OptimizedAttributes;

public ST_f61ad0d448ed247a1bde22a5051a7d04Structure() {
OptimizedAttributes = null;
ssEM_SM_MO_COSMOZ_Request_Struct = new ST_e88e810a3be3c7b278de1b477e897388Structure();
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
    ssEM_SM_MO_COSMOZ_Request_Struct.OptimizedAttributes = value[0];
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
public void ReadIM(ST_f61ad0d448ed247a1bde22a5051a7d04Structure r) {
this = r;
}


public static bool operator == (ST_f61ad0d448ed247a1bde22a5051a7d04Structure a, ST_f61ad0d448ed247a1bde22a5051a7d04Structure b) {
if (a.ssEM_SM_MO_COSMOZ_Request_Struct != b.ssEM_SM_MO_COSMOZ_Request_Struct) return false;
return true;
}

public static bool operator != (ST_f61ad0d448ed247a1bde22a5051a7d04Structure a, ST_f61ad0d448ed247a1bde22a5051a7d04Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f61ad0d448ed247a1bde22a5051a7d04Structure)) return false;
return (this == (ST_f61ad0d448ed247a1bde22a5051a7d04Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEM_SM_MO_COSMOZ_Request_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssEM_SM_MO_COSMOZ_Request_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssEM_SM_MO_COSMOZ_Request_Struct.InternalRecursiveSave();
}


public ST_f61ad0d448ed247a1bde22a5051a7d04Structure Duplicate() {
ST_f61ad0d448ed247a1bde22a5051a7d04Structure t;
t.ssEM_SM_MO_COSMOZ_Request_Struct = (ST_e88e810a3be3c7b278de1b477e897388Structure)this.ssEM_SM_MO_COSMOZ_Request_Struct.Duplicate();
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
if (head == "em_sm_mo_cosmoz_request_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_MO_COSMOZ_Request_Struct")) variable.Value = ssEM_SM_MO_COSMOZ_Request_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_mo_cosmoz_request_struct");
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
if (key == IdEM_SM_MO_COSMOZ_Request_Struct) {
return ssEM_SM_MO_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_MO_COSMOZ_Request_Struct.Key.AsGuid) {
return ssEM_SM_MO_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEM_SM_MO_COSMOZ_Request_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_MO_COSMOZ_Request_Struct));
}
} // ST_f61ad0d448ed247a1bde22a5051a7d04Structure
/// <summary>
/// RecordList type <code>EM_SM_MO_COSMOZ_RequestList</code> that represents a record list of
///  <code>EM_SM_MO_COSMOZ_Request</code>
/// </summary>
public partial class RL_957fa77aa0565cb52aad7e7e34f95a73 : GenericRecordList<ST_f61ad0d448ed247a1bde22a5051a7d04Structure>, IEnumerable, IEnumerator {

protected override ST_f61ad0d448ed247a1bde22a5051a7d04Structure GetElementDefaultValue() {
return new ST_f61ad0d448ed247a1bde22a5051a7d04Structure();
}

public T[] ToArray<T>(Func<ST_f61ad0d448ed247a1bde22a5051a7d04Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_957fa77aa0565cb52aad7e7e34f95a73 recordList, Func<ST_f61ad0d448ed247a1bde22a5051a7d04Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_957fa77aa0565cb52aad7e7e34f95a73(ST_f61ad0d448ed247a1bde22a5051a7d04Structure[] array) {
  RL_957fa77aa0565cb52aad7e7e34f95a73 result = new RL_957fa77aa0565cb52aad7e7e34f95a73();
result.InnerFromArray(array);
    return result;
}

public static RL_957fa77aa0565cb52aad7e7e34f95a73 ToList<T>(T[] array, Func <T, ST_f61ad0d448ed247a1bde22a5051a7d04Structure> converter) {
  RL_957fa77aa0565cb52aad7e7e34f95a73 result = new RL_957fa77aa0565cb52aad7e7e34f95a73();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_957fa77aa0565cb52aad7e7e34f95a73 FromRestList<T>(RestList<T> restList, Func <T, ST_f61ad0d448ed247a1bde22a5051a7d04Structure> converter) {
  RL_957fa77aa0565cb52aad7e7e34f95a73 result = new RL_957fa77aa0565cb52aad7e7e34f95a73();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_957fa77aa0565cb52aad7e7e34f95a73() : base() {
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
protected override OSList<ST_f61ad0d448ed247a1bde22a5051a7d04Structure> NewList() {
return new RL_957fa77aa0565cb52aad7e7e34f95a73();
}


} // RL_957fa77aa0565cb52aad7e7e34f95a73
}

