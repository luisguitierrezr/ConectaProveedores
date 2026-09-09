namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jVUacx7kREi_rbvoVekfCw)
///  <code>RC_605897e6a4b36a23ebf729de65626af9</code> that represent
/// s
///  <code>User_ApprovedByUser_AssignedToInvoiceInvoiceApprovalInvoiceComment_CancelInvoiceComment_Modif
/// yInvoiceApprovalLevelApplicationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: User_ApprovedByUser_AssignedToInvoiceInvoiceApprovalInvoiceComment_CancelInvoiceComment_ModifyInvoiceApprovalLevelApplicationRoleRecord
public partial struct RC_605897e6a4b36a23ebf729de65626af9 : ITypedRecord<RC_605897e6a4b36a23ebf729de65626af9> {
internal static readonly GlobalObjectKey IdUser_ApprovedBy = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ikw5cEw5gZWeOyYkA6BcaA");
internal static readonly GlobalObjectKey IdUser_AssignedTo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mTDDWoJnPDXPpxcpb5SRdQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceComment_Cancel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wVbTMTt7TYVKzT4oIxzn6A");
internal static readonly GlobalObjectKey IdInvoiceComment_Modify = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bk07N6EvqBchp0jT9S7yLg");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public ENUserEntityRecord ssENUser_ApprovedBy;

public ENUserEntityRecord ssENUser_AssignedTo;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord ssENInvoiceComment_Cancel;

public EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord ssENInvoiceComment_Modify;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_605897e6a4b36a23ebf729de65626af9() {
OptimizedAttributes = null;
ssENUser_ApprovedBy = new ENUserEntityRecord();
ssENUser_AssignedTo = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceComment_Cancel = new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord();
ssENInvoiceComment_Modify = new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(24,false);
    all[3] = new BitArray(10,false);
    all[4] = new BitArray(8,false);
    all[5] = new BitArray(8,false);
    all[6] = new BitArray(25,false);
    all[7] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_ApprovedBy.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_AssignedTo.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceComment_Cancel.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENInvoiceComment_Modify.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENUser_ApprovedBy.OptimizedAttributes = value[0];
    ssENUser_AssignedTo.OptimizedAttributes = value[1];
    ssENInvoice.OptimizedAttributes = value[2];
    ssENInvoiceApproval.OptimizedAttributes = value[3];
    ssENInvoiceComment_Cancel.OptimizedAttributes = value[4];
    ssENInvoiceComment_Modify.OptimizedAttributes = value[5];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[6];
    ssENApplicationRole.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENUser_ApprovedBy.OptimizedAttributes;
    all[1] = ssENUser_AssignedTo.OptimizedAttributes;
    all[2] = ssENInvoice.OptimizedAttributes;
    all[3] = ssENInvoiceApproval.OptimizedAttributes;
    all[4] = ssENInvoiceComment_Cancel.OptimizedAttributes;
    all[5] = ssENInvoiceComment_Modify.OptimizedAttributes;
    all[6] = ssENInvoiceApprovalLevel.OptimizedAttributes;
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
ssENUser_ApprovedBy.Read( r, ref index);
ssENUser_AssignedTo.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENInvoiceApproval.Read( r, ref index);
ssENInvoiceComment_Cancel.Read( r, ref index);
ssENInvoiceComment_Modify.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_605897e6a4b36a23ebf729de65626af9 r) {
this = r;
}


public static bool operator == (RC_605897e6a4b36a23ebf729de65626af9 a, RC_605897e6a4b36a23ebf729de65626af9 b) {
if (a.ssENUser_ApprovedBy != b.ssENUser_ApprovedBy) return false;
if (a.ssENUser_AssignedTo != b.ssENUser_AssignedTo) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceComment_Cancel != b.ssENInvoiceComment_Cancel) return false;
if (a.ssENInvoiceComment_Modify != b.ssENInvoiceComment_Modify) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_605897e6a4b36a23ebf729de65626af9 a, RC_605897e6a4b36a23ebf729de65626af9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_605897e6a4b36a23ebf729de65626af9)) return false;
return (this == (RC_605897e6a4b36a23ebf729de65626af9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_ApprovedBy.GetHashCode()
 ^ ssENUser_AssignedTo.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceComment_Cancel.GetHashCode()
 ^ ssENInvoiceComment_Modify.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_ApprovedBy.RecursiveReset();
ssENUser_AssignedTo.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceComment_Cancel.RecursiveReset();
ssENInvoiceComment_Modify.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_ApprovedBy.InternalRecursiveSave();
ssENUser_AssignedTo.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceComment_Cancel.InternalRecursiveSave();
ssENInvoiceComment_Modify.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_605897e6a4b36a23ebf729de65626af9 Duplicate() {
RC_605897e6a4b36a23ebf729de65626af9 t;
t.ssENUser_ApprovedBy = (ENUserEntityRecord)this.ssENUser_ApprovedBy.Duplicate();
t.ssENUser_AssignedTo = (ENUserEntityRecord)this.ssENUser_AssignedTo.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceComment_Cancel = (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord)this.ssENInvoiceComment_Cancel.Duplicate();
t.ssENInvoiceComment_Modify = (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord)this.ssENInvoiceComment_Modify.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
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
if (head == "user_approvedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_ApprovedBy")) variable.Value = ssENUser_ApprovedBy; else variable.Optimized = true;
variable.SetFieldName("user_approvedby");
} else if (head == "user_assignedto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_AssignedTo")) variable.Value = ssENUser_AssignedTo; else variable.Optimized = true;
variable.SetFieldName("user_assignedto");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
} else if (head == "invoicecomment_cancel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceComment_Cancel")) variable.Value = ssENInvoiceComment_Cancel; else variable.Optimized = true;
variable.SetFieldName("invoicecomment_cancel");
} else if (head == "invoicecomment_modify") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceComment_Modify")) variable.Value = ssENInvoiceComment_Modify; else variable.Optimized = true;
variable.SetFieldName("invoicecomment_modify");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
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
if (key == IdUser_ApprovedBy) {
return ssENUser_ApprovedBy;
}
if (key == IdUser_AssignedTo) {
return ssENUser_AssignedTo;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdInvoiceComment_Cancel) {
return ssENInvoiceComment_Cancel;
}
if (key == IdInvoiceComment_Modify) {
return ssENInvoiceComment_Modify;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_ApprovedBy.Key.AsGuid) {
return ssENUser_ApprovedBy;
}
if (attributeKey == IdUser_AssignedTo.Key.AsGuid) {
return ssENUser_AssignedTo;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
if (attributeKey == IdInvoiceComment_Cancel.Key.AsGuid) {
return ssENInvoiceComment_Cancel;
}
if (attributeKey == IdInvoiceComment_Modify.Key.AsGuid) {
return ssENInvoiceComment_Modify;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_ApprovedBy.FillFromOther((IRecord) other.AttributeGet(IdUser_ApprovedBy));
ssENUser_AssignedTo.FillFromOther((IRecord) other.AttributeGet(IdUser_AssignedTo));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceComment_Cancel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceComment_Cancel));
ssENInvoiceComment_Modify.FillFromOther((IRecord) other.AttributeGet(IdInvoiceComment_Modify));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_605897e6a4b36a23ebf729de65626af9
/// <summary>
/// RecordList type
///  <code>User_ApprovedByUser_AssignedToInvoiceInvoiceApprovalInvoiceComment_CancelInvoiceComment_Modif
/// yInvoiceApprovalLevelApplicationRoleRecordList</code> that represents a record list of <code>User,
///  User, Invoice, InvoiceApproval, InvoiceComment, InvoiceComment, InvoiceApprovalLevel
/// , ApplicationRole</code>
/// </summary>
public partial class RL_68b561fd1c8e1947226d48378281e5a1 : GenericRecordList<RC_605897e6a4b36a23ebf729de65626af9>, IEnumerable, IEnumerator {

protected override RC_605897e6a4b36a23ebf729de65626af9 GetElementDefaultValue() {
return new RC_605897e6a4b36a23ebf729de65626af9();
}

public T[] ToArray<T>(Func<RC_605897e6a4b36a23ebf729de65626af9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_68b561fd1c8e1947226d48378281e5a1 recordList, Func<RC_605897e6a4b36a23ebf729de65626af9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_68b561fd1c8e1947226d48378281e5a1(RC_605897e6a4b36a23ebf729de65626af9[] array) {
  RL_68b561fd1c8e1947226d48378281e5a1 result = new RL_68b561fd1c8e1947226d48378281e5a1();
result.InnerFromArray(array);
    return result;
}

public static RL_68b561fd1c8e1947226d48378281e5a1 ToList<T>(T[] array, Func <T, RC_605897e6a4b36a23ebf729de65626af9> converter) {
  RL_68b561fd1c8e1947226d48378281e5a1 result = new RL_68b561fd1c8e1947226d48378281e5a1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_68b561fd1c8e1947226d48378281e5a1 FromRestList<T>(RestList<T> restList, Func <T, RC_605897e6a4b36a23ebf729de65626af9> converter) {
  RL_68b561fd1c8e1947226d48378281e5a1 result = new RL_68b561fd1c8e1947226d48378281e5a1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_68b561fd1c8e1947226d48378281e5a1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(24,false);
def[3] = new BitArray(10,false);
def[4] = new BitArray(8,false);
def[5] = new BitArray(8,false);
def[6] = new BitArray(25,false);
def[7] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_605897e6a4b36a23ebf729de65626af9> NewList() {
return new RL_68b561fd1c8e1947226d48378281e5a1();
}


} // RL_68b561fd1c8e1947226d48378281e5a1
}

