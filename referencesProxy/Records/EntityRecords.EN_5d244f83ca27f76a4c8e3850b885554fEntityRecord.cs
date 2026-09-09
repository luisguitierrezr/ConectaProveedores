using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] RetentionTypes (FzJmGgzmEEGWniVP5TS+eA)
///  <code>EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord</code> that represent
/// s <code>RetentionTypes</code> <p>Description: Retention Types and Description</p>
/// </summary>
// Name: RetentionTypes
public partial struct EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord : ITypedRecord<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*s_of35ar+U+9pKRqSJEjuw");
internal static readonly GlobalObjectKey IdIndicator = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*qHVaQJ9URESGfqQ10EkbjQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*h26CQuDPckmK0UFFVG5ZBw");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(3,true);
          _ssId = value;
      }
  }
}

private string _ssIndicator;
public string ssIndicator{
  get{
      return _ssIndicator;
  }
  set{
      if((_ssIndicator!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssIndicator = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssDescription = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord() {
ChangedAttributes = new BitArray(3,true);
OptimizedAttributes = new BitArray(3,false);
_ssId = 0L;
_ssIndicator = "";
_ssDescription = "";
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
ssId = r.ReadLongInteger(index++, "RetentionTypes.Id", 0L);
ssIndicator = r.ReadText(index++, "RetentionTypes.Indicator", "");
ssDescription = r.ReadText(index++, "RetentionTypes.Description", "");
ChangedAttributes = new BitArray(3,false);
OptimizedAttributes = new BitArray(3,false);
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
public void ReadIM(EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord r) {
this = r;
}


public static bool operator == (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord a, EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssIndicator != b.ssIndicator) return false;
if (a.ssDescription != b.ssDescription) return false;
return true;
}

public static bool operator != (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord a, EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord)) return false;
return (this == (EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssIndicator.GetHashCode()
 ^ ssDescription.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord Duplicate() {
EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord t;
t._ssId = this._ssId;
t._ssIndicator = this._ssIndicator;
t._ssDescription = this._ssDescription;
t.ChangedAttributes = new BitArray(3);
t.OptimizedAttributes = new BitArray(3);
for(int i = 0; i < 3; i++){
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
} else if (head == "indicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Indicator")) variable.Value = ssIndicator; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdIndicator)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[2];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdIndicator)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[2];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdIndicator) {
return ssIndicator;
}
if (key == IdDescription) {
return ssDescription;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdIndicator.Key.AsGuid) {
return ssIndicator;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(3);
OptimizedAttributes = new BitArray(3);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssIndicator = (string) other.AttributeGet(IdIndicator);
ChangedAttributes[1] = other.ChangedAttributeGet(IdIndicator);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdIndicator);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
}
} // EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord

/// <summary>
/// RecordList type <code>RetentionTypesList</code> that represents a record list of
///  <code>RetentionTypes</code>
/// </summary>
public partial class RL_35287b560abefc29cc450e1d436ca53e : GenericRecordList<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord>, IEnumerable, IEnumerator {

protected override EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord GetElementDefaultValue() {
return new EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord();
}

public T[] ToArray<T>(Func<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_35287b560abefc29cc450e1d436ca53e recordList, Func<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_35287b560abefc29cc450e1d436ca53e(EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord[] array) {
  RL_35287b560abefc29cc450e1d436ca53e result = new RL_35287b560abefc29cc450e1d436ca53e();
result.InnerFromArray(array);
    return result;
}

public static RL_35287b560abefc29cc450e1d436ca53e ToList<T>(T[] array, Func <T, EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> converter) {
  RL_35287b560abefc29cc450e1d436ca53e result = new RL_35287b560abefc29cc450e1d436ca53e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_35287b560abefc29cc450e1d436ca53e FromRestList<T>(RestList<T> restList, Func <T, EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> converter) {
  RL_35287b560abefc29cc450e1d436ca53e result = new RL_35287b560abefc29cc450e1d436ca53e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_35287b560abefc29cc450e1d436ca53e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5d244f83ca27f76a4c8e3850b885554fEntityRecord> NewList() {
return new RL_35287b560abefc29cc450e1d436ca53e();
}


} // RL_35287b560abefc29cc450e1d436ca53e
}
