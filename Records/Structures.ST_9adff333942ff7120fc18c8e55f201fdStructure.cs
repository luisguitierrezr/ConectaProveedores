namespace ssConectaProveedores {
/// <summary>
/// [Structure] UserRole (c8BqWoqo9UO8EnhUcPKhQA)
///  <code>ST_9adff333942ff7120fc18c8e55f201fdStructure</code> that represents <code>UserRole</code
/// > <p>Description: User Role Struct.</p>
/// </summary>
// Name: UserRole
public partial struct ST_9adff333942ff7120fc18c8e55f201fdStructure : ITypedRecord<ST_9adff333942ff7120fc18c8e55f201fdStructure> {
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0uKB1GbXxke7UbGA8Nih+Q");
internal static readonly GlobalObjectKey IdRoleName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Glmh8tYen0KPiz7JEEpubg");

public long ssApplicationRoleId;

public string ssRoleName;


public BitArray OptimizedAttributes;

public ST_9adff333942ff7120fc18c8e55f201fdStructure() {
OptimizedAttributes = null;
ssApplicationRoleId = 0L;
ssRoleName = "";
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
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "UserRole.ApplicationRoleId", 0L);
ssRoleName = r.ReadText(index++, "UserRole.RoleName", "");
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
public void ReadIM(ST_9adff333942ff7120fc18c8e55f201fdStructure r) {
this = r;
}


public static bool operator == (ST_9adff333942ff7120fc18c8e55f201fdStructure a, ST_9adff333942ff7120fc18c8e55f201fdStructure b) {
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssRoleName != b.ssRoleName) return false;
return true;
}

public static bool operator != (ST_9adff333942ff7120fc18c8e55f201fdStructure a, ST_9adff333942ff7120fc18c8e55f201fdStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9adff333942ff7120fc18c8e55f201fdStructure)) return false;
return (this == (ST_9adff333942ff7120fc18c8e55f201fdStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssRoleName.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9adff333942ff7120fc18c8e55f201fdStructure Duplicate() {
ST_9adff333942ff7120fc18c8e55f201fdStructure t;
t.ssApplicationRoleId = this.ssApplicationRoleId;
t.ssRoleName = this.ssRoleName;
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
if (head == "applicationroleid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRoleId")) variable.Value = ssApplicationRoleId; else variable.Optimized = true;
} else if (head == "rolename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleName")) variable.Value = ssRoleName; else variable.Optimized = true;
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
if (key == IdApplicationRoleId) {
return ssApplicationRoleId;
}
if (key == IdRoleName) {
return ssRoleName;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApplicationRoleId.Key.AsGuid) {
return ssApplicationRoleId;
}
if (attributeKey == IdRoleName.Key.AsGuid) {
return ssRoleName;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ssRoleName = (string) other.AttributeGet(IdRoleName);
}
} // ST_9adff333942ff7120fc18c8e55f201fdStructure
/// <summary>
/// RecordList type <code>UserRoleList</code> that represents a record list of <code>UserRole</code>
/// </summary>
public partial class RL_da93b3cf8542f5b831efc106e94ee7e2 : GenericRecordList<ST_9adff333942ff7120fc18c8e55f201fdStructure>, IEnumerable, IEnumerator {

protected override ST_9adff333942ff7120fc18c8e55f201fdStructure GetElementDefaultValue() {
return new ST_9adff333942ff7120fc18c8e55f201fdStructure();
}

public T[] ToArray<T>(Func<ST_9adff333942ff7120fc18c8e55f201fdStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_da93b3cf8542f5b831efc106e94ee7e2 recordList, Func<ST_9adff333942ff7120fc18c8e55f201fdStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_da93b3cf8542f5b831efc106e94ee7e2(ST_9adff333942ff7120fc18c8e55f201fdStructure[] array) {
  RL_da93b3cf8542f5b831efc106e94ee7e2 result = new RL_da93b3cf8542f5b831efc106e94ee7e2();
result.InnerFromArray(array);
    return result;
}

public static RL_da93b3cf8542f5b831efc106e94ee7e2 ToList<T>(T[] array, Func <T, ST_9adff333942ff7120fc18c8e55f201fdStructure> converter) {
  RL_da93b3cf8542f5b831efc106e94ee7e2 result = new RL_da93b3cf8542f5b831efc106e94ee7e2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_da93b3cf8542f5b831efc106e94ee7e2 FromRestList<T>(RestList<T> restList, Func <T, ST_9adff333942ff7120fc18c8e55f201fdStructure> converter) {
  RL_da93b3cf8542f5b831efc106e94ee7e2 result = new RL_da93b3cf8542f5b831efc106e94ee7e2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_da93b3cf8542f5b831efc106e94ee7e2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9adff333942ff7120fc18c8e55f201fdStructure> NewList() {
return new RL_da93b3cf8542f5b831efc106e94ee7e2();
}


} // RL_da93b3cf8542f5b831efc106e94ee7e2
}

