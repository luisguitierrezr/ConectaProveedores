namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BActhJyWgUezGo2IMST7EA)
///  <code>RC_cf466c446053e827622ddde1ad0222be</code> that represent
/// s
///  <code>UserSourceUserTargetInvoiceReassignmentsRequisitionRequisitionApprovalLevelInvoiceApprovalLev
/// elRecord</code> <p>Description: </p>
/// </summary>
// Name: UserSourceUserTargetInvoiceReassignmentsRequisitionRequisitionApprovalLevelInvoiceApprovalLevelRecord
public partial struct RC_cf466c446053e827622ddde1ad0222be : ITypedRecord<RC_cf466c446053e827622ddde1ad0222be> {
internal static readonly GlobalObjectKey IdUserSource = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9agEKL1bfHvW_3ul4i9n5A");
internal static readonly GlobalObjectKey IdUserTarget = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QnMIQ76j2bs_KFEzIg_h3g");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdReassignments = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HE45yXcxCSJVD0bH9gDW7g");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public ENUserEntityRecord ssENUserSource;

public ENUserEntityRecord ssENUserTarget;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord ssENReassignments;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_cf466c446053e827622ddde1ad0222be() {
OptimizedAttributes = null;
ssENUserSource = new ENUserEntityRecord();
ssENUserTarget = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENReassignments = new EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(24,false);
    all[3] = new BitArray(17,false);
    all[4] = new BitArray(58,false);
    all[5] = new BitArray(26,false);
    all[6] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUserSource.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserTarget.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENReassignments.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENUserSource.OptimizedAttributes = value[0];
    ssENUserTarget.OptimizedAttributes = value[1];
    ssENInvoice.OptimizedAttributes = value[2];
    ssENReassignments.OptimizedAttributes = value[3];
    ssENRequisition.OptimizedAttributes = value[4];
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[5];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENUserSource.OptimizedAttributes;
    all[1] = ssENUserTarget.OptimizedAttributes;
    all[2] = ssENInvoice.OptimizedAttributes;
    all[3] = ssENReassignments.OptimizedAttributes;
    all[4] = ssENRequisition.OptimizedAttributes;
    all[5] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[6] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUserSource.Read( r, ref index);
ssENUserTarget.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENReassignments.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENRequisitionApprovalLevel.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_cf466c446053e827622ddde1ad0222be r) {
this = r;
}


public static bool operator == (RC_cf466c446053e827622ddde1ad0222be a, RC_cf466c446053e827622ddde1ad0222be b) {
if (a.ssENUserSource != b.ssENUserSource) return false;
if (a.ssENUserTarget != b.ssENUserTarget) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENReassignments != b.ssENReassignments) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_cf466c446053e827622ddde1ad0222be a, RC_cf466c446053e827622ddde1ad0222be b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cf466c446053e827622ddde1ad0222be)) return false;
return (this == (RC_cf466c446053e827622ddde1ad0222be)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUserSource.GetHashCode()
 ^ ssENUserTarget.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENReassignments.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUserSource.RecursiveReset();
ssENUserTarget.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENReassignments.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionApprovalLevel.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUserSource.InternalRecursiveSave();
ssENUserTarget.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENReassignments.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_cf466c446053e827622ddde1ad0222be Duplicate() {
RC_cf466c446053e827622ddde1ad0222be t;
t.ssENUserSource = (ENUserEntityRecord)this.ssENUserSource.Duplicate();
t.ssENUserTarget = (ENUserEntityRecord)this.ssENUserTarget.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENReassignments = (EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord)this.ssENReassignments.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
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
if (head == "usersource") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserSource")) variable.Value = ssENUserSource; else variable.Optimized = true;
variable.SetFieldName("usersource");
} else if (head == "usertarget") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserTarget")) variable.Value = ssENUserTarget; else variable.Optimized = true;
variable.SetFieldName("usertarget");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "reassignments") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Reassignments")) variable.Value = ssENReassignments; else variable.Optimized = true;
variable.SetFieldName("reassignments");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevel")) variable.Value = ssENRequisitionApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("requisitionapprovallevel");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
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
if (key == IdUserSource) {
return ssENUserSource;
}
if (key == IdUserTarget) {
return ssENUserTarget;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdReassignments) {
return ssENReassignments;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserSource.Key.AsGuid) {
return ssENUserSource;
}
if (attributeKey == IdUserTarget.Key.AsGuid) {
return ssENUserTarget;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdReassignments.Key.AsGuid) {
return ssENReassignments;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionApprovalLevel.Key.AsGuid) {
return ssENRequisitionApprovalLevel;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUserSource.FillFromOther((IRecord) other.AttributeGet(IdUserSource));
ssENUserTarget.FillFromOther((IRecord) other.AttributeGet(IdUserTarget));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENReassignments.FillFromOther((IRecord) other.AttributeGet(IdReassignments));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_cf466c446053e827622ddde1ad0222be
/// <summary>
/// RecordList type
///  <code>UserSourceUserTargetInvoiceReassignmentsRequisitionRequisitionApprovalLevelInvoiceApprovalLev
/// elRecordList</code> that represents a record list of <code>User, User, Invoice, Reassignments,
///  Requisition, RequisitionApprovalLevel, InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_9b70977d6dab04293e9e952de2a92b65 : GenericRecordList<RC_cf466c446053e827622ddde1ad0222be>, IEnumerable, IEnumerator {

protected override RC_cf466c446053e827622ddde1ad0222be GetElementDefaultValue() {
return new RC_cf466c446053e827622ddde1ad0222be();
}

public T[] ToArray<T>(Func<RC_cf466c446053e827622ddde1ad0222be, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9b70977d6dab04293e9e952de2a92b65 recordList, Func<RC_cf466c446053e827622ddde1ad0222be, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9b70977d6dab04293e9e952de2a92b65(RC_cf466c446053e827622ddde1ad0222be[] array) {
  RL_9b70977d6dab04293e9e952de2a92b65 result = new RL_9b70977d6dab04293e9e952de2a92b65();
result.InnerFromArray(array);
    return result;
}

public static RL_9b70977d6dab04293e9e952de2a92b65 ToList<T>(T[] array, Func <T, RC_cf466c446053e827622ddde1ad0222be> converter) {
  RL_9b70977d6dab04293e9e952de2a92b65 result = new RL_9b70977d6dab04293e9e952de2a92b65();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9b70977d6dab04293e9e952de2a92b65 FromRestList<T>(RestList<T> restList, Func <T, RC_cf466c446053e827622ddde1ad0222be> converter) {
  RL_9b70977d6dab04293e9e952de2a92b65 result = new RL_9b70977d6dab04293e9e952de2a92b65();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9b70977d6dab04293e9e952de2a92b65() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(24,false);
def[3] = new BitArray(17,false);
def[4] = new BitArray(58,false);
def[5] = new BitArray(26,false);
def[6] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cf466c446053e827622ddde1ad0222be> NewList() {
return new RL_9b70977d6dab04293e9e952de2a92b65();
}


} // RL_9b70977d6dab04293e9e952de2a92b65
}

