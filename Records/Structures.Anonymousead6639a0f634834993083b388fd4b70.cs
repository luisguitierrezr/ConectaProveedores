namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mmPW6mMPNEiZMIOziP1LcA)
///  <code>RC_c2921a936d592680b8275006015423c4</code> that represent
/// s <code>UserApplicationRoleApplicationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: UserApplicationRoleApplicationRoleRecord
public partial struct RC_c2921a936d592680b8275006015423c4 : ITypedRecord<RC_c2921a936d592680b8275006015423c4> {
internal static readonly GlobalObjectKey IdUserApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bEGhRAtqexFrflFk+dUUfw");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public EN_d70717a411b3cebe926da612400b1467EntityRecord ssENUserApplicationRole;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_c2921a936d592680b8275006015423c4() {
OptimizedAttributes = null;
ssENUserApplicationRole = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUserApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUserApplicationRole.OptimizedAttributes = value[0];
    ssENApplicationRole.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUserApplicationRole.OptimizedAttributes;
    all[1] = ssENApplicationRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUserApplicationRole.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
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
public void ReadIM(RC_c2921a936d592680b8275006015423c4 r) {
this = r;
}


public static bool operator == (RC_c2921a936d592680b8275006015423c4 a, RC_c2921a936d592680b8275006015423c4 b) {
if (a.ssENUserApplicationRole != b.ssENUserApplicationRole) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_c2921a936d592680b8275006015423c4 a, RC_c2921a936d592680b8275006015423c4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c2921a936d592680b8275006015423c4)) return false;
return (this == (RC_c2921a936d592680b8275006015423c4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUserApplicationRole.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUserApplicationRole.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUserApplicationRole.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_c2921a936d592680b8275006015423c4 Duplicate() {
RC_c2921a936d592680b8275006015423c4 t;
t.ssENUserApplicationRole = (EN_d70717a411b3cebe926da612400b1467EntityRecord)this.ssENUserApplicationRole.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
if (head == "userapplicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRole")) variable.Value = ssENUserApplicationRole; else variable.Optimized = true;
variable.SetFieldName("userapplicationrole");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
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
if (key == IdUserApplicationRole) {
return ssENUserApplicationRole;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserApplicationRole.Key.AsGuid) {
return ssENUserApplicationRole;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUserApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRole));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_c2921a936d592680b8275006015423c4
/// <summary>
/// RecordList type <code>UserApplicationRoleApplicationRoleRecordList</code> that represents a record
///  list of <code>UserApplicationRole, ApplicationRole</code>
/// </summary>
public partial class RL_6baa91071578818b75d38b8795012b73 : GenericRecordList<RC_c2921a936d592680b8275006015423c4>, IEnumerable, IEnumerator {

protected override RC_c2921a936d592680b8275006015423c4 GetElementDefaultValue() {
return new RC_c2921a936d592680b8275006015423c4();
}

public T[] ToArray<T>(Func<RC_c2921a936d592680b8275006015423c4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6baa91071578818b75d38b8795012b73 recordList, Func<RC_c2921a936d592680b8275006015423c4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6baa91071578818b75d38b8795012b73(RC_c2921a936d592680b8275006015423c4[] array) {
  RL_6baa91071578818b75d38b8795012b73 result = new RL_6baa91071578818b75d38b8795012b73();
result.InnerFromArray(array);
    return result;
}

public static RL_6baa91071578818b75d38b8795012b73 ToList<T>(T[] array, Func <T, RC_c2921a936d592680b8275006015423c4> converter) {
  RL_6baa91071578818b75d38b8795012b73 result = new RL_6baa91071578818b75d38b8795012b73();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6baa91071578818b75d38b8795012b73 FromRestList<T>(RestList<T> restList, Func <T, RC_c2921a936d592680b8275006015423c4> converter) {
  RL_6baa91071578818b75d38b8795012b73 result = new RL_6baa91071578818b75d38b8795012b73();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6baa91071578818b75d38b8795012b73() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(10,false);
def[1] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c2921a936d592680b8275006015423c4> NewList() {
return new RL_6baa91071578818b75d38b8795012b73();
}


} // RL_6baa91071578818b75d38b8795012b73
}

