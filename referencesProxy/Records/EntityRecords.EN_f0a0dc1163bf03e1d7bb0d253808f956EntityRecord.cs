using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] AccordionIconType (dOZEV9Dk6ECd8ZYkCYn1tg)
///  <code>EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord</code> that represent
/// s <code>AccordionIconType</code> <p>Description: Set of icons shown in of the AccordionItem</p>
/// </summary>
// Name: AccordionIconType
public partial struct EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord : ITypedRecord<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*+5yjGcUczkewBniybHnddg");

private string _ssId;
public string ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssId = "";
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
ssId = r.ReadText(index++, "AccordionIconType.Id", "");
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
public void ReadIM(EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord r) {
this = r;
}


public static bool operator == (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord a, EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord b) {
if (a.ssId != b.ssId) return false;
return true;
}

public static bool operator != (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord a, EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord)) return false;
return (this == (EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord Duplicate() {
EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord t;
t._ssId = this._ssId;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssId = (string) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
}
} // EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord

/// <summary>
/// RecordList type <code>AccordionIconTypeList</code> that represents a record list of
///  <code>AccordionIconType</code>
/// </summary>
public partial class RL_65b4601c7246ad02da4e6c18fe619d03 : GenericRecordList<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord>, IEnumerable, IEnumerator {

protected override EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord GetElementDefaultValue() {
return new EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord();
}

public T[] ToArray<T>(Func<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_65b4601c7246ad02da4e6c18fe619d03 recordList, Func<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_65b4601c7246ad02da4e6c18fe619d03(EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord[] array) {
  RL_65b4601c7246ad02da4e6c18fe619d03 result = new RL_65b4601c7246ad02da4e6c18fe619d03();
result.InnerFromArray(array);
    return result;
}

public static RL_65b4601c7246ad02da4e6c18fe619d03 ToList<T>(T[] array, Func <T, EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> converter) {
  RL_65b4601c7246ad02da4e6c18fe619d03 result = new RL_65b4601c7246ad02da4e6c18fe619d03();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_65b4601c7246ad02da4e6c18fe619d03 FromRestList<T>(RestList<T> restList, Func <T, EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> converter) {
  RL_65b4601c7246ad02da4e6c18fe619d03 result = new RL_65b4601c7246ad02da4e6c18fe619d03();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_65b4601c7246ad02da4e6c18fe619d03() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f0a0dc1163bf03e1d7bb0d253808f956EntityRecord> NewList() {
return new RL_65b4601c7246ad02da4e6c18fe619d03();
}


} // RL_65b4601c7246ad02da4e6c18fe619d03
}
