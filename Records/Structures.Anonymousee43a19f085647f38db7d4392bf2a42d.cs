namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (n6FD7lYI80eNt9Q5K_KkLQ)
///  <code>RC_0bd21c095360ef78cf6d0f1777ecf52a</code> that represent
/// s <code>ApprovalProcessInvoiceInvoiceApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalProcessInvoiceInvoiceApprovalRecord
public partial struct RC_0bd21c095360ef78cf6d0f1777ecf52a : ITypedRecord<RC_0bd21c095360ef78cf6d0f1777ecf52a> {
internal static readonly GlobalObjectKey IdApprovalProcess = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uHi98ulqoLu0bMXYgUg0rw");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");

public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord ssENApprovalProcess;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;


public BitArray OptimizedAttributes;

public RC_0bd21c095360ef78cf6d0f1777ecf52a() {
OptimizedAttributes = null;
ssENApprovalProcess = new EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(19,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApprovalProcess.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENApprovalProcess.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceApproval.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENApprovalProcess.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApprovalProcess.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENInvoiceApproval.Read( r, ref index);
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
public void ReadIM(RC_0bd21c095360ef78cf6d0f1777ecf52a r) {
this = r;
}


public static bool operator == (RC_0bd21c095360ef78cf6d0f1777ecf52a a, RC_0bd21c095360ef78cf6d0f1777ecf52a b) {
if (a.ssENApprovalProcess != b.ssENApprovalProcess) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
return true;
}

public static bool operator != (RC_0bd21c095360ef78cf6d0f1777ecf52a a, RC_0bd21c095360ef78cf6d0f1777ecf52a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0bd21c095360ef78cf6d0f1777ecf52a)) return false;
return (this == (RC_0bd21c095360ef78cf6d0f1777ecf52a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApprovalProcess.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApprovalProcess.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApprovalProcess.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
}


public RC_0bd21c095360ef78cf6d0f1777ecf52a Duplicate() {
RC_0bd21c095360ef78cf6d0f1777ecf52a t;
t.ssENApprovalProcess = (EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)this.ssENApprovalProcess.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
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
if (head == "approvalprocess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalProcess")) variable.Value = ssENApprovalProcess; else variable.Optimized = true;
variable.SetFieldName("approvalprocess");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
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
if (key == IdApprovalProcess) {
return ssENApprovalProcess;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalProcess.Key.AsGuid) {
return ssENApprovalProcess;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApprovalProcess.FillFromOther((IRecord) other.AttributeGet(IdApprovalProcess));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
}
} // RC_0bd21c095360ef78cf6d0f1777ecf52a
/// <summary>
/// RecordList type <code>ApprovalProcessInvoiceInvoiceApprovalRecordList</code> that represents a
///  record list of <code>ApprovalProcess, Invoice, InvoiceApproval</code>
/// </summary>
public partial class RL_41aa9995b50bccef3903021154e98b17 : GenericRecordList<RC_0bd21c095360ef78cf6d0f1777ecf52a>, IEnumerable, IEnumerator {

protected override RC_0bd21c095360ef78cf6d0f1777ecf52a GetElementDefaultValue() {
return new RC_0bd21c095360ef78cf6d0f1777ecf52a();
}

public T[] ToArray<T>(Func<RC_0bd21c095360ef78cf6d0f1777ecf52a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_41aa9995b50bccef3903021154e98b17 recordList, Func<RC_0bd21c095360ef78cf6d0f1777ecf52a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_41aa9995b50bccef3903021154e98b17(RC_0bd21c095360ef78cf6d0f1777ecf52a[] array) {
  RL_41aa9995b50bccef3903021154e98b17 result = new RL_41aa9995b50bccef3903021154e98b17();
result.InnerFromArray(array);
    return result;
}

public static RL_41aa9995b50bccef3903021154e98b17 ToList<T>(T[] array, Func <T, RC_0bd21c095360ef78cf6d0f1777ecf52a> converter) {
  RL_41aa9995b50bccef3903021154e98b17 result = new RL_41aa9995b50bccef3903021154e98b17();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_41aa9995b50bccef3903021154e98b17 FromRestList<T>(RestList<T> restList, Func <T, RC_0bd21c095360ef78cf6d0f1777ecf52a> converter) {
  RL_41aa9995b50bccef3903021154e98b17 result = new RL_41aa9995b50bccef3903021154e98b17();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_41aa9995b50bccef3903021154e98b17() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(19,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0bd21c095360ef78cf6d0f1777ecf52a> NewList() {
return new RL_41aa9995b50bccef3903021154e98b17();
}


} // RL_41aa9995b50bccef3903021154e98b17
}

