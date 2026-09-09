namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mK32Mw97gkOI45P9rP9wMg)
///  <code>RC_71a6039f6d90c4426aac574268306fe3</code> that represent
/// s <code>ExcelFolioLogToExportRecord</code> <p>Description: </p>
/// </summary>
// Name: ExcelFolioLogToExportRecord
public partial struct RC_71a6039f6d90c4426aac574268306fe3 : ITypedRecord<RC_71a6039f6d90c4426aac574268306fe3> {
internal static readonly GlobalObjectKey IdExcelFolioLogToExport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nwOmcZBtQsRqrFdCaDBv4w");

public ST_2e562a380f69a76cb54ade40213e888fStructure ssSTExcelFolioLogToExport;


public static implicit operator ST_2e562a380f69a76cb54ade40213e888fStructure( RC_71a6039f6d90c4426aac574268306fe3 r) {
return r.ssSTExcelFolioLogToExport;
}

public static implicit operator RC_71a6039f6d90c4426aac574268306fe3 (ST_2e562a380f69a76cb54ade40213e888fStructure r) {
RC_71a6039f6d90c4426aac574268306fe3 res = new RC_71a6039f6d90c4426aac574268306fe3 ();
res.ssSTExcelFolioLogToExport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_71a6039f6d90c4426aac574268306fe3() {
OptimizedAttributes = null;
ssSTExcelFolioLogToExport = new ST_2e562a380f69a76cb54ade40213e888fStructure();
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
    ssSTExcelFolioLogToExport.OptimizedAttributes = value[0];
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
ssSTExcelFolioLogToExport.Read( r, ref index);
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
public void ReadIM(RC_71a6039f6d90c4426aac574268306fe3 r) {
this = r;
}


public static bool operator == (RC_71a6039f6d90c4426aac574268306fe3 a, RC_71a6039f6d90c4426aac574268306fe3 b) {
if (a.ssSTExcelFolioLogToExport != b.ssSTExcelFolioLogToExport) return false;
return true;
}

public static bool operator != (RC_71a6039f6d90c4426aac574268306fe3 a, RC_71a6039f6d90c4426aac574268306fe3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_71a6039f6d90c4426aac574268306fe3)) return false;
return (this == (RC_71a6039f6d90c4426aac574268306fe3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExcelFolioLogToExport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExcelFolioLogToExport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExcelFolioLogToExport.InternalRecursiveSave();
}


public RC_71a6039f6d90c4426aac574268306fe3 Duplicate() {
RC_71a6039f6d90c4426aac574268306fe3 t;
t.ssSTExcelFolioLogToExport = (ST_2e562a380f69a76cb54ade40213e888fStructure)this.ssSTExcelFolioLogToExport.Duplicate();
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
if (head == "excelfoliologtoexport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcelFolioLogToExport")) variable.Value = ssSTExcelFolioLogToExport; else variable.Optimized = true;
variable.SetFieldName("excelfoliologtoexport");
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
if (key == IdExcelFolioLogToExport) {
return ssSTExcelFolioLogToExport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExcelFolioLogToExport.Key.AsGuid) {
return ssSTExcelFolioLogToExport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExcelFolioLogToExport.FillFromOther((IRecord) other.AttributeGet(IdExcelFolioLogToExport));
}
} // RC_71a6039f6d90c4426aac574268306fe3
/// <summary>
/// RecordList type <code>ExcelFolioLogToExportRecordList</code> that represents a record list of
///  <code>ExcelFolioLogToExport</code>
/// </summary>
public partial class RL_e219c3b03e8dfc2ac465a149c9f8e18b : GenericRecordList<RC_71a6039f6d90c4426aac574268306fe3>, IEnumerable, IEnumerator {

protected override RC_71a6039f6d90c4426aac574268306fe3 GetElementDefaultValue() {
return new RC_71a6039f6d90c4426aac574268306fe3();
}

public T[] ToArray<T>(Func<RC_71a6039f6d90c4426aac574268306fe3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e219c3b03e8dfc2ac465a149c9f8e18b recordList, Func<RC_71a6039f6d90c4426aac574268306fe3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e219c3b03e8dfc2ac465a149c9f8e18b(RC_71a6039f6d90c4426aac574268306fe3[] array) {
  RL_e219c3b03e8dfc2ac465a149c9f8e18b result = new RL_e219c3b03e8dfc2ac465a149c9f8e18b();
result.InnerFromArray(array);
    return result;
}

public static RL_e219c3b03e8dfc2ac465a149c9f8e18b ToList<T>(T[] array, Func <T, RC_71a6039f6d90c4426aac574268306fe3> converter) {
  RL_e219c3b03e8dfc2ac465a149c9f8e18b result = new RL_e219c3b03e8dfc2ac465a149c9f8e18b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e219c3b03e8dfc2ac465a149c9f8e18b FromRestList<T>(RestList<T> restList, Func <T, RC_71a6039f6d90c4426aac574268306fe3> converter) {
  RL_e219c3b03e8dfc2ac465a149c9f8e18b result = new RL_e219c3b03e8dfc2ac465a149c9f8e18b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e219c3b03e8dfc2ac465a149c9f8e18b() : base() {
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
protected override OSList<RC_71a6039f6d90c4426aac574268306fe3> NewList() {
return new RL_e219c3b03e8dfc2ac465a149c9f8e18b();
}


} // RL_e219c3b03e8dfc2ac465a149c9f8e18b
}

