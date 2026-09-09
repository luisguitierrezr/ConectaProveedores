namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (UUHiaaPCQ0u5jkL2EjA+xw)
///  <code>RC_ff6aa2b6e9ff9861ddfa27919ed0cfed</code> that represent
/// s <code>InvoiceOrderAccConceptsOrderMainCompanyPaymentTermsRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceOrderAccConceptsOrderMainCompanyPaymentTermsRecord
public partial struct RC_ff6aa2b6e9ff9861ddfa27919ed0cfed : ITypedRecord<RC_ff6aa2b6e9ff9861ddfa27919ed0cfed> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;


public BitArray OptimizedAttributes;

public RC_ff6aa2b6e9ff9861ddfa27919ed0cfed() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(14,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(11,false);
    all[4] = new BitArray(11,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENOrderAccConcepts.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENCompany.OptimizedAttributes = value[3];
    ssENPaymentTerms.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENOrderAccConcepts.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENCompany.OptimizedAttributes;
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
ssENOrderAccConcepts.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENCompany.Read( r, ref index);
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
public void ReadIM(RC_ff6aa2b6e9ff9861ddfa27919ed0cfed r) {
this = r;
}


public static bool operator == (RC_ff6aa2b6e9ff9861ddfa27919ed0cfed a, RC_ff6aa2b6e9ff9861ddfa27919ed0cfed b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
return true;
}

public static bool operator != (RC_ff6aa2b6e9ff9861ddfa27919ed0cfed a, RC_ff6aa2b6e9ff9861ddfa27919ed0cfed b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ff6aa2b6e9ff9861ddfa27919ed0cfed)) return false;
return (this == (RC_ff6aa2b6e9ff9861ddfa27919ed0cfed)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENOrderAccConcepts.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENCompany.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENOrderAccConcepts.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
}


public RC_ff6aa2b6e9ff9861ddfa27919ed0cfed Duplicate() {
RC_ff6aa2b6e9ff9861ddfa27919ed0cfed t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
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
} else if (head == "orderaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConcepts")) variable.Value = ssENOrderAccConcepts; else variable.Optimized = true;
variable.SetFieldName("orderaccconcepts");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
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
if (key == IdOrderAccConcepts) {
return ssENOrderAccConcepts;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdCompany) {
return ssENCompany;
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
if (attributeKey == IdOrderAccConcepts.Key.AsGuid) {
return ssENOrderAccConcepts;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdPaymentTerms.Key.AsGuid) {
return ssENPaymentTerms;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
}
} // RC_ff6aa2b6e9ff9861ddfa27919ed0cfed
/// <summary>
/// RecordList type <code>InvoiceOrderAccConceptsOrderMainCompanyPaymentTermsRecordList</code> that
///  represents a record list of <code>Invoice, OrderAccConcepts, OrderMain, Company
/// , PaymentTerms</code>
/// </summary>
public partial class RL_2ece488b15c9ecc6303dcb8130b7d6de : GenericRecordList<RC_ff6aa2b6e9ff9861ddfa27919ed0cfed>, IEnumerable, IEnumerator {

protected override RC_ff6aa2b6e9ff9861ddfa27919ed0cfed GetElementDefaultValue() {
return new RC_ff6aa2b6e9ff9861ddfa27919ed0cfed();
}

public T[] ToArray<T>(Func<RC_ff6aa2b6e9ff9861ddfa27919ed0cfed, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2ece488b15c9ecc6303dcb8130b7d6de recordList, Func<RC_ff6aa2b6e9ff9861ddfa27919ed0cfed, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2ece488b15c9ecc6303dcb8130b7d6de(RC_ff6aa2b6e9ff9861ddfa27919ed0cfed[] array) {
  RL_2ece488b15c9ecc6303dcb8130b7d6de result = new RL_2ece488b15c9ecc6303dcb8130b7d6de();
result.InnerFromArray(array);
    return result;
}

public static RL_2ece488b15c9ecc6303dcb8130b7d6de ToList<T>(T[] array, Func <T, RC_ff6aa2b6e9ff9861ddfa27919ed0cfed> converter) {
  RL_2ece488b15c9ecc6303dcb8130b7d6de result = new RL_2ece488b15c9ecc6303dcb8130b7d6de();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2ece488b15c9ecc6303dcb8130b7d6de FromRestList<T>(RestList<T> restList, Func <T, RC_ff6aa2b6e9ff9861ddfa27919ed0cfed> converter) {
  RL_2ece488b15c9ecc6303dcb8130b7d6de result = new RL_2ece488b15c9ecc6303dcb8130b7d6de();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2ece488b15c9ecc6303dcb8130b7d6de() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(24,false);
def[1] = new BitArray(14,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(11,false);
def[4] = new BitArray(11,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ff6aa2b6e9ff9861ddfa27919ed0cfed> NewList() {
return new RL_2ece488b15c9ecc6303dcb8130b7d6de();
}


} // RL_2ece488b15c9ecc6303dcb8130b7d6de
}

