namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (q5i99n8te0mm6D0FOhsEYA)
///  <code>RC_72ebc67e31662560b8d31a972a3fab67</code> that represent
/// s <code>ExcelInvoiceLogToExportRecord</code> <p>Description: </p>
/// </summary>
// Name: ExcelInvoiceLogToExportRecord
public partial struct RC_72ebc67e31662560b8d31a972a3fab67 : ITypedRecord<RC_72ebc67e31662560b8d31a972a3fab67> {
internal static readonly GlobalObjectKey IdExcelInvoiceLogToExport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fsbrcmYxYCW40xqXKj+rZw");

public ST_dcf36ec11d8d763002f3a9a106379cf7Structure ssSTExcelInvoiceLogToExport;


public static implicit operator ST_dcf36ec11d8d763002f3a9a106379cf7Structure( RC_72ebc67e31662560b8d31a972a3fab67 r) {
return r.ssSTExcelInvoiceLogToExport;
}

public static implicit operator RC_72ebc67e31662560b8d31a972a3fab67 (ST_dcf36ec11d8d763002f3a9a106379cf7Structure r) {
RC_72ebc67e31662560b8d31a972a3fab67 res = new RC_72ebc67e31662560b8d31a972a3fab67 ();
res.ssSTExcelInvoiceLogToExport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_72ebc67e31662560b8d31a972a3fab67() {
OptimizedAttributes = null;
ssSTExcelInvoiceLogToExport = new ST_dcf36ec11d8d763002f3a9a106379cf7Structure();
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
    ssSTExcelInvoiceLogToExport.OptimizedAttributes = value[0];
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
ssSTExcelInvoiceLogToExport.Read( r, ref index);
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
public void ReadIM(RC_72ebc67e31662560b8d31a972a3fab67 r) {
this = r;
}


public static bool operator == (RC_72ebc67e31662560b8d31a972a3fab67 a, RC_72ebc67e31662560b8d31a972a3fab67 b) {
if (a.ssSTExcelInvoiceLogToExport != b.ssSTExcelInvoiceLogToExport) return false;
return true;
}

public static bool operator != (RC_72ebc67e31662560b8d31a972a3fab67 a, RC_72ebc67e31662560b8d31a972a3fab67 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_72ebc67e31662560b8d31a972a3fab67)) return false;
return (this == (RC_72ebc67e31662560b8d31a972a3fab67)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExcelInvoiceLogToExport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExcelInvoiceLogToExport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExcelInvoiceLogToExport.InternalRecursiveSave();
}


public RC_72ebc67e31662560b8d31a972a3fab67 Duplicate() {
RC_72ebc67e31662560b8d31a972a3fab67 t;
t.ssSTExcelInvoiceLogToExport = (ST_dcf36ec11d8d763002f3a9a106379cf7Structure)this.ssSTExcelInvoiceLogToExport.Duplicate();
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
if (head == "excelinvoicelogtoexport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcelInvoiceLogToExport")) variable.Value = ssSTExcelInvoiceLogToExport; else variable.Optimized = true;
variable.SetFieldName("excelinvoicelogtoexport");
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
if (key == IdExcelInvoiceLogToExport) {
return ssSTExcelInvoiceLogToExport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExcelInvoiceLogToExport.Key.AsGuid) {
return ssSTExcelInvoiceLogToExport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExcelInvoiceLogToExport.FillFromOther((IRecord) other.AttributeGet(IdExcelInvoiceLogToExport));
}
} // RC_72ebc67e31662560b8d31a972a3fab67
/// <summary>
/// RecordList type <code>ExcelInvoiceLogToExportRecordList</code> that represents a record list of
///  <code>ExcelInvoiceLogToExport</code>
/// </summary>
public partial class RL_e46d5715ef43a06c3ff6bf3dfd62f74f : GenericRecordList<RC_72ebc67e31662560b8d31a972a3fab67>, IEnumerable, IEnumerator {

protected override RC_72ebc67e31662560b8d31a972a3fab67 GetElementDefaultValue() {
return new RC_72ebc67e31662560b8d31a972a3fab67();
}

public T[] ToArray<T>(Func<RC_72ebc67e31662560b8d31a972a3fab67, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e46d5715ef43a06c3ff6bf3dfd62f74f recordList, Func<RC_72ebc67e31662560b8d31a972a3fab67, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e46d5715ef43a06c3ff6bf3dfd62f74f(RC_72ebc67e31662560b8d31a972a3fab67[] array) {
  RL_e46d5715ef43a06c3ff6bf3dfd62f74f result = new RL_e46d5715ef43a06c3ff6bf3dfd62f74f();
result.InnerFromArray(array);
    return result;
}

public static RL_e46d5715ef43a06c3ff6bf3dfd62f74f ToList<T>(T[] array, Func <T, RC_72ebc67e31662560b8d31a972a3fab67> converter) {
  RL_e46d5715ef43a06c3ff6bf3dfd62f74f result = new RL_e46d5715ef43a06c3ff6bf3dfd62f74f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e46d5715ef43a06c3ff6bf3dfd62f74f FromRestList<T>(RestList<T> restList, Func <T, RC_72ebc67e31662560b8d31a972a3fab67> converter) {
  RL_e46d5715ef43a06c3ff6bf3dfd62f74f result = new RL_e46d5715ef43a06c3ff6bf3dfd62f74f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e46d5715ef43a06c3ff6bf3dfd62f74f() : base() {
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
protected override OSList<RC_72ebc67e31662560b8d31a972a3fab67> NewList() {
return new RL_e46d5715ef43a06c3ff6bf3dfd62f74f();
}


} // RL_e46d5715ef43a06c3ff6bf3dfd62f74f
}

