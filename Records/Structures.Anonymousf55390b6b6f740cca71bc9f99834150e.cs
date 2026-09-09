namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tpBT9fe2zECnG8n5mDQVDg)
///  <code>RC_04cecda152c36243971fd8bd8862f207</code> that represent
/// s
///  <code>InvoiceInvoiceStatusInvoiceExtendedReceiverInvoiceExtendedCartaPorteInvoiceExtendedIssuerInvo
/// iceAccountingInvoiceExtendedPaymentTermsRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceStatusInvoiceExtendedReceiverInvoiceExtendedCartaPorteInvoiceExtendedIssuerInvoiceAccountingInvoiceExtendedPaymentTermsRecord
public partial struct RC_04cecda152c36243971fd8bd8862f207 : ITypedRecord<RC_04cecda152c36243971fd8bd8862f207> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdInvoiceExtendedReceiver = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uBhvRvdwk4GYmQQSj8LRXA");
internal static readonly GlobalObjectKey IdInvoiceExtendedCartaPorte = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FDG4ebwnTL7k7L4EK_A3cw");
internal static readonly GlobalObjectKey IdInvoiceExtendedIssuer = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uN_tvHBWlarkSqBJGU8rfA");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord ssENInvoiceExtendedReceiver;

public EN_9bd576a05df3846c52ce88a606aff414EntityRecord ssENInvoiceExtendedCartaPorte;

public EN_1ca446167f1a5fee035306f622895668EntityRecord ssENInvoiceExtendedIssuer;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;


public BitArray OptimizedAttributes;

public RC_04cecda152c36243971fd8bd8862f207() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENInvoiceExtendedReceiver = new EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord();
ssENInvoiceExtendedCartaPorte = new EN_9bd576a05df3846c52ce88a606aff414EntityRecord();
ssENInvoiceExtendedIssuer = new EN_1ca446167f1a5fee035306f622895668EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(5,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(5,false);
    all[5] = new BitArray(21,false);
    all[6] = new BitArray(19,false);
    all[7] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceExtendedReceiver.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceExtendedCartaPorte.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceExtendedIssuer.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceStatus.OptimizedAttributes = value[1];
    ssENInvoiceExtendedReceiver.OptimizedAttributes = value[2];
    ssENInvoiceExtendedCartaPorte.OptimizedAttributes = value[3];
    ssENInvoiceExtendedIssuer.OptimizedAttributes = value[4];
    ssENInvoiceAccounting.OptimizedAttributes = value[5];
    ssENInvoiceExtended.OptimizedAttributes = value[6];
    ssENPaymentTerms.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceStatus.OptimizedAttributes;
    all[2] = ssENInvoiceExtendedReceiver.OptimizedAttributes;
    all[3] = ssENInvoiceExtendedCartaPorte.OptimizedAttributes;
    all[4] = ssENInvoiceExtendedIssuer.OptimizedAttributes;
    all[5] = ssENInvoiceAccounting.OptimizedAttributes;
    all[6] = ssENInvoiceExtended.OptimizedAttributes;
    all[7] = ssENPaymentTerms.OptimizedAttributes;
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
ssENInvoiceExtendedReceiver.Read( r, ref index);
ssENInvoiceExtendedCartaPorte.Read( r, ref index);
ssENInvoiceExtendedIssuer.Read( r, ref index);
ssENInvoiceAccounting.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
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
public void ReadIM(RC_04cecda152c36243971fd8bd8862f207 r) {
this = r;
}


public static bool operator == (RC_04cecda152c36243971fd8bd8862f207 a, RC_04cecda152c36243971fd8bd8862f207 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENInvoiceExtendedReceiver != b.ssENInvoiceExtendedReceiver) return false;
if (a.ssENInvoiceExtendedCartaPorte != b.ssENInvoiceExtendedCartaPorte) return false;
if (a.ssENInvoiceExtendedIssuer != b.ssENInvoiceExtendedIssuer) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
return true;
}

public static bool operator != (RC_04cecda152c36243971fd8bd8862f207 a, RC_04cecda152c36243971fd8bd8862f207 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_04cecda152c36243971fd8bd8862f207)) return false;
return (this == (RC_04cecda152c36243971fd8bd8862f207)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENInvoiceExtendedReceiver.GetHashCode()
 ^ ssENInvoiceExtendedCartaPorte.GetHashCode()
 ^ ssENInvoiceExtendedIssuer.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENInvoiceExtendedReceiver.RecursiveReset();
ssENInvoiceExtendedCartaPorte.RecursiveReset();
ssENInvoiceExtendedIssuer.RecursiveReset();
ssENInvoiceAccounting.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENInvoiceExtendedReceiver.InternalRecursiveSave();
ssENInvoiceExtendedCartaPorte.InternalRecursiveSave();
ssENInvoiceExtendedIssuer.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
}


public RC_04cecda152c36243971fd8bd8862f207 Duplicate() {
RC_04cecda152c36243971fd8bd8862f207 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENInvoiceExtendedReceiver = (EN_b0c20b1f1237d3e4f4e5e432cd60cb6aEntityRecord)this.ssENInvoiceExtendedReceiver.Duplicate();
t.ssENInvoiceExtendedCartaPorte = (EN_9bd576a05df3846c52ce88a606aff414EntityRecord)this.ssENInvoiceExtendedCartaPorte.Duplicate();
t.ssENInvoiceExtendedIssuer = (EN_1ca446167f1a5fee035306f622895668EntityRecord)this.ssENInvoiceExtendedIssuer.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
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
} else if (head == "invoiceextendedreceiver") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedReceiver")) variable.Value = ssENInvoiceExtendedReceiver; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedreceiver");
} else if (head == "invoiceextendedcartaporte") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedCartaPorte")) variable.Value = ssENInvoiceExtendedCartaPorte; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedcartaporte");
} else if (head == "invoiceextendedissuer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedIssuer")) variable.Value = ssENInvoiceExtendedIssuer; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedissuer");
} else if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
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
if (key == IdInvoiceExtendedReceiver) {
return ssENInvoiceExtendedReceiver;
}
if (key == IdInvoiceExtendedCartaPorte) {
return ssENInvoiceExtendedCartaPorte;
}
if (key == IdInvoiceExtendedIssuer) {
return ssENInvoiceExtendedIssuer;
}
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
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
if (attributeKey == IdInvoiceExtendedReceiver.Key.AsGuid) {
return ssENInvoiceExtendedReceiver;
}
if (attributeKey == IdInvoiceExtendedCartaPorte.Key.AsGuid) {
return ssENInvoiceExtendedCartaPorte;
}
if (attributeKey == IdInvoiceExtendedIssuer.Key.AsGuid) {
return ssENInvoiceExtendedIssuer;
}
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
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
ssENInvoiceExtendedReceiver.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedReceiver));
ssENInvoiceExtendedCartaPorte.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedCartaPorte));
ssENInvoiceExtendedIssuer.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedIssuer));
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
}
} // RC_04cecda152c36243971fd8bd8862f207
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceStatusInvoiceExtendedReceiverInvoiceExtendedCartaPorteInvoiceExtendedIssuerInvo
/// iceAccountingInvoiceExtendedPaymentTermsRecordList</code> that represents a record list of
///  <code>Invoice, InvoiceStatus, InvoiceExtendedReceiver, InvoiceExtendedCartaPorte
/// , InvoiceExtendedIssuer, InvoiceAccounting, InvoiceExtended, PaymentTerms</code>
/// </summary>
public partial class RL_e5b15916acd557f57fb46d28151701cd : GenericRecordList<RC_04cecda152c36243971fd8bd8862f207>, IEnumerable, IEnumerator {

protected override RC_04cecda152c36243971fd8bd8862f207 GetElementDefaultValue() {
return new RC_04cecda152c36243971fd8bd8862f207();
}

public T[] ToArray<T>(Func<RC_04cecda152c36243971fd8bd8862f207, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e5b15916acd557f57fb46d28151701cd recordList, Func<RC_04cecda152c36243971fd8bd8862f207, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e5b15916acd557f57fb46d28151701cd(RC_04cecda152c36243971fd8bd8862f207[] array) {
  RL_e5b15916acd557f57fb46d28151701cd result = new RL_e5b15916acd557f57fb46d28151701cd();
result.InnerFromArray(array);
    return result;
}

public static RL_e5b15916acd557f57fb46d28151701cd ToList<T>(T[] array, Func <T, RC_04cecda152c36243971fd8bd8862f207> converter) {
  RL_e5b15916acd557f57fb46d28151701cd result = new RL_e5b15916acd557f57fb46d28151701cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e5b15916acd557f57fb46d28151701cd FromRestList<T>(RestList<T> restList, Func <T, RC_04cecda152c36243971fd8bd8862f207> converter) {
  RL_e5b15916acd557f57fb46d28151701cd result = new RL_e5b15916acd557f57fb46d28151701cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e5b15916acd557f57fb46d28151701cd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(24,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(5,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(5,false);
def[5] = new BitArray(21,false);
def[6] = new BitArray(19,false);
def[7] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_04cecda152c36243971fd8bd8862f207> NewList() {
return new RL_e5b15916acd557f57fb46d28151701cd();
}


} // RL_e5b15916acd557f57fb46d28151701cd
}

