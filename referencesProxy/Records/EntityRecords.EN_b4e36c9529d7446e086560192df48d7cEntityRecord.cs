using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] DatePickerTimeFormat (zbdxQtPNe0qABZhJV_1JwQ)
///  <code>EN_b4e36c9529d7446e086560192df48d7cEntityRecord</code> that represent
/// s <code>DatePickerTimeFormat</code> <p>Description: Used to configure if the calendar is DateTime
///  12/24h type or if is Date type.</p>
/// </summary>
// Name: DatePickerTimeFormat
public partial struct EN_b4e36c9529d7446e086560192df48d7cEntityRecord : ITypedRecord<EN_b4e36c9529d7446e086560192df48d7cEntityRecord> {
internal static readonly GlobalObjectKey IdTimeformat = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*pjRMw0fSt0KJG_XUAxwxMg");

private string _ssTimeformat;
public string ssTimeformat{
  get{
      return _ssTimeformat;
  }
  set{
      if((_ssTimeformat!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssTimeformat = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b4e36c9529d7446e086560192df48d7cEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssTimeformat = "";
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
ssTimeformat = r.ReadText(index++, "DatePickerTimeFormat.Timeformat", "");
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
public void ReadIM(EN_b4e36c9529d7446e086560192df48d7cEntityRecord r) {
this = r;
}


public static bool operator == (EN_b4e36c9529d7446e086560192df48d7cEntityRecord a, EN_b4e36c9529d7446e086560192df48d7cEntityRecord b) {
if (a.ssTimeformat != b.ssTimeformat) return false;
return true;
}

public static bool operator != (EN_b4e36c9529d7446e086560192df48d7cEntityRecord a, EN_b4e36c9529d7446e086560192df48d7cEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b4e36c9529d7446e086560192df48d7cEntityRecord)) return false;
return (this == (EN_b4e36c9529d7446e086560192df48d7cEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTimeformat.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b4e36c9529d7446e086560192df48d7cEntityRecord Duplicate() {
EN_b4e36c9529d7446e086560192df48d7cEntityRecord t;
t._ssTimeformat = this._ssTimeformat;
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
if (head == "timeformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Timeformat")) variable.Value = ssTimeformat; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdTimeformat)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdTimeformat)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTimeformat) {
return ssTimeformat;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTimeformat.Key.AsGuid) {
return ssTimeformat;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssTimeformat = (string) other.AttributeGet(IdTimeformat);
ChangedAttributes[0] = other.ChangedAttributeGet(IdTimeformat);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdTimeformat);
}
} // EN_b4e36c9529d7446e086560192df48d7cEntityRecord

/// <summary>
/// RecordList type <code>DatePickerTimeFormatList</code> that represents a record list of
///  <code>DatePickerTimeFormat</code>
/// </summary>
public partial class RL_4ac7560fd222f165e8fbfd92d25d984e : GenericRecordList<EN_b4e36c9529d7446e086560192df48d7cEntityRecord>, IEnumerable, IEnumerator {

protected override EN_b4e36c9529d7446e086560192df48d7cEntityRecord GetElementDefaultValue() {
return new EN_b4e36c9529d7446e086560192df48d7cEntityRecord();
}

public T[] ToArray<T>(Func<EN_b4e36c9529d7446e086560192df48d7cEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4ac7560fd222f165e8fbfd92d25d984e recordList, Func<EN_b4e36c9529d7446e086560192df48d7cEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4ac7560fd222f165e8fbfd92d25d984e(EN_b4e36c9529d7446e086560192df48d7cEntityRecord[] array) {
  RL_4ac7560fd222f165e8fbfd92d25d984e result = new RL_4ac7560fd222f165e8fbfd92d25d984e();
result.InnerFromArray(array);
    return result;
}

public static RL_4ac7560fd222f165e8fbfd92d25d984e ToList<T>(T[] array, Func <T, EN_b4e36c9529d7446e086560192df48d7cEntityRecord> converter) {
  RL_4ac7560fd222f165e8fbfd92d25d984e result = new RL_4ac7560fd222f165e8fbfd92d25d984e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4ac7560fd222f165e8fbfd92d25d984e FromRestList<T>(RestList<T> restList, Func <T, EN_b4e36c9529d7446e086560192df48d7cEntityRecord> converter) {
  RL_4ac7560fd222f165e8fbfd92d25d984e result = new RL_4ac7560fd222f165e8fbfd92d25d984e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4ac7560fd222f165e8fbfd92d25d984e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b4e36c9529d7446e086560192df48d7cEntityRecord> NewList() {
return new RL_4ac7560fd222f165e8fbfd92d25d984e();
}


} // RL_4ac7560fd222f165e8fbfd92d25d984e
}
