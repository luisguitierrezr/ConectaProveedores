namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (bbBwvc0uyUa7DyY36Bup7w)
///  <code>RC_3010654f80c827b760b6758b9f15acbb</code> that represent
/// s <code>RequisitionRequisitionApprovalLevelRequisitionApprovalApplicationRoleRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: RequisitionRequisitionApprovalLevelRequisitionApprovalApplicationRoleRecord
public partial struct RC_3010654f80c827b760b6758b9f15acbb : ITypedRecord<RC_3010654f80c827b760b6758b9f15acbb> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_3010654f80c827b760b6758b9f15acbb() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(26,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[1];
    ssENRequisitionApproval.OptimizedAttributes = value[2];
    ssENApplicationRole.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[2] = ssENRequisitionApproval.OptimizedAttributes;
    all[3] = ssENApplicationRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisition.Read( r, ref index);
ssENRequisitionApprovalLevel.Read( r, ref index);
ssENRequisitionApproval.Read( r, ref index);
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
public void ReadIM(RC_3010654f80c827b760b6758b9f15acbb r) {
this = r;
}


public static bool operator == (RC_3010654f80c827b760b6758b9f15acbb a, RC_3010654f80c827b760b6758b9f15acbb b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_3010654f80c827b760b6758b9f15acbb a, RC_3010654f80c827b760b6758b9f15acbb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3010654f80c827b760b6758b9f15acbb)) return false;
return (this == (RC_3010654f80c827b760b6758b9f15acbb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_3010654f80c827b760b6758b9f15acbb Duplicate() {
RC_3010654f80c827b760b6758b9f15acbb t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
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
if (head == "requisition") {
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_3010654f80c827b760b6758b9f15acbb
/// <summary>
/// RecordList type
///  <code>RequisitionRequisitionApprovalLevelRequisitionApprovalApplicationRoleRecordList</code> tha
/// t represents a record list of <code>Requisition, RequisitionApprovalLevel, RequisitionApproval,
///  ApplicationRole</code>
/// </summary>
public partial class RL_e87aa4fcc2debbce04977171112902a4 : GenericRecordList<RC_3010654f80c827b760b6758b9f15acbb>, IEnumerable, IEnumerator {

protected override RC_3010654f80c827b760b6758b9f15acbb GetElementDefaultValue() {
return new RC_3010654f80c827b760b6758b9f15acbb();
}

public T[] ToArray<T>(Func<RC_3010654f80c827b760b6758b9f15acbb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e87aa4fcc2debbce04977171112902a4 recordList, Func<RC_3010654f80c827b760b6758b9f15acbb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e87aa4fcc2debbce04977171112902a4(RC_3010654f80c827b760b6758b9f15acbb[] array) {
  RL_e87aa4fcc2debbce04977171112902a4 result = new RL_e87aa4fcc2debbce04977171112902a4();
result.InnerFromArray(array);
    return result;
}

public static RL_e87aa4fcc2debbce04977171112902a4 ToList<T>(T[] array, Func <T, RC_3010654f80c827b760b6758b9f15acbb> converter) {
  RL_e87aa4fcc2debbce04977171112902a4 result = new RL_e87aa4fcc2debbce04977171112902a4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e87aa4fcc2debbce04977171112902a4 FromRestList<T>(RestList<T> restList, Func <T, RC_3010654f80c827b760b6758b9f15acbb> converter) {
  RL_e87aa4fcc2debbce04977171112902a4 result = new RL_e87aa4fcc2debbce04977171112902a4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e87aa4fcc2debbce04977171112902a4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(58,false);
def[1] = new BitArray(26,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3010654f80c827b760b6758b9f15acbb> NewList() {
return new RL_e87aa4fcc2debbce04977171112902a4();
}


} // RL_e87aa4fcc2debbce04977171112902a4
}

