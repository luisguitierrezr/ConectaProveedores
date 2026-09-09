namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (J3JgAan3GU2UxsvQ315QtQ)
///  <code>RC_6d589cc6382d191584ced81e067dc8ba</code> that represents <code>StorageIdRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: StorageIdRecord
public partial struct RC_6d589cc6382d191584ced81e067dc8ba : ITypedRecord<RC_6d589cc6382d191584ced81e067dc8ba> {
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xpxYbS04FRmEztgeBn3Iug");

public long ssStorageId;


public BitArray OptimizedAttributes;

public RC_6d589cc6382d191584ced81e067dc8ba() {
OptimizedAttributes = null;
ssStorageId = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "StorageIdRecord.StorageId", 0L);
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
public void ReadIM(RC_6d589cc6382d191584ced81e067dc8ba r) {
this = r;
}


public static bool operator == (RC_6d589cc6382d191584ced81e067dc8ba a, RC_6d589cc6382d191584ced81e067dc8ba b) {
if (a.ssStorageId != b.ssStorageId) return false;
return true;
}

public static bool operator != (RC_6d589cc6382d191584ced81e067dc8ba a, RC_6d589cc6382d191584ced81e067dc8ba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6d589cc6382d191584ced81e067dc8ba)) return false;
return (this == (RC_6d589cc6382d191584ced81e067dc8ba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssStorageId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_6d589cc6382d191584ced81e067dc8ba Duplicate() {
RC_6d589cc6382d191584ced81e067dc8ba t;
t.ssStorageId = this.ssStorageId;
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
if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
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
if (key == IdStorageId) {
return ssStorageId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssStorageId = (long) other.AttributeGet(IdStorageId);
}
} // RC_6d589cc6382d191584ced81e067dc8ba
/// <summary>
/// RecordList type <code>StorageIdRecordList</code> that represents a record list of
///  <code>StorageIdentifier</code>
/// </summary>
public partial class RL_0822a9314a3d52420dc7ca5047ccbaee : GenericRecordList<RC_6d589cc6382d191584ced81e067dc8ba>, IEnumerable, IEnumerator {

protected override RC_6d589cc6382d191584ced81e067dc8ba GetElementDefaultValue() {
return new RC_6d589cc6382d191584ced81e067dc8ba();
}

public T[] ToArray<T>(Func<RC_6d589cc6382d191584ced81e067dc8ba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0822a9314a3d52420dc7ca5047ccbaee recordList, Func<RC_6d589cc6382d191584ced81e067dc8ba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0822a9314a3d52420dc7ca5047ccbaee(RC_6d589cc6382d191584ced81e067dc8ba[] array) {
  RL_0822a9314a3d52420dc7ca5047ccbaee result = new RL_0822a9314a3d52420dc7ca5047ccbaee();
result.InnerFromArray(array);
    return result;
}

public static RL_0822a9314a3d52420dc7ca5047ccbaee ToList<T>(T[] array, Func <T, RC_6d589cc6382d191584ced81e067dc8ba> converter) {
  RL_0822a9314a3d52420dc7ca5047ccbaee result = new RL_0822a9314a3d52420dc7ca5047ccbaee();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0822a9314a3d52420dc7ca5047ccbaee FromRestList<T>(RestList<T> restList, Func <T, RC_6d589cc6382d191584ced81e067dc8ba> converter) {
  RL_0822a9314a3d52420dc7ca5047ccbaee result = new RL_0822a9314a3d52420dc7ca5047ccbaee();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0822a9314a3d52420dc7ca5047ccbaee() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6d589cc6382d191584ced81e067dc8ba> NewList() {
return new RL_0822a9314a3d52420dc7ca5047ccbaee();
}


} // RL_0822a9314a3d52420dc7ca5047ccbaee
}

