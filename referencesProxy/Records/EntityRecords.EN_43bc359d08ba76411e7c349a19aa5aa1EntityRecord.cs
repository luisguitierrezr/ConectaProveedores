using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] User_Preferences (GMkr62B1Z0uJhyEN5AywUw)
///  <code>EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord</code> that represent
/// s <code>User_Preferences</code> <p>Description: Entity holds users preferences.</p>
/// </summary>
// Name: User_Preferences
public partial struct EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord : ITypedRecord<EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ejXuzDtj+kGriD0gOEfo1A");
internal static readonly GlobalObjectKey IdTableLinesCount = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ibmVbVHL7Uqhh43HUYkp8Q");

private string _ssId;
public string ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssId = value;
      }
  }
}

private int _ssTableLinesCount;
public int ssTableLinesCount{
  get{
      return _ssTableLinesCount;
  }
  set{
      if((_ssTableLinesCount!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssTableLinesCount = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssId = "";
_ssTableLinesCount = 20;
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
ssId = r.ReadEntityReferenceText(index++, "User_Preferences.Id", "");
ssTableLinesCount = r.ReadInteger(index++, "User_Preferences.TableLinesCount", 20);
ChangedAttributes = new BitArray(2,false);
OptimizedAttributes = new BitArray(2,false);
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
public void ReadIM(EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord r) {
this = r;
}


public static bool operator == (EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord a, EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssTableLinesCount != b.ssTableLinesCount) return false;
return true;
}

public static bool operator != (EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord a, EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord)) return false;
return (this == (EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssTableLinesCount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord Duplicate() {
EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord t;
t._ssId = this._ssId;
t._ssTableLinesCount = this._ssTableLinesCount;
t.ChangedAttributes = new BitArray(2);
t.OptimizedAttributes = new BitArray(2);
for(int i = 0; i < 2; i++){
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "tablelinescount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TableLinesCount")) variable.Value = ssTableLinesCount; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdTableLinesCount)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdTableLinesCount)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdTableLinesCount) {
return ssTableLinesCount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdTableLinesCount.Key.AsGuid) {
return ssTableLinesCount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssTableLinesCount = (int) other.AttributeGet(IdTableLinesCount);
ChangedAttributes[1] = other.ChangedAttributeGet(IdTableLinesCount);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdTableLinesCount);
}
} // EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord

/// <summary>
/// RecordList type <code>User_PreferencesList</code> that represents a record list of
///  <code>User_Preferences</code>
/// </summary>
public partial class RL_ba7ab64121bb43496875f9beff1f920f : GenericRecordList<EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord>, IEnumerable, IEnumerator {

protected override EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord GetElementDefaultValue() {
return new EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord();
}

public T[] ToArray<T>(Func<EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ba7ab64121bb43496875f9beff1f920f recordList, Func<EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ba7ab64121bb43496875f9beff1f920f(EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord[] array) {
  RL_ba7ab64121bb43496875f9beff1f920f result = new RL_ba7ab64121bb43496875f9beff1f920f();
result.InnerFromArray(array);
    return result;
}

public static RL_ba7ab64121bb43496875f9beff1f920f ToList<T>(T[] array, Func <T, EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord> converter) {
  RL_ba7ab64121bb43496875f9beff1f920f result = new RL_ba7ab64121bb43496875f9beff1f920f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ba7ab64121bb43496875f9beff1f920f FromRestList<T>(RestList<T> restList, Func <T, EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord> converter) {
  RL_ba7ab64121bb43496875f9beff1f920f result = new RL_ba7ab64121bb43496875f9beff1f920f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ba7ab64121bb43496875f9beff1f920f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord> NewList() {
return new RL_ba7ab64121bb43496875f9beff1f920f();
}


} // RL_ba7ab64121bb43496875f9beff1f920f
}
