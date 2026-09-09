namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (v8kH0Odjx0Gk+DxQKxBong)
///  <code>RC_d95f07a9b902c9473d3a2501fb475225</code> that represents <code>EmailRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EmailRecord
public partial struct RC_d95f07a9b902c9473d3a2501fb475225 : ITypedRecord<RC_d95f07a9b902c9473d3a2501fb475225> {
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qQdf2QK5R8k9OiUB+0dSJQ");

public string ssEmail;


public BitArray OptimizedAttributes;

public RC_d95f07a9b902c9473d3a2501fb475225() {
OptimizedAttributes = null;
ssEmail = "";
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
ssEmail = r.ReadText(index++, "EmailRecord.Email", "");
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
public void ReadIM(RC_d95f07a9b902c9473d3a2501fb475225 r) {
this = r;
}


public static bool operator == (RC_d95f07a9b902c9473d3a2501fb475225 a, RC_d95f07a9b902c9473d3a2501fb475225 b) {
if (a.ssEmail != b.ssEmail) return false;
return true;
}

public static bool operator != (RC_d95f07a9b902c9473d3a2501fb475225 a, RC_d95f07a9b902c9473d3a2501fb475225 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d95f07a9b902c9473d3a2501fb475225)) return false;
return (this == (RC_d95f07a9b902c9473d3a2501fb475225)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEmail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_d95f07a9b902c9473d3a2501fb475225 Duplicate() {
RC_d95f07a9b902c9473d3a2501fb475225 t;
t.ssEmail = this.ssEmail;
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
if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
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
if (key == IdEmail) {
return ssEmail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEmail = (string) other.AttributeGet(IdEmail);
}
} // RC_d95f07a9b902c9473d3a2501fb475225
/// <summary>
/// RecordList type <code>EmailRecordList</code> that represents a record list of <code>Text</code>
/// </summary>
public partial class RL_9e2b74ef9afd45546e5941a720a69c18 : GenericRecordList<RC_d95f07a9b902c9473d3a2501fb475225>, IEnumerable, IEnumerator {

protected override RC_d95f07a9b902c9473d3a2501fb475225 GetElementDefaultValue() {
return new RC_d95f07a9b902c9473d3a2501fb475225();
}

public T[] ToArray<T>(Func<RC_d95f07a9b902c9473d3a2501fb475225, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9e2b74ef9afd45546e5941a720a69c18 recordList, Func<RC_d95f07a9b902c9473d3a2501fb475225, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9e2b74ef9afd45546e5941a720a69c18(RC_d95f07a9b902c9473d3a2501fb475225[] array) {
  RL_9e2b74ef9afd45546e5941a720a69c18 result = new RL_9e2b74ef9afd45546e5941a720a69c18();
result.InnerFromArray(array);
    return result;
}

public static RL_9e2b74ef9afd45546e5941a720a69c18 ToList<T>(T[] array, Func <T, RC_d95f07a9b902c9473d3a2501fb475225> converter) {
  RL_9e2b74ef9afd45546e5941a720a69c18 result = new RL_9e2b74ef9afd45546e5941a720a69c18();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9e2b74ef9afd45546e5941a720a69c18 FromRestList<T>(RestList<T> restList, Func <T, RC_d95f07a9b902c9473d3a2501fb475225> converter) {
  RL_9e2b74ef9afd45546e5941a720a69c18 result = new RL_9e2b74ef9afd45546e5941a720a69c18();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9e2b74ef9afd45546e5941a720a69c18() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d95f07a9b902c9473d3a2501fb475225> NewList() {
return new RL_9e2b74ef9afd45546e5941a720a69c18();
}


} // RL_9e2b74ef9afd45546e5941a720a69c18
}

