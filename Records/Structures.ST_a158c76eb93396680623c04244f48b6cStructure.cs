namespace ssConectaProveedores {
/// <summary>
/// [Structure] FileStruct (DifDSbP_Z0+_DTZfFFsGwA)
///  <code>ST_a158c76eb93396680623c04244f48b6cStructure</code> that represents <code>FileStruct</code
/// > <p>Description: Exportations file Struct.</p>
/// </summary>
// Name: FileStruct
public partial struct ST_a158c76eb93396680623c04244f48b6cStructure : ITypedRecord<ST_a158c76eb93396680623c04244f48b6cStructure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YNjeIYxzlEaS29jMlWzyDg");
internal static readonly GlobalObjectKey IdBinaryData = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*jjsqYw76Y0ijvt6XkLUcow");

public string ssName;

public byte[] ssBinaryData;


public BitArray OptimizedAttributes;

public ST_a158c76eb93396680623c04244f48b6cStructure() {
OptimizedAttributes = null;
ssName = "";
ssBinaryData = new byte[] {};
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
ssName = r.ReadText(index++, "FileStruct.Name", "");
ssBinaryData = r.ReadBinaryData(index++, "FileStruct.BinaryData", new byte[] {});
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
public void ReadIM(ST_a158c76eb93396680623c04244f48b6cStructure r) {
this = r;
}


public static bool operator == (ST_a158c76eb93396680623c04244f48b6cStructure a, ST_a158c76eb93396680623c04244f48b6cStructure b) {
if (a.ssName != b.ssName) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinaryData, b.ssBinaryData)) return false;
return true;
}

public static bool operator != (ST_a158c76eb93396680623c04244f48b6cStructure a, ST_a158c76eb93396680623c04244f48b6cStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_a158c76eb93396680623c04244f48b6cStructure)) return false;
return (this == (ST_a158c76eb93396680623c04244f48b6cStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssBinaryData.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_a158c76eb93396680623c04244f48b6cStructure Duplicate() {
ST_a158c76eb93396680623c04244f48b6cStructure t;
t.ssName = this.ssName;
t.ssBinaryData = this.ssBinaryData;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdBinaryData.Key.AsGuid) {
return ssBinaryData;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssBinaryData = (byte[]) other.AttributeGet(IdBinaryData);
}
} // ST_a158c76eb93396680623c04244f48b6cStructure
/// <summary>
/// RecordList type <code>FileStructList</code> that represents a record list of
///  <code>FileStruct</code>
/// </summary>
public partial class RL_a1f410d0f62252476f2a43f62445ebc5 : GenericRecordList<ST_a158c76eb93396680623c04244f48b6cStructure>, IEnumerable, IEnumerator {

protected override ST_a158c76eb93396680623c04244f48b6cStructure GetElementDefaultValue() {
return new ST_a158c76eb93396680623c04244f48b6cStructure();
}

public T[] ToArray<T>(Func<ST_a158c76eb93396680623c04244f48b6cStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a1f410d0f62252476f2a43f62445ebc5 recordList, Func<ST_a158c76eb93396680623c04244f48b6cStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a1f410d0f62252476f2a43f62445ebc5(ST_a158c76eb93396680623c04244f48b6cStructure[] array) {
  RL_a1f410d0f62252476f2a43f62445ebc5 result = new RL_a1f410d0f62252476f2a43f62445ebc5();
result.InnerFromArray(array);
    return result;
}

public static RL_a1f410d0f62252476f2a43f62445ebc5 ToList<T>(T[] array, Func <T, ST_a158c76eb93396680623c04244f48b6cStructure> converter) {
  RL_a1f410d0f62252476f2a43f62445ebc5 result = new RL_a1f410d0f62252476f2a43f62445ebc5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a1f410d0f62252476f2a43f62445ebc5 FromRestList<T>(RestList<T> restList, Func <T, ST_a158c76eb93396680623c04244f48b6cStructure> converter) {
  RL_a1f410d0f62252476f2a43f62445ebc5 result = new RL_a1f410d0f62252476f2a43f62445ebc5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a1f410d0f62252476f2a43f62445ebc5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_a158c76eb93396680623c04244f48b6cStructure> NewList() {
return new RL_a1f410d0f62252476f2a43f62445ebc5();
}


} // RL_a1f410d0f62252476f2a43f62445ebc5
}

