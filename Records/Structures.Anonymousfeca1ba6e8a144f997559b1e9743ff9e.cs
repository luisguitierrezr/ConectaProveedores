namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (phvK_qHo+USXVZsel0P_ng)
///  <code>RC_eecf597d9aac604956ae34e0eea91058</code> that represent
/// s <code>UserFolioApprovalFolioApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: UserFolioApprovalFolioApprovalLevelRecord
public partial struct RC_eecf597d9aac604956ae34e0eea91058 : ITypedRecord<RC_eecf597d9aac604956ae34e0eea91058> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");

public ENUserEntityRecord ssENUser;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;


public BitArray OptimizedAttributes;

public RC_eecf597d9aac604956ae34e0eea91058() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENFolioApproval.OptimizedAttributes = value[1];
    ssENFolioApprovalLevel.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENFolioApproval.OptimizedAttributes;
    all[2] = ssENFolioApprovalLevel.OptimizedAttributes;
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
public void ReadIM(RC_eecf597d9aac604956ae34e0eea91058 r) {
this = r;
}


public static bool operator == (RC_eecf597d9aac604956ae34e0eea91058 a, RC_eecf597d9aac604956ae34e0eea91058 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
return true;
}

public static bool operator != (RC_eecf597d9aac604956ae34e0eea91058 a, RC_eecf597d9aac604956ae34e0eea91058 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_eecf597d9aac604956ae34e0eea91058)) return false;
return (this == (RC_eecf597d9aac604956ae34e0eea91058)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENFolioApproval.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
}


public RC_eecf597d9aac604956ae34e0eea91058 Duplicate() {
RC_eecf597d9aac604956ae34e0eea91058 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
}
} // RC_eecf597d9aac604956ae34e0eea91058
/// <summary>
/// RecordList type <code>UserFolioApprovalFolioApprovalLevelRecordList</code> that represents a record
///  list of <code>User, FolioApproval, FolioApprovalLevel</code>
/// </summary>
public partial class RL_22c684c9a7250fc07aca158787cc388d : GenericRecordList<RC_eecf597d9aac604956ae34e0eea91058>, IEnumerable, IEnumerator {

protected override RC_eecf597d9aac604956ae34e0eea91058 GetElementDefaultValue() {
return new RC_eecf597d9aac604956ae34e0eea91058();
}

public T[] ToArray<T>(Func<RC_eecf597d9aac604956ae34e0eea91058, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_22c684c9a7250fc07aca158787cc388d recordList, Func<RC_eecf597d9aac604956ae34e0eea91058, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_22c684c9a7250fc07aca158787cc388d(RC_eecf597d9aac604956ae34e0eea91058[] array) {
  RL_22c684c9a7250fc07aca158787cc388d result = new RL_22c684c9a7250fc07aca158787cc388d();
result.InnerFromArray(array);
    return result;
}

public static RL_22c684c9a7250fc07aca158787cc388d ToList<T>(T[] array, Func <T, RC_eecf597d9aac604956ae34e0eea91058> converter) {
  RL_22c684c9a7250fc07aca158787cc388d result = new RL_22c684c9a7250fc07aca158787cc388d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_22c684c9a7250fc07aca158787cc388d FromRestList<T>(RestList<T> restList, Func <T, RC_eecf597d9aac604956ae34e0eea91058> converter) {
  RL_22c684c9a7250fc07aca158787cc388d result = new RL_22c684c9a7250fc07aca158787cc388d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_22c684c9a7250fc07aca158787cc388d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_eecf597d9aac604956ae34e0eea91058> NewList() {
return new RL_22c684c9a7250fc07aca158787cc388d();
}


} // RL_22c684c9a7250fc07aca158787cc388d
}

