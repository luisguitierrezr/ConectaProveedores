using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Steps (vdpm2DEAw06o7X90LOgO0Q)
///  <code>EN_7441573ccf264d27ef548a39a846bd68EntityRecord</code> that represents <code>Steps</code
/// > <p>Description: Contains different types of status for steps in a sequential process.</p>
/// </summary>
// Name: Steps
public partial struct EN_7441573ccf264d27ef548a39a846bd68EntityRecord : ITypedRecord<EN_7441573ccf264d27ef548a39a846bd68EntityRecord> {
internal static readonly GlobalObjectKey IdSteps = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*yPsuqwZWzE+4gNhJmkH+Aw");

private string _ssSteps;
public string ssSteps{
  get{
      return _ssSteps;
  }
  set{
      if((_ssSteps!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssSteps = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7441573ccf264d27ef548a39a846bd68EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssSteps = "";
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
ssSteps = r.ReadText(index++, "Steps.Steps", "");
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
public void ReadIM(EN_7441573ccf264d27ef548a39a846bd68EntityRecord r) {
this = r;
}


public static bool operator == (EN_7441573ccf264d27ef548a39a846bd68EntityRecord a, EN_7441573ccf264d27ef548a39a846bd68EntityRecord b) {
if (a.ssSteps != b.ssSteps) return false;
return true;
}

public static bool operator != (EN_7441573ccf264d27ef548a39a846bd68EntityRecord a, EN_7441573ccf264d27ef548a39a846bd68EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7441573ccf264d27ef548a39a846bd68EntityRecord)) return false;
return (this == (EN_7441573ccf264d27ef548a39a846bd68EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSteps.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7441573ccf264d27ef548a39a846bd68EntityRecord Duplicate() {
EN_7441573ccf264d27ef548a39a846bd68EntityRecord t;
t._ssSteps = this._ssSteps;
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
if (head == "steps") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Steps")) variable.Value = ssSteps; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSteps)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSteps)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSteps) {
return ssSteps;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSteps.Key.AsGuid) {
return ssSteps;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssSteps = (string) other.AttributeGet(IdSteps);
ChangedAttributes[0] = other.ChangedAttributeGet(IdSteps);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdSteps);
}
} // EN_7441573ccf264d27ef548a39a846bd68EntityRecord

/// <summary>
/// RecordList type <code>StepsList</code> that represents a record list of <code>Steps</code>
/// </summary>
public partial class RL_cbac71e3b2383e8c0c384139f6b34f78 : GenericRecordList<EN_7441573ccf264d27ef548a39a846bd68EntityRecord>, IEnumerable, IEnumerator {

protected override EN_7441573ccf264d27ef548a39a846bd68EntityRecord GetElementDefaultValue() {
return new EN_7441573ccf264d27ef548a39a846bd68EntityRecord();
}

public T[] ToArray<T>(Func<EN_7441573ccf264d27ef548a39a846bd68EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cbac71e3b2383e8c0c384139f6b34f78 recordList, Func<EN_7441573ccf264d27ef548a39a846bd68EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cbac71e3b2383e8c0c384139f6b34f78(EN_7441573ccf264d27ef548a39a846bd68EntityRecord[] array) {
  RL_cbac71e3b2383e8c0c384139f6b34f78 result = new RL_cbac71e3b2383e8c0c384139f6b34f78();
result.InnerFromArray(array);
    return result;
}

public static RL_cbac71e3b2383e8c0c384139f6b34f78 ToList<T>(T[] array, Func <T, EN_7441573ccf264d27ef548a39a846bd68EntityRecord> converter) {
  RL_cbac71e3b2383e8c0c384139f6b34f78 result = new RL_cbac71e3b2383e8c0c384139f6b34f78();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cbac71e3b2383e8c0c384139f6b34f78 FromRestList<T>(RestList<T> restList, Func <T, EN_7441573ccf264d27ef548a39a846bd68EntityRecord> converter) {
  RL_cbac71e3b2383e8c0c384139f6b34f78 result = new RL_cbac71e3b2383e8c0c384139f6b34f78();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cbac71e3b2383e8c0c384139f6b34f78() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7441573ccf264d27ef548a39a846bd68EntityRecord> NewList() {
return new RL_cbac71e3b2383e8c0c384139f6b34f78();
}


} // RL_cbac71e3b2383e8c0c384139f6b34f78
}
