namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (l8J7mBFKuUywlJe1jzEKGA)
///  <code>RC_aad5e0f2e56c05eeddd020d008f4b3d7</code> that represent
/// s <code>UserEntraRoleUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserEntraRoleUser_Extended_InternalRecord
public partial struct RC_aad5e0f2e56c05eeddd020d008f4b3d7 : ITypedRecord<RC_aad5e0f2e56c05eeddd020d008f4b3d7> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_aad5e0f2e56c05eeddd020d008f4b3d7() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENEntraRole.OptimizedAttributes = value[1];
    ssENUser_Extended_Internal.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENEntraRole.OptimizedAttributes;
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
ssENEntraRole.Read( r, ref index);
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
public void ReadIM(RC_aad5e0f2e56c05eeddd020d008f4b3d7 r) {
this = r;
}


public static bool operator == (RC_aad5e0f2e56c05eeddd020d008f4b3d7 a, RC_aad5e0f2e56c05eeddd020d008f4b3d7 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_aad5e0f2e56c05eeddd020d008f4b3d7 a, RC_aad5e0f2e56c05eeddd020d008f4b3d7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_aad5e0f2e56c05eeddd020d008f4b3d7)) return false;
return (this == (RC_aad5e0f2e56c05eeddd020d008f4b3d7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_aad5e0f2e56c05eeddd020d008f4b3d7 Duplicate() {
RC_aad5e0f2e56c05eeddd020d008f4b3d7 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
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
if (key == IdEntraRole) {
return ssENEntraRole;
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
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_aad5e0f2e56c05eeddd020d008f4b3d7
/// <summary>
/// RecordList type <code>UserEntraRoleUser_Extended_InternalRecordList</code> that represents a record
///  list of <code>User, EntraRole, User_Extended_Internal</code>
/// </summary>
public partial class RL_a37f5f153582e24adaea3ae8b54b3101 : GenericRecordList<RC_aad5e0f2e56c05eeddd020d008f4b3d7>, IEnumerable, IEnumerator {

protected override RC_aad5e0f2e56c05eeddd020d008f4b3d7 GetElementDefaultValue() {
return new RC_aad5e0f2e56c05eeddd020d008f4b3d7();
}

public T[] ToArray<T>(Func<RC_aad5e0f2e56c05eeddd020d008f4b3d7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a37f5f153582e24adaea3ae8b54b3101 recordList, Func<RC_aad5e0f2e56c05eeddd020d008f4b3d7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a37f5f153582e24adaea3ae8b54b3101(RC_aad5e0f2e56c05eeddd020d008f4b3d7[] array) {
  RL_a37f5f153582e24adaea3ae8b54b3101 result = new RL_a37f5f153582e24adaea3ae8b54b3101();
result.InnerFromArray(array);
    return result;
}

public static RL_a37f5f153582e24adaea3ae8b54b3101 ToList<T>(T[] array, Func <T, RC_aad5e0f2e56c05eeddd020d008f4b3d7> converter) {
  RL_a37f5f153582e24adaea3ae8b54b3101 result = new RL_a37f5f153582e24adaea3ae8b54b3101();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a37f5f153582e24adaea3ae8b54b3101 FromRestList<T>(RestList<T> restList, Func <T, RC_aad5e0f2e56c05eeddd020d008f4b3d7> converter) {
  RL_a37f5f153582e24adaea3ae8b54b3101 result = new RL_a37f5f153582e24adaea3ae8b54b3101();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a37f5f153582e24adaea3ae8b54b3101() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_aad5e0f2e56c05eeddd020d008f4b3d7> NewList() {
return new RL_a37f5f153582e24adaea3ae8b54b3101();
}


} // RL_a37f5f153582e24adaea3ae8b54b3101
}

