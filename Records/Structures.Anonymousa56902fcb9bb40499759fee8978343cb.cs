namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (_AJppbu5SUCXWf7ol4NDyw)
///  <code>RC_cc1082e7aa3de11fcab84972ca526b53</code> that represent
/// s <code>UserRequisitionApprovalLevelRequisitionApprovalUser_Extended_InternalRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: UserRequisitionApprovalLevelRequisitionApprovalUser_Extended_InternalRecord
public partial struct RC_cc1082e7aa3de11fcab84972ca526b53 : ITypedRecord<RC_cc1082e7aa3de11fcab84972ca526b53> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_cc1082e7aa3de11fcab84972ca526b53() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(26,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[1];
    ssENRequisitionApproval.OptimizedAttributes = value[2];
    ssENUser_Extended_Internal.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[2] = ssENRequisitionApproval.OptimizedAttributes;
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
ssENRequisitionApprovalLevel.Read( r, ref index);
ssENRequisitionApproval.Read( r, ref index);
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
public void ReadIM(RC_cc1082e7aa3de11fcab84972ca526b53 r) {
this = r;
}


public static bool operator == (RC_cc1082e7aa3de11fcab84972ca526b53 a, RC_cc1082e7aa3de11fcab84972ca526b53 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_cc1082e7aa3de11fcab84972ca526b53 a, RC_cc1082e7aa3de11fcab84972ca526b53 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cc1082e7aa3de11fcab84972ca526b53)) return false;
return (this == (RC_cc1082e7aa3de11fcab84972ca526b53)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_cc1082e7aa3de11fcab84972ca526b53 Duplicate() {
RC_cc1082e7aa3de11fcab84972ca526b53 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
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
} else if (head == "requisitionapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevel")) variable.Value = ssENRequisitionApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("requisitionapprovallevel");
} else if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
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
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
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
if (attributeKey == IdRequisitionApprovalLevel.Key.AsGuid) {
return ssENRequisitionApprovalLevel;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_cc1082e7aa3de11fcab84972ca526b53
/// <summary>
/// RecordList type
///  <code>UserRequisitionApprovalLevelRequisitionApprovalUser_Extended_InternalRecordList</code> tha
/// t represents a record list of <code>User, RequisitionApprovalLevel, RequisitionApproval,
///  User_Extended_Internal</code>
/// </summary>
public partial class RL_eb5141ae4756079cd46e163eaf3b6446 : GenericRecordList<RC_cc1082e7aa3de11fcab84972ca526b53>, IEnumerable, IEnumerator {

protected override RC_cc1082e7aa3de11fcab84972ca526b53 GetElementDefaultValue() {
return new RC_cc1082e7aa3de11fcab84972ca526b53();
}

public T[] ToArray<T>(Func<RC_cc1082e7aa3de11fcab84972ca526b53, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eb5141ae4756079cd46e163eaf3b6446 recordList, Func<RC_cc1082e7aa3de11fcab84972ca526b53, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eb5141ae4756079cd46e163eaf3b6446(RC_cc1082e7aa3de11fcab84972ca526b53[] array) {
  RL_eb5141ae4756079cd46e163eaf3b6446 result = new RL_eb5141ae4756079cd46e163eaf3b6446();
result.InnerFromArray(array);
    return result;
}

public static RL_eb5141ae4756079cd46e163eaf3b6446 ToList<T>(T[] array, Func <T, RC_cc1082e7aa3de11fcab84972ca526b53> converter) {
  RL_eb5141ae4756079cd46e163eaf3b6446 result = new RL_eb5141ae4756079cd46e163eaf3b6446();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eb5141ae4756079cd46e163eaf3b6446 FromRestList<T>(RestList<T> restList, Func <T, RC_cc1082e7aa3de11fcab84972ca526b53> converter) {
  RL_eb5141ae4756079cd46e163eaf3b6446 result = new RL_eb5141ae4756079cd46e163eaf3b6446();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eb5141ae4756079cd46e163eaf3b6446() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(26,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cc1082e7aa3de11fcab84972ca526b53> NewList() {
return new RL_eb5141ae4756079cd46e163eaf3b6446();
}


} // RL_eb5141ae4756079cd46e163eaf3b6446
}

