namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] DatePickerRangeOptionalConfigs (aRMWN+yUs0SEHtus9XxBSw)
///  <code>ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure</code> that represent
/// s <code>DatePickerRangeOptionalConfigs</code> <p>Description: DatePickerRange optional internal
///  configurations.</p>
/// </summary>
// Name: DatePickerRangeOptionalConfigs
public partial struct ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure : ITypedRecord<ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure> {
internal static readonly GlobalObjectKey IdInitialStartDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*70hTE0zDtkG_wsJtWfhuXw");
internal static readonly GlobalObjectKey IdInitialEndDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*5dcioJdmLUuRCLEhUrE08Q");
internal static readonly GlobalObjectKey IdMinDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*jMlVIFCeZ0q71cotQpUubA");
internal static readonly GlobalObjectKey IdMaxDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*3Bu4RSWEbUiR7SaPBbpBLw");
internal static readonly GlobalObjectKey IdFirstWeekDay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*eTxdEz_PPEekX7WwyzvHRA");
internal static readonly GlobalObjectKey IdShowWeekNumbers = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*DNBR4HdIeUKQk0axQDsxWA");

public DateTime ssInitialStartDate;

public DateTime ssInitialEndDate;

public DateTime ssMinDate;

public DateTime ssMaxDate;

public int ssFirstWeekDay;

public bool ssShowWeekNumbers;


public BitArray OptimizedAttributes;

public ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure() {
OptimizedAttributes = null;
ssInitialStartDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssInitialEndDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMinDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMaxDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssFirstWeekDay = RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DatePickerRangeOptionalConfigs_ReferenceStructureAttribute_FirstWeekDay;
ssShowWeekNumbers = false;
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
ssInitialStartDate = r.ReadDate(index++, "DatePickerRangeOptionalConfigs.InitialStartDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssInitialEndDate = r.ReadDate(index++, "DatePickerRangeOptionalConfigs.InitialEndDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMinDate = r.ReadDate(index++, "DatePickerRangeOptionalConfigs.MinDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMaxDate = r.ReadDate(index++, "DatePickerRangeOptionalConfigs.MaxDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFirstWeekDay = r.ReadEntityReference(index++, "DatePickerRangeOptionalConfigs.FirstWeekDay", 0);
ssShowWeekNumbers = r.ReadBoolean(index++, "DatePickerRangeOptionalConfigs.ShowWeekNumbers", false);
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
public void ReadIM(ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure r) {
this = r;
}


public static bool operator == (ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure a, ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure b) {
if (a.ssInitialStartDate != b.ssInitialStartDate) return false;
if (a.ssInitialEndDate != b.ssInitialEndDate) return false;
if (a.ssMinDate != b.ssMinDate) return false;
if (a.ssMaxDate != b.ssMaxDate) return false;
if (a.ssFirstWeekDay != b.ssFirstWeekDay) return false;
if (a.ssShowWeekNumbers != b.ssShowWeekNumbers) return false;
return true;
}

public static bool operator != (ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure a, ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure)) return false;
return (this == (ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInitialStartDate.GetHashCode()
 ^ ssInitialEndDate.GetHashCode()
 ^ ssMinDate.GetHashCode()
 ^ ssMaxDate.GetHashCode()
 ^ ssFirstWeekDay.GetHashCode()
 ^ ssShowWeekNumbers.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure Duplicate() {
ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure t;
t.ssInitialStartDate = this.ssInitialStartDate;
t.ssInitialEndDate = this.ssInitialEndDate;
t.ssMinDate = this.ssMinDate;
t.ssMaxDate = this.ssMaxDate;
t.ssFirstWeekDay = this.ssFirstWeekDay;
t.ssShowWeekNumbers = this.ssShowWeekNumbers;
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
if (head == "initialstartdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialStartDate")) variable.Value = ssInitialStartDate; else variable.Optimized = true;
} else if (head == "initialenddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialEndDate")) variable.Value = ssInitialEndDate; else variable.Optimized = true;
} else if (head == "mindate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MinDate")) variable.Value = ssMinDate; else variable.Optimized = true;
} else if (head == "maxdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MaxDate")) variable.Value = ssMaxDate; else variable.Optimized = true;
} else if (head == "firstweekday") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstWeekDay")) variable.Value = ssFirstWeekDay; else variable.Optimized = true;
} else if (head == "showweeknumbers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowWeekNumbers")) variable.Value = ssShowWeekNumbers; else variable.Optimized = true;
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
if (key == IdInitialStartDate) {
return ssInitialStartDate;
}
if (key == IdInitialEndDate) {
return ssInitialEndDate;
}
if (key == IdMinDate) {
return ssMinDate;
}
if (key == IdMaxDate) {
return ssMaxDate;
}
if (key == IdFirstWeekDay) {
return ssFirstWeekDay;
}
if (key == IdShowWeekNumbers) {
return ssShowWeekNumbers;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInitialStartDate.Key.AsGuid) {
return ssInitialStartDate;
}
if (attributeKey == IdInitialEndDate.Key.AsGuid) {
return ssInitialEndDate;
}
if (attributeKey == IdMinDate.Key.AsGuid) {
return ssMinDate;
}
if (attributeKey == IdMaxDate.Key.AsGuid) {
return ssMaxDate;
}
if (attributeKey == IdFirstWeekDay.Key.AsGuid) {
return ssFirstWeekDay;
}
if (attributeKey == IdShowWeekNumbers.Key.AsGuid) {
return ssShowWeekNumbers;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInitialStartDate = (DateTime) other.AttributeGet(IdInitialStartDate);
ssInitialEndDate = (DateTime) other.AttributeGet(IdInitialEndDate);
ssMinDate = (DateTime) other.AttributeGet(IdMinDate);
ssMaxDate = (DateTime) other.AttributeGet(IdMaxDate);
ssFirstWeekDay = (int) other.AttributeGet(IdFirstWeekDay);
ssShowWeekNumbers = (bool) other.AttributeGet(IdShowWeekNumbers);
}
} // ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure
/// <summary>
/// RecordList type <code>DatePickerRangeOptionalConfigsList</code> that represents a record list of
///  <code>DatePickerRangeOptionalConfigs</code>
/// </summary>
public partial class RL_4d556c695c13b2c308f888cfb68cea19 : GenericRecordList<ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure>, IEnumerable, IEnumerator {

protected override ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure GetElementDefaultValue() {
return new ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure();
}

public T[] ToArray<T>(Func<ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d556c695c13b2c308f888cfb68cea19 recordList, Func<ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d556c695c13b2c308f888cfb68cea19(ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure[] array) {
  RL_4d556c695c13b2c308f888cfb68cea19 result = new RL_4d556c695c13b2c308f888cfb68cea19();
result.InnerFromArray(array);
    return result;
}

public static RL_4d556c695c13b2c308f888cfb68cea19 ToList<T>(T[] array, Func <T, ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure> converter) {
  RL_4d556c695c13b2c308f888cfb68cea19 result = new RL_4d556c695c13b2c308f888cfb68cea19();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d556c695c13b2c308f888cfb68cea19 FromRestList<T>(RestList<T> restList, Func <T, ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure> converter) {
  RL_4d556c695c13b2c308f888cfb68cea19 result = new RL_4d556c695c13b2c308f888cfb68cea19();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d556c695c13b2c308f888cfb68cea19() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure> NewList() {
return new RL_4d556c695c13b2c308f888cfb68cea19();
}


} // RL_4d556c695c13b2c308f888cfb68cea19
}

