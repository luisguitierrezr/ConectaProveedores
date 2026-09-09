namespace ssConectaProveedores {
/// <summary>
/// [Structure] ExcelRequisitionLogToExport (Un4da+IX7ESWDZAUck7+mQ)
///  <code>ST_83be973cab4e7f90c5adb2c45a579242Structure</code> that represent
/// s <code>ExcelRequisitionLogToExport</code> <p>Description: Excel Log To Export Struct.</p>
/// </summary>
// Name: ExcelRequisitionLogToExport
public partial struct ST_83be973cab4e7f90c5adb2c45a579242Structure : ITypedRecord<ST_83be973cab4e7f90c5adb2c45a579242Structure> {
internal static readonly GlobalObjectKey IdRequisitionName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ShSSK+HPekiOozUiDiVEvQ");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*_B6mKWNmsE2hZtHk3a1ctA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dEzooVpPLUacMs0FrUUEVw");
internal static readonly GlobalObjectKey IdMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IPAVQxu2j0CW1mJMHR62PA");

public string ssRequisitionName;

public string ssCreatedBy;

public DateTime ssCreatedOn;

public string ssMessage;


public BitArray OptimizedAttributes;

public ST_83be973cab4e7f90c5adb2c45a579242Structure() {
OptimizedAttributes = null;
ssRequisitionName = "";
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
ssRequisitionName = r.ReadText(index++, "ExcelRequisitionLogToExport.RequisitionName", "");
ssCreatedBy = r.ReadText(index++, "ExcelRequisitionLogToExport.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "ExcelRequisitionLogToExport.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMessage = r.ReadText(index++, "ExcelRequisitionLogToExport.Message", "");
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
public void ReadIM(ST_83be973cab4e7f90c5adb2c45a579242Structure r) {
this = r;
}


public static bool operator == (ST_83be973cab4e7f90c5adb2c45a579242Structure a, ST_83be973cab4e7f90c5adb2c45a579242Structure b) {
if (a.ssRequisitionName != b.ssRequisitionName) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssMessage != b.ssMessage) return false;
return true;
}

public static bool operator != (ST_83be973cab4e7f90c5adb2c45a579242Structure a, ST_83be973cab4e7f90c5adb2c45a579242Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_83be973cab4e7f90c5adb2c45a579242Structure)) return false;
return (this == (ST_83be973cab4e7f90c5adb2c45a579242Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRequisitionName.GetHashCode()
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


public ST_83be973cab4e7f90c5adb2c45a579242Structure Duplicate() {
ST_83be973cab4e7f90c5adb2c45a579242Structure t;
t.ssRequisitionName = this.ssRequisitionName;
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
if (head == "requisitionname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionName")) variable.Value = ssRequisitionName; else variable.Optimized = true;
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
if (key == IdRequisitionName) {
return ssRequisitionName;
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
if (attributeKey == IdRequisitionName.Key.AsGuid) {
return ssRequisitionName;
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
ssRequisitionName = (string) other.AttributeGet(IdRequisitionName);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ssMessage = (string) other.AttributeGet(IdMessage);
}
} // ST_83be973cab4e7f90c5adb2c45a579242Structure
/// <summary>
/// RecordList type <code>ExcelRequisitionLogToExportList</code> that represents a record list of
///  <code>ExcelRequisitionLogToExport</code>
/// </summary>
public partial class RL_8784265c9b53c1e1c23af2a418666616 : GenericRecordList<ST_83be973cab4e7f90c5adb2c45a579242Structure>, IEnumerable, IEnumerator {

protected override ST_83be973cab4e7f90c5adb2c45a579242Structure GetElementDefaultValue() {
return new ST_83be973cab4e7f90c5adb2c45a579242Structure();
}

public T[] ToArray<T>(Func<ST_83be973cab4e7f90c5adb2c45a579242Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8784265c9b53c1e1c23af2a418666616 recordList, Func<ST_83be973cab4e7f90c5adb2c45a579242Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8784265c9b53c1e1c23af2a418666616(ST_83be973cab4e7f90c5adb2c45a579242Structure[] array) {
  RL_8784265c9b53c1e1c23af2a418666616 result = new RL_8784265c9b53c1e1c23af2a418666616();
result.InnerFromArray(array);
    return result;
}

public static RL_8784265c9b53c1e1c23af2a418666616 ToList<T>(T[] array, Func <T, ST_83be973cab4e7f90c5adb2c45a579242Structure> converter) {
  RL_8784265c9b53c1e1c23af2a418666616 result = new RL_8784265c9b53c1e1c23af2a418666616();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8784265c9b53c1e1c23af2a418666616 FromRestList<T>(RestList<T> restList, Func <T, ST_83be973cab4e7f90c5adb2c45a579242Structure> converter) {
  RL_8784265c9b53c1e1c23af2a418666616 result = new RL_8784265c9b53c1e1c23af2a418666616();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8784265c9b53c1e1c23af2a418666616() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_83be973cab4e7f90c5adb2c45a579242Structure> NewList() {
return new RL_8784265c9b53c1e1c23af2a418666616();
}


} // RL_8784265c9b53c1e1c23af2a418666616
}

