namespace ssConectaProveedores {
/// <summary>
/// [Structure] InvoicesReport48_Filters (u7cm6E+jwkm13yssobBSQg)
///  <code>ST_4301e782f48f03168dfeb78159c19548Structure</code> that represent
/// s <code>InvoicesReport48_Filters</code> <p>Description: </p>
/// </summary>
// Name: InvoicesReport48_Filters
public partial struct ST_4301e782f48f03168dfeb78159c19548Structure : ITypedRecord<ST_4301e782f48f03168dfeb78159c19548Structure> {
internal static readonly GlobalObjectKey IdInvoiceName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vc3CjmmIPUCF5tglPfzEqA");
internal static readonly GlobalObjectKey IdSupplierId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*SPQHPyvSr023PTWFPEbEtg");
internal static readonly GlobalObjectKey IdInvoiceStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*AioFDb+DKkG23U3LoAN01A");
internal static readonly GlobalObjectKey IdDateFrom = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*LBTc5nHqKkWX9dmidQ87Bg");
internal static readonly GlobalObjectKey IdDateTo = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Azks17FKX0imPXOoad3r_Q");

public string ssInvoiceName;

public long ssSupplierId;

public int ssInvoiceStatusId;

public DateTime ssDateFrom;

public DateTime ssDateTo;


public BitArray OptimizedAttributes;

public ST_4301e782f48f03168dfeb78159c19548Structure() {
OptimizedAttributes = null;
ssInvoiceName = "";
ssSupplierId = 0L;
ssInvoiceStatusId = 0;
ssDateFrom = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssDateTo = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssInvoiceName = r.ReadText(index++, "InvoicesReport48_Filters.InvoiceName", "");
ssSupplierId = r.ReadEntityReferenceLongInteger(index++, "InvoicesReport48_Filters.SupplierId", 0L);
ssInvoiceStatusId = r.ReadEntityReference(index++, "InvoicesReport48_Filters.InvoiceStatusId", 0);
ssDateFrom = r.ReadDate(index++, "InvoicesReport48_Filters.DateFrom", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssDateTo = r.ReadDate(index++, "InvoicesReport48_Filters.DateTo", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(ST_4301e782f48f03168dfeb78159c19548Structure r) {
this = r;
}


public static bool operator == (ST_4301e782f48f03168dfeb78159c19548Structure a, ST_4301e782f48f03168dfeb78159c19548Structure b) {
if (a.ssInvoiceName != b.ssInvoiceName) return false;
if (a.ssSupplierId != b.ssSupplierId) return false;
if (a.ssInvoiceStatusId != b.ssInvoiceStatusId) return false;
if (a.ssDateFrom != b.ssDateFrom) return false;
if (a.ssDateTo != b.ssDateTo) return false;
return true;
}

public static bool operator != (ST_4301e782f48f03168dfeb78159c19548Structure a, ST_4301e782f48f03168dfeb78159c19548Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_4301e782f48f03168dfeb78159c19548Structure)) return false;
return (this == (ST_4301e782f48f03168dfeb78159c19548Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceName.GetHashCode()
 ^ ssSupplierId.GetHashCode()
 ^ ssInvoiceStatusId.GetHashCode()
 ^ ssDateFrom.GetHashCode()
 ^ ssDateTo.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_4301e782f48f03168dfeb78159c19548Structure Duplicate() {
ST_4301e782f48f03168dfeb78159c19548Structure t;
t.ssInvoiceName = this.ssInvoiceName;
t.ssSupplierId = this.ssSupplierId;
t.ssInvoiceStatusId = this.ssInvoiceStatusId;
t.ssDateFrom = this.ssDateFrom;
t.ssDateTo = this.ssDateTo;
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
if (head == "invoicename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceName")) variable.Value = ssInvoiceName; else variable.Optimized = true;
} else if (head == "supplierid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierId")) variable.Value = ssSupplierId; else variable.Optimized = true;
} else if (head == "invoicestatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatusId")) variable.Value = ssInvoiceStatusId; else variable.Optimized = true;
} else if (head == "datefrom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateFrom")) variable.Value = ssDateFrom; else variable.Optimized = true;
} else if (head == "dateto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DateTo")) variable.Value = ssDateTo; else variable.Optimized = true;
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
if (key == IdInvoiceName) {
return ssInvoiceName;
}
if (key == IdSupplierId) {
return ssSupplierId;
}
if (key == IdInvoiceStatusId) {
return ssInvoiceStatusId;
}
if (key == IdDateFrom) {
return ssDateFrom;
}
if (key == IdDateTo) {
return ssDateTo;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceName.Key.AsGuid) {
return ssInvoiceName;
}
if (attributeKey == IdSupplierId.Key.AsGuid) {
return ssSupplierId;
}
if (attributeKey == IdInvoiceStatusId.Key.AsGuid) {
return ssInvoiceStatusId;
}
if (attributeKey == IdDateFrom.Key.AsGuid) {
return ssDateFrom;
}
if (attributeKey == IdDateTo.Key.AsGuid) {
return ssDateTo;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceName = (string) other.AttributeGet(IdInvoiceName);
ssSupplierId = (long) other.AttributeGet(IdSupplierId);
ssInvoiceStatusId = (int) other.AttributeGet(IdInvoiceStatusId);
ssDateFrom = (DateTime) other.AttributeGet(IdDateFrom);
ssDateTo = (DateTime) other.AttributeGet(IdDateTo);
}
} // ST_4301e782f48f03168dfeb78159c19548Structure
/// <summary>
/// RecordList type <code>InvoicesReport48_FiltersList</code> that represents a record list of
///  <code>InvoicesReport48_Filters</code>
/// </summary>
public partial class RL_a6954798d3f4e9aa5aa846562a338765 : GenericRecordList<ST_4301e782f48f03168dfeb78159c19548Structure>, IEnumerable, IEnumerator {

protected override ST_4301e782f48f03168dfeb78159c19548Structure GetElementDefaultValue() {
return new ST_4301e782f48f03168dfeb78159c19548Structure();
}

public T[] ToArray<T>(Func<ST_4301e782f48f03168dfeb78159c19548Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a6954798d3f4e9aa5aa846562a338765 recordList, Func<ST_4301e782f48f03168dfeb78159c19548Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a6954798d3f4e9aa5aa846562a338765(ST_4301e782f48f03168dfeb78159c19548Structure[] array) {
  RL_a6954798d3f4e9aa5aa846562a338765 result = new RL_a6954798d3f4e9aa5aa846562a338765();
result.InnerFromArray(array);
    return result;
}

public static RL_a6954798d3f4e9aa5aa846562a338765 ToList<T>(T[] array, Func <T, ST_4301e782f48f03168dfeb78159c19548Structure> converter) {
  RL_a6954798d3f4e9aa5aa846562a338765 result = new RL_a6954798d3f4e9aa5aa846562a338765();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a6954798d3f4e9aa5aa846562a338765 FromRestList<T>(RestList<T> restList, Func <T, ST_4301e782f48f03168dfeb78159c19548Structure> converter) {
  RL_a6954798d3f4e9aa5aa846562a338765 result = new RL_a6954798d3f4e9aa5aa846562a338765();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a6954798d3f4e9aa5aa846562a338765() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_4301e782f48f03168dfeb78159c19548Structure> NewList() {
return new RL_a6954798d3f4e9aa5aa846562a338765();
}


} // RL_a6954798d3f4e9aa5aa846562a338765
}

