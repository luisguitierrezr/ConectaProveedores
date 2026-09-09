namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioFile (fXJumRYDDkOePK75rs1vfw)
///  <code>ST_a23a10e9592e51ca9ffbbbc42c558496Structure</code> that represents <code>FolioFile</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioFile
public partial struct ST_a23a10e9592e51ca9ffbbbc42c558496Structure : ITypedRecord<ST_a23a10e9592e51ca9ffbbbc42c558496Structure> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*izzDq22q+EuDQM84PH2w4A");
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gEt6IxByF0q6ZWnO54gt2g");
internal static readonly GlobalObjectKey IdFolioId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QmXST92dZ0mqesS4CKkhnA");
internal static readonly GlobalObjectKey IdIsExtra = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*I9FdcEaAxUSMUrBTAByecw");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*A5Ip_SHMZEqcoo9qLyjYyg");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*x46M+jSdc0a3aJGX7MifeA");
internal static readonly GlobalObjectKey IdCreatedByName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*T2QDToCPrU2B1IKG12CrdQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hYNNOL4RJEiiZ38J7kKtLw");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*I002KmUHv02XlOKyqs5vqg");
internal static readonly GlobalObjectKey IdIsNewFile = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*p6uIhzKR3k+HboYK6bLiTg");

public long ssId;

public string ssFilename;

public long ssFolioId;

public bool ssIsExtra;

public long ssStorageId;

public string ssCreatedBy;

public string ssCreatedByName;

public DateTime ssCreatedOn;

public long ssSize;

public bool ssIsNewFile;


public BitArray OptimizedAttributes;

public ST_a23a10e9592e51ca9ffbbbc42c558496Structure() {
OptimizedAttributes = null;
ssId = 0L;
ssFilename = "";
ssFolioId = 0L;
ssIsExtra = false;
ssStorageId = 0L;
ssCreatedBy = "";
ssCreatedByName = "";
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssSize = 0L;
ssIsNewFile = false;
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
ssId = r.ReadLongInteger(index++, "FolioFile.Id", 0L);
ssFilename = r.ReadText(index++, "FolioFile.Filename", "");
ssFolioId = r.ReadEntityReferenceLongInteger(index++, "FolioFile.FolioId", 0L);
ssIsExtra = r.ReadBoolean(index++, "FolioFile.IsExtra", false);
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "FolioFile.StorageId", 0L);
ssCreatedBy = r.ReadEntityReferenceText(index++, "FolioFile.CreatedBy", "");
ssCreatedByName = r.ReadText(index++, "FolioFile.CreatedByName", "");
ssCreatedOn = r.ReadDateTime(index++, "FolioFile.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssSize = r.ReadLongInteger(index++, "FolioFile.Size", 0L);
ssIsNewFile = r.ReadBoolean(index++, "FolioFile.IsNewFile", false);
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
public void ReadIM(ST_a23a10e9592e51ca9ffbbbc42c558496Structure r) {
this = r;
}


public static bool operator == (ST_a23a10e9592e51ca9ffbbbc42c558496Structure a, ST_a23a10e9592e51ca9ffbbbc42c558496Structure b) {
if (a.ssId != b.ssId) return false;
if (a.ssFilename != b.ssFilename) return false;
if (a.ssFolioId != b.ssFolioId) return false;
if (a.ssIsExtra != b.ssIsExtra) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedByName != b.ssCreatedByName) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssSize != b.ssSize) return false;
if (a.ssIsNewFile != b.ssIsNewFile) return false;
return true;
}

public static bool operator != (ST_a23a10e9592e51ca9ffbbbc42c558496Structure a, ST_a23a10e9592e51ca9ffbbbc42c558496Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_a23a10e9592e51ca9ffbbbc42c558496Structure)) return false;
return (this == (ST_a23a10e9592e51ca9ffbbbc42c558496Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssFolioId.GetHashCode()
 ^ ssIsExtra.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedByName.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssSize.GetHashCode()
 ^ ssIsNewFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_a23a10e9592e51ca9ffbbbc42c558496Structure Duplicate() {
ST_a23a10e9592e51ca9ffbbbc42c558496Structure t;
t.ssId = this.ssId;
t.ssFilename = this.ssFilename;
t.ssFolioId = this.ssFolioId;
t.ssIsExtra = this.ssIsExtra;
t.ssStorageId = this.ssStorageId;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedByName = this.ssCreatedByName;
t.ssCreatedOn = this.ssCreatedOn;
t.ssSize = this.ssSize;
t.ssIsNewFile = this.ssIsNewFile;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "folioid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioId")) variable.Value = ssFolioId; else variable.Optimized = true;
} else if (head == "isextra") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsExtra")) variable.Value = ssIsExtra; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdbyname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedByName")) variable.Value = ssCreatedByName; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
} else if (head == "isnewfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsNewFile")) variable.Value = ssIsNewFile; else variable.Optimized = true;
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
if (key == IdId) {
return ssId;
}
if (key == IdFilename) {
return ssFilename;
}
if (key == IdFolioId) {
return ssFolioId;
}
if (key == IdIsExtra) {
return ssIsExtra;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedByName) {
return ssCreatedByName;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdSize) {
return ssSize;
}
if (key == IdIsNewFile) {
return ssIsNewFile;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdFolioId.Key.AsGuid) {
return ssFolioId;
}
if (attributeKey == IdIsExtra.Key.AsGuid) {
return ssIsExtra;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedByName.Key.AsGuid) {
return ssCreatedByName;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
if (attributeKey == IdIsNewFile.Key.AsGuid) {
return ssIsNewFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ssFilename = (string) other.AttributeGet(IdFilename);
ssFolioId = (long) other.AttributeGet(IdFolioId);
ssIsExtra = (bool) other.AttributeGet(IdIsExtra);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedByName = (string) other.AttributeGet(IdCreatedByName);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssSize = (long) other.AttributeGet(IdSize);
ssIsNewFile = (bool) other.AttributeGet(IdIsNewFile);
}
} // ST_a23a10e9592e51ca9ffbbbc42c558496Structure
/// <summary>
/// RecordList type <code>FolioFileList</code> that represents a record list of <code>FolioFile</code>
/// </summary>
public partial class RL_89dfc296578aaa53d7fbc0b8af34fb54 : GenericRecordList<ST_a23a10e9592e51ca9ffbbbc42c558496Structure>, IEnumerable, IEnumerator {

protected override ST_a23a10e9592e51ca9ffbbbc42c558496Structure GetElementDefaultValue() {
return new ST_a23a10e9592e51ca9ffbbbc42c558496Structure();
}

public T[] ToArray<T>(Func<ST_a23a10e9592e51ca9ffbbbc42c558496Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_89dfc296578aaa53d7fbc0b8af34fb54 recordList, Func<ST_a23a10e9592e51ca9ffbbbc42c558496Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_89dfc296578aaa53d7fbc0b8af34fb54(ST_a23a10e9592e51ca9ffbbbc42c558496Structure[] array) {
  RL_89dfc296578aaa53d7fbc0b8af34fb54 result = new RL_89dfc296578aaa53d7fbc0b8af34fb54();
result.InnerFromArray(array);
    return result;
}

public static RL_89dfc296578aaa53d7fbc0b8af34fb54 ToList<T>(T[] array, Func <T, ST_a23a10e9592e51ca9ffbbbc42c558496Structure> converter) {
  RL_89dfc296578aaa53d7fbc0b8af34fb54 result = new RL_89dfc296578aaa53d7fbc0b8af34fb54();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_89dfc296578aaa53d7fbc0b8af34fb54 FromRestList<T>(RestList<T> restList, Func <T, ST_a23a10e9592e51ca9ffbbbc42c558496Structure> converter) {
  RL_89dfc296578aaa53d7fbc0b8af34fb54 result = new RL_89dfc296578aaa53d7fbc0b8af34fb54();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_89dfc296578aaa53d7fbc0b8af34fb54() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_a23a10e9592e51ca9ffbbbc42c558496Structure> NewList() {
return new RL_89dfc296578aaa53d7fbc0b8af34fb54();
}


} // RL_89dfc296578aaa53d7fbc0b8af34fb54
}

