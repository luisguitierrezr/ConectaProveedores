namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (RNPxOcboK0edCboVWiEE0g)
///  <code>RC_d41d580f2f54d1ea8dfa839824757d81</code> that represent
/// s <code>UserFolioApprovalFolioApprovalLevelEntraRoleUser_Extended_InternalRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: UserFolioApprovalFolioApprovalLevelEntraRoleUser_Extended_InternalRecord
public partial struct RC_d41d580f2f54d1ea8dfa839824757d81 : ITypedRecord<RC_d41d580f2f54d1ea8dfa839824757d81> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_d41d580f2f54d1ea8dfa839824757d81() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENFolioApproval.OptimizedAttributes = value[1];
    ssENFolioApprovalLevel.OptimizedAttributes = value[2];
    ssENEntraRole.OptimizedAttributes = value[3];
    ssENUser_Extended_Internal.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENFolioApproval.OptimizedAttributes;
    all[2] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[3] = ssENEntraRole.OptimizedAttributes;
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
ssENFolioApproval.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_d41d580f2f54d1ea8dfa839824757d81 r) {
this = r;
}


public static bool operator == (RC_d41d580f2f54d1ea8dfa839824757d81 a, RC_d41d580f2f54d1ea8dfa839824757d81 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_d41d580f2f54d1ea8dfa839824757d81 a, RC_d41d580f2f54d1ea8dfa839824757d81 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d41d580f2f54d1ea8dfa839824757d81)) return false;
return (this == (RC_d41d580f2f54d1ea8dfa839824757d81)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENFolioApproval.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_d41d580f2f54d1ea8dfa839824757d81 Duplicate() {
RC_d41d580f2f54d1ea8dfa839824757d81 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
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
} else if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
} else if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
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
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
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
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
if (attributeKey == IdFolioApprovalLevel.Key.AsGuid) {
return ssENFolioApprovalLevel;
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
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_d41d580f2f54d1ea8dfa839824757d81
/// <summary>
/// RecordList type
///  <code>UserFolioApprovalFolioApprovalLevelEntraRoleUser_Extended_InternalRecordList</code> tha
/// t represents a record list of <code>User, FolioApproval, FolioApprovalLevel, EntraRole,
///  User_Extended_Internal</code>
/// </summary>
public partial class RL_c4a88225f641d9bcf04728601a4668b7 : GenericRecordList<RC_d41d580f2f54d1ea8dfa839824757d81>, IEnumerable, IEnumerator {

protected override RC_d41d580f2f54d1ea8dfa839824757d81 GetElementDefaultValue() {
return new RC_d41d580f2f54d1ea8dfa839824757d81();
}

public T[] ToArray<T>(Func<RC_d41d580f2f54d1ea8dfa839824757d81, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c4a88225f641d9bcf04728601a4668b7 recordList, Func<RC_d41d580f2f54d1ea8dfa839824757d81, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c4a88225f641d9bcf04728601a4668b7(RC_d41d580f2f54d1ea8dfa839824757d81[] array) {
  RL_c4a88225f641d9bcf04728601a4668b7 result = new RL_c4a88225f641d9bcf04728601a4668b7();
result.InnerFromArray(array);
    return result;
}

public static RL_c4a88225f641d9bcf04728601a4668b7 ToList<T>(T[] array, Func <T, RC_d41d580f2f54d1ea8dfa839824757d81> converter) {
  RL_c4a88225f641d9bcf04728601a4668b7 result = new RL_c4a88225f641d9bcf04728601a4668b7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c4a88225f641d9bcf04728601a4668b7 FromRestList<T>(RestList<T> restList, Func <T, RC_d41d580f2f54d1ea8dfa839824757d81> converter) {
  RL_c4a88225f641d9bcf04728601a4668b7 result = new RL_c4a88225f641d9bcf04728601a4668b7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c4a88225f641d9bcf04728601a4668b7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d41d580f2f54d1ea8dfa839824757d81> NewList() {
return new RL_c4a88225f641d9bcf04728601a4668b7();
}


} // RL_c4a88225f641d9bcf04728601a4668b7
}

