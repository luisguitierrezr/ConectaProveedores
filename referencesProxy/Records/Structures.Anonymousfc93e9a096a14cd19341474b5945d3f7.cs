namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (oOmT_KGW0UyTQUdLWUXT9w)
///  <code>RC_3bbaaca91096ad8efe700794daaa8285</code> that represent
/// s <code>EM_COSMOZ_Response_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_COSMOZ_Response_StructRecord
public partial struct RC_3bbaaca91096ad8efe700794daaa8285 : ITypedRecord<RC_3bbaaca91096ad8efe700794daaa8285> {
internal static readonly GlobalObjectKey IdEM_COSMOZ_Response_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qay6O5YQjq3+cAeU2qqChQ");

public ST_5bf89f3eec4235b40802e9da4fd3e4afStructure ssSTEM_COSMOZ_Response_Struct;


public static implicit operator ST_5bf89f3eec4235b40802e9da4fd3e4afStructure( RC_3bbaaca91096ad8efe700794daaa8285 r) {
return r.ssSTEM_COSMOZ_Response_Struct;
}

public static implicit operator RC_3bbaaca91096ad8efe700794daaa8285 (ST_5bf89f3eec4235b40802e9da4fd3e4afStructure r) {
RC_3bbaaca91096ad8efe700794daaa8285 res = new RC_3bbaaca91096ad8efe700794daaa8285 ();
res.ssSTEM_COSMOZ_Response_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_3bbaaca91096ad8efe700794daaa8285() {
OptimizedAttributes = null;
ssSTEM_COSMOZ_Response_Struct = new ST_5bf89f3eec4235b40802e9da4fd3e4afStructure();
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
    ssSTEM_COSMOZ_Response_Struct.OptimizedAttributes = value[0];
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
ssSTEM_COSMOZ_Response_Struct.Read( r, ref index);
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
public void ReadIM(RC_3bbaaca91096ad8efe700794daaa8285 r) {
this = r;
}


public static bool operator == (RC_3bbaaca91096ad8efe700794daaa8285 a, RC_3bbaaca91096ad8efe700794daaa8285 b) {
if (a.ssSTEM_COSMOZ_Response_Struct != b.ssSTEM_COSMOZ_Response_Struct) return false;
return true;
}

public static bool operator != (RC_3bbaaca91096ad8efe700794daaa8285 a, RC_3bbaaca91096ad8efe700794daaa8285 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3bbaaca91096ad8efe700794daaa8285)) return false;
return (this == (RC_3bbaaca91096ad8efe700794daaa8285)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_COSMOZ_Response_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_COSMOZ_Response_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_COSMOZ_Response_Struct.InternalRecursiveSave();
}


public RC_3bbaaca91096ad8efe700794daaa8285 Duplicate() {
RC_3bbaaca91096ad8efe700794daaa8285 t;
t.ssSTEM_COSMOZ_Response_Struct = (ST_5bf89f3eec4235b40802e9da4fd3e4afStructure)this.ssSTEM_COSMOZ_Response_Struct.Duplicate();
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
if (head == "em_cosmoz_response_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_COSMOZ_Response_Struct")) variable.Value = ssSTEM_COSMOZ_Response_Struct; else variable.Optimized = true;
variable.SetFieldName("em_cosmoz_response_struct");
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
if (key == IdEM_COSMOZ_Response_Struct) {
return ssSTEM_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_COSMOZ_Response_Struct.Key.AsGuid) {
return ssSTEM_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_COSMOZ_Response_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_COSMOZ_Response_Struct));
}
} // RC_3bbaaca91096ad8efe700794daaa8285
/// <summary>
/// RecordList type <code>EM_COSMOZ_Response_StructRecordList</code> that represents a record list of
///  <code>EM_COSMOZ_Response_Struct</code>
/// </summary>
public partial class RL_0a1990ad4e8dad19aa3481d2377e5b53 : GenericRecordList<RC_3bbaaca91096ad8efe700794daaa8285>, IEnumerable, IEnumerator {

protected override RC_3bbaaca91096ad8efe700794daaa8285 GetElementDefaultValue() {
return new RC_3bbaaca91096ad8efe700794daaa8285();
}

public T[] ToArray<T>(Func<RC_3bbaaca91096ad8efe700794daaa8285, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0a1990ad4e8dad19aa3481d2377e5b53 recordList, Func<RC_3bbaaca91096ad8efe700794daaa8285, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0a1990ad4e8dad19aa3481d2377e5b53(RC_3bbaaca91096ad8efe700794daaa8285[] array) {
  RL_0a1990ad4e8dad19aa3481d2377e5b53 result = new RL_0a1990ad4e8dad19aa3481d2377e5b53();
result.InnerFromArray(array);
    return result;
}

public static RL_0a1990ad4e8dad19aa3481d2377e5b53 ToList<T>(T[] array, Func <T, RC_3bbaaca91096ad8efe700794daaa8285> converter) {
  RL_0a1990ad4e8dad19aa3481d2377e5b53 result = new RL_0a1990ad4e8dad19aa3481d2377e5b53();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0a1990ad4e8dad19aa3481d2377e5b53 FromRestList<T>(RestList<T> restList, Func <T, RC_3bbaaca91096ad8efe700794daaa8285> converter) {
  RL_0a1990ad4e8dad19aa3481d2377e5b53 result = new RL_0a1990ad4e8dad19aa3481d2377e5b53();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0a1990ad4e8dad19aa3481d2377e5b53() : base() {
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
protected override OSList<RC_3bbaaca91096ad8efe700794daaa8285> NewList() {
return new RL_0a1990ad4e8dad19aa3481d2377e5b53();
}


} // RL_0a1990ad4e8dad19aa3481d2377e5b53
}

