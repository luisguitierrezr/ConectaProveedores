namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (OKW_SMvOZUy+DcwrkWp6NA)
///  <code>RC_3cb5faf855470afd6e46669ad1a86a21</code> that represent
/// s <code>UserIdEmailUserNameRecord</code> <p>Description: </p>
/// </summary>
// Name: UserIdEmailUserNameRecord
public partial struct RC_3cb5faf855470afd6e46669ad1a86a21 : ITypedRecord<RC_3cb5faf855470afd6e46669ad1a86a21> {
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7bYltFO7QFzcB1JfCLEFtw");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qQdf2QK5R8k9OiUB+0dSJQ");
internal static readonly GlobalObjectKey IdUserName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJrVOhuYo08aCWQeSpFJMA");

public string ssUserId;

public string ssEmail;

public string ssUserName;


public BitArray OptimizedAttributes;

public RC_3cb5faf855470afd6e46669ad1a86a21() {
OptimizedAttributes = null;
ssUserId = "";
ssEmail = "";
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
ssUserId = r.ReadEntityReferenceText(index++, "UserIdEmailUserNameRecord.UserId", "");
ssEmail = r.ReadText(index++, "UserIdEmailUserNameRecord.Email", "");
ssUserName = r.ReadText(index++, "UserIdEmailUserNameRecord.UserName", "");
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
public void ReadIM(RC_3cb5faf855470afd6e46669ad1a86a21 r) {
this = r;
}


public static bool operator == (RC_3cb5faf855470afd6e46669ad1a86a21 a, RC_3cb5faf855470afd6e46669ad1a86a21 b) {
if (a.ssUserId != b.ssUserId) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssUserName != b.ssUserName) return false;
return true;
}

public static bool operator != (RC_3cb5faf855470afd6e46669ad1a86a21 a, RC_3cb5faf855470afd6e46669ad1a86a21 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3cb5faf855470afd6e46669ad1a86a21)) return false;
return (this == (RC_3cb5faf855470afd6e46669ad1a86a21)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssEmail.GetHashCode()
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


public RC_3cb5faf855470afd6e46669ad1a86a21 Duplicate() {
RC_3cb5faf855470afd6e46669ad1a86a21 t;
t.ssUserId = this.ssUserId;
t.ssEmail = this.ssEmail;
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
if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
} else if (head == "email") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Email")) variable.Value = ssEmail; else variable.Optimized = true;
} else if (head == "username") {
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
if (key == IdUserId) {
return ssUserId;
}
if (key == IdEmail) {
return ssEmail;
}
if (key == IdUserName) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdUserName.Key.AsGuid) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUserId = (string) other.AttributeGet(IdUserId);
ssEmail = (string) other.AttributeGet(IdEmail);
ssUserName = (string) other.AttributeGet(IdUserName);
}
} // RC_3cb5faf855470afd6e46669ad1a86a21
/// <summary>
/// RecordList type <code>UserIdEmailUserNameRecordList</code> that represents a record list of
///  <code>UserIdentifier, Text, Text</code>
/// </summary>
public partial class RL_b6937d33871d635163e2cf0ad043c360 : GenericRecordList<RC_3cb5faf855470afd6e46669ad1a86a21>, IEnumerable, IEnumerator {

protected override RC_3cb5faf855470afd6e46669ad1a86a21 GetElementDefaultValue() {
return new RC_3cb5faf855470afd6e46669ad1a86a21();
}

public T[] ToArray<T>(Func<RC_3cb5faf855470afd6e46669ad1a86a21, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b6937d33871d635163e2cf0ad043c360 recordList, Func<RC_3cb5faf855470afd6e46669ad1a86a21, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b6937d33871d635163e2cf0ad043c360(RC_3cb5faf855470afd6e46669ad1a86a21[] array) {
  RL_b6937d33871d635163e2cf0ad043c360 result = new RL_b6937d33871d635163e2cf0ad043c360();
result.InnerFromArray(array);
    return result;
}

public static RL_b6937d33871d635163e2cf0ad043c360 ToList<T>(T[] array, Func <T, RC_3cb5faf855470afd6e46669ad1a86a21> converter) {
  RL_b6937d33871d635163e2cf0ad043c360 result = new RL_b6937d33871d635163e2cf0ad043c360();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b6937d33871d635163e2cf0ad043c360 FromRestList<T>(RestList<T> restList, Func <T, RC_3cb5faf855470afd6e46669ad1a86a21> converter) {
  RL_b6937d33871d635163e2cf0ad043c360 result = new RL_b6937d33871d635163e2cf0ad043c360();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b6937d33871d635163e2cf0ad043c360() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3cb5faf855470afd6e46669ad1a86a21> NewList() {
return new RL_b6937d33871d635163e2cf0ad043c360();
}


} // RL_b6937d33871d635163e2cf0ad043c360
}

