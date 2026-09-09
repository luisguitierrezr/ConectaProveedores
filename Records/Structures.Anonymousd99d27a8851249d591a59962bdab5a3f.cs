namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (qCed2RKF1UmRpZlivataPw)
///  <code>RC_85b2b46688ffbcbb7cd7720bbbe251ba</code> that represent
/// s
///  <code>InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelInvoiceAccountingInvoiceExtendedCompanyS
/// upplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelInvoiceAccountingInvoiceExtendedCompanySupplierRegionRecord
public partial struct RC_85b2b46688ffbcbb7cd7720bbbe251ba : ITypedRecord<RC_85b2b46688ffbcbb7cd7720bbbe251ba> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_85b2b46688ffbcbb7cd7720bbbe251ba() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[9];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(25,false);
    all[4] = new BitArray(21,false);
    all[5] = new BitArray(19,false);
    all[6] = new BitArray(11,false);
    all[7] = new BitArray(28,false);
    all[8] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[3];
    ssENInvoiceAccounting.OptimizedAttributes = value[4];
    ssENInvoiceExtended.OptimizedAttributes = value[5];
    ssENCompany.OptimizedAttributes = value[6];
    ssENSupplier.OptimizedAttributes = value[7];
    ssENRegion.OptimizedAttributes = value[8];
    }
}
get{
    BitArray[] all = new BitArray[9];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENInvoiceApprovalLevel.OptimizedAttributes;
    all[4] = ssENInvoiceAccounting.OptimizedAttributes;
    all[5] = ssENInvoiceExtended.OptimizedAttributes;
    all[6] = ssENCompany.OptimizedAttributes;
    all[7] = ssENSupplier.OptimizedAttributes;
    all[8] = ssENRegion.OptimizedAttributes;
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
ssENInvoiceAccounting.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_85b2b46688ffbcbb7cd7720bbbe251ba r) {
this = r;
}


public static bool operator == (RC_85b2b46688ffbcbb7cd7720bbbe251ba a, RC_85b2b46688ffbcbb7cd7720bbbe251ba b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_85b2b46688ffbcbb7cd7720bbbe251ba a, RC_85b2b46688ffbcbb7cd7720bbbe251ba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_85b2b46688ffbcbb7cd7720bbbe251ba)) return false;
return (this == (RC_85b2b46688ffbcbb7cd7720bbbe251ba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
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
ssENInvoiceAccounting.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_85b2b46688ffbcbb7cd7720bbbe251ba Duplicate() {
RC_85b2b46688ffbcbb7cd7720bbbe251ba t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
} else if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
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
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
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
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_85b2b46688ffbcbb7cd7720bbbe251ba
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelInvoiceAccountingInvoiceExtendedCompanyS
/// upplierRegionRecordList</code> that represents a record list of <code>Invoice, InvoiceApproval,
///  Requisition, InvoiceApprovalLevel, InvoiceAccounting, InvoiceExtended, Company, Supplier
/// , Region</code>
/// </summary>
public partial class RL_55207d74c9fa548c4383dfca6f13831e : GenericRecordList<RC_85b2b46688ffbcbb7cd7720bbbe251ba>, IEnumerable, IEnumerator {

protected override RC_85b2b46688ffbcbb7cd7720bbbe251ba GetElementDefaultValue() {
return new RC_85b2b46688ffbcbb7cd7720bbbe251ba();
}

public T[] ToArray<T>(Func<RC_85b2b46688ffbcbb7cd7720bbbe251ba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_55207d74c9fa548c4383dfca6f13831e recordList, Func<RC_85b2b46688ffbcbb7cd7720bbbe251ba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_55207d74c9fa548c4383dfca6f13831e(RC_85b2b46688ffbcbb7cd7720bbbe251ba[] array) {
  RL_55207d74c9fa548c4383dfca6f13831e result = new RL_55207d74c9fa548c4383dfca6f13831e();
result.InnerFromArray(array);
    return result;
}

public static RL_55207d74c9fa548c4383dfca6f13831e ToList<T>(T[] array, Func <T, RC_85b2b46688ffbcbb7cd7720bbbe251ba> converter) {
  RL_55207d74c9fa548c4383dfca6f13831e result = new RL_55207d74c9fa548c4383dfca6f13831e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_55207d74c9fa548c4383dfca6f13831e FromRestList<T>(RestList<T> restList, Func <T, RC_85b2b46688ffbcbb7cd7720bbbe251ba> converter) {
  RL_55207d74c9fa548c4383dfca6f13831e result = new RL_55207d74c9fa548c4383dfca6f13831e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_55207d74c9fa548c4383dfca6f13831e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[9];
def[0] = new BitArray(24,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(25,false);
def[4] = new BitArray(21,false);
def[5] = new BitArray(19,false);
def[6] = new BitArray(11,false);
def[7] = new BitArray(28,false);
def[8] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_85b2b46688ffbcbb7cd7720bbbe251ba> NewList() {
return new RL_55207d74c9fa548c4383dfca6f13831e();
}


} // RL_55207d74c9fa548c4383dfca6f13831e
}

