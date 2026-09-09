namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (p054UlTW20CYUnJUN1Z1Xg)
///  <code>RC_ff169b020f7f52f3fee2c054b741a07f</code> that represent
/// s <code>InvoiceOrderMainInvoiceAccountingProcessRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceOrderMainInvoiceAccountingProcessRecord
public partial struct RC_ff169b020f7f52f3fee2c054b741a07f : ITypedRecord<RC_ff169b020f7f52f3fee2c054b741a07f> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;


public BitArray OptimizedAttributes;

public RC_ff169b020f7f52f3fee2c054b741a07f() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENInvoiceAccountingProcess.OptimizedAttributes;
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
ssENOrderMain.Read( r, ref index);
ssENInvoiceAccountingProcess.Read( r, ref index);
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
public void ReadIM(RC_ff169b020f7f52f3fee2c054b741a07f r) {
this = r;
}


public static bool operator == (RC_ff169b020f7f52f3fee2c054b741a07f a, RC_ff169b020f7f52f3fee2c054b741a07f b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
return true;
}

public static bool operator != (RC_ff169b020f7f52f3fee2c054b741a07f a, RC_ff169b020f7f52f3fee2c054b741a07f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ff169b020f7f52f3fee2c054b741a07f)) return false;
return (this == (RC_ff169b020f7f52f3fee2c054b741a07f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENInvoiceAccountingProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENInvoiceAccountingProcess.InternalRecursiveSave();
}


public RC_ff169b020f7f52f3fee2c054b741a07f Duplicate() {
RC_ff169b020f7f52f3fee2c054b741a07f t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENInvoiceAccountingProcess = (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord)this.ssENInvoiceAccountingProcess.Duplicate();
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
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "invoiceaccountingprocess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcess")) variable.Value = ssENInvoiceAccountingProcess; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocess");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdInvoiceAccountingProcess) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdInvoiceAccountingProcess.Key.AsGuid) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
}
} // RC_ff169b020f7f52f3fee2c054b741a07f
/// <summary>
/// RecordList type <code>InvoiceOrderMainInvoiceAccountingProcessRecordList</code> that represents a
///  record list of <code>Invoice, OrderMain, InvoiceAccountingProcess</code>
/// </summary>
public partial class RL_9ffab0739d7699671c697b53b449a84f : GenericRecordList<RC_ff169b020f7f52f3fee2c054b741a07f>, IEnumerable, IEnumerator {

protected override RC_ff169b020f7f52f3fee2c054b741a07f GetElementDefaultValue() {
return new RC_ff169b020f7f52f3fee2c054b741a07f();
}

public T[] ToArray<T>(Func<RC_ff169b020f7f52f3fee2c054b741a07f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9ffab0739d7699671c697b53b449a84f recordList, Func<RC_ff169b020f7f52f3fee2c054b741a07f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9ffab0739d7699671c697b53b449a84f(RC_ff169b020f7f52f3fee2c054b741a07f[] array) {
  RL_9ffab0739d7699671c697b53b449a84f result = new RL_9ffab0739d7699671c697b53b449a84f();
result.InnerFromArray(array);
    return result;
}

public static RL_9ffab0739d7699671c697b53b449a84f ToList<T>(T[] array, Func <T, RC_ff169b020f7f52f3fee2c054b741a07f> converter) {
  RL_9ffab0739d7699671c697b53b449a84f result = new RL_9ffab0739d7699671c697b53b449a84f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9ffab0739d7699671c697b53b449a84f FromRestList<T>(RestList<T> restList, Func <T, RC_ff169b020f7f52f3fee2c054b741a07f> converter) {
  RL_9ffab0739d7699671c697b53b449a84f result = new RL_9ffab0739d7699671c697b53b449a84f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9ffab0739d7699671c697b53b449a84f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ff169b020f7f52f3fee2c054b741a07f> NewList() {
return new RL_9ffab0739d7699671c697b53b449a84f();
}


} // RL_9ffab0739d7699671c697b53b449a84f
}

