namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (_6qcR5+DWUG4rmELxCfIKw)
///  <code>RC_6783422774b4547f1160d86529102520</code> that represent
/// s <code>UserRoleConceptApplicationRoleEntraRoleUserExtensionUser_Extended_InternalRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: UserRoleConceptApplicationRoleEntraRoleUserExtensionUser_Extended_InternalRecord
public partial struct RC_6783422774b4547f1160d86529102520 : ITypedRecord<RC_6783422774b4547f1160d86529102520> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdRoleConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ibfwUXfv1rTUACc3+2O7uQ");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord ssENRoleConcept;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_6783422774b4547f1160d86529102520() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENRoleConcept = new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(4,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(3,false);
    all[5] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRoleConcept.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENRoleConcept.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    ssENEntraRole.OptimizedAttributes = value[3];
    ssENUserExtension.OptimizedAttributes = value[4];
    ssENUser_Extended_Internal.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENRoleConcept.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
    all[3] = ssENEntraRole.OptimizedAttributes;
    all[4] = ssENUserExtension.OptimizedAttributes;
    all[5] = ssENUser_Extended_Internal.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENRoleConcept.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
ssENUserExtension.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
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
public void ReadIM(RC_6783422774b4547f1160d86529102520 r) {
this = r;
}


public static bool operator == (RC_6783422774b4547f1160d86529102520 a, RC_6783422774b4547f1160d86529102520 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENRoleConcept != b.ssENRoleConcept) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_6783422774b4547f1160d86529102520 a, RC_6783422774b4547f1160d86529102520 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6783422774b4547f1160d86529102520)) return false;
return (this == (RC_6783422774b4547f1160d86529102520)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENRoleConcept.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENRoleConcept.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENRoleConcept.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_6783422774b4547f1160d86529102520 Duplicate() {
RC_6783422774b4547f1160d86529102520 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENRoleConcept = (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord)this.ssENRoleConcept.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "roleconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleConcept")) variable.Value = ssENRoleConcept; else variable.Optimized = true;
variable.SetFieldName("roleconcept");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
} else if (head == "userextension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserExtension")) variable.Value = ssENUserExtension; else variable.Optimized = true;
variable.SetFieldName("userextension");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdRoleConcept) {
return ssENRoleConcept;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
if (key == IdUserExtension) {
return ssENUserExtension;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdRoleConcept.Key.AsGuid) {
return ssENRoleConcept;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENRoleConcept.FillFromOther((IRecord) other.AttributeGet(IdRoleConcept));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_6783422774b4547f1160d86529102520
/// <summary>
/// RecordList type
///  <code>UserRoleConceptApplicationRoleEntraRoleUserExtensionUser_Extended_InternalRecordList</code
/// > that represents a record list of <code>User, RoleConcept, ApplicationRole, EntraRole,
///  UserExtension, User_Extended_Internal</code>
/// </summary>
public partial class RL_3a99147a5a14669e8ced82dd9eebacf0 : GenericRecordList<RC_6783422774b4547f1160d86529102520>, IEnumerable, IEnumerator {

protected override RC_6783422774b4547f1160d86529102520 GetElementDefaultValue() {
return new RC_6783422774b4547f1160d86529102520();
}

public T[] ToArray<T>(Func<RC_6783422774b4547f1160d86529102520, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3a99147a5a14669e8ced82dd9eebacf0 recordList, Func<RC_6783422774b4547f1160d86529102520, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3a99147a5a14669e8ced82dd9eebacf0(RC_6783422774b4547f1160d86529102520[] array) {
  RL_3a99147a5a14669e8ced82dd9eebacf0 result = new RL_3a99147a5a14669e8ced82dd9eebacf0();
result.InnerFromArray(array);
    return result;
}

public static RL_3a99147a5a14669e8ced82dd9eebacf0 ToList<T>(T[] array, Func <T, RC_6783422774b4547f1160d86529102520> converter) {
  RL_3a99147a5a14669e8ced82dd9eebacf0 result = new RL_3a99147a5a14669e8ced82dd9eebacf0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3a99147a5a14669e8ced82dd9eebacf0 FromRestList<T>(RestList<T> restList, Func <T, RC_6783422774b4547f1160d86529102520> converter) {
  RL_3a99147a5a14669e8ced82dd9eebacf0 result = new RL_3a99147a5a14669e8ced82dd9eebacf0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3a99147a5a14669e8ced82dd9eebacf0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(5,false);
def[1] = new BitArray(4,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(3,false);
def[5] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6783422774b4547f1160d86529102520> NewList() {
return new RL_3a99147a5a14669e8ced82dd9eebacf0();
}


} // RL_3a99147a5a14669e8ced82dd9eebacf0
}

