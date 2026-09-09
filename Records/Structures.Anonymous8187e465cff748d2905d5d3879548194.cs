namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZeSHgffP0kiQXV04eVSBlA)
///  <code>RC_85ff0b93155717e6346b97d39d3b0222</code> that represents <code>InvoiceCommentRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceCommentRecord
public partial struct RC_85ff0b93155717e6346b97d39d3b0222 : ITypedRecord<RC_85ff0b93155717e6346b97d39d3b0222> {
internal static readonly GlobalObjectKey IdInvoiceComment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kwv_hVcV5hc0a5fTnTsCIg");

public EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord ssENInvoiceComment;


public static implicit operator EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord( RC_85ff0b93155717e6346b97d39d3b0222 r) {
return r.ssENInvoiceComment;
}

public static implicit operator RC_85ff0b93155717e6346b97d39d3b0222 (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord r) {
RC_85ff0b93155717e6346b97d39d3b0222 res = new RC_85ff0b93155717e6346b97d39d3b0222 ();
res.ssENInvoiceComment = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceComment.ChangedAttributes = value;
}
get {
    return ssENInvoiceComment.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_85ff0b93155717e6346b97d39d3b0222() {
OptimizedAttributes = null;
ssENInvoiceComment = new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceComment.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceComment.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceComment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceComment.Read( r, ref index);
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
public void ReadIM(RC_85ff0b93155717e6346b97d39d3b0222 r) {
this = r;
}


public static bool operator == (RC_85ff0b93155717e6346b97d39d3b0222 a, RC_85ff0b93155717e6346b97d39d3b0222 b) {
if (a.ssENInvoiceComment != b.ssENInvoiceComment) return false;
return true;
}

public static bool operator != (RC_85ff0b93155717e6346b97d39d3b0222 a, RC_85ff0b93155717e6346b97d39d3b0222 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_85ff0b93155717e6346b97d39d3b0222)) return false;
return (this == (RC_85ff0b93155717e6346b97d39d3b0222)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceComment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceComment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceComment.InternalRecursiveSave();
}


public RC_85ff0b93155717e6346b97d39d3b0222 Duplicate() {
RC_85ff0b93155717e6346b97d39d3b0222 t;
t.ssENInvoiceComment = (EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord)this.ssENInvoiceComment.Duplicate();
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
if (head == "invoicecomment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceComment")) variable.Value = ssENInvoiceComment; else variable.Optimized = true;
variable.SetFieldName("invoicecomment");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceComment.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceComment.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceComment) {
return ssENInvoiceComment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceComment.Key.AsGuid) {
return ssENInvoiceComment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceComment.FillFromOther((IRecord) other.AttributeGet(IdInvoiceComment));
}
} // RC_85ff0b93155717e6346b97d39d3b0222
/// <summary>
/// RecordList type <code>InvoiceCommentRecordList</code> that represents a record list of
///  <code>InvoiceComment</code>
/// </summary>
public partial class RL_2e7f130f9df070446bc2a9ac7dcde539 : GenericRecordList<RC_85ff0b93155717e6346b97d39d3b0222>, IEnumerable, IEnumerator {

protected override RC_85ff0b93155717e6346b97d39d3b0222 GetElementDefaultValue() {
return new RC_85ff0b93155717e6346b97d39d3b0222();
}

public T[] ToArray<T>(Func<RC_85ff0b93155717e6346b97d39d3b0222, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2e7f130f9df070446bc2a9ac7dcde539 recordList, Func<RC_85ff0b93155717e6346b97d39d3b0222, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2e7f130f9df070446bc2a9ac7dcde539(RC_85ff0b93155717e6346b97d39d3b0222[] array) {
  RL_2e7f130f9df070446bc2a9ac7dcde539 result = new RL_2e7f130f9df070446bc2a9ac7dcde539();
result.InnerFromArray(array);
    return result;
}

public static RL_2e7f130f9df070446bc2a9ac7dcde539 ToList<T>(T[] array, Func <T, RC_85ff0b93155717e6346b97d39d3b0222> converter) {
  RL_2e7f130f9df070446bc2a9ac7dcde539 result = new RL_2e7f130f9df070446bc2a9ac7dcde539();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2e7f130f9df070446bc2a9ac7dcde539 FromRestList<T>(RestList<T> restList, Func <T, RC_85ff0b93155717e6346b97d39d3b0222> converter) {
  RL_2e7f130f9df070446bc2a9ac7dcde539 result = new RL_2e7f130f9df070446bc2a9ac7dcde539();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2e7f130f9df070446bc2a9ac7dcde539() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_85ff0b93155717e6346b97d39d3b0222> NewList() {
return new RL_2e7f130f9df070446bc2a9ac7dcde539();
}


} // RL_2e7f130f9df070446bc2a9ac7dcde539
}

