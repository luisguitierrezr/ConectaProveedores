namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (QduFOLVAEkCAufHxzFoHBA)
///  <code>RC_8b89674084a8b334109c261c1cd156c4</code> that represent
/// s
///  <code>User_ApprovedUser_AssignedRequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionCo
/// mment_CancelRequisitionComment_ModifyApplicationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: User_ApprovedUser_AssignedRequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionComment_CancelRequisitionComment_ModifyApplicationRoleRecord
public partial struct RC_8b89674084a8b334109c261c1cd156c4 : ITypedRecord<RC_8b89674084a8b334109c261c1cd156c4> {
internal static readonly GlobalObjectKey IdUser_Approved = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*i+Lhj9jIQWOOlLyP_LMf_w");
internal static readonly GlobalObjectKey IdUser_Assigned = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CZjl_1p6AoxYi45ACvvWaw");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");
internal static readonly GlobalObjectKey IdRequisitionComment_Cancel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sPOfUCXHLLTMWeQJRmDblA");
internal static readonly GlobalObjectKey IdRequisitionComment_Modify = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gI5yZdNl027RuuM+0k85QQ");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public ENUserEntityRecord ssENUser_Approved;

public ENUserEntityRecord ssENUser_Assigned;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;

public EN_cbeb601b681344342c8de0161d058f87EntityRecord ssENRequisitionComment_Cancel;

public EN_cbeb601b681344342c8de0161d058f87EntityRecord ssENRequisitionComment_Modify;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_8b89674084a8b334109c261c1cd156c4() {
OptimizedAttributes = null;
ssENUser_Approved = new ENUserEntityRecord();
ssENUser_Assigned = new ENUserEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
ssENRequisitionComment_Cancel = new EN_cbeb601b681344342c8de0161d058f87EntityRecord();
ssENRequisitionComment_Modify = new EN_cbeb601b681344342c8de0161d058f87EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(26,false);
    all[4] = new BitArray(10,false);
    all[5] = new BitArray(8,false);
    all[6] = new BitArray(8,false);
    all[7] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Approved.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Assigned.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRequisitionComment_Cancel.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENRequisitionComment_Modify.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENUser_Approved.OptimizedAttributes = value[0];
    ssENUser_Assigned.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[3];
    ssENRequisitionApproval.OptimizedAttributes = value[4];
    ssENRequisitionComment_Cancel.OptimizedAttributes = value[5];
    ssENRequisitionComment_Modify.OptimizedAttributes = value[6];
    ssENApplicationRole.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENUser_Approved.OptimizedAttributes;
    all[1] = ssENUser_Assigned.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[4] = ssENRequisitionApproval.OptimizedAttributes;
    all[5] = ssENRequisitionComment_Cancel.OptimizedAttributes;
    all[6] = ssENRequisitionComment_Modify.OptimizedAttributes;
    all[7] = ssENApplicationRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser_Approved.Read( r, ref index);
ssENUser_Assigned.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENRequisitionApprovalLevel.Read( r, ref index);
ssENRequisitionApproval.Read( r, ref index);
ssENRequisitionComment_Cancel.Read( r, ref index);
ssENRequisitionComment_Modify.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
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
public void ReadIM(RC_8b89674084a8b334109c261c1cd156c4 r) {
this = r;
}


public static bool operator == (RC_8b89674084a8b334109c261c1cd156c4 a, RC_8b89674084a8b334109c261c1cd156c4 b) {
if (a.ssENUser_Approved != b.ssENUser_Approved) return false;
if (a.ssENUser_Assigned != b.ssENUser_Assigned) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
if (a.ssENRequisitionComment_Cancel != b.ssENRequisitionComment_Cancel) return false;
if (a.ssENRequisitionComment_Modify != b.ssENRequisitionComment_Modify) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_8b89674084a8b334109c261c1cd156c4 a, RC_8b89674084a8b334109c261c1cd156c4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8b89674084a8b334109c261c1cd156c4)) return false;
return (this == (RC_8b89674084a8b334109c261c1cd156c4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Approved.GetHashCode()
 ^ ssENUser_Assigned.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
 ^ ssENRequisitionComment_Cancel.GetHashCode()
 ^ ssENRequisitionComment_Modify.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_Approved.RecursiveReset();
ssENUser_Assigned.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
ssENRequisitionComment_Cancel.RecursiveReset();
ssENRequisitionComment_Modify.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Approved.InternalRecursiveSave();
ssENUser_Assigned.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
ssENRequisitionComment_Cancel.InternalRecursiveSave();
ssENRequisitionComment_Modify.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_8b89674084a8b334109c261c1cd156c4 Duplicate() {
RC_8b89674084a8b334109c261c1cd156c4 t;
t.ssENUser_Approved = (ENUserEntityRecord)this.ssENUser_Approved.Duplicate();
t.ssENUser_Assigned = (ENUserEntityRecord)this.ssENUser_Assigned.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
t.ssENRequisitionComment_Cancel = (EN_cbeb601b681344342c8de0161d058f87EntityRecord)this.ssENRequisitionComment_Cancel.Duplicate();
t.ssENRequisitionComment_Modify = (EN_cbeb601b681344342c8de0161d058f87EntityRecord)this.ssENRequisitionComment_Modify.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
if (head == "user_approved") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Approved")) variable.Value = ssENUser_Approved; else variable.Optimized = true;
variable.SetFieldName("user_approved");
} else if (head == "user_assigned") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Assigned")) variable.Value = ssENUser_Assigned; else variable.Optimized = true;
variable.SetFieldName("user_assigned");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevel")) variable.Value = ssENRequisitionApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("requisitionapprovallevel");
} else if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
} else if (head == "requisitioncomment_cancel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionComment_Cancel")) variable.Value = ssENRequisitionComment_Cancel; else variable.Optimized = true;
variable.SetFieldName("requisitioncomment_cancel");
} else if (head == "requisitioncomment_modify") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionComment_Modify")) variable.Value = ssENRequisitionComment_Modify; else variable.Optimized = true;
variable.SetFieldName("requisitioncomment_modify");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
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
if (key == IdUser_Approved) {
return ssENUser_Approved;
}
if (key == IdUser_Assigned) {
return ssENUser_Assigned;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
if (key == IdRequisitionComment_Cancel) {
return ssENRequisitionComment_Cancel;
}
if (key == IdRequisitionComment_Modify) {
return ssENRequisitionComment_Modify;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_Approved.Key.AsGuid) {
return ssENUser_Approved;
}
if (attributeKey == IdUser_Assigned.Key.AsGuid) {
return ssENUser_Assigned;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionApprovalLevel.Key.AsGuid) {
return ssENRequisitionApprovalLevel;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
if (attributeKey == IdRequisitionComment_Cancel.Key.AsGuid) {
return ssENRequisitionComment_Cancel;
}
if (attributeKey == IdRequisitionComment_Modify.Key.AsGuid) {
return ssENRequisitionComment_Modify;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_Approved.FillFromOther((IRecord) other.AttributeGet(IdUser_Approved));
ssENUser_Assigned.FillFromOther((IRecord) other.AttributeGet(IdUser_Assigned));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
ssENRequisitionComment_Cancel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionComment_Cancel));
ssENRequisitionComment_Modify.FillFromOther((IRecord) other.AttributeGet(IdRequisitionComment_Modify));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_8b89674084a8b334109c261c1cd156c4
/// <summary>
/// RecordList type
///  <code>User_ApprovedUser_AssignedRequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionCo
/// mment_CancelRequisitionComment_ModifyApplicationRoleRecordList</code> that represents a record list
///  of <code>User, User, Requisition, RequisitionApprovalLevel, RequisitionApproval
/// , RequisitionComment, RequisitionComment, ApplicationRole</code>
/// </summary>
public partial class RL_7c4c6843d8ddca100085fd31262966c6 : GenericRecordList<RC_8b89674084a8b334109c261c1cd156c4>, IEnumerable, IEnumerator {

protected override RC_8b89674084a8b334109c261c1cd156c4 GetElementDefaultValue() {
return new RC_8b89674084a8b334109c261c1cd156c4();
}

public T[] ToArray<T>(Func<RC_8b89674084a8b334109c261c1cd156c4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7c4c6843d8ddca100085fd31262966c6 recordList, Func<RC_8b89674084a8b334109c261c1cd156c4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7c4c6843d8ddca100085fd31262966c6(RC_8b89674084a8b334109c261c1cd156c4[] array) {
  RL_7c4c6843d8ddca100085fd31262966c6 result = new RL_7c4c6843d8ddca100085fd31262966c6();
result.InnerFromArray(array);
    return result;
}

public static RL_7c4c6843d8ddca100085fd31262966c6 ToList<T>(T[] array, Func <T, RC_8b89674084a8b334109c261c1cd156c4> converter) {
  RL_7c4c6843d8ddca100085fd31262966c6 result = new RL_7c4c6843d8ddca100085fd31262966c6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7c4c6843d8ddca100085fd31262966c6 FromRestList<T>(RestList<T> restList, Func <T, RC_8b89674084a8b334109c261c1cd156c4> converter) {
  RL_7c4c6843d8ddca100085fd31262966c6 result = new RL_7c4c6843d8ddca100085fd31262966c6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7c4c6843d8ddca100085fd31262966c6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(26,false);
def[4] = new BitArray(10,false);
def[5] = new BitArray(8,false);
def[6] = new BitArray(8,false);
def[7] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8b89674084a8b334109c261c1cd156c4> NewList() {
return new RL_7c4c6843d8ddca100085fd31262966c6();
}


} // RL_7c4c6843d8ddca100085fd31262966c6
}

