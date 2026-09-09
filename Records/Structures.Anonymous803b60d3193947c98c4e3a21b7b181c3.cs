namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (02A7gDkZyUeMTjoht7GBww)
///  <code>RC_d95078dcb8f428bf6873002913f3165e</code> that represent
/// s <code>UserOrderApprovalOrderApprovalLevelEntraRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: UserOrderApprovalOrderApprovalLevelEntraRoleRecord
public partial struct RC_d95078dcb8f428bf6873002913f3165e : ITypedRecord<RC_d95078dcb8f428bf6873002913f3165e> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");

public ENUserEntityRecord ssENUser;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;


public BitArray OptimizedAttributes;

public RC_d95078dcb8f428bf6873002913f3165e() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(17,false);
    all[3] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENOrderApproval.OptimizedAttributes = value[1];
    ssENOrderApprovalLevel.OptimizedAttributes = value[2];
    ssENEntraRole.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENOrderApproval.OptimizedAttributes;
    all[2] = ssENOrderApprovalLevel.OptimizedAttributes;
    all[3] = ssENEntraRole.OptimizedAttributes;
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
ssENOrderApproval.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
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
public void ReadIM(RC_d95078dcb8f428bf6873002913f3165e r) {
this = r;
}


public static bool operator == (RC_d95078dcb8f428bf6873002913f3165e a, RC_d95078dcb8f428bf6873002913f3165e b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
return true;
}

public static bool operator != (RC_d95078dcb8f428bf6873002913f3165e a, RC_d95078dcb8f428bf6873002913f3165e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d95078dcb8f428bf6873002913f3165e)) return false;
return (this == (RC_d95078dcb8f428bf6873002913f3165e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENOrderApproval.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssENEntraRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENOrderApproval.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
}


public RC_d95078dcb8f428bf6873002913f3165e Duplicate() {
RC_d95078dcb8f428bf6873002913f3165e t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
} else if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
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
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
}
} // RC_d95078dcb8f428bf6873002913f3165e
/// <summary>
/// RecordList type <code>UserOrderApprovalOrderApprovalLevelEntraRoleRecordList</code> that represents
///  a record list of <code>User, OrderApproval, OrderApprovalLevel, EntraRole</code>
/// </summary>
public partial class RL_8f94456a098435a6d91415089487edb3 : GenericRecordList<RC_d95078dcb8f428bf6873002913f3165e>, IEnumerable, IEnumerator {

protected override RC_d95078dcb8f428bf6873002913f3165e GetElementDefaultValue() {
return new RC_d95078dcb8f428bf6873002913f3165e();
}

public T[] ToArray<T>(Func<RC_d95078dcb8f428bf6873002913f3165e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8f94456a098435a6d91415089487edb3 recordList, Func<RC_d95078dcb8f428bf6873002913f3165e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8f94456a098435a6d91415089487edb3(RC_d95078dcb8f428bf6873002913f3165e[] array) {
  RL_8f94456a098435a6d91415089487edb3 result = new RL_8f94456a098435a6d91415089487edb3();
result.InnerFromArray(array);
    return result;
}

public static RL_8f94456a098435a6d91415089487edb3 ToList<T>(T[] array, Func <T, RC_d95078dcb8f428bf6873002913f3165e> converter) {
  RL_8f94456a098435a6d91415089487edb3 result = new RL_8f94456a098435a6d91415089487edb3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8f94456a098435a6d91415089487edb3 FromRestList<T>(RestList<T> restList, Func <T, RC_d95078dcb8f428bf6873002913f3165e> converter) {
  RL_8f94456a098435a6d91415089487edb3 result = new RL_8f94456a098435a6d91415089487edb3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8f94456a098435a6d91415089487edb3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(17,false);
def[3] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d95078dcb8f428bf6873002913f3165e> NewList() {
return new RL_8f94456a098435a6d91415089487edb3();
}


} // RL_8f94456a098435a6d91415089487edb3
}

