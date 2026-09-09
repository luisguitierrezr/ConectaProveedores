namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (qSIEqFQOa0qGLr429K4Eqg)
///  <code>RC_93dc1c8a1fa45d29d89784afc0b5bc8d</code> that represent
/// s
///  <code>InvoiceRequisitionInvoiceAccountingInvoiceExtendedCompanySupplierPaymentTermsPaymentMethodsRe
/// cord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceRequisitionInvoiceAccountingInvoiceExtendedCompanySupplierPaymentTermsPaymentMethodsRecord
public partial struct RC_93dc1c8a1fa45d29d89784afc0b5bc8d : ITypedRecord<RC_93dc1c8a1fa45d29d89784afc0b5bc8d> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");
internal static readonly GlobalObjectKey IdPaymentMethods = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GI4gRZFLoSpiPN8Zdg6Ofg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;

public EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord ssENPaymentMethods;


public BitArray OptimizedAttributes;

public RC_93dc1c8a1fa45d29d89784afc0b5bc8d() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
ssENPaymentMethods = new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(21,false);
    all[3] = new BitArray(19,false);
    all[4] = new BitArray(11,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(11,false);
    all[7] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENPaymentMethods.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENInvoiceAccounting.OptimizedAttributes = value[2];
    ssENInvoiceExtended.OptimizedAttributes = value[3];
    ssENCompany.OptimizedAttributes = value[4];
    ssENSupplier.OptimizedAttributes = value[5];
    ssENPaymentTerms.OptimizedAttributes = value[6];
    ssENPaymentMethods.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENInvoiceAccounting.OptimizedAttributes;
    all[3] = ssENInvoiceExtended.OptimizedAttributes;
    all[4] = ssENCompany.OptimizedAttributes;
    all[5] = ssENSupplier.OptimizedAttributes;
    all[6] = ssENPaymentTerms.OptimizedAttributes;
    all[7] = ssENPaymentMethods.OptimizedAttributes;
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
ssENInvoiceAccounting.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENPaymentTerms.Read( r, ref index);
ssENPaymentMethods.Read( r, ref index);
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
public void ReadIM(RC_93dc1c8a1fa45d29d89784afc0b5bc8d r) {
this = r;
}


public static bool operator == (RC_93dc1c8a1fa45d29d89784afc0b5bc8d a, RC_93dc1c8a1fa45d29d89784afc0b5bc8d b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
if (a.ssENPaymentMethods != b.ssENPaymentMethods) return false;
return true;
}

public static bool operator != (RC_93dc1c8a1fa45d29d89784afc0b5bc8d a, RC_93dc1c8a1fa45d29d89784afc0b5bc8d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_93dc1c8a1fa45d29d89784afc0b5bc8d)) return false;
return (this == (RC_93dc1c8a1fa45d29d89784afc0b5bc8d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
 ^ ssENPaymentMethods.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceAccounting.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
ssENPaymentMethods.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
ssENPaymentMethods.InternalRecursiveSave();
}


public RC_93dc1c8a1fa45d29d89784afc0b5bc8d Duplicate() {
RC_93dc1c8a1fa45d29d89784afc0b5bc8d t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
t.ssENPaymentMethods = (EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord)this.ssENPaymentMethods.Duplicate();
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
} else if (head == "paymentterms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTerms")) variable.Value = ssENPaymentTerms; else variable.Optimized = true;
variable.SetFieldName("paymentterms");
} else if (head == "paymentmethods") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentMethods")) variable.Value = ssENPaymentMethods; else variable.Optimized = true;
variable.SetFieldName("paymentmethods");
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
if (key == IdPaymentTerms) {
return ssENPaymentTerms;
}
if (key == IdPaymentMethods) {
return ssENPaymentMethods;
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
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
if (attributeKey == IdPaymentMethods.Key.AsGuid) {
return ssENPaymentMethods;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
ssENPaymentMethods.FillFromOther((IRecord) other.AttributeGet(IdPaymentMethods));
}
} // RC_93dc1c8a1fa45d29d89784afc0b5bc8d
/// <summary>
/// RecordList type
///  <code>InvoiceRequisitionInvoiceAccountingInvoiceExtendedCompanySupplierPaymentTermsPaymentMethodsRe
/// cordList</code> that represents a record list of <code>Invoice, Requisition, InvoiceAccounting,
///  InvoiceExtended, Company, Supplier, PaymentTerms, PaymentMethods</code>
/// </summary>
public partial class RL_167572037cd88dd5ec827ef4b6fdc32a : GenericRecordList<RC_93dc1c8a1fa45d29d89784afc0b5bc8d>, IEnumerable, IEnumerator {

protected override RC_93dc1c8a1fa45d29d89784afc0b5bc8d GetElementDefaultValue() {
return new RC_93dc1c8a1fa45d29d89784afc0b5bc8d();
}

public T[] ToArray<T>(Func<RC_93dc1c8a1fa45d29d89784afc0b5bc8d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_167572037cd88dd5ec827ef4b6fdc32a recordList, Func<RC_93dc1c8a1fa45d29d89784afc0b5bc8d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_167572037cd88dd5ec827ef4b6fdc32a(RC_93dc1c8a1fa45d29d89784afc0b5bc8d[] array) {
  RL_167572037cd88dd5ec827ef4b6fdc32a result = new RL_167572037cd88dd5ec827ef4b6fdc32a();
result.InnerFromArray(array);
    return result;
}

public static RL_167572037cd88dd5ec827ef4b6fdc32a ToList<T>(T[] array, Func <T, RC_93dc1c8a1fa45d29d89784afc0b5bc8d> converter) {
  RL_167572037cd88dd5ec827ef4b6fdc32a result = new RL_167572037cd88dd5ec827ef4b6fdc32a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_167572037cd88dd5ec827ef4b6fdc32a FromRestList<T>(RestList<T> restList, Func <T, RC_93dc1c8a1fa45d29d89784afc0b5bc8d> converter) {
  RL_167572037cd88dd5ec827ef4b6fdc32a result = new RL_167572037cd88dd5ec827ef4b6fdc32a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_167572037cd88dd5ec827ef4b6fdc32a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(24,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(21,false);
def[3] = new BitArray(19,false);
def[4] = new BitArray(11,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(11,false);
def[7] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_93dc1c8a1fa45d29d89784afc0b5bc8d> NewList() {
return new RL_167572037cd88dd5ec827ef4b6fdc32a();
}


} // RL_167572037cd88dd5ec827ef4b6fdc32a
}

