namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8qooibwqK0yX3+xqCSRmIA)
///  <code>RC_572bb5931fdd9ca097b2d3800101c49b</code> that represent
/// s <code>InvoiceAccountingProcessRetentionsRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingProcessRetentionsRecord
public partial struct RC_572bb5931fdd9ca097b2d3800101c49b : ITypedRecord<RC_572bb5931fdd9ca097b2d3800101c49b> {
internal static readonly GlobalObjectKey IdInvoiceAccountingProcessRetentions = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k7UrV90foJyXstOAAQHEmw");

public EN_b5a4fdb73161852bf014862cdc591a06EntityRecord ssENInvoiceAccountingProcessRetentions;


public static implicit operator EN_b5a4fdb73161852bf014862cdc591a06EntityRecord( RC_572bb5931fdd9ca097b2d3800101c49b r) {
return r.ssENInvoiceAccountingProcessRetentions;
}

public static implicit operator RC_572bb5931fdd9ca097b2d3800101c49b (EN_b5a4fdb73161852bf014862cdc591a06EntityRecord r) {
RC_572bb5931fdd9ca097b2d3800101c49b res = new RC_572bb5931fdd9ca097b2d3800101c49b ();
res.ssENInvoiceAccountingProcessRetentions = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceAccountingProcessRetentions.ChangedAttributes = value;
}
get {
    return ssENInvoiceAccountingProcessRetentions.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_572bb5931fdd9ca097b2d3800101c49b() {
OptimizedAttributes = null;
ssENInvoiceAccountingProcessRetentions = new EN_b5a4fdb73161852bf014862cdc591a06EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingProcessRetentions.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccountingProcessRetentions.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccountingProcessRetentions.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccountingProcessRetentions.Read( r, ref index);
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
public void ReadIM(RC_572bb5931fdd9ca097b2d3800101c49b r) {
this = r;
}


public static bool operator == (RC_572bb5931fdd9ca097b2d3800101c49b a, RC_572bb5931fdd9ca097b2d3800101c49b b) {
if (a.ssENInvoiceAccountingProcessRetentions != b.ssENInvoiceAccountingProcessRetentions) return false;
return true;
}

public static bool operator != (RC_572bb5931fdd9ca097b2d3800101c49b a, RC_572bb5931fdd9ca097b2d3800101c49b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_572bb5931fdd9ca097b2d3800101c49b)) return false;
return (this == (RC_572bb5931fdd9ca097b2d3800101c49b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingProcessRetentions.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingProcessRetentions.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingProcessRetentions.InternalRecursiveSave();
}


public RC_572bb5931fdd9ca097b2d3800101c49b Duplicate() {
RC_572bb5931fdd9ca097b2d3800101c49b t;
t.ssENInvoiceAccountingProcessRetentions = (EN_b5a4fdb73161852bf014862cdc591a06EntityRecord)this.ssENInvoiceAccountingProcessRetentions.Duplicate();
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
if (head == "invoiceaccountingprocessretentions") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcessRetentions")) variable.Value = ssENInvoiceAccountingProcessRetentions; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingprocessretentions");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcessRetentions.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingProcessRetentions.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingProcessRetentions) {
return ssENInvoiceAccountingProcessRetentions;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingProcessRetentions.Key.AsGuid) {
return ssENInvoiceAccountingProcessRetentions;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingProcessRetentions.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingProcessRetentions));
}
} // RC_572bb5931fdd9ca097b2d3800101c49b
/// <summary>
/// RecordList type <code>InvoiceAccountingProcessRetentionsRecordList</code> that represents a record
///  list of <code>InvoiceAccountingProcessRetentions</code>
/// </summary>
public partial class RL_d8257fba7f427e1268305606412dd313 : GenericRecordList<RC_572bb5931fdd9ca097b2d3800101c49b>, IEnumerable, IEnumerator {

protected override RC_572bb5931fdd9ca097b2d3800101c49b GetElementDefaultValue() {
return new RC_572bb5931fdd9ca097b2d3800101c49b();
}

public T[] ToArray<T>(Func<RC_572bb5931fdd9ca097b2d3800101c49b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8257fba7f427e1268305606412dd313 recordList, Func<RC_572bb5931fdd9ca097b2d3800101c49b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8257fba7f427e1268305606412dd313(RC_572bb5931fdd9ca097b2d3800101c49b[] array) {
  RL_d8257fba7f427e1268305606412dd313 result = new RL_d8257fba7f427e1268305606412dd313();
result.InnerFromArray(array);
    return result;
}

public static RL_d8257fba7f427e1268305606412dd313 ToList<T>(T[] array, Func <T, RC_572bb5931fdd9ca097b2d3800101c49b> converter) {
  RL_d8257fba7f427e1268305606412dd313 result = new RL_d8257fba7f427e1268305606412dd313();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8257fba7f427e1268305606412dd313 FromRestList<T>(RestList<T> restList, Func <T, RC_572bb5931fdd9ca097b2d3800101c49b> converter) {
  RL_d8257fba7f427e1268305606412dd313 result = new RL_d8257fba7f427e1268305606412dd313();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8257fba7f427e1268305606412dd313() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_572bb5931fdd9ca097b2d3800101c49b> NewList() {
return new RL_d8257fba7f427e1268305606412dd313();
}


} // RL_d8257fba7f427e1268305606412dd313
}

