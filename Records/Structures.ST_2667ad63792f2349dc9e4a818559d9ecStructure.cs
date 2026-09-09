namespace ssConectaProveedores {
/// <summary>
/// [Structure] ValidationReportAuthorization (aZobX2mTlkW+Cih1l0vv+A)
///  <code>ST_2667ad63792f2349dc9e4a818559d9ecStructure</code> that represent
/// s <code>ValidationReportAuthorization</code> <p>Description: </p>
/// </summary>
// Name: ValidationReportAuthorization
public partial struct ST_2667ad63792f2349dc9e4a818559d9ecStructure : ITypedRecord<ST_2667ad63792f2349dc9e4a818559d9ecStructure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UEzzYG_i+EO28fw3DPvRWw");
internal static readonly GlobalObjectKey IdField = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2Ay3yRaLb02l8gRgQS9HAw");
internal static readonly GlobalObjectKey IdDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*v9tPgRC2v0Oo4d+wCt5OMQ");
internal static readonly GlobalObjectKey IdHour = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5VOf58y42EGDwhTiOqbIqw");

public string ssName;

public string ssField;

public string ssDate;

public string ssHour;


public BitArray OptimizedAttributes;

public ST_2667ad63792f2349dc9e4a818559d9ecStructure() {
OptimizedAttributes = null;
ssName = "";
ssField = "";
ssDate = "";
ssHour = "";
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
ssName = r.ReadText(index++, "ValidationReportAuthorization.Name", "");
ssField = r.ReadText(index++, "ValidationReportAuthorization.Field", "");
ssDate = r.ReadText(index++, "ValidationReportAuthorization.Date", "");
ssHour = r.ReadText(index++, "ValidationReportAuthorization.Hour", "");
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
public void ReadIM(ST_2667ad63792f2349dc9e4a818559d9ecStructure r) {
this = r;
}


public static bool operator == (ST_2667ad63792f2349dc9e4a818559d9ecStructure a, ST_2667ad63792f2349dc9e4a818559d9ecStructure b) {
if (a.ssName != b.ssName) return false;
if (a.ssField != b.ssField) return false;
if (a.ssDate != b.ssDate) return false;
if (a.ssHour != b.ssHour) return false;
return true;
}

public static bool operator != (ST_2667ad63792f2349dc9e4a818559d9ecStructure a, ST_2667ad63792f2349dc9e4a818559d9ecStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_2667ad63792f2349dc9e4a818559d9ecStructure)) return false;
return (this == (ST_2667ad63792f2349dc9e4a818559d9ecStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssField.GetHashCode()
 ^ ssDate.GetHashCode()
 ^ ssHour.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_2667ad63792f2349dc9e4a818559d9ecStructure Duplicate() {
ST_2667ad63792f2349dc9e4a818559d9ecStructure t;
t.ssName = this.ssName;
t.ssField = this.ssField;
t.ssDate = this.ssDate;
t.ssHour = this.ssHour;
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
if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "field") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Field")) variable.Value = ssField; else variable.Optimized = true;
} else if (head == "date") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Date")) variable.Value = ssDate; else variable.Optimized = true;
} else if (head == "hour") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hour")) variable.Value = ssHour; else variable.Optimized = true;
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
if (key == IdName) {
return ssName;
}
if (key == IdField) {
return ssField;
}
if (key == IdDate) {
return ssDate;
}
if (key == IdHour) {
return ssHour;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdField.Key.AsGuid) {
return ssField;
}
if (attributeKey == IdDate.Key.AsGuid) {
return ssDate;
}
if (attributeKey == IdHour.Key.AsGuid) {
return ssHour;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssField = (string) other.AttributeGet(IdField);
ssDate = (string) other.AttributeGet(IdDate);
ssHour = (string) other.AttributeGet(IdHour);
}
} // ST_2667ad63792f2349dc9e4a818559d9ecStructure
/// <summary>
/// RecordList type <code>ValidationReportAuthorizationList</code> that represents a record list of
///  <code>ValidationReportAuthorization</code>
/// </summary>
public partial class RL_2d1a9f1ebd1dae77afe7dba56f4eb06c : GenericRecordList<ST_2667ad63792f2349dc9e4a818559d9ecStructure>, IEnumerable, IEnumerator {

protected override ST_2667ad63792f2349dc9e4a818559d9ecStructure GetElementDefaultValue() {
return new ST_2667ad63792f2349dc9e4a818559d9ecStructure();
}

public T[] ToArray<T>(Func<ST_2667ad63792f2349dc9e4a818559d9ecStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2d1a9f1ebd1dae77afe7dba56f4eb06c recordList, Func<ST_2667ad63792f2349dc9e4a818559d9ecStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2d1a9f1ebd1dae77afe7dba56f4eb06c(ST_2667ad63792f2349dc9e4a818559d9ecStructure[] array) {
  RL_2d1a9f1ebd1dae77afe7dba56f4eb06c result = new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c();
result.InnerFromArray(array);
    return result;
}

public static RL_2d1a9f1ebd1dae77afe7dba56f4eb06c ToList<T>(T[] array, Func <T, ST_2667ad63792f2349dc9e4a818559d9ecStructure> converter) {
  RL_2d1a9f1ebd1dae77afe7dba56f4eb06c result = new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2d1a9f1ebd1dae77afe7dba56f4eb06c FromRestList<T>(RestList<T> restList, Func <T, ST_2667ad63792f2349dc9e4a818559d9ecStructure> converter) {
  RL_2d1a9f1ebd1dae77afe7dba56f4eb06c result = new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2d1a9f1ebd1dae77afe7dba56f4eb06c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_2667ad63792f2349dc9e4a818559d9ecStructure> NewList() {
return new RL_2d1a9f1ebd1dae77afe7dba56f4eb06c();
}


} // RL_2d1a9f1ebd1dae77afe7dba56f4eb06c
}

