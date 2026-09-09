namespace ssConectaProveedores {
/// <summary>
/// [Structure] Counter (xEaFqR2E9EyvDYEnTEm55w)
///  <code>ST_bfed96b4bd29e9b06f0b06e901b1508bStructure</code> that represents <code>Counter</code
/// > <p>Description: Counter Struct.</p>
/// </summary>
// Name: Counter
public partial struct ST_bfed96b4bd29e9b06f0b06e901b1508bStructure : ITypedRecord<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure> {
internal static readonly GlobalObjectKey IdStatusLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rxyhnzG9HUWLlpmU+1T9QQ");
internal static readonly GlobalObjectKey IdCount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*15lf3SpYvESGVBxWp1upog");

public string ssStatusLabel;

public int ssCount;


public BitArray OptimizedAttributes;

public ST_bfed96b4bd29e9b06f0b06e901b1508bStructure() {
OptimizedAttributes = null;
ssStatusLabel = "";
ssCount = 0;
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
ssStatusLabel = r.ReadText(index++, "Counter.StatusLabel", "");
ssCount = r.ReadInteger(index++, "Counter.Count", 0);
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
public void ReadIM(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure r) {
this = r;
}


public static bool operator == (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure a, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure b) {
if (a.ssStatusLabel != b.ssStatusLabel) return false;
if (a.ssCount != b.ssCount) return false;
return true;
}

public static bool operator != (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure a, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure)) return false;
return (this == (ST_bfed96b4bd29e9b06f0b06e901b1508bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssStatusLabel.GetHashCode()
 ^ ssCount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_bfed96b4bd29e9b06f0b06e901b1508bStructure Duplicate() {
ST_bfed96b4bd29e9b06f0b06e901b1508bStructure t;
t.ssStatusLabel = this.ssStatusLabel;
t.ssCount = this.ssCount;
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
if (head == "statuslabel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StatusLabel")) variable.Value = ssStatusLabel; else variable.Optimized = true;
} else if (head == "count") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Count")) variable.Value = ssCount; else variable.Optimized = true;
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
if (key == IdStatusLabel) {
return ssStatusLabel;
}
if (key == IdCount) {
return ssCount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStatusLabel.Key.AsGuid) {
return ssStatusLabel;
}
if (attributeKey == IdCount.Key.AsGuid) {
return ssCount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssStatusLabel = (string) other.AttributeGet(IdStatusLabel);
ssCount = (int) other.AttributeGet(IdCount);
}
} // ST_bfed96b4bd29e9b06f0b06e901b1508bStructure
/// <summary>
/// RecordList type <code>CounterList</code> that represents a record list of <code>Counter</code>
/// </summary>
public partial class RL_496abaeba4975b81a1a9b391230e8099 : GenericRecordList<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure>, IEnumerable, IEnumerator {

protected override ST_bfed96b4bd29e9b06f0b06e901b1508bStructure GetElementDefaultValue() {
return new ST_bfed96b4bd29e9b06f0b06e901b1508bStructure();
}

public T[] ToArray<T>(Func<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_496abaeba4975b81a1a9b391230e8099 recordList, Func<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_496abaeba4975b81a1a9b391230e8099(ST_bfed96b4bd29e9b06f0b06e901b1508bStructure[] array) {
  RL_496abaeba4975b81a1a9b391230e8099 result = new RL_496abaeba4975b81a1a9b391230e8099();
result.InnerFromArray(array);
    return result;
}

public static RL_496abaeba4975b81a1a9b391230e8099 ToList<T>(T[] array, Func <T, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure> converter) {
  RL_496abaeba4975b81a1a9b391230e8099 result = new RL_496abaeba4975b81a1a9b391230e8099();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_496abaeba4975b81a1a9b391230e8099 FromRestList<T>(RestList<T> restList, Func <T, ST_bfed96b4bd29e9b06f0b06e901b1508bStructure> converter) {
  RL_496abaeba4975b81a1a9b391230e8099 result = new RL_496abaeba4975b81a1a9b391230e8099();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_496abaeba4975b81a1a9b391230e8099() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_bfed96b4bd29e9b06f0b06e901b1508bStructure> NewList() {
return new RL_496abaeba4975b81a1a9b391230e8099();
}


} // RL_496abaeba4975b81a1a9b391230e8099
}

