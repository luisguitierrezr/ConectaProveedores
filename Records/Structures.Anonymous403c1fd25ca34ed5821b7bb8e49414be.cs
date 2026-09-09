namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0h88QKNc1U6CG3u45JQUvg)
///  <code>RC_6d4a92ad9e5239e9c12dd070f5b17d69</code> that represent
/// s <code>UserRoleConceptApplicationRoleEntraRoleUser_Extended_InternalRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: UserRoleConceptApplicationRoleEntraRoleUser_Extended_InternalRegionRecord
public partial struct RC_6d4a92ad9e5239e9c12dd070f5b17d69 : ITypedRecord<RC_6d4a92ad9e5239e9c12dd070f5b17d69> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdRoleConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ibfwUXfv1rTUACc3+2O7uQ");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord ssENRoleConcept;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_6d4a92ad9e5239e9c12dd070f5b17d69() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENRoleConcept = new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(4,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(20,false);
    all[5] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRoleConcept.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENRoleConcept.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    ssENEntraRole.OptimizedAttributes = value[3];
    ssENUser_Extended_Internal.OptimizedAttributes = value[4];
    ssENRegion.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENRoleConcept.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
    all[3] = ssENEntraRole.OptimizedAttributes;
    all[4] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[5] = ssENRegion.OptimizedAttributes;
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
public void ReadIM(RC_6d4a92ad9e5239e9c12dd070f5b17d69 r) {
this = r;
}


public static bool operator == (RC_6d4a92ad9e5239e9c12dd070f5b17d69 a, RC_6d4a92ad9e5239e9c12dd070f5b17d69 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENRoleConcept != b.ssENRoleConcept) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_6d4a92ad9e5239e9c12dd070f5b17d69 a, RC_6d4a92ad9e5239e9c12dd070f5b17d69 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6d4a92ad9e5239e9c12dd070f5b17d69)) return false;
return (this == (RC_6d4a92ad9e5239e9c12dd070f5b17d69)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENRoleConcept.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
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
ssENRoleConcept.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENRoleConcept.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_6d4a92ad9e5239e9c12dd070f5b17d69 Duplicate() {
RC_6d4a92ad9e5239e9c12dd070f5b17d69 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENRoleConcept = (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord)this.ssENRoleConcept.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
} else if (head == "roleconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleConcept")) variable.Value = ssENRoleConcept; else variable.Optimized = true;
variable.SetFieldName("roleconcept");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
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
if (key == IdRoleConcept) {
return ssENRoleConcept;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
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
if (attributeKey == IdRoleConcept.Key.AsGuid) {
return ssENRoleConcept;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
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
ssENRoleConcept.FillFromOther((IRecord) other.AttributeGet(IdRoleConcept));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_6d4a92ad9e5239e9c12dd070f5b17d69
/// <summary>
/// RecordList type
///  <code>UserRoleConceptApplicationRoleEntraRoleUser_Extended_InternalRegionRecordList</code> tha
/// t represents a record list of <code>User, RoleConcept, ApplicationRole, EntraRole,
///  User_Extended_Internal, Region</code>
/// </summary>
public partial class RL_721bdfcca4a4edbce82baece8dfe837b : GenericRecordList<RC_6d4a92ad9e5239e9c12dd070f5b17d69>, IEnumerable, IEnumerator {

protected override RC_6d4a92ad9e5239e9c12dd070f5b17d69 GetElementDefaultValue() {
return new RC_6d4a92ad9e5239e9c12dd070f5b17d69();
}

public T[] ToArray<T>(Func<RC_6d4a92ad9e5239e9c12dd070f5b17d69, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_721bdfcca4a4edbce82baece8dfe837b recordList, Func<RC_6d4a92ad9e5239e9c12dd070f5b17d69, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_721bdfcca4a4edbce82baece8dfe837b(RC_6d4a92ad9e5239e9c12dd070f5b17d69[] array) {
  RL_721bdfcca4a4edbce82baece8dfe837b result = new RL_721bdfcca4a4edbce82baece8dfe837b();
result.InnerFromArray(array);
    return result;
}

public static RL_721bdfcca4a4edbce82baece8dfe837b ToList<T>(T[] array, Func <T, RC_6d4a92ad9e5239e9c12dd070f5b17d69> converter) {
  RL_721bdfcca4a4edbce82baece8dfe837b result = new RL_721bdfcca4a4edbce82baece8dfe837b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_721bdfcca4a4edbce82baece8dfe837b FromRestList<T>(RestList<T> restList, Func <T, RC_6d4a92ad9e5239e9c12dd070f5b17d69> converter) {
  RL_721bdfcca4a4edbce82baece8dfe837b result = new RL_721bdfcca4a4edbce82baece8dfe837b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_721bdfcca4a4edbce82baece8dfe837b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(5,false);
def[1] = new BitArray(4,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(20,false);
def[5] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6d4a92ad9e5239e9c12dd070f5b17d69> NewList() {
return new RL_721bdfcca4a4edbce82baece8dfe837b();
}


} // RL_721bdfcca4a4edbce82baece8dfe837b
}

