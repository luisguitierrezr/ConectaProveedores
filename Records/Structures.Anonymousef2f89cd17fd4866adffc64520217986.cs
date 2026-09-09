namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (zYkv7_0XZkit_8ZFICF5hg)
///  <code>RC_fed31beb7af18398732c8010e2ffd34a</code> that represent
/// s <code>InvoiceRequisitionInvoiceAccountingProcessCompanySupplierRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceRequisitionInvoiceAccountingProcessCompanySupplierRegionRecord
public partial struct RC_fed31beb7af18398732c8010e2ffd34a : ITypedRecord<RC_fed31beb7af18398732c8010e2ffd34a> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_fed31beb7af18398732c8010e2ffd34a() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(9,false);
    all[3] = new BitArray(11,false);
    all[4] = new BitArray(28,false);
    all[5] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[2];
    ssENCompany.OptimizedAttributes = value[3];
    ssENSupplier.OptimizedAttributes = value[4];
    ssENRegion.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENInvoiceAccountingProcess.OptimizedAttributes;
    all[3] = ssENCompany.OptimizedAttributes;
    all[4] = ssENSupplier.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENInvoiceAccountingProcess.Read( r, ref index);
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
public void ReadIM(RC_fed31beb7af18398732c8010e2ffd34a r) {
this = r;
}


public static bool operator == (RC_fed31beb7af18398732c8010e2ffd34a a, RC_fed31beb7af18398732c8010e2ffd34a b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_fed31beb7af18398732c8010e2ffd34a a, RC_fed31beb7af18398732c8010e2ffd34a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fed31beb7af18398732c8010e2ffd34a)) return false;
return (this == (RC_fed31beb7af18398732c8010e2ffd34a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
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
ssENRequisition.RecursiveReset();
ssENInvoiceAccountingProcess.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceAccountingProcess.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_fed31beb7af18398732c8010e2ffd34a Duplicate() {
RC_fed31beb7af18398732c8010e2ffd34a t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceAccountingProcess = (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord)this.ssENInvoiceAccountingProcess.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceaccountingprocess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcess")) variable.Value = ssENInvoiceAccountingProcess; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocess");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceAccountingProcess) {
return ssENInvoiceAccountingProcess;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceAccountingProcess.Key.AsGuid) {
return ssENInvoiceAccountingProcess;
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
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_fed31beb7af18398732c8010e2ffd34a
/// <summary>
/// RecordList type
///  <code>InvoiceRequisitionInvoiceAccountingProcessCompanySupplierRegionRecordList</code> tha
/// t represents a record list of <code>Invoice, Requisition, InvoiceAccountingProcess, Company,
///  Supplier, Region</code>
/// </summary>
public partial class RL_e62ece2f731d9d568d38eaab7d6db3fb : GenericRecordList<RC_fed31beb7af18398732c8010e2ffd34a>, IEnumerable, IEnumerator {

protected override RC_fed31beb7af18398732c8010e2ffd34a GetElementDefaultValue() {
return new RC_fed31beb7af18398732c8010e2ffd34a();
}

public T[] ToArray<T>(Func<RC_fed31beb7af18398732c8010e2ffd34a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e62ece2f731d9d568d38eaab7d6db3fb recordList, Func<RC_fed31beb7af18398732c8010e2ffd34a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e62ece2f731d9d568d38eaab7d6db3fb(RC_fed31beb7af18398732c8010e2ffd34a[] array) {
  RL_e62ece2f731d9d568d38eaab7d6db3fb result = new RL_e62ece2f731d9d568d38eaab7d6db3fb();
result.InnerFromArray(array);
    return result;
}

public static RL_e62ece2f731d9d568d38eaab7d6db3fb ToList<T>(T[] array, Func <T, RC_fed31beb7af18398732c8010e2ffd34a> converter) {
  RL_e62ece2f731d9d568d38eaab7d6db3fb result = new RL_e62ece2f731d9d568d38eaab7d6db3fb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e62ece2f731d9d568d38eaab7d6db3fb FromRestList<T>(RestList<T> restList, Func <T, RC_fed31beb7af18398732c8010e2ffd34a> converter) {
  RL_e62ece2f731d9d568d38eaab7d6db3fb result = new RL_e62ece2f731d9d568d38eaab7d6db3fb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e62ece2f731d9d568d38eaab7d6db3fb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(24,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(9,false);
def[3] = new BitArray(11,false);
def[4] = new BitArray(28,false);
def[5] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_fed31beb7af18398732c8010e2ffd34a> NewList() {
return new RL_e62ece2f731d9d568d38eaab7d6db3fb();
}


} // RL_e62ece2f731d9d568d38eaab7d6db3fb
}

