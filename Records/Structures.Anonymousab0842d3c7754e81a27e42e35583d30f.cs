namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (00IIq3XHgU6ifkLjVYPTDw)
///  <code>RC_23a1d959d7c6821c1ced3d87b6f84ab7</code> that represent
/// s <code>InvoiceInvoiceAccountingProcessRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceAccountingProcessRecord
public partial struct RC_23a1d959d7c6821c1ced3d87b6f84ab7 : ITypedRecord<RC_23a1d959d7c6821c1ced3d87b6f84ab7> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;


public BitArray OptimizedAttributes;

public RC_23a1d959d7c6821c1ced3d87b6f84ab7() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceAccountingProcess.OptimizedAttributes;
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
public void ReadIM(RC_23a1d959d7c6821c1ced3d87b6f84ab7 r) {
this = r;
}


public static bool operator == (RC_23a1d959d7c6821c1ced3d87b6f84ab7 a, RC_23a1d959d7c6821c1ced3d87b6f84ab7 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
return true;
}

public static bool operator != (RC_23a1d959d7c6821c1ced3d87b6f84ab7 a, RC_23a1d959d7c6821c1ced3d87b6f84ab7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_23a1d959d7c6821c1ced3d87b6f84ab7)) return false;
return (this == (RC_23a1d959d7c6821c1ced3d87b6f84ab7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceAccountingProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceAccountingProcess.InternalRecursiveSave();
}


public RC_23a1d959d7c6821c1ced3d87b6f84ab7 Duplicate() {
RC_23a1d959d7c6821c1ced3d87b6f84ab7 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
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
if (key == IdInvoiceAccountingProcess) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceAccountingProcess.Key.AsGuid) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
}
} // RC_23a1d959d7c6821c1ced3d87b6f84ab7
/// <summary>
/// RecordList type <code>InvoiceInvoiceAccountingProcessRecordList</code> that represents a record
///  list of <code>Invoice, InvoiceAccountingProcess</code>
/// </summary>
public partial class RL_5b87df59357fc2d11e377efaebb2d7d6 : GenericRecordList<RC_23a1d959d7c6821c1ced3d87b6f84ab7>, IEnumerable, IEnumerator {

protected override RC_23a1d959d7c6821c1ced3d87b6f84ab7 GetElementDefaultValue() {
return new RC_23a1d959d7c6821c1ced3d87b6f84ab7();
}

public T[] ToArray<T>(Func<RC_23a1d959d7c6821c1ced3d87b6f84ab7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5b87df59357fc2d11e377efaebb2d7d6 recordList, Func<RC_23a1d959d7c6821c1ced3d87b6f84ab7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5b87df59357fc2d11e377efaebb2d7d6(RC_23a1d959d7c6821c1ced3d87b6f84ab7[] array) {
  RL_5b87df59357fc2d11e377efaebb2d7d6 result = new RL_5b87df59357fc2d11e377efaebb2d7d6();
result.InnerFromArray(array);
    return result;
}

public static RL_5b87df59357fc2d11e377efaebb2d7d6 ToList<T>(T[] array, Func <T, RC_23a1d959d7c6821c1ced3d87b6f84ab7> converter) {
  RL_5b87df59357fc2d11e377efaebb2d7d6 result = new RL_5b87df59357fc2d11e377efaebb2d7d6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5b87df59357fc2d11e377efaebb2d7d6 FromRestList<T>(RestList<T> restList, Func <T, RC_23a1d959d7c6821c1ced3d87b6f84ab7> converter) {
  RL_5b87df59357fc2d11e377efaebb2d7d6 result = new RL_5b87df59357fc2d11e377efaebb2d7d6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5b87df59357fc2d11e377efaebb2d7d6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(24,false);
def[1] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_23a1d959d7c6821c1ced3d87b6f84ab7> NewList() {
return new RL_5b87df59357fc2d11e377efaebb2d7d6();
}


} // RL_5b87df59357fc2d11e377efaebb2d7d6
}

