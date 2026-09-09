namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Og_MtgfkVkqJg2piUF_WnA)
///  <code>RC_a5a625e8d3ab33c9963e296857124373</code> that represent
/// s
///  <code>UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelSupplierR
/// ecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelSupplierRecord
public partial struct RC_a5a625e8d3ab33c9963e296857124373 : ITypedRecord<RC_a5a625e8d3ab33c9963e296857124373> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_a5a625e8d3ab33c9963e296857124373() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(10,false);
    all[5] = new BitArray(58,false);
    all[6] = new BitArray(25,false);
    all[7] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceApproval.OptimizedAttributes = value[2];
    ssENInvoiceStatus.OptimizedAttributes = value[3];
    ssENApprovalStatus.OptimizedAttributes = value[4];
    ssENRequisition.OptimizedAttributes = value[5];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[6];
    ssENSupplier.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceApproval.OptimizedAttributes;
    all[3] = ssENInvoiceStatus.OptimizedAttributes;
    all[4] = ssENApprovalStatus.OptimizedAttributes;
    all[5] = ssENRequisition.OptimizedAttributes;
    all[6] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[7] = ssENSupplier.OptimizedAttributes;
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
ssENInvoiceStatus.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_a5a625e8d3ab33c9963e296857124373 r) {
this = r;
}


public static bool operator == (RC_a5a625e8d3ab33c9963e296857124373 a, RC_a5a625e8d3ab33c9963e296857124373 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_a5a625e8d3ab33c9963e296857124373 a, RC_a5a625e8d3ab33c9963e296857124373 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a5a625e8d3ab33c9963e296857124373)) return false;
return (this == (RC_a5a625e8d3ab33c9963e296857124373)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_a5a625e8d3ab33c9963e296857124373 Duplicate() {
RC_a5a625e8d3ab33c9963e296857124373 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
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
if (key == IdSupplier) {
return ssENSupplier;
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
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
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
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_a5a625e8d3ab33c9963e296857124373
/// <summary>
/// RecordList type
///  <code>UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelSupplierR
/// ecordList</code> that represents a record list of <code>User, Invoice, InvoiceApproval,
///  InvoiceStatus, ApprovalStatus, Requisition, InvoiceApprovalLevel, Supplier</code>
/// </summary>
public partial class RL_d801fe1ea71112ff0b6aae5532582323 : GenericRecordList<RC_a5a625e8d3ab33c9963e296857124373>, IEnumerable, IEnumerator {

protected override RC_a5a625e8d3ab33c9963e296857124373 GetElementDefaultValue() {
return new RC_a5a625e8d3ab33c9963e296857124373();
}

public T[] ToArray<T>(Func<RC_a5a625e8d3ab33c9963e296857124373, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d801fe1ea71112ff0b6aae5532582323 recordList, Func<RC_a5a625e8d3ab33c9963e296857124373, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d801fe1ea71112ff0b6aae5532582323(RC_a5a625e8d3ab33c9963e296857124373[] array) {
  RL_d801fe1ea71112ff0b6aae5532582323 result = new RL_d801fe1ea71112ff0b6aae5532582323();
result.InnerFromArray(array);
    return result;
}

public static RL_d801fe1ea71112ff0b6aae5532582323 ToList<T>(T[] array, Func <T, RC_a5a625e8d3ab33c9963e296857124373> converter) {
  RL_d801fe1ea71112ff0b6aae5532582323 result = new RL_d801fe1ea71112ff0b6aae5532582323();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d801fe1ea71112ff0b6aae5532582323 FromRestList<T>(RestList<T> restList, Func <T, RC_a5a625e8d3ab33c9963e296857124373> converter) {
  RL_d801fe1ea71112ff0b6aae5532582323 result = new RL_d801fe1ea71112ff0b6aae5532582323();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d801fe1ea71112ff0b6aae5532582323() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(10,false);
def[5] = new BitArray(58,false);
def[6] = new BitArray(25,false);
def[7] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a5a625e8d3ab33c9963e296857124373> NewList() {
return new RL_d801fe1ea71112ff0b6aae5532582323();
}


} // RL_d801fe1ea71112ff0b6aae5532582323
}

