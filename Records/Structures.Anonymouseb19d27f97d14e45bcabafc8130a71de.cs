namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (f9IZ69GXRU68q6_IEwpx3g)
///  <code>RC_7f08dc0fb9c48f26d83ce6d2ad029a99</code> that represent
/// s
///  <code>UserInvoiceInvoiceApprovalApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingAppli
/// cationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceInvoiceApprovalApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleRecord
public partial struct RC_7f08dc0fb9c48f26d83ce6d2ad029a99 : ITypedRecord<RC_7f08dc0fb9c48f26d83ce6d2ad029a99> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_7f08dc0fb9c48f26d83ce6d2ad029a99() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(10,false);
    all[4] = new BitArray(58,false);
    all[5] = new BitArray(25,false);
    all[6] = new BitArray(21,false);
    all[7] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceApproval.OptimizedAttributes = value[2];
    ssENApprovalStatus.OptimizedAttributes = value[3];
    ssENRequisition.OptimizedAttributes = value[4];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[5];
    ssENInvoiceAccounting.OptimizedAttributes = value[6];
    ssENApplicationRole.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceApproval.OptimizedAttributes;
    all[3] = ssENApprovalStatus.OptimizedAttributes;
    all[4] = ssENRequisition.OptimizedAttributes;
    all[5] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[6] = ssENInvoiceAccounting.OptimizedAttributes;
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
ssENUser.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENInvoiceApproval.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
ssENInvoiceAccounting.Read( r, ref index);
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
public void ReadIM(RC_7f08dc0fb9c48f26d83ce6d2ad029a99 r) {
this = r;
}


public static bool operator == (RC_7f08dc0fb9c48f26d83ce6d2ad029a99 a, RC_7f08dc0fb9c48f26d83ce6d2ad029a99 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_7f08dc0fb9c48f26d83ce6d2ad029a99 a, RC_7f08dc0fb9c48f26d83ce6d2ad029a99 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7f08dc0fb9c48f26d83ce6d2ad029a99)) return false;
return (this == (RC_7f08dc0fb9c48f26d83ce6d2ad029a99)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENInvoiceAccounting.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_7f08dc0fb9c48f26d83ce6d2ad029a99 Duplicate() {
RC_7f08dc0fb9c48f26d83ce6d2ad029a99 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
} else if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_7f08dc0fb9c48f26d83ce6d2ad029a99
/// <summary>
/// RecordList type
///  <code>UserInvoiceInvoiceApprovalApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingAppli
/// cationRoleRecordList</code> that represents a record list of <code>User, Invoice, InvoiceApproval,
///  ApprovalStatus, Requisition, InvoiceApprovalLevel, InvoiceAccounting, ApplicationRole</code>
/// </summary>
public partial class RL_7e52acba89af9e5478e7de97c09a8561 : GenericRecordList<RC_7f08dc0fb9c48f26d83ce6d2ad029a99>, IEnumerable, IEnumerator {

protected override RC_7f08dc0fb9c48f26d83ce6d2ad029a99 GetElementDefaultValue() {
return new RC_7f08dc0fb9c48f26d83ce6d2ad029a99();
}

public T[] ToArray<T>(Func<RC_7f08dc0fb9c48f26d83ce6d2ad029a99, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7e52acba89af9e5478e7de97c09a8561 recordList, Func<RC_7f08dc0fb9c48f26d83ce6d2ad029a99, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7e52acba89af9e5478e7de97c09a8561(RC_7f08dc0fb9c48f26d83ce6d2ad029a99[] array) {
  RL_7e52acba89af9e5478e7de97c09a8561 result = new RL_7e52acba89af9e5478e7de97c09a8561();
result.InnerFromArray(array);
    return result;
}

public static RL_7e52acba89af9e5478e7de97c09a8561 ToList<T>(T[] array, Func <T, RC_7f08dc0fb9c48f26d83ce6d2ad029a99> converter) {
  RL_7e52acba89af9e5478e7de97c09a8561 result = new RL_7e52acba89af9e5478e7de97c09a8561();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7e52acba89af9e5478e7de97c09a8561 FromRestList<T>(RestList<T> restList, Func <T, RC_7f08dc0fb9c48f26d83ce6d2ad029a99> converter) {
  RL_7e52acba89af9e5478e7de97c09a8561 result = new RL_7e52acba89af9e5478e7de97c09a8561();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7e52acba89af9e5478e7de97c09a8561() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(10,false);
def[4] = new BitArray(58,false);
def[5] = new BitArray(25,false);
def[6] = new BitArray(21,false);
def[7] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7f08dc0fb9c48f26d83ce6d2ad029a99> NewList() {
return new RL_7e52acba89af9e5478e7de97c09a8561();
}


} // RL_7e52acba89af9e5478e7de97c09a8561
}

