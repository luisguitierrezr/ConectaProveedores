namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5jboQ8_FgUaDbADiMxPqoA)
///  <code>RC_1c2482ce6cd4b83ca44ec0510b231d44</code> that represent
/// s <code>AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord
public partial struct RC_1c2482ce6cd4b83ca44ec0510b231d44 : ITypedRecord<RC_1c2482ce6cd4b83ca44ec0510b231d44> {
internal static readonly GlobalObjectKey IdAdvPaymentValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cpr1dv9+VGKT5Y_B5fyKWA");
internal static readonly GlobalObjectKey IdCreditNoteValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9_dXV0G_XAxytOi1r0wRpw");
internal static readonly GlobalObjectKey IdVoucherValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LmXJ9dNwHdHPiRFNouGxRg");
internal static readonly GlobalObjectKey IdAdvPayment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NeMrzhUOHopnoTTBqWek5w");
internal static readonly GlobalObjectKey IdCreditNote = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aDdTCQ3UPtU5N8iS7L8kwA");
internal static readonly GlobalObjectKey IdNA = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8SlHtltLiwwJE_WxJs3gcg");
internal static readonly GlobalObjectKey IdVoucher = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rtzh9PQJlEOw_dqvvpfvgQ");

public decimal ssAdvPaymentValue;

public decimal ssCreditNoteValue;

public decimal ssVoucherValue;

public bool ssAdvPayment;

public bool ssCreditNote;

public bool ssNA;

public bool ssVoucher;


public BitArray OptimizedAttributes;

public RC_1c2482ce6cd4b83ca44ec0510b231d44() {
OptimizedAttributes = null;
ssAdvPaymentValue = 0.0M;
ssCreditNoteValue = 0.0M;
ssVoucherValue = 0.0M;
ssAdvPayment = false;
ssCreditNote = false;
ssNA = false;
ssVoucher = false;
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
ssAdvPaymentValue = r.ReadDecimal(index++, "AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord.AdvPaymentValue", 0.0M);
ssCreditNoteValue = r.ReadDecimal(index++, "AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord.CreditNoteValue", 0.0M);
ssVoucherValue = r.ReadDecimal(index++, "AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord.VoucherValue", 0.0M);
ssAdvPayment = r.ReadBoolean(index++, "AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord.AdvPayment", false);
ssCreditNote = r.ReadBoolean(index++, "AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord.CreditNote", false);
ssNA = r.ReadBoolean(index++, "AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord.NA", false);
ssVoucher = r.ReadBoolean(index++, "AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecord.Voucher", false);
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
public void ReadIM(RC_1c2482ce6cd4b83ca44ec0510b231d44 r) {
this = r;
}


public static bool operator == (RC_1c2482ce6cd4b83ca44ec0510b231d44 a, RC_1c2482ce6cd4b83ca44ec0510b231d44 b) {
if (a.ssAdvPaymentValue != b.ssAdvPaymentValue) return false;
if (a.ssCreditNoteValue != b.ssCreditNoteValue) return false;
if (a.ssVoucherValue != b.ssVoucherValue) return false;
if (a.ssAdvPayment != b.ssAdvPayment) return false;
if (a.ssCreditNote != b.ssCreditNote) return false;
if (a.ssNA != b.ssNA) return false;
if (a.ssVoucher != b.ssVoucher) return false;
return true;
}

public static bool operator != (RC_1c2482ce6cd4b83ca44ec0510b231d44 a, RC_1c2482ce6cd4b83ca44ec0510b231d44 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1c2482ce6cd4b83ca44ec0510b231d44)) return false;
return (this == (RC_1c2482ce6cd4b83ca44ec0510b231d44)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAdvPaymentValue.GetHashCode()
 ^ ssCreditNoteValue.GetHashCode()
 ^ ssVoucherValue.GetHashCode()
 ^ ssAdvPayment.GetHashCode()
 ^ ssCreditNote.GetHashCode()
 ^ ssNA.GetHashCode()
 ^ ssVoucher.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_1c2482ce6cd4b83ca44ec0510b231d44 Duplicate() {
RC_1c2482ce6cd4b83ca44ec0510b231d44 t;
t.ssAdvPaymentValue = this.ssAdvPaymentValue;
t.ssCreditNoteValue = this.ssCreditNoteValue;
t.ssVoucherValue = this.ssVoucherValue;
t.ssAdvPayment = this.ssAdvPayment;
t.ssCreditNote = this.ssCreditNote;
t.ssNA = this.ssNA;
t.ssVoucher = this.ssVoucher;
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
if (head == "advpaymentvalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvPaymentValue")) variable.Value = ssAdvPaymentValue; else variable.Optimized = true;
} else if (head == "creditnotevalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreditNoteValue")) variable.Value = ssCreditNoteValue; else variable.Optimized = true;
} else if (head == "vouchervalue") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VoucherValue")) variable.Value = ssVoucherValue; else variable.Optimized = true;
} else if (head == "advpayment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AdvPayment")) variable.Value = ssAdvPayment; else variable.Optimized = true;
} else if (head == "creditnote") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreditNote")) variable.Value = ssCreditNote; else variable.Optimized = true;
} else if (head == "na") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NA")) variable.Value = ssNA; else variable.Optimized = true;
} else if (head == "voucher") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Voucher")) variable.Value = ssVoucher; else variable.Optimized = true;
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
if (key == IdAdvPaymentValue) {
return ssAdvPaymentValue;
}
if (key == IdCreditNoteValue) {
return ssCreditNoteValue;
}
if (key == IdVoucherValue) {
return ssVoucherValue;
}
if (key == IdAdvPayment) {
return ssAdvPayment;
}
if (key == IdCreditNote) {
return ssCreditNote;
}
if (key == IdNA) {
return ssNA;
}
if (key == IdVoucher) {
return ssVoucher;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAdvPaymentValue.Key.AsGuid) {
return ssAdvPaymentValue;
}
if (attributeKey == IdCreditNoteValue.Key.AsGuid) {
return ssCreditNoteValue;
}
if (attributeKey == IdVoucherValue.Key.AsGuid) {
return ssVoucherValue;
}
if (attributeKey == IdAdvPayment.Key.AsGuid) {
return ssAdvPayment;
}
if (attributeKey == IdCreditNote.Key.AsGuid) {
return ssCreditNote;
}
if (attributeKey == IdNA.Key.AsGuid) {
return ssNA;
}
if (attributeKey == IdVoucher.Key.AsGuid) {
return ssVoucher;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAdvPaymentValue = (decimal) other.AttributeGet(IdAdvPaymentValue);
ssCreditNoteValue = (decimal) other.AttributeGet(IdCreditNoteValue);
ssVoucherValue = (decimal) other.AttributeGet(IdVoucherValue);
ssAdvPayment = (bool) other.AttributeGet(IdAdvPayment);
ssCreditNote = (bool) other.AttributeGet(IdCreditNote);
ssNA = (bool) other.AttributeGet(IdNA);
ssVoucher = (bool) other.AttributeGet(IdVoucher);
}
} // RC_1c2482ce6cd4b83ca44ec0510b231d44
/// <summary>
/// RecordList type
///  <code>AdvPaymentValueCreditNoteValueVoucherValueAdvPaymentCreditNoteNAVoucherRecordList</code> tha
/// t represents a record list of <code>Decimal, Decimal, Decimal, Boolean, Boolean, Boolean,
///  Boolean</code>
/// </summary>
public partial class RL_81c9b7ce3caaeb90e6998d03108f3f69 : GenericRecordList<RC_1c2482ce6cd4b83ca44ec0510b231d44>, IEnumerable, IEnumerator {

protected override RC_1c2482ce6cd4b83ca44ec0510b231d44 GetElementDefaultValue() {
return new RC_1c2482ce6cd4b83ca44ec0510b231d44();
}

public T[] ToArray<T>(Func<RC_1c2482ce6cd4b83ca44ec0510b231d44, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_81c9b7ce3caaeb90e6998d03108f3f69 recordList, Func<RC_1c2482ce6cd4b83ca44ec0510b231d44, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_81c9b7ce3caaeb90e6998d03108f3f69(RC_1c2482ce6cd4b83ca44ec0510b231d44[] array) {
  RL_81c9b7ce3caaeb90e6998d03108f3f69 result = new RL_81c9b7ce3caaeb90e6998d03108f3f69();
result.InnerFromArray(array);
    return result;
}

public static RL_81c9b7ce3caaeb90e6998d03108f3f69 ToList<T>(T[] array, Func <T, RC_1c2482ce6cd4b83ca44ec0510b231d44> converter) {
  RL_81c9b7ce3caaeb90e6998d03108f3f69 result = new RL_81c9b7ce3caaeb90e6998d03108f3f69();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_81c9b7ce3caaeb90e6998d03108f3f69 FromRestList<T>(RestList<T> restList, Func <T, RC_1c2482ce6cd4b83ca44ec0510b231d44> converter) {
  RL_81c9b7ce3caaeb90e6998d03108f3f69 result = new RL_81c9b7ce3caaeb90e6998d03108f3f69();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_81c9b7ce3caaeb90e6998d03108f3f69() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1c2482ce6cd4b83ca44ec0510b231d44> NewList() {
return new RL_81c9b7ce3caaeb90e6998d03108f3f69();
}


} // RL_81c9b7ce3caaeb90e6998d03108f3f69
}

