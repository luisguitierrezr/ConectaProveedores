using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] VideoState (9eGaRcb3Tk6mZvjZr24gDw)
///  <code>EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord</code> that represent
/// s <code>VideoState</code> <p>Description: The state of the video.</p>
/// </summary>
// Name: VideoState
public partial struct EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord : ITypedRecord<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> {
internal static readonly GlobalObjectKey IdState = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*GWeGbSU0dEinrwrLCYHZBw");

private string _ssState;
public string ssState{
  get{
      return _ssState;
  }
  set{
      if((_ssState!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssState = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssState = "";
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
ssState = r.ReadText(index++, "VideoState.State", "");
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
public void ReadIM(EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord r) {
this = r;
}


public static bool operator == (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord a, EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord b) {
if (a.ssState != b.ssState) return false;
return true;
}

public static bool operator != (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord a, EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord)) return false;
return (this == (EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssState.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord Duplicate() {
EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord t;
t._ssState = this._ssState;
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
if (head == "state") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".State")) variable.Value = ssState; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdState)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdState)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdState) {
return ssState;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdState.Key.AsGuid) {
return ssState;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssState = (string) other.AttributeGet(IdState);
ChangedAttributes[0] = other.ChangedAttributeGet(IdState);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdState);
}
} // EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord

/// <summary>
/// RecordList type <code>VideoStateList</code> that represents a record list of
///  <code>VideoState</code>
/// </summary>
public partial class RL_4438108cb3e8b9ed9e8aaff799663860 : GenericRecordList<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord>, IEnumerable, IEnumerator {

protected override EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord GetElementDefaultValue() {
return new EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord();
}

public T[] ToArray<T>(Func<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4438108cb3e8b9ed9e8aaff799663860 recordList, Func<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4438108cb3e8b9ed9e8aaff799663860(EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord[] array) {
  RL_4438108cb3e8b9ed9e8aaff799663860 result = new RL_4438108cb3e8b9ed9e8aaff799663860();
result.InnerFromArray(array);
    return result;
}

public static RL_4438108cb3e8b9ed9e8aaff799663860 ToList<T>(T[] array, Func <T, EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> converter) {
  RL_4438108cb3e8b9ed9e8aaff799663860 result = new RL_4438108cb3e8b9ed9e8aaff799663860();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4438108cb3e8b9ed9e8aaff799663860 FromRestList<T>(RestList<T> restList, Func <T, EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> converter) {
  RL_4438108cb3e8b9ed9e8aaff799663860 result = new RL_4438108cb3e8b9ed9e8aaff799663860();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4438108cb3e8b9ed9e8aaff799663860() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord> NewList() {
return new RL_4438108cb3e8b9ed9e8aaff799663860();
}


} // RL_4438108cb3e8b9ed9e8aaff799663860
}
