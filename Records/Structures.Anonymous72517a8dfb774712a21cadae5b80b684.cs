namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (jXpRcnf7EkeiHK2uW4C2hA)
///  <code>RC_bf8addab42f215a7fe4584fe7162ae78</code> that represent
/// s <code>RequisitionInvoiceAccountingProcessRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionInvoiceAccountingProcessRecord
public partial struct RC_bf8addab42f215a7fe4584fe7162ae78 : ITypedRecord<RC_bf8addab42f215a7fe4584fe7162ae78> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;


public BitArray OptimizedAttributes;

public RC_bf8addab42f215a7fe4584fe7162ae78() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisition.OptimizedAttributes;
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
public void ReadIM(RC_bf8addab42f215a7fe4584fe7162ae78 r) {
this = r;
}


public static bool operator == (RC_bf8addab42f215a7fe4584fe7162ae78 a, RC_bf8addab42f215a7fe4584fe7162ae78 b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
return true;
}

public static bool operator != (RC_bf8addab42f215a7fe4584fe7162ae78 a, RC_bf8addab42f215a7fe4584fe7162ae78 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bf8addab42f215a7fe4584fe7162ae78)) return false;
return (this == (RC_bf8addab42f215a7fe4584fe7162ae78)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENInvoiceAccountingProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENInvoiceAccountingProcess.InternalRecursiveSave();
}


public RC_bf8addab42f215a7fe4584fe7162ae78 Duplicate() {
RC_bf8addab42f215a7fe4584fe7162ae78 t;
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
if (head == "requisition") {
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceAccountingProcess) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
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
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
}
} // RC_bf8addab42f215a7fe4584fe7162ae78
/// <summary>
/// RecordList type <code>RequisitionInvoiceAccountingProcessRecordList</code> that represents a record
///  list of <code>Requisition, InvoiceAccountingProcess</code>
/// </summary>
public partial class RL_00bd7d2e1d6477607f48fdc5409b4a65 : GenericRecordList<RC_bf8addab42f215a7fe4584fe7162ae78>, IEnumerable, IEnumerator {

protected override RC_bf8addab42f215a7fe4584fe7162ae78 GetElementDefaultValue() {
return new RC_bf8addab42f215a7fe4584fe7162ae78();
}

public T[] ToArray<T>(Func<RC_bf8addab42f215a7fe4584fe7162ae78, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_00bd7d2e1d6477607f48fdc5409b4a65 recordList, Func<RC_bf8addab42f215a7fe4584fe7162ae78, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_00bd7d2e1d6477607f48fdc5409b4a65(RC_bf8addab42f215a7fe4584fe7162ae78[] array) {
  RL_00bd7d2e1d6477607f48fdc5409b4a65 result = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
result.InnerFromArray(array);
    return result;
}

public static RL_00bd7d2e1d6477607f48fdc5409b4a65 ToList<T>(T[] array, Func <T, RC_bf8addab42f215a7fe4584fe7162ae78> converter) {
  RL_00bd7d2e1d6477607f48fdc5409b4a65 result = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_00bd7d2e1d6477607f48fdc5409b4a65 FromRestList<T>(RestList<T> restList, Func <T, RC_bf8addab42f215a7fe4584fe7162ae78> converter) {
  RL_00bd7d2e1d6477607f48fdc5409b4a65 result = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_00bd7d2e1d6477607f48fdc5409b4a65() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(58,false);
def[1] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bf8addab42f215a7fe4584fe7162ae78> NewList() {
return new RL_00bd7d2e1d6477607f48fdc5409b4a65();
}


} // RL_00bd7d2e1d6477607f48fdc5409b4a65
}

