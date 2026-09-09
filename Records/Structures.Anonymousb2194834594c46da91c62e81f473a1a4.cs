namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (NEgZskxZ2kaRxi6B9HOhpA)
///  <code>RC_f4217b217830b749d338ebe1832450a6</code> that represent
/// s <code>UserIdRoleNameUserNameRecord</code> <p>Description: </p>
/// </summary>
// Name: UserIdRoleNameUserNameRecord
public partial struct RC_f4217b217830b749d338ebe1832450a6 : ITypedRecord<RC_f4217b217830b749d338ebe1832450a6> {
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7bYltFO7QFzcB1JfCLEFtw");
internal static readonly GlobalObjectKey IdRoleName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lBW5U2yEyIK2dhyOEkvC+Q");
internal static readonly GlobalObjectKey IdUserName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eJrVOhuYo08aCWQeSpFJMA");

public string ssUserId;

public string ssRoleName;

public string ssUserName;


public BitArray OptimizedAttributes;

public RC_f4217b217830b749d338ebe1832450a6() {
OptimizedAttributes = null;
ssUserId = "";
ssRoleName = "";
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
ssUserId = r.ReadEntityReferenceText(index++, "UserIdRoleNameUserNameRecord.UserId", "");
ssRoleName = r.ReadText(index++, "UserIdRoleNameUserNameRecord.RoleName", "");
ssUserName = r.ReadText(index++, "UserIdRoleNameUserNameRecord.UserName", "");
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
public void ReadIM(RC_f4217b217830b749d338ebe1832450a6 r) {
this = r;
}


public static bool operator == (RC_f4217b217830b749d338ebe1832450a6 a, RC_f4217b217830b749d338ebe1832450a6 b) {
if (a.ssUserId != b.ssUserId) return false;
if (a.ssRoleName != b.ssRoleName) return false;
if (a.ssUserName != b.ssUserName) return false;
return true;
}

public static bool operator != (RC_f4217b217830b749d338ebe1832450a6 a, RC_f4217b217830b749d338ebe1832450a6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f4217b217830b749d338ebe1832450a6)) return false;
return (this == (RC_f4217b217830b749d338ebe1832450a6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssUserId.GetHashCode()
 ^ ssRoleName.GetHashCode()
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


public RC_f4217b217830b749d338ebe1832450a6 Duplicate() {
RC_f4217b217830b749d338ebe1832450a6 t;
t.ssUserId = this.ssUserId;
t.ssRoleName = this.ssRoleName;
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
} else if (head == "rolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleName")) variable.Value = ssRoleName; else variable.Optimized = true;
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
if (key == IdRoleName) {
return ssRoleName;
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
if (attributeKey == IdRoleName.Key.AsGuid) {
return ssRoleName;
}
if (attributeKey == IdUserName.Key.AsGuid) {
return ssUserName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssUserId = (string) other.AttributeGet(IdUserId);
ssRoleName = (string) other.AttributeGet(IdRoleName);
ssUserName = (string) other.AttributeGet(IdUserName);
}
} // RC_f4217b217830b749d338ebe1832450a6
/// <summary>
/// RecordList type <code>UserIdRoleNameUserNameRecordList</code> that represents a record list of
///  <code>UserIdentifier, Text, Text</code>
/// </summary>
public partial class RL_1145aac6350efb8c92df9a6bfb52edab : GenericRecordList<RC_f4217b217830b749d338ebe1832450a6>, IEnumerable, IEnumerator {

protected override RC_f4217b217830b749d338ebe1832450a6 GetElementDefaultValue() {
return new RC_f4217b217830b749d338ebe1832450a6();
}

public T[] ToArray<T>(Func<RC_f4217b217830b749d338ebe1832450a6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1145aac6350efb8c92df9a6bfb52edab recordList, Func<RC_f4217b217830b749d338ebe1832450a6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1145aac6350efb8c92df9a6bfb52edab(RC_f4217b217830b749d338ebe1832450a6[] array) {
  RL_1145aac6350efb8c92df9a6bfb52edab result = new RL_1145aac6350efb8c92df9a6bfb52edab();
result.InnerFromArray(array);
    return result;
}

public static RL_1145aac6350efb8c92df9a6bfb52edab ToList<T>(T[] array, Func <T, RC_f4217b217830b749d338ebe1832450a6> converter) {
  RL_1145aac6350efb8c92df9a6bfb52edab result = new RL_1145aac6350efb8c92df9a6bfb52edab();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1145aac6350efb8c92df9a6bfb52edab FromRestList<T>(RestList<T> restList, Func <T, RC_f4217b217830b749d338ebe1832450a6> converter) {
  RL_1145aac6350efb8c92df9a6bfb52edab result = new RL_1145aac6350efb8c92df9a6bfb52edab();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1145aac6350efb8c92df9a6bfb52edab() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f4217b217830b749d338ebe1832450a6> NewList() {
return new RL_1145aac6350efb8c92df9a6bfb52edab();
}


} // RL_1145aac6350efb8c92df9a6bfb52edab
}

