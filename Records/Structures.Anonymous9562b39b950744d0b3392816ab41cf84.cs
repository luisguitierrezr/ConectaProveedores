namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (m7NilQeV0ESzOSgWq0HPhA)
///  <code>RC_426e2c309e94de792ac54a8e3665e09a</code> that represent
/// s <code>InvoiceInvoice_CNInvoiceStatusRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoice_CNInvoiceStatusRecord
public partial struct RC_426e2c309e94de792ac54a8e3665e09a : ITypedRecord<RC_426e2c309e94de792ac54a8e3665e09a> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoice_CN = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*H_R5HZrmYoYC9Pq5rdjlpw");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice_CN;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;


public BitArray OptimizedAttributes;

public RC_426e2c309e94de792ac54a8e3665e09a() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoice_CN = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice_CN.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoice_CN.OptimizedAttributes = value[1];
    ssENInvoiceStatus.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoice_CN.OptimizedAttributes;
    all[2] = ssENInvoiceStatus.OptimizedAttributes;
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
ssENInvoice_CN.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
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
public void ReadIM(RC_426e2c309e94de792ac54a8e3665e09a r) {
this = r;
}


public static bool operator == (RC_426e2c309e94de792ac54a8e3665e09a a, RC_426e2c309e94de792ac54a8e3665e09a b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoice_CN != b.ssENInvoice_CN) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
return true;
}

public static bool operator != (RC_426e2c309e94de792ac54a8e3665e09a a, RC_426e2c309e94de792ac54a8e3665e09a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_426e2c309e94de792ac54a8e3665e09a)) return false;
return (this == (RC_426e2c309e94de792ac54a8e3665e09a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoice_CN.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoice_CN.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoice_CN.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
}


public RC_426e2c309e94de792ac54a8e3665e09a Duplicate() {
RC_426e2c309e94de792ac54a8e3665e09a t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoice_CN = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice_CN.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
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
} else if (head == "invoice_cn") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice_CN")) variable.Value = ssENInvoice_CN; else variable.Optimized = true;
variable.SetFieldName("invoice_cn");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
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
if (key == IdInvoice_CN) {
return ssENInvoice_CN;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoice_CN.Key.AsGuid) {
return ssENInvoice_CN;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoice_CN.FillFromOther((IRecord) other.AttributeGet(IdInvoice_CN));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
}
} // RC_426e2c309e94de792ac54a8e3665e09a
/// <summary>
/// RecordList type <code>InvoiceInvoice_CNInvoiceStatusRecordList</code> that represents a record list
///  of <code>Invoice, Invoice, InvoiceStatus</code>
/// </summary>
public partial class RL_963435a7e2b76a25c650ba38c8633cf8 : GenericRecordList<RC_426e2c309e94de792ac54a8e3665e09a>, IEnumerable, IEnumerator {

protected override RC_426e2c309e94de792ac54a8e3665e09a GetElementDefaultValue() {
return new RC_426e2c309e94de792ac54a8e3665e09a();
}

public T[] ToArray<T>(Func<RC_426e2c309e94de792ac54a8e3665e09a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_963435a7e2b76a25c650ba38c8633cf8 recordList, Func<RC_426e2c309e94de792ac54a8e3665e09a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_963435a7e2b76a25c650ba38c8633cf8(RC_426e2c309e94de792ac54a8e3665e09a[] array) {
  RL_963435a7e2b76a25c650ba38c8633cf8 result = new RL_963435a7e2b76a25c650ba38c8633cf8();
result.InnerFromArray(array);
    return result;
}

public static RL_963435a7e2b76a25c650ba38c8633cf8 ToList<T>(T[] array, Func <T, RC_426e2c309e94de792ac54a8e3665e09a> converter) {
  RL_963435a7e2b76a25c650ba38c8633cf8 result = new RL_963435a7e2b76a25c650ba38c8633cf8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_963435a7e2b76a25c650ba38c8633cf8 FromRestList<T>(RestList<T> restList, Func <T, RC_426e2c309e94de792ac54a8e3665e09a> converter) {
  RL_963435a7e2b76a25c650ba38c8633cf8 result = new RL_963435a7e2b76a25c650ba38c8633cf8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_963435a7e2b76a25c650ba38c8633cf8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_426e2c309e94de792ac54a8e3665e09a> NewList() {
return new RL_963435a7e2b76a25c650ba38c8633cf8();
}


} // RL_963435a7e2b76a25c650ba38c8633cf8
}

