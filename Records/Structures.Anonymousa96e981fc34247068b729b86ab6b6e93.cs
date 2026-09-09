namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (H5huqULDBkeLcpuGq2tukw)
///  <code>RC_99fa4277b2264c97bde8f4525bdc92e0</code> that represents <code>TextValueRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TextValueRecord
public partial struct RC_99fa4277b2264c97bde8f4525bdc92e0 : ITypedRecord<RC_99fa4277b2264c97bde8f4525bdc92e0> {
internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*W1Fhyhtfo4H2OnL2lpOuNg");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*y18El1G4SZ7eWg3uWr4C0w");

public string ssText;

public int ssValue;


public BitArray OptimizedAttributes;

public RC_99fa4277b2264c97bde8f4525bdc92e0() {
OptimizedAttributes = null;
ssText = "";
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
ssText = r.ReadText(index++, "TextValueRecord.Text", "");
ssValue = r.ReadInteger(index++, "TextValueRecord.Value", 0);
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
public void ReadIM(RC_99fa4277b2264c97bde8f4525bdc92e0 r) {
this = r;
}


public static bool operator == (RC_99fa4277b2264c97bde8f4525bdc92e0 a, RC_99fa4277b2264c97bde8f4525bdc92e0 b) {
if (a.ssText != b.ssText) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (RC_99fa4277b2264c97bde8f4525bdc92e0 a, RC_99fa4277b2264c97bde8f4525bdc92e0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_99fa4277b2264c97bde8f4525bdc92e0)) return false;
return (this == (RC_99fa4277b2264c97bde8f4525bdc92e0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssText.GetHashCode()
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


public RC_99fa4277b2264c97bde8f4525bdc92e0 Duplicate() {
RC_99fa4277b2264c97bde8f4525bdc92e0 t;
t.ssText = this.ssText;
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
if (head == "text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssText; else variable.Optimized = true;
} else if (head == "value") {
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
if (key == IdText) {
return ssText;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdText.Key.AsGuid) {
return ssText;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssText = (string) other.AttributeGet(IdText);
ssValue = (int) other.AttributeGet(IdValue);
}
} // RC_99fa4277b2264c97bde8f4525bdc92e0
/// <summary>
/// RecordList type <code>TextValueRecordList</code> that represents a record list of <code>Text,
///  Integer</code>
/// </summary>
public partial class RL_a59fb62a79f0dae5316722bac67c6766 : GenericRecordList<RC_99fa4277b2264c97bde8f4525bdc92e0>, IEnumerable, IEnumerator {

protected override RC_99fa4277b2264c97bde8f4525bdc92e0 GetElementDefaultValue() {
return new RC_99fa4277b2264c97bde8f4525bdc92e0();
}

public T[] ToArray<T>(Func<RC_99fa4277b2264c97bde8f4525bdc92e0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a59fb62a79f0dae5316722bac67c6766 recordList, Func<RC_99fa4277b2264c97bde8f4525bdc92e0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a59fb62a79f0dae5316722bac67c6766(RC_99fa4277b2264c97bde8f4525bdc92e0[] array) {
  RL_a59fb62a79f0dae5316722bac67c6766 result = new RL_a59fb62a79f0dae5316722bac67c6766();
result.InnerFromArray(array);
    return result;
}

public static RL_a59fb62a79f0dae5316722bac67c6766 ToList<T>(T[] array, Func <T, RC_99fa4277b2264c97bde8f4525bdc92e0> converter) {
  RL_a59fb62a79f0dae5316722bac67c6766 result = new RL_a59fb62a79f0dae5316722bac67c6766();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a59fb62a79f0dae5316722bac67c6766 FromRestList<T>(RestList<T> restList, Func <T, RC_99fa4277b2264c97bde8f4525bdc92e0> converter) {
  RL_a59fb62a79f0dae5316722bac67c6766 result = new RL_a59fb62a79f0dae5316722bac67c6766();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a59fb62a79f0dae5316722bac67c6766() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_99fa4277b2264c97bde8f4525bdc92e0> NewList() {
return new RL_a59fb62a79f0dae5316722bac67c6766();
}


} // RL_a59fb62a79f0dae5316722bac67c6766
}

