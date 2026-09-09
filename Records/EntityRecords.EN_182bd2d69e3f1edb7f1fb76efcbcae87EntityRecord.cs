using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] BreakColumns (g3I5unMyHkWMS0b25poOzg)
///  <code>EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord</code> that represent
/// s <code>BreakColumns</code> <p>Description: Different ways of breaking the columns.</p>
/// </summary>
// Name: BreakColumns
public partial struct EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord : ITypedRecord<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> {
internal static readonly GlobalObjectKey IdBreakColumns = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*h2O_wrFyek2ZlDKpDHp8cA");

private string _ssBreakColumns;
public string ssBreakColumns{
  get{
      return _ssBreakColumns;
  }
  set{
      if((_ssBreakColumns!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssBreakColumns = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssBreakColumns = "";
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
ssBreakColumns = r.ReadText(index++, "BreakColumns.BreakColumns", "");
ChangedAttributes = new BitArray(1,false);
OptimizedAttributes = new BitArray(1,false);
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
public void ReadIM(EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord r) {
this = r;
}


public static bool operator == (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord a, EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord b) {
if (a.ssBreakColumns != b.ssBreakColumns) return false;
return true;
}

public static bool operator != (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord a, EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord)) return false;
return (this == (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssBreakColumns.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord Duplicate() {
EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord t;
t._ssBreakColumns = this._ssBreakColumns;
t.ChangedAttributes = new BitArray(1);
t.OptimizedAttributes = new BitArray(1);
for(int i = 0; i < 1; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "breakcolumns") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BreakColumns")) variable.Value = ssBreakColumns; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdBreakColumns)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdBreakColumns)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdBreakColumns) {
return ssBreakColumns;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBreakColumns.Key.AsGuid) {
return ssBreakColumns;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssBreakColumns = (string) other.AttributeGet(IdBreakColumns);
ChangedAttributes[0] = other.ChangedAttributeGet(IdBreakColumns);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdBreakColumns);
}
} // EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord

/// <summary>
/// RecordList type <code>BreakColumnsList</code> that represents a record list of
///  <code>BreakColumns</code>
/// </summary>
public partial class RL_67211e5ef9090bf1006a3e1da6767024 : GenericRecordList<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord>, IEnumerable, IEnumerator {

protected override EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord GetElementDefaultValue() {
return new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord();
}

public T[] ToArray<T>(Func<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_67211e5ef9090bf1006a3e1da6767024 recordList, Func<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_67211e5ef9090bf1006a3e1da6767024(EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord[] array) {
  RL_67211e5ef9090bf1006a3e1da6767024 result = new RL_67211e5ef9090bf1006a3e1da6767024();
result.InnerFromArray(array);
    return result;
}

public static RL_67211e5ef9090bf1006a3e1da6767024 ToList<T>(T[] array, Func <T, EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> converter) {
  RL_67211e5ef9090bf1006a3e1da6767024 result = new RL_67211e5ef9090bf1006a3e1da6767024();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_67211e5ef9090bf1006a3e1da6767024 FromRestList<T>(RestList<T> restList, Func <T, EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> converter) {
  RL_67211e5ef9090bf1006a3e1da6767024 result = new RL_67211e5ef9090bf1006a3e1da6767024();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_67211e5ef9090bf1006a3e1da6767024() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord> NewList() {
return new RL_67211e5ef9090bf1006a3e1da6767024();
}


} // RL_67211e5ef9090bf1006a3e1da6767024
}
