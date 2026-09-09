using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] LegendPosition (djQQgu22SEmKte8euWfeOg)
///  <code>EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord</code> that represent
/// s <code>LegendPosition</code> <p>Description: </p>
/// </summary>
// Name: LegendPosition
public partial struct EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord : ITypedRecord<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord> {
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*3fPFW9A91E+51KQXgp8SAQ");

private string _ssPosition;
public string ssPosition{
  get{
      return _ssPosition;
  }
  set{
      if((_ssPosition!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssPosition = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssPosition = "";
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
ssPosition = r.ReadText(index++, "LegendPosition.Position", "");
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
public void ReadIM(EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord r) {
this = r;
}


public static bool operator == (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord a, EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord b) {
if (a.ssPosition != b.ssPosition) return false;
return true;
}

public static bool operator != (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord a, EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord)) return false;
return (this == (EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPosition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord Duplicate() {
EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord t;
t._ssPosition = this._ssPosition;
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
if (head == "position") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Position")) variable.Value = ssPosition; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdPosition)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdPosition)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdPosition) {
return ssPosition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPosition.Key.AsGuid) {
return ssPosition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssPosition = (string) other.AttributeGet(IdPosition);
ChangedAttributes[0] = other.ChangedAttributeGet(IdPosition);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdPosition);
}
} // EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord

/// <summary>
/// RecordList type <code>LegendPositionList</code> that represents a record list of
///  <code>LegendPosition</code>
/// </summary>
public partial class RL_1c28901efde3032d217fafbbe1ebcdba : GenericRecordList<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord>, IEnumerable, IEnumerator {

protected override EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord GetElementDefaultValue() {
return new EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord();
}

public T[] ToArray<T>(Func<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1c28901efde3032d217fafbbe1ebcdba recordList, Func<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1c28901efde3032d217fafbbe1ebcdba(EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord[] array) {
  RL_1c28901efde3032d217fafbbe1ebcdba result = new RL_1c28901efde3032d217fafbbe1ebcdba();
result.InnerFromArray(array);
    return result;
}

public static RL_1c28901efde3032d217fafbbe1ebcdba ToList<T>(T[] array, Func <T, EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord> converter) {
  RL_1c28901efde3032d217fafbbe1ebcdba result = new RL_1c28901efde3032d217fafbbe1ebcdba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1c28901efde3032d217fafbbe1ebcdba FromRestList<T>(RestList<T> restList, Func <T, EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord> converter) {
  RL_1c28901efde3032d217fafbbe1ebcdba result = new RL_1c28901efde3032d217fafbbe1ebcdba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1c28901efde3032d217fafbbe1ebcdba() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_c09810fe22e8a6a144d75dbd4ee5e70eEntityRecord> NewList() {
return new RL_1c28901efde3032d217fafbbe1ebcdba();
}


} // RL_1c28901efde3032d217fafbbe1ebcdba
}
