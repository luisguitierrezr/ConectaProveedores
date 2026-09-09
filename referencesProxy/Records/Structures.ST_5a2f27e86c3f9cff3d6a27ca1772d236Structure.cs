namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] EM_SM_MO_COSMOZ_Response (CRguo8Q8uEqXeCdiJWN9jQ)
///  <code>ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure</code> that represent
/// s <code>EM_SM_MO_COSMOZ_Response</code> <p>Description: EM_SM_MO_COSMOZ_Response</p>
/// </summary>
// Name: EM_SM_MO_COSMOZ_Response
public partial struct ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure : ITypedRecord<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> {
internal static readonly GlobalObjectKey IdEM_SM_MO_COSMOZ_Response_Struct = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*XhD5EfLN5EegZq9h1iOu8w");

public ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure ssEM_SM_MO_COSMOZ_Response_Struct;


public BitArray OptimizedAttributes;

public ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure() {
OptimizedAttributes = null;
ssEM_SM_MO_COSMOZ_Response_Struct = new ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure();
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
    ssEM_SM_MO_COSMOZ_Response_Struct.OptimizedAttributes = value[0];
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
public void ReadIM(ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure r) {
this = r;
}


public static bool operator == (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure a, ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure b) {
if (a.ssEM_SM_MO_COSMOZ_Response_Struct != b.ssEM_SM_MO_COSMOZ_Response_Struct) return false;
return true;
}

public static bool operator != (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure a, ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure)) return false;
return (this == (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEM_SM_MO_COSMOZ_Response_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssEM_SM_MO_COSMOZ_Response_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssEM_SM_MO_COSMOZ_Response_Struct.InternalRecursiveSave();
}


public ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure Duplicate() {
ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure t;
t.ssEM_SM_MO_COSMOZ_Response_Struct = (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure)this.ssEM_SM_MO_COSMOZ_Response_Struct.Duplicate();
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
if (head == "em_sm_mo_cosmoz_response_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_MO_COSMOZ_Response_Struct")) variable.Value = ssEM_SM_MO_COSMOZ_Response_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_mo_cosmoz_response_struct");
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
if (key == IdEM_SM_MO_COSMOZ_Response_Struct) {
return ssEM_SM_MO_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_MO_COSMOZ_Response_Struct.Key.AsGuid) {
return ssEM_SM_MO_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEM_SM_MO_COSMOZ_Response_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_MO_COSMOZ_Response_Struct));
}
} // ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure
/// <summary>
/// RecordList type <code>EM_SM_MO_COSMOZ_ResponseList</code> that represents a record list of
///  <code>EM_SM_MO_COSMOZ_Response</code>
/// </summary>
public partial class RL_c3e9ac06e8c6292798830c1bd1e79a54 : GenericRecordList<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure>, IEnumerable, IEnumerator {

protected override ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure GetElementDefaultValue() {
return new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure();
}

public T[] ToArray<T>(Func<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c3e9ac06e8c6292798830c1bd1e79a54 recordList, Func<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c3e9ac06e8c6292798830c1bd1e79a54(ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure[] array) {
  RL_c3e9ac06e8c6292798830c1bd1e79a54 result = new RL_c3e9ac06e8c6292798830c1bd1e79a54();
result.InnerFromArray(array);
    return result;
}

public static RL_c3e9ac06e8c6292798830c1bd1e79a54 ToList<T>(T[] array, Func <T, ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> converter) {
  RL_c3e9ac06e8c6292798830c1bd1e79a54 result = new RL_c3e9ac06e8c6292798830c1bd1e79a54();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c3e9ac06e8c6292798830c1bd1e79a54 FromRestList<T>(RestList<T> restList, Func <T, ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> converter) {
  RL_c3e9ac06e8c6292798830c1bd1e79a54 result = new RL_c3e9ac06e8c6292798830c1bd1e79a54();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c3e9ac06e8c6292798830c1bd1e79a54() : base() {
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
protected override OSList<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> NewList() {
return new RL_c3e9ac06e8c6292798830c1bd1e79a54();
}


} // RL_c3e9ac06e8c6292798830c1bd1e79a54
}

