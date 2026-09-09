namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (vbSL0+UZyESQxol7Lr01LQ)
///  <code>RC_79713d00f72f3f42333169ab2740c159</code> that represent
/// s <code>UserUserApplicationRoleApplicationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUserApplicationRoleApplicationRoleRecord
public partial struct RC_79713d00f72f3f42333169ab2740c159 : ITypedRecord<RC_79713d00f72f3f42333169ab2740c159> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bEGhRAtqexFrflFk+dUUfw");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public ENUserEntityRecord ssENUser;

public EN_d70717a411b3cebe926da612400b1467EntityRecord ssENUserApplicationRole;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_79713d00f72f3f42333169ab2740c159() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserApplicationRole = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserApplicationRole.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserApplicationRole.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
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
public void ReadIM(RC_79713d00f72f3f42333169ab2740c159 r) {
this = r;
}


public static bool operator == (RC_79713d00f72f3f42333169ab2740c159 a, RC_79713d00f72f3f42333169ab2740c159 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserApplicationRole != b.ssENUserApplicationRole) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_79713d00f72f3f42333169ab2740c159 a, RC_79713d00f72f3f42333169ab2740c159 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_79713d00f72f3f42333169ab2740c159)) return false;
return (this == (RC_79713d00f72f3f42333169ab2740c159)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserApplicationRole.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUserApplicationRole.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserApplicationRole.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_79713d00f72f3f42333169ab2740c159 Duplicate() {
RC_79713d00f72f3f42333169ab2740c159 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "userapplicationrole") {
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdUserApplicationRole) {
return ssENUserApplicationRole;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUserApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRole));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_79713d00f72f3f42333169ab2740c159
/// <summary>
/// RecordList type <code>UserUserApplicationRoleApplicationRoleRecordList</code> that represents a
///  record list of <code>User, UserApplicationRole, ApplicationRole</code>
/// </summary>
public partial class RL_4fa77389273008bca2f5b798260e9dfd : GenericRecordList<RC_79713d00f72f3f42333169ab2740c159>, IEnumerable, IEnumerator {

protected override RC_79713d00f72f3f42333169ab2740c159 GetElementDefaultValue() {
return new RC_79713d00f72f3f42333169ab2740c159();
}

public T[] ToArray<T>(Func<RC_79713d00f72f3f42333169ab2740c159, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4fa77389273008bca2f5b798260e9dfd recordList, Func<RC_79713d00f72f3f42333169ab2740c159, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4fa77389273008bca2f5b798260e9dfd(RC_79713d00f72f3f42333169ab2740c159[] array) {
  RL_4fa77389273008bca2f5b798260e9dfd result = new RL_4fa77389273008bca2f5b798260e9dfd();
result.InnerFromArray(array);
    return result;
}

public static RL_4fa77389273008bca2f5b798260e9dfd ToList<T>(T[] array, Func <T, RC_79713d00f72f3f42333169ab2740c159> converter) {
  RL_4fa77389273008bca2f5b798260e9dfd result = new RL_4fa77389273008bca2f5b798260e9dfd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4fa77389273008bca2f5b798260e9dfd FromRestList<T>(RestList<T> restList, Func <T, RC_79713d00f72f3f42333169ab2740c159> converter) {
  RL_4fa77389273008bca2f5b798260e9dfd result = new RL_4fa77389273008bca2f5b798260e9dfd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4fa77389273008bca2f5b798260e9dfd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_79713d00f72f3f42333169ab2740c159> NewList() {
return new RL_4fa77389273008bca2f5b798260e9dfd();
}


} // RL_4fa77389273008bca2f5b798260e9dfd
}

