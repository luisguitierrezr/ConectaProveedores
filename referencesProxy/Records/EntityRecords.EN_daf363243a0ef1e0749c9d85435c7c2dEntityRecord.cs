using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Operator (LP77RxXgAkuWrSmdUlKFnA)
///  <code>EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord</code> that represents <code>Operator</code
/// > <p>Description: Mathematic operators.</p>
/// </summary>
// Name: Operator
public partial struct EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord : ITypedRecord<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> {
internal static readonly GlobalObjectKey IdOperator = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*tGHyfGUpYUad+5SehqGFBw");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*zkH_jnUHc0OKbTTRLClViw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*_KlEAW6YjEyWP+J4dE75QA");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("v+NnQCtg1EesOT+0Kkz94Q*W6J3FKT9P0GN1gQ6FRCsfg");

private string _ssOperator;
public string ssOperator{
  get{
      return _ssOperator;
  }
  set{
      if((_ssOperator!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssOperator = value;
      }
  }
}

private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
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
      if((_ssOrder!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssOrder = value;
      }
  }
}

private bool _ssIs_Active;
public bool ssIs_Active{
  get{
      return _ssIs_Active;
  }
  set{
      if((_ssIs_Active!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIs_Active = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssOperator = "";
_ssLabel = "";
_ssOrder = 0;
_ssIs_Active = false;
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
ssOperator = r.ReadText(index++, "Operator.Operator", "");
ssLabel = r.ReadText(index++, "Operator.Label", "");
ssOrder = r.ReadInteger(index++, "Operator.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "Operator.Is_Active", false);
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord r) {
this = r;
}


public static bool operator == (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord a, EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord b) {
if (a.ssOperator != b.ssOperator) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
return true;
}

public static bool operator != (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord a, EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord)) return false;
return (this == (EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOperator.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord Duplicate() {
EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord t;
t._ssOperator = this._ssOperator;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
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
if (head == "operator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Operator")) variable.Value = ssOperator; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "is_active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdOperator)) {
return ChangedAttributes[0];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[1];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdOperator)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOperator) {
return ssOperator;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrder) {
return ssOrder;
}
if (key == IdIs_Active) {
return ssIs_Active;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOperator.Key.AsGuid) {
return ssOperator;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdIs_Active.Key.AsGuid) {
return ssIs_Active;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssOperator = (string) other.AttributeGet(IdOperator);
ChangedAttributes[0] = other.ChangedAttributeGet(IdOperator);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdOperator);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
}
} // EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord

/// <summary>
/// RecordList type <code>OperatorList</code> that represents a record list of <code>Operator</code>
/// </summary>
public partial class RL_a6e0239db1a8572119165a4a856f8cb1 : GenericRecordList<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord>, IEnumerable, IEnumerator {

protected override EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord GetElementDefaultValue() {
return new EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord();
}

public T[] ToArray<T>(Func<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a6e0239db1a8572119165a4a856f8cb1 recordList, Func<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a6e0239db1a8572119165a4a856f8cb1(EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord[] array) {
  RL_a6e0239db1a8572119165a4a856f8cb1 result = new RL_a6e0239db1a8572119165a4a856f8cb1();
result.InnerFromArray(array);
    return result;
}

public static RL_a6e0239db1a8572119165a4a856f8cb1 ToList<T>(T[] array, Func <T, EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> converter) {
  RL_a6e0239db1a8572119165a4a856f8cb1 result = new RL_a6e0239db1a8572119165a4a856f8cb1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a6e0239db1a8572119165a4a856f8cb1 FromRestList<T>(RestList<T> restList, Func <T, EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> converter) {
  RL_a6e0239db1a8572119165a4a856f8cb1 result = new RL_a6e0239db1a8572119165a4a856f8cb1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a6e0239db1a8572119165a4a856f8cb1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_daf363243a0ef1e0749c9d85435c7c2dEntityRecord> NewList() {
return new RL_a6e0239db1a8572119165a4a856f8cb1();
}


} // RL_a6e0239db1a8572119165a4a856f8cb1
}
