namespace ssConectaProveedores {
/// <summary>
/// [Structure] FolioFilesStruct (46lou6LgyUqUqbsNE5RWXQ)
///  <code>ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure</code> that represent
/// s <code>FolioFilesStruct</code> <p>Description: Exportations file Struct.</p>
/// </summary>
// Name: FolioFilesStruct
public partial struct ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure : ITypedRecord<ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_ShgIihwiEyeF6SNdJ8JTA");
internal static readonly GlobalObjectKey IdBinaryData = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*imZ63Y76XUKDj9hCG4LEqA");
internal static readonly GlobalObjectKey IdIsExtra = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9U_8+ArWEUq1_v86VjLlKQ");
internal static readonly GlobalObjectKey IdStorageId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ga4S1N_sd0KSVGkfFa07Vw");
internal static readonly GlobalObjectKey IdFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*x7Q3lftVjEuFMteZNK6wmw");

public string ssName;

public byte[] ssBinaryData;

public bool ssIsExtra;

public long ssStorageId;

public long ssFileId;


public BitArray OptimizedAttributes;

public ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure() {
OptimizedAttributes = null;
ssName = "";
ssBinaryData = new byte[] {};
ssIsExtra = false;
ssStorageId = 0L;
ssFileId = 0L;
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
ssName = r.ReadText(index++, "FolioFilesStruct.Name", "");
ssBinaryData = r.ReadBinaryData(index++, "FolioFilesStruct.BinaryData", new byte[] {});
ssIsExtra = r.ReadBoolean(index++, "FolioFilesStruct.IsExtra", false);
ssStorageId = r.ReadEntityReferenceLongInteger(index++, "FolioFilesStruct.StorageId", 0L);
ssFileId = r.ReadEntityReferenceLongInteger(index++, "FolioFilesStruct.FileId", 0L);
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
public void ReadIM(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure r) {
this = r;
}


public static bool operator == (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure a, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure b) {
if (a.ssName != b.ssName) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinaryData, b.ssBinaryData)) return false;
if (a.ssIsExtra != b.ssIsExtra) return false;
if (a.ssStorageId != b.ssStorageId) return false;
if (a.ssFileId != b.ssFileId) return false;
return true;
}

public static bool operator != (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure a, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure)) return false;
return (this == (ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssBinaryData.GetHashCode()
 ^ ssIsExtra.GetHashCode()
 ^ ssStorageId.GetHashCode()
 ^ ssFileId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure Duplicate() {
ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure t;
t.ssName = this.ssName;
t.ssBinaryData = this.ssBinaryData;
t.ssIsExtra = this.ssIsExtra;
t.ssStorageId = this.ssStorageId;
t.ssFileId = this.ssFileId;
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
if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "binarydata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BinaryData")) variable.Value = ssBinaryData; else variable.Optimized = true;
} else if (head == "isextra") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsExtra")) variable.Value = ssIsExtra; else variable.Optimized = true;
} else if (head == "storageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StorageId")) variable.Value = ssStorageId; else variable.Optimized = true;
} else if (head == "fileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileId")) variable.Value = ssFileId; else variable.Optimized = true;
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
if (key == IdName) {
return ssName;
}
if (key == IdBinaryData) {
return ssBinaryData;
}
if (key == IdIsExtra) {
return ssIsExtra;
}
if (key == IdStorageId) {
return ssStorageId;
}
if (key == IdFileId) {
return ssFileId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdBinaryData.Key.AsGuid) {
return ssBinaryData;
}
if (attributeKey == IdIsExtra.Key.AsGuid) {
return ssIsExtra;
}
if (attributeKey == IdStorageId.Key.AsGuid) {
return ssStorageId;
}
if (attributeKey == IdFileId.Key.AsGuid) {
return ssFileId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssBinaryData = (byte[]) other.AttributeGet(IdBinaryData);
ssIsExtra = (bool) other.AttributeGet(IdIsExtra);
ssStorageId = (long) other.AttributeGet(IdStorageId);
ssFileId = (long) other.AttributeGet(IdFileId);
}
} // ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure
/// <summary>
/// RecordList type <code>FolioFilesStructList</code> that represents a record list of
///  <code>FolioFilesStruct</code>
/// </summary>
public partial class RL_1501ee54ff868a67eff67465502ee3d9 : GenericRecordList<ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure>, IEnumerable, IEnumerator {

protected override ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure GetElementDefaultValue() {
return new ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure();
}

public T[] ToArray<T>(Func<ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1501ee54ff868a67eff67465502ee3d9 recordList, Func<ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1501ee54ff868a67eff67465502ee3d9(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure[] array) {
  RL_1501ee54ff868a67eff67465502ee3d9 result = new RL_1501ee54ff868a67eff67465502ee3d9();
result.InnerFromArray(array);
    return result;
}

public static RL_1501ee54ff868a67eff67465502ee3d9 ToList<T>(T[] array, Func <T, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> converter) {
  RL_1501ee54ff868a67eff67465502ee3d9 result = new RL_1501ee54ff868a67eff67465502ee3d9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1501ee54ff868a67eff67465502ee3d9 FromRestList<T>(RestList<T> restList, Func <T, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> converter) {
  RL_1501ee54ff868a67eff67465502ee3d9 result = new RL_1501ee54ff868a67eff67465502ee3d9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1501ee54ff868a67eff67465502ee3d9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> NewList() {
return new RL_1501ee54ff868a67eff67465502ee3d9();
}


} // RL_1501ee54ff868a67eff67465502ee3d9
}

