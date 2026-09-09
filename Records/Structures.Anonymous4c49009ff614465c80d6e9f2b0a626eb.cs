namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nwBJTBT2XEaA1unysKYm6w)
///  <code>RC_12cddf42302e28dc02ca66ca24756e12</code> that represent
/// s <code>RecordCreatedUpdatedLogStructRecord</code> <p>Description: </p>
/// </summary>
// Name: RecordCreatedUpdatedLogStructRecord
public partial struct RC_12cddf42302e28dc02ca66ca24756e12 : ITypedRecord<RC_12cddf42302e28dc02ca66ca24756e12> {
internal static readonly GlobalObjectKey IdRecordCreatedUpdatedLogStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Qt_NEi4w3CgCymbKJHVuEg");

public ST_26711e61541f079fb4510d8f9bfa1e3dStructure ssSTRecordCreatedUpdatedLogStruct;


public static implicit operator ST_26711e61541f079fb4510d8f9bfa1e3dStructure( RC_12cddf42302e28dc02ca66ca24756e12 r) {
return r.ssSTRecordCreatedUpdatedLogStruct;
}

public static implicit operator RC_12cddf42302e28dc02ca66ca24756e12 (ST_26711e61541f079fb4510d8f9bfa1e3dStructure r) {
RC_12cddf42302e28dc02ca66ca24756e12 res = new RC_12cddf42302e28dc02ca66ca24756e12 ();
res.ssSTRecordCreatedUpdatedLogStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_12cddf42302e28dc02ca66ca24756e12() {
OptimizedAttributes = null;
ssSTRecordCreatedUpdatedLogStruct = new ST_26711e61541f079fb4510d8f9bfa1e3dStructure();
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
    ssSTRecordCreatedUpdatedLogStruct.OptimizedAttributes = value[0];
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
ssSTRecordCreatedUpdatedLogStruct.Read( r, ref index);
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
public void ReadIM(RC_12cddf42302e28dc02ca66ca24756e12 r) {
this = r;
}


public static bool operator == (RC_12cddf42302e28dc02ca66ca24756e12 a, RC_12cddf42302e28dc02ca66ca24756e12 b) {
if (a.ssSTRecordCreatedUpdatedLogStruct != b.ssSTRecordCreatedUpdatedLogStruct) return false;
return true;
}

public static bool operator != (RC_12cddf42302e28dc02ca66ca24756e12 a, RC_12cddf42302e28dc02ca66ca24756e12 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_12cddf42302e28dc02ca66ca24756e12)) return false;
return (this == (RC_12cddf42302e28dc02ca66ca24756e12)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRecordCreatedUpdatedLogStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRecordCreatedUpdatedLogStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRecordCreatedUpdatedLogStruct.InternalRecursiveSave();
}


public RC_12cddf42302e28dc02ca66ca24756e12 Duplicate() {
RC_12cddf42302e28dc02ca66ca24756e12 t;
t.ssSTRecordCreatedUpdatedLogStruct = (ST_26711e61541f079fb4510d8f9bfa1e3dStructure)this.ssSTRecordCreatedUpdatedLogStruct.Duplicate();
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
if (head == "recordcreatedupdatedlogstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RecordCreatedUpdatedLogStruct")) variable.Value = ssSTRecordCreatedUpdatedLogStruct; else variable.Optimized = true;
variable.SetFieldName("recordcreatedupdatedlogstruct");
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
if (key == IdRecordCreatedUpdatedLogStruct) {
return ssSTRecordCreatedUpdatedLogStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRecordCreatedUpdatedLogStruct.Key.AsGuid) {
return ssSTRecordCreatedUpdatedLogStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRecordCreatedUpdatedLogStruct.FillFromOther((IRecord) other.AttributeGet(IdRecordCreatedUpdatedLogStruct));
}
} // RC_12cddf42302e28dc02ca66ca24756e12
/// <summary>
/// RecordList type <code>RecordCreatedUpdatedLogStructRecordList</code> that represents a record list
///  of <code>RecordCreatedUpdatedLogStruct</code>
/// </summary>
public partial class RL_b5fb6d95a680a5f06884f683d30852ba : GenericRecordList<RC_12cddf42302e28dc02ca66ca24756e12>, IEnumerable, IEnumerator {

protected override RC_12cddf42302e28dc02ca66ca24756e12 GetElementDefaultValue() {
return new RC_12cddf42302e28dc02ca66ca24756e12();
}

public T[] ToArray<T>(Func<RC_12cddf42302e28dc02ca66ca24756e12, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b5fb6d95a680a5f06884f683d30852ba recordList, Func<RC_12cddf42302e28dc02ca66ca24756e12, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b5fb6d95a680a5f06884f683d30852ba(RC_12cddf42302e28dc02ca66ca24756e12[] array) {
  RL_b5fb6d95a680a5f06884f683d30852ba result = new RL_b5fb6d95a680a5f06884f683d30852ba();
result.InnerFromArray(array);
    return result;
}

public static RL_b5fb6d95a680a5f06884f683d30852ba ToList<T>(T[] array, Func <T, RC_12cddf42302e28dc02ca66ca24756e12> converter) {
  RL_b5fb6d95a680a5f06884f683d30852ba result = new RL_b5fb6d95a680a5f06884f683d30852ba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b5fb6d95a680a5f06884f683d30852ba FromRestList<T>(RestList<T> restList, Func <T, RC_12cddf42302e28dc02ca66ca24756e12> converter) {
  RL_b5fb6d95a680a5f06884f683d30852ba result = new RL_b5fb6d95a680a5f06884f683d30852ba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b5fb6d95a680a5f06884f683d30852ba() : base() {
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
protected override OSList<RC_12cddf42302e28dc02ca66ca24756e12> NewList() {
return new RL_b5fb6d95a680a5f06884f683d30852ba();
}


} // RL_b5fb6d95a680a5f06884f683d30852ba
}

