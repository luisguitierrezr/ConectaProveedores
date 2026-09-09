namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (O7lF_2_0Y02pl2MHovdYOQ)
///  <code>RC_caf61a1959588019d4022d8eec32ba1c</code> that represent
/// s <code>EM_SM_MO_COSMOZ_RequestRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_MO_COSMOZ_RequestRecord
public partial struct RC_caf61a1959588019d4022d8eec32ba1c : ITypedRecord<RC_caf61a1959588019d4022d8eec32ba1c> {
internal static readonly GlobalObjectKey IdEM_SM_MO_COSMOZ_Request = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GRr2ylhZGYDUAi2O7DK6HA");

public ST_f61ad0d448ed247a1bde22a5051a7d04Structure ssSTEM_SM_MO_COSMOZ_Request;


public static implicit operator ST_f61ad0d448ed247a1bde22a5051a7d04Structure( RC_caf61a1959588019d4022d8eec32ba1c r) {
return r.ssSTEM_SM_MO_COSMOZ_Request;
}

public static implicit operator RC_caf61a1959588019d4022d8eec32ba1c (ST_f61ad0d448ed247a1bde22a5051a7d04Structure r) {
RC_caf61a1959588019d4022d8eec32ba1c res = new RC_caf61a1959588019d4022d8eec32ba1c ();
res.ssSTEM_SM_MO_COSMOZ_Request = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_caf61a1959588019d4022d8eec32ba1c() {
OptimizedAttributes = null;
ssSTEM_SM_MO_COSMOZ_Request = new ST_f61ad0d448ed247a1bde22a5051a7d04Structure();
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
    ssSTEM_SM_MO_COSMOZ_Request.OptimizedAttributes = value[0];
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
ssSTEM_SM_MO_COSMOZ_Request.Read( r, ref index);
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
public void ReadIM(RC_caf61a1959588019d4022d8eec32ba1c r) {
this = r;
}


public static bool operator == (RC_caf61a1959588019d4022d8eec32ba1c a, RC_caf61a1959588019d4022d8eec32ba1c b) {
if (a.ssSTEM_SM_MO_COSMOZ_Request != b.ssSTEM_SM_MO_COSMOZ_Request) return false;
return true;
}

public static bool operator != (RC_caf61a1959588019d4022d8eec32ba1c a, RC_caf61a1959588019d4022d8eec32ba1c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_caf61a1959588019d4022d8eec32ba1c)) return false;
return (this == (RC_caf61a1959588019d4022d8eec32ba1c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_MO_COSMOZ_Request.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_MO_COSMOZ_Request.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_MO_COSMOZ_Request.InternalRecursiveSave();
}


public RC_caf61a1959588019d4022d8eec32ba1c Duplicate() {
RC_caf61a1959588019d4022d8eec32ba1c t;
t.ssSTEM_SM_MO_COSMOZ_Request = (ST_f61ad0d448ed247a1bde22a5051a7d04Structure)this.ssSTEM_SM_MO_COSMOZ_Request.Duplicate();
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
if (head == "em_sm_mo_cosmoz_request") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_MO_COSMOZ_Request")) variable.Value = ssSTEM_SM_MO_COSMOZ_Request; else variable.Optimized = true;
variable.SetFieldName("em_sm_mo_cosmoz_request");
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
if (key == IdEM_SM_MO_COSMOZ_Request) {
return ssSTEM_SM_MO_COSMOZ_Request;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_MO_COSMOZ_Request.Key.AsGuid) {
return ssSTEM_SM_MO_COSMOZ_Request;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_MO_COSMOZ_Request.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_MO_COSMOZ_Request));
}
} // RC_caf61a1959588019d4022d8eec32ba1c
/// <summary>
/// RecordList type <code>EM_SM_MO_COSMOZ_RequestRecordList</code> that represents a record list of
///  <code>EM_SM_MO_COSMOZ_Request</code>
/// </summary>
public partial class RL_7b78afa55dc12312204943e05bc3cd3e : GenericRecordList<RC_caf61a1959588019d4022d8eec32ba1c>, IEnumerable, IEnumerator {

protected override RC_caf61a1959588019d4022d8eec32ba1c GetElementDefaultValue() {
return new RC_caf61a1959588019d4022d8eec32ba1c();
}

public T[] ToArray<T>(Func<RC_caf61a1959588019d4022d8eec32ba1c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7b78afa55dc12312204943e05bc3cd3e recordList, Func<RC_caf61a1959588019d4022d8eec32ba1c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7b78afa55dc12312204943e05bc3cd3e(RC_caf61a1959588019d4022d8eec32ba1c[] array) {
  RL_7b78afa55dc12312204943e05bc3cd3e result = new RL_7b78afa55dc12312204943e05bc3cd3e();
result.InnerFromArray(array);
    return result;
}

public static RL_7b78afa55dc12312204943e05bc3cd3e ToList<T>(T[] array, Func <T, RC_caf61a1959588019d4022d8eec32ba1c> converter) {
  RL_7b78afa55dc12312204943e05bc3cd3e result = new RL_7b78afa55dc12312204943e05bc3cd3e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7b78afa55dc12312204943e05bc3cd3e FromRestList<T>(RestList<T> restList, Func <T, RC_caf61a1959588019d4022d8eec32ba1c> converter) {
  RL_7b78afa55dc12312204943e05bc3cd3e result = new RL_7b78afa55dc12312204943e05bc3cd3e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7b78afa55dc12312204943e05bc3cd3e() : base() {
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
protected override OSList<RC_caf61a1959588019d4022d8eec32ba1c> NewList() {
return new RL_7b78afa55dc12312204943e05bc3cd3e();
}


} // RL_7b78afa55dc12312204943e05bc3cd3e
}

