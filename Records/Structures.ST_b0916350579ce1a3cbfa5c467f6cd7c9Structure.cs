namespace ssConectaProveedores {
/// <summary>
/// [Structure] DocumentExtrationUUID (EdE7FNhCUkmdtaLxeOc7IQ)
///  <code>ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure</code> that represent
/// s <code>DocumentExtrationUUID</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationUUID
public partial struct ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure : ITypedRecord<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> {
internal static readonly GlobalObjectKey IdUUID = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*e0YT+fjgoUabz+SyYPGg5g");

public string ssUUID;


public BitArray OptimizedAttributes;

public ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure() {
OptimizedAttributes = null;
ssUUID = "";
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
ssUUID = r.ReadText(index++, "DocumentExtrationUUID.UUID", "");
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
public void ReadIM(ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure r) {
this = r;
}


public static bool operator == (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure a, ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure b) {
if (a.ssUUID != b.ssUUID) return false;
return true;
}

public static bool operator != (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure a, ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure)) return false;
return (this == (ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUUID.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure Duplicate() {
ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure t;
t.ssUUID = this.ssUUID;
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
if (head == "uuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UUID")) variable.Value = ssUUID; else variable.Optimized = true;
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
if (key == IdUUID) {
return ssUUID;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUUID.Key.AsGuid) {
return ssUUID;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUUID = (string) other.AttributeGet(IdUUID);
}
} // ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure
/// <summary>
/// RecordList type <code>DocumentExtrationUUIDList</code> that represents a record list of
///  <code>DocumentExtrationUUID</code>
/// </summary>
public partial class RL_b7743d9d304780134f71b95e4c6f850f : GenericRecordList<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure>, IEnumerable, IEnumerator {

protected override ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure GetElementDefaultValue() {
return new ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure();
}

public T[] ToArray<T>(Func<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b7743d9d304780134f71b95e4c6f850f recordList, Func<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b7743d9d304780134f71b95e4c6f850f(ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure[] array) {
  RL_b7743d9d304780134f71b95e4c6f850f result = new RL_b7743d9d304780134f71b95e4c6f850f();
result.InnerFromArray(array);
    return result;
}

public static RL_b7743d9d304780134f71b95e4c6f850f ToList<T>(T[] array, Func <T, ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> converter) {
  RL_b7743d9d304780134f71b95e4c6f850f result = new RL_b7743d9d304780134f71b95e4c6f850f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b7743d9d304780134f71b95e4c6f850f FromRestList<T>(RestList<T> restList, Func <T, ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> converter) {
  RL_b7743d9d304780134f71b95e4c6f850f result = new RL_b7743d9d304780134f71b95e4c6f850f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b7743d9d304780134f71b95e4c6f850f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b0916350579ce1a3cbfa5c467f6cd7c9Structure> NewList() {
return new RL_b7743d9d304780134f71b95e4c6f850f();
}


} // RL_b7743d9d304780134f71b95e4c6f850f
}

