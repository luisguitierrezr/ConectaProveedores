namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] DatePickerOptionalConfigs (IrulOpcf5EmHoBLWJAoAaw)
///  <code>ST_bc4abb4233d9ce894e855c520a20c76fStructure</code> that represent
/// s <code>DatePickerOptionalConfigs</code> <p>Description: DatePicker optional internal
///  configurations.</p>
/// </summary>
// Name: DatePickerOptionalConfigs
public partial struct ST_bc4abb4233d9ce894e855c520a20c76fStructure : ITypedRecord<ST_bc4abb4233d9ce894e855c520a20c76fStructure> {
internal static readonly GlobalObjectKey IdInitialDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*S_15GoFxl0C+t3SfJwVmDA");
internal static readonly GlobalObjectKey IdMinDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*1SSzY547JEO3wqEFECrPeQ");
internal static readonly GlobalObjectKey IdMaxDate = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*D_LdwD6ij0mHiPuLRLIUTg");
internal static readonly GlobalObjectKey IdFirstWeekDay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*zeDf2arKzU2w9FzyUZbCZw");
internal static readonly GlobalObjectKey IdShowWeekNumbers = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*7I+AaWC0MECxT2hCPw7BNw");

public DateTime ssInitialDate;

public DateTime ssMinDate;

public DateTime ssMaxDate;

public int ssFirstWeekDay;

public bool ssShowWeekNumbers;


public BitArray OptimizedAttributes;

public ST_bc4abb4233d9ce894e855c520a20c76fStructure() {
OptimizedAttributes = null;
ssInitialDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMinDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssMaxDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssFirstWeekDay = RsseSpaceOutSystemsUI.DefaultValues.ReferenceStructure_DatePickerOptionalConfigs_ReferenceStructureAttribute_FirstWeekDay;
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
ssInitialDate = r.ReadDateTime(index++, "DatePickerOptionalConfigs.InitialDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMinDate = r.ReadDateTime(index++, "DatePickerOptionalConfigs.MinDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssMaxDate = r.ReadDateTime(index++, "DatePickerOptionalConfigs.MaxDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssFirstWeekDay = r.ReadEntityReference(index++, "DatePickerOptionalConfigs.FirstWeekDay", 0);
ssShowWeekNumbers = r.ReadBoolean(index++, "DatePickerOptionalConfigs.ShowWeekNumbers", false);
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
public void ReadIM(ST_bc4abb4233d9ce894e855c520a20c76fStructure r) {
this = r;
}


public static bool operator == (ST_bc4abb4233d9ce894e855c520a20c76fStructure a, ST_bc4abb4233d9ce894e855c520a20c76fStructure b) {
if (a.ssInitialDate != b.ssInitialDate) return false;
if (a.ssMinDate != b.ssMinDate) return false;
if (a.ssMaxDate != b.ssMaxDate) return false;
if (a.ssFirstWeekDay != b.ssFirstWeekDay) return false;
if (a.ssShowWeekNumbers != b.ssShowWeekNumbers) return false;
return true;
}

public static bool operator != (ST_bc4abb4233d9ce894e855c520a20c76fStructure a, ST_bc4abb4233d9ce894e855c520a20c76fStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_bc4abb4233d9ce894e855c520a20c76fStructure)) return false;
return (this == (ST_bc4abb4233d9ce894e855c520a20c76fStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInitialDate.GetHashCode()
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


public ST_bc4abb4233d9ce894e855c520a20c76fStructure Duplicate() {
ST_bc4abb4233d9ce894e855c520a20c76fStructure t;
t.ssInitialDate = this.ssInitialDate;
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
if (head == "initialdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InitialDate")) variable.Value = ssInitialDate; else variable.Optimized = true;
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
if (key == IdInitialDate) {
return ssInitialDate;
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
if (attributeKey == IdInitialDate.Key.AsGuid) {
return ssInitialDate;
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
ssInitialDate = (DateTime) other.AttributeGet(IdInitialDate);
ssMinDate = (DateTime) other.AttributeGet(IdMinDate);
ssMaxDate = (DateTime) other.AttributeGet(IdMaxDate);
ssFirstWeekDay = (int) other.AttributeGet(IdFirstWeekDay);
ssShowWeekNumbers = (bool) other.AttributeGet(IdShowWeekNumbers);
}
} // ST_bc4abb4233d9ce894e855c520a20c76fStructure
/// <summary>
/// RecordList type <code>DatePickerOptionalConfigsList</code> that represents a record list of
///  <code>DatePickerOptionalConfigs</code>
/// </summary>
public partial class RL_806e82a94733d0af9e43960265151f80 : GenericRecordList<ST_bc4abb4233d9ce894e855c520a20c76fStructure>, IEnumerable, IEnumerator {

protected override ST_bc4abb4233d9ce894e855c520a20c76fStructure GetElementDefaultValue() {
return new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
}

public T[] ToArray<T>(Func<ST_bc4abb4233d9ce894e855c520a20c76fStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_806e82a94733d0af9e43960265151f80 recordList, Func<ST_bc4abb4233d9ce894e855c520a20c76fStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_806e82a94733d0af9e43960265151f80(ST_bc4abb4233d9ce894e855c520a20c76fStructure[] array) {
  RL_806e82a94733d0af9e43960265151f80 result = new RL_806e82a94733d0af9e43960265151f80();
result.InnerFromArray(array);
    return result;
}

public static RL_806e82a94733d0af9e43960265151f80 ToList<T>(T[] array, Func <T, ST_bc4abb4233d9ce894e855c520a20c76fStructure> converter) {
  RL_806e82a94733d0af9e43960265151f80 result = new RL_806e82a94733d0af9e43960265151f80();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_806e82a94733d0af9e43960265151f80 FromRestList<T>(RestList<T> restList, Func <T, ST_bc4abb4233d9ce894e855c520a20c76fStructure> converter) {
  RL_806e82a94733d0af9e43960265151f80 result = new RL_806e82a94733d0af9e43960265151f80();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_806e82a94733d0af9e43960265151f80() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_bc4abb4233d9ce894e855c520a20c76fStructure> NewList() {
return new RL_806e82a94733d0af9e43960265151f80();
}


} // RL_806e82a94733d0af9e43960265151f80
}

