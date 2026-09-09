namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (fqzJ3_bcSkqDsl+7k2GVOg)
///  <code>RC_8e50aadd5c1e05d0be3f2d234221ec50</code> that represent
/// s <code>UserOrderApprovalOrderApprovalLevelUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserOrderApprovalOrderApprovalLevelUser_Extended_InternalRecord
public partial struct RC_8e50aadd5c1e05d0be3f2d234221ec50 : ITypedRecord<RC_8e50aadd5c1e05d0be3f2d234221ec50> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_8e50aadd5c1e05d0be3f2d234221ec50() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(17,false);
    all[3] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENOrderApproval.OptimizedAttributes = value[1];
    ssENOrderApprovalLevel.OptimizedAttributes = value[2];
    ssENUser_Extended_Internal.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENOrderApproval.OptimizedAttributes;
    all[2] = ssENOrderApprovalLevel.OptimizedAttributes;
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
ssENOrderApproval.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_8e50aadd5c1e05d0be3f2d234221ec50 r) {
this = r;
}


public static bool operator == (RC_8e50aadd5c1e05d0be3f2d234221ec50 a, RC_8e50aadd5c1e05d0be3f2d234221ec50 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_8e50aadd5c1e05d0be3f2d234221ec50 a, RC_8e50aadd5c1e05d0be3f2d234221ec50 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8e50aadd5c1e05d0be3f2d234221ec50)) return false;
return (this == (RC_8e50aadd5c1e05d0be3f2d234221ec50)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENOrderApproval.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENOrderApproval.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_8e50aadd5c1e05d0be3f2d234221ec50 Duplicate() {
RC_8e50aadd5c1e05d0be3f2d234221ec50 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
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
} else if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
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
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
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
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_8e50aadd5c1e05d0be3f2d234221ec50
/// <summary>
/// RecordList type <code>UserOrderApprovalOrderApprovalLevelUser_Extended_InternalRecordList</code>
///  that represents a record list of <code>User, OrderApproval, OrderApprovalLevel
/// , User_Extended_Internal</code>
/// </summary>
public partial class RL_a492f6700ed5395e4cd6d4e3942ae398 : GenericRecordList<RC_8e50aadd5c1e05d0be3f2d234221ec50>, IEnumerable, IEnumerator {

protected override RC_8e50aadd5c1e05d0be3f2d234221ec50 GetElementDefaultValue() {
return new RC_8e50aadd5c1e05d0be3f2d234221ec50();
}

public T[] ToArray<T>(Func<RC_8e50aadd5c1e05d0be3f2d234221ec50, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a492f6700ed5395e4cd6d4e3942ae398 recordList, Func<RC_8e50aadd5c1e05d0be3f2d234221ec50, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a492f6700ed5395e4cd6d4e3942ae398(RC_8e50aadd5c1e05d0be3f2d234221ec50[] array) {
  RL_a492f6700ed5395e4cd6d4e3942ae398 result = new RL_a492f6700ed5395e4cd6d4e3942ae398();
result.InnerFromArray(array);
    return result;
}

public static RL_a492f6700ed5395e4cd6d4e3942ae398 ToList<T>(T[] array, Func <T, RC_8e50aadd5c1e05d0be3f2d234221ec50> converter) {
  RL_a492f6700ed5395e4cd6d4e3942ae398 result = new RL_a492f6700ed5395e4cd6d4e3942ae398();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a492f6700ed5395e4cd6d4e3942ae398 FromRestList<T>(RestList<T> restList, Func <T, RC_8e50aadd5c1e05d0be3f2d234221ec50> converter) {
  RL_a492f6700ed5395e4cd6d4e3942ae398 result = new RL_a492f6700ed5395e4cd6d4e3942ae398();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a492f6700ed5395e4cd6d4e3942ae398() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(17,false);
def[3] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8e50aadd5c1e05d0be3f2d234221ec50> NewList() {
return new RL_a492f6700ed5395e4cd6d4e3942ae398();
}


} // RL_a492f6700ed5395e4cd6d4e3942ae398
}

