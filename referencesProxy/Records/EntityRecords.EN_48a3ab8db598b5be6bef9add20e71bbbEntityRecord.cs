using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] GutterSize (F43GT14FN0W8wlFLCVZ65w)
///  <code>EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord</code> that represent
/// s <code>GutterSize</code> <p>Description: Contains different sizes of gutter.</p>
/// </summary>
// Name: GutterSize
public partial struct EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord : ITypedRecord<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> {
internal static readonly GlobalObjectKey IdGutterSize = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*6+ggGOmEB0KY9MWQEviYoA");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*cnCQRzWl40y1+_Sr6wu4EQ");

private string _ssGutterSize;
public string ssGutterSize{
  get{
      return _ssGutterSize;
  }
  set{
      if((_ssGutterSize!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssGutterSize = value;
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

public EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssGutterSize = "";
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
ssGutterSize = r.ReadText(index++, "GutterSize.GutterSize", "");
ssOrder = r.ReadInteger(index++, "GutterSize.Order", 0);
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
public void ReadIM(EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord r) {
this = r;
}


public static bool operator == (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord a, EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord b) {
if (a.ssGutterSize != b.ssGutterSize) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord a, EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord)) return false;
return (this == (EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssGutterSize.GetHashCode()
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


public EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord Duplicate() {
EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord t;
t._ssGutterSize = this._ssGutterSize;
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
if (head == "guttersize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GutterSize")) variable.Value = ssGutterSize; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdGutterSize)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdGutterSize)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdGutterSize) {
return ssGutterSize;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdGutterSize.Key.AsGuid) {
return ssGutterSize;
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
ssGutterSize = (string) other.AttributeGet(IdGutterSize);
ChangedAttributes[0] = other.ChangedAttributeGet(IdGutterSize);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdGutterSize);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord

/// <summary>
/// RecordList type <code>GutterSizeList</code> that represents a record list of
///  <code>GutterSize</code>
/// </summary>
public partial class RL_d28765f0509bd8278495bc8b55d5a50e : GenericRecordList<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord>, IEnumerable, IEnumerator {

protected override EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord GetElementDefaultValue() {
return new EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord();
}

public T[] ToArray<T>(Func<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d28765f0509bd8278495bc8b55d5a50e recordList, Func<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d28765f0509bd8278495bc8b55d5a50e(EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord[] array) {
  RL_d28765f0509bd8278495bc8b55d5a50e result = new RL_d28765f0509bd8278495bc8b55d5a50e();
result.InnerFromArray(array);
    return result;
}

public static RL_d28765f0509bd8278495bc8b55d5a50e ToList<T>(T[] array, Func <T, EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> converter) {
  RL_d28765f0509bd8278495bc8b55d5a50e result = new RL_d28765f0509bd8278495bc8b55d5a50e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d28765f0509bd8278495bc8b55d5a50e FromRestList<T>(RestList<T> restList, Func <T, EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> converter) {
  RL_d28765f0509bd8278495bc8b55d5a50e result = new RL_d28765f0509bd8278495bc8b55d5a50e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d28765f0509bd8278495bc8b55d5a50e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_48a3ab8db598b5be6bef9add20e71bbbEntityRecord> NewList() {
return new RL_d28765f0509bd8278495bc8b55d5a50e();
}


} // RL_d28765f0509bd8278495bc8b55d5a50e
}
