namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (k6gDGS6IMUmBTN6xy9FUnw)
///  <code>RC_140ae7635b5c550e5f93324b123e0b4f</code> that represents <code>NameRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: NameRecord
public partial struct RC_140ae7635b5c550e5f93324b123e0b4f : ITypedRecord<RC_140ae7635b5c550e5f93324b123e0b4f> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Y+cKFFxbDlVfkzJLEj4LTw");

public string ssName;


public BitArray OptimizedAttributes;

public RC_140ae7635b5c550e5f93324b123e0b4f() {
OptimizedAttributes = null;
ssName = "";
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
ssName = r.ReadText(index++, "NameRecord.Name", "");
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
public void ReadIM(RC_140ae7635b5c550e5f93324b123e0b4f r) {
this = r;
}


public static bool operator == (RC_140ae7635b5c550e5f93324b123e0b4f a, RC_140ae7635b5c550e5f93324b123e0b4f b) {
if (a.ssName != b.ssName) return false;
return true;
}

public static bool operator != (RC_140ae7635b5c550e5f93324b123e0b4f a, RC_140ae7635b5c550e5f93324b123e0b4f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_140ae7635b5c550e5f93324b123e0b4f)) return false;
return (this == (RC_140ae7635b5c550e5f93324b123e0b4f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_140ae7635b5c550e5f93324b123e0b4f Duplicate() {
RC_140ae7635b5c550e5f93324b123e0b4f t;
t.ssName = this.ssName;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
}
} // RC_140ae7635b5c550e5f93324b123e0b4f
/// <summary>
/// RecordList type <code>NameRecordList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_3e9501626d68e0b595764f7f1bae2fae : GenericRecordList<RC_140ae7635b5c550e5f93324b123e0b4f>, IEnumerable, IEnumerator {

protected override RC_140ae7635b5c550e5f93324b123e0b4f GetElementDefaultValue() {
return new RC_140ae7635b5c550e5f93324b123e0b4f();
}

public T[] ToArray<T>(Func<RC_140ae7635b5c550e5f93324b123e0b4f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3e9501626d68e0b595764f7f1bae2fae recordList, Func<RC_140ae7635b5c550e5f93324b123e0b4f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3e9501626d68e0b595764f7f1bae2fae(RC_140ae7635b5c550e5f93324b123e0b4f[] array) {
  RL_3e9501626d68e0b595764f7f1bae2fae result = new RL_3e9501626d68e0b595764f7f1bae2fae();
result.InnerFromArray(array);
    return result;
}

public static RL_3e9501626d68e0b595764f7f1bae2fae ToList<T>(T[] array, Func <T, RC_140ae7635b5c550e5f93324b123e0b4f> converter) {
  RL_3e9501626d68e0b595764f7f1bae2fae result = new RL_3e9501626d68e0b595764f7f1bae2fae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3e9501626d68e0b595764f7f1bae2fae FromRestList<T>(RestList<T> restList, Func <T, RC_140ae7635b5c550e5f93324b123e0b4f> converter) {
  RL_3e9501626d68e0b595764f7f1bae2fae result = new RL_3e9501626d68e0b595764f7f1bae2fae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3e9501626d68e0b595764f7f1bae2fae() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_140ae7635b5c550e5f93324b123e0b4f> NewList() {
return new RL_3e9501626d68e0b595764f7f1bae2fae();
}


} // RL_3e9501626d68e0b595764f7f1bae2fae
}

