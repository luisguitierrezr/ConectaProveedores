namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (FOLDEG0tkUy0sSBeSGK2oA)
///  <code>RC_210f541f43ec6384ba59bfd8fe4b8837</code> that represent
/// s <code>DatePickerWeekDayRecord</code> <p>Description: </p>
/// </summary>
// Name: DatePickerWeekDayRecord
public partial struct RC_210f541f43ec6384ba59bfd8fe4b8837 : ITypedRecord<RC_210f541f43ec6384ba59bfd8fe4b8837> {
internal static readonly GlobalObjectKey IdDatePickerWeekDay = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*H1QPIexDhGO6Wb_Y_kuINw");

public EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord ssENDatePickerWeekDay;


public static implicit operator EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord( RC_210f541f43ec6384ba59bfd8fe4b8837 r) {
return r.ssENDatePickerWeekDay;
}

public static implicit operator RC_210f541f43ec6384ba59bfd8fe4b8837 (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord r) {
RC_210f541f43ec6384ba59bfd8fe4b8837 res = new RC_210f541f43ec6384ba59bfd8fe4b8837 ();
res.ssENDatePickerWeekDay = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDatePickerWeekDay.ChangedAttributes = value;
}
get {
    return ssENDatePickerWeekDay.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_210f541f43ec6384ba59bfd8fe4b8837() {
OptimizedAttributes = null;
ssENDatePickerWeekDay = new EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDatePickerWeekDay.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDatePickerWeekDay.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDatePickerWeekDay.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDatePickerWeekDay.Read( r, ref index);
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
public void ReadIM(RC_210f541f43ec6384ba59bfd8fe4b8837 r) {
this = r;
}


public static bool operator == (RC_210f541f43ec6384ba59bfd8fe4b8837 a, RC_210f541f43ec6384ba59bfd8fe4b8837 b) {
if (a.ssENDatePickerWeekDay != b.ssENDatePickerWeekDay) return false;
return true;
}

public static bool operator != (RC_210f541f43ec6384ba59bfd8fe4b8837 a, RC_210f541f43ec6384ba59bfd8fe4b8837 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_210f541f43ec6384ba59bfd8fe4b8837)) return false;
return (this == (RC_210f541f43ec6384ba59bfd8fe4b8837)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDatePickerWeekDay.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDatePickerWeekDay.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDatePickerWeekDay.InternalRecursiveSave();
}


public RC_210f541f43ec6384ba59bfd8fe4b8837 Duplicate() {
RC_210f541f43ec6384ba59bfd8fe4b8837 t;
t.ssENDatePickerWeekDay = (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord)this.ssENDatePickerWeekDay.Duplicate();
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
if (head == "datepickerweekday") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DatePickerWeekDay")) variable.Value = ssENDatePickerWeekDay; else variable.Optimized = true;
variable.SetFieldName("datepickerweekday");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerWeekDay.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDatePickerWeekDay.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDatePickerWeekDay) {
return ssENDatePickerWeekDay;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDatePickerWeekDay.Key.AsGuid) {
return ssENDatePickerWeekDay;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDatePickerWeekDay.FillFromOther((IRecord) other.AttributeGet(IdDatePickerWeekDay));
}
} // RC_210f541f43ec6384ba59bfd8fe4b8837
/// <summary>
/// RecordList type <code>DatePickerWeekDayRecordList</code> that represents a record list of
///  <code>DatePickerWeekDay</code>
/// </summary>
public partial class RL_073741b4a94a52714ff12683c5a2ca93 : GenericRecordList<RC_210f541f43ec6384ba59bfd8fe4b8837>, IEnumerable, IEnumerator {

protected override RC_210f541f43ec6384ba59bfd8fe4b8837 GetElementDefaultValue() {
return new RC_210f541f43ec6384ba59bfd8fe4b8837();
}

public T[] ToArray<T>(Func<RC_210f541f43ec6384ba59bfd8fe4b8837, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_073741b4a94a52714ff12683c5a2ca93 recordList, Func<RC_210f541f43ec6384ba59bfd8fe4b8837, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_073741b4a94a52714ff12683c5a2ca93(RC_210f541f43ec6384ba59bfd8fe4b8837[] array) {
  RL_073741b4a94a52714ff12683c5a2ca93 result = new RL_073741b4a94a52714ff12683c5a2ca93();
result.InnerFromArray(array);
    return result;
}

public static RL_073741b4a94a52714ff12683c5a2ca93 ToList<T>(T[] array, Func <T, RC_210f541f43ec6384ba59bfd8fe4b8837> converter) {
  RL_073741b4a94a52714ff12683c5a2ca93 result = new RL_073741b4a94a52714ff12683c5a2ca93();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_073741b4a94a52714ff12683c5a2ca93 FromRestList<T>(RestList<T> restList, Func <T, RC_210f541f43ec6384ba59bfd8fe4b8837> converter) {
  RL_073741b4a94a52714ff12683c5a2ca93 result = new RL_073741b4a94a52714ff12683c5a2ca93();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_073741b4a94a52714ff12683c5a2ca93() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_210f541f43ec6384ba59bfd8fe4b8837> NewList() {
return new RL_073741b4a94a52714ff12683c5a2ca93();
}


} // RL_073741b4a94a52714ff12683c5a2ca93
}

