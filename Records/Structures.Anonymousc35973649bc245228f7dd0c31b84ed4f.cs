namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZHNZw8KbIkWPfdDDG4TtTw)
///  <code>RC_06efe9ed6a370dc0f5c291d28ffa3e14</code> that represent
/// s <code>ExcelOrderLogToExportRecord</code> <p>Description: </p>
/// </summary>
// Name: ExcelOrderLogToExportRecord
public partial struct RC_06efe9ed6a370dc0f5c291d28ffa3e14 : ITypedRecord<RC_06efe9ed6a370dc0f5c291d28ffa3e14> {
internal static readonly GlobalObjectKey IdExcelOrderLogToExport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7envBjdqwA31wpHSj_o+FA");

public ST_5fdc1be15c9e934a0a534eba5239d3c9Structure ssSTExcelOrderLogToExport;


public static implicit operator ST_5fdc1be15c9e934a0a534eba5239d3c9Structure( RC_06efe9ed6a370dc0f5c291d28ffa3e14 r) {
return r.ssSTExcelOrderLogToExport;
}

public static implicit operator RC_06efe9ed6a370dc0f5c291d28ffa3e14 (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure r) {
RC_06efe9ed6a370dc0f5c291d28ffa3e14 res = new RC_06efe9ed6a370dc0f5c291d28ffa3e14 ();
res.ssSTExcelOrderLogToExport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_06efe9ed6a370dc0f5c291d28ffa3e14() {
OptimizedAttributes = null;
ssSTExcelOrderLogToExport = new ST_5fdc1be15c9e934a0a534eba5239d3c9Structure();
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
    ssSTExcelOrderLogToExport.OptimizedAttributes = value[0];
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
ssSTExcelOrderLogToExport.Read( r, ref index);
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
public void ReadIM(RC_06efe9ed6a370dc0f5c291d28ffa3e14 r) {
this = r;
}


public static bool operator == (RC_06efe9ed6a370dc0f5c291d28ffa3e14 a, RC_06efe9ed6a370dc0f5c291d28ffa3e14 b) {
if (a.ssSTExcelOrderLogToExport != b.ssSTExcelOrderLogToExport) return false;
return true;
}

public static bool operator != (RC_06efe9ed6a370dc0f5c291d28ffa3e14 a, RC_06efe9ed6a370dc0f5c291d28ffa3e14 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_06efe9ed6a370dc0f5c291d28ffa3e14)) return false;
return (this == (RC_06efe9ed6a370dc0f5c291d28ffa3e14)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExcelOrderLogToExport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExcelOrderLogToExport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExcelOrderLogToExport.InternalRecursiveSave();
}


public RC_06efe9ed6a370dc0f5c291d28ffa3e14 Duplicate() {
RC_06efe9ed6a370dc0f5c291d28ffa3e14 t;
t.ssSTExcelOrderLogToExport = (ST_5fdc1be15c9e934a0a534eba5239d3c9Structure)this.ssSTExcelOrderLogToExport.Duplicate();
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
if (head == "excelorderlogtoexport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcelOrderLogToExport")) variable.Value = ssSTExcelOrderLogToExport; else variable.Optimized = true;
variable.SetFieldName("excelorderlogtoexport");
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
if (key == IdExcelOrderLogToExport) {
return ssSTExcelOrderLogToExport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExcelOrderLogToExport.Key.AsGuid) {
return ssSTExcelOrderLogToExport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExcelOrderLogToExport.FillFromOther((IRecord) other.AttributeGet(IdExcelOrderLogToExport));
}
} // RC_06efe9ed6a370dc0f5c291d28ffa3e14
/// <summary>
/// RecordList type <code>ExcelOrderLogToExportRecordList</code> that represents a record list of
///  <code>ExcelOrderLogToExport</code>
/// </summary>
public partial class RL_f96b75b3d608a6f390605b1e00d3642e : GenericRecordList<RC_06efe9ed6a370dc0f5c291d28ffa3e14>, IEnumerable, IEnumerator {

protected override RC_06efe9ed6a370dc0f5c291d28ffa3e14 GetElementDefaultValue() {
return new RC_06efe9ed6a370dc0f5c291d28ffa3e14();
}

public T[] ToArray<T>(Func<RC_06efe9ed6a370dc0f5c291d28ffa3e14, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f96b75b3d608a6f390605b1e00d3642e recordList, Func<RC_06efe9ed6a370dc0f5c291d28ffa3e14, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f96b75b3d608a6f390605b1e00d3642e(RC_06efe9ed6a370dc0f5c291d28ffa3e14[] array) {
  RL_f96b75b3d608a6f390605b1e00d3642e result = new RL_f96b75b3d608a6f390605b1e00d3642e();
result.InnerFromArray(array);
    return result;
}

public static RL_f96b75b3d608a6f390605b1e00d3642e ToList<T>(T[] array, Func <T, RC_06efe9ed6a370dc0f5c291d28ffa3e14> converter) {
  RL_f96b75b3d608a6f390605b1e00d3642e result = new RL_f96b75b3d608a6f390605b1e00d3642e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f96b75b3d608a6f390605b1e00d3642e FromRestList<T>(RestList<T> restList, Func <T, RC_06efe9ed6a370dc0f5c291d28ffa3e14> converter) {
  RL_f96b75b3d608a6f390605b1e00d3642e result = new RL_f96b75b3d608a6f390605b1e00d3642e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f96b75b3d608a6f390605b1e00d3642e() : base() {
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
protected override OSList<RC_06efe9ed6a370dc0f5c291d28ffa3e14> NewList() {
return new RL_f96b75b3d608a6f390605b1e00d3642e();
}


} // RL_f96b75b3d608a6f390605b1e00d3642e
}

