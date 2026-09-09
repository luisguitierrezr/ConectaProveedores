namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (J+hcDPyFAk+5c8mQ+g4Z8g)
///  <code>RC_0750e1f3144a1c14d632b9799d496b79</code> that represent
/// s <code>ApprovalStatusRequisitionRequisitionApprovalLevelRequisitionApprovalRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: ApprovalStatusRequisitionRequisitionApprovalLevelRequisitionApprovalRecord
public partial struct RC_0750e1f3144a1c14d632b9799d496b79 : ITypedRecord<RC_0750e1f3144a1c14d632b9799d496b79> {
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;


public BitArray OptimizedAttributes;

public RC_0750e1f3144a1c14d632b9799d496b79() {
OptimizedAttributes = null;
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(26,false);
    all[3] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENApprovalStatus.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[2];
    ssENRequisitionApproval.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENApprovalStatus.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[3] = ssENRequisitionApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalStatus.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENRequisitionApprovalLevel.Read( r, ref index);
ssENRequisitionApproval.Read( r, ref index);
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
public void ReadIM(RC_0750e1f3144a1c14d632b9799d496b79 r) {
this = r;
}


public static bool operator == (RC_0750e1f3144a1c14d632b9799d496b79 a, RC_0750e1f3144a1c14d632b9799d496b79 b) {
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
return true;
}

public static bool operator != (RC_0750e1f3144a1c14d632b9799d496b79 a, RC_0750e1f3144a1c14d632b9799d496b79 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0750e1f3144a1c14d632b9799d496b79)) return false;
return (this == (RC_0750e1f3144a1c14d632b9799d496b79)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalStatus.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalStatus.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
}


public RC_0750e1f3144a1c14d632b9799d496b79 Duplicate() {
RC_0750e1f3144a1c14d632b9799d496b79 t;
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
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
if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevel")) variable.Value = ssENRequisitionApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("requisitionapprovallevel");
} else if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
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
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
}
} // RC_0750e1f3144a1c14d632b9799d496b79
/// <summary>
/// RecordList type
///  <code>ApprovalStatusRequisitionRequisitionApprovalLevelRequisitionApprovalRecordList</code> tha
/// t represents a record list of <code>ApprovalStatus, Requisition, RequisitionApprovalLevel,
///  RequisitionApproval</code>
/// </summary>
public partial class RL_8e5586c70f591ef1a4332edba15ff911 : GenericRecordList<RC_0750e1f3144a1c14d632b9799d496b79>, IEnumerable, IEnumerator {

protected override RC_0750e1f3144a1c14d632b9799d496b79 GetElementDefaultValue() {
return new RC_0750e1f3144a1c14d632b9799d496b79();
}

public T[] ToArray<T>(Func<RC_0750e1f3144a1c14d632b9799d496b79, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8e5586c70f591ef1a4332edba15ff911 recordList, Func<RC_0750e1f3144a1c14d632b9799d496b79, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8e5586c70f591ef1a4332edba15ff911(RC_0750e1f3144a1c14d632b9799d496b79[] array) {
  RL_8e5586c70f591ef1a4332edba15ff911 result = new RL_8e5586c70f591ef1a4332edba15ff911();
result.InnerFromArray(array);
    return result;
}

public static RL_8e5586c70f591ef1a4332edba15ff911 ToList<T>(T[] array, Func <T, RC_0750e1f3144a1c14d632b9799d496b79> converter) {
  RL_8e5586c70f591ef1a4332edba15ff911 result = new RL_8e5586c70f591ef1a4332edba15ff911();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8e5586c70f591ef1a4332edba15ff911 FromRestList<T>(RestList<T> restList, Func <T, RC_0750e1f3144a1c14d632b9799d496b79> converter) {
  RL_8e5586c70f591ef1a4332edba15ff911 result = new RL_8e5586c70f591ef1a4332edba15ff911();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8e5586c70f591ef1a4332edba15ff911() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(10,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(26,false);
def[3] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0750e1f3144a1c14d632b9799d496b79> NewList() {
return new RL_8e5586c70f591ef1a4332edba15ff911();
}


} // RL_8e5586c70f591ef1a4332edba15ff911
}

