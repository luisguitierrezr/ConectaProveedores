namespace ssConectaProveedores {
/// <summary>
/// [Structure] FilesJson (4in0OC5A2kWgPCGu3PiDcw)
///  <code>ST_6c0a0d3b1d72414f90bb9301bad200fbStructure</code> that represents <code>FilesJson</code
/// > <p>Description: </p>
/// </summary>
// Name: FilesJson
public partial struct ST_6c0a0d3b1d72414f90bb9301bad200fbStructure : ITypedRecord<ST_6c0a0d3b1d72414f90bb9301bad200fbStructure> {
internal static readonly GlobalObjectKey IdFileId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MwRxM2pqw0a3WR6fnSRzaQ");
internal static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kGF2pSnkAkOMaljLvOye2Q");
internal static readonly GlobalObjectKey IdFileSize = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6BKegzN4UEqOYFAo24Kbjw");
internal static readonly GlobalObjectKey IdTotalChunks = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4pWJrQANk0qj9oUOH+NIOg");

public long ssFileId;

public string ssFileName;

public long ssFileSize;

public int ssTotalChunks;


public BitArray OptimizedAttributes;

public ST_6c0a0d3b1d72414f90bb9301bad200fbStructure() {
OptimizedAttributes = null;
ssFileId = 0L;
ssFileName = "";
ssFileSize = 0L;
ssTotalChunks = 0;
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
ssFileId = r.ReadLongInteger(index++, "FilesJson.FileId", 0L);
ssFileName = r.ReadText(index++, "FilesJson.FileName", "");
ssFileSize = r.ReadLongInteger(index++, "FilesJson.FileSize", 0L);
ssTotalChunks = r.ReadInteger(index++, "FilesJson.TotalChunks", 0);
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
public void ReadIM(ST_6c0a0d3b1d72414f90bb9301bad200fbStructure r) {
this = r;
}


public static bool operator == (ST_6c0a0d3b1d72414f90bb9301bad200fbStructure a, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure b) {
if (a.ssFileId != b.ssFileId) return false;
if (a.ssFileName != b.ssFileName) return false;
if (a.ssFileSize != b.ssFileSize) return false;
if (a.ssTotalChunks != b.ssTotalChunks) return false;
return true;
}

public static bool operator != (ST_6c0a0d3b1d72414f90bb9301bad200fbStructure a, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6c0a0d3b1d72414f90bb9301bad200fbStructure)) return false;
return (this == (ST_6c0a0d3b1d72414f90bb9301bad200fbStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFileId.GetHashCode()
 ^ ssFileName.GetHashCode()
 ^ ssFileSize.GetHashCode()
 ^ ssTotalChunks.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6c0a0d3b1d72414f90bb9301bad200fbStructure Duplicate() {
ST_6c0a0d3b1d72414f90bb9301bad200fbStructure t;
t.ssFileId = this.ssFileId;
t.ssFileName = this.ssFileName;
t.ssFileSize = this.ssFileSize;
t.ssTotalChunks = this.ssTotalChunks;
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
if (head == "fileid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileId")) variable.Value = ssFileId; else variable.Optimized = true;
} else if (head == "filename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
} else if (head == "filesize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileSize")) variable.Value = ssFileSize; else variable.Optimized = true;
} else if (head == "totalchunks") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalChunks")) variable.Value = ssTotalChunks; else variable.Optimized = true;
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
if (key == IdFileId) {
return ssFileId;
}
if (key == IdFileName) {
return ssFileName;
}
if (key == IdFileSize) {
return ssFileSize;
}
if (key == IdTotalChunks) {
return ssTotalChunks;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFileId.Key.AsGuid) {
return ssFileId;
}
if (attributeKey == IdFileName.Key.AsGuid) {
return ssFileName;
}
if (attributeKey == IdFileSize.Key.AsGuid) {
return ssFileSize;
}
if (attributeKey == IdTotalChunks.Key.AsGuid) {
return ssTotalChunks;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFileId = (long) other.AttributeGet(IdFileId);
ssFileName = (string) other.AttributeGet(IdFileName);
ssFileSize = (long) other.AttributeGet(IdFileSize);
ssTotalChunks = (int) other.AttributeGet(IdTotalChunks);
}
} // ST_6c0a0d3b1d72414f90bb9301bad200fbStructure
/// <summary>
/// RecordList type <code>FilesJsonList</code> that represents a record list of <code>FilesJson</code>
/// </summary>
public partial class RL_e2f87228588c7237002d108caedf9018 : GenericRecordList<ST_6c0a0d3b1d72414f90bb9301bad200fbStructure>, IEnumerable, IEnumerator {

protected override ST_6c0a0d3b1d72414f90bb9301bad200fbStructure GetElementDefaultValue() {
return new ST_6c0a0d3b1d72414f90bb9301bad200fbStructure();
}

public T[] ToArray<T>(Func<ST_6c0a0d3b1d72414f90bb9301bad200fbStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e2f87228588c7237002d108caedf9018 recordList, Func<ST_6c0a0d3b1d72414f90bb9301bad200fbStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e2f87228588c7237002d108caedf9018(ST_6c0a0d3b1d72414f90bb9301bad200fbStructure[] array) {
  RL_e2f87228588c7237002d108caedf9018 result = new RL_e2f87228588c7237002d108caedf9018();
result.InnerFromArray(array);
    return result;
}

public static RL_e2f87228588c7237002d108caedf9018 ToList<T>(T[] array, Func <T, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure> converter) {
  RL_e2f87228588c7237002d108caedf9018 result = new RL_e2f87228588c7237002d108caedf9018();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e2f87228588c7237002d108caedf9018 FromRestList<T>(RestList<T> restList, Func <T, ST_6c0a0d3b1d72414f90bb9301bad200fbStructure> converter) {
  RL_e2f87228588c7237002d108caedf9018 result = new RL_e2f87228588c7237002d108caedf9018();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e2f87228588c7237002d108caedf9018() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6c0a0d3b1d72414f90bb9301bad200fbStructure> NewList() {
return new RL_e2f87228588c7237002d108caedf9018();
}


} // RL_e2f87228588c7237002d108caedf9018
}

