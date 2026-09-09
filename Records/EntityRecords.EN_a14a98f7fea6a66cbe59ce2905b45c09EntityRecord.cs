using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Size (ZjmTJSj+6kitek+6gNG1nA)
///  <code>EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord</code> that represents <code>Size</code
/// > <p>Description: Contains different type of sizes.</p>
/// </summary>
// Name: Size
public partial struct EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord : ITypedRecord<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> {
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*TFetTGHeXkux8wEN3oi_8g");

private string _ssSize;
public string ssSize{
  get{
      return _ssSize;
  }
  set{
      if((_ssSize!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssSize = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssSize = "";
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
ssSize = r.ReadText(index++, "Size.Size", "");
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
public void ReadIM(EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord r) {
this = r;
}


public static bool operator == (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord a, EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord b) {
if (a.ssSize != b.ssSize) return false;
return true;
}

public static bool operator != (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord a, EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord)) return false;
return (this == (EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord Duplicate() {
EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord t;
t._ssSize = this._ssSize;
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
if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSize)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSize)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSize) {
return ssSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssSize = (string) other.AttributeGet(IdSize);
ChangedAttributes[0] = other.ChangedAttributeGet(IdSize);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdSize);
}
} // EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord

/// <summary>
/// RecordList type <code>SizeList</code> that represents a record list of <code>Size</code>
/// </summary>
public partial class RL_8add23b891a53c086b7017fd4cdd211b : GenericRecordList<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord>, IEnumerable, IEnumerator {

protected override EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord GetElementDefaultValue() {
return new EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord();
}

public T[] ToArray<T>(Func<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8add23b891a53c086b7017fd4cdd211b recordList, Func<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8add23b891a53c086b7017fd4cdd211b(EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord[] array) {
  RL_8add23b891a53c086b7017fd4cdd211b result = new RL_8add23b891a53c086b7017fd4cdd211b();
result.InnerFromArray(array);
    return result;
}

public static RL_8add23b891a53c086b7017fd4cdd211b ToList<T>(T[] array, Func <T, EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> converter) {
  RL_8add23b891a53c086b7017fd4cdd211b result = new RL_8add23b891a53c086b7017fd4cdd211b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8add23b891a53c086b7017fd4cdd211b FromRestList<T>(RestList<T> restList, Func <T, EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> converter) {
  RL_8add23b891a53c086b7017fd4cdd211b result = new RL_8add23b891a53c086b7017fd4cdd211b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8add23b891a53c086b7017fd4cdd211b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_a14a98f7fea6a66cbe59ce2905b45c09EntityRecord> NewList() {
return new RL_8add23b891a53c086b7017fd4cdd211b();
}


} // RL_8add23b891a53c086b7017fd4cdd211b
}
