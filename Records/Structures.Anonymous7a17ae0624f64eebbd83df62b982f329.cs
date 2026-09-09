namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Bq4XevYk6069g99iuYLzKQ)
///  <code>RC_284d6b812acb53aa55a28cbe2a22b4ca</code> that represent
/// s
///  <code>UserUser_AssignedByUser_RevokedApplicationRoleUserApplicationRoleTempRoleStatusRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: UserUser_AssignedByUser_RevokedApplicationRoleUserApplicationRoleTempRoleStatusRecord
public partial struct RC_284d6b812acb53aa55a28cbe2a22b4ca : ITypedRecord<RC_284d6b812acb53aa55a28cbe2a22b4ca> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUser_AssignedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FLnJtyG0MMzQ9EDXnztCeg");
internal static readonly GlobalObjectKey IdUser_Revoked = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hjInV3tGzYZvWw8H50Bq9g");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdUserApplicationRoleTemp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kn3GZlFuC4xnPZEZ9i2hkw");
internal static readonly GlobalObjectKey IdRoleStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*J2fH5uLau7Nex18I87+7IQ");

public ENUserEntityRecord ssENUser;

public ENUserEntityRecord ssENUser_AssignedBy;

public ENUserEntityRecord ssENUser_Revoked;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_20bdea9cf8f17569719f414a83b584b6EntityRecord ssENUserApplicationRoleTemp;

public EN_fee44a96be32c0c9f1bda470eac56718EntityRecord ssENRoleStatus;


public BitArray OptimizedAttributes;

public RC_284d6b812acb53aa55a28cbe2a22b4ca() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUser_AssignedBy = new ENUserEntityRecord();
ssENUser_Revoked = new ENUserEntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENUserApplicationRoleTemp = new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
ssENRoleStatus = new EN_fee44a96be32c0c9f1bda470eac56718EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(5,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(14,false);
    all[5] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_AssignedBy.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUser_Revoked.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENUserApplicationRoleTemp.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRoleStatus.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUser_AssignedBy.OptimizedAttributes = value[1];
    ssENUser_Revoked.OptimizedAttributes = value[2];
    ssENApplicationRole.OptimizedAttributes = value[3];
    ssENUserApplicationRoleTemp.OptimizedAttributes = value[4];
    ssENRoleStatus.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUser_AssignedBy.OptimizedAttributes;
    all[2] = ssENUser_Revoked.OptimizedAttributes;
    all[3] = ssENApplicationRole.OptimizedAttributes;
    all[4] = ssENUserApplicationRoleTemp.OptimizedAttributes;
    all[5] = ssENRoleStatus.OptimizedAttributes;
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
ssENUser_AssignedBy.Read( r, ref index);
ssENUser_Revoked.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssENUserApplicationRoleTemp.Read( r, ref index);
ssENRoleStatus.Read( r, ref index);
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
public void ReadIM(RC_284d6b812acb53aa55a28cbe2a22b4ca r) {
this = r;
}


public static bool operator == (RC_284d6b812acb53aa55a28cbe2a22b4ca a, RC_284d6b812acb53aa55a28cbe2a22b4ca b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUser_AssignedBy != b.ssENUser_AssignedBy) return false;
if (a.ssENUser_Revoked != b.ssENUser_Revoked) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENUserApplicationRoleTemp != b.ssENUserApplicationRoleTemp) return false;
if (a.ssENRoleStatus != b.ssENRoleStatus) return false;
return true;
}

public static bool operator != (RC_284d6b812acb53aa55a28cbe2a22b4ca a, RC_284d6b812acb53aa55a28cbe2a22b4ca b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_284d6b812acb53aa55a28cbe2a22b4ca)) return false;
return (this == (RC_284d6b812acb53aa55a28cbe2a22b4ca)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUser_AssignedBy.GetHashCode()
 ^ ssENUser_Revoked.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENUserApplicationRoleTemp.GetHashCode()
 ^ ssENRoleStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUser_AssignedBy.RecursiveReset();
ssENUser_Revoked.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENUserApplicationRoleTemp.RecursiveReset();
ssENRoleStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUser_AssignedBy.InternalRecursiveSave();
ssENUser_Revoked.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENUserApplicationRoleTemp.InternalRecursiveSave();
ssENRoleStatus.InternalRecursiveSave();
}


public RC_284d6b812acb53aa55a28cbe2a22b4ca Duplicate() {
RC_284d6b812acb53aa55a28cbe2a22b4ca t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUser_AssignedBy = (ENUserEntityRecord)this.ssENUser_AssignedBy.Duplicate();
t.ssENUser_Revoked = (ENUserEntityRecord)this.ssENUser_Revoked.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssENUserApplicationRoleTemp = (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord)this.ssENUserApplicationRoleTemp.Duplicate();
t.ssENRoleStatus = (EN_fee44a96be32c0c9f1bda470eac56718EntityRecord)this.ssENRoleStatus.Duplicate();
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
} else if (head == "user_assignedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_AssignedBy")) variable.Value = ssENUser_AssignedBy; else variable.Optimized = true;
variable.SetFieldName("user_assignedby");
} else if (head == "user_revoked") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Revoked")) variable.Value = ssENUser_Revoked; else variable.Optimized = true;
variable.SetFieldName("user_revoked");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "userapplicationroletemp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRoleTemp")) variable.Value = ssENUserApplicationRoleTemp; else variable.Optimized = true;
variable.SetFieldName("userapplicationroletemp");
} else if (head == "rolestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleStatus")) variable.Value = ssENRoleStatus; else variable.Optimized = true;
variable.SetFieldName("rolestatus");
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
if (key == IdUser_AssignedBy) {
return ssENUser_AssignedBy;
}
if (key == IdUser_Revoked) {
return ssENUser_Revoked;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdUserApplicationRoleTemp) {
return ssENUserApplicationRoleTemp;
}
if (key == IdRoleStatus) {
return ssENRoleStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUser_AssignedBy.Key.AsGuid) {
return ssENUser_AssignedBy;
}
if (attributeKey == IdUser_Revoked.Key.AsGuid) {
return ssENUser_Revoked;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdUserApplicationRoleTemp.Key.AsGuid) {
return ssENUserApplicationRoleTemp;
}
if (attributeKey == IdRoleStatus.Key.AsGuid) {
return ssENRoleStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUser_AssignedBy.FillFromOther((IRecord) other.AttributeGet(IdUser_AssignedBy));
ssENUser_Revoked.FillFromOther((IRecord) other.AttributeGet(IdUser_Revoked));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENUserApplicationRoleTemp.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRoleTemp));
ssENRoleStatus.FillFromOther((IRecord) other.AttributeGet(IdRoleStatus));
}
} // RC_284d6b812acb53aa55a28cbe2a22b4ca
/// <summary>
/// RecordList type
///  <code>UserUser_AssignedByUser_RevokedApplicationRoleUserApplicationRoleTempRoleStatusRecordList</co
/// de> that represents a record list of <code>User, User, User, ApplicationRole,
///  UserApplicationRoleTemp, RoleStatus</code>
/// </summary>
public partial class RL_bb4d6e713cd7ffbd47871f2337312efa : GenericRecordList<RC_284d6b812acb53aa55a28cbe2a22b4ca>, IEnumerable, IEnumerator {

protected override RC_284d6b812acb53aa55a28cbe2a22b4ca GetElementDefaultValue() {
return new RC_284d6b812acb53aa55a28cbe2a22b4ca();
}

public T[] ToArray<T>(Func<RC_284d6b812acb53aa55a28cbe2a22b4ca, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bb4d6e713cd7ffbd47871f2337312efa recordList, Func<RC_284d6b812acb53aa55a28cbe2a22b4ca, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bb4d6e713cd7ffbd47871f2337312efa(RC_284d6b812acb53aa55a28cbe2a22b4ca[] array) {
  RL_bb4d6e713cd7ffbd47871f2337312efa result = new RL_bb4d6e713cd7ffbd47871f2337312efa();
result.InnerFromArray(array);
    return result;
}

public static RL_bb4d6e713cd7ffbd47871f2337312efa ToList<T>(T[] array, Func <T, RC_284d6b812acb53aa55a28cbe2a22b4ca> converter) {
  RL_bb4d6e713cd7ffbd47871f2337312efa result = new RL_bb4d6e713cd7ffbd47871f2337312efa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bb4d6e713cd7ffbd47871f2337312efa FromRestList<T>(RestList<T> restList, Func <T, RC_284d6b812acb53aa55a28cbe2a22b4ca> converter) {
  RL_bb4d6e713cd7ffbd47871f2337312efa result = new RL_bb4d6e713cd7ffbd47871f2337312efa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bb4d6e713cd7ffbd47871f2337312efa() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(5,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(14,false);
def[5] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_284d6b812acb53aa55a28cbe2a22b4ca> NewList() {
return new RL_bb4d6e713cd7ffbd47871f2337312efa();
}


} // RL_bb4d6e713cd7ffbd47871f2337312efa
}

