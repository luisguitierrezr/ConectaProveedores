namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_SM_CECO_COSMOZ_Request (maPxfrMSCU6Hfho5Nv3amQ)
///  <code>ST_abeb699a3b96359819e408d199643162Structure</code> that represent
/// s <code>EM_SM_CECO_COSMOZ_Request</code> <p>Description: EM_SM_CECO_COSMOZ_Request</p>
/// </summary>
// Name: EM_SM_CECO_COSMOZ_Request
public partial struct ST_abeb699a3b96359819e408d199643162Structure : ITypedRecord<ST_abeb699a3b96359819e408d199643162Structure> {
internal static readonly GlobalObjectKey IdEM_SM_CECO_COSMOZ_Request_Struct = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*tEwO4FlBQEWa5VUsPY9pFw");

public ST_883584831b34399a326748c4b1ce95c9Structure ssEM_SM_CECO_COSMOZ_Request_Struct;


public BitArray OptimizedAttributes;

public ST_abeb699a3b96359819e408d199643162Structure() {
OptimizedAttributes = null;
ssEM_SM_CECO_COSMOZ_Request_Struct = new ST_883584831b34399a326748c4b1ce95c9Structure();
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
    ssEM_SM_CECO_COSMOZ_Request_Struct.OptimizedAttributes = value[0];
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
public void ReadIM(ST_abeb699a3b96359819e408d199643162Structure r) {
this = r;
}


public static bool operator == (ST_abeb699a3b96359819e408d199643162Structure a, ST_abeb699a3b96359819e408d199643162Structure b) {
if (a.ssEM_SM_CECO_COSMOZ_Request_Struct != b.ssEM_SM_CECO_COSMOZ_Request_Struct) return false;
return true;
}

public static bool operator != (ST_abeb699a3b96359819e408d199643162Structure a, ST_abeb699a3b96359819e408d199643162Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_abeb699a3b96359819e408d199643162Structure)) return false;
return (this == (ST_abeb699a3b96359819e408d199643162Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEM_SM_CECO_COSMOZ_Request_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssEM_SM_CECO_COSMOZ_Request_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssEM_SM_CECO_COSMOZ_Request_Struct.InternalRecursiveSave();
}


public ST_abeb699a3b96359819e408d199643162Structure Duplicate() {
ST_abeb699a3b96359819e408d199643162Structure t;
t.ssEM_SM_CECO_COSMOZ_Request_Struct = (ST_883584831b34399a326748c4b1ce95c9Structure)this.ssEM_SM_CECO_COSMOZ_Request_Struct.Duplicate();
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
if (head == "em_sm_ceco_cosmoz_request_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_CECO_COSMOZ_Request_Struct")) variable.Value = ssEM_SM_CECO_COSMOZ_Request_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_ceco_cosmoz_request_struct");
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
if (key == IdEM_SM_CECO_COSMOZ_Request_Struct) {
return ssEM_SM_CECO_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_CECO_COSMOZ_Request_Struct.Key.AsGuid) {
return ssEM_SM_CECO_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEM_SM_CECO_COSMOZ_Request_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_CECO_COSMOZ_Request_Struct));
}
} // ST_abeb699a3b96359819e408d199643162Structure
/// <summary>
/// RecordList type <code>EM_SM_CECO_COSMOZ_RequestList</code> that represents a record list of
///  <code>EM_SM_CECO_COSMOZ_Request</code>
/// </summary>
public partial class RL_dafc3d7968b8a3e720bf011af716980a : GenericRecordList<ST_abeb699a3b96359819e408d199643162Structure>, IEnumerable, IEnumerator {

protected override ST_abeb699a3b96359819e408d199643162Structure GetElementDefaultValue() {
return new ST_abeb699a3b96359819e408d199643162Structure();
}

public T[] ToArray<T>(Func<ST_abeb699a3b96359819e408d199643162Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dafc3d7968b8a3e720bf011af716980a recordList, Func<ST_abeb699a3b96359819e408d199643162Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dafc3d7968b8a3e720bf011af716980a(ST_abeb699a3b96359819e408d199643162Structure[] array) {
  RL_dafc3d7968b8a3e720bf011af716980a result = new RL_dafc3d7968b8a3e720bf011af716980a();
result.InnerFromArray(array);
    return result;
}

public static RL_dafc3d7968b8a3e720bf011af716980a ToList<T>(T[] array, Func <T, ST_abeb699a3b96359819e408d199643162Structure> converter) {
  RL_dafc3d7968b8a3e720bf011af716980a result = new RL_dafc3d7968b8a3e720bf011af716980a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dafc3d7968b8a3e720bf011af716980a FromRestList<T>(RestList<T> restList, Func <T, ST_abeb699a3b96359819e408d199643162Structure> converter) {
  RL_dafc3d7968b8a3e720bf011af716980a result = new RL_dafc3d7968b8a3e720bf011af716980a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dafc3d7968b8a3e720bf011af716980a() : base() {
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
protected override OSList<ST_abeb699a3b96359819e408d199643162Structure> NewList() {
return new RL_dafc3d7968b8a3e720bf011af716980a();
}


} // RL_dafc3d7968b8a3e720bf011af716980a
}

