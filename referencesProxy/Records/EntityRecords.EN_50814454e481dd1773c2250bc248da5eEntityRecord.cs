using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Direction (7sql_eTXKkClazWW_autFw)
///  <code>EN_50814454e481dd1773c2250bc248da5eEntityRecord</code> that represents <code>Direction</code
/// > <p>Description: Sets the direction: left or right.</p>
/// </summary>
// Name: Direction
public partial struct EN_50814454e481dd1773c2250bc248da5eEntityRecord : ITypedRecord<EN_50814454e481dd1773c2250bc248da5eEntityRecord> {
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*sEO9a8NN0kOeIXCjDFjAWg");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*iJXGopu4cEuhrI6hKw3THw");

private string _ssDirection;
public string ssDirection{
  get{
      return _ssDirection;
  }
  set{
      if((_ssDirection!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssDirection = value;
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

public EN_50814454e481dd1773c2250bc248da5eEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssDirection = "";
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
ssDirection = r.ReadText(index++, "Direction.Direction", "");
ssOrder = r.ReadInteger(index++, "Direction.Order", 0);
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
public void ReadIM(EN_50814454e481dd1773c2250bc248da5eEntityRecord r) {
this = r;
}


public static bool operator == (EN_50814454e481dd1773c2250bc248da5eEntityRecord a, EN_50814454e481dd1773c2250bc248da5eEntityRecord b) {
if (a.ssDirection != b.ssDirection) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_50814454e481dd1773c2250bc248da5eEntityRecord a, EN_50814454e481dd1773c2250bc248da5eEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_50814454e481dd1773c2250bc248da5eEntityRecord)) return false;
return (this == (EN_50814454e481dd1773c2250bc248da5eEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDirection.GetHashCode()
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


public EN_50814454e481dd1773c2250bc248da5eEntityRecord Duplicate() {
EN_50814454e481dd1773c2250bc248da5eEntityRecord t;
t._ssDirection = this._ssDirection;
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
if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdDirection)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdDirection)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDirection) {
return ssDirection;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
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
ssDirection = (string) other.AttributeGet(IdDirection);
ChangedAttributes[0] = other.ChangedAttributeGet(IdDirection);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdDirection);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_50814454e481dd1773c2250bc248da5eEntityRecord

/// <summary>
/// RecordList type <code>DirectionList</code> that represents a record list of <code>Direction</code>
/// </summary>
public partial class RL_78373738575ac72ef55dea9c617c7d1f : GenericRecordList<EN_50814454e481dd1773c2250bc248da5eEntityRecord>, IEnumerable, IEnumerator {

protected override EN_50814454e481dd1773c2250bc248da5eEntityRecord GetElementDefaultValue() {
return new EN_50814454e481dd1773c2250bc248da5eEntityRecord();
}

public T[] ToArray<T>(Func<EN_50814454e481dd1773c2250bc248da5eEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_78373738575ac72ef55dea9c617c7d1f recordList, Func<EN_50814454e481dd1773c2250bc248da5eEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_78373738575ac72ef55dea9c617c7d1f(EN_50814454e481dd1773c2250bc248da5eEntityRecord[] array) {
  RL_78373738575ac72ef55dea9c617c7d1f result = new RL_78373738575ac72ef55dea9c617c7d1f();
result.InnerFromArray(array);
    return result;
}

public static RL_78373738575ac72ef55dea9c617c7d1f ToList<T>(T[] array, Func <T, EN_50814454e481dd1773c2250bc248da5eEntityRecord> converter) {
  RL_78373738575ac72ef55dea9c617c7d1f result = new RL_78373738575ac72ef55dea9c617c7d1f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_78373738575ac72ef55dea9c617c7d1f FromRestList<T>(RestList<T> restList, Func <T, EN_50814454e481dd1773c2250bc248da5eEntityRecord> converter) {
  RL_78373738575ac72ef55dea9c617c7d1f result = new RL_78373738575ac72ef55dea9c617c7d1f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_78373738575ac72ef55dea9c617c7d1f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_50814454e481dd1773c2250bc248da5eEntityRecord> NewList() {
return new RL_78373738575ac72ef55dea9c617c7d1f();
}


} // RL_78373738575ac72ef55dea9c617c7d1f
}
