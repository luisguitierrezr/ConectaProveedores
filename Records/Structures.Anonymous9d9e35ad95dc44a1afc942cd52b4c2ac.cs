namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rTWendyVoUSvyULNUrTCrA)
///  <code>RC_a32d2d6effb998fa5a8e4b01f03a15ca</code> that represent
/// s <code>UserEntraRoleUser_Extended_InternalRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserEntraRoleUser_Extended_InternalRegionRecord
public partial struct RC_a32d2d6effb998fa5a8e4b01f03a15ca : ITypedRecord<RC_a32d2d6effb998fa5a8e4b01f03a15ca> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_a32d2d6effb998fa5a8e4b01f03a15ca() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENEntraRole.OptimizedAttributes = value[1];
    ssENUser_Extended_Internal.OptimizedAttributes = value[2];
    ssENRegion.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENEntraRole.OptimizedAttributes;
    all[2] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[3] = ssENRegion.OptimizedAttributes;
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
ssENEntraRole.Read( r, ref index);
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
public void ReadIM(RC_a32d2d6effb998fa5a8e4b01f03a15ca r) {
this = r;
}


public static bool operator == (RC_a32d2d6effb998fa5a8e4b01f03a15ca a, RC_a32d2d6effb998fa5a8e4b01f03a15ca b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_a32d2d6effb998fa5a8e4b01f03a15ca a, RC_a32d2d6effb998fa5a8e4b01f03a15ca b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a32d2d6effb998fa5a8e4b01f03a15ca)) return false;
return (this == (RC_a32d2d6effb998fa5a8e4b01f03a15ca)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_a32d2d6effb998fa5a8e4b01f03a15ca Duplicate() {
RC_a32d2d6effb998fa5a8e4b01f03a15ca t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
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
if (key == IdEntraRole) {
return ssENEntraRole;
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
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
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
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_a32d2d6effb998fa5a8e4b01f03a15ca
/// <summary>
/// RecordList type <code>UserEntraRoleUser_Extended_InternalRegionRecordList</code> that represents a
///  record list of <code>User, EntraRole, User_Extended_Internal, Region</code>
/// </summary>
public partial class RL_4c313dd08c2e051e0c0310a6d05109b0 : GenericRecordList<RC_a32d2d6effb998fa5a8e4b01f03a15ca>, IEnumerable, IEnumerator {

protected override RC_a32d2d6effb998fa5a8e4b01f03a15ca GetElementDefaultValue() {
return new RC_a32d2d6effb998fa5a8e4b01f03a15ca();
}

public T[] ToArray<T>(Func<RC_a32d2d6effb998fa5a8e4b01f03a15ca, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4c313dd08c2e051e0c0310a6d05109b0 recordList, Func<RC_a32d2d6effb998fa5a8e4b01f03a15ca, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4c313dd08c2e051e0c0310a6d05109b0(RC_a32d2d6effb998fa5a8e4b01f03a15ca[] array) {
  RL_4c313dd08c2e051e0c0310a6d05109b0 result = new RL_4c313dd08c2e051e0c0310a6d05109b0();
result.InnerFromArray(array);
    return result;
}

public static RL_4c313dd08c2e051e0c0310a6d05109b0 ToList<T>(T[] array, Func <T, RC_a32d2d6effb998fa5a8e4b01f03a15ca> converter) {
  RL_4c313dd08c2e051e0c0310a6d05109b0 result = new RL_4c313dd08c2e051e0c0310a6d05109b0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4c313dd08c2e051e0c0310a6d05109b0 FromRestList<T>(RestList<T> restList, Func <T, RC_a32d2d6effb998fa5a8e4b01f03a15ca> converter) {
  RL_4c313dd08c2e051e0c0310a6d05109b0 result = new RL_4c313dd08c2e051e0c0310a6d05109b0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4c313dd08c2e051e0c0310a6d05109b0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a32d2d6effb998fa5a8e4b01f03a15ca> NewList() {
return new RL_4c313dd08c2e051e0c0310a6d05109b0();
}


} // RL_4c313dd08c2e051e0c0310a6d05109b0
}

