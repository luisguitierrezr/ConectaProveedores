namespace ssConectaProveedores {
/// <summary>
/// [Structure] KeyValue (9epNhLPk8UK9MfvzupNUQw)
///  <code>ST_714c559a98f1e1080cbf60de3228e843Structure</code> that represents <code>KeyValue</code
/// > <p>Description: </p>
/// </summary>
// Name: KeyValue
public partial struct ST_714c559a98f1e1080cbf60de3228e843Structure : ITypedRecord<ST_714c559a98f1e1080cbf60de3228e843Structure> {
internal static readonly GlobalObjectKey IdKey = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*C5C3aUgBG0aqyR429uxPLQ");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gKO+S+Od9kK1xLvsx8doJQ");

public int ssKey;

public string ssValue;


public BitArray OptimizedAttributes;

public ST_714c559a98f1e1080cbf60de3228e843Structure() {
OptimizedAttributes = null;
ssKey = 0;
ssValue = "";
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
ssKey = r.ReadInteger(index++, "KeyValue.Key", 0);
ssValue = r.ReadText(index++, "KeyValue.Value", "");
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
public void ReadIM(ST_714c559a98f1e1080cbf60de3228e843Structure r) {
this = r;
}


public static bool operator == (ST_714c559a98f1e1080cbf60de3228e843Structure a, ST_714c559a98f1e1080cbf60de3228e843Structure b) {
if (a.ssKey != b.ssKey) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_714c559a98f1e1080cbf60de3228e843Structure a, ST_714c559a98f1e1080cbf60de3228e843Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_714c559a98f1e1080cbf60de3228e843Structure)) return false;
return (this == (ST_714c559a98f1e1080cbf60de3228e843Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssKey.GetHashCode()
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


public ST_714c559a98f1e1080cbf60de3228e843Structure Duplicate() {
ST_714c559a98f1e1080cbf60de3228e843Structure t;
t.ssKey = this.ssKey;
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
if (head == "key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Key")) variable.Value = ssKey; else variable.Optimized = true;
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
if (key == IdKey) {
return ssKey;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdKey.Key.AsGuid) {
return ssKey;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssKey = (int) other.AttributeGet(IdKey);
ssValue = (string) other.AttributeGet(IdValue);
}
} // ST_714c559a98f1e1080cbf60de3228e843Structure
/// <summary>
/// RecordList type <code>KeyValueList</code> that represents a record list of <code>KeyValue</code>
/// </summary>
public partial class RL_a579a1a05eaaba551100ea61f4cb3f6b : GenericRecordList<ST_714c559a98f1e1080cbf60de3228e843Structure>, IEnumerable, IEnumerator {

protected override ST_714c559a98f1e1080cbf60de3228e843Structure GetElementDefaultValue() {
return new ST_714c559a98f1e1080cbf60de3228e843Structure();
}

public T[] ToArray<T>(Func<ST_714c559a98f1e1080cbf60de3228e843Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a579a1a05eaaba551100ea61f4cb3f6b recordList, Func<ST_714c559a98f1e1080cbf60de3228e843Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a579a1a05eaaba551100ea61f4cb3f6b(ST_714c559a98f1e1080cbf60de3228e843Structure[] array) {
  RL_a579a1a05eaaba551100ea61f4cb3f6b result = new RL_a579a1a05eaaba551100ea61f4cb3f6b();
result.InnerFromArray(array);
    return result;
}

public static RL_a579a1a05eaaba551100ea61f4cb3f6b ToList<T>(T[] array, Func <T, ST_714c559a98f1e1080cbf60de3228e843Structure> converter) {
  RL_a579a1a05eaaba551100ea61f4cb3f6b result = new RL_a579a1a05eaaba551100ea61f4cb3f6b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a579a1a05eaaba551100ea61f4cb3f6b FromRestList<T>(RestList<T> restList, Func <T, ST_714c559a98f1e1080cbf60de3228e843Structure> converter) {
  RL_a579a1a05eaaba551100ea61f4cb3f6b result = new RL_a579a1a05eaaba551100ea61f4cb3f6b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a579a1a05eaaba551100ea61f4cb3f6b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_714c559a98f1e1080cbf60de3228e843Structure> NewList() {
return new RL_a579a1a05eaaba551100ea61f4cb3f6b();
}


} // RL_a579a1a05eaaba551100ea61f4cb3f6b
}

