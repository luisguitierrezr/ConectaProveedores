namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8GEf2W1r_0WEbhaxO1cFJQ)
///  <code>RC_9558728eac8dc806cf1b0c0e9a8e1262</code> that represents <code>FilenameBinaryRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FilenameBinaryRecord
public partial struct RC_9558728eac8dc806cf1b0c0e9a8e1262 : ITypedRecord<RC_9558728eac8dc806cf1b0c0e9a8e1262> {
internal static readonly GlobalObjectKey IdFilename = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+YrsofvLjSgLElKWrWIMDw");
internal static readonly GlobalObjectKey IdBinary = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Hd+yU+kiZHNSys4WkYkqmQ");

public string ssFilename;

public byte[] ssBinary;


public BitArray OptimizedAttributes;

public RC_9558728eac8dc806cf1b0c0e9a8e1262() {
OptimizedAttributes = null;
ssFilename = "";
ssBinary = new byte[] {};
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
ssFilename = r.ReadText(index++, "FilenameBinaryRecord.Filename", "");
ssBinary = r.ReadBinaryData(index++, "FilenameBinaryRecord.Binary", new byte[] {});
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
public void ReadIM(RC_9558728eac8dc806cf1b0c0e9a8e1262 r) {
this = r;
}


public static bool operator == (RC_9558728eac8dc806cf1b0c0e9a8e1262 a, RC_9558728eac8dc806cf1b0c0e9a8e1262 b) {
if (a.ssFilename != b.ssFilename) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinary, b.ssBinary)) return false;
return true;
}

public static bool operator != (RC_9558728eac8dc806cf1b0c0e9a8e1262 a, RC_9558728eac8dc806cf1b0c0e9a8e1262 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9558728eac8dc806cf1b0c0e9a8e1262)) return false;
return (this == (RC_9558728eac8dc806cf1b0c0e9a8e1262)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssFilename.GetHashCode()
 ^ ssBinary.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_9558728eac8dc806cf1b0c0e9a8e1262 Duplicate() {
RC_9558728eac8dc806cf1b0c0e9a8e1262 t;
t.ssFilename = this.ssFilename;
t.ssBinary = this.ssBinary;
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".Filename")) variable.Value = ssFilename; else variable.Optimized = true;
} else if (head == "binary") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Binary")) variable.Value = ssBinary; else variable.Optimized = true;
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
if (key == IdFilename) {
return ssFilename;
}
if (key == IdBinary) {
return ssBinary;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFilename.Key.AsGuid) {
return ssFilename;
}
if (attributeKey == IdBinary.Key.AsGuid) {
return ssBinary;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssFilename = (string) other.AttributeGet(IdFilename);
ssBinary = (byte[]) other.AttributeGet(IdBinary);
}
} // RC_9558728eac8dc806cf1b0c0e9a8e1262
/// <summary>
/// RecordList type <code>FilenameBinaryRecordList</code> that represents a record list of <code>Text,
///  BinaryData</code>
/// </summary>
public partial class RL_2a0d4fc753558da30a13e98ffb4a202b : GenericRecordList<RC_9558728eac8dc806cf1b0c0e9a8e1262>, IEnumerable, IEnumerator {

protected override RC_9558728eac8dc806cf1b0c0e9a8e1262 GetElementDefaultValue() {
return new RC_9558728eac8dc806cf1b0c0e9a8e1262();
}

public T[] ToArray<T>(Func<RC_9558728eac8dc806cf1b0c0e9a8e1262, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2a0d4fc753558da30a13e98ffb4a202b recordList, Func<RC_9558728eac8dc806cf1b0c0e9a8e1262, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2a0d4fc753558da30a13e98ffb4a202b(RC_9558728eac8dc806cf1b0c0e9a8e1262[] array) {
  RL_2a0d4fc753558da30a13e98ffb4a202b result = new RL_2a0d4fc753558da30a13e98ffb4a202b();
result.InnerFromArray(array);
    return result;
}

public static RL_2a0d4fc753558da30a13e98ffb4a202b ToList<T>(T[] array, Func <T, RC_9558728eac8dc806cf1b0c0e9a8e1262> converter) {
  RL_2a0d4fc753558da30a13e98ffb4a202b result = new RL_2a0d4fc753558da30a13e98ffb4a202b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2a0d4fc753558da30a13e98ffb4a202b FromRestList<T>(RestList<T> restList, Func <T, RC_9558728eac8dc806cf1b0c0e9a8e1262> converter) {
  RL_2a0d4fc753558da30a13e98ffb4a202b result = new RL_2a0d4fc753558da30a13e98ffb4a202b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2a0d4fc753558da30a13e98ffb4a202b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9558728eac8dc806cf1b0c0e9a8e1262> NewList() {
return new RL_2a0d4fc753558da30a13e98ffb4a202b();
}


} // RL_2a0d4fc753558da30a13e98ffb4a202b
}

