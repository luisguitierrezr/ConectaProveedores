using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] SeriesType (bD+TNzhCakmks0RGQSTahA)
///  <code>EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord</code> that represent
/// s <code>SeriesType</code> <p>Description: </p>
/// </summary>
// Name: SeriesType
public partial struct EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord : ITypedRecord<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> {
internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*AJ8jPuZepUSYlid_+EL6IQ");

private string _ssType;
public string ssType{
  get{
      return _ssType;
  }
  set{
      if((_ssType!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssType = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssType = "";
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
ssType = r.ReadText(index++, "SeriesType.Type", "");
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
public void ReadIM(EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord r) {
this = r;
}


public static bool operator == (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord a, EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord b) {
if (a.ssType != b.ssType) return false;
return true;
}

public static bool operator != (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord a, EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord)) return false;
return (this == (EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord Duplicate() {
EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord t;
t._ssType = this._ssType;
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
if (head == "type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdType)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdType)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdType) {
return ssType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdType.Key.AsGuid) {
return ssType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssType = (string) other.AttributeGet(IdType);
ChangedAttributes[0] = other.ChangedAttributeGet(IdType);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdType);
}
} // EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord

/// <summary>
/// RecordList type <code>SeriesTypeList</code> that represents a record list of
///  <code>SeriesType</code>
/// </summary>
public partial class RL_8906b8c65e0702bdf7509e7a0ac0f2d2 : GenericRecordList<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord>, IEnumerable, IEnumerator {

protected override EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord GetElementDefaultValue() {
return new EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord();
}

public T[] ToArray<T>(Func<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8906b8c65e0702bdf7509e7a0ac0f2d2 recordList, Func<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8906b8c65e0702bdf7509e7a0ac0f2d2(EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord[] array) {
  RL_8906b8c65e0702bdf7509e7a0ac0f2d2 result = new RL_8906b8c65e0702bdf7509e7a0ac0f2d2();
result.InnerFromArray(array);
    return result;
}

public static RL_8906b8c65e0702bdf7509e7a0ac0f2d2 ToList<T>(T[] array, Func <T, EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> converter) {
  RL_8906b8c65e0702bdf7509e7a0ac0f2d2 result = new RL_8906b8c65e0702bdf7509e7a0ac0f2d2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8906b8c65e0702bdf7509e7a0ac0f2d2 FromRestList<T>(RestList<T> restList, Func <T, EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> converter) {
  RL_8906b8c65e0702bdf7509e7a0ac0f2d2 result = new RL_8906b8c65e0702bdf7509e7a0ac0f2d2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8906b8c65e0702bdf7509e7a0ac0f2d2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord> NewList() {
return new RL_8906b8c65e0702bdf7509e7a0ac0f2d2();
}


} // RL_8906b8c65e0702bdf7509e7a0ac0f2d2
}
