using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Orientation (0hOnkJrP60u7TjN98nZTYA)
///  <code>EN_8d4f783227026ce93d50126c7f028443EntityRecord</code> that represent
/// s <code>Orientation</code> <p>Description: Different orientations.</p>
/// </summary>
// Name: Orientation
public partial struct EN_8d4f783227026ce93d50126c7f028443EntityRecord : ITypedRecord<EN_8d4f783227026ce93d50126c7f028443EntityRecord> {
internal static readonly GlobalObjectKey IdOrientation = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*JQ9+7xofpUCcKfz6b2Vulg");

private string _ssOrientation;
public string ssOrientation{
  get{
      return _ssOrientation;
  }
  set{
      if((_ssOrientation!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssOrientation = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_8d4f783227026ce93d50126c7f028443EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssOrientation = "";
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
ssOrientation = r.ReadText(index++, "Orientation.Orientation", "");
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
public void ReadIM(EN_8d4f783227026ce93d50126c7f028443EntityRecord r) {
this = r;
}


public static bool operator == (EN_8d4f783227026ce93d50126c7f028443EntityRecord a, EN_8d4f783227026ce93d50126c7f028443EntityRecord b) {
if (a.ssOrientation != b.ssOrientation) return false;
return true;
}

public static bool operator != (EN_8d4f783227026ce93d50126c7f028443EntityRecord a, EN_8d4f783227026ce93d50126c7f028443EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_8d4f783227026ce93d50126c7f028443EntityRecord)) return false;
return (this == (EN_8d4f783227026ce93d50126c7f028443EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrientation.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_8d4f783227026ce93d50126c7f028443EntityRecord Duplicate() {
EN_8d4f783227026ce93d50126c7f028443EntityRecord t;
t._ssOrientation = this._ssOrientation;
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
if (head == "orientation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Orientation")) variable.Value = ssOrientation; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdOrientation)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdOrientation)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrientation) {
return ssOrientation;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrientation.Key.AsGuid) {
return ssOrientation;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssOrientation = (string) other.AttributeGet(IdOrientation);
ChangedAttributes[0] = other.ChangedAttributeGet(IdOrientation);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdOrientation);
}
} // EN_8d4f783227026ce93d50126c7f028443EntityRecord

/// <summary>
/// RecordList type <code>OrientationList</code> that represents a record list of
///  <code>Orientation</code>
/// </summary>
public partial class RL_028be7f802152b5f25a868ed964b5ea2 : GenericRecordList<EN_8d4f783227026ce93d50126c7f028443EntityRecord>, IEnumerable, IEnumerator {

protected override EN_8d4f783227026ce93d50126c7f028443EntityRecord GetElementDefaultValue() {
return new EN_8d4f783227026ce93d50126c7f028443EntityRecord();
}

public T[] ToArray<T>(Func<EN_8d4f783227026ce93d50126c7f028443EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_028be7f802152b5f25a868ed964b5ea2 recordList, Func<EN_8d4f783227026ce93d50126c7f028443EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_028be7f802152b5f25a868ed964b5ea2(EN_8d4f783227026ce93d50126c7f028443EntityRecord[] array) {
  RL_028be7f802152b5f25a868ed964b5ea2 result = new RL_028be7f802152b5f25a868ed964b5ea2();
result.InnerFromArray(array);
    return result;
}

public static RL_028be7f802152b5f25a868ed964b5ea2 ToList<T>(T[] array, Func <T, EN_8d4f783227026ce93d50126c7f028443EntityRecord> converter) {
  RL_028be7f802152b5f25a868ed964b5ea2 result = new RL_028be7f802152b5f25a868ed964b5ea2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_028be7f802152b5f25a868ed964b5ea2 FromRestList<T>(RestList<T> restList, Func <T, EN_8d4f783227026ce93d50126c7f028443EntityRecord> converter) {
  RL_028be7f802152b5f25a868ed964b5ea2 result = new RL_028be7f802152b5f25a868ed964b5ea2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_028be7f802152b5f25a868ed964b5ea2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_8d4f783227026ce93d50126c7f028443EntityRecord> NewList() {
return new RL_028be7f802152b5f25a868ed964b5ea2();
}


} // RL_028be7f802152b5f25a868ed964b5ea2
}
