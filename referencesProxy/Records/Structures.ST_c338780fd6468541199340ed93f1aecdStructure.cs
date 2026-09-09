namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] EM_SM_RM_COSMOZ_Request (f2IXP3SBiE+vF75giQIOUw)
///  <code>ST_c338780fd6468541199340ed93f1aecdStructure</code> that represent
/// s <code>EM_SM_RM_COSMOZ_Request</code> <p>Description: EM_SM_RM_COSMOZ_Request</p>
/// </summary>
// Name: EM_SM_RM_COSMOZ_Request
public partial struct ST_c338780fd6468541199340ed93f1aecdStructure : ITypedRecord<ST_c338780fd6468541199340ed93f1aecdStructure> {
internal static readonly GlobalObjectKey IdEM_SM_RM_COSMOZ_Request_Struct = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*gYkxgaXpGUyFqPhCLAQyIg");

public ST_b38fe38940c72474a8e67442651bc995Structure ssEM_SM_RM_COSMOZ_Request_Struct;


public BitArray OptimizedAttributes;

public ST_c338780fd6468541199340ed93f1aecdStructure() {
OptimizedAttributes = null;
ssEM_SM_RM_COSMOZ_Request_Struct = new ST_b38fe38940c72474a8e67442651bc995Structure();
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
    ssEM_SM_RM_COSMOZ_Request_Struct.OptimizedAttributes = value[0];
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
public void ReadIM(ST_c338780fd6468541199340ed93f1aecdStructure r) {
this = r;
}


public static bool operator == (ST_c338780fd6468541199340ed93f1aecdStructure a, ST_c338780fd6468541199340ed93f1aecdStructure b) {
if (a.ssEM_SM_RM_COSMOZ_Request_Struct != b.ssEM_SM_RM_COSMOZ_Request_Struct) return false;
return true;
}

public static bool operator != (ST_c338780fd6468541199340ed93f1aecdStructure a, ST_c338780fd6468541199340ed93f1aecdStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_c338780fd6468541199340ed93f1aecdStructure)) return false;
return (this == (ST_c338780fd6468541199340ed93f1aecdStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEM_SM_RM_COSMOZ_Request_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssEM_SM_RM_COSMOZ_Request_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssEM_SM_RM_COSMOZ_Request_Struct.InternalRecursiveSave();
}


public ST_c338780fd6468541199340ed93f1aecdStructure Duplicate() {
ST_c338780fd6468541199340ed93f1aecdStructure t;
t.ssEM_SM_RM_COSMOZ_Request_Struct = (ST_b38fe38940c72474a8e67442651bc995Structure)this.ssEM_SM_RM_COSMOZ_Request_Struct.Duplicate();
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_RM_COSMOZ_Request_Struct")) variable.Value = ssEM_SM_RM_COSMOZ_Request_Struct; else variable.Optimized = true;
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
return ssEM_SM_RM_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_RM_COSMOZ_Request_Struct.Key.AsGuid) {
return ssEM_SM_RM_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEM_SM_RM_COSMOZ_Request_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_RM_COSMOZ_Request_Struct));
}
} // ST_c338780fd6468541199340ed93f1aecdStructure
/// <summary>
/// RecordList type <code>EM_SM_RM_COSMOZ_RequestList</code> that represents a record list of
///  <code>EM_SM_RM_COSMOZ_Request</code>
/// </summary>
public partial class RL_fa9d84d1ee8ce57b6c23f0e7b29b404f : GenericRecordList<ST_c338780fd6468541199340ed93f1aecdStructure>, IEnumerable, IEnumerator {

protected override ST_c338780fd6468541199340ed93f1aecdStructure GetElementDefaultValue() {
return new ST_c338780fd6468541199340ed93f1aecdStructure();
}

public T[] ToArray<T>(Func<ST_c338780fd6468541199340ed93f1aecdStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fa9d84d1ee8ce57b6c23f0e7b29b404f recordList, Func<ST_c338780fd6468541199340ed93f1aecdStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fa9d84d1ee8ce57b6c23f0e7b29b404f(ST_c338780fd6468541199340ed93f1aecdStructure[] array) {
  RL_fa9d84d1ee8ce57b6c23f0e7b29b404f result = new RL_fa9d84d1ee8ce57b6c23f0e7b29b404f();
result.InnerFromArray(array);
    return result;
}

public static RL_fa9d84d1ee8ce57b6c23f0e7b29b404f ToList<T>(T[] array, Func <T, ST_c338780fd6468541199340ed93f1aecdStructure> converter) {
  RL_fa9d84d1ee8ce57b6c23f0e7b29b404f result = new RL_fa9d84d1ee8ce57b6c23f0e7b29b404f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fa9d84d1ee8ce57b6c23f0e7b29b404f FromRestList<T>(RestList<T> restList, Func <T, ST_c338780fd6468541199340ed93f1aecdStructure> converter) {
  RL_fa9d84d1ee8ce57b6c23f0e7b29b404f result = new RL_fa9d84d1ee8ce57b6c23f0e7b29b404f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fa9d84d1ee8ce57b6c23f0e7b29b404f() : base() {
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
protected override OSList<ST_c338780fd6468541199340ed93f1aecdStructure> NewList() {
return new RL_fa9d84d1ee8ce57b6c23f0e7b29b404f();
}


} // RL_fa9d84d1ee8ce57b6c23f0e7b29b404f
}

