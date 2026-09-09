namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nSUmSW1ikUm+8IcVf_H34g)
///  <code>RC_43d13231e92dc315679ee8f8afa7a620</code> that represent
/// s <code>InvoiceAuditFilesListRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAuditFilesListRecord
public partial struct RC_43d13231e92dc315679ee8f8afa7a620 : ITypedRecord<RC_43d13231e92dc315679ee8f8afa7a620> {
internal static readonly GlobalObjectKey IdInvoiceAuditFilesList = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MTLRQy3pFcNnnuj4r6emIA");

public ST_15467825cb087ac1591b96b0d1989badStructure ssSTInvoiceAuditFilesList;


public static implicit operator ST_15467825cb087ac1591b96b0d1989badStructure( RC_43d13231e92dc315679ee8f8afa7a620 r) {
return r.ssSTInvoiceAuditFilesList;
}

public static implicit operator RC_43d13231e92dc315679ee8f8afa7a620 (ST_15467825cb087ac1591b96b0d1989badStructure r) {
RC_43d13231e92dc315679ee8f8afa7a620 res = new RC_43d13231e92dc315679ee8f8afa7a620 ();
res.ssSTInvoiceAuditFilesList = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_43d13231e92dc315679ee8f8afa7a620() {
OptimizedAttributes = null;
ssSTInvoiceAuditFilesList = new ST_15467825cb087ac1591b96b0d1989badStructure();
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
    ssSTInvoiceAuditFilesList.OptimizedAttributes = value[0];
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
ssSTInvoiceAuditFilesList.Read( r, ref index);
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
public void ReadIM(RC_43d13231e92dc315679ee8f8afa7a620 r) {
this = r;
}


public static bool operator == (RC_43d13231e92dc315679ee8f8afa7a620 a, RC_43d13231e92dc315679ee8f8afa7a620 b) {
if (a.ssSTInvoiceAuditFilesList != b.ssSTInvoiceAuditFilesList) return false;
return true;
}

public static bool operator != (RC_43d13231e92dc315679ee8f8afa7a620 a, RC_43d13231e92dc315679ee8f8afa7a620 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_43d13231e92dc315679ee8f8afa7a620)) return false;
return (this == (RC_43d13231e92dc315679ee8f8afa7a620)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoiceAuditFilesList.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoiceAuditFilesList.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoiceAuditFilesList.InternalRecursiveSave();
}


public RC_43d13231e92dc315679ee8f8afa7a620 Duplicate() {
RC_43d13231e92dc315679ee8f8afa7a620 t;
t.ssSTInvoiceAuditFilesList = (ST_15467825cb087ac1591b96b0d1989badStructure)this.ssSTInvoiceAuditFilesList.Duplicate();
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
if (head == "invoiceauditfileslist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAuditFilesList")) variable.Value = ssSTInvoiceAuditFilesList; else variable.Optimized = true;
variable.SetFieldName("invoiceauditfileslist");
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
if (key == IdInvoiceAuditFilesList) {
return ssSTInvoiceAuditFilesList;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAuditFilesList.Key.AsGuid) {
return ssSTInvoiceAuditFilesList;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoiceAuditFilesList.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAuditFilesList));
}
} // RC_43d13231e92dc315679ee8f8afa7a620
/// <summary>
/// RecordList type <code>InvoiceAuditFilesListRecordList</code> that represents a record list of
///  <code>InvoiceAuditFilesList</code>
/// </summary>
public partial class RL_84cc39d051e090dd6414685c3f484137 : GenericRecordList<RC_43d13231e92dc315679ee8f8afa7a620>, IEnumerable, IEnumerator {

protected override RC_43d13231e92dc315679ee8f8afa7a620 GetElementDefaultValue() {
return new RC_43d13231e92dc315679ee8f8afa7a620();
}

public T[] ToArray<T>(Func<RC_43d13231e92dc315679ee8f8afa7a620, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_84cc39d051e090dd6414685c3f484137 recordList, Func<RC_43d13231e92dc315679ee8f8afa7a620, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_84cc39d051e090dd6414685c3f484137(RC_43d13231e92dc315679ee8f8afa7a620[] array) {
  RL_84cc39d051e090dd6414685c3f484137 result = new RL_84cc39d051e090dd6414685c3f484137();
result.InnerFromArray(array);
    return result;
}

public static RL_84cc39d051e090dd6414685c3f484137 ToList<T>(T[] array, Func <T, RC_43d13231e92dc315679ee8f8afa7a620> converter) {
  RL_84cc39d051e090dd6414685c3f484137 result = new RL_84cc39d051e090dd6414685c3f484137();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_84cc39d051e090dd6414685c3f484137 FromRestList<T>(RestList<T> restList, Func <T, RC_43d13231e92dc315679ee8f8afa7a620> converter) {
  RL_84cc39d051e090dd6414685c3f484137 result = new RL_84cc39d051e090dd6414685c3f484137();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_84cc39d051e090dd6414685c3f484137() : base() {
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
protected override OSList<RC_43d13231e92dc315679ee8f8afa7a620> NewList() {
return new RL_84cc39d051e090dd6414685c3f484137();
}


} // RL_84cc39d051e090dd6414685c3f484137
}

