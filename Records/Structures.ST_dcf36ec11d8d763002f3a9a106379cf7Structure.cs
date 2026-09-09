namespace ssConectaProveedores {
/// <summary>
/// [Structure] ExcelInvoiceLogToExport (ChC0+KtcAku0ig5tqLueKg)
///  <code>ST_dcf36ec11d8d763002f3a9a106379cf7Structure</code> that represent
/// s <code>ExcelInvoiceLogToExport</code> <p>Description: Excel Log To Export Struct.</p>
/// </summary>
// Name: ExcelInvoiceLogToExport
public partial struct ST_dcf36ec11d8d763002f3a9a106379cf7Structure : ITypedRecord<ST_dcf36ec11d8d763002f3a9a106379cf7Structure> {
internal static readonly GlobalObjectKey IdInvoiceName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GtVqKBmo9EuLEgFBRjl2lQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*A2pXlLWLx0GkYvje3NzNBQ");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*c5UHU0WdrkuSYTYGirTtOQ");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zhaKKoY6SkGYZS2rHhHr1w");

public string ssInvoiceName;

public string ssCreatedBy;

public DateTime ssCreatedOn;

public string ssMessage;


public BitArray OptimizedAttributes;

public ST_dcf36ec11d8d763002f3a9a106379cf7Structure() {
OptimizedAttributes = null;
ssInvoiceName = "";
ssCreatedBy = "";
ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMessage = "";
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
ssInvoiceName = r.ReadText(index++, "ExcelInvoiceLogToExport.InvoiceName", "");
ssCreatedBy = r.ReadText(index++, "ExcelInvoiceLogToExport.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "ExcelInvoiceLogToExport.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMessage = r.ReadText(index++, "ExcelInvoiceLogToExport.Message", "");
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
public void ReadIM(ST_dcf36ec11d8d763002f3a9a106379cf7Structure r) {
this = r;
}


public static bool operator == (ST_dcf36ec11d8d763002f3a9a106379cf7Structure a, ST_dcf36ec11d8d763002f3a9a106379cf7Structure b) {
if (a.ssInvoiceName != b.ssInvoiceName) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_dcf36ec11d8d763002f3a9a106379cf7Structure a, ST_dcf36ec11d8d763002f3a9a106379cf7Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_dcf36ec11d8d763002f3a9a106379cf7Structure)) return false;
return (this == (ST_dcf36ec11d8d763002f3a9a106379cf7Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceName.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_dcf36ec11d8d763002f3a9a106379cf7Structure Duplicate() {
ST_dcf36ec11d8d763002f3a9a106379cf7Structure t;
t.ssInvoiceName = this.ssInvoiceName;
t.ssCreatedBy = this.ssCreatedBy;
t.ssCreatedOn = this.ssCreatedOn;
t.ssMessage = this.ssMessage;
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
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "message") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Message")) variable.Value = ssMessage; else variable.Optimized = true;
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
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdMessage) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceName.Key.AsGuid) {
return ssInvoiceName;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdMessage.Key.AsGuid) {
return ssMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceName = (string) other.AttributeGet(IdInvoiceName);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_dcf36ec11d8d763002f3a9a106379cf7Structure
/// <summary>
/// RecordList type <code>ExcelInvoiceLogToExportList</code> that represents a record list of
///  <code>ExcelInvoiceLogToExport</code>
/// </summary>
public partial class RL_ea45cdee0de01dcaf2dd1c576a5f22d2 : GenericRecordList<ST_dcf36ec11d8d763002f3a9a106379cf7Structure>, IEnumerable, IEnumerator {

protected override ST_dcf36ec11d8d763002f3a9a106379cf7Structure GetElementDefaultValue() {
return new ST_dcf36ec11d8d763002f3a9a106379cf7Structure();
}

public T[] ToArray<T>(Func<ST_dcf36ec11d8d763002f3a9a106379cf7Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ea45cdee0de01dcaf2dd1c576a5f22d2 recordList, Func<ST_dcf36ec11d8d763002f3a9a106379cf7Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ea45cdee0de01dcaf2dd1c576a5f22d2(ST_dcf36ec11d8d763002f3a9a106379cf7Structure[] array) {
  RL_ea45cdee0de01dcaf2dd1c576a5f22d2 result = new RL_ea45cdee0de01dcaf2dd1c576a5f22d2();
result.InnerFromArray(array);
    return result;
}

public static RL_ea45cdee0de01dcaf2dd1c576a5f22d2 ToList<T>(T[] array, Func <T, ST_dcf36ec11d8d763002f3a9a106379cf7Structure> converter) {
  RL_ea45cdee0de01dcaf2dd1c576a5f22d2 result = new RL_ea45cdee0de01dcaf2dd1c576a5f22d2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ea45cdee0de01dcaf2dd1c576a5f22d2 FromRestList<T>(RestList<T> restList, Func <T, ST_dcf36ec11d8d763002f3a9a106379cf7Structure> converter) {
  RL_ea45cdee0de01dcaf2dd1c576a5f22d2 result = new RL_ea45cdee0de01dcaf2dd1c576a5f22d2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ea45cdee0de01dcaf2dd1c576a5f22d2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_dcf36ec11d8d763002f3a9a106379cf7Structure> NewList() {
return new RL_ea45cdee0de01dcaf2dd1c576a5f22d2();
}


} // RL_ea45cdee0de01dcaf2dd1c576a5f22d2
}

