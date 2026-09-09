namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (rgTDF7fK+k6WkQ0+Gw1S4w)
///  <code>RC_f55a11d7040a1cc865a8cd2002788075</code> that represent
/// s <code>EM_SM_RM_COSMOZ_Request_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_RM_COSMOZ_Request_StructRecord
public partial struct RC_f55a11d7040a1cc865a8cd2002788075 : ITypedRecord<RC_f55a11d7040a1cc865a8cd2002788075> {
internal static readonly GlobalObjectKey IdEM_SM_RM_COSMOZ_Request_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1xFa9QoEyBxlqM0gAniAdQ");

public ST_b38fe38940c72474a8e67442651bc995Structure ssSTEM_SM_RM_COSMOZ_Request_Struct;


public static implicit operator ST_b38fe38940c72474a8e67442651bc995Structure( RC_f55a11d7040a1cc865a8cd2002788075 r) {
return r.ssSTEM_SM_RM_COSMOZ_Request_Struct;
}

public static implicit operator RC_f55a11d7040a1cc865a8cd2002788075 (ST_b38fe38940c72474a8e67442651bc995Structure r) {
RC_f55a11d7040a1cc865a8cd2002788075 res = new RC_f55a11d7040a1cc865a8cd2002788075 ();
res.ssSTEM_SM_RM_COSMOZ_Request_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f55a11d7040a1cc865a8cd2002788075() {
OptimizedAttributes = null;
ssSTEM_SM_RM_COSMOZ_Request_Struct = new ST_b38fe38940c72474a8e67442651bc995Structure();
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
    ssSTEM_SM_RM_COSMOZ_Request_Struct.OptimizedAttributes = value[0];
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
ssSTEM_SM_RM_COSMOZ_Request_Struct.Read( r, ref index);
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
public void ReadIM(RC_f55a11d7040a1cc865a8cd2002788075 r) {
this = r;
}


public static bool operator == (RC_f55a11d7040a1cc865a8cd2002788075 a, RC_f55a11d7040a1cc865a8cd2002788075 b) {
if (a.ssSTEM_SM_RM_COSMOZ_Request_Struct != b.ssSTEM_SM_RM_COSMOZ_Request_Struct) return false;
return true;
}

public static bool operator != (RC_f55a11d7040a1cc865a8cd2002788075 a, RC_f55a11d7040a1cc865a8cd2002788075 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f55a11d7040a1cc865a8cd2002788075)) return false;
return (this == (RC_f55a11d7040a1cc865a8cd2002788075)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_RM_COSMOZ_Request_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_RM_COSMOZ_Request_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_RM_COSMOZ_Request_Struct.InternalRecursiveSave();
}


public RC_f55a11d7040a1cc865a8cd2002788075 Duplicate() {
RC_f55a11d7040a1cc865a8cd2002788075 t;
t.ssSTEM_SM_RM_COSMOZ_Request_Struct = (ST_b38fe38940c72474a8e67442651bc995Structure)this.ssSTEM_SM_RM_COSMOZ_Request_Struct.Duplicate();
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
if (head == "em_sm_rm_cosmoz_request_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_RM_COSMOZ_Request_Struct")) variable.Value = ssSTEM_SM_RM_COSMOZ_Request_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_rm_cosmoz_request_struct");
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
if (key == IdEM_SM_RM_COSMOZ_Request_Struct) {
return ssSTEM_SM_RM_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_RM_COSMOZ_Request_Struct.Key.AsGuid) {
return ssSTEM_SM_RM_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_RM_COSMOZ_Request_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_RM_COSMOZ_Request_Struct));
}
} // RC_f55a11d7040a1cc865a8cd2002788075
/// <summary>
/// RecordList type <code>EM_SM_RM_COSMOZ_Request_StructRecordList</code> that represents a record list
///  of <code>EM_SM_RM_COSMOZ_Request_Struct</code>
/// </summary>
public partial class RL_e85ce05b08a696d98563cee50d7ad4e9 : GenericRecordList<RC_f55a11d7040a1cc865a8cd2002788075>, IEnumerable, IEnumerator {

protected override RC_f55a11d7040a1cc865a8cd2002788075 GetElementDefaultValue() {
return new RC_f55a11d7040a1cc865a8cd2002788075();
}

public T[] ToArray<T>(Func<RC_f55a11d7040a1cc865a8cd2002788075, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e85ce05b08a696d98563cee50d7ad4e9 recordList, Func<RC_f55a11d7040a1cc865a8cd2002788075, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e85ce05b08a696d98563cee50d7ad4e9(RC_f55a11d7040a1cc865a8cd2002788075[] array) {
  RL_e85ce05b08a696d98563cee50d7ad4e9 result = new RL_e85ce05b08a696d98563cee50d7ad4e9();
result.InnerFromArray(array);
    return result;
}

public static RL_e85ce05b08a696d98563cee50d7ad4e9 ToList<T>(T[] array, Func <T, RC_f55a11d7040a1cc865a8cd2002788075> converter) {
  RL_e85ce05b08a696d98563cee50d7ad4e9 result = new RL_e85ce05b08a696d98563cee50d7ad4e9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e85ce05b08a696d98563cee50d7ad4e9 FromRestList<T>(RestList<T> restList, Func <T, RC_f55a11d7040a1cc865a8cd2002788075> converter) {
  RL_e85ce05b08a696d98563cee50d7ad4e9 result = new RL_e85ce05b08a696d98563cee50d7ad4e9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e85ce05b08a696d98563cee50d7ad4e9() : base() {
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
protected override OSList<RC_f55a11d7040a1cc865a8cd2002788075> NewList() {
return new RL_e85ce05b08a696d98563cee50d7ad4e9();
}


} // RL_e85ce05b08a696d98563cee50d7ad4e9
}

