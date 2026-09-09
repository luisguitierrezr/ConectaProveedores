namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (k_AfNJpto0WFPOEpWamR6A)
///  <code>RC_18c2d75e8e190384e64859e7ed1d4f00</code> that represent
/// s <code>EmailEntraIdNameRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: EmailEntraIdNameRoleRecord
public partial struct RC_18c2d75e8e190384e64859e7ed1d4f00 : ITypedRecord<RC_18c2d75e8e190384e64859e7ed1d4f00> {
internal static readonly GlobalObjectKey IdEmail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qQdf2QK5R8k9OiUB+0dSJQ");
internal static readonly GlobalObjectKey IdEntraId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wmpzzm9V9WkwVkFdwSRrFw");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Y+cKFFxbDlVfkzJLEj4LTw");
internal static readonly GlobalObjectKey IdRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GscrgxyGSrs9kLKvmVZMSQ");

public string ssEmail;

public string ssEntraId;

public string ssName;

public string ssRole;


public BitArray OptimizedAttributes;

public RC_18c2d75e8e190384e64859e7ed1d4f00() {
OptimizedAttributes = null;
ssEmail = "";
ssEntraId = "";
ssName = "";
ssRole = "";
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
ssEmail = r.ReadText(index++, "EmailEntraIdNameRoleRecord.Email", "");
ssEntraId = r.ReadText(index++, "EmailEntraIdNameRoleRecord.EntraId", "");
ssName = r.ReadText(index++, "EmailEntraIdNameRoleRecord.Name", "");
ssRole = r.ReadText(index++, "EmailEntraIdNameRoleRecord.Role", "");
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
public void ReadIM(RC_18c2d75e8e190384e64859e7ed1d4f00 r) {
this = r;
}


public static bool operator == (RC_18c2d75e8e190384e64859e7ed1d4f00 a, RC_18c2d75e8e190384e64859e7ed1d4f00 b) {
if (a.ssEmail != b.ssEmail) return false;
if (a.ssEntraId != b.ssEntraId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssRole != b.ssRole) return false;
return true;
}

public static bool operator != (RC_18c2d75e8e190384e64859e7ed1d4f00 a, RC_18c2d75e8e190384e64859e7ed1d4f00 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_18c2d75e8e190384e64859e7ed1d4f00)) return false;
return (this == (RC_18c2d75e8e190384e64859e7ed1d4f00)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssEmail.GetHashCode()
 ^ ssEntraId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_18c2d75e8e190384e64859e7ed1d4f00 Duplicate() {
RC_18c2d75e8e190384e64859e7ed1d4f00 t;
t.ssEmail = this.ssEmail;
t.ssEntraId = this.ssEntraId;
t.ssName = this.ssName;
t.ssRole = this.ssRole;
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
} else if (head == "entraid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraId")) variable.Value = ssEntraId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "role") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Role")) variable.Value = ssRole; else variable.Optimized = true;
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
if (key == IdEntraId) {
return ssEntraId;
}
if (key == IdName) {
return ssName;
}
if (key == IdRole) {
return ssRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEmail.Key.AsGuid) {
return ssEmail;
}
if (attributeKey == IdEntraId.Key.AsGuid) {
return ssEntraId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdRole.Key.AsGuid) {
return ssRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssEmail = (string) other.AttributeGet(IdEmail);
ssEntraId = (string) other.AttributeGet(IdEntraId);
ssName = (string) other.AttributeGet(IdName);
ssRole = (string) other.AttributeGet(IdRole);
}
} // RC_18c2d75e8e190384e64859e7ed1d4f00
/// <summary>
/// RecordList type <code>EmailEntraIdNameRoleRecordList</code> that represents a record list of
///  <code>Text, Text, Text, Text</code>
/// </summary>
public partial class RL_144725d7e52a72fc566c148009197c7e : GenericRecordList<RC_18c2d75e8e190384e64859e7ed1d4f00>, IEnumerable, IEnumerator {

protected override RC_18c2d75e8e190384e64859e7ed1d4f00 GetElementDefaultValue() {
return new RC_18c2d75e8e190384e64859e7ed1d4f00();
}

public T[] ToArray<T>(Func<RC_18c2d75e8e190384e64859e7ed1d4f00, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_144725d7e52a72fc566c148009197c7e recordList, Func<RC_18c2d75e8e190384e64859e7ed1d4f00, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_144725d7e52a72fc566c148009197c7e(RC_18c2d75e8e190384e64859e7ed1d4f00[] array) {
  RL_144725d7e52a72fc566c148009197c7e result = new RL_144725d7e52a72fc566c148009197c7e();
result.InnerFromArray(array);
    return result;
}

public static RL_144725d7e52a72fc566c148009197c7e ToList<T>(T[] array, Func <T, RC_18c2d75e8e190384e64859e7ed1d4f00> converter) {
  RL_144725d7e52a72fc566c148009197c7e result = new RL_144725d7e52a72fc566c148009197c7e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_144725d7e52a72fc566c148009197c7e FromRestList<T>(RestList<T> restList, Func <T, RC_18c2d75e8e190384e64859e7ed1d4f00> converter) {
  RL_144725d7e52a72fc566c148009197c7e result = new RL_144725d7e52a72fc566c148009197c7e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_144725d7e52a72fc566c148009197c7e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_18c2d75e8e190384e64859e7ed1d4f00> NewList() {
return new RL_144725d7e52a72fc566c148009197c7e();
}


} // RL_144725d7e52a72fc566c148009197c7e
}

