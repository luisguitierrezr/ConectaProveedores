namespace ssConectaProveedores {
/// <summary>
/// [Structure] MFU_File (3O067K8lq0+2DWkGac3MmA)
///  <code>ST_1d6498da9105fbe815a7f766352917c0Structure</code> that represents <code>MFU_File</code
/// > <p>Description: File Structure</p>
/// </summary>
// Name: MFU_File
public partial struct ST_1d6498da9105fbe815a7f766352917c0Structure : ITypedRecord<ST_1d6498da9105fbe815a7f766352917c0Structure> {
internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dg5U0gao4EegMCq52RatUg");
internal static readonly GlobalObjectKey IdFileMimeType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wwgWiRdomkuCz4cSOaqe1Q");
internal static readonly GlobalObjectKey IdFileSize = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*adG5gbsbzEyqbjClXss9Gw");
internal static readonly GlobalObjectKey IdFileContent = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_EPCqUOM_kqmRqzoBVJNNQ");
internal static readonly GlobalObjectKey IdFileContentURL = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6zXm__9smkK9Chp3xzl0Yw");
internal static readonly GlobalObjectKey IdFileBigFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*DKtqvjed80Ws+I7kOdjkFA");

public string ssFileName;

public string ssFileMimeType;

public string ssFileSize;

public byte[] ssFileContent;

public string ssFileContentURL;

public long ssFileBigFileId;


public BitArray OptimizedAttributes;

public ST_1d6498da9105fbe815a7f766352917c0Structure() {
OptimizedAttributes = null;
ssFileName = "";
ssFileMimeType = "";
ssFileSize = "";
ssFileContent = new byte[] {};
ssFileContentURL = "";
ssFileBigFileId = 0L;
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
ssFileName = r.ReadText(index++, "MFU_File.FileName", "");
ssFileMimeType = r.ReadText(index++, "MFU_File.FileMimeType", "");
ssFileSize = r.ReadText(index++, "MFU_File.FileSize", "");
ssFileContent = r.ReadBinaryData(index++, "MFU_File.FileContent", new byte[] {});
ssFileContentURL = r.ReadText(index++, "MFU_File.FileContentURL", "");
ssFileBigFileId = r.ReadLongInteger(index++, "MFU_File.FileBigFileId", 0L);
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
public void ReadIM(ST_1d6498da9105fbe815a7f766352917c0Structure r) {
this = r;
}


public static bool operator == (ST_1d6498da9105fbe815a7f766352917c0Structure a, ST_1d6498da9105fbe815a7f766352917c0Structure b) {
if (a.ssFileName != b.ssFileName) return false;
if (a.ssFileMimeType != b.ssFileMimeType) return false;
if (a.ssFileSize != b.ssFileSize) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssFileContent, b.ssFileContent)) return false;
if (a.ssFileContentURL != b.ssFileContentURL) return false;
if (a.ssFileBigFileId != b.ssFileBigFileId) return false;
return true;
}

public static bool operator != (ST_1d6498da9105fbe815a7f766352917c0Structure a, ST_1d6498da9105fbe815a7f766352917c0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1d6498da9105fbe815a7f766352917c0Structure)) return false;
return (this == (ST_1d6498da9105fbe815a7f766352917c0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFileName.GetHashCode()
 ^ ssFileMimeType.GetHashCode()
 ^ ssFileSize.GetHashCode()
 ^ ssFileContent.GetHashCode()
 ^ ssFileContentURL.GetHashCode()
 ^ ssFileBigFileId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1d6498da9105fbe815a7f766352917c0Structure Duplicate() {
ST_1d6498da9105fbe815a7f766352917c0Structure t;
t.ssFileName = this.ssFileName;
t.ssFileMimeType = this.ssFileMimeType;
t.ssFileSize = this.ssFileSize;
t.ssFileContent = this.ssFileContent;
t.ssFileContentURL = this.ssFileContentURL;
t.ssFileBigFileId = this.ssFileBigFileId;
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
} else if (head == "filemimetype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileMimeType")) variable.Value = ssFileMimeType; else variable.Optimized = true;
} else if (head == "filesize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileSize")) variable.Value = ssFileSize; else variable.Optimized = true;
} else if (head == "filecontent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileContent")) variable.Value = ssFileContent; else variable.Optimized = true;
} else if (head == "filecontenturl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileContentURL")) variable.Value = ssFileContentURL; else variable.Optimized = true;
} else if (head == "filebigfileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileBigFileId")) variable.Value = ssFileBigFileId; else variable.Optimized = true;
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
if (key == IdFileMimeType) {
return ssFileMimeType;
}
if (key == IdFileSize) {
return ssFileSize;
}
if (key == IdFileContent) {
return ssFileContent;
}
if (key == IdFileContentURL) {
return ssFileContentURL;
}
if (key == IdFileBigFileId) {
return ssFileBigFileId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFileName.Key.AsGuid) {
return ssFileName;
}
if (attributeKey == IdFileMimeType.Key.AsGuid) {
return ssFileMimeType;
}
if (attributeKey == IdFileSize.Key.AsGuid) {
return ssFileSize;
}
if (attributeKey == IdFileContent.Key.AsGuid) {
return ssFileContent;
}
if (attributeKey == IdFileContentURL.Key.AsGuid) {
return ssFileContentURL;
}
if (attributeKey == IdFileBigFileId.Key.AsGuid) {
return ssFileBigFileId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFileName = (string) other.AttributeGet(IdFileName);
ssFileMimeType = (string) other.AttributeGet(IdFileMimeType);
ssFileSize = (string) other.AttributeGet(IdFileSize);
ssFileContent = (byte[]) other.AttributeGet(IdFileContent);
ssFileContentURL = (string) other.AttributeGet(IdFileContentURL);
ssFileBigFileId = (long) other.AttributeGet(IdFileBigFileId);
}
} // ST_1d6498da9105fbe815a7f766352917c0Structure
/// <summary>
/// RecordList type <code>MFU_FileList</code> that represents a record list of <code>MFU_File</code>
/// </summary>
public partial class RL_c1eb8411e912c8cb1baf6b6cb26787eb : GenericRecordList<ST_1d6498da9105fbe815a7f766352917c0Structure>, IEnumerable, IEnumerator {

protected override ST_1d6498da9105fbe815a7f766352917c0Structure GetElementDefaultValue() {
return new ST_1d6498da9105fbe815a7f766352917c0Structure();
}

public T[] ToArray<T>(Func<ST_1d6498da9105fbe815a7f766352917c0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c1eb8411e912c8cb1baf6b6cb26787eb recordList, Func<ST_1d6498da9105fbe815a7f766352917c0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c1eb8411e912c8cb1baf6b6cb26787eb(ST_1d6498da9105fbe815a7f766352917c0Structure[] array) {
  RL_c1eb8411e912c8cb1baf6b6cb26787eb result = new RL_c1eb8411e912c8cb1baf6b6cb26787eb();
result.InnerFromArray(array);
    return result;
}

public static RL_c1eb8411e912c8cb1baf6b6cb26787eb ToList<T>(T[] array, Func <T, ST_1d6498da9105fbe815a7f766352917c0Structure> converter) {
  RL_c1eb8411e912c8cb1baf6b6cb26787eb result = new RL_c1eb8411e912c8cb1baf6b6cb26787eb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c1eb8411e912c8cb1baf6b6cb26787eb FromRestList<T>(RestList<T> restList, Func <T, ST_1d6498da9105fbe815a7f766352917c0Structure> converter) {
  RL_c1eb8411e912c8cb1baf6b6cb26787eb result = new RL_c1eb8411e912c8cb1baf6b6cb26787eb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c1eb8411e912c8cb1baf6b6cb26787eb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1d6498da9105fbe815a7f766352917c0Structure> NewList() {
return new RL_c1eb8411e912c8cb1baf6b6cb26787eb();
}


} // RL_c1eb8411e912c8cb1baf6b6cb26787eb
}

