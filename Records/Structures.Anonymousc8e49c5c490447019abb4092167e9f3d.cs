namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (XJzkyARJAUeau0CSFn6fPQ)
///  <code>RC_1a5b8cd0ef1115d2fdd242fac41124bc</code> that represent
/// s <code>InvoiceFilesAuditRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceFilesAuditRecord
public partial struct RC_1a5b8cd0ef1115d2fdd242fac41124bc : ITypedRecord<RC_1a5b8cd0ef1115d2fdd242fac41124bc> {
internal static readonly GlobalObjectKey IdInvoiceFilesAudit = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0IxbGhHv0hX90kL6xBEkvA");

public ST_29dc80a5deae2388e31181e1082143cfStructure ssSTInvoiceFilesAudit;


public static implicit operator ST_29dc80a5deae2388e31181e1082143cfStructure( RC_1a5b8cd0ef1115d2fdd242fac41124bc r) {
return r.ssSTInvoiceFilesAudit;
}

public static implicit operator RC_1a5b8cd0ef1115d2fdd242fac41124bc (ST_29dc80a5deae2388e31181e1082143cfStructure r) {
RC_1a5b8cd0ef1115d2fdd242fac41124bc res = new RC_1a5b8cd0ef1115d2fdd242fac41124bc ();
res.ssSTInvoiceFilesAudit = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1a5b8cd0ef1115d2fdd242fac41124bc() {
OptimizedAttributes = null;
ssSTInvoiceFilesAudit = new ST_29dc80a5deae2388e31181e1082143cfStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTInvoiceFilesAudit.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTInvoiceFilesAudit.Read( r, ref index);
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
public void ReadIM(RC_1a5b8cd0ef1115d2fdd242fac41124bc r) {
this = r;
}


public static bool operator == (RC_1a5b8cd0ef1115d2fdd242fac41124bc a, RC_1a5b8cd0ef1115d2fdd242fac41124bc b) {
if (a.ssSTInvoiceFilesAudit != b.ssSTInvoiceFilesAudit) return false;
return true;
}

public static bool operator != (RC_1a5b8cd0ef1115d2fdd242fac41124bc a, RC_1a5b8cd0ef1115d2fdd242fac41124bc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1a5b8cd0ef1115d2fdd242fac41124bc)) return false;
return (this == (RC_1a5b8cd0ef1115d2fdd242fac41124bc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoiceFilesAudit.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoiceFilesAudit.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoiceFilesAudit.InternalRecursiveSave();
}


public RC_1a5b8cd0ef1115d2fdd242fac41124bc Duplicate() {
RC_1a5b8cd0ef1115d2fdd242fac41124bc t;
t.ssSTInvoiceFilesAudit = (ST_29dc80a5deae2388e31181e1082143cfStructure)this.ssSTInvoiceFilesAudit.Duplicate();
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
if (head == "invoicefilesaudit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFilesAudit")) variable.Value = ssSTInvoiceFilesAudit; else variable.Optimized = true;
variable.SetFieldName("invoicefilesaudit");
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
if (key == IdInvoiceFilesAudit) {
return ssSTInvoiceFilesAudit;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceFilesAudit.Key.AsGuid) {
return ssSTInvoiceFilesAudit;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoiceFilesAudit.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFilesAudit));
}
} // RC_1a5b8cd0ef1115d2fdd242fac41124bc
/// <summary>
/// RecordList type <code>InvoiceFilesAuditRecordList</code> that represents a record list of
///  <code>InvoiceFilesAudit</code>
/// </summary>
public partial class RL_22eb8cf271ae44a42b277c2841218ca1 : GenericRecordList<RC_1a5b8cd0ef1115d2fdd242fac41124bc>, IEnumerable, IEnumerator {

protected override RC_1a5b8cd0ef1115d2fdd242fac41124bc GetElementDefaultValue() {
return new RC_1a5b8cd0ef1115d2fdd242fac41124bc();
}

public T[] ToArray<T>(Func<RC_1a5b8cd0ef1115d2fdd242fac41124bc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_22eb8cf271ae44a42b277c2841218ca1 recordList, Func<RC_1a5b8cd0ef1115d2fdd242fac41124bc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_22eb8cf271ae44a42b277c2841218ca1(RC_1a5b8cd0ef1115d2fdd242fac41124bc[] array) {
  RL_22eb8cf271ae44a42b277c2841218ca1 result = new RL_22eb8cf271ae44a42b277c2841218ca1();
result.InnerFromArray(array);
    return result;
}

public static RL_22eb8cf271ae44a42b277c2841218ca1 ToList<T>(T[] array, Func <T, RC_1a5b8cd0ef1115d2fdd242fac41124bc> converter) {
  RL_22eb8cf271ae44a42b277c2841218ca1 result = new RL_22eb8cf271ae44a42b277c2841218ca1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_22eb8cf271ae44a42b277c2841218ca1 FromRestList<T>(RestList<T> restList, Func <T, RC_1a5b8cd0ef1115d2fdd242fac41124bc> converter) {
  RL_22eb8cf271ae44a42b277c2841218ca1 result = new RL_22eb8cf271ae44a42b277c2841218ca1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_22eb8cf271ae44a42b277c2841218ca1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1a5b8cd0ef1115d2fdd242fac41124bc> NewList() {
return new RL_22eb8cf271ae44a42b277c2841218ca1();
}


} // RL_22eb8cf271ae44a42b277c2841218ca1
}

