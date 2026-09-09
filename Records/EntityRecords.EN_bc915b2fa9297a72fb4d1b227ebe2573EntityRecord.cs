using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Space (PLhLxda2AEqigsWm2hjFmQ)
///  <code>EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord</code> that represents <code>Space</code
/// > <p>Description: Sets element spacing sizes.</p>
/// </summary>
// Name: Space
public partial struct EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord : ITypedRecord<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> {
internal static readonly GlobalObjectKey IdSpace = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*EWNRjpFZPUKcs4uX7fdNvw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*7iljq3Jw+UmIrT8MkqQFfw");

private string _ssSpace;
public string ssSpace{
  get{
      return _ssSpace;
  }
  set{
      if((_ssSpace!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssSpace = value;
      }
  }
}

private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrder = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssSpace = "";
_ssOrder = 0;
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
ssSpace = r.ReadText(index++, "Space.Space", "");
ssOrder = r.ReadInteger(index++, "Space.Order", 0);
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
public void ReadIM(EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord r) {
this = r;
}


public static bool operator == (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord a, EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord b) {
if (a.ssSpace != b.ssSpace) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord a, EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord)) return false;
return (this == (EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSpace.GetHashCode()
 ^ ssOrder.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord Duplicate() {
EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord t;
t._ssSpace = this._ssSpace;
t._ssOrder = this._ssOrder;
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
if (head == "space") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Space")) variable.Value = ssSpace; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSpace)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSpace)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSpace) {
return ssSpace;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpace.Key.AsGuid) {
return ssSpace;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssSpace = (string) other.AttributeGet(IdSpace);
ChangedAttributes[0] = other.ChangedAttributeGet(IdSpace);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdSpace);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord

/// <summary>
/// RecordList type <code>SpaceList</code> that represents a record list of <code>Space</code>
/// </summary>
public partial class RL_157fced35d515bf7b615f06f3ed59864 : GenericRecordList<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord>, IEnumerable, IEnumerator {

protected override EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord GetElementDefaultValue() {
return new EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord();
}

public T[] ToArray<T>(Func<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_157fced35d515bf7b615f06f3ed59864 recordList, Func<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_157fced35d515bf7b615f06f3ed59864(EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord[] array) {
  RL_157fced35d515bf7b615f06f3ed59864 result = new RL_157fced35d515bf7b615f06f3ed59864();
result.InnerFromArray(array);
    return result;
}

public static RL_157fced35d515bf7b615f06f3ed59864 ToList<T>(T[] array, Func <T, EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> converter) {
  RL_157fced35d515bf7b615f06f3ed59864 result = new RL_157fced35d515bf7b615f06f3ed59864();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_157fced35d515bf7b615f06f3ed59864 FromRestList<T>(RestList<T> restList, Func <T, EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> converter) {
  RL_157fced35d515bf7b615f06f3ed59864 result = new RL_157fced35d515bf7b615f06f3ed59864();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_157fced35d515bf7b615f06f3ed59864() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_bc915b2fa9297a72fb4d1b227ebe2573EntityRecord> NewList() {
return new RL_157fced35d515bf7b615f06f3ed59864();
}


} // RL_157fced35d515bf7b615f06f3ed59864
}
