using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] AccordionIconPosition (2FfXkOlPO0WL7nU8zd2hMw)
///  <code>EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord</code> that represent
/// s <code>AccordionIconPosition</code> <p>Description: Sets the position of the icon in a Accordion
///  Item pattern.</p>
/// </summary>
// Name: AccordionIconPosition
public partial struct EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord : ITypedRecord<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord> {
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*ipjnC+_NWEKtCwaIWtCFzw");

private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssLabel = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssLabel = "";
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
ssLabel = r.ReadText(index++, "AccordionIconPosition.Label", "");
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
public void ReadIM(EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord r) {
this = r;
}


public static bool operator == (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord a, EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord b) {
if (a.ssLabel != b.ssLabel) return false;
return true;
}

public static bool operator != (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord a, EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord)) return false;
return (this == (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLabel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord Duplicate() {
EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord t;
t._ssLabel = this._ssLabel;
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
if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLabel)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLabel)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLabel) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[0] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdLabel);
}
} // EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord

/// <summary>
/// RecordList type <code>AccordionIconPositionList</code> that represents a record list of
///  <code>AccordionIconPosition</code>
/// </summary>
public partial class RL_230328260e3d7a695b9562201483a549 : GenericRecordList<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord>, IEnumerable, IEnumerator {

protected override EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord GetElementDefaultValue() {
return new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord();
}

public T[] ToArray<T>(Func<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_230328260e3d7a695b9562201483a549 recordList, Func<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_230328260e3d7a695b9562201483a549(EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord[] array) {
  RL_230328260e3d7a695b9562201483a549 result = new RL_230328260e3d7a695b9562201483a549();
result.InnerFromArray(array);
    return result;
}

public static RL_230328260e3d7a695b9562201483a549 ToList<T>(T[] array, Func <T, EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord> converter) {
  RL_230328260e3d7a695b9562201483a549 result = new RL_230328260e3d7a695b9562201483a549();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_230328260e3d7a695b9562201483a549 FromRestList<T>(RestList<T> restList, Func <T, EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord> converter) {
  RL_230328260e3d7a695b9562201483a549 result = new RL_230328260e3d7a695b9562201483a549();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_230328260e3d7a695b9562201483a549() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord> NewList() {
return new RL_230328260e3d7a695b9562201483a549();
}


} // RL_230328260e3d7a695b9562201483a549
}
