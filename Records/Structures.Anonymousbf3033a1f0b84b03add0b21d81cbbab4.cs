namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (oTMwv7jwA0ut0LIdgcu6tA)
///  <code>RC_79a9c9a7ac5e18f00a42c0574d6a2449</code> that represent
/// s <code>UserInvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelRecord
public partial struct RC_79a9c9a7ac5e18f00a42c0574d6a2449 : ITypedRecord<RC_79a9c9a7ac5e18f00a42c0574d6a2449> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_79a9c9a7ac5e18f00a42c0574d6a2449() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(58,false);
    all[4] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceApproval.OptimizedAttributes = value[2];
    ssENRequisition.OptimizedAttributes = value[3];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceApproval.OptimizedAttributes;
    all[3] = ssENRequisition.OptimizedAttributes;
    all[4] = ssENInvoiceApprovalLevel.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_79a9c9a7ac5e18f00a42c0574d6a2449 r) {
this = r;
}


public static bool operator == (RC_79a9c9a7ac5e18f00a42c0574d6a2449 a, RC_79a9c9a7ac5e18f00a42c0574d6a2449 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_79a9c9a7ac5e18f00a42c0574d6a2449 a, RC_79a9c9a7ac5e18f00a42c0574d6a2449 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_79a9c9a7ac5e18f00a42c0574d6a2449)) return false;
return (this == (RC_79a9c9a7ac5e18f00a42c0574d6a2449)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_79a9c9a7ac5e18f00a42c0574d6a2449 Duplicate() {
RC_79a9c9a7ac5e18f00a42c0574d6a2449 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_79a9c9a7ac5e18f00a42c0574d6a2449
/// <summary>
/// RecordList type <code>UserInvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelRecordList</code>
///  that represents a record list of <code>User, Invoice, InvoiceApproval, Requisition
/// , InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_130cdfa67e01f3ebccac7a2b8ceec0bf : GenericRecordList<RC_79a9c9a7ac5e18f00a42c0574d6a2449>, IEnumerable, IEnumerator {

protected override RC_79a9c9a7ac5e18f00a42c0574d6a2449 GetElementDefaultValue() {
return new RC_79a9c9a7ac5e18f00a42c0574d6a2449();
}

public T[] ToArray<T>(Func<RC_79a9c9a7ac5e18f00a42c0574d6a2449, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_130cdfa67e01f3ebccac7a2b8ceec0bf recordList, Func<RC_79a9c9a7ac5e18f00a42c0574d6a2449, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_130cdfa67e01f3ebccac7a2b8ceec0bf(RC_79a9c9a7ac5e18f00a42c0574d6a2449[] array) {
  RL_130cdfa67e01f3ebccac7a2b8ceec0bf result = new RL_130cdfa67e01f3ebccac7a2b8ceec0bf();
result.InnerFromArray(array);
    return result;
}

public static RL_130cdfa67e01f3ebccac7a2b8ceec0bf ToList<T>(T[] array, Func <T, RC_79a9c9a7ac5e18f00a42c0574d6a2449> converter) {
  RL_130cdfa67e01f3ebccac7a2b8ceec0bf result = new RL_130cdfa67e01f3ebccac7a2b8ceec0bf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_130cdfa67e01f3ebccac7a2b8ceec0bf FromRestList<T>(RestList<T> restList, Func <T, RC_79a9c9a7ac5e18f00a42c0574d6a2449> converter) {
  RL_130cdfa67e01f3ebccac7a2b8ceec0bf result = new RL_130cdfa67e01f3ebccac7a2b8ceec0bf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_130cdfa67e01f3ebccac7a2b8ceec0bf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(58,false);
def[4] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_79a9c9a7ac5e18f00a42c0574d6a2449> NewList() {
return new RL_130cdfa67e01f3ebccac7a2b8ceec0bf();
}


} // RL_130cdfa67e01f3ebccac7a2b8ceec0bf
}

