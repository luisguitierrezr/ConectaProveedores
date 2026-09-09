namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jkqBszTCwUaF70RojVH95w)
///  <code>RC_3ad59a78981b4fa31a09641e4a914930</code> that represents <code>UserNameRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserNameRecord
public partial struct RC_3ad59a78981b4fa31a09641e4a914930 : ITypedRecord<RC_3ad59a78981b4fa31a09641e4a914930> {
internal static readonly GlobalObjectKey IdUserName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJrVOhuYo08aCWQeSpFJMA");

public string ssUserName;


public BitArray OptimizedAttributes;

public RC_3ad59a78981b4fa31a09641e4a914930() {
OptimizedAttributes = null;
ssUserName = "";
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
ssUserName = r.ReadText(index++, "UserNameRecord.UserName", "");
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
public void ReadIM(RC_3ad59a78981b4fa31a09641e4a914930 r) {
this = r;
}


public static bool operator == (RC_3ad59a78981b4fa31a09641e4a914930 a, RC_3ad59a78981b4fa31a09641e4a914930 b) {
if (a.ssUserName != b.ssUserName) return false;
return true;
}

public static bool operator != (RC_3ad59a78981b4fa31a09641e4a914930 a, RC_3ad59a78981b4fa31a09641e4a914930 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3ad59a78981b4fa31a09641e4a914930)) return false;
return (this == (RC_3ad59a78981b4fa31a09641e4a914930)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUserName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_3ad59a78981b4fa31a09641e4a914930 Duplicate() {
RC_3ad59a78981b4fa31a09641e4a914930 t;
t.ssUserName = this.ssUserName;
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
if (head == "username") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserName")) variable.Value = ssUserName; else variable.Optimized = true;
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
if (key == IdUserName) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserName.Key.AsGuid) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUserName = (string) other.AttributeGet(IdUserName);
}
} // RC_3ad59a78981b4fa31a09641e4a914930
/// <summary>
/// RecordList type <code>UserNameRecordList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_8e4276b7147c8295b1546570303ecba2 : GenericRecordList<RC_3ad59a78981b4fa31a09641e4a914930>, IEnumerable, IEnumerator {

protected override RC_3ad59a78981b4fa31a09641e4a914930 GetElementDefaultValue() {
return new RC_3ad59a78981b4fa31a09641e4a914930();
}

public T[] ToArray<T>(Func<RC_3ad59a78981b4fa31a09641e4a914930, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8e4276b7147c8295b1546570303ecba2 recordList, Func<RC_3ad59a78981b4fa31a09641e4a914930, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8e4276b7147c8295b1546570303ecba2(RC_3ad59a78981b4fa31a09641e4a914930[] array) {
  RL_8e4276b7147c8295b1546570303ecba2 result = new RL_8e4276b7147c8295b1546570303ecba2();
result.InnerFromArray(array);
    return result;
}

public static RL_8e4276b7147c8295b1546570303ecba2 ToList<T>(T[] array, Func <T, RC_3ad59a78981b4fa31a09641e4a914930> converter) {
  RL_8e4276b7147c8295b1546570303ecba2 result = new RL_8e4276b7147c8295b1546570303ecba2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8e4276b7147c8295b1546570303ecba2 FromRestList<T>(RestList<T> restList, Func <T, RC_3ad59a78981b4fa31a09641e4a914930> converter) {
  RL_8e4276b7147c8295b1546570303ecba2 result = new RL_8e4276b7147c8295b1546570303ecba2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8e4276b7147c8295b1546570303ecba2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3ad59a78981b4fa31a09641e4a914930> NewList() {
return new RL_8e4276b7147c8295b1546570303ecba2();
}


} // RL_8e4276b7147c8295b1546570303ecba2
}

