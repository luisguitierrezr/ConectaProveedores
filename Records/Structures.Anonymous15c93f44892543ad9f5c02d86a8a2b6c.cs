namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (RD_JFSWJrUOfXALYaoorbA)
///  <code>RC_87cc7367398744031899074e30b93bba</code> that represent
/// s <code>RoleConceptApplicationRoleEntraRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: RoleConceptApplicationRoleEntraRoleRecord
public partial struct RC_87cc7367398744031899074e30b93bba : ITypedRecord<RC_87cc7367398744031899074e30b93bba> {
internal static readonly GlobalObjectKey IdRoleConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ibfwUXfv1rTUACc3+2O7uQ");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");

public EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord ssENRoleConcept;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;


public BitArray OptimizedAttributes;

public RC_87cc7367398744031899074e30b93bba() {
OptimizedAttributes = null;
ssENRoleConcept = new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(4,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRoleConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENRoleConcept.OptimizedAttributes = value[0];
    ssENApplicationRole.OptimizedAttributes = value[1];
    ssENEntraRole.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENRoleConcept.OptimizedAttributes;
    all[1] = ssENApplicationRole.OptimizedAttributes;
    all[2] = ssENEntraRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRoleConcept.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
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
public void ReadIM(RC_87cc7367398744031899074e30b93bba r) {
this = r;
}


public static bool operator == (RC_87cc7367398744031899074e30b93bba a, RC_87cc7367398744031899074e30b93bba b) {
if (a.ssENRoleConcept != b.ssENRoleConcept) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
return true;
}

public static bool operator != (RC_87cc7367398744031899074e30b93bba a, RC_87cc7367398744031899074e30b93bba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_87cc7367398744031899074e30b93bba)) return false;
return (this == (RC_87cc7367398744031899074e30b93bba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRoleConcept.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRoleConcept.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENEntraRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRoleConcept.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
}


public RC_87cc7367398744031899074e30b93bba Duplicate() {
RC_87cc7367398744031899074e30b93bba t;
t.ssENRoleConcept = (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord)this.ssENRoleConcept.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
if (head == "roleconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleConcept")) variable.Value = ssENRoleConcept; else variable.Optimized = true;
variable.SetFieldName("roleconcept");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
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
if (key == IdRoleConcept) {
return ssENRoleConcept;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRoleConcept.Key.AsGuid) {
return ssENRoleConcept;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRoleConcept.FillFromOther((IRecord) other.AttributeGet(IdRoleConcept));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
}
} // RC_87cc7367398744031899074e30b93bba
/// <summary>
/// RecordList type <code>RoleConceptApplicationRoleEntraRoleRecordList</code> that represents a record
///  list of <code>RoleConcept, ApplicationRole, EntraRole</code>
/// </summary>
public partial class RL_a65d948725cf27ee989fa5314cba00e4 : GenericRecordList<RC_87cc7367398744031899074e30b93bba>, IEnumerable, IEnumerator {

protected override RC_87cc7367398744031899074e30b93bba GetElementDefaultValue() {
return new RC_87cc7367398744031899074e30b93bba();
}

public T[] ToArray<T>(Func<RC_87cc7367398744031899074e30b93bba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a65d948725cf27ee989fa5314cba00e4 recordList, Func<RC_87cc7367398744031899074e30b93bba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a65d948725cf27ee989fa5314cba00e4(RC_87cc7367398744031899074e30b93bba[] array) {
  RL_a65d948725cf27ee989fa5314cba00e4 result = new RL_a65d948725cf27ee989fa5314cba00e4();
result.InnerFromArray(array);
    return result;
}

public static RL_a65d948725cf27ee989fa5314cba00e4 ToList<T>(T[] array, Func <T, RC_87cc7367398744031899074e30b93bba> converter) {
  RL_a65d948725cf27ee989fa5314cba00e4 result = new RL_a65d948725cf27ee989fa5314cba00e4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a65d948725cf27ee989fa5314cba00e4 FromRestList<T>(RestList<T> restList, Func <T, RC_87cc7367398744031899074e30b93bba> converter) {
  RL_a65d948725cf27ee989fa5314cba00e4 result = new RL_a65d948725cf27ee989fa5314cba00e4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a65d948725cf27ee989fa5314cba00e4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(4,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_87cc7367398744031899074e30b93bba> NewList() {
return new RL_a65d948725cf27ee989fa5314cba00e4();
}


} // RL_a65d948725cf27ee989fa5314cba00e4
}

