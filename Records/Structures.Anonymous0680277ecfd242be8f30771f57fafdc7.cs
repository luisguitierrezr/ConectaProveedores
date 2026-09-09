namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (fieABtLPvkKPMHcfV_r9xw)
///  <code>RC_82a9276cec67a3d539884db9fd67d1e2</code> that represent
/// s <code>UserUserApplicationRoleApplicationRoleUser_Extended_InternalRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: UserUserApplicationRoleApplicationRoleUser_Extended_InternalRegionRecord
public partial struct RC_82a9276cec67a3d539884db9fd67d1e2 : ITypedRecord<RC_82a9276cec67a3d539884db9fd67d1e2> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bEGhRAtqexFrflFk+dUUfw");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_d70717a411b3cebe926da612400b1467EntityRecord ssENUserApplicationRole;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_82a9276cec67a3d539884db9fd67d1e2() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserApplicationRole = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserApplicationRole.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    ssENUser_Extended_Internal.OptimizedAttributes = value[3];
    ssENRegion.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserApplicationRole.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
    all[3] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[4] = ssENRegion.OptimizedAttributes;
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
ssENUser_Extended_Internal.Read( r, ref index);
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
public void ReadIM(RC_82a9276cec67a3d539884db9fd67d1e2 r) {
this = r;
}


public static bool operator == (RC_82a9276cec67a3d539884db9fd67d1e2 a, RC_82a9276cec67a3d539884db9fd67d1e2 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserApplicationRole != b.ssENUserApplicationRole) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_82a9276cec67a3d539884db9fd67d1e2 a, RC_82a9276cec67a3d539884db9fd67d1e2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_82a9276cec67a3d539884db9fd67d1e2)) return false;
return (this == (RC_82a9276cec67a3d539884db9fd67d1e2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserApplicationRole.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
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
ssENUser_Extended_Internal.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserApplicationRole.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_82a9276cec67a3d539884db9fd67d1e2 Duplicate() {
RC_82a9276cec67a3d539884db9fd67d1e2 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUserApplicationRole = (EN_d70717a411b3cebe926da612400b1467EntityRecord)this.ssENUserApplicationRole.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
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
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
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
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
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
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
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
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_82a9276cec67a3d539884db9fd67d1e2
/// <summary>
/// RecordList type
///  <code>UserUserApplicationRoleApplicationRoleUser_Extended_InternalRegionRecordList</code> tha
/// t represents a record list of <code>User, UserApplicationRole, ApplicationRole,
///  User_Extended_Internal, Region</code>
/// </summary>
public partial class RL_e8fb9c349f962da0bba19bd202a05712 : GenericRecordList<RC_82a9276cec67a3d539884db9fd67d1e2>, IEnumerable, IEnumerator {

protected override RC_82a9276cec67a3d539884db9fd67d1e2 GetElementDefaultValue() {
return new RC_82a9276cec67a3d539884db9fd67d1e2();
}

public T[] ToArray<T>(Func<RC_82a9276cec67a3d539884db9fd67d1e2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e8fb9c349f962da0bba19bd202a05712 recordList, Func<RC_82a9276cec67a3d539884db9fd67d1e2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e8fb9c349f962da0bba19bd202a05712(RC_82a9276cec67a3d539884db9fd67d1e2[] array) {
  RL_e8fb9c349f962da0bba19bd202a05712 result = new RL_e8fb9c349f962da0bba19bd202a05712();
result.InnerFromArray(array);
    return result;
}

public static RL_e8fb9c349f962da0bba19bd202a05712 ToList<T>(T[] array, Func <T, RC_82a9276cec67a3d539884db9fd67d1e2> converter) {
  RL_e8fb9c349f962da0bba19bd202a05712 result = new RL_e8fb9c349f962da0bba19bd202a05712();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e8fb9c349f962da0bba19bd202a05712 FromRestList<T>(RestList<T> restList, Func <T, RC_82a9276cec67a3d539884db9fd67d1e2> converter) {
  RL_e8fb9c349f962da0bba19bd202a05712 result = new RL_e8fb9c349f962da0bba19bd202a05712();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e8fb9c349f962da0bba19bd202a05712() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_82a9276cec67a3d539884db9fd67d1e2> NewList() {
return new RL_e8fb9c349f962da0bba19bd202a05712();
}


} // RL_e8fb9c349f962da0bba19bd202a05712
}

