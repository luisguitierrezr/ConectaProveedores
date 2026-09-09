namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_SM_RM_COSMOZ_Response (h3L3KYpF7kispRcc7gzZjw)
///  <code>ST_b3b2573902c6e22d9647e405d3baf728Structure</code> that represent
/// s <code>EM_SM_RM_COSMOZ_Response</code> <p>Description: EM_SM_RM_COSMOZ_Response</p>
/// </summary>
// Name: EM_SM_RM_COSMOZ_Response
public partial struct ST_b3b2573902c6e22d9647e405d3baf728Structure : ITypedRecord<ST_b3b2573902c6e22d9647e405d3baf728Structure> {
internal static readonly GlobalObjectKey IdEM_SM_RM_COSMOZ_Response_Struct = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*5HlDO_aoXUCgAvrFbmMBhQ");

public ST_e4cfb5ae163d3591da9f760267d740aaStructure ssEM_SM_RM_COSMOZ_Response_Struct;


public BitArray OptimizedAttributes;

public ST_b3b2573902c6e22d9647e405d3baf728Structure() {
OptimizedAttributes = null;
ssEM_SM_RM_COSMOZ_Response_Struct = new ST_e4cfb5ae163d3591da9f760267d740aaStructure();
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
    ssEM_SM_RM_COSMOZ_Response_Struct.OptimizedAttributes = value[0];
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
public void ReadIM(ST_b3b2573902c6e22d9647e405d3baf728Structure r) {
this = r;
}


public static bool operator == (ST_b3b2573902c6e22d9647e405d3baf728Structure a, ST_b3b2573902c6e22d9647e405d3baf728Structure b) {
if (a.ssEM_SM_RM_COSMOZ_Response_Struct != b.ssEM_SM_RM_COSMOZ_Response_Struct) return false;
return true;
}

public static bool operator != (ST_b3b2573902c6e22d9647e405d3baf728Structure a, ST_b3b2573902c6e22d9647e405d3baf728Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b3b2573902c6e22d9647e405d3baf728Structure)) return false;
return (this == (ST_b3b2573902c6e22d9647e405d3baf728Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEM_SM_RM_COSMOZ_Response_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssEM_SM_RM_COSMOZ_Response_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssEM_SM_RM_COSMOZ_Response_Struct.InternalRecursiveSave();
}


public ST_b3b2573902c6e22d9647e405d3baf728Structure Duplicate() {
ST_b3b2573902c6e22d9647e405d3baf728Structure t;
t.ssEM_SM_RM_COSMOZ_Response_Struct = (ST_e4cfb5ae163d3591da9f760267d740aaStructure)this.ssEM_SM_RM_COSMOZ_Response_Struct.Duplicate();
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_RM_COSMOZ_Response_Struct")) variable.Value = ssEM_SM_RM_COSMOZ_Response_Struct; else variable.Optimized = true;
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
return ssEM_SM_RM_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_RM_COSMOZ_Response_Struct.Key.AsGuid) {
return ssEM_SM_RM_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEM_SM_RM_COSMOZ_Response_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_RM_COSMOZ_Response_Struct));
}
} // ST_b3b2573902c6e22d9647e405d3baf728Structure
/// <summary>
/// RecordList type <code>EM_SM_RM_COSMOZ_ResponseList</code> that represents a record list of
///  <code>EM_SM_RM_COSMOZ_Response</code>
/// </summary>
public partial class RL_e0ebf7d55401e1fb3d6e2cfaadabfd19 : GenericRecordList<ST_b3b2573902c6e22d9647e405d3baf728Structure>, IEnumerable, IEnumerator {

protected override ST_b3b2573902c6e22d9647e405d3baf728Structure GetElementDefaultValue() {
return new ST_b3b2573902c6e22d9647e405d3baf728Structure();
}

public T[] ToArray<T>(Func<ST_b3b2573902c6e22d9647e405d3baf728Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e0ebf7d55401e1fb3d6e2cfaadabfd19 recordList, Func<ST_b3b2573902c6e22d9647e405d3baf728Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e0ebf7d55401e1fb3d6e2cfaadabfd19(ST_b3b2573902c6e22d9647e405d3baf728Structure[] array) {
  RL_e0ebf7d55401e1fb3d6e2cfaadabfd19 result = new RL_e0ebf7d55401e1fb3d6e2cfaadabfd19();
result.InnerFromArray(array);
    return result;
}

public static RL_e0ebf7d55401e1fb3d6e2cfaadabfd19 ToList<T>(T[] array, Func <T, ST_b3b2573902c6e22d9647e405d3baf728Structure> converter) {
  RL_e0ebf7d55401e1fb3d6e2cfaadabfd19 result = new RL_e0ebf7d55401e1fb3d6e2cfaadabfd19();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e0ebf7d55401e1fb3d6e2cfaadabfd19 FromRestList<T>(RestList<T> restList, Func <T, ST_b3b2573902c6e22d9647e405d3baf728Structure> converter) {
  RL_e0ebf7d55401e1fb3d6e2cfaadabfd19 result = new RL_e0ebf7d55401e1fb3d6e2cfaadabfd19();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e0ebf7d55401e1fb3d6e2cfaadabfd19() : base() {
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
protected override OSList<ST_b3b2573902c6e22d9647e405d3baf728Structure> NewList() {
return new RL_e0ebf7d55401e1fb3d6e2cfaadabfd19();
}


} // RL_e0ebf7d55401e1fb3d6e2cfaadabfd19
}

