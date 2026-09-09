namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (iGinBlgTlkym2SP7yXZj+A)
///  <code>RC_8ecd20e9afb5cd14c3f1aea1a6262374</code> that represents <code>InvoiceApprovalRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceApprovalRecord
public partial struct RC_8ecd20e9afb5cd14c3f1aea1a6262374 : ITypedRecord<RC_8ecd20e9afb5cd14c3f1aea1a6262374> {
internal static readonly GlobalObjectKey IdInvoiceApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6SDNjrWvFM3D8a6hpiYjdA");

public EN_c2bd0675fed3aedb585c484c59155eddEntityRecord ssENInvoiceApproval;


public static implicit operator EN_c2bd0675fed3aedb585c484c59155eddEntityRecord( RC_8ecd20e9afb5cd14c3f1aea1a6262374 r) {
return r.ssENInvoiceApproval;
}

public static implicit operator RC_8ecd20e9afb5cd14c3f1aea1a6262374 (EN_c2bd0675fed3aedb585c484c59155eddEntityRecord r) {
RC_8ecd20e9afb5cd14c3f1aea1a6262374 res = new RC_8ecd20e9afb5cd14c3f1aea1a6262374 ();
res.ssENInvoiceApproval = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceApproval.ChangedAttributes = value;
}
get {
    return ssENInvoiceApproval.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_8ecd20e9afb5cd14c3f1aea1a6262374() {
OptimizedAttributes = null;
ssENInvoiceApproval = new EN_c2bd0675fed3aedb585c484c59155eddEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceApproval.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_8ecd20e9afb5cd14c3f1aea1a6262374 r) {
this = r;
}


public static bool operator == (RC_8ecd20e9afb5cd14c3f1aea1a6262374 a, RC_8ecd20e9afb5cd14c3f1aea1a6262374 b) {
if (a.ssENInvoiceApproval != b.ssENInvoiceApproval) return false;
return true;
}

public static bool operator != (RC_8ecd20e9afb5cd14c3f1aea1a6262374 a, RC_8ecd20e9afb5cd14c3f1aea1a6262374 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8ecd20e9afb5cd14c3f1aea1a6262374)) return false;
return (this == (RC_8ecd20e9afb5cd14c3f1aea1a6262374)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceApproval.InternalRecursiveSave();
}


public RC_8ecd20e9afb5cd14c3f1aea1a6262374 Duplicate() {
RC_8ecd20e9afb5cd14c3f1aea1a6262374 t;
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
if (head == "invoiceapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApproval")) variable.Value = ssENInvoiceApproval; else variable.Optimized = true;
variable.SetFieldName("invoiceapproval");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceApproval.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceApproval.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceApproval) {
return ssENInvoiceApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceApproval.Key.AsGuid) {
return ssENInvoiceApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceApproval.FillFromOther((IRecord) other.AttributeGet(IdInvoiceApproval));
}
} // RC_8ecd20e9afb5cd14c3f1aea1a6262374
/// <summary>
/// RecordList type <code>InvoiceApprovalRecordList</code> that represents a record list of
///  <code>InvoiceApproval</code>
/// </summary>
public partial class RL_b496b6dad8a76ef02aafdb1cf78f19ec : GenericRecordList<RC_8ecd20e9afb5cd14c3f1aea1a6262374>, IEnumerable, IEnumerator {

protected override RC_8ecd20e9afb5cd14c3f1aea1a6262374 GetElementDefaultValue() {
return new RC_8ecd20e9afb5cd14c3f1aea1a6262374();
}

public T[] ToArray<T>(Func<RC_8ecd20e9afb5cd14c3f1aea1a6262374, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b496b6dad8a76ef02aafdb1cf78f19ec recordList, Func<RC_8ecd20e9afb5cd14c3f1aea1a6262374, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b496b6dad8a76ef02aafdb1cf78f19ec(RC_8ecd20e9afb5cd14c3f1aea1a6262374[] array) {
  RL_b496b6dad8a76ef02aafdb1cf78f19ec result = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
result.InnerFromArray(array);
    return result;
}

public static RL_b496b6dad8a76ef02aafdb1cf78f19ec ToList<T>(T[] array, Func <T, RC_8ecd20e9afb5cd14c3f1aea1a6262374> converter) {
  RL_b496b6dad8a76ef02aafdb1cf78f19ec result = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b496b6dad8a76ef02aafdb1cf78f19ec FromRestList<T>(RestList<T> restList, Func <T, RC_8ecd20e9afb5cd14c3f1aea1a6262374> converter) {
  RL_b496b6dad8a76ef02aafdb1cf78f19ec result = new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b496b6dad8a76ef02aafdb1cf78f19ec() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8ecd20e9afb5cd14c3f1aea1a6262374> NewList() {
return new RL_b496b6dad8a76ef02aafdb1cf78f19ec();
}


} // RL_b496b6dad8a76ef02aafdb1cf78f19ec
}

