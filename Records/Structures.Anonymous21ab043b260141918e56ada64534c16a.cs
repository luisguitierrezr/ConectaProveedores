namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (OwSrIQEmkUGOVq2mRTTBag)
///  <code>RC_72174731c5fd0896036e84e89a92eae9</code> that represent
/// s <code>StorageFileStructRecord</code> <p>Description: </p>
/// </summary>
// Name: StorageFileStructRecord
public partial struct RC_72174731c5fd0896036e84e89a92eae9 : ITypedRecord<RC_72174731c5fd0896036e84e89a92eae9> {
internal static readonly GlobalObjectKey IdStorageFileStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MUcXcv3FlggDboTompLq6Q");

public ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure ssSTStorageFileStruct;


public static implicit operator ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure( RC_72174731c5fd0896036e84e89a92eae9 r) {
return r.ssSTStorageFileStruct;
}

public static implicit operator RC_72174731c5fd0896036e84e89a92eae9 (ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure r) {
RC_72174731c5fd0896036e84e89a92eae9 res = new RC_72174731c5fd0896036e84e89a92eae9 ();
res.ssSTStorageFileStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_72174731c5fd0896036e84e89a92eae9() {
OptimizedAttributes = null;
ssSTStorageFileStruct = new ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
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
    ssSTStorageFileStruct.OptimizedAttributes = value[0];
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
ssSTStorageFileStruct.Read( r, ref index);
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
public void ReadIM(RC_72174731c5fd0896036e84e89a92eae9 r) {
this = r;
}


public static bool operator == (RC_72174731c5fd0896036e84e89a92eae9 a, RC_72174731c5fd0896036e84e89a92eae9 b) {
if (a.ssSTStorageFileStruct != b.ssSTStorageFileStruct) return false;
return true;
}

public static bool operator != (RC_72174731c5fd0896036e84e89a92eae9 a, RC_72174731c5fd0896036e84e89a92eae9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_72174731c5fd0896036e84e89a92eae9)) return false;
return (this == (RC_72174731c5fd0896036e84e89a92eae9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStorageFileStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStorageFileStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStorageFileStruct.InternalRecursiveSave();
}


public RC_72174731c5fd0896036e84e89a92eae9 Duplicate() {
RC_72174731c5fd0896036e84e89a92eae9 t;
t.ssSTStorageFileStruct = (ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure)this.ssSTStorageFileStruct.Duplicate();
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
if (head == "storagefilestruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageFileStruct")) variable.Value = ssSTStorageFileStruct; else variable.Optimized = true;
variable.SetFieldName("storagefilestruct");
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
if (key == IdStorageFileStruct) {
return ssSTStorageFileStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStorageFileStruct.Key.AsGuid) {
return ssSTStorageFileStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStorageFileStruct.FillFromOther((IRecord) other.AttributeGet(IdStorageFileStruct));
}
} // RC_72174731c5fd0896036e84e89a92eae9
/// <summary>
/// RecordList type <code>StorageFileStructRecordList</code> that represents a record list of
///  <code>StorageFileStruct</code>
/// </summary>
public partial class RL_ddc25dee3422224dd448d1eeee1b5951 : GenericRecordList<RC_72174731c5fd0896036e84e89a92eae9>, IEnumerable, IEnumerator {

protected override RC_72174731c5fd0896036e84e89a92eae9 GetElementDefaultValue() {
return new RC_72174731c5fd0896036e84e89a92eae9();
}

public T[] ToArray<T>(Func<RC_72174731c5fd0896036e84e89a92eae9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ddc25dee3422224dd448d1eeee1b5951 recordList, Func<RC_72174731c5fd0896036e84e89a92eae9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ddc25dee3422224dd448d1eeee1b5951(RC_72174731c5fd0896036e84e89a92eae9[] array) {
  RL_ddc25dee3422224dd448d1eeee1b5951 result = new RL_ddc25dee3422224dd448d1eeee1b5951();
result.InnerFromArray(array);
    return result;
}

public static RL_ddc25dee3422224dd448d1eeee1b5951 ToList<T>(T[] array, Func <T, RC_72174731c5fd0896036e84e89a92eae9> converter) {
  RL_ddc25dee3422224dd448d1eeee1b5951 result = new RL_ddc25dee3422224dd448d1eeee1b5951();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ddc25dee3422224dd448d1eeee1b5951 FromRestList<T>(RestList<T> restList, Func <T, RC_72174731c5fd0896036e84e89a92eae9> converter) {
  RL_ddc25dee3422224dd448d1eeee1b5951 result = new RL_ddc25dee3422224dd448d1eeee1b5951();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ddc25dee3422224dd448d1eeee1b5951() : base() {
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
protected override OSList<RC_72174731c5fd0896036e84e89a92eae9> NewList() {
return new RL_ddc25dee3422224dd448d1eeee1b5951();
}


} // RL_ddc25dee3422224dd448d1eeee1b5951
}

