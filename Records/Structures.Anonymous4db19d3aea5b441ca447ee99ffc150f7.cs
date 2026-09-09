namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Op2xTVvqHESkR+6Z_8FQ9w)
///  <code>RC_3435fb4b7e2feceb28dc5478c72a6c4b</code> that represent
/// s
///  <code>UserUserApplicationRoleApplicationRoleUserExtensionUser_Extended_InternalDepartmentRegionReco
/// rd</code> <p>Description: </p>
/// </summary>
// Name: UserUserApplicationRoleApplicationRoleUserExtensionUser_Extended_InternalDepartmentRegionRecord
public partial struct RC_3435fb4b7e2feceb28dc5478c72a6c4b : ITypedRecord<RC_3435fb4b7e2feceb28dc5478c72a6c4b> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bEGhRAtqexFrflFk+dUUfw");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IzSRoKR0M7PMRMnTx82Mqg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_d70717a411b3cebe926da612400b1467EntityRecord ssENUserApplicationRole;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ssENDepartment;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_3435fb4b7e2feceb28dc5478c72a6c4b() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserApplicationRole = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENDepartment = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(3,false);
    all[4] = new BitArray(20,false);
    all[5] = new BitArray(7,false);
    all[6] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENDepartment.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserApplicationRole.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    ssENUserExtension.OptimizedAttributes = value[3];
    ssENUser_Extended_Internal.OptimizedAttributes = value[4];
    ssENDepartment.OptimizedAttributes = value[5];
    ssENRegion.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserApplicationRole.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
    all[3] = ssENUserExtension.OptimizedAttributes;
    all[4] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[5] = ssENDepartment.OptimizedAttributes;
    all[6] = ssENRegion.OptimizedAttributes;
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
ssENUserApplicationRole.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssENUserExtension.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
ssENDepartment.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_3435fb4b7e2feceb28dc5478c72a6c4b r) {
this = r;
}


public static bool operator == (RC_3435fb4b7e2feceb28dc5478c72a6c4b a, RC_3435fb4b7e2feceb28dc5478c72a6c4b b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserApplicationRole != b.ssENUserApplicationRole) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENDepartment != b.ssENDepartment) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_3435fb4b7e2feceb28dc5478c72a6c4b a, RC_3435fb4b7e2feceb28dc5478c72a6c4b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3435fb4b7e2feceb28dc5478c72a6c4b)) return false;
return (this == (RC_3435fb4b7e2feceb28dc5478c72a6c4b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserApplicationRole.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENDepartment.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUserApplicationRole.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENDepartment.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserApplicationRole.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENDepartment.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_3435fb4b7e2feceb28dc5478c72a6c4b Duplicate() {
RC_3435fb4b7e2feceb28dc5478c72a6c4b t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUserApplicationRole = (EN_d70717a411b3cebe926da612400b1467EntityRecord)this.ssENUserApplicationRole.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENDepartment = (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)this.ssENDepartment.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "userapplicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRole")) variable.Value = ssENUserApplicationRole; else variable.Optimized = true;
variable.SetFieldName("userapplicationrole");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "userextension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserExtension")) variable.Value = ssENUserExtension; else variable.Optimized = true;
variable.SetFieldName("userextension");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "department") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssENDepartment; else variable.Optimized = true;
variable.SetFieldName("department");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdUserApplicationRole) {
return ssENUserApplicationRole;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdUserExtension) {
return ssENUserExtension;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdDepartment) {
return ssENDepartment;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUserApplicationRole.Key.AsGuid) {
return ssENUserApplicationRole;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdDepartment.Key.AsGuid) {
return ssENDepartment;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUserApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRole));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENDepartment.FillFromOther((IRecord) other.AttributeGet(IdDepartment));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_3435fb4b7e2feceb28dc5478c72a6c4b
/// <summary>
/// RecordList type
///  <code>UserUserApplicationRoleApplicationRoleUserExtensionUser_Extended_InternalDepartmentRegionReco
/// rdList</code> that represents a record list of <code>User, UserApplicationRole, ApplicationRole,
///  UserExtension, User_Extended_Internal, Department, Region</code>
/// </summary>
public partial class RL_8ded51402e95dd8f74345a43f441735c : GenericRecordList<RC_3435fb4b7e2feceb28dc5478c72a6c4b>, IEnumerable, IEnumerator {

protected override RC_3435fb4b7e2feceb28dc5478c72a6c4b GetElementDefaultValue() {
return new RC_3435fb4b7e2feceb28dc5478c72a6c4b();
}

public T[] ToArray<T>(Func<RC_3435fb4b7e2feceb28dc5478c72a6c4b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8ded51402e95dd8f74345a43f441735c recordList, Func<RC_3435fb4b7e2feceb28dc5478c72a6c4b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8ded51402e95dd8f74345a43f441735c(RC_3435fb4b7e2feceb28dc5478c72a6c4b[] array) {
  RL_8ded51402e95dd8f74345a43f441735c result = new RL_8ded51402e95dd8f74345a43f441735c();
result.InnerFromArray(array);
    return result;
}

public static RL_8ded51402e95dd8f74345a43f441735c ToList<T>(T[] array, Func <T, RC_3435fb4b7e2feceb28dc5478c72a6c4b> converter) {
  RL_8ded51402e95dd8f74345a43f441735c result = new RL_8ded51402e95dd8f74345a43f441735c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8ded51402e95dd8f74345a43f441735c FromRestList<T>(RestList<T> restList, Func <T, RC_3435fb4b7e2feceb28dc5478c72a6c4b> converter) {
  RL_8ded51402e95dd8f74345a43f441735c result = new RL_8ded51402e95dd8f74345a43f441735c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8ded51402e95dd8f74345a43f441735c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(3,false);
def[4] = new BitArray(20,false);
def[5] = new BitArray(7,false);
def[6] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3435fb4b7e2feceb28dc5478c72a6c4b> NewList() {
return new RL_8ded51402e95dd8f74345a43f441735c();
}


} // RL_8ded51402e95dd8f74345a43f441735c
}

