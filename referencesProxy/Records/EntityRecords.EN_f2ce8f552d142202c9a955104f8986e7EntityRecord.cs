using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] LegendLayout (dPAOTDLluUu_+kdxqXxJhQ)
///  <code>EN_f2ce8f552d142202c9a955104f8986e7EntityRecord</code> that represent
/// s <code>LegendLayout</code> <p>Description: The legend position in chart</p>
/// </summary>
// Name: LegendLayout
public partial struct EN_f2ce8f552d142202c9a955104f8986e7EntityRecord : ITypedRecord<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord> {
internal static readonly GlobalObjectKey IdLayout = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*SGf3PiiSK0ernVKiAGs0_g");

private string _ssLayout;
public string ssLayout{
  get{
      return _ssLayout;
  }
  set{
      if((_ssLayout!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(1,true);
          _ssLayout = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_f2ce8f552d142202c9a955104f8986e7EntityRecord() {
ChangedAttributes = new BitArray(1,true);
OptimizedAttributes = new BitArray(1,false);
_ssLayout = "";
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
ssLayout = r.ReadText(index++, "LegendLayout.Layout", "");
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
public void ReadIM(EN_f2ce8f552d142202c9a955104f8986e7EntityRecord r) {
this = r;
}


public static bool operator == (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord a, EN_f2ce8f552d142202c9a955104f8986e7EntityRecord b) {
if (a.ssLayout != b.ssLayout) return false;
return true;
}

public static bool operator != (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord a, EN_f2ce8f552d142202c9a955104f8986e7EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord)) return false;
return (this == (EN_f2ce8f552d142202c9a955104f8986e7EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLayout.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_f2ce8f552d142202c9a955104f8986e7EntityRecord Duplicate() {
EN_f2ce8f552d142202c9a955104f8986e7EntityRecord t;
t._ssLayout = this._ssLayout;
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
if (head == "layout") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Layout")) variable.Value = ssLayout; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLayout)) {
return ChangedAttributes[0];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLayout)) {
return OptimizedAttributes[0];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLayout) {
return ssLayout;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLayout.Key.AsGuid) {
return ssLayout;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(1);
OptimizedAttributes = new BitArray(1);
if (other == null) return;
ssLayout = (string) other.AttributeGet(IdLayout);
ChangedAttributes[0] = other.ChangedAttributeGet(IdLayout);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdLayout);
}
} // EN_f2ce8f552d142202c9a955104f8986e7EntityRecord

/// <summary>
/// RecordList type <code>LegendLayoutList</code> that represents a record list of
///  <code>LegendLayout</code>
/// </summary>
public partial class RL_5cace3a1ee80bf29b67e9cad96754231 : GenericRecordList<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord>, IEnumerable, IEnumerator {

protected override EN_f2ce8f552d142202c9a955104f8986e7EntityRecord GetElementDefaultValue() {
return new EN_f2ce8f552d142202c9a955104f8986e7EntityRecord();
}

public T[] ToArray<T>(Func<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5cace3a1ee80bf29b67e9cad96754231 recordList, Func<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5cace3a1ee80bf29b67e9cad96754231(EN_f2ce8f552d142202c9a955104f8986e7EntityRecord[] array) {
  RL_5cace3a1ee80bf29b67e9cad96754231 result = new RL_5cace3a1ee80bf29b67e9cad96754231();
result.InnerFromArray(array);
    return result;
}

public static RL_5cace3a1ee80bf29b67e9cad96754231 ToList<T>(T[] array, Func <T, EN_f2ce8f552d142202c9a955104f8986e7EntityRecord> converter) {
  RL_5cace3a1ee80bf29b67e9cad96754231 result = new RL_5cace3a1ee80bf29b67e9cad96754231();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5cace3a1ee80bf29b67e9cad96754231 FromRestList<T>(RestList<T> restList, Func <T, EN_f2ce8f552d142202c9a955104f8986e7EntityRecord> converter) {
  RL_5cace3a1ee80bf29b67e9cad96754231 result = new RL_5cace3a1ee80bf29b67e9cad96754231();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5cace3a1ee80bf29b67e9cad96754231() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_f2ce8f552d142202c9a955104f8986e7EntityRecord> NewList() {
return new RL_5cace3a1ee80bf29b67e9cad96754231();
}


} // RL_5cace3a1ee80bf29b67e9cad96754231
}
