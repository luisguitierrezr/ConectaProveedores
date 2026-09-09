namespace ssConectaProveedores {
/// <summary>
/// [Structure] StorageFileStruct (4baHZcVcjUKnzT77DdkI9g)
///  <code>ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure</code> that represent
/// s <code>StorageFileStruct</code> <p>Description: </p>
/// </summary>
// Name: StorageFileStruct
public partial struct ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure : ITypedRecord<ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> {
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*REVJLLb3iEW5jbQWh0PODg");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TCKZRmjP2kCYrpq3+6SPXQ");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*h_JfA6AUtU+5VXAbGzg_Hg");

public long ssStorageId;

public string ssFilename;

public long ssSize;


public BitArray OptimizedAttributes;

public ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure() {
OptimizedAttributes = null;
ssStorageId = 0L;
ssFilename = "";
ssSize = 0L;
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
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "StorageFileStruct.StorageId", 0L);
ssFilename = r.ReadText(index++, "StorageFileStruct.Filename", "");
ssSize = r.ReadLongInteger(index++, "StorageFileStruct.Size", 0L);
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
public void ReadIM(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure r) {
this = r;
}


public static bool operator == (ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure a, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure b) {
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssSize != b.ssSize) return false;
return true;
}

public static bool operator != (ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure a, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure)) return false;
return (this == (ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure Duplicate() {
ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure t;
t.ssStorageId = this.ssStorageId;
t.ssFilename = this.ssFilename;
t.ssSize = this.ssSize;
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
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
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
if (key == IdFilename) {
return ssFilename;
}
if (key == IdSize) {
return ssSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssFilename = (string) other.AttributeGet(IdFilename);
ssSize = (long) other.AttributeGet(IdSize);
}
} // ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure
/// <summary>
/// RecordList type <code>StorageFileStructList</code> that represents a record list of
///  <code>StorageFileStruct</code>
/// </summary>
public partial class RL_b48e8aa5377b7b15faec0f07ad9facf2 : GenericRecordList<ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure>, IEnumerable, IEnumerator {

protected override ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure GetElementDefaultValue() {
return new ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure();
}

public T[] ToArray<T>(Func<ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b48e8aa5377b7b15faec0f07ad9facf2 recordList, Func<ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b48e8aa5377b7b15faec0f07ad9facf2(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure[] array) {
  RL_b48e8aa5377b7b15faec0f07ad9facf2 result = new RL_b48e8aa5377b7b15faec0f07ad9facf2();
result.InnerFromArray(array);
    return result;
}

public static RL_b48e8aa5377b7b15faec0f07ad9facf2 ToList<T>(T[] array, Func <T, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> converter) {
  RL_b48e8aa5377b7b15faec0f07ad9facf2 result = new RL_b48e8aa5377b7b15faec0f07ad9facf2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b48e8aa5377b7b15faec0f07ad9facf2 FromRestList<T>(RestList<T> restList, Func <T, ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> converter) {
  RL_b48e8aa5377b7b15faec0f07ad9facf2 result = new RL_b48e8aa5377b7b15faec0f07ad9facf2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b48e8aa5377b7b15faec0f07ad9facf2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure> NewList() {
return new RL_b48e8aa5377b7b15faec0f07ad9facf2();
}


} // RL_b48e8aa5377b7b15faec0f07ad9facf2
}

