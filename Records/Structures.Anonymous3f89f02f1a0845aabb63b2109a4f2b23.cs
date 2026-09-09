namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (L_CJPwgaqkW7Y7IQmk8rIw)
///  <code>RC_bec85b4f53f0fb643f61e8bb4fa47a4b</code> that represent
/// s <code>InvoiceAccountingProcessResponseInvoiceAccountingProcessRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingProcessResponseInvoiceAccountingProcessRecord
public partial struct RC_bec85b4f53f0fb643f61e8bb4fa47a4b : ITypedRecord<RC_bec85b4f53f0fb643f61e8bb4fa47a4b> {
internal static readonly GlobalObjectKey IdInvoiceAccountingProcessResponse = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SX8sjXZOVD3+sTgQTDQa2w");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");

public EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord ssENInvoiceAccountingProcessResponse;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;


public BitArray OptimizedAttributes;

public RC_bec85b4f53f0fb643f61e8bb4fa47a4b() {
OptimizedAttributes = null;
ssENInvoiceAccountingProcessResponse = new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord();
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingProcessResponse.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoiceAccountingProcessResponse.OptimizedAttributes = value[0];
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoiceAccountingProcessResponse.OptimizedAttributes;
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
ssENInvoiceAccountingProcessResponse.Read( r, ref index);
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
public void ReadIM(RC_bec85b4f53f0fb643f61e8bb4fa47a4b r) {
this = r;
}


public static bool operator == (RC_bec85b4f53f0fb643f61e8bb4fa47a4b a, RC_bec85b4f53f0fb643f61e8bb4fa47a4b b) {
if (a.ssENInvoiceAccountingProcessResponse != b.ssENInvoiceAccountingProcessResponse) return false;
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
return true;
}

public static bool operator != (RC_bec85b4f53f0fb643f61e8bb4fa47a4b a, RC_bec85b4f53f0fb643f61e8bb4fa47a4b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bec85b4f53f0fb643f61e8bb4fa47a4b)) return false;
return (this == (RC_bec85b4f53f0fb643f61e8bb4fa47a4b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingProcessResponse.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingProcessResponse.RecursiveReset();
ssENInvoiceAccountingProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingProcessResponse.InternalRecursiveSave();
ssENInvoiceAccountingProcess.InternalRecursiveSave();
}


public RC_bec85b4f53f0fb643f61e8bb4fa47a4b Duplicate() {
RC_bec85b4f53f0fb643f61e8bb4fa47a4b t;
t.ssENInvoiceAccountingProcessResponse = (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord)this.ssENInvoiceAccountingProcessResponse.Duplicate();
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
if (head == "invoiceaccountingprocessresponse") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcessResponse")) variable.Value = ssENInvoiceAccountingProcessResponse; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocessresponse");
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
if (key == IdInvoiceAccountingProcessResponse) {
return ssENInvoiceAccountingProcessResponse;
}
if (key == IdInvoiceAccountingProcess) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingProcessResponse.Key.AsGuid) {
return ssENInvoiceAccountingProcessResponse;
}
if (attributeKey == IdInvoiceAccountingProcess.Key.AsGuid) {
return ssENInvoiceAccountingProcess;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingProcessResponse.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcessResponse));
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
}
} // RC_bec85b4f53f0fb643f61e8bb4fa47a4b
/// <summary>
/// RecordList type <code>InvoiceAccountingProcessResponseInvoiceAccountingProcessRecordList</code>
///  that represents a record list of <code>InvoiceAccountingProcessResponse
/// , InvoiceAccountingProcess</code>
/// </summary>
public partial class RL_1337c15efa2eafb36e59edff0fd662c9 : GenericRecordList<RC_bec85b4f53f0fb643f61e8bb4fa47a4b>, IEnumerable, IEnumerator {

protected override RC_bec85b4f53f0fb643f61e8bb4fa47a4b GetElementDefaultValue() {
return new RC_bec85b4f53f0fb643f61e8bb4fa47a4b();
}

public T[] ToArray<T>(Func<RC_bec85b4f53f0fb643f61e8bb4fa47a4b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1337c15efa2eafb36e59edff0fd662c9 recordList, Func<RC_bec85b4f53f0fb643f61e8bb4fa47a4b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1337c15efa2eafb36e59edff0fd662c9(RC_bec85b4f53f0fb643f61e8bb4fa47a4b[] array) {
  RL_1337c15efa2eafb36e59edff0fd662c9 result = new RL_1337c15efa2eafb36e59edff0fd662c9();
result.InnerFromArray(array);
    return result;
}

public static RL_1337c15efa2eafb36e59edff0fd662c9 ToList<T>(T[] array, Func <T, RC_bec85b4f53f0fb643f61e8bb4fa47a4b> converter) {
  RL_1337c15efa2eafb36e59edff0fd662c9 result = new RL_1337c15efa2eafb36e59edff0fd662c9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1337c15efa2eafb36e59edff0fd662c9 FromRestList<T>(RestList<T> restList, Func <T, RC_bec85b4f53f0fb643f61e8bb4fa47a4b> converter) {
  RL_1337c15efa2eafb36e59edff0fd662c9 result = new RL_1337c15efa2eafb36e59edff0fd662c9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1337c15efa2eafb36e59edff0fd662c9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(6,false);
def[1] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bec85b4f53f0fb643f61e8bb4fa47a4b> NewList() {
return new RL_1337c15efa2eafb36e59edff0fd662c9();
}


} // RL_1337c15efa2eafb36e59edff0fd662c9
}

