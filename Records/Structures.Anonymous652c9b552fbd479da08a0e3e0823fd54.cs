namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (VZssZb0vnUegig4+CCP9VA)
///  <code>RC_24dd7a73eff50484286a3caaeb8033d4</code> that represent
/// s
///  <code>UserRequisitionRequisitionApprovalLevelRequisitionApprovalApplicationRoleDoNotEntraSearchUser
/// ExtensionUser_Extended_InternalRecord</code> <p>Description: </p>
/// </summary>
// Name: UserRequisitionRequisitionApprovalLevelRequisitionApprovalApplicationRoleDoNotEntraSearchUserExtensionUser_Extended_InternalRecord
public partial struct RC_24dd7a73eff50484286a3caaeb8033d4 : ITypedRecord<RC_24dd7a73eff50484286a3caaeb8033d4> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdDoNotEntraSearch = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vlwPJZ6SSI7IrTMO_y0IIg");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");

public ENUserEntityRecord ssENUser;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public bool ssDoNotEntraSearch;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;


public BitArray OptimizedAttributes;

public RC_24dd7a73eff50484286a3caaeb8033d4() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssDoNotEntraSearch = false;
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(26,false);
    all[3] = new BitArray(10,false);
    all[4] = new BitArray(7,false);
    all[5] = new BitArray(3,false);
    all[6] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[2];
    ssENRequisitionApproval.OptimizedAttributes = value[3];
    ssENApplicationRole.OptimizedAttributes = value[4];
    ssENUserExtension.OptimizedAttributes = value[5];
    ssENUser_Extended_Internal.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[3] = ssENRequisitionApproval.OptimizedAttributes;
    all[4] = ssENApplicationRole.OptimizedAttributes;
    all[5] = ssENUserExtension.OptimizedAttributes;
    all[6] = ssENUser_Extended_Internal.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENRequisitionApprovalLevel.Read( r, ref index);
ssENRequisitionApproval.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssDoNotEntraSearch = r.ReadBoolean(index++, "UserRequisitionRequisitionApprovalLevelRequisitionApprovalApplicationRoleDoNotEntraSearchUserExtensionUser_Extended_InternalRecord.DoNotEntraSearch", false);
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
public void ReadIM(RC_24dd7a73eff50484286a3caaeb8033d4 r) {
this = r;
}


public static bool operator == (RC_24dd7a73eff50484286a3caaeb8033d4 a, RC_24dd7a73eff50484286a3caaeb8033d4 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssDoNotEntraSearch != b.ssDoNotEntraSearch) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
return true;
}

public static bool operator != (RC_24dd7a73eff50484286a3caaeb8033d4 a, RC_24dd7a73eff50484286a3caaeb8033d4 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_24dd7a73eff50484286a3caaeb8033d4)) return false;
return (this == (RC_24dd7a73eff50484286a3caaeb8033d4)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssDoNotEntraSearch.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
}


public RC_24dd7a73eff50484286a3caaeb8033d4 Duplicate() {
RC_24dd7a73eff50484286a3caaeb8033d4 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssDoNotEntraSearch = this.ssDoNotEntraSearch;
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevel")) variable.Value = ssENRequisitionApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("requisitionapprovallevel");
} else if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "donotentrasearch") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DoNotEntraSearch")) variable.Value = ssDoNotEntraSearch; else variable.Optimized = true;
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdDoNotEntraSearch) {
return ssDoNotEntraSearch;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionApprovalLevel.Key.AsGuid) {
return ssENRequisitionApprovalLevel;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdDoNotEntraSearch.Key.AsGuid) {
return ssDoNotEntraSearch;
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
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssDoNotEntraSearch = (bool) other.AttributeGet(IdDoNotEntraSearch);
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
}
} // RC_24dd7a73eff50484286a3caaeb8033d4
/// <summary>
/// RecordList type
///  <code>UserRequisitionRequisitionApprovalLevelRequisitionApprovalApplicationRoleDoNotEntraSearchUser
/// ExtensionUser_Extended_InternalRecordList</code> that represents a record list of <code>User,
///  Requisition, RequisitionApprovalLevel, RequisitionApproval, ApplicationRole, Boolean
/// , UserExtension, User_Extended_Internal</code>
/// </summary>
public partial class RL_f3017756521ae7cf1942cba9952a490e : GenericRecordList<RC_24dd7a73eff50484286a3caaeb8033d4>, IEnumerable, IEnumerator {

protected override RC_24dd7a73eff50484286a3caaeb8033d4 GetElementDefaultValue() {
return new RC_24dd7a73eff50484286a3caaeb8033d4();
}

public T[] ToArray<T>(Func<RC_24dd7a73eff50484286a3caaeb8033d4, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f3017756521ae7cf1942cba9952a490e recordList, Func<RC_24dd7a73eff50484286a3caaeb8033d4, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f3017756521ae7cf1942cba9952a490e(RC_24dd7a73eff50484286a3caaeb8033d4[] array) {
  RL_f3017756521ae7cf1942cba9952a490e result = new RL_f3017756521ae7cf1942cba9952a490e();
result.InnerFromArray(array);
    return result;
}

public static RL_f3017756521ae7cf1942cba9952a490e ToList<T>(T[] array, Func <T, RC_24dd7a73eff50484286a3caaeb8033d4> converter) {
  RL_f3017756521ae7cf1942cba9952a490e result = new RL_f3017756521ae7cf1942cba9952a490e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f3017756521ae7cf1942cba9952a490e FromRestList<T>(RestList<T> restList, Func <T, RC_24dd7a73eff50484286a3caaeb8033d4> converter) {
  RL_f3017756521ae7cf1942cba9952a490e result = new RL_f3017756521ae7cf1942cba9952a490e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f3017756521ae7cf1942cba9952a490e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(5,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(26,false);
def[3] = new BitArray(10,false);
def[4] = new BitArray(7,false);
def[5] = new BitArray(3,false);
def[6] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_24dd7a73eff50484286a3caaeb8033d4> NewList() {
return new RL_f3017756521ae7cf1942cba9952a490e();
}


} // RL_f3017756521ae7cf1942cba9952a490e
}

