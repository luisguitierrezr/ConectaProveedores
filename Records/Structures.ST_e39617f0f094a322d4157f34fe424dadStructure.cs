namespace ssConectaProveedores {
/// <summary>
/// [Structure] UserRoleCode (v4Hymclu30afSfiIvHacBw)
///  <code>ST_e39617f0f094a322d4157f34fe424dadStructure</code> that represents <code>UserRoleCode</code
/// > <p>Description: User Role Struct for code.</p>
/// </summary>
// Name: UserRoleCode
public partial struct ST_e39617f0f094a322d4157f34fe424dadStructure : ITypedRecord<ST_e39617f0f094a322d4157f34fe424dadStructure> {
internal static readonly GlobalObjectKey IdApplicationRoleId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*m_1RPaWvckmxwRnzKcaHKA");
internal static readonly GlobalObjectKey IdRoleName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*f1zbab5bnkCY_3oY8CUKKQ");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*L+O7PBcZi0ae8btpIs5Qbw");
internal static readonly GlobalObjectKey IdIsSubstitute = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6bqk9uOZPEiz4p7iT6MAvw");

public long ssApplicationRoleId;

public string ssRoleName;

public string ssCode;

public bool ssIsSubstitute;


public BitArray OptimizedAttributes;

public ST_e39617f0f094a322d4157f34fe424dadStructure() {
OptimizedAttributes = null;
ssApplicationRoleId = 0L;
ssRoleName = "";
ssCode = "";
ssIsSubstitute = false;
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
ssApplicationRoleId = r.ReadEntityReferenceLongInteger(index++, "UserRoleCode.ApplicationRoleId", 0L);
ssRoleName = r.ReadText(index++, "UserRoleCode.RoleName", "");
ssCode = r.ReadText(index++, "UserRoleCode.Code", "");
ssIsSubstitute = r.ReadBoolean(index++, "UserRoleCode.IsSubstitute", false);
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
public void ReadIM(ST_e39617f0f094a322d4157f34fe424dadStructure r) {
this = r;
}


public static bool operator == (ST_e39617f0f094a322d4157f34fe424dadStructure a, ST_e39617f0f094a322d4157f34fe424dadStructure b) {
if (a.ssApplicationRoleId != b.ssApplicationRoleId) return false;
if (a.ssRoleName != b.ssRoleName) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssIsSubstitute != b.ssIsSubstitute) return false;
return true;
}

public static bool operator != (ST_e39617f0f094a322d4157f34fe424dadStructure a, ST_e39617f0f094a322d4157f34fe424dadStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e39617f0f094a322d4157f34fe424dadStructure)) return false;
return (this == (ST_e39617f0f094a322d4157f34fe424dadStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssApplicationRoleId.GetHashCode()
 ^ ssRoleName.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssIsSubstitute.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e39617f0f094a322d4157f34fe424dadStructure Duplicate() {
ST_e39617f0f094a322d4157f34fe424dadStructure t;
t.ssApplicationRoleId = this.ssApplicationRoleId;
t.ssRoleName = this.ssRoleName;
t.ssCode = this.ssCode;
t.ssIsSubstitute = this.ssIsSubstitute;
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
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "issubstitute") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSubstitute")) variable.Value = ssIsSubstitute; else variable.Optimized = true;
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
if (key == IdCode) {
return ssCode;
}
if (key == IdIsSubstitute) {
return ssIsSubstitute;
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
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdIsSubstitute.Key.AsGuid) {
return ssIsSubstitute;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssApplicationRoleId = (long) other.AttributeGet(IdApplicationRoleId);
ssRoleName = (string) other.AttributeGet(IdRoleName);
ssCode = (string) other.AttributeGet(IdCode);
ssIsSubstitute = (bool) other.AttributeGet(IdIsSubstitute);
}
} // ST_e39617f0f094a322d4157f34fe424dadStructure
/// <summary>
/// RecordList type <code>UserRoleCodeList</code> that represents a record list of
///  <code>UserRoleCode</code>
/// </summary>
public partial class RL_97ac86b141c7934fd96d3cf71793066e : GenericRecordList<ST_e39617f0f094a322d4157f34fe424dadStructure>, IEnumerable, IEnumerator {

protected override ST_e39617f0f094a322d4157f34fe424dadStructure GetElementDefaultValue() {
return new ST_e39617f0f094a322d4157f34fe424dadStructure();
}

public T[] ToArray<T>(Func<ST_e39617f0f094a322d4157f34fe424dadStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_97ac86b141c7934fd96d3cf71793066e recordList, Func<ST_e39617f0f094a322d4157f34fe424dadStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_97ac86b141c7934fd96d3cf71793066e(ST_e39617f0f094a322d4157f34fe424dadStructure[] array) {
  RL_97ac86b141c7934fd96d3cf71793066e result = new RL_97ac86b141c7934fd96d3cf71793066e();
result.InnerFromArray(array);
    return result;
}

public static RL_97ac86b141c7934fd96d3cf71793066e ToList<T>(T[] array, Func <T, ST_e39617f0f094a322d4157f34fe424dadStructure> converter) {
  RL_97ac86b141c7934fd96d3cf71793066e result = new RL_97ac86b141c7934fd96d3cf71793066e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_97ac86b141c7934fd96d3cf71793066e FromRestList<T>(RestList<T> restList, Func <T, ST_e39617f0f094a322d4157f34fe424dadStructure> converter) {
  RL_97ac86b141c7934fd96d3cf71793066e result = new RL_97ac86b141c7934fd96d3cf71793066e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_97ac86b141c7934fd96d3cf71793066e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e39617f0f094a322d4157f34fe424dadStructure> NewList() {
return new RL_97ac86b141c7934fd96d3cf71793066e();
}


} // RL_97ac86b141c7934fd96d3cf71793066e
}

