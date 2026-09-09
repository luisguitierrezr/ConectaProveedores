namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Xw7JMTiM_Eeqf2Qig6aeDw)
///  <code>RC_9f188ad01e9c8bcb23bbc90643260885</code> that represent
/// s <code>UserUserApplicationRoleApplicationRoleUserExtensionUser_Extended_InternalRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: UserUserApplicationRoleApplicationRoleUserExtensionUser_Extended_InternalRecord
public partial struct RC_9f188ad01e9c8bcb23bbc90643260885 : ITypedRecord<RC_9f188ad01e9c8bcb23bbc90643260885> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bEGhRAtqexFrflFk+dUUfw");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_d70717a411b3cebe926da612400b1467EntityRecord ssENUserApplicationRole;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_9f188ad01e9c8bcb23bbc90643260885() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserApplicationRole = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(3,false);
    all[4] = new BitArray(20,false);
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
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserApplicationRole.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    ssENUserExtension.OptimizedAttributes = value[3];
    ssENUser_Extended_Internal.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserApplicationRole.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
    all[3] = ssENUserExtension.OptimizedAttributes;
    all[4] = ssENUser_Extended_Internal.OptimizedAttributes;
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
public void ReadIM(RC_9f188ad01e9c8bcb23bbc90643260885 r) {
this = r;
}


public static bool operator == (RC_9f188ad01e9c8bcb23bbc90643260885 a, RC_9f188ad01e9c8bcb23bbc90643260885 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserApplicationRole != b.ssENUserApplicationRole) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_9f188ad01e9c8bcb23bbc90643260885 a, RC_9f188ad01e9c8bcb23bbc90643260885 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9f188ad01e9c8bcb23bbc90643260885)) return false;
return (this == (RC_9f188ad01e9c8bcb23bbc90643260885)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserApplicationRole.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
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
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserApplicationRole.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_9f188ad01e9c8bcb23bbc90643260885 Duplicate() {
RC_9f188ad01e9c8bcb23bbc90643260885 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUserApplicationRole = (EN_d70717a411b3cebe926da612400b1467EntityRecord)this.ssENUserApplicationRole.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUserApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRole));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_9f188ad01e9c8bcb23bbc90643260885
/// <summary>
/// RecordList type
///  <code>UserUserApplicationRoleApplicationRoleUserExtensionUser_Extended_InternalRecordList</code
/// > that represents a record list of <code>User, UserApplicationRole, ApplicationRole, UserExtension,
///  User_Extended_Internal</code>
/// </summary>
public partial class RL_e636b7622ac541c8d20e097062759f2f : GenericRecordList<RC_9f188ad01e9c8bcb23bbc90643260885>, IEnumerable, IEnumerator {

protected override RC_9f188ad01e9c8bcb23bbc90643260885 GetElementDefaultValue() {
return new RC_9f188ad01e9c8bcb23bbc90643260885();
}

public T[] ToArray<T>(Func<RC_9f188ad01e9c8bcb23bbc90643260885, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e636b7622ac541c8d20e097062759f2f recordList, Func<RC_9f188ad01e9c8bcb23bbc90643260885, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e636b7622ac541c8d20e097062759f2f(RC_9f188ad01e9c8bcb23bbc90643260885[] array) {
  RL_e636b7622ac541c8d20e097062759f2f result = new RL_e636b7622ac541c8d20e097062759f2f();
result.InnerFromArray(array);
    return result;
}

public static RL_e636b7622ac541c8d20e097062759f2f ToList<T>(T[] array, Func <T, RC_9f188ad01e9c8bcb23bbc90643260885> converter) {
  RL_e636b7622ac541c8d20e097062759f2f result = new RL_e636b7622ac541c8d20e097062759f2f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e636b7622ac541c8d20e097062759f2f FromRestList<T>(RestList<T> restList, Func <T, RC_9f188ad01e9c8bcb23bbc90643260885> converter) {
  RL_e636b7622ac541c8d20e097062759f2f result = new RL_e636b7622ac541c8d20e097062759f2f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e636b7622ac541c8d20e097062759f2f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(3,false);
def[4] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9f188ad01e9c8bcb23bbc90643260885> NewList() {
return new RL_e636b7622ac541c8d20e097062759f2f();
}


} // RL_e636b7622ac541c8d20e097062759f2f
}

