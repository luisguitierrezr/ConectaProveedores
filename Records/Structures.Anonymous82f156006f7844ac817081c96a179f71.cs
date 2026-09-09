namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AFbxgnhvrESBcIHJahefcQ)
///  <code>RC_8fe6259afe1f49269695fecf5b2d7937</code> that represent
/// s <code>InvoiceInvoiceStatusRequisitionRequisitionAccountingPaymentTermsRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceStatusRequisitionRequisitionAccountingPaymentTermsRecord
public partial struct RC_8fe6259afe1f49269695fecf5b2d7937 : ITypedRecord<RC_8fe6259afe1f49269695fecf5b2d7937> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRequisitionAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bnJgWEJBKbtzubqI0xdGXw");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ssENRequisitionAccounting;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;


public BitArray OptimizedAttributes;

public RC_8fe6259afe1f49269695fecf5b2d7937() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(19,false);
    all[4] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisitionAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceStatus.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENRequisitionAccounting.OptimizedAttributes = value[3];
    ssENPaymentTerms.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceStatus.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENRequisitionAccounting.OptimizedAttributes;
    all[4] = ssENPaymentTerms.OptimizedAttributes;
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
ssENInvoiceStatus.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENRequisitionAccounting.Read( r, ref index);
ssENPaymentTerms.Read( r, ref index);
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
public void ReadIM(RC_8fe6259afe1f49269695fecf5b2d7937 r) {
this = r;
}


public static bool operator == (RC_8fe6259afe1f49269695fecf5b2d7937 a, RC_8fe6259afe1f49269695fecf5b2d7937 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRequisitionAccounting != b.ssENRequisitionAccounting) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
return true;
}

public static bool operator != (RC_8fe6259afe1f49269695fecf5b2d7937 a, RC_8fe6259afe1f49269695fecf5b2d7937 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8fe6259afe1f49269695fecf5b2d7937)) return false;
return (this == (RC_8fe6259afe1f49269695fecf5b2d7937)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRequisitionAccounting.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRequisitionAccounting.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRequisitionAccounting.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
}


public RC_8fe6259afe1f49269695fecf5b2d7937 Duplicate() {
RC_8fe6259afe1f49269695fecf5b2d7937 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENRequisitionAccounting = (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord)this.ssENRequisitionAccounting.Duplicate();
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
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
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "requisitionaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccounting")) variable.Value = ssENRequisitionAccounting; else variable.Optimized = true;
variable.SetFieldName("requisitionaccounting");
} else if (head == "paymentterms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTerms")) variable.Value = ssENPaymentTerms; else variable.Optimized = true;
variable.SetFieldName("paymentterms");
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
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdRequisitionAccounting) {
return ssENRequisitionAccounting;
}
if (key == IdPaymentTerms) {
return ssENPaymentTerms;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRequisitionAccounting.Key.AsGuid) {
return ssENRequisitionAccounting;
}
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRequisitionAccounting.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccounting));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
}
} // RC_8fe6259afe1f49269695fecf5b2d7937
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceStatusRequisitionRequisitionAccountingPaymentTermsRecordList</code> tha
/// t represents a record list of <code>Invoice, InvoiceStatus, Requisition, RequisitionAccounting,
///  PaymentTerms</code>
/// </summary>
public partial class RL_a0d7b43e9ac13e97d2ade731b2b4eb81 : GenericRecordList<RC_8fe6259afe1f49269695fecf5b2d7937>, IEnumerable, IEnumerator {

protected override RC_8fe6259afe1f49269695fecf5b2d7937 GetElementDefaultValue() {
return new RC_8fe6259afe1f49269695fecf5b2d7937();
}

public T[] ToArray<T>(Func<RC_8fe6259afe1f49269695fecf5b2d7937, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a0d7b43e9ac13e97d2ade731b2b4eb81 recordList, Func<RC_8fe6259afe1f49269695fecf5b2d7937, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a0d7b43e9ac13e97d2ade731b2b4eb81(RC_8fe6259afe1f49269695fecf5b2d7937[] array) {
  RL_a0d7b43e9ac13e97d2ade731b2b4eb81 result = new RL_a0d7b43e9ac13e97d2ade731b2b4eb81();
result.InnerFromArray(array);
    return result;
}

public static RL_a0d7b43e9ac13e97d2ade731b2b4eb81 ToList<T>(T[] array, Func <T, RC_8fe6259afe1f49269695fecf5b2d7937> converter) {
  RL_a0d7b43e9ac13e97d2ade731b2b4eb81 result = new RL_a0d7b43e9ac13e97d2ade731b2b4eb81();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a0d7b43e9ac13e97d2ade731b2b4eb81 FromRestList<T>(RestList<T> restList, Func <T, RC_8fe6259afe1f49269695fecf5b2d7937> converter) {
  RL_a0d7b43e9ac13e97d2ade731b2b4eb81 result = new RL_a0d7b43e9ac13e97d2ade731b2b4eb81();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a0d7b43e9ac13e97d2ade731b2b4eb81() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(24,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(19,false);
def[4] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8fe6259afe1f49269695fecf5b2d7937> NewList() {
return new RL_a0d7b43e9ac13e97d2ade731b2b4eb81();
}


} // RL_a0d7b43e9ac13e97d2ade731b2b4eb81
}

