namespace ssConectaProveedores {
/// <summary>
/// [Structure] Text (2FHLupVBmEK+vch7EfIfZA) <code>ST_1f76dfa138680efe9e5e11deb3c828b8Structure</code>
///  that represents <code>Text</code> <p>Description: Text</p>
/// </summary>
// Name: Text
public partial struct ST_1f76dfa138680efe9e5e11deb3c828b8Structure : ITypedRecord<ST_1f76dfa138680efe9e5e11deb3c828b8Structure> {
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*izulzDppiEm_jboz8+xSug");

public string ssValue;


public BitArray OptimizedAttributes;

public ST_1f76dfa138680efe9e5e11deb3c828b8Structure() {
OptimizedAttributes = null;
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
ssValue = r.ReadText(index++, "Text.Value", "");
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
public void ReadIM(ST_1f76dfa138680efe9e5e11deb3c828b8Structure r) {
this = r;
}


public static bool operator == (ST_1f76dfa138680efe9e5e11deb3c828b8Structure a, ST_1f76dfa138680efe9e5e11deb3c828b8Structure b) {
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_1f76dfa138680efe9e5e11deb3c828b8Structure a, ST_1f76dfa138680efe9e5e11deb3c828b8Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1f76dfa138680efe9e5e11deb3c828b8Structure)) return false;
return (this == (ST_1f76dfa138680efe9e5e11deb3c828b8Structure)o);
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


public ST_1f76dfa138680efe9e5e11deb3c828b8Structure Duplicate() {
ST_1f76dfa138680efe9e5e11deb3c828b8Structure t;
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
ssValue = (string) other.AttributeGet(IdValue);
}
} // ST_1f76dfa138680efe9e5e11deb3c828b8Structure
/// <summary>
/// RecordList type <code>TextList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_f36e98e1ea4e4525e74dd70d32783a2a : GenericRecordList<ST_1f76dfa138680efe9e5e11deb3c828b8Structure>, IEnumerable, IEnumerator {

protected override ST_1f76dfa138680efe9e5e11deb3c828b8Structure GetElementDefaultValue() {
return new ST_1f76dfa138680efe9e5e11deb3c828b8Structure();
}

public T[] ToArray<T>(Func<ST_1f76dfa138680efe9e5e11deb3c828b8Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f36e98e1ea4e4525e74dd70d32783a2a recordList, Func<ST_1f76dfa138680efe9e5e11deb3c828b8Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f36e98e1ea4e4525e74dd70d32783a2a(ST_1f76dfa138680efe9e5e11deb3c828b8Structure[] array) {
  RL_f36e98e1ea4e4525e74dd70d32783a2a result = new RL_f36e98e1ea4e4525e74dd70d32783a2a();
result.InnerFromArray(array);
    return result;
}

public static RL_f36e98e1ea4e4525e74dd70d32783a2a ToList<T>(T[] array, Func <T, ST_1f76dfa138680efe9e5e11deb3c828b8Structure> converter) {
  RL_f36e98e1ea4e4525e74dd70d32783a2a result = new RL_f36e98e1ea4e4525e74dd70d32783a2a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f36e98e1ea4e4525e74dd70d32783a2a FromRestList<T>(RestList<T> restList, Func <T, ST_1f76dfa138680efe9e5e11deb3c828b8Structure> converter) {
  RL_f36e98e1ea4e4525e74dd70d32783a2a result = new RL_f36e98e1ea4e4525e74dd70d32783a2a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f36e98e1ea4e4525e74dd70d32783a2a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1f76dfa138680efe9e5e11deb3c828b8Structure> NewList() {
return new RL_f36e98e1ea4e4525e74dd70d32783a2a();
}


} // RL_f36e98e1ea4e4525e74dd70d32783a2a
}

