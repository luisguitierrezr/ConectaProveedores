namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CieAsD8Qg0ShaAMmi79rvw)
///  <code>RC_45d2d2c3c5fe5caa10fa5e20326622ac</code> that represent
/// s
///  <code>CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_
/// PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord
public partial struct RC_45d2d2c3c5fe5caa10fa5e20326622ac : ITypedRecord<RC_45d2d2c3c5fe5caa10fa5e20326622ac> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pYG_Ox+CD2ypp5EEenCnjA");
internal static readonly GlobalObjectKey IdAmountDelivered = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kA0YPb9pdOUuD7pfZyYX2Q");
internal static readonly GlobalObjectKey IdAmountLeft = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UwswFQFlbgSvhhXsBZG2bQ");
internal static readonly GlobalObjectKey IdDifference_FormSAE_Invoice_Amount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nFPgVIf6DspYGlB+eLbiyA");
internal static readonly GlobalObjectKey IdDifference_FormSAE_Invoice_Percent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uux1LEp8hfx_R6XZaXG8fQ");
internal static readonly GlobalObjectKey IdInvoicingAmount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RocX5T23PaDqCHH9D5qjzA");
internal static readonly GlobalObjectKey IdPartialDeliveryAmount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UKqbQ30s58+dfylhsFdJYQ");
internal static readonly GlobalObjectKey IdPercentageDelivered = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*P_C0l643chQmnmeSV3eVlw");
internal static readonly GlobalObjectKey IdTotalAmount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uNH36LeiF7N+j_UOkhiw_A");

public string ssCurrency;

public decimal ssAmountDelivered;

public decimal ssAmountLeft;

public decimal ssDifference_FormSAE_Invoice_Amount;

public decimal ssDifference_FormSAE_Invoice_Percent;

public decimal ssInvoicingAmount;

public decimal ssPartialDeliveryAmount;

public decimal ssPercentageDelivered;

public decimal ssTotalAmount;


public BitArray OptimizedAttributes;

public RC_45d2d2c3c5fe5caa10fa5e20326622ac() {
OptimizedAttributes = null;
ssCurrency = "";
ssAmountDelivered = 0.0M;
ssAmountLeft = 0.0M;
ssDifference_FormSAE_Invoice_Amount = 0.0M;
ssDifference_FormSAE_Invoice_Percent = 0.0M;
ssInvoicingAmount = 0.0M;
ssPartialDeliveryAmount = 0.0M;
ssPercentageDelivered = 0.0M;
ssTotalAmount = 0.0M;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssCurrency = r.ReadText(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.Currency", "");
ssAmountDelivered = r.ReadDecimal(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.AmountDelivered", 0.0M);
ssAmountLeft = r.ReadDecimal(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.AmountLeft", 0.0M);
ssDifference_FormSAE_Invoice_Amount = r.ReadDecimal(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.Difference_FormSAE_Invoice_Amount", 0.0M);
ssDifference_FormSAE_Invoice_Percent = r.ReadDecimal(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.Difference_FormSAE_Invoice_Percent", 0.0M);
ssInvoicingAmount = r.ReadDecimal(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.InvoicingAmount", 0.0M);
ssPartialDeliveryAmount = r.ReadDecimal(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.PartialDeliveryAmount", 0.0M);
ssPercentageDelivered = r.ReadDecimal(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.PercentageDelivered", 0.0M);
ssTotalAmount = r.ReadDecimal(index++, "CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecord.TotalAmount", 0.0M);
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
public void ReadIM(RC_45d2d2c3c5fe5caa10fa5e20326622ac r) {
this = r;
}


public static bool operator == (RC_45d2d2c3c5fe5caa10fa5e20326622ac a, RC_45d2d2c3c5fe5caa10fa5e20326622ac b) {
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssAmountDelivered != b.ssAmountDelivered) return false;
if (a.ssAmountLeft != b.ssAmountLeft) return false;
if (a.ssDifference_FormSAE_Invoice_Amount != b.ssDifference_FormSAE_Invoice_Amount) return false;
if (a.ssDifference_FormSAE_Invoice_Percent != b.ssDifference_FormSAE_Invoice_Percent) return false;
if (a.ssInvoicingAmount != b.ssInvoicingAmount) return false;
if (a.ssPartialDeliveryAmount != b.ssPartialDeliveryAmount) return false;
if (a.ssPercentageDelivered != b.ssPercentageDelivered) return false;
if (a.ssTotalAmount != b.ssTotalAmount) return false;
return true;
}

public static bool operator != (RC_45d2d2c3c5fe5caa10fa5e20326622ac a, RC_45d2d2c3c5fe5caa10fa5e20326622ac b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_45d2d2c3c5fe5caa10fa5e20326622ac)) return false;
return (this == (RC_45d2d2c3c5fe5caa10fa5e20326622ac)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssAmountDelivered.GetHashCode()
 ^ ssAmountLeft.GetHashCode()
 ^ ssDifference_FormSAE_Invoice_Amount.GetHashCode()
 ^ ssDifference_FormSAE_Invoice_Percent.GetHashCode()
 ^ ssInvoicingAmount.GetHashCode()
 ^ ssPartialDeliveryAmount.GetHashCode()
 ^ ssPercentageDelivered.GetHashCode()
 ^ ssTotalAmount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_45d2d2c3c5fe5caa10fa5e20326622ac Duplicate() {
RC_45d2d2c3c5fe5caa10fa5e20326622ac t;
t.ssCurrency = this.ssCurrency;
t.ssAmountDelivered = this.ssAmountDelivered;
t.ssAmountLeft = this.ssAmountLeft;
t.ssDifference_FormSAE_Invoice_Amount = this.ssDifference_FormSAE_Invoice_Amount;
t.ssDifference_FormSAE_Invoice_Percent = this.ssDifference_FormSAE_Invoice_Percent;
t.ssInvoicingAmount = this.ssInvoicingAmount;
t.ssPartialDeliveryAmount = this.ssPartialDeliveryAmount;
t.ssPercentageDelivered = this.ssPercentageDelivered;
t.ssTotalAmount = this.ssTotalAmount;
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
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "amountdelivered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AmountDelivered")) variable.Value = ssAmountDelivered; else variable.Optimized = true;
} else if (head == "amountleft") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AmountLeft")) variable.Value = ssAmountLeft; else variable.Optimized = true;
} else if (head == "difference_formsae_invoice_amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Difference_FormSAE_Invoice_Amount")) variable.Value = ssDifference_FormSAE_Invoice_Amount; else variable.Optimized = true;
} else if (head == "difference_formsae_invoice_percent") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Difference_FormSAE_Invoice_Percent")) variable.Value = ssDifference_FormSAE_Invoice_Percent; else variable.Optimized = true;
} else if (head == "invoicingamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicingAmount")) variable.Value = ssInvoicingAmount; else variable.Optimized = true;
} else if (head == "partialdeliveryamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PartialDeliveryAmount")) variable.Value = ssPartialDeliveryAmount; else variable.Optimized = true;
} else if (head == "percentagedelivered") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PercentageDelivered")) variable.Value = ssPercentageDelivered; else variable.Optimized = true;
} else if (head == "totalamount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalAmount")) variable.Value = ssTotalAmount; else variable.Optimized = true;
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
return ssCurrency;
}
if (key == IdAmountDelivered) {
return ssAmountDelivered;
}
if (key == IdAmountLeft) {
return ssAmountLeft;
}
if (key == IdDifference_FormSAE_Invoice_Amount) {
return ssDifference_FormSAE_Invoice_Amount;
}
if (key == IdDifference_FormSAE_Invoice_Percent) {
return ssDifference_FormSAE_Invoice_Percent;
}
if (key == IdInvoicingAmount) {
return ssInvoicingAmount;
}
if (key == IdPartialDeliveryAmount) {
return ssPartialDeliveryAmount;
}
if (key == IdPercentageDelivered) {
return ssPercentageDelivered;
}
if (key == IdTotalAmount) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdAmountDelivered.Key.AsGuid) {
return ssAmountDelivered;
}
if (attributeKey == IdAmountLeft.Key.AsGuid) {
return ssAmountLeft;
}
if (attributeKey == IdDifference_FormSAE_Invoice_Amount.Key.AsGuid) {
return ssDifference_FormSAE_Invoice_Amount;
}
if (attributeKey == IdDifference_FormSAE_Invoice_Percent.Key.AsGuid) {
return ssDifference_FormSAE_Invoice_Percent;
}
if (attributeKey == IdInvoicingAmount.Key.AsGuid) {
return ssInvoicingAmount;
}
if (attributeKey == IdPartialDeliveryAmount.Key.AsGuid) {
return ssPartialDeliveryAmount;
}
if (attributeKey == IdPercentageDelivered.Key.AsGuid) {
return ssPercentageDelivered;
}
if (attributeKey == IdTotalAmount.Key.AsGuid) {
return ssTotalAmount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssAmountDelivered = (decimal) other.AttributeGet(IdAmountDelivered);
ssAmountLeft = (decimal) other.AttributeGet(IdAmountLeft);
ssDifference_FormSAE_Invoice_Amount = (decimal) other.AttributeGet(IdDifference_FormSAE_Invoice_Amount);
ssDifference_FormSAE_Invoice_Percent = (decimal) other.AttributeGet(IdDifference_FormSAE_Invoice_Percent);
ssInvoicingAmount = (decimal) other.AttributeGet(IdInvoicingAmount);
ssPartialDeliveryAmount = (decimal) other.AttributeGet(IdPartialDeliveryAmount);
ssPercentageDelivered = (decimal) other.AttributeGet(IdPercentageDelivered);
ssTotalAmount = (decimal) other.AttributeGet(IdTotalAmount);
}
} // RC_45d2d2c3c5fe5caa10fa5e20326622ac
/// <summary>
/// RecordList type
///  <code>CurrencyAmountDeliveredAmountLeftDifference_FormSAE_Invoice_AmountDifference_FormSAE_Invoice_
/// PercentInvoicingAmountPartialDeliveryAmountPercentageDeliveredTotalAmountRecordList</code> that
///  represents a record list of <code>Text, Decimal, Decimal, Decimal, Decimal, Decimal, Decimal
/// , Decimal, Decimal</code>
/// </summary>
public partial class RL_cb148c8425fdbaa14a36117885a448b8 : GenericRecordList<RC_45d2d2c3c5fe5caa10fa5e20326622ac>, IEnumerable, IEnumerator {

protected override RC_45d2d2c3c5fe5caa10fa5e20326622ac GetElementDefaultValue() {
return new RC_45d2d2c3c5fe5caa10fa5e20326622ac();
}

public T[] ToArray<T>(Func<RC_45d2d2c3c5fe5caa10fa5e20326622ac, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cb148c8425fdbaa14a36117885a448b8 recordList, Func<RC_45d2d2c3c5fe5caa10fa5e20326622ac, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cb148c8425fdbaa14a36117885a448b8(RC_45d2d2c3c5fe5caa10fa5e20326622ac[] array) {
  RL_cb148c8425fdbaa14a36117885a448b8 result = new RL_cb148c8425fdbaa14a36117885a448b8();
result.InnerFromArray(array);
    return result;
}

public static RL_cb148c8425fdbaa14a36117885a448b8 ToList<T>(T[] array, Func <T, RC_45d2d2c3c5fe5caa10fa5e20326622ac> converter) {
  RL_cb148c8425fdbaa14a36117885a448b8 result = new RL_cb148c8425fdbaa14a36117885a448b8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cb148c8425fdbaa14a36117885a448b8 FromRestList<T>(RestList<T> restList, Func <T, RC_45d2d2c3c5fe5caa10fa5e20326622ac> converter) {
  RL_cb148c8425fdbaa14a36117885a448b8 result = new RL_cb148c8425fdbaa14a36117885a448b8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cb148c8425fdbaa14a36117885a448b8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_45d2d2c3c5fe5caa10fa5e20326622ac> NewList() {
return new RL_cb148c8425fdbaa14a36117885a448b8();
}


} // RL_cb148c8425fdbaa14a36117885a448b8
}

