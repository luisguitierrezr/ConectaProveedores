using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] Shape (JPjUhBSfWUOqny6Q4uHp9A)
///  <code>EN_d11562be18a7e40ca777aa336c946163EntityRecord</code> that represents <code>Shape</code
/// > <p>Description: Contains different types of shapes.</p>
/// </summary>
// Name: Shape
public partial struct EN_d11562be18a7e40ca777aa336c946163EntityRecord : ITypedRecord<EN_d11562be18a7e40ca777aa336c946163EntityRecord> {
internal static readonly GlobalObjectKey IdShape = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*svf0JGT4nUufvJtpDOAWnw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*Wa9QUCpo0UO814YgzQdqFQ");

private string _ssShape;
public string ssShape{
  get{
      return _ssShape;
  }
  set{
      if((_ssShape!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssShape = value;
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

public EN_d11562be18a7e40ca777aa336c946163EntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssShape = "";
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
ssShape = r.ReadText(index++, "Shape.Shape", "");
ssOrder = r.ReadInteger(index++, "Shape.Order", 0);
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
public void ReadIM(EN_d11562be18a7e40ca777aa336c946163EntityRecord r) {
this = r;
}


public static bool operator == (EN_d11562be18a7e40ca777aa336c946163EntityRecord a, EN_d11562be18a7e40ca777aa336c946163EntityRecord b) {
if (a.ssShape != b.ssShape) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_d11562be18a7e40ca777aa336c946163EntityRecord a, EN_d11562be18a7e40ca777aa336c946163EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d11562be18a7e40ca777aa336c946163EntityRecord)) return false;
return (this == (EN_d11562be18a7e40ca777aa336c946163EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssShape.GetHashCode()
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


public EN_d11562be18a7e40ca777aa336c946163EntityRecord Duplicate() {
EN_d11562be18a7e40ca777aa336c946163EntityRecord t;
t._ssShape = this._ssShape;
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
if (head == "shape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Shape")) variable.Value = ssShape; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdShape)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdShape)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdShape) {
return ssShape;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShape.Key.AsGuid) {
return ssShape;
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
ssShape = (string) other.AttributeGet(IdShape);
ChangedAttributes[0] = other.ChangedAttributeGet(IdShape);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdShape);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_d11562be18a7e40ca777aa336c946163EntityRecord

/// <summary>
/// RecordList type <code>ShapeList</code> that represents a record list of <code>Shape</code>
/// </summary>
public partial class RL_549974f3b4457a3de60891ae7d23d2bc : GenericRecordList<EN_d11562be18a7e40ca777aa336c946163EntityRecord>, IEnumerable, IEnumerator {

protected override EN_d11562be18a7e40ca777aa336c946163EntityRecord GetElementDefaultValue() {
return new EN_d11562be18a7e40ca777aa336c946163EntityRecord();
}

public T[] ToArray<T>(Func<EN_d11562be18a7e40ca777aa336c946163EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_549974f3b4457a3de60891ae7d23d2bc recordList, Func<EN_d11562be18a7e40ca777aa336c946163EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_549974f3b4457a3de60891ae7d23d2bc(EN_d11562be18a7e40ca777aa336c946163EntityRecord[] array) {
  RL_549974f3b4457a3de60891ae7d23d2bc result = new RL_549974f3b4457a3de60891ae7d23d2bc();
result.InnerFromArray(array);
    return result;
}

public static RL_549974f3b4457a3de60891ae7d23d2bc ToList<T>(T[] array, Func <T, EN_d11562be18a7e40ca777aa336c946163EntityRecord> converter) {
  RL_549974f3b4457a3de60891ae7d23d2bc result = new RL_549974f3b4457a3de60891ae7d23d2bc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_549974f3b4457a3de60891ae7d23d2bc FromRestList<T>(RestList<T> restList, Func <T, EN_d11562be18a7e40ca777aa336c946163EntityRecord> converter) {
  RL_549974f3b4457a3de60891ae7d23d2bc result = new RL_549974f3b4457a3de60891ae7d23d2bc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_549974f3b4457a3de60891ae7d23d2bc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d11562be18a7e40ca777aa336c946163EntityRecord> NewList() {
return new RL_549974f3b4457a3de60891ae7d23d2bc();
}


} // RL_549974f3b4457a3de60891ae7d23d2bc
}
