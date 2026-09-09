namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (1ILWpmzpVke5ZUONiG565Q)
///  <code>RC_0abe3ce56ac5cb76651869d42c67839f</code> that represent
/// s <code>UserIdEmailNameOrderNumberRecord</code> <p>Description: </p>
/// </summary>
// Name: UserIdEmailNameOrderNumberRecord
public partial struct RC_0abe3ce56ac5cb76651869d42c67839f : ITypedRecord<RC_0abe3ce56ac5cb76651869d42c67839f> {
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7bYltFO7QFzcB1JfCLEFtw");
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qQdf2QK5R8k9OiUB+0dSJQ");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Y+cKFFxbDlVfkzJLEj4LTw");
internal static readonly GlobalObjectKey IdOrderNumber = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wAa0qxge8G_KWh0b4rJCyg");

public string ssUserId;

public string ssEmail;

public string ssName;

public string ssOrderNumber;


public BitArray OptimizedAttributes;

public RC_0abe3ce56ac5cb76651869d42c67839f() {
OptimizedAttributes = null;
ssUserId = "";
ssEmail = "";
ssName = "";
ssOrderNumber = "";
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
ssUserId = r.ReadEntityReferenceText(index++, "UserIdEmailNameOrderNumberRecord.UserId", "");
ssEmail = r.ReadText(index++, "UserIdEmailNameOrderNumberRecord.Email", "");
ssName = r.ReadText(index++, "UserIdEmailNameOrderNumberRecord.Name", "");
ssOrderNumber = r.ReadText(index++, "UserIdEmailNameOrderNumberRecord.OrderNumber", "");
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
public void ReadIM(RC_0abe3ce56ac5cb76651869d42c67839f r) {
this = r;
}


public static bool operator == (RC_0abe3ce56ac5cb76651869d42c67839f a, RC_0abe3ce56ac5cb76651869d42c67839f b) {
if (a.ssUserId != b.ssUserId) return false;
if (a.ssEmail != b.ssEmail) return false;
if (a.ssName != b.ssName) return false;
if (a.ssOrderNumber != b.ssOrderNumber) return false;
return true;
}

public static bool operator != (RC_0abe3ce56ac5cb76651869d42c67839f a, RC_0abe3ce56ac5cb76651869d42c67839f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0abe3ce56ac5cb76651869d42c67839f)) return false;
return (this == (RC_0abe3ce56ac5cb76651869d42c67839f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssOrderNumber.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_0abe3ce56ac5cb76651869d42c67839f Duplicate() {
RC_0abe3ce56ac5cb76651869d42c67839f t;
t.ssUserId = this.ssUserId;
t.ssEmail = this.ssEmail;
t.ssName = this.ssName;
t.ssOrderNumber = this.ssOrderNumber;
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
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "ordernumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderNumber")) variable.Value = ssOrderNumber; else variable.Optimized = true;
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
if (key == IdName) {
return ssName;
}
if (key == IdOrderNumber) {
return ssOrderNumber;
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
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdOrderNumber.Key.AsGuid) {
return ssOrderNumber;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUserId = (string) other.AttributeGet(IdUserId);
ssEmail = (string) other.AttributeGet(IdEmail);
ssName = (string) other.AttributeGet(IdName);
ssOrderNumber = (string) other.AttributeGet(IdOrderNumber);
}
} // RC_0abe3ce56ac5cb76651869d42c67839f
/// <summary>
/// RecordList type <code>UserIdEmailNameOrderNumberRecordList</code> that represents a record list of
///  <code>UserIdentifier, Text, Text, Text</code>
/// </summary>
public partial class RL_66bf4c4c2a926b63449c8fef667ea749 : GenericRecordList<RC_0abe3ce56ac5cb76651869d42c67839f>, IEnumerable, IEnumerator {

protected override RC_0abe3ce56ac5cb76651869d42c67839f GetElementDefaultValue() {
return new RC_0abe3ce56ac5cb76651869d42c67839f();
}

public T[] ToArray<T>(Func<RC_0abe3ce56ac5cb76651869d42c67839f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_66bf4c4c2a926b63449c8fef667ea749 recordList, Func<RC_0abe3ce56ac5cb76651869d42c67839f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_66bf4c4c2a926b63449c8fef667ea749(RC_0abe3ce56ac5cb76651869d42c67839f[] array) {
  RL_66bf4c4c2a926b63449c8fef667ea749 result = new RL_66bf4c4c2a926b63449c8fef667ea749();
result.InnerFromArray(array);
    return result;
}

public static RL_66bf4c4c2a926b63449c8fef667ea749 ToList<T>(T[] array, Func <T, RC_0abe3ce56ac5cb76651869d42c67839f> converter) {
  RL_66bf4c4c2a926b63449c8fef667ea749 result = new RL_66bf4c4c2a926b63449c8fef667ea749();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_66bf4c4c2a926b63449c8fef667ea749 FromRestList<T>(RestList<T> restList, Func <T, RC_0abe3ce56ac5cb76651869d42c67839f> converter) {
  RL_66bf4c4c2a926b63449c8fef667ea749 result = new RL_66bf4c4c2a926b63449c8fef667ea749();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_66bf4c4c2a926b63449c8fef667ea749() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0abe3ce56ac5cb76651869d42c67839f> NewList() {
return new RL_66bf4c4c2a926b63449c8fef667ea749();
}


} // RL_66bf4c4c2a926b63449c8fef667ea749
}

