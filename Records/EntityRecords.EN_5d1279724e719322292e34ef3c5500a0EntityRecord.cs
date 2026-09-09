using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Position (CRJA3IrbV0eZWEpFO8PFOg)
///  <code>EN_5d1279724e719322292e34ef3c5500a0EntityRecord</code> that represents <code>Position</code
/// > <p>Description: Contains different element alignment types.</p>
/// </summary>
// Name: Position
public partial struct EN_5d1279724e719322292e34ef3c5500a0EntityRecord : ITypedRecord<EN_5d1279724e719322292e34ef3c5500a0EntityRecord> {
internal static readonly GlobalObjectKey IdPosition = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*RsImf12QoUWJgXlj204cWA");

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

public EN_5d1279724e719322292e34ef3c5500a0EntityRecord() {
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
ssPosition = r.ReadText(index++, "Position.Position", "");
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
public void ReadIM(EN_5d1279724e719322292e34ef3c5500a0EntityRecord r) {
this = r;
}


public static bool operator == (EN_5d1279724e719322292e34ef3c5500a0EntityRecord a, EN_5d1279724e719322292e34ef3c5500a0EntityRecord b) {
if (a.ssPosition != b.ssPosition) return false;
return true;
}

public static bool operator != (EN_5d1279724e719322292e34ef3c5500a0EntityRecord a, EN_5d1279724e719322292e34ef3c5500a0EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5d1279724e719322292e34ef3c5500a0EntityRecord)) return false;
return (this == (EN_5d1279724e719322292e34ef3c5500a0EntityRecord)o);
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


public EN_5d1279724e719322292e34ef3c5500a0EntityRecord Duplicate() {
EN_5d1279724e719322292e34ef3c5500a0EntityRecord t;
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
} // EN_5d1279724e719322292e34ef3c5500a0EntityRecord

/// <summary>
/// RecordList type <code>PositionList</code> that represents a record list of <code>Position</code>
/// </summary>
public partial class RL_d7cde0d346486a854aee07525f121a90 : GenericRecordList<EN_5d1279724e719322292e34ef3c5500a0EntityRecord>, IEnumerable, IEnumerator {

protected override EN_5d1279724e719322292e34ef3c5500a0EntityRecord GetElementDefaultValue() {
return new EN_5d1279724e719322292e34ef3c5500a0EntityRecord();
}

public T[] ToArray<T>(Func<EN_5d1279724e719322292e34ef3c5500a0EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d7cde0d346486a854aee07525f121a90 recordList, Func<EN_5d1279724e719322292e34ef3c5500a0EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d7cde0d346486a854aee07525f121a90(EN_5d1279724e719322292e34ef3c5500a0EntityRecord[] array) {
  RL_d7cde0d346486a854aee07525f121a90 result = new RL_d7cde0d346486a854aee07525f121a90();
result.InnerFromArray(array);
    return result;
}

public static RL_d7cde0d346486a854aee07525f121a90 ToList<T>(T[] array, Func <T, EN_5d1279724e719322292e34ef3c5500a0EntityRecord> converter) {
  RL_d7cde0d346486a854aee07525f121a90 result = new RL_d7cde0d346486a854aee07525f121a90();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d7cde0d346486a854aee07525f121a90 FromRestList<T>(RestList<T> restList, Func <T, EN_5d1279724e719322292e34ef3c5500a0EntityRecord> converter) {
  RL_d7cde0d346486a854aee07525f121a90 result = new RL_d7cde0d346486a854aee07525f121a90();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d7cde0d346486a854aee07525f121a90() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5d1279724e719322292e34ef3c5500a0EntityRecord> NewList() {
return new RL_d7cde0d346486a854aee07525f121a90();
}


} // RL_d7cde0d346486a854aee07525f121a90
}
