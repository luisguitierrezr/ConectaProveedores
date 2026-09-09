namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9nhL9kZ9sUuF5UgOsAIVqA)
///  <code>RC_538a0a51e898da2a7d23f8bcef0baeae</code> that represent
/// s <code>InvoiceInvoiceApprovalApprovalStatusRequisitionInvoiceApprovalLevelRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceApprovalApprovalStatusRequisitionInvoiceApprovalLevelRecord
public partial struct RC_538a0a51e898da2a7d23f8bcef0baeae : ITypedRecord<RC_538a0a51e898da2a7d23f8bcef0baeae> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_538a0a51e898da2a7d23f8bcef0baeae() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(58,false);
    all[4] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENApprovalStatus.OptimizedAttributes = value[2];
    ssENRequisition.OptimizedAttributes = value[3];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENApprovalStatus.OptimizedAttributes;
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
ssENInvoice.Read( r, ref index);
ssENInvoiceApproval.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
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
public void ReadIM(RC_538a0a51e898da2a7d23f8bcef0baeae r) {
this = r;
}


public static bool operator == (RC_538a0a51e898da2a7d23f8bcef0baeae a, RC_538a0a51e898da2a7d23f8bcef0baeae b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_538a0a51e898da2a7d23f8bcef0baeae a, RC_538a0a51e898da2a7d23f8bcef0baeae b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_538a0a51e898da2a7d23f8bcef0baeae)) return false;
return (this == (RC_538a0a51e898da2a7d23f8bcef0baeae)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_538a0a51e898da2a7d23f8bcef0baeae Duplicate() {
RC_538a0a51e898da2a7d23f8bcef0baeae t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
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
if (head == "invoice") {
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_538a0a51e898da2a7d23f8bcef0baeae
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceApprovalApprovalStatusRequisitionInvoiceApprovalLevelRecordList</code> tha
/// t represents a record list of <code>Invoice, InvoiceApproval, ApprovalStatus, Requisition,
///  InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_3c728dd7388c237b99ca21867fe4fca8 : GenericRecordList<RC_538a0a51e898da2a7d23f8bcef0baeae>, IEnumerable, IEnumerator {

protected override RC_538a0a51e898da2a7d23f8bcef0baeae GetElementDefaultValue() {
return new RC_538a0a51e898da2a7d23f8bcef0baeae();
}

public T[] ToArray<T>(Func<RC_538a0a51e898da2a7d23f8bcef0baeae, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3c728dd7388c237b99ca21867fe4fca8 recordList, Func<RC_538a0a51e898da2a7d23f8bcef0baeae, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3c728dd7388c237b99ca21867fe4fca8(RC_538a0a51e898da2a7d23f8bcef0baeae[] array) {
  RL_3c728dd7388c237b99ca21867fe4fca8 result = new RL_3c728dd7388c237b99ca21867fe4fca8();
result.InnerFromArray(array);
    return result;
}

public static RL_3c728dd7388c237b99ca21867fe4fca8 ToList<T>(T[] array, Func <T, RC_538a0a51e898da2a7d23f8bcef0baeae> converter) {
  RL_3c728dd7388c237b99ca21867fe4fca8 result = new RL_3c728dd7388c237b99ca21867fe4fca8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3c728dd7388c237b99ca21867fe4fca8 FromRestList<T>(RestList<T> restList, Func <T, RC_538a0a51e898da2a7d23f8bcef0baeae> converter) {
  RL_3c728dd7388c237b99ca21867fe4fca8 result = new RL_3c728dd7388c237b99ca21867fe4fca8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3c728dd7388c237b99ca21867fe4fca8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(24,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(58,false);
def[4] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_538a0a51e898da2a7d23f8bcef0baeae> NewList() {
return new RL_3c728dd7388c237b99ca21867fe4fca8();
}


} // RL_3c728dd7388c237b99ca21867fe4fca8
}

