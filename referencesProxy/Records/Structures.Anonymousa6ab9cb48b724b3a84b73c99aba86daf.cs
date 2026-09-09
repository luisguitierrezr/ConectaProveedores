namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (tJyrpnKLOkuEtzyZq6htrw)
///  <code>RC_90eaabd400e22207e9526f366c8c042d</code> that represent
/// s <code>EM_SM_CECO_COSMOZ_RequestRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_CECO_COSMOZ_RequestRecord
public partial struct RC_90eaabd400e22207e9526f366c8c042d : ITypedRecord<RC_90eaabd400e22207e9526f366c8c042d> {
internal static readonly GlobalObjectKey IdEM_SM_CECO_COSMOZ_Request = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1KvqkOIAByLpUm82bIwELQ");

public ST_abeb699a3b96359819e408d199643162Structure ssSTEM_SM_CECO_COSMOZ_Request;


public static implicit operator ST_abeb699a3b96359819e408d199643162Structure( RC_90eaabd400e22207e9526f366c8c042d r) {
return r.ssSTEM_SM_CECO_COSMOZ_Request;
}

public static implicit operator RC_90eaabd400e22207e9526f366c8c042d (ST_abeb699a3b96359819e408d199643162Structure r) {
RC_90eaabd400e22207e9526f366c8c042d res = new RC_90eaabd400e22207e9526f366c8c042d ();
res.ssSTEM_SM_CECO_COSMOZ_Request = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_90eaabd400e22207e9526f366c8c042d() {
OptimizedAttributes = null;
ssSTEM_SM_CECO_COSMOZ_Request = new ST_abeb699a3b96359819e408d199643162Structure();
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
    ssSTEM_SM_CECO_COSMOZ_Request.OptimizedAttributes = value[0];
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
ssSTEM_SM_CECO_COSMOZ_Request.Read( r, ref index);
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
public void ReadIM(RC_90eaabd400e22207e9526f366c8c042d r) {
this = r;
}


public static bool operator == (RC_90eaabd400e22207e9526f366c8c042d a, RC_90eaabd400e22207e9526f366c8c042d b) {
if (a.ssSTEM_SM_CECO_COSMOZ_Request != b.ssSTEM_SM_CECO_COSMOZ_Request) return false;
return true;
}

public static bool operator != (RC_90eaabd400e22207e9526f366c8c042d a, RC_90eaabd400e22207e9526f366c8c042d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_90eaabd400e22207e9526f366c8c042d)) return false;
return (this == (RC_90eaabd400e22207e9526f366c8c042d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_CECO_COSMOZ_Request.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_CECO_COSMOZ_Request.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_CECO_COSMOZ_Request.InternalRecursiveSave();
}


public RC_90eaabd400e22207e9526f366c8c042d Duplicate() {
RC_90eaabd400e22207e9526f366c8c042d t;
t.ssSTEM_SM_CECO_COSMOZ_Request = (ST_abeb699a3b96359819e408d199643162Structure)this.ssSTEM_SM_CECO_COSMOZ_Request.Duplicate();
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
if (head == "em_sm_ceco_cosmoz_request") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_CECO_COSMOZ_Request")) variable.Value = ssSTEM_SM_CECO_COSMOZ_Request; else variable.Optimized = true;
variable.SetFieldName("em_sm_ceco_cosmoz_request");
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
if (key == IdEM_SM_CECO_COSMOZ_Request) {
return ssSTEM_SM_CECO_COSMOZ_Request;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_CECO_COSMOZ_Request.Key.AsGuid) {
return ssSTEM_SM_CECO_COSMOZ_Request;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_CECO_COSMOZ_Request.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_CECO_COSMOZ_Request));
}
} // RC_90eaabd400e22207e9526f366c8c042d
/// <summary>
/// RecordList type <code>EM_SM_CECO_COSMOZ_RequestRecordList</code> that represents a record list of
///  <code>EM_SM_CECO_COSMOZ_Request</code>
/// </summary>
public partial class RL_922bd018d5f6e49a2ab7f3959fc8f9ff : GenericRecordList<RC_90eaabd400e22207e9526f366c8c042d>, IEnumerable, IEnumerator {

protected override RC_90eaabd400e22207e9526f366c8c042d GetElementDefaultValue() {
return new RC_90eaabd400e22207e9526f366c8c042d();
}

public T[] ToArray<T>(Func<RC_90eaabd400e22207e9526f366c8c042d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_922bd018d5f6e49a2ab7f3959fc8f9ff recordList, Func<RC_90eaabd400e22207e9526f366c8c042d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_922bd018d5f6e49a2ab7f3959fc8f9ff(RC_90eaabd400e22207e9526f366c8c042d[] array) {
  RL_922bd018d5f6e49a2ab7f3959fc8f9ff result = new RL_922bd018d5f6e49a2ab7f3959fc8f9ff();
result.InnerFromArray(array);
    return result;
}

public static RL_922bd018d5f6e49a2ab7f3959fc8f9ff ToList<T>(T[] array, Func <T, RC_90eaabd400e22207e9526f366c8c042d> converter) {
  RL_922bd018d5f6e49a2ab7f3959fc8f9ff result = new RL_922bd018d5f6e49a2ab7f3959fc8f9ff();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_922bd018d5f6e49a2ab7f3959fc8f9ff FromRestList<T>(RestList<T> restList, Func <T, RC_90eaabd400e22207e9526f366c8c042d> converter) {
  RL_922bd018d5f6e49a2ab7f3959fc8f9ff result = new RL_922bd018d5f6e49a2ab7f3959fc8f9ff();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_922bd018d5f6e49a2ab7f3959fc8f9ff() : base() {
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
protected override OSList<RC_90eaabd400e22207e9526f366c8c042d> NewList() {
return new RL_922bd018d5f6e49a2ab7f3959fc8f9ff();
}


} // RL_922bd018d5f6e49a2ab7f3959fc8f9ff
}

