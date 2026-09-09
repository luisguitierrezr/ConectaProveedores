namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (1H199SN6fkS7YYZ80PXvRg)
///  <code>RC_0034cf2433ba52d290961e6b42045a29</code> that represent
/// s <code>InvoiceInvoiceApprovalInvoiceStatusCanUploadRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceApprovalInvoiceStatusCanUploadRecord
public partial struct RC_0034cf2433ba52d290961e6b42045a29 : ITypedRecord<RC_0034cf2433ba52d290961e6b42045a29> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdCanUpload = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PuoEPXvijJCHPAVMnJOzCA");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public bool ssCanUpload;


public BitArray OptimizedAttributes;

public RC_0034cf2433ba52d290961e6b42045a29() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssCanUpload = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENInvoiceStatus.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
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
ssENInvoiceApproval.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
ssCanUpload = r.ReadBoolean(index++, "InvoiceInvoiceApprovalInvoiceStatusCanUploadRecord.CanUpload", false);
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
public void ReadIM(RC_0034cf2433ba52d290961e6b42045a29 r) {
this = r;
}


public static bool operator == (RC_0034cf2433ba52d290961e6b42045a29 a, RC_0034cf2433ba52d290961e6b42045a29 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssCanUpload != b.ssCanUpload) return false;
return true;
}

public static bool operator != (RC_0034cf2433ba52d290961e6b42045a29 a, RC_0034cf2433ba52d290961e6b42045a29 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0034cf2433ba52d290961e6b42045a29)) return false;
return (this == (RC_0034cf2433ba52d290961e6b42045a29)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssCanUpload.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
}


public RC_0034cf2433ba52d290961e6b42045a29 Duplicate() {
RC_0034cf2433ba52d290961e6b42045a29 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssCanUpload = this.ssCanUpload;
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
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "canupload") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanUpload")) variable.Value = ssCanUpload; else variable.Optimized = true;
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
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
if (key == IdCanUpload) {
return ssCanUpload;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
if (attributeKey == IdCanUpload.Key.AsGuid) {
return ssCanUpload;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssCanUpload = (bool) other.AttributeGet(IdCanUpload);
}
} // RC_0034cf2433ba52d290961e6b42045a29
/// <summary>
/// RecordList type <code>InvoiceInvoiceApprovalInvoiceStatusCanUploadRecordList</code> that represents
///  a record list of <code>Invoice, InvoiceApproval, InvoiceStatus, Boolean</code>
/// </summary>
public partial class RL_9f948f770ba4600f86dd29332a1a7e00 : GenericRecordList<RC_0034cf2433ba52d290961e6b42045a29>, IEnumerable, IEnumerator {

protected override RC_0034cf2433ba52d290961e6b42045a29 GetElementDefaultValue() {
return new RC_0034cf2433ba52d290961e6b42045a29();
}

public T[] ToArray<T>(Func<RC_0034cf2433ba52d290961e6b42045a29, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9f948f770ba4600f86dd29332a1a7e00 recordList, Func<RC_0034cf2433ba52d290961e6b42045a29, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9f948f770ba4600f86dd29332a1a7e00(RC_0034cf2433ba52d290961e6b42045a29[] array) {
  RL_9f948f770ba4600f86dd29332a1a7e00 result = new RL_9f948f770ba4600f86dd29332a1a7e00();
result.InnerFromArray(array);
    return result;
}

public static RL_9f948f770ba4600f86dd29332a1a7e00 ToList<T>(T[] array, Func <T, RC_0034cf2433ba52d290961e6b42045a29> converter) {
  RL_9f948f770ba4600f86dd29332a1a7e00 result = new RL_9f948f770ba4600f86dd29332a1a7e00();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9f948f770ba4600f86dd29332a1a7e00 FromRestList<T>(RestList<T> restList, Func <T, RC_0034cf2433ba52d290961e6b42045a29> converter) {
  RL_9f948f770ba4600f86dd29332a1a7e00 result = new RL_9f948f770ba4600f86dd29332a1a7e00();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9f948f770ba4600f86dd29332a1a7e00() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0034cf2433ba52d290961e6b42045a29> NewList() {
return new RL_9f948f770ba4600f86dd29332a1a7e00();
}


} // RL_9f948f770ba4600f86dd29332a1a7e00
}

