namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (D_2EhMTVykKumrTwm75AZg)
///  <code>RC_b314153fb124399932b620e84baf5772</code> that represent
/// s <code>EM_SM_MO_COSMOZ_Request_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_MO_COSMOZ_Request_StructRecord
public partial struct RC_b314153fb124399932b620e84baf5772 : ITypedRecord<RC_b314153fb124399932b620e84baf5772> {
internal static readonly GlobalObjectKey IdEM_SM_MO_COSMOZ_Request_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PxUUsySxmTkytiDoS69Xcg");

public ST_e88e810a3be3c7b278de1b477e897388Structure ssSTEM_SM_MO_COSMOZ_Request_Struct;


public static implicit operator ST_e88e810a3be3c7b278de1b477e897388Structure( RC_b314153fb124399932b620e84baf5772 r) {
return r.ssSTEM_SM_MO_COSMOZ_Request_Struct;
}

public static implicit operator RC_b314153fb124399932b620e84baf5772 (ST_e88e810a3be3c7b278de1b477e897388Structure r) {
RC_b314153fb124399932b620e84baf5772 res = new RC_b314153fb124399932b620e84baf5772 ();
res.ssSTEM_SM_MO_COSMOZ_Request_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b314153fb124399932b620e84baf5772() {
OptimizedAttributes = null;
ssSTEM_SM_MO_COSMOZ_Request_Struct = new ST_e88e810a3be3c7b278de1b477e897388Structure();
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
    ssSTEM_SM_MO_COSMOZ_Request_Struct.OptimizedAttributes = value[0];
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
ssSTEM_SM_MO_COSMOZ_Request_Struct.Read( r, ref index);
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
public void ReadIM(RC_b314153fb124399932b620e84baf5772 r) {
this = r;
}


public static bool operator == (RC_b314153fb124399932b620e84baf5772 a, RC_b314153fb124399932b620e84baf5772 b) {
if (a.ssSTEM_SM_MO_COSMOZ_Request_Struct != b.ssSTEM_SM_MO_COSMOZ_Request_Struct) return false;
return true;
}

public static bool operator != (RC_b314153fb124399932b620e84baf5772 a, RC_b314153fb124399932b620e84baf5772 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b314153fb124399932b620e84baf5772)) return false;
return (this == (RC_b314153fb124399932b620e84baf5772)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_MO_COSMOZ_Request_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_MO_COSMOZ_Request_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_MO_COSMOZ_Request_Struct.InternalRecursiveSave();
}


public RC_b314153fb124399932b620e84baf5772 Duplicate() {
RC_b314153fb124399932b620e84baf5772 t;
t.ssSTEM_SM_MO_COSMOZ_Request_Struct = (ST_e88e810a3be3c7b278de1b477e897388Structure)this.ssSTEM_SM_MO_COSMOZ_Request_Struct.Duplicate();
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_MO_COSMOZ_Request_Struct")) variable.Value = ssSTEM_SM_MO_COSMOZ_Request_Struct; else variable.Optimized = true;
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
return ssSTEM_SM_MO_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_MO_COSMOZ_Request_Struct.Key.AsGuid) {
return ssSTEM_SM_MO_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_MO_COSMOZ_Request_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_MO_COSMOZ_Request_Struct));
}
} // RC_b314153fb124399932b620e84baf5772
/// <summary>
/// RecordList type <code>EM_SM_MO_COSMOZ_Request_StructRecordList</code> that represents a record list
///  of <code>EM_SM_MO_COSMOZ_Request_Struct</code>
/// </summary>
public partial class RL_3d6ffbf1c484adf178b9e120a1722616 : GenericRecordList<RC_b314153fb124399932b620e84baf5772>, IEnumerable, IEnumerator {

protected override RC_b314153fb124399932b620e84baf5772 GetElementDefaultValue() {
return new RC_b314153fb124399932b620e84baf5772();
}

public T[] ToArray<T>(Func<RC_b314153fb124399932b620e84baf5772, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3d6ffbf1c484adf178b9e120a1722616 recordList, Func<RC_b314153fb124399932b620e84baf5772, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3d6ffbf1c484adf178b9e120a1722616(RC_b314153fb124399932b620e84baf5772[] array) {
  RL_3d6ffbf1c484adf178b9e120a1722616 result = new RL_3d6ffbf1c484adf178b9e120a1722616();
result.InnerFromArray(array);
    return result;
}

public static RL_3d6ffbf1c484adf178b9e120a1722616 ToList<T>(T[] array, Func <T, RC_b314153fb124399932b620e84baf5772> converter) {
  RL_3d6ffbf1c484adf178b9e120a1722616 result = new RL_3d6ffbf1c484adf178b9e120a1722616();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3d6ffbf1c484adf178b9e120a1722616 FromRestList<T>(RestList<T> restList, Func <T, RC_b314153fb124399932b620e84baf5772> converter) {
  RL_3d6ffbf1c484adf178b9e120a1722616 result = new RL_3d6ffbf1c484adf178b9e120a1722616();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3d6ffbf1c484adf178b9e120a1722616() : base() {
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
protected override OSList<RC_b314153fb124399932b620e84baf5772> NewList() {
return new RL_3d6ffbf1c484adf178b9e120a1722616();
}


} // RL_3d6ffbf1c484adf178b9e120a1722616
}

