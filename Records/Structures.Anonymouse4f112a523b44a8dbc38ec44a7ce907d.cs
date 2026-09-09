namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pRLx5LQjjUq8OOxEp86QfQ)
///  <code>RC_d4fdf5fe986f15577c3a6610348f52f6</code> that represent
/// s <code>UserUserApplicationRoleUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUserApplicationRoleUser_Extended_InternalRecord
public partial struct RC_d4fdf5fe986f15577c3a6610348f52f6 : ITypedRecord<RC_d4fdf5fe986f15577c3a6610348f52f6> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bEGhRAtqexFrflFk+dUUfw");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_d70717a411b3cebe926da612400b1467EntityRecord ssENUserApplicationRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_d4fdf5fe986f15577c3a6610348f52f6() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserApplicationRole = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserApplicationRole.OptimizedAttributes = value[1];
    ssENUser_Extended_Internal.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserApplicationRole.OptimizedAttributes;
    all[2] = ssENUser_Extended_Internal.OptimizedAttributes;
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
public void ReadIM(RC_d4fdf5fe986f15577c3a6610348f52f6 r) {
this = r;
}


public static bool operator == (RC_d4fdf5fe986f15577c3a6610348f52f6 a, RC_d4fdf5fe986f15577c3a6610348f52f6 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserApplicationRole != b.ssENUserApplicationRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_d4fdf5fe986f15577c3a6610348f52f6 a, RC_d4fdf5fe986f15577c3a6610348f52f6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d4fdf5fe986f15577c3a6610348f52f6)) return false;
return (this == (RC_d4fdf5fe986f15577c3a6610348f52f6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserApplicationRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUserApplicationRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserApplicationRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_d4fdf5fe986f15577c3a6610348f52f6 Duplicate() {
RC_d4fdf5fe986f15577c3a6610348f52f6 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUserApplicationRole = (EN_d70717a411b3cebe926da612400b1467EntityRecord)this.ssENUserApplicationRole.Duplicate();
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
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUserApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_d4fdf5fe986f15577c3a6610348f52f6
/// <summary>
/// RecordList type <code>UserUserApplicationRoleUser_Extended_InternalRecordList</code> that
///  represents a record list of <code>User, UserApplicationRole, User_Extended_Internal</code>
/// </summary>
public partial class RL_edcb7e1d218607fc80645a6019e669d1 : GenericRecordList<RC_d4fdf5fe986f15577c3a6610348f52f6>, IEnumerable, IEnumerator {

protected override RC_d4fdf5fe986f15577c3a6610348f52f6 GetElementDefaultValue() {
return new RC_d4fdf5fe986f15577c3a6610348f52f6();
}

public T[] ToArray<T>(Func<RC_d4fdf5fe986f15577c3a6610348f52f6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_edcb7e1d218607fc80645a6019e669d1 recordList, Func<RC_d4fdf5fe986f15577c3a6610348f52f6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_edcb7e1d218607fc80645a6019e669d1(RC_d4fdf5fe986f15577c3a6610348f52f6[] array) {
  RL_edcb7e1d218607fc80645a6019e669d1 result = new RL_edcb7e1d218607fc80645a6019e669d1();
result.InnerFromArray(array);
    return result;
}

public static RL_edcb7e1d218607fc80645a6019e669d1 ToList<T>(T[] array, Func <T, RC_d4fdf5fe986f15577c3a6610348f52f6> converter) {
  RL_edcb7e1d218607fc80645a6019e669d1 result = new RL_edcb7e1d218607fc80645a6019e669d1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_edcb7e1d218607fc80645a6019e669d1 FromRestList<T>(RestList<T> restList, Func <T, RC_d4fdf5fe986f15577c3a6610348f52f6> converter) {
  RL_edcb7e1d218607fc80645a6019e669d1 result = new RL_edcb7e1d218607fc80645a6019e669d1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_edcb7e1d218607fc80645a6019e669d1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d4fdf5fe986f15577c3a6610348f52f6> NewList() {
return new RL_edcb7e1d218607fc80645a6019e669d1();
}


} // RL_edcb7e1d218607fc80645a6019e669d1
}

