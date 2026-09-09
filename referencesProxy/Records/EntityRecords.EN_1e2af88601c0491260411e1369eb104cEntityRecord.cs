using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] BooleanTypes (1jH3C5ZYckK4M0NsLcbJTg)
///  <code>EN_1e2af88601c0491260411e1369eb104cEntityRecord</code> that represent
/// s <code>BooleanTypes</code> <p>Description: Used in the context of Providers Enxtensibility.</p>
/// </summary>
// Name: BooleanTypes
public partial struct EN_1e2af88601c0491260411e1369eb104cEntityRecord : ITypedRecord<EN_1e2af88601c0491260411e1369eb104cEntityRecord> {
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*SL7vATIAhEa4ZxljWKkgnQ");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*89NGcPAsUk6o+Xsl_bn2uQ");

private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssLabel = value;
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

public EN_1e2af88601c0491260411e1369eb104cEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssLabel = "";
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
ssLabel = r.ReadText(index++, "BooleanTypes.Label", "");
ssOrder = r.ReadInteger(index++, "BooleanTypes.Order", 0);
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
public void ReadIM(EN_1e2af88601c0491260411e1369eb104cEntityRecord r) {
this = r;
}


public static bool operator == (EN_1e2af88601c0491260411e1369eb104cEntityRecord a, EN_1e2af88601c0491260411e1369eb104cEntityRecord b) {
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_1e2af88601c0491260411e1369eb104cEntityRecord a, EN_1e2af88601c0491260411e1369eb104cEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1e2af88601c0491260411e1369eb104cEntityRecord)) return false;
return (this == (EN_1e2af88601c0491260411e1369eb104cEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLabel.GetHashCode()
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


public EN_1e2af88601c0491260411e1369eb104cEntityRecord Duplicate() {
EN_1e2af88601c0491260411e1369eb104cEntityRecord t;
t._ssLabel = this._ssLabel;
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
if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLabel)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdLabel)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
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
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[0] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_1e2af88601c0491260411e1369eb104cEntityRecord

/// <summary>
/// RecordList type <code>BooleanTypesList</code> that represents a record list of
///  <code>BooleanTypes</code>
/// </summary>
public partial class RL_024c65775fda4a7c95336ab422a752c4 : GenericRecordList<EN_1e2af88601c0491260411e1369eb104cEntityRecord>, IEnumerable, IEnumerator {

protected override EN_1e2af88601c0491260411e1369eb104cEntityRecord GetElementDefaultValue() {
return new EN_1e2af88601c0491260411e1369eb104cEntityRecord();
}

public T[] ToArray<T>(Func<EN_1e2af88601c0491260411e1369eb104cEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_024c65775fda4a7c95336ab422a752c4 recordList, Func<EN_1e2af88601c0491260411e1369eb104cEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_024c65775fda4a7c95336ab422a752c4(EN_1e2af88601c0491260411e1369eb104cEntityRecord[] array) {
  RL_024c65775fda4a7c95336ab422a752c4 result = new RL_024c65775fda4a7c95336ab422a752c4();
result.InnerFromArray(array);
    return result;
}

public static RL_024c65775fda4a7c95336ab422a752c4 ToList<T>(T[] array, Func <T, EN_1e2af88601c0491260411e1369eb104cEntityRecord> converter) {
  RL_024c65775fda4a7c95336ab422a752c4 result = new RL_024c65775fda4a7c95336ab422a752c4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_024c65775fda4a7c95336ab422a752c4 FromRestList<T>(RestList<T> restList, Func <T, EN_1e2af88601c0491260411e1369eb104cEntityRecord> converter) {
  RL_024c65775fda4a7c95336ab422a752c4 result = new RL_024c65775fda4a7c95336ab422a752c4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_024c65775fda4a7c95336ab422a752c4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1e2af88601c0491260411e1369eb104cEntityRecord> NewList() {
return new RL_024c65775fda4a7c95336ab422a752c4();
}


} // RL_024c65775fda4a7c95336ab422a752c4
}
