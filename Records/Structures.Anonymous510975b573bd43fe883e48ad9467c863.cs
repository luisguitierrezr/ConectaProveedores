namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tXUJUb1z_kOIPkitlGfIYw)
///  <code>RC_ff0b06695390fb8e1933a62e3ed27cb9</code> that represents <code>EntraRoleIdRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: EntraRoleIdRecord
public partial struct RC_ff0b06695390fb8e1933a62e3ed27cb9 : ITypedRecord<RC_ff0b06695390fb8e1933a62e3ed27cb9> {
internal static readonly GlobalObjectKey IdEntraRoleId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aQYL_5BTjvsZM6YuPtJ8uQ");

public long ssEntraRoleId;


public BitArray OptimizedAttributes;

public RC_ff0b06695390fb8e1933a62e3ed27cb9() {
OptimizedAttributes = null;
ssEntraRoleId = 0L;
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
ssEntraRoleId = r.ReadEntityReferenceLongInteger(index++, "EntraRoleIdRecord.EntraRoleId", 0L);
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
public void ReadIM(RC_ff0b06695390fb8e1933a62e3ed27cb9 r) {
this = r;
}


public static bool operator == (RC_ff0b06695390fb8e1933a62e3ed27cb9 a, RC_ff0b06695390fb8e1933a62e3ed27cb9 b) {
if (a.ssEntraRoleId != b.ssEntraRoleId) return false;
return true;
}

public static bool operator != (RC_ff0b06695390fb8e1933a62e3ed27cb9 a, RC_ff0b06695390fb8e1933a62e3ed27cb9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ff0b06695390fb8e1933a62e3ed27cb9)) return false;
return (this == (RC_ff0b06695390fb8e1933a62e3ed27cb9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEntraRoleId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_ff0b06695390fb8e1933a62e3ed27cb9 Duplicate() {
RC_ff0b06695390fb8e1933a62e3ed27cb9 t;
t.ssEntraRoleId = this.ssEntraRoleId;
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
if (head == "entraroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRoleId")) variable.Value = ssEntraRoleId; else variable.Optimized = true;
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
if (key == IdEntraRoleId) {
return ssEntraRoleId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEntraRoleId.Key.AsGuid) {
return ssEntraRoleId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEntraRoleId = (long) other.AttributeGet(IdEntraRoleId);
}
} // RC_ff0b06695390fb8e1933a62e3ed27cb9
/// <summary>
/// RecordList type <code>EntraRoleIdRecordList</code> that represents a record list of
///  <code>EntraRoleIdentifier</code>
/// </summary>
public partial class RL_b13d2bf72a0c08d2621757797ed1bce6 : GenericRecordList<RC_ff0b06695390fb8e1933a62e3ed27cb9>, IEnumerable, IEnumerator {

protected override RC_ff0b06695390fb8e1933a62e3ed27cb9 GetElementDefaultValue() {
return new RC_ff0b06695390fb8e1933a62e3ed27cb9();
}

public T[] ToArray<T>(Func<RC_ff0b06695390fb8e1933a62e3ed27cb9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b13d2bf72a0c08d2621757797ed1bce6 recordList, Func<RC_ff0b06695390fb8e1933a62e3ed27cb9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b13d2bf72a0c08d2621757797ed1bce6(RC_ff0b06695390fb8e1933a62e3ed27cb9[] array) {
  RL_b13d2bf72a0c08d2621757797ed1bce6 result = new RL_b13d2bf72a0c08d2621757797ed1bce6();
result.InnerFromArray(array);
    return result;
}

public static RL_b13d2bf72a0c08d2621757797ed1bce6 ToList<T>(T[] array, Func <T, RC_ff0b06695390fb8e1933a62e3ed27cb9> converter) {
  RL_b13d2bf72a0c08d2621757797ed1bce6 result = new RL_b13d2bf72a0c08d2621757797ed1bce6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b13d2bf72a0c08d2621757797ed1bce6 FromRestList<T>(RestList<T> restList, Func <T, RC_ff0b06695390fb8e1933a62e3ed27cb9> converter) {
  RL_b13d2bf72a0c08d2621757797ed1bce6 result = new RL_b13d2bf72a0c08d2621757797ed1bce6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b13d2bf72a0c08d2621757797ed1bce6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ff0b06695390fb8e1933a62e3ed27cb9> NewList() {
return new RL_b13d2bf72a0c08d2621757797ed1bce6();
}


} // RL_b13d2bf72a0c08d2621757797ed1bce6
}

