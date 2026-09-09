namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (FOIqpieSFUq+QJLtvv7uLA)
///  <code>RC_cc70d98f5591c4042b4a1208b635d416</code> that represent
/// s <code>ExcelRequisitionLogToExportRecord</code> <p>Description: </p>
/// </summary>
// Name: ExcelRequisitionLogToExportRecord
public partial struct RC_cc70d98f5591c4042b4a1208b635d416 : ITypedRecord<RC_cc70d98f5591c4042b4a1208b635d416> {
internal static readonly GlobalObjectKey IdExcelRequisitionLogToExport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*j9lwzJFVBMQrShIItjXUFg");

public ST_83be973cab4e7f90c5adb2c45a579242Structure ssSTExcelRequisitionLogToExport;


public static implicit operator ST_83be973cab4e7f90c5adb2c45a579242Structure( RC_cc70d98f5591c4042b4a1208b635d416 r) {
return r.ssSTExcelRequisitionLogToExport;
}

public static implicit operator RC_cc70d98f5591c4042b4a1208b635d416 (ST_83be973cab4e7f90c5adb2c45a579242Structure r) {
RC_cc70d98f5591c4042b4a1208b635d416 res = new RC_cc70d98f5591c4042b4a1208b635d416 ();
res.ssSTExcelRequisitionLogToExport = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_cc70d98f5591c4042b4a1208b635d416() {
OptimizedAttributes = null;
ssSTExcelRequisitionLogToExport = new ST_83be973cab4e7f90c5adb2c45a579242Structure();
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
    ssSTExcelRequisitionLogToExport.OptimizedAttributes = value[0];
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
ssSTExcelRequisitionLogToExport.Read( r, ref index);
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
public void ReadIM(RC_cc70d98f5591c4042b4a1208b635d416 r) {
this = r;
}


public static bool operator == (RC_cc70d98f5591c4042b4a1208b635d416 a, RC_cc70d98f5591c4042b4a1208b635d416 b) {
if (a.ssSTExcelRequisitionLogToExport != b.ssSTExcelRequisitionLogToExport) return false;
return true;
}

public static bool operator != (RC_cc70d98f5591c4042b4a1208b635d416 a, RC_cc70d98f5591c4042b4a1208b635d416 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cc70d98f5591c4042b4a1208b635d416)) return false;
return (this == (RC_cc70d98f5591c4042b4a1208b635d416)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExcelRequisitionLogToExport.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExcelRequisitionLogToExport.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExcelRequisitionLogToExport.InternalRecursiveSave();
}


public RC_cc70d98f5591c4042b4a1208b635d416 Duplicate() {
RC_cc70d98f5591c4042b4a1208b635d416 t;
t.ssSTExcelRequisitionLogToExport = (ST_83be973cab4e7f90c5adb2c45a579242Structure)this.ssSTExcelRequisitionLogToExport.Duplicate();
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
if (head == "excelrequisitionlogtoexport") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExcelRequisitionLogToExport")) variable.Value = ssSTExcelRequisitionLogToExport; else variable.Optimized = true;
variable.SetFieldName("excelrequisitionlogtoexport");
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
if (key == IdExcelRequisitionLogToExport) {
return ssSTExcelRequisitionLogToExport;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExcelRequisitionLogToExport.Key.AsGuid) {
return ssSTExcelRequisitionLogToExport;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExcelRequisitionLogToExport.FillFromOther((IRecord) other.AttributeGet(IdExcelRequisitionLogToExport));
}
} // RC_cc70d98f5591c4042b4a1208b635d416
/// <summary>
/// RecordList type <code>ExcelRequisitionLogToExportRecordList</code> that represents a record list of
///  <code>ExcelRequisitionLogToExport</code>
/// </summary>
public partial class RL_4d8ea5080b0783cac180542c06a0e4ed : GenericRecordList<RC_cc70d98f5591c4042b4a1208b635d416>, IEnumerable, IEnumerator {

protected override RC_cc70d98f5591c4042b4a1208b635d416 GetElementDefaultValue() {
return new RC_cc70d98f5591c4042b4a1208b635d416();
}

public T[] ToArray<T>(Func<RC_cc70d98f5591c4042b4a1208b635d416, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d8ea5080b0783cac180542c06a0e4ed recordList, Func<RC_cc70d98f5591c4042b4a1208b635d416, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d8ea5080b0783cac180542c06a0e4ed(RC_cc70d98f5591c4042b4a1208b635d416[] array) {
  RL_4d8ea5080b0783cac180542c06a0e4ed result = new RL_4d8ea5080b0783cac180542c06a0e4ed();
result.InnerFromArray(array);
    return result;
}

public static RL_4d8ea5080b0783cac180542c06a0e4ed ToList<T>(T[] array, Func <T, RC_cc70d98f5591c4042b4a1208b635d416> converter) {
  RL_4d8ea5080b0783cac180542c06a0e4ed result = new RL_4d8ea5080b0783cac180542c06a0e4ed();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d8ea5080b0783cac180542c06a0e4ed FromRestList<T>(RestList<T> restList, Func <T, RC_cc70d98f5591c4042b4a1208b635d416> converter) {
  RL_4d8ea5080b0783cac180542c06a0e4ed result = new RL_4d8ea5080b0783cac180542c06a0e4ed();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d8ea5080b0783cac180542c06a0e4ed() : base() {
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
protected override OSList<RC_cc70d98f5591c4042b4a1208b635d416> NewList() {
return new RL_4d8ea5080b0783cac180542c06a0e4ed();
}


} // RL_4d8ea5080b0783cac180542c06a0e4ed
}

