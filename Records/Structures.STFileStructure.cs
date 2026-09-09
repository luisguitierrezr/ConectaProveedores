namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] File2 (r_FO4_qT6U+7iQKYseuh2g) <code>STFileStructure</code> that represents
///  <code>File2</code> <p>Description: </p>
/// </summary>
// Name: File2
public partial struct STFileStructure : ITypedRecord<STFileStructure>, OutSystems.Application.Extensibility.DataTypes.IStructure {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("X+oqN1bQrUqnUEI4hv+shg*MpTxrDsI2ZHiF0xV8l0PLA");
internal static readonly GlobalObjectKey IdIsDirectory = GlobalObjectKey.Parse("X+oqN1bQrUqnUEI4hv+shg*rHzfvJ_0SJQDG34TsgRK5w");
internal static readonly GlobalObjectKey IdDateTime = GlobalObjectKey.Parse("X+oqN1bQrUqnUEI4hv+shg*IbkGf+maVhROj4N7o66P8g");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("X+oqN1bQrUqnUEI4hv+shg*nKghhRfLBsd7HwdIgVKJpA");
internal static readonly GlobalObjectKey IdCompressedSize = GlobalObjectKey.Parse("X+oqN1bQrUqnUEI4hv+shg*h_HU1h7TUFboaIFcEUnZaw");
internal static readonly GlobalObjectKey IdContent = GlobalObjectKey.Parse("X+oqN1bQrUqnUEI4hv+shg*PNEDJrvw4BR+ZmOoYyR2Ag");

public string ssName;

public bool ssIsDirectory;

public DateTime ssDateTime;

public int ssSize;

public int ssCompressedSize;

public byte[] ssContent;


public BitArray OptimizedAttributes;

public STFileStructure() {
OptimizedAttributes = null;
ssName = "";
ssIsDirectory = false;
ssDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssSize = 0;
ssCompressedSize = 0;
ssContent = new byte[] {};
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
ssName = r.ReadText(index++, "File2.Name", "");
ssIsDirectory = r.ReadBoolean(index++, "File2.IsDirectory", false);
ssDateTime = r.ReadDateTime(index++, "File2.DateTime", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssSize = r.ReadInteger(index++, "File2.Size", 0);
ssCompressedSize = r.ReadInteger(index++, "File2.CompressedSize", 0);
ssContent = r.ReadBinaryData(index++, "File2.Content", new byte[] {});
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
public void ReadIM(STFileStructure r) {
this = r;
}


public static bool operator == (STFileStructure a, STFileStructure b) {
if (a.ssName != b.ssName) return false;
if (a.ssIsDirectory != b.ssIsDirectory) return false;
if (a.ssDateTime != b.ssDateTime) return false;
if (a.ssSize != b.ssSize) return false;
if (a.ssCompressedSize != b.ssCompressedSize) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssContent, b.ssContent)) return false;
return true;
}

public static bool operator != (STFileStructure a, STFileStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (STFileStructure)) return false;
return (this == (STFileStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssIsDirectory.GetHashCode()
 ^ ssDateTime.GetHashCode()
 ^ ssSize.GetHashCode()
 ^ ssCompressedSize.GetHashCode()
 ^ ssContent.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public STFileStructure Duplicate() {
STFileStructure t;
t.ssName = this.ssName;
t.ssIsDirectory = this.ssIsDirectory;
t.ssDateTime = this.ssDateTime;
t.ssSize = this.ssSize;
t.ssCompressedSize = this.ssCompressedSize;
t.ssContent = this.ssContent;
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
} else if (head == "isdirectory") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDirectory")) variable.Value = ssIsDirectory; else variable.Optimized = true;
} else if (head == "datetime") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateTime")) variable.Value = ssDateTime; else variable.Optimized = true;
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
} else if (head == "compressedsize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompressedSize")) variable.Value = ssCompressedSize; else variable.Optimized = true;
} else if (head == "content") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Content")) variable.Value = ssContent; else variable.Optimized = true;
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
if (key == IdIsDirectory) {
return ssIsDirectory;
}
if (key == IdDateTime) {
return ssDateTime;
}
if (key == IdSize) {
return ssSize;
}
if (key == IdCompressedSize) {
return ssCompressedSize;
}
if (key == IdContent) {
return ssContent;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdIsDirectory.Key.AsGuid) {
return ssIsDirectory;
}
if (attributeKey == IdDateTime.Key.AsGuid) {
return ssDateTime;
}
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
if (attributeKey == IdCompressedSize.Key.AsGuid) {
return ssCompressedSize;
}
if (attributeKey == IdContent.Key.AsGuid) {
return ssContent;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssIsDirectory = (bool) other.AttributeGet(IdIsDirectory);
ssDateTime = (DateTime) other.AttributeGet(IdDateTime);
ssSize = (int) other.AttributeGet(IdSize);
ssCompressedSize = (int) other.AttributeGet(IdCompressedSize);
ssContent = (byte[]) other.AttributeGet(IdContent);
}
public void CopyFrom(OutSystems.Application.Extensibility.DataTypes.IRecord other) {
if (other == null) return;
ssName = (string) other.GetAttribute(IdName.Key.AsGuid);
ssIsDirectory = (bool) other.GetAttribute(IdIsDirectory.Key.AsGuid);
ssDateTime = (DateTime) other.GetAttribute(IdDateTime.Key.AsGuid);
ssSize = (int) other.GetAttribute(IdSize.Key.AsGuid);
ssCompressedSize = (int) other.GetAttribute(IdCompressedSize.Key.AsGuid);
ssContent = (byte[]) other.GetAttribute(IdContent.Key.AsGuid);
}
} // STFileStructure
/// <summary>
/// RecordList type <code>File2List</code> that represents a record list of <code>File2</code>
/// </summary>
public partial class RLFileList : GenericRecordList<STFileStructure>, IEnumerable, IEnumerator {

protected override STFileStructure GetElementDefaultValue() {
return new STFileStructure();
}

public T[] ToArray<T>(Func<STFileStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RLFileList recordList, Func<STFileStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RLFileList(STFileStructure[] array) {
  RLFileList result = new RLFileList();
result.InnerFromArray(array);
    return result;
}

public static RLFileList ToList<T>(T[] array, Func <T, STFileStructure> converter) {
  RLFileList result = new RLFileList();
  result.InnerFromArray(array, converter);
  return result;
}

public static RLFileList FromRestList<T>(RestList<T> restList, Func <T, STFileStructure> converter) {
  RLFileList result = new RLFileList();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RLFileList() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<STFileStructure> NewList() {
return new RLFileList();
}


} // RLFileList
}

