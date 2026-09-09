namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (oMo4G9qFzkClqVCVY5R4hg)
///  <code>RC_f925a49e2decb9ca9ea463dccae74847</code> that represent
/// s <code>InvoiceAccountingTaxIndicatorPaymentTermsPaymentMethodsRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingTaxIndicatorPaymentTermsPaymentMethodsRecord
public partial struct RC_f925a49e2decb9ca9ea463dccae74847 : ITypedRecord<RC_f925a49e2decb9ca9ea463dccae74847> {
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdTaxIndicator = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K08LaPc4fWBh+vjvaP0mEw");
internal static readonly GlobalObjectKey IdPaymentTerms = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sbomVZepvUCHDd5qabo9mg");
internal static readonly GlobalObjectKey IdPaymentMethods = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GI4gRZFLoSpiPN8Zdg6Ofg");

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_efc751d189a1545503ba31ced5225e86EntityRecord ssENTaxIndicator;

public EN_17720044fda96c0c2d8d0760c429f48aEntityRecord ssENPaymentTerms;

public EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord ssENPaymentMethods;


public BitArray OptimizedAttributes;

public RC_f925a49e2decb9ca9ea463dccae74847() {
OptimizedAttributes = null;
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENTaxIndicator = new EN_efc751d189a1545503ba31ced5225e86EntityRecord();
ssENPaymentTerms = new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord();
ssENPaymentMethods = new EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(21,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(11,false);
    all[3] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENTaxIndicator.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENPaymentTerms.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENPaymentMethods.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENInvoiceAccounting.OptimizedAttributes = value[0];
    ssENTaxIndicator.OptimizedAttributes = value[1];
    ssENPaymentTerms.OptimizedAttributes = value[2];
    ssENPaymentMethods.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENInvoiceAccounting.OptimizedAttributes;
    all[1] = ssENTaxIndicator.OptimizedAttributes;
    all[2] = ssENPaymentTerms.OptimizedAttributes;
    all[3] = ssENPaymentMethods.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccounting.Read( r, ref index);
ssENTaxIndicator.Read( r, ref index);
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
public void ReadIM(RC_f925a49e2decb9ca9ea463dccae74847 r) {
this = r;
}


public static bool operator == (RC_f925a49e2decb9ca9ea463dccae74847 a, RC_f925a49e2decb9ca9ea463dccae74847 b) {
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENTaxIndicator != b.ssENTaxIndicator) return false;
if (a.ssENPaymentTerms != b.ssENPaymentTerms) return false;
if (a.ssENPaymentMethods != b.ssENPaymentMethods) return false;
return true;
}

public static bool operator != (RC_f925a49e2decb9ca9ea463dccae74847 a, RC_f925a49e2decb9ca9ea463dccae74847 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f925a49e2decb9ca9ea463dccae74847)) return false;
return (this == (RC_f925a49e2decb9ca9ea463dccae74847)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENTaxIndicator.GetHashCode()
 ^ ssENPaymentTerms.GetHashCode()
 ^ ssENPaymentMethods.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccounting.RecursiveReset();
ssENTaxIndicator.RecursiveReset();
ssENPaymentTerms.RecursiveReset();
ssENPaymentMethods.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccounting.InternalRecursiveSave();
ssENTaxIndicator.InternalRecursiveSave();
ssENPaymentTerms.InternalRecursiveSave();
ssENPaymentMethods.InternalRecursiveSave();
}


public RC_f925a49e2decb9ca9ea463dccae74847 Duplicate() {
RC_f925a49e2decb9ca9ea463dccae74847 t;
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
t.ssENTaxIndicator = (EN_efc751d189a1545503ba31ced5225e86EntityRecord)this.ssENTaxIndicator.Duplicate();
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
if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
} else if (head == "taxindicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TaxIndicator")) variable.Value = ssENTaxIndicator; else variable.Optimized = true;
variable.SetFieldName("taxindicator");
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
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
if (key == IdTaxIndicator) {
return ssENTaxIndicator;
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
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
if (attributeKey == IdTaxIndicator.Key.AsGuid) {
return ssENTaxIndicator;
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
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENTaxIndicator.FillFromOther((IRecord) other.AttributeGet(IdTaxIndicator));
ssENPaymentTerms.FillFromOther((IRecord) other.AttributeGet(IdPaymentTerms));
ssENPaymentMethods.FillFromOther((IRecord) other.AttributeGet(IdPaymentMethods));
}
} // RC_f925a49e2decb9ca9ea463dccae74847
/// <summary>
/// RecordList type <code>InvoiceAccountingTaxIndicatorPaymentTermsPaymentMethodsRecordList</code> that
///  represents a record list of <code>InvoiceAccounting, TaxIndicator, PaymentTerms
/// , PaymentMethods</code>
/// </summary>
public partial class RL_cc406982da8c42dd9f44909f6be7c1b9 : GenericRecordList<RC_f925a49e2decb9ca9ea463dccae74847>, IEnumerable, IEnumerator {

protected override RC_f925a49e2decb9ca9ea463dccae74847 GetElementDefaultValue() {
return new RC_f925a49e2decb9ca9ea463dccae74847();
}

public T[] ToArray<T>(Func<RC_f925a49e2decb9ca9ea463dccae74847, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cc406982da8c42dd9f44909f6be7c1b9 recordList, Func<RC_f925a49e2decb9ca9ea463dccae74847, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cc406982da8c42dd9f44909f6be7c1b9(RC_f925a49e2decb9ca9ea463dccae74847[] array) {
  RL_cc406982da8c42dd9f44909f6be7c1b9 result = new RL_cc406982da8c42dd9f44909f6be7c1b9();
result.InnerFromArray(array);
    return result;
}

public static RL_cc406982da8c42dd9f44909f6be7c1b9 ToList<T>(T[] array, Func <T, RC_f925a49e2decb9ca9ea463dccae74847> converter) {
  RL_cc406982da8c42dd9f44909f6be7c1b9 result = new RL_cc406982da8c42dd9f44909f6be7c1b9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cc406982da8c42dd9f44909f6be7c1b9 FromRestList<T>(RestList<T> restList, Func <T, RC_f925a49e2decb9ca9ea463dccae74847> converter) {
  RL_cc406982da8c42dd9f44909f6be7c1b9 result = new RL_cc406982da8c42dd9f44909f6be7c1b9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cc406982da8c42dd9f44909f6be7c1b9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(21,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(11,false);
def[3] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f925a49e2decb9ca9ea463dccae74847> NewList() {
return new RL_cc406982da8c42dd9f44909f6be7c1b9();
}


} // RL_cc406982da8c42dd9f44909f6be7c1b9
}

