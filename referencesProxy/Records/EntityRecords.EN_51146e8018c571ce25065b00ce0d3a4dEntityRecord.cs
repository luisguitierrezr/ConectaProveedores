using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] ApprovalProcessType (s7iMPG_5+k2Au6mO0pKA9A)
///  <code>EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord</code> that represent
/// s <code>ApprovalProcessType</code> <p>Description: Approval Process Type</p>
/// </summary>
// Name: ApprovalProcessType
public partial struct EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord : ITypedRecord<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*PiS7v3tDBUiXFqGbqaRA1A");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*KA1jFKEbaU2Xni2ho4rtpA");
internal static readonly GlobalObjectKey IdLabel_ES = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*dc7eCdBoNUWPMhbVqF8eaQ");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+bKS+n5POUCQ_mPtyXMM_Q");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*DzsiyVyI2EKKTAOvoXoK7w");

private int _ssId;
public int ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
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

private string _ssLabel_ES;
public string ssLabel_ES{
  get{
      return _ssLabel_ES;
  }
  set{
      if((_ssLabel_ES!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssLabel_ES = value;
      }
  }
}

private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssIs_Active!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIs_Active = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0;
_ssLabel = "";
_ssLabel_ES = "";
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
ssId = r.ReadInteger(index++, "ApprovalProcessType.Id", 0);
ssLabel = r.ReadText(index++, "ApprovalProcessType.Label", "");
ssLabel_ES = r.ReadText(index++, "ApprovalProcessType.Label_ES", "");
ssOrder = r.ReadInteger(index++, "ApprovalProcessType.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "ApprovalProcessType.Is_Active", false);
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord r) {
this = r;
}


public static bool operator == (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord a, EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssLabel_ES != b.ssLabel_ES) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
return true;
}

public static bool operator != (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord a, EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord)) return false;
return (this == (EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssLabel_ES.GetHashCode()
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


public EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord Duplicate() {
EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssLabel_ES = this._ssLabel_ES;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "label_es") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label_ES")) variable.Value = ssLabel_ES; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "is_active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLabel_ES)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLabel_ES)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdLabel_ES) {
return ssLabel_ES;
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
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdLabel_ES.Key.AsGuid) {
return ssLabel_ES;
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
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (int) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssLabel_ES = (string) other.AttributeGet(IdLabel_ES);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLabel_ES);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLabel_ES);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIs_Active);
}
} // EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord

/// <summary>
/// RecordList type <code>ApprovalProcessTypeList</code> that represents a record list of
///  <code>ApprovalProcessType</code>
/// </summary>
public partial class RL_9a9a1046e13719e3e94e37254f764a1f : GenericRecordList<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord>, IEnumerable, IEnumerator {

protected override EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord GetElementDefaultValue() {
return new EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord();
}

public T[] ToArray<T>(Func<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9a9a1046e13719e3e94e37254f764a1f recordList, Func<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9a9a1046e13719e3e94e37254f764a1f(EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord[] array) {
  RL_9a9a1046e13719e3e94e37254f764a1f result = new RL_9a9a1046e13719e3e94e37254f764a1f();
result.InnerFromArray(array);
    return result;
}

public static RL_9a9a1046e13719e3e94e37254f764a1f ToList<T>(T[] array, Func <T, EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> converter) {
  RL_9a9a1046e13719e3e94e37254f764a1f result = new RL_9a9a1046e13719e3e94e37254f764a1f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9a9a1046e13719e3e94e37254f764a1f FromRestList<T>(RestList<T> restList, Func <T, EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> converter) {
  RL_9a9a1046e13719e3e94e37254f764a1f result = new RL_9a9a1046e13719e3e94e37254f764a1f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9a9a1046e13719e3e94e37254f764a1f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_51146e8018c571ce25065b00ce0d3a4dEntityRecord> NewList() {
return new RL_9a9a1046e13719e3e94e37254f764a1f();
}


} // RL_9a9a1046e13719e3e94e37254f764a1f
}
