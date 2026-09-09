using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Trigger (x_lPgvxrikWdtl9_cLAACw)
///  <code>EN_52e55d60c515b6016f81404afb220594EntityRecord</code> that represents <code>Trigger</code
/// > <p>Description: Contains different triggers for the patterns behavior.</p>
/// </summary>
// Name: Trigger
public partial struct EN_52e55d60c515b6016f81404afb220594EntityRecord : ITypedRecord<EN_52e55d60c515b6016f81404afb220594EntityRecord> {
internal static readonly GlobalObjectKey IdTrigger = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*i2joQRg4PkOzTcvFf5yQiQ");

private string _ssTrigger;
public string ssTrigger{
  get{
      return _ssTrigger;
  }
  set{
      if((_ssTrigger!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssTrigger = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_52e55d60c515b6016f81404afb220594EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssTrigger = "";
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
ssTrigger = r.ReadText(index++, "Trigger.Trigger", "");
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
public void ReadIM(EN_52e55d60c515b6016f81404afb220594EntityRecord r) {
this = r;
}


public static bool operator == (EN_52e55d60c515b6016f81404afb220594EntityRecord a, EN_52e55d60c515b6016f81404afb220594EntityRecord b) {
if (a.ssTrigger != b.ssTrigger) return false;
return true;
}

public static bool operator != (EN_52e55d60c515b6016f81404afb220594EntityRecord a, EN_52e55d60c515b6016f81404afb220594EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_52e55d60c515b6016f81404afb220594EntityRecord)) return false;
return (this == (EN_52e55d60c515b6016f81404afb220594EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssTrigger.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_52e55d60c515b6016f81404afb220594EntityRecord Duplicate() {
EN_52e55d60c515b6016f81404afb220594EntityRecord t;
t._ssTrigger = this._ssTrigger;
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
if (head == "trigger") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Trigger")) variable.Value = ssTrigger; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdTrigger)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdTrigger)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTrigger) {
return ssTrigger;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTrigger.Key.AsGuid) {
return ssTrigger;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssTrigger = (string) other.AttributeGet(IdTrigger);
ChangedAttributes[0] = other.ChangedAttributeGet(IdTrigger);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdTrigger);
}
} // EN_52e55d60c515b6016f81404afb220594EntityRecord

/// <summary>
/// RecordList type <code>TriggerList</code> that represents a record list of <code>Trigger</code>
/// </summary>
public partial class RL_19efe67c3ea3fa4b4b07aaa801b42f8c : GenericRecordList<EN_52e55d60c515b6016f81404afb220594EntityRecord>, IEnumerable, IEnumerator {

protected override EN_52e55d60c515b6016f81404afb220594EntityRecord GetElementDefaultValue() {
return new EN_52e55d60c515b6016f81404afb220594EntityRecord();
}

public T[] ToArray<T>(Func<EN_52e55d60c515b6016f81404afb220594EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_19efe67c3ea3fa4b4b07aaa801b42f8c recordList, Func<EN_52e55d60c515b6016f81404afb220594EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_19efe67c3ea3fa4b4b07aaa801b42f8c(EN_52e55d60c515b6016f81404afb220594EntityRecord[] array) {
  RL_19efe67c3ea3fa4b4b07aaa801b42f8c result = new RL_19efe67c3ea3fa4b4b07aaa801b42f8c();
result.InnerFromArray(array);
    return result;
}

public static RL_19efe67c3ea3fa4b4b07aaa801b42f8c ToList<T>(T[] array, Func <T, EN_52e55d60c515b6016f81404afb220594EntityRecord> converter) {
  RL_19efe67c3ea3fa4b4b07aaa801b42f8c result = new RL_19efe67c3ea3fa4b4b07aaa801b42f8c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_19efe67c3ea3fa4b4b07aaa801b42f8c FromRestList<T>(RestList<T> restList, Func <T, EN_52e55d60c515b6016f81404afb220594EntityRecord> converter) {
  RL_19efe67c3ea3fa4b4b07aaa801b42f8c result = new RL_19efe67c3ea3fa4b4b07aaa801b42f8c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_19efe67c3ea3fa4b4b07aaa801b42f8c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_52e55d60c515b6016f81404afb220594EntityRecord> NewList() {
return new RL_19efe67c3ea3fa4b4b07aaa801b42f8c();
}


} // RL_19efe67c3ea3fa4b4b07aaa801b42f8c
}
