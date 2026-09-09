namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BrB4CeZMVEqWhODHfw5RcQ)
///  <code>RC_f8a6a0591753be81aad5115c1222bf32</code> that represent
/// s <code>ApprovalProcessSpecialWorkflowUploadPuestosSpecialWorkflowsRequisitionApprovalRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: ApprovalProcessSpecialWorkflowUploadPuestosSpecialWorkflowsRequisitionApprovalRecord
public partial struct RC_f8a6a0591753be81aad5115c1222bf32 : ITypedRecord<RC_f8a6a0591753be81aad5115c1222bf32> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdSpecialWorkflowUploadPuestos = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AJn2RjiTwrMph4fuS2Ji7A");
internal static readonly GlobalObjectKey IdSpecialWorkflows = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yf5QylATHSSjC2IieQZcbg");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord ssENSpecialWorkflowUploadPuestos;

public EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord ssENSpecialWorkflows;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;


public BitArray OptimizedAttributes;

public RC_f8a6a0591753be81aad5115c1222bf32() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENSpecialWorkflowUploadPuestos = new EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord();
ssENSpecialWorkflows = new EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(3,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSpecialWorkflowUploadPuestos.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSpecialWorkflows.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    ssENSpecialWorkflowUploadPuestos.OptimizedAttributes = value[1];
    ssENSpecialWorkflows.OptimizedAttributes = value[2];
    ssENRequisitionApproval.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    all[1] = ssENSpecialWorkflowUploadPuestos.OptimizedAttributes;
    all[2] = ssENSpecialWorkflows.OptimizedAttributes;
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
ssENApprovalProcess.Read( r, ref index);
ssENSpecialWorkflowUploadPuestos.Read( r, ref index);
ssENSpecialWorkflows.Read( r, ref index);
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
public void ReadIM(RC_f8a6a0591753be81aad5115c1222bf32 r) {
this = r;
}


public static bool operator == (RC_f8a6a0591753be81aad5115c1222bf32 a, RC_f8a6a0591753be81aad5115c1222bf32 b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENSpecialWorkflowUploadPuestos != b.ssENSpecialWorkflowUploadPuestos) return false;
if (a.ssENSpecialWorkflows != b.ssENSpecialWorkflows) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
return true;
}

public static bool operator != (RC_f8a6a0591753be81aad5115c1222bf32 a, RC_f8a6a0591753be81aad5115c1222bf32 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f8a6a0591753be81aad5115c1222bf32)) return false;
return (this == (RC_f8a6a0591753be81aad5115c1222bf32)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENSpecialWorkflowUploadPuestos.GetHashCode()
 ^ ssENSpecialWorkflows.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
ssENSpecialWorkflowUploadPuestos.RecursiveReset();
ssENSpecialWorkflows.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
ssENSpecialWorkflowUploadPuestos.InternalRecursiveSave();
ssENSpecialWorkflows.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
}


public RC_f8a6a0591753be81aad5115c1222bf32 Duplicate() {
RC_f8a6a0591753be81aad5115c1222bf32 t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENSpecialWorkflowUploadPuestos = (EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord)this.ssENSpecialWorkflowUploadPuestos.Duplicate();
t.ssENSpecialWorkflows = (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord)this.ssENSpecialWorkflows.Duplicate();
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
if (head == "approvalprocess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcess")) variable.Value = ssENApprovalProcess; else variable.Optimized = true;
variable.SetFieldName("approvalprocess");
} else if (head == "specialworkflowuploadpuestos") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialWorkflowUploadPuestos")) variable.Value = ssENSpecialWorkflowUploadPuestos; else variable.Optimized = true;
variable.SetFieldName("specialworkflowuploadpuestos");
} else if (head == "specialworkflows") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialWorkflows")) variable.Value = ssENSpecialWorkflows; else variable.Optimized = true;
variable.SetFieldName("specialworkflows");
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
if (key == IdApprovalProcess) {
return ssENApprovalProcess;
}
if (key == IdSpecialWorkflowUploadPuestos) {
return ssENSpecialWorkflowUploadPuestos;
}
if (key == IdSpecialWorkflows) {
return ssENSpecialWorkflows;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcess.Key.AsGuid) {
return ssENApprovalProcess;
}
if (attributeKey == IdSpecialWorkflowUploadPuestos.Key.AsGuid) {
return ssENSpecialWorkflowUploadPuestos;
}
if (attributeKey == IdSpecialWorkflows.Key.AsGuid) {
return ssENSpecialWorkflows;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENSpecialWorkflowUploadPuestos.FillFromOther((IRecord) other.AttributeGet(IdSpecialWorkflowUploadPuestos));
ssENSpecialWorkflows.FillFromOther((IRecord) other.AttributeGet(IdSpecialWorkflows));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
}
} // RC_f8a6a0591753be81aad5115c1222bf32
/// <summary>
/// RecordList type
///  <code>ApprovalProcessSpecialWorkflowUploadPuestosSpecialWorkflowsRequisitionApprovalRecordList</cod
/// e> that represents a record list of <code>ApprovalProcess, SpecialWorkflowUploadPuestos,
///  SpecialWorkflows, RequisitionApproval</code>
/// </summary>
public partial class RL_30636074d08fd7e7f28d138ca9feb3da : GenericRecordList<RC_f8a6a0591753be81aad5115c1222bf32>, IEnumerable, IEnumerator {

protected override RC_f8a6a0591753be81aad5115c1222bf32 GetElementDefaultValue() {
return new RC_f8a6a0591753be81aad5115c1222bf32();
}

public T[] ToArray<T>(Func<RC_f8a6a0591753be81aad5115c1222bf32, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_30636074d08fd7e7f28d138ca9feb3da recordList, Func<RC_f8a6a0591753be81aad5115c1222bf32, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_30636074d08fd7e7f28d138ca9feb3da(RC_f8a6a0591753be81aad5115c1222bf32[] array) {
  RL_30636074d08fd7e7f28d138ca9feb3da result = new RL_30636074d08fd7e7f28d138ca9feb3da();
result.InnerFromArray(array);
    return result;
}

public static RL_30636074d08fd7e7f28d138ca9feb3da ToList<T>(T[] array, Func <T, RC_f8a6a0591753be81aad5115c1222bf32> converter) {
  RL_30636074d08fd7e7f28d138ca9feb3da result = new RL_30636074d08fd7e7f28d138ca9feb3da();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_30636074d08fd7e7f28d138ca9feb3da FromRestList<T>(RestList<T> restList, Func <T, RC_f8a6a0591753be81aad5115c1222bf32> converter) {
  RL_30636074d08fd7e7f28d138ca9feb3da result = new RL_30636074d08fd7e7f28d138ca9feb3da();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_30636074d08fd7e7f28d138ca9feb3da() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(19,false);
def[1] = new BitArray(3,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f8a6a0591753be81aad5115c1222bf32> NewList() {
return new RL_30636074d08fd7e7f28d138ca9feb3da();
}


} // RL_30636074d08fd7e7f28d138ca9feb3da
}

