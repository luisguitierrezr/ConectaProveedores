namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (K9DCDBmfg0KipwO4aC93HQ)
///  <code>RC_77956dae907db5f208e8a848dc366336</code> that represent
/// s <code>UserEntraRoleUserExtensionUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserEntraRoleUserExtensionUser_Extended_InternalRecord
public partial struct RC_77956dae907db5f208e8a848dc366336 : ITypedRecord<RC_77956dae907db5f208e8a848dc366336> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_77956dae907db5f208e8a848dc366336() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(3,false);
    all[3] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENEntraRole.OptimizedAttributes = value[1];
    ssENUserExtension.OptimizedAttributes = value[2];
    ssENUser_Extended_Internal.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENEntraRole.OptimizedAttributes;
    all[2] = ssENUserExtension.OptimizedAttributes;
    all[3] = ssENUser_Extended_Internal.OptimizedAttributes;
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
public void ReadIM(RC_77956dae907db5f208e8a848dc366336 r) {
this = r;
}


public static bool operator == (RC_77956dae907db5f208e8a848dc366336 a, RC_77956dae907db5f208e8a848dc366336 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_77956dae907db5f208e8a848dc366336 a, RC_77956dae907db5f208e8a848dc366336 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_77956dae907db5f208e8a848dc366336)) return false;
return (this == (RC_77956dae907db5f208e8a848dc366336)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_77956dae907db5f208e8a848dc366336 Duplicate() {
RC_77956dae907db5f208e8a848dc366336 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
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
if (key == IdEntraRole) {
return ssENEntraRole;
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
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
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
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_77956dae907db5f208e8a848dc366336
/// <summary>
/// RecordList type <code>UserEntraRoleUserExtensionUser_Extended_InternalRecordList</code> that
///  represents a record list of <code>User, EntraRole, UserExtension, User_Extended_Internal</code>
/// </summary>
public partial class RL_f518d708e7bb15a03a65b75b9f603096 : GenericRecordList<RC_77956dae907db5f208e8a848dc366336>, IEnumerable, IEnumerator {

protected override RC_77956dae907db5f208e8a848dc366336 GetElementDefaultValue() {
return new RC_77956dae907db5f208e8a848dc366336();
}

public T[] ToArray<T>(Func<RC_77956dae907db5f208e8a848dc366336, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f518d708e7bb15a03a65b75b9f603096 recordList, Func<RC_77956dae907db5f208e8a848dc366336, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f518d708e7bb15a03a65b75b9f603096(RC_77956dae907db5f208e8a848dc366336[] array) {
  RL_f518d708e7bb15a03a65b75b9f603096 result = new RL_f518d708e7bb15a03a65b75b9f603096();
result.InnerFromArray(array);
    return result;
}

public static RL_f518d708e7bb15a03a65b75b9f603096 ToList<T>(T[] array, Func <T, RC_77956dae907db5f208e8a848dc366336> converter) {
  RL_f518d708e7bb15a03a65b75b9f603096 result = new RL_f518d708e7bb15a03a65b75b9f603096();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f518d708e7bb15a03a65b75b9f603096 FromRestList<T>(RestList<T> restList, Func <T, RC_77956dae907db5f208e8a848dc366336> converter) {
  RL_f518d708e7bb15a03a65b75b9f603096 result = new RL_f518d708e7bb15a03a65b75b9f603096();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f518d708e7bb15a03a65b75b9f603096() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(3,false);
def[3] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_77956dae907db5f208e8a848dc366336> NewList() {
return new RL_f518d708e7bb15a03a65b75b9f603096();
}


} // RL_f518d708e7bb15a03a65b75b9f603096
}

