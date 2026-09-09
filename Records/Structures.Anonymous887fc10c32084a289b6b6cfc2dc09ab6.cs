namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DMF_iAgyKEqba2z8LcCatg)
///  <code>RC_93712ae8022b855afd9826482f80eceb</code> that represent
/// s <code>InvoiceRequisitionInvoiceAccountingProcessRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceRequisitionInvoiceAccountingProcessRecord
public partial struct RC_93712ae8022b855afd9826482f80eceb : ITypedRecord<RC_93712ae8022b855afd9826482f80eceb> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;


public BitArray OptimizedAttributes;

public RC_93712ae8022b855afd9826482f80eceb() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_93712ae8022b855afd9826482f80eceb r) {
this = r;
}


public static bool operator == (RC_93712ae8022b855afd9826482f80eceb a, RC_93712ae8022b855afd9826482f80eceb b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
return true;
}

public static bool operator != (RC_93712ae8022b855afd9826482f80eceb a, RC_93712ae8022b855afd9826482f80eceb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_93712ae8022b855afd9826482f80eceb)) return false;
return (this == (RC_93712ae8022b855afd9826482f80eceb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceAccountingProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceAccountingProcess.InternalRecursiveSave();
}


public RC_93712ae8022b855afd9826482f80eceb Duplicate() {
RC_93712ae8022b855afd9826482f80eceb t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdRequisition) {
return ssENRequisition;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceAccountingProcess.Key.AsGuid) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
}
} // RC_93712ae8022b855afd9826482f80eceb
/// <summary>
/// RecordList type <code>InvoiceRequisitionInvoiceAccountingProcessRecordList</code> that represents a
///  record list of <code>Invoice, Requisition, InvoiceAccountingProcess</code>
/// </summary>
public partial class RL_e1821cde66da1d9e887529d6d8944d88 : GenericRecordList<RC_93712ae8022b855afd9826482f80eceb>, IEnumerable, IEnumerator {

protected override RC_93712ae8022b855afd9826482f80eceb GetElementDefaultValue() {
return new RC_93712ae8022b855afd9826482f80eceb();
}

public T[] ToArray<T>(Func<RC_93712ae8022b855afd9826482f80eceb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e1821cde66da1d9e887529d6d8944d88 recordList, Func<RC_93712ae8022b855afd9826482f80eceb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e1821cde66da1d9e887529d6d8944d88(RC_93712ae8022b855afd9826482f80eceb[] array) {
  RL_e1821cde66da1d9e887529d6d8944d88 result = new RL_e1821cde66da1d9e887529d6d8944d88();
result.InnerFromArray(array);
    return result;
}

public static RL_e1821cde66da1d9e887529d6d8944d88 ToList<T>(T[] array, Func <T, RC_93712ae8022b855afd9826482f80eceb> converter) {
  RL_e1821cde66da1d9e887529d6d8944d88 result = new RL_e1821cde66da1d9e887529d6d8944d88();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e1821cde66da1d9e887529d6d8944d88 FromRestList<T>(RestList<T> restList, Func <T, RC_93712ae8022b855afd9826482f80eceb> converter) {
  RL_e1821cde66da1d9e887529d6d8944d88 result = new RL_e1821cde66da1d9e887529d6d8944d88();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e1821cde66da1d9e887529d6d8944d88() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_93712ae8022b855afd9826482f80eceb> NewList() {
return new RL_e1821cde66da1d9e887529d6d8944d88();
}


} // RL_e1821cde66da1d9e887529d6d8944d88
}

