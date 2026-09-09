namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (aHpTA23+0kGZB6SU9PtFQw)
///  <code>RC_aa8eac9e200aee33e0be6438a23c61c3</code> that represent
/// s
///  <code>CurrencyUserInvoiceInvoiceStatusRequisitionInvoicePolizaInvoiceAccountingInvoiceExtendedUser_
/// Extended_InternalDepartmentSupplierManagementPaymentTermsRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyUserInvoiceInvoiceStatusRequisitionInvoicePolizaInvoiceAccountingInvoiceExtendedUser_Extended_InternalDepartmentSupplierManagementPaymentTermsRegionRecord
public partial struct RC_aa8eac9e200aee33e0be6438a23c61c3 : ITypedRecord<RC_aa8eac9e200aee33e0be6438a23c61c3> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoicePoliza = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FGf9FFyQZ8GAODzC2obuDQ");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IzSRoKR0M7PMRMnTx82Mqg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdManagement = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aX6HlzEsBTbAmgvoOWuXtA");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord ssENInvoicePoliza;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ssENDepartment;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_57ed198e55e574aae8caa812c90093e4EntityRecord ssENManagement;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_aa8eac9e200aee33e0be6438a23c61c3() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoicePoliza = new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENDepartment = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENManagement = new EN_57ed198e55e574aae8caa812c90093e4EntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[14];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(24,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(58,false);
    all[5] = new BitArray(9,false);
    all[6] = new BitArray(21,false);
    all[7] = new BitArray(19,false);
    all[8] = new BitArray(20,false);
    all[9] = new BitArray(7,false);
    all[10] = new BitArray(28,false);
    all[11] = new BitArray(7,false);
    all[12] = new BitArray(11,false);
    all[13] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENInvoicePoliza.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENDepartment.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[10];
    ssENManagement.OptimizedAttributes = GetDefaultOptimizedValues()[11];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[12];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[13];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENUser.OptimizedAttributes = value[1];
    ssENInvoice.OptimizedAttributes = value[2];
    ssENInvoiceStatus.OptimizedAttributes = value[3];
    ssENRequisition.OptimizedAttributes = value[4];
    ssENInvoicePoliza.OptimizedAttributes = value[5];
    ssENInvoiceAccounting.OptimizedAttributes = value[6];
    ssENInvoiceExtended.OptimizedAttributes = value[7];
    ssENUser_Extended_Internal.OptimizedAttributes = value[8];
    ssENDepartment.OptimizedAttributes = value[9];
    ssENSupplier.OptimizedAttributes = value[10];
    ssENManagement.OptimizedAttributes = value[11];
    ssENPaymentTerms.OptimizedAttributes = value[12];
    ssENRegion.OptimizedAttributes = value[13];
    }
}
get{
    BitArray[] all = new BitArray[14];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENUser.OptimizedAttributes;
    all[2] = ssENInvoice.OptimizedAttributes;
    all[3] = ssENInvoiceStatus.OptimizedAttributes;
    all[4] = ssENRequisition.OptimizedAttributes;
    all[5] = ssENInvoicePoliza.OptimizedAttributes;
    all[6] = ssENInvoiceAccounting.OptimizedAttributes;
    all[7] = ssENInvoiceExtended.OptimizedAttributes;
    all[8] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[9] = ssENDepartment.OptimizedAttributes;
    all[10] = ssENSupplier.OptimizedAttributes;
    all[11] = ssENManagement.OptimizedAttributes;
    all[12] = ssENPaymentTerms.OptimizedAttributes;
    all[13] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENUser.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENInvoicePoliza.Read( r, ref index);
ssENInvoiceAccounting.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
ssENDepartment.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENManagement.Read( r, ref index);
ssENPaymentTerms.Read( r, ref index);
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
public void ReadIM(RC_aa8eac9e200aee33e0be6438a23c61c3 r) {
this = r;
}


public static bool operator == (RC_aa8eac9e200aee33e0be6438a23c61c3 a, RC_aa8eac9e200aee33e0be6438a23c61c3 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoicePoliza != b.ssENInvoicePoliza) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENDepartment != b.ssENDepartment) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENManagement != b.ssENManagement) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_aa8eac9e200aee33e0be6438a23c61c3 a, RC_aa8eac9e200aee33e0be6438a23c61c3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_aa8eac9e200aee33e0be6438a23c61c3)) return false;
return (this == (RC_aa8eac9e200aee33e0be6438a23c61c3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoicePoliza.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENDepartment.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENManagement.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoicePoliza.RecursiveReset();
ssENInvoiceAccounting.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENDepartment.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENManagement.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoicePoliza.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENDepartment.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENManagement.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_aa8eac9e200aee33e0be6438a23c61c3 Duplicate() {
RC_aa8eac9e200aee33e0be6438a23c61c3 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoicePoliza = (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord)this.ssENInvoicePoliza.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENDepartment = (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)this.ssENDepartment.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENManagement = (EN_57ed198e55e574aae8caa812c90093e4EntityRecord)this.ssENManagement.Duplicate();
t.ssENPaymentTerms = (EN_17720044fda96c0c2d8d0760c429f48aEntityRecord)this.ssENPaymentTerms.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoicepoliza") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicePoliza")) variable.Value = ssENInvoicePoliza; else variable.Optimized = true;
variable.SetFieldName("invoicepoliza");
} else if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "department") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssENDepartment; else variable.Optimized = true;
variable.SetFieldName("department");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "management") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Management")) variable.Value = ssENManagement; else variable.Optimized = true;
variable.SetFieldName("management");
} else if (head == "paymentterms") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentTerms")) variable.Value = ssENPaymentTerms; else variable.Optimized = true;
variable.SetFieldName("paymentterms");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoicePoliza) {
return ssENInvoicePoliza;
}
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdDepartment) {
return ssENDepartment;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdManagement) {
return ssENManagement;
}
if (key == IdPaymentTerms) {
return ssENPaymentTerms;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoicePoliza.Key.AsGuid) {
return ssENInvoicePoliza;
}
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdDepartment.Key.AsGuid) {
return ssENDepartment;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdManagement.Key.AsGuid) {
return ssENManagement;
}
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoicePoliza.FillFromOther((IRecord) other.AttributeGet(IdInvoicePoliza));
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENDepartment.FillFromOther((IRecord) other.AttributeGet(IdDepartment));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENManagement.FillFromOther((IRecord) other.AttributeGet(IdManagement));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_aa8eac9e200aee33e0be6438a23c61c3
/// <summary>
/// RecordList type
///  <code>CurrencyUserInvoiceInvoiceStatusRequisitionInvoicePolizaInvoiceAccountingInvoiceExtendedUser_
/// Extended_InternalDepartmentSupplierManagementPaymentTermsRegionRecordList</code> that represents a
///  record list of <code>Currency, User, Invoice, InvoiceStatus, Requisition, InvoicePoliza
/// , InvoiceAccounting, InvoiceExtended, User_Extended_Internal, Department, Supplier, Management,
///  PaymentTerms, Region</code>
/// </summary>
public partial class RL_6f578d989bb546e044c5b0b47d17f46f : GenericRecordList<RC_aa8eac9e200aee33e0be6438a23c61c3>, IEnumerable, IEnumerator {

protected override RC_aa8eac9e200aee33e0be6438a23c61c3 GetElementDefaultValue() {
return new RC_aa8eac9e200aee33e0be6438a23c61c3();
}

public T[] ToArray<T>(Func<RC_aa8eac9e200aee33e0be6438a23c61c3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6f578d989bb546e044c5b0b47d17f46f recordList, Func<RC_aa8eac9e200aee33e0be6438a23c61c3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6f578d989bb546e044c5b0b47d17f46f(RC_aa8eac9e200aee33e0be6438a23c61c3[] array) {
  RL_6f578d989bb546e044c5b0b47d17f46f result = new RL_6f578d989bb546e044c5b0b47d17f46f();
result.InnerFromArray(array);
    return result;
}

public static RL_6f578d989bb546e044c5b0b47d17f46f ToList<T>(T[] array, Func <T, RC_aa8eac9e200aee33e0be6438a23c61c3> converter) {
  RL_6f578d989bb546e044c5b0b47d17f46f result = new RL_6f578d989bb546e044c5b0b47d17f46f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6f578d989bb546e044c5b0b47d17f46f FromRestList<T>(RestList<T> restList, Func <T, RC_aa8eac9e200aee33e0be6438a23c61c3> converter) {
  RL_6f578d989bb546e044c5b0b47d17f46f result = new RL_6f578d989bb546e044c5b0b47d17f46f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6f578d989bb546e044c5b0b47d17f46f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[14];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(24,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(58,false);
def[5] = new BitArray(9,false);
def[6] = new BitArray(21,false);
def[7] = new BitArray(19,false);
def[8] = new BitArray(20,false);
def[9] = new BitArray(7,false);
def[10] = new BitArray(28,false);
def[11] = new BitArray(7,false);
def[12] = new BitArray(11,false);
def[13] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_aa8eac9e200aee33e0be6438a23c61c3> NewList() {
return new RL_6f578d989bb546e044c5b0b47d17f46f();
}


} // RL_6f578d989bb546e044c5b0b47d17f46f
}

