namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (TRS6DFnVDkarLN9v3ILyVw)
///  <code>RC_d01c9a070ebc097e32a128e1b4125cc2</code> that represent
/// s <code>InvoiceAccountingProcessRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingProcessRecord
public partial struct RC_d01c9a070ebc097e32a128e1b4125cc2 : ITypedRecord<RC_d01c9a070ebc097e32a128e1b4125cc2> {
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;


public static implicit operator EN_d21666375df829d28ffce8e5e0a3400dEntityRecord( RC_d01c9a070ebc097e32a128e1b4125cc2 r) {
return r.ssENInvoiceAccountingProcess;
}

public static implicit operator RC_d01c9a070ebc097e32a128e1b4125cc2 (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord r) {
RC_d01c9a070ebc097e32a128e1b4125cc2 res = new RC_d01c9a070ebc097e32a128e1b4125cc2 ();
res.ssENInvoiceAccountingProcess = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceAccountingProcess.ChangedAttributes = value;
}
get {
    return ssENInvoiceAccountingProcess.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d01c9a070ebc097e32a128e1b4125cc2() {
OptimizedAttributes = null;
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccountingProcess.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_d01c9a070ebc097e32a128e1b4125cc2 r) {
this = r;
}


public static bool operator == (RC_d01c9a070ebc097e32a128e1b4125cc2 a, RC_d01c9a070ebc097e32a128e1b4125cc2 b) {
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
return true;
}

public static bool operator != (RC_d01c9a070ebc097e32a128e1b4125cc2 a, RC_d01c9a070ebc097e32a128e1b4125cc2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d01c9a070ebc097e32a128e1b4125cc2)) return false;
return (this == (RC_d01c9a070ebc097e32a128e1b4125cc2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingProcess.InternalRecursiveSave();
}


public RC_d01c9a070ebc097e32a128e1b4125cc2 Duplicate() {
RC_d01c9a070ebc097e32a128e1b4125cc2 t;
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
if (head == "invoiceaccountingprocess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcess")) variable.Value = ssENInvoiceAccountingProcess; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocess");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcess.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcess.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingProcess) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingProcess.Key.AsGuid) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
}
} // RC_d01c9a070ebc097e32a128e1b4125cc2
/// <summary>
/// RecordList type <code>InvoiceAccountingProcessRecordList</code> that represents a record list of
///  <code>InvoiceAccountingProcess</code>
/// </summary>
public partial class RL_4e909af3a15d1687c03c789af38db7ae : GenericRecordList<RC_d01c9a070ebc097e32a128e1b4125cc2>, IEnumerable, IEnumerator {

protected override RC_d01c9a070ebc097e32a128e1b4125cc2 GetElementDefaultValue() {
return new RC_d01c9a070ebc097e32a128e1b4125cc2();
}

public T[] ToArray<T>(Func<RC_d01c9a070ebc097e32a128e1b4125cc2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4e909af3a15d1687c03c789af38db7ae recordList, Func<RC_d01c9a070ebc097e32a128e1b4125cc2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4e909af3a15d1687c03c789af38db7ae(RC_d01c9a070ebc097e32a128e1b4125cc2[] array) {
  RL_4e909af3a15d1687c03c789af38db7ae result = new RL_4e909af3a15d1687c03c789af38db7ae();
result.InnerFromArray(array);
    return result;
}

public static RL_4e909af3a15d1687c03c789af38db7ae ToList<T>(T[] array, Func <T, RC_d01c9a070ebc097e32a128e1b4125cc2> converter) {
  RL_4e909af3a15d1687c03c789af38db7ae result = new RL_4e909af3a15d1687c03c789af38db7ae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4e909af3a15d1687c03c789af38db7ae FromRestList<T>(RestList<T> restList, Func <T, RC_d01c9a070ebc097e32a128e1b4125cc2> converter) {
  RL_4e909af3a15d1687c03c789af38db7ae result = new RL_4e909af3a15d1687c03c789af38db7ae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4e909af3a15d1687c03c789af38db7ae() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d01c9a070ebc097e32a128e1b4125cc2> NewList() {
return new RL_4e909af3a15d1687c03c789af38db7ae();
}


} // RL_4e909af3a15d1687c03c789af38db7ae
}

