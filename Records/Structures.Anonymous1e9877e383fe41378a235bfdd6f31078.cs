namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (43eYHv6DN0GKI1v91vMQeA)
///  <code>RC_5c7aa2d527f88af9496e24408ac97c64</code> that represent
/// s <code>InvoiceInvoiceAccountingProcessResponseInvoiceAccountingProcessRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceAccountingProcessResponseInvoiceAccountingProcessRecord
public partial struct RC_5c7aa2d527f88af9496e24408ac97c64 : ITypedRecord<RC_5c7aa2d527f88af9496e24408ac97c64> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcessResponse = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SX8sjXZOVD3+sTgQTDQa2w");
internal static readonly GlobalObjectKey IdInvoiceAccountingProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*B5oc0LwOfgkyoSjhtBJcwg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord ssENInvoiceAccountingProcessResponse;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord ssENInvoiceAccountingProcess;


public BitArray OptimizedAttributes;

public RC_5c7aa2d527f88af9496e24408ac97c64() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceAccountingProcessResponse = new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord();
ssENInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceAccountingProcessResponse.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceAccountingProcessResponse.OptimizedAttributes = value[1];
    ssENInvoiceAccountingProcess.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceAccountingProcessResponse.OptimizedAttributes;
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
public void ReadIM(RC_5c7aa2d527f88af9496e24408ac97c64 r) {
this = r;
}


public static bool operator == (RC_5c7aa2d527f88af9496e24408ac97c64 a, RC_5c7aa2d527f88af9496e24408ac97c64 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceAccountingProcessResponse != b.ssENInvoiceAccountingProcessResponse) return false;
if (a.ssENInvoiceAccountingProcess != b.ssENInvoiceAccountingProcess) return false;
return true;
}

public static bool operator != (RC_5c7aa2d527f88af9496e24408ac97c64 a, RC_5c7aa2d527f88af9496e24408ac97c64 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5c7aa2d527f88af9496e24408ac97c64)) return false;
return (this == (RC_5c7aa2d527f88af9496e24408ac97c64)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceAccountingProcessResponse.GetHashCode()
 ^ ssENInvoiceAccountingProcess.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceAccountingProcessResponse.RecursiveReset();
ssENInvoiceAccountingProcess.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceAccountingProcessResponse.InternalRecursiveSave();
ssENInvoiceAccountingProcess.InternalRecursiveSave();
}


public RC_5c7aa2d527f88af9496e24408ac97c64 Duplicate() {
RC_5c7aa2d527f88af9496e24408ac97c64 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoiceaccountingprocessresponse") {
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceAccountingProcessResponse) {
return ssENInvoiceAccountingProcessResponse;
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
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceAccountingProcessResponse.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcessResponse));
ssENInvoiceAccountingProcess.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcess));
}
} // RC_5c7aa2d527f88af9496e24408ac97c64
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceAccountingProcessResponseInvoiceAccountingProcessRecordList</code> tha
/// t represents a record list of <code>Invoice, InvoiceAccountingProcessResponse,
///  InvoiceAccountingProcess</code>
/// </summary>
public partial class RL_2df25a5fccd9d0f976dc8e12fe39e37c : GenericRecordList<RC_5c7aa2d527f88af9496e24408ac97c64>, IEnumerable, IEnumerator {

protected override RC_5c7aa2d527f88af9496e24408ac97c64 GetElementDefaultValue() {
return new RC_5c7aa2d527f88af9496e24408ac97c64();
}

public T[] ToArray<T>(Func<RC_5c7aa2d527f88af9496e24408ac97c64, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2df25a5fccd9d0f976dc8e12fe39e37c recordList, Func<RC_5c7aa2d527f88af9496e24408ac97c64, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2df25a5fccd9d0f976dc8e12fe39e37c(RC_5c7aa2d527f88af9496e24408ac97c64[] array) {
  RL_2df25a5fccd9d0f976dc8e12fe39e37c result = new RL_2df25a5fccd9d0f976dc8e12fe39e37c();
result.InnerFromArray(array);
    return result;
}

public static RL_2df25a5fccd9d0f976dc8e12fe39e37c ToList<T>(T[] array, Func <T, RC_5c7aa2d527f88af9496e24408ac97c64> converter) {
  RL_2df25a5fccd9d0f976dc8e12fe39e37c result = new RL_2df25a5fccd9d0f976dc8e12fe39e37c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2df25a5fccd9d0f976dc8e12fe39e37c FromRestList<T>(RestList<T> restList, Func <T, RC_5c7aa2d527f88af9496e24408ac97c64> converter) {
  RL_2df25a5fccd9d0f976dc8e12fe39e37c result = new RL_2df25a5fccd9d0f976dc8e12fe39e37c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2df25a5fccd9d0f976dc8e12fe39e37c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5c7aa2d527f88af9496e24408ac97c64> NewList() {
return new RL_2df25a5fccd9d0f976dc8e12fe39e37c();
}


} // RL_2df25a5fccd9d0f976dc8e12fe39e37c
}

