namespace ssConectaProveedores {
/// <summary>
/// [Structure] Integer (7_4ua8oWbk635OZtOyH_FQ)
///  <code>ST_e4103a4d41689de0feae1065888fc2e0Structure</code> that represents <code>Integer</code
/// > <p>Description: </p>
/// </summary>
// Name: Integer
public partial struct ST_e4103a4d41689de0feae1065888fc2e0Structure : ITypedRecord<ST_e4103a4d41689de0feae1065888fc2e0Structure> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0h+g+xWN4kOWZTYDpoUd0g");

public int ssValue;


public BitArray OptimizedAttributes;

public ST_e4103a4d41689de0feae1065888fc2e0Structure() {
OptimizedAttributes = null;
ssValue = 0;
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
ssValue = r.ReadInteger(index++, "Integer.Value", 0);
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
public void ReadIM(ST_e4103a4d41689de0feae1065888fc2e0Structure r) {
this = r;
}


public static bool operator == (ST_e4103a4d41689de0feae1065888fc2e0Structure a, ST_e4103a4d41689de0feae1065888fc2e0Structure b) {
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_e4103a4d41689de0feae1065888fc2e0Structure a, ST_e4103a4d41689de0feae1065888fc2e0Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e4103a4d41689de0feae1065888fc2e0Structure)) return false;
return (this == (ST_e4103a4d41689de0feae1065888fc2e0Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e4103a4d41689de0feae1065888fc2e0Structure Duplicate() {
ST_e4103a4d41689de0feae1065888fc2e0Structure t;
t.ssValue = this.ssValue;
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
if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssValue = (int) other.AttributeGet(IdValue);
}
} // ST_e4103a4d41689de0feae1065888fc2e0Structure
/// <summary>
/// RecordList type <code>IntegerList</code> that represents a record list of <code>Integer</code>
/// </summary>
public partial class RL_0d238a3f2ddaabf16b8f815e39f5ac6c : GenericRecordList<ST_e4103a4d41689de0feae1065888fc2e0Structure>, IEnumerable, IEnumerator {

protected override ST_e4103a4d41689de0feae1065888fc2e0Structure GetElementDefaultValue() {
return new ST_e4103a4d41689de0feae1065888fc2e0Structure();
}

public T[] ToArray<T>(Func<ST_e4103a4d41689de0feae1065888fc2e0Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0d238a3f2ddaabf16b8f815e39f5ac6c recordList, Func<ST_e4103a4d41689de0feae1065888fc2e0Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0d238a3f2ddaabf16b8f815e39f5ac6c(ST_e4103a4d41689de0feae1065888fc2e0Structure[] array) {
  RL_0d238a3f2ddaabf16b8f815e39f5ac6c result = new RL_0d238a3f2ddaabf16b8f815e39f5ac6c();
result.InnerFromArray(array);
    return result;
}

public static RL_0d238a3f2ddaabf16b8f815e39f5ac6c ToList<T>(T[] array, Func <T, ST_e4103a4d41689de0feae1065888fc2e0Structure> converter) {
  RL_0d238a3f2ddaabf16b8f815e39f5ac6c result = new RL_0d238a3f2ddaabf16b8f815e39f5ac6c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0d238a3f2ddaabf16b8f815e39f5ac6c FromRestList<T>(RestList<T> restList, Func <T, ST_e4103a4d41689de0feae1065888fc2e0Structure> converter) {
  RL_0d238a3f2ddaabf16b8f815e39f5ac6c result = new RL_0d238a3f2ddaabf16b8f815e39f5ac6c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0d238a3f2ddaabf16b8f815e39f5ac6c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e4103a4d41689de0feae1065888fc2e0Structure> NewList() {
return new RL_0d238a3f2ddaabf16b8f815e39f5ac6c();
}


} // RL_0d238a3f2ddaabf16b8f815e39f5ac6c
}

