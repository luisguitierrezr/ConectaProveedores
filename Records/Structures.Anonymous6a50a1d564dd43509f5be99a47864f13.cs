namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (1aFQat1kUEOfW+maR4ZPEw)
///  <code>RC_7bfa75f5202ddb9627a7dd8185c0c12b</code> that represents <code>UserRoleRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserRoleRecord
public partial struct RC_7bfa75f5202ddb9627a7dd8185c0c12b : ITypedRecord<RC_7bfa75f5202ddb9627a7dd8185c0c12b> {
internal static readonly GlobalObjectKey IdUserRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9XX6ey0gltsnp92BhcDBKw");

public ST_9adff333942ff7120fc18c8e55f201fdStructure ssSTUserRole;


public static implicit operator ST_9adff333942ff7120fc18c8e55f201fdStructure( RC_7bfa75f5202ddb9627a7dd8185c0c12b r) {
return r.ssSTUserRole;
}

public static implicit operator RC_7bfa75f5202ddb9627a7dd8185c0c12b (ST_9adff333942ff7120fc18c8e55f201fdStructure r) {
RC_7bfa75f5202ddb9627a7dd8185c0c12b res = new RC_7bfa75f5202ddb9627a7dd8185c0c12b ();
res.ssSTUserRole = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7bfa75f5202ddb9627a7dd8185c0c12b() {
OptimizedAttributes = null;
ssSTUserRole = new ST_9adff333942ff7120fc18c8e55f201fdStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTUserRole.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTUserRole.Read( r, ref index);
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
public void ReadIM(RC_7bfa75f5202ddb9627a7dd8185c0c12b r) {
this = r;
}


public static bool operator == (RC_7bfa75f5202ddb9627a7dd8185c0c12b a, RC_7bfa75f5202ddb9627a7dd8185c0c12b b) {
if (a.ssSTUserRole != b.ssSTUserRole) return false;
return true;
}

public static bool operator != (RC_7bfa75f5202ddb9627a7dd8185c0c12b a, RC_7bfa75f5202ddb9627a7dd8185c0c12b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7bfa75f5202ddb9627a7dd8185c0c12b)) return false;
return (this == (RC_7bfa75f5202ddb9627a7dd8185c0c12b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTUserRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTUserRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTUserRole.InternalRecursiveSave();
}


public RC_7bfa75f5202ddb9627a7dd8185c0c12b Duplicate() {
RC_7bfa75f5202ddb9627a7dd8185c0c12b t;
t.ssSTUserRole = (ST_9adff333942ff7120fc18c8e55f201fdStructure)this.ssSTUserRole.Duplicate();
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
if (head == "userrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserRole")) variable.Value = ssSTUserRole; else variable.Optimized = true;
variable.SetFieldName("userrole");
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
if (key == IdUserRole) {
return ssSTUserRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserRole.Key.AsGuid) {
return ssSTUserRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTUserRole.FillFromOther((IRecord) other.AttributeGet(IdUserRole));
}
} // RC_7bfa75f5202ddb9627a7dd8185c0c12b
/// <summary>
/// RecordList type <code>UserRoleRecordList</code> that represents a record list of
///  <code>UserRole</code>
/// </summary>
public partial class RL_d70d60310c194f7f5b4377c60b208de6 : GenericRecordList<RC_7bfa75f5202ddb9627a7dd8185c0c12b>, IEnumerable, IEnumerator {

protected override RC_7bfa75f5202ddb9627a7dd8185c0c12b GetElementDefaultValue() {
return new RC_7bfa75f5202ddb9627a7dd8185c0c12b();
}

public T[] ToArray<T>(Func<RC_7bfa75f5202ddb9627a7dd8185c0c12b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d70d60310c194f7f5b4377c60b208de6 recordList, Func<RC_7bfa75f5202ddb9627a7dd8185c0c12b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d70d60310c194f7f5b4377c60b208de6(RC_7bfa75f5202ddb9627a7dd8185c0c12b[] array) {
  RL_d70d60310c194f7f5b4377c60b208de6 result = new RL_d70d60310c194f7f5b4377c60b208de6();
result.InnerFromArray(array);
    return result;
}

public static RL_d70d60310c194f7f5b4377c60b208de6 ToList<T>(T[] array, Func <T, RC_7bfa75f5202ddb9627a7dd8185c0c12b> converter) {
  RL_d70d60310c194f7f5b4377c60b208de6 result = new RL_d70d60310c194f7f5b4377c60b208de6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d70d60310c194f7f5b4377c60b208de6 FromRestList<T>(RestList<T> restList, Func <T, RC_7bfa75f5202ddb9627a7dd8185c0c12b> converter) {
  RL_d70d60310c194f7f5b4377c60b208de6 result = new RL_d70d60310c194f7f5b4377c60b208de6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d70d60310c194f7f5b4377c60b208de6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7bfa75f5202ddb9627a7dd8185c0c12b> NewList() {
return new RL_d70d60310c194f7f5b4377c60b208de6();
}


} // RL_d70d60310c194f7f5b4377c60b208de6
}

