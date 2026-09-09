namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (3uWOLn_eiUOtX7dbBW7vKw)
///  <code>RC_c29b3326c29f006183b22af7b25050ff</code> that represent
/// s <code>InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelApplicationRoleRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelApplicationRoleRegionRecord
public partial struct RC_c29b3326c29f006183b22af7b25050ff : ITypedRecord<RC_c29b3326c29f006183b22af7b25050ff> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_c29b3326c29f006183b22af7b25050ff() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(25,false);
    all[4] = new BitArray(7,false);
    all[5] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[3];
    ssENApplicationRole.OptimizedAttributes = value[4];
    ssENRegion.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[4] = ssENApplicationRole.OptimizedAttributes;
    all[5] = ssENRegion.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_c29b3326c29f006183b22af7b25050ff r) {
this = r;
}


public static bool operator == (RC_c29b3326c29f006183b22af7b25050ff a, RC_c29b3326c29f006183b22af7b25050ff b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_c29b3326c29f006183b22af7b25050ff a, RC_c29b3326c29f006183b22af7b25050ff b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c29b3326c29f006183b22af7b25050ff)) return false;
return (this == (RC_c29b3326c29f006183b22af7b25050ff)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_c29b3326c29f006183b22af7b25050ff Duplicate() {
RC_c29b3326c29f006183b22af7b25050ff t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdRegion) {
return ssENRegion;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_c29b3326c29f006183b22af7b25050ff
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelApplicationRoleRegionRecordList</code
/// > that represents a record list of <code>Invoice, InvoiceApproval, Requisition,
///  InvoiceApprovalLevel, ApplicationRole, Region</code>
/// </summary>
public partial class RL_0c0399bc671f4e1ad26ddefe7a74d7a8 : GenericRecordList<RC_c29b3326c29f006183b22af7b25050ff>, IEnumerable, IEnumerator {

protected override RC_c29b3326c29f006183b22af7b25050ff GetElementDefaultValue() {
return new RC_c29b3326c29f006183b22af7b25050ff();
}

public T[] ToArray<T>(Func<RC_c29b3326c29f006183b22af7b25050ff, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0c0399bc671f4e1ad26ddefe7a74d7a8 recordList, Func<RC_c29b3326c29f006183b22af7b25050ff, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0c0399bc671f4e1ad26ddefe7a74d7a8(RC_c29b3326c29f006183b22af7b25050ff[] array) {
  RL_0c0399bc671f4e1ad26ddefe7a74d7a8 result = new RL_0c0399bc671f4e1ad26ddefe7a74d7a8();
result.InnerFromArray(array);
    return result;
}

public static RL_0c0399bc671f4e1ad26ddefe7a74d7a8 ToList<T>(T[] array, Func <T, RC_c29b3326c29f006183b22af7b25050ff> converter) {
  RL_0c0399bc671f4e1ad26ddefe7a74d7a8 result = new RL_0c0399bc671f4e1ad26ddefe7a74d7a8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0c0399bc671f4e1ad26ddefe7a74d7a8 FromRestList<T>(RestList<T> restList, Func <T, RC_c29b3326c29f006183b22af7b25050ff> converter) {
  RL_0c0399bc671f4e1ad26ddefe7a74d7a8 result = new RL_0c0399bc671f4e1ad26ddefe7a74d7a8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0c0399bc671f4e1ad26ddefe7a74d7a8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(24,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(25,false);
def[4] = new BitArray(7,false);
def[5] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c29b3326c29f006183b22af7b25050ff> NewList() {
return new RL_0c0399bc671f4e1ad26ddefe7a74d7a8();
}


} // RL_0c0399bc671f4e1ad26ddefe7a74d7a8
}

