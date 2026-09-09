using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] DatePickerWeekDay (L43URelRDECZzj0S6wwJaw)
///  <code>EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord</code> that represent
/// s <code>DatePickerWeekDay</code> <p>Description: Used to define which week day should be displayed
///  first.</p>
/// </summary>
// Name: DatePickerWeekDay
public partial struct EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord : ITypedRecord<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord> {
internal static readonly GlobalObjectKey IdWeekDay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Nj2cHrfzu0eJjA2quZMZBw");

private int _ssWeekDay;
public int ssWeekDay{
  get{
      return _ssWeekDay;
  }
  set{
      if((_ssWeekDay!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssWeekDay = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssWeekDay = 0;
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
ssWeekDay = r.ReadInteger(index++, "DatePickerWeekDay.WeekDay", 0);
ChangedAttributes = new BitArray(1,false);
OptimizedAttributes = new BitArray(1,false);
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
public void ReadIM(EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord r) {
this = r;
}


public static bool operator == (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord a, EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord b) {
if (a.ssWeekDay != b.ssWeekDay) return false;
return true;
}

public static bool operator != (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord a, EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord)) return false;
return (this == (EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssWeekDay.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord Duplicate() {
EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord t;
t._ssWeekDay = this._ssWeekDay;
t.ChangedAttributes = new BitArray(1);
t.OptimizedAttributes = new BitArray(1);
for(int i = 0; i < 1; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
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
if (head == "weekday") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WeekDay")) variable.Value = ssWeekDay; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdWeekDay)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdWeekDay)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdWeekDay) {
return ssWeekDay;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdWeekDay.Key.AsGuid) {
return ssWeekDay;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssWeekDay = (int) other.AttributeGet(IdWeekDay);
ChangedAttributes[0] = other.ChangedAttributeGet(IdWeekDay);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdWeekDay);
}
} // EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord

/// <summary>
/// RecordList type <code>DatePickerWeekDayList</code> that represents a record list of
///  <code>DatePickerWeekDay</code>
/// </summary>
public partial class RL_4e7296c1aceb3bd3dd9793888e254d07 : GenericRecordList<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord>, IEnumerable, IEnumerator {

protected override EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord GetElementDefaultValue() {
return new EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord();
}

public T[] ToArray<T>(Func<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4e7296c1aceb3bd3dd9793888e254d07 recordList, Func<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4e7296c1aceb3bd3dd9793888e254d07(EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord[] array) {
  RL_4e7296c1aceb3bd3dd9793888e254d07 result = new RL_4e7296c1aceb3bd3dd9793888e254d07();
result.InnerFromArray(array);
    return result;
}

public static RL_4e7296c1aceb3bd3dd9793888e254d07 ToList<T>(T[] array, Func <T, EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord> converter) {
  RL_4e7296c1aceb3bd3dd9793888e254d07 result = new RL_4e7296c1aceb3bd3dd9793888e254d07();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4e7296c1aceb3bd3dd9793888e254d07 FromRestList<T>(RestList<T> restList, Func <T, EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord> converter) {
  RL_4e7296c1aceb3bd3dd9793888e254d07 result = new RL_4e7296c1aceb3bd3dd9793888e254d07();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4e7296c1aceb3bd3dd9793888e254d07() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1b42e9a925bffd384f525d6adac8fe8eEntityRecord> NewList() {
return new RL_4e7296c1aceb3bd3dd9793888e254d07();
}


} // RL_4e7296c1aceb3bd3dd9793888e254d07
}
