namespace ssConectaProveedores {
/// <summary>
/// [Structure] DocumentExtrationFiles (ol1Y7Hat2kCANLvVtauQlQ)
///  <code>ST_27be19a2068bdbf4844f837df703a71bStructure</code> that represent
/// s <code>DocumentExtrationFiles</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationFiles
public partial struct ST_27be19a2068bdbf4844f837df703a71bStructure : ITypedRecord<ST_27be19a2068bdbf4844f837df703a71bStructure> {
internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kZOR2huoWEu8t3UvJ3YvCw");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8uoFOrPTWEuTIJubNKqj9g");
internal static readonly GlobalObjectKey IdSelect = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rU79sCDfkkqTCSQrYv6kFQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*le9FrUfGc0iJmICBKSG1oQ");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*VwroPxlQXkiOQ9MipupqAw");

public string ssFileName;

public long ssStorageId;

public bool ssSelect;

public DateTime ssCreatedOn;

public long ssSize;


public BitArray OptimizedAttributes;

public ST_27be19a2068bdbf4844f837df703a71bStructure() {
OptimizedAttributes = null;
ssFileName = "";
ssStorageId = 0L;
ssSelect = false;
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssFileName = r.ReadText(index++, "DocumentExtrationFiles.FileName", "");
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "DocumentExtrationFiles.StorageId", 0L);
ssSelect = r.ReadBoolean(index++, "DocumentExtrationFiles.Select", false);
ssCreatedOn = r.ReadDate(index++, "DocumentExtrationFiles.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssSize = r.ReadLongInteger(index++, "DocumentExtrationFiles.Size", 0L);
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
public void ReadIM(ST_27be19a2068bdbf4844f837df703a71bStructure r) {
this = r;
}


public static bool operator == (ST_27be19a2068bdbf4844f837df703a71bStructure a, ST_27be19a2068bdbf4844f837df703a71bStructure b) {
if (a.ssFileName != b.ssFileName) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssSelect != b.ssSelect) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssSize != b.ssSize) return false;
return true;
}

public static bool operator != (ST_27be19a2068bdbf4844f837df703a71bStructure a, ST_27be19a2068bdbf4844f837df703a71bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_27be19a2068bdbf4844f837df703a71bStructure)) return false;
return (this == (ST_27be19a2068bdbf4844f837df703a71bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFileName.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssSelect.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
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


public ST_27be19a2068bdbf4844f837df703a71bStructure Duplicate() {
ST_27be19a2068bdbf4844f837df703a71bStructure t;
t.ssFileName = this.ssFileName;
t.ssStorageId = this.ssStorageId;
t.ssSelect = this.ssSelect;
t.ssCreatedOn = this.ssCreatedOn;
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
if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "select") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Select")) variable.Value = ssSelect; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
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
if (key == IdFileName) {
return ssFileName;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdSelect) {
return ssSelect;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdSize) {
return ssSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFileName.Key.AsGuid) {
return ssFileName;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdSelect.Key.AsGuid) {
return ssSelect;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFileName = (string) other.AttributeGet(IdFileName);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssSelect = (bool) other.AttributeGet(IdSelect);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssSize = (long) other.AttributeGet(IdSize);
}
} // ST_27be19a2068bdbf4844f837df703a71bStructure
/// <summary>
/// RecordList type <code>DocumentExtrationFilesList</code> that represents a record list of
///  <code>DocumentExtrationFiles</code>
/// </summary>
public partial class RL_845dd74219b9b2e8e635abcbf851e5ff : GenericRecordList<ST_27be19a2068bdbf4844f837df703a71bStructure>, IEnumerable, IEnumerator {

protected override ST_27be19a2068bdbf4844f837df703a71bStructure GetElementDefaultValue() {
return new ST_27be19a2068bdbf4844f837df703a71bStructure();
}

public T[] ToArray<T>(Func<ST_27be19a2068bdbf4844f837df703a71bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_845dd74219b9b2e8e635abcbf851e5ff recordList, Func<ST_27be19a2068bdbf4844f837df703a71bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_845dd74219b9b2e8e635abcbf851e5ff(ST_27be19a2068bdbf4844f837df703a71bStructure[] array) {
  RL_845dd74219b9b2e8e635abcbf851e5ff result = new RL_845dd74219b9b2e8e635abcbf851e5ff();
result.InnerFromArray(array);
    return result;
}

public static RL_845dd74219b9b2e8e635abcbf851e5ff ToList<T>(T[] array, Func <T, ST_27be19a2068bdbf4844f837df703a71bStructure> converter) {
  RL_845dd74219b9b2e8e635abcbf851e5ff result = new RL_845dd74219b9b2e8e635abcbf851e5ff();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_845dd74219b9b2e8e635abcbf851e5ff FromRestList<T>(RestList<T> restList, Func <T, ST_27be19a2068bdbf4844f837df703a71bStructure> converter) {
  RL_845dd74219b9b2e8e635abcbf851e5ff result = new RL_845dd74219b9b2e8e635abcbf851e5ff();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_845dd74219b9b2e8e635abcbf851e5ff() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_27be19a2068bdbf4844f837df703a71bStructure> NewList() {
return new RL_845dd74219b9b2e8e635abcbf851e5ff();
}


} // RL_845dd74219b9b2e8e635abcbf851e5ff
}

