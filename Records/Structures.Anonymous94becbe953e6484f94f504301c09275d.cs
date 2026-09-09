namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6cu+lOZTT0iU9QQwHAknXQ)
///  <code>RC_8d72a852ad297e510ecacc4327468027</code> that represent
/// s <code>InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelRecord
public partial struct RC_8d72a852ad297e510ecacc4327468027 : ITypedRecord<RC_8d72a852ad297e510ecacc4327468027> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OoBCpbF1VpO+gnn7Jp5V+w");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord ssENInvoiceApprovalLevel;


public BitArray OptimizedAttributes;

public RC_8d72a852ad297e510ecacc4327468027() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceApprovalLevel = new EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceApproval.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENInvoiceApprovalLevel.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceApproval.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENInvoiceApprovalLevel.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENInvoiceApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_8d72a852ad297e510ecacc4327468027 r) {
this = r;
}


public static bool operator == (RC_8d72a852ad297e510ecacc4327468027 a, RC_8d72a852ad297e510ecacc4327468027 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceApprovalLevel != b.ssENInvoiceApprovalLevel) return false;
return true;
}

public static bool operator != (RC_8d72a852ad297e510ecacc4327468027 a, RC_8d72a852ad297e510ecacc4327468027 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8d72a852ad297e510ecacc4327468027)) return false;
return (this == (RC_8d72a852ad297e510ecacc4327468027)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceApproval.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceApproval.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceApprovalLevel.InternalRecursiveSave();
}


public RC_8d72a852ad297e510ecacc4327468027 Duplicate() {
RC_8d72a852ad297e510ecacc4327468027 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceApproval = (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord)this.ssENInvoiceApproval.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceApprovalLevel = (EN_6ab2e61b2d49a3c8ae1398437d98dde2EntityRecord)this.ssENInvoiceApprovalLevel.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevel")) variable.Value = ssENInvoiceApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("invoiceapprovallevel");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceApprovalLevel) {
return ssENInvoiceApprovalLevel;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceApprovalLevel.Key.AsGuid) {
return ssENInvoiceApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApprovalLevel));
}
} // RC_8d72a852ad297e510ecacc4327468027
/// <summary>
/// RecordList type <code>InvoiceInvoiceApprovalRequisitionInvoiceApprovalLevelRecordList</code> that
///  represents a record list of <code>Invoice, InvoiceApproval, Requisition
/// , InvoiceApprovalLevel</code>
/// </summary>
public partial class RL_fb6c7f141c4e2073f274935d3ab610b0 : GenericRecordList<RC_8d72a852ad297e510ecacc4327468027>, IEnumerable, IEnumerator {

protected override RC_8d72a852ad297e510ecacc4327468027 GetElementDefaultValue() {
return new RC_8d72a852ad297e510ecacc4327468027();
}

public T[] ToArray<T>(Func<RC_8d72a852ad297e510ecacc4327468027, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fb6c7f141c4e2073f274935d3ab610b0 recordList, Func<RC_8d72a852ad297e510ecacc4327468027, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fb6c7f141c4e2073f274935d3ab610b0(RC_8d72a852ad297e510ecacc4327468027[] array) {
  RL_fb6c7f141c4e2073f274935d3ab610b0 result = new RL_fb6c7f141c4e2073f274935d3ab610b0();
result.InnerFromArray(array);
    return result;
}

public static RL_fb6c7f141c4e2073f274935d3ab610b0 ToList<T>(T[] array, Func <T, RC_8d72a852ad297e510ecacc4327468027> converter) {
  RL_fb6c7f141c4e2073f274935d3ab610b0 result = new RL_fb6c7f141c4e2073f274935d3ab610b0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fb6c7f141c4e2073f274935d3ab610b0 FromRestList<T>(RestList<T> restList, Func <T, RC_8d72a852ad297e510ecacc4327468027> converter) {
  RL_fb6c7f141c4e2073f274935d3ab610b0 result = new RL_fb6c7f141c4e2073f274935d3ab610b0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fb6c7f141c4e2073f274935d3ab610b0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(24,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8d72a852ad297e510ecacc4327468027> NewList() {
return new RL_fb6c7f141c4e2073f274935d3ab610b0();
}


} // RL_fb6c7f141c4e2073f274935d3ab610b0
}

